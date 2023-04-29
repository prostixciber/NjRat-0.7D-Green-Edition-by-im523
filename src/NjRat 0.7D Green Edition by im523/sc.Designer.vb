Namespace NJRAT
	' Token: 0x02000024 RID: 36
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class sc
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060004D3 RID: 1235 RVA: 0x00170DEC File Offset: 0x0016F1EC
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

		' Token: 0x060004D4 RID: 1236 RVA: 0x00170E3C File Offset: 0x0016F23C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.sc))
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.CheckBox1 = New Global.System.Windows.Forms.CheckBox()
			Me.CheckBox2 = New Global.System.Windows.Forms.CheckBox()
			Me.CheckBox3 = New Global.System.Windows.Forms.CheckBox()
			Me.vmethod_16 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.vmethod_12 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.p = New Global.System.Windows.Forms.PictureBox()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Panel1.SuspendLayout()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.Label1)
			Me.Panel1.Controls.Add(Me.ComboBox1)
			Me.Panel1.Controls.Add(Me.CheckBox1)
			Me.Panel1.Controls.Add(Me.CheckBox2)
			Me.Panel1.Controls.Add(Me.CheckBox3)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(424, 27)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(2, 1)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(75, 22)
			button2.Size = size
			Me.Button1.TabIndex = 5
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(82, 5)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(30, 14)
			label2.Size = size
			Me.Label1.TabIndex = 4
			Me.Label1.Text = "Size"
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(116, 2)
			comboBox.Location = location
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(78, 21)
			comboBox2.Size = size
			Me.ComboBox1.TabIndex = 3
			Me.CheckBox1.AutoSize = True
			Me.CheckBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CheckBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim checkBox As Global.System.Windows.Forms.Control = Me.CheckBox1
			location = New Global.System.Drawing.Point(197, 2)
			checkBox.Location = location
			Me.CheckBox1.Name = "CheckBox1"
			Dim checkBox2 As Global.System.Windows.Forms.Control = Me.CheckBox1
			size = New Global.System.Drawing.Size(55, 17)
			checkBox2.Size = size
			Me.CheckBox1.TabIndex = 2
			Me.CheckBox1.Text = "Mouse"
			Me.CheckBox1.UseVisualStyleBackColor = True
			Me.CheckBox2.AutoSize = True
			Me.CheckBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CheckBox2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim checkBox3 As Global.System.Windows.Forms.Control = Me.CheckBox2
			location = New Global.System.Drawing.Point(255, 2)
			checkBox3.Location = location
			Me.CheckBox2.Name = "CheckBox2"
			Dim checkBox4 As Global.System.Windows.Forms.Control = Me.CheckBox2
			size = New Global.System.Drawing.Size(68, 17)
			checkBox4.Size = size
			Me.CheckBox2.TabIndex = 1
			Me.CheckBox2.Text = "Keyboard"
			Me.CheckBox2.UseVisualStyleBackColor = True
			Me.CheckBox3.AutoSize = True
			Me.CheckBox3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CheckBox3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim checkBox5 As Global.System.Windows.Forms.Control = Me.CheckBox3
			location = New Global.System.Drawing.Point(329, 2)
			checkBox5.Location = location
			Me.CheckBox3.Name = "CheckBox3"
			Dim checkBox6 As Global.System.Windows.Forms.Control = Me.CheckBox3
			size = New Global.System.Drawing.Size(70, 17)
			checkBox6.Size = size
			Me.CheckBox3.TabIndex = 0
			Me.CheckBox3.Text = "AutoSave"
			Me.CheckBox3.UseVisualStyleBackColor = True
			Me.vmethod_16.Enabled = True
			Me.vmethod_16.Interval = 10
			Me.vmethod_12.Enabled = True
			Me.vmethod_12.Interval = 1000
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			location = New Global.System.Drawing.Point(0, 246)
			progressBar.Location = location
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(424, 9)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 1
			Me.p.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim p As Global.System.Windows.Forms.Control = Me.p
			location = New Global.System.Drawing.Point(0, 27)
			p.Location = location
			Me.p.Name = "p"
			Dim p2 As Global.System.Windows.Forms.Control = Me.p
			size = New Global.System.Drawing.Size(424, 228)
			p2.Size = size
			Me.p.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.p.TabIndex = 2
			Me.p.TabStop = False
			Me.Button2.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.Button2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(209, 27)
			button3.Location = location
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(10, 12)
			button4.Size = size
			Me.Button2.TabIndex = 3
			Me.Button2.UseVisualStyleBackColor = False
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(424, 255)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.p)
			Me.Controls.Add(Me.Panel1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "sc"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "sc"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400023A RID: 570
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
