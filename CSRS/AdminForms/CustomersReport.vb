Imports Microsoft.Reporting.WinForms
Public Class CustomersReport

    Private Sub CustomersReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CGL_RMEDataSet2.Customers' table. You can move, or remove it, as needed.
        Dim testParam As New ReportParameter("demoParameter", aname)
        ReportViewer1.LocalReport.SetParameters(testParam)
        Me.CustomersTableAdapter.Fill(Me.CGL_RMEDataSet2.Customers)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Adminfrm.Show()
        Adminfrm.Enabled = True
        Me.Close()
    End Sub
End Class