﻿Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtpcname.Text = PCname
            txtpcmac.Text = PCmac

            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("SELECT * FROM computer_location WHERE `PCname`='" & PCname & "' and `PCmac`='" & PCmac & "'", con)
            dr = cmdselect.ExecuteReader
            If dr.Read = True Then
                txtbarcode.Enabled = True
                txtbarcode.Focus()
                PClocation = dr.GetString("location")
                txtpclocation.Text = PClocation
            Else
                Dim result As DialogResult = MessageBox.Show("Machine not Verified!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)


                If result = DialogResult.OK Then
                    display_form(Register_PC)

                ElseIf result = DialogResult.Cancel Then
                    con.Close()
                    Application.Exit()
                End If



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            con.Close()
            txtbarcode.Clear()

        End Try
    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub
    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim idwithA As String = "A" & txtbarcode.Text & "A"
                Dim idwithoutA As String = txtbarcode.Text.TrimStart("A"c).TrimEnd("A"c)
                Dim idwithoutasmall As String = txtbarcode.Text.TrimStart("a"c).TrimEnd("a"c)

                con.Close()

                con.Open()

                    Dim query As String = "SELECT * FROM tblscanoperator_ms WHERE IDno = @idwithoutA OR IDno = @idwithA OR IDno = @idwithoutasmall"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.Parameters.AddWithValue("@idwithA", idwithA)
                        cmd.Parameters.AddWithValue("@idwithoutA", idwithoutA)
                        cmd.Parameters.AddWithValue("@idwithoutasmall", idwithoutasmall)

                        Using dr As MySqlDataReader = cmd.ExecuteReader()
                            If dr.Read() Then
                                fname = dr("fullname").ToString()
                                idno = dr("IDno").ToString()

                                display_form(sub_FRAME)
                                sub_FRAME.userstrip.Text = fname
                                labelerror.Visible = False
                            Else
                                noid()
                            End If
                        End Using
                    End Using


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                txtbarcode.Clear()
            End Try
        End If
    End Sub


    Private Sub noid()
        Try
            labelerror.Visible = True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class