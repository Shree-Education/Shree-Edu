<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_discount
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
        Me.discountpanel = New System.Windows.Forms.Panel
        Me.Percentlabel = New System.Windows.Forms.Label
        Me.percentbox = New System.Windows.Forms.TextBox
        Me.peramountlabel = New System.Windows.Forms.Label
        Me.perdiscountbox = New System.Windows.Forms.TextBox
        Me.disamtlabel = New System.Windows.Forms.Label
        Me.percentageradio = New System.Windows.Forms.RadioButton
        Me.Rupeesradio = New System.Windows.Forms.RadioButton
        Me.discountamountbox = New System.Windows.Forms.TextBox
        Me.discountpanel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.discountpanel.Location = New System.Drawing.Point(13, 35)
        Me.discountpanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.discountpanel.Name = "discountpanel"
        Me.discountpanel.Size = New System.Drawing.Size(362, 156)
        Me.discountpanel.TabIndex = 22
        '
        'Percentlabel
        '
        Me.Percentlabel.AutoSize = True
        Me.Percentlabel.Location = New System.Drawing.Point(21, 66)
        Me.Percentlabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Percentlabel.Name = "Percentlabel"
        Me.Percentlabel.Size = New System.Drawing.Size(61, 16)
        Me.Percentlabel.TabIndex = 29
        Me.Percentlabel.Text = "Percent"
        '
        'percentbox
        '
        Me.percentbox.Location = New System.Drawing.Point(122, 62)
        Me.percentbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.percentbox.Name = "percentbox"
        Me.percentbox.Size = New System.Drawing.Size(226, 22)
        Me.percentbox.TabIndex = 28
        '
        'peramountlabel
        '
        Me.peramountlabel.AutoSize = True
        Me.peramountlabel.Location = New System.Drawing.Point(22, 107)
        Me.peramountlabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.peramountlabel.Name = "peramountlabel"
        Me.peramountlabel.Size = New System.Drawing.Size(59, 16)
        Me.peramountlabel.TabIndex = 27
        Me.peramountlabel.Text = "Amount"
        '
        'perdiscountbox
        '
        Me.perdiscountbox.Location = New System.Drawing.Point(123, 102)
        Me.perdiscountbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.perdiscountbox.Name = "perdiscountbox"
        Me.perdiscountbox.Size = New System.Drawing.Size(226, 22)
        Me.perdiscountbox.TabIndex = 26
        '
        'disamtlabel
        '
        Me.disamtlabel.AutoSize = True
        Me.disamtlabel.Location = New System.Drawing.Point(24, 86)
        Me.disamtlabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.disamtlabel.Name = "disamtlabel"
        Me.disamtlabel.Size = New System.Drawing.Size(59, 16)
        Me.disamtlabel.TabIndex = 25
        Me.disamtlabel.Text = "Amount"
        '
        'percentageradio
        '
        Me.percentageradio.AutoSize = True
        Me.percentageradio.Location = New System.Drawing.Point(170, 23)
        Me.percentageradio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.Rupeesradio.Location = New System.Drawing.Point(38, 25)
        Me.Rupeesradio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rupeesradio.Name = "Rupeesradio"
        Me.Rupeesradio.Size = New System.Drawing.Size(80, 20)
        Me.Rupeesradio.TabIndex = 23
        Me.Rupeesradio.TabStop = True
        Me.Rupeesradio.Text = "Rupees"
        Me.Rupeesradio.UseVisualStyleBackColor = True
        '
        'discountamountbox
        '
        Me.discountamountbox.Location = New System.Drawing.Point(123, 81)
        Me.discountamountbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.discountamountbox.Name = "discountamountbox"
        Me.discountamountbox.Size = New System.Drawing.Size(226, 22)
        Me.discountamountbox.TabIndex = 22
        '
        'Add_discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 217)
        Me.Controls.Add(Me.discountpanel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Add_discount"
        Me.Text = "Add_discount"
        Me.discountpanel.ResumeLayout(False)
        Me.discountpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents discountpanel As System.Windows.Forms.Panel
    Friend WithEvents Percentlabel As System.Windows.Forms.Label
    Friend WithEvents percentbox As System.Windows.Forms.TextBox
    Friend WithEvents peramountlabel As System.Windows.Forms.Label
    Friend WithEvents perdiscountbox As System.Windows.Forms.TextBox
    Friend WithEvents disamtlabel As System.Windows.Forms.Label
    Friend WithEvents percentageradio As System.Windows.Forms.RadioButton
    Friend WithEvents Rupeesradio As System.Windows.Forms.RadioButton
    Friend WithEvents discountamountbox As System.Windows.Forms.TextBox
End Class
