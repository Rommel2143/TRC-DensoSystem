Imports MySql.Data.MySqlClient
Public Class export_dmtn
    Private Sub export_dmtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myrpt As New report_dmtn
        dt.Clear()
        viewdata()
        myrpt.Database.Tables("denso_dmtn").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
    Sub viewdata()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("SELECT 
                                                d.id,
                                                d.dmtn, 
                                                d.partno,
                                                d.customerno, 
                                                 d.proddate,
                                                d.qty,
                                                d.serial AS d_serial,
                                                d.cml,
                                                c.serial AS c_serial,
                                                d.userout,
                                                d.dateout,
                                                i.serial AS innertag_serial,
                                                i.proddate AS innertag_proddate,
                                                i.qty AS innertag_qty
                                            FROM 
                                                denso_dmtn d
                                            INNER JOIN 
                                                denso_dmtn_cml c ON d.cml = c.cmlqr
                                            INNER JOIN 
                                                denso_dmtn_innertag i ON d.dmtn = i.fglabel
                                            WHERE
                                                    d.cml = '" & report_cmlqr & "'
                                            ORDER BY
                                                    d_serial", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()

    End Sub
End Class