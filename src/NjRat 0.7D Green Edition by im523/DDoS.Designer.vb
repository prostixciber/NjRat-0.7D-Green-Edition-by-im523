Namespace NJRAT
	' Token: 0x0200000A RID: 10
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class DDoS
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600005C RID: 92 RVA: 0x00149BA8 File Offset: 0x00147FA8
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

		' Token: 0x0600005D RID: 93 RVA: 0x00149BF8 File Offset: 0x00147FF8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.DDoS))
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.TrackBar1 = New Global.System.Windows.Forms.TrackBar()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.Label4 = New Global.System.Windows.Forms.Label()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.Label6 = New Global.System.Windows.Forms.Label()
			Me.TextBox3 = New Global.System.Windows.Forms.TextBox()
			Me.Button3 = New Global.System.Windows.Forms.Button()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.TextBox5 = New Global.System.Windows.Forms.TextBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.Label7 = New Global.System.Windows.Forms.Label()
			Me.TextBox4 = New Global.System.Windows.Forms.TextBox()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Label5 = New Global.System.Windows.Forms.Label()
			CType(Me.TrackBar1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.Panel1.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(6, 16)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(85, 86)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(9, 33)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(275, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 1
			Me.TextBox1.Text = "127.0.0.1"
			Me.TextBox2.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox2
			location = New Global.System.Drawing.Point(9, 34)
			textBox3.Location = location
			Me.TextBox2.Name = "TextBox2"
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox2
			size = New Global.System.Drawing.Size(74, 20)
			textBox4.Size = size
			Me.TextBox2.TabIndex = 2
			Me.TextBox2.Text = "80"
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "TCP", "UDP", "HTTP", "PING" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(89, 34)
			comboBox.Location = location
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(85, 22)
			comboBox2.Size = size
			Me.ComboBox1.TabIndex = 5
			Me.ComboBox1.Text = "UDP"
			Dim trackBar As Global.System.Windows.Forms.Control = Me.TrackBar1
			location = New Global.System.Drawing.Point(9, 33)
			trackBar.Location = location
			Me.TrackBar1.Name = "TrackBar1"
			Dim trackBar2 As Global.System.Windows.Forms.Control = Me.TrackBar1
			size = New Global.System.Drawing.Size(632, 45)
			trackBar2.Size = size
			Me.TrackBar1.TabIndex = 6
			Me.Label1.AutoSize = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(6, 16)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(61, 14)
			label2.Size = size
			Me.Label1.TabIndex = 7
			Me.Label1.Text = "IP Adress"
			Me.Label2.AutoSize = True
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(6, 15)
			label3.Location = location
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(30, 14)
			label4.Size = size
			Me.Label2.TabIndex = 8
			Me.Label2.Text = "Port"
			Me.Label3.AutoSize = True
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(86, 15)
			label5.Location = location
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(33, 14)
			label6.Size = size
			Me.Label3.TabIndex = 9
			Me.Label3.Text = "Type"
			Me.Label4.AutoSize = True
			Dim label7 As Global.System.Windows.Forms.Control = Me.Label4
			location = New Global.System.Drawing.Point(224, 16)
			label7.Location = location
			Me.Label4.Name = "Label4"
			Dim label8 As Global.System.Windows.Forms.Control = Me.Label4
			size = New Global.System.Drawing.Size(209, 14)
			label8.Size = size
			Me.Label4.TabIndex = 10
			Me.Label4.Text = "Hight <---------------------------------> Low"
			Me.GroupBox2.Controls.Add(Me.Button2)
			Me.GroupBox2.Controls.Add(Me.Label6)
			Me.GroupBox2.Controls.Add(Me.TextBox3)
			Me.GroupBox2.Controls.Add(Me.Button3)
			Me.GroupBox2.Controls.Add(Me.Label1)
			Me.GroupBox2.Controls.Add(Me.TextBox1)
			Me.GroupBox2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(167, 12)
			groupBox.Location = location
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(364, 108)
			groupBox2.Size = size
			Me.GroupBox2.TabIndex = 12
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Victim"
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(290, 73)
			button3.Location = location
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(63, 22)
			button4.Size = size
			Me.Button2.TabIndex = 13
			Me.Button2.Text = "Lock On"
			Me.Button2.UseVisualStyleBackColor = True
			Me.Label6.AutoSize = True
			Dim label9 As Global.System.Windows.Forms.Control = Me.Label6
			location = New Global.System.Drawing.Point(6, 56)
			label9.Location = location
			Me.Label6.Name = "Label6"
			Dim label10 As Global.System.Windows.Forms.Control = Me.Label6
			size = New Global.System.Drawing.Size(28, 14)
			label10.Size = size
			Me.Label6.TabIndex = 12
			Me.Label6.Text = "URL"
			Me.TextBox3.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox5 As Global.System.Windows.Forms.Control = Me.TextBox3
			location = New Global.System.Drawing.Point(9, 73)
			textBox5.Location = location
			Me.TextBox3.Name = "TextBox3"
			Dim textBox6 As Global.System.Windows.Forms.Control = Me.TextBox3
			size = New Global.System.Drawing.Size(275, 20)
			textBox6.Size = size
			Me.TextBox3.TabIndex = 11
			Me.TextBox3.Text = "www.exsample.com"
			Me.Button3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button3
			location = New Global.System.Drawing.Point(290, 33)
			button5.Location = location
			Me.Button3.Name = "Button3"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button3
			size = New Global.System.Drawing.Size(63, 22)
			button6.Size = size
			Me.Button3.TabIndex = 10
			Me.Button3.Text = "Lock On"
			Me.Button3.UseVisualStyleBackColor = True
			Me.GroupBox3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox3
			location = New Global.System.Drawing.Point(167, 195)
			groupBox3.Location = location
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(655, 115)
			groupBox4.Size = size
			Me.GroupBox3.TabIndex = 13
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Logs"
			Me.ColumnHeader1.Width = 540
			Me.Timer1.Enabled = True
			Me.TextBox5.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox5.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox5.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.TextBox5.Enabled = False
			Me.TextBox5.Font = New Global.System.Drawing.Font("Arial", 38F, Global.System.Drawing.FontStyle.Bold Or Global.System.Drawing.FontStyle.Italic, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox5.ForeColor = Global.System.Drawing.Color.White
			Dim textBox7 As Global.System.Windows.Forms.Control = Me.TextBox5
			location = New Global.System.Drawing.Point(0, 0)
			textBox7.Location = location
			Me.TextBox5.Multiline = True
			Me.TextBox5.Name = "TextBox5"
			Dim textBox8 As Global.System.Windows.Forms.Control = Me.TextBox5
			size = New Global.System.Drawing.Size(653, 61)
			textBox8.Size = size
			Me.TextBox5.TabIndex = 0
			Me.TextBox5.Text = "NONE!"
			Me.TextBox5.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Panel1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.Panel1.Controls.Add(Me.TextBox5)
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(167, 126)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(655, 63)
			panel2.Size = size
			Me.Panel1.TabIndex = 15
			Me.GroupBox4.Controls.Add(Me.Button1)
			Me.GroupBox4.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox4
			location = New Global.System.Drawing.Point(723, 13)
			groupBox5.Location = location
			Me.GroupBox4.Name = "GroupBox4"
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox4
			size = New Global.System.Drawing.Size(99, 108)
			groupBox6.Size = size
			Me.GroupBox4.TabIndex = 16
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "On/Off"
			Me.GroupBox1.Controls.Add(Me.TrackBar1)
			Me.GroupBox1.Controls.Add(Me.Label4)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(167, 316)
			groupBox7.Location = location
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(655, 80)
			groupBox8.Size = size
			Me.GroupBox1.TabIndex = 17
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "Packets"
			Me.GroupBox5.Controls.Add(Me.Label7)
			Me.GroupBox5.Controls.Add(Me.TextBox4)
			Me.GroupBox5.Controls.Add(Me.Label2)
			Me.GroupBox5.Controls.Add(Me.TextBox2)
			Me.GroupBox5.Controls.Add(Me.Label3)
			Me.GroupBox5.Controls.Add(Me.ComboBox1)
			Me.GroupBox5.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim groupBox9 As Global.System.Windows.Forms.Control = Me.GroupBox5
			location = New Global.System.Drawing.Point(537, 13)
			groupBox9.Location = location
			Me.GroupBox5.Name = "GroupBox5"
			Dim groupBox10 As Global.System.Windows.Forms.Control = Me.GroupBox5
			size = New Global.System.Drawing.Size(180, 108)
			groupBox10.Size = size
			Me.GroupBox5.TabIndex = 17
			Me.GroupBox5.TabStop = False
			Me.Label7.AutoSize = True
			Dim label11 As Global.System.Windows.Forms.Control = Me.Label7
			location = New Global.System.Drawing.Point(6, 63)
			label11.Location = location
			Me.Label7.Name = "Label7"
			Dim label12 As Global.System.Windows.Forms.Control = Me.Label7
			size = New Global.System.Drawing.Size(131, 14)
			label12.Size = size
			Me.Label7.TabIndex = 11
			Me.Label7.Text = "PING Flood Packet Size"
			Me.TextBox4.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox4.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox4.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox9 As Global.System.Windows.Forms.Control = Me.TextBox4
			location = New Global.System.Drawing.Point(9, 82)
			textBox9.Location = location
			Me.TextBox4.Name = "TextBox4"
			Dim textBox10 As Global.System.Windows.Forms.Control = Me.TextBox4
			size = New Global.System.Drawing.Size(165, 20)
			textBox10.Size = size
			Me.TextBox4.TabIndex = 10
			Me.TextBox4.Text = "36000"
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			location = New Global.System.Drawing.Point(-1, -9)
			pictureBox.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(162, 388)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 18
			Me.PictureBox1.TabStop = False
			Me.Label5.AutoSize = True
			Me.Label5.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label5.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label13 As Global.System.Windows.Forms.Control = Me.Label5
			location = New Global.System.Drawing.Point(12, 382)
			label13.Location = location
			Me.Label5.Name = "Label5"
			Dim label14 As Global.System.Windows.Forms.Control = Me.Label5
			size = New Global.System.Drawing.Size(13, 14)
			label14.Size = size
			Me.Label5.TabIndex = 19
			Me.Label5.Text = ".."
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 14F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(834, 404)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label5)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.GroupBox5)
			Me.Controls.Add(Me.GroupBox1)
			Me.Controls.Add(Me.GroupBox4)
			Me.Controls.Add(Me.Panel1)
			Me.Controls.Add(Me.GroupBox2)
			Me.Controls.Add(Me.GroupBox3)
			Me.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.Name = "DDoS"
			CType(Me.TrackBar1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			Me.GroupBox4.ResumeLayout(False)
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000029 RID: 41
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
