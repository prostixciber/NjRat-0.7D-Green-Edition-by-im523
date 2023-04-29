Namespace NJRAT
	' Token: 0x02000016 RID: 22
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Manager
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000310 RID: 784 RVA: 0x001617DC File Offset: 0x0015FBDC
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

		' Token: 0x06000311 RID: 785 RVA: 0x0016182C File Offset: 0x0015FC2C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Manager))
			Dim listViewItem As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("File Manager", "Icon_5.bmp")
			Dim listViewItem2 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Process Manager", "Icon_8.bmp")
			Dim listViewItem3 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Connections", "Icon_178.bmp")
			Dim listViewItem4 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Registry", "Icon_27.bmp")
			Dim listViewItem5 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Remote Shell", "Icon_1.bmp")
			Dim listViewItem6 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Services", "Icon_274.bmp")
			Me.StatusStrip1 = New Global.System.Windows.Forms.StatusStrip()
			Me.SL = New Global.System.Windows.Forms.ToolStripStatusLabel()
			Me.pr = New Global.System.Windows.Forms.ToolStripProgressBar()
			Me.M1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.KillToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.KillDeleteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RestartProcessToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.vmethod_26 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.ContextMenuStrip1 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.KillConnectionToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.crg = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.EditToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NewValueToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.DeleteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.rimg = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.crgk = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CreateKeyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.DeleteSelectedToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ContextMenuStrip2 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.StopToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PauseToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.StartToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ContextMenuStrip3 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.UPToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RefreshToolStripMenuItem2 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RunToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.Delete = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.EditToolStripMenuItem1 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RenameToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CopyToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.CutToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.PasteToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.DownloadToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UploadToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NewEmptyFileToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.NewFolderToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.OpenDownloadsToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.RarToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UnRarToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.UploadFromLinkToolStripMenuItem = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.ContextMenuStrip4 = New Global.System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.RefreshToolStripMenuItem3 = New Global.System.Windows.Forms.ToolStripMenuItem()
			Me.MG = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.ListView1 = New Global.System.Windows.Forms.ListView()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.vmethod_148 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.vmethod_108 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.FMM = New Global.System.Windows.Forms.Panel()
			Me.LSRV = New Global.NJRAT.GClass9()
			Me.ColumnHeader11 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader12 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader13 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader14 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader15 = New Global.System.Windows.Forms.ColumnHeader()
			Me.LPR = New Global.NJRAT.GClass9()
			Me.ColumnHeader22 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader23 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader24 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader25 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader26 = New Global.System.Windows.Forms.ColumnHeader()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.L1 = New Global.NJRAT.GClass9()
			Me.ColumnHeader6 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader7 = New Global.System.Windows.Forms.ColumnHeader()
			Me.p = New Global.System.Windows.Forms.PictureBox()
			Me.L2 = New Global.NJRAT.GClass9()
			Me.ColumnHeader8 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader9 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader10 = New Global.System.Windows.Forms.ColumnHeader()
			Me.LTCP = New Global.NJRAT.GClass9()
			Me.ColumnHeader16 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader17 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader18 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader19 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader20 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader21 = New Global.System.Windows.Forms.ColumnHeader()
			Me.RG = New Global.System.Windows.Forms.Panel()
			Me.RGLIST = New Global.NJRAT.GClass9()
			Me.ColumnHeader3 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader4 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader5 = New Global.System.Windows.Forms.ColumnHeader()
			Me.RGk = New Global.System.Windows.Forms.TreeView()
			Me.sh = New Global.System.Windows.Forms.Panel()
			Me.T1 = New Global.System.Windows.Forms.RichTextBox()
			Me.T2 = New Global.System.Windows.Forms.TextBox()
			Me.StatusStrip1.SuspendLayout()
			Me.M1.SuspendLayout()
			Me.ContextMenuStrip1.SuspendLayout()
			Me.crg.SuspendLayout()
			Me.crgk.SuspendLayout()
			Me.ContextMenuStrip2.SuspendLayout()
			Me.ContextMenuStrip3.SuspendLayout()
			Me.ContextMenuStrip4.SuspendLayout()
			Me.FMM.SuspendLayout()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.RG.SuspendLayout()
			Me.sh.SuspendLayout()
			Me.SuspendLayout()
			Me.StatusStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.StatusStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.SL, Me.pr })
			Dim statusStrip As Global.System.Windows.Forms.Control = Me.StatusStrip1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 323)
			statusStrip.Location = location
			Me.StatusStrip1.Name = "StatusStrip1"
			Me.StatusStrip1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.Professional
			Dim statusStrip2 As Global.System.Windows.Forms.Control = Me.StatusStrip1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(667, 22)
			statusStrip2.Size = size
			Me.StatusStrip1.TabIndex = 0
			Me.StatusStrip1.Text = "StatusStrip1"
			Me.SL.IsLink = True
			Me.SL.Name = "SL"
			Dim sl As Global.System.Windows.Forms.ToolStripItem = Me.SL
			size = New Global.System.Drawing.Size(13, 17)
			sl.Size = size
			Me.SL.Text = ".."
			Me.pr.Name = "pr"
			Dim pr As Global.System.Windows.Forms.ToolStripControlHost = Me.pr
			size = New Global.System.Drawing.Size(100, 16)
			pr.Size = size
			Me.M1.BackColor = Global.System.Drawing.Color.Black
			Me.M1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.KillToolStripMenuItem1, Me.KillDeleteToolStripMenuItem, Me.ToolStripMenuItem1, Me.RestartProcessToolStripMenuItem })
			Me.M1.Name = "M1"
			Me.M1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Dim m As Global.System.Windows.Forms.Control = Me.M1
			size = New Global.System.Drawing.Size(154, 92)
			m.Size = size
			Me.KillToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.KillToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("KillToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.KillToolStripMenuItem1.Name = "KillToolStripMenuItem1"
			Dim killToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.KillToolStripMenuItem1
			size = New Global.System.Drawing.Size(153, 22)
			killToolStripMenuItem.Size = size
			Me.KillToolStripMenuItem1.Text = "Kill"
			Me.KillDeleteToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.KillDeleteToolStripMenuItem.Image = CType(componentResourceManager.GetObject("KillDeleteToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.KillDeleteToolStripMenuItem.Name = "KillDeleteToolStripMenuItem"
			Dim killDeleteToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.KillDeleteToolStripMenuItem
			size = New Global.System.Drawing.Size(153, 22)
			killDeleteToolStripMenuItem.Size = size
			Me.KillDeleteToolStripMenuItem.Text = "Kill + Delete"
			Me.ToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("ToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
			Dim toolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.ToolStripMenuItem1
			size = New Global.System.Drawing.Size(153, 22)
			toolStripMenuItem.Size = size
			Me.ToolStripMenuItem1.Text = "New Process"
			Me.RestartProcessToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RestartProcessToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RestartProcessToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RestartProcessToolStripMenuItem.Name = "RestartProcessToolStripMenuItem"
			Dim restartProcessToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.RestartProcessToolStripMenuItem
			size = New Global.System.Drawing.Size(153, 22)
			restartProcessToolStripMenuItem.Size = size
			Me.RestartProcessToolStripMenuItem.Text = "Restart Process"
			Me.vmethod_26.Interval = 1000
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.ImageList1.Images.SetKeyName(0, "Icon_1.bmp")
			Me.ImageList1.Images.SetKeyName(1, "Icon_5.bmp")
			Me.ImageList1.Images.SetKeyName(2, "Icon_8.bmp")
			Me.ImageList1.Images.SetKeyName(3, "Icon_27.bmp")
			Me.ImageList1.Images.SetKeyName(4, "Icon_178.bmp")
			Me.ImageList1.Images.SetKeyName(5, "Icon_274.bmp")
			Me.ContextMenuStrip1.BackColor = Global.System.Drawing.Color.Black
			Me.ContextMenuStrip1.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.KillConnectionToolStripMenuItem })
			Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
			Me.ContextMenuStrip1.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Dim contextMenuStrip As Global.System.Windows.Forms.Control = Me.ContextMenuStrip1
			size = New Global.System.Drawing.Size(156, 26)
			contextMenuStrip.Size = size
			Me.KillConnectionToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.KillConnectionToolStripMenuItem.Image = CType(componentResourceManager.GetObject("KillConnectionToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.KillConnectionToolStripMenuItem.Name = "KillConnectionToolStripMenuItem"
			Dim killConnectionToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.KillConnectionToolStripMenuItem
			size = New Global.System.Drawing.Size(155, 22)
			killConnectionToolStripMenuItem.Size = size
			Me.KillConnectionToolStripMenuItem.Text = "Kill Connection"
			Me.crg.BackColor = Global.System.Drawing.Color.Black
			Me.crg.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshToolStripMenuItem, Me.EditToolStripMenuItem, Me.NewValueToolStripMenuItem, Me.DeleteToolStripMenuItem })
			Me.crg.Name = "crg"
			Me.crg.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Dim crg As Global.System.Windows.Forms.Control = Me.crg
			size = New Global.System.Drawing.Size(131, 92)
			crg.Size = size
			Me.RefreshToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RefreshToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RefreshToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
			Dim refreshToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.RefreshToolStripMenuItem
			size = New Global.System.Drawing.Size(130, 22)
			refreshToolStripMenuItem.Size = size
			Me.RefreshToolStripMenuItem.Text = "Refresh"
			Me.EditToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.EditToolStripMenuItem.Image = CType(componentResourceManager.GetObject("EditToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
			Dim editToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.EditToolStripMenuItem
			size = New Global.System.Drawing.Size(130, 22)
			editToolStripMenuItem.Size = size
			Me.EditToolStripMenuItem.Text = "Edit"
			Me.NewValueToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.NewValueToolStripMenuItem.Image = CType(componentResourceManager.GetObject("NewValueToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.NewValueToolStripMenuItem.Name = "NewValueToolStripMenuItem"
			Dim newValueToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.NewValueToolStripMenuItem
			size = New Global.System.Drawing.Size(130, 22)
			newValueToolStripMenuItem.Size = size
			Me.NewValueToolStripMenuItem.Text = "New Value"
			Me.DeleteToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.DeleteToolStripMenuItem.Image = CType(componentResourceManager.GetObject("DeleteToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
			Dim deleteToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.DeleteToolStripMenuItem
			size = New Global.System.Drawing.Size(130, 22)
			deleteToolStripMenuItem.Size = size
			Me.DeleteToolStripMenuItem.Text = "Delete"
			Me.rimg.ImageStream = CType(componentResourceManager.GetObject("rimg.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.rimg.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.rimg.Images.SetKeyName(0, "Icon_19.ico")
			Me.rimg.Images.SetKeyName(1, "8.bmp")
			Me.rimg.Images.SetKeyName(2, "9.bmp")
			Me.rimg.Images.SetKeyName(3, "Treetog-Junior-Folder-open.ico")
			Me.rimg.Images.SetKeyName(4, "Icon_20.ico")
			Me.crgk.BackColor = Global.System.Drawing.Color.Black
			Me.crgk.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshToolStripMenuItem1, Me.CreateKeyToolStripMenuItem, Me.DeleteSelectedToolStripMenuItem })
			Me.crgk.Name = "crgk"
			Me.crgk.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Dim crgk As Global.System.Windows.Forms.Control = Me.crgk
			size = New Global.System.Drawing.Size(155, 70)
			crgk.Size = size
			Me.RefreshToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RefreshToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("RefreshToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.RefreshToolStripMenuItem1.Name = "RefreshToolStripMenuItem1"
			Dim refreshToolStripMenuItem2 As Global.System.Windows.Forms.ToolStripItem = Me.RefreshToolStripMenuItem1
			size = New Global.System.Drawing.Size(154, 22)
			refreshToolStripMenuItem2.Size = size
			Me.RefreshToolStripMenuItem1.Text = "Refresh"
			Me.CreateKeyToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.CreateKeyToolStripMenuItem.Image = CType(componentResourceManager.GetObject("CreateKeyToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.CreateKeyToolStripMenuItem.Name = "CreateKeyToolStripMenuItem"
			Dim createKeyToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CreateKeyToolStripMenuItem
			size = New Global.System.Drawing.Size(154, 22)
			createKeyToolStripMenuItem.Size = size
			Me.CreateKeyToolStripMenuItem.Text = "Create Key"
			Me.DeleteSelectedToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.DeleteSelectedToolStripMenuItem.Image = CType(componentResourceManager.GetObject("DeleteSelectedToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.DeleteSelectedToolStripMenuItem.Name = "DeleteSelectedToolStripMenuItem"
			Dim deleteSelectedToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.DeleteSelectedToolStripMenuItem
			size = New Global.System.Drawing.Size(154, 22)
			deleteSelectedToolStripMenuItem.Size = size
			Me.DeleteSelectedToolStripMenuItem.Text = "Delete Selected"
			Me.ContextMenuStrip2.BackColor = Global.System.Drawing.Color.Black
			Me.ContextMenuStrip2.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.StopToolStripMenuItem, Me.PauseToolStripMenuItem, Me.StartToolStripMenuItem })
			Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
			Me.ContextMenuStrip2.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Dim contextMenuStrip2 As Global.System.Windows.Forms.Control = Me.ContextMenuStrip2
			size = New Global.System.Drawing.Size(106, 70)
			contextMenuStrip2.Size = size
			Me.StopToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.StopToolStripMenuItem.Image = CType(componentResourceManager.GetObject("StopToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
			Dim stopToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.StopToolStripMenuItem
			size = New Global.System.Drawing.Size(105, 22)
			stopToolStripMenuItem.Size = size
			Me.StopToolStripMenuItem.Text = "Stop"
			Me.PauseToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.PauseToolStripMenuItem.Image = CType(componentResourceManager.GetObject("PauseToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
			Dim pauseToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.PauseToolStripMenuItem
			size = New Global.System.Drawing.Size(105, 22)
			pauseToolStripMenuItem.Size = size
			Me.PauseToolStripMenuItem.Text = "Pause"
			Me.StartToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.StartToolStripMenuItem.Image = CType(componentResourceManager.GetObject("StartToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
			Dim startToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.StartToolStripMenuItem
			size = New Global.System.Drawing.Size(105, 22)
			startToolStripMenuItem.Size = size
			Me.StartToolStripMenuItem.Text = "Start"
			Me.ContextMenuStrip3.BackColor = Global.System.Drawing.Color.Black
			Me.ContextMenuStrip3.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.UPToolStripMenuItem, Me.RefreshToolStripMenuItem2, Me.RunToolStripMenuItem, Me.Delete, Me.EditToolStripMenuItem1, Me.RenameToolStripMenuItem, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DownloadToolStripMenuItem, Me.UploadToolStripMenuItem, Me.NewEmptyFileToolStripMenuItem, Me.NewFolderToolStripMenuItem, Me.OpenDownloadsToolStripMenuItem, Me.RarToolStripMenuItem, Me.UnRarToolStripMenuItem, Me.UploadFromLinkToolStripMenuItem })
			Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
			Me.ContextMenuStrip3.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Dim contextMenuStrip3 As Global.System.Windows.Forms.Control = Me.ContextMenuStrip3
			size = New Global.System.Drawing.Size(169, 378)
			contextMenuStrip3.Size = size
			Me.UPToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.UPToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UPToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UPToolStripMenuItem.Name = "UPToolStripMenuItem"
			Dim uptoolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.UPToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			uptoolStripMenuItem.Size = size
			Me.UPToolStripMenuItem.Text = "UP"
			Me.RefreshToolStripMenuItem2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RefreshToolStripMenuItem2.Image = CType(componentResourceManager.GetObject("RefreshToolStripMenuItem2.Image"), Global.System.Drawing.Image)
			Me.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2"
			Dim refreshToolStripMenuItem3 As Global.System.Windows.Forms.ToolStripItem = Me.RefreshToolStripMenuItem2
			size = New Global.System.Drawing.Size(168, 22)
			refreshToolStripMenuItem3.Size = size
			Me.RefreshToolStripMenuItem2.Text = "Refresh"
			Me.RunToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RunToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RunToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
			Dim runToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.RunToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			runToolStripMenuItem.Size = size
			Me.RunToolStripMenuItem.Text = "Run"
			Me.Delete.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.Delete.Image = CType(componentResourceManager.GetObject("Delete.Image"), Global.System.Drawing.Image)
			Me.Delete.Name = "Delete"
			Dim delete As Global.System.Windows.Forms.ToolStripItem = Me.Delete
			size = New Global.System.Drawing.Size(168, 22)
			delete.Size = size
			Me.Delete.Text = "Delete"
			Me.EditToolStripMenuItem1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.EditToolStripMenuItem1.Image = CType(componentResourceManager.GetObject("EditToolStripMenuItem1.Image"), Global.System.Drawing.Image)
			Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
			Dim editToolStripMenuItem2 As Global.System.Windows.Forms.ToolStripItem = Me.EditToolStripMenuItem1
			size = New Global.System.Drawing.Size(168, 22)
			editToolStripMenuItem2.Size = size
			Me.EditToolStripMenuItem1.Text = "Edit"
			Me.RenameToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RenameToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RenameToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
			Dim renameToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.RenameToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			renameToolStripMenuItem.Size = size
			Me.RenameToolStripMenuItem.Text = "Rename"
			Me.CopyToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.CopyToolStripMenuItem.Image = CType(componentResourceManager.GetObject("CopyToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
			Dim copyToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CopyToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			copyToolStripMenuItem.Size = size
			Me.CopyToolStripMenuItem.Text = "Copy"
			Me.CutToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.CutToolStripMenuItem.Image = CType(componentResourceManager.GetObject("CutToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
			Dim cutToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.CutToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			cutToolStripMenuItem.Size = size
			Me.CutToolStripMenuItem.Text = "Cut"
			Me.PasteToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.PasteToolStripMenuItem.Image = CType(componentResourceManager.GetObject("PasteToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
			Dim pasteToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.PasteToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			pasteToolStripMenuItem.Size = size
			Me.PasteToolStripMenuItem.Text = "Paste"
			Me.DownloadToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.DownloadToolStripMenuItem.Image = CType(componentResourceManager.GetObject("DownloadToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.DownloadToolStripMenuItem.Name = "DownloadToolStripMenuItem"
			Dim downloadToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.DownloadToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			downloadToolStripMenuItem.Size = size
			Me.DownloadToolStripMenuItem.Text = "Download"
			Me.UploadToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.UploadToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UploadToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
			Dim uploadToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.UploadToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			uploadToolStripMenuItem.Size = size
			Me.UploadToolStripMenuItem.Text = "Upload"
			Me.NewEmptyFileToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.NewEmptyFileToolStripMenuItem.Image = CType(componentResourceManager.GetObject("NewEmptyFileToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.NewEmptyFileToolStripMenuItem.Name = "NewEmptyFileToolStripMenuItem"
			Dim newEmptyFileToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.NewEmptyFileToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			newEmptyFileToolStripMenuItem.Size = size
			Me.NewEmptyFileToolStripMenuItem.Text = "New Empty File"
			Me.NewFolderToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.NewFolderToolStripMenuItem.Image = CType(componentResourceManager.GetObject("NewFolderToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.NewFolderToolStripMenuItem.Name = "NewFolderToolStripMenuItem"
			Dim newFolderToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.NewFolderToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			newFolderToolStripMenuItem.Size = size
			Me.NewFolderToolStripMenuItem.Text = "New Folder"
			Me.OpenDownloadsToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.OpenDownloadsToolStripMenuItem.Image = CType(componentResourceManager.GetObject("OpenDownloadsToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.OpenDownloadsToolStripMenuItem.Name = "OpenDownloadsToolStripMenuItem"
			Dim openDownloadsToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.OpenDownloadsToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			openDownloadsToolStripMenuItem.Size = size
			Me.OpenDownloadsToolStripMenuItem.Text = "Open Downloads"
			Me.RarToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RarToolStripMenuItem.Image = CType(componentResourceManager.GetObject("RarToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.RarToolStripMenuItem.Name = "RarToolStripMenuItem"
			Dim rarToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.RarToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			rarToolStripMenuItem.Size = size
			Me.RarToolStripMenuItem.Text = "Rar"
			Me.UnRarToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.UnRarToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UnRarToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UnRarToolStripMenuItem.Name = "UnRarToolStripMenuItem"
			Dim unRarToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.UnRarToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			unRarToolStripMenuItem.Size = size
			Me.UnRarToolStripMenuItem.Text = "UnRar"
			Me.UploadFromLinkToolStripMenuItem.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.UploadFromLinkToolStripMenuItem.Image = CType(componentResourceManager.GetObject("UploadFromLinkToolStripMenuItem.Image"), Global.System.Drawing.Image)
			Me.UploadFromLinkToolStripMenuItem.Name = "UploadFromLinkToolStripMenuItem"
			Dim uploadFromLinkToolStripMenuItem As Global.System.Windows.Forms.ToolStripItem = Me.UploadFromLinkToolStripMenuItem
			size = New Global.System.Drawing.Size(168, 22)
			uploadFromLinkToolStripMenuItem.Size = size
			Me.UploadFromLinkToolStripMenuItem.Text = "Upload From Link"
			Me.ContextMenuStrip4.BackColor = Global.System.Drawing.Color.Black
			Me.ContextMenuStrip4.Items.AddRange(New Global.System.Windows.Forms.ToolStripItem() { Me.RefreshToolStripMenuItem3 })
			Me.ContextMenuStrip4.Name = "ContextMenuStrip4"
			Me.ContextMenuStrip4.RenderMode = Global.System.Windows.Forms.ToolStripRenderMode.System
			Dim contextMenuStrip4 As Global.System.Windows.Forms.Control = Me.ContextMenuStrip4
			size = New Global.System.Drawing.Size(114, 26)
			contextMenuStrip4.Size = size
			Me.RefreshToolStripMenuItem3.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RefreshToolStripMenuItem3.Image = CType(componentResourceManager.GetObject("RefreshToolStripMenuItem3.Image"), Global.System.Drawing.Image)
			Me.RefreshToolStripMenuItem3.Name = "RefreshToolStripMenuItem3"
			Dim refreshToolStripMenuItem4 As Global.System.Windows.Forms.ToolStripItem = Me.RefreshToolStripMenuItem3
			size = New Global.System.Drawing.Size(113, 22)
			refreshToolStripMenuItem4.Size = size
			Me.RefreshToolStripMenuItem3.Text = "Refresh"
			Me.MG.ImageStream = CType(componentResourceManager.GetObject("MG.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.MG.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.MG.Images.SetKeyName(0, "Icon_20.ico")
			Me.MG.Images.SetKeyName(1, "drive-cd-empty-icon.png")
			Me.MG.Images.SetKeyName(2, "drive-cd-icon.png")
			Me.MG.Images.SetKeyName(3, "Aha-Soft-Torrent-Download.ico")
			Me.MG.Images.SetKeyName(4, "6.bmp")
			Me.MG.Images.SetKeyName(5, "Oxygen-Icons.org-Oxygen-Apps-preferences-system-network-sharing.ico")
			Me.ListView1.Activation = Global.System.Windows.Forms.ItemActivation.OneClick
			Me.ListView1.BackColor = Global.System.Drawing.Color.Black
			Me.ListView1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2 })
			Me.ListView1.Dock = Global.System.Windows.Forms.DockStyle.Top
			Me.ListView1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ListView1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.ListView1.HeaderStyle = Global.System.Windows.Forms.ColumnHeaderStyle.None
			Me.ListView1.HotTracking = True
			Me.ListView1.HoverSelection = True
			listViewItem.Tag = ""
			listViewItem2.Tag = "0"
			listViewItem3.Tag = "1"
			listViewItem4.Tag = "2"
			listViewItem5.Tag = "3"
			listViewItem6.Tag = "4"
			Me.ListView1.Items.AddRange(New Global.System.Windows.Forms.ListViewItem() { listViewItem, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 })
			Me.ListView1.LargeImageList = Me.ImageList1
			Dim listView As Global.System.Windows.Forms.Control = Me.ListView1
			location = New Global.System.Drawing.Point(0, 0)
			listView.Location = location
			Me.ListView1.MultiSelect = False
			Me.ListView1.Name = "ListView1"
			Me.ListView1.Scrollable = False
			Dim listView2 As Global.System.Windows.Forms.Control = Me.ListView1
			size = New Global.System.Drawing.Size(667, 52)
			listView2.Size = size
			Me.ListView1.SmallImageList = Me.ImageList1
			Me.ListView1.TabIndex = 9
			Dim listView3 As Global.System.Windows.Forms.ListView = Me.ListView1
			size = New Global.System.Drawing.Size(130, 25)
			listView3.TileSize = size
			Me.ListView1.UseCompatibleStateImageBehavior = False
			Me.ListView1.View = Global.System.Windows.Forms.View.Tile
			Me.vmethod_148.ColorDepth = Global.System.Windows.Forms.ColorDepth.Depth8Bit
			Dim vmethod_ As Global.System.Windows.Forms.ImageList = Me.vmethod_148
			size = New Global.System.Drawing.Size(16, 16)
			vmethod_.ImageSize = size
			Me.vmethod_148.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.vmethod_108.ColorDepth = Global.System.Windows.Forms.ColorDepth.Depth32Bit
			Dim vmethod_2 As Global.System.Windows.Forms.ImageList = Me.vmethod_108
			size = New Global.System.Drawing.Size(20, 20)
			vmethod_2.ImageSize = size
			Me.vmethod_108.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.FMM.Controls.Add(Me.LSRV)
			Me.FMM.Controls.Add(Me.LPR)
			Me.FMM.Controls.Add(Me.TextBox1)
			Me.FMM.Controls.Add(Me.L1)
			Me.FMM.Controls.Add(Me.p)
			Me.FMM.Controls.Add(Me.L2)
			Me.FMM.Controls.Add(Me.LTCP)
			Me.FMM.Controls.Add(Me.RG)
			Me.FMM.Controls.Add(Me.sh)
			Me.FMM.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim fmm As Global.System.Windows.Forms.Control = Me.FMM
			location = New Global.System.Drawing.Point(0, 52)
			fmm.Location = location
			Me.FMM.Name = "FMM"
			Dim fmm2 As Global.System.Windows.Forms.Control = Me.FMM
			size = New Global.System.Drawing.Size(667, 271)
			fmm2.Size = size
			Me.FMM.TabIndex = 49
			Me.LSRV.BackColor = Global.System.Drawing.Color.Black
			Me.LSRV.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15 })
			Me.LSRV.ContextMenuStrip = Me.ContextMenuStrip2
			Me.LSRV.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LSRV.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.LSRV.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.LSRV.FullRowSelect = True
			Me.LSRV.GridLines = True
			Dim lsrv As Global.System.Windows.Forms.Control = Me.LSRV
			location = New Global.System.Drawing.Point(0, 0)
			lsrv.Location = location
			Me.LSRV.Name = "LSRV"
			Me.LSRV.OwnerDraw = True
			Me.LSRV.ShowItemToolTips = True
			Dim lsrv2 As Global.System.Windows.Forms.Control = Me.LSRV
			size = New Global.System.Drawing.Size(667, 271)
			lsrv2.Size = size
			Me.LSRV.TabIndex = 55
			Me.LSRV.UseCompatibleStateImageBehavior = False
			Me.LSRV.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader11.Text = "Service"
			Me.ColumnHeader12.Text = "Display Name"
			Me.ColumnHeader13.Text = "Type"
			Me.ColumnHeader14.Text = "Status"
			Me.ColumnHeader15.Text = "Can Stop?"
			Me.ColumnHeader15.Width = 423
			Me.LPR.BackColor = Global.System.Drawing.Color.Black
			Me.LPR.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24, Me.ColumnHeader25, Me.ColumnHeader26 })
			Me.LPR.ContextMenuStrip = Me.M1
			Me.LPR.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LPR.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.LPR.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.LPR.FullRowSelect = True
			Me.LPR.GridLines = True
			Dim lpr As Global.System.Windows.Forms.Control = Me.LPR
			location = New Global.System.Drawing.Point(0, 0)
			lpr.Location = location
			Me.LPR.Name = "LPR"
			Me.LPR.OwnerDraw = True
			Me.LPR.ShowItemToolTips = True
			Dim lpr2 As Global.System.Windows.Forms.Control = Me.LPR
			size = New Global.System.Drawing.Size(667, 271)
			lpr2.Size = size
			Me.LPR.TabIndex = 54
			Me.LPR.UseCompatibleStateImageBehavior = False
			Me.LPR.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader22.Text = "Name"
			Me.ColumnHeader23.Text = "PID"
			Me.ColumnHeader23.Width = 49
			Me.ColumnHeader24.Text = "Directory"
			Me.ColumnHeader24.Width = 116
			Me.ColumnHeader25.Text = "User"
			Me.ColumnHeader26.Text = "CommandLine"
			Me.ColumnHeader26.Width = 378
			Me.TextBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(194, 0)
			textBox.Location = location
			Me.TextBox1.Name = "TextBox1"
			Me.TextBox1.[ReadOnly] = True
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(473, 20)
			textBox2.Size = size
			Me.TextBox1.TabIndex = 32
			Me.L1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.L1.BackColor = Global.System.Drawing.Color.Black
			Me.L1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader6, Me.ColumnHeader7 })
			Me.L1.ContextMenuStrip = Me.ContextMenuStrip4
			Me.L1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.L1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.L1.FullRowSelect = True
			Me.L1.LargeImageList = Me.MG
			Dim l As Global.System.Windows.Forms.Control = Me.L1
			location = New Global.System.Drawing.Point(0, 0)
			l.Location = location
			Me.L1.Name = "L1"
			Me.L1.OwnerDraw = True
			Dim l2 As Global.System.Windows.Forms.Control = Me.L1
			size = New Global.System.Drawing.Size(194, 271)
			l2.Size = size
			Me.L1.SmallImageList = Me.MG
			Me.L1.TabIndex = 21
			Me.L1.UseCompatibleStateImageBehavior = False
			Me.L1.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader6.Text = "Name"
			Me.ColumnHeader6.Width = 106
			Me.ColumnHeader7.Text = "Type"
			Me.ColumnHeader7.Width = 84
			Me.p.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Dim p As Global.System.Windows.Forms.Control = Me.p
			location = New Global.System.Drawing.Point(390, 114)
			p.Location = location
			Me.p.Name = "p"
			Dim p2 As Global.System.Windows.Forms.Control = Me.p
			size = New Global.System.Drawing.Size(197, 126)
			p2.Size = size
			Me.p.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.p.TabIndex = 31
			Me.p.TabStop = False
			Me.L2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.L2.BackColor = Global.System.Drawing.Color.Black
			Me.L2.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10 })
			Me.L2.ContextMenuStrip = Me.ContextMenuStrip3
			Me.L2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.L2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.L2.FullRowSelect = True
			Me.L2.LargeImageList = Me.vmethod_108
			Dim l3 As Global.System.Windows.Forms.Control = Me.L2
			location = New Global.System.Drawing.Point(194, 21)
			l3.Location = location
			Me.L2.Name = "L2"
			Me.L2.OwnerDraw = True
			Me.L2.ShowItemToolTips = True
			Dim l4 As Global.System.Windows.Forms.Control = Me.L2
			size = New Global.System.Drawing.Size(473, 250)
			l4.Size = size
			Me.L2.SmallImageList = Me.vmethod_108
			Me.L2.TabIndex = 23
			Dim l5 As Global.System.Windows.Forms.ListView = Me.L2
			size = New Global.System.Drawing.Size(60, 40)
			l5.TileSize = size
			Me.L2.UseCompatibleStateImageBehavior = False
			Me.L2.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader8.Text = "Name"
			Me.ColumnHeader8.Width = 165
			Me.ColumnHeader9.Text = "Size"
			Me.ColumnHeader9.Width = 93
			Me.ColumnHeader10.Text = "Type"
			Me.ColumnHeader10.Width = 211
			Me.LTCP.BackColor = Global.System.Drawing.Color.Black
			Me.LTCP.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21 })
			Me.LTCP.ContextMenuStrip = Me.ContextMenuStrip1
			Me.LTCP.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.LTCP.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.LTCP.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.LTCP.FullRowSelect = True
			Me.LTCP.GridLines = True
			Dim ltcp As Global.System.Windows.Forms.Control = Me.LTCP
			location = New Global.System.Drawing.Point(0, 0)
			ltcp.Location = location
			Me.LTCP.Name = "LTCP"
			Me.LTCP.OwnerDraw = True
			Me.LTCP.ShowItemToolTips = True
			Dim ltcp2 As Global.System.Windows.Forms.Control = Me.LTCP
			size = New Global.System.Drawing.Size(667, 271)
			ltcp2.Size = size
			Me.LTCP.TabIndex = 48
			Me.LTCP.UseCompatibleStateImageBehavior = False
			Me.LTCP.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader16.Text = "LocalIP"
			Me.ColumnHeader17.Text = "LocalPort"
			Me.ColumnHeader18.Text = "RemoteIP"
			Me.ColumnHeader18.Width = 116
			Me.ColumnHeader19.Text = "RemotePort"
			Me.ColumnHeader20.Text = "State"
			Me.ColumnHeader21.Text = "Process"
			Me.ColumnHeader21.Width = 307
			Me.RG.Controls.Add(Me.RGLIST)
			Me.RG.Controls.Add(Me.RGk)
			Me.RG.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim rg As Global.System.Windows.Forms.Control = Me.RG
			location = New Global.System.Drawing.Point(0, 0)
			rg.Location = location
			Me.RG.Name = "RG"
			Dim rg2 As Global.System.Windows.Forms.Control = Me.RG
			size = New Global.System.Drawing.Size(667, 271)
			rg2.Size = size
			Me.RG.TabIndex = 52
			Me.RGLIST.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.RGLIST.BackColor = Global.System.Drawing.Color.Black
			Me.RGLIST.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5 })
			Me.RGLIST.ContextMenuStrip = Me.crg
			Me.RGLIST.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.RGLIST.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RGLIST.FullRowSelect = True
			Me.RGLIST.LargeImageList = Me.rimg
			Dim rglist As Global.System.Windows.Forms.Control = Me.RGLIST
			location = New Global.System.Drawing.Point(200, 0)
			rglist.Location = location
			Me.RGLIST.Name = "RGLIST"
			Me.RGLIST.OwnerDraw = True
			Dim rglist2 As Global.System.Windows.Forms.Control = Me.RGLIST
			size = New Global.System.Drawing.Size(467, 271)
			rglist2.Size = size
			Me.RGLIST.SmallImageList = Me.rimg
			Me.RGLIST.TabIndex = 18
			Me.RGLIST.UseCompatibleStateImageBehavior = False
			Me.RGLIST.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader3.Text = "Name"
			Me.ColumnHeader3.Width = 109
			Me.ColumnHeader4.Text = "Type"
			Me.ColumnHeader4.Width = 109
			Me.ColumnHeader5.Text = "Value"
			Me.ColumnHeader5.Width = 245
			Me.RGk.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left)
			Me.RGk.BackColor = Global.System.Drawing.Color.Black
			Me.RGk.ContextMenuStrip = Me.crgk
			Me.RGk.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.RGk.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.RGk.ImageIndex = 0
			Me.RGk.ImageList = Me.rimg
			Dim rgk As Global.System.Windows.Forms.Control = Me.RGk
			location = New Global.System.Drawing.Point(0, 0)
			rgk.Location = location
			Me.RGk.Name = "RGk"
			Me.RGk.SelectedImageIndex = 0
			Dim rgk2 As Global.System.Windows.Forms.Control = Me.RGk
			size = New Global.System.Drawing.Size(200, 271)
			rgk2.Size = size
			Me.RGk.TabIndex = 14
			Me.sh.Controls.Add(Me.T1)
			Me.sh.Controls.Add(Me.T2)
			Me.sh.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Dim sh As Global.System.Windows.Forms.Control = Me.sh
			location = New Global.System.Drawing.Point(0, 0)
			sh.Location = location
			Me.sh.Name = "sh"
			Dim sh2 As Global.System.Windows.Forms.Control = Me.sh
			size = New Global.System.Drawing.Size(667, 271)
			sh2.Size = size
			Me.sh.TabIndex = 53
			Me.T1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.T1.BackColor = Global.System.Drawing.Color.Black
			Me.T1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.T1.Cursor = Global.System.Windows.Forms.Cursors.Arrow
			Me.T1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.T1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim t As Global.System.Windows.Forms.Control = Me.T1
			location = New Global.System.Drawing.Point(0, 0)
			t.Location = location
			Me.T1.Name = "T1"
			Me.T1.[ReadOnly] = True
			Dim t2 As Global.System.Windows.Forms.Control = Me.T1
			size = New Global.System.Drawing.Size(667, 251)
			t2.Size = size
			Me.T1.TabIndex = 4
			Me.T1.Text = ""
			Me.T2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.T2.BackColor = Global.System.Drawing.Color.Gray
			Me.T2.BorderStyle = Global.System.Windows.Forms.BorderStyle.FixedSingle
			Me.T2.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.T2.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim t3 As Global.System.Windows.Forms.Control = Me.T2
			location = New Global.System.Drawing.Point(0, 251)
			t3.Location = location
			Me.T2.Name = "T2"
			Me.T2.[ReadOnly] = True
			Dim t4 As Global.System.Windows.Forms.Control = Me.T2
			size = New Global.System.Drawing.Size(667, 20)
			t4.Size = size
			Me.T2.TabIndex = 3
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(667, 345)
			Me.ClientSize = size
			Me.Controls.Add(Me.FMM)
			Me.Controls.Add(Me.ListView1)
			Me.Controls.Add(Me.StatusStrip1)
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.Name = "Manager"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Manager"
			Me.StatusStrip1.ResumeLayout(False)
			Me.StatusStrip1.PerformLayout()
			Me.M1.ResumeLayout(False)
			Me.ContextMenuStrip1.ResumeLayout(False)
			Me.crg.ResumeLayout(False)
			Me.crgk.ResumeLayout(False)
			Me.ContextMenuStrip2.ResumeLayout(False)
			Me.ContextMenuStrip3.ResumeLayout(False)
			Me.ContextMenuStrip4.ResumeLayout(False)
			Me.FMM.ResumeLayout(False)
			Me.FMM.PerformLayout()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.RG.ResumeLayout(False)
			Me.sh.ResumeLayout(False)
			Me.sh.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()
		End Sub

		' Token: 0x0400015A RID: 346
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
