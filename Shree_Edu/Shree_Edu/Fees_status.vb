Imports System.Data.Odbc

Public Class Fees_status
    Dim con As New OdbcConnection("DSN=SHREEDSN")

    Private Sub Session_Combo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Session_Combo.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Session_Combo.Items.Clear()
            cmd = New OdbcCommand("Select Distinct Year from student_Info", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Session_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Class_Combo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Class_Combo.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Class_Combo.Items.Clear()
            cmd = New OdbcCommand("select distinct Class_Name from Add_Subject", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Class_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()


    End Sub

    Private Sub Studid_Combo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Studid_Combo.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Studid_Combo.Items.Clear()
            cmd = New OdbcCommand("select Distinct Student_Id from assign_subject where Class_Detail='" + Class_Combo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Studid_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()


    End Sub

    Private Sub Subid_Combo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Subid_Combo.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            Subid_Combo.Items.Clear()
            cmd = New OdbcCommand("select Sub_Id from Assign_Subject where Student_Id='" + Studid_Combo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Subid_Combo.Items.Add(dr.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub


    Private Sub Subid_Combo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Subid_Combo.TextChanged
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select Fees from Add_Subject where Sub_Id='" + Subid_Combo.Text + "'", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                amount.Text = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub paid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paid.Click
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("insert into Fees_Status values('" + Session_Combo.Text + "','" + Class_Combo.Text + "','" + Studid_Combo.Text + "','" + Subid_Combo.Text + "','" + Month_Combo.Text + "','" + amount.Text + "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Fees Paid Successfully")
            Session_Combo.Text = ""
            Class_Combo.Text = ""
            Studid_Combo.Text = ""
            Subid_Combo.Text = ""
            Month_Combo.Text = "---- Select ----"
            amount.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

    End Sub


End Class