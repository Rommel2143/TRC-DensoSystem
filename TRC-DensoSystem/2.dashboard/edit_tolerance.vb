Imports MySql.Data.MySqlClient
Public Class edit_tolerance
    Dim dataid As Integer
    Private Sub edit_tolerance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loaddata(id As Integer)
        con.Close()
        con.Open()

        Dim selectmasterlist As New MySqlCommand("SELECT * FROM `denso_parts_masterlist`
                                                WHERE id='" & id & "'", con)
        dr = selectmasterlist.ExecuteReader()
        If dr.Read = True Then
            lbl_partname.Text = dr.GetString("partname")
            lbl_partcode.Text = dr.GetString("partno")
            txt_min.Text = dr.GetInt32("min")
            txt_max.Text = dr.GetInt32("max")
            dataid = id
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con.Close()
        con.Open()

        Dim edit As New MySqlCommand("UPDATE `denso_parts_masterlist` SET `min`='" & txt_min.Text & "',`max`='" & txt_max.Text & "' WHERE id = '" & dataid & "'", con)
        edit.ExecuteNonQuery()
        dashboard.LoadMemberProfiles()
        dashboard.reload_graph()
        Me.Close()
    End Sub

    Private Sub txt_min_TextChanged(sender As Object, e As EventArgs) Handles txt_min.TextChanged

    End Sub
    Private Sub txtNumberOnly_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_max.KeyPress, txt_min.KeyPress
        ' Check if the key pressed is not a digit and is not a control key like backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If it's not, cancel the event so the keypress won't be registered
            e.Handled = True
        End If
    End Sub
End Class