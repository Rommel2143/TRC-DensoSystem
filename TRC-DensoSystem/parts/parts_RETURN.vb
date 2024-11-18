
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient


Public Class parts_RETURN



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
                display_error("No Qrtype Detected! Please Register first", 0)
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

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                con.Close()
                            con.Open()
                            Dim cmdselect As New MySqlCommand("SELECT qrcode,partno, userin, datein,status,qty FROM `denso_parts`
                                                WHERE qrcode = '" & txtqr.Text & "'", con)
                            dr = cmdselect.ExecuteReader()
                            If dr.Read = True Then
                                lbl_partno.Text = dr.GetString("partno")
                                lbl_qty.Text = dr.GetInt32("qty")

                                Select Case dr.GetInt32("status")
                                    Case 0
                                        'call update qty
                                        If Convert.ToInt32(lbl_qty.Text) = 0 Then
                                            display_error("No avilable qty to deduct", 0)
                                            panel_qty.Enabled = False
                                        Else
                                            panel_qty.Enabled = True
                                            error_panel.Hide()
                                        End If

                                    Case 1
                                        display_error("Box not Scanned as OUT. Scan first!", 0)
                                End Select

                            Else
                                'norecord
                                display_error("No record. Please scan in first", 0)
                            End If





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
        'reload("SELECT dp.qrcode AS QR, dp.partno AS Partcode,pm.partname, dp.qty AS QTY, dp.color AS Color,dp.lotnumber AS Lotno, DATE_FORMAT(dp.proddate, '%b-%d-%Y') AS Production_date FROM `denso_parts` dp 
        '        JOIN denso_parts_masterlist pm ON pm.partno = dp.partno
        '        WHERE batchout='" & batchcode.Text & "' AND userout='" & idno & "' AND dateout='" & datedb & "' ORDER BY dp.id DESC", datagrid1)

    End Sub
    Private Sub displaygrid2()
        'reload("SELECT dp.partno AS Partcode, SUM(dp.qty) AS Total_QTY FROM denso_parts dp

        '    WHERE batchout='" & batchcode.Text & "' AND userout='" & idno & "' AND dateout='" & datedb & "' 
        '    GROUP BY dp.partno", datagrid2)
    End Sub


    Private Sub datagrid2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim results As New parts_OUT_Results
        results.ShowDialog()
        results.BringToFront()
    End Sub

    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub txt_qtyrem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qtyrem.KeyPress
        ' Allow only numbers, control keys, and a single decimal point
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Cancel the key press
        End If

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        con.Close()
        con.Open()
        Try

            If txt_qtyrem.Text = "" Then
                display_error("Please input remaining QTY", 0)
                Exit Sub
            End If
            If Convert.ToInt32(lbl_qty.Text) >= Convert.ToInt32(txt_qtyrem.Text) Then
                'update
                Dim query As String = "UPDATE `denso_parts` SET `qty`=" & Convert.ToInt32(txt_qtyrem.Text) & ", status=1 WHERE qrcode='" & serialNumber & "'"
                Using updateqty As New MySqlCommand(query, con)
                    updateqty.ExecuteNonQuery()
                End Using
                lbl_qty.Text = "0"
                lbl_partno.Text = "---"
                txt_qtyrem.Clear()
                serialNumber = ""
            Else
                display_error("Invalid Qty", 0)

            End If

        Catch ex As Exception
            display_error("No Box Selected ot scanned!", 0)
        End Try
    End Sub


End Class