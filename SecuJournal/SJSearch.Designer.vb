<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SJSearch
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
        Me.MCCheckBox = New System.Windows.Forms.CheckBox()
        Me.lblSearchText = New System.Windows.Forms.Label()
        Me.txtSearchText = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.lblReplacementText = New System.Windows.Forms.Label()
        Me.txtReplacementText = New System.Windows.Forms.TextBox()
        Me.btnReplace = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MCCheckBox
        '
        Me.MCCheckBox.AutoSize = True
        Me.MCCheckBox.Location = New System.Drawing.Point(15, 100)
        Me.MCCheckBox.Name = "MCCheckBox"
        Me.MCCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.MCCheckBox.TabIndex = 19
        Me.MCCheckBox.Text = "Match case"
        Me.MCCheckBox.UseVisualStyleBackColor = True
        '
        'lblSearchText
        '
        Me.lblSearchText.AutoSize = True
        Me.lblSearchText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSearchText.Location = New System.Drawing.Point(12, 9)
        Me.lblSearchText.Name = "lblSearchText"
        Me.lblSearchText.Size = New System.Drawing.Size(68, 13)
        Me.lblSearchText.TabIndex = 11
        Me.lblSearchText.Text = "Search Text:"
        '
        'txtSearchText
        '
        Me.txtSearchText.Location = New System.Drawing.Point(15, 25)
        Me.txtSearchText.Name = "txtSearchText"
        Me.txtSearchText.Size = New System.Drawing.Size(212, 20)
        Me.txtSearchText.TabIndex = 12
        '
        'btnFind
        '
        Me.btnFind.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnFind.Location = New System.Drawing.Point(233, 23)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 17
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblReplacementText
        '
        Me.lblReplacementText.AutoSize = True
        Me.lblReplacementText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReplacementText.Location = New System.Drawing.Point(12, 48)
        Me.lblReplacementText.Name = "lblReplacementText"
        Me.lblReplacementText.Size = New System.Drawing.Size(97, 13)
        Me.lblReplacementText.TabIndex = 13
        Me.lblReplacementText.Text = "Replacement Text:"
        '
        'txtReplacementText
        '
        Me.txtReplacementText.Location = New System.Drawing.Point(15, 65)
        Me.txtReplacementText.Name = "txtReplacementText"
        Me.txtReplacementText.Size = New System.Drawing.Size(212, 20)
        Me.txtReplacementText.TabIndex = 14
        '
        'btnReplace
        '
        Me.btnReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnReplace.Location = New System.Drawing.Point(233, 63)
        Me.btnReplace.Name = "btnReplace"
        Me.btnReplace.Size = New System.Drawing.Size(75, 23)
        Me.btnReplace.TabIndex = 18
        Me.btnReplace.Text = "Replace"
        Me.btnReplace.UseVisualStyleBackColor = True
        '
        'SJSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 151)
        Me.Controls.Add(Me.MCCheckBox)
        Me.Controls.Add(Me.btnReplace)
        Me.Controls.Add(Me.txtReplacementText)
        Me.Controls.Add(Me.lblReplacementText)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtSearchText)
        Me.Controls.Add(Me.lblSearchText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SJSearch"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find and Replace"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MCCheckBox As CheckBox
    Friend WithEvents lblSearchText As Label
    Friend WithEvents txtSearchText As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents lblReplacementText As Label
    Friend WithEvents txtReplacementText As TextBox
    Friend WithEvents btnReplace As Button
End Class
