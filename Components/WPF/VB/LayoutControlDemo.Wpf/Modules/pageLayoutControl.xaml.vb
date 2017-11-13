Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.LayoutControl

Namespace DevExpress.Xpf.LayoutControlDemo
    Partial Public Class pageLayoutControl
        Inherits LayoutControlDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub RaiseIsPopupContentInvisibleChanged(ByVal e As DependencyPropertyChangedEventArgs)
            MyBase.RaiseIsPopupContentInvisibleChanged(e)
            If IsPopupContentInvisible AndAlso layoutItems.IsCustomization Then
                layoutItems.Controller.CustomizationController.SelectedElements.Clear()
            End If
        End Sub

        Private Sub layoutItems_IsCustomizationChanged(ByVal sender As Object, ByVal e As EventArgs)
            If layoutItems.IsCustomization Then
                AddHandler layoutItems.Controller.CustomizationController.SelectionChanged, AddressOf layoutItems_SelectionChanged
            Else
                RemoveHandler layoutItems.Controller.CustomizationController.SelectionChanged, AddressOf layoutItems_SelectionChanged
            End If
            If PropertiesControl IsNot Nothing Then
                PropertiesControl.SelectedItem = Nothing
            End If
        End Sub
        Private Sub layoutItems_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            layoutItems.IsCustomization = True
        End Sub
        Private Sub layoutItems_SelectionChanged(ByVal sender As Object, ByVal e As LayoutControlSelectionChangedEventArgs)
            If e.SelectedElements.Count = 1 AndAlso (Not ReferenceEquals(e.SelectedElements(0), layoutItems)) Then
                PropertiesControl.SelectedItem = e.SelectedElements(0)
            Else
                PropertiesControl.SelectedItem = Nothing
            End If
        End Sub

        Private Sub AllowAvailableItemsDuringCustomizationCheckEdit_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            layoutItems.AllowItemMovingDuringCustomization = True
        End Sub
        Private Sub AllowNewItemsDuringCustomizationCheckEdit_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            layoutItems.AllowAvailableItemsDuringCustomization = True
        End Sub

        Private Sub LayoutGroupViewGroupBoxRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim radioButton = DirectCast(sender, RadioButton)
            Dim group = DirectCast(radioButton.DataContext, LayoutGroup)
            If group.Header Is Nothing Then
                group.Header = "Group"
            End If
        End Sub
        Private Sub LayoutGroupHeaderTextEdit_EditValueChanging(ByVal sender As Object, ByVal e As EditValueChangingEventArgs)
            Dim textBox = DirectCast(sender, TextEdit)
            Dim layoutGroup = TryCast(textBox.DataContext, LayoutGroup)
            If layoutGroup Is Nothing Then
                Return
            End If
            If textBox.EditValue IsNot Nothing AndAlso Object.Equals(textBox.EditValue, e.NewValue) AndAlso (Not CType(layoutGroup.Parent, LayoutGroup).View.Equals(LayoutGroupView.Tabs)) Then
                layoutGroup.View = LayoutGroupView.GroupBox
            End If
        End Sub
        Private Sub LayoutGroupIsCollapsibleCheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim checkEdit = DirectCast(sender, CheckEdit)
            CType(checkEdit.DataContext, LayoutGroup).View = LayoutGroupView.GroupBox
        End Sub
        Private Sub LayoutGroupIsCollapsedCheckBox_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim checkEdit = DirectCast(sender, CheckEdit)
            Dim group = CType(checkEdit.DataContext, LayoutGroup)
            group.View = LayoutGroupView.GroupBox
            group.IsCollapsible = True
        End Sub
    End Class
End Namespace
