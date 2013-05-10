Imports System.Data.Odbc
Public Class Marks_Data_Entry

    Dim con As New OdbcConnection("DSN=SHREEDSN")
    Dim var As Integer

    Private Sub Marks_Data_Entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        present.Checked = True
        DOT.Enabled = True
        Class_Name.Enabled = True
        TestId.Enabled = True
        Stud_Id.Enabled = False
        present.Enabled = False
        absent.Enabled = False
        Marks_Obt.Enabled = False
        save.Enabled = False
        Finish.Enabled = False
        DOT.Format = DateTimePickerFormat.Custom
        DOT.CustomFormat = "yyyy/MM/dd"
        Try
            con.Open()
            Dim cmd As New OdbcCommand

            Dim ds As New DataSet
            cmd = New OdbcCommand("Select Student_Id,Name from Student_Info ", con)
            Dim adp As New OdbcDataAdapter(cmd)
            'adp = New OdbcDataAdapter(cmd)
            adp.Fill(ds, "Student_Info")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Student_Info"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        con.Close()


    End Sub

    Private Sub Class_Name_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Class_Name.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Class_Name.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject order by Class_Name", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Class_Name.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

        Try
            con.Open()
            Dim cmd2 As OdbcCommand
            cmd2 = New OdbcCommand("select Max_Marks from Add_Test where Test_Id='" + TestId.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd2.ExecuteReader
            While dr.Read
                maxmarks.Text = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Stud_Id_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Stud_Id.Items.Clear()
            cmd = New OdbcCommand("select distinct student_id from assign_subject where Class_Detail='" + Class_Name.Text + "' order by Sub_Id ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Stud_Id.Items.Add(dr.Item(0))
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub test_Id_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TestId.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            TestId.Items.Clear()
            cmd = New OdbcCommand("select Test_Id from Add_Test where Class='" + Class_Name.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                TestId.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub


    Private Sub Start_Entry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start_Entry.Click
        If DOT.Text = "" Or Class_Name.Text = "" Or TestId.Text = "" Then
            MsgBox("Fields can't left blank", MsgBoxStyle.Critical)
        Else
            DOT.Enabled = False
            Class_Name.Enabled = False
            TestId.Enabled = False
            Stud_Id.Enabled = True
            present.Enabled = True
            absent.Enabled = True
            Marks_Obt.Enabled = True
            save.Enabled = True
            Finish.Enabled = True
            ' Marks_Obt.Enabled = False
        End If
    End Sub


    Private Sub save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Stud_Id.Text = "" Then
            MsgBox("Fields can't left blank", MsgBoxStyle.Critical)
        Else
            If Val(maxmarks.Text) < Val(Marks_Obt.Text) Or Marks_Obt.Text < 0 Then
                MsgBox("Please Enter Correct marks", MsgBoxStyle.Critical)
            Else
                Try
                    con.Open()
                    Dim count As Integer
                    count = Stud_Id.Items.Count
                    MsgBox(count)
                    Dim cmd As OdbcCommand
                    Dim dtest, cname, tid, sid, mobt As String
                    dtest = DOT.Text
                    cname = Class_Name.Text
                    tid = TestId.Text
                    sid = Stud_Id.Text
                    If present.Checked = True Then
                        Marks_Obt.Enabled = True
                        mobt = Marks_Obt.Text
                    Else
                        mobt = "Absent"
                    End If
                    cmd = New OdbcCommand("insert into marks_status (student_id, Class, Test_Id, DOT, Marks_Obt) values('" + sid + "','" + cname + "','" + tid + "','" + dtest + "','" + mobt + "') ", con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Information is saved", MsgBoxStyle.Information)
                    Marks_Obt.Clear()
                    Stud_Id.SelectedIndex.ToString()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                    MsgBox("You have already entered the marks of this student", MsgBoxStyle.Critical)
                End Try
                con.Close()
            End If
        End If
    End Sub


    Private Sub Finish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Finish.Click
        DOT.Enabled = True
        Class_Name.Enabled = True
        TestId.Enabled = True
        Stud_Id.Enabled = False
        present.Enabled = False
        absent.Enabled = False
        Marks_Obt.Enabled = False
        save.Enabled = False
        Finish.Enabled = False
    End Sub


    Private Sub present_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles present.Click
        Marks_Obt.Enabled = True
    End Sub


    Private Sub absent_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles absent.Click
        Marks_Obt.Enabled = False
    End Sub

    Private Sub Stud_Id_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Stud_Id.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Stud_Id.Items.Clear()
            cmd = New OdbcCommand("select distinct student_id from assign_subject where Class_Detail='" + Class_Name.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Stud_Id.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub Stud_Id_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Stud_Id.TextChanged
        Try
            con.Open()
            Dim cmd1 As OdbcCommand
            cmd1 = New OdbcCommand("select Name from Student_Info where Student_Id='" + Stud_Id.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd1.ExecuteReader
            While dr.Read
                sname.Text = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub TestId_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TestId.TextChanged
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Max_Marks from Add_Test where Test_Id='" + TestId.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                maxmarks.Text = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub Class_Name_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Class_Name.TextChanged
        Try
            con.Open()
            Dim cmd As New OdbcCommand

            Dim ds As New DataSet
            cmd = New OdbcCommand("Select Student_Id,Name from Student_Info where Class='" + Class_Name.Text + "'  ", con)
            Dim adp As New OdbcDataAdapter(cmd)
            'adp = New OdbcDataAdapter(cmd)
            adp.Fill(ds, "Student_Info")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Student_Info"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        con.Close()
    End Sub

    Private Sub Marks_Obt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Marks_Obt.KeyPress
        If Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MsgBox("Please enters numbers only", MsgBoxStyle.Critical)
            e.Handled = True
        End If
    End Sub

    Private Sub Class_Name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Class_Name.SelectedIndexChanged

    End Sub
End Class