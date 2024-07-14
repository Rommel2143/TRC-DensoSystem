Imports MySql.Data.MySqlClient
Public Class OUT_DMTN
    Dim qrlenght As Integer
    Dim serialNumber As String
    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub
    Private Sub processQRcodeTDE()
        Try

            serialNumber = txtqr.Text

            'Qr Lenght
            qrlenght = serialNumber.Length

            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT `id`, `qrtype`, `qrlenght`, `partno`, `qty`, `customer`, `color`, `proddate`, `shift`, `machine`, `line`, `series` FROM `denso_qrtype` WHERE qrlenght= '" & qrlenght & "'", con)
            dr = cmdselect.ExecuteReader()
            If dr.Read = True Then

                'l_partno = NewMethod(serialNumber)
                getcoordinates(dr.GetString("partno"), txt_partno)
                getcoordinates(dr.GetString("qty"), txt_qty)
                getcoordinates(dr.GetString("customer"), txt_customerno)
                getcoordinates(dr.GetString("color"), txt_color)
                getcoordinates(dr.GetString("proddate"), txt_prod)
                getcoordinates(dr.GetString("shift"), txt_shift)
                getcoordinates(dr.GetString("machine"), txt_machine)
                getcoordinates(dr.GetString("line"), txt_line)
                getcoordinates(dr.GetString("series"), txt_series)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub getcoordinates(partdb As String, txtbox As Guna.UI2.WinForms.Guna2TextBox)

        Dim partno() As String = partdb.Split(",")
        Dim partget1 As Integer = partno(0)
        Dim partget2 As Integer = partno(1)

        ' Extract parts based on fixed positions
        txtbox.Text = serialNumber.Substring(partget1, partget2)

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            processQRcodeTDE()
            txtqr.Clear()
            txtqr.Focus()

        End If
    End Sub


End Class