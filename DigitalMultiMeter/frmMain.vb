Imports System
Imports System.IO.Ports

Public Class frmMain
    Public _serialByteArray(14) As Byte
    Public _displayValueDouble As Double
    Public _displayValueString As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddHandler serialPort.DataReceived, AddressOf dataRcvdTerm
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub btnDigital_Click(sender As Object, e As EventArgs) Handles btnDigital.Click, DigitalToolStripMenuItem.Click
        txtTerminal.Text = serialPort.ReadExisting.ToString
    End Sub


    Private Sub btnAnalog_Click(sender As Object, e As EventArgs) Handles btnAnalog.Click, AnalogToolStripMenuItem.Click

    End Sub


    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click, ListToolStripMenuItem.Click

    End Sub

    Private Sub btnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click, GraphToolStripMenuItem.Click

    End Sub

    Private Sub COMPortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COMPortToolStripMenuItem.Click
        frmComSettings.ShowDialog()
    End Sub

    Private Sub btnBeginStop_Click(sender As Object, e As EventArgs) Handles btnBeginStop.Click
        If serialPort.IsOpen Then
            comClose()
            bkgdWorkerSerial.CancelAsync()
            btnBeginStop.Text = "Begin"
            Exit Sub
        Else
            Dim dlgComResult As DialogResult = New frmComSettings().ShowDialog(Me)
            If dlgComResult = DialogResult.OK Then
                bkgdWorkerSerial.RunWorkerAsync()
                comOpen()
                btnBeginStop.Text = "Stop"
                Exit Sub
            End If
        End If
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        comClose()
        bkgdWorkerSerial.CancelAsync()
    End Sub

    ' Actual Functions 
    Public Sub dataRcvdTerm(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)
        Try
            txtTerminal.Invoke(New delegateTerm(AddressOf updateTextBox), New Object() {})
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Delegate Sub delegateTerm()
    Public Sub updateTextBox()
        boolDelegate = True
    End Sub
    Private Sub bkgdWorkerSerial_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bkgdWorkerSerial.ProgressChanged

        Dim dataLength As Integer = serialPort.BytesToRead
        Dim tempData As Byte() = New Byte(dataLength) {}
        Dim nbrDataRead As Integer = serialPort.Read(tempData, 0, dataLength)

        For Each childByte In tempData
            _serialByteArray(childByte >> 4) = childByte ' could also use And &HF0
        Next

        ' Byte 1: AC DC Auto RS232
        lblAC.Visible = _serialByteArray(1) And &H8
        lblDC.Visible = _serialByteArray(1) And &H4
        lblAuto.Visible = _serialByteArray(1) And &H2
        lblRS232.Visible = _serialByteArray(1) And &H1

        lblDigitalDisplay.Text = getDigitalDisplayValue(_serialByteArray(2), _serialByteArray(3), _serialByteArray(4), _serialByteArray(5), _serialByteArray(6), _serialByteArray(7), _serialByteArray(8), _serialByteArray(9))
        ' Byte A: μ n k {Diode}
        ' Byte B: m % M ♫
        ' Byte C: F Ω ∆ Hold
        ' Byte D: A V Hz {Battery}


        lblMicro.Visible = _serialByteArray(10) And &H8
        lblNano.Visible = _serialByteArray(10) And &H4
        lblKilo.Visible = _serialByteArray(10) And &H2
        lblDiode.Visible = _serialByteArray(10) And &H1

        lblMilli.Visible = _serialByteArray(11) And &H8
        lblDutyCycle.Visible = _serialByteArray(11) And &H4
        lblMega.Visible = _serialByteArray(11) And &H2
        lblSound.Visible = _serialByteArray(11) And &H1

        lblFarads.Visible = _serialByteArray(12) And &H8
        lblOhms.Visible = _serialByteArray(12) And &H4
        lblRelDelta.Visible = _serialByteArray(12) And &H2
        lblHold.Visible = _serialByteArray(12) And &H1

        lblAmps.Visible = _serialByteArray(13) And &H8
        lblVolts.Visible = _serialByteArray(13) And &H4
        lblHertz.Visible = _serialByteArray(13) And &H2
        lblBattery.Visible = _serialByteArray(13) And &H1

        'INTERNAL USE - lblINTERNAL.Visible
        'INTERNAL USE - lblINTERNAL.Visible
        lblDegreeC.Visible = _serialByteArray(14) And &H2
        'NOT IMPLEMENTED - lblhFE.Visible = _serialByteArray(14) And &H1



    End Sub

    Private Function getDigitalDisplayValue(ByVal inputByte2, ByVal inputByte3, ByVal inputByte4, ByVal inputByte5, ByVal inputByte6, ByVal inputByte7, ByVal inputByte8, ByVal inputByte9) As String
        Dim displayNegative As String = ""
        Dim displayDecimal1 As String = ""
        Dim displayDecimal2 As String = ""
        Dim displayDecimal3 As String = ""

        If New BitArray(System.BitConverter.GetBytes(_serialByteArray(2))).Get(3) = True Then
            displayNegative = "-"
        End If
        If New BitArray(System.BitConverter.GetBytes(_serialByteArray(4))).Get(3) = True Then
            displayDecimal1 = "."
        End If
        If New BitArray(System.BitConverter.GetBytes(_serialByteArray(6))).Get(3) = True Then
            displayDecimal2 = "."
        End If
        If New BitArray(System.BitConverter.GetBytes(_serialByteArray(8))).Get(3) = True Then
            displayDecimal3 = "."
        End If

        Dim byteDigit1 As Byte = CByte((((inputByte2 And &HF) << 4) Or (inputByte3 And &HF)) And &H7F)
        Dim byteDigit2 As Byte = CByte((((inputByte4 And &HF) << 4) Or (inputByte5 And &HF)) And &H7F)
        Dim byteDigit3 As Byte = CByte((((inputByte6 And &HF) << 4) Or (inputByte7 And &HF)) And &H7F)
        Dim byteDigit4 As Byte = CByte((((inputByte8 And &HF) << 4) Or (inputByte9 And &HF)) And &H7F)

        Dim displayDigit1 As String = ""
        Dim displayDigit2 As String = ""
        Dim displayDigit3 As String = ""
        Dim displayDigit4 As String = ""

        Select Case byteDigit1
            Case &H0 ' 0000000 Blank
                displayDigit1 = ""
            Case &H5 ' 0000101 1
                displayDigit1 = "1"
            Case &H15 ' 0010101 7
                displayDigit1 = "7"
            Case &H1F ' 0011111 3
                displayDigit1 = "3"
            Case &H27 ' 0100111 4
                displayDigit1 = "4"
            Case &H3E ' 0111110 5
                displayDigit1 = "5"
            Case &H3F ' 0111111 9
                displayDigit1 = "9"
            Case &H5B ' 1011011 2
                displayDigit1 = "2"
            Case &H68 ' 1101000 L
                displayDigit1 = "L"
            Case &H7D ' 1111101 0
                displayDigit1 = "0"
            Case &H7E ' 1111110 6
                displayDigit1 = "6"
            Case &H7F ' 1111111 8
                displayDigit1 = "8"
        End Select
        Select Case byteDigit2
            Case &H0 ' 0000000 Blank
                displayDigit2 = ""
            Case &H5 ' 0000101 1
                displayDigit2 = "1"
            Case &H15 ' 0010101 7
                displayDigit2 = "7"
            Case &H1F ' 0011111 3
                displayDigit2 = "3"
            Case &H27 ' 0100111 4
                displayDigit2 = "4"
            Case &H3E ' 0111110 5
                displayDigit2 = "5"
            Case &H3F ' 0111111 9
                displayDigit2 = "9"
            Case &H5B ' 1011011 2
                displayDigit2 = "2"
            Case &H68 ' 1101000 L
                displayDigit2 = "L"
            Case &H7D ' 1111101 0
                displayDigit2 = "0"
            Case &H7E ' 1111110 6
                displayDigit2 = "6"
            Case &H7F ' 1111111 8
                displayDigit2 = "8"
        End Select
        Select Case byteDigit3
            Case &H0 ' 0000000 Blank
                displayDigit3 = ""
            Case &H5 ' 0000101 1
                displayDigit3 = "1"
            Case &H15 ' 0010101 7
                displayDigit3 = "7"
            Case &H1F ' 0011111 3
                displayDigit3 = "3"
            Case &H27 ' 0100111 4
                displayDigit3 = "4"
            Case &H3E ' 0111110 5
                displayDigit3 = "5"
            Case &H3F ' 0111111 9
                displayDigit3 = "9"
            Case &H5B ' 1011011 2
                displayDigit3 = "2"
            Case &H68 ' 1101000 L
                displayDigit3 = "L"
            Case &H7D ' 1111101 0
                displayDigit3 = "0"
            Case &H7E ' 1111110 6
                displayDigit3 = "6"
            Case &H7F ' 1111111 8
                displayDigit3 = "8"
        End Select
        Select Case byteDigit4
            Case &H0 ' 0000000 Blank
                displayDigit4 = ""
            Case &H5 ' 0000101 1
                displayDigit4 = "1"
            Case &H15 ' 0010101 7
                displayDigit4 = "7"
            Case &H1F ' 0011111 3
                displayDigit4 = "3"
            Case &H27 ' 0100111 4
                displayDigit4 = "4"
            Case &H3E ' 0111110 5
                displayDigit4 = "5"
            Case &H3F ' 0111111 9
                displayDigit4 = "9"
            Case &H5B ' 1011011 2
                displayDigit4 = "2"
            Case &H68 ' 1101000 L
                displayDigit4 = "L"
            Case &H7D ' 1111101 0
                displayDigit4 = "0"
            Case &H7E ' 1111110 6
                displayDigit4 = "6"
            Case &H7F ' 1111111 8
                displayDigit4 = "8"
        End Select

        _displayValueString = displayNegative & displayDigit1 & displayDecimal1 & displayDigit2 & displayDecimal2 & displayDigit3 & displayDecimal3 & displayDigit4
        If _displayValueString.Contains("L") Then
            _displayValueDouble = Nothing
        Else
            Try
                _displayValueDouble = _displayValueString
                'VuMeter1.Level = _displayValueDouble
            Catch ex As Exception

            End Try
            
        End If

        Return displayNegative & displayDigit1 & displayDecimal1 & displayDigit2 & displayDecimal2 & displayDigit3 & displayDecimal3 & displayDigit4


    End Function

    Private Sub bkgdWorkerSerial_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bkgdWorkerSerial.DoWork
        Do While True
            If boolComData = True Then
                bkgdWorkerSerial.ReportProgress(1)
                boolComData = False
            End If
            If bkgdWorkerSerial.CancellationPending = True Then
                'bkgdWorkTerm.CancelAsync() 'Kill the background worker
                e.Cancel = True
                Return
            End If
            Application.DoEvents()
            If boolDelegate = True Then
                bkgdWorkerSerial.ReportProgress(1)
                boolDelegate = False
            End If
        Loop
    End Sub
    Private Sub bkgdWorkTerm_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkgdWorkerSerial.RunWorkerCompleted
        'mnuTermConn.Enabled = True
    End Sub

    Private Sub lblRelDelta_Click(sender As Object, e As EventArgs) Handles lblRelDelta.Click

    End Sub

    Private Sub lblKilo_Click(sender As Object, e As EventArgs) Handles lblKilo.Click

    End Sub
End Class
