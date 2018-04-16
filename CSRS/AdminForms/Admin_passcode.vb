Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient.SqlDataAdapter

Public Class Admin_passcode
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim reader As SqlDataReader
    Dim affector As Integer
    Dim code As String
    Dim code1 As String
    Dim code2 As String
    Dim code3 As String
    Dim code4 As String
    Dim samp As String = 0
    Dim samp1 As String = 0
    Public globalconfirm As Boolean = False

    Private Sub Admin_passcode_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TopMost = True
    End Sub

    Private Sub Passcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.9
        BunifuMaterialTextbox1.Focus()
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
    End Sub

    Private Sub BunifuMaterialTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMaterialTextbox1.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            BunifuMaterialTextbox1.Text = ""
            BunifuMaterialTextbox1.isPassword = True
            samp = 1
        Else
            samp = 0
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
            samp1 = 0
        Else
            samp1 = 1
        End If
    End Sub

    Private Sub BunifuMaterialTextbox4_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox4.OnValueChanged
        code4 = BunifuMaterialTextbox4.Text
        code = code1 + code2 + code3 + code4


            comm = New SqlCommand("Select * From Admins where Username = @Username and Passcode = @Passcode", conn)

            comm.Parameters.Add("@Username", SqlDbType.VarChar).Value = Loginfrm.BunifuMaterialTextbox1.Text
            comm.Parameters.Add("@Passcode", SqlDbType.VarChar).Value = code


            Dim adapter As New SqlDataAdapter(comm)

            Dim table As New DataTable

            adapter.Fill(table)

            conn.Close()
      

        If samp1 = 1 Then
            If table.Rows.Count() <= 0 Then
                My.Computer.Audio.Play("C:\Users\Christian\Desktop\Thesis\CSRS Resources\Windows_10_Error_Sound.wav")
                samp1 = 0
                BunifuMaterialTextbox1.Text = ""
                BunifuMaterialTextbox2.Text = ""
                BunifuMaterialTextbox3.Text = ""
                BunifuMaterialTextbox4.Text = ""
                BunifuMaterialTextbox1.Focus()
                BunifuMaterialTextbox1.isPassword = True

            Else
                If Admin_editStaff.editstaff = True Then
                    Admin_editStaff.Show()
                    Admin_editStaff.editstaff = False
                    Admin_editStaff.Enabled = True
                    Me.Close()
                End If

                If Admin_editAdmin.admin_editadmin = True Then
                    Admin_editAdmin.Show()
                    Admin_editAdmin.admin_editadmin = False
                    Admin_editAdmin.Enabled = True
                    Me.Close()
                End If

                If Adminfrm.adminfrm = True Then
                    Adminfrm.Show()
                    Adminfrm.adminfrm = False
                    Adminfrm.Enabled = True
                    Me.Close()
                End If
                If Adminfrm.confirmcreate = True Then
                    Admin_addAdmin.Show()
                    Adminfrm.confirmcreate = False
                    Admin_addAdmin.Enabled = True
                    Me.Close()
                End If
                If Adminfrm.adminaddfrm = True Then
                    Admin_addAdmin.BunifuCircleProgressbar1.Value = 0
                    Adminfrm.adminaddfrm = False
                    Admin_addAdmin.Enabled = True
                    Me.Close()
                End If
                If Adminfrm.viewadmin = True Then
                    Adminfrm.viewadmin = False
                    Admin_viewAdmin.Enabled = True
                    Admin_viewAdmin.Show()
                    Me.Close()

                End If
                If Adminfrm.deletestaff = True Then
                    Adminfrm.deletestaff = False
                    Admin_deleteStaff.Enabled = True
                    Me.Close()
                    Admin_deleteStaff.Show()
                End If
                If Adminfrm.viewstaff = True Then
                    Admin_viewStaff.Show()
                    Adminfrm.viewstaff = False
                    Me.Close()
                    Admin_viewStaff.Enabled = True

                End If
                If Adminfrm.admineditadmin = True Then
                    Adminfrm.admineditadmin = False
                    Admin_editAdmin.Enabled = True
                    Admin_editAdmin.Show()
                    Me.Close()

                End If
                If Adminfrm.admindeletefrm = True Then
                    Adminfrm.admindeletefrm = False
                    Admin_deleteAdmin.Enabled = True
                    Me.Close()
                End If
                If Adminfrm.staffaddstaff = True Then
                    Adminfrm.staffaddstaff = False
                    Staff_addStaff.BunifuCircleProgressbar1.Value = 0
                    Staff_addStaff.Enabled = True
                    Me.Close()

                End If
                If Adminfrm.confirmcreatestaff = True Then
                    Adminfrm.confirmcreatestaff = False
                    Staff_addStaff.Enabled = True
                    Staff_addStaff.Show()
                    Me.Close()
                End If

                If Admin_deleteAdmin.admindelete = True Then
                    Admin_deleteAdmin.admindelete = False
                    Try
                        conn = New SqlConnection(constr)
                        conn.Open()
                        comm = New SqlCommand("Delete from Admins where ID='" & Admin_deleteAdmin.ListView1.FocusedItem.SubItems.Item(7).Text & "'", conn)
                        affector = comm.ExecuteNonQuery
                        Admin_deleteAdmin.loadrecords()
                        MsgBox("Deleted")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Me.Close()
                End If
                If Admin_deleteStaff.staffdelete = True Then
                    Admin_deleteStaff.staffdelete = False
                    Try
                        conn = New SqlConnection(constr)
                        conn.Open()
                        comm = New SqlCommand("Delete from Staffs where ID='" & Admin_deleteStaff.ListView1.FocusedItem.SubItems.Item(6).Text & "'", conn)
                        affector = comm.ExecuteNonQuery
                        Admin_deleteStaff.loadrecords()
                        MsgBox("Deleted")
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Me.Close()
                End If
               
            End If
        End If
      

    End Sub
End Class