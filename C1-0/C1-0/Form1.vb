Public Class frmSuma
    Private Sub btnAdauga_Click(sender As Object, e As EventArgs) Handles btnAdauga.Click
        lstbNumere.Items.Add(txtbNumar.Text)
        txtbNumar.Text = ""
        txtbNumar.Focus()
    End Sub

    Private Sub btnSterge_Click(sender As Object, e As EventArgs) Handles btnSterge.Click
        If lstbNumere.SelectedIndex >= 0 Then
            lstbNumere.Items.Remove(lstbNumere.SelectedItem)
        End If
    End Sub

    Private Sub btnStergeLista_Click(sender As Object, e As EventArgs) Handles btnStergeLista.Click
        lstbNumere.Items.Clear()
    End Sub

    Private Sub btnAleatoriu_Click(sender As Object, e As EventArgs) Handles btnAleatoriu.Click
        Dim nrCurent As Single
        Dim i As Integer = 0

        Randomize()

        Do Until Rnd() * 10 < 1
            nrCurent = Math.Round(Rnd() * 20, 3)
            lstbNumere.Items.Add(nrCurent)
            i = i + 1
        Loop

        MsgBox("Au fost adaugate " & i & " numere aleatorii din intervalul [0,20) . ")
    End Sub

    Private Sub btnCalculSuma_Click(sender As Object, e As EventArgs) Handles btnCalculSuma.Click
        Dim s As Single
        Dim i As Integer

        s = 0

        For i = 0 To lstbNumere.Items.Count - 1
            s = s + lstbNumere.Items(i)
        Next

        txtbSuma.Text = s
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MessageBox.Show("Program creat de ...", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnIesire_Click(sender As Object, e As EventArgs) Handles btnIesire.Click
        Me.Close()
    End Sub

    Private Sub frmSuma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
