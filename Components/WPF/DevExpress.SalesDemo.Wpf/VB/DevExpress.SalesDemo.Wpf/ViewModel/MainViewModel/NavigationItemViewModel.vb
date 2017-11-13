Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.SalesDemo.Wpf.Helpers
Imports System
Imports System.Windows.Media.Imaging

Namespace DevExpress.SalesDemo.Wpf.ViewModel
    Public Class NavigationItemViewModel
        Public Shared Function Create(ByVal moduleType As ModuleType, ByVal caption As String, ByVal description As String, ByVal glyph As BitmapImage) As NavigationItemViewModel
            Dim res = ViewModelSource.Create(Function() New NavigationItemViewModel())
            res.moduleType = moduleType
            res.Caption = caption
            res.Description = description
            res.Glyph = glyph
            Return res
        End Function
        Protected Sub New()
            If Me.IsInDesignMode() Then
                InitializeInDesignMode()
            End If
            ViewInjectionManager.Default.RegisterNavigatedEventHandler(Me, Sub() IsActive = True)
            ViewInjectionManager.Default.RegisterNavigatedAwayEventHandler(Me, Sub() IsActive = False)
        End Sub
        Private Sub InitializeInDesignMode()
            Caption = "Sales"
            Description = "Revenue" & Environment.NewLine & "Snapshots"
            Glyph = ResourceImageHelper.GetResourceImage("Sales.png")
        End Sub

        Private moduleType As ModuleType
        Public Overridable Property Caption() As String
        Public Overridable Property Description() As String
        Public Overridable Property Glyph() As BitmapImage
        Public Overridable Property IsActive() As Boolean

        Public Sub Activate()
            If IsActive Then
                Return
            End If
            ViewInjectionManager.Default.Navigate(Regions.Navigation, moduleType)
        End Sub
        Protected Sub OnIsActiveChanged()
            If IsActive Then
                ViewInjectionManager.Default.Navigate(Regions.Main, moduleType)
            End If
        End Sub
    End Class
End Namespace
