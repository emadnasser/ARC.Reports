Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Presenters
Imports DevExpress.DevAV
Imports System.Collections.Generic
Imports System

Namespace DevExpress.DevAV.Modules

    Partial Public Class OrderMapView
        Inherits BaseModuleControl
        Implements IRibbonModule

        Public Sub New()
            MyBase.New(GetType(OrderMapViewModel))
            InitializeComponent()
            Presenter = CreatePresenter()
            BindCommands()
            BindEditors()
            UpdateColors()
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
            Presenter.Dispose()
            MyBase.OnDisposing()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As OrderMapViewModel
            Get
                Return GetViewModel(Of OrderMapViewModel)()
            End Get
        End Property
        Private privatePresenter As OrderRouteMapPresenter
        Protected Property Presenter() As OrderRouteMapPresenter
            Get
                Return privatePresenter
            End Get
            Private Set(ByVal value As OrderRouteMapPresenter)
                privatePresenter = value
            End Set
        End Property
        Protected Overridable Function CreatePresenter() As OrderRouteMapPresenter
            Return New OrderRouteMapPresenter(mapControl, ViewModel, AddressOf UpdateUI, AddressOf UpdateRouteList)
        End Function
        Protected Overridable Sub BindCommands()
            biSave.BindCommand(Sub() ViewModel.Save(), ViewModel)
            biClose.BindCommand(Sub() ViewModel.Close(), ViewModel)
            biSaveAndClose.BindCommand(Sub() ViewModel.SaveAndClose(), ViewModel)
            biDelete.BindCommand(Sub() ViewModel.Delete(), ViewModel)
            biDriving.BindCommand(Sub() ViewModel.SetDrivingTravelMode(), ViewModel)
            biWalking.BindCommand(Sub() ViewModel.SetWalkingTravelMode(), ViewModel)
            CType(routeButtons.Buttons(0), WindowsUIButton).BindCommand(Sub() ViewModel.SetWalkingTravelMode(), ViewModel)
            CType(routeButtons.Buttons(1), WindowsUIButton).BindCommand(Sub() ViewModel.SetDrivingTravelMode(), ViewModel)
            CType(swapRouteButtons.Buttons(0), WindowsUIButton).BindCommand(Sub() ViewModel.SwapRoutePoints(), ViewModel)
            AddHandler biPrint.ItemClick, Sub(s, e) mapControl.Print()
            AddHandler biPrintPreview.ItemClick, Sub(s, e) mapControl.ShowRibbonPrintPreview()
            AddHandler barExportItem.ItemClick, Sub(s, e) mapControl.Export("Sales.Map.png")
        End Sub
        Protected Overridable Sub BindEditors()
            bindingSource.DataSource = ViewModel
            colManeuver.ColumnEdit = EditorHelpers.CreateManeuverImageComboBox()
        End Sub
        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            UpdateColors()
        End Sub
        Private Sub UpdateColors()
            routeResultLabel.Appearance.BackColor = ColorHelper.WindowColor
            routeResultLabel.Appearance.ForeColor = ColorHelper.WindowTextColor
            ItemForAddressLine1.AppearanceItemCaption.ForeColor = ColorHelper.DisabledTextColor
            ItemForAddressLine1.AppearanceItemCaption.Options.UseForeColor = True
        End Sub
        Private Sub UpdateUI(ByVal order As Order)
            ribbonControl.ApplicationDocumentCaption = order.Customer.Name
        End Sub
        Private Sub UpdateRouteList(ByVal routePoints As List(Of RoutePoint))
            gridControl.DataSource = routePoints
        End Sub
        #Region "IRibbonModule"
        Private ReadOnly Property IRibbonModule_Ribbon() As XtraBars.Ribbon.RibbonControl Implements IRibbonModule.Ribbon
            Get
                Return ribbonControl
            End Get
        End Property
        #End Region
    End Class
End Namespace
