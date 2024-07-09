Imports MySql.Data.MySqlClient

Public Class Add_item
    Dim qrcode As String
    Dim partNumber As String
    Dim quantity As String
    Dim colorcode As String
    Dim productionDate As String
    Dim partcode As String
    Dim supplier As String
    Dim customerNumber As String
    Dim qrlenght As Integer

    Private Sub processQRcode()
        Try
            Dim serialNumber As String = fg_txtqr.Text

            ' Extract parts based on fixed positions
            partNumber = serialNumber.Substring(0, 10)
            quantity = serialNumber.Substring(10, 2)
            colorcode = serialNumber.Substring(12, 3)

            Dim productionDateRaw As String = serialNumber.Substring(15)
            Dim year As Integer = Integer.Parse(productionDateRaw.Substring(0, 2))
            Dim month As Integer = Integer.Parse(productionDateRaw.Substring(2, 2))
            Dim day As Integer = Integer.Parse(productionDateRaw.Substring(4, 2))

            ' Convert to yyyy-MM-dd format
            Dim productionDateDateTime As New DateTime(2000 + year, month, day)
            productionDate = productionDateDateTime.ToString("yyyy-MM-dd")
            qrlenght = serialNumber.Length

            txt_qty.Text = quantity
            txt_prod.Text = productionDate
            partno.Text = partNumber
            txt_color.Text = colorcode
            qr_lenght.Text = qrlenght.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub processQRcodeTDE()
        Try
            Dim serialNumber As String = fg_txtqr.Text

            ' Extract parts based on fixed positions
            customerNumber = serialNumber.Substring(0, 15)
            partNumber = serialNumber.Substring(15, 10)
            quantity = serialNumber.Substring(25, 2)


            ' Convert to yyyy-MM-dd format
            Dim productionDateRaw As String = serialNumber.Substring(29, 10)
            Dim year As Integer = Integer.Parse(productionDateRaw.Substring(0, 2))
            Dim month As Integer = Integer.Parse(productionDateRaw.Substring(2, 2))
            Dim day As Integer = Integer.Parse(productionDateRaw.Substring(4, 2))
            Dim productionDateDateTime As New DateTime(2000 + year, month, day)
            productionDate = productionDateDateTime.ToString("yyyy-MM-dd")

            'Qr Lenght
            qrlenght = serialNumber.Length

            'Covert Color if no colorcode
            colorcode = serialNumber.Substring(27, 3)
            If colorcode.Contains("--") Then
                colorcode = "--"
            End If


            txt_qty.Text = quantity
            txt_prod.Text = productionDate
            partno.Text = partNumber
            txt_color.Text = colorcode
            txt_customerno.Text = customerNumber
            qr_lenght.Text = qrlenght.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub fg_txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles fg_txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            qrcode = fg_txtqr.Text

            cleartext()

            qrlenght = qrcode.Length

            Select Case qrlenght
                Case 23 To 28
                    processQRcode()

                Case 40 To 43
                    processQRcodeTDE()
                    txt_type.Text = "TDE"
            End Select

            fg_txtqr.Clear()
        End If
    End Sub

    Private Sub cleartext()
        partno.Clear()
        partname.Clear()
        txt_customerno.Clear()
        txt_color.Clear()
        qr_lenght.Clear()
        txt_prod.Clear()
        txt_type.Clear()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub

    Private Sub Guna2GroupBox2_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox2.Click

    End Sub
End Class
