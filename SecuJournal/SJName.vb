Public Class SJName
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim NewEntry As New SJEntry
        NewEntry.MdiParent = SJMain
        NewEntry.Show()

        If TextBox1.Text = "" Then
            NewEntry.TextBox1.Text = "New journal entry - " + Date.Now.ToString("dd-MM-yyyy")
        Else
            NewEntry.TextBox1.Text = TextBox1.Text
            NewEntry.DateTimePicker1.Text = DateTimePicker1.Text
        End If


        'Load write title settings.
        If My.Settings.WriteTitle = 0 Then

        Else
            NewEntry.RichTextBox1.Text = NewEntry.TextBox1.Text + " - " + NewEntry.DateTimePicker1.Text
        End If

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class