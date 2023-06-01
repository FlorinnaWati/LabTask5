Public Class frmCharacterThree
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If RadioButton1.Checked = True Then
            jawBetul += 1
            MessageBox.Show("That is a good one", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf RadioButton3.Checked = True Or RadioButton2.Checked = True Then
            MsgBox("0 Mark")
        End If
        lblJawBetul.Text = jawBetul
        btnCheck.Enabled = False
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Form1.Show()
    End Sub
End Class