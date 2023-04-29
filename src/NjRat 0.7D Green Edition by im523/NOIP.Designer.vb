Namespace NJRAT
	' Token: 0x0200001B RID: 27
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class NOIP
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000415 RID: 1045 RVA: 0x0016ADC8 File Offset: 0x001691C8
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

		' Token: 0x06000416 RID: 1046 RVA: 0x0016AE18 File Offset: 0x00169218
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.NOIP))
			Me.LinkLabel1 = New Global.System.Windows.Forms.LinkLabel()
			Me.RichTextBox2 = New Global.System.Windows.Forms.RichTextBox()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.TextBox3 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.LinkLabel1.AutoSize = True
			Me.LinkLabel1.BackColor = Global.System.Drawing.Color.Black
			Me.LinkLabel1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Dim linkLabel As Global.System.Windows.Forms.Control = Me.LinkLabel1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(178, 333)
			linkLabel.Location = location
			Me.LinkLabel1.Name = "LinkLabel1"
			Dim linkLabel2 As Global.System.Windows.Forms.Control = Me.LinkLabel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(77, 13)
			linkLabel2.Size = size
			Me.LinkLabel1.TabIndex = 28
			Me.LinkLabel1.TabStop = True
			Me.LinkLabel1.Text = "www.noip.com"
			Me.RichTextBox2.BackColor = Global.System.Drawing.Color.Black
			Me.RichTextBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.RichTextBox2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.RichTextBox2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim richTextBox As Global.System.Windows.Forms.Control = Me.RichTextBox2
			location = New Global.System.Drawing.Point(12, 234)
			richTextBox.Location = location
			Me.RichTextBox2.Name = "RichTextBox2"
			Dim richTextBox2 As Global.System.Windows.Forms.Control = Me.RichTextBox2
			size = New Global.System.Drawing.Size(243, 96)
			richTextBox2.Size = size
			Me.RichTextBox2.TabIndex = 27
			Me.RichTextBox2.Text = ""
			Me.RichTextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.RichTextBox1.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Dim richTextBox3 As Global.System.Windows.Forms.Control = Me.RichTextBox1
			location = New Global.System.Drawing.Point(374, 294)
			richTextBox3.Location = location
			Me.RichTextBox1.Name = "RichTextBox1"
			Dim richTextBox4 As Global.System.Windows.Forms.Control = Me.RichTextBox1
			size = New Global.System.Drawing.Size(37, 22)
			richTextBox4.Size = size
			Me.RichTextBox1.TabIndex = 25
			Me.RichTextBox1.Text = ""
			Me.Button1.BackColor = Global.System.Drawing.Color.Black
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial Black", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(12, 192)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(243, 36)
			button2.Size = size
			Me.Button1.TabIndex = 24
			Me.Button1.Text = "Update"
			Me.Button1.UseVisualStyleBackColor = False
			Me.TextBox3.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox3
			location = New Global.System.Drawing.Point(12, 166)
			textBox.Location = location
			Me.TextBox3.Name = "TextBox3"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox3
			size = New Global.System.Drawing.Size(243, 20)
			textBox2.Size = size
			Me.TextBox3.TabIndex = 23
			Me.TextBox3.Text = "Host.no-ip.biz"
			Me.TextBox2.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox2
			location = New Global.System.Drawing.Point(12, 140)
			textBox3.Location = location
			Me.TextBox2.Name = "TextBox2"
			Me.TextBox2.PasswordChar = "*"c
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox2
			size = New Global.System.Drawing.Size(243, 20)
			textBox4.Size = size
			Me.TextBox2.TabIndex = 22
			Me.TextBox2.Text = "Password"
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox5 As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(12, 114)
			textBox5.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox6 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(243, 20)
			textBox6.Size = size
			Me.TextBox1.TabIndex = 21
			Me.TextBox1.Text = "Email"
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			location = New Global.System.Drawing.Point(32, 12)
			pictureBox.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(203, 81)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 29
			Me.PictureBox1.TabStop = False
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(265, 354)
			Me.ClientSize = size
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.LinkLabel1)
			Me.Controls.Add(Me.RichTextBox2)
			Me.Controls.Add(Me.RichTextBox1)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.TextBox3)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.TextBox1)
			Me.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.Name = "NOIP"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "No-Ip"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040001E2 RID: 482
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
