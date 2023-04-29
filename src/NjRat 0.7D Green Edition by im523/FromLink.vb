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
	' Token: 0x02000012 RID: 18
	<DesignerGenerated()>
	Public Partial Class FromLink
		Inherits Form

		' Token: 0x060001EC RID: 492 RVA: 0x00159184 File Offset: 0x00157584
		<DebuggerNonUserCode()>
		Public Sub New()
			FromLink.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x060001ED RID: 493 RVA: 0x0015919C File Offset: 0x0015759C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FromLink.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = FromLink.__ENCList.Count = FromLink.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FromLink.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FromLink.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								FromLink.__ENCList(num) = FromLink.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FromLink.__ENCList.RemoveRange(num, FromLink.__ENCList.Count - num)
					FromLink.__ENCList.Capacity = FromLink.__ENCList.Count
				End If
				FromLink.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000AF RID: 175
		' (get) Token: 0x060001F0 RID: 496 RVA: 0x001597A4 File Offset: 0x00157BA4
		' (set) Token: 0x060001F1 RID: 497 RVA: 0x001597BC File Offset: 0x00157BBC
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

		' Token: 0x170000B0 RID: 176
		' (get) Token: 0x060001F2 RID: 498 RVA: 0x0015981C File Offset: 0x00157C1C
		' (set) Token: 0x060001F3 RID: 499 RVA: 0x00159834 File Offset: 0x00157C34
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

		' Token: 0x170000B1 RID: 177
		' (get) Token: 0x060001F4 RID: 500 RVA: 0x00159894 File Offset: 0x00157C94
		' (set) Token: 0x060001F5 RID: 501 RVA: 0x001598AC File Offset: 0x00157CAC
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextAlignChanged
				Dim flag As Boolean = Me._TextBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox1.TextAlignChanged, value2
				End If
				Me._TextBox1 = value
				flag = (Me._TextBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._TextBox1.TextAlignChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000B2 RID: 178
		' (get) Token: 0x060001F6 RID: 502 RVA: 0x0015990C File Offset: 0x00157D0C
		' (set) Token: 0x060001F7 RID: 503 RVA: 0x00159924 File Offset: 0x00157D24
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		' Token: 0x170000B3 RID: 179
		' (get) Token: 0x060001F8 RID: 504 RVA: 0x00159930 File Offset: 0x00157D30
		' (set) Token: 0x060001F9 RID: 505 RVA: 0x00159948 File Offset: 0x00157D48
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

		' Token: 0x170000B4 RID: 180
		' (get) Token: 0x060001FA RID: 506 RVA: 0x00159954 File Offset: 0x00157D54
		' (set) Token: 0x060001FB RID: 507 RVA: 0x0015996C File Offset: 0x00157D6C
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x060001FC RID: 508 RVA: 0x00159978 File Offset: 0x00157D78
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.IsOK = True
			Me.Close()
		End Sub

		' Token: 0x060001FD RID: 509 RVA: 0x0015998C File Offset: 0x00157D8C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060001FE RID: 510 RVA: 0x00159998 File Offset: 0x00157D98
		Private Sub TextBox1_TextAlignChanged(sender As Object, e As EventArgs)
			Try
				Me.TextBox2.Text = Strings.Split(Me.TextBox1.Text, "\", -1, CompareMethod.Binary)(Strings.Split(Me.TextBox1.Text, "\", -1, CompareMethod.Binary).Length - 1)
			Catch ex As Exception
				Me.TextBox2.Text = "File.txt"
			End Try
		End Sub

		' Token: 0x040000E3 RID: 227
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000E5 RID: 229
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000E6 RID: 230
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040000E7 RID: 231
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040000E8 RID: 232
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040000E9 RID: 233
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040000EA RID: 234
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x040000EB RID: 235
		Public IsOK As Boolean
	End Class
End Namespace
