﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class export_dmtn
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.rad_w = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rad_wo = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.dtpicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_cml = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 127)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1050, 651)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2Panel1)
        Me.Panel1.Controls.Add(Me.dtpicker)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmb_cml)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1050, 127)
        Me.Panel1.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.DimGray
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.rad_w)
        Me.Guna2Panel1.Controls.Add(Me.rad_wo)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(717, 56)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.Size = New System.Drawing.Size(286, 39)
        Me.Guna2Panel1.TabIndex = 229
        '
        'rad_w
        '
        Me.rad_w.AutoSize = True
        Me.rad_w.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rad_w.CheckedState.BorderThickness = 0
        Me.rad_w.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rad_w.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rad_w.CheckedState.InnerOffset = -4
        Me.rad_w.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_w.Location = New System.Drawing.Point(162, 9)
        Me.rad_w.Name = "rad_w"
        Me.rad_w.Size = New System.Drawing.Size(109, 21)
        Me.rad_w.TabIndex = 228
        Me.rad_w.Text = "with InnerTag"
        Me.rad_w.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rad_w.UncheckedState.BorderThickness = 2
        Me.rad_w.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rad_w.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'rad_wo
        '
        Me.rad_wo.AutoSize = True
        Me.rad_wo.Checked = True
        Me.rad_wo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rad_wo.CheckedState.BorderThickness = 0
        Me.rad_wo.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rad_wo.CheckedState.InnerColor = System.Drawing.Color.White
        Me.rad_wo.CheckedState.InnerOffset = -4
        Me.rad_wo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rad_wo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rad_wo.Location = New System.Drawing.Point(10, 9)
        Me.rad_wo.Name = "rad_wo"
        Me.rad_wo.Size = New System.Drawing.Size(105, 21)
        Me.rad_wo.TabIndex = 227
        Me.rad_wo.TabStop = True
        Me.rad_wo.Text = "w/o InnerTag"
        Me.rad_wo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.rad_wo.UncheckedState.BorderThickness = 2
        Me.rad_wo.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rad_wo.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'dtpicker
        '
        Me.dtpicker.Checked = True
        Me.dtpicker.FillColor = System.Drawing.SystemColors.HotTrack
        Me.dtpicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpicker.ForeColor = System.Drawing.Color.White
        Me.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpicker.Location = New System.Drawing.Point(52, 59)
        Me.dtpicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpicker.Name = "dtpicker"
        Me.dtpicker.Size = New System.Drawing.Size(200, 36)
        Me.dtpicker.TabIndex = 226
        Me.dtpicker.Value = New Date(2024, 8, 3, 14, 18, 59, 924)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(49, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 225
        Me.Label2.Text = "Date :"
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
        Me.cmb_cml.Location = New System.Drawing.Point(326, 59)
        Me.cmb_cml.Name = "cmb_cml"
        Me.cmb_cml.Size = New System.Drawing.Size(372, 36)
        Me.cmb_cml.TabIndex = 224
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(323, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 223
        Me.Label3.Text = "CML :"
        '
        'export_dmtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 778)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "export_dmtn"
        Me.Text = "export_dmtn"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmb_cml As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents rad_w As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rad_wo As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
