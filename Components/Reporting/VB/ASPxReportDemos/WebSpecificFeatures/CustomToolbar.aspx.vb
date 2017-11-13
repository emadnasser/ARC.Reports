Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web
Imports DevExpress.Web.Demos

Partial Public Class WebSpecificFeatures_CustomToolbar
	Inherits PageBase(Of XtraReportsDemos.OddEvenStyles.Report)
	Protected Sub ASPxRibbon1_Init(ByVal sender As Object, ByVal e As EventArgs)
		For Each tab As RibbonTab In ASPxRibbon1.Tabs
			Dim reportGroup As RibbonGroup = tab.Groups.FindByName("CustomReportGroup")
			If reportGroup Is Nothing Then
				Continue For
			End If
			Dim showParametersPanelCommand = CType(reportGroup.Items.FindByName("ShowParametersPanelToggleCommand"), RibbonToggleButtonItem)
			Dim showDocumentMapCommand = CType(reportGroup.Items.FindByName("ShowDocumentMapToggleCommand"), RibbonToggleButtonItem)
			Dim isMetro = Utils.CurrentTheme Is "Moderno" OrElse Utils.CurrentTheme Is "Mulberry" OrElse Utils.CurrentTheme Is "Metropolis" OrElse Utils.CurrentTheme Is "MetropolisBlue"
			Dim imageUrlSuffix As String = If(isMetro, "_Metro", String.Empty)
			showDocumentMapCommand.SmallImage.Url = String.Format("~/Content/CustomToolbar/DocumentMap_16x16{0}.png", imageUrlSuffix)
			showDocumentMapCommand.LargeImage.Url = String.Format("~/Content/CustomToolbar/DocumentMap_32x32{0}.png", imageUrlSuffix)
			showParametersPanelCommand.SmallImage.Url = String.Format("~/Content/CustomToolbar/Parameters_16x16{0}.png", imageUrlSuffix)
			showParametersPanelCommand.LargeImage.Url = String.Format("~/Content/CustomToolbar/Parameters_32x32{0}.png", imageUrlSuffix)
			showParametersPanelCommand.Checked = True
			showDocumentMapCommand.Checked = True
		Next tab
	End Sub
End Class
