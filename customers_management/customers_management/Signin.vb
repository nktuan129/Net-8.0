Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text

Public Class Signin

    Public Function GetMD5(ByVal str As String) As String
        Dim md5 As MD5 = md5.Create()
        Dim inputBytes As Byte() = Encoding.ASCII.GetBytes(str)
        Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)

        Dim sb As New StringBuilder()
        For i As Integer = 0 To hashBytes.Length - 1
            sb.Append(hashBytes(i).ToString("x2"))
        Next

        Return sb.ToString()
    End Function
    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassw.Text.Trim()
        Dim hashedPassword As String = GetMD5(password)
        Try
            connection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM users WHERE user_name = ? AND user_password = ?"

            Using dml As New OdbcCommand(sql, connection)

                dml.Parameters.AddWithValue("@user_name", username)
                dml.Parameters.AddWithValue("@user_password", hashedPassword)

                Dim count As Integer = CInt(dml.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("Đăng nhập thành công!")
                    Dim frm As New Form1()
                    frm.ShowDialog()
                Else
                    MessageBox.Show("Sai username hoặc mật khẩu.")
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim frm As New Signup()
        frm.ShowDialog()

    End Sub
    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect_db()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class