Public Class Select_Action


    Private Sub SR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Hide()
        Student_Reg.Show()
    End Sub


    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Student_Reg.Show()
    End Sub

    Private Sub srpic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles srpic.LinkClicked

        Student_Reg.Show()
    End Sub


    Private Sub acpic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles acpic.LinkClicked
        Add_Class.Show()
    End Sub

    Private Sub adepic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles adepic.LinkClicked
        Marks_Data_Entry.Show()
    End Sub

    Private Sub cppic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles cppic.LinkClicked
        Change_Pwd.Show()
    End Sub

    Private Sub atpic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles atpic.LinkClicked
        Add_Test.Show()
    End Sub

    Private Sub aspiv_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles aspiv.LinkClicked
        Assign_sub.Show()
    End Sub


    Private Sub sfspic_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles sfspic.LinkClicked
        Fees_status.Show()
    End Sub

    Private Sub email_link_label_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles email_link_label.LinkClicked
        emailtest.Show()
    End Sub

    Private Sub Select_Action_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'srtext.Enabled = False
    End Sub

    Private Sub srpic_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles srpic.MouseHover
        ' select_picturebox.Load(Application.StartupPath & ".Resources\reg.jpeg")
        ' select_picturebox.Image = Image.FromFile(Application.StartupPath & "\shree_edu\reg.jpeg")
        'Label1.Text = "This is student registration link, which let you to register new students or to update the information of previously registered students"
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Reports.Show()
    End Sub

    Private Sub UsersGuideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersGuideToolStripMenuItem.Click
        Process.Start("C:\Users\Nitesh\Desktop\latest project\Shree15\Shree_Edu\Shree Education User Guide.pdf")
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Fees_status.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Student_Reg.Show()
    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Add_Class.Show()
    End Sub

    Private Sub LinkLabel5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Add_Test.Show()
    End Sub

    Private Sub LinkLabel6_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Assign_sub.Show()
    End Sub

    Private Sub LinkLabel7_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Marks_Data_Entry.Show()
    End Sub

    Private Sub LinkLabel10_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        emailtest.Show()
    End Sub

    Private Sub LinkLabel9_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        Change_Pwd.Show()
    End Sub

    Private Sub LinkLabel8_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        Reports.Show()
    End Sub

    Private Sub StudentRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentRegistrationToolStripMenuItem.Click
        Student_Reg.Show()
    End Sub

    Private Sub AddTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddTestToolStripMenuItem.Click
        Add_Test.Show()
    End Sub

    Private Sub AddClassToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddClassToolStripMenuItem.Click
        Add_Class.Show()
    End Sub

    Private Sub AssignSubjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssignSubjectToolStripMenuItem.Click
        Assign_sub.Show()
    End Sub

    Private Sub MarksDataEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarksDataEntryToolStripMenuItem.Click
        Marks_Data_Entry.Show()
    End Sub

    Private Sub StudentFeesStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentFeesStatusToolStripMenuItem.Click
        Fees_status.Show()
    End Sub

    Private Sub EmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailToolStripMenuItem.Click
        emailtest.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Change_Pwd.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportsToolStripMenuItem.Click
        Reports.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        loginForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub
End Class