Imports System.Data.SqlClient
Public Class Staff_viewCustomers
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim reader As SqlDataReader
    Dim lst As ListViewItem
    Dim samp As String
    Private Sub Admin_viewCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = constr
        conn.Open()
        comm = New SqlCommand("Select * From Customers", conn)
        reader = comm.ExecuteReader
        ListView1.Items.Clear()
        Do While reader.Read = True
            lst = ListView1.Items.Add(reader(2).ToString + " " + reader(4) + " " + reader(3))
            lst.SubItems.Add(reader(5).ToString)
            If reader(6) = "Email Address (Optional)" Then
                lst.SubItems.Add("None")
            Else
                lst.SubItems.Add(reader(6))
            End If
            If reader(7) = "Student ID No." Or reader(7) = "Senior Citizen ID No." Then
                lst.SubItems.Add("None")
            Else
                lst.SubItems.Add(reader(7))
            End If
            If reader(8).ToString = "0" Then
                lst.SubItems.Add("Regular")
            ElseIf reader(8).ToString = "1" Then
                lst.SubItems.Add("Student")
            Else
                lst.SubItems.Add("Senior Citizen")
            End If
            lst.SubItems.Add("₱ " + reader(9).ToString)
        Loop
        conn.Close()
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
        BunifuCustomLabel1.Select()
    End Sub

    Private Sub BunifuTextbox1_OnTextChange(sender As Object, e As EventArgs) Handles BunifuTextbox1.OnTextChange
        If samp = 1 Then
            conn.Open()
            comm = New SqlCommand("SELECT * FROM Customers Where Firstname like '%" & BunifuTextbox1.text & "%' OR Lastname like '%" & BunifuTextbox1.text & "%' OR MiddleInitial like '%" & BunifuTextbox1.text & "%' OR Contact like '%" & BunifuTextbox1.text & "%' OR Email like '%" & BunifuTextbox1.text & "%' OR Loads like '%" & BunifuTextbox1.text & "%'", conn)
            reader = comm.ExecuteReader
            ListView1.Items.Clear()
            Do While reader.Read = True
                lst = ListView1.Items.Add(reader(2).ToString + " " + reader(4) + " " + reader(3))
                lst.SubItems.Add(reader(5).ToString)
                If reader(6) = "Email Address (Optional)" Then
                    lst.SubItems.Add("None")
                Else
                    lst.SubItems.Add(reader(6))
                End If
                If reader(7) = "Student ID No." Or reader(7) = "Senior Citizen ID No." Then
                    lst.SubItems.Add("None")
                Else
                    lst.SubItems.Add(reader(7))
                End If
                If reader(8).ToString = "0" Then
                    lst.SubItems.Add("Regular")
                ElseIf reader(8).ToString = "1" Then
                    lst.SubItems.Add("Student")
                Else
                    lst.SubItems.Add("Senior Citizen")
                End If
                lst.SubItems.Add("₱ " + reader(9).ToString)
            Loop
            conn.Close()


        End If
    End Sub

    Private Sub header_Click(sender As Object, e As EventArgs) Handles header.Click

    End Sub

    Private Sub header_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Stafffrm.Enabled = True
        Stafffrm.Show()
        Me.Close()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class