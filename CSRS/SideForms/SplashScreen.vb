Public Class Splashscreen


    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent)
        'If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
        '    Loginfrm.Show()
        '    Me.Hide()
        'End If
    End Sub

    Private Sub Splashscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1
            Label1.Text += 1
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        If Label1.Text = 50 Then
            Label1.BackColor = Color.Black
            Label1.ForeColor = Color.White

        End If
    End Sub



   
    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
