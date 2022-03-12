Public Class frmAnsamblare
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub frmAnsamblare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listbSub.SelectedIndex = 0
        listbPre.SelectedIndex = 0
        listbComp.SelectedIndex = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim subiect, predicat, complement, propozitie, semn As String

        subiect = listbSub.SelectedItem
        predicat = listbPre.SelectedItem
        complement = listbComp.SelectedItem

        If rb1.Checked Then
            semn = "."
        ElseIf rb2.Checked Then
            semn = "!"
        ElseIf rb3.Checked Then
            semn = "?"
        End If
        propozitie = subiect & " " & predicat & " " & complement & semn
        listbPropozitii.Items.Add(propozitie)
    End Sub

    Private Sub btnSterge_Click(sender As Object, e As EventArgs) Handles btnSterge.Click
        listbPropozitii.Items.Remove(listbPropozitii.SelectedItem)
    End Sub

    Private Sub btnStergeTot_Click(sender As Object, e As EventArgs) Handles btnStergeTot.Click
        listbPropozitii.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
