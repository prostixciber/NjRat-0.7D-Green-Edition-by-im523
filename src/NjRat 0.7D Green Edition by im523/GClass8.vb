Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000036 RID: 54
	Public NotInheritable Class GClass8
		Inherits PictureBox

		' Token: 0x060005BE RID: 1470 RVA: 0x001459F0 File Offset: 0x00143DF0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = GClass8.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = GClass8.__ENCList.Count = GClass8.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = GClass8.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = GClass8.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								GClass8.__ENCList(num) = GClass8.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					GClass8.__ENCList.RemoveRange(num, GClass8.__ENCList.Count - num)
					GClass8.__ENCList.Capacity = GClass8.__ENCList.Count
				End If
				GClass8.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060005BF RID: 1471 RVA: 0x00145AF4 File Offset: 0x00143EF4
		Public Sub New()
			GClass8.__ENCAddToList(Me)
			Me.fonty = New Font("arial", 8F, FontStyle.Bold)
			Me.Lines = New List(Of Object())()
			Dim t As Timer = New Timer() With { .Interval = 50, .Enabled = False }
			Me.T = t
			Me.SizeMode = PictureBoxSizeMode.Normal
		End Sub

		' Token: 0x060005C0 RID: 1472 RVA: 0x00145B5C File Offset: 0x00143F5C
		<DebuggerStepThrough()>
		<CompilerGenerated()>
		Private Sub lam__4(a0 As Object, a1 As EventArgs)
			Try
				Me.wrk()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005C1 RID: 1473 RVA: 0x00145B98 File Offset: 0x00143F98
		Public Sub wrk()
			Try
				Me.T.Enabled = False
				SyncLock Me
					Dim image As Bitmap = New Bitmap(Me.Width, Me.Height)
					Me.G = Graphics.FromImage(image)
					Me.G.Clear(Color.Black)
					Dim num As Integer = 3
					Dim height As Integer = TextRenderer.MeasureText("test", Me.Font).Height
					Dim color As Color = Color.White
					For i As Integer = Me.Lines.Count - 1 To 0 Step -1
						Dim num2 As Integer = 3
						Dim array As Object() = Me.Lines(i)
						Dim num3 As Integer = array.Length - 1
						For j As Integer = 0 To num3
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array(j))))))))
							Dim left As String = objectValue.[GetType]().ToString()
							Dim flag As Boolean = Operators.CompareString(left, GetType(Bitmap).ToString(), False) = 0
							If flag Then
								Dim bitmap As Bitmap = CType(objectValue, Bitmap)
								flag = (bitmap.Height > height)
								If flag Then
									Dim callbackData As IntPtr
									bitmap = CType(bitmap.GetThumbnailImage(height, height, Nothing, callbackData), Bitmap)
								End If
								Me.G.DrawImage(bitmap, num2, num)
								num2 += bitmap.Width + 3
							Else
								flag = (Operators.CompareString(left, GetType(String).ToString(), False) = 0)
								If flag Then
									Dim text As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(objectValue))))
									Dim size As Size = TextRenderer.MeasureText(text, Me.Font)
									Me.G.DrawString(text, Me.Font, New Pen(color).Brush, CSng(num2), CSng(num))
									flag = (size.Height - height > 0)
									If flag Then
										num += size.Height - height
										num2 = 3
									Else
										num2 += size.Width + 3
									End If
								Else
									flag = (Operators.CompareString(left, GetType(Color).ToString(), False) = 0)
									If flag Then
										color = CType(objectValue, Color)
									End If
								End If
							End If
						Next
						num += height
					Next
					Me.G.Dispose()
					Me.Image = image
				End SyncLock
				Me.T.Enabled = True
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060005C2 RID: 1474 RVA: 0x00145E74 File Offset: 0x00144274
		Public Sub WRT(ParamArray A As Object())
			SyncLock Me
				Me.Lines.Add(A)
				Dim flag As Boolean = Me.Lines.Count = 100
				If flag Then
					Me.Lines.RemoveAt(0)
				End If
			End SyncLock
		End Sub

		' Token: 0x170001E3 RID: 483
		' (get) Token: 0x060005C3 RID: 1475 RVA: 0x00145EDC File Offset: 0x001442DC
		' (set) Token: 0x060005C4 RID: 1476 RVA: 0x00145EF4 File Offset: 0x001442F4
		Public Property T As Timer
			Get
				Return Me._T
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.lam__4
				Dim flag As Boolean = Me._T IsNot Nothing
				If flag Then
					RemoveHandler Me._T.Tick, value2
				End If
				Me._T = value
				flag = (Me._T IsNot Nothing)
				If flag Then
					AddHandler Me._T.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x0400031F RID: 799
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000320 RID: 800
		Private _T As Timer

		' Token: 0x04000321 RID: 801
		Public fonty As Font

		' Token: 0x04000322 RID: 802
		Public G As Graphics

		' Token: 0x04000323 RID: 803
		Public Lines As List(Of Object())
	End Class
End Namespace
