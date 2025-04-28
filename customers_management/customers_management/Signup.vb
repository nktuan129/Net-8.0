Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Signup
    ' Helper method to execute scalar queries
    Private Function ExecuteScalarQuery(query As String, parameters As List(Of OdbcParameter)) As Integer
        Try
            connection.Open()
            Using command As New OdbcCommand(query, connection)
                If parameters IsNot Nothing Then
                    command.Parameters.AddRange(parameters.ToArray())
                End If
                Return CInt(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return -1
        Finally
            connection.Close()
        End Try
    End Function

    ' Helper method to execute non-query commands
    Private Sub ExecuteNonQuery(query As String, parameters As List(Of OdbcParameter))
        Try
            connection.Open()
            Using command As New OdbcCommand(query, connection)
                If parameters IsNot Nothing Then
                    command.Parameters.AddRange(parameters.ToArray())
                End If
                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Generate MD5 hash for a given string
    Public Function GetMD5(ByVal str As String) As String
        Using md5 As MD5 = MD5.Create()
            Dim inputBytes As Byte() = Encoding.ASCII.GetBytes(str)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)

            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    ' Check if a username already exists
    Private Function IsUsernameTaken(ByVal username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE user_name = ?"
        Dim parameters As New List(Of OdbcParameter) From {
            New OdbcParameter("@user_name", username)
        }
        Return ExecuteScalarQuery(query, parameters) > 0
    End Function

    ' Validate email format
    Public Function IsValidEmail(ByVal email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim regex As New Regex(pattern)
        Return regex.IsMatch(email)
    End Function

    ' Clear form fields
    Private Sub ClearForm()
        txtUsername.Clear()
        txtPassw.Clear()
        txtMail.Clear()
    End Sub

    ' Handle Sign Up button click
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassw.Text.Trim()
        Dim email As String = txtMail.Text.Trim()

        ' Validate input fields
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) OrElse String.IsNullOrEmpty(email) Then
            MessageBox.Show("Username, Password, and Email cannot be empty!")
            Return
        End If

        If IsUsernameTaken(username) Then
            MessageBox.Show("Username already exists. Please choose a different one!")
            Return
        End If

        If password.Length < 6 Then
            MessageBox.Show("Password must be at least 6 characters long!")
            Return
        End If

        If Not IsValidEmail(email) Then
            MessageBox.Show("Invalid email format!")
            Return
        End If

        ' Insert new user into the database
        Dim hashedPassword As String = GetMD5(password)
        Dim query As String = "INSERT INTO users (user_name, user_password, user_mail) VALUES (?, ?, ?)"
        Dim parameters As New List(Of OdbcParameter) From {
            New OdbcParameter("@user_name", username),
            New OdbcParameter("@user_password", hashedPassword),
            New OdbcParameter("@user_mail", email)
        }

        ExecuteNonQuery(query, parameters)
        MessageBox.Show("Registration successful!")
        ClearForm()

        ' Open Sign In form
        Dim signinForm As New Signin()
        signinForm.ShowDialog()
    End Sub

    ' Load event for Signup form
    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect_db()
    End Sub

    ' Handle Exit button click
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
