﻿Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter

Public Class Admin_deleteAdmin
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim lst As ListViewItem
    Dim type As String = "regular"
    Dim un As String
    Public admindelete As Boolean = False
    Dim samp As Integer

    Private Sub Admin_deleteAdmin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TopMost = True
    End Sub

    Private Sub Admin_deleteAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            conn.ConnectionString = constr
            conn.Open()
            If conn.State = ConnectionState.Closed Then
                MessageBox.Show("Database Not Connected")
                End
            Else
                loadrecords()
              
            End If

        Catch ex As Exception

        End Try

        
      

    End Sub

    Sub loadrecords()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Select * From Admins", conn)
            reader = comm.ExecuteReader
            ListView1.Items.Clear()
            Do While reader.Read = True
                lst = ListView1.Items.Add(reader(1).ToString)
                lst.SubItems.Add(reader(2).ToString)
                lst.SubItems.Add(Format(reader(3), "MM\/dd\/yyyy"))
                lst.SubItems.Add(reader(4).ToString)
                lst.SubItems.Add(reader(5).ToString)
                lst.SubItems.Add(reader(6).ToString)
                lst.SubItems.Add(reader(16).ToString)
                lst.SubItems.Add(reader(0).ToString)
                lst.SubItems.Add(reader(7).ToString)
            Loop

        Catch ex As Exception

        End Try
        'If headerpanel.Width = 753 Then
        '    If headerpanel.Visible = False Then
        '        PanelAnimator.ShowSync(headerpanel)
        '        headerpanel.Visible = True
        '    End If
        'Else
        '    If headerpanel.Visible = False Then
        '        PanelAnimator.ShowSync(headerpanel)
        '        headerpanel.Visible = True
        '    End If
        'End If
        

    End Sub

  
    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Adminfrm.Show()
        Adminfrm.Enabled = True
        Me.Close()
    End Sub

    Private Sub header_MouseDown(sender As Object, e As MouseEventArgs) Handles header.MouseDown
        BunifuTextbox1.text = "Search"
        samp = 0
        loadrecords()
        BunifuCustomLabel1.Select()
    End Sub

    Private Sub header_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Me.ListView1.SelectedItems.Count = 0 Then
            e.Cancel = True

        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        type = ListView1.FocusedItem.SubItems.Item(6).Text
        un = ListView1.FocusedItem.SubItems.Item(8).Text


        If type = "super" Then
            MsgBox("You can't delete the super admin.")
        ElseIf un = Loginfrm.BunifuMaterialTextbox1.Text Then
            MsgBox("You can't delete your own account.")
        Else
            Admin_passcode.Show()
            admindelete = True
        End If


    End Sub

    Private Sub BunifuTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuTextbox1.Enter
        If BunifuTextbox1.text = "Search" Then
            BunifuTextbox1.text = ""
            samp = 1
        End If
    End Sub

    Private Sub BunifuTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuTextbox1.Leave
        BunifuTextbox1.text = "Search"
        samp = 0
        loadrecords()
        BunifuCustomLabel1.Select()
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange
        If samp = 1 Then
            Try
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("SELECT * FROM Admins Where Firstname like '%" & BunifuTextbox1.text & "%' OR Lastname like '%" & BunifuTextbox1.text & "%' OR Birthday like '%" & BunifuTextbox1.text & "%' OR Contact like '%" & BunifuTextbox1.text & "%' OR Email like '%" & BunifuTextbox1.text & "%' OR Address like '%" & BunifuTextbox1.text & "%'", conn)
                reader = comm.ExecuteReader
                ListView1.Items.Clear()
                Do While reader.Read = True
                    lst = ListView1.Items.Add(reader(1).ToString)
                    lst.SubItems.Add(reader(2).ToString)
                    lst.SubItems.Add(Format(reader(3), "MM\/dd\/yyyy"))
                    lst.SubItems.Add(reader(4).ToString)
                    lst.SubItems.Add(reader(5).ToString)
                    lst.SubItems.Add(reader(6).ToString)
                    lst.SubItems.Add(reader(16).ToString)
                    lst.SubItems.Add(reader(0).ToString)
                    lst.SubItems.Add(reader(7).ToString)
                Loop

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        BunifuTextbox1.text = "Search"
        samp = 0
        loadrecords()
        BunifuCustomLabel1.Select()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click

    End Sub
End Class