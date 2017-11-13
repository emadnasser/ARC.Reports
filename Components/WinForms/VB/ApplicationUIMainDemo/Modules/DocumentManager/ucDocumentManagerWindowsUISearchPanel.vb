Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraBars.Docking2010.Views

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ucDocumentManagerWindowsUISearchPanel
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			AddHandler windowsUIView.QueryControl, AddressOf OnQueryControl
			AddHandler windowsUIView.CustomizeSearchItems, AddressOf OnCustomizeSearchItems
			AddHandler windowsUIView.NavigatedFrom, AddressOf OnNavigatedFrom
			AddHandler windowsUIView.NavigatedTo, AddressOf OnNavigatedTo
			ucProductsGridDocument.SearchTags = SalesPerformanceDataGenerator.Current.FilterTotalSales.Select(Function(x) x.Category).Distinct().ToArray()
			ucChartProductItemDocument.SearchTags = SalesPerformanceDataGenerator.Current.MonthlySales.Select(Function(x) x.Product).Distinct().ToArray()
			ucChoroplethMapItemDocument.SearchTags = New String() { "Map" }
			ucCategorySalesDocument.SearchTags = New String() { "Revenue" }
            salesInCalifornia.Tag = "California"
            salesInMontana.Tag = "Montana"
            salesInTexas.Tag = "Texas"
		End Sub
		Private Sub OnCustomizeSearchItems(ByVal sender As Object, ByVal e As CustomizeSearchItemsEventArgs)
			Dim content As New List(Of String)()
			content.Add(TryCast(e.SourceContainer.Tag, String))
			If e.Source Is ucProductsGridDocument Then
				content.AddRange(GetType(DevExpress.ApplicationUI.Demos.SalesPerformanceDataGenerator.TotalSalesItem).GetProperties().Select(Function(x) x.ToString()).ToArray())
			End If
			e.Content = content
			e.Image = GetResourceImage(e.Source)
		End Sub
		Private Function GetResourceImage(ByVal component As IComponent) As Image
			Dim name As String = Nothing
			If TypeOf component Is Document Then
				name = (CType(component, Document)).ControlName
			End If
			If TypeOf component Is IContentContainer Then
				name = (CType(component, IContentContainer)).Name
			End If
			If TypeOf component Is BaseTile Then
				name = (CType(component, BaseTile)).Name
			End If
			If String.IsNullOrEmpty(name) Then
				Return Nothing
			End If
			Return TryCast(DevExpress.Utils.ResourceImageHelper.CreateImageFromResourcesEx(String.Format("DevExpress.ApplicationUI.Demos.Images.{0}.png", name), GetType(ucDocumentManagerWindowsUISearchPanel).Assembly), Image)
		End Function
		Private Sub OnNavigatedTo(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.WindowsUI.NavigationEventArgs)
			If e.Target Is Nothing OrElse e.Target.Tag Is Nothing OrElse e.Target Is tileContainer Then
				Return
			End If
			SalesPerformanceDataGenerator.Current.Filter = e.Target.Tag.ToString()
		End Sub
		Private Sub OnNavigatedFrom(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.WindowsUI.NavigationEventArgs)
			If e.Source Is salesByState Then
				e.Source.Tag = SalesPerformanceDataGenerator.Current.Filter
			End If
		End Sub
		Private Sub OnQueryControl(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.QueryControlEventArgs)
			If String.IsNullOrEmpty(e.Document.ControlTypeName) Then
				e.Control = New Control()
			Else
				e.Control = TryCast(Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)), Control)
			End If
		End Sub
	End Class
End Namespace
