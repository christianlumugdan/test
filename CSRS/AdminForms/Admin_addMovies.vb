Imports System.Data.SqlClient
Public Class Admin_addMovies
    Public c1t1 As DateTime
    Public c1t2 As DateTime
    Public c1t3 As DateTime
    Public c1t4 As DateTime
    Public c1t5 As DateTime
    Public c2t1 As DateTime
    Public c2t2 As DateTime
    Public c2t3 As DateTime
    Public c2t4 As DateTime
    Public c2t5 As DateTime
    Public c3t1 As DateTime
    Public c3t2 As DateTime
    Public c3t3 As DateTime
    Public c3t4 As DateTime
    Public c3t5 As DateTime
    Public c4t1 As DateTime
    Public c4t2 As DateTime
    Public c4t3 As DateTime
    Public c4t4 As DateTime
    Public c4t5 As DateTime
    Public c5t1 As DateTime
    Public c5t2 As DateTime
    Public c5t3 As DateTime
    Public c5t4 As DateTime
    Public c5t5 As DateTime
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim reader As SqlDataReader
    Dim startdate As DateTime
    Public editc1 As String
    Public editc2 As String
    Public editc3 As String
    Public editc4 As String
    Public editc5 As String
    Public edit As String
    Public selected As String
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        selected = "1"
        AddMoviefrm.Show()
        AddMoviefrm.TopMost = True
        Me.Enabled = False

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        selected = "2"
        AddMoviefrm.Show()
        AddMoviefrm.TopMost = True
        Me.Enabled = False
    End Sub
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        selected = "3"
        AddMoviefrm.Show()
        AddMoviefrm.TopMost = True
        Me.Enabled = False
    End Sub
    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        selected = "4"
        AddMoviefrm.Show()
        AddMoviefrm.TopMost = True
        Me.Enabled = False
    End Sub
    Private Sub BunifuThinButton25_Click(sender As Object, e As EventArgs) Handles BunifuThinButton25.Click
        selected = "5"
        AddMoviefrm.Show()
        AddMoviefrm.TopMost = True
        Me.Enabled = False
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label8.Text <> "Time Slot 1" And Label8.Text <> "" Then
            Dim a1t1 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label8.Text
            If Date.Now >= c1t1 Then
                Label8.ForeColor = Color.Red
            ElseIf Date.Now >= a1t1 Then
                Label8.ForeColor = Color.Yellow
            Else
                Label8.ForeColor = Color.Lime
            End If
        End If
        If Label9.Text <> "Time Slot 2" And Label9.Text <> "" Then
            Dim a1t2 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label9.Text
            If Date.Now >= c1t2 Then
                Label9.ForeColor = Color.Red
            ElseIf Date.Now >= a1t2 Then
                Label9.ForeColor = Color.Yellow
            Else
                Label9.ForeColor = Color.Lime
            End If
        End If
        If Label10.Text <> "Time Slot 3" And Label10.Text <> "" Then
            Dim a1t3 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label10.Text
            If Date.Now >= c1t3 Then
                Label10.ForeColor = Color.Red
            ElseIf Date.Now >= a1t3 Then
                Label10.ForeColor = Color.Yellow
            Else
                Label10.ForeColor = Color.Lime
            End If
        End If
        If Label11.Text <> "Time Slot 4" And Label11.Text <> "" Then
            Dim a1t4 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label11.Text
            If Date.Now >= c1t4 Then
                Label11.ForeColor = Color.Red
            ElseIf Date.Now >= a1t4 Then
                Label11.ForeColor = Color.Yellow
            Else
                Label11.ForeColor = Color.Lime
            End If
        End If
        If Label13.Text <> "Time Slot 5" And Label13.Text <> "" Then
            Dim a1t5 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label13.Text
            If Date.Now >= c1t5 Then
                Label13.ForeColor = Color.Red
            ElseIf Date.Now >= a1t5 Then
                Label13.ForeColor = Color.Yellow
            Else
                Label13.ForeColor = Color.Lime
            End If
        End If
        '''''''''' Cinema 2

        If Label16.Text <> "Time Slot 1" And Label16.Text <> "" Then
            Dim a2t1 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label16.Text
            If Date.Now >= c2t1 Then
                Label16.ForeColor = Color.Red
            ElseIf Date.Now >= a2t1 Then
                Label16.ForeColor = Color.Yellow
            Else
                Label16.ForeColor = Color.Lime
            End If
        End If
        If Label18.Text <> "Time Slot 2" And Label18.Text <> "" Then
            Dim a2t2 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label18.Text
            If Date.Now >= c2t2 Then
                Label18.ForeColor = Color.Red
            ElseIf Date.Now >= a2t2 Then
                Label18.ForeColor = Color.Yellow
            Else
                Label18.ForeColor = Color.Lime
            End If
        End If
        If Label19.Text <> "Time Slot 3" And Label19.Text <> "" Then
            Dim a2t3 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label19.Text
            If Date.Now >= c2t3 Then
                Label19.ForeColor = Color.Red
            ElseIf Date.Now >= a2t3 Then
                Label19.ForeColor = Color.Yellow
            Else
                Label19.ForeColor = Color.Lime
            End If
        End If
        If Label20.Text <> "Time Slot 4" And Label20.Text <> "" Then
            Dim a2t4 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label20.Text
            If Date.Now >= c2t4 Then
                Label20.ForeColor = Color.Red
            ElseIf Date.Now >= a2t4 Then
                Label20.ForeColor = Color.Yellow
            Else
                Label20.ForeColor = Color.Lime
            End If
        End If
        If Label21.Text <> "Time Slot 5" And Label21.Text <> "" Then
            Dim a2t5 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label21.Text
            If Date.Now >= c2t5 Then
                Label21.ForeColor = Color.Red
            ElseIf Date.Now >= a2t5 Then
                Label21.ForeColor = Color.Yellow
            Else
                Label21.ForeColor = Color.Lime
            End If
        End If
        '''''''''''''Cinema Three
        If Label22.Text <> "Time Slot 1" And Label22.Text <> "" Then
            Dim a3t1 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label22.Text
            If Date.Now >= c3t1 Then
                Label22.ForeColor = Color.Red
            ElseIf Date.Now >= a3t1 Then
                Label22.ForeColor = Color.Yellow
            Else
                Label22.ForeColor = Color.Lime
            End If
        End If
        If Label25.Text <> "Time Slot 2" And Label25.Text <> "" Then
            Dim a3t2 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label25.Text
            If Date.Now >= c3t2 Then
                Label25.ForeColor = Color.Red
            ElseIf Date.Now >= a3t2 Then
                Label25.ForeColor = Color.Yellow
            Else
                Label25.ForeColor = Color.Lime
            End If
        End If
        If Label27.Text <> "Time Slot 3" And Label27.Text <> "" Then
            Dim a3t3 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label27.Text
            If Date.Now >= c3t3 Then
                Label27.ForeColor = Color.Red
            ElseIf Date.Now >= a3t3 Then
                Label27.ForeColor = Color.Yellow
            Else
                Label27.ForeColor = Color.Lime
            End If
        End If
        If Label28.Text <> "Time Slot 4" And Label28.Text <> "" Then
            Dim a3t4 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label28.Text
            If Date.Now >= c3t4 Then
                Label28.ForeColor = Color.Red
            ElseIf Date.Now >= a3t4 Then
                Label28.ForeColor = Color.Yellow
            Else
                Label28.ForeColor = Color.Lime
            End If
        End If
        If Label29.Text <> "Time Slot 5" And Label29.Text <> "" Then
            Dim a3t5 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label29.Text
            If Date.Now >= c3t5 Then
                Label29.ForeColor = Color.Red
            ElseIf Date.Now >= a3t5 Then
                Label29.ForeColor = Color.Yellow
            Else
                Label29.ForeColor = Color.Lime
            End If
        End If
        ''''''''''''''' Cinema Four
        If Label34.Text <> "Time Slot 1" And Label34.Text <> "" Then
            Dim a4t1 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label34.Text
            If Date.Now >= c4t1 Then
                Label34.ForeColor = Color.Red
            ElseIf Date.Now >= a4t1 Then
                Label34.ForeColor = Color.Yellow
            Else
                Label34.ForeColor = Color.Lime
            End If
        End If
        If Label30.Text <> "Time Slot 2" And Label30.Text <> "" Then
            Dim a4t2 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label30.Text
            If Date.Now >= c4t2 Then
                Label30.ForeColor = Color.Red
            ElseIf Date.Now >= a4t2 Then
                Label30.ForeColor = Color.Yellow
            Else
                Label30.ForeColor = Color.Lime
            End If
        End If
        If Label33.Text <> "Time Slot 3" And Label33.Text <> "" Then
            Dim a4t3 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label33.Text
            If Date.Now >= c4t3 Then
                Label33.ForeColor = Color.Red
            ElseIf Date.Now >= a4t3 Then
                Label33.ForeColor = Color.Yellow
            Else
                Label33.ForeColor = Color.Lime
            End If
        End If
        If Label36.Text <> "Time Slot 4" And Label36.Text <> "" Then
            Dim a4t4 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label36.Text
            If Date.Now >= c4t4 Then
                Label36.ForeColor = Color.Red
            ElseIf Date.Now >= a4t4 Then
                Label36.ForeColor = Color.Yellow
            Else
                Label36.ForeColor = Color.Lime
            End If
        End If
        If Label37.Text <> "Time Slot 5" And Label37.Text <> "" Then
            Dim a4t5 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label37.Text
            If Date.Now >= c4t5 Then
                Label37.ForeColor = Color.Red
            ElseIf Date.Now >= a4t5 Then
                Label37.ForeColor = Color.Yellow
            Else
                Label37.ForeColor = Color.Lime
            End If
        End If
        '''''''''''' Cinema Five
        If Label40.Text <> "Time Slot 1" And Label40.Text <> "" Then
            Dim a5t1 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label40.Text
            If Date.Now >= c5t1 Then
                Label40.ForeColor = Color.Red
            ElseIf Date.Now >= a5t1 Then
                Label40.ForeColor = Color.Yellow
            Else
                Label40.ForeColor = Color.Lime
            End If
        End If
        If Label39.Text <> "Time Slot 2" And Label39.Text <> "" Then
            Dim a5t2 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label39.Text
            If Date.Now >= c5t2 Then
                Label39.ForeColor = Color.Red
            ElseIf Date.Now >= a5t2 Then
                Label39.ForeColor = Color.Yellow
            Else
                Label39.ForeColor = Color.Lime
            End If
        End If
        If Label43.Text <> "Time Slot 3" And Label43.Text <> "" Then
            Dim a5t3 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label43.Text
            If Date.Now >= c5t3 Then
                Label40.ForeColor = Color.Red
            ElseIf Date.Now >= a5t3 Then
                Label40.ForeColor = Color.Yellow
            Else
                Label40.ForeColor = Color.Lime
            End If
        End If
        If Label41.Text <> "Time Slot 4" And Label41.Text <> "" Then
            Dim a5t4 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label41.Text
            If Date.Now >= c5t4 Then
                Label41.ForeColor = Color.Red
            ElseIf Date.Now >= a5t4 Then
                Label41.ForeColor = Color.Yellow
            Else
                Label41.ForeColor = Color.Lime
            End If
        End If
        If Label45.Text <> "Time Slot 5" And Label45.Text <> "" Then
            Dim a5t5 As DateTime = Date.Now.ToString("MMM/dd/yyyy") + " " + Label45.Text
            If Date.Now >= c5t5 Then
                Label45.ForeColor = Color.Red
            ElseIf Date.Now >= a5t5 Then
                Label45.ForeColor = Color.Yellow
            Else
                Label45.ForeColor = Color.Lime
            End If
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Admin_AddMovies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.ConnectionString = constr
        conn.Open()
        comm = New SqlCommand("Select * from Movies Where Date='" & Date.Now.ToString("MMM/dd/yyyy") & "' and Cinema='Cinema 1'", conn)
        reader = comm.ExecuteReader
        If reader.Read = True Then
            Label1.Text = reader(3)
            Label6.Text = reader(4)
            Label7.Text = reader(5)
            Label12.Text = "₱ " + reader(6).ToString
            Label46.Text = reader(7).ToString + " % Student Discount"
            Label8.Text = reader(8)
            startdate = reader(18)
            c1t1 = startdate.AddMinutes(reader(9))
            Label9.Text = reader(10)
            c1t2 = startdate.AddMinutes(reader(11))
            Label10.Text = reader(12)
            c1t3 = startdate.AddMinutes(reader(13))
            Label11.Text = reader(14)
            c1t4 = startdate.AddMinutes(reader(15))
            Label13.Text = reader(16)
            c1t5 = startdate.AddMinutes(reader(17))
            Panel6.Visible = False
            editc1 = reader(0)
            BunifuThinButton21.Visible = False
        End If
        conn.Close()
        conn.Open()
        comm = New SqlCommand("Select * from Movies Where Date='" & Date.Now.ToString("MMM/dd/yyyy") & "' and Cinema='Cinema 2'", conn)
        reader = comm.ExecuteReader
        If reader.Read = True Then
            Panel6.Visible = False
            Label2.Text = reader(3)
            Label14.Text = reader(4)
            Label15.Text = reader(5)
            Label17.Text = "₱ " + reader(6).ToString
            Label47.Text = reader(7).ToString + " % Student Discount"
            Label16.Text = reader(8)
            startdate = reader(18)
            c2t1 = startdate.AddMinutes(reader(9))
            Label18.Text = reader(10)
            c2t2 = startdate.AddMinutes(reader(11))
            Label19.Text = reader(12)
            c2t3 = startdate.AddMinutes(reader(13))
            Label20.Text = reader(14)
            c2t4 = startdate.AddMinutes(reader(15))
            Label21.Text = reader(16)
            c2t5 = startdate.AddMinutes(reader(17))
            Panel7.Visible = False
            editc2 = reader(0)
            BunifuThinButton22.Visible = False
        End If
        conn.Close()
        conn.Open()
        comm = New SqlCommand("Select * from Movies Where Date='" & Date.Now.ToString("MMM/dd/yyyy") & "' and Cinema='Cinema 3'", conn)
        reader = comm.ExecuteReader
        If reader.Read = True Then
            Panel7.Visible = False
            Label3.Text = reader(3)
            Label26.Text = reader(4)
            Label24.Text = reader(5)
            Label23.Text = "₱ " + reader(6).ToString
            Label48.Text = reader(7).ToString + " % Student Discount"
            Label22.Text = reader(8)
            startdate = reader(18)
            c3t1 = startdate.AddMinutes(reader(9))
            Label25.Text = reader(10)
            c3t2 = startdate.AddMinutes(reader(11))
            Label27.Text = reader(12)
            c3t3 = startdate.AddMinutes(reader(13))
            Label28.Text = reader(14)
            c3t4 = startdate.AddMinutes(reader(15))
            Label29.Text = reader(16)
            c3t5 = startdate.AddMinutes(reader(17))
            Panel8.Visible = False
            editc3 = reader(0)
            BunifuThinButton23.Visible = False
        End If
        conn.Close()
        conn.Open()
        comm = New SqlCommand("Select * from Movies Where Date='" & Date.Now.ToString("MMM/dd/yyyy") & "' and Cinema='Cinema 4'", conn)
        reader = comm.ExecuteReader
        If reader.Read = True Then
            Panel8.Visible = False
            Label4.Text = reader(3)
            Label31.Text = reader(4)
            Label32.Text = reader(5)
            Label35.Text = "₱ " + reader(6).ToString
            Label49.Text = reader(7).ToString + " % Student Discount"
            Label34.Text = reader(8)
            startdate = reader(18)
            c4t1 = startdate.AddMinutes(reader(9))
            Label30.Text = reader(10)
            c4t2 = startdate.AddMinutes(reader(11))
            Label33.Text = reader(12)
            c4t3 = startdate.AddMinutes(reader(13))
            Label36.Text = reader(14)
            c4t4 = startdate.AddMinutes(reader(15))
            Label37.Text = reader(16)
            c4t5 = startdate.AddMinutes(reader(17))
            Panel9.Visible = False
            editc4 = reader(0)
            BunifuThinButton24.Visible = False
        End If
        conn.Close()
        conn.Open()
        comm = New SqlCommand("Select * from Movies Where Date='" & Date.Now.ToString("MMM/dd/yyyy") & "' and Cinema='Cinema 5'", conn)
        reader = comm.ExecuteReader
        If reader.Read = True Then
            Panel9.Visible = False
            Label5.Text = reader(3)
            Label44.Text = reader(4)
            Label42.Text = reader(5)
            Label38.Text = "₱ " + reader(6).ToString
            Label50.Text = reader(7).ToString + " % Student Discount"
            Label40.Text = reader(8)
            startdate = reader(18)
            c5t1 = startdate.AddMinutes(reader(9))
            Label39.Text = reader(10)
            c5t2 = startdate.AddMinutes(reader(11))
            Label43.Text = reader(12)
            c5t3 = startdate.AddMinutes(reader(13))
            Label41.Text = reader(14)
            c5t4 = startdate.AddMinutes(reader(15))
            Label45.Text = reader(16)
            c5t5 = startdate.AddMinutes(reader(17))
            editc5 = reader(0)
            BunifuThinButton25.Visible = False
        End If
        conn.Close()
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Adminfrm.Enabled = True
        Adminfrm.Show()
        Me.Close()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class