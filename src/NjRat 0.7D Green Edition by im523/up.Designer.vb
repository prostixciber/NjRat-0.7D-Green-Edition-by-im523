Namespace NJRAT
	' Token: 0x02000027 RID: 39
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class up
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600054A RID: 1354 RVA: 0x001750D4 File Offset: 0x001734D4
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

		' Token: 0x0600054B RID: 1355 RVA: 0x00175124 File Offset: 0x00173524
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim listViewItem As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("File")
			Dim listViewItem2 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Size")
			Dim listViewItem3 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Speed")
			Dim listViewItem4 As Global.System.Windows.Forms.ListViewItem = New Global.System.Windows.Forms.ListViewItem("Uploaded")
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.up))
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.vmethod_4 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Lv1 = New Global.NJRAT.GClass9()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.SuspendLayout()
			Me.ProgressBar1.Dock = Global.System.Windows.Forms.DockStyle.Bottom
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 73)
			progressBar.Location = location
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(581, 23)
			progressBar2.Size = size
			Me.ProgressBar1.TabIndex = 0
			Me.Button1.Dock = Global.System.Windows.Forms.DockStyle.Right
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(506, 0)
			button.Location = location
			Me.Button1.Name = "Button1"
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(75, 73)
			button2.Size = size
			Me.Button1.TabIndex = 1
			Me.Button1.Text = "Satrt"
			Me.Button1.UseVisualStyleBackColor = True
			Me.vmethod_4.Interval = 1000
			Me.Lv1.BackColor = Global.System.Drawing.Color.Black
			Me.Lv1.BorderStyle = Global.System.Windows.Forms.BorderStyle.None
			Me.Lv1.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2 })
			Me.Lv1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.Lv1.Font = New Global.System.Drawing.Font("Arial", 8F, Global.System.Drawing.FontStyle.Bold)
			Me.Lv1.ForeColor = Global.System.Drawing.Color.LimeGreen
			Me.Lv1.FullRowSelect = True
			Me.Lv1.GridLines = True
			Me.Lv1.HeaderStyle = Global.System.Windows.Forms.ColumnHeaderStyle.None
			Me.Lv1.Items.AddRange(New Global.System.Windows.Forms.ListViewItem() { listViewItem, listViewItem2, listViewItem3, listViewItem4 })
			Dim lv As Global.System.Windows.Forms.Control = Me.Lv1
			location = New Global.System.Drawing.Point(0, 0)
			lv.Location = location
			Me.Lv1.Name = "Lv1"
			Me.Lv1.OwnerDraw = True
			Dim lv2 As Global.System.Windows.Forms.Control = Me.Lv1
			size = New Global.System.Drawing.Size(581, 73)
			lv2.Size = size
			Me.Lv1.TabIndex = 1
			Me.Lv1.UseCompatibleStateImageBehavior = False
			Me.Lv1.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader1.Width = 96
			Me.ColumnHeader2.Width = 485
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(581, 96)
			Me.ClientSize = size
			Me.Controls.Add(Me.Button1)
			Me.Controls.Add(Me.Lv1)
			Me.Controls.Add(Me.ProgressBar1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			Me.MaximizeBox = False
			Me.Name = "up"
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "up"
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x0400027A RID: 634
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
