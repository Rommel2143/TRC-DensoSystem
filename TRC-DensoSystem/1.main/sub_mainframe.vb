﻿Imports System
Public Class sub_mainframe

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


    Private Sub PARTSToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub FGToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TDEToolStripMenuItem_Click(sender As Object, e As EventArgs)

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


    Private Sub OTHERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        display_formscan(OUTFG_OTHER)
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub



    Private Sub MONITORINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MONITORINGToolStripMenuItem.Click
        display_formscan(dmtn_qrchecker)

    End Sub

    Private Sub userstrip_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        display_form(New Login)
        Me.Close()

        Login.txtbarcode.Clear()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        MessageBox.Show($"Device loc: {PClocation}   /  Mac: {PCmac}   /  Device: {PCname}", "This Device is Registered", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Try
            ' Close database connection
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Add any cleanup code here if necessary

        Catch ex As Exception
            MessageBox.Show("Error closing application: " & ex.Message)
        Finally
            Application.Exit() ' Ensure the application exits
        End Try
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        suggest_improvent.Show()
        suggest_improvent.BringToFront()
    End Sub



    Private Sub REPORTToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub REPORTOTHERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        display_formscan(REPORT_OTHER)

    End Sub



    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddItemToolStripMenuItem.Click
        display_formscan(Add_item)
    End Sub



    Private Sub StockMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExpiringStockToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MIXEDPalletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MIXEDPalletToolStripMenuItem.Click
        display_formscan(dmtn_mixed)
    End Sub

    Private Sub MatrixToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatrixToolStripMenuItem.Click
        display_formscan(yt_matrix)
    End Sub

    Private Sub YTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YTToolStripMenuItem.Click

    End Sub

    Private Sub FGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FGINToolStripMenuItem.Click
        display_formscan(dmtn_fgin)
    End Sub

    Private Sub OUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OUTToolStripMenuItem.Click
        display_formscan(yt_out)
    End Sub

    Private Sub INToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INToolStripMenuItem.Click
        display_formscan(jeco_in)
    End Sub

    Private Sub OUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OUTToolStripMenuItem1.Click
        display_formscan(jeco_out)
    End Sub

    Private Sub INToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles INToolStripMenuItem1.Click
        display_formscan(New _20cy_in)
    End Sub

    Private Sub OUTToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OUTToolStripMenuItem2.Click
        display_formscan(retainer_20cy_out)
    End Sub

    Private Sub INToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles INToolStripMenuItem2.Click
        display_formscan(New intelli_in)
    End Sub

    Private Sub OUTToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles OUTToolStripMenuItem3.Click
        display_formscan(INTELLI_out)
    End Sub

    Private Sub INToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles INToolStripMenuItem3.Click
        display_formscan(retainer_3T_IN)
    End Sub

    Private Sub OUTToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles OUTToolStripMenuItem4.Click
        display_formscan(retainer_3t_out)
    End Sub

    Private Sub FGINBYPASSReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FGINBYPASSReportToolStripMenuItem.Click
        display_formscan(export_dmtn_bypass)
    End Sub

    Private Sub INToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles INToolStripMenuItem4.Click
        '   display_formscan(INFG)
        display_formscan(tde_IN)
    End Sub

    Private Sub OUTToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles OUTToolStripMenuItem5.Click
        display_formscan(tde_OUT)
    End Sub

    Private Sub ReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem1.Click
        display_formscan(tde_Report)
    End Sub

    Private Sub PrintCMLReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintCMLReportsToolStripMenuItem.Click
        display_formscan(New export_dmtn)
    End Sub

    Private Sub UpdateSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateSystemToolStripMenuItem.Click
        Try
            Dim setupPath As String = "\\ptif1-ds\SystemServer\Denso System\setup.exe"
            If System.IO.File.Exists(setupPath) Then
                Process.Start(setupPath)
                Application.Exit()
            Else
                MessageBox.Show("Update file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while trying to update: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StockMonitoringToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles StockMonitoringToolStripMenuItem.Click
        display_formscan(FG_monitoring)

    End Sub


    Private Sub RecievingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecievingToolStripMenuItem.Click
        display_formscan(parts_IN)
    End Sub

    Private Sub OutgoingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutgoingToolStripMenuItem.Click
        display_formscan(parts_OUT)
    End Sub

    Private Sub PARTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PARTToolStripMenuItem.Click
        display_formscan(New parts_stock)
    End Sub

    Private Sub tool_overview_Click(sender As Object, e As EventArgs) Handles tool_overview.Click
        display_formscan(dashboard)
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RETURNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RETURNToolStripMenuItem.Click
        display_formscan(parts_RETURN)
    End Sub

    Private Sub HandCarryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HandCarryToolStripMenuItem.Click
        display_formscan(dmtn_handcarry)
    End Sub

    Private Sub TdeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TdeOutToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub
End Class