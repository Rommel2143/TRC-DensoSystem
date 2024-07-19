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

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub datagrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellClick
        reload("SELECT `innertag`, `partno`, `customerno`, `color`, `proddate`, `qty`, `shift`, `process`, `line`, `serial`,`userin`, `datein` FROM `denso_dmtn_innertag` WHERE fglabel = '" & datagrid1.SelectedCells(0).Value.ToString() & "'", datagrid2)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    End Sub
End Class