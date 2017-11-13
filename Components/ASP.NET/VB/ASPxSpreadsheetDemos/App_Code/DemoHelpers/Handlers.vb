Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web
Imports DevExpress.Spreadsheet
Imports DevExpress.Web.Office
Imports DevExpress.XtraSpreadsheet

Namespace DevExpress.Web.Demos
	Public NotInheritable Class SpreadsheetGlobalHandlers
		Private Sub New()
		End Sub
		Public Shared Sub OnCellValueChanged(ByVal sender As Object, ByVal e As SpreadsheetCellEventArgs)
			Dim documentInfo As SpreadsheetDocumentInfo = TryCast(sender, SpreadsheetDocumentInfo)
			If DocumentShouldBeProcessed(documentInfo) AndAlso TrackingNumberChanged(e) Then
				ShowShipmentInfo(e.Value, e.Worksheet)
			End If
		End Sub

		Private Shared Function TrackingNumberChanged(ByVal e As SpreadsheetCellEventArgs) As Boolean
			Return e.Cell.GetReferenceA1() = "C3"
		End Function

		Private Shared Function DocumentShouldBeProcessed(ByVal documentInfo As SpreadsheetDocumentInfo) As Boolean
			Return documentInfo.DocumentId.StartsWith(DocumentIdGenerator.CellValueChangedDocumentIdPrefix)
		End Function

		Private Shared Sub ShowShipmentInfo(ByVal trackingNumber As CellValue, ByVal worksheet As Worksheet)
			Dim shipment As Shipment = SampleDataSource.Lookup(trackingNumber.TextValue)
			worksheet.Cells("C6").Value = shipment.GetShipmentWeight()
			worksheet.Cells("C7").Value = shipment.Sender
			worksheet.Cells("C8").Value = shipment.Recipient
			worksheet.Cells("C9").Value = shipment.GetShippingDate()
			worksheet.Cells("C10").Value = shipment.GetDeliveryDate()
		End Sub
	End Class
End Namespace
