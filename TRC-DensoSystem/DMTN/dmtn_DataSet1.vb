Partial Class dmtn_DataSet1
    Partial Public Class denso_fg_scanDataTable
        Private Sub denso_fg_scanDataTable_denso_fg_scanRowChanging(sender As Object, e As denso_fg_scanRowChangeEvent) Handles Me.denso_fg_scanRowChanging

        End Sub

    End Class

    Partial Public Class denso_dmtnDataTable
        Private Sub denso_dmtnDataTable_denso_dmtnRowChanging(sender As Object, e As denso_dmtnRowChangeEvent) Handles Me.denso_dmtnRowChanging

        End Sub

        Private Sub denso_dmtnDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.idColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
