Public Class SJImage
    Private Sub RatioButton169_CheckedChanged(sender As Object, e As EventArgs) Handles RatioButton169.CheckedChanged
        If RatioButton169.Checked = True Then
            NumericUpDown1.Enabled = False
            NumericUpDown2.Enabled = False
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If RatioButton169.Checked = True Then
            My.Settings.SetImgWidth = 208
            My.Settings.SetImgHeight = 117
        ElseIf RatioButton43.Checked = True Then
            My.Settings.SetImgWidth = 200
            My.Settings.SetImgHeight = 150
        Else
            My.Settings.SetImgWidth = NumericUpDown1.Value
            My.Settings.SetImgHeight = NumericUpDown2.Value
        End If
        Me.Close()
    End Sub

    Private Sub RatioButton43_CheckedChanged(sender As Object, e As EventArgs) Handles RatioButton43.CheckedChanged
        If RatioButton43.Checked = True Then
            NumericUpDown1.Enabled = False
            NumericUpDown2.Enabled = False
        End If
    End Sub

    Private Sub RatioButtonCustom_CheckedChanged(sender As Object, e As EventArgs) Handles RatioButtonCustom.CheckedChanged
        NumericUpDown1.Enabled = True
        NumericUpDown2.Enabled = True
    End Sub
End Class