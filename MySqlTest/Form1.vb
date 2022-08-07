
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection
        Dim myConnectionString As String

        myConnectionString = "server=127.0.0.1;" _
                    & "uid=root;" _
                    & "pwd=;" _
                    & "database=mysqltest"

        Try
            conn.ConnectionString = myConnectionString
            conn.Open()
            MessageBox.Show("Connected Database: " & conn.Database.ToString, "Connected!")
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try

        If conn.State = ConnectionState.Open Then
            conn.Close()
            MessageBox.Show("Connection Closed !", "Connecttion Lost")
        End If
    End Sub
End Class
