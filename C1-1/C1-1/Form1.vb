Public Class frmFactor
    Private Sub btnCalcFor_Click(sender As Object, e As EventArgs) Handles btnCalcFor.Click
        Dim f As Long
        Dim i As Integer

        f = 1
        i = 2

        For i = 1 To numericN.Value Step 2
            f = f * i
        Next

        txtbFor.Text = f
        txtbFor.BackColor = Color.LightSteelBlue

    End Sub

    Private Sub btnCalcDo_Click(sender As Object, e As EventArgs) Handles btnCalcDo.Click
        Dim f, n As Long
        Dim i As Integer

        n = numericN.Value
        f = 1
        i = 1

        Do While i <= n
            f = f * i
            i = i + 2
        Loop
        txtbDo.Text = f
        txtbDo.BackColor = Color.LightCyan
    End Sub
End Class
