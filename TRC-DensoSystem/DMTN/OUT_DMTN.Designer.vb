<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OUT_DMTN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OUT_DMTN))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtqr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panel_toogle = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_fg_save = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_qty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_prod = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_series = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_line = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_machine = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_shift = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_color = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_customerno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_partno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panel_toogle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 203
        Me.Label5.Text = "QR Code :"
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
        Me.txtqr.Location = New System.Drawing.Point(29, 39)
        Me.txtqr.Name = "txtqr"
        Me.txtqr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqr.PlaceholderText = "Scan QR..."
        Me.txtqr.SelectedText = ""
        Me.txtqr.Size = New System.Drawing.Size(389, 36)
        Me.txtqr.TabIndex = 202
        '
        'panel_toogle
        '
        Me.panel_toogle.AutoScroll = True
        Me.panel_toogle.AutoScrollMargin = New System.Drawing.Size(0, 40)
        Me.panel_toogle.BackColor = System.Drawing.Color.Transparent
        Me.panel_toogle.Controls.Add(Me.btn_fg_save)
        Me.panel_toogle.Controls.Add(Me.Label9)
        Me.panel_toogle.Controls.Add(Me.txt_qty)
        Me.panel_toogle.Controls.Add(Me.Label4)
        Me.panel_toogle.Controls.Add(Me.txt_prod)
        Me.panel_toogle.Controls.Add(Me.Label8)
        Me.panel_toogle.Controls.Add(Me.txt_series)
        Me.panel_toogle.Controls.Add(Me.Label7)
        Me.panel_toogle.Controls.Add(Me.txt_line)
        Me.panel_toogle.Controls.Add(Me.Label6)
        Me.panel_toogle.Controls.Add(Me.txt_machine)
        Me.panel_toogle.Controls.Add(Me.Label1)
        Me.panel_toogle.Controls.Add(Me.txt_shift)
        Me.panel_toogle.Controls.Add(Me.Label2)
        Me.panel_toogle.Controls.Add(Me.txt_color)
        Me.panel_toogle.Controls.Add(Me.Label10)
        Me.panel_toogle.Controls.Add(Me.txt_customerno)
        Me.panel_toogle.Controls.Add(Me.Label19)
        Me.panel_toogle.Controls.Add(Me.txt_partno)
        Me.panel_toogle.Location = New System.Drawing.Point(29, 159)
        Me.panel_toogle.Name = "panel_toogle"
        Me.panel_toogle.Size = New System.Drawing.Size(644, 385)
        Me.panel_toogle.TabIndex = 204
        '
        'btn_fg_save
        '
        Me.btn_fg_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_fg_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_fg_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_fg_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_fg_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_fg_save.FillColor = System.Drawing.Color.DodgerBlue
        Me.btn_fg_save.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_fg_save.ForeColor = System.Drawing.Color.White
        Me.btn_fg_save.Image = CType(resources.GetObject("btn_fg_save.Image"), System.Drawing.Image)
        Me.btn_fg_save.Location = New System.Drawing.Point(243, 327)
        Me.btn_fg_save.Name = "btn_fg_save"
        Me.btn_fg_save.Size = New System.Drawing.Size(126, 37)
        Me.btn_fg_save.TabIndex = 68
        Me.btn_fg_save.Text = "ADD QR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(94, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Qty :"
        '
        'txt_qty
        '
        Me.txt_qty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qty.DefaultText = ""
        Me.txt_qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qty.Location = New System.Drawing.Point(94, 95)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qty.PlaceholderText = "..."
        Me.txt_qty.ReadOnly = True
        Me.txt_qty.SelectedText = ""
        Me.txt_qty.Size = New System.Drawing.Size(139, 36)
        Me.txt_qty.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(94, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Production Date :"
        '
        'txt_prod
        '
        Me.txt_prod.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_prod.DefaultText = ""
        Me.txt_prod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_prod.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_prod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_prod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_prod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_prod.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_prod.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_prod.Location = New System.Drawing.Point(94, 284)
        Me.txt_prod.Name = "txt_prod"
        Me.txt_prod.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_prod.PlaceholderText = "..."
        Me.txt_prod.ReadOnly = True
        Me.txt_prod.SelectedText = ""
        Me.txt_prod.Size = New System.Drawing.Size(139, 36)
        Me.txt_prod.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(399, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Series:"
        '
        'txt_series
        '
        Me.txt_series.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_series.DefaultText = ""
        Me.txt_series.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_series.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_series.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_series.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_series.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_series.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_series.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_series.Location = New System.Drawing.Point(399, 222)
        Me.txt_series.Name = "txt_series"
        Me.txt_series.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_series.PlaceholderText = "..."
        Me.txt_series.ReadOnly = True
        Me.txt_series.SelectedText = ""
        Me.txt_series.Size = New System.Drawing.Size(139, 36)
        Me.txt_series.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(399, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Line:"
        '
        'txt_line
        '
        Me.txt_line.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_line.DefaultText = ""
        Me.txt_line.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_line.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_line.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_line.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_line.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_line.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_line.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_line.Location = New System.Drawing.Point(399, 157)
        Me.txt_line.Name = "txt_line"
        Me.txt_line.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_line.PlaceholderText = "..."
        Me.txt_line.ReadOnly = True
        Me.txt_line.SelectedText = ""
        Me.txt_line.Size = New System.Drawing.Size(139, 36)
        Me.txt_line.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(399, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Machine :"
        '
        'txt_machine
        '
        Me.txt_machine.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_machine.DefaultText = ""
        Me.txt_machine.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_machine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_machine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_machine.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_machine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_machine.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_machine.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_machine.Location = New System.Drawing.Point(399, 95)
        Me.txt_machine.Name = "txt_machine"
        Me.txt_machine.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_machine.PlaceholderText = "..."
        Me.txt_machine.ReadOnly = True
        Me.txt_machine.SelectedText = ""
        Me.txt_machine.Size = New System.Drawing.Size(139, 36)
        Me.txt_machine.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(399, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Shift :"
        '
        'txt_shift
        '
        Me.txt_shift.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_shift.DefaultText = ""
        Me.txt_shift.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_shift.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_shift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_shift.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_shift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_shift.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_shift.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_shift.Location = New System.Drawing.Point(399, 39)
        Me.txt_shift.Name = "txt_shift"
        Me.txt_shift.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_shift.PlaceholderText = "..."
        Me.txt_shift.ReadOnly = True
        Me.txt_shift.SelectedText = ""
        Me.txt_shift.Size = New System.Drawing.Size(139, 36)
        Me.txt_shift.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(94, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Color code :"
        '
        'txt_color
        '
        Me.txt_color.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_color.DefaultText = ""
        Me.txt_color.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_color.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_color.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_color.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_color.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_color.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_color.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_color.Location = New System.Drawing.Point(94, 219)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_color.PlaceholderText = "..."
        Me.txt_color.ReadOnly = True
        Me.txt_color.SelectedText = ""
        Me.txt_color.Size = New System.Drawing.Size(139, 36)
        Me.txt_color.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Gray
        Me.Label10.Location = New System.Drawing.Point(94, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Customer no :"
        '
        'txt_customerno
        '
        Me.txt_customerno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_customerno.DefaultText = ""
        Me.txt_customerno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_customerno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_customerno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_customerno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_customerno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_customerno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_customerno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_customerno.Location = New System.Drawing.Point(94, 157)
        Me.txt_customerno.Name = "txt_customerno"
        Me.txt_customerno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_customerno.PlaceholderText = "..."
        Me.txt_customerno.ReadOnly = True
        Me.txt_customerno.SelectedText = ""
        Me.txt_customerno.Size = New System.Drawing.Size(139, 36)
        Me.txt_customerno.TabIndex = 18
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.ForeColor = System.Drawing.Color.Gray
        Me.Label19.Location = New System.Drawing.Point(94, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Partno :"
        '
        'txt_partno
        '
        Me.txt_partno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_partno.DefaultText = ""
        Me.txt_partno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_partno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_partno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_partno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_partno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_partno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_partno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_partno.Location = New System.Drawing.Point(94, 39)
        Me.txt_partno.Name = "txt_partno"
        Me.txt_partno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_partno.PlaceholderText = "..."
        Me.txt_partno.ReadOnly = True
        Me.txt_partno.SelectedText = ""
        Me.txt_partno.Size = New System.Drawing.Size(139, 36)
        Me.txt_partno.TabIndex = 5
        '
        'OUT_DMTN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 699)
        Me.Controls.Add(Me.panel_toogle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtqr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OUT_DMTN"
        Me.Text = "OUT_DMTN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_toogle.ResumeLayout(False)
        Me.panel_toogle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtqr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panel_toogle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_fg_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_qty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_prod As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_series As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_line As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_machine As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_shift As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_color As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_customerno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_partno As Guna.UI2.WinForms.Guna2TextBox
End Class
