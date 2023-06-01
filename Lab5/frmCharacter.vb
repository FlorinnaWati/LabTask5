Public Class frmCharacter
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If RadioButton3.Checked = True Then
            jawBetul += 1
            MessageBox.Show("That is a good one", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf RadioButton1.Checked = True Or RadioButton2.Checked = True Then
            MsgBox("0 Mark")
        End If
        btnCheck.Enabled = False
    End Sub

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Me.Hide()
        frmCharacterTwo.Show()
    End Sub

End Class