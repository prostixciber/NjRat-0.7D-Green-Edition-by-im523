Namespace NJRAT
	' Token: 0x02000021 RID: 33
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Pass
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000471 RID: 1137 RVA: 0x0016DD00 File Offset: 0x0016C100
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

		' Token: 0x06000472 RID: 1138 RVA: 0x0016DD50 File Offset: 0x0016C150
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Pass))
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.CopyUseToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyPassToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopySiteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyALLToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveAllToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.InClipboardToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.InDiskToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.FindToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RemoveEmptyPWToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.SaveFileDialog1 = New Global.System.Windows.Forms.SaveFileDialog()
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.MenuStrip1 = New Global.System.Windows.Forms.MenuStrip()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.L1 = New Global.NJRAT.GClass9()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader3 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader4 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader5 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ContextMenuStrip1.SuspendLayout()
			Me.MenuStrip1.SuspendLayout()
			Me.SuspendLayout()
			Me.ContextMenuStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.CopyUseToolStripMenuItem, Me.CopyPassToolStripMenuItem, Me.CopySiteToolStripMenuItem, Me.CopyALLToolStripMenuItem, Me.SaveAllToolStripMenuItem, Me.FindToolStripMenuItem, Me.RemoveEmptyPWToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Me.ContextMenuStrip1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Me.ContextMenuStrip1.ShowImageMargin = False
			Dim contextMenuStrip As Global.System.Windows.Forms.Control = Me.ContextMenuStrip1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(151, 180)
			contextMenuStrip.Size = size
			Me.CopyUseToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.CopyUseToolStripMenuItem.Name = "CopyUseToolStripMenuItem"
			Dim copyUseToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyUseToolStripMenuItem
			size = New Global.System.Drawing.Size(150, 22)
			copyUseToolStripMenuItem.Size = size
			Me.CopyUseToolStripMenuItem.Text = "Copy User"
			Me.CopyPassToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.CopyPassToolStripMenuItem.Name = "CopyPassToolStripMenuItem"
			Dim copyPassToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyPassToolStripMenuItem
			size = New Global.System.Drawing.Size(150, 22)
			copyPassToolStripMenuItem.Size = size
			Me.CopyPassToolStripMenuItem.Text = "Copy Pass"
			Me.CopySiteToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.CopySiteToolStripMenuItem.Name = "CopySiteToolStripMenuItem"
			Dim copySiteToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopySiteToolStripMenuItem
			size = New Global.System.Drawing.Size(150, 22)
			copySiteToolStripMenuItem.Size = size
			Me.CopySiteToolStripMenuItem.Text = "Copy Site"
			Me.CopyALLToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.CopyALLToolStripMenuItem.Name = "CopyALLToolStripMenuItem"
			Dim copyALLToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyALLToolStripMenuItem
			size = New Global.System.Drawing.Size(150, 22)
			copyALLToolStripMenuItem.Size = size
			Me.CopyALLToolStripMenuItem.Text = "Copy ALL"
			Me.SaveAllToolStripMenuItem.DropDownItems.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.InClipboardToolStripMenuItem, Me.InDiskToolStripMenuItem })
			Me.SaveAllToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.SaveAllToolStripMenuItem.Name = "SaveAllToolStripMenuItem"
			Dim saveAllToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.SaveAllToolStripMenuItem
			size = New Global.System.Drawing.Size(150, 22)
			saveAllToolStripMenuItem.Size = size
			Me.SaveAllToolStripMenuItem.Text = "Save All"
			Me.InClipboardToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.InClipboardToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.InClipboardToolStripMenuItem.Name = "InClipboardToolStripMenuItem"
			Dim inClipboardToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.InClipboardToolStripMenuItem
			size = New Global.System.Drawing.Size(139, 22)
			inClipboardToolStripMenuItem.Size = size
			Me.InClipboardToolStripMenuItem.Text = "in Clipboard"
			Me.InDiskToolStripMenuItem.BackColor = Global.System.Drawing.Color.Black
			Me.InDiskToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LightSteelBlue
			Me.InDiskToolStripMenuItem.Name = "InDiskToolStripMenuItem"
			Dim inDiskToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.InDiskToolStripMenuItem
			size = New Global.System.Drawing.Size(139, 22)
			inDiskToolStripMenuItem.Size = size
			Me.InDiskToolStripMenuItem.Text = "in Disk"
			Me.FindToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
			Dim findToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.FindToolStripMenuItem
			size = New Global.System.Drawing.Size(150, 22)
			findToolStripMenuItem.Size = size
			Me.FindToolStripMenuItem.Text = "Find"
			Me.RemoveEmptyPWToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RemoveEmptyPWToolStripMenuItem.Name = "RemoveEmptyPWToolStripMenuItem"
			Dim removeEmptyPWToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.RemoveEmptyPWToolStripMenuItem
			size = New Global.System.Drawing.Size(150, 22)
			removeEmptyPWToolStripMenuItem.Size = size
			Me.RemoveEmptyPWToolStripMenuItem.Text = "Remove Empty PW"
			Me.SaveFileDialog1.FileName = "Pass.txt"
			Me.SaveFileDialog1.Filter = "Text|.txt"
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList1.Images.SetKeyName(0, "1.bmp")
			Me.ImageList1.Images.SetKeyName(1, "2.bmp")
			Me.ImageList1.Images.SetKeyName(2, "3.bmp")
			Me.ImageList1.Images.SetKeyName(3, "4.bmp")
			Me.ImageList1.Images.SetKeyName(4, "5.bmp")
			Me.ImageList1.Images.SetKeyName(5, "6.bmp")
			Me.ImageList1.Images.SetKeyName(6, "7.bmp")
			Me.ImageList1.Images.SetKeyName(7, "8.bmp")
			Me.ImageList1.Images.SetKeyName(8, "9.bmp")
			Me.ImageList1.Images.SetKeyName(9, "10.bmp")
			Me.ImageList1.Images.SetKeyName(10, "11.bmp")
			Me.ImageList1.Images.SetKeyName(11, "12.bmp")
			Me.ImageList1.Images.SetKeyName(12, "13.bmp")
			Me.MenuStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.MenuStrip1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Me.MenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.ToolStripMenuItem1 })
			Dim menuStrip As Global.System.Windows.Forms.Control = Me.MenuStrip1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 222)
			menuStrip.Location = location
			Me.MenuStrip1.Name = "MenuStrip1"
			Dim menuStrip2 As Global.System.Windows.Forms.Control = Me.MenuStrip1
			size = New Global.System.Drawing.Size(679, 24)
			menuStrip2.Size = size
			Me.MenuStrip1.TabIndex = 1
			Me.MenuStrip1.Text = "MenuStrip1"
			Me.ToolStripMenuItem1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Dim toolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem1
			size = New Global.System.Drawing.Size(82, 20)
			toolStripMenuItem.Size = size
			Me.ToolStripMenuItem1.Text = "Passwords"
			Me.L1.BackColor = Global.System.Drawing.Color.Black
			Me.L1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5 })
			Me.L1.ContextMenuStrip = Me.ContextMenuStrip1
			Me.L1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.L1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.L1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.L1.FullRowSelect = True
			Dim l As Global.System.Windows.Forms.Control = Me.L1
			location = New Global.System.Drawing.Point(0, 0)
			l.Location = location
			Me.L1.Name = "L1"
			Me.L1.OwnerDraw = True
			Dim l2 As Global.System.Windows.Forms.Control = Me.L1
			size = New Global.System.Drawing.Size(679, 222)
			l2.Size = size
			Me.L1.SmallImageList = Me.ImageList1
			Me.L1.TabIndex = 2
			Me.L1.UseCompatibleStateImageBehavior = False
			Me.L1.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader1.Text = "UserName"
			Me.ColumnHeader1.Width = 115
			Me.ColumnHeader2.Text = "Password"
			Me.ColumnHeader2.Width = 93
			Me.ColumnHeader3.Text = "URL"
			Me.ColumnHeader3.Width = 93
			Me.ColumnHeader4.Text = "App"
			Me.ColumnHeader4.Width = 95
			Me.ColumnHeader5.Text = "User"
			Me.ColumnHeader5.Width = 276
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(679, 246)
			Me.ClientSize = size
			Me.Controls.Add(Me.L1)
			Me.Controls.Add(Me.MenuStrip1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MainMenuStrip = Me.MenuStrip1
			Me.Name = "Pass"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Pass"
			Me.ContextMenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.ResumeLayout(False)
			Me.MenuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x04000211 RID: 529
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
