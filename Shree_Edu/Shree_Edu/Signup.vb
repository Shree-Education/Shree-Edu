Imports System.Data.Odbc
Public Class Signup
    Dim con As New OdbcConnection("DSN=EVENTMANAGEMENTDSN")
    Private Sub Signup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub signupbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signupbtn.Click
        Try
            con.Open()
            Dim cmd1, cmd2 As OdbcCommand
            Dim s_uid, s_pass, sr_pass As String
            s_uid = suid.Text
            s_pass = spwd.Text
            sr_pass = srpwd.Text
            If s_pass = sr_pass Then
                MsgBox("password match")
                cmd1 = New OdbcCommand("select * from signup where Username='" + s_uid + "'", con)
                If (cmd1.ExecuteNonQuery = 1) Then
                    MsgBox("User Already exists, Please login to access")
                Else
                    cmd2 = New OdbcCommand("insert into signup values('" + s_uid + "','" + s_pass + "')", con)
                    cmd2.ExecuteNonQuery()

                    MsgBox("signup successful, Please login now")
                    suid.Clear()
                    spwd.Clear()
                    srpwd.Clear()
                End If
            Else
                MsgBox("Password not matching")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Login_Link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Login_Link.LinkClicked
        Me.Hide()
        loginForm.Show()
    End Sub
End Class