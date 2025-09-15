<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SJImage
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
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RatioButton169 = New System.Windows.Forms.RadioButton()
        Me.RatioButton43 = New System.Windows.Forms.RadioButton()
        Me.RatioButtonCustom = New System.Windows.Forms.RadioButton()
        Me.OKButton = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(54, 40)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(45, 20)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(125, 40)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(53, 20)
        Me.NumericUpDown2.TabIndex = 1
        Me.NumericUpDown2.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(105, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Resize image"
        '
        'RatioButton169
        '
        Me.RatioButton169.AutoSize = True
        Me.RatioButton169.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RatioButton169.Location = New System.Drawing.Point(15, 82)
        Me.RatioButton169.Name = "RatioButton169"
        Me.RatioButton169.Size = New System.Drawing.Size(110, 18)
        Me.RatioButton169.TabIndex = 4
        Me.RatioButton169.TabStop = True
        Me.RatioButton169.Text = "208 X 117 (16:9)"
        Me.RatioButton169.UseVisualStyleBackColor = True
        '
        'RatioButton43
        '
        Me.RatioButton43.AutoSize = True
        Me.RatioButton43.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RatioButton43.Location = New System.Drawing.Point(125, 82)
        Me.RatioButton43.Name = "RatioButton43"
        Me.RatioButton43.Size = New System.Drawing.Size(104, 18)
        Me.RatioButton43.TabIndex = 5
        Me.RatioButton43.TabStop = True
        Me.RatioButton43.Text = "200 X 150 (4:3)"
        Me.RatioButton43.UseVisualStyleBackColor = True
        '
        'RatioButtonCustom
        '
        Me.RatioButtonCustom.AutoSize = True
        Me.RatioButtonCustom.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RatioButtonCustom.Location = New System.Drawing.Point(229, 82)
        Me.RatioButtonCustom.Name = "RatioButtonCustom"
        Me.RatioButtonCustom.Size = New System.Drawing.Size(66, 18)
        Me.RatioButtonCustom.TabIndex = 6
        Me.RatioButtonCustom.TabStop = True
        Me.RatioButtonCustom.Text = "Custom"
        Me.RatioButtonCustom.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKButton.Location = New System.Drawing.Point(214, 12)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 7
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'SJImage
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 114)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.RatioButtonCustom)
        Me.Controls.Add(Me.RatioButton43)
        Me.Controls.Add(Me.RatioButton169)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SJImage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Image"
        Me.TopMost = True
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RatioButton169 As RadioButton
    Friend WithEvents RatioButton43 As RadioButton
    Friend WithEvents RatioButtonCustom As RadioButton
    Friend WithEvents OKButton As Button
End Class
