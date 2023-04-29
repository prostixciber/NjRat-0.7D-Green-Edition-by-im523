Namespace NJRAT
	' Token: 0x0200001F RID: 31
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class OpenSite
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000447 RID: 1095 RVA: 0x0016CB44 File Offset: 0x0016AF44
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

		' Token: 0x06000448 RID: 1096 RVA: 0x0016CB94 File Offset: 0x0016AF94
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.OpenSite))
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.SuspendLayout()
			Me.Label1.AutoSize = True
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(9, 14)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(28, 14)
			label2.Size = size
			Me.Label1.TabIndex = 6
			Me.Label1.Text = "URL"
			Me.TextBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(43, 12)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(393, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 5
			Me.TextBox1.Text = "http://www.google.com"
			Me.Button1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(442, 8)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(91, 27)
			button2.Size = size
			Me.Button1.TabIndex = 4
			Me.Button1.Text = "Open"
			Me.Button1.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 14F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(545, 44)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Button1)
			Me.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			size = New Global.System.Drawing.Size(561, 83)
			Me.MaximumSize = size
			size = New Global.System.Drawing.Size(561, 83)
			Me.MinimumSize = size
			Me.Name = "OpenSite"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "OpenSite"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040001FD RID: 509
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
