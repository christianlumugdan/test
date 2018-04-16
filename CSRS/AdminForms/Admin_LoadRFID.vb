

Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Ports
Imports System.Threading

Public Class Admin_LoadRFID
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim reader As SqlDataReader
    Dim affector As Integer
    Dim amount As String = 0
    Dim upper As String
    Dim first As Boolean = False
    Dim second As Boolean = False
    Dim third As Boolean = False
    Dim cname As String
    Dim loads As String
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Adminfrm.Enabled = True
        Adminfrm.Show()
        Me.Close()
    End Sub
    Private Sub BunifuMetroTextbox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox6.KeyPress
        If Len(BunifuMetroTextbox6.Text) = 20 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        Else
            BunifuMetroTextbox6.BorderColorIdle = Color.Lime
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "zxcvbnmasdaafghjklqwertyuiop1324567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub BunifuMetroTextbox3_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox3.Enter
        If BunifuMetroTextbox3.Text = "Contact Number" Then
            BunifuMetroTextbox3.Text = ""
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Email Address (Optional)"
        End If
        If BunifuDropdown1.selectedIndex = 1 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Student ID No."
            End If
        ElseIf BunifuDropdown1.selectedIndex = 2 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Senior Citizen ID No."
            End If
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "M.I"
        End If
    End Sub

    Private Sub BunifuMetroTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox3.KeyPress
        If Len(BunifuMetroTextbox3.Text) = 11 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
            BunifuMetroTextbox3.BorderColorIdle = Color.Lime
        Else
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

    Private Sub BunifuMetroTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox3.OnValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click
        If BunifuMetroTextbox5.Text < 5000 Then
            amount += 100
            loads += 100
            Label3.Text = amount.ToString
            BunifuMetroTextbox5.Text = amount.ToString
        End If

    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = 0
        End If
        If amount < 5000 Then
            amount += 50
            loads += 50
            Label3.Text = amount.ToString
            BunifuMetroTextbox5.Text = amount.ToString
        End If

    End Sub

    Private Sub BunifuImageButton5_Click(sender As Object, e As EventArgs) Handles BunifuImageButton5.Click
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = 0
        End If
        If amount > 0 Then
            amount -= 50
            Label3.Text = amount.ToString
            BunifuMetroTextbox5.Text = amount.ToString
        End If
    End Sub

    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Label3.TextChanged
        If Len(BunifuMetroTextbox5.Text) = 3 Then
            Label3.Location = New Point(557, 329)
        ElseIf Len(BunifuMetroTextbox5.Text) = 4 Then
            Label3.Location = New Point(529, 329)
        Else
            Label3.Location = New Point(602, 329)
        End If

    End Sub

    Private Sub BunifuMetroTextbox5_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox5.Enter
        If BunifuMetroTextbox5.Text = "0" Then
            BunifuMetroTextbox5.Text = ""
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Email Address (Optional)"
        End If
        If BunifuDropdown1.selectedIndex = 1 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Student ID No."
            End If
        ElseIf BunifuDropdown1.selectedIndex = 2 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Senior Citizen ID No."
            End If
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "M.I"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
    End Sub

    Private Sub BunifuMetroTextbox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox5.KeyPress
        If Len(BunifuMetroTextbox5.Text) > 3 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox5_Leave(sender As Object, e As EventArgs) Handles BunifuMetroTextbox5.Leave
        If BunifuMetroTextbox5.Text = "" Then
            BunifuMetroTextbox5.Text = 0
        End If
    End Sub

    Private Sub BunifuMetroTextbox5_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox5.OnValueChanged

        amount = BunifuMetroTextbox5.Text
        Label3.Text = amount.ToString
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        amount += 50
        loads += 50
        Label3.Text = amount.ToString
        BunifuMetroTextbox5.Text = amount.ToString
        Label7.Text = "Total: " + loads.ToString
    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        If BunifuMetroTextbox5.Text < 5000 Then
            amount += 200
            loads += 200
            Label3.Text = amount.ToString
            BunifuMetroTextbox5.Text = amount.ToString
            Label7.Text = "Total: " + loads.ToString
        End If

    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        If BunifuMetroTextbox5.Text < 5000 Then
            amount += 250
            loads += 250
            Label3.Text = amount.ToString
            BunifuMetroTextbox5.Text = amount.ToString
            Label7.Text = "Total: " + loads.ToString
        End If

    End Sub

    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click
        If BunifuMetroTextbox5.Text < 5000 Then
            amount += 300
            loads += 300
            Label3.Text = amount.ToString
            BunifuMetroTextbox5.Text = amount.ToString
            Label7.Text = "Total: " + loads.ToString
        End If

    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        If BunifuMetroTextbox5.Text < 5000 Then
            amount += 500
            loads += 500
            Label3.Text = amount.ToString
            BunifuMetroTextbox5.Text = amount.ToString
            Label7.Text = "Total: " + loads.ToString
        End If

    End Sub

    Private Sub Admin_AddCustomer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Select()
        conn.ConnectionString = constr
        conn.Open()
        comm = New SqlCommand("Select * From Customers Where RFID='" & LoadTapRFID.rfid & "'", conn)
        reader = comm.ExecuteReader
        While reader.Read
            BunifuMetroTextbox1.Text = reader(2)
            BunifuMetroTextbox2.Text = reader(3)
            BunifuMetroTextbox7.Text = reader(4)
            BunifuMetroTextbox3.Text = reader(5)
            BunifuMetroTextbox4.Text = reader(6)
            BunifuMetroTextbox6.Text = reader(7)
            BunifuDropdown1.selectedIndex = reader(8)
            BunifuMetroTextbox5.Text = reader(9)
        End While
        conn.Close()
    End Sub

    Private Sub BunifuDropdown1_onItemSelected(sender As Object, e As EventArgs) Handles BunifuDropdown1.onItemSelected
        'If BunifuDropdown1.selectedIndex = 1 Then
        '    BunifuMetroTextbox6.Visible = True
        '    BunifuMetroTextbox6.Text = "Student ID No."
        'ElseIf BunifuDropdown1.selectedIndex = 2 Then
        '    BunifuMetroTextbox6.Visible = True
        '    BunifuMetroTextbox6.Text = "Senior Citizen ID No."
        'Else
        '    BunifuMetroTextbox6.Visible = False
        'End If
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs)
        BunifuMetroTextbox5.Text = 0
    End Sub

    Private Sub BunifuMetroTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.Enter
        If BunifuMetroTextbox1.Text = "Firstname" Then
            BunifuMetroTextbox1.Text = ""

        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Email Address (Optional)"
        End If
        If BunifuDropdown1.selectedIndex = 1 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Student ID No."
            End If
        ElseIf BunifuDropdown1.selectedIndex = 2 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Senior Citizen ID No."
            End If
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "M.I"
        End If
    End Sub

    Private Sub BunifuMetroTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox1.KeyPress
        If Len(BunifuMetroTextbox1.Text) = 30 Then
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
            Dim allowedChars As String = "zxcvbnmasdaafghjklqwertyuiop"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.Leave
        BunifuMetroTextbox1.Text = StrConv(BunifuMetroTextbox1.Text, vbProperCase)
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.Enter
        If BunifuMetroTextbox2.Text = "Lastname" Then
            BunifuMetroTextbox2.Text = ""
        End If

        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Email Address (Optional)"
        End If
        If BunifuDropdown1.selectedIndex = 1 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Student ID No."
            End If
        ElseIf BunifuDropdown1.selectedIndex = 2 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Senior Citizen ID No."
            End If
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "M.I"
        End If
    End Sub



    Private Sub BunifuMetroTextbox4_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.Enter
        If BunifuMetroTextbox4.Text = "Email Address (Optional)" Then
            BunifuMetroTextbox4.Text = ""
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuDropdown1.selectedIndex = 1 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Student ID No."
            End If
        ElseIf BunifuDropdown1.selectedIndex = 2 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Senior Citizen ID No."
            End If
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "M.I"
        End If
    End Sub

    'Private Sub BunifuMetroTextbox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox4.KeyPress
    '    If Len(BunifuMetroTextbox4.Text) = 30 Then
    '        If Not (Asc(e.KeyChar) = 8) Then
    '            Dim allowedChars As String = ""
    '            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
    '                e.KeyChar = ChrW(0)
    '                e.Handled = True
    '            End If
    '        End If
    '    ElseIf Len(BunifuMetroTextbox4.Text) <= 1 Then
    '        BunifuMetroTextbox4.BorderColorIdle = Color.Red
    '    Else
    '        BunifuMetroTextbox4.BorderColorIdle = Color.Lime
    '    End If
    '    If Not (Asc(e.KeyChar) = 8) Then
    '        Dim allowedChars As String = "zxcvbnmasdaafghjklqwertyuiop1234567890!@#$^&*,./';\][+_=-"
    '        If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
    '            e.KeyChar = ChrW(0)
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox4.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox6_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox6.Enter
        If BunifuMetroTextbox6.Text = "Student ID No." Or BunifuMetroTextbox6.Text = "Senior Citizen ID No." Then
            BunifuMetroTextbox6.Text = ""
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Email Address (Optional)"
        End If
        If BunifuMetroTextbox7.Text = "" Then
            BunifuMetroTextbox7.Text = "M.I"
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
            Dim allowedChars As String = "zxcvbnmasdaafghjklqwertyuiop"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If loads <= 0 Then
            My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\Windows_10_Error_Sound.wav")
            InputLoad.Show()
        Else
            Load_RFIDTapForm.TextBox1.Focus()
            first = False
            second = False
            third = False
            'Label8.Visible = False
            'Label5.Visible = False
            'Label6.Visible = False
            If Len(BunifuMetroTextbox3.Text) <= 10 Then
                BunifuMetroTextbox3.BorderColorIdle = Color.Red
            Else
                BunifuMetroTextbox3.BorderColorIdle = Color.Lime
            End If
            If BunifuMetroTextbox5.Text = "" Then
                BunifuMetroTextbox5.Text = "0"
            End If
            If BunifuMetroTextbox2.Text = "" Then
                BunifuMetroTextbox2.Text = "Lastname"
            End If
            If BunifuMetroTextbox1.Text = "" Then
                BunifuMetroTextbox1.Text = "Firstname"
            End If
            If BunifuMetroTextbox4.Text = "" Then
                BunifuMetroTextbox4.Text = "Email Address (Optional)"
                BunifuMetroTextbox4.BorderColorIdle = Color.FromArgb(0, 102, 204)
            End If
            If BunifuDropdown1.selectedIndex = 1 Then
                If BunifuMetroTextbox6.Text = "" Then
                    BunifuMetroTextbox6.Text = "Student ID No."
                End If
            ElseIf BunifuDropdown1.selectedIndex = 2 Then
                If BunifuMetroTextbox6.Text = "" Then
                    BunifuMetroTextbox6.Text = "Senior Citizen ID No."
                End If
            End If
            If BunifuMetroTextbox7.Text = "" Then
                BunifuMetroTextbox7.Text = "M.I"
            End If
            If BunifuMetroTextbox3.Text = "" Then
                BunifuMetroTextbox3.Text = "Contact Number"
            End If
            Label1.Select()
            Dim pattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
            If BunifuMetroTextbox1.BorderColorIdle = Color.FromArgb(0, 102, 204) Or BunifuMetroTextbox1.Text = "Firstname" Then
                BunifuMetroTextbox1.BorderColorIdle = Color.Red
            End If
            If BunifuMetroTextbox3.BorderColorIdle = Color.FromArgb(0, 102, 204) Or BunifuMetroTextbox3.Text = "Contact Number" Then
                BunifuMetroTextbox3.BorderColorIdle = Color.Red
            End If
            If BunifuMetroTextbox2.BorderColorIdle = Color.FromArgb(0, 102, 204) Or BunifuMetroTextbox2.Text = "Lastname" Then
                BunifuMetroTextbox2.BorderColorIdle = Color.Red
            End If
            If BunifuMetroTextbox7.BorderColorIdle = Color.FromArgb(0, 102, 204) Or BunifuMetroTextbox7.Text = "M.I" Then
                BunifuMetroTextbox7.BorderColorIdle = Color.Red

            End If
            If BunifuDropdown1.selectedIndex = 1 Or BunifuDropdown1.selectedIndex = 2 Then
                If BunifuMetroTextbox6.BorderColorIdle = Color.FromArgb(0, 102, 204) And BunifuMetroTextbox6.Visible = True Or BunifuMetroTextbox6.Text = "Student ID No." Or BunifuMetroTextbox6.Text = "Senior Citizen ID No." Then
                    BunifuMetroTextbox6.BorderColorIdle = Color.Red
                End If
            Else
                BunifuMetroTextbox6.BorderColorIdle = Color.Lime
            End If

            If BunifuMetroTextbox5.Text <= 50 Then
                BunifuMetroTextbox5.BorderColorIdle = Color.Red
            Else
                BunifuMetroTextbox5.BorderColorIdle = Color.Lime
            End If
            If BunifuMetroTextbox4.Text <> "Email Address (Optional)" And BunifuMetroTextbox4.Text <> "" Then
                If Not Regex.IsMatch(BunifuMetroTextbox4.Text, pattern) Then
                    BunifuMetroTextbox4.BorderColorIdle = Color.Red
                Else
                    BunifuMetroTextbox4.BorderColorIdle = Color.Lime
                End If
            End If

            ''''''

            ''''

            If BunifuMetroTextbox1.Text <> "Firstname" And BunifuMetroTextbox2.Text <> "Lastname" And BunifuMetroTextbox7.Text <> "M.I" Then
                'conn.Open()
                'comm = New SqlCommand("Select * From Customers Where Firstname='" & BunifuMetroTextbox1.Text & "' and Lastname='" & BunifuMetroTextbox2.Text & "' and MiddleInitial ='" & BunifuMetroTextbox7.Text & "'", conn)
                'reader = comm.ExecuteReader
                'While reader.Read = True
                '    first = True
                'End While
                'conn.Close()
                'If first = True Then
                '    Label8.Visible = True
                '    BunifuMetroTextbox1.BorderColorIdle = Color.Red
                '    BunifuMetroTextbox2.BorderColorIdle = Color.Red
                '    BunifuMetroTextbox7.BorderColorIdle = Color.Red
                'End If
                If first = False Then
                    Label8.Visible = False
                    BunifuMetroTextbox1.BorderColorIdle = Color.Lime
                    BunifuMetroTextbox2.BorderColorIdle = Color.Lime
                    BunifuMetroTextbox7.BorderColorIdle = Color.Lime
                End If
            End If
            If BunifuMetroTextbox3.Text <> "Contact Number" Then
                'conn.Open()
                'comm = New SqlCommand("Select * From Customers Where Contact='" & BunifuMetroTextbox3.Text & "'", conn)
                'reader = comm.ExecuteReader
                'While reader.Read = True
                '    second = True
                'End While
                'conn.Close()
                'If second = True Then
                '    Label5.Visible = True
                '    BunifuMetroTextbox3.BorderColorIdle = Color.Red
                'End If
                If second = False Then
                    Label5.Visible = False
                    BunifuMetroTextbox3.BorderColorIdle = Color.Lime
                End If

            End If
            If BunifuMetroTextbox6.Text <> "Student ID No." And BunifuMetroTextbox6.Text <> "Senior Citizen ID No." Then
                'conn.Open()
                'comm = New SqlCommand("Select * From Customers Where IDNumber='" & BunifuMetroTextbox6.Text & "'", conn)
                'reader = comm.ExecuteReader
                'While reader.Read = True
                '    third = True
                'End While
                'conn.Close()
                If third = False Then
                    Label6.Visible = False
                    BunifuMetroTextbox6.BorderColorIdle = Color.Lime
                End If

                'If third = True Then
                '    Label6.Visible = True
                '    BunifuMetroTextbox6.BorderColorIdle = Color.Red
                'End If
            End If

            ''''


            If BunifuMetroTextbox1.BorderColorIdle = Color.Red Or BunifuMetroTextbox2.BorderColorIdle = Color.Red Or BunifuMetroTextbox3.BorderColorIdle = Color.Red Or BunifuMetroTextbox5.BorderColorIdle = Color.Red Or BunifuMetroTextbox7.BorderColorIdle = Color.Red Or BunifuMetroTextbox6.BorderColorIdle = Color.Red Or BunifuMetroTextbox4.BorderColorIdle = Color.Red Then

            Else
                cname = BunifuMetroTextbox1.Text + " " + BunifuMetroTextbox7.Text + ". " + BunifuMetroTextbox2.Text
                conn.Open()
                comm = New SqlCommand("Update Customers set Loads='" & BunifuMetroTextbox5.Text & "' where Contact='" & BunifuMetroTextbox3.Text & "'", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                conn.Open()
                comm = New SqlCommand("Insert into SalesReport (Date, Name, TransactionDetails, Operatedby, Amount) values ('" & Date.Now.Date & "','" & cname & "','Load Customer','" & aname & "','" & loads & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                loads = 0
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
                    SerialPort1.WriteLine("AT+CMGS=" & Chr(34) & BunifuMetroTextbox3.Text & Chr(34) & vbCr)
                    System.Threading.Thread.Sleep(200)
                    SerialPort1.WriteLine("Thank you for loading " + BunifuMetroTextbox1.Text + "! Your current load is: " & BunifuMetroTextbox5.Text & vbCrLf & Chr(26))
                    System.Threading.Thread.Sleep(200)
                Else
                    NoBalance.Show()
                End If

                Me.Close()
                SuccessfulFrm.Show()

            End If

        End If
           End Sub

    Private Sub BunifuMetroTextbox7_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox7.Enter
        If BunifuMetroTextbox7.Text = "M.I" Then
            BunifuMetroTextbox7.Text = ""

        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Lastname"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Firstname"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "Contact Number"
        End If
        If BunifuMetroTextbox4.Text = "" Then
            BunifuMetroTextbox4.Text = "Email Address (Optional)"
        End If
        If BunifuDropdown1.selectedIndex = 1 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Student ID No."
            End If
        ElseIf BunifuDropdown1.selectedIndex = 2 Then
            If BunifuMetroTextbox6.Text = "" Then
                BunifuMetroTextbox6.Text = "Senior Citizen ID No."
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox7.KeyPress
        If Len(BunifuMetroTextbox7.Text) = 3 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        End If
        'ElseIf Len(BunifuMetroTextbox7.Text) >= 0 Then
        '    BunifuMetroTextbox7.BorderColorIdle = Color.Lime
        'ElseIf Len(BunifuMetroTextbox7.Text) = -1 Then
        '    BunifuMetroTextbox7.BorderColorIdle = Color.Lime
        If Len(BunifuMetroTextbox7.Text) >= 0 Then

            BunifuMetroTextbox7.BorderColorIdle = Color.Lime
        ElseIf BunifuMetroTextbox7.Text = "" Then

            BunifuMetroTextbox7.BorderColorIdle = Color.Red
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "zxcvbnmasdaafghjklqwertyuiop"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox7_Leave(sender As Object, e As EventArgs) Handles BunifuMetroTextbox7.Leave
        upper = BunifuMetroTextbox7.Text.ToUpper
        BunifuMetroTextbox7.Text = upper
    End Sub

    Private Sub BunifuMetroTextbox7_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox7.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox2_Leave(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.Leave
        BunifuMetroTextbox2.Text = StrConv(BunifuMetroTextbox2.Text, vbProperCase)
    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged

    End Sub



    Private Sub BunifuMetroTextbox6_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox6.OnValueChanged

    End Sub
End Class