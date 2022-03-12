Public Class frmMinMax
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

    Private Sub btnStergeTot_Click(sender As Object, e As EventArgs) Handles btnStergeTot.Click
        listbNumere.Items.Clear()
        txtbNumere.Text = ""
        txtbMinim.Text = ""
        txtbMaxim.Text = ""
    End Sub

    Private Sub btnMaxMin_Click(sender As Object, e As EventArgs) Handles btnMaxMin.Click
        Dim min, max, nr As Single
        Dim i As Integer

        min = Single.MaxValue
        max = Single.MinValue

        For i = 0 To listbNumere.Items.Count - 1
            nr = listbNumere.Items(i)
            If nr < min Then
                min = nr
            End If
            If nr > max Then
                max = nr
            End If
        Next
        txtbMinim.Text = min
        txtbMaxim.Text = max
    End Sub
End Class
