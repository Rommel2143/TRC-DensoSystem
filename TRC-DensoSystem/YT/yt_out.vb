Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class yt_out



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
    Private Sub txtqr_label_TextChanged(sender As Object, e As EventArgs) Handles txtqr_label.TextChanged

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
    Private Sub showduplicate(user As String, date1 As String)
        Try
            labelerror.Visible = True
            texterror.Text = "QR Already Scanned by " & user & " on " & date1 & ""
            soundduplicate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class