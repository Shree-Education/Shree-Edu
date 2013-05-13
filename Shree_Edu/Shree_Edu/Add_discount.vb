Public Class Add_discount

    Private Sub Add_discount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        disamtlabel.Visible = False
        discountamountbox.Visible = False
        percentbox.Visible = False
        Percentlabel.Visible = False
        perdiscountbox.Visible = False
        peramountlabel.Visible = False

    End Sub

    Private Sub percentbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If percentbox.Text > 100 Then
                MsgBox("Enter correct value", MsgBoxStyle.Critical)
            Else
                perdiscountbox.Text = (percentbox.Text * vamount) / 100

                vamounttobepaid = Val(vamount) - Val(perdiscountbox.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub discountamountbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Val(discountamountbox.Text) > Val(vamount) Then
                MsgBox("Enter correct value", MsgBoxStyle.Critical)
            Else
                vamounttobepaid = vamount - discountamountbox.Text
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Rupeesradio_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rupeesradio.CheckedChanged
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

    Private Sub percentageradio_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percentageradio.CheckedChanged
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
End Class