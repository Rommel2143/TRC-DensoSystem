Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class dmtn_handcarry
    Dim serialNumber As String = Nothing
    Dim partno As String = Nothing


    Dim qrlenght As Integer
    Dim qty As String
    Dim customerno As String
    Dim color As String
    Dim prod As String
    Dim shift As String
    Dim process As String
    Dim line As String
    Dim series As String
    ' List to store scanned QR codes
    Dim scannedQRCodes As New List(Of String)
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

                If productionDateRaw = "" Then
                Else
                    Dim year As Integer = Integer.Parse(productionDateRaw.Substring(0, 2))
                    Dim month As Integer = Integer.Parse(productionDateRaw.Substring(2, 2))
                    Dim day As Integer = Integer.Parse(productionDateRaw.Substring(4, 2))
                    Dim productionDateDateTime As New DateTime(2000 + year, month, day)
                    prod = productionDateDateTime.ToString("yyyy-MM-dd")
                End If



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

    Private Sub txtqr_label_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_sticker.KeyDown
        Try


            If e.KeyCode = Keys.Enter Then
                If txtqr_sticker.Text = "" Then
                    datagrid1.DataSource = Nothing
                Else



                    dt = New DataTable
                    con.Close()
                    con.Open()
                    With cmd
                        .Connection = con
                        .CommandText = "SELECT serial, `partno`, `customerno`, `color`,`qty`, `userin`, `datein` FROM `denso_dmtn_innertag` WHERE fglabel='" & txtqr_sticker.Text & "'"
                    End With
                    da.SelectCommand = cmd
                    da.Fill(dt)

                    If processQRcode("DMTN", txtqr_sticker) Then
                        con.Close()
                        con.Open()
                        Dim cmdselect As New MySqlCommand("SELECT dmtn,customerno, userin, datein,cml FROM `denso_dmtn`
                                                WHERE dmtn = '" & txtqr_sticker.Text.Trim & "'", con)
                        dr = cmdselect.ExecuteReader()
                        If dr.Read = True Then


                            If dr.GetString("cml") = "" Then
                                displaygrid(datagrid2)
                                UpdateRowCountAndTotalQty(datagrid2, lbl_count, lbl_qty)
                                labelerror.Hide()
                            Else
                                'duplicate
                                showduplicate(dr.GetString("userin"), dr.GetDateTime("datein").ToString("yyy-MM-dd"))
                            End If
                        Else
                            'invalid or not scanned
                            showerror("No Record Found! Please scan again")


                        End If

                    End If

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("No records found for the entered label.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        datagrid1.DataSource = Nothing
                    Else
                        datagrid1.DataSource = dt
                    End If
                End If
                txtqr_sticker.Clear()
                txtqr_sticker.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub UpdateRowCountAndTotalQty(datagrid As Guna2DataGridView, labelRowCount As Label, labelTotalQty As Label)
        ' Update row count
        labelRowCount.Text = datagrid.Rows.Count.ToString()

        ' Calculate total quantity
        Dim totalQty As Integer = 0
        For Each row As DataGridViewRow In datagrid.Rows
            If row.Cells(2).Value IsNot Nothing Then
                totalQty += Convert.ToInt32(row.Cells(2).Value)
            End If
        Next

        ' Update total quantity label
        labelTotalQty.Text = totalQty.ToString()
    End Sub



    Private Sub displaygrid(datagrid As Guna2DataGridView)
        'Filter Duplicate on QR


        Dim qrcode As String = txtqr_sticker.Text

        For Each row As DataGridViewRow In datagrid.Rows

            If row.Cells(3).Value IsNot Nothing AndAlso row.Cells(3).Value.ToString() = qrcode Then

                labelerror.Visible = True
                texterror.Text = "QR already scanned!"
                soundduplicate()
                labelerror.Visible = True
                Exit Sub
            End If
        Next

        'Filter Duplicate on Partno and CustomerNO
        If datagrid.Rows.Count > 0 Then
            Dim firstPartno As String = datagrid.Rows(0).Cells(1).Value.ToString()

            If partno <> firstPartno Then
                labelerror.Visible = True
                texterror.Text = "Part Number or Customer Number does not match. Please check the Table!"
                soundduplicate()
                Exit Sub
            End If
        End If
        'display grid
        Dim newrow As String() = New String() {series, partno, qty, qrcode}
        datagrid.Rows.Add(newrow)
        labelerror.Visible = False

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

    Public Sub showerror(text As String)

        Try
            labelerror.Visible = True
            texterror.Text = text
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        datagrid2.Rows.Clear()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtqr_cml.TextChanged

    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_cml.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                If processQRcode("DMTN-CML", txtqr_cml) Then

                    ' Add scanned QR code to the list
                    scannedQRCodes.Add(txtqr_cml.Text)

                    ' Check if three QR codes have been scanned
                    If scannedQRCodes.Count = 3 Then
                        ' Check if all three QR codes are the same
                        If scannedQRCodes.Distinct().Count() = 1 Then
                            con.Close()
                            con.Open()
                            Dim cmdselect As New MySqlCommand("SELECT cmlqr, userout, dateout FROM `denso_dmtn_cml`
                                                                WHERE cmlqr = '" & txtqr_cml.Text.Trim & "'", con)
                            dr = cmdselect.ExecuteReader()
                            If dr.Read = True Then
                                'duplicate
                                showduplicate(dr.GetString("userout"), dr.GetDateTime("dateout").ToString("yyy-MM-dd"))

                            Else

                                saveqr()

                            End If
                        Else
                            ' Show error if QR codes do not match
                            showerror("QR codes do not match. Please scan the same QR code three times.")
                            scannedQRCodes.Clear()

                        End If
                    Else
                        txtqr_cml.Clear()

                    End If
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub saveqr()
        Try


            For Each row As DataGridViewRow In datagrid2.Rows
                ' Skip new or empty rows
                If row.IsNewRow Then Continue For

                ' Retrieve data from the DataGridView row

                Dim grid_dmtn As String = row.Cells(3).Value.ToString()

                Dim cml As String = txtqr_cml.Text.Trim

                ' Create the SQL command to update the data
                con.Close()
                con.Open()
                Dim cmdupdate As New MySqlCommand("UPDATE denso_dmtn SET cml=@cml, userout=@userout, dateout=@dateout WHERE dmtn=@dmtn", con)

                ' Add parameters with values
                With cmdupdate.Parameters
                    .AddWithValue("@cml", cml)
                    .AddWithValue("@userout", idno)
                    .AddWithValue("@dateout", datedb)
                    .AddWithValue("@dmtn", grid_dmtn)
                End With

                cmdupdate.ExecuteNonQuery()
            Next
            con.Close()
            con.Open()

            Dim cmdinsertdmtn As New MySqlCommand("INSERT INTO denso_dmtn_cml (cmlqr, qty, serial,userout,dateout) " &
                                      "VALUES (@cmlqr,@qty, @serial, @userout, @dateout)", con)
            With cmdinsertdmtn.Parameters
                .AddWithValue("@cmlqr", txtqr_cml.Text)
                .AddWithValue("@qty", lbl_qty.Text)
                .AddWithValue("@serial", series)
                .AddWithValue("@userout", idno)
                .AddWithValue("@dateout", datedb)
            End With
            cmdinsertdmtn.ExecuteNonQuery()

            datagrid2.Rows.Clear()
            labelerror.Hide()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub txtqr_sticker_TextChanged(sender As Object, e As EventArgs) Handles txtqr_sticker.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class