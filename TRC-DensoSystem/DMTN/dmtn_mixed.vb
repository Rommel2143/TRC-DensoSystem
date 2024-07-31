Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class dmtn_mixed


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

    Private Function processQRcodecml(type As String, txtqr As Guna.UI2.WinForms.Guna2TextBox) As Boolean
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

    Private Sub displaygrid(datagrid As Guna2DataGridView)
        'Filter Duplicate on QR
        For Each row As DataGridViewRow In datagrid.Rows
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = serialNumber Then
                labelerror.Visible = True
                texterror.Text = "QR Already Scanned Please check the Table!"
                soundduplicate()
                Exit Sub
            End If
        Next


        'display grid
        Dim newrow As String() = New String() {serialNumber, partno, qty, customerno, color, prod, shift, process, line, series}
        datagrid.Rows.Add(newrow)
        labelerror.Visible = False
        UpdateRowCountAndTotalQty(datagrid, lbl_count, lbl_qty)
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


                If processQRcode("DMTN", txtqr) Then
                    con.Close()
                    con.Open()
                    Dim cmdselect As New MySqlCommand("SELECT dmtn,customerno, userin, datein,cml FROM `denso_dmtn`
                                                WHERE dmtn = '" & txtqr.Text & "'", con)
                    dr = cmdselect.ExecuteReader()
                    If dr.Read = True Then


                        If dr.GetString("cml") = "" Then
                            'save
                            customerno = dr.GetString("customerno")
                            displaygrid(datagrid1)
                        Else
                            'duplicate
                            showduplicate(dr.GetString("userin"), dr.GetDateTime("datein").ToString("yyy-MM-dd"))
                        End If
                    Else
                        'invalid or not scanned
                        showerror("QR not Recorded!")


                    End If
                    txtqr.Clear()
                    txtqr.Focus()

                End If




            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_fg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                If processQRcodecml("DMTN-CML", txtqr_fg) Then
                    ' Add scanned QR code to the list
                    scannedQRCodes.Add(txtqr_fg.Text)

                    ' Check if three QR codes have been scanned
                    If scannedQRCodes.Count = 3 Then
                        ' Check if all three QR codes are the same
                        If scannedQRCodes.Distinct().Count() = 1 Then
                            con.Close()
                            con.Open()
                            Dim cmdselect As New MySqlCommand("SELECT cmlqr, userout, dateout FROM `denso_dmtn_cml`
                                                                WHERE cmlqr = '" & txtqr_fg.Text & "'", con)
                            dr = cmdselect.ExecuteReader()
                            If dr.Read = True Then
                                'duplicate
                                showduplicate(dr.GetString("userout"), dr.GetDateTime("dateout").ToString("yyy-MM-dd"))
                                txtqr_fg.Clear()
                                txtqr_fg.Focus()
                            Else
                                saveqr()
                                labelerror.Visible = False
                                txtqr_fg.Clear()
                                txtqr_fg.Enabled = False
                                txtqr.Enabled = True
                                txtqr.Clear()
                                txtqr.Focus()
                            End If
                        Else
                            ' Show error if QR codes do not match
                            showerror("QR codes do not match. Please scan the same QR code three times.")
                            scannedQRCodes.Clear()
                            txtqr_fg.Clear()
                            txtqr_fg.Focus()
                        End If
                    Else
                        txtqr_fg.Clear()
                        txtqr_fg.Focus()
                    End If
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    'Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_fg.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        Try

    '            If processQRcodecml("DMTN-CML", txtqr_fg) Then
    '                con.Close()
    '                con.Open()
    '                Dim cmdselect As New MySqlCommand("SELECT cmlqr, userout, dateout FROM `denso_dmtn_cml`
    '                                            WHERE cmlqr = '" & txtqr_fg.Text & "'", con)
    '                dr = cmdselect.ExecuteReader()
    '                If dr.Read = True Then
    '                    'duplicate
    '                    showduplicate(dr.GetString("userout"), dr.GetDateTime("dateout").ToString("yyy-MM-dd"))
    '                    txtqr_fg.Clear()
    '                    txtqr_fg.Focus()
    '                Else
    '                    saveqr()
    '                    labelerror.Visible = False
    '                    txtqr_fg.Clear()
    '                    txtqr_fg.Enabled = False
    '                    txtqr.Enabled = True
    '                    txtqr.Clear()
    '                    txtqr.Focus()

    '                End If


    '            End If




    '        Catch ex As MySqlException
    '            MessageBox.Show(ex.Message)

    '        Finally
    '            con.Close()
    '        End Try
    '    End If
    'End Sub
    Private Sub saveqr()
        Try
            ' Define your MySQL connection string


            For Each row As DataGridViewRow In datagrid1.Rows
                ' Skip new or empty rows
                If row.IsNewRow Then Continue For

                ' Retrieve data from the DataGridView row

                Dim grid_dmtn As String = row.Cells(0).Value.ToString()
                Dim grid_partno As String = row.Cells(1).Value.ToString()
                Dim grid_qty As Integer = Convert.ToInt32(row.Cells(2).Value)
                Dim grid_customerno As String = row.Cells(3).Value.ToString()
                Dim grid_color As String = row.Cells(4).Value.ToString()
                Dim grid_proddate As String = row.Cells(5).Value.ToString()
                Dim grid_shift As String = row.Cells(6).Value.ToString()
                Dim grid_process As String = row.Cells(7).Value.ToString()
                Dim grid_line As String = row.Cells(8).Value.ToString()
                Dim grid_serial As String = row.Cells(9).Value.ToString()

                Dim cml As String = txtqr_fg.Text

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
                .AddWithValue("@cmlqr", txtqr_fg.Text)
                .AddWithValue("@qty", lbl_qty.Text)
                .AddWithValue("@serial", series)
                .AddWithValue("@userout", idno)
                .AddWithValue("@dateout", datedb)
            End With
            cmdinsertdmtn.ExecuteNonQuery()
            reload("SELECT `cmlqr`, `qty`, `serial`,`userout`,`dateout` FROM `denso_dmtn_cml`", datagrid2)
            datagrid1.Rows.Clear()
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
        datagrid1.Rows.Clear()
    End Sub

    Private Sub txtqr_fg_TextChanged(sender As Object, e As EventArgs) Handles txtqr_fg.TextChanged

    End Sub

    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub lbl_count_Click(sender As Object, e As EventArgs) Handles lbl_count.Click

    End Sub

    Private Sub lbl_count_TextChanged(sender As Object, e As EventArgs) Handles lbl_count.TextChanged

    End Sub

    Private Sub lbl_qty_Click(sender As Object, e As EventArgs) Handles lbl_qty.Click

    End Sub

    Private Sub lbl_qty_TextChanged(sender As Object, e As EventArgs) Handles lbl_qty.TextChanged
        If lbl_qty.Text = "1440" Then
            txtqr_fg.Enabled = True
            txtqr.Enabled = False

        Else
            txtqr_fg.Enabled = False
            txtqr.Enabled = True
        End If
    End Sub

    Private Sub dmtn_cml_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtqr_Layout(sender As Object, e As LayoutEventArgs) Handles txtqr.Layout

    End Sub
End Class