Imports System
Imports System.Windows
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Utils.Themes
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Core
Imports DependencyPropertyManager = System.Windows.DependencyProperty

Namespace PivotGridDemo.PivotGrid
    Public Class PivotGridDemoModule
        Inherits DemoModule

        Private Pivot As WeakReference = Nothing
        Public Shared ReadOnly PivotGridControlProperty As DependencyProperty

        Shared Sub New()
            Dim ownerType As Type = GetType(PivotGridDemoModule)
            PivotGridControlProperty = DependencyPropertyManager.Register("PivotGridControl", GetType(PivotGridControl), ownerType, New PropertyMetadata(Nothing, AddressOf OnPivotGridControlChanged))
        End Sub

        Public Shared Sub OnPivotGridControlChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            If e.NewValue Is Nothing Then
                Return
            End If
            CType(d, PivotGridDemoModule).Pivot = New WeakReference(e.NewValue)
        End Sub

        Public Sub New()
            AddHandler Loaded, Sub(sender As Object, e As RoutedEventArgs) OnLoaded()
        End Sub

        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As System.Windows.DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            EnsurePivot()
            If Pivot Is Nothing Then
                Return
            End If
            Dim lastPivot As PivotGridControl = TryCast(Pivot.Target, PivotGridControl)
            If IsPopupContentInvisible AndAlso lastPivot IsNot Nothing Then
                lastPivot.IsFieldListVisible = False
            End If
        End Sub

        Public Property PivotGridControl() As PivotGridControl
            Get
                Return CType(GetValue(PivotGridControlProperty), PivotGridControl)
            End Get
            Set(ByVal value As PivotGridControl)
                SetValue(PivotGridControlProperty, value)
            End Set
        End Property
        Public Overrides Sub OnApplyTemplate()
            MyBase.OnApplyTemplate()
            EnsurePivot()
        End Sub

        Private Sub EnsurePivot()
            If PivotGridControl IsNot Nothing Then
                Return
            End If
            DemoModuleControl.DemoContent = DemoModuleControl.FindDemoContent(GetType(PivotGridControl), CType(Content, DependencyObject))
            If TryCast(DemoModuleControl.DemoContent, FrameworkElement) Is Nothing Then
                Return
            End If
            PivotGridControl = TryCast(LayoutHelper.FindElement((CType(DemoModuleControl.DemoContent, FrameworkElement)), AddressOf IsPivot), PivotGridControl)
        End Sub

        Private Function IsPivot(ByVal element As FrameworkElement) As Boolean
            Return TypeOf element Is PivotGridControl
        End Function

        Protected Overridable Sub OnLoaded()
            If PivotGridControl IsNot Nothing AndAlso Object.Equals(PivotGridControl.RowTotalsLocation, FieldRowTotalsLocation.Tree) Then
                PivotGridControl.BestFit(FieldArea.RowArea, True, False)
            End If
        End Sub
        Protected Overrides Function GetModuleDataContext() As Object
            Return DemoModuleControl.FindDemoContent(GetType(PivotGridControl), CType(Content, DependencyObject))
        End Function
        Protected Overridable ReadOnly Property NeedChangeEditorsTheme() As Boolean
            Get
                Return False
            End Get
        End Property
        Protected Overrides Function CanLeave() As Boolean
            Return True
        End Function
        Protected Overrides Sub Clear()
            PivotGridControl = Nothing
        End Sub

        Public Sub ShowPrintPreview(ByVal pivotGrid As PivotGridControl)
            Dim owner As Window = LayoutHelper.FindParentObject(Of Window)(Me)
            pivotGrid.ShowPrintPreview(owner)
        End Sub
    End Class

End Namespace
