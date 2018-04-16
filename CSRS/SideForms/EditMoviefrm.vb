Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class EditMoviefrm
    Dim yes As String = ""
    Dim ts1 As String
    Dim ts2 As String
    Dim ts3 As String
    Dim ts4 As String
    Dim ts5 As String
    Dim hnow As Integer
    Dim mnow As Integer
    Dim hans As Integer
    Dim mans As Integer
    Dim h As Integer
    Dim m As Integer
    Dim dp1 As DateTime
    Dim dp2 As DateTime
    Dim dp3 As DateTime
    Dim dp4 As DateTime
    Dim dp5 As DateTime
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim affector As Integer
    Dim upper As String
    Dim reader As SqlDataReader
    Dim duration As String
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
        Admin_EditMovies.Enabled = True
        Admin_EditMovies.TopMost = True

    End Sub
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        'hnow = Now.Hour
        'mnow = Now.Minute
        'h = BunifuMetroTextbox3.Text
        'm = BunifuMetroTextbox4.Text
        'hans = hnow + h
        'mans = mnow + m
        'DateTimePicker1.Value = Date.Parse("1/11/2000" + " " + hans + ":" + mans + " " + Now.ToString("tt"))
        If BunifuDropdown2.selectedIndex = 0 Then
            InputFields.BunifuCustomLabel1.Text = "Put duration first"
            InputFields.Show()
        Else
            DateTimePicker1.Value = Date.Now.Date + " 12:00 AM"
            DateTimePicker2.Value = Date.Now.Date + " 12:00 AM"
            DateTimePicker3.Value = Date.Now.Date + " 12:00 AM"
            DateTimePicker4.Value = Date.Now.Date + " 12:00 AM"
            DateTimePicker5.Value = Date.Now.Date + " 12:00 AM"
            mans = BunifuDropdown2.selectedValue
            hnow = mans * 60
            hans = BunifuDropdown3.selectedValue
            mnow = hnow + hans + 30
            dp1 = Date.Now.AddMinutes(30)
            ts1 = mnow
            dp2 = Date.Now.AddMinutes(mnow + 30)
            ts2 = mnow * 2
            dp3 = Date.Now.AddMinutes(mnow * 2 + 30)
            ts3 = mnow * 3
            dp4 = Date.Now.AddMinutes(mnow * 3 + 30)
            ts4 = mnow * 4
            dp5 = Date.Now.AddMinutes(mnow * 4 + 30)
            ts5 = mnow * 5
            If dp1 > Date.Parse(Date.Now.Date + " 9:00 PM") Then
                MsgBox("Cut off")
                Panel1.BackColor = Color.Red
            Else
                DateTimePicker1.Value = dp1
                Panel1.BackColor = Color.Lime
            End If
            If dp2 > Date.Parse(Date.Now.Date + " 9:00 PM") Then
                Panel2.BackColor = Color.Red
            Else
                DateTimePicker2.Value = dp2
                Panel2.BackColor = Color.Lime
            End If
            If dp3 > Date.Parse(Date.Now.Date + " 9:00 PM") Then
                Panel3.BackColor = Color.Red
            Else
                DateTimePicker3.Value = dp3
                Panel3.BackColor = Color.Lime
            End If
            If dp4 > Date.Parse(Date.Now.Date + " 9:00 PM") Then
                Panel4.BackColor = Color.Red
            Else
                Panel4.BackColor = Color.Lime
                DateTimePicker4.Value = dp4
            End If
            If dp5 > Date.Parse(Date.Now.Date + " 9:00 PM") Then
                Panel5.BackColor = Color.Red
            Else
                Panel5.BackColor = Color.Lime
                DateTimePicker5.Value = dp5
            End If

        End If

    End Sub
    Private Sub AddMoviefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Date.Now.Date + " 12:00 AM"
        DateTimePicker1.ShowUpDown = True
        DateTimePicker2.ShowUpDown = True
        DateTimePicker3.ShowUpDown = True
        DateTimePicker4.ShowUpDown = True
        DateTimePicker5.ShowUpDown = True
        conn.ConnectionString = constr
        Me.Opacity = 0.9
        conn.Open()
        comm = New SqlCommand("Select * From Movies Where ID='" & Admin_EditMovies.edit & "' and Date='" & Date.Now.ToString("MMM/dd/yyyy") & "'", conn)
        reader = comm.ExecuteReader
        If reader.Read = True Then
            BunifuMetroTextbox1.Text = reader(3)
            BunifuDropdown1.Text = reader(5)
            BunifuMetroTextbox2.Text = reader(6)
            BunifuMetroTextbox3.Text = reader(7)
            BunifuDropdown2.selectedIndex = reader(19)
            BunifuDropdown3.selectedIndex = reader(20)
            DateTimePicker1.Text = reader(8).ToString
            DateTimePicker2.Text = reader(10).ToString
            DateTimePicker3.Text = reader(12).ToString
            DateTimePicker4.Text = reader(14).ToString
            DateTimePicker5.Text = reader(16).ToString
        End If
        conn.Close()



    End Sub


    

    Private Sub BunifuMetroTextbox2_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.Enter
        If BunifuMetroTextbox2.Text = "Price" Then
            BunifuMetroTextbox2.Text = ""
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "0"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Title"
        End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub BunifuMetroTextbox1_Enter(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.Enter
        If BunifuMetroTextbox1.Text = "Title" Then
            BunifuMetroTextbox1.Text = ""
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Price"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "0"
        End If

    End Sub


    Private Sub BunifuMetroTextbox3_Enter(sender As Object, e As EventArgs)
        If BunifuMetroTextbox3.Text = "0" Then
            BunifuMetroTextbox3.Text = ""
        End If
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Price"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Title"
        End If
    End Sub


    Private Sub BunifuMetroTextbox4_Enter(sender As Object, e As EventArgs)

        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Price"
        End If

        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Title"
        End If
    End Sub



    Private Sub BunifuDropdown2_Enter(sender As Object, e As EventArgs) Handles BunifuDropdown2.Enter
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Price"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "0"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Title"
        End If
    End Sub



    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If BunifuMetroTextbox1.Text = "" Or BunifuMetroTextbox2.Text = "" Or BunifuMetroTextbox1.Text = "Title" Or BunifuMetroTextbox2.Text = "Price" Then
            InputFields.BunifuCustomLabel1.Text = "Please input all fields"
            InputFields.Show()
        ElseIf Panel1.BackColor <> Color.Lime Then
            InputFields.BunifuCustomLabel1.Text = "Generate schedule"
            InputFields.Show()
        Else
            If Admin_EditMovies.selected = "1" Then
                Admin_EditMovies.BunifuThinButton21.Visible = False
                Admin_EditMovies.Panel6.Visible = False
                Admin_EditMovies.Label1.Text = BunifuMetroTextbox1.Text
                Admin_EditMovies.Label6.Text = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
                Admin_EditMovies.Label7.Text = BunifuDropdown1.selectedValue
                Admin_EditMovies.Label12.Text = "₱ " + BunifuMetroTextbox2.Text
                Admin_EditMovies.Label46.Text = BunifuMetroTextbox3.Text + "% Student Discount"
                If Panel2.BackColor = Color.Red Then
                    Admin_EditMovies.Label8.Text = DateTimePicker1.Value.ToString("hh:mm tt")

                    Admin_EditMovies.Label11.Text = ""
                    Admin_EditMovies.Label13.Text = ""
                    Admin_EditMovies.Label10.Text = ""
                    Admin_EditMovies.Label9.Text = ""
                ElseIf Panel3.BackColor = Color.Red Then
                    Admin_EditMovies.Label9.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label8.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label11.Text = ""
                    Admin_EditMovies.Label13.Text = ""
                    Admin_EditMovies.Label10.Text = ""
                ElseIf Panel4.BackColor = Color.Red Then
                    Admin_EditMovies.Label9.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label8.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label10.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label11.Text = ""
                    Admin_EditMovies.Label13.Text = ""
                ElseIf Panel5.BackColor = Color.Red Then
                    Admin_EditMovies.Label11.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label9.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label8.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label10.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label13.Text = ""
                Else
                    Admin_EditMovies.Label11.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label9.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label8.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label10.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label13.Text = DateTimePicker5.Value.ToString("hh:mm tt")
                End If
                Admin_EditMovies.Label11.ForeColor = Color.Lime
                Admin_EditMovies.Label9.ForeColor = Color.Lime
                Admin_EditMovies.Label8.ForeColor = Color.Lime
                Admin_EditMovies.Label10.ForeColor = Color.Lime
                Admin_EditMovies.Label13.ForeColor = Color.Lime
                conn.Open()
                comm = New SqlCommand("Delete from Movies  where ID='" & Admin_EditMovies.edit & "'", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                conn.Open()
                comm = New SqlCommand("Insert into Movies(Date, Cinema, Title, Duration, Ratings, Price, Discount, TimeSlot1, TimeSlotEnd1, TimeSlot2, TimeSlotEnd2, TimeSlot3, TimeSlotEnd3, TimeSlot4, TimeSlotEnd4, TimeSlot5, TimeSlotEnd5, DateStart, Hour, Minute) values ('" & Date.Now.ToString("MMM/dd/yyyy") & "','" & "Cinema 1" & "','" & BunifuMetroTextbox1.Text & "','" & Admin_EditMovies.Label6.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & Admin_EditMovies.Label8.Text & "','" & ts1 & "','" & Admin_EditMovies.Label9.Text & "','" & ts2 & "','" & Admin_EditMovies.Label10.Text & "','" & ts3 & "','" & Admin_EditMovies.Label11.Text & "','" & ts4 & "','" & Admin_EditMovies.Label13.Text & "','" & ts5 & "', '" & Date.Now & "', '" & BunifuDropdown2.selectedIndex & "', '" & BunifuDropdown3.selectedIndex & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                Admin_EditMovies.c1t1 = Date.Now.AddMinutes(ts1)
                Admin_EditMovies.c1t2 = Date.Now.AddMinutes(ts2)
                Admin_EditMovies.c1t3 = Date.Now.AddMinutes(ts3)
                Admin_EditMovies.c1t4 = Date.Now.AddMinutes(ts4)
                Admin_EditMovies.c1t5 = Date.Now.AddMinutes(ts5)
            ElseIf Admin_EditMovies.selected = "2" Then
                Admin_EditMovies.BunifuThinButton22.Visible = False
                Admin_EditMovies.Panel7.Visible = False
                Admin_EditMovies.Label2.Text = BunifuMetroTextbox1.Text
                Admin_EditMovies.Label14.Text = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
                Admin_EditMovies.Label15.Text = BunifuDropdown1.selectedValue
                Admin_EditMovies.Label17.Text = "₱ " + BunifuMetroTextbox2.Text
                Admin_EditMovies.Label47.Text = BunifuMetroTextbox3.Text + "% Student Discount"
                If Panel2.BackColor = Color.Red Then
                    Admin_EditMovies.Label16.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label18.Text = ""
                    Admin_EditMovies.Label19.Text = ""
                    Admin_EditMovies.Label20.Text = ""
                    Admin_EditMovies.Label21.Text = ""
                ElseIf Panel3.BackColor = Color.Red Then
                    Admin_EditMovies.Label16.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label18.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label19.Text = ""
                    Admin_EditMovies.Label20.Text = ""
                    Admin_EditMovies.Label21.Text = ""
                ElseIf Panel4.BackColor = Color.Red Then
                    Admin_EditMovies.Label16.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label18.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label19.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label20.Text = ""
                    Admin_EditMovies.Label21.Text = ""
                ElseIf Panel5.BackColor = Color.Red Then
                    Admin_EditMovies.Label16.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label18.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label19.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label20.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label21.Text = ""
                Else
                    Admin_EditMovies.Label16.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label18.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label19.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label20.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label21.Text = DateTimePicker5.Value.ToString("hh:mm tt")
                End If
                conn.Open()
                comm = New SqlCommand("Delete from Movies  where ID='" & Admin_EditMovies.edit & "'", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                conn.Open()
                comm = New SqlCommand("Insert into Movies(Date, Cinema, Title, Duration, Ratings, Price, Discount, TimeSlot1, TimeSlotEnd1, TimeSlot2, TimeSlotEnd2, TimeSlot3, TimeSlotEnd3, TimeSlot4, TimeSlotEnd4, TimeSlot5, TimeSlotEnd5, DateStart, Hour, Minute) values ('" & Date.Now.ToString("MMM/dd/yyyy") & "','" & "Cinema 2" & "','" & BunifuMetroTextbox1.Text & "','" & Admin_EditMovies.Label14.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & Admin_EditMovies.Label16.Text & "','" & ts1 & "','" & Admin_EditMovies.Label18.Text & "','" & ts2 & "','" & Admin_EditMovies.Label19.Text & "','" & ts3 & "','" & Admin_EditMovies.Label20.Text & "','" & ts4 & "','" & Admin_EditMovies.Label21.Text & "','" & ts5 & "', '" & Date.Now & "', '" & BunifuDropdown2.selectedIndex & "', '" & BunifuDropdown3.selectedIndex & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                Admin_EditMovies.Label16.ForeColor = Color.Lime
                Admin_EditMovies.Label18.ForeColor = Color.Lime
                Admin_EditMovies.Label19.ForeColor = Color.Lime
                Admin_EditMovies.Label20.ForeColor = Color.Lime
                Admin_EditMovies.Label21.ForeColor = Color.Lime
                Admin_EditMovies.c2t1 = Date.Now.AddMinutes(ts1)
                Admin_EditMovies.c2t2 = Date.Now.AddMinutes(ts2)
                Admin_EditMovies.c2t3 = Date.Now.AddMinutes(ts3)
                Admin_EditMovies.c2t4 = Date.Now.AddMinutes(ts4)
                Admin_EditMovies.c2t5 = Date.Now.AddMinutes(ts5)
            ElseIf Admin_EditMovies.selected = "3" Then
                Admin_EditMovies.BunifuThinButton23.Visible = False
                Admin_EditMovies.Panel8.Visible = False
                Admin_EditMovies.Label3.Text = BunifuMetroTextbox1.Text
                Admin_EditMovies.Label26.Text = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
                Admin_EditMovies.Label24.Text = BunifuDropdown1.selectedValue
                Admin_EditMovies.Label23.Text = "₱ " + BunifuMetroTextbox2.Text
                Admin_EditMovies.Label48.Text = BunifuMetroTextbox3.Text + "% Student Discount"
                If Panel2.BackColor = Color.Red Then
                    Admin_EditMovies.Label22.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label25.Text = ""
                    Admin_EditMovies.Label27.Text = ""
                    Admin_EditMovies.Label28.Text = ""
                    Admin_EditMovies.Label29.Text = ""
                ElseIf Panel3.BackColor = Color.Red Then
                    Admin_EditMovies.Label22.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label25.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label27.Text = ""
                    Admin_EditMovies.Label28.Text = ""
                    Admin_EditMovies.Label29.Text = ""
                ElseIf Panel4.BackColor = Color.Red Then
                    Admin_EditMovies.Label22.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label25.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label27.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label28.Text = ""
                    Admin_EditMovies.Label29.Text = ""
                ElseIf Panel5.BackColor = Color.Red Then
                    Admin_EditMovies.Label22.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label25.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label27.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label28.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label29.Text = ""
                Else
                    Admin_EditMovies.Label22.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label25.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label27.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label28.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label29.Text = DateTimePicker5.Value.ToString("hh:mm tt")
                End If
                conn.Open()
                comm = New SqlCommand("Delete from Movies  where ID='" & Admin_EditMovies.edit & "'", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                conn.Open()
                comm = New SqlCommand("Insert into Movies(Date, Cinema, Title, Duration, Ratings, Price, Discount, TimeSlot1, TimeSlotEnd1, TimeSlot2, TimeSlotEnd2, TimeSlot3, TimeSlotEnd3, TimeSlot4, TimeSlotEnd4, TimeSlot5, TimeSlotEnd5, DateStart, Hour, Minute) values ('" & Date.Now.ToString("MMM/dd/yyyy") & "','" & "Cinema 3" & "','" & BunifuMetroTextbox1.Text & "','" & Admin_EditMovies.Label26.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & Admin_EditMovies.Label22.Text & "','" & ts1 & "','" & Admin_EditMovies.Label25.Text & "','" & ts2 & "','" & Admin_EditMovies.Label27.Text & "','" & ts3 & "','" & Admin_EditMovies.Label28.Text & "','" & ts4 & "','" & Admin_EditMovies.Label29.Text & "','" & ts5 & "', '" & Date.Now & "', '" & BunifuDropdown2.selectedIndex & "', '" & BunifuDropdown3.selectedIndex & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                Admin_EditMovies.Label22.ForeColor = Color.Lime
                Admin_EditMovies.Label25.ForeColor = Color.Lime
                Admin_EditMovies.Label27.ForeColor = Color.Lime
                Admin_EditMovies.Label28.ForeColor = Color.Lime
                Admin_EditMovies.Label29.ForeColor = Color.Lime
                Admin_EditMovies.c3t1 = Date.Now.AddMinutes(ts1)
                Admin_EditMovies.c3t2 = Date.Now.AddMinutes(ts2)
                Admin_EditMovies.c3t3 = Date.Now.AddMinutes(ts3)
                Admin_EditMovies.c3t4 = Date.Now.AddMinutes(ts4)
                Admin_EditMovies.c3t5 = Date.Now.AddMinutes(ts5)
            ElseIf Admin_EditMovies.selected = "4" Then
                Admin_EditMovies.BunifuThinButton24.Visible = False
                Admin_EditMovies.Panel9.Visible = False
                Admin_EditMovies.Label4.Text = BunifuMetroTextbox1.Text
                Admin_EditMovies.Label31.Text = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
                Admin_EditMovies.Label32.Text = BunifuDropdown1.selectedValue
                Admin_EditMovies.Label35.Text = "₱ " + BunifuMetroTextbox2.Text
                Admin_EditMovies.Label49.Text = BunifuMetroTextbox3.Text + "% Student Discount"
                If Panel2.BackColor = Color.Red Then
                    Admin_EditMovies.Label34.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label30.Text = ""
                    Admin_EditMovies.Label33.Text = ""
                    Admin_EditMovies.Label36.Text = ""
                    Admin_EditMovies.Label37.Text = ""
                ElseIf Panel3.BackColor = Color.Red Then
                    Admin_EditMovies.Label34.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label30.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label33.Text = ""
                    Admin_EditMovies.Label36.Text = ""
                    Admin_EditMovies.Label37.Text = ""
                ElseIf Panel4.BackColor = Color.Red Then
                    Admin_EditMovies.Label34.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label30.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label33.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label36.Text = ""
                    Admin_EditMovies.Label37.Text = ""
                ElseIf Panel5.BackColor = Color.Red Then
                    Admin_EditMovies.Label34.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label30.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label33.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label36.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label37.Text = ""
                Else
                    Admin_EditMovies.Label34.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label30.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label33.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label36.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label37.Text = DateTimePicker5.Value.ToString("hh:mm tt")
                End If
                conn.Open()
                comm = New SqlCommand("Delete from Movies  where ID='" & Admin_EditMovies.edit & "'", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                conn.Open()
                comm = New SqlCommand("Insert into Movies(Date, Cinema, Title, Duration, Ratings, Price, Discount, TimeSlot1, TimeSlotEnd1, TimeSlot2, TimeSlotEnd2, TimeSlot3, TimeSlotEnd3, TimeSlot4, TimeSlotEnd4, TimeSlot5, TimeSlotEnd5, DateStart, Hour, Minute) values ('" & Date.Now.ToString("MMM/dd/yyyy") & "','" & "Cinema 4" & "','" & BunifuMetroTextbox1.Text & "','" & Admin_EditMovies.Label31.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & Admin_EditMovies.Label34.Text & "','" & ts1 & "','" & Admin_EditMovies.Label30.Text & "','" & ts2 & "','" & Admin_EditMovies.Label33.Text & "','" & ts3 & "','" & Admin_EditMovies.Label36.Text & "','" & ts4 & "','" & Admin_EditMovies.Label37.Text & "','" & ts5 & "','" & Date.Now & "', '" & BunifuDropdown2.selectedIndex & "', '" & BunifuDropdown3.selectedIndex & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                Admin_EditMovies.Label34.ForeColor = Color.Lime
                Admin_EditMovies.Label30.ForeColor = Color.Lime
                Admin_EditMovies.Label33.ForeColor = Color.Lime
                Admin_EditMovies.Label36.ForeColor = Color.Lime
                Admin_EditMovies.Label37.ForeColor = Color.Lime
                Admin_EditMovies.c4t1 = Date.Now.AddMinutes(ts1)
                Admin_EditMovies.c4t2 = Date.Now.AddMinutes(ts2)
                Admin_EditMovies.c4t3 = Date.Now.AddMinutes(ts3)
                Admin_EditMovies.c4t4 = Date.Now.AddMinutes(ts4)
                Admin_EditMovies.c4t5 = Date.Now.AddMinutes(ts5)
            Else
                Admin_EditMovies.BunifuThinButton25.Visible = False
                Admin_EditMovies.Label5.Text = BunifuMetroTextbox1.Text
                Admin_EditMovies.Label44.Text = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
                Admin_EditMovies.Label42.Text = BunifuDropdown1.selectedValue
                Admin_EditMovies.Label38.Text = "₱ " + BunifuMetroTextbox2.Text
                Admin_EditMovies.Label50.Text = BunifuMetroTextbox3.Text + "% Student Discount"
                If Panel2.BackColor = Color.Red Then
                    Admin_EditMovies.Label40.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label39.Text = ""
                    Admin_EditMovies.Label43.Text = ""
                    Admin_EditMovies.Label41.Text = ""
                    Admin_EditMovies.Label45.Text = ""
                ElseIf Panel3.BackColor = Color.Red Then
                    Admin_EditMovies.Label40.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label39.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label43.Text = ""
                    Admin_EditMovies.Label41.Text = ""
                    Admin_EditMovies.Label45.Text = ""
                ElseIf Panel4.BackColor = Color.Red Then
                    Admin_EditMovies.Label40.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label39.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label43.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label41.Text = ""
                    Admin_EditMovies.Label45.Text = ""
                ElseIf Panel5.BackColor = Color.Red Then
                    Admin_EditMovies.Label40.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label39.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label43.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label41.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label45.Text = ""
                Else
                    Admin_EditMovies.Label40.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label39.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label43.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label41.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Admin_EditMovies.Label45.Text = DateTimePicker5.Value.ToString("hh:mm tt")
                End If
                conn.Open()
                comm = New SqlCommand("Delete from Movies  where ID='" & Admin_EditMovies.edit & "'", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                conn.Open()
                comm = New SqlCommand("Insert into Movies(Date, Cinema, Title, Duration, Ratings, Price, Discount, TimeSlot1, TimeSlotEnd1, TimeSlot2, TimeSlotEnd2, TimeSlot3, TimeSlotEnd3, TimeSlot4, TimeSlotEnd4, TimeSlot5, TimeSlotEnd5, DateStart, Hour, Minute) values ('" & Date.Now.ToString("MMM/dd/yyyy") & "','" & "Cinema 5" & "','" & BunifuMetroTextbox1.Text & "','" & Admin_EditMovies.Label44.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & Admin_EditMovies.Label40.Text & "','" & ts1 & "','" & Admin_EditMovies.Label39.Text & "','" & ts2 & "','" & Admin_EditMovies.Label43.Text & "','" & ts3 & "','" & Admin_EditMovies.Label41.Text & "','" & ts4 & "','" & Admin_EditMovies.Label45.Text & "','" & ts5 & "', '" & Date.Now & "', '" & BunifuDropdown2.selectedIndex & "', '" & BunifuDropdown3.selectedIndex & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                Admin_EditMovies.Label40.ForeColor = Color.Lime
                Admin_EditMovies.Label39.ForeColor = Color.Lime
                Admin_EditMovies.Label43.ForeColor = Color.Lime
                Admin_EditMovies.Label41.ForeColor = Color.Lime
                Admin_EditMovies.Label45.ForeColor = Color.Lime
                Admin_EditMovies.c5t1 = Date.Now.AddMinutes(ts1)
                Admin_EditMovies.c5t2 = Date.Now.AddMinutes(ts2)
                Admin_EditMovies.c5t3 = Date.Now.AddMinutes(ts3)
                Admin_EditMovies.c5t4 = Date.Now.AddMinutes(ts4)
                Admin_EditMovies.c5t5 = Date.Now.AddMinutes(ts5)
            End If
            Me.Close()
            Admin_EditMovies.Enabled = True
            Admin_EditMovies.TopMost = True
        End If
        'If BunifuMetroTextbox1.Text = "" Or BunifuMetroTextbox2.Text = "" Then
        '    MsgBox("Input all fields")
        'ElseIf Panel1.BackColor <> Color.Lime Then
        '    MsgBox("Generate movie schedule first")
        'Else
        '    conn.Open()
        '    duration = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
        '    comm = New SqlCommand("Update Movies set Date='" & Date.Now.ToString("MMM/dd/yyyy") & "', Title='" & BunifuMetroTextbox1.Text & "', Duration='" & duration & "', Ratings='" & BunifuDropdown1.selectedValue & "', Price='" & BunifuMetroTextbox2.Text & "', Discount='" & BunifuMetroTextbox3.Text & "', TimeSlot1='" & DateTimePicker1.Value.ToString("hh:mm tt") & "', TimeSlotEnd1='" & ts1 & "', TimeSlot2='" & DateTimePicker2.Value.ToString("hh:mm tt") & "', TimeSlotEnd2='" & ts2 & "', TimeSlot3='" & DateTimePicker3.Value.ToString("hh:mm tt") & "', TimeSlotEnd3='" & ts3 & "', TimeSlot4='" & DateTimePicker4.Value.ToString("hh:mm tt") & "', TimeSlotEnd4='" & ts4 & "', TimeSlot5='" & DateTimePicker5.Value.ToString("hh:mm tt") & "', TimeSlotEnd5='" & ts5 & "', DateStart='" & Date.Now & "', Hour='" & BunifuDropdown2.selectedValue & "', Minute='" & BunifuDropdown3.selectedValue & "' where ID='" & Admin_EditMovies.edit & "'", conn)
        '    affector = comm.ExecuteNonQuery
        '    conn.Close()
        '    Admin_EditMovies.UpdateSched()
        '    Me.Close()
        '    Admin_EditMovies.Enabled = True
        '    Admin_EditMovies.TopMost = True
        'End If


    End Sub

    Private Sub BunifuMetroTextbox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox2.KeyPress
        If Len(BunifuMetroTextbox2.Text) = 4 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox2_LostFocus(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.LostFocus

    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox1.KeyPress

        If Len(BunifuMetroTextbox1.Text) = 50 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "zxcvbnmasdaafghjklqwertyuiop1234567890., "
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox1_Leave(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.Leave
        BunifuMetroTextbox1.Text = StrConv(BunifuMetroTextbox1.Text, vbProperCase)
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox3_Enter1(sender As Object, e As EventArgs) Handles BunifuMetroTextbox3.Enter
        If BunifuMetroTextbox3.Text = "0" Then
            BunifuMetroTextbox3.Text = ""
        End If
        If BunifuMetroTextbox2.Text = "Price" Then
            BunifuMetroTextbox2.Text = ""
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "0"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Title"
        End If
    End Sub



    Private Sub BunifuMetroTextbox3_KeyDown(sender As Object, e As KeyEventArgs) Handles BunifuMetroTextbox3.KeyDown

    End Sub

    Private Sub BunifuMetroTextbox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BunifuMetroTextbox3.KeyPress
        If Len(BunifuMetroTextbox3.Text) = 2 Then
            If Not (Asc(e.KeyChar) = 8) Then
                Dim allowedChars As String = ""
                If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                    e.KeyChar = ChrW(0)
                    e.Handled = True
                End If
            End If
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BunifuMetroTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox3.OnValueChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuDropdown1_Enter(sender As Object, e As EventArgs) Handles BunifuDropdown1.Enter
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Price"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "0"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Title"
        End If
    End Sub

    Private Sub BunifuDropdown3_Enter(sender As Object, e As EventArgs) Handles BunifuDropdown3.Enter
        If BunifuMetroTextbox2.Text = "" Then
            BunifuMetroTextbox2.Text = "Price"
        End If
        If BunifuMetroTextbox3.Text = "" Then
            BunifuMetroTextbox3.Text = "0"
        End If
        If BunifuMetroTextbox1.Text = "" Then
            BunifuMetroTextbox1.Text = "Title"
        End If
    End Sub

End Class
