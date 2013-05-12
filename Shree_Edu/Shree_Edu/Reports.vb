
Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Reports
    Dim con As New OdbcConnection("DSN=SHREEDSN")
    Private Sub viewReportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewReportButton.Click

        Try
            If yearComboBox.Text = "" And classcombobox.Text = "" And studentidcombobox.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Critical)
            End If
            Module1.mstudent_id = studentidcombobox.Text
            Individual_Report_Form.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Reports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        From_Date.Format = DateTimePickerFormat.Custom
        From_Date.CustomFormat = "yyyy/MM/dd"

        To_Date.Format = DateTimePickerFormat.Custom
        To_Date.CustomFormat = "yyyy/MM/dd"

        namelabel.Enabled = False
        
    End Sub

    Private Sub yearComboBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles yearComboBox.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            yearComboBox.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                yearComboBox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub yearComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yearComboBox.SelectedIndexChanged

    End Sub

    Private Sub Class_combobox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles classcombobox.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            classcombobox.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                classcombobox.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles classcombobox.SelectedIndexChanged

    End Sub

    Private Sub studentidcombobox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles studentidcombobox.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            studentidcombobox.Items.Clear()
            cmd = New OdbcCommand("select Student_Id from Student_Info where Class='" + classcombobox.Text + "' ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                studentidcombobox.Items.Add(dr.Item(0))
                'namelabel.Text = (dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub sid_combo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sid_combo.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Sid_Combo.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from assign_subject where Student_Id='" + studentidcombobox.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Sid_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub classwisebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles classwisebtn.Click
        Try
            If yearcombo.Text = "" And testid_combo.Text = "" And classcombo.Text = "" Then
                MsgBox("Fields can't be left blank", MsgBoxStyle.Critical)
            End If
            Module1.clas = classcombo.Text
            Module1.mtid = testid_combo.Text
            class_report.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub yearcombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles yearcombo.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            yearComboBox.Items.Clear()
            cmd = New OdbcCommand("select distinct year from student_info ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                yearcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub classcombo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles classcombo.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            classcombo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from add_subject", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                classcombo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub testid_combo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles testid_combo.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            testid_combo.Items.Clear()
            cmd = New OdbcCommand("select test_id from add_test where class='" + classcombo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                testid_combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub studentidcombobox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles studentidcombobox.SelectedValueChanged
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Name from Student_Info where Student_Id='" + studentidcombobox.Text + "' ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                namelabel.Text = (dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub
End Class