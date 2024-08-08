Imports MySql.Data.MySqlClient
Public Class REPORT_TDE
    Private Sub REPORT_TDE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("Select distinct `dateout` FROM `denso_fg_scan` WHERE `status`='OUT' ", con)
        dr = cmd.ExecuteReader
        boxdate.Items.Clear()
        While (dr.Read())

            Dim dateout As DateTime = dr.GetDateTime("dateout")
            boxdate.Items.Add(dateout.ToString("yyyy-MM-dd"))
        End While
        con.Close()

    End Sub
    Sub viewdata()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("Select `id`, `status`, `datein`, `shift`, `operator`, `type`, `qrcode`, `partno`, `customerno`, `model`, `color`, `quantity`, `lotnumber`, `proddate`, `dateout`, `serial`, `qrtde`, `cml`,`operatorout`,`shiftout` from denso_fg_scan where dateout='" & boxdate.Text & "' and `type`='TDE' and shiftout = '" & cmb_shift.Text & "'", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()

    End Sub

    Private Sub boxdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxdate.SelectedIndexChanged

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_shift.SelectedIndexChanged
        Dim myrpt As New OUT_TDE
        dt.Clear()
        viewdata()
        myrpt.Database.Tables("denso_fg_scan").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
End Class