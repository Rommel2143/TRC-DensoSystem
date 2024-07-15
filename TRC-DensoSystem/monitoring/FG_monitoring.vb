Imports MySql.Data.MySqlClient
Public Class FG_monitoring
    Private Sub stock_monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshgrid()

    End Sub
    Private Sub refreshgrid()
        Try
            con.Close()
            con.Open()
            Dim cmdrefreshgrid As New MySqlCommand("SELECT `partno`, `customerno`, `partname`, `model`, `color`, `qrtype`, `qty` FROM `denso_fg_masterlist`", con)

            Dim da As New MySqlDataAdapter(cmdrefreshgrid)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        refreshgrid()
    End Sub
End Class