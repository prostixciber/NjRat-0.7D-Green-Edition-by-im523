Namespace NJRAT
	' Token: 0x0200000F RID: 15
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Dos
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000129 RID: 297 RVA: 0x00150B34 File Offset: 0x0014EF34
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

		' Token: 0x0600012A RID: 298 RVA: 0x00150B84 File Offset: 0x0014EF84
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Dos))
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.ClearLogsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Logs = New Global.NJRAT.LV()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.TextBox3 = New Global.System.Windows.Forms.TextBox()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.ContextMenuStrip1.SuspendLayout()
			Me.Panel1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Button1.Enabled = False
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(110, 234)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(416, 25)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Start Flood"
			Me.Button1.UseVisualStyleBackColor = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(111, 27)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(195, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 1
			Me.TextBox1.Text = "127.0.0.1"
			Me.TextBox2.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox2
			location = New Global.System.Drawing.Point(375, 27)
			textBox3.Location = location
			Me.TextBox2.Name = "TextBox2"
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox2
			size = New Global.System.Drawing.Size(65, 20)
			textBox4.Size = size
			Me.TextBox2.TabIndex = 2
			Me.TextBox2.Text = "80"
			Me.Label1.AutoSize = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(107, 10)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(48, 14)
			label2.Size = size
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "Target :"
			Me.Label2.AutoSize = True
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(372, 10)
			label3.Location = location
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(36, 14)
			label4.Size = size
			Me.Label2.TabIndex = 4
			Me.Label2.Text = "Port :"
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.Font = New Global.System.Drawing.Font("Arial", 7F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(312, 27)
			button3.Location = location
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(57, 20)
			button4.Size = size
			Me.Button2.TabIndex = 5
			Me.Button2.Text = "Lock On"
			Me.Button2.UseVisualStyleBackColor = True
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ClearLogsToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Me.ContextMenuStrip1.ShowImageMargin = False
			Dim contextMenuStrip As Global.System.Windows.Forms.Control = Me.ContextMenuStrip1
			size = New Global.System.Drawing.Size(79, 26)
			contextMenuStrip.Size = size
			Me.ClearLogsToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.ClearLogsToolStripMenuItem.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.ClearLogsToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.ClearLogsToolStripMenuItem.Name = "ClearLogsToolStripMenuItem"
			Dim clearLogsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ClearLogsToolStripMenuItem
			size = New Global.System.Drawing.Size(78, 22)
			clearLogsToolStripMenuItem.Size = size
			Me.ClearLogsToolStripMenuItem.Text = "Clear"
			Me.Panel1.BackColor = Global.System.Drawing.Color.Black
			Me.Panel1.Controls.Add(Me.Logs)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(111, 102)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(415, 126)
			panel2.Size = size
			Me.Panel1.TabIndex = 7
			Me.Logs.BackColor = Global.System.Drawing.Color.Black
			Me.Logs.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1 })
			Me.Logs.ContextMenuStrip = Me.ContextMenuStrip1
			Me.Logs.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Logs.Font = New Global.System.Drawing.Font("Arial", 7F, Global.System.Drawing.FontStyle.Bold)
			Me.Logs.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.Logs.FullRowSelect = True
			Me.Logs.HeaderStyle = Global.System.Windows.Forms.ColumnHeaderStyle.None
			Dim logs As Global.System.Windows.Forms.Control = Me.Logs
			location = New Global.System.Drawing.Point(0, 0)
			logs.Location = location
			Me.Logs.Name = "Logs"
			Dim logs2 As Global.System.Windows.Forms.Control = Me.Logs
			size = New Global.System.Drawing.Size(415, 126)
			logs2.Size = size
			Me.Logs.TabIndex = 6
			Me.Logs.UseCompatibleStateImageBehavior = False
			Me.Logs.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader1.Width = 300
			Me.Label3.AutoSize = True
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(108, 85)
			label5.Location = location
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(41, 14)
			label6.Size = size
			Me.Label3.TabIndex = 8
			Me.Label3.Text = "Logs :"
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "Full!!!", "VHigh", "High", "Medium", "Slow", "VSlow" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(446, 26)
			comboBox.Location = location
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(80, 22)
			comboBox2.Size = size
			Me.ComboBox1.TabIndex = 9
			Me.ComboBox1.Text = "Medium"
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			location = New Global.System.Drawing.Point(-4, -2)
			pictureBox.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(109, 282)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 19
			Me.PictureBox1.TabStop = False
			Me.TextBox3.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox3.Font = New Global.System.Drawing.Font("Arial", 15F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox5 As Global.System.Windows.Forms.Control = Me.TextBox3
			location = New Global.System.Drawing.Point(111, 53)
			textBox5.Location = location
			Me.TextBox3.Multiline = True
			Me.TextBox3.Name = "TextBox3"
			Dim textBox6 As Global.System.Windows.Forms.Control = Me.TextBox3
			size = New Global.System.Drawing.Size(415, 29)
			textBox6.Size = size
			Me.TextBox3.TabIndex = 20
			Me.TextBox3.Text = "NONE!"
			Me.TextBox3.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Label4.AutoSize = True
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(443, 10)
			label7.Location = location
			Me.Label4.Name = "Label4"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(39, 14)
			label8.Size = size
			Me.Label4.TabIndex = 21
			Me.Label4.Text = "Preq :"
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 14F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(536, 267)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label4)
			Me.Controls.Add(Me.TextBox3)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.ComboBox1)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Button1)
			Me.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			size = New Global.System.Drawing.Size(552, 306)
			Me.MaximumSize = size
			size = New Global.System.Drawing.Size(552, 306)
			Me.MinimumSize = size
			Me.Name = "Dos"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Form2"
			Me.ContextMenuStrip1.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400008C RID: 140
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
