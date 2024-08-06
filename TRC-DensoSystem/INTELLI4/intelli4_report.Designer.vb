<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class intelli4_report
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbuser = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmb_cml = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 131)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1362, 614)
        Me.CrystalReportViewer1.TabIndex = 7
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.cmbuser)
        Me.Guna2Panel1.Controls.Add(Me.cmb_cml)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.dtpicker)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1362, 131)
        Me.Guna2Panel1.TabIndex = 8
        '
        'cmbuser
        '
        Me.cmbuser.BackColor = System.Drawing.Color.Transparent
        Me.cmbuser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbuser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbuser.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbuser.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbuser.ItemHeight = 30
        Me.cmbuser.Location = New System.Drawing.Point(312, 44)
        Me.cmbuser.Name = "cmbuser"
        Me.cmbuser.Size = New System.Drawing.Size(223, 36)
        Me.cmbuser.TabIndex = 221
        '
        'cmb_cml
        '
        Me.cmb_cml.BackColor = System.Drawing.Color.Transparent
        Me.cmb_cml.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_cml.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cml.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_cml.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_cml.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_cml.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_cml.ItemHeight = 30
        Me.cmb_cml.Location = New System.Drawing.Point(570, 44)
        Me.cmb_cml.Name = "cmb_cml"
        Me.cmb_cml.Size = New System.Drawing.Size(223, 36)
        Me.cmb_cml.TabIndex = 222
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(576, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 220
        Me.Label3.Text = "CML :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(309, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 219
        Me.Label1.Text = "User :"
        '
        'dtpicker
        '
        Me.dtpicker.Checked = True
        Me.dtpicker.FillColor = System.Drawing.SystemColors.HotTrack
        Me.dtpicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpicker.ForeColor = System.Drawing.Color.White
        Me.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker.Location = New System.Drawing.Point(70, 44)
        Me.dtpicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker.Name = "dtpicker"
        Me.dtpicker.Size = New System.Drawing.Size(200, 36)
        Me.dtpicker.TabIndex = 218
        Me.dtpicker.Value = New Date(2024, 8, 3, 14, 18, 59, 924)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(67, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "Date :"
        '
        'intelli4_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 745)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "intelli4_report"
        Me.Text = " "
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbuser As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmb_cml As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
End Class
