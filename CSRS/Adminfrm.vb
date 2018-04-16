Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter

Public Class Adminfrm
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=RME;Integrated Security=True"
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim reader As SqlDataReader
    Dim user As String
    Private Sub Adminfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BunifuCustomLabel1.Select()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Select * from Staffs where Username='" & Loginfrm.BunifuMaterialTextbox1.Text & "'", conn)
            reader = comm.ExecuteReader
            If reader.Read = True Then
                BunifuMaterialTextbox1.Text = reader(1).ToString

            Else

                MessageBox.Show("No record(s) found")


            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        AdminPanel.Visible = False
        StaffPanel.Visible = False
        CustomersPanel.Visible = False
        MoviesPanel.Visible = False
        SeatsPanel.Visible = False
        ReportsPanel.Visible = False
        SettingsPanel.Visible = False
        If SidePanel.Width = 50 Then
            SubPanel.Location = New Point(219, 160)
            SidePanel.Visible = False
            SidePanel.Width = 219
            PanelAnimator.ShowSync(SidePanel)
            LogoAnimator.ShowSync(logo)

        Else
            SubPanel.Location = New Point(49, 159)
            LogoAnimator.ShowSync(logo)
            SidePanel.Visible = False
            SidePanel.Width = 50
            PanelAnimator.ShowSync(SidePanel)

        End If
    End Sub

    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click
        Me.Close()
        Loginfrm.Show()
        Loginfrm.BunifuMaterialTextbox1.Text = "Username"
        Loginfrm.BunifuMaterialTextbox2.isPassword = "False"
        Loginfrm.BunifuMaterialTextbox2.Text = "Password"
    End Sub

    Private Sub BunifuImageButton4_Click(sender As Object, e As EventArgs) Handles BunifuImageButton4.Click
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

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
            If AdminPanel.Visible = False Then
                StaffPanel.Visible = False
                CustomersPanel.Visible = False
                MoviesPanel.Visible = False
                SeatsPanel.Visible = False
                ReportsPanel.Visible = False
                SettingsPanel.Visible = False
                PanelAnimator.ShowSync(AdminPanel)
                AdminPanel.Visible = True

            Else
                PanelAnimator.ShowSync(AdminPanel)
                AdminPanel.Visible = False

            End If
       

    End Sub


    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        If StaffPanel.Visible = False Then
            AdminPanel.Visible = False
            CustomersPanel.Visible = False
            MoviesPanel.Visible = False
            SeatsPanel.Visible = False
            ReportsPanel.Visible = False
            SettingsPanel.Visible = False
            PanelAnimator.ShowSync(StaffPanel)

            StaffPanel.Visible = True

        Else
            PanelAnimator.ShowSync(StaffPanel)
            StaffPanel.Visible = False

        End If

    End Sub

    Private Sub BunifuFlatButton3_Click_1(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        If CustomersPanel.Visible = False Then
            AdminPanel.Visible = False
            StaffPanel.Visible = False
            MoviesPanel.Visible = False
            SeatsPanel.Visible = False
            ReportsPanel.Visible = False
            SettingsPanel.Visible = False
            PanelAnimator.ShowSync(CustomersPanel)
            CustomersPanel.Visible = True
        Else
            PanelAnimator.ShowSync(CustomersPanel)
            CustomersPanel.Visible = False
        End If
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        If MoviesPanel.Visible = False Then
            AdminPanel.Visible = False
            StaffPanel.Visible = False
            CustomersPanel.Visible = False
            SeatsPanel.Visible = False
            ReportsPanel.Visible = False
            SettingsPanel.Visible = False
            PanelAnimator.ShowSync(MoviesPanel)
            MoviesPanel.Visible = True
        Else
            PanelAnimator.ShowSync(MoviesPanel)
            MoviesPanel.Visible = False
        End If
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        If SeatsPanel.Visible = False Then
            AdminPanel.Visible = False
            StaffPanel.Visible = False
            CustomersPanel.Visible = False
            MoviesPanel.Visible = False
            ReportsPanel.Visible = False
            SettingsPanel.Visible = False
            PanelAnimator.ShowSync(SeatsPanel)
            SeatsPanel.Visible = True
        Else
            PanelAnimator.ShowSync(SeatsPanel)
            SeatsPanel.Visible = False
        End If
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        If ReportsPanel.Visible = False Then
            AdminPanel.Visible = False
            StaffPanel.Visible = False
            CustomersPanel.Visible = False
            MoviesPanel.Visible = False
            SeatsPanel.Visible = False
            SettingsPanel.Visible = False
            PanelAnimator.ShowSync(ReportsPanel)
            ReportsPanel.Visible = True
        Else
            PanelAnimator.ShowSync(ReportsPanel)
            ReportsPanel.Visible = False
        End If
    End Sub

    Private Sub BunifuFlatButton7_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton7.Click
        If SettingsPanel.Visible = False Then
            AdminPanel.Visible = False
            StaffPanel.Visible = False
            CustomersPanel.Visible = False
            MoviesPanel.Visible = False
            SeatsPanel.Visible = False
            ReportsPanel.Visible = False
            PanelAnimator.ShowSync(SettingsPanel)
            SettingsPanel.Visible = True
        Else
            PanelAnimator.ShowSync(SettingsPanel)
            SettingsPanel.Visible = False
        End If
    End Sub


    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click

    End Sub
End Class