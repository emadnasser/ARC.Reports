Imports System
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.DemoBase
Imports System.Windows.Input
Imports System.Windows.Threading

Namespace GridDemo
    <CodeFile("ModuleResources/ColumnCustomizationClasses.(cs)")>
    Partial Public Class ColumnCustomization
        Inherits GridDemoModule

        Public Shared ReadOnly ColumnChooserTypeProperty As DependencyProperty = DependencyProperty.Register("ColumnChooserType", GetType(ColumnChooserType), GetType(ColumnCustomization), New PropertyMetadata(ColumnChooserType.Default, New PropertyChangedCallback(AddressOf OnColumnChooserTypeChanged)))

        Private Shared Sub OnColumnChooserTypeChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            CType(d, ColumnCustomization).ColumnChooserTypeChanged(DirectCast(e.NewValue, ColumnChooserType))
        End Sub

        Public Property ColumnChooserType() As ColumnChooserType
            Get
                Return CType(GetValue(ColumnChooserTypeProperty), ColumnChooserType)
            End Get
            Set(ByVal value As ColumnChooserType)
                SetValue(ColumnChooserTypeProperty, value)
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            UpdateToggleButtonContent()
        End Sub
        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            If Not IsPopupContentInvisible Then
                Dispatcher.BeginInvoke(New Action(AddressOf gridView.ShowColumnChooser), DispatcherPriority.Render, Nothing)

            End If
        End Sub

        Private Sub columnChooser_PreviewGotKeyboardFocus(ByVal sender As Object, ByVal e As KeyboardFocusChangedEventArgs)
            e.Handled = True
        End Sub

        Private Sub ColumnChooserTypeChanged(ByVal newChooserType As ColumnChooserType)
            If newChooserType = ColumnChooserType.Default Then
                columnChooser.View = Nothing
                grid.View.ClearValue(GridViewBase.ColumnChooserFactoryProperty)
            Else
                columnChooser.View = gridView
                grid.View.ColumnChooserFactory = New DemoColumnChooser(columnChooser)
                gridView.ShowColumnChooser()
            End If
        End Sub

        Private Sub showHideButton_Toggle(ByVal sender As Object, ByVal e As RoutedEventArgs)
            UpdateToggleButtonContent()
        End Sub

        Private Sub UpdateToggleButtonContent()
            showHideButton.Content = If(showHideButton.IsChecked.Value, "Hide Column Chooser", "Show Column Chooser")
        End Sub
        Protected Overrides Function GetModuleDataContext() As Object
            MyBase.GetModuleDataContext()
            Return Me
        End Function


    End Class
End Namespace
