Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports System

Namespace DevExpress.DevAV.Modules

    Public Class BaseModuleControl
        Inherits XtraUserControl
        Implements ISupportViewModel

        #Region "ViewModel injection"
        Protected Sub New(ByVal viewModelType As Type, ByVal viewModel As Object)
            Me.New()
            Me.mvvmContext.SetViewModel(viewModelType, viewModel)
            Me.BindingContext = New System.Windows.Forms.BindingContext()
            OnInitServices()
        End Sub
        Protected Sub New(ByVal viewModelType As Type)
            Me.New()
            Me.mvvmContext.ViewModelType = viewModelType
            Me.BindingContext = New System.Windows.Forms.BindingContext()
            OnInitServices()
        End Sub
        Protected Sub New(ByVal viewModelType As Type, ByVal viewModelConstructorParameters() As Object)
            Me.New()
            Me.mvvmContext.ViewModelType = viewModelType
            Me.mvvmContext.ViewModelConstructorParameters = viewModelConstructorParameters
            Me.BindingContext = New System.Windows.Forms.BindingContext()
            OnInitServices()
        End Sub
        #End Region ' ViewModel injection
        Protected Sub ReleaseModule()
            Dim locator = GetService(Of Services.IModuleLocator)()
            If locator IsNot Nothing Then
                locator.ReleaseModule(Me)
            End If
        End Sub
        Protected Sub ReleaseModuleReports(Of TEnum As Structure)()
            Dim locator = GetService(Of Services.IReportLocator)()
            If locator Is Nothing Then
                Return
            End If
            For Each key As TEnum In System.Enum.GetValues(GetType(TEnum))
                locator.ReleaseReport(key)
            Next key
        End Sub
        Protected Overridable Sub OnInitServices()
        End Sub
        Protected Overridable Sub OnDisposing()
        End Sub
        Protected Function GetViewModel(Of TViewModel)() As TViewModel
            Return mvvmContext.GetViewModel(Of TViewModel)()
        End Function
        Protected Function GetParentViewModel(Of TViewModel)() As TViewModel
            Return mvvmContext.GetParentViewModel(Of TViewModel)()
        End Function
        Protected Overloads Function GetService(Of TService As Class)() As TService
            Return mvvmContext.GetService(Of TService)()
        End Function
        Private ReadOnly Property ISupportViewModel_ViewModel() As Object Implements ISupportViewModel.ViewModel
            Get
                Return mvvmContext.GetViewModel(Of Object)()
            End Get
        End Property
        Private Sub ISupportViewModel_ParentViewModelAttached() Implements ISupportViewModel.ParentViewModelAttached
            OnParentViewModelAttached()
        End Sub
        Protected Overridable Sub OnParentViewModelAttached()
        End Sub
        Protected Overridable Sub OnDelayedUIUpdate()
        End Sub
        Protected Overridable Function GetUIUpdateDelay() As Integer
            Return 250
        End Function
        Private updateTimer As Timer
        Protected Sub QueueUIUpdate()
            EnsureUIUpdateTimer()
            updateTimer.Stop()
            updateTimer.Start()
        End Sub
        Private Sub EnsureUIUpdateTimer()
            If updateTimer Is Nothing Then
                updateTimer = New Timer(components)
                updateTimer.Interval = GetUIUpdateDelay()
                AddHandler updateTimer.Tick, AddressOf OnUIUpdate
            End If
        End Sub
        Private Sub DestroyUIUpdateTimer()
            If updateTimer IsNot Nothing Then
                RemoveHandler updateTimer.Tick, AddressOf OnUIUpdate
                updateTimer.Stop()
                updateTimer.Dispose()
            End If
            updateTimer = Nothing
        End Sub
        Private Sub OnUIUpdate(ByVal sender As Object, ByVal e As EventArgs)
            updateTimer.Stop()
            OnDelayedUIUpdate()
        End Sub
        #Region "for DesignTime"
        Private Sub New()
            InitializeComponent()
        End Sub
        Private components As System.ComponentModel.IContainer
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.SuspendLayout()
            Me.mvvmContext.ContainerControl = Me
            Me.Name = "BaseModuleControl"
            Me.ResumeLayout(False)
        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                DestroyUIUpdateTimer()
                If mvvmContext.IsViewModelCreated Then
                    ReleaseModule()
                End If
                OnDisposing()
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Protected mvvmContext As Utils.MVVM.MVVMContext
        #End Region
    End Class
End Namespace
