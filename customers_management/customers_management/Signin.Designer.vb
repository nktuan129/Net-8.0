<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtUsername = New TextBox()
        txtPassw = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnSignin = New Button()
        btnExit = New Button()
        btnSignup = New Button()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(176, 80)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Multiline = True
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(248, 39)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassw
        ' 
        txtPassw.Location = New Point(176, 185)
        txtPassw.Margin = New Padding(3, 4, 3, 4)
        txtPassw.Multiline = True
        txtPassw.Name = "txtPassw"
        txtPassw.PasswordChar = "*"c
        txtPassw.Size = New Size(248, 39)
        txtPassw.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(64, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 20)
        Label1.TabIndex = 1
        Label1.Text = "User name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(64, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' btnSignin
        ' 
        btnSignin.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignin.Location = New Point(68, 269)
        btnSignin.Margin = New Padding(3, 4, 3, 4)
        btnSignin.Name = "btnSignin"
        btnSignin.Size = New Size(90, 51)
        btnSignin.TabIndex = 2
        btnSignin.Text = "Sign in"
        btnSignin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(247, 269)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 51)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnSignup
        ' 
        btnSignup.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSignup.Location = New Point(406, 269)
        btnSignup.Margin = New Padding(3, 4, 3, 4)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(91, 51)
        btnSignup.TabIndex = 3
        btnSignup.Text = "Sign up"
        btnSignup.UseVisualStyleBackColor = True
        ' 
        ' Signin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(509, 391)
        Controls.Add(btnExit)
        Controls.Add(btnSignup)
        Controls.Add(btnSignin)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassw)
        Controls.Add(txtUsername)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Signin"
        Text = "Sign in"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassw As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSignin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSignup As Button
End Class
