Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x0200001D RID: 29
	<DesignerGenerated()>
	Public Partial Class notf
		Inherits Form

		' Token: 0x06000437 RID: 1079 RVA: 0x0016C060 File Offset: 0x0016A460
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = notf.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = notf.__ENCList.Count = notf.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = notf.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = notf.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								notf.__ENCList(num) = notf.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					notf.__ENCList.RemoveRange(num, notf.__ENCList.Count - num)
					notf.__ENCList.Capacity = notf.__ENCList.Count
				End If
				notf.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000188 RID: 392
		' (get) Token: 0x0600043A RID: 1082 RVA: 0x0016C320 File Offset: 0x0016A720
		' (set) Token: 0x0600043B RID: 1083 RVA: 0x0016C338 File Offset: 0x0016A738
		Friend Overridable Property p As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._p
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.p_Click
				Dim flag As Boolean = Me._p IsNot Nothing
				If flag Then
					RemoveHandler Me._p.Click, value2
				End If
				Me._p = value
				flag = (Me._p IsNot Nothing)
				If flag Then
					AddHandler Me._p.Click, value2
				End If
			End Set
		End Property

		' Token: 0x0600043C RID: 1084 RVA: 0x0016C398 File Offset: 0x0016A798
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.notf_Load
			notf.__ENCAddToList(Me)
			AddHandler MyBase.Load, AddressOf Me.notf_Load
			Me.bool_0 = True
			Me.Items = New List(Of notf.GClass15)()
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600043D RID: 1085 RVA: 0x0016C3F8 File Offset: 0x0016A7F8
		Public Sub AddItem(img As Bitmap, Text As String)
			Dim flag As Boolean = Not Class7.class8_0.bool_9
			If Not flag Then
				MyProject.Computer.Audio.Play("Sound/Sound.wav", AudioPlayMode.Background)
			End If
			Dim items As List(Of notf.GClass15) = Me.Items
			Dim obj As List(Of notf.GClass15) = items
			SyncLock obj
				flag = (Me.Items.Count > 50)
				If flag Then
					Me.Items.RemoveAt(0)
				End If
				Dim item As notf.GClass15 = New notf.GClass15() With { .bitmap_0 = CType(img.Clone(), Bitmap), .string_0 = Text }
				Me.Items.Add(item)
			End SyncLock
		End Sub

		' Token: 0x0600043E RID: 1086 RVA: 0x0016C4B4 File Offset: 0x0016A8B4
		Public Sub back()
			Me.bool_0 = True
			Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
			Me.Left = workingArea.Width - Me.Width - 5
			Me.Top = workingArea.Height - Me.Height - 5
		End Sub

		' Token: 0x0600043F RID: 1087 RVA: 0x0016C504 File Offset: 0x0016A904
		Public Sub go()
			Me.bool_0 = False
			Dim workingArea As Rectangle = Screen.PrimaryScreen.WorkingArea
			Me.Left = workingArea.Width
			Me.Top = workingArea.Height
		End Sub

		' Token: 0x06000440 RID: 1088 RVA: 0x0016C544 File Offset: 0x0016A944
		Private Sub p_Click(sender As Object, e As EventArgs)
			Dim items As List(Of notf.GClass15) = Me.Items
			Dim obj As List(Of notf.GClass15) = items
			SyncLock obj
				Me.Items.Clear()
			End SyncLock
		End Sub

		' Token: 0x06000441 RID: 1089 RVA: 0x0016C58C File Offset: 0x0016A98C
		Private Sub notf_Load(sender As Object, e As EventArgs)
			Me.p.BackColor = Color.Pink
			Me.TransparencyKey = Color.Pink
			Me.back()
			Control.CheckForIllegalCrossThreadCalls = False
			Dim thread As Thread = AddressOf Me.wrk
			thread.Start()
		End Sub

		' Token: 0x06000442 RID: 1090 RVA: 0x0016C5E0 File Offset: 0x0016A9E0
		Public Sub wrk()
			While True
				Thread.Sleep(80)
				Dim flag As Boolean = Me.Items.Count = 0
				If flag Then
					Me.go()
				Else
					Try
						Dim bitmap As Bitmap = New Bitmap(Me.p.Width, Me.p.Height)
						Dim graphics As Graphics = Graphics.FromImage(bitmap)
						graphics.Clear(Me.p.BackColor)
						Dim items As List(Of notf.GClass15) = Me.Items
						Dim obj As List(Of notf.GClass15) = items
						SyncLock obj
							Try
								For Each gclass As notf.GClass15 In Me.Items
									flag = (gclass.int_0 <= 2)
									If flag Then
										gclass.int_0 = 2
										Dim gclass2 As notf.GClass15 = gclass
										Dim gclass3 As notf.GClass15 = gclass2
										gclass3.int_1 += 1
									Else
										Dim count As Integer = Me.Items.Count
										flag = (count > 30)
										If flag Then
											gclass.int_0 = 2
										Else
											flag = (count > 20)
											If flag Then
												Dim gclass2 As notf.GClass15 = gclass
												gclass2.int_0 += -20
											Else
												flag = (count > 10)
												If flag Then
													Dim gclass2 As notf.GClass15 = gclass
													gclass2.int_0 += -10
												Else
													Dim gclass2 As notf.GClass15 = gclass
													gclass2.int_0 += -2
												End If
											End If
										End If
										flag = (gclass.int_0 < 2)
										If flag Then
											gclass.int_0 = 2
										End If
									End If
									Dim size As Size = TextRenderer.MeasureText(gclass.string_0, Me.Font)
									size.Width = bitmap.Width
									size.Height += 5
									Dim rectangle As Rectangle = New Rectangle(0, gclass.int_0 - 2, Me.Width, size.Height)
									graphics.FillRectangle(Brushes.Black, rectangle)
									rectangle = New Rectangle(0, gclass.int_0 - 2, Me.Width, size.Height)
									ControlPaint.DrawLockedFrame(graphics, rectangle, False)
									Dim array As Object() = New Object(1) {}
									array(0) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(gclass.bitmap_0.Clone())))
									Dim point As Point = New Point(5, gclass.int_0 - 2)
									array(1) = point
									NewLateBinding.LateCall(graphics, Nothing, "DrawImage", array, Nothing, Nothing, Nothing, True)
									graphics.DrawString(gclass.string_0, Me.Font, Brushes.LimeGreen, 5F, CSng(gclass.int_0))
									flag = (gclass.int_0 > Me.Height - 50)
									If flag Then
										Exit For
									End If
								Next
							Finally
								Dim enumerator As List(Of notf.GClass15).Enumerator
								CType(enumerator, IDisposable).Dispose()
							End Try
							While True
								IL_29E:
								Try
									For Each gclass4 As notf.GClass15 In Me.Items
										flag = (gclass4.int_1 = 40)
										If flag Then
											Me.Items.Remove(gclass4)
											GoTo IL_29E
										End If
									Next
								Finally
									Dim enumerator2 As List(Of notf.GClass15).Enumerator
									CType(enumerator2, IDisposable).Dispose()
								End Try
								Exit For
							End While
							flag = (Me.Items.Count = 0 And Me.bool_0)
							If flag Then
								Me.go()
							End If
							flag = (Me.Items.Count > 0 And Not Me.bool_0)
							If flag Then
								Me.back()
							End If
						End SyncLock
						graphics.Flush(FlushIntention.Sync)
						graphics.Dispose()
						Me.p.Image = bitmap
					Catch ex As Exception
					End Try
				End If
			End While
		End Sub

		' Token: 0x040001F2 RID: 498
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001F4 RID: 500
		<AccessedThroughProperty("p")>
		Private _p As PictureBox

		' Token: 0x040001F5 RID: 501
		Public su As Boolean

		' Token: 0x040001F6 RID: 502
		Private bool_0 As Boolean

		' Token: 0x040001F7 RID: 503
		Public Items As List(Of notf.GClass15)

		' Token: 0x0200001E RID: 30
		Public NotInheritable Class GClass15
			' Token: 0x06000443 RID: 1091 RVA: 0x0016C9F0 File Offset: 0x0016ADF0
			Public Sub New()
				Me.int_0 = MyProject.Forms.notf.Height
				Me.int_1 = 0
			End Sub

			' Token: 0x040001F8 RID: 504
			Public bitmap_0 As Bitmap

			' Token: 0x040001F9 RID: 505
			Public int_0 As Integer

			' Token: 0x040001FA RID: 506
			Public int_1 As Integer

			' Token: 0x040001FB RID: 507
			Public string_0 As String
		End Class
	End Class
End Namespace
