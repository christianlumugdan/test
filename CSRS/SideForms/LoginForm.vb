Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Public Class Loginfrm
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim login_error As String
    Dim affector As Integer
    Public logintime As String
    Dim comm_un As SqlCommand = New SqlCommand


    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\Windows_10_Error_Sound.wav")
    End Sub

    Private Sub Loginfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Brand.Select()



        Try
            conn.ConnectionString = constr
            conn.Open()
            If conn.State = ConnectionState.Closed Then
                MessageBox.Show("Database Not Connected")
                End
            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        BunifuCustomLabel1.Visible = False


    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        End
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        login()
        BunifuCustomLabel1.Select()
    End Sub


    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If BunifuMaterialTextbox1.Text <> "Username" Then
            BunifuMaterialTextbox1.Text = "Username"
        End If
        If BunifuMaterialTextbox2.Text <> "Password" Then
            BunifuMaterialTextbox2.Text = "Password"
            BunifuMaterialTextbox2.isPassword = False
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

        If BunifuMaterialTextbox2.Text = "Password" Then
            BunifuMaterialTextbox2.isPassword = False
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

    Private Sub BunifuImageButton2_MouseDown(sender As Object, e As MouseEventArgs) Handles BunifuImageButton2.MouseDown
        BunifuMaterialTextbox2.isPassword = False
    End Sub

    Private Sub BunifuImageButton2_MouseUp(sender As Object, e As MouseEventArgs) Handles BunifuImageButton2.MouseUp

        If BunifuMaterialTextbox2.Text <> "Password" Then
            BunifuMaterialTextbox2.isPassword = True
        End If

    End Sub

    Private Sub BunifuMaterialTextbox2_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuMaterialTextbox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
            BunifuMaterialTextbox2.isPassword = False
            BunifuCustomLabel1.Select()
        End If

    End Sub

    Sub login()
        BunifuMaterialTextbox1.Visible = True
        BrandAnimator.ShowSync(BunifuMaterialTextbox1)
        conn = New SqlConnection(constr)
        comm = New SqlCommand("Select * From Admins where Username = @Username and Password = @Password", conn)

        comm.Parameters.Add("@Username", SqlDbType.VarChar).Value = BunifuMaterialTextbox1.Text
        comm.Parameters.Add("@Password", SqlDbType.VarChar).Value = BunifuMaterialTextbox2.Text

        Dim adapter As New SqlDataAdapter(comm)

        Dim table As New DataTable

        adapter.Fill(table)

        conn.Close()

        If login_error < 5 Then
            If BunifuMaterialTextbox1.Text = "Username" And BunifuMaterialTextbox2.Text = "Password" Then
                PlayBackgroundSoundFile()
                InputFields.BunifuCustomLabel1.Text = "Please input all fields"
                InputFields.Show()
            ElseIf table.Rows.Count() >= 1 Then
                conn = New SqlConnection(constr)
                conn.Open()
                logintime = Now
                comm = New SqlCommand("Insert into AdminLogs(Username, Login) values ('" & BunifuMaterialTextbox1.Text & "','" & Now & "')", conn)
                affector = comm.ExecuteNonQuery
                Adminfrm.Show()
                Me.Hide()
            ElseIf table.Rows.Count() <= 0 Then
                conn = New SqlConnection(constr)
                comm_un = New SqlCommand("Select * From Staffs where Username = @Username and Password = @Password", conn)
                comm_un.Parameters.Add("@Username", SqlDbType.VarChar).Value = BunifuMaterialTextbox1.Text
                comm_un.Parameters.Add("@Password", SqlDbType.VarChar).Value = BunifuMaterialTextbox2.Text

                Dim adapters As New SqlDataAdapter(comm_un)

                Dim tables As New DataTable

                adapters.Fill(tables)

                conn.Close()

                If tables.Rows.Count() <= 0 Then
                    PlayBackgroundSoundFile()
                    InvalidCredentials.Show()
                    BunifuMaterialTextbox1.Text = "Username"
                    BunifuMaterialTextbox2.isPassword = False
                    BunifuMaterialTextbox2.Text = "Password"
                    login_error += 1
                Else
                    conn = New SqlConnection(constr)
                    conn.Open()
                    logintime = Now
                    comm = New SqlCommand("Insert into StaffLogs(Username, Login) values ('" & BunifuMaterialTextbox1.Text & "','" & Now & "')", conn)
                    affector = comm.ExecuteNonQuery
                    Stafffrm.Show()
                    Me.Hide()
                End If

            End If
        Else
            MessageBox.Show("Intruders not allowed!")
            My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\Alarm.wav", AudioPlayMode.WaitToComplete)
            Me.Close()
        End If
    End Sub

    Private Sub Loginfrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        BrandAnimator.ShowSync(BunifuCustomLabel1)
        Brand.Select()

    End Sub

    'Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox1.OnValueChanged
    '    My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\typing2.wav")
    'End Sub

    'Private Sub BunifuMaterialTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox2.OnValueChanged
    '    My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\typing2.wav")
    'End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress
        My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\typing2.wav", AudioPlayMode.Background)

    End Sub

    Private Sub BunifuMaterialTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox2.KeyPress
        My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\typing2.wav", AudioPlayMode.Background)

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        BunifuCustomLabel1.Select()
        If BunifuMaterialTextbox1.Text = "" Then
            BunifuMaterialTextbox1.Text = "Username"
        End If
      
            conn = New SqlConnection(constr)
            comm = New SqlCommand("Select * From Admins where Username = @Username", conn)

            comm.Parameters.Add("@Username", SqlDbType.VarChar).Value = BunifuMaterialTextbox1.Text


            Dim adapter As New SqlDataAdapter(comm)

            Dim table As New DataTable

            adapter.Fill(table)

            conn.Close()

            If login_error < 5 Then
                If BunifuMaterialTextbox1.Text = "Username" Then
                    PlayBackgroundSoundFile()
                InputFields.BunifuCustomLabel1.Text = "Please input username"
                InputFields.Show()
            ElseIf table.Rows.Count() >= 1 Then
                type = "admin"
                Me.Hide()
                ForgotPass.Show()
                ElseIf table.Rows.Count() <= 0 Then
                    conn = New SqlConnection(constr)
                comm_un = New SqlCommand("Select * From Staffs where Username = @Username", conn)
                comm_un.Parameters.Add("@Username", SqlDbType.VarChar).Value = BunifuMaterialTextbox1.Text

                    Dim adapters As New SqlDataAdapter(comm_un)

                    Dim tables As New DataTable

                    adapters.Fill(tables)

                    conn.Close()

                    If tables.Rows.Count() <= 0 Then
                        PlayBackgroundSoundFile()
                    InvalidCredentials.Show()
                        BunifuMaterialTextbox1.Text = "Username"
                        login_error += 1
                Else
                    type = "staff"
                    Me.Hide()
                    ForgotPass.Show()
                    End If

                End If
            Else
                MessageBox.Show("Intruders not allowed!")
                My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\Alarm.wav", AudioPlayMode.WaitToComplete)
                Me.Close()
            End If

    End Sub
End Class