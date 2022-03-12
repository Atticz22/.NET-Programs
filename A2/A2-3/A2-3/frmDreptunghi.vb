Public Class frmDreptunghi
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim l, w, d, p, a As Single

        l = txtLenght.Text
        w = txtWidth.Text

        d = Math.Sqrt(w ^ 2 + l ^ 2)
        p = 2 * (w + l)
        a = w * l

        txtDiagonal.Text = d
        txtPerimeter.Text = p
        txtArea.Text = a



    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtLenght.Text = ""
        txtWidth.Text = ""
        txtDiagonal.Text = ""
        txtPerimeter.Text = ""
        txtArea.Text = ""


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        frmCalcGeo.Show()

    End Sub
End Class