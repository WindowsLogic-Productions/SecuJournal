Public Class SJDate
    Private Sub UCDTButton_Click(sender As Object, e As EventArgs) Handles UCDTButton.Click
        Clipboard.SetText(Date.Now.ToString)
        SJEntry.RichTextBox1.Paste()
        Me.Close()
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Clipboard.SetText(DateTimePicker1.Text + " " + DateTimePicker2.Text)
        SJEntry.RichTextBox1.Paste()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class