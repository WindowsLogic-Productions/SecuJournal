Imports System.IO
Imports System.Security.Cryptography
Imports VPKSoft.WinFormsRtfPrint

Public Class SJEntry
    Private enc As System.Text.UTF8Encoding
    Private encryptor As ICryptoTransform
    Private decryptor As ICryptoTransform

#Region "Form Moveability"
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Label1.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Label1.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Label1.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
#End Region
#Region "Panel Moveability"
    Public MovePanel As Boolean
    Public MovePanel_MousePosition As Point

    Public Sub MovePanel_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown

        If e.Button = MouseButtons.Left Then
            MovePanel = True
            MovePanel_MousePosition = e.Location
        End If

    End Sub

    Public Sub MovePanel_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove

        If MovePanel Then
            Panel1.Location = Panel1.Location + (e.Location - MovePanel_MousePosition)
        End If

    End Sub

    Public Sub MovePanel_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp

        If e.Button = MouseButtons.Left Then
            MovePanel = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
#End Region
#Region "Load Settings"
    Private Sub SJEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.OTFEncryption = 1 Then

            Dim KEY_128 As Byte() = {42, 1, 52, 67, 231, 13, 94, 101, 123, 6, 0, 12, 32, 91, 4, 111, 31, 70, 21, 141, 123, 142, 234, 82, 95, 129, 187, 162, 12, 55, 98, 23}
            Dim IV_128 As Byte() = {234, 12, 52, 44, 214, 222, 200, 109, 2, 98, 45, 76, 88, 53, 23, 78}
            Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
            symmetricKey.Mode = CipherMode.CBC

            Me.enc = New System.Text.UTF8Encoding
            Me.encryptor = symmetricKey.CreateEncryptor(KEY_128, IV_128)
            Me.decryptor = symmetricKey.CreateDecryptor(KEY_128, IV_128)
            EncryptTextToolStripMenuItem.Enabled = True
            DecryptTextToolStripMenuItem.Enabled = True
        Else
            EncryptTextToolStripMenuItem.Enabled = False
            DecryptTextToolStripMenuItem.Enabled = False
        End If

        'Load word wrap settings.
        If My.Settings.WordWrap = 0 Then
            RichTextBox1.WordWrap = False
        Else
            RichTextBox1.WordWrap = True
        End If
    End Sub
#End Region
#Region "Menu"
#Region "File"
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If RichTextBox1.Text = "" Then
            MsgBox("You cannot print a blank document.")
        Else
            RichTextBox1.PrintWithDialog()
        End If
    End Sub

    Private Sub SaveAndCloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAndCloseToolStripMenuItem.Click
        RichTextBox1.SaveFile(My.Settings.DefaultSaveDirectory + "\" + TextBox1.Text + ".sje")
        Me.Close()
    End Sub
#End Region
#End Region





    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub PictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PictureToolStripMenuItem.Click
        InsertPicture()
    End Sub

    Private Sub DateAndTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateAndTimeToolStripMenuItem.Click
        SJDate.ShowDialog()
    End Sub

    Private Sub EncryptTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncryptTextToolStripMenuItem.Click
        Dim sPlainText As String = Me.RichTextBox1.SelectedText
        If Not String.IsNullOrEmpty(sPlainText) Then
            Dim memoryStream As MemoryStream = New MemoryStream()
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.encryptor, CryptoStreamMode.Write)
            cryptoStream.Write(Me.enc.GetBytes(sPlainText), 0, sPlainText.Length)
            cryptoStream.FlushFinalBlock()
            Me.RichTextBox1.SelectedText = Convert.ToBase64String(memoryStream.ToArray())
            memoryStream.Close()
            cryptoStream.Close()
        End If
    End Sub

    Private Sub DecryptTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecryptTextToolStripMenuItem.Click
        Try
            Dim cypherTextBytes As Byte() = Convert.FromBase64String(Me.RichTextBox1.SelectedText)
            Dim memoryStream As MemoryStream = New MemoryStream(cypherTextBytes)
            Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, Me.decryptor, CryptoStreamMode.Read)
            Dim plainTextBytes(cypherTextBytes.Length) As Byte
            Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
            memoryStream.Close()
            cryptoStream.Close()
            Me.RichTextBox1.SelectedText = Me.enc.GetString(plainTextBytes, 0, decryptedByteCount)
        Catch
            MsgBox("Text is already decrypted or you have not selected any text.")
        End Try
    End Sub



    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Dim NewFont As New FontDialog
        NewFont.ShowDialog()
        RichTextBox1.SelectionFont = NewFont.Font
    End Sub

    Private Sub TextColourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextColourToolStripMenuItem.Click
        Dim NewColour As New ColorDialog()
        NewColour.ShowDialog()
        RichTextBox1.SelectionColor = NewColour.Color
    End Sub

    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoldToolStripMenuItem.Click
        ToggleStyle(FontStyle.Bold)
    End Sub

    Private Sub ItalicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItalicToolStripMenuItem.Click
        ToggleStyle(FontStyle.Italic)
    End Sub

    Private Sub UnderlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderlineToolStripMenuItem.Click
        ToggleStyle(FontStyle.Underline)
    End Sub

    Private Sub StrikethroughToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrikethroughToolStripMenuItem.Click
        ToggleStyle(FontStyle.Strikeout)
    End Sub

    Private Sub AlignTextLeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignTextLeftToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub AlignTextCentreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignTextCentreToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub AlignTextRightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlignTextRightToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub UndoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem1.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem1.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem1.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem1.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem1.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem1.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub InsertPictureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertPictureToolStripMenuItem.Click
        InsertPicture()
    End Sub

    Private Sub InsertDateAndTimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertDateAndTimeToolStripMenuItem.Click
        SJDate.ShowDialog()
    End Sub
#Region "Functions"
    Sub ToggleStyle(styleToToggle As FontStyle)

        'Backup the current font style
        Dim currentStyle As FontStyle = RichTextBox1.SelectionFont.Style

        'Check what we want to toggle
        If styleToToggle = FontStyle.Bold Then

            'Check if bold is off
            If RichTextBox1.SelectionFont.Bold = False Then
                'Add bold 
                currentStyle += FontStyle.Bold
            Else
                'Turn off bold
                currentStyle -= FontStyle.Bold
            End If

        ElseIf styleToToggle = FontStyle.Italic Then

            'Check if Italic is off
            If RichTextBox1.SelectionFont.Italic = False Then
                'Add Italic 
                currentStyle += FontStyle.Italic
            Else
                'Turn off Italic
                currentStyle -= FontStyle.Italic
            End If

        ElseIf styleToToggle = FontStyle.Underline Then

            'Check if Underline is off
            If RichTextBox1.SelectionFont.Underline = False Then
                'Add Underline 
                currentStyle += FontStyle.Underline
            Else
                'Turn off Underline
                currentStyle -= FontStyle.Underline
            End If

        ElseIf styleToToggle = FontStyle.Strikeout Then

            'Check if Strikeout is off
            If RichTextBox1.SelectionFont.Strikeout = False Then
                'Add Strikeout 
                currentStyle += FontStyle.Strikeout
            Else
                'Turn off Strikeout
                currentStyle -= FontStyle.Strikeout
            End If

        End If

        'Replace the current font with the new style
        RichTextBox1.SelectionFont = New Font(RichTextBox1.SelectionFont, currentStyle)

    End Sub

    Sub InsertPicture()
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "Image Files|*.jpg;*.jpeg;*.gif;*.png;*.tiff;*.bmp"
        If OpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            SJImage.ShowDialog()
            Dim img As Image = Image.FromFile(OpenFile.FileName)
            Dim bmp As New Bitmap(My.Settings.SetImgWidth, My.Settings.SetImgHeight)
            Dim g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), New Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel)
            Clipboard.SetImage(bmp)
            RichTextBox1.Paste()
            g.Dispose()
            bmp.Dispose()
            img.Dispose()
        End If
    End Sub

    Private Sub SJEntry_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RichTextBox1.SaveFile(My.Settings.DefaultSaveDirectory + "\" + TextBox1.Text + " - " + DateTimePicker1.Text + ".sje")
    End Sub
#End Region
#Region "Title Bar"
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub MinimiseButton_Click(sender As Object, e As EventArgs) Handles MinimiseButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MaximiseButton_Click(sender As Object, e As EventArgs) Handles MaximiseButton.Click
        If Me.WindowState = FormWindowState.Maximized Then
            MaximiseButton.Image = My.Resources.WinMaximise
            Me.WindowState = FormWindowState.Normal
            ToolTip1.SetToolTip(MaximiseButton, "Maximise")
        Else
            MaximiseButton.Image = My.Resources.WinRestore
            Me.WindowState = FormWindowState.Maximized
            ToolTip1.SetToolTip(MaximiseButton, "Restore")
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Panel1.Show()
        txtSearchText.Text = RichTextBox1.SelectedText
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        TextBox1.Cut()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        TextBox1.Copy()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        TextBox1.Paste()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        TextBox1.SelectAll()
    End Sub
#End Region
#Region "Find and Replace"
    Private Sub FindPanelClose_Click(sender As Object, e As EventArgs) Handles FindPanelClose.Click
        Panel1.Hide()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If MCCheckBox.Checked = True Then
            RichTextBox1.Find(txtSearchText.Text, 0, RichTextBoxFinds.MatchCase)
        Else
            RichTextBox1.Find(txtSearchText.Text, 0, RichTextBoxFinds.None)
        End If
        RichTextBox1.Focus()
    End Sub

    Private Sub btnReplace_Click(sender As Object, e As EventArgs) Handles btnReplace.Click
        If RichTextBox1.SelectedText = "" Then
        Else
            If RFNCheckBox.Checked = True Then
                RichTextBox1.SelectedText = txtReplacementText.Text
                TextBox1.Text = txtReplacementText.Text
            Else
                RichTextBox1.SelectedText = txtReplacementText.Text
            End If
        End If
    End Sub




#End Region
End Class