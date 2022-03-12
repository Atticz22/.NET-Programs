Public Class frmCalcTrigonom
    Private Sub frmCalcTrigonom_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim u, ur, r As Double


        u = txtbUnghi.Text
        ur = u * (Math.PI / 180)

        If Not IsNumeric(txtbUnghi.Text) Then
            MessageBox.Show("Trebuie introdus o valoare", "Visual Basic", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtbUnghi.SelectAll()
            txtbUnghi.Focus()

        ElseIf rbSin.Checked Then
            r = Math.Sin(ur)
            ElseIf rbCos.Checked Then
                r = Math.Cos(ur)
            ElseIf rbTg.Checked Then
                r = Math.Tan(ur)
            ElseIf rbCtg.Checked Then
                r = 1 / Math.Tan(ur)
            End If


        txtbRezultat.Text = Math.Round(r, 3)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtbUnghi.Text = "0"
        txtbRezultat.Text = ""
    End Sub

    Private Sub txtbUnghi_TextChanged(sender As Object, e As EventArgs) Handles txtbUnghi.TextChanged

    End Sub
End Class
