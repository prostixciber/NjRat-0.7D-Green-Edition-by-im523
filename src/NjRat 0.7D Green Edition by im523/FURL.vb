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
	' Token: 0x02000014 RID: 20
	<DesignerGenerated()>
	Public Partial Class FURL
		Inherits Form

		' Token: 0x060002DA RID: 730 RVA: 0x00160050 File Offset: 0x0015E450
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FURL.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = FURL.__ENCList.Count = FURL.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FURL.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FURL.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								FURL.__ENCList(num) = FURL.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FURL.__ENCList.RemoveRange(num, FURL.__ENCList.Count - num)
					FURL.__ENCList.Capacity = FURL.__ENCList.Count
				End If
				FURL.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700010C RID: 268
		' (get) Token: 0x060002DD RID: 733 RVA: 0x00160648 File Offset: 0x0015EA48
		' (set) Token: 0x060002DE RID: 734 RVA: 0x00160660 File Offset: 0x0015EA60
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

		' Token: 0x1700010D RID: 269
		' (get) Token: 0x060002DF RID: 735 RVA: 0x0016066C File Offset: 0x0015EA6C
		' (set) Token: 0x060002E0 RID: 736 RVA: 0x00160684 File Offset: 0x0015EA84
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

		' Token: 0x1700010E RID: 270
		' (get) Token: 0x060002E1 RID: 737 RVA: 0x00160690 File Offset: 0x0015EA90
		' (set) Token: 0x060002E2 RID: 738 RVA: 0x001606A8 File Offset: 0x0015EAA8
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

		' Token: 0x1700010F RID: 271
		' (get) Token: 0x060002E3 RID: 739 RVA: 0x001606B4 File Offset: 0x0015EAB4
		' (set) Token: 0x060002E4 RID: 740 RVA: 0x001606CC File Offset: 0x0015EACC
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextAlignChanged
				Dim value3 As EventHandler = AddressOf Me.TextBox1_TextChanged
				Dim flag As Boolean = Me._TextBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox1.TextAlignChanged, value2
					RemoveHandler Me._TextBox1.TextChanged, value3
				End If
				Me._TextBox1 = value
				flag = (Me._TextBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._TextBox1.TextAlignChanged, value2
					AddHandler Me._TextBox1.TextChanged, value3
				End If
			End Set
		End Property

		' Token: 0x17000110 RID: 272
		' (get) Token: 0x060002E5 RID: 741 RVA: 0x00160754 File Offset: 0x0015EB54
		' (set) Token: 0x060002E6 RID: 742 RVA: 0x0016076C File Offset: 0x0015EB6C
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

		' Token: 0x17000111 RID: 273
		' (get) Token: 0x060002E7 RID: 743 RVA: 0x001607CC File Offset: 0x0015EBCC
		' (set) Token: 0x060002E8 RID: 744 RVA: 0x001607E4 File Offset: 0x0015EBE4
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

		' Token: 0x060002E9 RID: 745 RVA: 0x00160844 File Offset: 0x0015EC44
		Public Sub New()
			AddHandler MyBase.KeyDown, AddressOf Me.FURL_KeyDown
			FURL.__ENCAddToList(Me)
			Me.IsOK = False
			Me.InitializeComponent()
		End Sub

		' Token: 0x060002EA RID: 746 RVA: 0x00160878 File Offset: 0x0015EC78
		Private Sub FURL_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.[Return]
			If flag Then
				Me.Button1_Click(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
			End If
		End Sub

		' Token: 0x060002EB RID: 747 RVA: 0x001608B0 File Offset: 0x0015ECB0
		Private Sub TextBox1_TextAlignChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060002EC RID: 748 RVA: 0x001608B4 File Offset: 0x0015ECB4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.TextBox1.Text.Length > 0 And Me.TextBox1.Text.ToLower().StartsWith("http") And Me.TextBox2.TextLength > 0
			If flag Then
				Me.IsOK = True
				Me.Close()
			End If
		End Sub

		' Token: 0x060002ED RID: 749 RVA: 0x00160914 File Offset: 0x0015ED14
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060002EE RID: 750 RVA: 0x00160920 File Offset: 0x0015ED20
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
			Try
				Me.TextBox2.Text = Strings.Split(Me.TextBox1.Text, ".", -1, CompareMethod.Binary)(Strings.Split(Me.TextBox1.Text, ".", -1, CompareMethod.Binary).Length - 1)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x04000142 RID: 322
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000144 RID: 324
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000145 RID: 325
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000146 RID: 326
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x04000147 RID: 327
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000148 RID: 328
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000149 RID: 329
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400014A RID: 330
		Public IsOK As Boolean
	End Class
End Namespace
