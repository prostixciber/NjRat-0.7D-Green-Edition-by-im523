Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My
	' Token: 0x0200004A RID: 74
	<DebuggerNonUserCode()>
	<HideModuleName()>
	<CompilerGenerated()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x170001F2 RID: 498
		' (get) Token: 0x06000626 RID: 1574 RVA: 0x00148A10 File Offset: 0x00146E10
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
