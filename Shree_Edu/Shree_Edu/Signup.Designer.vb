<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Me.Login_Link = New System.Windows.Forms.LinkLabel
        Me.Button6 = New System.Windows.Forms.Button
        Me.signupbtn = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.spwd = New System.Windows.Forms.TextBox
        Me.srpwd = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.suid = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Login_Link
        '
        Me.Login_Link.AutoSize = True
        Me.Login_Link.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Link.Location = New System.Drawing.Point(306, 214)
        Me.Login_Link.Name = "Login_Link"
        Me.Login_Link.Size = New System.Drawing.Size(113, 17)
        Me.Login_Link.TabIndex = 55
        Me.Login_Link.TabStop = True
        Me.Login_Link.Text = "Go to login page"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(187, 207)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 30)
        Me.Button6.TabIndex = 54
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'signupbtn
        '
        Me.signupbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signupbtn.Location = New System.Drawing.Point(68, 207)
        Me.signupbtn.Name = "signupbtn"
        Me.signupbtn.Size = New System.Drawing.Size(102, 30)
        Me.signupbtn.TabIndex = 53
        Me.signupbtn.Text = "Sign Up"
        Me.signupbtn.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(49, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 17)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Password"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(48, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 17)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "User ID"
        '
        'spwd
        '
        Me.spwd.Location = New System.Drawing.Point(200, 99)
        Me.spwd.Name = "spwd"
        Me.spwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.spwd.Size = New System.Drawing.Size(189, 22)
        Me.spwd.TabIndex = 51
        '
        'srpwd
        '
        Me.srpwd.Location = New System.Drawing.Point(202, 143)
        Me.srpwd.Name = "srpwd"
        Me.srpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.srpwd.Size = New System.Drawing.Size(187, 22)
        Me.srpwd.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(47, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 17)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Re-type Password"
        '
        'suid
        '
        Me.suid.Location = New System.Drawing.Point(199, 54)
        Me.suid.Name = "suid"
        Me.suid.Size = New System.Drawing.Size(189, 22)
        Me.suid.TabIndex = 50
        '
        'Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(471, 274)
        Me.Controls.Add(Me.Login_Link)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.signupbtn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.spwd)
        Me.Controls.Add(Me.srpwd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.suid)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Signup"
        Me.Text = "Signup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login_Link As System.Windows.Forms.LinkLabel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents signupbtn As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents spwd As System.Windows.Forms.TextBox
    Friend WithEvents srpwd As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents suid As System.Windows.Forms.TextBox
End Class
