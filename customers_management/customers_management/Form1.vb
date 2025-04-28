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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Try
            connection.Open()
            sql = "INSERT INTO customers (name, address, phone, email, gender) VALUES (?, ?, ?, ?, ?)"

            Using dml As New OdbcCommand(sql, connection)

                dml.Parameters.AddWithValue("@name", txtCustomerName.Text)
                dml.Parameters.AddWithValue("@address", txtAddress.Text)
                dml.Parameters.AddWithValue("@phone", txtPhone.Text)
                dml.Parameters.AddWithValue("@email", txtEmail.Text)
                dml.Parameters.AddWithValue("@gender", comboGender.Text)

                dml.ExecuteNonQuery()
                MessageBox.Show("Lưu thành công!")
                LoadData()
                actClear()
            End Using

        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub LoadData()
        Dim dt As New DataTable()
        Try
            sql = "SELECT * FROM customers"

            Using dml As New OdbcCommand(sql, connection)
                Using adapter As New OdbcDataAdapter(dml)
                    adapter.Fill(dt)
                    customerView.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub actClear()
        txtCustomerName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtCustomerName.Focus()
        comboGender.SelectedIndex = -1
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim dt As New DataTable()
        Try
            sql = "SELECT * FROM customers WHERE name LIKE ?"

            Using dml As New OdbcCommand(sql, connection)

                dml.Parameters.AddWithValue("@name", "%" & txtCustomerName.Text & "%")

                Using adapter As New OdbcDataAdapter(dml)
                    adapter.Fill(dt)
                    customerView.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If customerView.SelectedRows.Count > 0 Then
            Dim id As Integer = customerView.SelectedRows(0).Cells("id").Value
            Try
                connection.Open()
                sql = "DELETE FROM customers WHERE id= ?"

                Using dml As New OdbcCommand(sql, connection)

                    dml.Parameters.AddWithValue("@id", id)
                    dml.ExecuteNonQuery()
                    MessageBox.Show("Đã xóa!")
                    LoadData()
                    actClear()
                End Using

            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Chọn một dòng để xóa!")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        actClear()
    End Sub

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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect_db()
        LoadData()
    End Sub
End Class
