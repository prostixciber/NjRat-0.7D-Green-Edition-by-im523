Namespace NJRAT
	' Token: 0x02000025 RID: 37
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class script
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000505 RID: 1285 RVA: 0x00172D1C File Offset: 0x0017111C
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

		' Token: 0x06000506 RID: 1286 RVA: 0x00172D6C File Offset: 0x0017116C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.script))
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Panel1.SuspendLayout()
			Me.SuspendLayout()
			Me.Panel1.Controls.Add(Me.Button1)
			Me.Panel1.Controls.Add(Me.ComboBox1)
			Me.Panel1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 273)
			panel.Location = location
			Me.Panel1.Name = "Panel1"
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(514, 23)
			panel2.Size = size
			Me.Panel1.TabIndex = 0
			Me.Button1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Button1.BackColor = Global.System.Drawing.Color.Black
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(0, 0)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(441, 21)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Execute"
			Me.Button1.UseVisualStyleBackColor = False
			Me.ComboBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "vbs", "bat", "cmd", "txt", "html", "hta" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(447, 0)
			comboBox.Location = location
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(67, 21)
			comboBox2.Size = size
			Me.ComboBox1.TabIndex = 0
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(0, 0)
			textBox.Location = location
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(514, 273)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 1
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			size = New Global.System.Drawing.Size(514, 296)
			Me.ClientSize = size
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Panel1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "script"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "script"
			Me.Panel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000257 RID: 599
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
