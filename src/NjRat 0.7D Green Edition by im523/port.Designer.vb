Namespace NJRAT
	' Token: 0x02000022 RID: 34
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class port
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060004AB RID: 1195 RVA: 0x0016FA9C File Offset: 0x0016DE9C
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

		' Token: 0x060004AC RID: 1196 RVA: 0x0016FAEC File Offset: 0x0016DEEC
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.SuspendLayout()
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.Font = New Global.System.Drawing.Font("Arial", 11.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(61, 6)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(118, 25)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 0
			Me.TextBox1.Text = "5552"
			Me.TextBox1.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(8, 37)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(171, 33)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(6, 7)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(51, 19)
			label2.Size = size
			Me.Label1.TabIndex = 2
			Me.Label1.Text = "Port :"
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button2.Font = New Global.System.Drawing.Font("Arial", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(8, 76)
			button3.Location = location
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(171, 33)
			button4.Size = size
			Me.Button2.TabIndex = 3
			Me.Button2.Text = "Exit"
			Me.Button2.UseVisualStyleBackColor = True
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(191, 116)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.TextBox1)
			Me.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.KeyPreview = True
			Me.MaximizeBox = False
			Me.Name = "port"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "njRAT"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000228 RID: 552
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
