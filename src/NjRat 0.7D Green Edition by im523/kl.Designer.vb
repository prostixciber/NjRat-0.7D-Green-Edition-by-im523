Namespace NJRAT
	' Token: 0x02000015 RID: 21
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class kl
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060002F1 RID: 753 RVA: 0x00160AA8 File Offset: 0x0015EEA8
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

		' Token: 0x060002F2 RID: 754 RVA: 0x00160AF8 File Offset: 0x0015EEF8
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.kl))
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem2 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.TFind = New Global.System.Windows.Forms.ToolStripTextBox()
			Me.ToolStripMenuItem3 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.T1 = New Global.System.Windows.Forms.RichTextBox()
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.CopyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SelectAllToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.MenuStrip1.SuspendLayout()
			Me.ContextMenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 322)
			progressBar.Location = location
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(641, 10)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 0
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.TFind, Me.ToolStripMenuItem3 })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			location = New Global.System.Drawing.Point(0, 0)
			menuStrip.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			size = New Global.System.Drawing.Size(641, 27)
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
			Me.TFind.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.TFind.Name = "TFind"
			Dim tfind As Global.System.Windows.Forms.ToolStripControlHost = Me.TFind
			size = New Global.System.Drawing.Size(100, 23)
			tfind.Size = size
			Me.TFind.Text = ".."
			Me.ToolStripMenuItem3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
			Dim toolStripMenuItem3 As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem3
			size = New Global.System.Drawing.Size(100, 23)
			toolStripMenuItem3.Size = size
			Me.ToolStripMenuItem3.Text = "Fix [BackSpace]"
			Me.T1.BackColor = Global.System.Drawing.Color.MintCream
			Me.T1.ContextMenuStrip = Me.ContextMenuStrip1
			Me.T1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim t As Global.System.Windows.Forms.Control = Me.T1
			location = New Global.System.Drawing.Point(0, 27)
			t.Location = location
			Me.T1.Name = "T1"
			Dim t2 As Global.System.Windows.Forms.Control = Me.T1
			size = New Global.System.Drawing.Size(641, 295)
			t2.Size = size
			Me.T1.TabIndex = 2
			Me.T1.Text = ""
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CopyToolStripMenuItem, Me.SelectAllToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Me.ContextMenuStrip1.ShowImageMargin = False
			Dim contextMenuStrip As Global.System.Windows.Forms.Control = Me.ContextMenuStrip1
			size = New Global.System.Drawing.Size(98, 48)
			contextMenuStrip.Size = size
			Me.CopyToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.CopyToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
			Dim copyToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyToolStripMenuItem
			size = New Global.System.Drawing.Size(97, 22)
			copyToolStripMenuItem.Size = size
			Me.CopyToolStripMenuItem.Text = "Copy"
			Me.SelectAllToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.SelectAllToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
			Dim selectAllToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SelectAllToolStripMenuItem
			size = New Global.System.Drawing.Size(97, 22)
			selectAllToolStripMenuItem.Size = size
			Me.SelectAllToolStripMenuItem.Text = "Select All"
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			size = New Global.System.Drawing.Size(641, 332)
			Me.ClientSize = size
			Me.Controls.Add(Me.T1)
			Me.Controls.Add(Me.ProgressBar1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "kl"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "kl"
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ContextMenuStrip1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400014C RID: 332
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
