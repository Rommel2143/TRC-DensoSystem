Imports System.Data.OleDb
Imports System.IO
Imports ClosedXML.Excel ' Ensure you have the ClosedXML library installed for Excel operations

Public Class expiring_stock
    Dim cmdselect As String

    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged

        Select Case cmb_type.Text
            Case "DMTN"
                reload("SELECT `id`,`serial`, `partno`, `customerno`,`proddate` FROM `denso_dmtn` WHERE dateout is NULL ORDER BY proddate", datagrid1)
            Case "20CY"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_20cy`  WHERE dateout is NULL ORDER BY proddate", datagrid1)
            Case "TDE"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_fg_scan` WHERE type = 'TDE' and dateout is NULL ORDER BY proddate", datagrid1)
            Case "INTELLI IV"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_intelli4`  WHERE dateout is NULL ORDER BY proddate", datagrid1)
            Case "YT"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_yt`  WHERE dateout is NULL ORDER BY proddate", datagrid1)
            Case "JECO"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_jeco`  WHERE dateout is NULL ORDER BY proddate", datagrid1)
            Case "3T"
                reload("SELECT `id`,`serial`,`partno`, `customerno`, `proddate` FROM `denso_3t`  WHERE dateout is NULL ORDER BY proddate", datagrid1)
        End Select

    End Sub

    Private Sub datagrid1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles datagrid1.CellFormatting
        ' Ensure we are formatting the entire row, not individual cells
        If e.RowIndex >= 0 AndAlso datagrid1.Columns(e.ColumnIndex).Name = "proddate" Then
            Dim row As DataGridViewRow = datagrid1.Rows(e.RowIndex)
            Dim proddate As Date

            If Date.TryParse(row.Cells("proddate").Value.ToString(), proddate) Then
                Dim sixMonthsAgo As Date = Date.Today.AddMonths(-6)
                Dim fourMonthsAgo As Date = Date.Today.AddMonths(-4)

                If proddate <= sixMonthsAgo Then
                    row.DefaultCellStyle.BackColor = Color.IndianRed ' Color for 6 months old
                ElseIf proddate <= fourMonthsAgo Then
                    row.DefaultCellStyle.BackColor = Color.Coral ' Color for 4 months old
                Else
                    row.DefaultCellStyle.BackColor = Color.White ' Or reset to default color
                End If
            End If
        End If
    End Sub

    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        Try
            Dim saveFileDialog As New SaveFileDialog
            saveFileDialog.Filter = "Excel Files|*.xlsx"
            saveFileDialog.Title = "Save an Excel File"
            saveFileDialog.ShowDialog()

            If saveFileDialog.FileName <> "" Then
                Using workbook As New XLWorkbook()
                    Dim worksheet = workbook.Worksheets.Add("Expiring Stock")

                    ' Add header row
                    For i As Integer = 0 To datagrid1.Columns.Count - 1
                        worksheet.Cell(1, i + 1).Value = datagrid1.Columns(i).HeaderText
                    Next
                    worksheet.Cell(1, datagrid1.Columns.Count + 1).Value = "Status"

                    ' Add data rows
                    For i As Integer = 0 To datagrid1.Rows.Count - 1
                        For j As Integer = 0 To datagrid1.Columns.Count - 1
                            Dim cellValue = datagrid1.Rows(i).Cells(j).Value
                            If cellValue IsNot Nothing Then
                                worksheet.Cell(i + 2, j + 1).Value = cellValue.ToString()
                            End If
                        Next

                        ' Determine status and apply color
                        Dim proddate As Date
                        If Date.TryParse(datagrid1.Rows(i).Cells("proddate").Value.ToString(), proddate) Then
                            Dim sixMonthsAgo As Date = Date.Today.AddMonths(-6)
                            Dim fourMonthsAgo As Date = Date.Today.AddMonths(-4)
                            If proddate <= sixMonthsAgo Then
                                worksheet.Cell(i + 2, datagrid1.Columns.Count + 1).Value = "Expired"
                                worksheet.Row(i + 2).Style.Fill.BackgroundColor = XLColor.IndianRed
                            ElseIf proddate <= fourMonthsAgo Then
                                worksheet.Cell(i + 2, datagrid1.Columns.Count + 1).Value = "Near Expiry"
                                worksheet.Row(i + 2).Style.Fill.BackgroundColor = XLColor.Coral
                            Else
                                worksheet.Cell(i + 2, datagrid1.Columns.Count + 1).Value = "Valid"
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

    Private Sub Guna2Shapes3_Click(sender As Object, e As EventArgs) Handles Guna2Shapes3.Click

    End Sub
End Class
