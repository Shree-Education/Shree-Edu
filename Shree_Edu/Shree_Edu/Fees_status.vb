Imports System.Data.Odbc

Public Class Fees_status
    Dim con As New OdbcConnection("DSN=SHREEDSN")

    'Private Sub Session_Combo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        con.Open()
    '        Dim cmd As OdbcCommand
    '        Session_Combo.Items.Clear()
    '        cmd = New OdbcCommand("Select Distinct Year from student_Info", con)
    '        Dim dr As OdbcDataReader
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            Session_Combo.Items.Add(dr.Item(0))
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    '    con.Close()
    'End Sub

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

    'Private Sub Subid_Combo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        con.Open()
    '        Dim cmd As OdbcCommand
    '        Subid_Combo.Items.Clear()
    '        cmd = New OdbcCommand("select Sub_Id from Assign_Subject where Student_Id='" + Studid_Combo.Text + "'", con)
    '        Dim dr As OdbcDataReader
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            Subid_Combo.Items.Add(dr.Item(0))
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    '    con.Close()
    'End Sub


    'Private Sub Subid_Combo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        con.Open()
    '        Dim cmd As OdbcCommand
    '        cmd = New OdbcCommand("select Fees from Add_Subject where Sub_Id='" + Subid_Combo.Text + "'", con)
    '        Dim dr As OdbcDataReader
    '        dr = cmd.ExecuteReader
    '        While dr.Read
    '            amount.Text = dr(0)
    '        End While
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try
    '    con.Close()
    'End Sub

    Private Sub paid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paid.Click
        'Try
        '    con.Open()
        '    Dim cmd As OdbcCommand
        '    cmd = New OdbcCommand("insert into Fees_Status values('" + Session_Combo.Text + "','" + Class_Combo.Text + "','" + Studid_Combo.Text + "','" + Subid_Combo.Text + "','" + Month_Combo.Text + "','" + checkddno.Text + "','" + amount.Text + "')", con)
        '    cmd.ExecuteNonQuery()
        '    MsgBox("Fees Paid Successfully")
        '    Session_Combo.Text = ""
        '    Class_Combo.Text = ""
        '    Studid_Combo.Text = ""
        '    Subid_Combo.Text = ""
        '    Month_Combo.Text = ""
        '    amount.Text = ""
        '    percentbox.Clear()
        '    discountamountbox.Clear()
        '    perdiscountbox.Clear()
        '    checkddno.Clear()
        '    cashradio.Checked = True
        '    noradio.Checked = True
        '    amountpaidbox.Clear()
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
        'con.Close()

    End Sub



    Private Sub Fees_status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.Open()
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("Select Distinct Year from student_Info order by Year ASC", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                sessionLabel.Text = dr(0)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
        vamount = totalamounttextbox.Text
        vamounttobepaid = amounttobepaidtextbox.Text
    End Sub

    Private Sub cashradio_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cashradio.CheckedChanged
        If cashradio.Checked = True Then
            checkddno.Text = "Not Available"
        End If
    End Sub

    Private Sub checkradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkradio.CheckedChanged
        If checkradio.Checked = True Then
            checkddno.Clear()
        End If
    End Sub

    Private Sub ddradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddradio.CheckedChanged
        If ddradio.Checked = True Then
            checkddno.Clear()
        End If
    End Sub

   
    Private Sub feesDiscountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles feesDiscountToolStripMenuItem.Click
        Add_discount.Show()
    End Sub

End Class