Public Class Confirmationfrm
    Dim ok As Boolean
    Dim cancel As Boolean

    Private Sub Confirmationfrm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TopMost = True
    End Sub

    Private Sub Confirmationfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.9
        ok = False
        cancel = False
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles Confirmation.Click
        If Admin_addAdmin.confirm = True Then
            Adminfrm.Enabled = True
            Admin_addAdmin.Enabled = True
            Admin_addAdmin.confirm = False
            Admin_addAdmin.Close()
            Adminfrm.Show()
            Me.Close()
        ElseIf Admin_editAdmin.confirm = True Then
            Adminfrm.Enabled = True
            Admin_editAdmin.Enabled = True
            Admin_editAdmin.confirm = False
            Admin_editAdmin.Close()
            Adminfrm.Show()
            Me.Close()
        ElseIf Staff_addStaff.confirm = True Then
            Adminfrm.Enabled = True
            Staff_addStaff.Enabled = True
            Staff_addStaff.confirm = False
            Staff_addStaff.Close()
            Adminfrm.Show()
            Me.Close()
        ElseIf Admin_Changepw.confirm = True Then
            Adminfrm.Enabled = True
            Admin_Changepw.confirm = False
            Admin_Changepw.Close()
            Adminfrm.Show()
            Me.Close()
        ElseIf Staff_Changepw.confirm = True Then
            Stafffrm.Enabled = True
            Staff_Changepw.confirm = False
            Staff_Changepw.Close()
            Stafffrm.Show()
            Me.Close()
        ElseIf Admin_editStaff.confireditstaff = True Then
            Admin_viewStaff.Enabled = True
            Admin_editStaff.confireditstaff = False
            Admin_editStaff.Close()
            Admin_viewStaff.Show()
            Admin_viewStaff.loadrecords()
            Me.Close()

        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        If Admin_addAdmin.confirm = True Then
            Admin_addAdmin.Enabled = True
            Admin_addAdmin.confirm = False
            Admin_addAdmin.Show()
            Admin_addAdmin.BunifuCircleProgressbar1.Value = 0
            Me.Close()
        ElseIf Admin_editAdmin.confirm = True Then
            Admin_editAdmin.Enabled = True
            Admin_editAdmin.confirm = False
            Admin_editAdmin.Show()
            Me.Close()
        ElseIf Staff_addStaff.confirm = True Then
            Staff_addStaff.Enabled = True
            Staff_addStaff.confirm = False
            Staff_addStaff.Show()
            Me.Close()
        ElseIf Admin_Changepw.confirm = True Then
            Admin_Changepw.Enabled = True
            Admin_Changepw.confirm = False
            Admin_Changepw.Show()
            Me.Close()
        ElseIf Staff_Changepw.confirm = True Then
            Staff_Changepw.Enabled = True
            Staff_Changepw.confirm = False
            Staff_Changepw.Show()
            Me.Close()
        ElseIf Admin_editStaff.confireditstaff = True Then
            Admin_editStaff.Enabled = True
            Admin_editStaff.confireditstaff = False
            Admin_editStaff.Show()
            Me.Close()

        End If
    End Sub
End Class