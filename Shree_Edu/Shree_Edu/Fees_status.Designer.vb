<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fees_status
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
        Me.Class_Combo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Session_Combo = New System.Windows.Forms.ComboBox
        Me.Month_Combo = New System.Windows.Forms.ComboBox
        Me.Subid_Combo = New System.Windows.Forms.ComboBox
        Me.Studid_Combo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.amount = New System.Windows.Forms.Label
        Me.paid = New System.Windows.Forms.Button
        Me.back = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Class_Combo
        '
        Me.Class_Combo.FormattingEnabled = True
        Me.Class_Combo.Location = New System.Drawing.Point(163, 89)
        Me.Class_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Class_Combo.Name = "Class_Combo"
        Me.Class_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Class_Combo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class"
        '
        'Session_Combo
        '
        Me.Session_Combo.FormattingEnabled = True
        Me.Session_Combo.Location = New System.Drawing.Point(163, 45)
        Me.Session_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Session_Combo.Name = "Session_Combo"
        Me.Session_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Session_Combo.TabIndex = 1
        '
        'Month_Combo
        '
        Me.Month_Combo.FormattingEnabled = True
        Me.Month_Combo.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.Month_Combo.Location = New System.Drawing.Point(163, 229)
        Me.Month_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Month_Combo.Name = "Month_Combo"
        Me.Month_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Month_Combo.TabIndex = 5
        '
        'Subid_Combo
        '
        Me.Subid_Combo.FormattingEnabled = True
        Me.Subid_Combo.Location = New System.Drawing.Point(163, 181)
        Me.Subid_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Subid_Combo.Name = "Subid_Combo"
        Me.Subid_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Subid_Combo.TabIndex = 4
        '
        'Studid_Combo
        '
        Me.Studid_Combo.FormattingEnabled = True
        Me.Studid_Combo.Location = New System.Drawing.Point(163, 132)
        Me.Studid_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Studid_Combo.Name = "Studid_Combo"
        Me.Studid_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Studid_Combo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 237)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 189)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Subject Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Student Id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Session"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 281)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Amount"
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(160, 281)
        Me.amount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(200, 16)
        Me.amount.TabIndex = 11
        '
        'paid
        '
        Me.paid.Location = New System.Drawing.Point(67, 344)
        Me.paid.Name = "paid"
        Me.paid.Size = New System.Drawing.Size(112, 31)
        Me.paid.TabIndex = 7
        Me.paid.Text = "Submit"
        Me.paid.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(220, 344)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(112, 31)
        Me.back.TabIndex = 8
        Me.back.Text = "Print"
        Me.back.UseVisualStyleBackColor = True
        '
        'Fees_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(417, 426)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.paid)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Studid_Combo)
        Me.Controls.Add(Me.Subid_Combo)
        Me.Controls.Add(Me.Month_Combo)
        Me.Controls.Add(Me.Session_Combo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Class_Combo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Fees_status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fees_status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Class_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Session_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Month_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Subid_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Studid_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents amount As System.Windows.Forms.Label
    Friend WithEvents paid As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
End Class
