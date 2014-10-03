<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComSettings
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
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.COM_Port = New System.Windows.Forms.ComboBox
        Me.COM_portLabel = New System.Windows.Forms.Label
        Me.COM_Baud = New System.Windows.Forms.ComboBox
        Me.COM_baudLabel = New System.Windows.Forms.Label
        Me.COM_dataLabel = New System.Windows.Forms.Label
        Me.COM_parityLabel = New System.Windows.Forms.Label
        Me.COM_StopBits = New System.Windows.Forms.ComboBox
        Me.COM_bitsLabel = New System.Windows.Forms.Label
        Me.COM_Talkman = New System.Windows.Forms.Button
        Me.COM_DataBits = New System.Windows.Forms.ComboBox
        Me.COM_Parity = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.OK_Button.Location = New System.Drawing.Point(12, 193)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(68, 24)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(94, 193)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(68, 24)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'COM_Port
        '
        Me.COM_Port.FormattingEnabled = True
        Me.COM_Port.Location = New System.Drawing.Point(92, 12)
        Me.COM_Port.Name = "COM_Port"
        Me.COM_Port.Size = New System.Drawing.Size(70, 21)
        Me.COM_Port.Sorted = True
        Me.COM_Port.TabIndex = 1
        '
        'COM_portLabel
        '
        Me.COM_portLabel.AutoSize = True
        Me.COM_portLabel.Location = New System.Drawing.Point(9, 12)
        Me.COM_portLabel.Name = "COM_portLabel"
        Me.COM_portLabel.Size = New System.Drawing.Size(29, 13)
        Me.COM_portLabel.TabIndex = 2
        Me.COM_portLabel.Text = "Port:"
        '
        'COM_Baud
        '
        Me.COM_Baud.FormattingEnabled = True
        Me.COM_Baud.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "56000", "57600", "115200"})
        Me.COM_Baud.Location = New System.Drawing.Point(92, 40)
        Me.COM_Baud.Name = "COM_Baud"
        Me.COM_Baud.Size = New System.Drawing.Size(70, 21)
        Me.COM_Baud.TabIndex = 3
        '
        'COM_baudLabel
        '
        Me.COM_baudLabel.AutoSize = True
        Me.COM_baudLabel.Location = New System.Drawing.Point(9, 40)
        Me.COM_baudLabel.Name = "COM_baudLabel"
        Me.COM_baudLabel.Size = New System.Drawing.Size(35, 13)
        Me.COM_baudLabel.TabIndex = 4
        Me.COM_baudLabel.Text = "Baud:"
        '
        'COM_dataLabel
        '
        Me.COM_dataLabel.AutoSize = True
        Me.COM_dataLabel.Location = New System.Drawing.Point(9, 67)
        Me.COM_dataLabel.Name = "COM_dataLabel"
        Me.COM_dataLabel.Size = New System.Drawing.Size(53, 13)
        Me.COM_dataLabel.TabIndex = 5
        Me.COM_dataLabel.Text = "Data Bits:"
        '
        'COM_parityLabel
        '
        Me.COM_parityLabel.AutoSize = True
        Me.COM_parityLabel.Location = New System.Drawing.Point(9, 97)
        Me.COM_parityLabel.Name = "COM_parityLabel"
        Me.COM_parityLabel.Size = New System.Drawing.Size(36, 13)
        Me.COM_parityLabel.TabIndex = 8
        Me.COM_parityLabel.Text = "Parity:"
        '
        'COM_StopBits
        '
        Me.COM_StopBits.FormattingEnabled = True
        Me.COM_StopBits.Items.AddRange(New Object() {"1", "2", "1.5"})
        Me.COM_StopBits.Location = New System.Drawing.Point(92, 121)
        Me.COM_StopBits.Name = "COM_StopBits"
        Me.COM_StopBits.Size = New System.Drawing.Size(70, 21)
        Me.COM_StopBits.TabIndex = 9
        '
        'COM_bitsLabel
        '
        Me.COM_bitsLabel.AutoSize = True
        Me.COM_bitsLabel.Location = New System.Drawing.Point(9, 124)
        Me.COM_bitsLabel.Name = "COM_bitsLabel"
        Me.COM_bitsLabel.Size = New System.Drawing.Size(52, 13)
        Me.COM_bitsLabel.TabIndex = 10
        Me.COM_bitsLabel.Text = "Stop Bits:"
        '
        'COM_Talkman
        '
        Me.COM_Talkman.Location = New System.Drawing.Point(94, 164)
        Me.COM_Talkman.Name = "COM_Talkman"
        Me.COM_Talkman.Size = New System.Drawing.Size(68, 23)
        Me.COM_Talkman.TabIndex = 11
        Me.COM_Talkman.Text = "Defaults"
        Me.COM_Talkman.UseVisualStyleBackColor = True
        '
        'COM_DataBits
        '
        Me.COM_DataBits.FormattingEnabled = True
        Me.COM_DataBits.Items.AddRange(New Object() {"5", "6", "7", "8"})
        Me.COM_DataBits.Location = New System.Drawing.Point(92, 67)
        Me.COM_DataBits.Name = "COM_DataBits"
        Me.COM_DataBits.Size = New System.Drawing.Size(70, 21)
        Me.COM_DataBits.TabIndex = 14
        '
        'COM_Parity
        '
        Me.COM_Parity.FormattingEnabled = True
        Me.COM_Parity.Items.AddRange(New Object() {"None", "Odd", "Even", "Mark", "Space"})
        Me.COM_Parity.Location = New System.Drawing.Point(92, 94)
        Me.COM_Parity.Name = "COM_Parity"
        Me.COM_Parity.Size = New System.Drawing.Size(70, 21)
        Me.COM_Parity.TabIndex = 15
        '
        'frmComSettings
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(174, 229)
        Me.Controls.Add(Me.COM_Parity)
        Me.Controls.Add(Me.COM_DataBits)
        Me.Controls.Add(Me.COM_Talkman)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.COM_bitsLabel)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.COM_StopBits)
        Me.Controls.Add(Me.COM_parityLabel)
        Me.Controls.Add(Me.COM_dataLabel)
        Me.Controls.Add(Me.COM_baudLabel)
        Me.Controls.Add(Me.COM_Baud)
        Me.Controls.Add(Me.COM_portLabel)
        Me.Controls.Add(Me.COM_Port)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmComSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "COM Port Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents COM_portLabel As System.Windows.Forms.Label
    Friend WithEvents COM_Baud As System.Windows.Forms.ComboBox
    Friend WithEvents COM_baudLabel As System.Windows.Forms.Label
    Friend WithEvents COM_dataLabel As System.Windows.Forms.Label
    Friend WithEvents COM_parityLabel As System.Windows.Forms.Label
    Friend WithEvents COM_StopBits As System.Windows.Forms.ComboBox
    Friend WithEvents COM_bitsLabel As System.Windows.Forms.Label
    Friend WithEvents COM_Talkman As System.Windows.Forms.Button
    Friend WithEvents COM_DataBits As System.Windows.Forms.ComboBox
    Friend WithEvents COM_Parity As System.Windows.Forms.ComboBox
    Public WithEvents COM_Port As System.Windows.Forms.ComboBox

End Class
