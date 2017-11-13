Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.DemoBase.DataClasses
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Editors.Settings
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.DemoData.Models
Imports System.Data.Entity
Imports System.Linq
Imports DevExpress.DemoData.Models.Vehicles

Namespace GridDemo
    <CodeFile("ModuleResources/CardViewTemplates(.SL).xaml"), CodeFile("ModuleResources/CardViewPrintingTemplates(.SL).xaml")>
    Partial Public Class CardView
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            grid.ItemsSource = (New VehiclesContext()).Models.ToList()
        End Sub

        Private Sub maxCardCountInRowSpinEdit_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            If view Is Nothing Then
                Return
            End If
            If maxCardCountInRowValueRadioButton.IsChecked.Value Then
                view.MaxCardCountInRow = CInt((maxCardCountInRowSpinEdit.Value))
            End If
        End Sub

        Private Sub maxCardCountInRowNoLimitRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If view Is Nothing Then
                Return
            End If
            maxCardCountInRowSpinEdit.IsEnabled = False
            view.MaxCardCountInRow = Integer.MaxValue
        End Sub

        Private Sub maxCardCountInRowValueRadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If view Is Nothing Then
                Return
            End If
            maxCardCountInRowSpinEdit.IsEnabled = True
            view.MaxCardCountInRow = CInt((maxCardCountInRowSpinEdit.Value))
        End Sub

        Private Sub ComboBoxEdit_EditValueChanged(ByVal sender As Object, ByVal e As EditValueChangedEventArgs)
            Dim settings As New MemoEditSettings() With {.ShowIcon = False, .PopupWidth = 500, .PopupHeight = 300, .MemoTextWrapping = TextWrapping.Wrap, .MemoVerticalScrollBarVisibility = ScrollBarVisibility.Auto}
            If Object.Equals(CType(e.NewValue, CardLayout), CardLayout.Rows) Then
                settings.MaxWidth = 300R
            End If
            grid.Columns("Description").EditSettings = settings

        End Sub
    End Class
End Namespace
