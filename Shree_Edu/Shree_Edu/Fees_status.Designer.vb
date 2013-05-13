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
        Me.Month_Combo = New System.Windows.Forms.ComboBox
        Me.Studid_Combo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.amount = New System.Windows.Forms.Label
        Me.paid = New System.Windows.Forms.Button
        Me.back = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.checkddno = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.noradio = New System.Windows.Forms.RadioButton
        Me.yesradio = New System.Windows.Forms.RadioButton
        Me.discountpanel = New System.Windows.Forms.Panel
        Me.Percentlabel = New System.Windows.Forms.Label
        Me.percentbox = New System.Windows.Forms.TextBox
        Me.peramountlabel = New System.Windows.Forms.Label
        Me.perdiscountbox = New System.Windows.Forms.TextBox
        Me.disamtlabel = New System.Windows.Forms.Label
        Me.percentageradio = New System.Windows.Forms.RadioButton
        Me.Rupeesradio = New System.Windows.Forms.RadioButton
        Me.discountamountbox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.amountpaidbox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.checkradio = New System.Windows.Forms.RadioButton
        Me.ddradio = New System.Windows.Forms.RadioButton
        Me.cashradio = New System.Windows.Forms.RadioButton
        Me.sessionLabel = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.feesAddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.feesDiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.discountpanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Class_Combo
        '
        Me.Class_Combo.FormattingEnabled = True
        Me.Class_Combo.Location = New System.Drawing.Point(168, 89)
        Me.Class_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Class_Combo.Name = "Class_Combo"
        Me.Class_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Class_Combo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Class"
        '
        'Month_Combo
        '
        Me.Month_Combo.FormattingEnabled = True
        Me.Month_Combo.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.Month_Combo.Location = New System.Drawing.Point(168, 229)
        Me.Month_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Month_Combo.Name = "Month_Combo"
        Me.Month_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Month_Combo.TabIndex = 5
        '
        'Studid_Combo
        '
        Me.Studid_Combo.FormattingEnabled = True
        Me.Studid_Combo.Location = New System.Drawing.Point(168, 132)
        Me.Studid_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Studid_Combo.Name = "Studid_Combo"
        Me.Studid_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Studid_Combo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 237)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Student Id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 53)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Session"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 281)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Amount"
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(165, 281)
        Me.amount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(107, 16)
        Me.amount.TabIndex = 11
        '
        'paid
        '
        Me.paid.Location = New System.Drawing.Point(42, 572)
        Me.paid.Name = "paid"
        Me.paid.Size = New System.Drawing.Size(112, 31)
        Me.paid.TabIndex = 7
        Me.paid.Text = "Submit"
        Me.paid.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(198, 572)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(112, 31)
        Me.back.TabIndex = 8
        Me.back.Text = "Print"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 440)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Mode of Payment"
        '
        'checkddno
        '
        Me.checkddno.Location = New System.Drawing.Point(168, 486)
        Me.checkddno.Name = "checkddno"
        Me.checkddno.Size = New System.Drawing.Size(197, 22)
        Me.checkddno.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 342)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Discount"
        '
        'noradio
        '
        Me.noradio.AutoSize = True
        Me.noradio.Location = New System.Drawing.Point(16, 55)
        Me.noradio.Name = "noradio"
        Me.noradio.Size = New System.Drawing.Size(46, 20)
        Me.noradio.TabIndex = 20
        Me.noradio.TabStop = True
        Me.noradio.Text = "No"
        Me.noradio.UseVisualStyleBackColor = True
        '
        'yesradio
        '
        Me.yesradio.AutoSize = True
        Me.yesradio.Location = New System.Drawing.Point(16, 21)
        Me.yesradio.Name = "yesradio"
        Me.yesradio.Size = New System.Drawing.Size(53, 20)
        Me.yesradio.TabIndex = 19
        Me.yesradio.TabStop = True
        Me.yesradio.Text = "Yes"
        Me.yesradio.UseVisualStyleBackColor = True
        '
        'discountpanel
        '
        Me.discountpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.discountpanel.Controls.Add(Me.Percentlabel)
        Me.discountpanel.Controls.Add(Me.percentbox)
        Me.discountpanel.Controls.Add(Me.peramountlabel)
        Me.discountpanel.Controls.Add(Me.perdiscountbox)
        Me.discountpanel.Controls.Add(Me.disamtlabel)
        Me.discountpanel.Controls.Add(Me.percentageradio)
        Me.discountpanel.Controls.Add(Me.Rupeesradio)
        Me.discountpanel.Controls.Add(Me.discountamountbox)
        Me.discountpanel.Location = New System.Drawing.Point(265, 298)
        Me.discountpanel.Name = "discountpanel"
        Me.discountpanel.Size = New System.Drawing.Size(243, 119)
        Me.discountpanel.TabIndex = 21
        '
        'Percentlabel
        '
        Me.Percentlabel.AutoSize = True
        Me.Percentlabel.Location = New System.Drawing.Point(14, 54)
        Me.Percentlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Percentlabel.Name = "Percentlabel"
        Me.Percentlabel.Size = New System.Drawing.Size(61, 16)
        Me.Percentlabel.TabIndex = 29
        Me.Percentlabel.Text = "Percent"
        '
        'percentbox
        '
        Me.percentbox.Location = New System.Drawing.Point(81, 50)
        Me.percentbox.Name = "percentbox"
        Me.percentbox.Size = New System.Drawing.Size(152, 22)
        Me.percentbox.TabIndex = 28
        '
        'peramountlabel
        '
        Me.peramountlabel.AutoSize = True
        Me.peramountlabel.Location = New System.Drawing.Point(15, 87)
        Me.peramountlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.peramountlabel.Name = "peramountlabel"
        Me.peramountlabel.Size = New System.Drawing.Size(59, 16)
        Me.peramountlabel.TabIndex = 27
        Me.peramountlabel.Text = "Amount"
        '
        'perdiscountbox
        '
        Me.perdiscountbox.Location = New System.Drawing.Point(82, 83)
        Me.perdiscountbox.Name = "perdiscountbox"
        Me.perdiscountbox.Size = New System.Drawing.Size(152, 22)
        Me.perdiscountbox.TabIndex = 26
        '
        'disamtlabel
        '
        Me.disamtlabel.AutoSize = True
        Me.disamtlabel.Location = New System.Drawing.Point(16, 70)
        Me.disamtlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.disamtlabel.Name = "disamtlabel"
        Me.disamtlabel.Size = New System.Drawing.Size(59, 16)
        Me.disamtlabel.TabIndex = 25
        Me.disamtlabel.Text = "Amount"
        '
        'percentageradio
        '
        Me.percentageradio.AutoSize = True
        Me.percentageradio.Location = New System.Drawing.Point(113, 19)
        Me.percentageradio.Name = "percentageradio"
        Me.percentageradio.Size = New System.Drawing.Size(106, 20)
        Me.percentageradio.TabIndex = 24
        Me.percentageradio.TabStop = True
        Me.percentageradio.Text = "Percentage"
        Me.percentageradio.UseVisualStyleBackColor = True
        '
        'Rupeesradio
        '
        Me.Rupeesradio.AutoSize = True
        Me.Rupeesradio.Location = New System.Drawing.Point(25, 20)
        Me.Rupeesradio.Name = "Rupeesradio"
        Me.Rupeesradio.Size = New System.Drawing.Size(80, 20)
        Me.Rupeesradio.TabIndex = 23
        Me.Rupeesradio.TabStop = True
        Me.Rupeesradio.Text = "Rupees"
        Me.Rupeesradio.UseVisualStyleBackColor = True
        '
        'discountamountbox
        '
        Me.discountamountbox.Location = New System.Drawing.Point(82, 66)
        Me.discountamountbox.Name = "discountamountbox"
        Me.discountamountbox.Size = New System.Drawing.Size(152, 22)
        Me.discountamountbox.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 492)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 16)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Check / DD No."
        '
        'amountpaidbox
        '
        Me.amountpaidbox.Location = New System.Drawing.Point(171, 524)
        Me.amountpaidbox.Name = "amountpaidbox"
        Me.amountpaidbox.Size = New System.Drawing.Size(194, 22)
        Me.amountpaidbox.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 530)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Amount Paid"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.yesradio)
        Me.Panel1.Controls.Add(Me.noradio)
        Me.Panel1.Location = New System.Drawing.Point(171, 311)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(86, 93)
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.checkradio)
        Me.Panel2.Controls.Add(Me.ddradio)
        Me.Panel2.Controls.Add(Me.cashradio)
        Me.Panel2.Location = New System.Drawing.Point(172, 432)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 39)
        Me.Panel2.TabIndex = 32
        '
        'checkradio
        '
        Me.checkradio.AutoSize = True
        Me.checkradio.Location = New System.Drawing.Point(96, 8)
        Me.checkradio.Name = "checkradio"
        Me.checkradio.Size = New System.Drawing.Size(69, 20)
        Me.checkradio.TabIndex = 18
        Me.checkradio.TabStop = True
        Me.checkradio.Text = "Check"
        Me.checkradio.UseVisualStyleBackColor = True
        '
        'ddradio
        '
        Me.ddradio.AutoSize = True
        Me.ddradio.Location = New System.Drawing.Point(181, 8)
        Me.ddradio.Name = "ddradio"
        Me.ddradio.Size = New System.Drawing.Size(48, 20)
        Me.ddradio.TabIndex = 17
        Me.ddradio.TabStop = True
        Me.ddradio.Text = "DD"
        Me.ddradio.UseVisualStyleBackColor = True
        '
        'cashradio
        '
        Me.cashradio.AutoSize = True
        Me.cashradio.Location = New System.Drawing.Point(15, 8)
        Me.cashradio.Name = "cashradio"
        Me.cashradio.Size = New System.Drawing.Size(61, 20)
        Me.cashradio.TabIndex = 16
        Me.cashradio.TabStop = True
        Me.cashradio.Text = "Cash"
        Me.cashradio.UseVisualStyleBackColor = True
        '
        'sessionLabel
        '
        Me.sessionLabel.AutoSize = True
        Me.sessionLabel.Location = New System.Drawing.Point(109, 53)
        Me.sessionLabel.Name = "sessionLabel"
        Me.sessionLabel.Size = New System.Drawing.Size(485, 16)
        Me.sessionLabel.TabIndex = 33
        Me.sessionLabel.Text = "Session Shold be displayed automatically from DB , jo current hai abi"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.feesAddToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(536, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'feesAddToolStripMenuItem
        '
        Me.feesAddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.feesDiscountToolStripMenuItem})
        Me.feesAddToolStripMenuItem.Name = "feesAddToolStripMenuItem"
        Me.feesAddToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.feesAddToolStripMenuItem.Text = "Add"
        '
        'feesDiscountToolStripMenuItem
        '
        Me.feesDiscountToolStripMenuItem.Name = "feesDiscountToolStripMenuItem"
        Me.feesDiscountToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.feesDiscountToolStripMenuItem.Text = "Discount"
        '
        'Fees_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(536, 617)
        Me.Controls.Add(Me.sessionLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.amountpaidbox)
        Me.Controls.Add(Me.discountpanel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.checkddno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.paid)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Studid_Combo)
        Me.Controls.Add(Me.Month_Combo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Class_Combo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Fees_status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fees_status"
        Me.discountpanel.ResumeLayout(False)
        Me.discountpanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Class_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Month_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Studid_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents amount As System.Windows.Forms.Label
    Friend WithEvents paid As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents checkddno As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents noradio As System.Windows.Forms.RadioButton
    Friend WithEvents yesradio As System.Windows.Forms.RadioButton
    Friend WithEvents discountpanel As System.Windows.Forms.Panel
    Friend WithEvents percentageradio As System.Windows.Forms.RadioButton
    Friend WithEvents Rupeesradio As System.Windows.Forms.RadioButton
    Friend WithEvents discountamountbox As System.Windows.Forms.TextBox
    Friend WithEvents disamtlabel As System.Windows.Forms.Label
    Friend WithEvents peramountlabel As System.Windows.Forms.Label
    Friend WithEvents perdiscountbox As System.Windows.Forms.TextBox
    Friend WithEvents Percentlabel As System.Windows.Forms.Label
    Friend WithEvents percentbox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents amountpaidbox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents checkradio As System.Windows.Forms.RadioButton
    Friend WithEvents ddradio As System.Windows.Forms.RadioButton
    Friend WithEvents cashradio As System.Windows.Forms.RadioButton
    Friend WithEvents sessionLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents feesAddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents feesDiscountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
