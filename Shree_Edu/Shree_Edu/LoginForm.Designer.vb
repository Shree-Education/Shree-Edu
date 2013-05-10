<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.logintxt = New System.Windows.Forms.TextBox
        Me.password = New System.Windows.Forms.TextBox
        Me.Login = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.masterLinkLabel = New System.Windows.Forms.LinkLabel
        Me.forgotPasswordLinkLabel = New System.Windows.Forms.LinkLabel
        Me.cancel = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logintxt
        '
        Me.logintxt.AcceptsTab = True
        Me.logintxt.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.logintxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logintxt.Location = New System.Drawing.Point(187, 80)
        Me.logintxt.Name = "logintxt"
        Me.logintxt.Size = New System.Drawing.Size(140, 26)
        Me.logintxt.TabIndex = 2
        Me.logintxt.Text = "USERNAME"
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(187, 131)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(140, 26)
        Me.password.TabIndex = 3
        Me.password.Text = "PASSWORD"
        '
        'Login
        '
        Me.Login.AccessibleDescription = ""
        Me.Login.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Login.Location = New System.Drawing.Point(104, 181)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(96, 33)
        Me.Login.TabIndex = 45
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.ForeColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(434, 60)
        Me.Panel1.TabIndex = 47
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(3, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(72, 183)
        Me.Panel3.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(86, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(284, 31)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "SHREE EDUCATION "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.masterLinkLabel)
        Me.Panel2.Controls.Add(Me.forgotPasswordLinkLabel)
        Me.Panel2.Location = New System.Drawing.Point(0, 220)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(431, 40)
        Me.Panel2.TabIndex = 48
        '
        'masterLinkLabel
        '
        Me.masterLinkLabel.AutoSize = True
        Me.masterLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.masterLinkLabel.Location = New System.Drawing.Point(5, 13)
        Me.masterLinkLabel.Name = "masterLinkLabel"
        Me.masterLinkLabel.Size = New System.Drawing.Size(39, 13)
        Me.masterLinkLabel.TabIndex = 1
        Me.masterLinkLabel.TabStop = True
        Me.masterLinkLabel.Text = "Master"
        '
        'forgotPasswordLinkLabel
        '
        Me.forgotPasswordLinkLabel.AutoSize = True
        Me.forgotPasswordLinkLabel.DisabledLinkColor = System.Drawing.Color.Black
        Me.forgotPasswordLinkLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.forgotPasswordLinkLabel.LinkColor = System.Drawing.Color.Black
        Me.forgotPasswordLinkLabel.Location = New System.Drawing.Point(317, 13)
        Me.forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel"
        Me.forgotPasswordLinkLabel.Size = New System.Drawing.Size(94, 13)
        Me.forgotPasswordLinkLabel.TabIndex = 0
        Me.forgotPasswordLinkLabel.TabStop = True
        Me.forgotPasswordLinkLabel.Text = "Forgot password ?"
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cancel.Location = New System.Drawing.Point(231, 181)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(96, 33)
        Me.cancel.TabIndex = 46
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(125, 121)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 50
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(125, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'loginForm
        '
        Me.AcceptButton = Me.Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(423, 255)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.logintxt)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(439, 293)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Page"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents logintxt As System.Windows.Forms.TextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents Login As System.Windows.Forms.Button
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents forgotPasswordLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents masterLinkLabel As System.Windows.Forms.LinkLabel
End Class
