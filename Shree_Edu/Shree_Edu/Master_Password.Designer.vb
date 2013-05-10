<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master_Password
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
        Me.resetNewPasswordButton = New System.Windows.Forms.Button
        Me.masterPasswordTextBox = New System.Windows.Forms.TextBox
        Me.masterPasswordLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'resetNewPasswordButton
        '
        Me.resetNewPasswordButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetNewPasswordButton.Location = New System.Drawing.Point(22, 186)
        Me.resetNewPasswordButton.Name = "resetNewPasswordButton"
        Me.resetNewPasswordButton.Size = New System.Drawing.Size(96, 33)
        Me.resetNewPasswordButton.TabIndex = 17
        Me.resetNewPasswordButton.Text = "Enter >>"
        Me.resetNewPasswordButton.UseVisualStyleBackColor = True
        '
        'masterPasswordTextBox
        '
        Me.masterPasswordTextBox.Location = New System.Drawing.Point(22, 82)
        Me.masterPasswordTextBox.Name = "masterPasswordTextBox"
        Me.masterPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.masterPasswordTextBox.Size = New System.Drawing.Size(210, 20)
        Me.masterPasswordTextBox.TabIndex = 1
        '
        'masterPasswordLabel
        '
        Me.masterPasswordLabel.AutoSize = True
        Me.masterPasswordLabel.Location = New System.Drawing.Point(22, 51)
        Me.masterPasswordLabel.Name = "masterPasswordLabel"
        Me.masterPasswordLabel.Size = New System.Drawing.Size(132, 13)
        Me.masterPasswordLabel.TabIndex = 3
        Me.masterPasswordLabel.Text = "Enter the master password"
        '
        'Master_Password
        '
        Me.AcceptButton = Me.resetNewPasswordButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.masterPasswordLabel)
        Me.Controls.Add(Me.masterPasswordTextBox)
        Me.Controls.Add(Me.resetNewPasswordButton)
        Me.KeyPreview = True
        Me.Name = "Master_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents resetNewPasswordButton As System.Windows.Forms.Button
    Friend WithEvents masterPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents masterPasswordLabel As System.Windows.Forms.Label
End Class
