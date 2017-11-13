Imports DevExpress.DevAV.ViewModels
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public Class CollectionUIViewModel
        #Region "ViewKind"
        Public Overridable Property ViewKind() As CollectionViewKind
        <Command>
        Public Sub ShowCard()
            ViewKind = CollectionViewKind.CardView
        End Sub
        Public Function CanShowCard() As Boolean
            Return ViewKind <> CollectionViewKind.CardView
        End Function
        <Command>
        Public Sub ShowList()
            ViewKind = CollectionViewKind.ListView
        End Sub
        Public Function CanShowList() As Boolean
            Return ViewKind <> CollectionViewKind.ListView
        End Function
        <Command>
        Public Sub ShowCarousel()
            ViewKind = CollectionViewKind.Carousel
        End Sub
        Public Function CanShowCarousel() As Boolean
            Return ViewKind <> CollectionViewKind.Carousel
        End Function
        Protected Overridable Sub OnViewKindChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.ShowList())
            Me.RaiseCanExecuteChanged(Sub(x) x.ShowCard())
            Me.RaiseCanExecuteChanged(Sub(x) x.ShowCarousel())
            Me.RaiseCanExecuteChanged(Sub(x) x.ResetView())
            RaiseViewKindChanged()
        End Sub
        #End Region
        #Region "ViewLayout"
        Public Overridable Property ViewLayout() As CollectionViewMasterDetailLayout
        Public ReadOnly Property IsDetailHidden() As Boolean
            Get
                Return ViewLayout = CollectionViewMasterDetailLayout.DetailHidden
            End Get
        End Property
        Public ReadOnly Property IsHorizontalLayout() As Boolean
            Get
                Return ViewLayout = CollectionViewMasterDetailLayout.Horizontal
            End Get
        End Property
        <Command>
        Public Sub ShowHorizontalLayout()
            ViewLayout = CollectionViewMasterDetailLayout.Horizontal
        End Sub
        Public Function CanShowHorizontalLayout() As Boolean
            Return ViewLayout <> CollectionViewMasterDetailLayout.Horizontal
        End Function
        <Command>
        Public Sub ShowVerticalLayout()
            ViewLayout = CollectionViewMasterDetailLayout.Vertical
        End Sub
        Public Function CanShowVerticalLayout() As Boolean
            Return ViewLayout <> CollectionViewMasterDetailLayout.Vertical
        End Function
        <Command>
        Public Sub HideDetail()
            ViewLayout = CollectionViewMasterDetailLayout.DetailHidden
        End Sub
        Public Function CanHideDetail() As Boolean
            Return ViewLayout <> CollectionViewMasterDetailLayout.DetailHidden
        End Function
        Protected Overridable Sub OnViewLayoutChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.ShowHorizontalLayout())
            Me.RaiseCanExecuteChanged(Sub(x) x.ShowVerticalLayout())
            Me.RaiseCanExecuteChanged(Sub(x) x.HideDetail())
            Me.RaiseCanExecuteChanged(Sub(x) x.ResetView())
            RaiseViewLayoutChanged()
        End Sub
        #End Region
        #Region "Reset"
        Public Property DefaultViewKind() As CollectionViewKind
        Public Property DefaultViewLayout() As CollectionViewMasterDetailLayout
        <Command>
        Public Sub ResetView()
            ViewKind = DefaultViewKind
            ViewLayout = DefaultViewLayout
        End Sub
        Public Function CanResetView() As Boolean
            Return ViewKind <> DefaultViewKind OrElse ViewLayout <> DefaultViewLayout
        End Function
        #End Region
        Public Event ViewKindChanged As EventHandler
        Public Event ViewLayoutChanged As EventHandler
        Private Sub RaiseViewKindChanged()
            Dim handler As EventHandler = ViewKindChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Sub RaiseViewLayoutChanged()
            Dim handler As EventHandler = ViewLayoutChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
    End Class
End Namespace
