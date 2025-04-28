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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.labelCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.labelAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.labelPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.labelGender = New System.Windows.Forms.Label()
        Me.comboGender = New System.Windows.Forms.ComboBox()
        Me.customerView = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.customerView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelCustomerName
        '
        Me.labelCustomerName.AutoSize = True
        Me.labelCustomerName.Location = New System.Drawing.Point(12, 28)
        Me.labelCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCustomerName.Name = "labelCustomerName"
        Me.labelCustomerName.Size = New System.Drawing.Size(103, 16)
        Me.labelCustomerName.TabIndex = 1
        Me.labelCustomerName.Text = "Tên khách hàng"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(16, 48)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(200, 22)
        Me.txtCustomerName.TabIndex = 2
        '
        'labelAddress
        '
        Me.labelAddress.AutoSize = True
        Me.labelAddress.Location = New System.Drawing.Point(301, 28)
        Me.labelAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelAddress.Name = "labelAddress"
        Me.labelAddress.Size = New System.Drawing.Size(47, 16)
        Me.labelAddress.TabIndex = 3
        Me.labelAddress.Text = "Địa chỉ"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(305, 48)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 22)
        Me.txtAddress.TabIndex = 4
        '
        'labelPhone
        '
        Me.labelPhone.AutoSize = True
        Me.labelPhone.Location = New System.Drawing.Point(584, 28)
        Me.labelPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelPhone.Name = "labelPhone"
        Me.labelPhone.Size = New System.Drawing.Size(85, 16)
        Me.labelPhone.TabIndex = 5
        Me.labelPhone.Text = "Số điện thoại"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(588, 48)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(200, 22)
        Me.txtPhone.TabIndex = 6
        '
        'labelEmail
        '
        Me.labelEmail.AutoSize = True
        Me.labelEmail.Location = New System.Drawing.Point(12, 118)
        Me.labelEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelEmail.Name = "labelEmail"
        Me.labelEmail.Size = New System.Drawing.Size(41, 16)
        Me.labelEmail.TabIndex = 7
        Me.labelEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(16, 138)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 22)
        Me.txtEmail.TabIndex = 8
        '
        'labelGender
        '
        Me.labelGender.AutoSize = True
        Me.labelGender.Location = New System.Drawing.Point(301, 118)
        Me.labelGender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelGender.Name = "labelGender"
        Me.labelGender.Size = New System.Drawing.Size(54, 16)
        Me.labelGender.TabIndex = 9
        Me.labelGender.Text = "Giới tính"
        '
        'comboGender
        '
        Me.comboGender.FormattingEnabled = True
        Me.comboGender.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.comboGender.Location = New System.Drawing.Point(305, 135)
        Me.comboGender.Margin = New System.Windows.Forms.Padding(4)
        Me.comboGender.Name = "comboGender"
        Me.comboGender.Size = New System.Drawing.Size(200, 24)
        Me.comboGender.TabIndex = 10
        '
        'customerView
        '
        Me.customerView.AllowUserToAddRows = False
        Me.customerView.AllowUserToDeleteRows = False
        Me.customerView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.customerView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customerView.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.customerView.Location = New System.Drawing.Point(16, 294)
        Me.customerView.Margin = New System.Windows.Forms.Padding(4)
        Me.customerView.Name = "customerView"
        Me.customerView.ReadOnly = True
        Me.customerView.RowHeadersVisible = False
        Me.customerView.RowHeadersWidth = 51
        Me.customerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.customerView.Size = New System.Drawing.Size(772, 294)
        Me.customerView.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(17, 217)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(152, 28)
        Me.btnSearch.TabIndex = 13
        Me.btnSearch.Text = "Tìm kiếm"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(212, 217)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(152, 28)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Lưu"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(429, 217)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(152, 28)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Xóa"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(636, 217)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 28)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 614)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.customerView)
        Me.Controls.Add(Me.comboGender)
        Me.Controls.Add(Me.labelGender)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.labelEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.labelPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.labelAddress)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.labelCustomerName)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.customerView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

End Class
