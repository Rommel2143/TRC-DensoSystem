Imports MySql.Data.MySqlClient
Public Class tde_OUT
    Private Shared cml_serial As String
    Dim serialnumber As String
    Private Sub tde_OUT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reload("SELECT cml_serial,partno,customerno,color FROM denso_tde WHERE dateout='" & datedb & "' GROUP BY cml_serial", datagrid2)
    End Sub

    Private Sub txtqr_sticker_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_sticker.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                con.Close()
                con.Open()
                Dim cmdselect As New MySqlCommand("SELECT id, dateout, userout FROM `denso_tde` 
                                           WHERE tdeqr = @tdeqr AND customer_qr = @customer_qr", con)
                cmdselect.Parameters.AddWithValue("@tdeqr", txtqr_sticker.Text)
                cmdselect.Parameters.AddWithValue("@customer_qr", txtqr_customer.Text)

                dr = cmdselect.ExecuteReader()

                If dr.Read() Then
                    If dr.IsDBNull(dr.GetOrdinal("dateout")) Then
                        ' Update
                        Dim dataid As Integer = dr.GetInt32("id")

                        ' Check if dataid already exists in datagrid1
                        Dim isDuplicate As Boolean = False

                        For Each row As DataGridViewRow In datagrid1.Rows
                            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(0).Value.ToString() = dataid Then
                                isDuplicate = True
                                Exit For
                            End If
                        Next

                        If Not isDuplicate Then

                            datagrid1.Rows.Add(dataid, txtqr_sticker.Text)

                            Dim rowCount As Integer = datagrid1.Rows.Count


                            gp_box.Text = "Box Count: " & rowCount

                        Else
                            showerror("Duplicate Scan. Check data table!")
                        End If


                        labelerror.Visible = False
                        txtqr_sticker.Clear()
                        txtqr_customer.Enabled = True
                        txtqr_sticker.Enabled = False
                    Else
                        ' Duplicate
                        showduplicate(dr.GetString("userout"), dr.GetDateTime("dateout"))

                        txtqr_customer.Enabled = True
                        txtqr_sticker.Enabled = False
                    End If
                Else

                    showerror("No record found.")
                End If
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
                txtqr_customer.Clear()
                txtqr_sticker.Clear()
                txtqr_customer.Focus()
            End Try
        End If

    End Sub

    Private Shared Sub updateout(dataid As Integer, txtqr_cml As String)
        Try
            ' Ensure the connection is properly closed before opening
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            con.Open()

            ' SQL query with corrected syntax
            Dim cmdupdate As New MySqlCommand("UPDATE `denso_tde` SET cml = @cml, cml_serial = @cmlserial, dateout = @dateout, userout = @userout WHERE id = @id", con)

            ' Add parameters
            cmdupdate.Parameters.AddWithValue("@cml", txtqr_cml)
            cmdupdate.Parameters.AddWithValue("@cmlserial", cml_serial)
            cmdupdate.Parameters.AddWithValue("@dateout", datedb) ' Ensure this is a valid date
            cmdupdate.Parameters.AddWithValue("@userout", idno)   ' Ensure idno is initialized
            cmdupdate.Parameters.AddWithValue("@id", dataid)

            ' Execute the update query
            cmdupdate.ExecuteNonQuery()

        Catch ex As MySqlException
            ' Enhanced error handling
            MessageBox.Show("An error occurred while updating the database: " & ex.Message,
                        "Database Update Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
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
    Private Sub showduplicate(user As String, date1 As String)
        Try
            labelerror.Visible = True
            texterror.Text = "QR Already Scanned by " & user & " on " & date1 & ""
            soundduplicate()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtqr_customer_TextChanged(sender As Object, e As EventArgs) Handles txtqr_customer.TextChanged

    End Sub

    Private Sub txtqr_customer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_customer.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtqr_sticker.Enabled = True
            txtqr_customer.Enabled = False
            txtqr_sticker.Focus() ' Optional: Automatically focus on the next field
        End If
    End Sub

    Private Sub datagrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid1.CellContentClick

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtqr_cml.TextChanged

    End Sub

    ' Declare variables to track scanned string and count
    Private previousScan As String = ""
    Private scanCount As Integer = 0

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr_cml.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim currentScan As String = txtqr_cml.Text.Trim() ' Get the current scan and trim whitespace

            ' Check if the current scan matches the previous scan
            If currentScan = previousScan Then
                scanCount += 1 ' Increment the counter for identical scans
            Else
                scanCount = 1 ' Reset the counter if the scan changes
            End If

            ' Update the previous scan value
            previousScan = currentScan

            ' Proceed only if the scan count reaches 3
            If scanCount = 3 Then
                If processQRcode_cml("TDE-CML", txtqr_cml) Then
                    For Each row As DataGridViewRow In datagrid1.Rows
                        If row.Cells(0).Value IsNot Nothing Then ' Ensure the cell is not empty
                            Dim dataid As Integer = Convert.ToInt32(row.Cells(0).Value)
                            updateout(dataid, txtqr_cml.Text) ' Call the updateout method for each dataid
                        End If
                    Next
                    btn_reset.PerformClick()
                    reload("SELECT cml_serial,partno,customerno,color FROM denso_tde WHERE dateout='" & datedb & "' GROUP BY cml_serial", datagrid2)
                End If

                ' Reset the scan tracking after processing
                scanCount = 0
                previousScan = ""
            Else
                ' If scan count is less than 3, clear the textbox and set focus
                txtqr_cml.Clear()
                txtqr_cml.Focus()
            End If
        End If
    End Sub


    Private Function processQRcode_cml(type As String, txtqr As Guna.UI2.WinForms.Guna2TextBox) As Boolean
        Try

            serialnumber = txtqr.Text

            'Qr Lenght
            Dim qrlenght As String = serialnumber.Length
            Dim productionDateRaw As String = ""


            con.Close()
            con.Open()
            Dim cmdselectqr As New MySqlCommand("Select `id`, `qrtype`, `qrlenght`, `partno`, `qty`, `customer`, `color`, `proddate`, `shift`, `process`, `line`, `series` FROM `denso_qrtype`
                                                WHERE qrlenght= '" & qrlenght & "'", con)
            dr = cmdselectqr.ExecuteReader()
            If dr.Read = True Then


                getcoordinates(dr.GetString("series"), cml_serial)

            Else
                showerror("No Qrtype Detected! Please Register first")
                txtqr.Clear()
                txtqr.Focus()
                Return False
            End If


            Return True



        Catch ex As Exception
            MessageBox.Show(ex.Message)

            Return False
        End Try
    End Function
    Private Sub getcoordinates(partdb As String, ByRef txtstring As String)

        Dim partno() As String = partdb.Split(",")
        Dim partget1 As Integer = partno(0)
        Dim partget2 As Integer = partno(1)

        ' Extract parts based on fixed positions
        txtstring = serialNumber.Substring(partget1, partget2)

    End Sub

    Private Sub gp_box_Click(sender As Object, e As EventArgs) Handles gp_box.Click

    End Sub

    Private Sub gp_box_TextChanged(sender As Object, e As EventArgs) Handles gp_box.TextChanged, txtqr_sticker.KeyDown
        If gp_box.Text = "Box Count: 24" Then
            txtqr_cml.Enabled = True
            txtqr_customer.Enabled = False
            txtqr_cml.Focus()
        Else

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        datagrid1.Rows.Clear()
        gp_box.Text = "Box Count: 0"
        txtqr_cml.Clear()
        txtqr_cml.Enabled = False
        txtqr_sticker.Enabled = False
        txtqr_customer.Enabled = True
        txtqr_customer.Clear()
        txtqr_customer.Focus()
    End Sub

    Private Sub txtqr_sticker_TextChanged(sender As Object, e As EventArgs) Handles txtqr_sticker.TextChanged

    End Sub
End Class