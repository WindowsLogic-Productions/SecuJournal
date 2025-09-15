<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SJSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DSLBrowseButton = New System.Windows.Forms.Button()
        Me.DSLText = New System.Windows.Forms.TextBox()
        Me.DSLLabel = New System.Windows.Forms.Label()
        Me.OTFECheckBox = New System.Windows.Forms.CheckBox()
        Me.OTFEPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WWCheckbox = New System.Windows.Forms.CheckBox()
        Me.WTCheckBox = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DSLBrowseButton
        '
        Me.DSLBrowseButton.Location = New System.Drawing.Point(307, 13)
        Me.DSLBrowseButton.Name = "DSLBrowseButton"
        Me.DSLBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.DSLBrowseButton.TabIndex = 7
        Me.DSLBrowseButton.Text = "Browse..."
        Me.DSLBrowseButton.UseVisualStyleBackColor = True
        '
        'DSLText
        '
        Me.DSLText.Location = New System.Drawing.Point(128, 15)
        Me.DSLText.Name = "DSLText"
        Me.DSLText.Size = New System.Drawing.Size(173, 20)
        Me.DSLText.TabIndex = 6
        '
        'DSLLabel
        '
        Me.DSLLabel.AutoSize = True
        Me.DSLLabel.Location = New System.Drawing.Point(12, 18)
        Me.DSLLabel.Name = "DSLLabel"
        Me.DSLLabel.Size = New System.Drawing.Size(110, 13)
        Me.DSLLabel.TabIndex = 5
        Me.DSLLabel.Text = "Default save location:"
        '
        'OTFECheckBox
        '
        Me.OTFECheckBox.AutoSize = True
        Me.OTFECheckBox.Location = New System.Drawing.Point(6, 67)
        Me.OTFECheckBox.Name = "OTFECheckBox"
        Me.OTFECheckBox.Size = New System.Drawing.Size(200, 17)
        Me.OTFECheckBox.TabIndex = 8
        Me.OTFECheckBox.Text = "Use text encryption for journal entries"
        Me.OTFECheckBox.UseVisualStyleBackColor = True
        '
        'OTFEPassword
        '
        Me.OTFEPassword.Enabled = False
        Me.OTFEPassword.Location = New System.Drawing.Point(6, 41)
        Me.OTFEPassword.Name = "OTFEPassword"
        Me.OTFEPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.OTFEPassword.Size = New System.Drawing.Size(359, 20)
        Me.OTFEPassword.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.OTFECheckBox)
        Me.GroupBox1.Controls.Add(Me.OTFEPassword)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 90)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Text Encryption"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(354, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "When using text encryption, a password is required to unlock your journal."
        '
        'WWCheckbox
        '
        Me.WWCheckbox.AutoSize = True
        Me.WWCheckbox.Location = New System.Drawing.Point(12, 49)
        Me.WWCheckbox.Name = "WWCheckbox"
        Me.WWCheckbox.Size = New System.Drawing.Size(111, 17)
        Me.WWCheckbox.TabIndex = 11
        Me.WWCheckbox.Text = "Enable word wrap"
        Me.WWCheckbox.UseVisualStyleBackColor = True
        '
        'WTCheckBox
        '
        Me.WTCheckBox.AutoSize = True
        Me.WTCheckBox.Location = New System.Drawing.Point(129, 49)
        Me.WTCheckBox.Name = "WTCheckBox"
        Me.WTCheckBox.Size = New System.Drawing.Size(176, 17)
        Me.WTCheckBox.TabIndex = 12
        Me.WTCheckBox.Text = "Write journal title on top of page"
        Me.ToolTip1.SetToolTip(Me.WTCheckBox, "When starting a new journal entry, the title will be written at the top of the pa" &
        "ge.")
        Me.WTCheckBox.UseVisualStyleBackColor = True
        '
        'SJSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 183)
        Me.Controls.Add(Me.WTCheckBox)
        Me.Controls.Add(Me.WWCheckbox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DSLBrowseButton)
        Me.Controls.Add(Me.DSLText)
        Me.Controls.Add(Me.DSLLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SJSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SecuJournal Settings"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSLBrowseButton As Button
    Friend WithEvents DSLText As TextBox
    Friend WithEvents DSLLabel As Label
    Friend WithEvents OTFECheckBox As CheckBox
    Friend WithEvents OTFEPassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents WWCheckbox As CheckBox
    Friend WithEvents WTCheckBox As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
