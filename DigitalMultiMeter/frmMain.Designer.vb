<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnBeginStop = New System.Windows.Forms.Button()
        Me.btnDigital = New System.Windows.Forms.Button()
        Me.btnAnalog = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnGraph = New System.Windows.Forms.Button()
        Me.btnRecordOne = New System.Windows.Forms.Button()
        Me.grpRecording = New System.Windows.Forms.GroupBox()
        Me.chkContinuous = New System.Windows.Forms.CheckBox()
        Me.chkRecording = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDataFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveDataFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintGraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DigitalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnalogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTerminal = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblhFE = New System.Windows.Forms.Label()
        Me.lblDegreeC = New System.Windows.Forms.Label()
        Me.lblDutyCycle = New System.Windows.Forms.Label()
        Me.lblMilli = New System.Windows.Forms.Label()
        Me.lblMega = New System.Windows.Forms.Label()
        Me.lblNano = New System.Windows.Forms.Label()
        Me.lblMicro = New System.Windows.Forms.Label()
        Me.lblKilo = New System.Windows.Forms.Label()
        Me.lblOhms = New System.Windows.Forms.Label()
        Me.lblFarads = New System.Windows.Forms.Label()
        Me.lblAmps = New System.Windows.Forms.Label()
        Me.lblVolts = New System.Windows.Forms.Label()
        Me.lblDC = New System.Windows.Forms.Label()
        Me.lblDiode = New System.Windows.Forms.Label()
        Me.lblSound = New System.Windows.Forms.Label()
        Me.lblBattery = New System.Windows.Forms.Label()
        Me.lblRelDelta = New System.Windows.Forms.Label()
        Me.lblHertz = New System.Windows.Forms.Label()
        Me.lblHold = New System.Windows.Forms.Label()
        Me.lblDigitalDisplay = New System.Windows.Forms.Label()
        Me.lblRS232 = New System.Windows.Forms.Label()
        Me.lblAC = New System.Windows.Forms.Label()
        Me.lblAuto = New System.Windows.Forms.Label()
        Me.bkgdWorkerSerial = New System.ComponentModel.BackgroundWorker()
        Me.grpRecording.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBeginStop
        '
        Me.btnBeginStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBeginStop.Location = New System.Drawing.Point(537, 28)
        Me.btnBeginStop.Name = "btnBeginStop"
        Me.btnBeginStop.Size = New System.Drawing.Size(75, 23)
        Me.btnBeginStop.TabIndex = 0
        Me.btnBeginStop.Text = "Begin"
        Me.btnBeginStop.UseVisualStyleBackColor = True
        '
        'btnDigital
        '
        Me.btnDigital.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDigital.Location = New System.Drawing.Point(537, 86)
        Me.btnDigital.Name = "btnDigital"
        Me.btnDigital.Size = New System.Drawing.Size(75, 23)
        Me.btnDigital.TabIndex = 1
        Me.btnDigital.Text = "Digital"
        Me.btnDigital.UseVisualStyleBackColor = True
        '
        'btnAnalog
        '
        Me.btnAnalog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnalog.Location = New System.Drawing.Point(537, 115)
        Me.btnAnalog.Name = "btnAnalog"
        Me.btnAnalog.Size = New System.Drawing.Size(75, 23)
        Me.btnAnalog.TabIndex = 2
        Me.btnAnalog.Text = "Analog"
        Me.btnAnalog.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnList.Location = New System.Drawing.Point(537, 144)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 3
        Me.btnList.Text = "List"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnGraph
        '
        Me.btnGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGraph.Location = New System.Drawing.Point(537, 173)
        Me.btnGraph.Name = "btnGraph"
        Me.btnGraph.Size = New System.Drawing.Size(75, 23)
        Me.btnGraph.TabIndex = 4
        Me.btnGraph.Text = "Graph"
        Me.btnGraph.UseVisualStyleBackColor = True
        '
        'btnRecordOne
        '
        Me.btnRecordOne.Location = New System.Drawing.Point(6, 39)
        Me.btnRecordOne.Name = "btnRecordOne"
        Me.btnRecordOne.Size = New System.Drawing.Size(62, 23)
        Me.btnRecordOne.TabIndex = 5
        Me.btnRecordOne.Text = "One"
        Me.btnRecordOne.UseVisualStyleBackColor = True
        '
        'grpRecording
        '
        Me.grpRecording.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpRecording.Controls.Add(Me.chkContinuous)
        Me.grpRecording.Controls.Add(Me.chkRecording)
        Me.grpRecording.Controls.Add(Me.btnRecordOne)
        Me.grpRecording.Location = New System.Drawing.Point(537, 202)
        Me.grpRecording.Name = "grpRecording"
        Me.grpRecording.Size = New System.Drawing.Size(75, 89)
        Me.grpRecording.TabIndex = 6
        Me.grpRecording.TabStop = False
        Me.grpRecording.Text = "Recording"
        '
        'chkContinuous
        '
        Me.chkContinuous.AutoSize = True
        Me.chkContinuous.Location = New System.Drawing.Point(6, 68)
        Me.chkContinuous.Name = "chkContinuous"
        Me.chkContinuous.Size = New System.Drawing.Size(68, 17)
        Me.chkContinuous.TabIndex = 7
        Me.chkContinuous.Text = "Continue"
        Me.chkContinuous.UseVisualStyleBackColor = True
        '
        'chkRecording
        '
        Me.chkRecording.AutoSize = True
        Me.chkRecording.Location = New System.Drawing.Point(6, 19)
        Me.chkRecording.Name = "chkRecording"
        Me.chkRecording.Size = New System.Drawing.Size(15, 14)
        Me.chkRecording.TabIndex = 6
        Me.chkRecording.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(624, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DisplayToolStripMenuItem, Me.OptionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDataFileToolStripMenuItem, Me.SaveDataFileToolStripMenuItem, Me.ToolStripMenuItem2, Me.PrintSetupToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripMenuItem3, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenDataFileToolStripMenuItem
        '
        Me.OpenDataFileToolStripMenuItem.Name = "OpenDataFileToolStripMenuItem"
        Me.OpenDataFileToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.OpenDataFileToolStripMenuItem.Text = "Open Data File"
        '
        'SaveDataFileToolStripMenuItem
        '
        Me.SaveDataFileToolStripMenuItem.Name = "SaveDataFileToolStripMenuItem"
        Me.SaveDataFileToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SaveDataFileToolStripMenuItem.Text = "Save Data File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(148, 6)
        '
        'PrintSetupToolStripMenuItem
        '
        Me.PrintSetupToolStripMenuItem.Name = "PrintSetupToolStripMenuItem"
        Me.PrintSetupToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PrintSetupToolStripMenuItem.Text = "Print Setup"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintListToolStripMenuItem, Me.PrintGraphToolStripMenuItem})
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintListToolStripMenuItem
        '
        Me.PrintListToolStripMenuItem.Name = "PrintListToolStripMenuItem"
        Me.PrintListToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.PrintListToolStripMenuItem.Text = "List"
        '
        'PrintGraphToolStripMenuItem
        '
        Me.PrintGraphToolStripMenuItem.Name = "PrintGraphToolStripMenuItem"
        Me.PrintGraphToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.PrintGraphToolStripMenuItem.Text = "Graph"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(148, 6)
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'DisplayToolStripMenuItem
        '
        Me.DisplayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DigitalToolStripMenuItem, Me.AnalogToolStripMenuItem, Me.ToolStripMenuItem1, Me.ListToolStripMenuItem, Me.GraphToolStripMenuItem})
        Me.DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem"
        Me.DisplayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.DisplayToolStripMenuItem.Text = "Display"
        '
        'DigitalToolStripMenuItem
        '
        Me.DigitalToolStripMenuItem.Name = "DigitalToolStripMenuItem"
        Me.DigitalToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DigitalToolStripMenuItem.Text = "Digital"
        '
        'AnalogToolStripMenuItem
        '
        Me.AnalogToolStripMenuItem.Name = "AnalogToolStripMenuItem"
        Me.AnalogToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.AnalogToolStripMenuItem.Text = "Analog"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(109, 6)
        '
        'ListToolStripMenuItem
        '
        Me.ListToolStripMenuItem.Name = "ListToolStripMenuItem"
        Me.ListToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ListToolStripMenuItem.Text = "List"
        '
        'GraphToolStripMenuItem
        '
        Me.GraphToolStripMenuItem.Name = "GraphToolStripMenuItem"
        Me.GraphToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.GraphToolStripMenuItem.Text = "Graph"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMPortToolStripMenuItem, Me.ConfigureToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "Option"
        '
        'COMPortToolStripMenuItem
        '
        Me.COMPortToolStripMenuItem.Name = "COMPortToolStripMenuItem"
        Me.COMPortToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.COMPortToolStripMenuItem.Text = "COM Port"
        '
        'ConfigureToolStripMenuItem
        '
        Me.ConfigureToolStripMenuItem.Name = "ConfigureToolStripMenuItem"
        Me.ConfigureToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ConfigureToolStripMenuItem.Text = "Configure"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 380)
        Me.Panel1.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Info
        Me.Panel3.Location = New System.Drawing.Point(10, 174)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(500, 195)
        Me.Panel3.TabIndex = 1
        '
        'txtTerminal
        '
        Me.txtTerminal.Location = New System.Drawing.Point(543, 360)
        Me.txtTerminal.Multiline = True
        Me.txtTerminal.Name = "txtTerminal"
        Me.txtTerminal.Size = New System.Drawing.Size(69, 48)
        Me.txtTerminal.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.Panel2.Controls.Add(Me.lblhFE)
        Me.Panel2.Controls.Add(Me.lblDegreeC)
        Me.Panel2.Controls.Add(Me.lblDutyCycle)
        Me.Panel2.Controls.Add(Me.lblMilli)
        Me.Panel2.Controls.Add(Me.lblMega)
        Me.Panel2.Controls.Add(Me.lblNano)
        Me.Panel2.Controls.Add(Me.lblMicro)
        Me.Panel2.Controls.Add(Me.lblKilo)
        Me.Panel2.Controls.Add(Me.lblOhms)
        Me.Panel2.Controls.Add(Me.lblFarads)
        Me.Panel2.Controls.Add(Me.lblAmps)
        Me.Panel2.Controls.Add(Me.lblVolts)
        Me.Panel2.Controls.Add(Me.lblDC)
        Me.Panel2.Controls.Add(Me.lblDiode)
        Me.Panel2.Controls.Add(Me.lblSound)
        Me.Panel2.Controls.Add(Me.lblBattery)
        Me.Panel2.Controls.Add(Me.lblRelDelta)
        Me.Panel2.Controls.Add(Me.lblHertz)
        Me.Panel2.Controls.Add(Me.lblHold)
        Me.Panel2.Controls.Add(Me.lblDigitalDisplay)
        Me.Panel2.Controls.Add(Me.lblRS232)
        Me.Panel2.Controls.Add(Me.lblAC)
        Me.Panel2.Controls.Add(Me.lblAuto)
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 158)
        Me.Panel2.TabIndex = 0
        '
        'lblhFE
        '
        Me.lblhFE.AutoSize = True
        Me.lblhFE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhFE.Location = New System.Drawing.Point(451, 4)
        Me.lblhFE.Name = "lblhFE"
        Me.lblhFE.Size = New System.Drawing.Size(42, 20)
        Me.lblhFE.TabIndex = 30
        Me.lblhFE.Text = "hFE"
        Me.lblhFE.Visible = False
        '
        'lblDegreeC
        '
        Me.lblDegreeC.AutoSize = True
        Me.lblDegreeC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegreeC.Location = New System.Drawing.Point(392, 77)
        Me.lblDegreeC.Name = "lblDegreeC"
        Me.lblDegreeC.Size = New System.Drawing.Size(27, 20)
        Me.lblDegreeC.TabIndex = 29
        Me.lblDegreeC.Text = "C°"
        '
        'lblDutyCycle
        '
        Me.lblDutyCycle.AutoSize = True
        Me.lblDutyCycle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDutyCycle.Location = New System.Drawing.Point(396, 77)
        Me.lblDutyCycle.Name = "lblDutyCycle"
        Me.lblDutyCycle.Size = New System.Drawing.Size(24, 20)
        Me.lblDutyCycle.TabIndex = 28
        Me.lblDutyCycle.Text = "%"
        '
        'lblMilli
        '
        Me.lblMilli.AutoSize = True
        Me.lblMilli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilli.Location = New System.Drawing.Point(392, 97)
        Me.lblMilli.Name = "lblMilli"
        Me.lblMilli.Size = New System.Drawing.Size(23, 20)
        Me.lblMilli.TabIndex = 27
        Me.lblMilli.Text = "m"
        '
        'lblMega
        '
        Me.lblMega.AutoSize = True
        Me.lblMega.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMega.Location = New System.Drawing.Point(392, 57)
        Me.lblMega.Name = "lblMega"
        Me.lblMega.Size = New System.Drawing.Size(23, 20)
        Me.lblMega.TabIndex = 26
        Me.lblMega.Text = "M"
        '
        'lblNano
        '
        Me.lblNano.AutoSize = True
        Me.lblNano.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNano.Location = New System.Drawing.Point(396, 97)
        Me.lblNano.Name = "lblNano"
        Me.lblNano.Size = New System.Drawing.Size(19, 20)
        Me.lblNano.TabIndex = 25
        Me.lblNano.Text = "n"
        '
        'lblMicro
        '
        Me.lblMicro.AutoSize = True
        Me.lblMicro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMicro.Location = New System.Drawing.Point(392, 97)
        Me.lblMicro.Name = "lblMicro"
        Me.lblMicro.Size = New System.Drawing.Size(19, 20)
        Me.lblMicro.TabIndex = 24
        Me.lblMicro.Text = "μ"
        '
        'lblKilo
        '
        Me.lblKilo.AutoSize = True
        Me.lblKilo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKilo.Location = New System.Drawing.Point(396, 57)
        Me.lblKilo.Name = "lblKilo"
        Me.lblKilo.Size = New System.Drawing.Size(18, 20)
        Me.lblKilo.TabIndex = 23
        Me.lblKilo.Text = "k"
        '
        'lblOhms
        '
        Me.lblOhms.AutoSize = True
        Me.lblOhms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOhms.Location = New System.Drawing.Point(417, 57)
        Me.lblOhms.Name = "lblOhms"
        Me.lblOhms.Size = New System.Drawing.Size(22, 20)
        Me.lblOhms.TabIndex = 22
        Me.lblOhms.Text = "Ω"
        '
        'lblFarads
        '
        Me.lblFarads.AutoSize = True
        Me.lblFarads.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFarads.Location = New System.Drawing.Point(417, 97)
        Me.lblFarads.Name = "lblFarads"
        Me.lblFarads.Size = New System.Drawing.Size(20, 20)
        Me.lblFarads.TabIndex = 21
        Me.lblFarads.Text = "F"
        '
        'lblAmps
        '
        Me.lblAmps.AutoSize = True
        Me.lblAmps.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmps.Location = New System.Drawing.Point(417, 97)
        Me.lblAmps.Name = "lblAmps"
        Me.lblAmps.Size = New System.Drawing.Size(21, 20)
        Me.lblAmps.TabIndex = 20
        Me.lblAmps.Text = "A"
        '
        'lblVolts
        '
        Me.lblVolts.AutoSize = True
        Me.lblVolts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolts.Location = New System.Drawing.Point(417, 97)
        Me.lblVolts.Name = "lblVolts"
        Me.lblVolts.Size = New System.Drawing.Size(21, 20)
        Me.lblVolts.TabIndex = 19
        Me.lblVolts.Text = "V"
        '
        'lblDC
        '
        Me.lblDC.AutoSize = True
        Me.lblDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDC.Location = New System.Drawing.Point(10, 51)
        Me.lblDC.Name = "lblDC"
        Me.lblDC.Size = New System.Drawing.Size(34, 20)
        Me.lblDC.TabIndex = 18
        Me.lblDC.Text = "DC"
        '
        'lblDiode
        '
        Me.lblDiode.AutoSize = True
        Me.lblDiode.Image = CType(resources.GetObject("lblDiode.Image"), System.Drawing.Image)
        Me.lblDiode.Location = New System.Drawing.Point(348, 9)
        Me.lblDiode.MaximumSize = New System.Drawing.Size(16, 16)
        Me.lblDiode.MinimumSize = New System.Drawing.Size(16, 16)
        Me.lblDiode.Name = "lblDiode"
        Me.lblDiode.Size = New System.Drawing.Size(16, 16)
        Me.lblDiode.TabIndex = 17
        '
        'lblSound
        '
        Me.lblSound.AutoSize = True
        Me.lblSound.Image = CType(resources.GetObject("lblSound.Image"), System.Drawing.Image)
        Me.lblSound.Location = New System.Drawing.Point(370, 9)
        Me.lblSound.MaximumSize = New System.Drawing.Size(16, 16)
        Me.lblSound.MinimumSize = New System.Drawing.Size(16, 16)
        Me.lblSound.Name = "lblSound"
        Me.lblSound.Size = New System.Drawing.Size(16, 16)
        Me.lblSound.TabIndex = 16
        '
        'lblBattery
        '
        Me.lblBattery.AutoSize = True
        Me.lblBattery.Image = CType(resources.GetObject("lblBattery.Image"), System.Drawing.Image)
        Me.lblBattery.Location = New System.Drawing.Point(11, 10)
        Me.lblBattery.MaximumSize = New System.Drawing.Size(16, 16)
        Me.lblBattery.MinimumSize = New System.Drawing.Size(16, 16)
        Me.lblBattery.Name = "lblBattery"
        Me.lblBattery.Size = New System.Drawing.Size(16, 16)
        Me.lblBattery.TabIndex = 15
        '
        'lblRelDelta
        '
        Me.lblRelDelta.AutoSize = True
        Me.lblRelDelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRelDelta.Location = New System.Drawing.Point(392, 5)
        Me.lblRelDelta.Name = "lblRelDelta"
        Me.lblRelDelta.Size = New System.Drawing.Size(53, 20)
        Me.lblRelDelta.TabIndex = 13
        Me.lblRelDelta.Text = "Rel ∆"
        '
        'lblHertz
        '
        Me.lblHertz.AutoSize = True
        Me.lblHertz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHertz.Location = New System.Drawing.Point(420, 57)
        Me.lblHertz.Name = "lblHertz"
        Me.lblHertz.Size = New System.Drawing.Size(31, 20)
        Me.lblHertz.TabIndex = 6
        Me.lblHertz.Text = "Hz"
        '
        'lblHold
        '
        Me.lblHold.AutoSize = True
        Me.lblHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHold.Location = New System.Drawing.Point(296, 4)
        Me.lblHold.Name = "lblHold"
        Me.lblHold.Size = New System.Drawing.Size(46, 20)
        Me.lblHold.TabIndex = 5
        Me.lblHold.Text = "Hold"
        '
        'lblDigitalDisplay
        '
        Me.lblDigitalDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigitalDisplay.Location = New System.Drawing.Point(39, 34)
        Me.lblDigitalDisplay.Name = "lblDigitalDisplay"
        Me.lblDigitalDisplay.Size = New System.Drawing.Size(378, 108)
        Me.lblDigitalDisplay.TabIndex = 4
        Me.lblDigitalDisplay.Text = "-8.8.8.8"
        Me.lblDigitalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRS232
        '
        Me.lblRS232.AutoSize = True
        Me.lblRS232.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRS232.Location = New System.Drawing.Point(43, 10)
        Me.lblRS232.Name = "lblRS232"
        Me.lblRS232.Size = New System.Drawing.Size(64, 20)
        Me.lblRS232.TabIndex = 3
        Me.lblRS232.Text = "RS232"
        '
        'lblAC
        '
        Me.lblAC.AutoSize = True
        Me.lblAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAC.Location = New System.Drawing.Point(10, 30)
        Me.lblAC.Name = "lblAC"
        Me.lblAC.Size = New System.Drawing.Size(33, 20)
        Me.lblAC.TabIndex = 2
        Me.lblAC.Text = "AC"
        '
        'lblAuto
        '
        Me.lblAuto.AutoSize = True
        Me.lblAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuto.Location = New System.Drawing.Point(110, 10)
        Me.lblAuto.Name = "lblAuto"
        Me.lblAuto.Size = New System.Drawing.Size(47, 20)
        Me.lblAuto.TabIndex = 0
        Me.lblAuto.Text = "Auto"
        '
        'bkgdWorkerSerial
        '
        Me.bkgdWorkerSerial.WorkerReportsProgress = True
        Me.bkgdWorkerSerial.WorkerSupportsCancellation = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.txtTerminal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.grpRecording)
        Me.Controls.Add(Me.btnGraph)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnAnalog)
        Me.Controls.Add(Me.btnDigital)
        Me.Controls.Add(Me.btnBeginStop)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "DigitalMultiMeter"
        Me.grpRecording.ResumeLayout(False)
        Me.grpRecording.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBeginStop As System.Windows.Forms.Button
    Friend WithEvents btnDigital As System.Windows.Forms.Button
    Friend WithEvents btnAnalog As System.Windows.Forms.Button
    Friend WithEvents btnList As System.Windows.Forms.Button
    Friend WithEvents btnGraph As System.Windows.Forms.Button
    Friend WithEvents btnRecordOne As System.Windows.Forms.Button
    Friend WithEvents grpRecording As System.Windows.Forms.GroupBox
    Friend WithEvents chkContinuous As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecording As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COMPortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDataFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveDataFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintGraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DigitalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnalogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblAuto As System.Windows.Forms.Label
    Friend WithEvents lblAC As System.Windows.Forms.Label
    Friend WithEvents lblRelDelta As System.Windows.Forms.Label
    Friend WithEvents lblHertz As System.Windows.Forms.Label
    Friend WithEvents lblHold As System.Windows.Forms.Label
    Friend WithEvents lblDigitalDisplay As System.Windows.Forms.Label
    Friend WithEvents lblRS232 As System.Windows.Forms.Label
    Friend WithEvents lblDiode As System.Windows.Forms.Label
    Friend WithEvents lblSound As System.Windows.Forms.Label
    Friend WithEvents lblBattery As System.Windows.Forms.Label
    Friend WithEvents bkgdWorkerSerial As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtTerminal As System.Windows.Forms.TextBox
    Friend WithEvents lblDC As System.Windows.Forms.Label
    Friend WithEvents lblAmps As System.Windows.Forms.Label
    Friend WithEvents lblVolts As System.Windows.Forms.Label
    Friend WithEvents lblFarads As System.Windows.Forms.Label
    Friend WithEvents lblOhms As System.Windows.Forms.Label
    Friend WithEvents lblNano As System.Windows.Forms.Label
    Friend WithEvents lblMicro As System.Windows.Forms.Label
    Friend WithEvents lblKilo As System.Windows.Forms.Label
    Friend WithEvents lblMega As System.Windows.Forms.Label
    Friend WithEvents lblDutyCycle As System.Windows.Forms.Label
    Friend WithEvents lblMilli As System.Windows.Forms.Label
    Friend WithEvents lblDegreeC As System.Windows.Forms.Label
    Friend WithEvents lblhFE As System.Windows.Forms.Label

End Class
