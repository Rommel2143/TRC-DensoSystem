<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class REPORT_TDE
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.boxdate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_shift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(227, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 178
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
        Me.boxdate.Location = New System.Drawing.Point(268, 12)
        Me.boxdate.Name = "boxdate"
        Me.boxdate.Size = New System.Drawing.Size(209, 26)
        Me.boxdate.TabIndex = 177
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 45)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1026, 689)
        Me.CrystalReportViewer1.TabIndex = 179
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(487, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Shift :"
        '
        'cmb_shift
        '
        Me.cmb_shift.BackColor = System.Drawing.Color.Transparent
        Me.cmb_shift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_shift.DropDownHeight = 200
        Me.cmb_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_shift.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_shift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_shift.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_shift.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_shift.IntegralHeight = False
        Me.cmb_shift.ItemHeight = 20
        Me.cmb_shift.Items.AddRange(New Object() {"NIGHT SHIFT", "DAY SHIFT"})
        Me.cmb_shift.Location = New System.Drawing.Point(530, 12)
        Me.cmb_shift.Name = "cmb_shift"
        Me.cmb_shift.Size = New System.Drawing.Size(209, 26)
        Me.cmb_shift.TabIndex = 180
        '
        'REPORT_TDE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 778)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_shift)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.boxdate)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "REPORT_TDE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents boxdate As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_shift As Guna.UI2.WinForms.Guna2ComboBox
End Class
