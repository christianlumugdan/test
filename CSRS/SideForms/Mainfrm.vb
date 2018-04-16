﻿Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter


Public Class Mainfrm
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim sqlconstr As SqlConnection = New SqlConnection
    Dim conn As SqlConnection = New SqlConnection
    Dim comm As SqlCommand = New SqlCommand
    Dim affector As Integer
    Dim reader As SqlDataReader
    Dim lst As ListViewItem
    Dim getold_name As String
    Dim save_type As String

    Private Sub Mainfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        save_type = "new"
        Try
            sqlconstr.ConnectionString = constr
            sqlconstr.Open()
            If sqlconstr.State = ConnectionState.Closed Then
                MessageBox.Show("Database Not Connected")
                End
            Else
                load_records()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub load_records()
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Select * From Admins", conn)
            reader = comm.ExecuteReader
            ListView1.Items.Clear()
            Do While reader.Read = True
                lst = ListView1.Items.Add(reader(1).ToString)
                lst.SubItems.Add(reader(2).ToString)
                lst.SubItems.Add(reader(3).ToString)
                lst.SubItems.Add(reader(4).ToString)
                lst.SubItems.Add(reader(5).ToString)
            Loop

        Catch ex As Exception

        End Try
    End Sub
    Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        DateTimePicker1.Value = Now
        TextBox5.Text = ""
        TextBox6.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
        save_type = "new"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            If save_type = "new" Then
                conn = New SqlConnection(constr)
                conn.Open()
                comm = New SqlCommand("Select * from Admins where Username='" & TextBox5.Text & "'", conn)
                reader = comm.ExecuteReader
                If reader.Read = True Then
                    MessageBox.Show("Userame already exist.")
                    TextBox5.Focus()
                Else
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("Insert into Staffs(Firstname, Lastname, Birthday, Contact, Address,Username,Password) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & DateTimePicker1.Value & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')", conn)
                    affector = comm.ExecuteNonQuery
                    clear()
                    MessageBox.Show("Record has been saved.")
                    TextBox1.Focus()
                    load_records()
                End If

            Else
                If TextBox1.Text = getold_name Then
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("Update Staffs set Firstname='" & TextBox1.Text & "', Lastname='" & TextBox2.Text & "', Birthday='" & DateTimePicker1.Value & "',  Contact='" & TextBox3.Text & "',  Address='" & TextBox4.Text & "' where Firstname='" & getold_name.ToString & "'", conn)
                    affector = comm.ExecuteNonQuery
                    MessageBox.Show("Record has been updated.")
                    clear()
                    TextBox1.Focus()
                    save_type = "new"
                    load_records()

                Else
                    conn = New SqlConnection(constr)
                    conn.Open()
                    comm = New SqlCommand("Select * from Staffs where Firstname='" & TextBox1.Text & "'", conn)
                    reader = comm.ExecuteReader
                    If reader.Read = True Then
                        MessageBox.Show("Username already exist.")
                        TextBox1.Focus()
                    Else
                        conn = New SqlConnection(constr)
                        conn.Open()
                        comm = New SqlCommand("Update Staffs set Firstname='" & TextBox1.Text & "', Lastname='" & TextBox2.Text & "', Birthday='" & DateTimePicker1.Value & "',  Contact='" & TextBox3.Text & "', Address='" & TextBox4.Text & "', Username='" & TextBox5.Text & "', Password='" & TextBox6.Text & "' where Firstname='" & getold_name.ToString & "'", conn)
                        affector = comm.ExecuteNonQuery
                        MessageBox.Show("Record has been updated.")
                        clear()
                        TextBox1.Focus()
                        save_type = "new"
                        load_records()

                    End If

                End If

            End If

        Catch ex As Exception

        End Try

               
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Select * from Staffs where Firstname='" & TextBox8.Text & "'", conn)
            reader = comm.ExecuteReader
            If reader.Read = True Then
                TextBox1.Text = reader(1).ToString
                TextBox2.Text = reader(2).ToString
                DateTimePicker1.Value = reader(3).ToString
                TextBox3.Text = reader(4).ToString
                TextBox4.Text = reader(5).ToString
                TextBox5.Text = reader(6).ToString
                TextBox6.Text = (reader(7).ToString)
                getold_name = reader(1).ToString
                save_type = "update "
            Else

                MessageBox.Show("No record(s) found")
                TextBox8.Focus()

            End If
        Catch ex As Exception

        End Try
    End Sub

 
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        TextBox1.Text = ListView1.FocusedItem.SubItems.Item(0).Text
        TextBox2.Text = ListView1.FocusedItem.SubItems.Item(1).Text
        DateTimePicker1.Value = ListView1.FocusedItem.SubItems.Item(2).Text
        TextBox3.Text = ListView1.FocusedItem.SubItems.Item(3).Text
        TextBox4.Text = ListView1.FocusedItem.SubItems.Item(4).Text
        getold_name = ListView1.FocusedItem.SubItems.Item(0).Text
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Try
            conn = New SqlConnection(constr)
            conn.Open()
            comm = New SqlCommand("Delete from Admins where Firstname='" & ListView1.FocusedItem.SubItems.Item(0).Text & "'", conn)
            affector = comm.ExecuteNonQuery
            load_records()
            clear()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Me.ListView1.SelectedItems.Count = 0 Then
            e.Cancel = True
        End If
    End Sub

  
End Class