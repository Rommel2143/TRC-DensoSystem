Imports MySql.Data.MySqlClient
Public Class INFG
    Private Sub INFG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxshift.Enabled = True
        txtdate.Text = datedb
        sub_FRAME.userstrip.Text = fname
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
        con.Close()
    End Sub

    Private Sub boxtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxtype.SelectedIndexChanged
        txtqr.Enabled = True
        txtqr.Focus()

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim qrlenght As Integer
            Dim qrcode As String = txtqr.Text

            If boxtype.Text = "DMTN" Then
                txtcode.Text = qrcode.Substring(0, 14)
                txtcolor1.Text = qrcode.Substring(0, 17)
                txtqty.Text = qrcode.Substring(14, 3)
                txtlot.Text = qrcode.Substring(qrcode.Length - 12)
                colorcode()
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
                    Dim cmd1 As New MySqlCommand("Select * FROM `denso_fg_masterlist` where `partno` = '" & txtcode.Text & "' and `qrtype`='" & boxtype.Text & "'", con)
                    dr = cmd1.ExecuteReader
                    If dr.Read = True Then
                        labelerror1.Visible = False
                        txtcustomer.Text = (dr.GetString("customerno"))
                        txtmodel.Text = (dr.GetString("model"))
                        txtname.Text = (dr.GetString("partname"))
                        txthide1.Text = (dr.GetInt32("qty"))
                        Dim x As Integer
                        x = Val(txthide1.Text)
                        con.Close()
                        updates("Update `denso_fg_masterlist` set `qty`='" & Val(txtqty.Text) + x & "' where `partno` = '" & txtcode.Text & "' and `qrtype`='" & boxtype.Text & "' and `customerno`='" & txtcustomer.Text & "'")
                        con.Close()
                        insertitem("Insert into `denso_fg_scan` (`status`,`datein`,`shift`,`operator`,`type`,`qrcode`,`partno`,`customerno`,`model`,`color`,`quantity`,`lotnumber`,`proddate`)
                                    values ('" & txthide.Text & "','" & datedb & "','" & boxshift.Text & "','" & txtoperator.Text & "','" & boxtype.Text & "','" & txtqr.Text & "','" & txtcode.Text & "','" & txtcustomer.Text & "','" & txtmodel.Text & "','" & txtcolor.Text & "','" & txtqty.Text & "','" & txtlot.Text & "','" & ddate & "')")
                    Else
                        labelerror1.Visible = True

                    End If

                End If
            ElseIf boxtype.Text = "INTELLI IV" Then
                qrlenght = qrcode.Length

                Select Case qrlenght
                    Case 23
                        txtcode.Text = qrcode.Substring(0, 10)
                        txtcolor1.Text = qrcode.Substring(0, 12)
                        txtqty.Text = qrcode.Substring(10, 2)
                        txtlot.Text = qrcode.Substring(qrcode.Length - 11)
                        colorcode()
                    Case 26
                        txtcode.Text = qrcode.Substring(0, 10)
                        txtcolor1.Text = qrcode.Substring(0, 12)
                        txtqty.Text = qrcode.Substring(10, 2)
                        txtlot.Text = qrcode.Substring(qrcode.Length - 12)
                        colorcode()
                    Case 27
                        txtcode.Text = qrcode.Substring(0, 10)
                        txtcolor1.Text = qrcode.Substring(0, 12)
                        txtqty.Text = qrcode.Substring(10, 2)
                        txtlot.Text = qrcode.Substring(qrcode.Length - 12)
                        colorcode()
                    Case 31
                        txtcode.Text = qrcode.Substring(0, 14)
                        txtcolor1.Text = qrcode.Substring(0, 16)
                        txtqty.Text = qrcode.Substring(14, 2)
                        txtlot.Text = qrcode.Substring(qrcode.Length - 12)
                        colorcode()

                End Select


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
    End Sub
    Public Sub colorcode()
        Dim sn As String = txtqr.Text
        Dim fpart As String = txtcolor1.Text
        Dim lpart As String = txtlot.Text
        Dim rpart As String = sn.Replace(fpart, "").Replace(lpart, "")
        txtcolor.Text = rpart



    End Sub
    Public Sub reloadgrid()
        Try
            reload("Select * FROM `denso_fg_scan` where `datein` = '" & txtdate.Text & "' and `shift`='" & boxshift.Text & "' and `type`='" & boxtype.Text & "'", datagrid1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtlot_TextChanged(sender As Object, e As EventArgs) Handles txtlot.TextChanged

    End Sub
    Public Sub save1()

    End Sub

    Private Sub txtcolor_TextChanged(sender As Object, e As EventArgs) Handles txtcolor.TextChanged

    End Sub
End Class