Imports System
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000032 RID: 50
	Public NotInheritable Class GClass5
		' Token: 0x060005B2 RID: 1458 RVA: 0x00145710 File Offset: 0x00143B10
		Public Sub New(string_1 As String)
			Me.string_0 = string_1
		End Sub

		' Token: 0x060005B3 RID: 1459 RVA: 0x00145724 File Offset: 0x00143B24
		Public Function method_0() As Integer
			Dim flag As Boolean = Me.string_0 = Nothing Or Operators.CompareString(Me.string_0, String.Empty, False) = 0
			Dim result As Integer
			If flag Then
				result = GClass5.int_0
			Else
				result = Convert.ToInt32(Me.string_0.Substring(4, 3)) - 105
			End If
			Return result
		End Function

		' Token: 0x060005B4 RID: 1460 RVA: 0x00145778 File Offset: 0x00143B78
		Public Function method_1() As Boolean
			Return Me.string_0.IndexOf("FREE") < 0
		End Function

		' Token: 0x060005B5 RID: 1461 RVA: 0x001457A0 File Offset: 0x00143BA0
		Public Function method_2() As DateTime
			Dim num As Integer = Me.string_0.Length - 10
			For i As Integer = 0 To num
				Dim flag As Boolean = Char.IsWhiteSpace(Me.string_0(i))
				If flag Then
					Dim s As String = Me.string_0.Substring(i + 1, 8)
					Try
						Return DateTime.ParseExact(s, "yyyyMMdd", Nothing)
					Catch ex As Exception
						Dim ex2 As Exception = ex
						Console.Write(ex2.Message)
						Exit Try
					End Try
				End If
			Next
			Return DateTime.Now
		End Function

		' Token: 0x060005B6 RID: 1462 RVA: 0x00145864 File Offset: 0x00143C64
		Public Function method_3() As String
			Return Me.string_0
		End Function

		' Token: 0x040002FA RID: 762
		Public Shared int_0 As Integer = 1

		' Token: 0x040002FB RID: 763
		Public Shared int_1 As Integer = 7

		' Token: 0x040002FC RID: 764
		Public Shared int_10 As Integer = 11

		' Token: 0x040002FD RID: 765
		Public Shared int_11 As Integer = 12

		' Token: 0x040002FE RID: 766
		Public Shared int_12 As Integer = 21

		' Token: 0x040002FF RID: 767
		Public Shared int_13 As Integer = 22

		' Token: 0x04000300 RID: 768
		Public Shared int_14 As Integer = 23

		' Token: 0x04000301 RID: 769
		Public Shared int_15 As Integer = 24

		' Token: 0x04000302 RID: 770
		Public Shared int_16 As Integer = 30

		' Token: 0x04000303 RID: 771
		Public Shared int_17 As Integer = 31

		' Token: 0x04000304 RID: 772
		Public Shared int_18 As Integer = 32

		' Token: 0x04000305 RID: 773
		Public Shared int_19 As Integer = 33

		' Token: 0x04000306 RID: 774
		Public Shared int_2 As Integer = 3

		' Token: 0x04000307 RID: 775
		Public Shared int_3 As Integer = 6

		' Token: 0x04000308 RID: 776
		Public Shared int_4 As Integer = 2

		' Token: 0x04000309 RID: 777
		Public Shared int_5 As Integer = 5

		' Token: 0x0400030A RID: 778
		Public Shared int_6 As Integer = 4

		' Token: 0x0400030B RID: 779
		Public Shared int_7 As Integer = 8

		' Token: 0x0400030C RID: 780
		Public Shared int_8 As Integer = 9

		' Token: 0x0400030D RID: 781
		Public Shared int_9 As Integer = 10

		' Token: 0x0400030E RID: 782
		Private string_0 As String
	End Class
End Namespace
