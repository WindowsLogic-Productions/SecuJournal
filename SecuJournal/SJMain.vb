Imports System.IO
Imports System.Security.Cryptography

Public Class SJMain
    Private Sub NewJournalEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewJournalEntryToolStripMenuItem.Click
        SJName.ShowDialog()
    End Sub

    Private Sub SJMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.OTFEncryption = 1 Then
            SJPassword.ShowDialog()
        Else

        End If

        For Each arg As String In My.Application.CommandLineArgs
            Dim NewEntry As New SJEntry
            NewEntry.Show()
            NewEntry.RichTextBox1.Text = File.ReadAllText(arg)
        Next

        Dim root As String = "C:\SecuJournal"
        If Not Directory.Exists(root) Then
            Directory.CreateDirectory(root)
        End If

        Environment.GetCommandLineArgs()
    End Sub

    Private Sub OpenJournalEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenJournalEntryToolStripMenuItem.Click
        OpenFileDialog1.InitialDirectory = My.Settings.DefaultSaveDirectory
        OpenFileDialog1.Title = "Open Journal Entry"
        OpenFileDialog1.Filter = "SecuJournal Entry|*.sje"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim OpenEntry As New SJEntry
            OpenEntry.MdiParent = Me
            OpenEntry.Show()
            OpenEntry.RichTextBox1.LoadFile(OpenFileDialog1.FileName)
            OpenEntry.TextBox1.Text = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub BackupJournalEntriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupJournalEntriesToolStripMenuItem.Click
        Dim FolderDialogue As New FolderBrowserDialog
        FolderDialogue.ShowNewFolderButton = True
        Dim SourcePath As String = My.Settings.DefaultSaveDirectory
        Dim DestinationPath As String
        If (FolderDialogue.ShowDialog() = DialogResult.OK) Then
            DestinationPath = FolderDialogue.SelectedPath
            Dim root As Environment.SpecialFolder = FolderDialogue.RootFolder
            Dim newDirectory As String = System.IO.Path.Combine(DestinationPath, Path.GetFileName(Path.GetDirectoryName(SourcePath)))
            If Not (Directory.Exists(newDirectory)) Then
                Directory.CreateDirectory(newDirectory)
            End If
            Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(SourcePath, newDirectory)
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        SJSettings.ShowDialog()
    End Sub

    Private Sub SJMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        File.Create(Application.StartupPath & "\SecuJournal.ini").Dispose()

        System.IO.File.WriteAllText(Application.StartupPath & "\SecuJournal.ini", "")

        'Dim objWriter As New System.IO.StreamWriter(Application.StartupPath & "\SecuJournal.ini", True)
        'objWriter.WriteLine("[SecuJournal]")
        'objWriter.WriteLine(My.Settings.DefaultSaveDirectory)
        'objWriter.WriteLine(My.Settings.OTFEncryption)

        '' Encrypt password before saving.
        'Dim sPlainText As String = My.Settings.SJPassword

        'If sPlainText Is Empty(sPlainText) Then

        'End If

        'String sPlainText = this.richTextBoxNote.Text;

        '    If (!string.IsNullOrEmpty(sPlainText)) Then
        '                {
        '        MemoryStream MemoryStream = New MemoryStream();
        '        CryptoStream CryptoStream = New CryptoStream(MemoryStream, this.encryptor, CryptoStreamMode.Write);
        '        CryptoStream.Write(this.enc.GetBytes(sPlainText), 0, sPlainText.Length);
        '        CryptoStream.FlushFinalBlock();
        '        this.richTextBoxNote.Text = Convert.ToBase64String(MemoryStream.ToArray());
        '        MemoryStream.Close();
        '        CryptoStream.Close();
        '    }

        'objWriter.WriteLine("[Slimes]")
        'objWriter.WriteLine(My.Settings.Slimes.ToString)
        'objWriter.WriteLine("[Cat Maids]")
        'objWriter.WriteLine(My.Settings.CatMaid.ToString)
        'objWriter.WriteLine("[Coin Farms]")
        'objWriter.WriteLine(My.Settings.CoinFarm.ToString)
        'objWriter.WriteLine("[Coin Minting Facilities]")
        'objWriter.WriteLine(My.Settings.CoinMint.ToString)
        'objWriter.WriteLine("[Coin Banks]")
        'objWriter.WriteLine(My.Settings.CoinBank.ToString)
        'objWriter.WriteLine("[Coin Temples]")
        'objWriter.WriteLine(My.Settings.CoinTemple.ToString)
        'objWriter.WriteLine("[Coin Towers]")
        'objWriter.WriteLine(My.Settings.CoinTower.ToString)
        'objWriter.WriteLine("[Coin Mines]")
        'objWriter.WriteLine(My.Settings.CoinMine.ToString)
        'objWriter.WriteLine("[Calculators]")
        'objWriter.WriteLine(My.Settings.AutoClickerCalc.ToString)
        'objWriter.WriteLine(My.Settings.SlimeCalc.ToString)
        'objWriter.WriteLine(My.Settings.CatMaidCalc.ToString)
        'objWriter.WriteLine(My.Settings.CoinFarmCalc.ToString)
        'objWriter.WriteLine(My.Settings.CoinBankCalc.ToString)
        'objWriter.WriteLine(My.Settings.CoinMintCalc.ToString)
        'objWriter.WriteLine(My.Settings.CoinTempleCalc.ToString)
        'objWriter.WriteLine(My.Settings.CoinTowerCalc.ToString)
        'objWriter.WriteLine(My.Settings.CoinMineCalc.ToString)
        'objWriter.WriteLine("[Sound]")
        'objWriter.WriteLine(My.Settings.MuteMusic)
        'objWriter.WriteLine(My.Settings.MuteSounds)
        'objWriter.WriteLine("[Time Cycle]")
        'objWriter.WriteLine(My.Settings.AlwaysDay)
        'objWriter.WriteLine(My.Settings.AlwaysNight)
        'objWriter.WriteLine(My.Settings.RealTime)
        'objWriter.WriteLine("[Updates]")
        'objWriter.WriteLine(My.Settings.Updates)
        'objWriter.WriteLine("[Upgrade Costs]")
        'objWriter.WriteLine(My.Settings.AutoClickerCost)
        'objWriter.WriteLine(My.Settings.SlimeWorkerCost)
        'objWriter.WriteLine(My.Settings.CatMaidCost)
        'objWriter.WriteLine(My.Settings.CoinFarmCost)
        'objWriter.WriteLine(My.Settings.CoinMintCost)
        'objWriter.WriteLine(My.Settings.CoinBankCost)
        'objWriter.WriteLine(My.Settings.CoinTempleCost)
        'objWriter.WriteLine(My.Settings.CoinTowerCost)
        'objWriter.WriteLine(My.Settings.CoinMineCost)
        'objWriter.WriteLine("[Cursor Perks]")
        'objWriter.WriteLine(My.Settings.HasCursorPerk)

        'objWriter.Close()
    End Sub
End Class
