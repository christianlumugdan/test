Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient.SqlDataAdapter

Public Class Admin_editAdmin
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
    Dim old_un As String
    Public admin_editadmin As Boolean = False
    Dim id As Integer
    Public confirm As Boolean = False
    Dim reader_un As SqlDataReader
    Dim un As Boolean = False
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Enabled = False
        confirm = True
        Confirmationfrm.Show()

    End Sub

    Private Sub Admin_editAdmin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TopMost = True
        old_un = BunifuMetroTextbox4.Text
    End Sub

    Private Sub Admin_addAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load

        BunifuDatepicker1.Value = Now
        Timer1.Enabled = True
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
                id = reader(0).ToString()
                BunifuMetroTextbox1.Text = reader(1).ToString()
                BunifuMetroTextbox2.Text = reader(2).ToString()
                BunifuDatepicker1.Value = reader(3).ToString()
                BunifuMetroTextbox3.Text = reader(4).ToString()
                BunifuMetroTextbox8.Text = reader(5).ToString()
                BunifuMetroTextbox9.Text = reader(6).ToString()
                BunifuMetroTextbox4.Text = reader(7).ToString()
                BunifuDropdown1.selectedIndex = reader(11).ToString()
                BunifuDropdown2.selectedIndex = reader(12).ToString()
                BunifuMetroTextbox6.Text = reader(13).ToString()
                BunifuMetroTextbox7.Text = reader(14).ToString()
            Else

                MessageBox.Show("No record(s) found")

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
            BunifuMetroTextbox1.BorderColorIdle = Color.FromArgb(0, 102, 204)
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
            BunifuMetroTextbox2.BorderColorIdle = Color.FromArgb(0, 102, 204)
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
            BunifuMetroTextbox3.BorderColorIdle = Color.FromArgb(0, 102, 204)
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
            BunifuMetroTextbox4.BorderColorIdle = Color.FromArgb(0, 102, 204)
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz1234567890@.,/?"
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
                BunifuMetroTextbox6.Focus()
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
                BunifuMetroTextbox7.Focus()
            End If
            If BunifuDropdown2.NomalColor = Color.Lime Then
                BunifuDropdown2.ForeColor = Color.Black
            Else
                BunifuDropdown2.ForeColor = Color.White
            End If
        End If
    End Sub
    

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
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



    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs)

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
        ElseIf BunifuMetroTextbox4.Text <> "Username" And Len(BunifuMetroTextbox4.Text) <= 20 Then
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

        If BunifuMetroTextbox1.BorderColorIdle = Color.Red Or BunifuMetroTextbox2.BorderColorIdle = Color.Red Or BunifuMetroTextbox3.BorderColorIdle = Color.Red Or BunifuMetroTextbox4.BorderColorIdle = Color.Red Or BunifuMetroTextbox6.BorderColorIdle = Color.Red Or BunifuMetroTextbox7.BorderColorIdle = Color.Red Or BunifuMetroTextbox8.BorderColorIdle = Color.Red Or BunifuMetroTextbox9.BorderColorIdle = Color.Red Or BunifuDatepicker1.BackColor = Color.Red Or BunifuDropdown1.NomalColor = Color.Red Or BunifuDropdown2.NomalColor = Color.Red Then
            MessageBox.Show("Mind the red box")

        End If
    End Sub
    

    Private Sub BunifuMetroTextbox9_Leave(sender As Object, e As EventArgs) Handles BunifuMetroTextbox9.Leave
        BunifuMetroTextbox9.Text = StrConv(BunifuMetroTextbox9.Text, vbProperCase)
    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs)
        Dim result As Integer = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            Adminfrm.Show()
            Adminfrm.Enabled = True
            Me.Close()

        ElseIf result = DialogResult.Cancel Then

        End If
    End Sub
    Sub enable_edit()
        BunifuMetroTextbox1.Enabled = True
        BunifuMetroTextbox2.Enabled = True
        BunifuMetroTextbox3.Enabled = True
        BunifuMetroTextbox4.Enabled = True
        BunifuMetroTextbox6.Enabled = True
        BunifuMetroTextbox7.Enabled = True
        BunifuMetroTextbox8.Enabled = True
        BunifuMetroTextbox9.Enabled = True
        BunifuDropdown1.Enabled = True
        BunifuDropdown2.Enabled = True
        BunifuDatepicker1.Enabled = True
    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Admin_passcode.Show()
        admin_editadmin = True
        Me.Enabled = False
        BunifuFlatButton1.Visible = False
        enable_edit()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        BunifuMetroTextbox1.Text = StrConv(BunifuMetroTextbox1.Text, vbProperCase)
        BunifuMetroTextbox2.Text = StrConv(BunifuMetroTextbox2.Text, vbProperCase)
        BunifuMetroTextbox9.Text = StrConv(BunifuMetroTextbox9.Text, vbProperCase)
        BunifuCustomLabel1.Focus()
        Dim pattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        BunifuCustomLabel1.Focus()
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
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.BorderColorIdle = Color.Red
        ElseIf BunifuMetroTextbox3.Text <> "Contact Number" And Len(BunifuMetroTextbox3.Text) <= 10 Then
            Label5.Visible = True
            BunifuMetroTextbox3.BorderColorIdle = Color.Red
        Else
            Label5.Visible = False
            BunifuMetroTextbox3.BorderColorIdle = Color.FromArgb(0, 102, 204)
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.BorderColorIdle = Color.Red
        ElseIf BunifuMetroTextbox4.Text <> "Username" And Len(BunifuMetroTextbox4.Text) <= 10 Then
            Label8.Visible = True
            BunifuMetroTextbox4.BorderColorIdle = Color.Red
        Else
            Label8.Visible = False
            BunifuMetroTextbox4.BorderColorIdle = Color.FromArgb(0, 102, 204)
        End If
        If BunifuMetroTextbox6.Text = "" Then
            BunifuMetroTextbox6.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox8.Text = "" Then
            BunifuMetroTextbox8.BorderColorIdle = Color.Red
        End If
        If BunifuMetroTextbox9.Text = "" Then
            BunifuMetroTextbox9.BorderColorIdle = Color.Red
        End If
        If sp.Days < total Then
            If samp = 1 Then
                Label4.Visible = True
            End If
        Else
            Label4.Visible = False
        End If
        If BunifuDropdown1.selectedIndex = 0 Then
            BunifuDropdown1.NomalColor = Color.Red
        End If
        If BunifuDropdown2.selectedIndex = 0 Then
            BunifuDropdown2.NomalColor = Color.Red
        End If
        If Not Regex.IsMatch(BunifuMetroTextbox8.Text, pattern) Then
            BunifuMetroTextbox8.BorderColorIdle = Color.Red
            Label3.Visible = True
        Else
            Label3.Visible = False
            BunifuMetroTextbox8.BorderColorIdle = Color.FromArgb(0, 102, 204)
        End If

        If old_un <> BunifuMetroTextbox4.Text Then


            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Select * from Admins where Username='" & BunifuMetroTextbox4.Text & "'", conn)
            reader = comm.ExecuteReader

            If reader.Read = True Then
                BunifuMetroTextbox4.BorderColorIdle = Color.Red
                Label8.Text = "Username Already Exist"
                Label8.Visible = True
                BunifuCustomLabel1.Select()
            ElseIf reader.Read = False Then
                conn.Close()
                conn.Open()
                comm_un = New SqlCommand("Select * from Staffs where Username='" & BunifuMetroTextbox4.Text & "'", conn)
                reader_un = comm_un.ExecuteReader
                If reader_un.Read = True Then
                    BunifuMetroTextbox4.BorderColorIdle = Color.Red
                    Label8.Text = "Username Already Exist"
                    Label8.Visible = True
                    BunifuCustomLabel1.Select()
                Else
                    un = True
                    BunifuMetroTextbox4.BorderColorIdle = Color.FromArgb(0, 102, 204)
                    Label8.Visible = False
                End If
            End If
        End If
        If BunifuMetroTextbox1.BorderColorIdle = Color.Red Or BunifuMetroTextbox2.BorderColorIdle = Color.Red Or BunifuMetroTextbox3.BorderColorIdle = Color.Red Or BunifuMetroTextbox4.BorderColorIdle = Color.Red Or BunifuMetroTextbox6.BorderColorIdle = Color.Red Or BunifuMetroTextbox7.BorderColorIdle = Color.Red Or BunifuMetroTextbox8.BorderColorIdle = Color.Red Or BunifuMetroTextbox9.BorderColorIdle = Color.Red Or BunifuDatepicker1.BackColor = Color.Red Or BunifuDropdown1.NomalColor = Color.Red Or BunifuDropdown2.NomalColor = Color.Red Then
            'MessageBox.Show("Mind the red box")
        Else
            If un = True Then
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("Update Admins set Firstname='" & BunifuMetroTextbox1.Text & "', Lastname='" & BunifuMetroTextbox2.Text & "', Birthday='" & BunifuDatepicker1.Value & "',  Contact='" & BunifuMetroTextbox3.Text & "',  Email='" & BunifuMetroTextbox8.Text & "',  Address='" & BunifuMetroTextbox9.Text & "',  Username='" & BunifuMetroTextbox4.Text & "',  SecurityQ1='" & BunifuDropdown1.selectedValue & "',  SecurityQ2='" & BunifuDropdown2.selectedValue & "',  SecurityI1='" & BunifuDropdown1.selectedIndex & "',  SecurityI2='" & BunifuDropdown2.selectedIndex & "',  SecurityA1='" & BunifuMetroTextbox6.Text & "',  SecurityA2='" & BunifuMetroTextbox7.Text & "' where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "'", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                BunifuCustomLabel1.Select()
                MessageBox.Show("Record has been update.")
                Loginfrm.BunifuMaterialTextbox1.Text = BunifuMetroTextbox4.Text
                old_un = BunifuMetroTextbox4.Text
                disable_tb()
                BunifuMetroTextbox3.BorderColorIdle = Color.FromArgb(0, 102, 204)
            Else
                BunifuCustomLabel1.Select()
                MessageBox.Show("Record has been update.")
                Loginfrm.BunifuMaterialTextbox1.Text = BunifuMetroTextbox4.Text
                disable_tb()
                BunifuMetroTextbox3.BorderColorIdle = Color.FromArgb(0, 102, 204)
            End If
        End If


    End Sub

    Sub disable_tb()
        BunifuMetroTextbox1.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox2.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox3.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox4.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox6.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox7.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox8.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuMetroTextbox9.BorderColorIdle = Color.FromArgb(0, 102, 204)
        BunifuDatepicker1.BackColor = Color.FromArgb(0, 102, 204)
        BunifuDropdown1.NomalColor = Color.FromArgb(0, 102, 204)
        BunifuDropdown2.NomalColor = Color.FromArgb(0, 102, 204)
        Label2.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label8.Visible = False
        BunifuMetroTextbox1.Enabled = False
        BunifuMetroTextbox2.Enabled = False
        BunifuMetroTextbox3.Enabled = False
        BunifuMetroTextbox4.Enabled = False
        BunifuMetroTextbox6.Enabled = False
        BunifuMetroTextbox7.Enabled = False
        BunifuMetroTextbox8.Enabled = False
        BunifuMetroTextbox9.Enabled = False
        BunifuDropdown1.Enabled = False
        BunifuDropdown2.Enabled = False
        BunifuDatepicker1.Enabled = False
        BunifuFlatButton1.Visible = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class