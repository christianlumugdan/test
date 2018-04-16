Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports System.Runtime.InteropServices

Public Class Stafffrm
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim reader As SqlDataReader
    Dim affector As Integer
    Dim user As String
    Dim thisDate As Date = #6/10/2011#
    Dim Hrs As Integer
    Dim Min As Integer
    Dim Sec As Integer
    Dim admin As String
    Dim admintimer As Integer
    Private it As New IdleTime
    Dim idlelimit As Integer = 120
    Public confirmcreate As Boolean = False
    Public adminaddfrm As Boolean = False
    Public adminfrm As Boolean = False
    Public admindeletefrm As Boolean = False
    Public staffaddstaff As Boolean = False
    Public admineditadmin As Boolean = False
    Public confirmcreatestaff As Boolean = False

    Private Sub Stafffrm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TopMost = True
    End Sub


    Private Sub Adminfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Select * from Staffs where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "'", conn)
            reader = comm.ExecuteReader
            If reader.Read = True Then
                admin = reader(1).ToString
                aname = reader(1) + " " + reader(2)
                timerlimit = reader("PasscodeTimer")
            Else
                MessageBox.Show("No record(s) found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BunifuCustomLabel1.Text = "Hi, " + admin + "!"

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        disable_sidepanel()
        If SidePanel.Width = 50 Then
            SidePanel.Visible = False
            SidePanel.Width = 219
            btnMenu.Visible = False
            logo.Visible = False
            PanelAnimator.ShowSync(SidePanel)
            LogoAnimator.ShowSync(btnMenu)
            BrandAnimator.ShowSync(logo)

            'My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\Power_down_swoosh_-_Sound_Effects_Transition_.wav")

        Else
            'My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\Smooth_-_Screen.wav")
            LogoAnimator.ShowSync(logo)
            SidePanel.Visible = False
            SidePanel.Width = 50
            btnMenu.Visible = False
            logo.Visible = False
            PanelAnimator.ShowSync(SidePanel)
            LogoAnimator.ShowSync(btnMenu)
            BrandAnimator.ShowSync(logo)

        End If
    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click
        logout()
        Me.Close()
        Loginfrm.Show()
        Loginfrm.BunifuMaterialTextbox1.Text = "Username"
        Loginfrm.BunifuMaterialTextbox2.isPassword = "False"
        Loginfrm.BunifuMaterialTextbox2.Text = "Password"
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
        logout()
        Me.Close()
        Loginfrm.Show()
        Loginfrm.BunifuMaterialTextbox1.Text = "Username"
        Loginfrm.BunifuMaterialTextbox2.isPassword = "False"
        Loginfrm.BunifuMaterialTextbox2.Text = "Password"
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

   


  

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        If SidePanel.Width = 50 Then
            SubPanel.Location = New Point(49, 158)
            If CustomersPanel.Visible = False Then
                MoviesPanel.Visible = False
                SeatsPanel.Visible = False
                SettingsPanel.Visible = False
                PanelAnimator.ShowSync(CustomersPanel)
                CustomersPanel.Visible = True
            Else
                PanelAnimator.ShowSync(CustomersPanel)
                CustomersPanel.Visible = False
            End If
        Else
            SubPanel.Location = New Point(219, 158)
            If CustomersPanel.Visible = False Then
                MoviesPanel.Visible = False
                SeatsPanel.Visible = False
                SettingsPanel.Visible = False
                PanelAnimator.ShowSync(CustomersPanel)
                CustomersPanel.Visible = True
            Else
                PanelAnimator.ShowSync(CustomersPanel)
                CustomersPanel.Visible = False
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click

        If SidePanel.Width = 50 Then
            SubPanel.Location = New Point(49, 158)
            If MoviesPanel.Visible = False Then
                CustomersPanel.Visible = False
                SeatsPanel.Visible = False
                SettingsPanel.Visible = False
                PanelAnimator.ShowSync(MoviesPanel)
                MoviesPanel.Visible = True
            Else
                PanelAnimator.ShowSync(MoviesPanel)
                MoviesPanel.Visible = False
            End If
        Else
            SubPanel.Location = New Point(219, 158)
            If MoviesPanel.Visible = False Then
                CustomersPanel.Visible = False
                SeatsPanel.Visible = False
                SettingsPanel.Visible = False
                PanelAnimator.ShowSync(MoviesPanel)
                MoviesPanel.Visible = True
            Else
                PanelAnimator.ShowSync(MoviesPanel)
                MoviesPanel.Visible = False
            End If
        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        If SidePanel.Width = 50 Then
            SubPanel.Location = New Point(49, 158)
            If SeatsPanel.Visible = False Then
                CustomersPanel.Visible = False
                MoviesPanel.Visible = False
                SettingsPanel.Visible = False
                PanelAnimator.ShowSync(SeatsPanel)
                SeatsPanel.Visible = True
            Else
                PanelAnimator.ShowSync(SeatsPanel)
                SeatsPanel.Visible = False
            End If
        Else
            SubPanel.Location = New Point(219, 158)
            If SeatsPanel.Visible = False Then
                CustomersPanel.Visible = False
                MoviesPanel.Visible = False
                SettingsPanel.Visible = False
                PanelAnimator.ShowSync(SeatsPanel)
                SeatsPanel.Visible = True
            Else
                PanelAnimator.ShowSync(SeatsPanel)
                SeatsPanel.Visible = False
            End If
        End If
    End Sub



    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click

        If SidePanel.Width = 50 Then
            SubPanel.Location = New Point(49, 158)
            If SettingsPanel.Visible = False Then
                CustomersPanel.Visible = False
                MoviesPanel.Visible = False
                SeatsPanel.Visible = False
                PanelAnimator.ShowSync(SettingsPanel)
                SettingsPanel.Visible = True
            Else
                PanelAnimator.ShowSync(SettingsPanel)
                SettingsPanel.Visible = False
            End If
        Else
            SubPanel.Location = New Point(219, 158)
            If SettingsPanel.Visible = False Then
                CustomersPanel.Visible = False
                MoviesPanel.Visible = False
                SeatsPanel.Visible = False
                PanelAnimator.ShowSync(SettingsPanel)
                SettingsPanel.Visible = True
            Else
                PanelAnimator.ShowSync(SettingsPanel)
                SettingsPanel.Visible = False
            End If
        End If
    End Sub

    Sub disable_sidepanel()
        
        CustomersPanel.Visible = False
        MoviesPanel.Visible = False
        SeatsPanel.Visible = False
        SettingsPanel.Visible = False
    End Sub

    Private Sub header_Click(sender As Object, e As EventArgs) Handles header.Click
        disable_sidepanel()
    End Sub

    Private Sub SidePanel_Click(sender As Object, e As EventArgs) Handles SidePanel.Click
        disable_sidepanel()
    End Sub

    Private Sub main_Click(sender As Object, e As EventArgs) Handles main.Click
        disable_sidepanel()
    End Sub

    Private Sub BunifuFlatButton15_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton15.Click
        Staff_Changepw.Show()
        Staff_Changepw.Enabled = True
        Me.Enabled = False
        Me.Hide()
        disable_sidepanel()
    End Sub
    Private Sub BunifuFlatButton28_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton28.Click
        Staff_AddCustomer.Show()
        Staff_AddCustomer.Enabled = True
        Me.Enabled = False
        Me.Hide()
        disable_sidepanel()
    End Sub
    Private Sub BunifuFlatButton27_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton27.Click
        Staff_LoadTapRFID.Show()
        Staff_LoadTapRFID.Enabled = True
        Me.Enabled = False
        Me.Hide()
        disable_sidepanel()
    End Sub
    Private Sub BunifuFlatButton26_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton26.Click
        Staff_viewCustomers.Show()
        Staff_viewCustomers.Enabled = True
        Me.Enabled = False
        Me.Hide()
        disable_sidepanel()
    End Sub
    Private Sub BunifuFlatButton25_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton25.Click
        Staff_addMovies.Show()
        Staff_addMovies.Enabled = True
        Me.Enabled = False
        Me.Hide()
        disable_sidepanel()
    End Sub
    Private Sub BunifuFlatButton24_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton24.Click
        Staff_EditMovies.Show()
        Staff_EditMovies.Enabled = True
        Me.Enabled = False
        Me.Hide()
        disable_sidepanel()
    End Sub
    Private Sub BunifuFlatButton14_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton14.Click
        Staff_settings.Show()
        Staff_settings.Enabled = True
        Me.Enabled = False
        Me.Hide()
        disable_sidepanel()
    End Sub

    Private Sub BunifuFlatButton16_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton16.Click
        Staff_viewStaff.Show()
        Staff_viewStaff.Enabled = True
        Me.Enabled = False
        Me.Hide()
        disable_sidepanel()
    End Sub
    Private Sub BunifuFlatButton23_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton23.Click
        Staff_viewMovies.Show()
        Staff_viewMovies.Enabled = True
        Me.Enabled = False
        Me.Hide()
        disable_sidepanel()
    End Sub
    Private Sub BunifuFlatButton21_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton21.Click
        Staff_staffLogs.Show()
        Staff_staffLogs.Enabled = True
        Me.Enabled = False
        Me.Hide()
        disable_sidepanel()
    End Sub
    'Private Sub BunifuFlatButton25_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton25.Click
    '    Staff_viewCustomers.Show()
    '    Staff_viewCustomers.Enabled = True
    '    Me.Enabled = False
    '    Me.Hide()
    '    disable_sidepanel()
    'End Sub


    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Hour(Now), "00") & ":" & Format(Minute(Now), "00")
        Label3.Text = Now.Date
        BunifuCircleProgressbar1.Value = Second(Now)

        If Now.DayOfWeek = 0 Then
            Label2.Text = "Sunday"
            Label2.Location = New Point(807, 136)
        ElseIf Now.DayOfWeek = 1 Then
            Label2.Text = "Monday"
        ElseIf Now.DayOfWeek = 2 Then
            Label2.Text = "Tuesday"
            Label2.Location = New Point(803, 136)
        ElseIf Now.DayOfWeek = 3 Then
            Label2.Text = "Wednesday"
            Label2.Location = New Point(790, 136)
        ElseIf Now.DayOfWeek = 4 Then
            Label2.Text = "Thursday"
            Label2.Location = New Point(801, 136)
        ElseIf Now.DayOfWeek = 5 Then
            Label2.Text = "Friday"
            Label2.Location = New Point(809, 136)
        ElseIf Now.DayOfWeek = 6 Then
            Label2.Text = "Saturday"
            Label2.Location = New Point(802, 136)
        End If
        Label5.Text = Second(Now)
        Label4.Text = GetTime(0)
        admintimer += 1



        If it.IdleTime >= timerlimit Then
            If Me.Enabled = True Then
                Me.Enabled = False
                adminfrm = True
                Staff_passcode.Show()
            End If

        End If
    End Sub
    Sub logout()
        conn = New SqlConnection(constr)
        conn.Open()
        comm = New SqlCommand("Update StaffLogs set Duration='" & Label4.Text & "', Logout='" & Now & "' where Login='" & Loginfrm.logintime & "'", conn)
        affector = comm.ExecuteNonQuery
        conn.Close()
    End Sub

    Public Function GetTime(Time As Integer) As String
        Sec = admintimer Mod 60
        Min = ((admintimer - Sec) / 60) Mod 60
        Hrs = ((admintimer - (Sec + (Min * 60))) / 3600) Mod 60
        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    End Function

    Private Sub Adminfrm_MouseWheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel

    End Sub



    Private Sub Adminfrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\Correct_-_Answer.wav")
        VertAnimator.ShowSync(SidePanel)
        SidePanel.Visible = True
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub main_Paint(sender As Object, e As PaintEventArgs) Handles main.Paint

    End Sub
End Class

Public Class IdleTimeStaff

    Private Declare Function GetLastInputInfo Lib "User32.dll" _
      (ByRef lastInput As LASTINPUTINFO) As Boolean

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure LASTINPUTINFO
        Public cbSize As Int32
        Public dwTime As Int32
    End Structure


    Public ReadOnly Property IdleTime() As Integer

        Get

            Dim lastInput As New LASTINPUTINFO

            lastInput.cbSize = Marshal.SizeOf(lastInput)

            If GetLastInputInfo(lastInput) Then

                Return (Environment.TickCount - lastInput.dwTime) / 1000

            End If

        End Get

    End Property

End Class
