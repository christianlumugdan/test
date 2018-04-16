Imports System.Data.SqlClient
Public Class Admin_settings
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim reader As SqlDataReader
    Dim saves As String
    Private Sub Admin_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = constr
        conn.Open()
        comm = New SqlCommand("Select * From Admins Where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "'", conn)
        reader = comm.ExecuteReader
        While reader.Read
            BunifuMetroTextbox1.Text = reader("PasscodeTime") / 60
        End While
        conn.Close()
        BunifuiOSSwitch1.Value = 0
    End Sub


    Private Sub BunifuiOSSwitch1_OnValueChange(sender As Object, e As EventArgs) Handles BunifuiOSSwitch1.OnValueChange
        If BunifuiOSSwitch1.Value = True Then
            BunifuMetroTextbox1.Enabled = True
        Else
            If BunifuMetroTextbox1.Text <= 0 Then
                BunifuiOSSwitch1.Value = True
            Else
                BunifuMetroTextbox1.Enabled = False
                saves = BunifuMetroTextbox1.Text * 60
                conn.Open()
                comm = New SqlCommand("Update Admins set PasscodeTime='" & saves & "' where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "'", conn)
                comm.ExecuteNonQuery()
                conn.Close()
                timerlimit = BunifuMetroTextbox1.Text
            End If
           
        End If
    End Sub

    Private Sub BunifuCustomLabel4_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.Click

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Adminfrm.Enabled = True
        Adminfrm.Show()
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class