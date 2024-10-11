Imports System.ComponentModel

Public Class Mainframe
    Private Sub molding_mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display_form(New Login)
    End Sub

    Private Sub Mainframe_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            ' Close database connection
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Add any cleanup code here if necessary

        Catch ex As Exception
            MessageBox.Show("Error closing application: " & ex.Message)
        Finally
            Application.Exit() ' Ensure the application exits
        End Try
    End Sub
End Class