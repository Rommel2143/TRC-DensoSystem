Imports MySql.Data.MySqlClient
Public Class OUTFG_TDE
    Private Sub OUTFG_TDE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        boxshift.Enabled = True
        txtdate.Text = datedb
        sub_FRAME.userstrip.Text = fname
        txtoperator.Text = fname
    End Sub
    Private Sub boxshift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles boxshift.SelectedIndexChanged
        tdeqr.Enabled = True
        tdeqr.Focus()

    End Sub

    Private Sub tdeqr_KeyDown(sender As Object, e As KeyEventArgs) Handles tdeqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("Select * FROM `denso_fg_scan` where `status`='IN' and `qrtde`= '" & tdeqr.Text & "'", con)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                labelerror1.Visible = False
                Dim tdeqrcode As String = tdeqr.Text
                tdecustomer.Text = tdeqrcode.Substring(96, 13)
                tdeserial.Text = tdeqrcode.Substring(154, 7)
                txtqr.Text = Nothing
                txtqr.Enabled = True
                txtqr.Focus()
            Else
                labelerror1.Visible = True
            End If
        End If
    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            con.Close()
            con.Open()
            Dim cmd As New MySqlCommand("Select * FROM `denso_fg_scan` where `qrcode` = '" & txtqr.Text & "' and `status`='" & txthide.Text & "' and `qrtde` = '" & tdeqr.Text & "'", con)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                labelerror1.Visible = False
                Dim qrcode As String = txtqr.Text
                txtcode.Text = qrcode.Substring(15, 10)
                con.Close()
                con.Open()
                Dim cmd1 As New MySqlCommand("Select * FROM `denso_temp` where `tdeqr` = '" & tdeqr.Text & "' and `qr` = '" & txtqr.Text & "'", con)
                dr = cmd1.ExecuteReader
                If dr.Read = True Then
                    labelerror2.Visible = True
                Else
                    labelerror2.Visible = False
                    insertitem("Insert into `denso_temp` (`tdeqr`,`qr`,`partno`,`customerno`,`serial`)
                                    values ('" & tdeqr.Text & "','" & txtqr.Text & "','" & txtcode.Text & "','" & tdecustomer.Text & "','" & tdeserial.Text & "')")
                    cls()
                End If
            Else
                labelerror1.Visible = True
            End If

        End If

    End Sub
    Public Sub cls()
        tdeqr.Text = Nothing
        tdeqr.Focus()
        txtqr.Text = Nothing
        txtcode.Text = Nothing
        tdeserial.Text = Nothing
        tdecustomer.Text = Nothing
    End Sub

    Private Sub tdeqr_TextChanged(sender As Object, e As EventArgs) Handles tdeqr.TextChanged

    End Sub
End Class