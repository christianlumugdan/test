Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient.SqlDataAdapter


Public Class Staff_makePasscode
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim reader As SqlDataReader
    Dim affector As Integer
    Dim samp As String = 0
    Dim code As String
    Dim code1 As String
    Dim code2 As String
    Dim code3 As String
    Dim code4 As String

    Private Sub Staff_makePasscode_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TopMost = True
    End Sub

    Private Sub Passcode_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Opacity = 0.9
        BunifuMaterialTextbox1.Focus()
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

            comm = New SqlCommand("Select * from Staffs where Username='" & Staff_addStaff.BunifuMetroTextbox4.Text & "'", conn)
            reader = comm.ExecuteReader
            If reader.Read = True Then
                code = reader(15).ToString()
            Else
                MessageBox.Show("No record(s) found")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            BunifuMaterialTextbox1.Text = ""
            BunifuMaterialTextbox1.isPassword = True
            samp = 1
        Else
            samp = 0
        End If
        If Len(BunifuMaterialTextbox1.Text) = 1 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        End If

    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged
        If samp = 1 Then
            BunifuMaterialTextbox1.Text = ""
        ElseIf samp = 0 Then
            BunifuMaterialTextbox2.Focus()
            BunifuMaterialTextbox2.isPassword = True
            code1 = BunifuMaterialTextbox1.Text
        End If

    End Sub

    Private Sub BunifuMaterialTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox3.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            BunifuMaterialTextbox2.Text = ""
            BunifuMaterialTextbox2.Focus()
        Else

        End If
        If Len(BunifuMaterialTextbox3.Text) = 1 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub BunifuMaterialTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox3.OnValueChanged
        BunifuMaterialTextbox4.Focus()
        BunifuMaterialTextbox4.isPassword = True
        code3 = BunifuMaterialTextbox3.Text
    End Sub

    Private Sub BunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            BunifuMaterialTextbox1.Text = ""
            BunifuMaterialTextbox1.Focus()

        End If
        If Len(BunifuMaterialTextbox2.Text) = 1 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged
        BunifuMaterialTextbox3.Focus()
        BunifuMaterialTextbox3.isPassword = True
        code2 = BunifuMaterialTextbox2.Text
    End Sub

    Private Sub BunifuMaterialTextbox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox4.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            BunifuMaterialTextbox3.Text = ""
            BunifuMaterialTextbox3.Focus()

        End If
        If Len(BunifuMaterialTextbox4.Text) = 1 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub BunifuMaterialTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox4.OnValueChanged

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click

    End Sub

    Private Sub BunifuImageButton1_MouseDown(sender As Object, e As MouseEventArgs) Handles BunifuImageButton1.MouseDown
        BunifuMaterialTextbox1.isPassword = False
        BunifuMaterialTextbox2.isPassword = False
        BunifuMaterialTextbox3.isPassword = False
        BunifuMaterialTextbox4.isPassword = False
    End Sub

    Private Sub BunifuImageButton1_MouseUp(sender As Object, e As MouseEventArgs) Handles BunifuImageButton1.MouseUp
        BunifuMaterialTextbox1.isPassword = True
        BunifuMaterialTextbox2.isPassword = True
        BunifuMaterialTextbox3.isPassword = True
        BunifuMaterialTextbox4.isPassword = True
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        code4 = BunifuMaterialTextbox4.Text
        If BunifuMaterialTextbox1.Text = "" Or BunifuMaterialTextbox2.Text = "" Or BunifuMaterialTextbox3.Text = "" Or BunifuMaterialTextbox4.Text = "" Then
            MessageBox.Show("Input all lines")

        Else
            code = code1 + code2 + code3 + code4
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Update Staffs set Passcode='" & code & "' where Username='" & Staff_addStaff.BunifuMetroTextbox4.Text & "'", conn)
            affector = comm.ExecuteNonQuery
            MessageBox.Show("Record has been saved.")
            Staff_addStaff.Close()
            Adminfrm.Show()
            Adminfrm.Enabled = True
            Me.Close()
        End If
    End Sub
End Class