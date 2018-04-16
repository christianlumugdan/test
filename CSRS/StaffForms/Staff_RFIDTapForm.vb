Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Public Class Staff_RFIDTapForm
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim reader As SqlDataReader
    Dim affector As Integer
    Dim bool As Boolean = False
    Dim cname As String
    Private Sub RFIDTapForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.9
        TextBox1.Focus()
        conn.ConnectionString = constr
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Len(TextBox1.Text) = 10 Then
            bool = False
            conn.Open()
            comm = New SqlCommand("Select * From Customers Where RFID='" & TextBox1.Text & "'", conn)
            reader = comm.ExecuteReader
            While reader.Read
                bool = True
            End While
            conn.Close()
            If bool = True Then
                BunifuCustomLabel1.Text = "This RFID is already used"
                BunifuCustomLabel1.ForeColor = Color.Red
                TextBox1.Text = ""
                TextBox1.Focus()

            Else
                cname = Staff_AddCustomer.BunifuMetroTextbox1.Text + " " + Staff_AddCustomer.BunifuMetroTextbox7.Text + ". " + Staff_AddCustomer.BunifuMetroTextbox2.Text
                conn.Open()
                comm = New SqlCommand("Insert into Customers(RFID, Firstname, Lastname, MiddleInitial, Contact, Email, IDNumber , UserType, Loads) values ('" & TextBox1.Text & "','" & Staff_AddCustomer.BunifuMetroTextbox1.Text & "','" & Staff_AddCustomer.BunifuMetroTextbox2.Text & "','" & Staff_AddCustomer.BunifuMetroTextbox7.Text & "','" & Staff_AddCustomer.BunifuMetroTextbox3.Text & "','" & Staff_AddCustomer.BunifuMetroTextbox4.Text & "','" & Staff_AddCustomer.BunifuMetroTextbox6.Text & "','" & Staff_AddCustomer.BunifuDropdown1.selectedIndex & "','" & Staff_AddCustomer.BunifuMetroTextbox5.Text & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                conn.Open()
                comm = New SqlCommand("Insert into SalesReport(Date, Name, TransactionDetails, Operatedby, Amount) values ('" & Date.Now.Date & "','" & cname & "','Add Customer','" & aname & "','" & Staff_AddCustomer.BunifuMetroTextbox5.Text & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                'Staff_AddCustomer.BunifuMetroTextbox1.Text = "Firstname"
                'Staff_AddCustomer.BunifuMetroTextbox2.Text = "Lastname"
                'Staff_AddCustomer.BunifuMetroTextbox3.Text = "Contact Number"
                'Staff_AddCustomer.BunifuMetroTextbox4.Text = "Email Address (Optional)"
                'Staff_AddCustomer.BunifuMetroTextbox5.Text = "0"
                'Staff_AddCustomer.BunifuMetroTextbox7.Text = "M.I"
                'Staff_AddCustomer.BunifuMetroTextbox1.BorderColorIdle = Color.FromArgb(0, 102, 204)
                'Staff_AddCustomer.BunifuMetroTextbox2.BorderColorIdle = Color.FromArgb(0, 102, 204)
                'Staff_AddCustomer.BunifuMetroTextbox3.BorderColorIdle = Color.FromArgb(0, 102, 204)
                'Staff_AddCustomer.BunifuMetroTextbox4.BorderColorIdle = Color.FromArgb(0, 102, 204)
                'Staff_AddCustomer.BunifuMetroTextbox5.BorderColorIdle = Color.FromArgb(0, 102, 204)
                'Staff_AddCustomer.BunifuMetroTextbox5.BorderColorIdle = Color.FromArgb(0, 102, 204)
                'Staff_AddCustomer.BunifuMetroTextbox7.BorderColorIdle = Color.FromArgb(0, 102, 204)
                If SerialPort1.IsOpen Then
                    SerialPort1.Close()
                End If
                Try
                    With SerialPort1
                        .PortName = ComName
                        .BaudRate = 9600
                        .Parity = Parity.None
                        .DataBits = 8
                        .StopBits = StopBits.One
                        .Handshake = Handshake.RequestToSend
                        .DtrEnable = True
                        .RtsEnable = True
                        .NewLine = vbCrLf
                    End With
                    SerialPort1.Open()
                Catch ex As Exception
                End Try
                If SerialPort1.IsOpen Then
                    SerialPort1.WriteLine("AT+CMGF=1" & vbCr)
                    System.Threading.Thread.Sleep(200)
                    SerialPort1.WriteLine("AT+CMGS=" & Chr(34) & Staff_AddCustomer.BunifuMetroTextbox3.Text & Chr(34) & vbCr)
                    System.Threading.Thread.Sleep(200)
                    SerialPort1.WriteLine("Welcome to Movieworld " + Staff_AddCustomer.BunifuMetroTextbox1.Text + "! Thank you for choosing Robinsons. Your current load is: " & Staff_AddCustomer.BunifuMetroTextbox5.Text & vbCrLf & Chr(26))
                    System.Threading.Thread.Sleep(200)
                Else
                    NoBalance.Show()
                End If

                Stafffrm.Enabled = True
                Stafffrm.BringToFront()
                Staff_AddCustomer.Close()
                Me.Close()
                Staff_SuccessfulFrm.Show()

            End If
           

        End If

    End Sub


    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated

    End Sub
End Class