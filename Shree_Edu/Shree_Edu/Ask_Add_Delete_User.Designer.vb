<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ask_Add_Delete_User
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
        Me.deleteUserComboBox = New System.Windows.Forms.ComboBox
        Me.deleteButton = New System.Windows.Forms.Button
        Me.addUserButton = New System.Windows.Forms.Button
        Me.deleteUserButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'deleteUserComboBox
        '
        Me.deleteUserComboBox.FormattingEnabled = True
        Me.deleteUserComboBox.Location = New System.Drawing.Point(13, 117)
        Me.deleteUserComboBox.Name = "deleteUserComboBox"
        Me.deleteUserComboBox.Size = New System.Drawing.Size(227, 21)
        Me.deleteUserComboBox.TabIndex = 9
        Me.deleteUserComboBox.Visible = False
        '
        'deleteButton
        '
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(13, 208)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(112, 33)
        Me.deleteButton.TabIndex = 10
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = True
        Me.deleteButton.Visible = False
        '
        'addUserButton
        '
        Me.addUserButton.Location = New System.Drawing.Point(31, 44)
        Me.addUserButton.Name = "addUserButton"
        Me.addUserButton.Size = New System.Drawing.Size(75, 23)
        Me.addUserButton.TabIndex = 11
        Me.addUserButton.Text = "Add User"
        Me.addUserButton.UseVisualStyleBackColor = True
        '
        'deleteUserButton
        '
        Me.deleteUserButton.Location = New System.Drawing.Point(138, 44)
        Me.deleteUserButton.Name = "deleteUserButton"
        Me.deleteUserButton.Size = New System.Drawing.Size(75, 23)
        Me.deleteUserButton.TabIndex = 12
        Me.deleteUserButton.Text = "Delete User"
        Me.deleteUserButton.UseVisualStyleBackColor = True
        '
        'Ask_Add_Delete_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.deleteUserButton)
        Me.Controls.Add(Me.addUserButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.deleteUserComboBox)
        Me.Name = "Ask_Add_Delete_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ask_Add_Delete_User"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deleteUserComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents deleteButton As System.Windows.Forms.Button
    Friend WithEvents addUserButton As System.Windows.Forms.Button
    Friend WithEvents deleteUserButton As System.Windows.Forms.Button
End Class
