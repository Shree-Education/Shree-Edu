<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FogortPasswordForm
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
        Me.selectSecurityQuestionComboBox = New System.Windows.Forms.ComboBox
        Me.securityQuestionAnswerTextBox = New System.Windows.Forms.TextBox
        Me.nextButton = New System.Windows.Forms.Button
        Me.selectUserNameComboBox = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'selectSecurityQuestionComboBox
        '
        Me.selectSecurityQuestionComboBox.FormattingEnabled = True
        Me.selectSecurityQuestionComboBox.Location = New System.Drawing.Point(12, 69)
        Me.selectSecurityQuestionComboBox.Name = "selectSecurityQuestionComboBox"
        Me.selectSecurityQuestionComboBox.Size = New System.Drawing.Size(410, 21)
        Me.selectSecurityQuestionComboBox.TabIndex = 1
        Me.selectSecurityQuestionComboBox.Text = "Select your security question here"
        '
        'securityQuestionAnswerTextBox
        '
        Me.securityQuestionAnswerTextBox.Location = New System.Drawing.Point(13, 124)
        Me.securityQuestionAnswerTextBox.Name = "securityQuestionAnswerTextBox"
        Me.securityQuestionAnswerTextBox.Size = New System.Drawing.Size(167, 20)
        Me.securityQuestionAnswerTextBox.TabIndex = 2
        Me.securityQuestionAnswerTextBox.Text = "Your Answer"
        '
        'nextButton
        '
        Me.nextButton.Location = New System.Drawing.Point(12, 227)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(75, 23)
        Me.nextButton.TabIndex = 3
        Me.nextButton.Text = "Next >>"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'selectUserNameComboBox
        '
        Me.selectUserNameComboBox.FormattingEnabled = True
        Me.selectUserNameComboBox.Location = New System.Drawing.Point(12, 33)
        Me.selectUserNameComboBox.Name = "selectUserNameComboBox"
        Me.selectUserNameComboBox.Size = New System.Drawing.Size(168, 21)
        Me.selectUserNameComboBox.TabIndex = 0
        Me.selectUserNameComboBox.Text = "Select Your User Name"
        '
        'FogortPasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 262)
        Me.Controls.Add(Me.selectUserNameComboBox)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.securityQuestionAnswerTextBox)
        Me.Controls.Add(Me.selectSecurityQuestionComboBox)
        Me.Name = "FogortPasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fogort Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selectSecurityQuestionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents securityQuestionAnswerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents selectUserNameComboBox As System.Windows.Forms.ComboBox
End Class
