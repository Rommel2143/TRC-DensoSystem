<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class INFG
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(INFG))
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cmbsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panelset = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtproddate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labelerror2 = New System.Windows.Forms.Label()
        Me.boxshift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtcustomer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmodel = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtqty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtlot = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtoperator = New Guna.UI2.WinForms.Guna2TextBox()
        Me.boxtype = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.labelerror1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtqr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txthide = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txthide1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcolor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtcolor1 = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.panelset.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToAddRows = False
        Me.datagrid1.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.datagrid1.ColumnHeadersHeight = 30
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle12
        Me.datagrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(0, 232)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.ReadOnly = True
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.Size = New System.Drawing.Size(1193, 370)
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
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 181)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1193, 51)
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
        Me.cmbsearch.PlaceholderText = "Enter part number..."
        Me.cmbsearch.SelectedText = ""
        Me.cmbsearch.Size = New System.Drawing.Size(224, 32)
        Me.cmbsearch.TabIndex = 207
        '
        'panelset
        '
        Me.panelset.Controls.Add(Me.txtcolor1)
        Me.panelset.Controls.Add(Me.txtcolor)
        Me.panelset.Controls.Add(Me.txthide1)
        Me.panelset.Controls.Add(Me.txthide)
        Me.panelset.Controls.Add(Me.Panel1)
        Me.panelset.Controls.Add(Me.txtproddate)
        Me.panelset.Controls.Add(Me.labelerror2)
        Me.panelset.Controls.Add(Me.boxshift)
        Me.panelset.Controls.Add(Me.txtcustomer)
        Me.panelset.Controls.Add(Me.Label6)
        Me.panelset.Controls.Add(Me.txtmodel)
        Me.panelset.Controls.Add(Me.Guna2Panel1)
        Me.panelset.Controls.Add(Me.txtqty)
        Me.panelset.Controls.Add(Me.Label1)
        Me.panelset.Controls.Add(Me.txtlot)
        Me.panelset.Controls.Add(Me.Label5)
        Me.panelset.Controls.Add(Me.Label3)
        Me.panelset.Controls.Add(Me.txtoperator)
        Me.panelset.Controls.Add(Me.boxtype)
        Me.panelset.Controls.Add(Me.labelerror1)
        Me.panelset.Controls.Add(Me.Label12)
        Me.panelset.Controls.Add(Me.Label4)
        Me.panelset.Controls.Add(Me.txtdate)
        Me.panelset.Controls.Add(Me.Label2)
        Me.panelset.Controls.Add(Me.txtqr)
        Me.panelset.Controls.Add(Me.txtcode)
        Me.panelset.Controls.Add(Me.Label9)
        Me.panelset.Controls.Add(Me.txtname)
        Me.panelset.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelset.Location = New System.Drawing.Point(0, 0)
        Me.panelset.Name = "panelset"
        Me.panelset.Size = New System.Drawing.Size(1193, 232)
        Me.panelset.TabIndex = 191
        '
        'txtproddate
        '
        Me.txtproddate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtproddate.DefaultText = ""
        Me.txtproddate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtproddate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtproddate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtproddate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtproddate.Enabled = False
        Me.txtproddate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtproddate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproddate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtproddate.Location = New System.Drawing.Point(867, 85)
        Me.txtproddate.Name = "txtproddate"
        Me.txtproddate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtproddate.PlaceholderText = "Production Date..."
        Me.txtproddate.SelectedText = ""
        Me.txtproddate.Size = New System.Drawing.Size(131, 23)
        Me.txtproddate.TabIndex = 188
        '
        'labelerror2
        '
        Me.labelerror2.AutoSize = True
        Me.labelerror2.BackColor = System.Drawing.Color.Red
        Me.labelerror2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelerror2.ForeColor = System.Drawing.Color.White
        Me.labelerror2.Location = New System.Drawing.Point(1012, 79)
        Me.labelerror2.Name = "labelerror2"
        Me.labelerror2.Size = New System.Drawing.Size(178, 25)
        Me.labelerror2.TabIndex = 187
        Me.labelerror2.Text = "DUPLICATE QR"
        Me.labelerror2.Visible = False
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
        Me.boxshift.Location = New System.Drawing.Point(320, 55)
        Me.boxshift.Name = "boxshift"
        Me.boxshift.Size = New System.Drawing.Size(149, 26)
        Me.boxshift.TabIndex = 186
        '
        'txtcustomer
        '
        Me.txtcustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcustomer.DefaultText = ""
        Me.txtcustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcustomer.Enabled = False
        Me.txtcustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustomer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustomer.Location = New System.Drawing.Point(629, 85)
        Me.txtcustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcustomer.Name = "txtcustomer"
        Me.txtcustomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcustomer.PlaceholderText = "Customer Part no..."
        Me.txtcustomer.SelectedText = ""
        Me.txtcustomer.Size = New System.Drawing.Size(236, 23)
        Me.txtcustomer.TabIndex = 185
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(520, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 184
        Me.Label6.Text = "Customer Part no. :"
        '
        'txtmodel
        '
        Me.txtmodel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmodel.DefaultText = ""
        Me.txtmodel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtmodel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtmodel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmodel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtmodel.Enabled = False
        Me.txtmodel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmodel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodel.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmodel.Location = New System.Drawing.Point(867, 139)
        Me.txtmodel.Name = "txtmodel"
        Me.txtmodel.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmodel.PlaceholderText = "Model..."
        Me.txtmodel.SelectedText = ""
        Me.txtmodel.Size = New System.Drawing.Size(65, 23)
        Me.txtmodel.TabIndex = 182
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
        Me.txtqty.Location = New System.Drawing.Point(629, 139)
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
        Me.Label1.Location = New System.Drawing.Point(450, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 13)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Quantity / Lotno / Model / Color :"
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
        Me.txtlot.Location = New System.Drawing.Point(735, 139)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtlot.PlaceholderText = "Lot number..."
        Me.txtlot.SelectedText = ""
        Me.txtlot.Size = New System.Drawing.Size(130, 23)
        Me.txtlot.TabIndex = 178
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 176
        Me.Label5.Text = "Type :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 88)
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
        Me.txtoperator.Location = New System.Drawing.Point(123, 85)
        Me.txtoperator.Name = "txtoperator"
        Me.txtoperator.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtoperator.PlaceholderText = "Operator..."
        Me.txtoperator.SelectedText = ""
        Me.txtoperator.Size = New System.Drawing.Size(346, 30)
        Me.txtoperator.TabIndex = 174
        '
        'boxtype
        '
        Me.boxtype.BackColor = System.Drawing.Color.Transparent
        Me.boxtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.boxtype.DropDownHeight = 200
        Me.boxtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.boxtype.Enabled = False
        Me.boxtype.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.boxtype.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.boxtype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.boxtype.IntegralHeight = False
        Me.boxtype.ItemHeight = 20
        Me.boxtype.Location = New System.Drawing.Point(123, 119)
        Me.boxtype.Name = "boxtype"
        Me.boxtype.Size = New System.Drawing.Size(346, 26)
        Me.boxtype.TabIndex = 173
        '
        'labelerror1
        '
        Me.labelerror1.AutoSize = True
        Me.labelerror1.BackColor = System.Drawing.Color.Red
        Me.labelerror1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelerror1.ForeColor = System.Drawing.Color.White
        Me.labelerror1.Location = New System.Drawing.Point(1027, 112)
        Me.labelerror1.Name = "labelerror1"
        Me.labelerror1.Size = New System.Drawing.Size(139, 25)
        Me.labelerror1.TabIndex = 169
        Me.labelerror1.Text = "INVALID QR"
        Me.labelerror1.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(277, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 168
        Me.Label12.Text = "Shift :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 61)
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
        Me.txtdate.Location = New System.Drawing.Point(123, 57)
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
        Me.Label2.Location = New System.Drawing.Point(569, 54)
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
        Me.txtqr.Location = New System.Drawing.Point(629, 50)
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
        Me.txtcode.Location = New System.Drawing.Point(629, 112)
        Me.txtcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcode.PlaceholderText = "Part no..."
        Me.txtcode.SelectedText = ""
        Me.txtcode.Size = New System.Drawing.Size(100, 23)
        Me.txtcode.TabIndex = 159
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(514, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 13)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Part no. / Partname :"
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
        Me.txtname.Location = New System.Drawing.Point(735, 112)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.PlaceholderText = "Part name..."
        Me.txtname.SelectedText = ""
        Me.txtname.Size = New System.Drawing.Size(263, 23)
        Me.txtname.TabIndex = 133
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1193, 36)
        Me.Panel1.TabIndex = 189
        '
        'txthide
        '
        Me.txthide.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txthide.DefaultText = "IN"
        Me.txthide.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txthide.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txthide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txthide.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txthide.Enabled = False
        Me.txthide.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txthide.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthide.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txthide.Location = New System.Drawing.Point(1151, 42)
        Me.txthide.Name = "txthide"
        Me.txthide.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txthide.PlaceholderText = ""
        Me.txthide.SelectedText = ""
        Me.txthide.Size = New System.Drawing.Size(30, 23)
        Me.txthide.TabIndex = 182
        Me.txthide.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(10, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 32)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Daily Output (IN)"
        '
        'txthide1
        '
        Me.txthide1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txthide1.DefaultText = ""
        Me.txthide1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txthide1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txthide1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txthide1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txthide1.Enabled = False
        Me.txthide1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txthide1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthide1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txthide1.Location = New System.Drawing.Point(1101, 42)
        Me.txthide1.Name = "txthide1"
        Me.txthide1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txthide1.PlaceholderText = ""
        Me.txthide1.SelectedText = ""
        Me.txthide1.Size = New System.Drawing.Size(44, 23)
        Me.txthide1.TabIndex = 190
        Me.txthide1.Visible = False
        '
        'txtcolor
        '
        Me.txtcolor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcolor.DefaultText = ""
        Me.txtcolor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcolor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcolor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcolor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcolor.Enabled = False
        Me.txtcolor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcolor.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcolor.Location = New System.Drawing.Point(936, 138)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcolor.PlaceholderText = "Color..."
        Me.txtcolor.SelectedText = ""
        Me.txtcolor.Size = New System.Drawing.Size(62, 23)
        Me.txtcolor.TabIndex = 191
        '
        'txtcolor1
        '
        Me.txtcolor1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcolor1.DefaultText = ""
        Me.txtcolor1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcolor1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcolor1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcolor1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcolor1.Enabled = False
        Me.txtcolor1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcolor1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcolor1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcolor1.Location = New System.Drawing.Point(1017, 139)
        Me.txtcolor1.Name = "txtcolor1"
        Me.txtcolor1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcolor1.PlaceholderText = "Color..."
        Me.txtcolor1.SelectedText = ""
        Me.txtcolor1.Size = New System.Drawing.Size(173, 23)
        Me.txtcolor1.TabIndex = 192
        Me.txtcolor1.Visible = False
        '
        'INFG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 602)
        Me.Controls.Add(Me.datagrid1)
        Me.Controls.Add(Me.panelset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "INFG"
        Me.Text = "INFG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.panelset.ResumeLayout(False)
        Me.panelset.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cmbsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panelset As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtmodel As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtqty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlot As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtoperator As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents boxtype As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents labelerror1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtqr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtcustomer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents labelerror2 As Label
    Friend WithEvents txtproddate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents boxshift As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txthide As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txthide1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcolor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtcolor1 As Guna.UI2.WinForms.Guna2TextBox
End Class
