Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000040 RID: 64
	Public NotInheritable Class L1
		Inherits DataGridView

		' Token: 0x060005E9 RID: 1513 RVA: 0x001472D8 File Offset: 0x001456D8
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = L1.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = L1.__ENCList.Count = L1.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = L1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = L1.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								L1.__ENCList(num) = L1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					L1.__ENCList.RemoveRange(num, L1.__ENCList.Count - num)
					L1.__ENCList.Capacity = L1.__ENCList.Count
				End If
				L1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060005EA RID: 1514 RVA: 0x001473DC File Offset: 0x001457DC
		Public Sub New()
			L1.__ENCAddToList(Me)
			Me.collection_0 = New Collection()
			Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
			Me.DefaultCellStyle.WrapMode = DataGridViewTriState.[False]
			Me.RowHeadersVisible = False
			Me.DoubleBuffered = True
			Me.ShowCellErrors = True
			Me.ShowEditingIcon = True
			Me.ShowRowErrors = True
			Me.Font = New Font("arial", 8F, FontStyle.Bold)
			Me.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.EnableNotifyMessage Or ControlStyles.OptimizedDoubleBuffer, True)
		End Sub

		' Token: 0x060005EB RID: 1515 RVA: 0x00147470 File Offset: 0x00145870
		Public Function method_0(int_0 As Integer) As DataGridViewRow
			Return CType(Me.collection_0(int_0 + 1), DataGridViewRow)
		End Function

		' Token: 0x060005EC RID: 1516 RVA: 0x00147498 File Offset: 0x00145898
		Public Function method_1(string_0 As String) As DataGridViewRow
			Return CType(Me.collection_0(string_0), DataGridViewRow)
		End Function

		' Token: 0x060005ED RID: 1517 RVA: 0x001474BC File Offset: 0x001458BC
		Public Sub method_10(int_0 As Integer)
			Dim invokeRequired As Boolean = Me.InvokeRequired
			If invokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Me.Invoke(AddressOf Me.method_10, New Object() { int_0 })
					Return
				End SyncLock
			End If
			Me.Rows.RemoveAt(int_0)
		End Sub

		' Token: 0x060005EE RID: 1518 RVA: 0x0014753C File Offset: 0x0014593C
		Public Sub method_11(string_0 As String, genum0_0 As L1.GEnum0, dataGridViewAutoSizeColumnMode_0 As DataGridViewAutoSizeColumnMode)
			Dim collection As Collection = Me.collection_0
			Dim obj As Collection = collection
			SyncLock obj
				Dim dataGridViewColumn As DataGridViewColumn = Nothing
				Select Case genum0_0
					Case L1.GEnum0.Text
						dataGridViewColumn = New DataGridViewTextBoxColumn()
					Case L1.GEnum0.Link
						dataGridViewColumn = New DataGridViewLinkColumn()
					Case L1.GEnum0.Image
						Dim dataGridViewImageColumn As DataGridViewImageColumn = New DataGridViewImageColumn() With { .ImageLayout = DataGridViewImageCellLayout.Zoom }
						dataGridViewColumn = dataGridViewImageColumn
					Case L1.GEnum0.StretchImage
						Dim dataGridViewImageColumn As DataGridViewImageColumn = New DataGridViewImageColumn() With { .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewColumn = dataGridViewImageColumn
				End Select
				dataGridViewColumn.AutoSizeMode = dataGridViewAutoSizeColumnMode_0
				dataGridViewColumn.Tag = genum0_0
				dataGridViewColumn.HeaderText = string_0
				Me.Columns.Add(dataGridViewColumn)
			End SyncLock
		End Sub

		' Token: 0x060005EF RID: 1519 RVA: 0x00147610 File Offset: 0x00145A10
		Public Function method_2(string_0 As String) As Boolean
			Return Me.collection_0.Contains(string_0)
		End Function

		' Token: 0x060005F0 RID: 1520 RVA: 0x00147630 File Offset: 0x00145A30
		Public Function method_3() As DataGridViewRow()
			Dim list As List(Of DataGridViewRow) = New List(Of DataGridViewRow)()
			Dim flag As Boolean = Me.RowCount = 0
			Dim result As DataGridViewRow()
			If flag Then
				result = list.ToArray()
			Else
				Try
					Dim num As Integer = Me.FirstDisplayedScrollingRowIndex + Me.DisplayedRowCount(False)
					For i As Integer = Me.FirstDisplayedScrollingRowIndex To num
						flag = (i > Me.RowCount - 1)
						If flag Then
							Exit For
						End If
						Try
							list.Add(Me.Rows(i))
						Catch ex As Exception
							Exit Try
						End Try
					Next
				Catch ex2 As Exception
				End Try
				result = list.ToArray()
			End If
			Return result
		End Function

		' Token: 0x060005F1 RID: 1521 RVA: 0x00147728 File Offset: 0x00145B28
		Public Sub method_4()
			Dim collection As Collection = Me.collection_0
			Dim obj As Collection = collection
			SyncLock obj
				Me.Rows.Clear()
				Me.collection_0.Clear()
			End SyncLock
		End Sub

		' Token: 0x060005F2 RID: 1522 RVA: 0x0014777C File Offset: 0x00145B7C
		Public Function method_5(object_0 As Object()) As DataGridViewRow
			Dim invokeRequired As Boolean = Me.InvokeRequired
			If invokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Return CType(Me.Invoke(AddressOf Me.method_5, object_0), DataGridViewRow)
				End SyncLock
			End If
			Dim dataGridViewRow As DataGridViewRow = New DataGridViewRow()
			Dim num As Integer = Me.ColumnCount - 1
			For i As Integer = 0 To num
				Select Case Conversions.ToInteger(RuntimeHelpers.GetObjectValue(Me.Columns(i).Tag))
					Case 0
						Dim dataGridViewCell As DataGridViewTextBoxCell = New DataGridViewTextBoxCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell)
					Case 1
						Dim dataGridViewCell2 As DataGridViewLinkCell = New DataGridViewLinkCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell2)
					Case 2
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Normal }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
					Case 3
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
				End Select
			Next
			dataGridViewRow.Resizable = DataGridViewTriState.[False]
			Me.collection_0.Add(dataGridViewRow, Nothing, Nothing, Nothing)
			Me.Rows.Add(dataGridViewRow)
			Return dataGridViewRow
		End Function

		' Token: 0x060005F3 RID: 1523 RVA: 0x00147978 File Offset: 0x00145D78
		Public Function method_6() As Integer
			Return Me.RowTemplate.Height
		End Function

		' Token: 0x060005F4 RID: 1524 RVA: 0x00147998 File Offset: 0x00145D98
		Public Sub method_7(int_0 As Integer)
			Me.RowTemplate.Height = int_0
		End Sub

		' Token: 0x060005F5 RID: 1525 RVA: 0x001479AC File Offset: 0x00145DAC
		Public Function method_8(string_0 As String, object_0 As Object()) As DataGridViewRow
			Dim invokeRequired As Boolean = Me.InvokeRequired
			If invokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Return CType(Me.Invoke(AddressOf Me.method_8, New Object() { string_0, object_0 }), DataGridViewRow)
				End SyncLock
			End If
			Dim dataGridViewRow As DataGridViewRow = New DataGridViewRow() With { .Height = Me.method_6() }
			Dim num As Integer = Me.ColumnCount - 1
			For i As Integer = 0 To num
				Select Case Conversions.ToInteger(RuntimeHelpers.GetObjectValue(Me.Columns(i).Tag))
					Case 0
						Dim dataGridViewCell As DataGridViewTextBoxCell = New DataGridViewTextBoxCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell)
					Case 1
						Dim dataGridViewCell2 As DataGridViewLinkCell = New DataGridViewLinkCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell2)
					Case 2
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Zoom }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
					Case 3
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
				End Select
			Next
			dataGridViewRow.Resizable = DataGridViewTriState.[False]
			Me.collection_0.Add(dataGridViewRow, string_0, Nothing, Nothing)
			Me.Rows.Add(dataGridViewRow)
			Return dataGridViewRow
		End Function

		' Token: 0x060005F6 RID: 1526 RVA: 0x00147BD0 File Offset: 0x00145FD0
		Public Sub method_9(dataGridViewRow_0 As DataGridViewRow)
			Dim invokeRequired As Boolean = Me.InvokeRequired
			If invokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Me.Invoke(AddressOf Me.method_9, New Object() { dataGridViewRow_0 })
					Return
				End SyncLock
			End If
			Me.Rows.Remove(dataGridViewRow_0)
		End Sub

		' Token: 0x060005F7 RID: 1527 RVA: 0x00147C48 File Offset: 0x00146048
		Protected Overrides Sub OnMouseUp(mouseEventArgs_0 As MouseEventArgs)
			Dim flag As Boolean = mouseEventArgs_0.Button = MouseButtons.Right
			If flag Then
				Try
					Dim hitTestInfo As DataGridView.HitTestInfo = Me.HitTest(mouseEventArgs_0.X, mouseEventArgs_0.Y)
					flag = (hitTestInfo.RowIndex <> -1)
					If flag Then
						Dim dataGridViewRow As DataGridViewRow = Me.Rows(hitTestInfo.RowIndex)
						flag = Not dataGridViewRow.Selected
						If flag Then
							Me.ClearSelection()
							dataGridViewRow.Selected = True
						End If
					End If
				Catch ex As Exception
				End Try
			End If
			MyBase.OnMouseUp(mouseEventArgs_0)
		End Sub

		' Token: 0x060005F8 RID: 1528 RVA: 0x00147CF4 File Offset: 0x001460F4
		Protected Overrides Sub OnMouseWheel(mouseEventArgs_0 As MouseEventArgs)
			MyBase.OnMouseWheel(mouseEventArgs_0)
			Try
				Dim delta As Integer = mouseEventArgs_0.Delta
				Dim flag As Boolean = delta = 120
				If flag Then
					Me.FirstDisplayedScrollingRowIndex = Math.Max(0, Me.FirstDisplayedScrollingRowIndex - SystemInformation.MouseWheelScrollLines)
				Else
					flag = (delta = -120)
					If flag Then
						Me.FirstDisplayedScrollingRowIndex += SystemInformation.MouseWheelScrollLines
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005F9 RID: 1529 RVA: 0x00147D8C File Offset: 0x0014618C
		Protected Overrides Sub OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0 As DataGridViewRowPostPaintEventArgs)
			Try
				Dim dataGridViewRow As DataGridViewRow = Me.Rows(dataGridViewRowPostPaintEventArgs_0.RowIndex)
				Dim flag As Boolean = dataGridViewRow.Height <> Me.method_6()
				If flag Then
					dataGridViewRow.Height = Me.method_6()
				End If
			Catch ex As Exception
			End Try
			MyBase.OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0)
		End Sub

		' Token: 0x0400034D RID: 845
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400034E RID: 846
		Private collection_0 As Collection

		' Token: 0x02000041 RID: 65
		' (Invoke) Token: 0x060005FD RID: 1533
		Private Delegate Function Delegate1(object_0 As Object()) As DataGridViewRow

		' Token: 0x02000042 RID: 66
		' (Invoke) Token: 0x06000601 RID: 1537
		Private Delegate Function Delegate2(string_0 As String, object_0 As Object()) As DataGridViewRow

		' Token: 0x02000043 RID: 67
		' (Invoke) Token: 0x06000605 RID: 1541
		Private Delegate Sub Delegate3(dataGridViewRow_0 As DataGridViewRow)

		' Token: 0x02000044 RID: 68
		' (Invoke) Token: 0x06000609 RID: 1545
		Private Delegate Sub Delegate4(int_0 As Integer)

		' Token: 0x02000045 RID: 69
		Public Enum GEnum0
			' Token: 0x04000350 RID: 848
			Image = 2
			' Token: 0x04000351 RID: 849
			Link = 1
			' Token: 0x04000352 RID: 850
			StretchImage = 3
			' Token: 0x04000353 RID: 851
			Text = 0
		End Enum
	End Class
End Namespace
