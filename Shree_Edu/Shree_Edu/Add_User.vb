Imports ShreeEducation.connection
Imports System.Data.Odbc


Public Class Add_User

    Private Sub Add_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        


        resetFields() ' function call to reset fields
        Try
            con.Open()

            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select S_Question from security_question_table ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader

            While dr.Read
                securityQuestionComboBox.Items.Add(dr.Item(0))
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try
        


    End Sub

    Private Sub resetNewPasswordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addUserButton.Click
        Dim userName = newUserNameTextBox.Text
        Dim password = newPasswordTextBox.Text
        Dim securityQuestion = securityQuestionComboBox.Text
        Dim answer = answerTextBox.Text


        Try
            'MsgBox(con.State)

            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        Dim cmd, cmd1 As OdbcCommand
        cmd = New OdbcCommand("insert into login values('" + userName + "','" + password + "','" + securityQuestion + "','" + answer + "')", con)
        cmd1 = New OdbcCommand("select User_Id from login where User_Id = '" + userName + "'", con)

        Try
            If newUserNameTextBox.Text = "" Or newPasswordTextBox.Text = "" Or answerTextBox.Text = "" Then
                MsgBox("Some Fields are blank")
            ElseIf cmd1.ExecuteNonQuery > 0 Then
                MsgBox("User already exist. Select a different user ")
                resetFields() ' function call to reset fields
                

            ElseIf newUserNameTextBox.Text <> "" And newPasswordTextBox.Text <> "" And securityQuestionComboBox.SelectedIndex >= 0 And answerTextBox.Text <> "" Then

                Dim msgResult = MsgBox("Are you sure you want to add " + userName + " to user Name List ?", MsgBoxStyle.YesNo)

                If msgResult = MsgBoxResult.Yes Then
                    cmd.ExecuteNonQuery()
                    MsgBox("User " + userName + " added successfully ")
                    con.Close()
                    Me.Hide()
                    loginForm.Show()
                Else
                    newUserNameTextBox.Focus()
                End If

                con.Close()
            Else
                MsgBox("Please select the security question ")

            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


    End Sub
    Private Sub resetFields()
        newUserNameTextBox.Clear()
        newPasswordTextBox.Clear()
        answerTextBox.Clear()
        newUserNameTextBox.Focus()
        securityQuestionComboBox.Text = "Select the security question"
    End Sub
End Class