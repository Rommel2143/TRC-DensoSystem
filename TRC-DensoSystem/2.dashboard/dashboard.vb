

Imports MySql.Data.MySqlClient
Imports System.Drawing ' Ensure this is imported for Color
Imports Guna.Charts.WinForms
Imports Guna.UI2.WinForms
Public Class dashboard
    Private Sub memo_analytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload_all()
        LoadMemberProfiles()
    End Sub


    Private Sub reload_all()
        Try
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("SELECT dp.partno, pm.partname, SUM(qty) AS TOTAL, pm.min, pm.max 
                                              FROM denso_parts dp
                                              JOIN denso_parts_masterlist pm ON pm.partno = dp.partno
                                              WHERE status = 1 
                                              GROUP BY dp.partno", con)

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim gunahorizontalbardataset As New DataSet()

            ' Fill the dataset with data
            adapter.Fill(gunahorizontalbardataset, "PARTS STOCK MONITORING")

            ' Clear existing points in bardataset by reinitializing it
            bardataset = New GunaHorizontalBarDataset()
            bardataset.Label = "Total Stock"

            ' Populate bardataset with data from the dataset
            For Each row As DataRow In gunahorizontalbardataset.Tables("PARTS STOCK MONITORING").Rows
                Dim partName As String = row("partname").ToString()
                Dim total As Integer = Convert.ToInt32(row("TOTAL"))
                Dim min As Integer = Convert.ToInt32(row("min"))
                Dim max As Integer = Convert.ToInt32(row("max"))

                ' Determine the color based on stock levels
                Dim barColor As Color
                If total < min Then
                    barColor = Color.Red ' Depleting
                ElseIf total > max Then
                    barColor = Color.Orange ' Overstocked
                Else
                    barColor = Color.Blue ' Normal stock
                End If

                ' Add the data point with the determined color
                bardataset.DataPoints.Add(partName, total)


            Next

            ' Add bardataset to Chart1 and refresh the chart
            Chart1.Datasets.Clear()
            Chart1.Datasets.Add(bardataset)
            Chart1.Update()

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message)
        End Try
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
                memberPanel.Width = (flow_loan.Width / 3) ' Set width so that two panels fit per row with space between them
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
                               $" Min: {reader("min")}             Max: {reader("min")}"

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
                    memberPanel.Width = (flow_loan.Width / 3) ' Set width so that two panels fit per row with space between them
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
                                   $" Min: {reader("min")}             Max: {reader("min")}"

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
End Class
