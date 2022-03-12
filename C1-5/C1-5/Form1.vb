Public Class frmPrimulNr
    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        If IsNumeric(txtbNumere.Text) Then
            listbNumere.Items.Add(txtbNumere.Text)
            txtbNumere.Text = ""
            txtbNumere.Focus()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnSterge_Click(sender As Object, e As EventArgs) Handles btnSterge.Click
        If listbNumere.SelectedIndex >= 0 Then
            listbNumere.Items.Remove(listbNumere.SelectedItem)
        End If
    End Sub

    Private Sub btnStergeLista_Click(sender As Object, e As EventArgs) Handles btnStergeLista.Click
        listbNumere.Items.Clear()
    End Sub

    Private Sub btnCauta_Click(sender As Object, e As EventArgs) Handles btnCauta.Click
        Dim i, n As Integer
        n = listbNumere.Items.Count

        i = 0

        Do Until listbNumere.Items(i) < 0
            i = i + 1
            If i >= n Then
                Exit Do
            End If
        Loop
        If i < n Then
            MessageBox.Show("Primul numar negativ este al " & (i + 1) & "-lea numar!", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Lista nu contine nici un numar negativ!", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
