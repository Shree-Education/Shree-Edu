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
            cmd = New OdbcCommand("insert into Fees_Status values('" + Session_Combo.Text + "','" + Class_Combo.Text + "','" + Studid_Combo.Text + "','" + Subid_Combo.Text + "','" + Month_Combo.Text + "','" + checkddno.Text + "','" + amount.Text + "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Fees Paid Successfully")
            Session_Combo.Text = ""
            Class_Combo.Text = ""
            Studid_Combo.Text = ""
            Subid_Combo.Text = ""
            Month_Combo.Text = ""
            amount.Text = ""
            percentbox.Clear()
            discountamountbox.Clear()
            perdiscountbox.Clear()
            checkddno.Clear()
            cashradio.Checked = True
            noradio.Checked = True
            amountpaidbox.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

    End Sub


    Private Sub yesradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yesradio.CheckedChanged
        If yesradio.Checked = True Then
            discountpanel.Visible = True
        End If
    End Sub

    Private Sub Fees_status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        amountpaidbox.Enabled = False
        discountpanel.Visible = False
        disamtlabel.Visible = False
        discountamountbox.Visible = False
        percentbox.Visible = False
        Percentlabel.Visible = False
        perdiscountbox.Visible = False
        peramountlabel.Visible = False
        amount.Enabled = False
    End Sub

    Private Sub noradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noradio.CheckedChanged
        If noradio.Checked = True Then
            discountpanel.Visible = False
            amountpaidbox.Text = amount.Text
        End If

    End Sub

    Private Sub Rupeesradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rupeesradio.CheckedChanged
        If Rupeesradio.Checked = True Then
            percentbox.Visible = False
            Percentlabel.Visible = False
            disamtlabel.Visible = True
            discountamountbox.Visible = True
            perdiscountbox.Visible = False
            peramountlabel.Visible = False
            percentbox.Clear()
            perdiscountbox.Clear()
        End If
    End Sub

    Private Sub percentageradio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percentageradio.CheckedChanged
        If percentageradio.Checked = True Then
            disamtlabel.Visible = False
            discountamountbox.Visible = False
            percentbox.Visible = True
            perdiscountbox.Visible = True
            peramountlabel.Visible = True
            Percentlabel.Visible = True
            discountamountbox.Clear()
            perdiscountbox.Enabled = False
        End If
    End Sub


    Private Sub percentbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percentbox.TextChanged
        Try
            If percentbox.Text > 100 Then
                MsgBox("Enter correct value", MsgBoxStyle.Critical)
            Else
                perdiscountbox.Text = (percentbox.Text * amount.Text) / 100

                amountpaidbox.Text = Val(amount.Text) - Val(perdiscountbox.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        
        
    End Sub

    Private Sub discountamountbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles discountamountbox.TextChanged
        Try
            If Val(discountamountbox.Text) > Val(amount.Text) Then
                MsgBox("Enter correct value", MsgBoxStyle.Critical)
            Else
                amountpaidbox.Text = amount.Text - discountamountbox.Text
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        

    End Sub


    Private Sub cashradio_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cashradio.CheckedChanged
        If cashradio.Checked = True Then
            checkddno.Text = "Not Available"
            If noradio.Checked = False Then
                amountpaidbox.Text = amount.Text
            End If
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
End Class