Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient


Public Class parts_OUT



    Dim qrlenght As Integer
    Dim serialNumber As String = ""

    Dim partno As String
    Dim qty As Integer
    Dim customerno As String
    Dim color As String
    Dim prod As String
    Dim shift As String
    Dim process As String
    Dim line As String
    Dim series As String
    Private Sub part_IN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdate.Text = date1
    End Sub
    Public Sub display_error(text As String, play As Integer)
        error_panel.Show()
        lbl_error.Text = text

        Select Case play
            Case 0
                sounderror()
            Case 1
                soundduplicate()
        End Select
    End Sub

    Private Sub batchcode_TextChanged(sender As Object, e As EventArgs) Handles batchcode.TextChanged
        If batchcode.Text = "" Then
            txtqr.Enabled = False
        Else
            txtqr.Enabled = True
        End If
    End Sub
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
    Private Sub getcoordinates(partdb As String, ByRef txtstring As String)

        Dim partno() As String = partdb.Split(",")
        Dim partget1 As Integer = partno(0)
        Dim partget2 As Integer = partno(1)

        ' Extract parts based on fixed positions
        txtstring = serialNumber.Substring(partget1, partget2)

    End Sub
    Private Sub showerror(text As String)
        error_panel.Visible = True
        lbl_error.Text = text
    End Sub

    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Select Case cmb_sup.Text
                    Case "DENSO"

                        If processQRcode("PARTS", txtqr) Then
                            con.Close()
                            con.Open()
                            Dim selectmasterlist As New MySqlCommand("SELECT * FROM `denso_parts_masterlist`
                                                WHERE partno='" & partno & "' and customerno ='" & customerno & "'  and color = '" & color & "'", con)
                            dr = selectmasterlist.ExecuteReader()
                            If dr.Read = True Then

                                con.Close()
                                con.Open()
                                Dim cmdselect As New MySqlCommand("SELECT qrcode, userin, datein,status FROM `denso_parts`
                                                WHERE qrcode = '" & txtqr.Text & "'", con)
                                dr = cmdselect.ExecuteReader()
                                If dr.Read = True Then
                                    Select Case dr.GetInt32("status")
                                        Case 0
                                            'duplicate
                                            display_error("Status : Duplicate " & dr.GetDateTime("datein").ToString("MMMM-dd-yyyy"), 1)
                                        Case 1
                                            'update
                                            con.Close()
                                            con.Open()
                                            Dim cmdupdate As New MySqlCommand("UPDATE denso_parts SET batchout=@batchout, userout=@userout, dateout=@dateout, status=@status WHERE qrcode=@qrcode", con)

                                            ' Add parameters with values
                                            With cmdupdate.Parameters
                                                .AddWithValue("@batchout", batchcode.Text)
                                                .AddWithValue("@userout", idno)
                                                .AddWithValue("@dateout", datedb)
                                                .AddWithValue("@status", 0)
                                                .AddWithValue("@qrcode", txtqr.Text)
                                            End With

                                            cmdupdate.ExecuteNonQuery()
                                            displaygrid()
                                            displaygrid2()
                                            error_panel.Visible = False
                                    End Select

                                Else
                                    'norecord
                                    display_error("No record. Please scan in first", 0)
                                End If

                            Else
                                display_error("No Partcode Exists, Call Leader to Register!", 0)
                            End If

                        End If

                    Case "INOAC"
                        Dim parts() As String = txtqr.Text.Trim.Split("|")

                        'CON 1 : QR SPLITING
                        If parts.Length >= 3 Then
                            partno = parts(1)
                            Dim lotnumber As String = parts(2)
                            qty = parts(3)
                            Dim productionDateRaw As String = parts(2).Remove(6, 7).Trim


                            Dim year As Integer = Integer.Parse(productionDateRaw.Substring(0, 2))
                            Dim month As Integer = Integer.Parse(productionDateRaw.Substring(2, 2))
                            Dim day As Integer = Integer.Parse(productionDateRaw.Substring(4, 2))
                            Dim productionDateDateTime As New DateTime(2000 + year, month, day)
                            prod = productionDateDateTime.ToString("yyyy-MM-dd")

                            'CON 2 : IF SCANNED
                            con.Close()
                            con.Open()
                            Dim cmdselect As New MySqlCommand("SELECT `qrcode`,`status` FROM `denso_parts` WHERE `qrcode`='" & txtqr.Text.Trim & "' LIMIT 1", con)
                            dr = cmdselect.ExecuteReader
                            If dr.Read = True Then
                                Dim status As Integer = dr.GetInt32("status")

                                Select Case status

                                    Case "1"
                                        'update
                                        con.Close()
                                        con.Open()
                                        Dim cmdupdate As New MySqlCommand("UPDATE denso_parts SET batchout=@batchout, userout=@userout, dateout=@dateout, status=@status WHERE qrcode=@qrcode", con)

                                        ' Add parameters with values
                                        With cmdupdate.Parameters
                                            .AddWithValue("@batchout", batchcode.Text)
                                            .AddWithValue("@userout", idno)
                                            .AddWithValue("@dateout", datedb)
                                            .AddWithValue("@status", 0)
                                            .AddWithValue("@qrcode", txtqr.Text.Trim)
                                        End With

                                        cmdupdate.ExecuteNonQuery()
                                        displaygrid()
                                        displaygrid2()
                                        error_panel.Visible = False
                                    Case "0"
                                        'duplicate
                                        display_error("Duplicate Entry", 2)
                                End Select

                            Else 'CON 2 : IF NOT SCANNED
                                display_error("Record doesn't exist", 1)

                            End If

                        Else  'CON 1 : QR SPLITING
                            display_error("INVALID QR FORMAT!", 1)

                        End If

                    Case "TRC"

                        Dim parts() As String = txtqr.Text.Trim.Split("|")

                        'CON 1 : QR SPLITING

                        If parts.Length >= 5 AndAlso parts.Length <= 8 Then
                            partno = parts(0).Remove(0, 2).Trim

                            qty = parts(3).Remove(0, 2).Trim
                            Dim lotnumber As String = parts(2).Remove(0, 2).Trim
                            Dim productionDateRaw As String = parts(2).Substring(13, 6).Trim
                            Dim year As Integer = Integer.Parse(productionDateRaw.Substring(0, 2))
                            Dim month As Integer = Integer.Parse(productionDateRaw.Substring(2, 2))
                            Dim day As Integer = Integer.Parse(productionDateRaw.Substring(4, 2))
                            Dim productionDateDateTime As New DateTime(2000 + year, month, day)
                            prod = productionDateDateTime.ToString("yyyy-MM-dd")


                            'CON 2 : IF SCANNED
                            con.Close()
                            con.Open()
                            Dim cmdselect As New MySqlCommand("SELECT `qrcode`,`status` FROM `denso_parts` WHERE `qrcode`='" & txtqr.Text.Trim & "' LIMIT 1", con)
                            dr = cmdselect.ExecuteReader
                            If dr.Read = True Then
                                Dim status As Integer = dr.GetInt32("status")

                                Select Case status

                                    Case "1"
                                        'update
                                        con.Close()
                                        con.Open()
                                        Dim cmdupdate As New MySqlCommand("UPDATE denso_parts SET batchout=@batchout, userout=@userout, dateout=@dateout, status=@status WHERE qrcode=@qrcode", con)

                                        ' Add parameters with values
                                        With cmdupdate.Parameters
                                            .AddWithValue("@batchout", batchcode.Text)
                                            .AddWithValue("@userout", idno)
                                            .AddWithValue("@dateout", datedb)
                                            .AddWithValue("@status", 0)
                                            .AddWithValue("@qrcode", txtqr.Text.Trim)
                                        End With

                                        cmdupdate.ExecuteNonQuery()
                                        displaygrid()
                                        displaygrid2()
                                        error_panel.Visible = False
                                    Case "0"
                                        'duplicate
                                        display_error("Duplicate Entry", 2)
                                End Select

                            Else 'CON 2 : IF NOT SCANNED
                                display_error("Record doesn't exist", 1)

                            End If

                        Else  'CON 1 : QR SPLITING
                            display_error("INVALID QR FORMAT!", 1)

                        End If

                End Select




                txtqr.Clear()
                txtqr.Focus()

            Catch ex As MySqlException
                display_error("Error on scanning : " & ex.Message, 0)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub displaygrid()
        reload("SELECT dp.qrcode AS QR, dp.partno AS Partcode,pm.partname, dp.qty AS QTY, dp.color AS Color,dp.lotnumber AS Lotno, DATE_FORMAT(dp.proddate, '%b-%d-%Y') AS Production_date FROM `denso_parts` dp 
                JOIN denso_parts_masterlist pm ON pm.partno = dp.partno
                WHERE batchout='" & batchcode.Text & "' AND userout='" & idno & "' AND dateout='" & datedb & "' ORDER BY dp.id DESC", datagrid1)

    End Sub
    Private Sub displaygrid2()
        reload("SELECT dp.partno AS Partcode, SUM(dp.qty) AS Total_QTY FROM denso_parts dp
           
            WHERE batchout='" & batchcode.Text & "' AND userout='" & idno & "' AND dateout='" & datedb & "' 
            GROUP BY dp.partno", datagrid2)
    End Sub


    Private Sub datagrid2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim results As New parts_OUT_Results
        results.ShowDialog()
        results.BringToFront()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub cmb_sup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_sup.SelectedIndexChanged
        Panel1.Enabled = True
    End Sub
End Class