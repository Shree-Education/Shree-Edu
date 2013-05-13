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
        Me.Studid_Combo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.paid = New System.Windows.Forms.Button
        Me.back = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.checkddno = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.amountpaidbox = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.checkradio = New System.Windows.Forms.RadioButton
        Me.ddradio = New System.Windows.Forms.RadioButton
        Me.cashradio = New System.Windows.Forms.RadioButton
        Me.sessionLabel = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.feesAddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.feesDiscountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.totalamounttextbox = New System.Windows.Forms.TextBox
        Me.amounttobepaidtextbox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.amountpaidtextbox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.amountduetextbox = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.dateofpayment = New System.Windows.Forms.DateTimePicker
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
        'Studid_Combo
        '
        Me.Studid_Combo.FormattingEnabled = True
        Me.Studid_Combo.Location = New System.Drawing.Point(168, 132)
        Me.Studid_Combo.Margin = New System.Windows.Forms.Padding(4)
        Me.Studid_Combo.Name = "Studid_Combo"
        Me.Studid_Combo.Size = New System.Drawing.Size(197, 24)
        Me.Studid_Combo.TabIndex = 3
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
        Me.Label6.Location = New System.Drawing.Point(20, 186)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total Amount"
        '
        'paid
        '
        Me.paid.Location = New System.Drawing.Point(36, 542)
        Me.paid.Name = "paid"
        Me.paid.Size = New System.Drawing.Size(112, 31)
        Me.paid.TabIndex = 7
        Me.paid.Text = "Submit"
        Me.paid.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(189, 542)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(112, 31)
        Me.back.TabIndex = 8
        Me.back.Text = "Print"
        Me.back.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 400)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Mode of Payment"
        '
        'checkddno
        '
        Me.checkddno.Location = New System.Drawing.Point(168, 448)
        Me.checkddno.Name = "checkddno"
        Me.checkddno.Size = New System.Drawing.Size(197, 22)
        Me.checkddno.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 454)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 16)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Check / DD No."
        '
        'amountpaidbox
        '
        Me.amountpaidbox.Location = New System.Drawing.Point(171, 486)
        Me.amountpaidbox.Name = "amountpaidbox"
        Me.amountpaidbox.Size = New System.Drawing.Size(194, 22)
        Me.amountpaidbox.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 492)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Amount Paid"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.checkradio)
        Me.Panel2.Controls.Add(Me.ddradio)
        Me.Panel2.Controls.Add(Me.cashradio)
        Me.Panel2.Location = New System.Drawing.Point(155, 389)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 39)
        Me.Panel2.TabIndex = 32
        '
        'checkradio
        '
        Me.checkradio.AutoSize = True
        Me.checkradio.Location = New System.Drawing.Point(79, 8)
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
        Me.ddradio.Location = New System.Drawing.Point(155, 8)
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
        Me.cashradio.Location = New System.Drawing.Point(11, 8)
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
        Me.sessionLabel.Location = New System.Drawing.Point(165, 53)
        Me.sessionLabel.Name = "sessionLabel"
        Me.sessionLabel.Size = New System.Drawing.Size(0, 16)
        Me.sessionLabel.TabIndex = 33
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.feesAddToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(414, 24)
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
        Me.feesDiscountToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.feesDiscountToolStripMenuItem.Text = "Discount"
        '
        'totalamounttextbox
        '
        Me.totalamounttextbox.Location = New System.Drawing.Point(168, 177)
        Me.totalamounttextbox.Name = "totalamounttextbox"
        Me.totalamounttextbox.Size = New System.Drawing.Size(197, 22)
        Me.totalamounttextbox.TabIndex = 35
        '
        'amounttobepaidtextbox
        '
        Me.amounttobepaidtextbox.Location = New System.Drawing.Point(168, 221)
        Me.amounttobepaidtextbox.Name = "amounttobepaidtextbox"
        Me.amounttobepaidtextbox.Size = New System.Drawing.Size(197, 22)
        Me.amounttobepaidtextbox.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 224)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Amount to be Paid"
        '
        'amountpaidtextbox
        '
        Me.amountpaidtextbox.Location = New System.Drawing.Point(168, 266)
        Me.amountpaidtextbox.Name = "amountpaidtextbox"
        Me.amountpaidtextbox.Size = New System.Drawing.Size(197, 22)
        Me.amountpaidtextbox.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 269)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Amount Paid"
        '
        'amountduetextbox
        '
        Me.amountduetextbox.Location = New System.Drawing.Point(168, 308)
        Me.amountduetextbox.Name = "amountduetextbox"
        Me.amountduetextbox.Size = New System.Drawing.Size(197, 22)
        Me.amountduetextbox.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 311)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Amount Due"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 351)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 16)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Date of Payment"
        '
        'dateofpayment
        '
        Me.dateofpayment.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateofpayment.Location = New System.Drawing.Point(168, 351)
        Me.dateofpayment.Name = "dateofpayment"
        Me.dateofpayment.Size = New System.Drawing.Size(197, 22)
        Me.dateofpayment.TabIndex = 43
        '
        'Fees_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(414, 606)
        Me.Controls.Add(Me.dateofpayment)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.amountduetextbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.amountpaidtextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.amounttobepaidtextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totalamounttextbox)
        Me.Controls.Add(Me.sessionLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.amountpaidbox)
        Me.Controls.Add(Me.checkddno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.paid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Studid_Combo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Class_Combo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Fees_status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fees_status"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Class_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Studid_Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents paid As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents checkddno As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents amountpaidbox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents checkradio As System.Windows.Forms.RadioButton
    Friend WithEvents ddradio As System.Windows.Forms.RadioButton
    Friend WithEvents cashradio As System.Windows.Forms.RadioButton
    Friend WithEvents sessionLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents feesAddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents feesDiscountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents totalamounttextbox As System.Windows.Forms.TextBox
    Friend WithEvents amounttobepaidtextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents amountpaidtextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents amountduetextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dateofpayment As System.Windows.Forms.DateTimePicker
End Class
