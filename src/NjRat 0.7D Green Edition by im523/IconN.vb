Imports System
Imports System.Diagnostics
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security

Namespace NJRAT
	' Token: 0x02000039 RID: 57
	Public Class IconN
		' Token: 0x060005DC RID: 1500 RVA: 0x00146E70 File Offset: 0x00145270
		<DebuggerNonUserCode()>
		Public Sub New()
		End Sub

		' Token: 0x060005DD RID: 1501 RVA: 0x00146E7C File Offset: 0x0014527C
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String)
			IconN.InjectIcon(exeFileName, iconFileName, 1UI, 1UI)
		End Sub

		' Token: 0x060005DE RID: 1502 RVA: 0x00146E8C File Offset: 0x0014528C
		Public Shared Sub InjectIcon(exeFileName As String, iconFileName As String, iconGroupID As UInteger, iconBaseID As UInteger)
			Dim iconFile As IconN.IconFile = IconN.IconFile.FromFile(iconFileName)
			Dim intPtr As IntPtr = IconN.NativeMethods.BeginUpdateResource(exeFileName, False)
			Dim array As Byte() = iconFile.CreateIconGroupData(iconBaseID)
			Dim hUpdate As IntPtr = intPtr
			Dim intPtr2 As IntPtr = New IntPtr(14L)
			Dim type As IntPtr = intPtr2
			Dim intPtr3 As IntPtr = New IntPtr(CLng(CULng(iconGroupID)))
			IconN.NativeMethods.UpdateResource(hUpdate, type, intPtr3, 0S, array, array.Length)
			Dim num As Integer = 0
			Dim num2 As Integer = iconFile.ImageCount - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit For
				End If
				Dim array2 As Byte() = iconFile.get_ImageData(num3)
				Dim hUpdate2 As IntPtr = intPtr
				intPtr3 = New IntPtr(3L)
				Dim type2 As IntPtr = intPtr3
				intPtr2 = New IntPtr(CLng((CULng(iconBaseID) + CULng(CLng(num3)))))
				IconN.NativeMethods.UpdateResource(hUpdate2, type2, intPtr2, 0S, array2, array2.Length)
				num3 += 1
			End While
			IconN.NativeMethods.EndUpdateResource(intPtr, False)
		End Sub

		' Token: 0x0200003A RID: 58
		<SuppressUnmanagedCodeSecurity()>
		Private Class NativeMethods
			' Token: 0x060005DF RID: 1503 RVA: 0x00146F30 File Offset: 0x00145330
			<DebuggerNonUserCode()>
			Public Sub New()
			End Sub

			' Token: 0x060005E0 RID: 1504
			Public Declare Function BeginUpdateResource Lib "kernel32" (fileName As String, <MarshalAs(UnmanagedType.Bool)> deleteExistingResources As Boolean) As IntPtr

			' Token: 0x060005E1 RID: 1505
			Public Declare Function UpdateResource Lib "kernel32" (hUpdate As IntPtr, type As IntPtr, name As IntPtr, language As Short, <MarshalAs(UnmanagedType.LPArray, SizeParamIndex := 5S)> data As Byte(), dataSize As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean

			' Token: 0x060005E2 RID: 1506
			Public Declare Function EndUpdateResource Lib "kernel32" (hUpdate As IntPtr, <MarshalAs(UnmanagedType.Bool)> discard As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
		End Class

		' Token: 0x0200003B RID: 59
		Private Structure ICONDIR
			' Token: 0x0400032C RID: 812
			Public Reserved As UShort

			' Token: 0x0400032D RID: 813
			Public Type As UShort

			' Token: 0x0400032E RID: 814
			Public Count As UShort
		End Structure

		' Token: 0x0200003C RID: 60
		Private Structure ICONDIRENTRY
			' Token: 0x0400032F RID: 815
			Public Width As Byte

			' Token: 0x04000330 RID: 816
			Public Height As Byte

			' Token: 0x04000331 RID: 817
			Public ColorCount As Byte

			' Token: 0x04000332 RID: 818
			Public Reserved As Byte

			' Token: 0x04000333 RID: 819
			Public Planes As UShort

			' Token: 0x04000334 RID: 820
			Public BitCount As UShort

			' Token: 0x04000335 RID: 821
			Public BytesInRes As Integer

			' Token: 0x04000336 RID: 822
			Public ImageOffset As Integer
		End Structure

		' Token: 0x0200003D RID: 61
		Private Structure BITMAPINFOHEADER
			' Token: 0x04000337 RID: 823
			Public Size As UInteger

			' Token: 0x04000338 RID: 824
			Public Width As Integer

			' Token: 0x04000339 RID: 825
			Public Height As Integer

			' Token: 0x0400033A RID: 826
			Public Planes As UShort

			' Token: 0x0400033B RID: 827
			Public BitCount As UShort

			' Token: 0x0400033C RID: 828
			Public Compression As UInteger

			' Token: 0x0400033D RID: 829
			Public SizeImage As UInteger

			' Token: 0x0400033E RID: 830
			Public XPelsPerMeter As Integer

			' Token: 0x0400033F RID: 831
			Public YPelsPerMeter As Integer

			' Token: 0x04000340 RID: 832
			Public ClrUsed As UInteger

			' Token: 0x04000341 RID: 833
			Public ClrImportant As UInteger
		End Structure

		' Token: 0x0200003E RID: 62
		<StructLayout(LayoutKind.Sequential, Pack := 2)>
		Private Structure GRPICONDIRENTRY
			' Token: 0x04000342 RID: 834
			Public Width As Byte

			' Token: 0x04000343 RID: 835
			Public Height As Byte

			' Token: 0x04000344 RID: 836
			Public ColorCount As Byte

			' Token: 0x04000345 RID: 837
			Public Reserved As Byte

			' Token: 0x04000346 RID: 838
			Public Planes As UShort

			' Token: 0x04000347 RID: 839
			Public BitCount As UShort

			' Token: 0x04000348 RID: 840
			Public BytesInRes As Integer

			' Token: 0x04000349 RID: 841
			Public ID As UShort
		End Structure

		' Token: 0x0200003F RID: 63
		Private Class IconFile
			' Token: 0x170001E4 RID: 484
			' (get) Token: 0x060005E3 RID: 1507 RVA: 0x00146F3C File Offset: 0x0014533C
			Public ReadOnly Property ImageCount As Integer
				Get
					Return CInt(Me.iconDir.Count)
				End Get
			End Property

			' Token: 0x170001E5 RID: 485
			' (get) Token: 0x060005E4 RID: 1508 RVA: 0x00146F5C File Offset: 0x0014535C
			Public ReadOnly Property ImageData(index As Integer) As Byte()
				Get
					Return Me.iconImage(index)
				End Get
			End Property

			' Token: 0x060005E5 RID: 1509 RVA: 0x00146F78 File Offset: 0x00145378
			Private Sub New()
				Me.iconDir = Nothing
			End Sub

			' Token: 0x060005E6 RID: 1510 RVA: 0x00146F90 File Offset: 0x00145390
			Public Shared Function FromFile(filename As String) As IconN.IconFile
				Dim iconFile As IconN.IconFile = New IconN.IconFile()
				Dim array As Byte() = File.ReadAllBytes(filename)
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				iconFile.iconDir = CType(Marshal.PtrToStructure(gchandle.AddrOfPinnedObject(), GetType(IconN.ICONDIR)), IconN.ICONDIR)
				iconFile.iconEntry = New IconN.ICONDIRENTRY(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1) {}
				iconFile.iconImage = New Byte(CInt((iconFile.iconDir.Count - 1US + 1US)) - 1)() {}
				Dim num As Integer = Marshal.SizeOf(iconFile.iconDir)
				Dim typeFromHandle As Type = GetType(IconN.ICONDIRENTRY)
				Dim num2 As Integer = Marshal.SizeOf(typeFromHandle)
				Dim num3 As Integer = 0
				Dim num4 As Integer = CInt((iconFile.iconDir.Count - 1US))
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit For
					End If
					Dim ptr As IntPtr = New IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + CLng(num))
					Dim icondirentry As IconN.ICONDIRENTRY = CType(Marshal.PtrToStructure(ptr, typeFromHandle), IconN.ICONDIRENTRY)
					iconFile.iconEntry(num5) = icondirentry
					iconFile.iconImage(num5) = New Byte(icondirentry.BytesInRes - 1 + 1 - 1) {}
					Buffer.BlockCopy(array, icondirentry.ImageOffset, iconFile.iconImage(num5), 0, icondirentry.BytesInRes)
					num += num2
					num5 += 1
				End While
				gchandle.Free()
				Return iconFile
			End Function

			' Token: 0x060005E7 RID: 1511 RVA: 0x001470F0 File Offset: 0x001454F0
			Public Function CreateIconGroupData(iconBaseID As UInteger) As Byte()
				Dim num As Integer = Marshal.SizeOf(GetType(IconN.ICONDIR)) + Marshal.SizeOf(GetType(IconN.GRPICONDIRENTRY)) * Me.ImageCount
				Dim array As Byte() = New Byte(num - 1 + 1 - 1) {}
				Dim gchandle As GCHandle = GCHandle.Alloc(array, GCHandleType.Pinned)
				Marshal.StructureToPtr(Me.iconDir, gchandle.AddrOfPinnedObject(), False)
				Dim num2 As Integer = Marshal.SizeOf(Me.iconDir)
				Dim num3 As Integer = 0
				Dim num4 As Integer = Me.ImageCount - 1
				Dim num5 As Integer = num3
				While True
					Dim num6 As Integer = num5
					Dim num7 As Integer = num4
					If num6 > num7 Then
						Exit For
					End If
					Dim grpicondirentry As IconN.GRPICONDIRENTRY = Nothing
					Dim bitmapinfoheader As IconN.BITMAPINFOHEADER = Nothing
					Dim gchandle2 As GCHandle = GCHandle.Alloc(bitmapinfoheader, GCHandleType.Pinned)
					Marshal.Copy(Me.get_ImageData(num5), 0, gchandle2.AddrOfPinnedObject(), Marshal.SizeOf(GetType(IconN.BITMAPINFOHEADER)))
					gchandle2.Free()
					grpicondirentry.Width = Me.iconEntry(num5).Width
					grpicondirentry.Height = Me.iconEntry(num5).Height
					grpicondirentry.ColorCount = Me.iconEntry(num5).ColorCount
					grpicondirentry.Reserved = Me.iconEntry(num5).Reserved
					grpicondirentry.Planes = bitmapinfoheader.Planes
					grpicondirentry.BitCount = bitmapinfoheader.BitCount
					grpicondirentry.BytesInRes = Me.iconEntry(num5).BytesInRes
					grpicondirentry.ID = CUShort((CULng(iconBaseID) + CULng(CLng(num5))))
					Dim [structure] As Object = grpicondirentry
					Dim ptr As IntPtr = New IntPtr(gchandle.AddrOfPinnedObject().ToInt64() + CLng(num2))
					Marshal.StructureToPtr([structure], ptr, False)
					num2 += Marshal.SizeOf(GetType(IconN.GRPICONDIRENTRY))
					num5 += 1
				End While
				gchandle.Free()
				Return array
			End Function

			' Token: 0x0400034A RID: 842
			Private iconDir As IconN.ICONDIR

			' Token: 0x0400034B RID: 843
			Private iconEntry As IconN.ICONDIRENTRY()

			' Token: 0x0400034C RID: 844
			Private iconImage As Byte()()
		End Class
	End Class
End Namespace
