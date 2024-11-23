﻿Imports MySql.Data.MySqlClient
Public Class tde_IN


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
    Dim checkcolor As String
    Dim tdeserial As String



    Private Function processQRcodeTDE(type As String, txtqr As Guna.UI2.WinForms.Guna2TextBox) As Boolean
        Try



            serialNumber = txtqr.Text

            'Qr Lenght
            qrlenght = serialNumber.Length
            Dim productionDateRaw As String = ""


            con.Close()
            con.Open()
            Dim cmdselectqr As New MySqlCommand("SELECT `id`, `qrtype`, `qrlenght`, `partno`, `qty`, `customer`, `color`, `proddate`, `shift`, `process`, `line`, `series` FROM `denso_qrtype`
                                                WHERE qrlenght= '" & qrlenght & "' and qrtype  = '" & type & "'", con)
            dr = cmdselectqr.ExecuteReader()
            If dr.Read = True Then


                getcoordinates(dr.GetString("series"), tdeserial)

            Else
                showerror("No Qrtype Detected! Please Register first")
                txtqr.Clear()
                txtqr.Focus()
                Return False
            End If


            Return True



        Catch ex As Exception
            MessageBox.Show(ex.Message)

            Return False
        End Try
    End Function


    Private Function processQRcode(type As String, txtqr As Guna.UI2.WinForms.Guna2TextBox) As Boolean
        Try
            serialNumber = txtqr.Text

            'Qr Lenght
            qrlenght = serialNumber.Length

            Select Case qrlenght
                Case 43

                Case Else

            End Select
            Dim productionDateRaw As String = ""


            con.Close()
            con.Open()
            Dim cmdselectqr As New MySqlCommand("SELECT `id`, `qrtype`, `qrlenght`, `partno`, `qty`, `customer`, `color`, `proddate`, `shift`, `process`, `line`, `series` FROM `denso_qrtype`
                                                WHERE qrlenght= '" & qrlenght & "' and qrtype  = '" & type & "'", con)
            dr = cmdselectqr.ExecuteReader()
            If dr.Read = True Then


                getcoordinates(dr.GetString("color"), color)
                getcoordinates(dr.GetString("partno"), partno)
                getcoordinates(dr.GetString("qty"), qty)
                getcoordinates(dr.GetString("customer"), customerno)

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

            Else
                showerror("No Qrtype Detected! Please Register first")
                txtqr.Clear()
                txtqr.Focus()
                Return False
            End If


            Return True



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
    Public Sub showerror(text As String)

        Try
            labelerror.Visible = True
            texterror.Text = text
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
    Private Sub txtqr_label_TextChanged(sender As Object, e As EventArgs) Handles txtqr_tde.TextChanged

    End Sub

    Private Sub txtqr_label_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_tde.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try


                If processQRcodeTDE("TDE", txtqr_tde) Then

                    con.Close()
                    con.Open()
                    Dim cmdselect As New MySqlCommand("SELECT tdeqr, userin, datein FROM `denso_tde`
                                                WHERE tdeqr = '" & txtqr_tde.Text & "'", con)
                    dr = cmdselect.ExecuteReader()
                    If dr.Read = True Then
                        'duplicate

                        showduplicate(dr.GetString("userin"), dr.GetDateTime("datein"))
                    Else

                        MessageBox.Show(tdeserial)
                        labelerror.Visible = False
                    End If



                End If




            Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    con.Close()
                End Try

        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtqr_sticker_TextChanged(sender As Object, e As EventArgs) Handles txtqr_sticker.TextChanged

    End Sub

    Private Sub txtqr_sticker_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_sticker.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try


                If processQRcode("TDE-SL", txtqr_sticker) Then

                    con.Close()
                    con.Open()
                    Dim cmdselect As New MySqlCommand("SELECT qrcode, userin, datein FROM `denso_tde`
                                                WHERE qrcode = '" & txtqr_tde.Text & "'", con)
                    dr = cmdselect.ExecuteReader()
                    If dr.Read = True Then
                        'duplicate

                        showduplicate(dr.GetString("userin"), dr.GetDateTime("datein"))
                    Else

                        MessageBox.Show(tdeserial & "-" & partno & "-" & customerno & "-" & qty & "-" & series)
                        labelerror.Visible = False
                    End If



                End If

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try

        End If

    End Sub
End Class