Public Class frmTransfer
    Private Sub btnAddAll_Click(sender As Object, e As EventArgs) Handles btnAddAll.Click
        lstbProduseCump.Items.AddRange(lstbListaProduse.Items)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'If lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 0 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 1 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 2 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 3 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 4 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 5 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 6 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 7 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 8 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 9 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) = 10 Then
        '    MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    lstbProduseCump.Items.Remove(lstbListaProduse.SelectedItem)
        'End If

        If lstbListaProduse.SelectedIndex = -1 Then
            MessageBox.Show("Nici un produs selectat", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf lstbProduseCump.FindStringExact(lstbListaProduse.SelectedItem) >= 0 And Not chbX.Checked Then
            MessageBox.Show("Produsul a fost deja plasat in cosul de cumparaturi", "VisualStudio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            lstbProduseCump.Items.Add(lstbListaProduse.SelectedItem)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstbProduseCump.Items.RemoveAt(lstbProduseCump.Items.Count - 1)
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        lstbProduseCump.Items.Clear()
    End Sub
End Class
