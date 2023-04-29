Namespace NJRAT
	' Token: 0x0200001A RID: 26
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Mic
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060003FF RID: 1023 RVA: 0x0016A1D4 File Offset: 0x001685D4
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

		' Token: 0x06000400 RID: 1024 RVA: 0x0016A224 File Offset: 0x00168624
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Mic))
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.vmethod_4 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.ComboBox2 = New Global.System.Windows.Forms.ComboBox()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.SuspendLayout()
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ComboBox1.FormattingEnabled = True
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(2, 3)
			comboBox.Location = location
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(224, 21)
			comboBox2.Size = size
			Me.ComboBox1.TabIndex = 0
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(232, 3)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(124, 48)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = True
			Me.vmethod_4.Enabled = True
			Me.vmethod_4.Interval = 50
			Me.Label1.AutoSize = True
			Me.Label1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(5, 33)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(55, 13)
			label2.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "BufferSize"
			Me.ComboBox2.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox2.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Popup
			Me.ComboBox2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ComboBox2.FormattingEnabled = True
			Me.ComboBox2.Items.AddRange(New Object() { "4 kb 8bit", "6 kb 8bit", "8 kb 8bit", "8 kb 16bit", "12 kb 16bit", "16 kb 16bit", "20 kb 16bit", "24 kb 16bit" })
			Dim comboBox3 As Global.System.Windows.Forms.Control = Me.ComboBox2
			location = New Global.System.Drawing.Point(86, 30)
			comboBox3.Location = location
			Me.ComboBox2.Name = "ComboBox2"
			Dim comboBox4 As Global.System.Windows.Forms.Control = Me.ComboBox2
			size = New Global.System.Drawing.Size(140, 21)
			comboBox4.Size = size
			Me.ComboBox2.TabIndex = 3
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			location = New Global.System.Drawing.Point(0, 55)
			progressBar.Location = location
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			size = New Global.System.Drawing.Size(359, 10)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 4
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(359, 65)
			Me.ClientSize = size
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.ComboBox2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.ComboBox1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.Name = "Mic"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Mic"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040001D7 RID: 471
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
