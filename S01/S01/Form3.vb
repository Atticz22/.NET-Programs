Public Class frmNumere
    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        If IsNumeric(textbNumereLista.Text) Then
            listboxNumere.Items.Add(textbNumereLista.Text)
            textbNumereLista.Text = ""
            textbNumereLista.Focus()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnSterge_Click(sender As Object, e As EventArgs) Handles btnSterge.Click
        If listboxNumere.SelectedIndex >= 0 Then
            listboxNumere.Items.Remove(listboxNumere.SelectedItem)
        End If
    End Sub

    Private Sub btnStergeLista_Click(sender As Object, e As EventArgs) Handles btnStergeLista.Click
        listboxNumere.Items.Clear()
        listboxNrPare.Items.Clear()
        listboxNrImpare.Items.Clear()
    End Sub

    Private Sub radiobtnVerde_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtnVerde.CheckedChanged
        listboxNumere.BackColor = Color.LightGreen
        listboxNrPare.BackColor = Color.LightGreen
        listboxNrImpare.BackColor = Color.LightGreen
    End Sub

    Private Sub radiobtnAlb_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtnAlb.CheckedChanged
        listboxNumere.BackColor = Color.White
        listboxNrPare.BackColor = Color.White
        listboxNrImpare.BackColor = Color.White
    End Sub

    Private Sub radiobtnRoz_CheckedChanged(sender As Object, e As EventArgs) Handles radiobtnRoz.CheckedChanged
        listboxNumere.BackColor = Color.LightPink
        listboxNrPare.BackColor = Color.LightPink
        listboxNrImpare.BackColor = Color.LightPink
    End Sub

    Private Sub btnIesireNumere_Click(sender As Object, e As EventArgs) Handles btnIesireNumere.Click
        Me.Close()
        frmSubiect.Show()
    End Sub
End Class