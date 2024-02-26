Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form1
    Dim connectionString As String = "server=localhost;port=33066;userid=root;password='default123';database=Student"
    Dim connection As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim dataTable As DataTable
    Dim command As MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddStudent1.Hide()
        RudStudent1.Hide()

        Welcome1.Show()
        Welcome1.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RudStudent1.Hide()
        Welcome1.Hide()

        AddStudent1.Show()
        AddStudent1.BringToFront()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Connection = New MySqlConnection(connectionString)
        Try
            Connection.Open()
            Dim selectQuery As String = "SELECT * FROM student_detail"
            adapter = New MySqlDataAdapter(selectQuery, connection)
            dataTable = New DataTable()
            adapter.Fill(dataTable)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
            End If
        End Try
        AddStudent1.Hide()
        Welcome1.Hide()

        RudStudent1.Show()
        RudStudent1.BringToFront()
    End Sub
End Class