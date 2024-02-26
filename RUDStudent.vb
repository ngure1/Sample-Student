Imports MySql.Data.MySqlClient

Public Class RUDStudent
    Dim connectionString As String = "server=localhost;port=33066;userid=root;password='default123';database=Student"
    Dim connection As MySqlConnection
    Dim adapter As MySqlDataAdapter
    Dim dataTable As DataTable
    Dim command As MySqlCommand
    Private Sub RUDStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New MySqlConnection(connectionString)
        Try
            connection.Open()

            Dim selectQuery As String = "SELECT * FROM student_detail"
            adapter = New MySqlDataAdapter(selectQuery, connection)

            dataTable = New DataTable()

            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable

            DataGridView1.Dock = DockStyle.Fill
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.ScrollBars = ScrollBars.Vertical
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub PopulateTextBoxesFromSelectedRow(selectedRow As DataGridViewRow)
        ' Extract data from the selected row
        Dim student_id As Integer = Convert.ToInt32(selectedRow.Cells("student_id").Value)
        Dim student_name As String = selectedRow.Cells("student_name").Value.ToString()
        Dim regNo As String = selectedRow.Cells("registration_number").Value.ToString()
        Dim location As String = selectedRow.Cells("location").Value.ToString()

        ' Populate textboxes with data
        IdTextBox.Text = student_id.ToString()
        NameTextBox.Text = student_name
        RegNoTextBox.Text = regNo
        LocationTextBox.Text = location
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            ' Populate textboxes with data from the selected row
            PopulateTextBoxesFromSelectedRow(selectedRow)
        End If
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim student_id As Integer = Integer.Parse(IdTextBox.Text)
                Dim student_name As String = NameTextBox.Text
                Dim regNo As String = RegNoTextBox.Text
                Dim location As String = LocationTextBox.Text

                Dim updateQuery As String = "UPDATE student_detail SET student_name=@student_name ,registration_number = @regNo , location = @location WHERE student_id = @student_id"

                Using command As New MySqlCommand(updateQuery, connection)

                    command.Parameters.AddWithValue("@student_id", student_id)
                    command.Parameters.AddWithValue("@student_name", student_name)
                    command.Parameters.AddWithValue("@regNo", regNo)
                    command.Parameters.AddWithValue("@location", location)

                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("Student updated successfully")

                ' Refresh the DataGridView to reflect the changes
                dataTable.Clear()
                adapter.Fill(dataTable)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim deleteQuery As String = "DELETE FROM student_detail WHERE student_id = @student_id"
                Using command As New MySqlCommand(deleteQuery, connection)

                    command.Parameters.AddWithValue("@student_id", Integer.Parse(IdTextBox.Text))

                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("Student deleted successfully")

                dataTable.Clear()
                adapter.Fill(dataTable)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            ' Close the connection
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        ' Refresh the DataGridView to reflect the changes
        dataTable.Clear()
        adapter.Fill(dataTable)
    End Sub
End Class
