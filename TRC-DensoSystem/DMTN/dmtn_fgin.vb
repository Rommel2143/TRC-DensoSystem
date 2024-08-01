Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient
Public Class dmtn_fgin
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

    Private Sub txtqr_fg_TextChanged(sender As Object, e As EventArgs) Handles txtqr_fg.TextChanged

    End Sub

    Private Sub txtqr_fg_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_fg.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim cmdselect As New MySqlCommand("SELECT dmtn, userin, datein FROM `denso_dmtn`
                                                WHERE dmtn = '" & txtqr_fg.Text & "'", con)
                dr = cmdselect.ExecuteReader()
                If dr.Read = True Then
                    'duplicate
                    showduplicate(dr.GetString("userin"), dr.GetDateTime("datein").ToString("yyy-MM-dd"))

                Else
                    If processQRcode("DMTN", txtqr_fg) Then
                        'saveqr

                        saveqr()
                        labelerror.Visible = False
                        txtqr_fg.Clear()
                        txtqr_fg.Focus()

                    Else
                        showerror("QTY does'nt match the given Inner Tags!")
                    End If

                    UpdateRowCountAndTotalQty(datagrid2, lbl_count, lbl_qty)
                End If


            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Private Sub UpdateRowCountAndTotalQty(datagrid As Guna2DataGridView, labelRowCount As Label, labelTotalQty As Label)
        ' Update row count
        labelRowCount.Text = datagrid.Rows.Count.ToString()

        ' Calculate total quantity
        Dim totalQty As Integer = 0
        For Each row As DataGridViewRow In datagrid.Rows
            If row.Cells(2).Value IsNot Nothing Then
                totalQty += Convert.ToInt32(row.Cells(5).Value)
            End If
        Next

        ' Update total quantity label
        labelTotalQty.Text = totalQty.ToString()
    End Sub
    Private Sub saveqr()
        Try
            ' Define your MySQL connection string


            con.Close()
            con.Open()

            Dim cmdinsertdmtn As New MySqlCommand("INSERT INTO denso_dmtn (dmtn, partno, qty, customerno, color, proddate, shift, process, line, serial,userin, datein) " &
                                      "VALUES (@dmtn, @partno, @qty, @customerno, @color, @proddate, @shift, @process, @line, @serial, @userin, @datein)", con)
            With cmdinsertdmtn.Parameters
                .AddWithValue("@dmtn", txtqr_fg.Text)
                .AddWithValue("@partno", partno)
                .AddWithValue("@qty", qty)
                .AddWithValue("@customerno", customerno)
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
            reload("SELECT `dmtn`, `partno`, `customerno`, `color`, `proddate`, `qty`, `shift`, `process`, `line`, `serial` FROM `denso_dmtn`", datagrid2)

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
End Class