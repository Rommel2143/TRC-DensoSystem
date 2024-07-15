Imports System
Public Class sub_FRAME

    Private Sub Scan_Frame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userstrip.Text = fname
    End Sub


    Private Sub display_formscan(form As Form)
        With form
            .Refresh()
            .TopLevel = False
            Panel1.Controls.Add(form)
            .BringToFront()
            .Show()

        End With
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        con.Close()
        Application.Exit()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        display_form(Login)
        Login.txtbarcode.Clear()
    End Sub

    Private Sub DeviceInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeviceInfoToolStripMenuItem.Click
        MessageBox.Show($"Device loc: {PClocation}   /  Mac: {PCmac}   /  Device: {PCname}", "This Device is Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub SuggestToImproveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuggestToImproveToolStripMenuItem.Click
        suggest_improvent.Show()
        suggest_improvent.BringToFront()
    End Sub

    Private Sub ManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageToolStripMenuItem.Click
        display_formscan(Add_item)
    End Sub


    Private Sub PARTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PARTSToolStripMenuItem.Click
        display_formscan(INFG)
    End Sub

    Private Sub MixedPalletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MixedPalletToolStripMenuItem.Click
        display_formscan(mixed_pallet)
    End Sub

    Private Sub QRCheckerToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QRCheckerToolStripMenuItem1.Click

    End Sub

    Private Sub StockMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockMonitoringToolStripMenuItem.Click

    End Sub

    Private Sub FGToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FGToolStripMenuItem1.Click
        display_formscan(FG_monitoring)
    End Sub

    Private Sub DMTNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DMTNToolStripMenuItem.Click
        display_formscan(OUT_DMTN)
    End Sub

    Private Sub IdentifyQRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdentifyQRToolStripMenuItem.Click
        display_formscan(QR_identifier)
    End Sub

    Private Sub ScanInnerTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanInnerTagToolStripMenuItem.Click
        display_formscan(Inner_Tag)
    End Sub
End Class