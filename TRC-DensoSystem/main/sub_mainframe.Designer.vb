<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sub_mainframe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sub_mainframe))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRIdentifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QRCheckerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpiringStockToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InnerTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DMTNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIXEDPalletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MONITORINGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTHERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TDEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTOTHERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterlistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatrixToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.userstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 41)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1342, 775)
        Me.Panel1.TabIndex = 12
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QRIdentifierToolStripMenuItem, Me.AddItemToolStripMenuItem})
        Me.ManageToolStripMenuItem.Image = CType(resources.GetObject("ManageToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(99, 37)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'QRIdentifierToolStripMenuItem
        '
        Me.QRIdentifierToolStripMenuItem.Image = CType(resources.GetObject("QRIdentifierToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QRIdentifierToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QRIdentifierToolStripMenuItem.Name = "QRIdentifierToolStripMenuItem"
        Me.QRIdentifierToolStripMenuItem.Size = New System.Drawing.Size(182, 38)
        Me.QRIdentifierToolStripMenuItem.Text = "QR Identifier"
        '
        'AddItemToolStripMenuItem
        '
        Me.AddItemToolStripMenuItem.Image = CType(resources.GetObject("AddItemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddItemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AddItemToolStripMenuItem.Name = "AddItemToolStripMenuItem"
        Me.AddItemToolStripMenuItem.Size = New System.Drawing.Size(182, 38)
        Me.AddItemToolStripMenuItem.Text = "Add Item"
        '
        'StockMonitoringToolStripMenuItem
        '
        Me.StockMonitoringToolStripMenuItem.Image = CType(resources.GetObject("StockMonitoringToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StockMonitoringToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StockMonitoringToolStripMenuItem.Name = "StockMonitoringToolStripMenuItem"
        Me.StockMonitoringToolStripMenuItem.Size = New System.Drawing.Size(195, 38)
        Me.StockMonitoringToolStripMenuItem.Text = "FG Stock"
        '
        'QRCheckerToolStripMenuItem
        '
        Me.QRCheckerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockMonitoringToolStripMenuItem, Me.ExpiringStockToolStripMenuItem1})
        Me.QRCheckerToolStripMenuItem.Image = CType(resources.GetObject("QRCheckerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QRCheckerToolStripMenuItem.Name = "QRCheckerToolStripMenuItem"
        Me.QRCheckerToolStripMenuItem.Size = New System.Drawing.Size(119, 37)
        Me.QRCheckerToolStripMenuItem.Text = " Monitoring"
        '
        'ExpiringStockToolStripMenuItem1
        '
        Me.ExpiringStockToolStripMenuItem1.Image = CType(resources.GetObject("ExpiringStockToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ExpiringStockToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExpiringStockToolStripMenuItem1.Name = "ExpiringStockToolStripMenuItem1"
        Me.ExpiringStockToolStripMenuItem1.Size = New System.Drawing.Size(195, 38)
        Me.ExpiringStockToolStripMenuItem1.Text = "Expiring Stock"
        '
        'CMLToolStripMenuItem
        '
        Me.CMLToolStripMenuItem.Image = CType(resources.GetObject("CMLToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CMLToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CMLToolStripMenuItem.Name = "CMLToolStripMenuItem"
        Me.CMLToolStripMenuItem.Size = New System.Drawing.Size(223, 38)
        Me.CMLToolStripMenuItem.Text = "LABEL to CML"
        '
        'InnerTagToolStripMenuItem
        '
        Me.InnerTagToolStripMenuItem.Image = CType(resources.GetObject("InnerTagToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InnerTagToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InnerTagToolStripMenuItem.Name = "InnerTagToolStripMenuItem"
        Me.InnerTagToolStripMenuItem.Size = New System.Drawing.Size(223, 38)
        Me.InnerTagToolStripMenuItem.Text = "Inner Tag to LABEL"
        '
        'DMTNToolStripMenuItem
        '
        Me.DMTNToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InnerTagToolStripMenuItem, Me.CMLToolStripMenuItem, Me.MIXEDPalletToolStripMenuItem, Me.MONITORINGToolStripMenuItem})
        Me.DMTNToolStripMenuItem.Image = CType(resources.GetObject("DMTNToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DMTNToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DMTNToolStripMenuItem.Name = "DMTNToolStripMenuItem"
        Me.DMTNToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.DMTNToolStripMenuItem.Text = "DMTN"
        '
        'MIXEDPalletToolStripMenuItem
        '
        Me.MIXEDPalletToolStripMenuItem.Image = CType(resources.GetObject("MIXEDPalletToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MIXEDPalletToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MIXEDPalletToolStripMenuItem.Name = "MIXEDPalletToolStripMenuItem"
        Me.MIXEDPalletToolStripMenuItem.Size = New System.Drawing.Size(223, 38)
        Me.MIXEDPalletToolStripMenuItem.Text = "MIXED Pallet"
        '
        'MONITORINGToolStripMenuItem
        '
        Me.MONITORINGToolStripMenuItem.Image = CType(resources.GetObject("MONITORINGToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MONITORINGToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MONITORINGToolStripMenuItem.Name = "MONITORINGToolStripMenuItem"
        Me.MONITORINGToolStripMenuItem.Size = New System.Drawing.Size(223, 38)
        Me.MONITORINGToolStripMenuItem.Text = "MONITORING"
        '
        'OTHERToolStripMenuItem
        '
        Me.OTHERToolStripMenuItem.Name = "OTHERToolStripMenuItem"
        Me.OTHERToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.OTHERToolStripMenuItem.Text = "OTHER"
        '
        'TDEToolStripMenuItem
        '
        Me.TDEToolStripMenuItem.Name = "TDEToolStripMenuItem"
        Me.TDEToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.TDEToolStripMenuItem.Text = "TDE"
        '
        'FGToolStripMenuItem
        '
        Me.FGToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TDEToolStripMenuItem, Me.OTHERToolStripMenuItem, Me.REPORTToolStripMenuItem, Me.REPORTOTHERToolStripMenuItem})
        Me.FGToolStripMenuItem.Image = CType(resources.GetObject("FGToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FGToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FGToolStripMenuItem.Name = "FGToolStripMenuItem"
        Me.FGToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.FGToolStripMenuItem.Text = "OUT"
        '
        'REPORTToolStripMenuItem
        '
        Me.REPORTToolStripMenuItem.Name = "REPORTToolStripMenuItem"
        Me.REPORTToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.REPORTToolStripMenuItem.Text = "REPORT TDE"
        '
        'REPORTOTHERToolStripMenuItem
        '
        Me.REPORTOTHERToolStripMenuItem.Name = "REPORTOTHERToolStripMenuItem"
        Me.REPORTOTHERToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.REPORTOTHERToolStripMenuItem.Text = "REPORT OTHER"
        '
        'PARTSToolStripMenuItem
        '
        Me.PARTSToolStripMenuItem.Image = CType(resources.GetObject("PARTSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PARTSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PARTSToolStripMenuItem.Name = "PARTSToolStripMenuItem"
        Me.PARTSToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.PARTSToolStripMenuItem.Text = "IN"
        '
        'MasterlistToolStripMenuItem
        '
        Me.MasterlistToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PARTSToolStripMenuItem, Me.FGToolStripMenuItem, Me.DMTNToolStripMenuItem, Me.YTToolStripMenuItem})
        Me.MasterlistToolStripMenuItem.Image = CType(resources.GetObject("MasterlistToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MasterlistToolStripMenuItem.Name = "MasterlistToolStripMenuItem"
        Me.MasterlistToolStripMenuItem.Size = New System.Drawing.Size(56, 37)
        Me.MasterlistToolStripMenuItem.Text = "FG"
        '
        'YTToolStripMenuItem
        '
        Me.YTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatrixToolStripMenuItem})
        Me.YTToolStripMenuItem.Name = "YTToolStripMenuItem"
        Me.YTToolStripMenuItem.Size = New System.Drawing.Size(196, 38)
        Me.YTToolStripMenuItem.Text = "YT"
        '
        'MatrixToolStripMenuItem
        '
        Me.MatrixToolStripMenuItem.Name = "MatrixToolStripMenuItem"
        Me.MatrixToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MatrixToolStripMenuItem.Text = "Matrix"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterlistToolStripMenuItem, Me.QRCheckerToolStripMenuItem, Me.ManageToolStripMenuItem, Me.userstrip})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1342, 41)
        Me.MenuStrip1.TabIndex = 13
        '
        'userstrip
        '
        Me.userstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.userstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.userstrip.Image = CType(resources.GetObject("userstrip.Image"), System.Drawing.Image)
        Me.userstrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.userstrip.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.userstrip.Name = "userstrip"
        Me.userstrip.Size = New System.Drawing.Size(83, 37)
        Me.userstrip.Text = "User"
        Me.userstrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(216, 22)
        Me.ToolStripMenuItem2.Text = "Logout"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(216, 22)
        Me.ToolStripMenuItem3.Text = "Exit"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(216, 22)
        Me.ToolStripMenuItem4.Text = "Suggest to improve"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(216, 22)
        Me.ToolStripMenuItem5.Text = "Device info."
        '
        'sub_mainframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 816)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sub_mainframe"
        Me.Text = "sub_mainframe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRIdentifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockMonitoringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QRCheckerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InnerTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DMTNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MONITORINGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OTHERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TDEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FGToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PARTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterlistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents userstrip As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents REPORTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTOTHERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpiringStockToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MIXEDPalletToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatrixToolStripMenuItem As ToolStripMenuItem
End Class
