Imports MySql.Data.MySqlClient

Public Class addStudent
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim connectionString As String = "server=localhost;port=33066;userid=root;password='default123';database=Student"
        conn = New MySqlConnection(connectionString)

        Try
            conn.Open()
            Dim insertQuery As String = "INSERT INTO student_detail(student_name,registration_number,location) VALUES(@name,@regNo,@location)"
            command = New MySqlCommand(insertQuery, conn)
            command.Parameters.AddWithValue("@name", NameTextBox.Text)
            command.Parameters.AddWithValue("@regNo", RegNoTextBox.Text)
            command.Parameters.AddWithValue("@location", LocationTextBox.Text)
            command.ExecuteNonQuery()
            MessageBox.Show("Student Created Successfully!!!")
        Catch ex As MySqlException
            MessageBox.Show("MySQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class
