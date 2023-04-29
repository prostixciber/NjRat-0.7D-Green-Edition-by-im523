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
	' Token: 0x02000022 RID: 34
	<DesignerGenerated()>
	Public Partial Class port
		Inherits Form

		' Token: 0x060004AA RID: 1194 RVA: 0x0016F998 File Offset: 0x0016DD98
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = NJRAT.port.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = NJRAT.port.__ENCList.Count = NJRAT.port.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = NJRAT.port.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = NJRAT.port.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								NJRAT.port.__ENCList(num) = NJRAT.port.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					NJRAT.port.__ENCList.RemoveRange(num, NJRAT.port.__ENCList.Count - num)
					NJRAT.port.__ENCList.Capacity = NJRAT.port.__ENCList.Count
				End If
				NJRAT.port.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001AA RID: 426
		' (get) Token: 0x060004AD RID: 1197 RVA: 0x0016FED8 File Offset: 0x0016E2D8
		' (set) Token: 0x060004AE RID: 1198 RVA: 0x0016FEF0 File Offset: 0x0016E2F0
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

		' Token: 0x170001AB RID: 427
		' (get) Token: 0x060004AF RID: 1199 RVA: 0x0016FF50 File Offset: 0x0016E350
		' (set) Token: 0x060004B0 RID: 1200 RVA: 0x0016FF68 File Offset: 0x0016E368
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

		' Token: 0x170001AC RID: 428
		' (get) Token: 0x060004B1 RID: 1201 RVA: 0x0016FFC8 File Offset: 0x0016E3C8
		' (set) Token: 0x060004B2 RID: 1202 RVA: 0x0016FFE0 File Offset: 0x0016E3E0
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

		' Token: 0x170001AD RID: 429
		' (get) Token: 0x060004B3 RID: 1203 RVA: 0x0016FFEC File Offset: 0x0016E3EC
		' (set) Token: 0x060004B4 RID: 1204 RVA: 0x00170004 File Offset: 0x0016E404
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

		' Token: 0x060004B5 RID: 1205 RVA: 0x00170064 File Offset: 0x0016E464
		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.port_Activated
			AddHandler MyBase.KeyDown, AddressOf Me.port_KeyDown
			AddHandler MyBase.Load, AddressOf Me.port_Load
			NJRAT.port.__ENCAddToList(Me)
			Me.port = -1
			Me.InitializeComponent()
		End Sub

		' Token: 0x060004B6 RID: 1206 RVA: 0x001700CC File Offset: 0x0016E4CC
		Private Sub port_Activated(sender As Object, e As EventArgs)
			Me.TextBox1.Focus()
		End Sub

		' Token: 0x060004B7 RID: 1207 RVA: 0x001700DC File Offset: 0x0016E4DC
		Private Sub port_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				e.SuppressKeyPress = True
				flag = Me.Button1.Enabled
				If flag Then
					Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), New EventArgs())
				End If
			Else
				flag = (e.KeyCode = Keys.Escape)
				If flag Then
					Me.port = -1
					Me.Close()
				End If
			End If
		End Sub

		' Token: 0x060004B8 RID: 1208 RVA: 0x0017014C File Offset: 0x0016E54C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.port = Conversions.ToInteger(Me.TextBox1.Text)
			Me.Close()
		End Sub

		' Token: 0x060004B9 RID: 1209 RVA: 0x00170170 File Offset: 0x0016E570
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.port = -1
			Me.Close()
		End Sub

		' Token: 0x060004BA RID: 1210 RVA: 0x00170184 File Offset: 0x0016E584
		Private Sub port_Load(sender As Object, e As EventArgs)
			Me.Icon = Resources.icon
		End Sub

		' Token: 0x060004BB RID: 1211 RVA: 0x00170194 File Offset: 0x0016E594
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Try
				Dim num As Integer = Conversions.ToInteger(Me.TextBox1.Text)
				Dim flag As Boolean = Conversions.ToInteger(Me.TextBox1.Text) > 65534 Or Conversions.ToInteger(Me.TextBox1.Text) < 1
				If flag Then
					Me.Button1.Enabled = False
				Else
					Me.Button1.Enabled = True
				End If
			Catch ex As Exception
				Me.Button1.Enabled = False
			End Try
		End Sub

		' Token: 0x04000227 RID: 551
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000229 RID: 553
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400022A RID: 554
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400022B RID: 555
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400022C RID: 556
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400022D RID: 557
		Public port As Integer
	End Class
End Namespace
