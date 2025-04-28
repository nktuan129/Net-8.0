<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        labelCustomerName = New Label()
        txtCustomerName = New TextBox()
        labelAddress = New Label()
        txtAddress = New TextBox()
        labelPhone = New Label()
        txtPhone = New TextBox()
        labelEmail = New Label()
        txtEmail = New TextBox()
        labelGender = New Label()
        comboGender = New ComboBox()
        customerView = New DataGridView()
        btnSearch = New Button()
        btnSave = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        btnExit = New Button()
        CType(customerView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' labelCustomerName
        ' 
        labelCustomerName.AutoSize = True
        labelCustomerName.Location = New Point(12, 35)
        labelCustomerName.Margin = New Padding(4, 0, 4, 0)
        labelCustomerName.Name = "labelCustomerName"
        labelCustomerName.Size = New Size(111, 20)
        labelCustomerName.TabIndex = 1
        labelCustomerName.Text = "Tên khách hàng"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(16, 60)
        txtCustomerName.Margin = New Padding(4, 5, 4, 5)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(200, 27)
        txtCustomerName.TabIndex = 2
        ' 
        ' labelAddress
        ' 
        labelAddress.AutoSize = True
        labelAddress.Location = New Point(301, 35)
        labelAddress.Margin = New Padding(4, 0, 4, 0)
        labelAddress.Name = "labelAddress"
        labelAddress.Size = New Size(55, 20)
        labelAddress.TabIndex = 3
        labelAddress.Text = "Địa chỉ"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(305, 60)
        txtAddress.Margin = New Padding(4, 5, 4, 5)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(200, 27)
        txtAddress.TabIndex = 4
        ' 
        ' labelPhone
        ' 
        labelPhone.AutoSize = True
        labelPhone.Location = New Point(584, 35)
        labelPhone.Margin = New Padding(4, 0, 4, 0)
        labelPhone.Name = "labelPhone"
        labelPhone.Size = New Size(97, 20)
        labelPhone.TabIndex = 5
        labelPhone.Text = "Số điện thoại"
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(588, 60)
        txtPhone.Margin = New Padding(4, 5, 4, 5)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 27)
        txtPhone.TabIndex = 6
        ' 
        ' labelEmail
        ' 
        labelEmail.AutoSize = True
        labelEmail.Location = New Point(12, 148)
        labelEmail.Margin = New Padding(4, 0, 4, 0)
        labelEmail.Name = "labelEmail"
        labelEmail.Size = New Size(46, 20)
        labelEmail.TabIndex = 7
        labelEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(16, 172)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 27)
        txtEmail.TabIndex = 8
        ' 
        ' labelGender
        ' 
        labelGender.AutoSize = True
        labelGender.Location = New Point(301, 148)
        labelGender.Margin = New Padding(4, 0, 4, 0)
        labelGender.Name = "labelGender"
        labelGender.Size = New Size(65, 20)
        labelGender.TabIndex = 9
        labelGender.Text = "Giới tính"
        ' 
        ' comboGender
        ' 
        comboGender.FormattingEnabled = True
        comboGender.Items.AddRange(New Object() {"Nam", "Nữ"})
        comboGender.Location = New Point(305, 169)
        comboGender.Margin = New Padding(4, 5, 4, 5)
        comboGender.Name = "comboGender"
        comboGender.Size = New Size(200, 28)
        comboGender.TabIndex = 10
        ' 
        ' customerView
        ' 
        customerView.AllowUserToAddRows = False
        customerView.AllowUserToDeleteRows = False
        customerView.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        customerView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        customerView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        customerView.Font = New Font("Tahoma", 12F)
        customerView.Location = New Point(16, 368)
        customerView.Margin = New Padding(4, 5, 4, 5)
        customerView.Name = "customerView"
        customerView.ReadOnly = True
        customerView.RowHeadersVisible = False
        customerView.RowHeadersWidth = 51
        customerView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        customerView.Size = New Size(772, 368)
        customerView.TabIndex = 11
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(17, 271)
        btnSearch.Margin = New Padding(4, 5, 4, 5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(152, 35)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Tìm kiếm"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(177, 271)
        btnSave.Margin = New Padding(4, 5, 4, 5)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(152, 35)
        btnSave.TabIndex = 14
        btnSave.Text = "Lưu"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(353, 271)
        btnDelete.Margin = New Padding(4, 5, 4, 5)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(152, 35)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Xóa"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(529, 271)
        btnClear.Margin = New Padding(4, 5, 4, 5)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(152, 35)
        btnClear.TabIndex = 16
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(697, 274)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 17
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(805, 768)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(btnSearch)
        Controls.Add(customerView)
        Controls.Add(comboGender)
        Controls.Add(labelGender)
        Controls.Add(txtEmail)
        Controls.Add(labelEmail)
        Controls.Add(txtPhone)
        Controls.Add(labelPhone)
        Controls.Add(txtAddress)
        Controls.Add(labelAddress)
        Controls.Add(txtCustomerName)
        Controls.Add(labelCustomerName)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Form1"
        CType(customerView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents labelCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents labelAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents labelPhone As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents labelEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents labelGender As System.Windows.Forms.Label
    Friend WithEvents comboGender As System.Windows.Forms.ComboBox
    Friend WithEvents customerView As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As Button

End Class
