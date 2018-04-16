Imports System.Data.SqlClient

Public Class Admin_adminLogs
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim reader As SqlDataReader
    Dim lst As ListViewItem
    Dim enter As Boolean = False

    Private Sub Admin_TimeLogs_Click(sender As Object, e As EventArgs) Handles Me.Click
        loadrecords()
    End Sub
    Private Sub Admin_TimeLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = constr
        loadrecords()
    End Sub
    Sub loadrecords()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Select * From AdminLogs", conn)
            reader = comm.ExecuteReader
            ListView1.Items.Clear()
            Do While reader.Read = True
                lst = ListView1.Items.Add(reader(1).ToString)
                lst.SubItems.Add(Format(reader(2), "MM/dd/yyyy"))
                lst.SubItems.Add(Format(reader(2), "hh:mm tt"))
                If IsDBNull(reader(3)) Then
                    lst.SubItems.Add("N/A")
                    lst.SubItems.Add("N/A")
                Else
                    lst.SubItems.Add(Format(reader(4), "hh:mm tt"))
                    lst.SubItems.Add(reader(3).ToString)
                End If

            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BunifuDatepicker1_Enter(sender As Object, e As EventArgs) Handles BunifuDatepicker1.Enter
        enter = True
    End Sub

    Private Sub BunifuDatepicker1_Leave(sender As Object, e As EventArgs) Handles BunifuDatepicker1.Leave
        loadrecords()
    End Sub

    Private Sub BunifuDatepicker1_onValueChanged(sender As Object, e As EventArgs) Handles BunifuDatepicker1.onValueChanged

        If enter = True Then

            Try
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("SELECT ID, Username, Login, Duration,Logout FROM [CGL.RME].[dbo].[AdminLogs] Where Convert(VARCHAR(10),Login,101) =  Convert(Varchar(10),'" & BunifuDatepicker1.Value.ToString("MM/dd/yyyy") & "',101)", conn)
                reader = comm.ExecuteReader
                ListView1.Items.Clear()
                Do While reader.Read = True
                    lst = ListView1.Items.Add(reader(1).ToString)
                    lst.SubItems.Add(Format(reader(2), "MM/dd/yyyy"))
                    lst.SubItems.Add(Format(reader(2), "hh:mm tt"))
                    If IsDBNull(reader(3)) Then
                        lst.SubItems.Add("N/A")
                        lst.SubItems.Add("N/A")
                    Else
                        lst.SubItems.Add(Format(reader(4), "hh:mm tt"))
                        lst.SubItems.Add(reader(3).ToString)
                    End If

                Loop

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Adminfrm.Enabled = True
        Adminfrm.Show()
        Me.Close()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click

    End Sub
End Class