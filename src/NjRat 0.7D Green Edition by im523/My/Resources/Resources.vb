Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My.Resources
	' Token: 0x02000048 RID: 72
	<DebuggerNonUserCode()>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")>
	<HideModuleName()>
	<CompilerGenerated()>
	Friend NotInheritable Module Resources
		' Token: 0x170001E7 RID: 487
		' (get) Token: 0x06000617 RID: 1559 RVA: 0x0014873C File Offset: 0x00146B3C
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				Dim flag As Boolean = Object.ReferenceEquals(Resources.resourceMan, Nothing)
				If flag Then
					Dim resourceManager As ResourceManager = New ResourceManager("NJRAT.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x170001E8 RID: 488
		' (get) Token: 0x06000618 RID: 1560 RVA: 0x00148784 File Offset: 0x00146B84
		' (set) Token: 0x06000619 RID: 1561 RVA: 0x0014879C File Offset: 0x00146B9C
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x170001E9 RID: 489
		' (get) Token: 0x0600061A RID: 1562 RVA: 0x001487A8 File Offset: 0x00146BA8
		Friend ReadOnly Property bullet_arrow_down As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("bullet_arrow_down", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x170001EA RID: 490
		' (get) Token: 0x0600061B RID: 1563 RVA: 0x001487DC File Offset: 0x00146BDC
		Friend ReadOnly Property bullet_arrow_up As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("bullet_arrow_up", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x170001EB RID: 491
		' (get) Token: 0x0600061C RID: 1564 RVA: 0x00148810 File Offset: 0x00146C10
		Friend ReadOnly Property control_pause_blue As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("control_pause_blue", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x170001EC RID: 492
		' (get) Token: 0x0600061D RID: 1565 RVA: 0x00148844 File Offset: 0x00146C44
		Friend ReadOnly Property control_play_blue As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("control_play_blue", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x170001ED RID: 493
		' (get) Token: 0x0600061E RID: 1566 RVA: 0x00148878 File Offset: 0x00146C78
		Friend ReadOnly Property icon As Icon
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("icon", Resources.resourceCulture))
				Return CType(objectValue, Icon)
			End Get
		End Property

		' Token: 0x170001EE RID: 494
		' (get) Token: 0x0600061F RID: 1567 RVA: 0x001488AC File Offset: 0x00146CAC
		Friend ReadOnly Property JPEG As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("JPEG", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x170001EF RID: 495
		' (get) Token: 0x06000620 RID: 1568 RVA: 0x001488E0 File Offset: 0x00146CE0
		Friend ReadOnly Property notf As String
			Get
				Return Resources.ResourceManager.GetString("notf", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x170001F0 RID: 496
		' (get) Token: 0x06000621 RID: 1569 RVA: 0x00148908 File Offset: 0x00146D08
		Friend ReadOnly Property RichTextBox1 As String
			Get
				Return Resources.ResourceManager.GetString("RichTextBox1", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x0400035D RID: 861
		Private resourceMan As ResourceManager

		' Token: 0x0400035E RID: 862
		Private resourceCulture As CultureInfo
	End Module
End Namespace
