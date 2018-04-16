Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Public Class RFIDTapForm2
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim reader As SqlDataReader
    Dim affector As Integer
    Dim bool As Boolean = False
    Dim bools As Boolean = False
    Dim cname As String
    Dim loading As String
    Dim ids As String
    Private Sub RFIDTapForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.9
        TextBox1.Focus()
        conn.ConnectionString = constr
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Len(TextBox1.Text) = 10 Then
            conn.Open()
            comm = New SqlCommand("Select * From Customers Where RFID='" & TextBox1.Text & "'", conn)
            reader = comm.ExecuteReader
            If reader.Read = True Then
                bool = True
            Else
                bool = False
            End If
            conn.Close()
            If bool = True Then
                BunifuCustomLabel1.Text = "This RFID is already used"
                BunifuCustomLabel1.ForeColor = Color.Red
                TextBox1.Text = ""
                TextBox1.Focus()
            Else
                conn.Open()
                comm = New SqlCommand("Select * From Customers Where Contact='" & Admin_viewCustomers.id & "'", conn)
                reader = comm.ExecuteReader
                If reader.Read = True Then
                    bools = True
                    cname = reader(2)
                    loading = reader(9).ToString
                    ids = reader(1)
                Else
                    bool = False
                End If
                conn.Close()
            End If
            If bools = True Then
                conn.Open()
                comm = New SqlCommand("Update Tickets set RFID='" & TextBox1.Text & "' Where RFID ='" & ids & "'", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                conn.Open()
                comm = New SqlCommand("Update Customers set RFID='" & TextBox1.Text & "' Where Contact ='" & Admin_viewCustomers.id & "'", conn)
                affector = comm.ExecuteNonQuery
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
                    SerialPort1.WriteLine("AT+CMGS=" & Chr(34) & Admin_viewCustomers.id & Chr(34) & vbCr)
                    System.Threading.Thread.Sleep(200)
                    SerialPort1.WriteLine(cname + "! Your card is already retrieved. Welcome back to MovieWorld. Your load balance is: " + loading & vbCrLf & Chr(26))
                    System.Threading.Thread.Sleep(200)
                    Adminfrm.Enabled = True
                    Adminfrm.BringToFront()
                    Admin_viewCustomers.Close()
                Else
                    NoBalance.Show()
                End If
                Me.Close()
                SuccessfulFrm.Show()
            End If
            'bool = False
            'conn.Open()
            'comm = New SqlCommand("Select * From Customers Where RFID='" & TextBox1.Text & "'", conn)
            'reader = comm.ExecuteReader
            'While reader.Read
            '    bool = True
            'End While
            'conn.Close()
            'If bool = True Then
            '    BunifuCustomLabel1.Text = "This RFID is already used"
            '    BunifuCustomLabel1.ForeColor = Color.Red
            '    TextBox1.Text = ""
            '    TextBox1.Focus()

            'Else
            '    cname = Admin_AddCustomer.BunifuMetroTextbox1.Text + " " + Admin_AddCustomer.BunifuMetroTextbox7.Text + ". " + Admin_AddCustomer.BunifuMetroTextbox2.Text
            '    conn.Open()
            '    comm = New SqlCommand("Insert into Customers(RFID, Firstname, Lastname, MiddleInitial, Contact, Email, IDNumber , UserType, Loads) values ('" & TextBox1.Text & "','" & Admin_AddCustomer.BunifuMetroTextbox1.Text & "','" & Admin_AddCustomer.BunifuMetroTextbox2.Text & "','" & Admin_AddCustomer.BunifuMetroTextbox7.Text & "','" & Admin_AddCustomer.BunifuMetroTextbox3.Text & "','" & Admin_AddCustomer.BunifuMetroTextbox4.Text & "','" & Admin_AddCustomer.BunifuMetroTextbox6.Text & "','" & Admin_AddCustomer.BunifuDropdown1.selectedIndex & "','" & Admin_AddCustomer.BunifuMetroTextbox5.Text & "')", conn)
            '    affector = comm.ExecuteNonQuery
            '    conn.Close()
            '    conn.Open()
            '    comm = New SqlCommand("Insert into SalesReport(Date, Name, TransactionDetails, Operatedby, Amount) values ('" & Date.Now.Date & "','" & cname & "','Add Customer','" & aname & "','" & Admin_AddCustomer.BunifuMetroTextbox5.Text & "')", conn)
            '    affector = comm.ExecuteNonQuery
            '    conn.Close()
            '    'Staff_AddCustomer.BunifuMetroTextbox1.Text = "Firstname"
            '    'Staff_AddCustomer.BunifuMetroTextbox2.Text = "Lastname"
            '    'Staff_AddCustomer.BunifuMetroTextbox3.Text = "Contact Number"
            '    'Staff_AddCustomer.BunifuMetroTextbox4.Text = "Email Address (Optional)"
            '    'Staff_AddCustomer.BunifuMetroTextbox5.Text = "0"
            '    'Staff_AddCustomer.BunifuMetroTextbox7.Text = "M.I"
            '    'Staff_AddCustomer.BunifuMetroTextbox1.BorderColorIdle = Color.FromArgb(0, 102, 204)
            '    'Staff_AddCustomer.BunifuMetroTextbox2.BorderColorIdle = Color.FromArgb(0, 102, 204)
            '    'Staff_AddCustomer.BunifuMetroTextbox3.BorderColorIdle = Color.FromArgb(0, 102, 204)
            '    'Staff_AddCustomer.BunifuMetroTextbox4.BorderColorIdle = Color.FromArgb(0, 102, 204)
            '    'Staff_AddCustomer.BunifuMetroTextbox5.BorderColorIdle = Color.FromArgb(0, 102, 204)
            '    'Staff_AddCustomer.BunifuMetroTextbox5.BorderColorIdle = Color.FromArgb(0, 102, 204)
            '    'Staff_AddCustomer.BunifuMetroTextbox7.BorderColorIdle = Color.FromArgb(0, 102, 204)
            '    ' Send SMS 
           

        End If


    End Sub


    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated

    End Sub
End Class