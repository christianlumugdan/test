Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Staff_AddMoviefrm
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
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Me.Close()
        Staff_addMovies.Enabled = True
        Staff_addMovies.TopMost = True
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
        DateTimePicker1.ShowUpDown = True
        DateTimePicker2.ShowUpDown = True
        DateTimePicker3.ShowUpDown = True
        DateTimePicker4.ShowUpDown = True
        DateTimePicker5.ShowUpDown = True
        conn.ConnectionString = constr
        Me.Opacity = 0.9
        DateTimePicker1.Value = Date.Now.Date + " 12:00 AM"
    End Sub


    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If DateTimePicker1.Value > DateTimePicker2.Value Then
            MsgBox("Conflict Schedule")
        End If
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        If DateTimePicker2.Value > DateTimePicker3.Value Then
            MsgBox("Conflict Schedule")
        End If
    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker4.ValueChanged
        If DateTimePicker3.Value > DateTimePicker4.Value Then
            MsgBox("Conflict Schedule")
        End If
    End Sub

    Private Sub DateTimePicker5_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker5.ValueChanged
        If DateTimePicker4.Value > DateTimePicker5.Value Then
            MsgBox("Conflict Schedule")
        End If
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
            InputFields.BunifuCustomLabel1.Text = "Please input all"
            InputFields.Show()
        ElseIf Panel1.BackColor <> Color.Lime Then
            InputFields.BunifuCustomLabel1.Text = "Generate schedule"
            InputFields.Show()
        Else
            If Staff_addMovies.selected = "1" Then
                Staff_addMovies.BunifuThinButton21.Visible = False
                Staff_addMovies.Panel6.Visible = False
                Staff_addMovies.Label1.Text = BunifuMetroTextbox1.Text
                Staff_addMovies.Label6.Text = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
                Staff_addMovies.Label7.Text = BunifuDropdown1.selectedValue
                Staff_addMovies.Label12.Text = "₱ " + BunifuMetroTextbox2.Text
                Staff_addMovies.Label46.Text = BunifuMetroTextbox3.Text + "% Student Discount"
                If Panel2.BackColor = Color.Red Then
                    Staff_addMovies.Label8.Text = DateTimePicker1.Value.ToString("hh:mm tt")

                    Staff_addMovies.Label11.Text = ""
                    Staff_addMovies.Label13.Text = ""
                    Staff_addMovies.Label10.Text = ""
                    Staff_addMovies.Label9.Text = ""
                ElseIf Panel3.BackColor = Color.Red Then
                    Staff_addMovies.Label9.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label8.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label11.Text = ""
                    Staff_addMovies.Label13.Text = ""
                    Staff_addMovies.Label10.Text = ""
                ElseIf Panel4.BackColor = Color.Red Then
                    Staff_addMovies.Label9.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label8.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label10.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label11.Text = ""
                    Staff_addMovies.Label13.Text = ""
                ElseIf Panel5.BackColor = Color.Red Then
                    Staff_addMovies.Label11.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label9.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label8.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label10.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label13.Text = ""
                Else
                    Staff_addMovies.Label11.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label9.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label8.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label10.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label13.Text = DateTimePicker5.Value.ToString("hh:mm tt")
                End If
                Staff_addMovies.Label11.ForeColor = Color.Lime
                Staff_addMovies.Label9.ForeColor = Color.Lime
                Staff_addMovies.Label8.ForeColor = Color.Lime
                Staff_addMovies.Label10.ForeColor = Color.Lime
                Staff_addMovies.Label13.ForeColor = Color.Lime
                conn.Open()
                comm = New SqlCommand("Insert into Movies(Date, Cinema, Title, Duration, Ratings, Price, Discount, TimeSlot1, TimeSlotEnd1, TimeSlot2, TimeSlotEnd2, TimeSlot3, TimeSlotEnd3, TimeSlot4, TimeSlotEnd4, TimeSlot5, TimeSlotEnd5, DateStart, Hour, Minute) values ('" & Date.Now.ToString("MMM/dd/yyyy") & "','" & "Cinema 1" & "','" & BunifuMetroTextbox1.Text & "','" & Staff_addMovies.Label6.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & Staff_addMovies.Label8.Text & "','" & ts1 & "','" & Staff_addMovies.Label9.Text & "','" & ts2 & "','" & Staff_addMovies.Label10.Text & "','" & ts3 & "','" & Staff_addMovies.Label11.Text & "','" & ts4 & "','" & Staff_addMovies.Label13.Text & "','" & ts5 & "', '" & Date.Now & "', '" & BunifuDropdown2.selectedIndex & "', '" & BunifuDropdown3.selectedIndex & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                Staff_addMovies.c1t1 = Date.Now.AddMinutes(ts1)
                Staff_addMovies.c1t2 = Date.Now.AddMinutes(ts2)
                Staff_addMovies.c1t3 = Date.Now.AddMinutes(ts3)
                Staff_addMovies.c1t4 = Date.Now.AddMinutes(ts4)
                Staff_addMovies.c1t5 = Date.Now.AddMinutes(ts5)
            ElseIf Staff_addMovies.selected = "2" Then
                Staff_addMovies.BunifuThinButton22.Visible = False
                Staff_addMovies.Panel7.Visible = False
                Staff_addMovies.Label2.Text = BunifuMetroTextbox1.Text
                Staff_addMovies.Label14.Text = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
                Staff_addMovies.Label15.Text = BunifuDropdown1.selectedValue
                Staff_addMovies.Label17.Text = "₱ " + BunifuMetroTextbox2.Text
                Staff_addMovies.Label47.Text = BunifuMetroTextbox3.Text + "% Student Discount"
                If Panel2.BackColor = Color.Red Then
                    Staff_addMovies.Label16.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label18.Text = ""
                    Staff_addMovies.Label19.Text = ""
                    Staff_addMovies.Label20.Text = ""
                    Staff_addMovies.Label21.Text = ""
                ElseIf Panel3.BackColor = Color.Red Then
                    Staff_addMovies.Label16.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label18.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label19.Text = ""
                    Staff_addMovies.Label20.Text = ""
                    Staff_addMovies.Label21.Text = ""
                ElseIf Panel4.BackColor = Color.Red Then
                    Staff_addMovies.Label16.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label18.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label19.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label20.Text = ""
                    Staff_addMovies.Label21.Text = ""
                ElseIf Panel5.BackColor = Color.Red Then
                    Staff_addMovies.Label16.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label18.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label19.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label20.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label21.Text = ""
                Else
                    Staff_addMovies.Label16.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label18.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label19.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label20.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label21.Text = DateTimePicker5.Value.ToString("hh:mm tt")
                End If
                conn.Open()
                comm = New SqlCommand("Insert into Movies(Date, Cinema, Title, Duration, Ratings, Price, Discount, TimeSlot1, TimeSlotEnd1, TimeSlot2, TimeSlotEnd2, TimeSlot3, TimeSlotEnd3, TimeSlot4, TimeSlotEnd4, TimeSlot5, TimeSlotEnd5, DateStart, Hour, Minute) values ('" & Date.Now.ToString("MMM/dd/yyyy") & "','" & "Cinema 2" & "','" & BunifuMetroTextbox1.Text & "','" & Staff_addMovies.Label14.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & Staff_addMovies.Label16.Text & "','" & ts1 & "','" & Staff_addMovies.Label18.Text & "','" & ts2 & "','" & Staff_addMovies.Label19.Text & "','" & ts3 & "','" & Staff_addMovies.Label20.Text & "','" & ts4 & "','" & Staff_addMovies.Label21.Text & "','" & ts5 & "', '" & Date.Now & "', '" & BunifuDropdown2.selectedIndex & "', '" & BunifuDropdown3.selectedIndex & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                Staff_addMovies.Label16.ForeColor = Color.Lime
                Staff_addMovies.Label18.ForeColor = Color.Lime
                Staff_addMovies.Label19.ForeColor = Color.Lime
                Staff_addMovies.Label20.ForeColor = Color.Lime
                Staff_addMovies.Label21.ForeColor = Color.Lime
                Staff_addMovies.c2t1 = Date.Now.AddMinutes(ts1)
                Staff_addMovies.c2t2 = Date.Now.AddMinutes(ts2)
                Staff_addMovies.c2t3 = Date.Now.AddMinutes(ts3)
                Staff_addMovies.c2t4 = Date.Now.AddMinutes(ts4)
                Staff_addMovies.c2t5 = Date.Now.AddMinutes(ts5)
            ElseIf Staff_addMovies.selected = "3" Then
                Staff_addMovies.BunifuThinButton23.Visible = False
                Staff_addMovies.Panel8.Visible = False
                Staff_addMovies.Label3.Text = BunifuMetroTextbox1.Text
                Staff_addMovies.Label26.Text = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
                Staff_addMovies.Label24.Text = BunifuDropdown1.selectedValue
                Staff_addMovies.Label23.Text = "₱ " + BunifuMetroTextbox2.Text
                Staff_addMovies.Label48.Text = BunifuMetroTextbox3.Text + "% Student Discount"
                If Panel2.BackColor = Color.Red Then
                    Staff_addMovies.Label22.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label25.Text = ""
                    Staff_addMovies.Label27.Text = ""
                    Staff_addMovies.Label28.Text = ""
                    Staff_addMovies.Label29.Text = ""
                ElseIf Panel3.BackColor = Color.Red Then
                    Staff_addMovies.Label22.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label25.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label27.Text = ""
                    Staff_addMovies.Label28.Text = ""
                    Staff_addMovies.Label29.Text = ""
                ElseIf Panel4.BackColor = Color.Red Then
                    Staff_addMovies.Label22.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label25.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label27.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label28.Text = ""
                    Staff_addMovies.Label29.Text = ""
                ElseIf Panel5.BackColor = Color.Red Then
                    Staff_addMovies.Label22.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label25.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label27.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label28.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label29.Text = ""
                Else
                    Staff_addMovies.Label22.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label25.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label27.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label28.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label29.Text = DateTimePicker5.Value.ToString("hh:mm tt")
                End If
                conn.Open()
                comm = New SqlCommand("Insert into Movies(Date, Cinema, Title, Duration, Ratings, Price, Discount, TimeSlot1, TimeSlotEnd1, TimeSlot2, TimeSlotEnd2, TimeSlot3, TimeSlotEnd3, TimeSlot4, TimeSlotEnd4, TimeSlot5, TimeSlotEnd5, DateStart, Hour, Minute) values ('" & Date.Now.ToString("MMM/dd/yyyy") & "','" & "Cinema 3" & "','" & BunifuMetroTextbox1.Text & "','" & Staff_addMovies.Label26.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & Staff_addMovies.Label22.Text & "','" & ts1 & "','" & Staff_addMovies.Label25.Text & "','" & ts2 & "','" & Staff_addMovies.Label27.Text & "','" & ts3 & "','" & Staff_addMovies.Label28.Text & "','" & ts4 & "','" & Staff_addMovies.Label29.Text & "','" & ts5 & "', '" & Date.Now & "', '" & BunifuDropdown2.selectedIndex & "', '" & BunifuDropdown3.selectedIndex & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                Staff_addMovies.Label22.ForeColor = Color.Lime
                Staff_addMovies.Label25.ForeColor = Color.Lime
                Staff_addMovies.Label27.ForeColor = Color.Lime
                Staff_addMovies.Label28.ForeColor = Color.Lime
                Staff_addMovies.Label29.ForeColor = Color.Lime
                Staff_addMovies.c3t1 = Date.Now.AddMinutes(ts1)
                Staff_addMovies.c3t2 = Date.Now.AddMinutes(ts2)
                Staff_addMovies.c3t3 = Date.Now.AddMinutes(ts3)
                Staff_addMovies.c3t4 = Date.Now.AddMinutes(ts4)
                Staff_addMovies.c3t5 = Date.Now.AddMinutes(ts5)
            ElseIf Staff_addMovies.selected = "4" Then
                Staff_addMovies.BunifuThinButton24.Visible = False
                Staff_addMovies.Panel9.Visible = False
                Staff_addMovies.Label4.Text = BunifuMetroTextbox1.Text
                Staff_addMovies.Label31.Text = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
                Staff_addMovies.Label32.Text = BunifuDropdown1.selectedValue
                Staff_addMovies.Label35.Text = "₱ " + BunifuMetroTextbox2.Text
                Staff_addMovies.Label49.Text = BunifuMetroTextbox3.Text + "% Student Discount"
                If Panel2.BackColor = Color.Red Then
                    Staff_addMovies.Label34.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label30.Text = ""
                    Staff_addMovies.Label33.Text = ""
                    Staff_addMovies.Label36.Text = ""
                    Staff_addMovies.Label37.Text = ""
                ElseIf Panel3.BackColor = Color.Red Then
                    Staff_addMovies.Label34.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label30.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label33.Text = ""
                    Staff_addMovies.Label36.Text = ""
                    Staff_addMovies.Label37.Text = ""
                ElseIf Panel4.BackColor = Color.Red Then
                    Staff_addMovies.Label34.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label30.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label33.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label36.Text = ""
                    Staff_addMovies.Label37.Text = ""
                ElseIf Panel5.BackColor = Color.Red Then
                    Staff_addMovies.Label34.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label30.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label33.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label36.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label37.Text = ""
                Else
                    Staff_addMovies.Label34.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label30.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label33.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label36.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label37.Text = DateTimePicker5.Value.ToString("hh:mm tt")
                End If
                conn.Open()
                comm = New SqlCommand("Insert into Movies(Date, Cinema, Title, Duration, Ratings, Price, Discount, TimeSlot1, TimeSlotEnd1, TimeSlot2, TimeSlotEnd2, TimeSlot3, TimeSlotEnd3, TimeSlot4, TimeSlotEnd4, TimeSlot5, TimeSlotEnd5, DateStart, Hour, Minute) values ('" & Date.Now.ToString("MMM/dd/yyyy") & "','" & "Cinema 4" & "','" & BunifuMetroTextbox1.Text & "','" & Staff_addMovies.Label31.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & Staff_addMovies.Label34.Text & "','" & ts1 & "','" & Staff_addMovies.Label30.Text & "','" & ts2 & "','" & Staff_addMovies.Label33.Text & "','" & ts3 & "','" & Staff_addMovies.Label36.Text & "','" & ts4 & "','" & Staff_addMovies.Label37.Text & "','" & ts5 & "','" & Date.Now & "', '" & BunifuDropdown2.selectedIndex & "', '" & BunifuDropdown3.selectedIndex & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                Staff_addMovies.Label34.ForeColor = Color.Lime
                Staff_addMovies.Label30.ForeColor = Color.Lime
                Staff_addMovies.Label33.ForeColor = Color.Lime
                Staff_addMovies.Label36.ForeColor = Color.Lime
                Staff_addMovies.Label37.ForeColor = Color.Lime
                Staff_addMovies.c4t1 = Date.Now.AddMinutes(ts1)
                Staff_addMovies.c4t2 = Date.Now.AddMinutes(ts2)
                Staff_addMovies.c4t3 = Date.Now.AddMinutes(ts3)
                Staff_addMovies.c4t4 = Date.Now.AddMinutes(ts4)
                Staff_addMovies.c4t5 = Date.Now.AddMinutes(ts5)
            Else
                Staff_addMovies.BunifuThinButton25.Visible = False
                Staff_addMovies.Label5.Text = BunifuMetroTextbox1.Text
                Staff_addMovies.Label44.Text = BunifuDropdown2.selectedValue + " hour(s) and " + BunifuDropdown3.selectedValue + " minute(s)"
                Staff_addMovies.Label42.Text = BunifuDropdown1.selectedValue
                Staff_addMovies.Label38.Text = "₱ " + BunifuMetroTextbox2.Text
                Staff_addMovies.Label50.Text = BunifuMetroTextbox3.Text + "% Student Discount"
                If Panel2.BackColor = Color.Red Then
                    Staff_addMovies.Label40.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label39.Text = ""
                    Staff_addMovies.Label43.Text = ""
                    Staff_addMovies.Label41.Text = ""
                    Staff_addMovies.Label45.Text = ""
                ElseIf Panel3.BackColor = Color.Red Then
                    Staff_addMovies.Label40.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label39.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label43.Text = ""
                    Staff_addMovies.Label41.Text = ""
                    Staff_addMovies.Label45.Text = ""
                ElseIf Panel4.BackColor = Color.Red Then
                    Staff_addMovies.Label40.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label39.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label43.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label41.Text = ""
                    Staff_addMovies.Label45.Text = ""
                ElseIf Panel5.BackColor = Color.Red Then
                    Staff_addMovies.Label40.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label39.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label43.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label41.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label45.Text = ""
                Else
                    Staff_addMovies.Label40.Text = DateTimePicker1.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label39.Text = DateTimePicker2.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label43.Text = DateTimePicker3.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label41.Text = DateTimePicker4.Value.ToString("hh:mm tt")
                    Staff_addMovies.Label45.Text = DateTimePicker5.Value.ToString("hh:mm tt")
                End If
                conn.Open()
                comm = New SqlCommand("Insert into Movies(Date, Cinema, Title, Duration, Ratings, Price, Discount, TimeSlot1, TimeSlotEnd1, TimeSlot2, TimeSlotEnd2, TimeSlot3, TimeSlotEnd3, TimeSlot4, TimeSlotEnd4, TimeSlot5, TimeSlotEnd5, DateStart, Hour, Minute) values ('" & Date.Now.ToString("MMM/dd/yyyy") & "','" & "Cinema 5" & "','" & BunifuMetroTextbox1.Text & "','" & Staff_addMovies.Label44.Text & "','" & BunifuDropdown1.selectedValue & "','" & BunifuMetroTextbox2.Text & "','" & BunifuMetroTextbox3.Text & "','" & Staff_addMovies.Label40.Text & "','" & ts1 & "','" & Staff_addMovies.Label39.Text & "','" & ts2 & "','" & Staff_addMovies.Label43.Text & "','" & ts3 & "','" & Staff_addMovies.Label41.Text & "','" & ts4 & "','" & Staff_addMovies.Label45.Text & "','" & ts5 & "', '" & Date.Now & "', '" & BunifuDropdown2.selectedIndex & "', '" & BunifuDropdown3.selectedIndex & "')", conn)
                affector = comm.ExecuteNonQuery
                conn.Close()
                Staff_addMovies.Label40.ForeColor = Color.Lime
                Staff_addMovies.Label39.ForeColor = Color.Lime
                Staff_addMovies.Label43.ForeColor = Color.Lime
                Staff_addMovies.Label41.ForeColor = Color.Lime
                Staff_addMovies.Label45.ForeColor = Color.Lime
                Staff_addMovies.c5t1 = Date.Now.AddMinutes(ts1)
                Staff_addMovies.c5t2 = Date.Now.AddMinutes(ts2)
                Staff_addMovies.c5t3 = Date.Now.AddMinutes(ts3)
                Staff_addMovies.c5t4 = Date.Now.AddMinutes(ts4)
                Staff_addMovies.c5t5 = Date.Now.AddMinutes(ts5)
            End If
            Me.Close()
            Staff_addMovies.Enabled = True
            Staff_addMovies.TopMost = True
        End If
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

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub BunifuThinButton24_Click_1(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
    End Sub


End Class
