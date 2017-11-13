Imports DevExpress.XtraMap.Services
Imports DevExpress.XtraMap
Imports DevExpress.DevAV.ViewModels
Imports System.Linq
Imports System

Namespace DevExpress.DevAV.Modules

    Partial Public Class QuoteMapView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(QuoteMapViewModel))
            InitializeComponent()
            AddHandler ViewModel.StageChanged, AddressOf ViewModel_StageChanged
            BindCommands()
            BindMap()
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub
        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColors()
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ItemsLayer.DataLoaded, AddressOf ItemsLayer_DataLoaded
            RemoveHandler ViewModel.StageChanged, AddressOf ViewModel_StageChanged
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As QuoteMapViewModel
            Get
                Return GetViewModel(Of QuoteMapViewModel)()
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As QuoteCollectionViewModel
            Get
                Return GetParentViewModel(Of QuoteCollectionViewModel)()
            End Get
        End Property
        Private Sub BindCommands()
            biSave.BindCommand(Sub() ViewModel.Save(), ViewModel)
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
            biSaveAndClose.BindCommand(Sub() ViewModel.SaveAndClose(), ViewModel)
            biDelete.BindCommand(Sub() ViewModel.Delete(), ViewModel)
            biHigh.BindCommand(Sub() ViewModel.SetHighStage(), ViewModel)
            biMedium.BindCommand(Sub() ViewModel.SetMediumStage(), ViewModel)
            biLow.BindCommand(Sub() ViewModel.SetLowStage(), ViewModel)
            biUnlikely.BindCommand(Sub() ViewModel.SetUnlikelyStage(), ViewModel)
            AddHandler biPrint.ItemClick, Sub(s, e) mapControl.Print()
            AddHandler biPrintPreview.ItemClick, Sub(s, e) mapControl.ShowRibbonPrintPreview()
            AddHandler barExportItem.ItemClick, Sub(s, e) mapControl.Export("Opportunities.Map.png")
        End Sub
        Private Sub UpdateColors()
            Dim moduleLocator = GetService(Of Services.IModuleLocator)()
            If moduleLocator Is Nothing OrElse (Not moduleLocator.IsModuleLoaded(ModuleType.QuoteView)) Then
                Return
            End If
            Dim quoteView As QuoteView = TryCast(moduleLocator.GetModule(ModuleType.QuoteView), QuoteView)
            ItemsLayer.ItemStyle.Fill = quoteView.GetStageColor(ViewModel.Stage)
        End Sub
        Protected Overrides Sub OnParentViewModelAttached()
            UpdateColors()
            UpdateOpportunities()
        End Sub
        Private zoomService As IZoomToRegionService
        Private Sub BindMap()
            TilesProvider.BingKey = MapViewModelBase.WinBingKey
            Me.zoomService = TryCast(DirectCast(mapControl, IServiceProvider).GetService(GetType(IZoomToRegionService)), IZoomToRegionService)
            mapControl.SelectionMode = ElementSelectionMode.Single
            AddHandler mapControl.SelectionChanged, AddressOf mapControl_SelectionChanged
        End Sub
        Private ReadOnly Property TilesLayer() As ImageLayer
            Get
                Return CType(mapControl.Layers(0), ImageLayer)
            End Get
        End Property
        Private ReadOnly Property ItemsLayer() As VectorItemsLayer
            Get
                Return CType(mapControl.Layers(1), VectorItemsLayer)
            End Get
        End Property
        Private ReadOnly Property CalloutLayer() As VectorItemsLayer
            Get
                Return CType(mapControl.Layers(2), VectorItemsLayer)
            End Get
        End Property
        Private ReadOnly Property TilesProvider() As BingMapDataProvider
            Get
                Return CType(TilesLayer.DataProvider, BingMapDataProvider)
            End Get
        End Property
        Private ReadOnly Property BubbleChartDataAdapter() As BubbleChartDataAdapter
            Get
                Return CType(ItemsLayer.Data, BubbleChartDataAdapter)
            End Get
        End Property
        Private ReadOnly Property Callout() As MapCallout
            Get
                Return (CType(CalloutLayer.Data.GetItem(0), MapCallout))
            End Get
        End Property
        Private Sub ViewModel_StageChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColors()
            UpdateOpportunities()
        End Sub
        Private Sub UpdateOpportunities()
            ribbonControl.ApplicationDocumentCaption = "Opportunities"
            If CollectionViewModel IsNot Nothing Then
                BubbleChartDataAdapter.DataSource = CollectionViewModel.GetOpportunities(ViewModel.Stage)
                zoomService.ZoomTo(CollectionViewModel.GetAddresses(ViewModel.Stage))
            End If
        End Sub
        Private Sub mapControl_SelectionChanged(ByVal sender As Object, ByVal e As MapSelectionChangedEventArgs)
            Dim dataItem = TryCast(e.Selection.FirstOrDefault(), QuoteMapItem)
            If dataItem IsNot Nothing Then
                Callout.Location = dataItem.Address.ToGeoPoint()
                Dim total = CollectionViewModel.GetOpportunity(ViewModel.Stage, dataItem.Address.City)
                Callout.Text = String.Format("TOTAL<br><color=206,113,0><b><size=+4>{0:c}</color></size></b><br>{1}", total, dataItem.Address.City)
            End If
        End Sub
        Private Sub ItemsLayer_DataLoaded(ByVal sender As Object, ByVal e As DataLoadedEventArgs) Handles vectorItemsLayer1.DataLoaded
            Dim mapItem = ItemsLayer.Data.Items.FirstOrDefault()
            ItemsLayer.SelectedItem = If(mapItem IsNot Nothing, ItemsLayer.Data.GetItemSourceObject(mapItem), Nothing)
        End Sub
        #Region ""
        Private ReadOnly Property IRibbonModule_Ribbon() As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
        #End Region
    End Class
End Namespace
