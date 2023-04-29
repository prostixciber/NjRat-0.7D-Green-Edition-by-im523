Namespace NJRAT
	' Token: 0x0200000E RID: 14
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Chat
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000115 RID: 277 RVA: 0x0014FF58 File Offset: 0x0014E358
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

		' Token: 0x06000116 RID: 278 RVA: 0x0014FFA8 File Offset: 0x0014E3A8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Chat))
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.T2 = New Global.System.Windows.Forms.TextBox()
			Me.vmethod_8 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.T1 = New Global.System.Windows.Forms.RichTextBox()
			Me.SuspendLayout()
			Me.Button1.BackColor = Global.System.Drawing.Color.Black
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(400, 125)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(75, 23)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Send"
			Me.Button1.UseVisualStyleBackColor = False
			Me.Button1.Visible = False
			Me.T2.BackColor = Global.System.Drawing.Color.Black
			Me.T2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.T2.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.T2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim t As Global.System.Windows.Forms.Control = Me.T2
			location = New Global.System.Drawing.Point(0, 177)
			t.Location = location
			Me.T2.Name = "T2"
			Dim t2 As Global.System.Windows.Forms.Control = Me.T2
			size = New Global.System.Drawing.Size(417, 20)
			t2.Size = size
			Me.T2.TabIndex = 0
			Me.T1.BackColor = Global.System.Drawing.Color.Black
			Me.T1.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.T1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.T1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim t3 As Global.System.Windows.Forms.Control = Me.T1
			location = New Global.System.Drawing.Point(0, 0)
			t3.Location = location
			Me.T1.Name = "T1"
			Dim t4 As Global.System.Windows.Forms.Control = Me.T1
			size = New Global.System.Drawing.Size(417, 177)
			t4.Size = size
			Me.T1.TabIndex = 23
			Me.T1.Text = ""
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(417, 197)
			Me.ClientSize = size
			Me.Controls.Add(Me.T1)
			Me.Controls.Add(Me.T2)
			Me.Controls.Add(Me.Button1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Chat"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Chat"
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000083 RID: 131
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
