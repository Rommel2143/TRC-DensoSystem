Imports MySql.Data.MySqlClient
Public Class retainer_20cy_report
    Private Sub export_dmtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub viewdata()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("SELECT 
                                                d.id,
                                                d.cyqr, 
                                                d.partno,
                                                d.customerno,
                                                d.color,
                                                d.proddate,
                                                d.qty,
                                                d.serial,
                                                d.batchcode,
                                                d.userout,
                                                d.dateout
                                             
                                            FROM 
                                                denso_20cy d
                                            JOIN denso_scanoperator ds ON ds.IDno = d.userout
                                            WHERE
                                                  d.batchcode = '" & cmb_cml.Text & "' and d.dateout ='" & dtpicker.Value.ToString("yyyy-MM-dd") & "' and ds.fullname = '" & cmbuser.Text & "'
                                            ORDER BY
                                                    d.serial", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()

    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker.ValueChanged
        Try
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT DISTINCT fullname FROM `denso_20cy`
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
            Dim cmdselect As New MySqlCommand("Select distinct ts.`batchcode` FROM `denso_20cy` ts
                                              Left Join denso_scanoperator tsoout ON ts.userout = tsoout.IDno
                                               
                                                WHERE `dateout`='" & dtpicker.Value.ToString("yyyy-MM-dd") & "' and `fullname`='" & cmbuser.Text & "'", con)
            dr = cmdselect.ExecuteReader
            cmb_cml.Items.Clear()
            While (dr.Read())
                cmb_cml.Items.Add(dr.GetString("batchcode"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmb_cml_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cml.SelectedIndexChanged
        Dim myrpt As New retainer_20cy_rpt
        dt.Clear()
        viewdata()
        myrpt.Database.Tables("20cy").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
End Class