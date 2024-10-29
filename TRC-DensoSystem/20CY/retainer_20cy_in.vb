Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class _20cy_in
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
                getcoordinates(dr.GetString("color"), color)
                getcoordinates(dr.GetString("proddate"), productionDateRaw)
                getcoordinates(dr.GetString("shift"), shift)
                getcoordinates(dr.GetString("process"), process)
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
    Public Sub showerror(text As String)

        Try
            labelerror.Visible = True
            texterror.Text = text
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub getcoordinates(partdb As String, ByRef txtstring As String)

        Dim partno() As String = partdb.Split(",")
        Dim partget1 As Integer = partno(0)
        Dim partget2 As Integer = partno(1)

        ' Extract parts based on fixed positions
        txtstring = serialNumber.Substring(partget1, partget2)

    End Sub
    Private Sub txtqr_label_TextChanged(sender As Object, e As EventArgs) Handles txtqr_label.TextChanged

    End Sub
    Private Sub txtqr_fg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_label.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtqr_verify.Text = txtqr_label.Text Then
                Try


                    If processQRcode("20CY", txtqr_label) Then
                        con.Close()
                        con.Open()
                        Dim cmdselect As New MySqlCommand("SELECT cyqr, userin, datein,status FROM `denso_20cy`
                                                WHERE cyqr = '" & txtqr_label.Text & "'", con)
                        dr = cmdselect.ExecuteReader()
                        If dr.Read = True Then
                            'duplicate

                            showduplicate(dr.GetString("userin"), dr.GetDateTime("datein"))
                        Else
                            'save
                            saveqr()
                            reload("SELECT `cyqr`, `partno`, `customerno`, `color`, `proddate`, `qty`, `shift`, `process`, `line`, `serial` FROM `denso_20cy` 
                                   WHERE datein= '" & datedb & "'", datagrid_label)
                            labelerror.Visible = False
                        End If
                        txtqr_verify.Clear()
                        txtqr_verify.Focus()

                    End If




                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    con.Close()
                End Try
            Else
                showerror("QR not the same!")
            End If
        End If
    End Sub
    Private Sub saveqr()
        Try

            con.Close()
            con.Open()

            Dim insertjeco As New MySqlCommand("INSERT INTO `denso_20cy`(`cyqr`,
                                                                            `partno`,
                                                                            `customerno`,
                                                                            `color`,
                                                                            `proddate`,
                                                                            `qty`, 
                                                                            `shift`, 
                                                                            `process`, 
                                                                            `line`, 
                                                                            `serial`,
                                                                            `userin`,
                                                                            `datein`) 
                                                                    VALUES ('" & txtqr_label.Text & "',
                                                                            '" & partno & "',
                                                                            '" & txt_customer.Text & "',
                                                                            '" & color & "',
                                                                            '" & prod & "',
                                                                            '" & Val(qty) & "',
                                                                            '" & shift & "',
                                                                            '" & process & "',
                                                                            '" & line & "',
                                                                            '" & series & "',
                                                                            '" & idno & "',
                                                                            '" & datedb & "')", con)


            insertjeco.ExecuteNonQuery()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub showduplicate(user As String, date1 As String)
        Try
            labelerror.Visible = True
            texterror.Text = "QR Already Scanned by " & user & " on " & date1 & ""
            soundduplicate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtqr_verify_TextChanged(sender As Object, e As EventArgs) Handles txtqr_verify.TextChanged

    End Sub

    Private Sub txtqr_verify_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_verify.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtqr_label.Clear()
            txtqr_label.Focus()
        End If
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub


    Private Sub cmb_customerno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_customer.TextChanged
        If txt_customer.Text = "" Then
            panelscan.Enabled = False
        Else
            panelscan.Enabled = True
        End If
    End Sub

    Private Sub part_IN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdate.Text = date1
    End Sub


End Class