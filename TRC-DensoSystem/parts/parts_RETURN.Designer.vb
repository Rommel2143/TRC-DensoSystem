<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class parts_RETURN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(parts_RETURN))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_close = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.Label()
        Me.error_panel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.txtqr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_qty = New System.Windows.Forms.Label()
        Me.lbl_partno = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.error_panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1251, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 205
        Me.PictureBox1.TabStop = False
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageRotate = 0!
        Me.btn_close.Location = New System.Drawing.Point(1367, 5)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(15, 15)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 2
        Me.btn_close.TabStop = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(12, 2)
        Me.Guna2PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(23, 23)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 1
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Panel2.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.Label10)
        Me.Guna2Panel2.Controls.Add(Me.txtdate)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1391, 20)
        Me.Guna2Panel2.TabIndex = 205
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(0, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 21)
        Me.Label10.TabIndex = 204
        Me.Label10.Text = "Parts Return"
        '
        'txtdate
        '
        Me.txtdate.AutoSize = True
        Me.txtdate.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.ForeColor = System.Drawing.Color.White
        Me.txtdate.Location = New System.Drawing.Point(1272, 0)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(119, 20)
        Me.txtdate.TabIndex = 1
        Me.txtdate.Text = "MMMM-dd-yyyy"
        Me.txtdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'error_panel
        '
        Me.error_panel.Controls.Add(Me.btn_close)
        Me.error_panel.Controls.Add(Me.Guna2PictureBox3)
        Me.error_panel.Controls.Add(Me.lbl_error)
        Me.error_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.error_panel.FillColor = System.Drawing.Color.Red
        Me.error_panel.FillColor2 = System.Drawing.Color.Salmon
        Me.error_panel.Location = New System.Drawing.Point(0, 20)
        Me.error_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.error_panel.Name = "error_panel"
        Me.error_panel.Size = New System.Drawing.Size(1391, 27)
        Me.error_panel.TabIndex = 207
        Me.error_panel.Visible = False
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.BackColor = System.Drawing.Color.Transparent
        Me.lbl_error.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.White
        Me.lbl_error.Location = New System.Drawing.Point(41, 6)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(119, 17)
        Me.lbl_error.TabIndex = 0
        Me.lbl_error.Text = "Invalid Credentials"
        '
        'txtqr
        '
        Me.txtqr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtqr.DefaultText = ""
        Me.txtqr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtqr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtqr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtqr.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqr.IconLeft = CType(resources.GetObject("txtqr.IconLeft"), System.Drawing.Image)
        Me.txtqr.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtqr.Location = New System.Drawing.Point(54, 89)
        Me.txtqr.Name = "txtqr"
        Me.txtqr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqr.PlaceholderText = "Scan QR..."
        Me.txtqr.SelectedText = ""
        Me.txtqr.Size = New System.Drawing.Size(438, 36)
        Me.txtqr.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lbl_qty)
        Me.Panel2.Controls.Add(Me.lbl_partno)
        Me.Panel2.Controls.Add(Me.error_panel)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel2.Controls.Add(Me.Guna2Panel2)
        Me.Panel2.Controls.Add(Me.txtqr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1391, 369)
        Me.Panel2.TabIndex = 10
        '
        'lbl_qty
        '
        Me.lbl_qty.AutoSize = True
        Me.lbl_qty.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qty.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_qty.Location = New System.Drawing.Point(281, 172)
        Me.lbl_qty.Name = "lbl_qty"
        Me.lbl_qty.Size = New System.Drawing.Size(19, 21)
        Me.lbl_qty.TabIndex = 213
        Me.lbl_qty.Text = "0"
        '
        'lbl_partno
        '
        Me.lbl_partno.AutoSize = True
        Me.lbl_partno.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partno.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_partno.Location = New System.Drawing.Point(160, 141)
        Me.lbl_partno.Name = "lbl_partno"
        Me.lbl_partno.Size = New System.Drawing.Size(28, 21)
        Me.lbl_partno.TabIndex = 212
        Me.lbl_partno.Text = "---"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(54, 141)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(81, 65)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 210
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(160, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "Returned QTY:"
        '
        'parts_RETURN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1391, 770)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "parts_RETURN"
        Me.Text = "parts_RETURN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.error_panel.ResumeLayout(False)
        Me.error_panel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdate As Label
    Friend WithEvents error_panel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents lbl_error As Label
    Friend WithEvents txtqr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_qty As Label
    Friend WithEvents lbl_partno As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
End Class
