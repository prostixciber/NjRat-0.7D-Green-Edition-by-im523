Namespace NJRAT
	' Token: 0x0200000D RID: 13
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Cam
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060000F5 RID: 245 RVA: 0x0014ED88 File Offset: 0x0014D188
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

		' Token: 0x060000F6 RID: 246 RVA: 0x0014EDD8 File Offset: 0x0014D1D8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Cam))
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.ComboBox2 = New Global.System.Windows.Forms.ComboBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.CheckBox3 = New Global.System.Windows.Forms.CheckBox()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.vmethod_6 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Panel1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.Panel1.Controls.Add(Me.ComboBox2)
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.CheckBox3)
			Me.Panel1.Controls.Add(Me.ComboBox1)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 248)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(380, 29)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.ComboBox2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ComboBox2.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox2.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ComboBox2.FormattingEnabled = True
			Me.ComboBox2.Items.AddRange(New Object() { "%100", "%90", "%80", "%70", "%60", "%50" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox2
			location = New Global.System.Drawing.Point(312, 5)
			comboBox.Location = location
			Me.ComboBox2.Name = "ComboBox2"
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox2
			size = New Global.System.Drawing.Size(65, 21)
			comboBox2.Size = size
			Me.ComboBox2.TabIndex = 3
			Me.Button1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(3, 3)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(67, 23)
			button2.Size = size
			Me.Button1.TabIndex = 2
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = True
			Me.CheckBox3.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.CheckBox3.AutoSize = True
			Me.CheckBox3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim checkBox As Global.System.Windows.Forms.Control = Me.CheckBox3
			location = New Global.System.Drawing.Point(74, 7)
			checkBox.Location = location
			Me.CheckBox3.Name = "CheckBox3"
			Dim checkBox2 As Global.System.Windows.Forms.Control = Me.CheckBox3
			size = New Global.System.Drawing.Size(73, 17)
			checkBox2.Size = size
			Me.CheckBox3.TabIndex = 1
			Me.CheckBox3.Text = "AutoSave"
			Me.CheckBox3.UseVisualStyleBackColor = True
			Me.ComboBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ComboBox1.FormattingEnabled = True
			Dim comboBox3 As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(151, 5)
			comboBox3.Location = location
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox4 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(158, 21)
			comboBox4.Size = size
			Me.ComboBox1.TabIndex = 0
			Me.PictureBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			location = New Global.System.Drawing.Point(0, 0)
			pictureBox.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(380, 242)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 1
			Me.PictureBox1.TabStop = False
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			location = New Global.System.Drawing.Point(0, 238)
			progressBar.Location = location
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(380, 10)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 2
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(380, 277)
			Me.ClientSize = size
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.PictureBox1)
			Me.Controls.Add(Me.Panel1)
			Me.ForeColor = Global.System.Drawing.Color.SlateBlue
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			size = New Global.System.Drawing.Size(396, 316)
			Me.MinimumSize = size
			Me.Name = "Cam"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Cam"
			Me.Panel1.ResumeLayout(False)
			Me.Panel1.PerformLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000071 RID: 113
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
