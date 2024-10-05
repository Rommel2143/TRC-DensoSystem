Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel
Public Class FG_monitoring
    Private Sub stock_monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub refreshgrid(table As String)
        Try
            con.Close()
            con.Open()
            Dim cmdrefreshgrid As New MySqlCommand("SELECT `partno`, `customerno`, `color`,sum(`qty`) as TOTAL FROM " & table & "  WHERE dateout is NULL GROUP BY `partno`, `customerno`, `color`", con)

            Dim da As New MySqlDataAdapter(cmdrefreshgrid)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try
    End Sub

    Private Sub refreshtodb(cmbbox As Guna.UI2.WinForms.Guna2ComboBox, db As String)
        Try
            con.Close()
            con.Open()
            Dim cmdrefreshgrid As New MySqlCommand("SELECT `partno`, `customerno`, SUM(`qty`) FROM '" & db & "' WHERE qrtype='" & cmbbox.Text & "'", con)

            Dim da As New MySqlDataAdapter(cmdrefreshgrid)
            Dim dt As New DataTable
            da.Fill(dt)
            datagrid1.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            con.Close()
        End Try
    End Sub


    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged

        Select Case cmb_type.Text
            Case "DMTN"
                refreshgrid("denso_dmtn")
            Case "20CY"
                refreshgrid("denso_20cy")
            Case "TDE"
                con.Close()
                con.Open()
                Dim cmdrefreshgrid As New MySqlCommand("SELECT `partno`, `customerno`, `partname`,`qty` FROM `denso_fg_masterlist` WHERE qrtype='TDE' and qty != '0' ", con)

                Dim da As New MySqlDataAdapter(cmdrefreshgrid)
                Dim dt As New DataTable
                da.Fill(dt)
                datagrid1.DataSource = dt
            Case "INTELLI IV"
                refreshgrid("denso_intelli4")
            Case "YT"
                refreshgrid("denso_yt")
            Case "JECO"
                refreshgrid("denso_jeco")
            Case "3T"
                refreshgrid("denso_3t")
        End Select



    End Sub

    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        Try
            If datagrid1.Rows.Count > 0 Then
                Dim dt As New DataTable()

                ' Adding the Columns
                For Each column As DataGridViewColumn In datagrid1.Columns
                    dt.Columns.Add(column.HeaderText, column.ValueType)
                Next

                ' Adding the Rows
                For Each row As DataGridViewRow In datagrid1.Rows
                    If Not row.IsNewRow Then
                        dt.Rows.Add()
                        For Each cell As DataGridViewCell In row.Cells
                            dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
                        Next
                    End If
                Next

                ' Save the data to an Excel file
                Using sfd As New SaveFileDialog()
                    sfd.Filter = "Excel Workbook|*.xlsx"
                    sfd.Title = "Save an Excel File"
                    sfd.ShowDialog()

                    If sfd.FileName <> "" Then
                        Using wb As New XLWorkbook()
                            wb.Worksheets.Add(dt, "Sheet1")
                            wb.SaveAs(sfd.FileName)
                        End Using
                        MessageBox.Show("Data successfully exported to Excel.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Else
                MessageBox.Show("No data available to export.", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmb_type_exp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type_exp.SelectedIndexChanged
        Select Case cmb_type_exp.Text
            Case "DMTN"
                reload("SELECT `id`,`serial`, `partno`, `customerno`,`proddate` FROM `denso_dmtn` WHERE dateout is NULL ORDER BY proddate", datagrid1_exp)
            Case "20CY"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_20cy`  WHERE dateout is NULL ORDER BY proddate", datagrid1_exp)
            Case "TDE"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_fg_scan` WHERE type = 'TDE' and dateout is NULL ORDER BY proddate", datagrid1_exp)
            Case "INTELLI IV"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_intelli4`  WHERE dateout is NULL ORDER BY proddate", datagrid1_exp)
            Case "YT"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_yt`  WHERE dateout is NULL ORDER BY proddate", datagrid1_exp)
            Case "JECO"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_jeco`  WHERE dateout is NULL ORDER BY proddate", datagrid1_exp)
            Case "3T"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_3t`  WHERE dateout is NULL ORDER BY proddate", datagrid1_exp)
        End Select

    End Sub
    Private Sub datagrid1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles datagrid1_exp.CellFormatting
        ' Ensure we are formatting the entire row, not individual cells
        If e.RowIndex >= 0 AndAlso datagrid1_exp.Columns(e.ColumnIndex).Name = "proddate" Then
            Dim row As DataGridViewRow = datagrid1_exp.Rows(e.RowIndex)
            Dim proddate As Date

            If Date.TryParse(row.Cells("proddate").Value.ToString(), proddate) Then
                Dim sixMonthsAgo As Date = Date.Today.AddMonths(-6)
                Dim fourMonthsAgo As Date = Date.Today.AddMonths(-4)

                If proddate <= sixMonthsAgo Then
                    row.DefaultCellStyle.BackColor = Color.Red ' Color for 6 months old
                ElseIf proddate <= fourMonthsAgo Then
                    row.DefaultCellStyle.BackColor = Color.IndianRed ' Color for 4 months old
                Else
                    row.DefaultCellStyle.BackColor = Color.White ' Or reset to default color
                End If
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Try
            Dim saveFileDialog As New SaveFileDialog
            saveFileDialog.Filter = "Excel Files|*.xlsx"
            saveFileDialog.Title = "Save an Excel File"
            saveFileDialog.ShowDialog()

            If saveFileDialog.FileName <> "" Then
                Using workbook As New XLWorkbook()
                    Dim worksheet = workbook.Worksheets.Add("Expiring Stock")

                    ' Add header row
                    For i As Integer = 0 To datagrid1_exp.Columns.Count - 1
                        worksheet.Cell(1, i + 1).Value = datagrid1_exp.Columns(i).HeaderText
                    Next
                    worksheet.Cell(1, datagrid1_exp.Columns.Count + 1).Value = "Status"

                    ' Add data rows
                    For i As Integer = 0 To datagrid1_exp.Rows.Count - 1
                        For j As Integer = 0 To datagrid1_exp.Columns.Count - 1
                            Dim cellValue = datagrid1_exp.Rows(i).Cells(j).Value
                            If cellValue IsNot Nothing Then
                                worksheet.Cell(i + 2, j + 1).Value = cellValue.ToString()
                            End If
                        Next

                        ' Determine status and apply color
                        Dim proddate As Date
                        If Date.TryParse(datagrid1_exp.Rows(i).Cells("proddate").Value.ToString(), proddate) Then
                            Dim sixMonthsAgo As Date = Date.Today.AddMonths(-6)
                            Dim fourMonthsAgo As Date = Date.Today.AddMonths(-4)
                            If proddate <= sixMonthsAgo Then
                                worksheet.Cell(i + 2, datagrid1_exp.Columns.Count + 1).Value = "Expired"
                                worksheet.Row(i + 2).Style.Fill.BackgroundColor = XLColor.IndianRed
                            ElseIf proddate <= fourMonthsAgo Then
                                worksheet.Cell(i + 2, datagrid1_exp.Columns.Count + 1).Value = "Near Expiry"
                                worksheet.Row(i + 2).Style.Fill.BackgroundColor = XLColor.Coral
                            Else
                                worksheet.Cell(i + 2, datagrid1_exp.Columns.Count + 1).Value = "Valid"
                                worksheet.Row(i + 2).Style.Fill.BackgroundColor = XLColor.White
                            End If
                        End If
                    Next

                    workbook.SaveAs(saveFileDialog.FileName)
                End Using

                MessageBox.Show("Data Exported Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class