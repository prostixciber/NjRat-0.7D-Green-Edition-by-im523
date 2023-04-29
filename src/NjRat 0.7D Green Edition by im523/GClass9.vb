Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000037 RID: 55
	<DesignerGenerated()>
	Public NotInheritable Class GClass9
		Inherits ListView

		' Token: 0x060005C6 RID: 1478 RVA: 0x00145F64 File Offset: 0x00144364
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = GClass9.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = GClass9.__ENCList.Count = GClass9.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = GClass9.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = GClass9.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								GClass9.__ENCList(num) = GClass9.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					GClass9.__ENCList.RemoveRange(num, GClass9.__ENCList.Count - num)
					GClass9.__ENCList.Capacity = GClass9.__ENCList.Count
				End If
				GClass9.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060005C7 RID: 1479 RVA: 0x00146068 File Offset: 0x00144468
		Public Sub New()
			GClass9.__ENCAddToList(Me)
			AddHandler MyBase.ParentChanged, AddressOf Me.GClass9_ParentChanged
			AddHandler MyBase.MouseMove, AddressOf Me.GClass9_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.GClass9_MouseUp
			AddHandler MyBase.ColumnClick, AddressOf Me.GClass9_ColumnClick
			AddHandler MyBase.KeyDown, AddressOf Me.GClass9_KeyDown
			AddHandler MyBase.MouseDown, AddressOf Me.GClass9_MouseDown
			Me.listViewItem_0 = Nothing
			Me.point_0 = Point.Empty
			Me.point_1 = Point.Empty
			Me.AllowDrop = False
			Me.Font = New Font("arial", 8F, FontStyle.Bold)
			Me.Dock = DockStyle.Fill
			Me.FullRowSelect = True
			Me.View = View.Details
			Me.OwnerDraw = True
			Me.SetStyle(ControlStyles.UserPaint, False)
			Me.DoubleBuffered = True
			Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.SetStyle(ControlStyles.EnableNotifyMessage, True)
		End Sub

		' Token: 0x060005C8 RID: 1480 RVA: 0x00146184 File Offset: 0x00144584
		<CompilerGenerated()>
		<DebuggerStepThrough()>
		Private Sub lam__3(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x060005C9 RID: 1481 RVA: 0x00146190 File Offset: 0x00144590
		<CompilerGenerated()>
		<DebuggerStepThrough()>
		Private Sub lam__4(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x060005CA RID: 1482 RVA: 0x0014619C File Offset: 0x0014459C
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.icontainer_0 IsNot Nothing
				If flag Then
					Me.icontainer_0.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x060005CB RID: 1483 RVA: 0x001461EC File Offset: 0x001445EC
		Public Sub GClass9_ColumnClick(sender As Object, e As ColumnClickEventArgs)
			SyncLock Me
				Dim flag As Boolean = e.Column <> -1
				If flag Then
					Try
						Dim columnHeader As ColumnHeader = CType(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(sender), Nothing, "Columns", New Object() { e.Column }, Nothing, Nothing, Nothing), ColumnHeader)
						flag = (Me.columnHeader_0 Is Nothing)
						Dim sortOrder_ As SortOrder
						Dim flag2 As Boolean
						If flag Then
							sortOrder_ = SortOrder.Ascending
							columnHeader.Tag = "+"
						Else
							flag = columnHeader.Equals(Me.columnHeader_0)
							If flag Then
								flag2 = Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(Me.columnHeader_0.Tag), "+", False)
								If flag2 Then
									sortOrder_ = SortOrder.Descending
									Me.columnHeader_0.Tag = "-"
								Else
									Me.columnHeader_0.Tag = "+"
									sortOrder_ = SortOrder.Ascending
								End If
							Else
								sortOrder_ = SortOrder.Ascending
							End If
						End If
						Me.columnHeader_0 = columnHeader
						flag2 = (Me.columnHeader_0.Tag Is Nothing)
						If flag2 Then
							Me.columnHeader_0.Tag = "+"
						End If
						flag2 = (sender IsNot Nothing)
						If flag2 Then
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), Nothing, "ListViewItemSorter", New Object() { New GClass9.GClass10(e.Column, sortOrder_) }, Nothing, Nothing)
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(sender), Nothing, "Sort", New Object(-1) {}, Nothing, Nothing, Nothing, True)
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), Nothing, "ListViewItemSorter", New Object() { Nothing }, Nothing, Nothing)
						End If
					Catch ex As Exception
					End Try
				End If
			End SyncLock
		End Sub

		' Token: 0x060005CC RID: 1484 RVA: 0x001463E0 File Offset: 0x001447E0
		Private Sub GClass9_KeyDown(sender As Object, e As KeyEventArgs)
			Dim flag As Boolean = e.KeyCode = Keys.Space
			If flag Then
				Me.method_3()
			End If
			flag = (e.KeyCode = Keys.A And e.Control)
			If flag Then
				Try
					For Each obj As Object In Me.Items
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						listViewItem.Selected = True
					Next
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x060005CD RID: 1485 RVA: 0x00146478 File Offset: 0x00144878
		Private Sub GClass9_MouseDown(sender As Object, e As MouseEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Me.listViewItem_0 = Me.GetItemAt(e.X, e.Y)
				Me.point_0 = e.Location
			End If
		End Sub

		' Token: 0x060005CE RID: 1486 RVA: 0x001464C0 File Offset: 0x001448C0
		Private Sub GClass9_MouseMove(sender As Object, e As MouseEventArgs)
			Me.point_1 = e.Location
			Dim flag As Boolean = Me.point_0 <> Point.Empty
			If flag Then
				Dim flag2 As Boolean = Me.listViewItem_0 IsNot Nothing AndAlso Me.listViewItem_0.Index = -1
				If flag2 Then
					Me.listViewItem_0 = Nothing
				End If
				flag2 = ((e.Button = MouseButtons.Left And Me.listViewItem_0 IsNot Nothing) AndAlso Me.listViewItem_0 IsNot Nothing)
				If flag2 Then
					Dim itemAt As ListViewItem = Me.GetItemAt(e.X, e.Y)
					flag2 = (itemAt IsNot Nothing)
					If flag2 Then
						flag = (itemAt.Index > Me.listViewItem_0.Index)
						If flag Then
							Dim index As Integer = itemAt.Index
							For i As Integer = Me.listViewItem_0.Index To index
								flag2 = Not Me.SelectedIndices.Contains(i)
								If flag2 Then
									Me.SelectedIndices.Add(i)
								End If
							Next
							Try
								For Each obj As Object In Me.SelectedIndices
									Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj)))
									flag2 = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue), Me.listViewItem_0.Index, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue), itemAt.Index, False)))))
									If flag2 Then
										Me.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue)))
									End If
								Next
								Return
							Finally
								Dim enumerator As IEnumerator
								flag2 = (TypeOf enumerator Is IDisposable)
								If flag2 Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
						End If
						Dim index2 As Integer = Me.listViewItem_0.Index
						For j As Integer = itemAt.Index To index2
							flag2 = Not Me.SelectedIndices.Contains(j)
							If flag2 Then
								Me.SelectedIndices.Add(j)
							End If
						Next
						Try
							For Each obj2 As Object In Me.SelectedIndices
								Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj2)))
								flag2 = Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue2), itemAt.Index, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue2), Me.listViewItem_0.Index, False)))))
								If flag2 Then
									Me.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue2)))
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							flag2 = (TypeOf enumerator2 Is IDisposable)
							If flag2 Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
				End If
			End If
		End Sub

		' Token: 0x060005CF RID: 1487 RVA: 0x001467E4 File Offset: 0x00144BE4
		Private Sub GClass9_MouseUp(sender As Object, e As MouseEventArgs)
			Me.listViewItem_0 = Nothing
			Me.point_0 = Point.Empty
		End Sub

		' Token: 0x060005D0 RID: 1488 RVA: 0x001467FC File Offset: 0x00144BFC
		Private Sub GClass9_ParentChanged(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.Parent IsNot Nothing
				If flag Then
					RemoveHandler Me.Parent.Resize, AddressOf Me.lam__3
				End If
				AddHandler Me.Parent.Resize, AddressOf Me.lam__4
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005D1 RID: 1489 RVA: 0x00146880 File Offset: 0x00144C80
		<DebuggerStepThrough()>
		Private Sub method_0()
			Me.icontainer_0 = New Container()
		End Sub

		' Token: 0x060005D2 RID: 1490 RVA: 0x00146890 File Offset: 0x00144C90
		Public Sub method_1()
			Me.method_3()
		End Sub

		' Token: 0x060005D3 RID: 1491 RVA: 0x0014689C File Offset: 0x00144C9C
		Public Function method_2() As ListViewItem()
			Dim result As ListViewItem()
			SyncLock Me
				Dim list As List(Of ListViewItem) = New List(Of ListViewItem)()
				Dim flag As Boolean = Me.Items.Count = 0
				If flag Then
					Return list.ToArray()
				End If
				Try
					Dim listViewItem As ListViewItem = Me.TopItem
					list.Add(listViewItem)
					Dim num As Integer = Me.Items.Count - 1
					For i As Integer = listViewItem.Index + 1 To num
						Try
							listViewItem = Me.Items(i)
							flag = Me.Bounds.IntersectsWith(Me.Items(i).Bounds)
							If Not flag Then
								Exit Try
							End If
							list.Add(listViewItem)
						Catch ex As Exception
							Exit Try
						End Try
					Next
				Catch ex2 As Exception
				End Try
				result = list.ToArray()
			End SyncLock
			Return result
		End Function

		' Token: 0x060005D4 RID: 1492 RVA: 0x00146A20 File Offset: 0x00144E20
		Public Sub method_3()
			Try
				Dim flag As Boolean = Me.Columns.Count <> 0
				If flag Then
					Dim flag2 As Boolean = Me.Items.Count = 0
					If flag2 Then
						Me.Columns(Me.Columns.Count - 1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
					Else
						Dim num As Integer = Me.Columns.Count - 1
						For i As Integer = 0 To num
							Me.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
						Next
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005D5 RID: 1493 RVA: 0x00146AE4 File Offset: 0x00144EE4
		Protected Overrides Sub OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0 As DrawListViewColumnHeaderEventArgs)
			Try
				Dim format As StringFormat = New StringFormat() With { .FormatFlags = StringFormatFlags.NoWrap, .Trimming = StringTrimming.EllipsisCharacter, .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near }
				Dim rect As Rectangle = New Rectangle(drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.Width, drawListViewColumnHeaderEventArgs_0.Bounds.Height)
				drawListViewColumnHeaderEventArgs_0.Graphics.FillRectangle(New Pen(ControlPaint.Light(Me.BackColor, 0.1F)).Brush, rect)
				drawListViewColumnHeaderEventArgs_0.Graphics.DrawString(drawListViewColumnHeaderEventArgs_0.Header.Text, Me.Font, New Pen(Me.ForeColor).Brush, drawListViewColumnHeaderEventArgs_0.Bounds, format)
				drawListViewColumnHeaderEventArgs_0.Graphics.DrawLine(New Pen(Me.ForeColor), drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y + drawListViewColumnHeaderEventArgs_0.Bounds.Height)
				drawListViewColumnHeaderEventArgs_0.DrawDefault = False
			Catch ex As Exception
			End Try
			MyBase.OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0)
		End Sub

		' Token: 0x060005D6 RID: 1494 RVA: 0x00146C74 File Offset: 0x00145074
		Protected Overrides Sub OnDrawItem(drawListViewItemEventArgs_0 As DrawListViewItemEventArgs)
			drawListViewItemEventArgs_0.DrawDefault = True
			MyBase.OnDrawItem(drawListViewItemEventArgs_0)
		End Sub

		' Token: 0x060005D7 RID: 1495 RVA: 0x00146C88 File Offset: 0x00145088
		Protected Overrides Sub OnDrawSubItem(drawListViewSubItemEventArgs_0 As DrawListViewSubItemEventArgs)
			drawListViewSubItemEventArgs_0.DrawDefault = True
			MyBase.OnDrawSubItem(drawListViewSubItemEventArgs_0)
		End Sub

		' Token: 0x060005D8 RID: 1496 RVA: 0x00146C9C File Offset: 0x0014509C
		Protected Overrides Sub OnNotifyMessage(message_0 As Message)
			Dim flag As Boolean = message_0.Msg <> 20
			If flag Then
				MyBase.OnNotifyMessage(message_0)
			End If
		End Sub

		' Token: 0x04000324 RID: 804
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000325 RID: 805
		Public columnHeader_0 As ColumnHeader

		' Token: 0x04000326 RID: 806
		Private icontainer_0 As IContainer

		' Token: 0x04000327 RID: 807
		Private listViewItem_0 As ListViewItem

		' Token: 0x04000328 RID: 808
		Private point_0 As Point

		' Token: 0x04000329 RID: 809
		Private point_1 As Point

		' Token: 0x02000038 RID: 56
		Public NotInheritable Class GClass10
			Implements IComparer

			' Token: 0x060005D9 RID: 1497 RVA: 0x00146CC8 File Offset: 0x001450C8
			Public Sub New(int_1 As Integer, sortOrder_1 As SortOrder)
				Me.int_0 = int_1
				Me.sortOrder_0 = sortOrder_1
			End Sub

			' Token: 0x060005DA RID: 1498 RVA: 0x00146CE4 File Offset: 0x001450E4
			Public Function Compare(object_0 As Object, object_1 As Object) As Integer
				Dim listViewItem As ListViewItem = CType(object_0, ListViewItem)
				Dim listViewItem2 As ListViewItem = CType(object_1, ListViewItem)
				Dim flag As Boolean = listViewItem.SubItems.Count <= Me.int_0
				Dim text As String
				If flag Then
					text = String.Empty
				Else
					text = listViewItem.SubItems(Me.int_0).Text
				End If
				flag = (listViewItem2.SubItems.Count <= Me.int_0)
				Dim text2 As String
				If flag Then
					text2 = String.Empty
				Else
					text2 = listViewItem2.SubItems(Me.int_0).Text
				End If
				flag = (Me.sortOrder_0 = SortOrder.Ascending)
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

			' Token: 0x060005DB RID: 1499 RVA: 0x00146E60 File Offset: 0x00145260
			Public Function Compare1(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
				Dim result As Integer
				Return result
			End Function

			' Token: 0x0400032A RID: 810
			Private int_0 As Integer

			' Token: 0x0400032B RID: 811
			Private sortOrder_0 As SortOrder
		End Class
	End Class
End Namespace
