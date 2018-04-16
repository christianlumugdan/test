Imports System.Data.SqlClient


Public Class Loginfrm
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=RME;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim login_error As String

    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\WTFwav.wav")
    End Sub

    Private Sub Loginfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuCustomLabel1.Select()
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        conn = New SqlConnection(constr)
        comm = New SqlCommand("Select * From Staffs where Username = @Username and Password = @Password", conn)

        comm.Parameters.Add("@Username", SqlDbType.VarChar).Value = BunifuMaterialTextbox1.Text
        comm.Parameters.Add("@Password", SqlDbType.VarChar).Value = BunifuMaterialTextbox2.Text

        Dim adapter As New SqlDataAdapter(comm)

        Dim table As New DataTable

        adapter.Fill(table)

        conn.Close()


        If login_error < 5 Then
            If BunifuMaterialTextbox1.Text = "Username" And BunifuMaterialTextbox2.Text = "Password" Then
                PlayBackgroundSoundFile()
                MessageBox.Show("Input all fields")
            ElseIf table.Rows.Count() <= 0 Then

                PlayBackgroundSoundFile()
                MessageBox.Show("Invalid credentials.")
                BunifuMaterialTextbox1.Text = "Username"
                BunifuMaterialTextbox2.isPassword = False
                BunifuMaterialTextbox2.Text = "Password"
                login_error += 1
            Else
                Adminfrm.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Intruders not allowed!")
            My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\Alarm.wav", AudioPlayMode.WaitToComplete)
            Me.Close()
        End If

    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If BunifuMaterialTextbox1.Text <> "Username" Then
            BunifuMaterialTextbox1.Text = "Username"
        End If
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        If BunifuMaterialTextbox2.Text <> "Password" Then
            BunifuMaterialTextbox2.isPassword = False
            BunifuMaterialTextbox2.Text = "Password"
        End If
    End Sub

    Private Sub BunifuMaterialTextbox1_Enter1(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.Enter
        If BunifuMaterialTextbox1.Text = "Username" Then
            BunifuMaterialTextbox1.Text = ""
        Else
            BunifuMaterialTextbox1.Select()

        End If

        If BunifuMaterialTextbox2.Text = "" Then
            BunifuMaterialTextbox2.Text = "Password"
        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_Enter1(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.Enter
        BunifuMaterialTextbox2.isPassword = True
        If BunifuMaterialTextbox2.Text = "Password" Then
            BunifuMaterialTextbox2.Text = ""
        Else
            BunifuMaterialTextbox2.Select()
        End If

        If BunifuMaterialTextbox1.Text = "" Then
            BunifuMaterialTextbox1.Text = "Username"
        End If
    End Sub

    Private Sub BunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress

    End Sub
End Class