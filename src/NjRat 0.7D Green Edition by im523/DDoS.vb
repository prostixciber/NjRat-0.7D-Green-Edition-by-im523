Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public Partial Class DDoS
		Inherits Form

		' Token: 0x0600005A RID: 90 RVA: 0x00149A80 File Offset: 0x00147E80
		Public Sub New()
			DDoS.__ENCAddToList(Me)
			Me.th = "1"
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600005B RID: 91 RVA: 0x00149AA4 File Offset: 0x00147EA4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = DDoS.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = DDoS.__ENCList.Count = DDoS.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = DDoS.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = DDoS.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								DDoS.__ENCList(num) = DDoS.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					DDoS.__ENCList.RemoveRange(num, DDoS.__ENCList.Count - num)
					DDoS.__ENCList.Capacity = DDoS.__ENCList.Count
				End If
				DDoS.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x0600005E RID: 94 RVA: 0x0014ADB4 File Offset: 0x001491B4
		' (set) Token: 0x0600005F RID: 95 RVA: 0x0014ADCC File Offset: 0x001491CC
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

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x06000060 RID: 96 RVA: 0x0014AE2C File Offset: 0x0014922C
		' (set) Token: 0x06000061 RID: 97 RVA: 0x0014AE44 File Offset: 0x00149244
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

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x06000062 RID: 98 RVA: 0x0014AE50 File Offset: 0x00149250
		' (set) Token: 0x06000063 RID: 99 RVA: 0x0014AE68 File Offset: 0x00149268
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000064 RID: 100 RVA: 0x0014AE74 File Offset: 0x00149274
		' (set) Token: 0x06000065 RID: 101 RVA: 0x0014AE8C File Offset: 0x0014928C
		Friend Overridable Property ComboBox1 As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ComboBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._ComboBox1 = value
			End Set
		End Property

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x06000066 RID: 102 RVA: 0x0014AE98 File Offset: 0x00149298
		' (set) Token: 0x06000067 RID: 103 RVA: 0x0014AEB0 File Offset: 0x001492B0
		Friend Overridable Property TrackBar1 As TrackBar
			<DebuggerNonUserCode()>
			Get
				Return Me._TrackBar1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TrackBar)
				Dim value2 As EventHandler = AddressOf Me.TrackBar1_Scroll
				Dim flag As Boolean = Me._TrackBar1 IsNot Nothing
				If flag Then
					RemoveHandler Me._TrackBar1.Scroll, value2
				End If
				Me._TrackBar1 = value
				flag = (Me._TrackBar1 IsNot Nothing)
				If flag Then
					AddHandler Me._TrackBar1.Scroll, value2
				End If
			End Set
		End Property

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x06000068 RID: 104 RVA: 0x0014AF10 File Offset: 0x00149310
		' (set) Token: 0x06000069 RID: 105 RVA: 0x0014AF28 File Offset: 0x00149328
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

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x0600006A RID: 106 RVA: 0x0014AF34 File Offset: 0x00149334
		' (set) Token: 0x0600006B RID: 107 RVA: 0x0014AF4C File Offset: 0x0014934C
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

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x0600006C RID: 108 RVA: 0x0014AF58 File Offset: 0x00149358
		' (set) Token: 0x0600006D RID: 109 RVA: 0x0014AF70 File Offset: 0x00149370
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

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x0600006E RID: 110 RVA: 0x0014AF7C File Offset: 0x0014937C
		' (set) Token: 0x0600006F RID: 111 RVA: 0x0014AF94 File Offset: 0x00149394
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

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x06000070 RID: 112 RVA: 0x0014AFA0 File Offset: 0x001493A0
		' (set) Token: 0x06000071 RID: 113 RVA: 0x0014AFB8 File Offset: 0x001493B8
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

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x06000072 RID: 114 RVA: 0x0014AFC4 File Offset: 0x001493C4
		' (set) Token: 0x06000073 RID: 115 RVA: 0x0014AFDC File Offset: 0x001493DC
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

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x06000074 RID: 116 RVA: 0x0014AFE8 File Offset: 0x001493E8
		' (set) Token: 0x06000075 RID: 117 RVA: 0x0014B000 File Offset: 0x00149400
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

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x06000076 RID: 118 RVA: 0x0014B00C File Offset: 0x0014940C
		' (set) Token: 0x06000077 RID: 119 RVA: 0x0014B024 File Offset: 0x00149424
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
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

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x06000078 RID: 120 RVA: 0x0014B084 File Offset: 0x00149484
		' (set) Token: 0x06000079 RID: 121 RVA: 0x0014B09C File Offset: 0x0014949C
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

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x0600007A RID: 122 RVA: 0x0014B0A8 File Offset: 0x001494A8
		' (set) Token: 0x0600007B RID: 123 RVA: 0x0014B0C0 File Offset: 0x001494C0
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

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x0600007C RID: 124 RVA: 0x0014B0CC File Offset: 0x001494CC
		' (set) Token: 0x0600007D RID: 125 RVA: 0x0014B0E4 File Offset: 0x001494E4
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

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x0600007E RID: 126 RVA: 0x0014B144 File Offset: 0x00149544
		' (set) Token: 0x0600007F RID: 127 RVA: 0x0014B15C File Offset: 0x0014955C
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

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x06000080 RID: 128 RVA: 0x0014B1BC File Offset: 0x001495BC
		' (set) Token: 0x06000081 RID: 129 RVA: 0x0014B1D4 File Offset: 0x001495D4
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

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x06000082 RID: 130 RVA: 0x0014B1E0 File Offset: 0x001495E0
		' (set) Token: 0x06000083 RID: 131 RVA: 0x0014B1F8 File Offset: 0x001495F8
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

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x06000084 RID: 132 RVA: 0x0014B204 File Offset: 0x00149604
		' (set) Token: 0x06000085 RID: 133 RVA: 0x0014B21C File Offset: 0x0014961C
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

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x06000086 RID: 134 RVA: 0x0014B228 File Offset: 0x00149628
		' (set) Token: 0x06000087 RID: 135 RVA: 0x0014B240 File Offset: 0x00149640
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

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x06000088 RID: 136 RVA: 0x0014B24C File Offset: 0x0014964C
		' (set) Token: 0x06000089 RID: 137 RVA: 0x0014B264 File Offset: 0x00149664
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

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x0600008A RID: 138 RVA: 0x0014B270 File Offset: 0x00149670
		' (set) Token: 0x0600008B RID: 139 RVA: 0x0014B288 File Offset: 0x00149688
		Friend Overridable Property Label7 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x0600008C RID: 140 RVA: 0x0014B294 File Offset: 0x00149694
		' (set) Token: 0x0600008D RID: 141 RVA: 0x0014B2AC File Offset: 0x001496AC
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

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x0600008E RID: 142 RVA: 0x0014B2B8 File Offset: 0x001496B8
		' (set) Token: 0x0600008F RID: 143 RVA: 0x0014B2D0 File Offset: 0x001496D0
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

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x06000090 RID: 144 RVA: 0x0014B2DC File Offset: 0x001496DC
		' (set) Token: 0x06000091 RID: 145 RVA: 0x0014B2F4 File Offset: 0x001496F4
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

		' Token: 0x06000092 RID: 146 RVA: 0x0014B300 File Offset: 0x00149700
		Private Sub Button1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000093 RID: 147 RVA: 0x0014B304 File Offset: 0x00149704
		Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs)
			Dim flag As Boolean = Me.TrackBar1.Value = 1
			If flag Then
				Me.th = "1"
			Else
				flag = (Me.TrackBar1.Value = 2)
				If flag Then
					Me.th = "10"
				Else
					flag = (Me.TrackBar1.Value = 3)
					If flag Then
						Me.th = "30"
					Else
						flag = (Me.TrackBar1.Value = 4)
						If flag Then
							Me.th = "50"
						Else
							flag = (Me.TrackBar1.Value = 5)
							If flag Then
								Me.th = "70"
							Else
								flag = (Me.TrackBar1.Value = 6)
								If flag Then
									Me.th = "100"
								Else
									flag = (Me.TrackBar1.Value = 7)
									If flag Then
										Me.th = "150"
									Else
										flag = (Me.TrackBar1.Value = 8)
										If flag Then
											Me.th = "250"
										Else
											flag = (Me.TrackBar1.Value = 9)
											If flag Then
												Me.th = "400"
											Else
												flag = (Me.TrackBar1.Value = 10)
												If flag Then
													Me.th = "500"
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
		End Sub

		' Token: 0x06000094 RID: 148 RVA: 0x0014B45C File Offset: 0x0014985C
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000095 RID: 149 RVA: 0x0014B460 File Offset: 0x00149860
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Me.TextBox5.Text = Me.TextBox1.Text
		End Sub

		' Token: 0x06000096 RID: 150 RVA: 0x0014B47C File Offset: 0x0014987C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = CType(Dns.GetHostByName(Me.TextBox3.Text).AddressList.GetValue(0), IPAddress).ToString()
				Me.TextBox5.Text = text
			Catch ex As Exception
				Interaction.MsgBox("Error", MsgBoxStyle.Information, Nothing)
			End Try
		End Sub

		' Token: 0x04000028 RID: 40
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400002A RID: 42
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400002B RID: 43
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x0400002C RID: 44
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x0400002D RID: 45
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x0400002E RID: 46
		<AccessedThroughProperty("TrackBar1")>
		Private _TrackBar1 As TrackBar

		' Token: 0x0400002F RID: 47
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000030 RID: 48
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000031 RID: 49
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000032 RID: 50
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000033 RID: 51
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000034 RID: 52
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x04000035 RID: 53
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x04000036 RID: 54
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x04000037 RID: 55
		<AccessedThroughProperty("TextBox5")>
		Private _TextBox5 As TextBox

		' Token: 0x04000038 RID: 56
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x04000039 RID: 57
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x0400003A RID: 58
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x0400003B RID: 59
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x0400003C RID: 60
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x0400003D RID: 61
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x0400003E RID: 62
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x0400003F RID: 63
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x04000040 RID: 64
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x04000041 RID: 65
		<AccessedThroughProperty("TextBox4")>
		Private _TextBox4 As TextBox

		' Token: 0x04000042 RID: 66
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x04000043 RID: 67
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x04000044 RID: 68
		Public sock As Integer

		' Token: 0x04000045 RID: 69
		Private th As String

		' Token: 0x04000046 RID: 70
		Public pcat As Object
	End Class
End Namespace
