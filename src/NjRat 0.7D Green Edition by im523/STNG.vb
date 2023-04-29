Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000026 RID: 38
	<DesignerGenerated()>
	Public Partial Class STNG
		Inherits Form

		' Token: 0x06000512 RID: 1298 RVA: 0x001732D4 File Offset: 0x001716D4
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.STNG_Load
			STNG.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000513 RID: 1299 RVA: 0x00173300 File Offset: 0x00171700
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = STNG.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = STNG.__ENCList.Count = STNG.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = STNG.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = STNG.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								STNG.__ENCList(num) = STNG.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					STNG.__ENCList.RemoveRange(num, STNG.__ENCList.Count - num)
					STNG.__ENCList.Capacity = STNG.__ENCList.Count
				End If
				STNG.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001C5 RID: 453
		' (get) Token: 0x06000516 RID: 1302 RVA: 0x00174978 File Offset: 0x00172D78
		' (set) Token: 0x06000517 RID: 1303 RVA: 0x00174990 File Offset: 0x00172D90
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

		' Token: 0x170001C6 RID: 454
		' (get) Token: 0x06000518 RID: 1304 RVA: 0x0017499C File Offset: 0x00172D9C
		' (set) Token: 0x06000519 RID: 1305 RVA: 0x001749B4 File Offset: 0x00172DB4
		Friend Overridable Property ShowAlert As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ShowAlert
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._ShowAlert = value
			End Set
		End Property

		' Token: 0x170001C7 RID: 455
		' (get) Token: 0x0600051A RID: 1306 RVA: 0x001749C0 File Offset: 0x00172DC0
		' (set) Token: 0x0600051B RID: 1307 RVA: 0x001749D8 File Offset: 0x00172DD8
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

		' Token: 0x170001C8 RID: 456
		' (get) Token: 0x0600051C RID: 1308 RVA: 0x001749E4 File Offset: 0x00172DE4
		' (set) Token: 0x0600051D RID: 1309 RVA: 0x001749FC File Offset: 0x00172DFC
		Friend Overridable Property LOGMSGS As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGMSGS
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGMSGS = value
			End Set
		End Property

		' Token: 0x170001C9 RID: 457
		' (get) Token: 0x0600051E RID: 1310 RVA: 0x00174A08 File Offset: 0x00172E08
		' (set) Token: 0x0600051F RID: 1311 RVA: 0x00174A20 File Offset: 0x00172E20
		Friend Overridable Property LOGRERR As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGRERR
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGRERR = value
			End Set
		End Property

		' Token: 0x170001CA RID: 458
		' (get) Token: 0x06000520 RID: 1312 RVA: 0x00174A2C File Offset: 0x00172E2C
		' (set) Token: 0x06000521 RID: 1313 RVA: 0x00174A44 File Offset: 0x00172E44
		Friend Overridable Property LOGCONNECTIONS As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGCONNECTIONS
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGCONNECTIONS = value
			End Set
		End Property

		' Token: 0x170001CB RID: 459
		' (get) Token: 0x06000522 RID: 1314 RVA: 0x00174A50 File Offset: 0x00172E50
		' (set) Token: 0x06000523 RID: 1315 RVA: 0x00174A68 File Offset: 0x00172E68
		Friend Overridable Property LOGLERR As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGLERR
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGLERR = value
			End Set
		End Property

		' Token: 0x170001CC RID: 460
		' (get) Token: 0x06000524 RID: 1316 RVA: 0x00174A74 File Offset: 0x00172E74
		' (set) Token: 0x06000525 RID: 1317 RVA: 0x00174A8C File Offset: 0x00172E8C
		Friend Overridable Property LOGLOGIN As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGLOGIN
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGLOGIN = value
			End Set
		End Property

		' Token: 0x170001CD RID: 461
		' (get) Token: 0x06000526 RID: 1318 RVA: 0x00174A98 File Offset: 0x00172E98
		' (set) Token: 0x06000527 RID: 1319 RVA: 0x00174AB0 File Offset: 0x00172EB0
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

		' Token: 0x170001CE RID: 462
		' (get) Token: 0x06000528 RID: 1320 RVA: 0x00174ABC File Offset: 0x00172EBC
		' (set) Token: 0x06000529 RID: 1321 RVA: 0x00174AD4 File Offset: 0x00172ED4
		Friend Overridable Property SCAUT As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._SCAUT
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._SCAUT = value
			End Set
		End Property

		' Token: 0x170001CF RID: 463
		' (get) Token: 0x0600052A RID: 1322 RVA: 0x00174AE0 File Offset: 0x00172EE0
		' (set) Token: 0x0600052B RID: 1323 RVA: 0x00174AF8 File Offset: 0x00172EF8
		Friend Overridable Property SCI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._SCI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._SCI = value
			End Set
		End Property

		' Token: 0x170001D0 RID: 464
		' (get) Token: 0x0600052C RID: 1324 RVA: 0x00174B04 File Offset: 0x00172F04
		' (set) Token: 0x0600052D RID: 1325 RVA: 0x00174B1C File Offset: 0x00172F1C
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

		' Token: 0x170001D1 RID: 465
		' (get) Token: 0x0600052E RID: 1326 RVA: 0x00174B28 File Offset: 0x00172F28
		' (set) Token: 0x0600052F RID: 1327 RVA: 0x00174B40 File Offset: 0x00172F40
		Friend Overridable Property GroupBox4 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox4 = value
			End Set
		End Property

		' Token: 0x170001D2 RID: 466
		' (get) Token: 0x06000530 RID: 1328 RVA: 0x00174B4C File Offset: 0x00172F4C
		' (set) Token: 0x06000531 RID: 1329 RVA: 0x00174B64 File Offset: 0x00172F64
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x170001D3 RID: 467
		' (get) Token: 0x06000532 RID: 1330 RVA: 0x00174B70 File Offset: 0x00172F70
		' (set) Token: 0x06000533 RID: 1331 RVA: 0x00174B88 File Offset: 0x00172F88
		Friend Overridable Property CAMI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CAMI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._CAMI = value
			End Set
		End Property

		' Token: 0x170001D4 RID: 468
		' (get) Token: 0x06000534 RID: 1332 RVA: 0x00174B94 File Offset: 0x00172F94
		' (set) Token: 0x06000535 RID: 1333 RVA: 0x00174BAC File Offset: 0x00172FAC
		Friend Overridable Property CAMAUT As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CAMAUT
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CAMAUT = value
			End Set
		End Property

		' Token: 0x170001D5 RID: 469
		' (get) Token: 0x06000536 RID: 1334 RVA: 0x00174BB8 File Offset: 0x00172FB8
		' (set) Token: 0x06000537 RID: 1335 RVA: 0x00174BD0 File Offset: 0x00172FD0
		Friend Overridable Property GroupBox5 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox5 = value
			End Set
		End Property

		' Token: 0x170001D6 RID: 470
		' (get) Token: 0x06000538 RID: 1336 RVA: 0x00174BDC File Offset: 0x00172FDC
		' (set) Token: 0x06000539 RID: 1337 RVA: 0x00174BF4 File Offset: 0x00172FF4
		Friend Overridable Property MICI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._MICI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._MICI = value
			End Set
		End Property

		' Token: 0x170001D7 RID: 471
		' (get) Token: 0x0600053A RID: 1338 RVA: 0x00174C00 File Offset: 0x00173000
		' (set) Token: 0x0600053B RID: 1339 RVA: 0x00174C18 File Offset: 0x00173018
		Friend Overridable Property MICAUT As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._MICAUT
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._MICAUT = value
			End Set
		End Property

		' Token: 0x170001D8 RID: 472
		' (get) Token: 0x0600053C RID: 1340 RVA: 0x00174C24 File Offset: 0x00173024
		' (set) Token: 0x0600053D RID: 1341 RVA: 0x00174C3C File Offset: 0x0017303C
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

		' Token: 0x170001D9 RID: 473
		' (get) Token: 0x0600053E RID: 1342 RVA: 0x00174C48 File Offset: 0x00173048
		' (set) Token: 0x0600053F RID: 1343 RVA: 0x00174C60 File Offset: 0x00173060
		Friend Overridable Property scrI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._scrI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._scrI = value
			End Set
		End Property

		' Token: 0x170001DA RID: 474
		' (get) Token: 0x06000540 RID: 1344 RVA: 0x00174C6C File Offset: 0x0017306C
		' (set) Token: 0x06000541 RID: 1345 RVA: 0x00174C84 File Offset: 0x00173084
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

		' Token: 0x170001DB RID: 475
		' (get) Token: 0x06000542 RID: 1346 RVA: 0x00174CE4 File Offset: 0x001730E4
		' (set) Token: 0x06000543 RID: 1347 RVA: 0x00174CFC File Offset: 0x001730FC
		Friend Overridable Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		' Token: 0x170001DC RID: 476
		' (get) Token: 0x06000544 RID: 1348 RVA: 0x00174D08 File Offset: 0x00173108
		' (set) Token: 0x06000545 RID: 1349 RVA: 0x00174D20 File Offset: 0x00173120
		Friend Overridable Property Snd As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Snd
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._Snd = value
			End Set
		End Property

		' Token: 0x06000546 RID: 1350 RVA: 0x00174D2C File Offset: 0x0017312C
		Private Sub STNG_Load(sender As Object, e As EventArgs)
			Me.SCAUT.Checked = Class7.class8_0.bool_6
			Me.SCI.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0)
			Me.CAMAUT.Checked = Class7.class8_0.bool_7
			Me.CAMI.SelectedIndex = Class7.class8_0.int_0
			Me.MICAUT.Checked = Class7.class8_0.bool_8
			Me.LOGCONNECTIONS.Checked = Class7.class8_0.bool_2
			Me.LOGLERR.Checked = Class7.class8_0.bool_3
			Me.LOGRERR.Checked = Class7.class8_0.bool_4
			Me.LOGMSGS.Checked = Class7.class8_0.bool_5
			Me.LOGLOGIN.Checked = Class7.class8_0.bool_1
			Me.Snd.Checked = Class7.class8_0.bool_9
			Me.ShowAlert.Checked = Class7.class8_0.bool_0
			Me.MICI.SelectedIndex = Class7.class8_0.int_1
			Me.scrI.SelectedIndex = Class7.class8_0.int_2
		End Sub

		' Token: 0x06000547 RID: 1351 RVA: 0x00174E74 File Offset: 0x00173274
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Class7.class8_0.bool_6 = Me.SCAUT.Checked
			Class7.class8_0.string_0 = Conversions.ToString(Me.SCI.SelectedIndex)
			Class7.class8_0.bool_7 = Me.CAMAUT.Checked
			Class7.class8_0.int_0 = Me.CAMI.SelectedIndex
			Class7.class8_0.bool_8 = Me.MICAUT.Checked
			Class7.class8_0.bool_2 = Me.LOGCONNECTIONS.Checked
			Class7.class8_0.bool_3 = Me.LOGLERR.Checked
			Class7.class8_0.bool_4 = Me.LOGRERR.Checked
			Class7.class8_0.bool_5 = Me.LOGMSGS.Checked
			Class7.class8_0.bool_1 = Me.LOGLOGIN.Checked
			Class7.class8_0.bool_9 = Me.Snd.Checked
			Class7.class8_0.bool_0 = Me.ShowAlert.Checked
			Class7.class8_0.int_1 = Me.MICI.SelectedIndex
			Class7.class8_0.int_2 = Me.scrI.SelectedIndex
			Class7.class8_0.method_1()
			Me.Hide()
		End Sub

		' Token: 0x0400025F RID: 607
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000261 RID: 609
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000262 RID: 610
		<AccessedThroughProperty("ShowAlert")>
		Private _ShowAlert As CheckBox

		' Token: 0x04000263 RID: 611
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000264 RID: 612
		<AccessedThroughProperty("LOGMSGS")>
		Private _LOGMSGS As CheckBox

		' Token: 0x04000265 RID: 613
		<AccessedThroughProperty("LOGRERR")>
		Private _LOGRERR As CheckBox

		' Token: 0x04000266 RID: 614
		<AccessedThroughProperty("LOGCONNECTIONS")>
		Private _LOGCONNECTIONS As CheckBox

		' Token: 0x04000267 RID: 615
		<AccessedThroughProperty("LOGLERR")>
		Private _LOGLERR As CheckBox

		' Token: 0x04000268 RID: 616
		<AccessedThroughProperty("LOGLOGIN")>
		Private _LOGLOGIN As CheckBox

		' Token: 0x04000269 RID: 617
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x0400026A RID: 618
		<AccessedThroughProperty("SCAUT")>
		Private _SCAUT As CheckBox

		' Token: 0x0400026B RID: 619
		<AccessedThroughProperty("SCI")>
		Private _SCI As ComboBox

		' Token: 0x0400026C RID: 620
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400026D RID: 621
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x0400026E RID: 622
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400026F RID: 623
		<AccessedThroughProperty("CAMI")>
		Private _CAMI As ComboBox

		' Token: 0x04000270 RID: 624
		<AccessedThroughProperty("CAMAUT")>
		Private _CAMAUT As CheckBox

		' Token: 0x04000271 RID: 625
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x04000272 RID: 626
		<AccessedThroughProperty("MICI")>
		Private _MICI As ComboBox

		' Token: 0x04000273 RID: 627
		<AccessedThroughProperty("MICAUT")>
		Private _MICAUT As CheckBox

		' Token: 0x04000274 RID: 628
		<AccessedThroughProperty("GroupBox6")>
		Private _GroupBox6 As GroupBox

		' Token: 0x04000275 RID: 629
		<AccessedThroughProperty("scrI")>
		Private _scrI As ComboBox

		' Token: 0x04000276 RID: 630
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000277 RID: 631
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000278 RID: 632
		<AccessedThroughProperty("Snd")>
		Private _Snd As CheckBox
	End Class
End Namespace
