Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter

Public Class Admin_viewAdmin
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim lst As ListViewItem
    Dim samp As Integer = 0

  

    Private Sub Admin_viewAdmin_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
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

    Private Sub header_Click(sender As Object, e As EventArgs) Handles header.Click
        BunifuTextbox1.text = "Search"
        samp = 0
        loadrecords()
        BunifuCustomLabel1.Select()
    End Sub

    Private Sub header_MouseDown(sender As Object, e As MouseEventArgs) Handles header.MouseDown
        BunifuTextbox1.text = "Search"
        samp = 0
        loadrecords()
        BunifuCustomLabel1.Select()
    End Sub

    Private Sub header_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As ComponentModel.CancelEventArgs)
        If Me.ListView1.SelectedItems.Count = 0 Then
            e.Cancel = True

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

    Private Sub BunifuTextbox1_Enter(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub BunifuTextbox1_Leave(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub BunifuTextbox1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub BunifuTextbox1_Enter1(sender As Object, e As EventArgs) Handles BunifuTextbox1.Enter
        If BunifuTextbox1.text = "Search" Then
            BunifuTextbox1.text = ""
            samp = 1
        End If
    End Sub

    Private Sub BunifuTextbox1_Leave1(sender As Object, e As EventArgs) Handles BunifuTextbox1.Leave
        BunifuTextbox1.text = "Search"
        samp = 0

        loadrecords()
        BunifuCustomLabel1.Select()
    End Sub


   
    Private Sub BunifuTextbox1_OnTextChange_1(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange
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
    '  Private Sub ListView1_ClientSizeChanged(ByVal sender As Object, ByVal e As EventArgs) _
    'Handles ListView1.ClientSizeChanged
    '      If ListView1.Columns.Count > 0 Then
    '          ListView1.Columns(0).Width = ListView1.ClientSize.Width
    '      End If
    '  End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
   
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

    End Sub
End Class