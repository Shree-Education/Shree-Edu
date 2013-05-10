<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_User
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
        Me.newUserNameLabel = New System.Windows.Forms.Label
        Me.newPasswordLabel = New System.Windows.Forms.Label
        Me.newUserNameTextBox = New System.Windows.Forms.TextBox
        Me.newPasswordTextBox = New System.Windows.Forms.TextBox
        Me.addUserButton = New System.Windows.Forms.Button
        Me.securityQuestionLabel = New System.Windows.Forms.Label
        Me.answerLabel = New System.Windows.Forms.Label
        Me.securityQuestionComboBox = New System.Windows.Forms.ComboBox
        Me.answerTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'newUserNameLabel
        '
        Me.newUserNameLabel.AutoSize = True
        Me.newUserNameLabel.Location = New System.Drawing.Point(45, 59)
        Me.newUserNameLabel.Name = "newUserNameLabel"
        Me.newUserNameLabel.Size = New System.Drawing.Size(82, 13)
        Me.newUserNameLabel.TabIndex = 0
        Me.newUserNameLabel.Text = "New UserName"
        '
        'newPasswordLabel
        '
        Me.newPasswordLabel.AutoSize = True
        Me.newPasswordLabel.Location = New System.Drawing.Point(45, 92)
        Me.newPasswordLabel.Name = "newPasswordLabel"
        Me.newPasswordLabel.Size = New System.Drawing.Size(78, 13)
        Me.newPasswordLabel.TabIndex = 1
        Me.newPasswordLabel.Text = "New Password"
        '
        'newUserNameTextBox
        '
        Me.newUserNameTextBox.Location = New System.Drawing.Point(181, 59)
        Me.newUserNameTextBox.Name = "newUserNameTextBox"
        Me.newUserNameTextBox.Size = New System.Drawing.Size(130, 20)
        Me.newUserNameTextBox.TabIndex = 2
        '
        'newPasswordTextBox
        '
        Me.newPasswordTextBox.Location = New System.Drawing.Point(181, 92)
        Me.newPasswordTextBox.Name = "newPasswordTextBox"
        Me.newPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPasswordTextBox.Size = New System.Drawing.Size(130, 20)
        Me.newPasswordTextBox.TabIndex = 3
        '
        'addUserButton
        '
        Me.addUserButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUserButton.Location = New System.Drawing.Point(132, 207)
        Me.addUserButton.Name = "addUserButton"
        Me.addUserButton.Size = New System.Drawing.Size(96, 33)
        Me.addUserButton.TabIndex = 6
        Me.addUserButton.Text = "Add User"
        Me.addUserButton.UseVisualStyleBackColor = True
        '
        'securityQuestionLabel
        '
        Me.securityQuestionLabel.AutoSize = True
        Me.securityQuestionLabel.Location = New System.Drawing.Point(48, 130)
        Me.securityQuestionLabel.Name = "securityQuestionLabel"
        Me.securityQuestionLabel.Size = New System.Drawing.Size(90, 13)
        Me.securityQuestionLabel.TabIndex = 19
        Me.securityQuestionLabel.Text = "Security Question"
        '
        'answerLabel
        '
        Me.answerLabel.AutoSize = True
        Me.answerLabel.Location = New System.Drawing.Point(48, 161)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(93, 13)
        Me.answerLabel.TabIndex = 20
        Me.answerLabel.Text = "Enter your Answer"
        '
        'securityQuestionComboBox
        '
        Me.securityQuestionComboBox.FormattingEnabled = True
        Me.securityQuestionComboBox.Location = New System.Drawing.Point(181, 127)
        Me.securityQuestionComboBox.Name = "securityQuestionComboBox"
        Me.securityQuestionComboBox.Size = New System.Drawing.Size(219, 21)
        Me.securityQuestionComboBox.TabIndex = 4
        '
        'answerTextBox
        '
        Me.answerTextBox.Location = New System.Drawing.Point(181, 158)
        Me.answerTextBox.Name = "answerTextBox"
        Me.answerTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.answerTextBox.Size = New System.Drawing.Size(130, 20)
        Me.answerTextBox.TabIndex = 5
        '
        'Add_User
        '
        Me.AcceptButton = Me.addUserButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 262)
        Me.Controls.Add(Me.answerTextBox)
        Me.Controls.Add(Me.securityQuestionComboBox)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.securityQuestionLabel)
        Me.Controls.Add(Me.addUserButton)
        Me.Controls.Add(Me.newPasswordTextBox)
        Me.Controls.Add(Me.newUserNameTextBox)
        Me.Controls.Add(Me.newPasswordLabel)
        Me.Controls.Add(Me.newUserNameLabel)
        Me.Name = "Add_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newUserNameLabel As System.Windows.Forms.Label
    Friend WithEvents newPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents newUserNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents newPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addUserButton As System.Windows.Forms.Button
    Friend WithEvents securityQuestionLabel As System.Windows.Forms.Label
    Friend WithEvents answerLabel As System.Windows.Forms.Label
    Friend WithEvents securityQuestionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents answerTextBox As System.Windows.Forms.TextBox
End Class
