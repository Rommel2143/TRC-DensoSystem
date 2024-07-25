Imports MySql.Data.MySqlClient
Public Class OUTFG_OTHER

    Private Sub OUTFG_OTHER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxshift.Enabled = True
        txtdate.Text = datedb
        sub_mainframe.userstrip.Text = fname
        txtoperator.Text = fname
    End Sub

    Private Sub boxshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxshift.SelectedIndexChanged
        boxtype.Enabled = True
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("Select distinct `qrtype` FROM `denso_fg_masterlist`", con)
        dr = cmd.ExecuteReader
        boxtype.Items.Clear()
        While (dr.Read())
            boxtype.Items.Add(dr.GetString("qrtype"))
        End While
        txtqr1.Enabled = True
        txtqr1.Focus()
        con.Close()
    End Sub

    Private Sub txtqr1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtqr2.Enabled = True
            txtqr2.Focus()
        End If
    End Sub

    Private Sub txtqr2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtqr1.Text = txtqr2.Text Then
                labelerror1.Visible = False
                con.Close()
                con.Open()
                Dim cmd As New MySqlCommand("Select * FROM `denso_fg_scan` where `qrcode` = '" & txtqr1.Text & "' and `status`='IN'", con)
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    labelerror1.Visible = False
                    txtcustomer.Text = dr("customerno").ToString
                    txtcode.Text = dr("partno").ToString
                    txtqty.Text = dr("quantity").ToString
                    txtlot.Text = dr("lotnumber").ToString
                    txtmodel.Text = dr("model").ToString
                    txtcolor.Text = dr("color").ToString
                    con.Close()
                    con.Open()
                    Dim cmd1 As New MySqlCommand("Select * FROM `denso_fg_masterlist` where `partno`= '" & txtcode.Text & "' and `qrtype`='" & boxtype.Text & "' and `color`='" & txtcolor.Text & "'", con)
                    dr = cmd1.ExecuteReader
                    If dr.Read = True Then
                        Dim a As Integer
                        a = dr("qty").ToString
                        con.Close()
                        updates("Update `denso_fg_masterlist` set `qty` ='" & a - Val(txtqty.Text) & "' where `partno`= '" & txtcode.Text & "' and `qrtype`='" & boxtype.Text & "' and `color`='" & txtcolor.Text & "'")
                        con.Close()
                        updates("Update `denso_fg_scan` set `status` ='" & txthide.Text & "' , `dateout` = '" & datedb & "' where `qrcode` = '" & txtqr1.Text & "'")

                    End If
                Else
                    labelerror1.Visible = True
                End If
            Else
                labelerror1.Visible = True
            End If
            cls()
            reloadgrid()
        End If
    End Sub
    Public Sub cls()
        txtqr1.Text = Nothing
        txtqr2.Text = Nothing
        txtcustomer.Text = Nothing
        txtcode.Text = Nothing
        txtname.Text = Nothing
        txtqty.Text = Nothing
        txtlot.Text = Nothing
        txtmodel.Text = Nothing
        txtcolor.Text = Nothing
        txtqr1.Focus()
    End Sub
    Public Sub reloadgrid()
        Try
            reload("Select * FROM `denso_fg_scan` where `dateout` = '" & txtdate.Text & "' and `type`='" & boxtype.Text & "'", datagrid1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class