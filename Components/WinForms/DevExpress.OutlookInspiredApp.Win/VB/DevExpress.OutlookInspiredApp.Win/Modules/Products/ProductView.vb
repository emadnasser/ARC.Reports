Imports DevExpress.DevAV.ViewModels
Imports DevExpress.DevAV.Services
Imports DevExpress.DevAV
Imports System

Namespace DevExpress.DevAV.Modules

    Partial Public Class ProductView
        Inherits BaseModuleControl

        Public Sub New()
            MyBase.New(GetType(SynchronizedProductViewModel))
            InitializeComponent()
            AddHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            pdfViewer.BackColor = ColorHelper.GetControlColor(LookAndFeel)
            AddHandler pdfViewer.ZoomChanged, AddressOf pdfViewer_ZoomChanged
            AddHandler LookAndFeel.StyleChanged, AddressOf LookAndFeel_StyleChanged
        End Sub
        Protected Overrides Sub OnInitServices()
            mvvmContext.RegisterService(New Services.LoadingService(Me))
        End Sub
        Private Sub pdfViewer_ZoomChanged(ByVal sender As Object, ByVal e As XtraPdfViewer.PdfZoomChangedEventArgs)
            RaiseZoomLevelChanged()
        End Sub
        Protected Overrides Sub OnDisposing()
            RemoveHandler ViewModel.EntityChanged, AddressOf ViewModel_EntityChanged
            MyBase.OnDisposing()
        End Sub
        Private Sub LookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
            pdfViewer.BackColor = ColorHelper.GetControlColor(LookAndFeel)
        End Sub
        Public ReadOnly Overloads Property ViewModel() As ProductViewModel
            Get
                Return GetViewModel(Of ProductViewModel)()
            End Get
        End Property
        Public ReadOnly Property CollectionViewModel() As ProductCollectionViewModel
            Get
                Return GetParentViewModel(Of ProductCollectionViewModel)()
            End Get
        End Property
        Private Sub ViewModel_EntityChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            QueueUIUpdate()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
            MyBase.OnLoad(e)
            UpdateUI(ViewModel.Entity)
        End Sub
        Protected Overrides Sub OnDelayedUIUpdate()
            UpdateUI(ViewModel.Entity)
        End Sub
        Private Sub UpdateUI(ByVal product As Product)
            UpdateDocument(product)
            pdfViewer.Visible = (product IsNot Nothing)
        End Sub
        Private Sub UpdateDocument(ByVal product As Product)
            If product Is Nothing Then
                Return
            End If
            If product.Brochure Is Nothing Then
                pdfViewer.CloseDocument()
            Else
                LoadDocument(product)
            End If
        End Sub
        Private Sub LoadDocument(ByVal product As Product)
            Dim loadingService = GetService(Of Services.IWaitingService)()
            Using loadingService.Enter(product.Name)
                pdfViewer.LoadDocument(product.Brochure)
                pdfViewer.ZoomMode = XtraPdfViewer.PdfZoomMode.PageLevel
                RaiseZoomLevelChanged()
            End Using
        End Sub
        Public Property ZoomLevel() As Integer
            Get
                Return CInt((System.Math.Ceiling(pdfViewer.ZoomFactor)))
            End Get
            Set(ByVal value As Integer)
                If value <> ZoomLevel Then
                    pdfViewer.ZoomFactor = CSng(value)
                End If
            End Set
        End Property
        Public Event ZoomLevelChanged As EventHandler
        Private Sub RaiseZoomLevelChanged()
            Dim handler As EventHandler = ZoomLevelChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
    End Class
End Namespace
