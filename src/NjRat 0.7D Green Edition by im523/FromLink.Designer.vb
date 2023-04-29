Namespace NJRAT
	' Token: 0x02000012 RID: 18
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FromLink
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060001EE RID: 494 RVA: 0x001592A0 File Offset: 0x001576A0
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

		' Token: 0x060001EF RID: 495 RVA: 0x001592F0 File Offset: 0x001576F0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.FromLink))
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox2 = New Global.System.Windows.Forms.TextBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.SuspendLayout()
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(165, 61)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(82, 23)
			button2.Size = size
			Me.Button1.TabIndex = 0
			Me.Button1.Text = "OK"
			Me.Button1.UseVisualStyleBackColor = True
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(253, 61)
			button3.Location = location
			Me.Button2.Name = "Button2"
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(82, 23)
			button4.Size = size
			Me.Button2.TabIndex = 1
			Me.Button2.Text = "Cancel"
			Me.Button2.UseVisualStyleBackColor = True
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(14, 24)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(321, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 2
			Me.TextBox2.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox2
			location = New Global.System.Drawing.Point(14, 63)
			textBox3.Location = location
			Me.TextBox2.Name = "TextBox2"
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox2
			size = New Global.System.Drawing.Size(140, 20)
			textBox4.Size = size
			Me.TextBox2.TabIndex = 3
			Me.TextBox2.Text = "File.txt"
			Me.Label1.AutoSize = True
			Me.Label1.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(11, 47)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(52, 13)
			label2.Size = size
			Me.Label1.TabIndex = 4
			Me.Label1.Text = "Save As"
			Me.Label2.AutoSize = True
			Me.Label2.Font = New Global.System.Drawing.Font("Tahoma", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(12, 9)
			label3.Location = location
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(30, 13)
			label4.Size = size
			Me.Label2.TabIndex = 5
			Me.Label2.Text = "Link"
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(350, 102)
			Me.ClientSize = size
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.Controls.Add(Me.TextBox2)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Button2)
			Me.Controls.Add(Me.Button1)
			Me.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.Name = "FromLink"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "FromLink"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x040000E4 RID: 228
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
