Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000008 RID: 8
	Public Class LV
		Inherits ListView

		' Token: 0x06000052 RID: 82 RVA: 0x0013A330 File Offset: 0x00138730
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = LV.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = LV.__ENCList.Count = LV.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = LV.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = LV.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								LV.__ENCList(num) = LV.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					LV.__ENCList.RemoveRange(num, LV.__ENCList.Count - num)
					LV.__ENCList.Capacity = LV.__ENCList.Count
				End If
				LV.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x06000053 RID: 83 RVA: 0x0013A434 File Offset: 0x00138834
		Public Sub New()
			AddHandler MyBase.ColumnClick, AddressOf Me.ColumnClick
			LV.__ENCAddToList(Me)
			Me.AllowDrop = False
			Me.Font = New Font("arial", 8F, FontStyle.Bold)
			Me.Dock = DockStyle.Fill
			Me.FullRowSelect = True
			Me.View = View.Details
			Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.SetStyle(ControlStyles.EnableNotifyMessage, True)
		End Sub

		' Token: 0x06000054 RID: 84 RVA: 0x0013A4B8 File Offset: 0x001388B8
		Public Sub FX()
			Me.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
		End Sub

		' Token: 0x06000055 RID: 85 RVA: 0x0013A4C4 File Offset: 0x001388C4
		Protected Overrides Sub OnNotifyMessage(m As Message)
		End Sub

		' Token: 0x06000056 RID: 86 RVA: 0x0013A4F4 File Offset: 0x001388F4
		Public Sub ColumnClick(sender As Object, e As ColumnClickEventArgs)
			Dim columnHeader As ColumnHeader = CType(NewLateBinding.LateGet(sender, Nothing, "Columns", New Object() { e.Column }, Nothing, Nothing, Nothing), ColumnHeader)
			Dim flag As Boolean = Me.m_SortingColumn Is Nothing
			Dim sortOrder As SortOrder
			Dim flag2 As Boolean
			If flag Then
				sortOrder = SortOrder.Ascending
			Else
				flag = columnHeader.Equals(Me.m_SortingColumn)
				If flag Then
					flag2 = Me.m_SortingColumn.Text.StartsWith("+")
					If flag2 Then
						sortOrder = SortOrder.Descending
					Else
						sortOrder = SortOrder.Ascending
					End If
				Else
					sortOrder = SortOrder.Ascending
				End If
				Me.m_SortingColumn.Text = Me.m_SortingColumn.Text.Substring(1)
			End If
			Me.m_SortingColumn = columnHeader
			flag2 = (sortOrder = SortOrder.Ascending)
			If flag2 Then
				Me.m_SortingColumn.Text = "+" + Me.m_SortingColumn.Text
			Else
				Me.m_SortingColumn.Text = "-" + Me.m_SortingColumn.Text
			End If
			flag2 = (sender Is Nothing)
			If Not flag2 Then
				NewLateBinding.LateSet(sender, Nothing, "ListViewItemSorter", New Object() { New LV.clsListviewSorter(e.Column, sortOrder) }, Nothing, Nothing)
				NewLateBinding.LateCall(sender, Nothing, "Sort", New Object(-1) {}, Nothing, Nothing, Nothing, True)
				NewLateBinding.LateSet(sender, Nothing, "ListViewItemSorter", New Object() { Nothing }, Nothing, Nothing)
			End If
		End Sub

		' Token: 0x04000023 RID: 35
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000024 RID: 36
		Friend Selected As Object

		' Token: 0x04000025 RID: 37
		Private m_SortingColumn As ColumnHeader

		' Token: 0x02000009 RID: 9
		Public Class clsListviewSorter
			Implements IComparer

			' Token: 0x06000057 RID: 87 RVA: 0x0013A658 File Offset: 0x00138A58
			Public Sub New(column_number As Integer, sort_order As SortOrder)
				Me.m_ColumnNumber = column_number
				Me.m_SortOrder = sort_order
			End Sub

			' Token: 0x06000058 RID: 88 RVA: 0x0013A674 File Offset: 0x00138A74
			Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
				Dim listViewItem As ListViewItem = CType(x, ListViewItem)
				Dim listViewItem2 As ListViewItem = CType(y, ListViewItem)
				Dim flag As Boolean = listViewItem.SubItems.Count <= Me.m_ColumnNumber
				Dim text As String
				If flag Then
					text = ""
				Else
					text = listViewItem.SubItems(Me.m_ColumnNumber).Text
				End If
				flag = (listViewItem2.SubItems.Count <= Me.m_ColumnNumber)
				Dim text2 As String
				If flag Then
					text2 = ""
				Else
					text2 = listViewItem2.SubItems(Me.m_ColumnNumber).Text
				End If
				flag = (Me.m_SortOrder = SortOrder.Ascending)
				Dim result As Integer
				If flag Then
					Dim flag2 As Boolean = Versioned.IsNumeric(text) And Versioned.IsNumeric(text2)
					If flag2 Then
						result = Conversion.Val(text).CompareTo(Conversion.Val(text2))
					Else
						flag2 = (Information.IsDate(text) And Information.IsDate(text2))
						If flag2 Then
							result = DateTime.Parse(text).CompareTo(DateTime.Parse(text2))
						Else
							result = String.Compare(text, text2)
						End If
					End If
				Else
					Dim flag2 As Boolean = Versioned.IsNumeric(text) And Versioned.IsNumeric(text2)
					If flag2 Then
						result = Conversion.Val(text2).CompareTo(Conversion.Val(text))
					Else
						flag2 = (Information.IsDate(text) And Information.IsDate(text2))
						If flag2 Then
							result = DateTime.Parse(text2).CompareTo(DateTime.Parse(text))
						Else
							result = String.Compare(text2, text)
						End If
					End If
				End If
				Return result
			End Function

			' Token: 0x04000026 RID: 38
			Private m_ColumnNumber As Integer

			' Token: 0x04000027 RID: 39
			Private m_SortOrder As SortOrder
		End Class
	End Class
End Namespace
