﻿Public Class SuccessfulFrm
    Dim cnt As Integer
    Private Sub SuccessfulFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.9
        cnt = 0
        Me.TopMost = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cnt += 1
        If cnt = 2 Then
            Me.Close()
            Admin_AddCustomer.Close()
            Adminfrm.Enabled = True
            Adminfrm.Show()
            Adminfrm.TopMost = True
            cnt = 0
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class