Imports MySql.Data.MySqlClient
Public Class OUTFG_TDE
    Private Sub OUTFG_TDE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxshift.Enabled = True
        txtdate.Text = datedb
        sub_FRAME.userstrip.Text = fname
        txtoperator.Text = fname
        '   delete("Delete FROM `denso_temp`")

    End Sub
    Private Sub boxshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxshift.SelectedIndexChanged
        tdeqr.Enabled = True
        tdeqr.Focus()

    End Sub

    Private Sub tdeqr_KeyDown(sender As Object, e As KeyEventArgs) Handles tdeqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("Select * FROM `denso_fg_scan` where `status`='IN' and `qrtde`= '" & tdeqr.Text & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                labelerror1.Visible = False
                Dim tdeqrcode As String = tdeqr.Text
                tdecustomer.Text = tdeqrcode.Substring(96, 13)
                tdeserial.Text = tdeqrcode.Substring(154, 7)
                txtqr.Text = Nothing
                txtqr.Enabled = True
                txtqr.Focus()
            Else
                labelerror1.Visible = True
            End If
        End If
    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("Select * FROM `denso_fg_scan` where `qrcode` = '" & txtqr.Text & "' and `status`='IN' and `qrtde` = '" & tdeqr.Text & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                labelerror1.Visible = False
                Dim qrcode As String = txtqr.Text
                txtcode.Text = qrcode.Substring(15, 10)
                txtqty.Text = qrcode.Substring(25, 2)
                con.Close()
                con.Open()
                Dim cmd1 As New MySqlCommand("Select * FROM `denso_temp` where `tdeqr` = '" & tdeqr.Text & "' and `qr` = '" & txtqr.Text & "'", con)
                dr = cmd1.ExecuteReader
                If dr.Read = True Then
                    labelerror2.Visible = True
                Else
                    labelerror2.Visible = False
                    con.Close()
                    con.Open()
                    Dim cmd3 As New MySqlCommand("Select * from `denso_temp` where `tdeqr` = '" & tdeqr.Text & "'", con)
                    dr = cmd3.ExecuteReader
                    If dr.Read = True Then
                        labelerror2.Visible = True
                    Else
                        labelerror2.Visible = False
                        con.Close()
                        con.Open()
                        Dim cmd4 As New MySqlCommand("Select * from `denso_temp`", con)
                        dr = cmd4.ExecuteReader
                        If dr.Read = True Then
                            Dim x As String = dr("partno").ToString
                            Dim y As String = dr("customerno").ToString
                            If x = txtcode.Text And y = tdecustomer.Text Then
                                labelerror1.Visible = False
                                insertitem("Insert into `denso_temp` (`tdeqr`,`qr`,`partno`,`customerno`,`serial`,`qty`)
                                    values ('" & tdeqr.Text & "','" & txtqr.Text & "','" & txtcode.Text & "','" & tdecustomer.Text & "','" & tdeserial.Text & "','" & txtqty.Text & "')")
                            Else
                                labelerror1.Visible = True
                            End If
                        Else
                            insertitem("Insert into `denso_temp` (`tdeqr`,`qr`,`partno`,`customerno`,`serial`,`qty`)
                                    values ('" & tdeqr.Text & "','" & txtqr.Text & "','" & txtcode.Text & "','" & tdecustomer.Text & "','" & tdeserial.Text & "','" & txtqty.Text & "')")

                        End If
                        reloadgrid()
                        cls()
                        con.Close()
                        con.Open()
                        Dim cmd2 As New MySqlCommand("Select Count(qr) as totalcount FROM `denso_temp`", con)
                        dr = cmd2.ExecuteReader
                        If dr.Read = True Then
                            txtcount.Text = dr("totalcount").ToString
                            If txtcount.Text = 6 Then
                                txtcml1.Enabled = True
                                txtcml1.Focus()
                            End If
                        End If
                    End If
                End If
            Else
                labelerror1.Visible = True
            End If
        End If

    End Sub
    Public Sub cls()
        tdeqr.Text = Nothing
        tdeqr.Focus()
        txtqr.Text = Nothing
        txtcode.Text = Nothing
        tdeserial.Text = Nothing
        tdecustomer.Text = Nothing
        txtqty.Text = Nothing
    End Sub
    Public Sub reloadgrid()
        Try
            reload("SELECT * FROM `denso_temp`", datagrid2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub reloadgrid1()
        Try
            reload("Select * FROM `denso_fg_scan` where `dateout` = '" & txtdate.Text & "' and `shift`='" & boxshift.Text & "' and `type`='" & Guna2TextBox1.Text & "'", datagrid3)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtcml1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcml1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcml2.Enabled = True
            txtcml2.Focus()
        End If
    End Sub

    Private Sub txtcml2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcml2.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtcml3.Enabled = True
            txtcml3.Focus()
        End If
    End Sub

    Private Sub txtcml3_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcml3.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtcml1.Text = txtcml2.Text And txtcml1.Text = txtcml3.Text Then
                labelerror3.Visible = False
                Dim x As Integer
                x = 0
                For Each row As DataGridViewRow In datagrid2.Rows
                    con.Close()
                    con.Open()
                    Dim cmd2 As New MySqlCommand("Select * FROM `denso_fg_masterlist` where `partno`= '" & datagrid2.Rows(x).Cells(3).Value.ToString() & "' and `customerno`= '" & datagrid2.Rows(x).Cells(4).Value.ToString() & "' and `qrtype`='TDE'", con)
                    dr = cmd2.ExecuteReader
                    If dr.Read = True Then
                        Dim a As Integer
                        a = dr("qty").ToString
                        con.Close()
                        updates("Update `denso_fg_masterlist` set `qty` ='" & a - datagrid2.Rows(x).Cells(6).Value.ToString() & "' where `partno`= '" & datagrid2.Rows(x).Cells(3).Value.ToString() & "' and `customerno`= '" & datagrid2.Rows(x).Cells(4).Value.ToString() & "' and `qrtype`='TDE'")
                    End If
                    con.Close()
                    updates("Update `denso_fg_scan` set `status` ='" & txthide3.Text & "' , `dateout` = '" & datedb & "', `cml`='" & txtcml1.Text & "' where `qrtde`= '" & datagrid2.Rows(x).Cells(1).Value.ToString() & "'")
                    x = x + 1


                Next
                reloadgrid1()
                delete("Delete FROM `denso_temp`")
                reloadgrid()
                con.Close()
            Else
                labelerror3.Visible = True
            End If
        End If
    End Sub
End Class