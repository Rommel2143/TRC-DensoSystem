<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INFG
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INFG))
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panelset = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtmatcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtqty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlot = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbprocess = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtoperator = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbline = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtuser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labelerror = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtshift = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtqr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtname = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.panelset.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToAddRows = False
        Me.datagrid1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid1.ColumnHeadersHeight = 30
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(0, 211)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.ReadOnly = True
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.Size = New System.Drawing.Size(1193, 391)
        Me.datagrid1.TabIndex = 192
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid1.ThemeStyle.HeaderStyle.Height = 30
        Me.datagrid1.ThemeStyle.ReadOnly = True
        Me.datagrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.cmbsearch)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 161)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1193, 50)
        Me.Guna2Panel1.TabIndex = 181
        '
        'cmbsearch
        '
        Me.cmbsearch.AutoRoundedCorners = True
        Me.cmbsearch.BorderRadius = 15
        Me.cmbsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbsearch.DefaultText = ""
        Me.cmbsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.cmbsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.cmbsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cmbsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.cmbsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.cmbsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbsearch.IconLeft = CType(resources.GetObject("cmbsearch.IconLeft"), System.Drawing.Image)
        Me.cmbsearch.Location = New System.Drawing.Point(24, 10)
        Me.cmbsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cmbsearch.PlaceholderText = "Enter Line or Process..."
        Me.cmbsearch.SelectedText = ""
        Me.cmbsearch.Size = New System.Drawing.Size(224, 32)
        Me.cmbsearch.TabIndex = 207
        '
        'panelset
        '
        Me.panelset.Controls.Add(Me.txtmatcode)
        Me.panelset.Controls.Add(Me.Guna2Panel1)
        Me.panelset.Controls.Add(Me.txtqty)
        Me.panelset.Controls.Add(Me.Label1)
        Me.panelset.Controls.Add(Me.txtlot)
        Me.panelset.Controls.Add(Me.cmbprocess)
        Me.panelset.Controls.Add(Me.Label5)
        Me.panelset.Controls.Add(Me.Label3)
        Me.panelset.Controls.Add(Me.txtoperator)
        Me.panelset.Controls.Add(Me.cmbline)
        Me.panelset.Controls.Add(Me.txtuser)
        Me.panelset.Controls.Add(Me.Label13)
        Me.panelset.Controls.Add(Me.txtbox)
        Me.panelset.Controls.Add(Me.labelerror)
        Me.panelset.Controls.Add(Me.Label12)
        Me.panelset.Controls.Add(Me.txtshift)
        Me.panelset.Controls.Add(Me.Label4)
        Me.panelset.Controls.Add(Me.txtdate)
        Me.panelset.Controls.Add(Me.Label2)
        Me.panelset.Controls.Add(Me.txtqr)
        Me.panelset.Controls.Add(Me.txtcode)
        Me.panelset.Controls.Add(Me.Label9)
        Me.panelset.Controls.Add(Me.txtname)
        Me.panelset.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelset.Enabled = False
        Me.panelset.Location = New System.Drawing.Point(0, 0)
        Me.panelset.Name = "panelset"
        Me.panelset.Size = New System.Drawing.Size(1193, 211)
        Me.panelset.TabIndex = 191
        '
        'txtmatcode
        '
        Me.txtmatcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmatcode.DefaultText = ""
        Me.txtmatcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmatcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmatcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmatcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmatcode.Enabled = False
        Me.txtmatcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmatcode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmatcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmatcode.Location = New System.Drawing.Point(775, 114)
        Me.txtmatcode.Name = "txtmatcode"
        Me.txtmatcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmatcode.PlaceholderText = "Matcode..."
        Me.txtmatcode.SelectedText = ""
        Me.txtmatcode.Size = New System.Drawing.Size(130, 23)
        Me.txtmatcode.TabIndex = 182
        '
        'txtqty
        '
        Me.txtqty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtqty.DefaultText = ""
        Me.txtqty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtqty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtqty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqty.Enabled = False
        Me.txtqty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqty.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtqty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqty.Location = New System.Drawing.Point(536, 114)
        Me.txtqty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqty.PlaceholderText = "Quantity..."
        Me.txtqty.SelectedText = ""
        Me.txtqty.Size = New System.Drawing.Size(100, 23)
        Me.txtqty.TabIndex = 180
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(436, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Quantity / Lotno :"
        '
        'txtlot
        '
        Me.txtlot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlot.DefaultText = ""
        Me.txtlot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtlot.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtlot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtlot.Enabled = False
        Me.txtlot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtlot.Location = New System.Drawing.Point(642, 114)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlot.PlaceholderText = "Lot number..."
        Me.txtlot.SelectedText = ""
        Me.txtlot.Size = New System.Drawing.Size(130, 23)
        Me.txtlot.TabIndex = 178
        '
        'cmbprocess
        '
        Me.cmbprocess.BackColor = System.Drawing.Color.Transparent
        Me.cmbprocess.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbprocess.DropDownHeight = 200
        Me.cmbprocess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbprocess.Enabled = False
        Me.cmbprocess.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbprocess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbprocess.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbprocess.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbprocess.IntegralHeight = False
        Me.cmbprocess.ItemHeight = 30
        Me.cmbprocess.Location = New System.Drawing.Point(269, 72)
        Me.cmbprocess.Name = "cmbprocess"
        Me.cmbprocess.Size = New System.Drawing.Size(141, 36)
        Me.cmbprocess.TabIndex = 177
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 176
        Me.Label5.Text = "Line / Process :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Scanner / Operator :"
        '
        'txtoperator
        '
        Me.txtoperator.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtoperator.DefaultText = ""
        Me.txtoperator.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtoperator.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtoperator.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtoperator.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtoperator.Enabled = False
        Me.txtoperator.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoperator.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtoperator.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoperator.Location = New System.Drawing.Point(269, 36)
        Me.txtoperator.Name = "txtoperator"
        Me.txtoperator.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtoperator.PlaceholderText = "Operator..."
        Me.txtoperator.SelectedText = ""
        Me.txtoperator.Size = New System.Drawing.Size(141, 30)
        Me.txtoperator.TabIndex = 174
        '
        'cmbline
        '
        Me.cmbline.BackColor = System.Drawing.Color.Transparent
        Me.cmbline.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbline.DropDownHeight = 200
        Me.cmbline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbline.Enabled = False
        Me.cmbline.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbline.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbline.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbline.IntegralHeight = False
        Me.cmbline.ItemHeight = 30
        Me.cmbline.Items.AddRange(New Object() {"Line 1", "Line 2", "Line 3", "Line 4", "Line 5", "Line 6", "Line 7", "Line 8", "Line 9", "Line 10"})
        Me.cmbline.Location = New System.Drawing.Point(122, 72)
        Me.cmbline.Name = "cmbline"
        Me.cmbline.Size = New System.Drawing.Size(141, 36)
        Me.cmbline.TabIndex = 173
        '
        'txtuser
        '
        Me.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtuser.DefaultText = ""
        Me.txtuser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtuser.Enabled = False
        Me.txtuser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuser.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtuser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtuser.Location = New System.Drawing.Point(122, 36)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtuser.PlaceholderText = "Scanner...."
        Me.txtuser.SelectedText = ""
        Me.txtuser.Size = New System.Drawing.Size(141, 30)
        Me.txtuser.TabIndex = 172
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(482, 46)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 171
        Me.Label13.Text = "Box no :"
        '
        'txtbox
        '
        Me.txtbox.BackColor = System.Drawing.SystemColors.Control
        Me.txtbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox.DefaultText = ""
        Me.txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox.Enabled = False
        Me.txtbox.FillColor = System.Drawing.SystemColors.Info
        Me.txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox.Location = New System.Drawing.Point(536, 46)
        Me.txtbox.Margin = New System.Windows.Forms.Padding(5)
        Me.txtbox.Name = "txtbox"
        Me.txtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox.PlaceholderText = "Box no..."
        Me.txtbox.SelectedText = ""
        Me.txtbox.Size = New System.Drawing.Size(102, 34)
        Me.txtbox.TabIndex = 170
        '
        'labelerror
        '
        Me.labelerror.AutoSize = True
        Me.labelerror.BackColor = System.Drawing.Color.Red
        Me.labelerror.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelerror.ForeColor = System.Drawing.Color.White
        Me.labelerror.Location = New System.Drawing.Point(764, 55)
        Me.labelerror.Name = "labelerror"
        Me.labelerror.Size = New System.Drawing.Size(139, 25)
        Me.labelerror.TabIndex = 169
        Me.labelerror.Text = "INVALID QR"
        Me.labelerror.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(276, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 168
        Me.Label12.Text = "Shift :"
        '
        'txtshift
        '
        Me.txtshift.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtshift.DefaultText = ""
        Me.txtshift.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtshift.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtshift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtshift.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtshift.Enabled = False
        Me.txtshift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtshift.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtshift.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtshift.Location = New System.Drawing.Point(319, 8)
        Me.txtshift.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtshift.Name = "txtshift"
        Me.txtshift.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtshift.PlaceholderText = "shift..."
        Me.txtshift.SelectedText = ""
        Me.txtshift.Size = New System.Drawing.Size(91, 23)
        Me.txtshift.TabIndex = 167
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "Date :"
        '
        'txtdate
        '
        Me.txtdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdate.DefaultText = ""
        Me.txtdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdate.Enabled = False
        Me.txtdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdate.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdate.Location = New System.Drawing.Point(122, 8)
        Me.txtdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdate.PlaceholderText = "date..."
        Me.txtdate.SelectedText = ""
        Me.txtdate.Size = New System.Drawing.Size(141, 23)
        Me.txtdate.TabIndex = 165
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(474, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "QR code :"
        '
        'txtqr
        '
        Me.txtqr.BackColor = System.Drawing.SystemColors.Control
        Me.txtqr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtqr.DefaultText = ""
        Me.txtqr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtqr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtqr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtqr.Enabled = False
        Me.txtqr.FillColor = System.Drawing.SystemColors.Info
        Me.txtqr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqr.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txtqr.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqr.Location = New System.Drawing.Point(536, 12)
        Me.txtqr.Name = "txtqr"
        Me.txtqr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqr.PlaceholderText = "Scan QR..."
        Me.txtqr.SelectedText = ""
        Me.txtqr.Size = New System.Drawing.Size(369, 30)
        Me.txtqr.TabIndex = 163
        '
        'txtcode
        '
        Me.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcode.DefaultText = ""
        Me.txtcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcode.Enabled = False
        Me.txtcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcode.Location = New System.Drawing.Point(536, 85)
        Me.txtcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcode.PlaceholderText = "Partcode..."
        Me.txtcode.SelectedText = ""
        Me.txtcode.Size = New System.Drawing.Size(100, 23)
        Me.txtcode.TabIndex = 159
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(418, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 13)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Partcode / Partname :"
        '
        'txtname
        '
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.DefaultText = ""
        Me.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.Enabled = False
        Me.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Location = New System.Drawing.Point(642, 85)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.PlaceholderText = "Part name..."
        Me.txtname.SelectedText = ""
        Me.txtname.Size = New System.Drawing.Size(263, 23)
        Me.txtname.TabIndex = 133
        '
        'INFG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 602)
        Me.Controls.Add(Me.datagrid1)
        Me.Controls.Add(Me.panelset)
        Me.Name = "INFG"
        Me.Text = "INFG"
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.panelset.ResumeLayout(False)
        Me.panelset.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panelset As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtmatcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtqty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlot As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbprocess As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtoperator As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbline As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtuser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labelerror As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtshift As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtqr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtname As Guna.UI2.WinForms.Guna2TextBox
End Class
