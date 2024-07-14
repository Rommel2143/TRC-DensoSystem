Imports MySql.Data.MySqlClient

Public Class Add_item


    Private Sub processQRcodeVT()
        Try
            Dim serialNumber As String = fg_txtqr.Text

            ' Extract parts based on fixed positions
            Dim partNumber As String = serialNumber.Substring(0, 10)
            Dim quantity As String = serialNumber.Substring(10, 2)
            Dim colorcode As String = serialNumber.Substring(12, 3)


            Dim qrlenght As String = serialNumber.Length


            txt_partno.Text = partNumber
            txt_color.Text = colorcode
            txt_qrlenght.Text = qrlenght.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub processQRcode2T()
        Try
            Dim serialNumber As String = fg_txtqr.Text

            ' Extract parts based on fixed positions
            Dim partNumber As String = serialNumber.Substring(0, 10)
            Dim quantity As String = serialNumber.Substring(10, 2)
            Dim colorcode As String = serialNumber.Substring(12, 3)


            Dim qrlenght As String = serialNumber.Length


            txt_partno.Text = partNumber
            txt_color.Text = colorcode
            txt_qrlenght.Text = qrlenght.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub processQRcode20cy()
        Try
            Dim serialNumber As String = fg_txtqr.Text

            ' Extract parts based on fixed positions
            Dim partNumber As String = serialNumber.Substring(0, 10)
            Dim quantity As String = serialNumber.Substring(10, 2)
            Dim productionDateRaw As String = serialNumber.Substring(15)
            Dim colorcode As String = serialNumber.Replace(partNumber, "").Replace(quantity, "").Replace(productionDateRaw, "")


            Dim qrlenght As String = serialNumber.Length

            txt_partno.Text = partNumber
            txt_color.Text = colorcode
            txt_qrlenght.Text = qrlenght.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub processQRcodeTDE()
        Try
            Dim serialNumber As String = fg_txtqr.Text

            ' Extract parts based on fixed positions
            Dim customerNumber As String = serialNumber.Substring(0, 15)
            Dim partNumber As String = serialNumber.Substring(15, 10)
            Dim quantity As String = serialNumber.Substring(25, 2)


            'Qr Lenght
            Dim qrlenght As String = serialNumber.Length

            'Covert Color if no colorcode
            Dim colorcode As String = serialNumber.Substring(27, 3)
            If colorcode.Contains("--") Then
                colorcode = "--"
            End If


            txt_partno.Text = partNumber
            txt_color.Text = colorcode
            txt_customerno.Text = customerNumber
            txt_qrlenght.Text = qrlenght.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub processQRcodeDMTN()
        Try
            Dim serialNumber As String = fg_txtqr.Text

            ' Extract parts based on fixed positions
            Dim partNumber As String = serialNumber.Substring(0, 14)
            Dim quantity As String = serialNumber.Substring(14, 3)
            Dim productionDate As String = serialNumber.Substring(serialNumber.Length - 12, 12)



            'Qr Lenght
            Dim qrlenght As String = serialNumber.Length


            Dim colorcode As String = serialNumber.Replace(partNumber, "").Replace(quantity, "").Replace(productionDate, "")

            ListBox1.Items.Add(partNumber)
            ListBox1.Items.Add(quantity)
            ListBox1.Items.Add(productionDate)

            txt_partno.Text = partNumber
            txt_color.Text = colorcode

            txt_qrlenght.Text = qrlenght.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub processQRcodeintelliiv()
        Try


            Dim serialNumber As String = fg_txtqr.Text
            Dim qrlenght As String = serialNumber.Length
            Dim partNumber As String = ""
            Dim quantity As String = ""
            Dim productionDate As String = ""
            Dim colorcode As String = ""
            Dim prodcolor As String = ""
            Select Case qrlenght

                Case "27"
                    ' Extract parts based on fixed positions
                    partNumber = serialNumber.Substring(0, 10)
                    quantity = serialNumber.Substring(10, 2)
                    colorcode = serialNumber.Substring(12, 3)

                Case "26"
                    ' Extract parts based on fixed positions
                    partNumber = serialNumber.Substring(0, 10)
                    quantity = serialNumber.Substring(10, 2)
                    colorcode = serialNumber.Substring(12, 2)
                Case "31"
                    ' Extract parts based on fixed positions
                    partNumber = serialNumber.Substring(0, 14)
                    quantity = serialNumber.Substring(14, 2)
                    colorcode = serialNumber.Substring(16, 3)
                Case "23"
                    ' Extract parts based on fixed positions
                    partNumber = serialNumber.Substring(0, 14)
                    quantity = serialNumber.Substring(14, 2)
                    colorcode = serialNumber.Substring(16, 3)
            End Select

            ListBox1.Items.Add(partNumber)
            ListBox1.Items.Add(quantity)
            ListBox1.Items.Add(productionDate)

            txt_partno.Text = partNumber
            txt_color.Text = colorcode

            txt_qrlenght.Text = qrlenght.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub fg_txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles fg_txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case txt_type.Text

                Case "DMTN" 'ok na
                    processQRcodeDMTN()
                    return_ok()

                Case "Intelli IV"
                    processQRcodeintelliiv()
                    return_ok()

                Case "TDE"
                    processQRcodeTDE()

                Case "20CY"
                    processQRcode20cy()
                    return_ok()

                Case "VT"
                    processQRcodeVT()
                    return_ok()

                Case "2T"
                    processQRcode2T()
                    return_ok()
            End Select
        End If
    End Sub

    Private Sub return_ok()
        fg_txtqr.Clear()
        fg_txtqr.Focus()
        lbl_fgerror.Visible = False
    End Sub

    Private Sub cleartext()
        txt_partno.Clear()
        txt_partname.Clear()
        txt_customerno.Clear()
        txt_color.Clear()
        txt_qrlenght.Clear()
        fg_txtqr.Clear()


    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btn_fg_save.Click
        Try
            If txt_partname.Text = "" Then
                lbl_fgerror.Visible = True
                lbl_fgerror.Text = "Please Input Partname!"
            Else
                con.Close()
                con.Open()
                Dim cmdselect As New MySqlCommand("SELECT * FROM `denso_fg_masterlist` WHERE partno= '" & txt_partno.Text & "' and customerno = '" & txt_customerno.Text & "'", con)
                dr = cmdselect.ExecuteReader()
                If dr.Read = True Then
                    lbl_fgerror.Visible = True
                    lbl_fgerror.Text = "FG Already Exists!"
                Else
                    con.Close()
                    con.Open()
                    Dim cmdinsert As New MySqlCommand("INSERT INTO `denso_fg_masterlist`
                                                            (`partno`, `customerno`, `partname`, `model`, `color`, `qrtype`, `qrlenght`) 
                                                    VALUES ('" & txt_partno.Text & "',
                                                            '" & txt_customerno.Text & "',
                                                            '" & txt_partname.Text & "',
                                                            '" & txt_model.Text & "',
                                                            '" & txt_color.Text & "',
                                                            '" & txt_type.Text & "',
                                                            '" & txt_qrlenght.Text & "')", con)
                    cmdinsert.ExecuteNonQuery()
                    MessageBox.Show("USER Added successfully!")
                    con.Close()
                    lbl_duplicate.Visible = False

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Guna2GroupBox2_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox2.Click

    End Sub

    Private Sub fg_txtqr_TextChanged(sender As Object, e As EventArgs) Handles fg_txtqr.TextChanged

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT IDno FROM `denso_scanoperator` WHERE IDno= '" & idno.Text & "'", con)
            dr = cmdselect.ExecuteReader()
            If dr.Read = True Then
                lbl_duplicate.Visible = True
            Else
                con.Close()
                con.Open()
                Dim cmdinsert As New MySqlCommand(" INSERT INTO `denso_scanoperator`(`IDno`, `Fullname`, `status`) VALUES ('" & idno.Text & "','" & fname.Text & "','user')", con)
                cmdinsert.ExecuteNonQuery()
                MessageBox.Show("USER Added successfully!")
                con.Close()
                lbl_duplicate.Visible = False

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        If txtpassword.Text = "123" Then
            btn_fg_save.Enabled = True
        Else
            btn_fg_save.Enabled = False
        End If
    End Sub

    Private Sub txt_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_type.SelectedIndexChanged

    End Sub

    Private Sub txt_partno_TextChanged(sender As Object, e As EventArgs) Handles txt_partno.TextChanged

    End Sub
End Class
