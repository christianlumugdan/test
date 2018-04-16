Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient.SqlDataAdapter

Public Class Staff_addStaff
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim comm_un As SqlCommand = New SqlCommand
    Dim reader As SqlDataReader
    Dim affector As Integer
    Dim affector_un As Integer
    Dim temp As String
    Dim samp As String
    Dim samp1 As String
    Dim samp2 As String
    Dim dtStart As DateTime
    Dim sp As TimeSpan
    Dim year As Integer = "18"
    Dim days As Integer = 365
    Dim total As Integer
    Dim reader_un As SqlDataReader
    Public confirm As Boolean = False
    Dim un As Boolean = False
    Dim dig As Boolean = False
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        confirm = True
        Confirmationfrm.Show()
    End Sub

    Private Sub Staff_addStaff_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TopMost = True
    End Sub

    Private Sub Admin_addAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        BunifuImageButton4.Select()
        BunifuDatepicker1.Value = Now
        BunifuCircleProgressbar1.Value = 0
        Try
            sqlconstr.ConnectionString = constr
            sqlconstr.Open()
            If sqlconstr.State = ConnectionState.Closed Then
                MessageBox.Show("Database Not Connected")
                End
            Else

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuMetroTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.Enter
        '1
        If BunifuMetroTextbox1.Text = "Firstname" Then
            BunifuMetroTextbox1.Text = ""
            BunifuMetroTextbox1.BorderColorIdle = Color.Red
        End If
        '2
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Username"
        End If
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = "Password"
            BunifuMetroTextbox5.isPassword = False
        End If
        If BunifuMetroTextbox6.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #1"
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #2"
        End If
        If BunifuMetroTextbox8.Text = "" Then
            BunifuMetroTextbox8.Text = "Email Address"
        End If
        If BunifuMetroTextbox9.Text = "" Then
            BunifuMetroTextbox9.Text = "Address"
        End If

    End Sub

    Private Sub BunifuMetroTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox1.KeyPress
        If Len(BunifuMetroTextbox1.Text) = 40 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        ElseIf Len(BunifuMetroTextbox1.Text) <= 1 Then
            BunifuMetroTextbox1.BorderColorIdle = Color.Red
        Else
            BunifuMetroTextbox1.BorderColorIdle = Color.Lime
        End If

        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.Enter
        If BunifuMetroTextbox2.Text = "Lastname" Then
            BunifuMetroTextbox2.Text = ""
            BunifuMetroTextbox2.BorderColorIdle = Color.Red
        End If

        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Username"
        End If
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = "Password"
            BunifuMetroTextbox5.isPassword = False
        End If
        If BunifuMetroTextbox6.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #1"
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #2"
        End If
        If BunifuMetroTextbox8.Text = "" Then
            BunifuMetroTextbox8.Text = "Email Address"
        End If
        If BunifuMetroTextbox9.Text = "" Then
            BunifuMetroTextbox9.Text = "Address"
        End If
    End Sub

    Private Sub BunifuMetroTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox2.KeyPress
        If Len(BunifuMetroTextbox2.Text) = 30 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        ElseIf Len(BunifuMetroTextbox2.Text) <= 1 Then
            BunifuMetroTextbox2.BorderColorIdle = Color.Red
        Else
            BunifuMetroTextbox2.BorderColorIdle = Color.Lime
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox3_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox3.Enter
        If BunifuMetroTextbox3.Text = "Contact Number" Then
            BunifuMetroTextbox3.Text = ""
            BunifuMetroTextbox3.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Username"
        End If
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = "Password"
            BunifuMetroTextbox5.isPassword = False
        End If
        If BunifuMetroTextbox6.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #1"
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #2"
        End If
        If BunifuMetroTextbox8.Text = "" Then
            BunifuMetroTextbox8.Text = "Email Address"
        End If
        If BunifuMetroTextbox9.Text = "" Then
            BunifuMetroTextbox9.Text = "Address"
        End If
    End Sub

    Private Sub BunifuMetroTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox3.KeyPress
        samp2 = 1
        If Len(BunifuMetroTextbox3.Text) = 11 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
            BunifuMetroTextbox3.BorderColorIdle = Color.Lime
        ElseIf Len(BunifuMetroTextbox3.Text) < 11 Then
            BunifuMetroTextbox3.BorderColorIdle = Color.Red
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox4_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.Enter
        If BunifuMetroTextbox4.Text = "Username" Then
            BunifuMetroTextbox4.Text = ""
            BunifuMetroTextbox4.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = "Password"
            BunifuMetroTextbox5.isPassword = False
        End If
        If BunifuMetroTextbox6.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #1"
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #2"
        End If
        If BunifuMetroTextbox8.Text = "" Then
            BunifuMetroTextbox8.Text = "Email Address"
        End If
        If BunifuMetroTextbox9.Text = "" Then
            BunifuMetroTextbox9.Text = "Address"
        End If
    End Sub

    Private Sub BunifuMetroTextbox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox4.KeyPress
        If Len(BunifuMetroTextbox4.Text) = 30 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        ElseIf Len(BunifuMetroTextbox4.Text) <= 10 Then
            BunifuMetroTextbox4.BorderColorIdle = Color.Red
        Else
            BunifuMetroTextbox4.BorderColorIdle = Color.Lime
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890@.,/?"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox5_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox5.Enter
        If BunifuMetroTextbox5.Text = "Password" Then
            BunifuMetroTextbox5.isPassword = True
            BunifuMetroTextbox5.Text = ""
            BunifuMetroTextbox5.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Username"
        End If
        If BunifuMetroTextbox6.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #1"
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #2"
        End If
        If BunifuMetroTextbox8.Text = "" Then
            BunifuMetroTextbox8.Text = "Email Address"
        End If
        If BunifuMetroTextbox9.Text = "" Then
            BunifuMetroTextbox9.Text = "Address"
        End If

    End Sub

    Private Sub BunifuMetroTextbox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox5.KeyPress
        Label1.Visible = Enabled
        If BunifuCircleProgressbar1.Value < 50 Then
            BunifuCircleProgressbar1.ProgressColor = Color.Red
            Label1.Text = "Weak"
        ElseIf BunifuCircleProgressbar1.Value >= 50 And BunifuCircleProgressbar1.Value < 80 Then
            BunifuCircleProgressbar1.ProgressColor = Color.Orange
            Label1.Text = "Good"
        ElseIf BunifuCircleProgressbar1.Value >= 80 Then
            BunifuCircleProgressbar1.ProgressColor = Color.Lime
            Label1.Text = "Strong"
        End If

        If Len(BunifuMetroTextbox5.Text) = 30 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        ElseIf Len(BunifuMetroTextbox5.Text) < 14 Then
            BunifuMetroTextbox5.BorderColorIdle = Color.Red
        Else
            BunifuMetroTextbox5.BorderColorIdle = Color.Lime
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.Leave
        BunifuMetroTextbox1.Text = StrConv(BunifuMetroTextbox1.Text, vbProperCase)
    End Sub

    Private Sub BunifuMetroTextbox2_Leave(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.Leave
        BunifuMetroTextbox2.Text = StrConv(BunifuMetroTextbox2.Text, vbProperCase)
    End Sub

    Private Sub BunifuDatepicker1_Enter(sender As Object, e As EventArgs) Handles BunifuDatepicker1.Enter
        samp = 1
    End Sub

    Private Sub BunifuDatepicker1_onValueChanged(sender As Object, e As EventArgs) Handles BunifuDatepicker1.onValueChanged
        FormatDateTime(Now, DateFormat.ShortDate)
        dtStart = DateTime.Parse(BunifuDatepicker1.Value)
        sp = DateTime.Now - dtStart
        total = year * days

        If samp = 1 Then
            If sp.Days < total Then
                MessageBox.Show("Below 18?")
                BunifuDatepicker1.BackColor = Color.Red
                BunifuDatepicker1.ForeColor = Color.White
            Else
                BunifuDatepicker1.BackColor = Color.Lime
                BunifuDatepicker1.ForeColor = Color.Black
            End If
        End If

    End Sub

    Private Sub BunifuDropdown1_Enter(sender As Object, e As EventArgs) Handles BunifuDropdown1.Enter
        samp1 = 1
    End Sub

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown1.onItemSelected
        If samp1 = 1 Then
            If BunifuDropdown1.selectedIndex = 0 Then
                BunifuDropdown1.NomalColor = Color.Red
            ElseIf BunifuDropdown1.selectedIndex = BunifuDropdown2.selectedIndex Then
                BunifuDropdown1.NomalColor = Color.Red
            Else
                BunifuDropdown1.NomalColor = Color.Lime
            End If
            If BunifuDropdown1.NomalColor = Color.Lime Then
                BunifuDropdown1.ForeColor = Color.Black
            Else
                BunifuDropdown1.ForeColor = Color.White
            End If
        End If

    End Sub

    Private Sub BunifuDropdown2_Enter(sender As Object, e As EventArgs) Handles BunifuDropdown2.Enter
        samp1 = 1
    End Sub

    Private Sub BunifuDropdown2_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown2.onItemSelected
        If samp1 = 1 Then
            If BunifuDropdown2.selectedIndex = 0 Then
                BunifuDropdown2.NomalColor = Color.Red
            ElseIf BunifuDropdown2.selectedIndex = BunifuDropdown1.selectedIndex Then
                BunifuDropdown2.NomalColor = Color.Red
            ElseIf BunifuDropdown1.selectedIndex = BunifuDropdown2.selectedIndex Then
                BunifuDropdown2.NomalColor = Color.Red
            Else
                BunifuDropdown2.NomalColor = Color.Lime
            End If
            If BunifuDropdown2.NomalColor = Color.Lime Then
                BunifuDropdown2.ForeColor = Color.Black
            Else
                BunifuDropdown2.ForeColor = Color.White
            End If
        End If
    End Sub
    Sub strength_password()
        If BunifuMetroTextbox5.isPassword = Enabled Then
            If Len(BunifuMetroTextbox5.Text) = 0 Then
                BunifuCircleProgressbar1.Value = 0
                Label1.Visible = False
            ElseIf Len(BunifuMetroTextbox5.Text) = 1 Then
                BunifuCircleProgressbar1.Value = 4
            ElseIf Len(BunifuMetroTextbox5.Text) = 2 Then
                BunifuCircleProgressbar1.Value = 8
            ElseIf Len(BunifuMetroTextbox5.Text) = 3 Then
                BunifuCircleProgressbar1.Value = 12
            ElseIf Len(BunifuMetroTextbox5.Text) = 4 Then
                BunifuCircleProgressbar1.Value = 16
            ElseIf Len(BunifuMetroTextbox5.Text) = 5 Then
                BunifuCircleProgressbar1.Value = 20
            ElseIf Len(BunifuMetroTextbox5.Text) = 6 Then
                BunifuCircleProgressbar1.Value = 24
            ElseIf Len(BunifuMetroTextbox5.Text) = 7 Then
                BunifuCircleProgressbar1.Value = 28
            ElseIf Len(BunifuMetroTextbox5.Text) = 8 Then
                BunifuCircleProgressbar1.Value = 32
            ElseIf Len(BunifuMetroTextbox5.Text) = 9 Then
                BunifuCircleProgressbar1.Value = 36
            ElseIf Len(BunifuMetroTextbox5.Text) = 10 Then
                BunifuCircleProgressbar1.Value = 40
            ElseIf Len(BunifuMetroTextbox5.Text) = 11 Then
                BunifuCircleProgressbar1.Value = 44
            ElseIf Len(BunifuMetroTextbox5.Text) = 12 Then
                BunifuCircleProgressbar1.Value = 48
            ElseIf Len(BunifuMetroTextbox5.Text) = 13 Then
                BunifuCircleProgressbar1.Value = 49
            ElseIf Len(BunifuMetroTextbox5.Text) = 14 Then
                BunifuCircleProgressbar1.Value = 50
            ElseIf Len(BunifuMetroTextbox5.Text) = 15 Then
                BunifuCircleProgressbar1.Value = 53
            ElseIf Len(BunifuMetroTextbox5.Text) = 16 Then
                BunifuCircleProgressbar1.Value = 56
            ElseIf Len(BunifuMetroTextbox5.Text) = 17 Then
                BunifuCircleProgressbar1.Value = 59
            ElseIf Len(BunifuMetroTextbox5.Text) = 18 Then
                BunifuCircleProgressbar1.Value = 62
            ElseIf Len(BunifuMetroTextbox5.Text) = 19 Then
                BunifuCircleProgressbar1.Value = 65
            ElseIf Len(BunifuMetroTextbox5.Text) = 20 Then
                BunifuCircleProgressbar1.Value = 68
            ElseIf Len(BunifuMetroTextbox5.Text) = 21 Then
                BunifuCircleProgressbar1.Value = 71
            ElseIf Len(BunifuMetroTextbox5.Text) = 22 Then
                BunifuCircleProgressbar1.Value = 74
            ElseIf Len(BunifuMetroTextbox5.Text) = 23 Then
                BunifuCircleProgressbar1.Value = 77
            ElseIf Len(BunifuMetroTextbox5.Text) = 24 Then
                BunifuCircleProgressbar1.Value = 80
            ElseIf Len(BunifuMetroTextbox5.Text) = 25 Then
                BunifuCircleProgressbar1.Value = 83
            ElseIf Len(BunifuMetroTextbox5.Text) = 26 Then
                BunifuCircleProgressbar1.Value = 86
            ElseIf Len(BunifuMetroTextbox5.Text) = 27 Then
                BunifuCircleProgressbar1.Value = 89
            ElseIf Len(BunifuMetroTextbox5.Text) = 28 Then
                BunifuCircleProgressbar1.Value = 92
            ElseIf Len(BunifuMetroTextbox5.Text) = 29 Then
                BunifuCircleProgressbar1.Value = 95
            ElseIf Len(BunifuMetroTextbox5.Text) = 30 Then
                BunifuCircleProgressbar1.Value = 100
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        strength_password()
        If samp2 = 1 Then

            If Len(BunifuMetroTextbox3.Text) < 11 And BunifuMetroTextbox3.Text <> "Contact Number" Then
                BunifuMetroTextbox3.BorderColorIdle = Color.Red
            Else
                BunifuMetroTextbox3.BorderColorIdle = Color.Lime
            End If

        End If
    End Sub

    Private Sub BunifuMetroTextbox6_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox6.Enter
        If BunifuDropdown1.selectedIndex = 0 Then
            BunifuCustomLabel1.Focus()
            MessageBox.Show("You must select question first.")
        Else
            If BunifuMetroTextbox6.Text = "Security Answer #1" Then
                BunifuMetroTextbox6.Text = ""
                BunifuMetroTextbox6.BorderColorIdle = Color.Red

            End If

        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Username"
        End If
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = "Password"
            BunifuMetroTextbox5.isPassword = False
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #2"
        End If
        If BunifuMetroTextbox8.Text = "" Then
            BunifuMetroTextbox8.Text = "Email Address"
        End If
        If BunifuMetroTextbox9.Text = "" Then
            BunifuMetroTextbox9.Text = "Address"
        End If

    End Sub


    Private Sub BunifuMetroTextbox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox6.KeyPress
        If Len(BunifuMetroTextbox6.Text) = 30 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        ElseIf Len(BunifuMetroTextbox6.Text) <= 1 Then
            BunifuMetroTextbox6.BorderColorIdle = Color.Red
        Else
            BunifuMetroTextbox6.BorderColorIdle = Color.Lime
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox7_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox7.Enter
        If BunifuDropdown2.selectedIndex = 0 Then
            BunifuCustomLabel1.Focus()
            MessageBox.Show("You must select question first.")
        Else
            If BunifuMetroTextbox7.Text = "Security Answer #2" Then
                BunifuMetroTextbox7.Text = ""
                BunifuMetroTextbox7.BorderColorIdle = Color.Red

            End If
        End If

        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Username"
        End If
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = "Password"
            BunifuMetroTextbox5.isPassword = False
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox6.Text = "" Then
            BunifuMetroTextbox6.Text = "Security Answer #1"
        End If
        If BunifuMetroTextbox8.Text = "" Then
            BunifuMetroTextbox8.Text = "Email Address"
        End If
        If BunifuMetroTextbox9.Text = "" Then
            BunifuMetroTextbox9.Text = "Address"
        End If
    End Sub


    Private Sub BunifuMetroTextbox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox7.KeyPress
        If Len(BunifuMetroTextbox7.Text) = 30 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        ElseIf Len(BunifuMetroTextbox7.Text) <= 1 Then
            BunifuMetroTextbox7.BorderColorIdle = Color.Red
        Else
            BunifuMetroTextbox7.BorderColorIdle = Color.Lime
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890 "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox8_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox8.Enter
        If BunifuMetroTextbox8.Text = "Email Address" Then
            BunifuMetroTextbox8.Text = ""
            BunifuMetroTextbox8.BorderColorIdle = Color.Red

        End If
        '2
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Username"
        End If
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = "Password"
            BunifuMetroTextbox5.isPassword = False
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox6.Text = "" Then
            BunifuMetroTextbox6.Text = "Security Answer #1"
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #2"
        End If
        If BunifuMetroTextbox9.Text = "" Then
            BunifuMetroTextbox9.Text = "Address"
        End If
    End Sub

    Private Sub BunifuMetroTextbox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox8.KeyPress
        If Len(BunifuMetroTextbox8.Text) = 30 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        ElseIf Len(BunifuMetroTextbox8.Text) <= 10 Then
            BunifuMetroTextbox8.BorderColorIdle = Color.Red
        Else
            BunifuMetroTextbox8.BorderColorIdle = Color.Lime
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890@.,/?_"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox9_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox9.Enter
        If BunifuMetroTextbox9.Text = "Address" Then
            BunifuMetroTextbox9.Text = ""
            BunifuMetroTextbox9.BorderColorIdle = Color.Red

        End If
        '2
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Username"
        End If
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = "Password"
            BunifuMetroTextbox5.isPassword = False
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox6.Text = "" Then
            BunifuMetroTextbox6.Text = "Security Answer #1"
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "Security Answer #2"
        End If
        If BunifuMetroTextbox8.Text = "" Then
            BunifuMetroTextbox8.Text = "Email Address"
        End If
    End Sub

    Private Sub BunifuMetroTextbox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox9.KeyPress
        If Len(BunifuMetroTextbox9.Text) = 100 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        ElseIf Len(BunifuMetroTextbox9.Text) <= 1 Then
            BunifuMetroTextbox9.BorderColorIdle = Color.Red
        Else
            BunifuMetroTextbox9.BorderColorIdle = Color.Lime
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890@.,/?#()_+ "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuImageButton6_MouseDown(sender As Object, e As MouseEventArgs) Handles BunifuImageButton6.MouseDown
        BunifuMetroTextbox5.isPassword = False
    End Sub

    Private Sub BunifuImageButton6_MouseUp(sender As Object, e As MouseEventArgs) Handles BunifuImageButton6.MouseUp
        If BunifuMetroTextbox5.Text <> "Password" Then
            BunifuMetroTextbox5.isPassword = True
        End If
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        BunifuMetroTextbox1.Text = StrConv(BunifuMetroTextbox1.Text, vbProperCase)
        BunifuMetroTextbox2.Text = StrConv(BunifuMetroTextbox2.Text, vbProperCase)
        Label1.Select()
        Dim s As String = BunifuMetroTextbox5.Text
        Dim pattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If BunifuDropdown1.selectedIndex = BunifuDropdown2.selectedIndex Then
            If samp1 = 1 Then
                Label2.Visible = True
            End If
        ElseIf BunifuDropdown2.selectedIndex = BunifuDropdown1.selectedIndex Then
            If samp1 = 1 Then
                Label2.Visible = True
            End If
        Else
            Label2.Visible = False
        End If
        If BunifuMetroTextbox1.BorderColorIdle = Color.FromArgb(0, 102, 204) Then
            BunifuMetroTextbox1.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox2.BorderColorIdle = Color.FromArgb(0, 102, 204) Then
            BunifuMetroTextbox2.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox3.BorderColorIdle = Color.FromArgb(0, 102, 204) Then
            BunifuMetroTextbox3.BorderColorIdle = Color.Red
        ElseIf BunifuMetroTextbox3.Text <> "Contact Number" And Len(BunifuMetroTextbox3.Text) <= 10 Then
            Label5.Visible = True
        Else
            Label5.Visible = False
        End If
        If BunifuMetroTextbox4.BorderColorIdle = Color.FromArgb(0, 102, 204) Then
            BunifuMetroTextbox4.BorderColorIdle = Color.Red
        ElseIf BunifuMetroTextbox4.Text <> "Username" And Len(BunifuMetroTextbox4.Text) <= 10 Then
            Label8.Visible = True
        Else
            Label8.Visible = False
        End If
       
        If BunifuMetroTextbox6.BorderColorIdle = Color.FromArgb(0, 102, 204) Then
            BunifuMetroTextbox6.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox7.BorderColorIdle = Color.FromArgb(0, 102, 204) Then
            BunifuMetroTextbox7.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox8.BorderColorIdle = Color.FromArgb(0, 102, 204) Then
            BunifuMetroTextbox8.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox9.BorderColorIdle = Color.FromArgb(0, 102, 204) Then
            BunifuMetroTextbox9.BorderColorIdle = Color.Red
        End If
        If BunifuDatepicker1.BackColor = Color.FromArgb(0, 102, 204) Then
            BunifuDatepicker1.BackColor = Color.Red
        ElseIf sp.Days < total Then
            If samp = 1 Then
                Label4.Visible = True
            End If
        Else
            Label4.Visible = False
        End If
        If BunifuDropdown1.NomalColor = Color.FromArgb(0, 102, 204) Then
            BunifuDropdown1.NomalColor = Color.Red
        End If
        If BunifuDropdown2.NomalColor = Color.FromArgb(0, 102, 204) Then
            BunifuDropdown2.NomalColor = Color.Red
        End If
        If BunifuMetroTextbox8.Text <> "Email Address" Then
            If Not Regex.IsMatch(BunifuMetroTextbox8.Text, pattern) Then
                BunifuMetroTextbox8.BorderColorIdle = Color.Red
                Label3.Visible = True
            Else
                Label3.Visible = False
                BunifuMetroTextbox8.BorderColorIdle = Color.Lime
            End If
        End If
        If BunifuMetroTextbox5.Text <> "Password" Then
            If BunifuMetroTextbox5.Text = LCase$(BunifuMetroTextbox5.Text) Then
                BunifuMetroTextbox5.BorderColorIdle = Color.Red
                Label13.Visible = True
                Label13.Text = "Password must have at least 1 capital character"
            Else
                Label13.Visible = False
                BunifuMetroTextbox5.BorderColorIdle = Color.Lime
            End If
            If Not s.Contains("1") AndAlso Not s.Contains("0") AndAlso Not s.Contains("2") AndAlso Not _
                        s.Contains("3") AndAlso Not s.Contains("4") AndAlso Not s.Contains("5") AndAlso Not _
                        s.Contains("6") AndAlso Not s.Contains("7") AndAlso Not s.Contains("8") AndAlso Not s.Contains("9") AndAlso Not s.Contains("Password") Or Not s.Contains("") Then
                BunifuMetroTextbox5.BorderColorIdle = Color.Red
                Label13.Visible = True
                Label13.Text = "Password must contain 1 digit"
            ElseIf Not BunifuMetroTextbox5.Text = LCase$(BunifuMetroTextbox5.Text) Then
                Label13.Visible = True
                dig = True
                BunifuMetroTextbox5.BorderColorIdle = Color.Lime
            End If
        End If
        If BunifuMetroTextbox5.BorderColorIdle = Color.FromArgb(0, 102, 204) Then
            BunifuMetroTextbox5.BorderColorIdle = Color.Red
        ElseIf BunifuCircleProgressbar1.Value < 50 And BunifuMetroTextbox5.Text <> "Password " Then
            Label13.Visible = True
            Label13.Text = "Password must not be weak"
            BunifuMetroTextbox5.BorderColorIdle = Color.Red
        ElseIf BunifuCircleProgressbar1.Value >= 50 And Regex.IsMatch(BunifuMetroTextbox8.Text, pattern) And dig = True Then

            Label13.Visible = False
        End If
        If BunifuMetroTextbox4.Text <> "Username" Then
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Select * from Admins where Username='" & BunifuMetroTextbox4.Text & "'", conn)
            reader = comm.ExecuteReader

            If reader.Read = True And BunifuMetroTextbox4.Text <> "Username" Then
                BunifuMetroTextbox4.BorderColorIdle = Color.Red
                Label8.Text = "Username Already Exist"
                Label8.Visible = True
                BunifuCustomLabel1.Select()
            ElseIf reader.Read = False Then
                conn.Close()
                conn.Open()
                comm_un = New SqlCommand("Select * from Staffs where Username='" & BunifuMetroTextbox4.Text & "'", conn)
                reader_un = comm_un.ExecuteReader
                If reader_un.Read = True And BunifuMetroTextbox4.Text <> "Username" Then
                    BunifuMetroTextbox4.BorderColorIdle = Color.Red
                    Label8.Text = "Username Already Exist"
                    Label8.Visible = True
                    BunifuCustomLabel1.Select()
                Else
                    un = True
                    BunifuMetroTextbox4.BorderColorIdle = Color.Lime
                    Label8.Visible = False
                End If
            End If
            If BunifuMetroTextbox1.BorderColorIdle = Color.Red Or BunifuMetroTextbox2.BorderColorIdle = Color.Red Or BunifuMetroTextbox3.BorderColorIdle = Color.Red Or BunifuMetroTextbox4.BorderColorIdle = Color.Red Or BunifuMetroTextbox5.BorderColorIdle = Color.Red Or BunifuMetroTextbox6.BorderColorIdle = Color.Red Or BunifuMetroTextbox7.BorderColorIdle = Color.Red Or BunifuMetroTextbox8.BorderColorIdle = Color.Red Or BunifuMetroTextbox9.BorderColorIdle = Color.Red Or BunifuDatepicker1.BackColor = Color.Red Or BunifuDropdown1.NomalColor = Color.Red Or BunifuDropdown2.NomalColor = Color.Red Then
                'MessageBox.Show("Mind the red box")
            Else
                If un = True Then
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("Insert into Staffs(Firstname, Lastname, Birthday, Contact, Email, Address, Username, Password, SecurityQ1, SecurityQ2, SecurityI1, SecurityI2, SecurityA1, SecurityA2) values ('" & BunifuMetroTextbox1.Text & "','" & BunifuMetroTextbox2.Text & "','" & BunifuDatepicker1.Value & "','" & BunifuMetroTextbox3.Text & "','" & BunifuMetroTextbox8.Text & "','" & BunifuMetroTextbox9.Text & "','" & BunifuMetroTextbox4.Text & "','" & BunifuMetroTextbox5.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuDropdown2.selectedValue & "','" & BunifuDropdown1.selectedIndex & "','" & BunifuDropdown2.selectedIndex & "','" & BunifuMetroTextbox6.Text & "','" & BunifuMetroTextbox7.Text & "')", conn)
                    affector = comm.ExecuteNonQuery
                    Staff_makePasscode.Show()
                End If
            End If
        End If

    End Sub
    Sub login_success()
        BunifuMetroTextbox1.Text = "Firstname"
        BunifuMetroTextbox1.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox2.Text = "Lastname"
        BunifuMetroTextbox2.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox3.Text = "Contact Number"
        BunifuMetroTextbox3.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox4.Text = "Username"
        BunifuMetroTextbox4.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox5.Text = "Password"
        BunifuMetroTextbox5.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox5.isPassword = False
        Label1.Visible = False
        BunifuCircleProgressbar1.Value = 0
        BunifuMetroTextbox6.Text = "Security Answer#1"
        BunifuMetroTextbox6.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox7.Text = "Security Answer#2"
        BunifuMetroTextbox7.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox8.Text = "Email Address"
        BunifuMetroTextbox8.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox9.Text = "Address"
        BunifuMetroTextbox9.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuDatepicker1.BackColor = Color.FromArgb(0, 102, 204)
        BunifuDatepicker1.Value = Now
        BunifuDropdown1.NomalColor = Color.FromArgb(0, 102, 204)
        BunifuDropdown1.selectedIndex = 0
        BunifuDropdown2.NomalColor = Color.FromArgb(0, 102, 204)
        BunifuDropdown2.selectedIndex = 0

    End Sub

    Private Sub BunifuMetroTextbox9_Leave(sender As Object, e As EventArgs) Handles BunifuMetroTextbox9.Leave
        BunifuMetroTextbox9.Text = StrConv(BunifuMetroTextbox9.Text, vbProperCase)
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Adminfrm.Show()
            Adminfrm.Enabled = True
            Me.Close()

        ElseIf result = DialogResult.Cancel Then

        End If
    End Sub

    Private Sub BunifuImageButton7_Click(sender As Object, e As EventArgs) Handles BunifuImageButton7.Click

    End Sub

    Private Sub BunifuImageButton7_MouseEnter(sender As Object, e As EventArgs) Handles BunifuImageButton7.MouseEnter
        PasswordInfo.Show()

    End Sub

    Private Sub BunifuImageButton7_MouseLeave(sender As Object, e As EventArgs) Handles BunifuImageButton7.MouseLeave
        PasswordInfo.Close()
    End Sub
End Class