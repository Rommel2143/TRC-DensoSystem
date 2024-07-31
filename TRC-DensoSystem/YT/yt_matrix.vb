Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class yt_matrix


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
    Private Function processQRcode_matrix(type As String, txtqr As Guna.UI2.WinForms.Guna2TextBox) As Boolean
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
                getcoordinates(dr.GetString("proddate"), prod)
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

    Private Sub txtqr_fg_TextChanged(sender As Object, e As EventArgs) Handles txtqr_label.TextChanged

    End Sub

    Private Sub txtqr_fg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_label.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try


                If processQRcode("YT", txtqr_label) Then
                    con.Close()
                    con.Open()
                    Dim cmdselect As New MySqlCommand("SELECT ytqr, userin, datein FROM `denso_yt`
                                                WHERE ytqr = '" & txtqr_label.Text & "'", con)
                    dr = cmdselect.ExecuteReader()
                    If dr.Read = True Then

                        'duplicate
                        showduplicate(dr.GetString("userin"), dr.GetDateTime("datein").ToString("yyy-MM-dd"))


                    Else
                        displaygrid(datagrid_label)
                        lbl_qty.Text = qty
                        txtqr_label.Enabled = False

                    End If
                    txtqr_label.Clear()

                    txtqr_label.Focus()

                End If




            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub UpdateRowCountAndTotalQty(datagrid As Guna2DataGridView, labelRowCount As Label)
        ' Update row count
        labelRowCount.Text = datagrid.Rows.Count.ToString()



    End Sub
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
        ' UpdateRowCountAndTotalQty(datagrid, lbl_count, lbl_qty)
    End Sub
    Private Sub displaygrid_matrix(datagrid As Guna2DataGridView)
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
        Dim newrow As String() = New String() {serialNumber, partno, "1", customerno, color, prod, shift, process, line, series}
        datagrid.Rows.Add(newrow)
        labelerror.Visible = False
        ' UpdateRowCountAndTotalQty(datagrid, lbl_count, lbl_qty)
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

    Private Sub txtqr_matrix_TextChanged(sender As Object, e As EventArgs) Handles txtqr_matrix.TextChanged

    End Sub

    Private Sub txtqr_matrix_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_matrix.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                If processQRcode_matrix("YT-M", txtqr_matrix) Then

                    displaygrid_matrix(datagrid_matrix)

                    UpdateRowCountAndTotalQty(datagrid_matrix, lbl_count2)

                    End If
                    txtqr_matrix.Clear()
                    txtqr_matrix.Focus()


            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub lbl_count2_Click(sender As Object, e As EventArgs) Handles lbl_count2.Click

    End Sub

    Private Sub lbl_count2_TextChanged(sender As Object, e As EventArgs) Handles lbl_count2.TextChanged
        If lbl_qty.Text = lbl_count2.Text Then
            'saveqr
            saveqr()
            lbl_count2.Text = 0
            lbl_qty.Text = 0
            txtqr_label.Enabled = True
            txtqr_matrix.Enabled = False

        End If
    End Sub
    Private Sub saveqr()
        Try
            ' Define your MySQL connection string


            For Each row As DataGridViewRow In datagrid_matrix.Rows
                ' Skip new or empty rows
                If row.IsNewRow Then Continue For

                ' Retrieve data from the DataGridView row

                Dim grid_innertag As String = row.Cells(0).Value.ToString()
                Dim grid_partno As String = row.Cells(1).Value.ToString()
                Dim grid_qty As Integer = Convert.ToInt32(row.Cells(2).Value)
                Dim grid_customerno As String = row.Cells(3).Value.ToString()
                Dim grid_color As String = row.Cells(4).Value.ToString()
                Dim grid_proddate As String = row.Cells(5).Value.ToString()
                Dim grid_shift As String = row.Cells(6).Value.ToString()
                Dim grid_process As String = row.Cells(7).Value.ToString()
                Dim grid_line As String = row.Cells(8).Value.ToString()
                Dim grid_serial As String = row.Cells(9).Value.ToString()

                Dim fglabel As String = txtqr_label.Text

                con.Close()
                con.Open()
                ' Create the SQL command to insert the data
                Dim cmdinsert As New MySqlCommand("INSERT INTO denso_yt_matrix (matrixqr, partno, qty,ytqr, userin, datein) " &
                                          "VALUES (@matrixqr, @partno, @qty,@ytqr, @userin, @datein)", con)
                With cmdinsert.Parameters
                    .AddWithValue("@matrixqr", grid_innertag)
                    .AddWithValue("@partno", grid_partno)
                    .AddWithValue("@qty", grid_qty)
                    .AddWithValue("@ytqr", datagrid_label.Rows(0).Cells(0).Value.ToString())
                    .AddWithValue("@userin", idno)
                    .AddWithValue("@datein", datedb)
                    cmdinsert.ExecuteNonQuery()
                End With
            Next

            con.Close()
            con.Open()

            Dim cmdinsertdmtn As New MySqlCommand("INSERT INTO denso_yt (ytqr, partno, qty, customerno, color, proddate, shift, process, line, serial,userin, datein) " &
                                      "VALUES (@ytqr, @partno, @qty, @customerno, @color, @proddate, @shift, @process, @line, @serial, @userin, @datein)", con)
            With cmdinsertdmtn.Parameters
                .AddWithValue("@ytqr", datagrid_label.Rows(0).Cells(0).Value.ToString())
                .AddWithValue("@partno", partno)
                .AddWithValue("@qty", qty)
                .AddWithValue("@customerno", datagrid_matrix.Rows(0).Cells(3).Value.ToString())
                .AddWithValue("@color", color)
                .AddWithValue("@proddate", prod)
                .AddWithValue("@shift", shift)
                .AddWithValue("@process", process)
                .AddWithValue("@line", line)
                .AddWithValue("@serial", series)
                .AddWithValue("@userin", idno)
                .AddWithValue("@datein", datedb)
            End With
            cmdinsertdmtn.ExecuteNonQuery()

            datagrid_label.Rows.Clear()
            datagrid_matrix.Rows.Clear()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class