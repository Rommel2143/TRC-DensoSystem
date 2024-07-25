Public Class expiring_stock
    Dim cmdselect As String
    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged
        Select Case cmb_type.Text
            Case "DMTN"
                cmbselect = "DMTN"
            Case " DMTN-Inner Tag"
                cmbselect = "DMTN-IT"
            Case "DMTN-CML"
                cmbselect = "DMTN-CML"
            Case "INTELLI IV"
                cmbselect = "INT4"
            Case "TDE"
                cmbselect = "TDE"
            Case "20CY"
                cmbselect = "20CY"
            Case "VT"
                cmbselect = "VT"
            Case "2T"
                cmbselect = "2T"


        End Select
    End Sub
End Class