
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports ClosedXML.Excel
Public Class dashboard
    Dim table As String
    Dim query As String
      Dim gunahorizontalbardataset As New DataSet()
    Private Sub memo_analytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dt_to.Value = Date.Now
            dt_from.Value = Date.Now
            reload_graph()
            LoadMemberProfiles()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub reload_graph()
        con.Close()
        con.Open()

        ' SQL query to get partno, partname, sum(qty), min, and max
        Dim cmd As New MySqlCommand("SELECT dp.partno,dp.color, pm.partname, SUM(qty) AS TOTAL, pm.min, pm.max 
                                 FROM denso_parts dp
                                 JOIN denso_parts_masterlist pm ON pm.partno = dp.partno
                                 WHERE status = 1 
                                 GROUP BY dp.partno,dp.color
                                  ORDER BY TOTAL DESC", con)

        ' Execute the query and get data into a MySqlDataReader
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        ' Clear existing series, titles, chart areas, and legends
        Chart1.Series.Clear()
        Chart1.Titles.Clear()
        Chart1.ChartAreas.Clear()
        Chart1.Legends.Clear()

        ' Create a new chart area
        Dim chartArea As New ChartArea()
        chartArea.AxisY.Title = "Total Quantity"
        chartArea.AxisY.TitleFont = New Font("Segoe UI Semibold", 10)

        ' Add the chart area to the chart
        Chart1.ChartAreas.Add(chartArea)

        ' Set grid color
        chartArea.AxisX.MajorGrid.LineColor = Color.LightGray
        chartArea.AxisY.MajorGrid.LineColor = Color.LightGray

        ' Create a new series for the chart
        Dim series As New Series(" ")
        series.ChartType = SeriesChartType.Bar ' Set the chart type to Bar
        series.Font = New Font("Segoe UI Semibold", 9)
        series.IsValueShownAsLabel = True ' Show values on bars
        series.LabelForeColor = Color.White ' Make label text white
        series.Color = Color.White



        Dim legendColors As New Dictionary(Of String, Color) From {
        {"Critical", Color.Red},
        {"Normal", Color.SteelBlue},
          {"Overstock", Color.Orange}
    }

        ' Add legend to the chart
        Dim legend As New Legend()
        legend.Docking = Docking.Top ' Dock the legend to the right
        legend.Font = New Font("Segoe UI", 10)
        legend.Alignment = StringAlignment.Near ' Align text to the right
        Chart1.Legends.Add(legend)

        ' Add legend items
        For Each entry In legendColors
            ' Create a new legend item
            Dim legendItem As New LegendItem()
            legendItem.Name = entry.Key ' Set the name for the legend item
            legendItem.Color = entry.Value ' Set the color for the legend item
            legendItem.BorderColor = Color.Transparent ' Optional: set border color
            legend.CustomItems.Add(legendItem) ' Add the legend item to the custom items
        Next




        ' Add data points to the series
        While reader.Read()
            Dim partno As String = reader("partno").ToString()
            Dim partname As String = reader("partname").ToString()
            Dim total As Integer = Convert.ToInt32(reader("TOTAL"))
            Dim min As Integer = Convert.ToInt32(reader("min"))
            Dim max As Integer = Convert.ToInt32(reader("max"))
            Dim colorcode As String = reader("color").ToString()
            ' Determine the bar color based on the min and max values
            Dim barColor As Color
            Dim note As String
            If total < min Then
                barColor = Color.Red ' Depleting stock
                note = "Alert: Critical" ' Depleting stock
            ElseIf total > max Then
                barColor = Color.Orange ' Overstocked
                note = "Alert: Overstocked" ' Overstocked
            Else
                barColor = Color.SteelBlue ' Normal stock
                note = "" ' Normal stock
            End If

            ' Create the X-axis label with partname, min, and max on two lines
            Dim xLabel As String = $"{partno}{vbCrLf}{partname}  {colorcode}{vbCrLf}{note}"

            ' Create a new DataPoint and assign the bar color
            Dim dataPoint As New DataPoint()
            dataPoint.AxisLabel = xLabel ' Set the X-axis label on two lines
            dataPoint.YValues = New Double() {total} ' Set the Y-axis value (total qty)
            dataPoint.Color = barColor ' Set the bar color based on stock status
            dataPoint.Font = New Font("Segoe UI Semibold", 10, FontStyle.Bold)
            dataPoint.LabelForeColor = Color.Blue
            ' Set the tooltip to show on hover
            dataPoint.ToolTip = $"Min: {min}{vbCrLf}Max: {max}"

            ' Add the data point to the series
            series.Points.Add(dataPoint)
        End While

        ' Add the series to the chart (no name set)
        Chart1.Series.Add(series)

        ' Add a title to the chart
        Dim title As New Title("Parts Inventory with Stock Status")
        title.Font = New Font("Segoe UI Semibold", 16, FontStyle.Bold)
        title.ForeColor = Color.DarkBlue
        Chart1.Titles.Add(title)

        ' Close the reader and connection
        reader.Close()
        con.Close()
    End Sub


    Public Sub LoadMemberProfiles()
        Try
            flow_loan.Controls.Clear()
            flow_loan.FlowDirection = FlowDirection.LeftToRight ' Set flow direction to left to right
            flow_loan.WrapContents = True ' Allow wrapping to next row when space is insufficient
            flow_loan.AutoScroll = True ' Enable scrolling if needed

            con.Close()
            con.Open()
            Dim query As String = "SELECT * from denso_parts_masterlist ORDER BY partname DESC"
            Dim cmd As New MySqlCommand(query, con)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                ' Create a new Guna2Panel for each member
                Dim memberPanel As New Guna2Panel()
                memberPanel.Width = (flow_loan.Width / 3) - 10 ' Set width so that two panels fit per row with space between them
                memberPanel.Height = 120
                memberPanel.BackColor = Color.White
                memberPanel.FillColor = Color.White ' Set the background to white
                memberPanel.BorderRadius = 10

                ' Set margin for spacing between panels (left, top, right, bottom)
                memberPanel.Margin = New Padding(20, 10, 20, 10)

                ' Set shadow properties
                memberPanel.ShadowDecoration.Parent = memberPanel
                memberPanel.ShadowDecoration.Color = Color.Silver ' Shadow color
                memberPanel.ShadowDecoration.Shadow = New Padding(5) ' Shadow depth/size
                memberPanel.ShadowDecoration.BorderRadius = 15 ' Same as panel's border radius for a smooth look
                memberPanel.ShadowDecoration.Enabled = True ' Enable shadow

                ' Label for member information
                Dim memberLabel As New Label()
                memberLabel.Font = New Font("Segoe UI", 12)
                memberLabel.ForeColor = Color.FromArgb(50, 50, 50)
                memberLabel.AutoSize = True
                memberLabel.Text = $"{reader("partname")}" & Environment.NewLine &
                   $"  {reader("partno")}" & Environment.NewLine &
                   $"" & Environment.NewLine &
                   $" Min: {reader("min")}             Max: {reader("max")}"

                memberLabel.Location = New Point(10, 15)

                ' Button for edit
                Dim editbtn As New Guna2Button() With {
                            .Text = "",
                            .Image = My.Resources.edit,
                            .Width = 65,
                            .Height = 30,
                            .ImageSize = New Size(40, 40),
                            .Dock = DockStyle.Right,
                            .Tag = reader("id"),
                            .FillColor = Color.Transparent}

                ' Add Label and Button to the Panel
                memberPanel.Controls.Add(memberLabel)
                memberPanel.Controls.Add(editbtn)

                ' Add Panel to the FlowLayoutPanel
                flow_loan.Controls.Add(memberPanel)

                ' Optional hover effect
                AddHandler memberPanel.MouseEnter, Sub(senderObj, eArgs)

                                                       memberPanel.FillColor = Color.FromArgb(240, 240, 240)
                                                       memberLabel.ForeColor = Color.FromArgb(30, 30, 30)

                                                   End Sub

                AddHandler memberPanel.MouseLeave, Sub(senderObj, eArgs)
                                                       memberPanel.BorderRadius = 10
                                                       memberPanel.FillColor = Color.White
                                                       memberLabel.ForeColor = Color.FromArgb(50, 50, 50)

                                                   End Sub

                AddHandler editbtn.Click, Sub(senderObj, eArgs)
                                              Dim btn As Guna2Button = CType(senderObj, Guna2Button)
                                              Dim loanreference As String = CType(btn.Tag, String)
                                              Dim form As New edit_tolerance
                                              form.loaddata(loanreference)
                                              form.ShowDialog()
                                              form.BringToFront()

                                          End Sub
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub flow_loan_Paint(sender As Object, e As PaintEventArgs) Handles flow_loan.Paint

    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then
            LoadMemberProfiles()
        Else
            Try
                flow_loan.Controls.Clear()
                flow_loan.FlowDirection = FlowDirection.LeftToRight ' Set flow direction to left to right
                flow_loan.WrapContents = True ' Allow wrapping to next row when space is insufficient
                flow_loan.AutoScroll = True ' Enable scrolling if needed

                con.Close()
                con.Open()
                Dim query As String = "SELECT * from denso_parts_masterlist WHERE partno REGEXP '" & txt_search.Text & "' or partname REGEXP '" & txt_search.Text & "' ORDER BY partname DESC "
                Dim cmd As New MySqlCommand(query, con)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ' Create a new Guna2Panel for each member
                    Dim memberPanel As New Guna2Panel()
                    memberPanel.Width = (flow_loan.Width / 3) - 10 ' Set width so that two panels fit per row with space between them
                    memberPanel.Height = 120
                    memberPanel.BackColor = Color.White
                    memberPanel.FillColor = Color.White ' Set the background to white
                    memberPanel.BorderRadius = 10

                    ' Set margin for spacing between panels (left, top, right, bottom)
                    memberPanel.Margin = New Padding(20, 10, 20, 10)

                    ' Set shadow properties
                    memberPanel.ShadowDecoration.Parent = memberPanel
                    memberPanel.ShadowDecoration.Color = Color.Silver ' Shadow color
                    memberPanel.ShadowDecoration.Shadow = New Padding(5) ' Shadow depth/size
                    memberPanel.ShadowDecoration.BorderRadius = 15 ' Same as panel's border radius for a smooth look
                    memberPanel.ShadowDecoration.Enabled = True ' Enable shadow

                    ' Label for member information
                    Dim memberLabel As New Label()
                    memberLabel.Font = New Font("Segoe UI", 12)
                    memberLabel.ForeColor = Color.FromArgb(50, 50, 50)
                    memberLabel.AutoSize = True
                    memberLabel.Text = $"{reader("partname")}" & Environment.NewLine &
                   $"  {reader("partno")}" & Environment.NewLine &
                   $"" & Environment.NewLine &
                   $" Min: {reader("min")}             Max: {reader("max")}"

                    memberLabel.Location = New Point(10, 15)

                    ' Button for edit
                    Dim editbtn As New Guna2Button() With {
                                .Text = "",
                                .Image = My.Resources.edit,
                                .Width = 65,
                                .Height = 30,
                                .ImageSize = New Size(40, 40),
                                .Dock = DockStyle.Right,
                                .Tag = reader("id"),
                                .FillColor = Color.Transparent}

                    ' Add Label and Button to the Panel
                    memberPanel.Controls.Add(memberLabel)
                    memberPanel.Controls.Add(editbtn)

                    ' Add Panel to the FlowLayoutPanel
                    flow_loan.Controls.Add(memberPanel)

                    ' Optional hover effect
                    AddHandler memberPanel.MouseEnter, Sub(senderObj, eArgs)

                                                           memberPanel.FillColor = Color.FromArgb(240, 240, 240)
                                                           memberLabel.ForeColor = Color.FromArgb(30, 30, 30)

                                                       End Sub

                    AddHandler memberPanel.MouseLeave, Sub(senderObj, eArgs)
                                                           memberPanel.BorderRadius = 10
                                                           memberPanel.FillColor = Color.White
                                                           memberLabel.ForeColor = Color.FromArgb(50, 50, 50)

                                                       End Sub

                    AddHandler editbtn.Click, Sub(senderObj, eArgs)
                                                  Dim btn As Guna2Button = CType(senderObj, Guna2Button)
                                                  Dim loanreference As String = CType(btn.Tag, String)
                                                  Dim form As New edit_tolerance
                                                  form.loaddata(loanreference)
                                                  form.ShowDialog()
                                                  form.BringToFront()

                                              End Sub
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        reload_graph()
    End Sub

    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        If table = Nothing Then
            MessageBox.Show("All Fields are required")
            Exit Sub
        End If

        If dt_from.Value > dt_to.Value Then
            MessageBox.Show("Invalid date range")
            Exit Sub
        End If
        dt = New DataTable()
            con.Close()
            con.Open()

        Select Case Guna2ComboBox1.Text
            Case "Date IN"
                If cmb_partno.Text = "All" Then
                    query = "SELECT * FROM " & table & "  WHERE datein BETWEEN '" & dt_from.Value.ToString("yyyy-MM-dd") & "' AND '" & dt_to.Value.ToString("yyyy-MM-dd") & "'  ORDER BY datein DESC"

                Else
                    query = "SELECT * FROM " & table & " WHERE partno = '" & cmb_partno.Text & "' AND datein BETWEEN '" & dt_from.Value.ToString("yyyy-MM-dd") & "' AND '" & dt_to.Value.ToString("yyyy-MM-dd") & "'  ORDER BY datein DESC"
                End If
            Case "Date OUT"
                If cmb_partno.Text = "All" Then
                    query = "SELECT * FROM " & table & " WHERE  datein BETWEEN '" & dt_from.Value.ToString("yyyy-MM-dd") & "' AND '" & dt_to.Value.ToString("yyyy-MM-dd") & "'  ORDER BY datein DESC"

                Else
                    query = "SELECT * FROM " & table & " WHERE partno = '" & cmb_partno.Text & "' AND datein BETWEEN '" & dt_from.Value.ToString("yyyy-MM-dd") & "' AND '" & dt_to.Value.ToString("yyyy-MM-dd") & "'  ORDER BY datein DESC"
                End If

        End Select
        Dim cmd As New MySqlCommand(query, con)

        da.SelectCommand = cmd
            da.Fill(dt)


        Try
            If dt.Rows.Count > 0 Then
                ' Save the data to an Excel file
                Using sfd As New SaveFileDialog()
                    sfd.Filter = "Excel Workbook|*.xlsx"
                    sfd.Title = "Save an Excel File"
                    sfd.ShowDialog()

                    If sfd.FileName <> "" Then
                        Using wb As New XLWorkbook()
                            wb.Worksheets.Add(dt, "Sheet1") ' Use the existing DataTable (dt)
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

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        Select Case cmb_type.Text
            Case "3T"
                load_export("denso_3t")

            Case "20CY"
                load_export("denso_20cy")

            Case "DMTN"
                load_export("denso_dmtn")

            Case "INTELLI IV"
                load_export("denso_intelli4")

            Case "JECO"
                load_export("denso_jeco")

            Case "YT"
                load_export("denso_yt")

            Case "TDE"
                load_export("denso_fg_scan")


        End Select


    End Sub
    Private Sub load_export(table1 As String)
        Try
            table = table1
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT DISTINCT(partno) FROM " & table1 & " ORDER BY partno DESC", con)
            dr = cmdselect.ExecuteReader
            cmb_partno.Items.Clear()
            cmb_partno.Items.Add("All")
            While (dr.Read())
                cmb_partno.Items.Add(dr.GetString("partno"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
