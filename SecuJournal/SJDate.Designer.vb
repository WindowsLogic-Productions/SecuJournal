<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SJDate
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
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.UCDTButton = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker2.Location = New System.Drawing.Point(231, 36)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.ShowUpDown = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePicker2.TabIndex = 22
        '
        'UCDTButton
        '
        Me.UCDTButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.UCDTButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.UCDTButton.Location = New System.Drawing.Point(126, 81)
        Me.UCDTButton.Name = "UCDTButton"
        Me.UCDTButton.Size = New System.Drawing.Size(156, 23)
        Me.UCDTButton.TabIndex = 21
        Me.UCDTButton.Text = "Use Current Date and Time"
        Me.UCDTButton.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(101, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(124, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CancelButton.Location = New System.Drawing.Point(288, 81)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 19
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(376, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Select a date and time from the picker below, or use the current date and time."
        '
        'OKButton
        '
        Me.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OKButton.Location = New System.Drawing.Point(369, 81)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 17
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'SJDate
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 115)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.UCDTButton)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OKButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SJDate"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Date and Time"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents UCDTButton As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OKButton As Button
End Class
