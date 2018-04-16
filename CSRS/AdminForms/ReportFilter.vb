Imports System.Data.SqlClient

Public Class ReportFilter
    Dim constr As String = "Data Source=DESKTOP-7B5SP0J\SQLEXPRESS;Initial Catalog=CGL.RME;Integrated Security=True"
    Dim conn As New SqlConnection
    Dim comm As New SqlCommand
    Dim reader As SqlDataReader

    Private Sub ReportFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = constr
        conn.Open()
        comm = New SqlCommand("Select * From SalesReport Where")
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click, BunifuFlatButton2.Click

    End Sub
End Class