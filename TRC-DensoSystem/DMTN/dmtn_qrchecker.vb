Public Class dmtn_qrchecker
    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

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

    Private Sub txtqr_sticker_TextChanged(sender As Object, e As EventArgs) Handles txtqr_sticker.TextChanged

    End Sub

    Private Sub txtqr_sticker_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_sticker.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtqr_sticker.Text = "" Then
                datagrid_sticker.DataSource = Nothing
            Else

                reload("SELECT `innertag`, `partno`, `customerno`, `color`, `proddate`, `qty`, `shift`, `process`, `line`, `serial`, `userin`, `datein` FROM `denso_dmtn_innertag` WHERE fglabel='" & txtqr_sticker.Text & "'", datagrid_sticker)

            End If
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtqr_innertag.TextChanged

    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_innertag.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtqr_innertag.Text = "" Then
                datagrid_innertag.DataSource = Nothing
            Else

                reload("SELECT `innertag`, `partno`, `customerno`, `color`, `proddate`, `qty`, `shift`, `process`, `line`, `serial`,`fglabel`,`userin`, `datein` FROM `denso_dmtn_innertag` WHERE innertag='" & txtqr_innertag.Text & "'", datagrid_innertag)

            End If
        End If
    End Sub
End Class