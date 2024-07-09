Public Class mixed_pallet
    Dim scancount As Integer
    Private Sub txt_cml_TextChanged(sender As Object, e As EventArgs) Handles txt_cml.TextChanged
        Select Case scancount
            Case 0
                lbl_cml.Text = txt_cml.Text
            Case 1 To 2
                If txt_cml.Text = lbl_cml.Text Then
                    scancount += 1

                Else
                    showerror()

                End If
            Case 3

        End Select
        txt_cml.Clear()
        lbl_count.Text = scancount
    End Sub

    Private Sub showerror()
        lblerror.Visible = True
        sounderror()
    End Sub
End Class