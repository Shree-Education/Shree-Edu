Imports System.Net.Mail
Public Class emailtest

    Private Sub sendbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sendbutton.Click
        Try
            Dim mail, atchmail As New MailMessage
            mail.Subject = subjecttextbox.Text
            mail.To.Add(totextbox.Text)
            mail.From = New MailAddress(usernametextbox.Text)
            mail.Body = bodytextbox.Text
            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment(attachmenttextbox.Text)
            mail.Attachments.Add(attachment)
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential(usernametextbox.Text, passwordtextbox.Text)
            smtp.Port = "587"
            smtp.Send(mail)

            
            MsgBox("Message Send Successfully", MsgBoxStyle.Information)
            totextbox.Clear()
            subjecttextbox.Clear()
            bodytextbox.Clear()
            attachmenttextbox.Clear()
            usernametextbox.Clear()
            passwordtextbox.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        

    End Sub

    Private Sub browsebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browsebutton.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        attachmenttextbox.Text = OpenFileDialog1.FileName
    End Sub
End Class