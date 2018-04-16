Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter

Public Class AdminChangepw
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim reader As SqlDataReader
    Dim pass As String
    Dim affector As Integer
    Public confirm As Boolean = False
    Dim dg As Boolean = False
    Private Sub Admin_Forgotpw_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.TopMost = True

        Try
            sqlconstr.ConnectionString = constr
            sqlconstr.Open()
            If sqlconstr.State = ConnectionState.Closed Then
                MessageBox.Show("Database Not Connected")
                End
            Else

            End If
            conn = New SqlConnection(constr)
            conn.Open()

            comm = New SqlCommand("Select * from Admins where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "'", conn)
            reader = comm.ExecuteReader
            If reader.Read = True Then
                pass = reader(8).ToString()
            Else

                MessageBox.Show("No record(s) found")
                BunifuCustomLabel1.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuMaterialTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.Enter
        If BunifuMaterialTextbox2.Text = "Type your new password" Then
            BunifuMaterialTextbox2.Text = ""
            BunifuMaterialTextbox2.isPassword = True
        End If
       
        If BunifuMaterialTextbox3.Text = "" Then
            BunifuMaterialTextbox3.Text = "Retype your new password"
            BunifuMaterialTextbox3.isPassword = False
            BunifuMaterialTextbox3.LineIdleColor = Color.Red
        End If
    End Sub

    Private Sub BunifuMaterialTextbox1_Click(sender As Object, e As EventArgs)
        
        If BunifuMaterialTextbox2.Text = "" Then
            BunifuMaterialTextbox2.isPassword = False
            BunifuMaterialTextbox2.Text = "Type your new password"
            BunifuMaterialTextbox2.LineIdleColor = Color.Red
        End If
        If BunifuMaterialTextbox3.Text = "" Then
            BunifuMaterialTextbox3.Text = "Retype your new password"
            BunifuMaterialTextbox3.isPassword = False
            BunifuMaterialTextbox3.LineIdleColor = Color.Red
        End If
    End Sub


    Private Sub BunifuMaterialTextbox1_Enter(sender As Object, e As EventArgs)
      
        If BunifuMaterialTextbox2.Text = "" Then
            BunifuMaterialTextbox2.isPassword = False
            BunifuMaterialTextbox2.Text = "Type your new password"
            BunifuMaterialTextbox2.LineIdleColor = Color.Red
        End If
        If BunifuMaterialTextbox3.Text = "" Then
            BunifuMaterialTextbox3.Text = "Retype your new password"
            BunifuMaterialTextbox3.isPassword = False
            BunifuMaterialTextbox3.LineIdleColor = Color.Red
        End If
    End Sub

    Private Sub BunifuMaterialTextbox3_Enter(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox3.Enter
        If BunifuMaterialTextbox3.Text = "Retype your new password" Then
            BunifuMaterialTextbox3.Text = ""
            BunifuMaterialTextbox3.isPassword = True
        End If
        If BunifuMaterialTextbox2.Text = "" Then
            BunifuMaterialTextbox2.Text = "Type your new password"
            BunifuMaterialTextbox2.isPassword = False
            BunifuMaterialTextbox2.LineIdleColor = Color.Red
        End If
     
    End Sub

    Private Sub BunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress
        Label1.Visible = Enabled
        If BunifuCircleProgressbar1.Value < 50 Then
            BunifuCircleProgressbar1.ProgressColor = Color.Red
            Label1.Text = "Weak"
        ElseIf BunifuCircleProgressbar1.Value >= 50 And BunifuCircleProgressbar1.Value < 80 Then
            BunifuCircleProgressbar1.ProgressColor = Color.Orange
            Label1.Text = "Good"
            BunifuMaterialTextbox3.Enabled = True
        ElseIf BunifuCircleProgressbar1.Value >= 80 Then
            BunifuCircleProgressbar1.ProgressColor = Color.Lime
            Label1.Text = "Strong"
            BunifuMaterialTextbox3.Enabled = True
        End If
        If Len(BunifuMaterialTextbox2.Text) = 30 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        ElseIf Len(BunifuMaterialTextbox2.Text) < 14 Then
            BunifuMaterialTextbox2.LineIdleColor = Color.Red
        Else
            BunifuMaterialTextbox2.LineIdleColor = Color.Lime
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Sub strength_password()
        If BunifuMaterialTextbox2.isPassword = Enabled Then
            If Len(BunifuMaterialTextbox2.Text) = 0 Then
                BunifuCircleProgressbar1.Value = 0
                Label1.Visible = False
            ElseIf Len(BunifuMaterialTextbox2.Text) = 1 Then
                BunifuCircleProgressbar1.Value = 4
            ElseIf Len(BunifuMaterialTextbox2.Text) = 2 Then
                BunifuCircleProgressbar1.Value = 8
            ElseIf Len(BunifuMaterialTextbox2.Text) = 3 Then
                BunifuCircleProgressbar1.Value = 12
            ElseIf Len(BunifuMaterialTextbox2.Text) = 4 Then
                BunifuCircleProgressbar1.Value = 16
            ElseIf Len(BunifuMaterialTextbox2.Text) = 5 Then
                BunifuCircleProgressbar1.Value = 20
            ElseIf Len(BunifuMaterialTextbox2.Text) = 6 Then
                BunifuCircleProgressbar1.Value = 24
            ElseIf Len(BunifuMaterialTextbox2.Text) = 7 Then
                BunifuCircleProgressbar1.Value = 28
            ElseIf Len(BunifuMaterialTextbox2.Text) = 8 Then
                BunifuCircleProgressbar1.Value = 32
            ElseIf Len(BunifuMaterialTextbox2.Text) = 9 Then
                BunifuCircleProgressbar1.Value = 36
            ElseIf Len(BunifuMaterialTextbox2.Text) = 10 Then
                BunifuCircleProgressbar1.Value = 40
            ElseIf Len(BunifuMaterialTextbox2.Text) = 11 Then
                BunifuCircleProgressbar1.Value = 44
            ElseIf Len(BunifuMaterialTextbox2.Text) = 12 Then
                BunifuCircleProgressbar1.Value = 48
            ElseIf Len(BunifuMaterialTextbox2.Text) = 13 Then
                BunifuCircleProgressbar1.Value = 49
            ElseIf Len(BunifuMaterialTextbox2.Text) = 14 Then
                BunifuCircleProgressbar1.Value = 50
            ElseIf Len(BunifuMaterialTextbox2.Text) = 15 Then
                BunifuCircleProgressbar1.Value = 53
            ElseIf Len(BunifuMaterialTextbox2.Text) = 16 Then
                BunifuCircleProgressbar1.Value = 56
            ElseIf Len(BunifuMaterialTextbox2.Text) = 17 Then
                BunifuCircleProgressbar1.Value = 59
            ElseIf Len(BunifuMaterialTextbox2.Text) = 18 Then
                BunifuCircleProgressbar1.Value = 62
            ElseIf Len(BunifuMaterialTextbox2.Text) = 19 Then
                BunifuCircleProgressbar1.Value = 65
            ElseIf Len(BunifuMaterialTextbox2.Text) = 20 Then
                BunifuCircleProgressbar1.Value = 68
            ElseIf Len(BunifuMaterialTextbox2.Text) = 21 Then
                BunifuCircleProgressbar1.Value = 71
            ElseIf Len(BunifuMaterialTextbox2.Text) = 22 Then
                BunifuCircleProgressbar1.Value = 74
            ElseIf Len(BunifuMaterialTextbox2.Text) = 23 Then
                BunifuCircleProgressbar1.Value = 77
            ElseIf Len(BunifuMaterialTextbox2.Text) = 24 Then
                BunifuCircleProgressbar1.Value = 80
            ElseIf Len(BunifuMaterialTextbox2.Text) = 25 Then
                BunifuCircleProgressbar1.Value = 83
            ElseIf Len(BunifuMaterialTextbox2.Text) = 26 Then
                BunifuCircleProgressbar1.Value = 86
            ElseIf Len(BunifuMaterialTextbox2.Text) = 27 Then
                BunifuCircleProgressbar1.Value = 89
            ElseIf Len(BunifuMaterialTextbox2.Text) = 28 Then
                BunifuCircleProgressbar1.Value = 92
            ElseIf Len(BunifuMaterialTextbox2.Text) = 29 Then
                BunifuCircleProgressbar1.Value = 95
            ElseIf Len(BunifuMaterialTextbox2.Text) = 30 Then
                BunifuCircleProgressbar1.Value = 100
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        strength_password()

    End Sub

   

    Private Sub BunifuMaterialTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox3.KeyPress
        If Len(BunifuMaterialTextbox3.Text) = 30 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Else
            BunifuMaterialTextbox3.LineIdleColor = Color.Lime
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        BunifuCustomLabel1.Select()
       
        If BunifuMaterialTextbox2.LineIdleColor = Color.FromArgb(0, 102, 204) Then
            BunifuMaterialTextbox2.LineIdleColor = Color.Red
        End If
        If BunifuMaterialTextbox3.LineIdleColor = Color.FromArgb(0, 102, 204) Then
            BunifuMaterialTextbox3.LineIdleColor = Color.Red
        End If
        If BunifuMaterialTextbox3.Text = "" Then
            BunifuMaterialTextbox3.Text = "Retype your new password"
            BunifuMaterialTextbox3.LineIdleColor = Color.Red
            BunifuMaterialTextbox3.isPassword = False
            Label4.Visible = False
            BunifuMaterialTextbox3.isPassword = False
        End If
        If BunifuMaterialTextbox2.Text = "" Then
            BunifuMaterialTextbox2.Text = "Type your new password"
            BunifuMaterialTextbox2.isPassword = False
            BunifuMaterialTextbox2.LineIdleColor = Color.Red
            Label3.Visible = False
            BunifuMaterialTextbox2.isPassword = False
        End If
      
        If BunifuMaterialTextbox2.Text <> "Type your new password" And BunifuMaterialTextbox3.Text <> "Retype your new password" Then
            If BunifuMaterialTextbox2.Text = "" Or BunifuMaterialTextbox3.Text = "" Then
                BunifuMaterialTextbox2.Text = "Type your new password"
                BunifuMaterialTextbox3.Text = "Retype your new password"
                BunifuMaterialTextbox2.isPassword = False
                BunifuMaterialTextbox3.isPassword = False
            Else
                If BunifuMaterialTextbox2.Text <> BunifuMaterialTextbox3.Text Then
                    BunifuMaterialTextbox2.LineIdleColor = Color.Red
                    BunifuMaterialTextbox3.LineIdleColor = Color.Red
                    Label4.Visible = True
                    'BunifuMaterialTextbox2.Text = "Type your new password"
                    'BunifuMaterialTextbox2.isPassword = False
                    'BunifuMaterialTextbox3.Text = "Retype your new password"
                    'BunifuMaterialTextbox3.isPassword = False
                Else
                    Label4.Visible = False
                    BunifuMaterialTextbox2.LineIdleColor = Color.Lime
                    BunifuMaterialTextbox3.LineIdleColor = Color.Lime
                End If
            End If

        Else
            Label4.Visible = False
        End If

       

        If BunifuMaterialTextbox2.Text = LCase$(BunifuMaterialTextbox2.Text) And BunifuMaterialTextbox2.Text <> "Type your new password" Then
            Label3.Visible = True
            Label3.Text = "Password must contain at least 1 capital character"
            BunifuMaterialTextbox2.LineIdleColor = Color.Red
        ElseIf Not BunifuMaterialTextbox2.Text = LCase$(BunifuMaterialTextbox2.Text) And BunifuMaterialTextbox2.Text <> "Type your new password" Then
            BunifuMaterialTextbox2.LineIdleColor = Color.Lime
            Label3.Visible = False
        End If
        Dim s As String = BunifuMaterialTextbox2.Text
        If Not s.Contains("1") AndAlso Not s.Contains("0") AndAlso Not s.Contains("2") AndAlso Not _
                       s.Contains("3") AndAlso Not s.Contains("4") AndAlso Not s.Contains("5") AndAlso Not _
                       s.Contains("6") AndAlso Not s.Contains("7") AndAlso Not s.Contains("8") AndAlso Not s.Contains("9") AndAlso BunifuMaterialTextbox2.Text <> "Type your new password" Then
            BunifuMaterialTextbox2.LineIdleColor = Color.Red
            Label3.Visible = True
            Label3.Text = "Password must contain 1 digit"
        ElseIf BunifuMaterialTextbox2.Text <> "Type your new password" And BunifuMaterialTextbox2.Text <> LCase$(BunifuMaterialTextbox2.Text) Then
            Label3.Visible = False
            BunifuMaterialTextbox2.LineIdleColor = Color.Lime
            dg = True
        End If


        If BunifuMaterialTextbox2.Text <> "Type your new password" Then
            If BunifuMaterialTextbox2.Text = "" Then
                BunifuMaterialTextbox2.Text = "Type your new password"
                BunifuMaterialTextbox2.isPassword = False
            Else
                If BunifuCircleProgressbar1.Value < 50 Then
                    BunifuMaterialTextbox2.LineIdleColor = Color.Red
                    Label3.Visible = True
                    Label3.Text = "Weak Password"
               
                ElseIf BunifuMaterialTextbox2.Text <> LCase$(BunifuMaterialTextbox2.Text) And dg = True Then
                    Label3.Visible = False
                    BunifuMaterialTextbox2.LineIdleColor = Color.Lime
                End If
            End If

        End If
       
        If BunifuMaterialTextbox2.LineIdleColor = Color.Red Or BunifuMaterialTextbox3.LineIdleColor = Color.Red Then
          
            If BunifuMaterialTextbox2.LineIdleColor = Color.Red Then
                BunifuMaterialTextbox2.Visible = False
                TextboxTransition.ShowSync(BunifuMaterialTextbox2)
            End If
            If BunifuMaterialTextbox3.LineIdleColor = Color.Red Then
                BunifuMaterialTextbox3.Visible = False
                TextboxTransition.ShowSync(BunifuMaterialTextbox3)
            End If
        Else
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Update Admins set Password='" & BunifuMaterialTextbox2.Text & "' where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "'", conn)
            affector = comm.ExecuteNonQuery
            conn.Close()
            MsgBox("Password successfully changed. ")
            Me.Close()
            Loginfrm.Show()
            Loginfrm.BunifuMaterialTextbox1.Text = "Username"
            Loginfrm.BunifuMaterialTextbox2.isPassword = "False"
            Loginfrm.BunifuMaterialTextbox2.Text = "Password"
        End If

    End Sub


    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs)

    End Sub

   

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        Loginfrm.Show()
        Loginfrm.BunifuMaterialTextbox1.Text = "Username"
        Loginfrm.BunifuMaterialTextbox2.isPassword = "False"
        Loginfrm.BunifuMaterialTextbox2.Text = "Password"
    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
