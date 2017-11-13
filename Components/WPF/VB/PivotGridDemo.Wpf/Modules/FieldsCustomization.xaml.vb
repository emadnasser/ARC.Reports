Imports System
Imports System.Linq
Imports System.Windows
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Core
Imports System.Windows.Markup
Imports System.Windows.Data
Imports DevExpress.Xpf.Editors.Helpers
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.Editors.Popups
Imports System.Windows.Controls
Imports DevExpress.DemoData.Models


Namespace PivotGridDemo.PivotGrid
    Partial Public Class FieldsCustomization
        Inherits PivotGridDemoModule

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().SalesPersons.ToList()
            pivotGrid.FieldListFactory = DefaultFieldListFactory.Instance
        End Sub

        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            If Not IsPopupContentInvisible Then
            pivotGrid.ShowFieldList()
            End If
        End Sub

        Private Sub ShowHideFieldList_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGrid.IsFieldListVisible = Not pivotGrid.IsFieldListVisible
        End Sub

        Private Sub customizationStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim IsFieldListVisible As Boolean = pivotGrid.IsFieldListVisible
            pivotGrid.FieldListStyle = CType(customizationStyle.SelectedItem, FieldListStyle)
            pivotGrid.IsFieldListVisible = IsFieldListVisible
            If pivotGrid.FieldListStyle = FieldListStyle.Simple Then
                VisualStateManager.GoToState(Me, "HideAdvancedOptions", True)

            Else
                VisualStateManager.GoToState(Me, "ShowAdvancedOptions", True)
            End If
        End Sub

        Private Sub OnAllowCustomizationFormChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            If Not IsLoaded Then
                Return
            End If
            pivotGrid.IsFieldListVisible = pivotGrid.AllowCustomizationForm
        End Sub

        Private Sub OnCustomizationLayoutsEditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            Dim layout As FieldListAllowedLayouts = CType(customizationLayouts.SelectedItems(0), FieldListAllowedLayouts)
            For Each layout2 As FieldListAllowedLayouts In customizationLayouts.SelectedItems
                layout = layout Or layout2
            Next layout2
            pivotGrid.FieldListAllowedLayouts = layout
            EnsureCurrentLayoutItems(True)
        End Sub

        Private Sub OnCustomizationLayoutsPopupContentSelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
            PopupBaseEditHelper.GetOkButton(customizationLayouts).IsEnabled = GetListBox().SelectedItems.Count > 0
        End Sub
        Private Function GetListBox() As PopupListBox
            Return CType(LayoutHelper.FindElement(CType(PopupBaseEditHelper.GetPopup(customizationLayouts).PopupContent, FrameworkElement), AddressOf IsListBox), PopupListBox)
        End Function
        Private Function IsListBox(ByVal d As FrameworkElement) As Boolean
            Return TryCast(d, PopupListBox) IsNot Nothing
        End Function

        Private Sub OnCurrentLayoutEditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            EnsureCurrentLayoutItems(False)
        End Sub

        Private Sub EnsureCurrentLayoutItems(ByVal includeCurrent As Boolean)
            currentLayout.Items.BeginUpdate()
            currentLayout.Items.Clear()
            For Each layout2 As FieldListAllowedLayouts In customizationLayouts.SelectedItems
                currentLayout.Items.Add(ToFieldListAllowedLayouts(layout2))
            Next layout2
            If includeCurrent AndAlso (Not currentLayout.Items.Contains(pivotGrid.FieldListLayout)) Then
                currentLayout.Items.Add(pivotGrid.FieldListLayout)
            End If
            currentLayout.Items.EndUpdate()
        End Sub

        Private Function ToFieldListAllowedLayouts(ByVal layout As FieldListLayout) As FieldListAllowedLayouts
            Select Case layout
                Case FieldListLayout.BottomPanelOnly1by4
                    Return FieldListAllowedLayouts.BottomPanelOnly1by4
                Case FieldListLayout.BottomPanelOnly2by2
                    Return FieldListAllowedLayouts.BottomPanelOnly2by2
                Case FieldListLayout.StackedDefault
                    Return FieldListAllowedLayouts.StackedDefault
                Case FieldListLayout.StackedSideBySide
                    Return FieldListAllowedLayouts.StackedSideBySide
                Case FieldListLayout.TopPanelOnly
                    Return FieldListAllowedLayouts.TopPanelOnly
                Case Else
                    Throw New NotImplementedException("FieldListLayout")
            End Select
        End Function

        Private Function ToFieldListAllowedLayouts(ByVal layout As FieldListAllowedLayouts) As FieldListLayout
            Select Case layout
                Case FieldListAllowedLayouts.BottomPanelOnly1by4
                    Return FieldListLayout.BottomPanelOnly1by4
                Case FieldListAllowedLayouts.BottomPanelOnly2by2
                    Return FieldListLayout.BottomPanelOnly2by2
                Case FieldListAllowedLayouts.StackedDefault
                    Return FieldListLayout.StackedDefault
                Case FieldListAllowedLayouts.StackedSideBySide
                    Return FieldListLayout.StackedSideBySide
                Case FieldListAllowedLayouts.TopPanelOnly
                    Return FieldListLayout.TopPanelOnly
                Case Else
                    Return FieldListLayout.StackedDefault
            End Select
        End Function
    End Class

    Public Class FieldListVisibleToCommandTextConverter
        Inherits MarkupExtension
        Implements IValueConverter

        #Region "IValueConverter Members"
        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Select Case DirectCast(value, Boolean)
                Case False
                    Return "Show Field List"
                Case Else
                    Return "Hide Field List"
            End Select
        End Function
        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
        #End Region

        Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
            Return Me
        End Function
    End Class
End Namespace
