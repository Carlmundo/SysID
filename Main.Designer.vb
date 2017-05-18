<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.tblSpec = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRAM_Extra = New System.Windows.Forms.Label()
        Me.hdRAM = New System.Windows.Forms.Label()
        Me.lblRAM = New System.Windows.Forms.Label()
        Me.hdManufacturer = New System.Windows.Forms.Label()
        Me.hdProcessor = New System.Windows.Forms.Label()
        Me.hdOffice = New System.Windows.Forms.Label()
        Me.lblOS = New System.Windows.Forms.Label()
        Me.hdOS = New System.Windows.Forms.Label()
        Me.lblProcessor = New System.Windows.Forms.Label()
        Me.hdOpticalDrive = New System.Windows.Forms.Label()
        Me.hdGraphicsCard = New System.Windows.Forms.Label()
        Me.lblGraphicsCard = New System.Windows.Forms.Label()
        Me.hdTotalSpace = New System.Windows.Forms.Label()
        Me.lblTotalSpace = New System.Windows.Forms.Label()
        Me.hdModel = New System.Windows.Forms.Label()
        Me.hdFreeSpace = New System.Windows.Forms.Label()
        Me.lblFreeSpace = New System.Windows.Forms.Label()
        Me.flwModel = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblOpticalDrive = New System.Windows.Forms.Label()
        Me.lblOffice = New System.Windows.Forms.Label()
        Me.flwManufacturer = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.cbRAM_Extra = New System.Windows.Forms.CheckBox()
        Me.tblDesign = New System.Windows.Forms.TableLayoutPanel()
        Me.flwButtons = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblSpec.SuspendLayout()
        Me.flwModel.SuspendLayout()
        Me.flwManufacturer.SuspendLayout()
        Me.tblDesign.SuspendLayout()
        Me.flwButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox5)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(47, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(110, 110)
        Me.FlowLayoutPanel1.TabIndex = 35
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox5.Image = Global.SysID.My.Resources.Resources.icon_RAM
        Me.PictureBox5.InitialImage = Nothing
        Me.PictureBox5.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'tblSpec
        '
        Me.tblSpec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tblSpec.AutoSize = True
        Me.tblSpec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tblSpec.BackColor = System.Drawing.Color.Transparent
        Me.tblSpec.ColumnCount = 2
        Me.tblSpec.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSpec.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblSpec.Controls.Add(Me.lblRAM_Extra, 1, 5)
        Me.tblSpec.Controls.Add(Me.hdRAM, 0, 4)
        Me.tblSpec.Controls.Add(Me.lblRAM, 1, 4)
        Me.tblSpec.Controls.Add(Me.hdManufacturer, 0, 0)
        Me.tblSpec.Controls.Add(Me.hdProcessor, 0, 3)
        Me.tblSpec.Controls.Add(Me.hdOffice, 0, 8)
        Me.tblSpec.Controls.Add(Me.lblOS, 1, 2)
        Me.tblSpec.Controls.Add(Me.hdOS, 0, 2)
        Me.tblSpec.Controls.Add(Me.lblProcessor, 1, 3)
        Me.tblSpec.Controls.Add(Me.hdOpticalDrive, 0, 6)
        Me.tblSpec.Controls.Add(Me.hdGraphicsCard, 0, 7)
        Me.tblSpec.Controls.Add(Me.lblGraphicsCard, 1, 7)
        Me.tblSpec.Controls.Add(Me.hdTotalSpace, 0, 10)
        Me.tblSpec.Controls.Add(Me.lblTotalSpace, 1, 10)
        Me.tblSpec.Controls.Add(Me.hdModel, 0, 1)
        Me.tblSpec.Controls.Add(Me.hdFreeSpace, 0, 9)
        Me.tblSpec.Controls.Add(Me.lblFreeSpace, 1, 9)
        Me.tblSpec.Controls.Add(Me.flwModel, 1, 1)
        Me.tblSpec.Controls.Add(Me.lblOpticalDrive, 1, 6)
        Me.tblSpec.Controls.Add(Me.lblOffice, 1, 8)
        Me.tblSpec.Controls.Add(Me.flwManufacturer, 1, 0)
        Me.tblSpec.Controls.Add(Me.cbRAM_Extra, 0, 5)
        Me.tblSpec.Location = New System.Drawing.Point(15, 118)
        Me.tblSpec.Margin = New System.Windows.Forms.Padding(2)
        Me.tblSpec.Name = "tblSpec"
        Me.tblSpec.RowCount = 11
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblSpec.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tblSpec.Size = New System.Drawing.Size(173, 297)
        Me.tblSpec.TabIndex = 36
        '
        'lblRAM_Extra
        '
        Me.lblRAM_Extra.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRAM_Extra.AutoSize = True
        Me.lblRAM_Extra.BackColor = System.Drawing.Color.Transparent
        Me.lblRAM_Extra.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRAM_Extra.Location = New System.Drawing.Point(147, 135)
        Me.lblRAM_Extra.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRAM_Extra.Name = "lblRAM_Extra"
        Me.lblRAM_Extra.Padding = New System.Windows.Forms.Padding(3)
        Me.lblRAM_Extra.Size = New System.Drawing.Size(24, 26)
        Me.lblRAM_Extra.TabIndex = 58
        Me.lblRAM_Extra.Text = "..."
        Me.lblRAM_Extra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRAM_Extra.Visible = False
        '
        'hdRAM
        '
        Me.hdRAM.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hdRAM.AutoSize = True
        Me.hdRAM.BackColor = System.Drawing.Color.Transparent
        Me.hdRAM.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdRAM.Location = New System.Drawing.Point(95, 108)
        Me.hdRAM.Margin = New System.Windows.Forms.Padding(0)
        Me.hdRAM.Name = "hdRAM"
        Me.hdRAM.Padding = New System.Windows.Forms.Padding(3)
        Me.hdRAM.Size = New System.Drawing.Size(52, 27)
        Me.hdRAM.TabIndex = 56
        Me.hdRAM.Text = "RAM"
        Me.hdRAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRAM
        '
        Me.lblRAM.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRAM.AutoSize = True
        Me.lblRAM.BackColor = System.Drawing.Color.Transparent
        Me.lblRAM.Location = New System.Drawing.Point(147, 108)
        Me.lblRAM.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRAM.Name = "lblRAM"
        Me.lblRAM.Padding = New System.Windows.Forms.Padding(3)
        Me.lblRAM.Size = New System.Drawing.Size(25, 27)
        Me.lblRAM.TabIndex = 55
        Me.lblRAM.Text = "..."
        Me.lblRAM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'hdManufacturer
        '
        Me.hdManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hdManufacturer.AutoSize = True
        Me.hdManufacturer.BackColor = System.Drawing.Color.Transparent
        Me.hdManufacturer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdManufacturer.Location = New System.Drawing.Point(32, 0)
        Me.hdManufacturer.Margin = New System.Windows.Forms.Padding(0)
        Me.hdManufacturer.Name = "hdManufacturer"
        Me.hdManufacturer.Padding = New System.Windows.Forms.Padding(3)
        Me.hdManufacturer.Size = New System.Drawing.Size(115, 27)
        Me.hdManufacturer.TabIndex = 39
        Me.hdManufacturer.Text = "Manufacturer"
        Me.hdManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdProcessor
        '
        Me.hdProcessor.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hdProcessor.AutoSize = True
        Me.hdProcessor.BackColor = System.Drawing.Color.Transparent
        Me.hdProcessor.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdProcessor.Location = New System.Drawing.Point(59, 81)
        Me.hdProcessor.Margin = New System.Windows.Forms.Padding(0)
        Me.hdProcessor.Name = "hdProcessor"
        Me.hdProcessor.Padding = New System.Windows.Forms.Padding(3)
        Me.hdProcessor.Size = New System.Drawing.Size(88, 27)
        Me.hdProcessor.TabIndex = 22
        Me.hdProcessor.Text = "Processor"
        Me.hdProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdOffice
        '
        Me.hdOffice.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hdOffice.AutoSize = True
        Me.hdOffice.BackColor = System.Drawing.Color.Transparent
        Me.hdOffice.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdOffice.Location = New System.Drawing.Point(10, 216)
        Me.hdOffice.Margin = New System.Windows.Forms.Padding(0)
        Me.hdOffice.Name = "hdOffice"
        Me.hdOffice.Padding = New System.Windows.Forms.Padding(3)
        Me.hdOffice.Size = New System.Drawing.Size(137, 27)
        Me.hdOffice.TabIndex = 26
        Me.hdOffice.Text = "Microsoft Office"
        Me.hdOffice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOS
        '
        Me.lblOS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOS.AutoSize = True
        Me.lblOS.BackColor = System.Drawing.Color.Transparent
        Me.lblOS.Location = New System.Drawing.Point(147, 54)
        Me.lblOS.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Padding = New System.Windows.Forms.Padding(3)
        Me.lblOS.Size = New System.Drawing.Size(25, 27)
        Me.lblOS.TabIndex = 10
        Me.lblOS.Text = "..."
        Me.lblOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdOS
        '
        Me.hdOS.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hdOS.AutoSize = True
        Me.hdOS.BackColor = System.Drawing.Color.Transparent
        Me.hdOS.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdOS.Location = New System.Drawing.Point(0, 54)
        Me.hdOS.Margin = New System.Windows.Forms.Padding(0)
        Me.hdOS.Name = "hdOS"
        Me.hdOS.Padding = New System.Windows.Forms.Padding(3)
        Me.hdOS.Size = New System.Drawing.Size(147, 27)
        Me.hdOS.TabIndex = 20
        Me.hdOS.Text = "Operating System"
        Me.hdOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProcessor
        '
        Me.lblProcessor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblProcessor.AutoSize = True
        Me.lblProcessor.BackColor = System.Drawing.Color.Transparent
        Me.lblProcessor.Location = New System.Drawing.Point(147, 81)
        Me.lblProcessor.Margin = New System.Windows.Forms.Padding(0)
        Me.lblProcessor.Name = "lblProcessor"
        Me.lblProcessor.Padding = New System.Windows.Forms.Padding(3)
        Me.lblProcessor.Size = New System.Drawing.Size(25, 27)
        Me.lblProcessor.TabIndex = 13
        Me.lblProcessor.Text = "..."
        Me.lblProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdOpticalDrive
        '
        Me.hdOpticalDrive.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hdOpticalDrive.AutoSize = True
        Me.hdOpticalDrive.BackColor = System.Drawing.Color.Transparent
        Me.hdOpticalDrive.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdOpticalDrive.Location = New System.Drawing.Point(37, 162)
        Me.hdOpticalDrive.Margin = New System.Windows.Forms.Padding(0)
        Me.hdOpticalDrive.Name = "hdOpticalDrive"
        Me.hdOpticalDrive.Padding = New System.Windows.Forms.Padding(3)
        Me.hdOpticalDrive.Size = New System.Drawing.Size(110, 27)
        Me.hdOpticalDrive.TabIndex = 27
        Me.hdOpticalDrive.Text = "Optical Drive"
        Me.hdOpticalDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdGraphicsCard
        '
        Me.hdGraphicsCard.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hdGraphicsCard.AutoSize = True
        Me.hdGraphicsCard.BackColor = System.Drawing.Color.Transparent
        Me.hdGraphicsCard.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdGraphicsCard.Location = New System.Drawing.Point(30, 189)
        Me.hdGraphicsCard.Margin = New System.Windows.Forms.Padding(0)
        Me.hdGraphicsCard.Name = "hdGraphicsCard"
        Me.hdGraphicsCard.Padding = New System.Windows.Forms.Padding(3)
        Me.hdGraphicsCard.Size = New System.Drawing.Size(117, 27)
        Me.hdGraphicsCard.TabIndex = 24
        Me.hdGraphicsCard.Text = "Graphics Card"
        Me.hdGraphicsCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGraphicsCard
        '
        Me.lblGraphicsCard.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblGraphicsCard.AutoSize = True
        Me.lblGraphicsCard.BackColor = System.Drawing.Color.Transparent
        Me.lblGraphicsCard.Location = New System.Drawing.Point(147, 189)
        Me.lblGraphicsCard.Margin = New System.Windows.Forms.Padding(0)
        Me.lblGraphicsCard.Name = "lblGraphicsCard"
        Me.lblGraphicsCard.Padding = New System.Windows.Forms.Padding(3)
        Me.lblGraphicsCard.Size = New System.Drawing.Size(25, 27)
        Me.lblGraphicsCard.TabIndex = 14
        Me.lblGraphicsCard.Text = "..."
        Me.lblGraphicsCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdTotalSpace
        '
        Me.hdTotalSpace.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hdTotalSpace.AutoSize = True
        Me.hdTotalSpace.BackColor = System.Drawing.Color.Transparent
        Me.hdTotalSpace.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdTotalSpace.Location = New System.Drawing.Point(48, 270)
        Me.hdTotalSpace.Margin = New System.Windows.Forms.Padding(0)
        Me.hdTotalSpace.Name = "hdTotalSpace"
        Me.hdTotalSpace.Padding = New System.Windows.Forms.Padding(3)
        Me.hdTotalSpace.Size = New System.Drawing.Size(99, 27)
        Me.hdTotalSpace.TabIndex = 31
        Me.hdTotalSpace.Text = "Total Space"
        Me.hdTotalSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSpace
        '
        Me.lblTotalSpace.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTotalSpace.AutoSize = True
        Me.lblTotalSpace.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalSpace.Location = New System.Drawing.Point(147, 270)
        Me.lblTotalSpace.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTotalSpace.Name = "lblTotalSpace"
        Me.lblTotalSpace.Padding = New System.Windows.Forms.Padding(3)
        Me.lblTotalSpace.Size = New System.Drawing.Size(25, 27)
        Me.lblTotalSpace.TabIndex = 30
        Me.lblTotalSpace.Text = "..."
        Me.lblTotalSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdModel
        '
        Me.hdModel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hdModel.AutoSize = True
        Me.hdModel.BackColor = System.Drawing.Color.Transparent
        Me.hdModel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdModel.Location = New System.Drawing.Point(83, 27)
        Me.hdModel.Margin = New System.Windows.Forms.Padding(0)
        Me.hdModel.Name = "hdModel"
        Me.hdModel.Padding = New System.Windows.Forms.Padding(3)
        Me.hdModel.Size = New System.Drawing.Size(64, 27)
        Me.hdModel.TabIndex = 45
        Me.hdModel.Text = "Model"
        Me.hdModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hdFreeSpace
        '
        Me.hdFreeSpace.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.hdFreeSpace.AutoSize = True
        Me.hdFreeSpace.BackColor = System.Drawing.Color.Transparent
        Me.hdFreeSpace.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdFreeSpace.Location = New System.Drawing.Point(51, 243)
        Me.hdFreeSpace.Margin = New System.Windows.Forms.Padding(0)
        Me.hdFreeSpace.Name = "hdFreeSpace"
        Me.hdFreeSpace.Padding = New System.Windows.Forms.Padding(3)
        Me.hdFreeSpace.Size = New System.Drawing.Size(96, 27)
        Me.hdFreeSpace.TabIndex = 28
        Me.hdFreeSpace.Text = "Free Space"
        Me.hdFreeSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFreeSpace
        '
        Me.lblFreeSpace.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFreeSpace.AutoSize = True
        Me.lblFreeSpace.BackColor = System.Drawing.Color.Transparent
        Me.lblFreeSpace.Location = New System.Drawing.Point(147, 243)
        Me.lblFreeSpace.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFreeSpace.Name = "lblFreeSpace"
        Me.lblFreeSpace.Padding = New System.Windows.Forms.Padding(3)
        Me.lblFreeSpace.Size = New System.Drawing.Size(25, 27)
        Me.lblFreeSpace.TabIndex = 44
        Me.lblFreeSpace.Text = "..."
        Me.lblFreeSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flwModel
        '
        Me.flwModel.AutoSize = True
        Me.flwModel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flwModel.Controls.Add(Me.lblModel)
        Me.flwModel.Location = New System.Drawing.Point(147, 27)
        Me.flwModel.Margin = New System.Windows.Forms.Padding(0)
        Me.flwModel.Name = "flwModel"
        Me.flwModel.Size = New System.Drawing.Size(26, 24)
        Me.flwModel.TabIndex = 47
        '
        'lblModel
        '
        Me.lblModel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblModel.AutoSize = True
        Me.lblModel.BackColor = System.Drawing.Color.Transparent
        Me.lblModel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(0, 0)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Padding = New System.Windows.Forms.Padding(3)
        Me.lblModel.Size = New System.Drawing.Size(26, 24)
        Me.lblModel.TabIndex = 46
        Me.lblModel.Text = "..."
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOpticalDrive
        '
        Me.lblOpticalDrive.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOpticalDrive.AutoSize = True
        Me.lblOpticalDrive.BackColor = System.Drawing.Color.Transparent
        Me.lblOpticalDrive.Location = New System.Drawing.Point(147, 162)
        Me.lblOpticalDrive.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOpticalDrive.Name = "lblOpticalDrive"
        Me.lblOpticalDrive.Padding = New System.Windows.Forms.Padding(3)
        Me.lblOpticalDrive.Size = New System.Drawing.Size(25, 27)
        Me.lblOpticalDrive.TabIndex = 48
        Me.lblOpticalDrive.Text = "..."
        Me.lblOpticalDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOffice
        '
        Me.lblOffice.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblOffice.AutoSize = True
        Me.lblOffice.BackColor = System.Drawing.Color.Transparent
        Me.lblOffice.Location = New System.Drawing.Point(147, 216)
        Me.lblOffice.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOffice.Name = "lblOffice"
        Me.lblOffice.Padding = New System.Windows.Forms.Padding(3)
        Me.lblOffice.Size = New System.Drawing.Size(25, 27)
        Me.lblOffice.TabIndex = 49
        Me.lblOffice.Text = "..."
        Me.lblOffice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flwManufacturer
        '
        Me.flwManufacturer.AutoSize = True
        Me.flwManufacturer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flwManufacturer.Controls.Add(Me.lblManufacturer)
        Me.flwManufacturer.Location = New System.Drawing.Point(147, 0)
        Me.flwManufacturer.Margin = New System.Windows.Forms.Padding(0)
        Me.flwManufacturer.Name = "flwManufacturer"
        Me.flwManufacturer.Size = New System.Drawing.Size(26, 24)
        Me.flwManufacturer.TabIndex = 50
        '
        'lblManufacturer
        '
        Me.lblManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.BackColor = System.Drawing.Color.Transparent
        Me.lblManufacturer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturer.Location = New System.Drawing.Point(0, 0)
        Me.lblManufacturer.Margin = New System.Windows.Forms.Padding(0)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Padding = New System.Windows.Forms.Padding(3)
        Me.lblManufacturer.Size = New System.Drawing.Size(26, 24)
        Me.lblManufacturer.TabIndex = 48
        Me.lblManufacturer.Text = "..."
        Me.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbRAM_Extra
        '
        Me.cbRAM_Extra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbRAM_Extra.AutoSize = True
        Me.cbRAM_Extra.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRAM_Extra.Location = New System.Drawing.Point(32, 138)
        Me.cbRAM_Extra.Name = "cbRAM_Extra"
        Me.cbRAM_Extra.Size = New System.Drawing.Size(112, 21)
        Me.cbRAM_Extra.TabIndex = 57
        Me.cbRAM_Extra.Text = "Additional Info"
        Me.cbRAM_Extra.UseVisualStyleBackColor = True
        '
        'tblDesign
        '
        Me.tblDesign.AutoSize = True
        Me.tblDesign.BackColor = System.Drawing.Color.Transparent
        Me.tblDesign.ColumnCount = 1
        Me.tblDesign.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblDesign.Controls.Add(Me.tblSpec, 0, 1)
        Me.tblDesign.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.tblDesign.Controls.Add(Me.flwButtons, 0, 3)
        Me.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblDesign.Location = New System.Drawing.Point(0, 0)
        Me.tblDesign.Name = "tblDesign"
        Me.tblDesign.RowCount = 5
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblDesign.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0!))
        Me.tblDesign.Size = New System.Drawing.Size(204, 472)
        Me.tblDesign.TabIndex = 37
        '
        'flwButtons
        '
        Me.flwButtons.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.flwButtons.AutoSize = True
        Me.flwButtons.Controls.Add(Me.cmdExport)
        Me.flwButtons.Location = New System.Drawing.Point(48, 420)
        Me.flwButtons.Name = "flwButtons"
        Me.flwButtons.Size = New System.Drawing.Size(107, 39)
        Me.flwButtons.TabIndex = 38
        Me.flwButtons.WrapContents = False
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdExport.AutoSize = True
        Me.cmdExport.Location = New System.Drawing.Point(3, 3)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(101, 33)
        Me.cmdExport.TabIndex = 39
        Me.cmdExport.Text = "Save"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(204, 472)
        Me.Controls.Add(Me.tblDesign)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SysID"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblSpec.ResumeLayout(False)
        Me.tblSpec.PerformLayout()
        Me.flwModel.ResumeLayout(False)
        Me.flwModel.PerformLayout()
        Me.flwManufacturer.ResumeLayout(False)
        Me.flwManufacturer.PerformLayout()
        Me.tblDesign.ResumeLayout(False)
        Me.tblDesign.PerformLayout()
        Me.flwButtons.ResumeLayout(False)
        Me.flwButtons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents tblSpec As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents hdOS As System.Windows.Forms.Label
    Friend WithEvents hdProcessor As System.Windows.Forms.Label
    Friend WithEvents hdOpticalDrive As System.Windows.Forms.Label
    Friend WithEvents lblTotalSpace As System.Windows.Forms.Label
    Friend WithEvents hdOffice As System.Windows.Forms.Label
    Friend WithEvents lblProcessor As System.Windows.Forms.Label
    Friend WithEvents hdTotalSpace As System.Windows.Forms.Label
    Friend WithEvents lblOS As System.Windows.Forms.Label
    Friend WithEvents hdGraphicsCard As System.Windows.Forms.Label
    Friend WithEvents hdFreeSpace As System.Windows.Forms.Label
    Friend WithEvents lblGraphicsCard As System.Windows.Forms.Label
    Friend WithEvents tblDesign As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents hdManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblFreeSpace As System.Windows.Forms.Label
    Friend WithEvents lblOpticalDrive As System.Windows.Forms.Label
    Friend WithEvents lblOffice As System.Windows.Forms.Label
    Friend WithEvents flwButtons As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents hdModel As System.Windows.Forms.Label
    Friend WithEvents flwModel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents flwManufacturer As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lblManufacturer As System.Windows.Forms.Label
    Friend WithEvents lblRAM As System.Windows.Forms.Label
    Friend WithEvents lblRAM_Extra As System.Windows.Forms.Label
    Friend WithEvents hdRAM As System.Windows.Forms.Label
    Friend WithEvents cbRAM_Extra As System.Windows.Forms.CheckBox

End Class
