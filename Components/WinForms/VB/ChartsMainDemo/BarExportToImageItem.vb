Imports Microsoft.VisualBasic
Imports System.Drawing.Imaging
Imports DevExpress.XtraBars

Namespace DevExpress.XtraCharts.Demos

	Public Class BarExportToImageItem
		Inherits BarButtonItem
		Private ReadOnly imageFormat_Renamed As ImageFormat
		Private ReadOnly imageCodecInfo_Renamed As ImageCodecInfo

		Public ReadOnly Property ImageFormat() As ImageFormat
			Get
				Return imageFormat_Renamed
			End Get
		End Property
		Public ReadOnly Property ImageCodecInfo() As ImageCodecInfo
			Get
				Return imageCodecInfo_Renamed
			End Get
		End Property

		Public Sub New(ByVal barManager As BarManager, ByVal imageFormat As ImageFormat, ByVal imageCodecInfo As ImageCodecInfo)
			MyBase.New(barManager, String.Empty)
			Me.imageFormat_Renamed = imageFormat
			Me.imageCodecInfo_Renamed = imageCodecInfo
			Caption = String.Format("{0}", imageCodecInfo.FormatDescription)
		End Sub
	End Class

End Namespace
