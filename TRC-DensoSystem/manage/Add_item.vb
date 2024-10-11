Imports MySql.Data.MySqlClient

Public Class Add_item
    Dim qrlenght As Integer
    Dim serialNumber As String = ""

    Dim partno As String
    Dim qty As String
    Dim customerno As String
    Dim color As String
    Dim prod As String
    Dim shift As String
    Dim process As String
    Dim line As String
    Dim series As String

    Dim cmbselect As String

    Private Function processQRcode(type As String, txtqr As Guna.UI2.WinForms.Guna2TextBox) As Boolean
        Try

            serialNumber = txtqr.Text

            'Qr Lenght
            qrlenght = serialNumber.Length
            Dim productionDateRaw As String = ""
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT `id`, `qrtype`, `qrlenght`, `partno`, `qty`, `customer`, `color`, `proddate`, `shift`, `process`, `line`, `series` FROM `denso_qrtype`
                                                WHERE qrlenght= '" & qrlenght & "' and qrtype  = '" & type & "'", con)
            dr = cmdselect.ExecuteReader()
            If dr.Read = True Then

                getcoordinates(dr.GetString("partno"), partno)
                getcoordinates(dr.GetString("qty"), qty)
                getcoordinates(dr.GetString("customer"), customerno)
                getcoordinates(dr.GetString("color"), Color)
                getcoordinates(dr.GetString("proddate"), productionDateRaw)
                getcoordinates(dr.GetString("shift"), shift)
                getcoordinates(dr.GetString("process"), Process)
                getcoordinates(dr.GetString("line"), line)
                getcoordinates(dr.GetString("series"), series)

                Dim year As Integer = Integer.Parse(productionDateRaw.Substring(0, 2))
                Dim month As Integer = Integer.Parse(productionDateRaw.Substring(2, 2))
                Dim day As Integer = Integer.Parse(productionDateRaw.Substring(4, 2))
                Dim productionDateDateTime As New DateTime(2000 + year, month, day)
                prod = productionDateDateTime.ToString("yyyy-MM-dd")


                Return True

            Else
                showerror("No Qrtype Detected! Please Register first")
                txtqr.Clear()
                txtqr.Focus()
                Return False
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)

            Return False
        End Try
    End Function
    Private Sub getcoordinates(partdb As String, ByRef txtstring As String)

        Dim partno() As String = partdb.Split(",")
        Dim partget1 As Integer = partno(0)
        Dim partget2 As Integer = partno(1)

        ' Extract parts based on fixed positions
        txtstring = serialNumber.Substring(partget1, partget2)

    End Sub

    Private Sub return_ok()
        txtqr.Clear()
        txtqr.Focus()
        lbl_fgerror.Visible = False
    End Sub

    Private Sub cleartext()
        txt_partno.Clear()
        txt_partname.Clear()
        txt_customerno.Clear()
        txt_color.Clear()
        txt_qrlenght.Clear()
        txtqr.Clear()


    End Sub
    Public Sub showerror(text As String)

        Try
            labelerror.Visible = True
            texterror.Text = text
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btn_fg_save.Click
        Try
            If txt_partname.Text = "" Then
                lbl_fgerror.Visible = True
                lbl_fgerror.Text = "Please Input Partname!"
            Else
                con.Close()
                con.Open()
                Dim cmdselect As New MySqlCommand("SELECT * FROM `denso_fg_masterlist` WHERE partno= '" & txt_partno.Text & "' and customerno = '" & txt_customerno.Text & "' and color='" & color & "'", con)
                dr = cmdselect.ExecuteReader()
                If dr.Read = True Then
                    lbl_fgerror.Visible = True
                    lbl_fgerror.Text = "FG Already Exists!"
                Else
                    con.Close()
                    con.Open()
                    Dim cmdinsert As New MySqlCommand("INSERT INTO `denso_fg_masterlist`
                                                            (`partno`, `customerno`, `partname`, `color`, `qrtype`, `qrlenght`) 
                                                    VALUES ('" & txt_partno.Text & "',
                                                            '" & txt_customerno.Text & "',
                                                            '" & txt_partname.Text & "',
                                                         
                                                            '" & txt_color.Text & "',
                                                            '" & cmbselect & "',
                                                            '" & txt_qrlenght.Text & "')", con)
                    cmdinsert.ExecuteNonQuery()
                    MessageBox.Show("USER Added successfully!")
                    txt_customerno.Clear()
                    txt_partname.Clear()
                    txtpassword.Clear()
                    btn_fg_save.Enabled = False
                    txtqr.Focus()
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



    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Try
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT IDno FROM `denso_scanoperator` WHERE IDno= '" & txt_idno.Text & "'", con)
            dr = cmdselect.ExecuteReader()
            If dr.Read = True Then
                lbl_duplicate.Visible = True
            Else
                con.Close()
                con.Open()
                Dim cmdinsert As New MySqlCommand(" INSERT INTO `denso_scanoperator`(`IDno`, `Fullname`, `status`,password) VALUES ('" & txt_idno.Text & "','" & fname.Text & "',0,NULL)", con)
                cmdinsert.ExecuteNonQuery()
                MessageBox.Show("USER Added successfully!")
                con.Close()
                fname.Clear()
                txt_idno.Clear()
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


    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub fg_txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub fg_txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try


                If processQRcode(cmbselect, txtqr) Then
                    txt_partno.Text = partno
                    txt_customerno.Text = customerno
                    txt_color.Text = color
                    txt_qrlenght.Text = qrlenght
                    labelerror.Visible = False
                End If


                txtqr.Clear()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub



    Private Sub cmb_type_SelectedIndexChanged_2(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        Select Case cmb_type.Text
            Case "DMTN"
                cmbselect = "DMTN"
            Case " DMTN-Inner Tag"
                cmbselect = "DMTN-IT"
            Case "DMTN-CML"
                cmbselect = "DMTN-CML"
            Case "INTELLI IV"
                cmbselect = "INT4"
            Case "TDE"
                cmbselect = "TDE"
            Case "20CY"
                cmbselect = "20CY"
            Case "VT"
                cmbselect = "VT"
            Case "2T"
                cmbselect = "2T"
            Case "YT"
                cmbselect = "YT"
            Case "YT-Matrix"
                cmbselect = "YT-M"
            Case "JECO"
                cmbselect = "JECO"
            Case "JECO-CML"
                cmbselect = "JECO-CML"
            Case "3T"
                cmbselect = "3T"
            Case "3T-Matrix"
                cmbselect = "3T-M"
            Case "DENSO PARTS"
                cmbselect = "PARTS"
        End Select
    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtqr_parts.TextChanged

    End Sub

    Private Sub Guna2TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_parts.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try


                If processQRcode("PARTS", txtqr_parts) Then
                    txt_parts_partno.Text = partno
                    txt_part_customerno.Text = customerno
                    txt_part_color.Text = color

                    labelerror.Visible = False
                End If


                txtqr_parts.Clear()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_part_save.Click
        Try
            If txt_parts_partname.Text = "" Then
                lbl_fgerror.Visible = True
                lbl_fgerror.Text = "Please Input Partname!"
            Else
                con.Close()
                con.Open()
                Dim cmdselect As New MySqlCommand("SELECT * FROM `denso_parts_masterlist` WHERE partno= '" & txt_partno.Text & "' and customerno = '" & txt_customerno.Text & "' and color='" & color & "'", con)
                dr = cmdselect.ExecuteReader()
                If dr.Read = True Then
                    lbl_fgerror.Visible = True
                    lbl_fgerror.Text = "FG Already Exists!"
                Else
                    con.Close()
                    con.Open()
                    Dim cmdinsert As New MySqlCommand("INSERT INTO `denso_parts_masterlist`
                                                            (`partno`, `customerno`, `partname`, `color`) 
                                                    VALUES ('" & txt_parts_partno.Text & "',
                                                            '" & txt_part_customerno.Text & "',
                                                            '" & txt_parts_partname.Text & "',
                                                            '" & txt_part_color.Text & "')", con)
                    cmdinsert.ExecuteNonQuery()
                    MessageBox.Show("Part Added successfully!")
                    txt_part_customerno.Clear()
                    txt_parts_partname.Clear()
                    txtpassword.Clear()
                    btn_fg_save.Enabled = False
                    txtqr.Focus()
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

    Private Sub txt_part_password_TextChanged(sender As Object, e As EventArgs) Handles txt_part_password.TextChanged
        If txt_part_password.Text = "123" Then
            btn_part_save.Enabled = True
        Else
            btn_part_save.Enabled = False
        End If
    End Sub
End Class
