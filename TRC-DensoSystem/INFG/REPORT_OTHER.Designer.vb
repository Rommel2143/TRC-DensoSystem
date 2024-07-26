<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORT_OTHER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxdate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.boxtype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.boxshift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(414, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 181
        Me.Label5.Text = "Date :"
        '
        'boxdate
        '
        Me.boxdate.BackColor = System.Drawing.Color.Transparent
        Me.boxdate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.boxdate.DropDownHeight = 200
        Me.boxdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxdate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxdate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.boxdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.boxdate.IntegralHeight = False
        Me.boxdate.ItemHeight = 20
        Me.boxdate.Location = New System.Drawing.Point(455, 27)
        Me.boxdate.Name = "boxdate"
        Me.boxdate.Size = New System.Drawing.Size(149, 26)
        Me.boxdate.TabIndex = 180
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 75)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1010, 657)
        Me.CrystalReportViewer1.TabIndex = 182
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "Type :"
        '
        'boxtype
        '
        Me.boxtype.BackColor = System.Drawing.Color.Transparent
        Me.boxtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.boxtype.DropDownHeight = 200
        Me.boxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxtype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxtype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.boxtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.boxtype.IntegralHeight = False
        Me.boxtype.ItemHeight = 20
        Me.boxtype.Location = New System.Drawing.Point(249, 27)
        Me.boxtype.Name = "boxtype"
        Me.boxtype.Size = New System.Drawing.Size(149, 26)
        Me.boxtype.TabIndex = 183
        '
        'boxshift
        '
        Me.boxshift.BackColor = System.Drawing.Color.Transparent
        Me.boxshift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.boxshift.DropDownHeight = 200
        Me.boxshift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxshift.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxshift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxshift.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.boxshift.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.boxshift.IntegralHeight = False
        Me.boxshift.ItemHeight = 20
        Me.boxshift.Items.AddRange(New Object() {"DAY SHIFT", "NIGHT SHIFT"})
        Me.boxshift.Location = New System.Drawing.Point(662, 27)
        Me.boxshift.Name = "boxshift"
        Me.boxshift.Size = New System.Drawing.Size(149, 26)
        Me.boxshift.TabIndex = 188
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(619, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 187
        Me.Label12.Text = "Shift :"
        '
        'REPORT_OTHER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 739)
        Me.Controls.Add(Me.boxshift)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.boxtype)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.boxdate)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "REPORT_OTHER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORT_OTHER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents boxdate As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents boxtype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents boxshift As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label12 As Label
End Class
