Public Module modSerialFunctions
    Public boolDelegate As Boolean
    Public strSerialData As String
    Public boolComData As Boolean
    Public portSettings(4) As String

    Public WithEvents serialPort As New IO.Ports.SerialPort

    Public Sub comClose()
        Try
            serialPort.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub comOpen()
        Try
            With serialPort
                '.PortName = frmComSettings.COM_Port.Text
                '.BaudRate = frmComSettings.COM_Baud.Text
                '.Parity = frmComSettings.COM_Parity.SelectedIndex
                '.DataBits = frmComSettings.COM_DataBits.Text
                '.StopBits = frmComSettings.COM_StopBits.SelectedIndex + 1

                .PortName = portSettings(0).ToString
                .BaudRate = portSettings(1).ToString
                .Parity = portSettings(2).ToString
                .DataBits = portSettings(3).ToString
                .StopBits = portSettings(4).ToString

                .DtrEnable = True ' need this for TP400ZC

                '.Encoding = System.Text.Encoding.Default
                '.Encoding = System.Text.Encoding.UTF8
                .ReadTimeout = 10
            End With
            serialPort.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



End Module
