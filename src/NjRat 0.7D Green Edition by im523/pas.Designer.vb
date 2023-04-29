Namespace NJRAT
	' Token: 0x02000020 RID: 32
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class pas
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000452 RID: 1106 RVA: 0x0016D0CC File Offset: 0x0016B4CC
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

		' Token: 0x06000453 RID: 1107 RVA: 0x0016D11C File Offset: 0x0016B51C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem2 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.TFind = New Global.System.Windows.Forms.ToolStripTextBox()
			Me.T1 = New Global.System.Windows.Forms.RichTextBox()
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.CopyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SelectAllToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveAsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.MenuStrip1.SuspendLayout()
			Me.ContextMenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 395)
			progressBar.Location = location
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(347, 10)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 0
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.TFind })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			location = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			size = New Global.System.Drawing.Size(347, 27)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 1
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.ToolStripMenuItem1.BackColor = Global.System.Drawing.Color.Black
			Me.ToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Dim toolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem1
			size = New Global.System.Drawing.Size(58, 23)
			toolStripMenuItem.Size = size
			Me.ToolStripMenuItem1.Text = "Refresh"
			Me.ToolStripMenuItem2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
			Dim toolStripMenuItem2 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem2
			size = New Global.System.Drawing.Size(42, 23)
			toolStripMenuItem2.Size = size
			Me.ToolStripMenuItem2.Text = "Find"
			Me.TFind.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.TFind.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.TFind.Name = "TFind"
			Dim tfind As Global.System.Windows.Forms.ToolStripControlHost = Me.TFind
			size = New Global.System.Drawing.Size(100, 23)
			tfind.Size = size
			Me.TFind.Text = ".."
			Me.T1.BackColor = Global.System.Drawing.Color.MintCream
			Me.T1.ContextMenuStrip = Me.ContextMenuStrip1
			Me.T1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim t As Global.System.Windows.Forms.Control = Me.T1
			location = New Global.System.Drawing.Point(0, 27)
			t.Location = location
			Me.T1.Name = "T1"
			Dim t2 As Global.System.Windows.Forms.Control = Me.T1
			size = New Global.System.Drawing.Size(347, 368)
			t2.Size = size
			Me.T1.TabIndex = 2
			Me.T1.Text = ""
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CopyToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.SaveAsToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Me.ContextMenuStrip1.ShowImageMargin = False
			Dim contextMenuStrip As Global.System.Windows.Forms.Control = Me.ContextMenuStrip1
			size = New Global.System.Drawing.Size(128, 92)
			contextMenuStrip.Size = size
			Me.CopyToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.CopyToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
			Dim copyToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyToolStripMenuItem
			size = New Global.System.Drawing.Size(127, 22)
			copyToolStripMenuItem.Size = size
			Me.CopyToolStripMenuItem.Text = "Copy"
			Me.SelectAllToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.SelectAllToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
			Dim selectAllToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SelectAllToolStripMenuItem
			size = New Global.System.Drawing.Size(127, 22)
			selectAllToolStripMenuItem.Size = size
			Me.SelectAllToolStripMenuItem.Text = "Select All"
			Me.SaveAsToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.SaveAsToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
			Dim saveAsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveAsToolStripMenuItem
			size = New Global.System.Drawing.Size(127, 22)
			saveAsToolStripMenuItem.Size = size
			Me.SaveAsToolStripMenuItem.Text = "Save As"
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(347, 405)
			Me.ClientSize = size
			Me.Controls.Add(Me.T1)
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "pas"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "kl"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ContextMenuStrip1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000203 RID: 515
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
