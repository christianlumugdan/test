Public Class NoBalance
    Dim cnt As String
    Private Sub InputFields_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.9
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cnt += 1
        If cnt = 6 Then
            Me.Close()
            cnt = 0
        End If
    End Sub
End Class