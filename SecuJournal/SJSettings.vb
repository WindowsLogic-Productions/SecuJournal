Public Class SJSettings
    Private Sub SJSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load default save directory settings.
        DSLText.Text = My.Settings.DefaultSaveDirectory

        'Load word wrap settings.
        If My.Settings.WordWrap = 0 Then
            WWCheckbox.Checked = False
        Else
            WWCheckbox.Checked = True
        End If

        'Load write title settings.
        If My.Settings.WriteTitle = 0 Then
            WTCheckBox.Checked = False
        Else
            WTCheckBox.Checked = True
        End If

        'Load encryption settings.
        If My.Settings.OTFEncryption = 0 Then
            OTFECheckBox.Checked = False
            OTFEPassword.Enabled = False
        Else
            OTFECheckBox.Checked = True
            OTFEPassword.Enabled = True
        End If

        OTFEPassword.Text = My.Settings.SJPassword
    End Sub

    Private Sub SJSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.DefaultSaveDirectory = DSLText.Text
        If OTFEPassword.Text = "" Then
        Else
            SJEntry.EncryptTextToolStripMenuItem.Enabled = True
            SJEntry.DecryptTextToolStripMenuItem.Enabled = True
        End If
        My.Settings.SJPassword = OTFEPassword.Text
        My.Settings.Save()
    End Sub

    Private Sub DSLBrowseButton_Click(sender As Object, e As EventArgs) Handles DSLBrowseButton.Click
        Dim FolderDialogue As New FolderBrowserDialog
        FolderDialogue.ShowNewFolderButton = True
        If (FolderDialogue.ShowDialog() = DialogResult.OK) Then
            DSLText.Text = FolderDialogue.SelectedPath
        End If
    End Sub

    Private Sub OTFECheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles OTFECheckBox.CheckedChanged
        If OTFECheckBox.Checked = True Then
            My.Settings.OTFEncryption = 1
            OTFEPassword.Enabled = True
        Else
            My.Settings.OTFEncryption = 0
            OTFEPassword.Enabled = False
        End If
    End Sub

    Private Sub WWCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles WWCheckbox.CheckedChanged
        If WWCheckbox.Checked = True Then
            My.Settings.wordwrap = 1
        Else
            My.Settings.wordwrap = 0
        End If
    End Sub

    Private Sub WTCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles WTCheckBox.CheckedChanged
        If WTCheckBox.Checked = True Then
            My.Settings.WriteTitle = 1
        Else
            My.Settings.WriteTitle = 0
        End If
    End Sub
End Class