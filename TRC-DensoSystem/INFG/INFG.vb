Imports MySql.Data.MySqlClient
Public Class INFG

    Private Sub INFG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxshift.Enabled = True
        txtdate.Text = datedb
        sub_mainframe.userstrip.Text = fname
        txtoperator.Text = fname
    End Sub
    Private Sub boxshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxshift.SelectedIndexChanged
        boxtype.Enabled = True
        'con.Close()
        'con.Open()
        'Dim cmd As New MySqlCommand("Select distinct `qrtype` FROM `denso_fg_masterlist`", con)
        'dr = cmd.ExecuteReader
        'boxtype.Items.Clear()
        'While (dr.Read())
        '    boxtype.Items.Add(dr.GetString("qrtype"))
        'End While
        'con.Close()
    End Sub

    Private Sub boxtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxtype.SelectedIndexChanged
        If boxtype.Text = "TDE" Then
            tdeqr.Visible = True
            tdeqr.Enabled = True
            tdeqr.Focus()
            tdepartno.Visible = True
            tdeserial.Visible = True
            tdecustomer.Visible = True
        Else
            tdeqr.Visible = False
            tdepartno.Visible = False
            tdeserial.Visible = False
            tdecustomer.Visible = False
            txtqr.Enabled = True
            txtqr.Focus()
        End If

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim qrlenght As Integer
            Dim qrcode As String = txtqr.Text
            qrlenght = qrcode.Length
            If boxtype.Text = "DMTN" Then
                txtcode.Text = qrcode.Substring(0, 14)
                txtcolor1.Text = qrcode.Substring(0, 17)
                txtqty.Text = qrcode.Substring(14, 3)
                txtlot.Text = qrcode.Substring(qrcode.Length - 12)
                saveupdate()
            ElseIf boxtype.Text = "INTELLI IV" Then
                Select Case qrlenght
                    Case 23
                        txtcode.Text = qrcode.Substring(0, 10)
                        txtcolor1.Text = qrcode.Substring(0, 12)
                        txtqty.Text = qrcode.Substring(10, 2)
                        txtlot.Text = qrcode.Substring(qrcode.Length - 11)
                        saveupdate()
                    Case 26 To 27
                        txtcode.Text = qrcode.Substring(0, 10)
                        txtcolor1.Text = qrcode.Substring(0, 12)
                        txtqty.Text = qrcode.Substring(10, 2)
                        txtlot.Text = qrcode.Substring(qrcode.Length - 12)
                        saveupdate()
                    Case 31
                        txtcode.Text = qrcode.Substring(0, 14)
                        txtcolor1.Text = qrcode.Substring(0, 16)
                        txtqty.Text = qrcode.Substring(14, 2)
                        txtlot.Text = qrcode.Substring(qrcode.Length - 12)
                        saveupdate()
                End Select
            ElseIf boxtype.Text = "20CY" Then
                Select Case qrlenght
                    Case 24 To 28
                        txtcode.Text = qrcode.Substring(0, 10)
                        txtcolor1.Text = qrcode.Substring(0, 12)
                        txtqty.Text = qrcode.Substring(10, 2)
                        txtlot.Text = qrcode.Substring(qrcode.Length - 12)
                        saveupdate()
                    Case 31
                        txtcode.Text = qrcode.Substring(0, 14)
                        txtcolor1.Text = qrcode.Substring(0, 16)
                        txtqty.Text = qrcode.Substring(14, 2)
                        txtlot.Text = qrcode.Substring(qrcode.Length - 12)
                        saveupdate()
                End Select
            ElseIf boxtype.Text = "VT" Then
                txtcode.Text = qrcode.Substring(0, 10)
                txtcolor1.Text = qrcode.Substring(0, 12)
                txtqty.Text = qrcode.Substring(10, 2)
                txtlot.Text = qrcode.Substring(qrcode.Length - 11)
                saveupdate()
            ElseIf boxtype.Text = "2T" Then
                txtcode.Text = qrcode.Substring(0, 10)
                txtcolor1.Text = qrcode.Substring(0, 12)
                txtqty.Text = qrcode.Substring(10, 2)
                txtlot.Text = qrcode.Substring(qrcode.Length - 11)
                saveupdate()




            ElseIf boxtype.Text = "TDE" Then
                If qrcode.Length = 44 Then
                    txtcustomer.Text = qrcode.Substring(0, 13)
                    txtcolor1.Text = qrcode.Substring(0, 27)
                    txtcode.Text = qrcode.Substring(15, 10)
                    txtqty.Text = qrcode.Substring(25, 2)
                    txtlot.Text = qrcode.Substring(qrcode.Length - 13)
                    saveupdate()

                ElseIf qrcode.Length = 43 And qrcode.Substring(27, 3) = "A29" Then
                    txtcustomer.Text = qrcode.Substring(0, 15)
                    txtcolor1.Text = qrcode.Substring(27, 4)
                    txtcode.Text = qrcode.Substring(15, 10)
                    txtqty.Text = qrcode.Substring(25, 2)
                    txtlot.Text = qrcode.Substring(31, 12)
                    saveupdate43()

                ElseIf qrcode.Length = 43 Then
                    txtcustomer.Text = qrcode.Substring(0, 15)
                    txtcolor1.Text = qrcode.Substring(27, 3)
                    txtcode.Text = qrcode.Substring(15, 10)
                    txtqty.Text = qrcode.Substring(25, 2)
                    txtlot.Text = qrcode.Substring(30, 13)
                    saveupdate43()

                ElseIf qrcode.Length = 42 And qrcode.Contains("--") Then
                    txtcustomer.Text = qrcode.Substring(0, 13)
                        txtcolor1.Text = qrcode.Substring(0, 27)
                        txtcode.Text = qrcode.Substring(15, 10)
                        txtqty.Text = qrcode.Substring(25, 2)
                        txtlot.Text = qrcode.Substring(qrcode.Length - 13)
                        saveupdate()
                    Else
                    txtcustomer.Text = qrcode.Substring(0, 13)
                    txtcolor1.Text = qrcode.Substring(0, 27)
                    txtcode.Text = qrcode.Substring(15, 10)
                    txtqty.Text = qrcode.Substring(25, 2)
                    txtlot.Text = qrcode.Substring(qrcode.Length - 12)
                    saveupdate()
                End If

            Else
                labelerror1.Visible = True 'INVALID QR
            End If

            reloadgrid()
            cls()

        End If
    End Sub
    Public Sub cls()
        txtqr.Text = Nothing
        txtqr.Focus()
        txtcustomer.Text = Nothing
        txtproddate.Text = Nothing
        txtcode.Text = Nothing
        txtname.Text = Nothing
        txtqty.Text = Nothing
        txtlot.Text = Nothing
        txtmodel.Text = Nothing
        txthide1.Text = Nothing
        txtcolor.Text = Nothing
        txtcolor1.Text = Nothing
        txthide2.Text = Nothing
        tdeserial.Text = Nothing
        tdepartno.Text = Nothing
        tdeqr.Text = Nothing
        If boxtype.Text = "TDE" Then
            tdeqr.Visible = True
            tdeqr.Enabled = True
            tdeqr.Text = Nothing
            tdeqr.Focus()
            tdepartno.Visible = True
            tdeserial.Visible = True
            tdecustomer.Visible = True
        Else
            tdeqr.Visible = False
            tdepartno.Visible = False
            tdeserial.Visible = False
            tdecustomer.Visible = False
            txtqr.Enabled = True
            txtqr.Focus()
        End If
    End Sub

    Public Sub saveupdate()
        Dim sn As String = txtqr.Text
        Dim fpart As String = txtcolor1.Text
        Dim lpart As String = txtlot.Text
        Dim rpart As String = sn.Replace(fpart, "").Replace(lpart, "")
        txtcolor.Text = rpart
        Dim prodd As String = txtlot.Text
        Dim proddate As String = prodd.Substring(0, 6)
        Dim year As Integer = Integer.Parse(proddate.Substring(0, 2))
        Dim month As Integer = Integer.Parse(proddate.Substring(2, 2))
        Dim day As Integer = Integer.Parse(proddate.Substring(4, 2))
        Dim prodf As New DateTime(2000 + year, month, day)
        txtproddate.Text = prodf.ToString("yyyy-MM-dd")
        Dim ddate As String = prodf.ToString("yyyy-MM-dd")
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("Select * FROM `denso_fg_scan` where `qrcode` = '" & txtqr.Text & "'", con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            labelerror2.Visible = True 'DUPLICATE
        Else
            labelerror2.Visible = False
            con.Close()
            con.Open()
            Dim cmd1 As New MySqlCommand("Select * FROM `denso_fg_masterlist` where `partno` = '" & txtcode.Text & "' and `qrtype`='" & boxtype.Text & "' and `color`='" & txtcolor.Text & "'", con)
            dr = cmd1.ExecuteReader
            If dr.Read = True Then
                labelerror1.Visible = False
                txtcustomer.Text = (dr.GetString("customerno"))
                txtmodel.Text = (dr.GetString("model"))
                txtname.Text = (dr.GetString("partname"))
                txthide1.Text = (dr.GetInt32("qty"))
                ' txthide2.Text = (dr.GetString("color"))
                Dim x As Integer
                x = Val(txthide1.Text)
                con.Close()
                updates("Update `denso_fg_masterlist` set `qty`='" & Val(txtqty.Text) + x & "' where `partno` = '" & txtcode.Text & "' and `qrtype`='" & boxtype.Text & "' and `color`='" & txtcolor.Text & "'")
                '  updates("Update `denso_fg_masterlist` set `qty`='" & Val(txtqty.Text) + x & "' where `partno` = '" & txtcode.Text & "' and `qrtype`='" & boxtype.Text & "' and `customerno`='" & txtcustomer.Text & "'and `color`='" & txtcolor.Text & "'")
                con.Close()
                insertitem("Insert into `denso_fg_scan` (`status`,`datein`,`shift`,`operator`,`type`,`qrcode`,`partno`,`customerno`,`model`,`color`,`quantity`,`lotnumber`,`proddate`,`serial`,`qrtde`)
                                    values ('" & txthide.Text & "','" & datedb & "','" & boxshift.Text & "','" & txtoperator.Text & "','" & boxtype.Text & "','" & txtqr.Text & "','" & txtcode.Text & "','" & txtcustomer.Text & "','" & txtmodel.Text & "','" & txtcolor.Text & "','" & txtqty.Text & "','" & txtlot.Text & "','" & ddate & "','" & tdeserial.Text & "','" & tdeqr.Text & "')")
                txtqty.Text = Nothing
            Else
                labelerror1.Visible = True

            End If

        End If
    End Sub

    Public Sub saveupdate43()
        Dim sn As String = txtqr.Text
        Dim fpart As String = txtcolor1.Text
        Dim lpart As String = txtlot.Text
        Dim rpart As String = sn.Replace(fpart, "").Replace(lpart, "")
        txtcolor.Text = rpart
        Dim prodd As String = txtlot.Text
        Dim proddate As String = prodd.Substring(0, 6)
        Dim year As Integer = Integer.Parse(proddate.Substring(0, 2))
        Dim month As Integer = Integer.Parse(proddate.Substring(2, 2))
        Dim day As Integer = Integer.Parse(proddate.Substring(4, 2))
        Dim prodf As New DateTime(2000 + year, month, day)
        txtproddate.Text = prodf.ToString("yyyy-MM-dd")
        Dim ddate As String = prodf.ToString("yyyy-MM-dd")
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("Select * FROM `denso_fg_scan` where `qrcode` = '" & txtqr.Text & "'", con)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            labelerror2.Visible = True 'DUPLICATE
        Else
            labelerror2.Visible = False
            con.Close()
            con.Open()
            Dim cmd1 As New MySqlCommand("Select * FROM `denso_fg_masterlist` where `partno` = '" & txtcode.Text & "' and `qrtype`='" & boxtype.Text & "' and `color`='" & txtcolor1.Text & "'", con)
            dr = cmd1.ExecuteReader
            If dr.Read = True Then
                labelerror1.Visible = False
                txtcustomer.Text = (dr.GetString("customerno"))
                txtmodel.Text = (dr.GetString("model"))
                txtname.Text = (dr.GetString("partname"))
                txthide1.Text = (dr.GetInt32("qty"))
                ' txthide2.Text = (dr.GetString("color"))
                Dim x As Integer
                x = Val(txthide1.Text)
                con.Close()
                updates("Update `denso_fg_masterlist` set `qty`='" & Val(txtqty.Text) + x & "' where `partno` = '" & txtcode.Text & "' and `qrtype`='" & boxtype.Text & "' and `color`='" & txtcolor1.Text & "'")
                '  updates("Update `denso_fg_masterlist` set `qty`='" & Val(txtqty.Text) + x & "' where `partno` = '" & txtcode.Text & "' and `qrtype`='" & boxtype.Text & "' and `customerno`='" & txtcustomer.Text & "'and `color`='" & txtcolor.Text & "'")
                con.Close()
                insertitem("Insert into `denso_fg_scan` (`status`,`datein`,`shift`,`operator`,`type`,`qrcode`,`partno`,`customerno`,`model`,`color`,`quantity`,`lotnumber`,`proddate`,`serial`,`qrtde`)
                                    values ('" & txthide.Text & "','" & datedb & "','" & boxshift.Text & "','" & txtoperator.Text & "','" & boxtype.Text & "','" & txtqr.Text & "','" & txtcode.Text & "','" & txtcustomer.Text & "','" & txtmodel.Text & "','" & txtcolor1.Text & "','" & txtqty.Text & "','" & txtlot.Text & "','" & ddate & "','" & tdeserial.Text & "','" & tdeqr.Text & "')")
                txtqty.Text = Nothing
            Else
                labelerror1.Visible = True

            End If

        End If
    End Sub
    Public Sub reloadgrid()
        Try
            reload("Select * FROM `denso_fg_scan` where `datein` = '" & txtdate.Text & "' and `shift`='" & boxshift.Text & "' and `type`='" & boxtype.Text & "'", datagrid1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub tdeqr_KeyDown(sender As Object, e As KeyEventArgs) Handles tdeqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim tdeqrcode As String = tdeqr.Text
            tdecustomer.Text = tdeqrcode.Substring(96, 13)
            tdeserial.Text = tdeqrcode.Substring(154, 7)
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("Select * FROM `denso_fg_scan` where `qrtde` = '" & tdeqr.Text & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                labelerror2.Visible = True 'DUPLICATE
            Else
                labelerror2.Visible = False
                con.Close()
                con.Open()
                Dim cmd2 As New MySqlCommand("Select * FROM `denso_fg_scan` where `customerno` = '" & tdecustomer.Text & "' and `serial` = '" & tdeserial.Text & "' and `type` = '" & boxtype.Text & "'", con)
                dr = cmd2.ExecuteReader
                If dr.Read = True Then
                    labelerror2.Visible = True 'DUPLICATE
                Else
                    con.Close()
                    con.Open()
                    Dim cmd1 As New MySqlCommand("Select * FROM `denso_fg_masterlist` where `customerno` = '" & tdecustomer.Text & "' and `qrtype`='" & boxtype.Text & "'", con)
                    dr = cmd1.ExecuteReader
                    labelerror2.Visible = False
                    If dr.Read = True Then
                        tdepartno.Text = (dr.GetString("partno"))
                        txtqr.Text = Nothing
                        txtqr.Enabled = True
                        txtqr.Focus()
                    Else
                        labelerror1.Visible = True
                    End If

                End If
            End If

        End If
    End Sub

    Private Sub cmbsearch_TextChanged(sender As Object, e As EventArgs) Handles cmbsearch.TextChanged
        Try
            reload("Select * FROM `denso_fg_scan` where `datein` = '" & txtdate.Text & "' and `shift`='" & boxshift.Text & "' and `type`='" & boxtype.Text & "' and `customerno` REGEXP '" & cmbsearch.Text & "'", datagrid1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub tdeqr_TextChanged(sender As Object, e As EventArgs) Handles tdeqr.TextChanged

    End Sub

    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub
End Class