Imports MySql.Data.MySqlClient
Public Class export_dmtn
    Dim radio As Integer = 0
    Private Sub export_dmtn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpicker.Value = Date.Now
    End Sub
    Sub viewdata_with()
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
                                                c.userout,
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
                                                    d_serial ASC", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rad_w.CheckedChanged
        radio = 1

    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rad_wo.CheckedChanged
        radio = 0

    End Sub
    Private Sub cmb_cml_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_cml.SelectedIndexChanged, rad_w.CheckedChanged, rad_wo.CheckedChanged
        Try
            If cmb_cml.Text = "" Then

            Else
                Select Case radio
                    Case 1

                        con.Close()
                        con.Open()
                        Dim cmdselect As New MySqlCommand("SELECT `cmlqr`,`serial` FROM `denso_dmtn_cml` WHERE serial='" & cmb_cml.Text & "'", con)
                        dr = cmdselect.ExecuteReader
                        If dr.Read Then
                            report_cmlqr = dr.GetString("cmlqr")
                        End If
                        Dim myrpt As New report_dmtn_innertag
                        dt.Clear()
                        viewdata_with()
                        myrpt.Database.Tables("denso_dmtn").SetDataSource(dt)
                        CrystalReportViewer1.ReportSource = Nothing
                        CrystalReportViewer1.ReportSource = myrpt
                    Case 0
                        Dim myrpt As New dmtn_bypass
                        dt.Clear()
                        viewdata_without()
                        myrpt.Database.Tables("denso_dmtn_bypass").SetDataSource(dt)
                        CrystalReportViewer1.ReportSource = Nothing
                        CrystalReportViewer1.ReportSource = myrpt
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub viewdata_without()
        con.Close()
        con.Open()
        Dim showreport As New MySqlCommand("SELECT 
                                                d.id,
                                                d.dmtn, 
                                                d.partno,
                                                d.customerno,
                                                d.color,
                                                 d.proddate,
                                                d.qty,
                                                d.cml,
                                                ddc.userout,
                                                d.dateout,
                                                d.serial,
                                                ddc.serial AS cmlserial,
                                                d.shift,
                                                d.process,
                                                d.line
                                            FROM 
                                                denso_dmtn d
                                            JOIN denso_dmtn_cml ddc ON d.cml=ddc.cmlqr
                                            WHERE
                                                    ddc.serial = '" & cmb_cml.Text & "'
                                            ORDER BY
                                                    d.serial", con)
        Dim da As New MySqlDataAdapter(showreport)
        da.Fill(dt)
        con.Close()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dtpicker_ValueChanged(sender As Object, e As EventArgs) Handles dtpicker.ValueChanged
        Try
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT serial FROM `denso_dmtn_cml`
                                                WHERE `dateout`='" & dtpicker.Value.ToString("yyyy-MM-dd") & "'", con)
            dr = cmdselect.ExecuteReader
            cmb_cml.Items.Clear()
            While (dr.Read())
                cmb_cml.Items.Add(dr.GetString("serial"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class