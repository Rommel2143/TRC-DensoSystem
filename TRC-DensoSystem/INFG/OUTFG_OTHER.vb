Imports MySql.Data.MySqlClient
Public Class OUTFG_OTHER

    Private Sub OUTFG_OTHER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxshift.Enabled = True
        txtdate.Text = datedb
        sub_FRAME.userstrip.Text = fname
        txtoperator.Text = fname
    End Sub

    Private Sub boxshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxshift.SelectedIndexChanged
        boxtype.Enabled = True
        con.Close()
        con.Open()
        Dim cmd As New MySqlCommand("Select distinct `qrtype` FROM `denso_fg_masterlist`", con)
        dr = cmd.ExecuteReader
        boxtype.Items.Clear()
        While (dr.Read())
            boxtype.Items.Add(dr.GetString("qrtype"))
        End While












        con.Close()
    End Sub

End Class