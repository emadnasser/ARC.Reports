Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI
Imports DevExpress.Data
Imports DevExpress.Web

Partial Public Class Columns_ContextMenu
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal args As EventArgs)
		If (Not IsPostBack) Then
			Grid.DataBind()
			Grid.ExpandRow(1)
		End If
	End Sub
	Protected Sub Grid_FillContextMenuItems(ByVal sender As Object, ByVal e As ASPxGridViewContextMenuEventArgs)
		If e.MenuType = GridViewContextMenuType.Rows Then
			Dim item = e.CreateItem("Export", "Export")
			item.BeginGroup = True
			e.Items.Insert(e.Items.IndexOfCommand(GridViewContextMenuCommand.Refresh), item)

			AddMenuSubItem(item, "PDF", "ExportToPDF", "Images/ExportToPdf.png", True)
			AddMenuSubItem(item, "XLS", "ExportToXLS", "Images/ExportToXls.png", True)
		End If
	End Sub
	Private Shared Sub AddMenuSubItem(ByVal parentItem As GridViewContextMenuItem, ByVal text As String, ByVal name As String, ByVal imageUrl As String, ByVal isPostBack As Boolean)
		Dim exportToXlsItem = parentItem.Items.Add(text, name)
		exportToXlsItem.Image.Url = imageUrl
	End Sub
	Protected Sub Grid_ContextMenuItemClick(ByVal sender As Object, ByVal e As ASPxGridViewContextMenuItemClickEventArgs)
		Select Case e.Item.Name
			Case "ExportToPDF"
				GridExporter.WritePdfToResponse()
			Case "ExportToXLS"
				GridExporter.WriteXlsToResponse()
		End Select
	End Sub
	Protected Sub Grid_AddSummaryItemViaContextMenu(ByVal sender As Object, ByVal e As ASPxGridViewAddSummaryItemViaContextMenuEventArgs)
		If e.SummaryItem.FieldName = "UnitsInStock" AndAlso e.SummaryItem.SummaryType = SummaryItemType.Average Then
			e.SummaryItem.ValueDisplayFormat = "{0:0.00}"
		End If
	End Sub

	Private totalSum As Integer
	Protected Sub Grid_CustomSummaryCalculate(ByVal sender As Object, ByVal e As CustomSummaryEventArgs)
		If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Start Then
			totalSum = 0
		End If
		If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Calculate Then
			If Grid.Selection.IsRowSelectedByKey(e.GetValue(Grid.KeyFieldName)) Then
				totalSum += Convert.ToInt32(e.FieldValue)
			End If
		End If
		If e.SummaryProcess = DevExpress.Data.CustomSummaryProcess.Finalize Then
			e.TotalValue = totalSum
		End If
	End Sub
End Class
