Imports System.Data.SqlClient

Public Class LoadTapRFID
    Public rfid As String
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim reader As SqlDataReader
    Private Sub LoadTapRFID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        conn.ConnectionString = constr
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Adminfrm.Enabled = True
        Adminfrm.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
       
        If Len(TextBox1.Text) = 10 Then
            conn.Open()
            comm = New SqlCommand("Select * From Customers Where RFID='" & TextBox1.Text & "'", conn)
            reader = comm.ExecuteReader
            If reader.Read = True Then
                rfid = TextBox1.Text
                BunifuCustomLabel3.Visible = False
                Admin_LoadRFID.Show()
                Me.Close()
            Else
                BunifuCustomLabel3.Visible = True
                TextBox1.Text = ""
                TextBox1.Focus()
            End If
            conn.Close()

        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class