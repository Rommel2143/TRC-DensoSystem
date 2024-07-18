Public Class OUTFG_OTHER

    Private Sub OUTFG_OTHER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxshift.Enabled = True
        txtdate.Text = datedb
        sub_FRAME.userstrip.Text = fname
        txtoperator.Text = fname
    End Sub
End Class