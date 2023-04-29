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
	' Token: 0x0200000B RID: 11
	<DesignerGenerated()>
	Public Partial Class About
		Inherits Form

		' Token: 0x06000098 RID: 152 RVA: 0x0014B500 File Offset: 0x00149900
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.About_Load
			About.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000099 RID: 153 RVA: 0x0014B52C File Offset: 0x0014992C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = About.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = About.__ENCList.Count = About.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = About.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = About.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								About.__ENCList(num) = About.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					About.__ENCList.RemoveRange(num, About.__ENCList.Count - num)
					About.__ENCList.Capacity = About.__ENCList.Count
				End If
				About.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x0600009C RID: 156 RVA: 0x0014B8D0 File Offset: 0x00149CD0
		' (set) Token: 0x0600009D RID: 157 RVA: 0x0014B8E8 File Offset: 0x00149CE8
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x0600009E RID: 158 RVA: 0x0014B8F4 File Offset: 0x00149CF4
		' (set) Token: 0x0600009F RID: 159 RVA: 0x0014B90C File Offset: 0x00149D0C
		Friend Overridable Property RichTextBox1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RichTextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._RichTextBox1 = value
			End Set
		End Property

		' Token: 0x060000A0 RID: 160 RVA: 0x0014B918 File Offset: 0x00149D18
		Private Sub About_Load(sender As Object, e As EventArgs)
			Me.RichTextBox1.Text = Resources.RichTextBox1
		End Sub

		' Token: 0x04000047 RID: 71
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000049 RID: 73
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400004A RID: 74
		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox
	End Class
End Namespace
