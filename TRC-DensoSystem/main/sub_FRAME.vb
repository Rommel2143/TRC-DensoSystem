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
        'display_formscan(Add_item)
    End Sub


    Private Sub PARTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PARTSToolStripMenuItem.Click
        display_formscan(INFG)
    End Sub


    Private Sub FGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FGToolStripMenuItem.Click

    End Sub

    Private Sub TDEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TDEToolStripMenuItem.Click
        display_formscan(OUTFG_TDE)
    End Sub

    Private Sub InnerTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InnerTagToolStripMenuItem.Click
        display_formscan(dmtn_inner_tag)
    End Sub

    Private Sub CMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CMLToolStripMenuItem.Click
        display_formscan(dmtn_cml)
    End Sub

    Private Sub QRIdentifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QRIdentifierToolStripMenuItem.Click
        display_formscan(QR_identifier)
    End Sub

<<<<<<< HEAD
    Private Sub OTHERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OTHERToolStripMenuItem.Click
        display_formscan(OUTFG_OTHER)
=======
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub TrackCMLToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QRCheckerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QRCheckerToolStripMenuItem.Click

    End Sub

    Private Sub MONITORINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MONITORINGToolStripMenuItem.Click
        display_formscan(cml_track)
>>>>>>> 9b77771674d49695a116ee829e8d46645ab2eea6
    End Sub
End Class