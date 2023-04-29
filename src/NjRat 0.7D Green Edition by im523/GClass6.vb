Imports System
Imports System.Diagnostics

Namespace NJRAT
	' Token: 0x02000033 RID: 51
	Public NotInheritable Class GClass6
		' Token: 0x060005B8 RID: 1464 RVA: 0x001458B0 File Offset: 0x00143CB0
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x060005B9 RID: 1465 RVA: 0x001458BC File Offset: 0x00143CBC
		Public Function method_0(gclass6_0 As GClass6) As Double
			Dim num As Double = Me.double_0
			Dim num2 As Double = Me.double_1
			Dim num3 As Double = gclass6_0.double_0
			Dim num4 As Double = gclass6_0.double_1
			num *= GClass6.double_4
			num3 *= GClass6.double_4
			Dim num5 As Double = num3 - num
			Dim num6 As Double = (num4 - num2) * GClass6.double_4
			Dim num7 As Double = Math.Pow(Math.Sin(num5 / 2.0), 2.0) + Math.Cos(num) * Math.Cos(num3) * Math.Pow(Math.Sin(num6 / 2.0), 2.0)
			Return GClass6.double_2 * Math.Atan2(Math.Sqrt(num7), Math.Sqrt(1.0 - num7))
		End Function

		' Token: 0x0400030F RID: 783
		Public double_0 As Double

		' Token: 0x04000310 RID: 784
		Public double_1 As Double

		' Token: 0x04000311 RID: 785
		Private Shared double_2 As Double = 12756.4

		' Token: 0x04000312 RID: 786
		Private Shared double_3 As Double = 3.14159265

		' Token: 0x04000313 RID: 787
		Private Shared double_4 As Double = GClass6.double_3 / 180.0

		' Token: 0x04000314 RID: 788
		Public int_0 As Integer

		' Token: 0x04000315 RID: 789
		Public int_1 As Integer

		' Token: 0x04000316 RID: 790
		Public int_2 As Integer

		' Token: 0x04000317 RID: 791
		Public string_0 As String

		' Token: 0x04000318 RID: 792
		Public string_1 As String

		' Token: 0x04000319 RID: 793
		Public string_2 As String

		' Token: 0x0400031A RID: 794
		Public string_3 As String

		' Token: 0x0400031B RID: 795
		Public string_4 As String

		' Token: 0x0400031C RID: 796
		Public string_5 As String
	End Class
End Namespace
