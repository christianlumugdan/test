Imports System.Data.SqlClient

Public Class ForgotPass
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim reader As SqlDataReader
    Dim ans1 As String
    Dim ans2 As String
    Private Sub ForgotPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = constr
        If type = "admin" Then
            conn.Open()
            comm = New SqlCommand("Select * From Admins Where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "'", conn)
            reader = comm.ExecuteReader
            While reader.Read
                Label1.Text = "1. " + reader("SecurityQ1")
                Label2.Text = "2. " + reader("SecurityQ2")
            End While
            conn.Close()
        Else
            conn.Open()
            comm = New SqlCommand("Select * From Staffs Where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "'", conn)
            reader = comm.ExecuteReader
            While reader.Read
                Label1.Text = "1. " + reader("SecurityQ1")
                Label2.Text = "2. " + reader("SecurityQ2")
            End While
            conn.Close()
        End If
        BunifuMetroTextbox1.Focus()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        Loginfrm.Show()
        Loginfrm.BunifuMaterialTextbox1.Text = "Username"
        Loginfrm.BunifuMaterialTextbox2.isPassword = "False"
        Loginfrm.BunifuMaterialTextbox2.Text = "Password"
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Label1.Select()
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.BorderColorIdle = Color.Red
        
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.BorderColorIdle = Color.Red
    
        End If
        If type = "admin" Then
            If BunifuMetroTextbox2.Text <> "" And BunifuMetroTextbox1.Text <> "" Then
                conn.Open()
                comm = New SqlCommand("Select * From Admins Where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "' and SecurityA1='" & BunifuMetroTextbox1.Text & "' and SecurityA2='" & BunifuMetroTextbox2.Text & "'", conn)
                reader = comm.ExecuteReader
                If reader.Read = True Then
                    Me.Hide()
                    AdminChangepw.Show()
                Else
                    MsgBox("Invalid credential")
                    Label1.Select()
                    BunifuMetroTextbox1.Text = ""
                    BunifuMetroTextbox2.Text = ""
                    BunifuMetroTextbox1.BorderColorIdle = Color.Red
                    BunifuMetroTextbox2.BorderColorIdle = Color.Red
                End If
                conn.Close()
            End If
        Else
            If BunifuMetroTextbox2.Text <> "" And BunifuMetroTextbox1.Text <> "" Then
                conn.Open()
                comm = New SqlCommand("Select * From Staffs Where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "' and SecurityA1='" & BunifuMetroTextbox1.Text & "' and SecurityA2='" & BunifuMetroTextbox2.Text & "'", conn)
                reader = comm.ExecuteReader
                If reader.Read = True Then
                    Me.Hide()
                    StaffChangepw.Show()
                Else
                    MsgBox("Invalid credential")
                    Label1.Select()
                    BunifuMetroTextbox1.Text = ""
                    BunifuMetroTextbox2.Text = ""
                    BunifuMetroTextbox1.BorderColorIdle = Color.Red
                    BunifuMetroTextbox2.BorderColorIdle = Color.Red
                End If
                conn.Close()
            End If
        End If

    

    End Sub
End Class