Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My
	' Token: 0x02000004 RID: 4
	<GeneratedCode("MyTemplate", "8.0.0.0")>
	<HideModuleName()>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000008 RID: 8 RVA: 0x00148C08 File Offset: 0x00147008
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00148C24 File Offset: 0x00147024
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x0600000A RID: 10 RVA: 0x00148C40 File Offset: 0x00147040
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x0600000B RID: 11 RVA: 0x00148C5C File Offset: 0x0014705C
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000C RID: 12 RVA: 0x00148C78 File Offset: 0x00147078
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000002 RID: 2
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000003 RID: 3
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000004 RID: 4
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000005 RID: 5
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000006 RID: 6
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x02000005 RID: 5
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			' Token: 0x17000006 RID: 6
			' (get) Token: 0x0600000D RID: 13 RVA: 0x00148C94 File Offset: 0x00147094
			' (set) Token: 0x06000027 RID: 39 RVA: 0x001490A4 File Offset: 0x001474A4
			Public Property About As About
				<DebuggerNonUserCode()>
				Get
					Me.m_About = MyProject.MyForms.Create__Instance__(Of About)(Me.m_About)
					Return Me.m_About
				End Get
				<DebuggerNonUserCode()>
				Set(value As About)
					Dim flag As Boolean = value Is Me.m_About
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of About)(Me.m_About)
					End If
				End Set
			End Property

			' Token: 0x17000007 RID: 7
			' (get) Token: 0x0600000E RID: 14 RVA: 0x00148CBC File Offset: 0x001470BC
			' (set) Token: 0x06000028 RID: 40 RVA: 0x001490E8 File Offset: 0x001474E8
			Public Property Builder As Builder
				<DebuggerNonUserCode()>
				Get
					Me.m_Builder = MyProject.MyForms.Create__Instance__(Of Builder)(Me.m_Builder)
					Return Me.m_Builder
				End Get
				<DebuggerNonUserCode()>
				Set(value As Builder)
					Dim flag As Boolean = value Is Me.m_Builder
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Builder)(Me.m_Builder)
					End If
				End Set
			End Property

			' Token: 0x17000008 RID: 8
			' (get) Token: 0x0600000F RID: 15 RVA: 0x00148CE4 File Offset: 0x001470E4
			' (set) Token: 0x06000029 RID: 41 RVA: 0x0014912C File Offset: 0x0014752C
			Public Property Cam As Cam
				<DebuggerNonUserCode()>
				Get
					Me.m_Cam = MyProject.MyForms.Create__Instance__(Of Cam)(Me.m_Cam)
					Return Me.m_Cam
				End Get
				<DebuggerNonUserCode()>
				Set(value As Cam)
					Dim flag As Boolean = value Is Me.m_Cam
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Cam)(Me.m_Cam)
					End If
				End Set
			End Property

			' Token: 0x17000009 RID: 9
			' (get) Token: 0x06000010 RID: 16 RVA: 0x00148D0C File Offset: 0x0014710C
			' (set) Token: 0x0600002A RID: 42 RVA: 0x00149170 File Offset: 0x00147570
			Public Property Chat As Chat
				<DebuggerNonUserCode()>
				Get
					Me.m_Chat = MyProject.MyForms.Create__Instance__(Of Chat)(Me.m_Chat)
					Return Me.m_Chat
				End Get
				<DebuggerNonUserCode()>
				Set(value As Chat)
					Dim flag As Boolean = value Is Me.m_Chat
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Chat)(Me.m_Chat)
					End If
				End Set
			End Property

			' Token: 0x1700000A RID: 10
			' (get) Token: 0x06000011 RID: 17 RVA: 0x00148D34 File Offset: 0x00147134
			' (set) Token: 0x0600002B RID: 43 RVA: 0x001491B4 File Offset: 0x001475B4
			Public Property DDoS As DDoS
				<DebuggerNonUserCode()>
				Get
					Me.m_DDoS = MyProject.MyForms.Create__Instance__(Of DDoS)(Me.m_DDoS)
					Return Me.m_DDoS
				End Get
				<DebuggerNonUserCode()>
				Set(value As DDoS)
					Dim flag As Boolean = value Is Me.m_DDoS
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of DDoS)(Me.m_DDoS)
					End If
				End Set
			End Property

			' Token: 0x1700000B RID: 11
			' (get) Token: 0x06000012 RID: 18 RVA: 0x00148D5C File Offset: 0x0014715C
			' (set) Token: 0x0600002C RID: 44 RVA: 0x001491F8 File Offset: 0x001475F8
			Public Property Dos As Dos
				<DebuggerNonUserCode()>
				Get
					Me.m_Dos = MyProject.MyForms.Create__Instance__(Of Dos)(Me.m_Dos)
					Return Me.m_Dos
				End Get
				<DebuggerNonUserCode()>
				Set(value As Dos)
					Dim flag As Boolean = value Is Me.m_Dos
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Dos)(Me.m_Dos)
					End If
				End Set
			End Property

			' Token: 0x1700000C RID: 12
			' (get) Token: 0x06000013 RID: 19 RVA: 0x00148D84 File Offset: 0x00147184
			' (set) Token: 0x0600002D RID: 45 RVA: 0x0014923C File Offset: 0x0014763C
			Public Property DW As DW
				<DebuggerNonUserCode()>
				Get
					Me.m_DW = MyProject.MyForms.Create__Instance__(Of DW)(Me.m_DW)
					Return Me.m_DW
				End Get
				<DebuggerNonUserCode()>
				Set(value As DW)
					Dim flag As Boolean = value Is Me.m_DW
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of DW)(Me.m_DW)
					End If
				End Set
			End Property

			' Token: 0x1700000D RID: 13
			' (get) Token: 0x06000014 RID: 20 RVA: 0x00148DAC File Offset: 0x001471AC
			' (set) Token: 0x0600002E RID: 46 RVA: 0x00149280 File Offset: 0x00147680
			Public Property Form1 As Form1
				<DebuggerNonUserCode()>
				Get
					Me.m_Form1 = MyProject.MyForms.Create__Instance__(Of Form1)(Me.m_Form1)
					Return Me.m_Form1
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form1)
					Dim flag As Boolean = value Is Me.m_Form1
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form1)(Me.m_Form1)
					End If
				End Set
			End Property

			' Token: 0x1700000E RID: 14
			' (get) Token: 0x06000015 RID: 21 RVA: 0x00148DD4 File Offset: 0x001471D4
			' (set) Token: 0x0600002F RID: 47 RVA: 0x001492C4 File Offset: 0x001476C4
			Public Property FromLink As FromLink
				<DebuggerNonUserCode()>
				Get
					Me.m_FromLink = MyProject.MyForms.Create__Instance__(Of FromLink)(Me.m_FromLink)
					Return Me.m_FromLink
				End Get
				<DebuggerNonUserCode()>
				Set(value As FromLink)
					Dim flag As Boolean = value Is Me.m_FromLink
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FromLink)(Me.m_FromLink)
					End If
				End Set
			End Property

			' Token: 0x1700000F RID: 15
			' (get) Token: 0x06000016 RID: 22 RVA: 0x00148DFC File Offset: 0x001471FC
			' (set) Token: 0x06000030 RID: 48 RVA: 0x00149308 File Offset: 0x00147708
			Public Property fun As fun
				<DebuggerNonUserCode()>
				Get
					Me.m_fun = MyProject.MyForms.Create__Instance__(Of fun)(Me.m_fun)
					Return Me.m_fun
				End Get
				<DebuggerNonUserCode()>
				Set(value As fun)
					Dim flag As Boolean = value Is Me.m_fun
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of fun)(Me.m_fun)
					End If
				End Set
			End Property

			' Token: 0x17000010 RID: 16
			' (get) Token: 0x06000017 RID: 23 RVA: 0x00148E24 File Offset: 0x00147224
			' (set) Token: 0x06000031 RID: 49 RVA: 0x0014934C File Offset: 0x0014774C
			Public Property FURL As FURL
				<DebuggerNonUserCode()>
				Get
					Me.m_FURL = MyProject.MyForms.Create__Instance__(Of FURL)(Me.m_FURL)
					Return Me.m_FURL
				End Get
				<DebuggerNonUserCode()>
				Set(value As FURL)
					Dim flag As Boolean = value Is Me.m_FURL
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FURL)(Me.m_FURL)
					End If
				End Set
			End Property

			' Token: 0x17000011 RID: 17
			' (get) Token: 0x06000018 RID: 24 RVA: 0x00148E4C File Offset: 0x0014724C
			' (set) Token: 0x06000032 RID: 50 RVA: 0x00149390 File Offset: 0x00147790
			Public Property kl As kl
				<DebuggerNonUserCode()>
				Get
					Me.m_kl = MyProject.MyForms.Create__Instance__(Of kl)(Me.m_kl)
					Return Me.m_kl
				End Get
				<DebuggerNonUserCode()>
				Set(value As kl)
					Dim flag As Boolean = value Is Me.m_kl
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of kl)(Me.m_kl)
					End If
				End Set
			End Property

			' Token: 0x17000012 RID: 18
			' (get) Token: 0x06000019 RID: 25 RVA: 0x00148E74 File Offset: 0x00147274
			' (set) Token: 0x06000033 RID: 51 RVA: 0x001493D4 File Offset: 0x001477D4
			Public Property Manager As Manager
				<DebuggerNonUserCode()>
				Get
					Me.m_Manager = MyProject.MyForms.Create__Instance__(Of Manager)(Me.m_Manager)
					Return Me.m_Manager
				End Get
				<DebuggerNonUserCode()>
				Set(value As Manager)
					Dim flag As Boolean = value Is Me.m_Manager
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Manager)(Me.m_Manager)
					End If
				End Set
			End Property

			' Token: 0x17000013 RID: 19
			' (get) Token: 0x0600001A RID: 26 RVA: 0x00148E9C File Offset: 0x0014729C
			' (set) Token: 0x06000034 RID: 52 RVA: 0x00149418 File Offset: 0x00147818
			Public Property Mic As Mic
				<DebuggerNonUserCode()>
				Get
					Me.m_Mic = MyProject.MyForms.Create__Instance__(Of Mic)(Me.m_Mic)
					Return Me.m_Mic
				End Get
				<DebuggerNonUserCode()>
				Set(value As Mic)
					Dim flag As Boolean = value Is Me.m_Mic
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Mic)(Me.m_Mic)
					End If
				End Set
			End Property

			' Token: 0x17000014 RID: 20
			' (get) Token: 0x0600001B RID: 27 RVA: 0x00148EC4 File Offset: 0x001472C4
			' (set) Token: 0x06000035 RID: 53 RVA: 0x0014945C File Offset: 0x0014785C
			Public Property NOIP As NOIP
				<DebuggerNonUserCode()>
				Get
					Me.m_NOIP = MyProject.MyForms.Create__Instance__(Of NOIP)(Me.m_NOIP)
					Return Me.m_NOIP
				End Get
				<DebuggerNonUserCode()>
				Set(value As NOIP)
					Dim flag As Boolean = value Is Me.m_NOIP
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of NOIP)(Me.m_NOIP)
					End If
				End Set
			End Property

			' Token: 0x17000015 RID: 21
			' (get) Token: 0x0600001C RID: 28 RVA: 0x00148EEC File Offset: 0x001472EC
			' (set) Token: 0x06000036 RID: 54 RVA: 0x001494A0 File Offset: 0x001478A0
			Public Property Note As Note
				<DebuggerNonUserCode()>
				Get
					Me.m_Note = MyProject.MyForms.Create__Instance__(Of Note)(Me.m_Note)
					Return Me.m_Note
				End Get
				<DebuggerNonUserCode()>
				Set(value As Note)
					Dim flag As Boolean = value Is Me.m_Note
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Note)(Me.m_Note)
					End If
				End Set
			End Property

			' Token: 0x17000016 RID: 22
			' (get) Token: 0x0600001D RID: 29 RVA: 0x00148F14 File Offset: 0x00147314
			' (set) Token: 0x06000037 RID: 55 RVA: 0x001494E4 File Offset: 0x001478E4
			Public Property notf As notf
				<DebuggerNonUserCode()>
				Get
					Me.m_notf = MyProject.MyForms.Create__Instance__(Of notf)(Me.m_notf)
					Return Me.m_notf
				End Get
				<DebuggerNonUserCode()>
				Set(value As notf)
					Dim flag As Boolean = value Is Me.m_notf
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of notf)(Me.m_notf)
					End If
				End Set
			End Property

			' Token: 0x17000017 RID: 23
			' (get) Token: 0x0600001E RID: 30 RVA: 0x00148F3C File Offset: 0x0014733C
			' (set) Token: 0x06000038 RID: 56 RVA: 0x00149528 File Offset: 0x00147928
			Public Property OpenSite As OpenSite
				<DebuggerNonUserCode()>
				Get
					Me.m_OpenSite = MyProject.MyForms.Create__Instance__(Of OpenSite)(Me.m_OpenSite)
					Return Me.m_OpenSite
				End Get
				<DebuggerNonUserCode()>
				Set(value As OpenSite)
					Dim flag As Boolean = value Is Me.m_OpenSite
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of OpenSite)(Me.m_OpenSite)
					End If
				End Set
			End Property

			' Token: 0x17000018 RID: 24
			' (get) Token: 0x0600001F RID: 31 RVA: 0x00148F64 File Offset: 0x00147364
			' (set) Token: 0x06000039 RID: 57 RVA: 0x0014956C File Offset: 0x0014796C
			Public Property pas As pas
				<DebuggerNonUserCode()>
				Get
					Me.m_pas = MyProject.MyForms.Create__Instance__(Of pas)(Me.m_pas)
					Return Me.m_pas
				End Get
				<DebuggerNonUserCode()>
				Set(value As pas)
					Dim flag As Boolean = value Is Me.m_pas
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of pas)(Me.m_pas)
					End If
				End Set
			End Property

			' Token: 0x17000019 RID: 25
			' (get) Token: 0x06000020 RID: 32 RVA: 0x00148F8C File Offset: 0x0014738C
			' (set) Token: 0x0600003A RID: 58 RVA: 0x001495B0 File Offset: 0x001479B0
			Public Property Pass As Pass
				<DebuggerNonUserCode()>
				Get
					Me.m_Pass = MyProject.MyForms.Create__Instance__(Of Pass)(Me.m_Pass)
					Return Me.m_Pass
				End Get
				<DebuggerNonUserCode()>
				Set(value As Pass)
					Dim flag As Boolean = value Is Me.m_Pass
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Pass)(Me.m_Pass)
					End If
				End Set
			End Property

			' Token: 0x1700001A RID: 26
			' (get) Token: 0x06000021 RID: 33 RVA: 0x00148FB4 File Offset: 0x001473B4
			' (set) Token: 0x0600003B RID: 59 RVA: 0x001495F4 File Offset: 0x001479F4
			Public Property port As port
				<DebuggerNonUserCode()>
				Get
					Me.m_port = MyProject.MyForms.Create__Instance__(Of port)(Me.m_port)
					Return Me.m_port
				End Get
				<DebuggerNonUserCode()>
				Set(value As port)
					Dim flag As Boolean = value Is Me.m_port
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of port)(Me.m_port)
					End If
				End Set
			End Property

			' Token: 0x1700001B RID: 27
			' (get) Token: 0x06000022 RID: 34 RVA: 0x00148FDC File Offset: 0x001473DC
			' (set) Token: 0x0600003C RID: 60 RVA: 0x00149638 File Offset: 0x00147A38
			Public Property RGv As RGv
				<DebuggerNonUserCode()>
				Get
					Me.m_RGv = MyProject.MyForms.Create__Instance__(Of RGv)(Me.m_RGv)
					Return Me.m_RGv
				End Get
				<DebuggerNonUserCode()>
				Set(value As RGv)
					Dim flag As Boolean = value Is Me.m_RGv
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of RGv)(Me.m_RGv)
					End If
				End Set
			End Property

			' Token: 0x1700001C RID: 28
			' (get) Token: 0x06000023 RID: 35 RVA: 0x00149004 File Offset: 0x00147404
			' (set) Token: 0x0600003D RID: 61 RVA: 0x0014967C File Offset: 0x00147A7C
			Public Property sc As sc
				<DebuggerNonUserCode()>
				Get
					Me.m_sc = MyProject.MyForms.Create__Instance__(Of sc)(Me.m_sc)
					Return Me.m_sc
				End Get
				<DebuggerNonUserCode()>
				Set(value As sc)
					Dim flag As Boolean = value Is Me.m_sc
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of sc)(Me.m_sc)
					End If
				End Set
			End Property

			' Token: 0x1700001D RID: 29
			' (get) Token: 0x06000024 RID: 36 RVA: 0x0014902C File Offset: 0x0014742C
			' (set) Token: 0x0600003E RID: 62 RVA: 0x001496C0 File Offset: 0x00147AC0
			Public Property script As script
				<DebuggerNonUserCode()>
				Get
					Me.m_script = MyProject.MyForms.Create__Instance__(Of script)(Me.m_script)
					Return Me.m_script
				End Get
				<DebuggerNonUserCode()>
				Set(value As script)
					Dim flag As Boolean = value Is Me.m_script
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of script)(Me.m_script)
					End If
				End Set
			End Property

			' Token: 0x1700001E RID: 30
			' (get) Token: 0x06000025 RID: 37 RVA: 0x00149054 File Offset: 0x00147454
			' (set) Token: 0x0600003F RID: 63 RVA: 0x00149704 File Offset: 0x00147B04
			Public Property STNG As STNG
				<DebuggerNonUserCode()>
				Get
					Me.m_STNG = MyProject.MyForms.Create__Instance__(Of STNG)(Me.m_STNG)
					Return Me.m_STNG
				End Get
				<DebuggerNonUserCode()>
				Set(value As STNG)
					Dim flag As Boolean = value Is Me.m_STNG
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of STNG)(Me.m_STNG)
					End If
				End Set
			End Property

			' Token: 0x1700001F RID: 31
			' (get) Token: 0x06000026 RID: 38 RVA: 0x0014907C File Offset: 0x0014747C
			' (set) Token: 0x06000040 RID: 64 RVA: 0x00149748 File Offset: 0x00147B48
			Public Property up As up
				<DebuggerNonUserCode()>
				Get
					Me.m_up = MyProject.MyForms.Create__Instance__(Of up)(Me.m_up)
					Return Me.m_up
				End Get
				<DebuggerNonUserCode()>
				Set(value As up)
					Dim flag As Boolean = value Is Me.m_up
					If Not flag Then
						flag = (value IsNot Nothing)
						If flag Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of up)(Me.m_up)
					End If
				End Set
			End Property

			' Token: 0x06000041 RID: 65 RVA: 0x0014978C File Offset: 0x00147B8C
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim flag As Boolean = Instance Is Nothing OrElse Instance.IsDisposed
				If flag Then
					Dim flag2 As Boolean = MyProject.MyForms.m_FormBeingCreated IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))
						If flag3 Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return Instance
			End Function

			' Token: 0x06000042 RID: 66 RVA: 0x001498C8 File Offset: 0x00147CC8
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x06000043 RID: 67 RVA: 0x001498F4 File Offset: 0x00147CF4
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x06000044 RID: 68 RVA: 0x00149900 File Offset: 0x00147D00
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000045 RID: 69 RVA: 0x00149920 File Offset: 0x00147D20
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000046 RID: 70 RVA: 0x00149938 File Offset: 0x00147D38
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x06000047 RID: 71 RVA: 0x00149954 File Offset: 0x00147D54
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x04000007 RID: 7
			Public m_About As About

			' Token: 0x04000008 RID: 8
			Public m_Builder As Builder

			' Token: 0x04000009 RID: 9
			Public m_Cam As Cam

			' Token: 0x0400000A RID: 10
			Public m_Chat As Chat

			' Token: 0x0400000B RID: 11
			Public m_DDoS As DDoS

			' Token: 0x0400000C RID: 12
			Public m_Dos As Dos

			' Token: 0x0400000D RID: 13
			Public m_DW As DW

			' Token: 0x0400000E RID: 14
			Public m_Form1 As Form1

			' Token: 0x0400000F RID: 15
			Public m_FromLink As FromLink

			' Token: 0x04000010 RID: 16
			Public m_fun As fun

			' Token: 0x04000011 RID: 17
			Public m_FURL As FURL

			' Token: 0x04000012 RID: 18
			Public m_kl As kl

			' Token: 0x04000013 RID: 19
			Public m_Manager As Manager

			' Token: 0x04000014 RID: 20
			Public m_Mic As Mic

			' Token: 0x04000015 RID: 21
			Public m_NOIP As NOIP

			' Token: 0x04000016 RID: 22
			Public m_Note As Note

			' Token: 0x04000017 RID: 23
			Public m_notf As notf

			' Token: 0x04000018 RID: 24
			Public m_OpenSite As OpenSite

			' Token: 0x04000019 RID: 25
			Public m_pas As pas

			' Token: 0x0400001A RID: 26
			Public m_Pass As Pass

			' Token: 0x0400001B RID: 27
			Public m_port As port

			' Token: 0x0400001C RID: 28
			Public m_RGv As RGv

			' Token: 0x0400001D RID: 29
			Public m_sc As sc

			' Token: 0x0400001E RID: 30
			Public m_script As script

			' Token: 0x0400001F RID: 31
			Public m_STNG As STNG

			' Token: 0x04000020 RID: 32
			Public m_up As up

			' Token: 0x04000021 RID: 33
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable
		End Class

		' Token: 0x02000006 RID: 6
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			' Token: 0x06000048 RID: 72 RVA: 0x0014996C File Offset: 0x00147D6C
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000049 RID: 73 RVA: 0x0014998C File Offset: 0x00147D8C
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600004A RID: 74 RVA: 0x001499A4 File Offset: 0x00147DA4
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x0600004B RID: 75 RVA: 0x001499C0 File Offset: 0x00147DC0
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x0600004C RID: 76 RVA: 0x001499D8 File Offset: 0x00147DD8
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim flag As Boolean = instance Is Nothing
				Dim result As T
				If flag Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

			' Token: 0x0600004D RID: 77 RVA: 0x00149A04 File Offset: 0x00147E04
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x0600004E RID: 78 RVA: 0x00149A24 File Offset: 0x00147E24
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000007 RID: 7
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x17000020 RID: 32
			' (get) Token: 0x0600004F RID: 79 RVA: 0x00149A30 File Offset: 0x00147E30
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					Dim flag As Boolean = MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing
					If flag Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x06000050 RID: 80 RVA: 0x00149A64 File Offset: 0x00147E64
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x04000022 RID: 34
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
