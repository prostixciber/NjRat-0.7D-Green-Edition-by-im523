Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My
	' Token: 0x02000049 RID: 73
	<CompilerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x06000624 RID: 1572 RVA: 0x00148964 File Offset: 0x00146D64
		<DebuggerNonUserCode()>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Private Shared Sub AutoSaveSettings(sender As Object, e As EventArgs)
			Dim saveMySettingsOnExit As Boolean = MyProject.Application.SaveMySettingsOnExit
			If saveMySettingsOnExit Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub

		' Token: 0x170001F1 RID: 497
		' (get) Token: 0x06000625 RID: 1573 RVA: 0x00148990 File Offset: 0x00146D90
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				Dim flag As Boolean = Not MySettings.addedHandler
				If flag Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						flag = Not MySettings.addedHandler
						If flag Then
							AddHandler MyProject.Application.Shutdown, AddressOf MySettings.AutoSaveSettings
							MySettings.addedHandler = True
						End If
					End SyncLock
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		' Token: 0x0400035F RID: 863
		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)

		' Token: 0x04000360 RID: 864
		Private Shared addedHandler As Boolean

		' Token: 0x04000361 RID: 865
		Private Shared addedHandlerLockObject As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Class
End Namespace
