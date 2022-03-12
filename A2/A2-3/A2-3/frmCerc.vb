Public Class frmCerc
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtbArea.TextChanged

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim r, p, a As Double

        r = txtbRadius.Text

        p = 2 * Math.PI * r

        a = Math.PI * r ^ 2

        txtbPerimeter.Text = p
        txtbArea.Text = a
        txtbPerimeter.Text = Math.Round(p, 3)
        txtbArea.Text = Math.Round(a, 3)



    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtbRadius.Text = ""
        txtbPerimeter.Text = ""
        txtbArea.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        frmCalcGeo.Show()

    End Sub
End Class