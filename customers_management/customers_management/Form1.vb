Imports System.Data.Odbc
Public Class Form1
    Private Sub txtCustomerName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomerName.TextChanged

    End Sub

    Private Sub txtAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtPhone_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub txtEmail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub comboGender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboGender.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles customerView.CellContentClick

    End Sub

    ' Clear form fields
    Private Sub ClearForm()
        txtCustomerName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        comboGender.SelectedIndex = -1
        txtCustomerName.Focus()
    End Sub

    ' Helper method to execute database queries
    Private Sub ExecuteQuery(query As String, parameters As List(Of OdbcParameter), action As Action(Of OdbcCommand))
        Try
            connection.Open()
            Using command As New OdbcCommand(query, connection)
                If parameters IsNot Nothing Then
                    command.Parameters.AddRange(parameters.ToArray())
                End If
                action(command)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Load customer data into DataGridView
    Private Sub LoadCustomerData()
        Dim query As String = "SELECT * FROM customers"
        ExecuteQuery(query, Nothing, Sub(cmd)
                                         Dim dt As New DataTable()
                                         Using adapter As New OdbcDataAdapter(cmd)
                                             adapter.Fill(dt)
                                             customerView.DataSource = dt
                                         End Using
                                     End Sub)
    End Sub

    ' Save customer data
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim query As String = "INSERT INTO customers (name, address, phone, email, gender) VALUES (?, ?, ?, ?, ?)"
        Dim parameters As New List(Of OdbcParameter) From {
            New OdbcParameter("@name", txtCustomerName.Text),
            New OdbcParameter("@address", txtAddress.Text),
            New OdbcParameter("@phone", txtPhone.Text),
            New OdbcParameter("@email", txtEmail.Text),
            New OdbcParameter("@gender", comboGender.Text)
        }

        ExecuteQuery(query, parameters, Sub(cmd)
                                            cmd.ExecuteNonQuery()
                                            MessageBox.Show("Saved successfully!")
                                            LoadCustomerData()
                                            ClearForm()
                                        End Sub)
    End Sub

    ' Search for customers by name
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim query As String = "SELECT * FROM customers WHERE name LIKE ?"
        Dim parameters As New List(Of OdbcParameter) From {
            New OdbcParameter("@name", "%" & txtCustomerName.Text & "%")
        }

        ExecuteQuery(query, parameters, Sub(cmd)
                                            Dim dt As New DataTable()
                                            Using adapter As New OdbcDataAdapter(cmd)
                                                adapter.Fill(dt)
                                                customerView.DataSource = dt
                                            End Using
                                        End Sub)
    End Sub

    ' Delete selected customer
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If customerView.SelectedRows.Count > 0 Then
            Dim id As Integer = customerView.SelectedRows(0).Cells("id").Value
            Dim query As String = "DELETE FROM customers WHERE id = ?"
            Dim parameters As New List(Of OdbcParameter) From {
                New OdbcParameter("@id", id)
            }

            ExecuteQuery(query, parameters, Sub(cmd)
                                                cmd.ExecuteNonQuery()
                                                MessageBox.Show("Deleted successfully!")
                                                LoadCustomerData()
                                                ClearForm()
                                            End Sub)
        Else
            MessageBox.Show("Please select a row to delete!")
        End If
    End Sub

    ' Populate form fields when a row is clicked
    Private Sub customerView_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles customerView.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = customerView.Rows(e.RowIndex)
            txtCustomerName.Text = row.Cells("name").Value.ToString()
            txtAddress.Text = row.Cells("address").Value.ToString()
            txtPhone.Text = row.Cells("phone").Value.ToString()
            txtEmail.Text = row.Cells("email").Value.ToString()
            comboGender.Text = row.Cells("gender").Value.ToString()
        End If
    End Sub

    ' Clear form fields
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    ' Load data on form load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect_db()
        LoadCustomerData()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
