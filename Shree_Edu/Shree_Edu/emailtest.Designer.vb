<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class emailtest
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
        Me.bodytextbox = New System.Windows.Forms.TextBox
        Me.usernametextbox = New System.Windows.Forms.TextBox
        Me.passwordtextbox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.sendbutton = New System.Windows.Forms.Button
        Me.Body = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.subjecttextbox = New System.Windows.Forms.TextBox
        Me.totextbox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.attachmenttextbox = New System.Windows.Forms.TextBox
        Me.browsebutton = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'bodytextbox
        '
        Me.bodytextbox.Location = New System.Drawing.Point(108, 131)
        Me.bodytextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.bodytextbox.Multiline = True
        Me.bodytextbox.Name = "bodytextbox"
        Me.bodytextbox.Size = New System.Drawing.Size(388, 193)
        Me.bodytextbox.TabIndex = 3
        '
        'usernametextbox
        '
        Me.usernametextbox.Location = New System.Drawing.Point(111, 383)
        Me.usernametextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.usernametextbox.Name = "usernametextbox"
        Me.usernametextbox.Size = New System.Drawing.Size(388, 22)
        Me.usernametextbox.TabIndex = 5
        '
        'passwordtextbox
        '
        Me.passwordtextbox.Location = New System.Drawing.Point(111, 422)
        Me.passwordtextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordtextbox.Name = "passwordtextbox"
        Me.passwordtextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtextbox.Size = New System.Drawing.Size(388, 22)
        Me.passwordtextbox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 384)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 420)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'sendbutton
        '
        Me.sendbutton.Location = New System.Drawing.Point(111, 461)
        Me.sendbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.sendbutton.Name = "sendbutton"
        Me.sendbutton.Size = New System.Drawing.Size(112, 28)
        Me.sendbutton.TabIndex = 7
        Me.sendbutton.Text = "Send"
        Me.sendbutton.UseVisualStyleBackColor = True
        '
        'Body
        '
        Me.Body.AutoSize = True
        Me.Body.Location = New System.Drawing.Point(16, 221)
        Me.Body.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Body.Name = "Body"
        Me.Body.Size = New System.Drawing.Size(44, 16)
        Me.Body.TabIndex = 6
        Me.Body.Text = "Body"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "To"
        '
        'subjecttextbox
        '
        Me.subjecttextbox.Location = New System.Drawing.Point(108, 89)
        Me.subjecttextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.subjecttextbox.Name = "subjecttextbox"
        Me.subjecttextbox.Size = New System.Drawing.Size(388, 22)
        Me.subjecttextbox.TabIndex = 2
        '
        'totextbox
        '
        Me.totextbox.Location = New System.Drawing.Point(108, 50)
        Me.totextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.totextbox.Name = "totextbox"
        Me.totextbox.Size = New System.Drawing.Size(388, 22)
        Me.totextbox.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 346)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Attachment"
        '
        'attachmenttextbox
        '
        Me.attachmenttextbox.Location = New System.Drawing.Point(108, 344)
        Me.attachmenttextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.attachmenttextbox.Name = "attachmenttextbox"
        Me.attachmenttextbox.Size = New System.Drawing.Size(244, 22)
        Me.attachmenttextbox.TabIndex = 12
        '
        'browsebutton
        '
        Me.browsebutton.Location = New System.Drawing.Point(357, 344)
        Me.browsebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.browsebutton.Name = "browsebutton"
        Me.browsebutton.Size = New System.Drawing.Size(120, 24)
        Me.browsebutton.TabIndex = 13
        Me.browsebutton.Text = "Browse"
        Me.browsebutton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Select Your File"
        Me.OpenFileDialog1.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*"
        Me.OpenFileDialog1.InitialDirectory = "C:\Users\Nitesh\Desktop"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(275, 461)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 14
        '
        'emailtest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(514, 493)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.browsebutton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.attachmenttextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.subjecttextbox)
        Me.Controls.Add(Me.totextbox)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.sendbutton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passwordtextbox)
        Me.Controls.Add(Me.usernametextbox)
        Me.Controls.Add(Me.bodytextbox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "emailtest"
        Me.Text = "emailtest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bodytextbox As System.Windows.Forms.TextBox
    Friend WithEvents usernametextbox As System.Windows.Forms.TextBox
    Friend WithEvents passwordtextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents sendbutton As System.Windows.Forms.Button
    Friend WithEvents Body As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents subjecttextbox As System.Windows.Forms.TextBox
    Friend WithEvents totextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents attachmenttextbox As System.Windows.Forms.TextBox
    Friend WithEvents browsebutton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
