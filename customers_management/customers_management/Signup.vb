Imports System.Data.Odbc
Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Signup
    Private Sub actClear()
        txtUsername.Clear()
        txtPassw.Clear()
        txtMail.Clear()
    End Sub
    Public Function GetMD5(ByVal str As String) As String
        Dim md5 As MD5 = MD5.Create()
        Dim inputBytes As Byte() = Encoding.ASCII.GetBytes(str)
        Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)

        Dim sb As New StringBuilder()
        For i As Integer = 0 To hashBytes.Length - 1
            sb.Append(hashBytes(i).ToString("x2"))
        Next

        Return sb.ToString()
    End Function

    Private Function chkUser(ByVal username As String) As Boolean
        Try
            connection.Open()
            Dim sql As String = "SELECT COUNT(*) FROM users WHERE user_name = ?"

            Using dml As New OdbcCommand(sql, connection)
                dml.Parameters.AddWithValue("@user_name", username)
                Dim count As Integer = CInt(dml.ExecuteScalar())
                Return count > 0
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function IsValidEmail(ByVal email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassw.Text.Trim()
        Dim mail As String = txtMail.Text.Trim()

        'Check Username, Password, Mail: Null
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Or String.IsNullOrEmpty(mail) Then
            MessageBox.Show("Username, Password, E-mail không được để trống!")
            Return
        Else
            'Check User unique
            If chkUser(username) Then
                MessageBox.Show("Username đã tồn tại. Vui lòng chọn tên khác!")
                Return
            End If

            'Check Length Pass < 6
            If password.Length < 6 Then
                MessageBox.Show("Pass phải có từ 6 ký tự trở lên!")
                Return
            Else

            End If
            'Check Mail type
            If Not IsValidEmail(mail) Then
                MessageBox.Show("E-mail không hợp lệ!")
                Return
            End If
        End If

        Dim hashedPassword As String = GetMD5(password)
        Try
            connection.Open()
            Dim sql As String = "INSERT INTO users (user_name, user_password, user_mail) VALUES (?, ?, ?)"

            Using dml As New OdbcCommand(sql, connection)

                dml.Parameters.AddWithValue("@user_name", username)
                dml.Parameters.AddWithValue("@user_password", hashedPassword)
                dml.Parameters.AddWithValue("@user_mail", mail)

                dml.ExecuteNonQuery()
                MessageBox.Show("Đăng ký thành công!")
                actClear()
                Dim frm As New Signin()
                frm.ShowDialog()
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect_db()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
