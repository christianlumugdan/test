Imports Microsoft.Reporting.WinForms

Public Class SalesReport

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim testParam As New ReportParameter("demoParameter", aname)
        ReportViewer1.LocalReport.SetParameters(testParam)
        'TODO: This line of code loads data into the 'CGL_RMEDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Time(Me.CGL_RMEDataSet.Sales, SalesDateLimit.BunifuDatepicker1.Value, SalesDateLimit.BunifuDatepicker2.Value)
       

        'TODO: This line of code loads data into the 'CGL_RMEDataSet.Sales' table. You can move, or remove it, as needed.
     
        Me.ReportViewer1.RefreshReport()
       
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Adminfrm.Enabled = True
        Adminfrm.Show()
        Me.Close()
    End Sub

    Private Sub header_Paint(sender As Object, e As PaintEventArgs) Handles header.Paint

    End Sub
End Class