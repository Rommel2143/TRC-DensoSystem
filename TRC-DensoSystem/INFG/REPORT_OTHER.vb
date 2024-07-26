Imports MySql.Data.MySqlClient
Public Class REPORT_OTHER
    Private Sub REPORT_OTHER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("Select distinct `qrtype` FROM `denso_fg_masterlist`", con)
        dr = cmd.ExecuteReader
        boxtype.Items.Clear()
        While (dr.Read())
            boxtype.Items.Add(dr.GetString("qrtype"))
        End While
        con.Close()
    End Sub

    Private Sub boxtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxtype.SelectedIndexChanged
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("Select distinct `dateout` FROM `denso_fg_scan` WHERE `type`='" & boxtype.Text & "' and `status`='OUT'", con)
        dr = cmd.ExecuteReader
        boxdate.Items.Clear()
        While (dr.Read())

            Dim dateout As DateTime = dr.GetDateTime("dateout")
            boxdate.Items.Add(dateout.ToString("yyyy-MM-dd"))
        End While
        con.Close()
    End Sub

    Private Sub boxdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxdate.SelectedIndexChanged
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("Select distinct `shiftout` FROM `denso_fg_scan` WHERE `type`='" & boxtype.Text & "' and `status`='OUT' and `dateout`='" & boxdate.Text & "'", con)
        dr = cmd.ExecuteReader
        boxshift.Items.Clear()
        While (dr.Read())
            boxshift.Items.Add(dr.GetString("shiftout"))
        End While
        con.Close()
    End Sub
    Sub viewdata()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("Select `id`, `status`, `datein`, `shift`, `operator`, `type`, `qrcode`, `partno`, `customerno`, `model`, `color`, `quantity`, `lotnumber`, `proddate`, `dateout`, `serial`, `qrtde`, `cml`,`operatorout`,`shiftout` from denso_fg_scan where dateout='" & boxdate.Text & "' and `type`='" & boxtype.Text & "'and `shiftout`='" & boxshift.Text & "'", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()

    End Sub

    Private Sub boxshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxshift.SelectedIndexChanged
        Dim myrpt As New OUT_OTHER
        dt.Clear()
        viewdata()
        myrpt.Database.Tables("denso_fg_scan").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
End Class