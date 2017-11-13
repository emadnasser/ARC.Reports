Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.XtraPivotGrid.Data

Namespace DevExpress.XtraPivotGrid.Demos.Helpers
	Public NotInheritable Class OLAPConfigurator
		Public Const QuantityFieldName As String = "[Measures].[Quantity]"
		Public Const CategoriesFieldName As String = "[Categories].[Category Name].[Category Name]"
		Public Const ProductsFieldName As String = "[Products].[Products].[Products]"
		Public Const DiscountFieldName As String = "[Measures].[Discount]"
		Public Const CountryFieldName As String = "[Customers].[Country].[Country]"

		Private Sub New()
		End Sub
		Public Shared Function CreateSampleOLAPConfiguration(ByVal pivot As PivotGridControl) As Boolean
			Try
				pivot.OLAPConnectionString = OLAPConnectionDesigner.SampleConnectionString
			Catch e1 As OLAPConnectionException
				pivot.OLAPConnectionString = Nothing
				pivot.Enabled = False
				Return False
			End Try
			ConfigureSampleFields(pivot)
			Return True
		End Function
		Public Shared Function CreateSampleAdoConfiguration(ByVal pivot As PivotGridControl) As Boolean
			If (Not AdomdMetaGetter.IsProviderAvailable) Then
				Return False
			End If
			Try
				Dim ds As New PivotGridAdomdDataSource()
				ds.ConnectionString = OLAPConnectionDesigner.SampleConnectionString
				pivot.DataSource = ds
			Catch e1 As OLAPConnectionException
				pivot.DataSource = Nothing
				pivot.Enabled = False
				Return False
			End Try
			ConfigureSampleFields(pivot)
			Return True
		End Function
		Private Shared Sub ConfigureSampleFields(ByVal pivot As PivotGridControl)
			RetrieveFields(pivot)
			Dim fieldQuantity As PivotGridField = pivot.Fields(QuantityFieldName), fieldCategories As PivotGridField = pivot.Fields(CategoriesFieldName), fieldProducts As PivotGridField = pivot.Fields(ProductsFieldName)
			If fieldQuantity IsNot Nothing Then
				fieldQuantity.Visible = True
				fieldQuantity.Area = PivotArea.DataArea
			End If
			If fieldCategories IsNot Nothing Then
				fieldCategories.Visible = True
				fieldCategories.Area = PivotArea.RowArea
			End If
			If fieldProducts IsNot Nothing Then
				fieldProducts.Visible = True
				fieldProducts.Area = PivotArea.RowArea
			End If
		End Sub
		Public Shared Sub RetrieveFields(ByVal pivot As PivotGridControl)
			pivot.BeginUpdate()
			pivot.RetrieveFields(PivotArea.FilterArea, False)
			For i As Integer = 0 To pivot.Fields.Count - 1
				pivot.Fields(i).SortMode = PivotSortMode.None
			Next i
			pivot.EndUpdate()
		End Sub
	End Class
End Namespace
