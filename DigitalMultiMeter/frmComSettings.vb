Imports System.Windows.Forms

Public Class frmComSettings

    Private Sub COMDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        comGetPorts()

        'If Owner.ActiveMdiChild.Name = "frmTerminal" Then
        'If frmMain.PanelTalkman.Visible = True Then
        COM_Port.SelectedIndex = 0
        COM_Baud.Text = "2400"
        COM_DataBits.Text = "8"
        COM_Parity.SelectedIndex = 0
        COM_StopBits.SelectedIndex = 0
        'Else
        'COM_Port.SelectedIndex = 0
        'COM_Baud.Text = "9600"
        'COM_DataBits.Text = "8"
        'COM_Parity.SelectedIndex = 0
        'COM_StopBits.SelectedIndex = 0
        'End If
    End Sub

    Public Sub comGetPorts()
        For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
            COM_Port.Items.Add(My.Computer.Ports.SerialPortNames(i))
        Next
    End Sub

    Private Sub COM_Talkman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM_Talkman.Click
        If Owner.ActiveMdiChild.Name = "frmTerminal" Then
            ' If frmMain.PanelTalkman.Visible = True Then
            COM_Port.SelectedIndex = 0
            COM_Baud.Text = "57600"
            COM_DataBits.Text = "8"
            COM_Parity.SelectedIndex = 0
            COM_StopBits.SelectedIndex = 0
        Else
            COM_Port.SelectedIndex = 0
            COM_Baud.Text = "9600"
            COM_DataBits.Text = "8"
            COM_Parity.SelectedIndex = 0
            COM_StopBits.SelectedIndex = 0
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        storeComPortSettings()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub storeComPortSettings()
        portSettings(0) = COM_Port.Text
        portSettings(1) = COM_Baud.Text
        portSettings(2) = COM_Parity.SelectedIndex
        portSettings(3) = COM_DataBits.Text
        portSettings(4) = COM_StopBits.SelectedIndex + 1

        '.PortName = frmComSettings.COM_Port.Text
        '.BaudRate = frmComSettings.COM_Baud.Text
        '.Parity = frmComSettings.COM_Parity.SelectedIndex
        '.DataBits = frmComSettings.COM_DataBits.Text
        '.StopBits = frmComSettings.COM_StopBits.SelectedIndex + 1

    End Sub

End Class
