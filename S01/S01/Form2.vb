Public Class frmPlan
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim unghi, coeficient, g, a, b As Double

        unghi = txtbUNGHI.Text
        coeficient = txtbCOEFICIENT.Text
        g = 9.81

        b = unghi * (Math.PI / 180)

        If 0 <= coeficient And coeficient <= 0.85 Then
            a = g * (Math.Sin(b) - coeficient * Math.Cos(b))
        Else
            MessageBox.Show("Calculul se va efectua doar în cazul în care coeficientul de frecare este în intervalul [0; 0.85].", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        txtbREZULTAT.Text = Math.Round(a, 1)

        If a > 0 Then
            MessageBox.Show("Exista alunecare", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf a <= 0 Then
            MessageBox.Show("Corpul este in echilibru", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MessageBox.Show("Czampo Attila-Norbert. Subiectul 01. Examen Programare", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnIesire_Click(sender As Object, e As EventArgs) Handles btnIesire.Click
        Me.Close()
        frmSubiect.Show()
    End Sub
End Class