Imports MySql.Data.MySqlClient

Public Class Add_item

    Dim cmbselect As String
    Private Sub Add_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                                                            '" & cmbselect & "',
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


    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        Select Case cmb_type.Text
            Case "DMTN"
                cmbselect = "DMTN"
            Case " DMTN Inner Tag"
                cmbselect = "DMTN-IT"
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


        End Select
    End Sub


End Class
