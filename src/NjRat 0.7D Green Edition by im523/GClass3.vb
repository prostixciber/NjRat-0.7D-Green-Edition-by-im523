Imports System
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000030 RID: 48
	Public NotInheritable Class GClass3
		' Token: 0x06000594 RID: 1428 RVA: 0x00143FFC File Offset: 0x001423FC
		Public Sub New(string_3 As String)
			Me.New(string_3, GClass3.int_20)
		End Sub

		' Token: 0x06000595 RID: 1429 RVA: 0x00144010 File Offset: 0x00142410
		Public Sub New(string_3 As String, int_26 As Integer)
			Me.fileStream_0 = Nothing
			Me.gclass5_0 = Nothing
			Me.object_0 = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(New Object())))
			Me.byte_0 = Convert.ToByte(GClass5.int_0)
			Me.int_3 = 0
			Try
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0 = New FileStream(string_3, FileMode.Open, FileAccess.Read)
				End SyncLock
				Me.int_2 = int_26
				Me.method_0()
			Catch ex As SystemException
				Console.Write("cannot open file " + string_3 + vbLf)
			End Try
		End Sub

		' Token: 0x06000596 RID: 1430 RVA: 0x0014410C File Offset: 0x0014250C
		Private Sub method_0()
			Dim array As Byte() = New Byte(2) {}
			Dim array2 As Byte() = New Byte(GClass3.int_9 - 1 + 1 - 1 + 1 - 1) {}
			Me.byte_0 = CByte(GClass5.int_0)
			Me.int_1 = GClass3.int_10
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
			ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
			Dim obj As Object = objectValue
			ObjectFlowControl.CheckForSyncLockOnValueType(obj)
			SyncLock obj
				Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
				Dim num As Integer = GClass3.int_6 - 1
				Dim flag As Boolean
				For i As Integer = 0 To num
					Me.fileStream_0.Read(array, 0, 3)
					flag = (array(0) = Byte.MaxValue AndAlso array(1) = Byte.MaxValue AndAlso array(2) = Byte.MaxValue)
					If flag Then
						Me.byte_0 = Convert.ToByte(Me.fileStream_0.ReadByte())
						flag = (Me.byte_0 >= 106)
						If flag Then
							Me.byte_0 -= 105
						End If
						flag = (CInt(Me.byte_0) = GClass5.int_1)
						If flag Then
							Me.int_0 = New Integer() { GClass3.int_15 }
							Me.int_1 = GClass3.int_10
						Else
							flag = (CInt(Me.byte_0) = GClass5.int_2)
							If flag Then
								Me.int_0 = New Integer() { GClass3.int_16 }
								Me.int_1 = GClass3.int_10
							Else
								Dim flag2 As Boolean
								If CInt(Me.byte_0) <> GClass5.int_3 AndAlso CInt(Me.byte_0) <> GClass5.int_4 Then
									If CInt(Me.byte_0) <> GClass5.int_5 AndAlso CInt(Me.byte_0) <> GClass5.int_14 Then
										If CInt(Me.byte_0) <> GClass5.int_6 AndAlso CInt(Me.byte_0) <> GClass5.int_13 Then
											If CInt(Me.byte_0) <> GClass5.int_8 AndAlso CInt(Me.byte_0) <> GClass5.int_12 Then
												If CInt(Me.byte_0) <> GClass5.int_18 AndAlso CInt(Me.byte_0) <> GClass5.int_19 Then
													If CInt(Me.byte_0) <> GClass5.int_17 AndAlso CInt(Me.byte_0) <> GClass5.int_16 Then
														flag2 = False
														GoTo IL_215
													End If
												End If
											End If
										End If
									End If
								End If
								flag2 = True
								IL_215:
								flag = flag2
								If flag Then
									Me.int_0 = New Integer() { 0 }
									Dim flag3 As Boolean
									If CInt(Me.byte_0) <> GClass5.int_3 AndAlso CInt(Me.byte_0) <> GClass5.int_4 Then
										If CInt(Me.byte_0) <> GClass5.int_12 AndAlso CInt(Me.byte_0) <> GClass5.int_18 Then
											If CInt(Me.byte_0) <> GClass5.int_19 AndAlso CInt(Me.byte_0) <> GClass5.int_17 Then
												If CInt(Me.byte_0) <> GClass5.int_16 AndAlso CInt(Me.byte_0) <> GClass5.int_8 Then
													flag3 = False
													GoTo IL_2A5
												End If
											End If
										End If
									End If
									flag3 = True
									IL_2A5:
									flag = flag3
									If flag Then
										Me.int_1 = GClass3.int_10
									Else
										Me.int_1 = GClass3.int_11
									End If
									Me.fileStream_0.Read(array2, 0, GClass3.int_9)
									Dim num2 As Integer = GClass3.int_9 - 1
									For j As Integer = 0 To num2
										Dim num3 As Integer = 0
										Me.int_0(num3) = Me.int_0(num3) + (GClass3.smethod_2(array2(j)) << j * 8)
									Next
								End If
							End If
						End If
						Exit For
					End If
					Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
				Next
				Dim flag4 As Boolean
				If CInt(Me.byte_0) <> GClass5.int_0 AndAlso CInt(Me.byte_0) <> GClass5.int_11 Then
					If CInt(Me.byte_0) <> GClass5.int_7 AndAlso CInt(Me.byte_0) <> GClass5.int_9 Then
						flag4 = False
						GoTo IL_388
					End If
				End If
				flag4 = True
				IL_388:
				flag = flag4
				If flag Then
					Me.int_0 = New Integer() { GClass3.int_4 }
					Me.int_1 = GClass3.int_10
				End If
				flag = ((Me.int_2 And GClass3.int_21) = 1)
				If flag Then
					Dim num4 As Integer = CInt(Me.fileStream_0.Length)
					Me.byte_1 = New Byte(num4 - 1 + 1 - 1 + 1 - 1) {}
					Me.fileStream_0.Seek(0L, SeekOrigin.Begin)
					Me.fileStream_0.Read(Me.byte_1, 0, num4)
				End If
			End SyncLock
		End Sub

		' Token: 0x06000597 RID: 1431 RVA: 0x00144554 File Offset: 0x00142954
		Public Sub method_1()
			Try
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
				ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
				Dim obj As Object = objectValue
				ObjectFlowControl.CheckForSyncLockOnValueType(obj)
				SyncLock obj
					Me.fileStream_0.Close()
				End SyncLock
				Me.fileStream_0 = Nothing
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000598 RID: 1432 RVA: 0x001445EC File Offset: 0x001429EC
		Public Function method_10() As GClass5
			Dim flag As Boolean = Me.gclass5_0 IsNot Nothing
			Dim result As GClass5
			If flag Then
				result = Me.gclass5_0
			Else
				Try
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
					Dim obj As Object = objectValue
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						Dim flag2 As Boolean = False
						Dim array As Byte() = New Byte(2) {}
						Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
						Dim num As Integer = GClass3.int_6 - 1
						For i As Integer = 0 To num
							Me.fileStream_0.Read(array, 0, 3)
							flag = (array(0) = Byte.MaxValue AndAlso array(1) = Byte.MaxValue AndAlso array(2) = Byte.MaxValue)
							If flag Then
								flag2 = True
								Exit For
							End If
							Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
						Next
						flag = flag2
						If flag Then
							Me.fileStream_0.Seek(-6L, SeekOrigin.Current)
						Else
							Me.fileStream_0.Seek(-3L, SeekOrigin.[End])
						End If
						Dim num2 As Integer = GClass3.int_7 - 1
						For j As Integer = 0 To num2
							Me.fileStream_0.Read(array, 0, 3)
							flag = (array(0) = 0 AndAlso array(1) = 0 AndAlso array(2) = 0)
							If flag Then
								Dim array2 As Byte() = New Byte(j - 1 + 1 - 1 + 1 - 1) {}
								Dim array3 As Char() = New Char(j - 1 + 1 - 1 + 1 - 1) {}
								Me.fileStream_0.Read(array2, 0, j)
								Dim num3 As Integer = j - 1
								For k As Integer = 0 To num3
									array3(k) = Convert.ToChar(array2(k))
								Next
								Me.gclass5_0 = New GClass5(New String(array3))
								Return Me.gclass5_0
							End If
							Me.fileStream_0.Seek(-4L, SeekOrigin.Current)
						Next
					End SyncLock
				Catch ex As Exception
					Dim ex2 As Exception = ex
					Console.Write(ex2.Message)
				End Try
				result = New GClass5(String.Empty)
			End If
			Return result
		End Function

		' Token: 0x06000599 RID: 1433 RVA: 0x00144860 File Offset: 0x00142C60
		Public Function method_11(ipaddress_0 As IPAddress) As GClass6
			Return Me.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress_0.GetAddressBytes())))
		End Function

		' Token: 0x0600059A RID: 1434 RVA: 0x00144888 File Offset: 0x00142C88
		Public Function method_12(string_3 As String) As GClass6
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_12(Conversions.ToString(GClass3.smethod_1(ipaddress.GetAddressBytes())))
		End Function

		' Token: 0x0600059B RID: 1435 RVA: 0x00144900 File Offset: 0x00142D00
		Public Function method_13(ipaddress_0 As IPAddress) As String
			Return Me.method_17(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x0600059C RID: 1436 RVA: 0x00144924 File Offset: 0x00142D24
		Public Function method_14(string_3 As String) As String
			Dim ipaddress_ As IPAddress
			Try
				ipaddress_ = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_16(ipaddress_)
		End Function

		' Token: 0x0600059D RID: 1437 RVA: 0x0014498C File Offset: 0x00142D8C
		Public Function method_15(string_3 As String) As String
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return Nothing
			End Try
			Return Me.method_17(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x0600059E RID: 1438 RVA: 0x00144A00 File Offset: 0x00142E00
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Function method_16(ipaddress_0 As IPAddress) As String
			Dim num As Integer = 0
			Dim array As Byte() = New Byte(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Char() = New Char(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim result As String
			Try
				Dim num2 As Integer = Me.method_18(ipaddress_0)
				Dim flag As Boolean = num2 = Me.int_0(0)
				If flag Then
					Return Nothing
				End If
				Dim num3 As Integer = num2 + (2 * Me.int_1 - 1) * Me.int_0(0)
				flag = ((Me.int_2 And GClass3.int_21) = 1)
				If flag Then
					Array.Copy(Me.byte_1, num3, array, 0, Math.Min(Me.byte_1.Length - num3, GClass3.int_13))
				Else
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
					Dim obj As Object = objectValue
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						Me.fileStream_0.Seek(CLng(num3), SeekOrigin.Begin)
						Me.fileStream_0.Read(array, 0, GClass3.int_13)
					End SyncLock
				End If
				While array(num) <> 0
					array2(num) = Convert.ToChar(array(num))
					num += 1
				End While
				array2(num) = vbNullChar
				result = New String(array2, 0, num)
			Catch ex As IOException
				Console.Write("IO Exception")
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x0600059F RID: 1439 RVA: 0x00144BAC File Offset: 0x00142FAC
		<MethodImpl(MethodImplOptions.Synchronized)>
		Public Function method_17(long_0 As Long) As String
			Dim num As Integer = 0
			Dim array As Byte() = New Byte(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Char() = New Char(GClass3.int_13 - 1 + 1 - 1 + 1 - 1) {}
			Dim result As String
			Try
				Dim num2 As Integer = Me.method_19(long_0)
				Dim flag As Boolean = num2 = Me.int_0(0)
				If flag Then
					Return Nothing
				End If
				Dim num3 As Integer = num2 + (2 * Me.int_1 - 1) * Me.int_0(0)
				flag = ((Me.int_2 And GClass3.int_21) = 1)
				If flag Then
					Array.Copy(Me.byte_1, num3, array, 0, Math.Min(Me.byte_1.Length - num3, GClass3.int_13))
				Else
					Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
					ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
					Dim obj As Object = objectValue
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						Me.fileStream_0.Seek(CLng(num3), SeekOrigin.Begin)
						Me.fileStream_0.Read(array, 0, GClass3.int_13)
					End SyncLock
				End If
				While array(num) <> 0
					array2(num) = Convert.ToChar(array(num))
					num += 1
				End While
				array2(num) = vbNullChar
				result = New String(array2, 0, num)
			Catch ex As IOException
				Console.Write("IO Exception")
				result = Nothing
			End Try
			Return result
		End Function

		' Token: 0x060005A0 RID: 1440 RVA: 0x00144D58 File Offset: 0x00143158
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Function method_18(ipaddress_0 As IPAddress) As Integer
			Dim addressBytes As Byte() = ipaddress_0.GetAddressBytes()
			Dim array As Byte() = New Byte(2 * GClass3.int_12 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Integer() = New Integer(1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = 127
			While True
				Dim flag As Boolean
				Try
					flag = ((Me.int_2 And GClass3.int_21) = 1)
					If flag Then
						Dim num3 As Integer = 2 * GClass3.int_12 - 1
						For i As Integer = 0 To num3
							array(i) = Me.byte_1(i + 2 * Me.int_1 * num)
						Next
					Else
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
						Dim obj As Object = objectValue
						ObjectFlowControl.CheckForSyncLockOnValueType(obj)
						SyncLock obj
							Me.fileStream_0.Seek(CLng((2 * Me.int_1 * num)), SeekOrigin.Begin)
							Me.fileStream_0.Read(array, 0, 2 * GClass3.int_12)
						End SyncLock
					End If
				Catch ex As IOException
					Console.Write("IO Exception")
				End Try
				Dim num4 As Integer = 0
				Do
					array2(num4) = 0
					Dim num5 As Integer = Me.int_1 - 1
					For j As Integer = 0 To num5
						Dim num6 As Integer = CInt(array(num4 * Me.int_1 + j))
						flag = (num6 < 0)
						If flag Then
							num6 += 256
						End If
						Dim num7 As Integer = num4
						array2(num7) += num6 << j * 8
					Next
					num4 += 1
				Loop While num4 <= 1
				Dim num8 As Integer = 127 - num2
				Dim num9 As Integer = num8 >> 3
				Dim num10 As Integer = 1 << ((num8 And 7) Xor 7)
				flag = ((CInt(addressBytes(num9)) And num10) > 0)
				If flag Then
					Dim flag2 As Boolean = array2(1) >= Me.int_0(0)
					If flag2 Then
						Exit For
					End If
					num = array2(1)
				Else
					Dim flag2 As Boolean = array2(0) >= Me.int_0(0)
					If flag2 Then
						GoTo Block_7
					End If
					num = array2(0)
				End If
				num2 += -1
				If num2 < 0 Then
					GoTo Block_8
				End If
			End While
			Return array2(1)
			Block_7:
			Return array2(0)
			Block_8:
			Console.Write("Error Seeking country while Seeking " + Convert.ToString(ipaddress_0))
			Return 0
		End Function

		' Token: 0x060005A1 RID: 1441 RVA: 0x00144FC8 File Offset: 0x001433C8
		<MethodImpl(MethodImplOptions.Synchronized)>
		Private Function method_19(long_0 As Long) As Integer
			Dim array As Byte() = New Byte(2 * GClass3.int_12 - 1 + 1 - 1 + 1 - 1) {}
			Dim array2 As Integer() = New Integer(1) {}
			Dim num As Integer = 0
			Dim num2 As Integer = 31
			While True
				Dim flag As Boolean
				Try
					flag = ((Me.int_2 And GClass3.int_21) = 1)
					If flag Then
						Dim num3 As Integer = 2 * GClass3.int_12 - 1
						For i As Integer = 0 To num3
							array(i) = Me.byte_1(i + 2 * Me.int_1 * num)
						Next
					Else
						Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.object_0)
						ObjectFlowControl.CheckForSyncLockOnValueType(RuntimeHelpers.GetObjectValue(objectValue))
						Dim obj As Object = objectValue
						ObjectFlowControl.CheckForSyncLockOnValueType(obj)
						SyncLock obj
							Me.fileStream_0.Seek(CLng((2 * Me.int_1 * num)), SeekOrigin.Begin)
							Me.fileStream_0.Read(array, 0, 2 * GClass3.int_12)
						End SyncLock
					End If
				Catch ex As IOException
					Console.Write("IO Exception")
				End Try
				Dim num4 As Integer = 0
				Do
					array2(num4) = 0
					Dim num5 As Integer = Me.int_1 - 1
					For j As Integer = 0 To num5
						Dim num6 As Integer = CInt(array(num4 * Me.int_1 + j))
						flag = (num6 < 0)
						If flag Then
							num6 += 256
						End If
						Dim num7 As Integer = num4
						array2(num7) += num6 << j * 8
					Next
					num4 += 1
				Loop While num4 <= 1
				flag = ((long_0 And 1L << (num2 And 31)) > 0L)
				If flag Then
					Dim flag2 As Boolean = array2(1) >= Me.int_0(0)
					If flag2 Then
						Exit For
					End If
					num = array2(1)
				Else
					Dim flag2 As Boolean = array2(0) >= Me.int_0(0)
					If flag2 Then
						GoTo Block_7
					End If
					num = array2(0)
				End If
				num2 += -1
				If num2 < 0 Then
					GoTo Block_8
				End If
			End While
			Return array2(1)
			Block_7:
			Return array2(0)
			Block_8:
			Console.Write("Error Seeking country while Seeking " + Conversions.ToString(long_0))
			Return 0
		End Function

		' Token: 0x060005A2 RID: 1442 RVA: 0x00145218 File Offset: 0x00143618
		Public Function method_2(ipaddress_0 As IPAddress) As GClass4
			Return Me.method_6(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x060005A3 RID: 1443 RVA: 0x0014523C File Offset: 0x0014363C
		Public Function method_3(string_3 As String) As GClass4
			Dim ipaddress_ As IPAddress
			Try
				ipaddress_ = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return GClass3.gclass4_0
			End Try
			Return Me.method_5(ipaddress_)
		End Function

		' Token: 0x060005A4 RID: 1444 RVA: 0x001452AC File Offset: 0x001436AC
		Public Function method_4(string_3 As String) As GClass4
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return GClass3.gclass4_0
			End Try
			Return Me.method_6(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x060005A5 RID: 1445 RVA: 0x00145328 File Offset: 0x00143728
		Public Function method_5(ipaddress_0 As IPAddress) As GClass4
			Dim flag As Boolean = Me.fileStream_0 Is Nothing
			If flag Then
				Throw New Exception("Database has been closed.")
			End If
			flag = (CInt(Me.byte_0) = GClass5.int_4 Or CInt(Me.byte_0) = GClass5.int_3)
			Dim result As GClass4
			If flag Then
				Dim gclass As GClass6 = Me.method_11(ipaddress_0)
				flag = (gclass Is Nothing)
				If flag Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(gclass.string_0, gclass.string_1)
				End If
			Else
				Dim num As Integer = Me.method_18(ipaddress_0) - GClass3.int_4
				flag = (num = 0)
				If flag Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(GClass3.string_1(num), GClass3.string_2(num))
				End If
			End If
			Return result
		End Function

		' Token: 0x060005A6 RID: 1446 RVA: 0x001453D4 File Offset: 0x001437D4
		Public Function method_6(long_0 As Long) As GClass4
			Dim flag As Boolean = Me.fileStream_0 Is Nothing
			If flag Then
				Throw New Exception("Database has been closed.")
			End If
			flag = (CInt(Me.byte_0) = GClass5.int_4 Or CInt(Me.byte_0) = GClass5.int_3)
			Dim result As GClass4
			If flag Then
				Dim gclass As GClass6 = Me.method_12(Conversions.ToString(long_0))
				flag = (gclass Is Nothing)
				If flag Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(gclass.string_0, gclass.string_1)
				End If
			Else
				Dim num As Integer = Me.method_19(long_0) - GClass3.int_4
				flag = (num = 0)
				If flag Then
					result = GClass3.gclass4_0
				Else
					result = New GClass4(GClass3.string_1(num), GClass3.string_2(num))
				End If
			End If
			Return result
		End Function

		' Token: 0x060005A7 RID: 1447 RVA: 0x00145484 File Offset: 0x00143884
		Public Function method_7(string_3 As String) As Integer
			Dim ipaddress As IPAddress
			Try
				ipaddress = IPAddress.Parse(string_3)
			Catch ex As Exception
				Dim ex2 As Exception = ex
				Console.Write(ex2.Message)
				Return 0
			End Try
			Return Me.method_9(GClass3.smethod_1(ipaddress.GetAddressBytes()))
		End Function

		' Token: 0x060005A8 RID: 1448 RVA: 0x001454F8 File Offset: 0x001438F8
		Public Function method_8(ipaddress_0 As IPAddress) As Integer
			Return Me.method_9(GClass3.smethod_1(ipaddress_0.GetAddressBytes()))
		End Function

		' Token: 0x060005A9 RID: 1449 RVA: 0x0014551C File Offset: 0x0014391C
		Public Function method_9(long_0 As Long) As Integer
			Dim flag As Boolean = Me.fileStream_0 Is Nothing
			If flag Then
				Throw New Exception("Database has been closed.")
			End If
			Return Me.method_19(long_0) - Me.int_0(0)
		End Function

		' Token: 0x060005AA RID: 1450 RVA: 0x00145558 File Offset: 0x00143958
		Private Shared Function smethod_0(long_0 As Long) As Long
			Return(long_0 >> 0 And 255L) << 24 Or (long_0 >> 8 And 255L) << 16 Or (long_0 >> 16 And 255L) << 8 Or (long_0 >> 24 And 255L) << 0
		End Function

		' Token: 0x060005AB RID: 1451 RVA: 0x001455A4 File Offset: 0x001439A4
		Private Shared Function smethod_1(byte_2 As Byte()) As Long
			Dim num As Long = 0L
			Dim num2 As Integer = 0
			Do
				Dim num3 As Long = CLng(CULng(byte_2(num2)))
				Dim flag As Boolean = num3 < 0L
				If flag Then
					num3 += 256L
				End If
				num += num3 << (3 - num2) * 8
				num2 += 1
			Loop While num2 <= 3
			Return num
		End Function

		' Token: 0x060005AC RID: 1452 RVA: 0x001455F8 File Offset: 0x001439F8
		Private Shared Function smethod_2(byte_2 As Byte) As Integer
			Return CInt((byte_2 And Byte.MaxValue))
		End Function

		' Token: 0x060005AD RID: 1453 RVA: 0x00145614 File Offset: 0x00143A14
		Private Shared Function smethod_3(Of T)(ByRef gparam_0 As T, gparam_1 As T) As T
			gparam_0 = gparam_1
			Return gparam_1
		End Function

		' Token: 0x040002D5 RID: 725
		Private byte_0 As Byte

		' Token: 0x040002D6 RID: 726
		Private byte_1 As Byte()

		' Token: 0x040002D7 RID: 727
		Private fileStream_0 As FileStream

		' Token: 0x040002D8 RID: 728
		Private Shared gclass4_0 As GClass4 = New GClass4("--", "N/A")

		' Token: 0x040002D9 RID: 729
		Private gclass5_0 As GClass5

		' Token: 0x040002DA RID: 730
		Private int_0 As Integer()

		' Token: 0x040002DB RID: 731
		Private int_1 As Integer

		' Token: 0x040002DC RID: 732
		Private Shared int_10 As Integer = 3

		' Token: 0x040002DD RID: 733
		Private Shared int_11 As Integer = 4

		' Token: 0x040002DE RID: 734
		Private Shared int_12 As Integer = 4

		' Token: 0x040002DF RID: 735
		Private Shared int_13 As Integer = 1000

		' Token: 0x040002E0 RID: 736
		Private Shared int_14 As Integer = 360

		' Token: 0x040002E1 RID: 737
		Private Shared int_15 As Integer = 16700000

		' Token: 0x040002E2 RID: 738
		Private Shared int_16 As Integer = 16000000

		' Token: 0x040002E3 RID: 739
		Private Shared int_17 As Integer = 1

		' Token: 0x040002E4 RID: 740
		Private Shared int_18 As Integer = 677

		' Token: 0x040002E5 RID: 741
		Private Shared int_19 As Integer = 1353

		' Token: 0x040002E6 RID: 742
		Private int_2 As Integer

		' Token: 0x040002E7 RID: 743
		Public Shared int_20 As Integer = 0

		' Token: 0x040002E8 RID: 744
		Public Shared int_21 As Integer = 1

		' Token: 0x040002E9 RID: 745
		Public Shared int_22 As Integer = 0

		' Token: 0x040002EA RID: 746
		Public Shared int_23 As Integer = 1

		' Token: 0x040002EB RID: 747
		Public Shared int_24 As Integer = 2

		' Token: 0x040002EC RID: 748
		Public Shared int_25 As Integer = 3

		' Token: 0x040002ED RID: 749
		Private int_3 As Integer

		' Token: 0x040002EE RID: 750
		Private Shared int_4 As Integer = 16776960

		' Token: 0x040002EF RID: 751
		Private Shared int_5 As Integer = 16700000

		' Token: 0x040002F0 RID: 752
		Private Shared int_6 As Integer = 20

		' Token: 0x040002F1 RID: 753
		Private Shared int_7 As Integer = 100

		' Token: 0x040002F2 RID: 754
		Private Shared int_8 As Integer = 100

		' Token: 0x040002F3 RID: 755
		Private Shared int_9 As Integer = 3

		' Token: 0x040002F4 RID: 756
		Private object_0 As Object

		' Token: 0x040002F5 RID: 757
		Private string_0 As String

		' Token: 0x040002F6 RID: 758
		Public Shared string_1 As String() = New String() { "--", "AP", "EU", "AD", "AE", "AF", "AG", "AI", "AL", "AM", "CW", "AO", "AQ", "AR", "AS", "AT", "AU", "AW", "AZ", "BA", "BB", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BM", "BN", "BO", "BR", "BS", "BT", "BV", "BW", "BY", "BZ", "CA", "CC", "CD", "CF", "CG", "CH", "CI", "CK", "CL", "CM", "CN", "CO", "CR", "CU", "CV", "CX", "CY", "CZ", "DE", "DJ", "DK", "DM", "DO", "DZ", "EC", "EE", "EG", "EH", "ER", "ES", "ET", "FI", "FJ", "FK", "FM", "FO", "FR", "SX", "GA", "GB", "GD", "GE", "GF", "GH", "GI", "GL", "GM", "GN", "GP", "GQ", "GR", "GS", "GT", "GU", "GW", "GY", "HK", "HM", "HN", "HR", "HT", "HU", "ID", "IE", "IL", "IN", "IO", "IQ", "IR", "IS", "IT", "JM", "JO", "JP", "KE", "KG", "KH", "KI", "KM", "KN", "KP", "KR", "KW", "KY", "KZ", "LA", "LB", "LC", "LI", "LK", "LR", "LS", "LT", "LU", "LV", "LY", "MA", "MC", "MD", "MG", "MH", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NC", "NE", "NF", "NG", "NI", "NL", "NO", "NP", "NR", "NU", "NZ", "OM", "PA", "PE", "PF", "PG", "PH", "PK", "PL", "PM", "PN", "PR", "PS", "PT", "PW", "PY", "QA", "RE", "RO", "RU", "RW", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SR", "ST", "SV", "SY", "SZ", "TC", "TD", "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "TO", "TL", "TR", "TT", "TV", "TW", "TZ", "UA", "UG", "UM", "US", "UY", "UZ", "VA", "VC", "VE", "VG", "VI", "VN", "VU", "WF", "WS", "YE", "YT", "RS", "ZA", "ZM", "ME", "ZW", "A1", "A2", "O1", "AX", "GG", "IM", "JE", "BL", "MF", "BQ", "SS", "O1" }

		' Token: 0x040002F7 RID: 759
		Private Shared string_2 As String() = New String() { "N/A", "Asia/Pacific Region", "Europe", "Andorra", "United Arab Emirates", "Afghanistan", "Antigua and Barbuda", "Anguilla", "Albania", "Armenia", "Curacao", "Angola", "Antarctica", "Argentina", "American Samoa", "Austria", "Australia", "Aruba", "Azerbaijan", "Bosnia and Herzegovina", "Barbados", "Bangladesh", "Belgium", "Burkina Faso", "Bulgaria", "Bahrain", "Burundi", "Benin", "Bermuda", "Brunei Darussalam", "Bolivia", "Brazil", "Bahamas", "Bhutan", "Bouvet Island", "Botswana", "Belarus", "Belize", "Canada", "Cocos (Keeling) Islands", "Congo, The Democratic Republic of the", "Central African Republic", "Congo", "Switzerland", "Cote D'Ivoire", "Cook Islands", "Chile", "Cameroon", "China", "Colombia", "Costa Rica", "Cuba", "Cape Verde", "Christmas Island", "Cyprus", "Czech Republic", "Germany", "Djibouti", "Denmark", "Dominica", "Dominican Republic", "Algeria", "Ecuador", "Estonia", "Egypt", "Western Sahara", "Eritrea", "Spain", "Ethiopia", "Finland", "Fiji", "Falkland Islands (Malvinas)", "Micronesia, Federated States of", "Faroe Islands", "France", "Sint Maarten (Dutch part)", "Gabon", "United Kingdom", "Grenada", "Georgia", "French Guiana", "Ghana", "Gibraltar", "Greenland", "Gambia", "Guinea", "Guadeloupe", "Equatorial Guinea", "Greece", "South Georgia and the South Sandwich Islands", "Guatemala", "Guam", "Guinea-Bissau", "Guyana", "Hong Kong", "Heard Island and McDonald Islands", "Honduras", "Croatia", "Haiti", "Hungary", "Indonesia", "Ireland", "Israel", "India", "British Indian Ocean Territory", "Iraq", "Iran, Islamic Republic of", "Iceland", "Italy", "Jamaica", "Jordan", "Japan", "Kenya", "Kyrgyzstan", "Cambodia", "Kiribati", "Comoros", "Saint Kitts and Nevis", "Korea, Democratic People's Republic of", "Korea, Republic of", "Kuwait", "Cayman Islands", "Kazakhstan", "Lao People's Democratic Republic", "Lebanon", "Saint Lucia", "Liechtenstein", "Sri Lanka", "Liberia", "Lesotho", "Lithuania", "Luxembourg", "Latvia", "Libya", "Morocco", "Monaco", "Moldova, Republic of", "Madagascar", "Marshall Islands", "Macedonia", "Mali", "Myanmar", "Mongolia", "Macau", "Northern Mariana Islands", "Martinique", "Mauritania", "Montserrat", "Malta", "Mauritius", "Maldives", "Malawi", "Mexico", "Malaysia", "Mozambique", "Namibia", "New Caledonia", "Niger", "Norfolk Island", "Nigeria", "Nicaragua", "Netherlands", "Norway", "Nepal", "Nauru", "Niue", "New Zealand", "Oman", "Panama", "Peru", "French Polynesia", "Papua New Guinea", "Philippines", "Pakistan", "Poland", "Saint Pierre and Miquelon", "Pitcairn Islands", "Puerto Rico", "Palestinian Territory", "Portugal", "Palau", "Paraguay", "Qatar", "Reunion", "Romania", "Russian Federation", "Rwanda", "Saudi Arabia", "Solomon Islands", "Seychelles", "Sudan", "Sweden", "Singapore", "Saint Helena", "Slovenia", "Svalbard and Jan Mayen", "Slovakia", "Sierra Leone", "San Marino", "Senegal", "Somalia", "Suriname", "Sao Tome and Principe", "El Salvador", "Syrian Arab Republic", "Swaziland", "Turks and Caicos Islands", "Chad", "French Southern Territories", "Togo", "Thailand", "Tajikistan", "Tokelau", "Turkmenistan", "Tunisia", "Tonga", "Timor-Leste", "Turkey", "Trinidad and Tobago", "Tuvalu", "Taiwan", "Tanzania, United Republic of", "Ukraine", "Uganda", "United States Minor Outlying Islands", "United States", "Uruguay", "Uzbekistan", "Holy See (Vatican City State)", "Saint Vincent and the Grenadines", "Venezuela", "Virgin Islands, British", "Virgin Islands, U.S.", "Vietnam", "Vanuatu", "Wallis and Futuna", "Samoa", "Yemen", "Mayotte", "Serbia", "South Africa", "Zambia", "Montenegro", "Zimbabwe", "Anonymous Proxy", "Satellite Provider", "Other", "Aland Islands", "Guernsey", "Isle of Man", "Jersey", "Saint Barthelemy", "Saint Martin", "Bonaire, Saint Eustatius and Saba", "South Sudan", "Other" }
	End Class
End Namespace
