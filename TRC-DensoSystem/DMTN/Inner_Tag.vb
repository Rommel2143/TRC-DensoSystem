Imports MySql.Data.MySqlClient
Public Class Inner_Tag
    Dim qrlenght As Integer
    Dim serialNumber As String = ""

    Dim partno As String
    Dim qty As String
    Dim customerno As String
    Dim color As String


    Dim prod As String
    Dim shift As String
    Dim process As String
    Dim line As String
    Dim series As String


    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub
    Private Sub processQRcode(type As String, datagrid As Guna.UI2.WinForms.Guna2DataGridView, txtqr As Guna.UI2.WinForms.Guna2TextBox)
        Try

            serialNumber = txtqr.Text

            'Qr Lenght
            qrlenght = serialNumber.Length
            Dim productionDateRaw As String = ""
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT `id`, `qrtype`, `qrlenght`, `partno`, `qty`, `customer`, `color`, `proddate`, `shift`, `process`, `line`, `series` FROM `denso_qrtype` WHERE qrlenght= '" & qrlenght & "' and qrtype  = '" & type & "'", con)
            dr = cmdselect.ExecuteReader()
            If dr.Read = True Then

                getcoordinates(dr.GetString("partno"), partno)
                getcoordinates(dr.GetString("qty"), qty)
                getcoordinates(dr.GetString("customer"), customerno)
                getcoordinates(dr.GetString("color"), color)
                getcoordinates(dr.GetString("proddate"), productionDateRaw)
                getcoordinates(dr.GetString("shift"), shift)
                getcoordinates(dr.GetString("process"), process)
                getcoordinates(dr.GetString("line"), line)
                getcoordinates(dr.GetString("series"), series)

                Dim year As Integer = Integer.Parse(productionDateRaw.Substring(0, 2))
                Dim month As Integer = Integer.Parse(productionDateRaw.Substring(2, 2))
                Dim day As Integer = Integer.Parse(productionDateRaw.Substring(4, 2))
                Dim productionDateDateTime As New DateTime(2000 + year, month, day)

                prod = productionDateDateTime.ToString("yyyy-MM-dd")

                Dim row As String() = New String() {partno, qty, customerno, color, prod, shift, process, line, series}
                datagrid.Rows.Add(row)
            Else
                showerror("No Qrtype Detected! Please Register first")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub processQRcodefg(type As String)
    '    Try

    '        serialNumber = txtqr_fg.Text

    '        'Qr Lenght
    '        qrlenght = serialNumber.Length

    '        con.Close()
    '        con.Open()
    '        Dim cmdselect As New MySqlCommand("SELECT `id`, `qrtype`, `qrlenght`, `partno`, `qty`, `customer`, `color`, `proddate`, `shift`, `process`, `line`, `series` FROM `denso_qrtype` WHERE qrlenght= '" & qrlenght & "' and qrtype  = '" & type & "'", con)
    '        dr = cmdselect.ExecuteReader()
    '        If dr.Read = True Then
    '            getcoordinates(dr.GetString("partno"), partno)
    '            getcoordinates(dr.GetString("qty"), qty)
    '            getcoordinates(dr.GetString("customer"), customerno)
    '            getcoordinates(dr.GetString("color"), color)
    '            getcoordinates(dr.GetString("proddate"), productionDateRaw)
    '            getcoordinates(dr.GetString("shift"), shift)
    '            getcoordinates(dr.GetString("process"), process)
    '            getcoordinates(dr.GetString("line"), line)
    '            getcoordinates(dr.GetString("series"), series)
    '            displaygrid2()
    '        Else
    '            showerror("No Qrtype Detected! Please Register first")
    '        End If


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Private Sub displaygrid(datagrid As Guna.UI2.WinForms.Guna2DataGridView)

        ' Create a new row in the DataGridView
        Dim row As String() = New String() {partno, qty, customerno, color, prod, shift, process, line, series}
        datagrid.Rows.Add(row)
    End Sub


    Private Sub getcoordinates(partdb As String, ByRef txtbox As String)

        Dim partno() As String = partdb.Split(",")
        Dim partget1 As Integer = partno(0)
        Dim partget2 As Integer = partno(1)

        ' Extract parts based on fixed positions
        txtbox = serialNumber.Substring(partget1, partget2)

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            processQRcode("DMTN-IT", datagrid1, txtqr)
            txtqr.Clear()
            txtqr.Focus()
        End If
    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_fg.KeyDown
        If e.KeyCode = Keys.Enter Then
            processQRcode("DMTN", datagrid2, txtqr_fg)
            txtqr_fg.Clear()
            txtqr_fg.Focus()
        End If
    End Sub
    Private Sub showduplicate()
        Try
            labelerror.Visible = True
            texterror.Text = "QR Already Scanned"
            soundduplicate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub showerror(text As String)

        Try
            labelerror.Visible = True
            texterror.Text = text
            sounderror()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtqr_fg.TextChanged

    End Sub

End Class