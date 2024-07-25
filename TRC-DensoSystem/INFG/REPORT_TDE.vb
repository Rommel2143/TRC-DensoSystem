Imports MySql.Data.MySqlClient
Public Class REPORT_TDE
    Private Sub REPORT_TDE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myrpt As New report_dmtn
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("Select distinct `dateout` FROM `denso_fg_scan`", con)
        dr = cmd.ExecuteReader
        boxdate.Items.Clear()
        While (dr.Read())
            boxdate.Items.Add(dr.GetString("dateout"))
        End While
        con.Close()
        dt.Clear()
        viewdata()
        myrpt.Database.Tables("denso_fg_scan").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
    Sub viewdata()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("Select * from denso_fg_scan where dateout='" & boxdate.Text & "'", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()

    End Sub
End Class