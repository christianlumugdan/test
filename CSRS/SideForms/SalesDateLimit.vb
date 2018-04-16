Public Class SalesDateLimit

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        If BunifuDatepicker2.Value < BunifuDatepicker1.Value Then
            MsgBox("Invalid Filter")
        Else
            If limit = "Movie" Then
                MoviesReport.Show()
                Me.Hide()
            ElseIf limit = "Sales" Then
                SalesReport.Show()
            End If

        End If
       
    End Sub
End Class