﻿Imports MySql.Data.MySqlClient
Public Class QR_identifier
    Dim partNumber As String
    Dim serialNumber As String
    Dim qrlenght As Integer

    Dim txtbox As Guna.UI2.WinForms.Guna2TextBox
    Dim txtval As Guna.UI2.WinForms.Guna2TextBox
    Private Sub txt_qr_TextChanged(sender As Object, e As EventArgs) Handles txt_qr.TextChanged
        If txt_qr.Text = "" Then
            panel_toogle.Enabled = False

        Else
            panel_toogle.Enabled = True
        End If
    End Sub

    Private Sub txt_qr_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_qr.KeyDown
        If e.KeyCode = Keys.Enter Then
            serialNumber = txt_qr.Text
            qrlenght = serialNumber.Length
            qr_lenght.Text = qrlenght

            qrbar.Maximum = Math.Max(0, qrlenght - count.Value)
            qrbar.Value = 0


        End If
    End Sub


    Private Sub updatevalue(txt As Guna.UI2.WinForms.Guna2TextBox, val As Guna.UI2.WinForms.Guna2TextBox)
        Try


            ' Update the TextBox with the current value of the TrackBar
            Dim qrvalue As Integer = qrbar.Value ' Get the current value of the TrackBar

            If qrvalue + count.Value <= serialNumber.Length Then
                ' Check if the substring can be safely extracted without going out of bounds
                txt.Text = serialNumber.Substring(qrvalue, count.Value) ' Extract substring
                val.Text = $"{qrvalue},{count.Value}" ' Update the second TextBox with indices

                ' Set focus and select the extracted substring in the txt_qr TextBox
                txt_qr.Focus()
                txt_qr.Select(qrvalue, count.Value)
            Else
                ' Handle case where the substring would go out of bounds
                txt.Text = String.Empty ' Clear the text if out of bounds
                val.Text = "Out of bounds" ' Update the second TextBox with a message
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub Guna2TrackBar1_Scroll_1(sender As Object, e As ScrollEventArgs) Handles qrbar.Scroll
        updatevalue(txtbox, txtval)

    End Sub

    Private Sub count_ValueChanged(sender As Object, e As EventArgs) Handles count.ValueChanged
        updatevalue(txtbox, txtval)
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub QR_identifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadgrid()
    End Sub
    Public Sub reloadgrid()
        Try
            reload("SELECT * FROM `denso_qrtype`", datagrid1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Guna2CustomRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomRadioButton1.CheckedChanged
        txtbox = txt_partno
        txtval = val_partno
    End Sub

    Private Sub Guna2CustomRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomRadioButton2.CheckedChanged
        txtbox = txt_customerno
        txtval = val_customer
    End Sub

    Private Sub Guna2CustomRadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomRadioButton3.CheckedChanged
        txtbox = txt_color
        txtval = val_color
    End Sub

    Private Sub Guna2CustomRadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomRadioButton4.CheckedChanged
        txtbox = txt_prod
        txtval = val_prod
    End Sub

    Private Sub Guna2CustomRadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomRadioButton5.CheckedChanged
        txtbox = txt_shift
        txtval = val_shift
    End Sub

    Private Sub Guna2CustomRadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomRadioButton6.CheckedChanged
        txtbox = txt_machine
        txtval = val_machine
    End Sub

    Private Sub Guna2CustomRadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomRadioButton8.CheckedChanged
        txtbox = txt_line
        txtval = val_line
    End Sub

    Private Sub Guna2CustomRadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomRadioButton7.CheckedChanged
        txtbox = txt_series
        txtval = val_series
    End Sub

    Private Sub Guna2CustomRadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomRadioButton9.CheckedChanged
        txtbox = txt_qty
        txtval = val_qty
    End Sub

    Private Sub btn_fg_save_Click(sender As Object, e As EventArgs) Handles btn_fg_save.Click

        Try


            con.Close()
            con.Open()
            Dim cmdinsert As New MySqlCommand("INSERT INTO `denso_qrtype`( `qrtype`,
                                                                            `qrlenght`,
                                                                            `partno`,
                                                                            `qty`, 
                                                                            `customer`,
                                                                            `color`,
                                                                            `proddate`,
                                                                            `shift`,
                                                                            `machine`,
                                                                            `line`, 
                                                                            `series`)
                                                                    VALUES ('" & cmb_type.Text & "',
                                                                            '" & qrlenght & "',
                                                                            '" & val_partno.Text & "',
                                                                            '" & val_qty.Text & "',
                                                                            '" & val_customer.Text & "',
                                                                            '" & val_color.Text & "',
                                                                            '" & val_prod.Text & "',
                                                                            '" & val_shift.Text & "',
                                                                            '" & val_machine.Text & "',
                                                                            '" & val_line.Text & "',
                                                                            '" & val_series.Text & "'
                                                                            )", con)
            cmdinsert.ExecuteNonQuery()
            MessageBox.Show("USER Added successfully!")
            con.Close()

            reloadgrid()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
