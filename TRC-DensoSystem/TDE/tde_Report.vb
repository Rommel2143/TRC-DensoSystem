Imports MySql.Data.MySqlClient
Public Class tde_Report
    Private Sub tde_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker.Value = Date.Now
    End Sub
    Private Sub dtpicker_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker.ValueChanged
        Try
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT DISTINCT fullname FROM `denso_tde`
                                                INNER JOIN `denso_scanoperator` ON `userout` = `IDno`
                                                WHERE `dateout`='" & dtpicker.Value.ToString("yyyy-MM-dd") & "'", con)
            dr = cmdselect.ExecuteReader
            cmbuser.Items.Clear()
            While (dr.Read())
                cmbuser.Items.Add(dr.GetString("fullname"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbuser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbuser.SelectedIndexChanged
        Try
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("Select distinct ts.`cml_serial` FROM `denso_tde` ts
                                              Left Join denso_scanoperator tsoout ON ts.userout = tsoout.IDno
                                               
                                                WHERE `dateout`='" & dtpicker.Value.ToString("yyyy-MM-dd") & "' and `fullname`='" & cmbuser.Text & "'", con)
            dr = cmdselect.ExecuteReader
            cmb_cml.Items.Clear()
            While (dr.Read())
                cmb_cml.Items.Add(dr.GetString("cml_serial"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmb_cml_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cml.SelectedIndexChanged
        Dim myrpt As New tdereport
        dt.Clear()
        viewdata()
        myrpt.Database.Tables("TDE").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub

    Sub viewdata()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("SELECT 
                                                d.id,
                                                d.tdeqr, 
                                                d.partno,
                                                d.customerno,
                                                d.color,
                                                d.proddate,
                                                d.qty,
                                                d.serial,
                                                d.cml,
                                                d.userout,
                                                d.dateout,
                                                 d.cml_serial,
                                                   d.shift,
                                                    d.process,
                                                        d.line,
                                                        d.customer_qr
                                            FROM 
                                                denso_tde d
                                    
                                            WHERE
                                                  d.cml_serial = '" & cmb_cml.Text & "'
                                            ORDER BY
                                                    d.serial", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class