Public Class mixed_pallet
    Dim scancount As Integer
    Private Sub txt_cml_TextChanged(sender As Object, e As EventArgs) Handles txt_cml.TextChanged

    End Sub

    Private Sub showerror()
        lblerror.Visible = True
        sounderror()
    End Sub

    Private Sub txt_cml_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cml.KeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case scancount

                Case 0
                    lbl_cml.Text = txt_cml.Text
                    scancount += 1
                Case 1
                    If txt_cml.Text = lbl_cml.Text Then
                        scancount += 1

                    Else
                        showerror()

                    End If
                Case 2
                    scancount += 1

            End Select
            txt_cml.Clear()
            lbl_count.Text = scancount
        End If


    End Sub
End Class