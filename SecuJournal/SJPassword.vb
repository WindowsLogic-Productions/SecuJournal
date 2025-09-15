Public Class SJPassword
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        End
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If My.Settings.SJPassword = TextBox1.Text Then
            Me.Close()
        Else
            MsgBox("You have entered the wrong password for this journal.", MsgBoxStyle.Critical, "Journal Password")
        End If
    End Sub
End Class