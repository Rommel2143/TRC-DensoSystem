
Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient


Public Class parts_RETURN



    Dim qrlenght As Integer
    Dim serialNumber As String = ""

    Dim partno As String
    Dim qty As Integer
    Dim customerno As String
    Dim color As String
    Dim prod As String
    Dim shift As String
    Dim process As String
    Dim line As String
    Dim series As String
    Private Sub part_IN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtdate.Text = date1
    End Sub
    Public Sub display_error(text As String, play As Integer)
        error_panel.Show()
        lbl_error.Text = text

        Select Case play
            Case 0
                sounderror()
            Case 1
                soundduplicate()
        End Select
    End Sub



    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try

                con.Close()
                            con.Open()
                            Dim cmdselect As New MySqlCommand("SELECT qrcode,partno, userin, datein,status,qty FROM `denso_parts`
                                                WHERE qrcode = '" & txtqr.Text & "'", con)
                            dr = cmdselect.ExecuteReader()
                            If dr.Read = True Then
                                lbl_partno.Text = dr.GetString("partno")
                                lbl_qty.Text = dr.GetInt32("qty")

                                Select Case dr.GetInt32("status")
                                    Case 0
                            con.Close()
                            con.Open()
                            Dim cmdupdate As New MySqlCommand("UPDATE `denso_parts` SET status=1 
                                                WHERE qrcode = '" & txtqr.Text & "'", con)
                            cmdupdate.ExecuteNonQuery()

                        Case 1
                                        display_error("Box not Scanned as OUT. Scan first!", 0)
                                End Select

                            Else
                                'norecord
                                display_error("No record. Please scan in first", 0)
                            End If





                        txtqr.Clear()
                txtqr.Focus()

            Catch ex As MySqlException
                display_error("Error on scanning : " & ex.Message, 0)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class