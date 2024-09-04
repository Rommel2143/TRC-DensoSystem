Imports MySql.Data.MySqlClient
Public Class outgoing_report
    Private Sub export_dmtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker.Value = Date.Now
    End Sub
    Sub viewdata()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("SELECT 
                                                d.id,
                                                d.jecoqr, 
                                                d.partno,
                                                d.customerno,
                                                d.color,
                                                d.proddate,
                                                d.qty,
                                                d.serial,
                                                d.cmlqr,
                                                d.userout,
                                                d.dateout,
                                                 d.cmlserial,
                                                   d.shift,
                                                    d.process,
                                                        d.line
                                            FROM 
                                                denso_jeco d
                                    
                                            WHERE
                                                  d.cmlserial = '" & cmb_cml.Text & "'
                                            ORDER BY
                                                    d.serial", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker.ValueChanged
        Try
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT DISTINCT fullname FROM `denso_jeco`
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
            Dim cmdselect As New MySqlCommand("Select distinct ts.`cmlserial` FROM `denso_jeco` ts
                                              Left Join denso_scanoperator tsoout ON ts.userout = tsoout.IDno
                                               
                                                WHERE `dateout`='" & dtpicker.Value.ToString("yyyy-MM-dd") & "' and `fullname`='" & cmbuser.Text & "'", con)
            dr = cmdselect.ExecuteReader
            cmb_cml.Items.Clear()
            While (dr.Read())
                cmb_cml.Items.Add(dr.GetString("cmlserial"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmb_cml_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cml.SelectedIndexChanged
        Dim myrpt As New jeco_crystalreport
        dt.Clear()
        viewdata()
        myrpt.Database.Tables("jeco").SetDataSource(dt)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = myrpt
    End Sub
End Class