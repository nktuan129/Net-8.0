Imports System.Data.Odbc
Imports System.Security.Cryptography
Imports System.Text

Public Class Signin
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

    ' Handle Sign In button click
    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassw.Text.Trim()

        ' Check if username or password is empty
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Username and Password cannot be empty!")
            Return
        End If

        Dim hashedPassword As String = GetMD5(password)

        Dim query As String = "SELECT COUNT(*) FROM users WHERE user_name = ? AND user_password = ?"
        Dim parameters As New List(Of OdbcParameter) From {
            New OdbcParameter("@user_name", username),
            New OdbcParameter("@user_password", hashedPassword)
        }

        Dim count As Integer = ExecuteScalarQuery(query, parameters)
        If count > 0 Then
            MessageBox.Show("Login successful!")
            txtUsername.Clear()
            txtPassw.Clear()
            Dim frm As New Form1()
            frm.ShowDialog()
        ElseIf count = 0 Then
            MessageBox.Show("Invalid username or password. If you do not have an account, please Signup.")
            btnSignup.Visible = True
        End If
    End Sub

    ' Handle Sign Up button click
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim frm As New Signup()
        frm.ShowDialog()
    End Sub

    ' Handle Exit button click
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    ' Load event for Signin form
    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect_db()
        btnSignup.Visible = False
    End Sub
End Class
