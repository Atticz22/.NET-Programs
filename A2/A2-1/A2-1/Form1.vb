Public Class frmSP
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim a As Single, b As Single, c As Single
        Dim s As Single
        Dim p As Single


        a = txtA.Text
        b = txtB.Text
        c = txtC.Text

        s = a + b + c

        p = a * b * c

        txtSuma.Text = s
        txtProdus.Text = p


    End Sub

    Private Sub txtA_TextChanged(sender As Object, e As EventArgs) Handles txtA.TextChanged

    End Sub

    Private Sub txtSuma_TextChanged(sender As Object, e As EventArgs) Handles txtSuma.TextChanged

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MsgBox("Suma=a+b+c" & vbCrLf & "Produs=a*b*c")



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
