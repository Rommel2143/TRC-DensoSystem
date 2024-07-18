Public Class cml_track
    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub txtqr_MouseDown(sender As Object, e As MouseEventArgs) Handles txtqr.MouseDown

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtqr.Text = "" Then
                datagrid1.DataSource = Nothing
            Else
                reload("SELECT `dmtn`, `partno`, `customerno`, `color`, `proddate`, `qty`, `shift`, `process`, `line`, `serial`,`userin`, `datein`, `userout`, `dateout` FROM `denso_dmtn` WHERE cml REGEXP '" & txtqr.Text & "'", datagrid1)

            End If
        End If

    End Sub
End Class