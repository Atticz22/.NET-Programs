Public Class frmProdus
    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        If IsNumeric(txtbNumere.Text) Then
            listbNumere.Items.Add(txtbNumere.Text)
            txtbNumere.Text = ""
            txtbNumere.Focus()
        End If
    End Sub

    Private Sub btnSterge_Click(sender As Object, e As EventArgs) Handles btnSterge.Click
        If listbNumere.SelectedIndex >= 0 Then
            listbNumere.Items.Remove(listbNumere.SelectedItem)
        End If
    End Sub

    Private Sub btnStergeTot_Click(sender As Object, e As EventArgs) Handles btnStergeTot.Click
        listbNumere.Items.Clear()
        txtbNumerePoz.Text = ""
        txtbNumereNeg.Text = ""
    End Sub

    Private Sub btnCalcul_Click(sender As Object, e As EventArgs) Handles btnCalcul.Click
        Dim pp, pn, nr As Single
        Dim i As Integer


        pp = 1
        pn = 1

        For i = 0 To listbNumere.Items.Count - 1
            nr = listbNumere.Items(i)
            If nr > 0 Then
                pp = pp * listbNumere.Items(i)
            Else
                pn = pn * listbNumere.Items(i)
            End If
        Next
        txtbNumereNeg.Text = pn
        txtbNumerePoz.Text = pp
    End Sub
End Class
