Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Media
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Native
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Grid.Themes

Namespace GridDemo

    Partial Public Class ScrollBarAnnotations
        Inherits GridDemoModule

        Public Sub New()
            InitializeComponent()
            listAnnotaions.SelectAll()
        End Sub

        Private Sub view_ValidateCell(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.GridCellValidationEventArgs)
            If e.CellValue IsNot Nothing Then
                Select Case e.Column.FieldName
                    Case "Quantity"
                        Dim quantity As Integer = Integer.Parse(e.CellValue.ToString())
                        If quantity >= 100 Then
                            e.IsValid = False
                            e.SetError("Quantity is greater than or equals to 100")
                        End If
                    Case "Discount"
                        Dim discount As Double = Double.Parse(e.CellValue.ToString())
                        If discount > 0.21 Then
                            e.IsValid = False
                            e.SetError("Discount is greater than 21%")
                        End If
                    Case "UnitPrice"
                        Dim val As Double = Double.Parse(e.CellValue.ToString())
                        If val < 2.5 Then
                            e.IsValid = False
                            e.SetError("Unit Price is less than 2.5")
                        End If
                    Case Else
                        Return
                End Select
            End If
        End Sub

        Private changedRows As New HashSet(Of Integer)()

        Private Sub view_ScrollBarAnnotationsCreating(ByVal sender As Object, ByVal e As ScrollBarAnnotationsCreatingEventArgs)
            If changedRows IsNot Nothing Then
                Dim info As New ScrollBarAnnotationInfo(Brushes.Green, ScrollBarAnnotationAlignment.Left, 4, 3)
                e.CustomScrollBarAnnotations = New List(Of ScrollBarAnnotationRowInfo)(changedRows.Select(Function(x) New ScrollBarAnnotationRowInfo(grid.GetRowHandleByListIndex(x), info)))
            End If
        End Sub

        Private Sub view_RowUpdated(ByVal sender As Object, ByVal e As RowEventArgs)
            If changedRows IsNot Nothing Then
                changedRows.Add(grid.GetListIndexByRowHandle(e.RowHandle))
            End If
        End Sub
    End Class


    Public Class ToScrollBarAnnotationsModeConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim list = TryCast(value, IEnumerable)
            If list Is Nothing Then
                Return ScrollBarAnnotationMode.None
            End If
            Dim result As ScrollBarAnnotationMode = ScrollBarAnnotationMode.None
            For Each item In list
                result = result Or CType(item, AnnotationsDataContext.AnnotationsItem).Mode
            Next item
            Return result
        End Function

        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class ColorAnnotationConverter
        Implements IMultiValueConverter

        Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
            Dim key = TryCast(values(0), DevExpress.Xpf.Grid.Themes.TableViewThemeKeyExtension)
            If key Is Nothing Then
                Return values(3)
            End If
            Dim treeWalker = TryCast(values(1), ThemeTreeWalker)
            Dim frameworkElement = TryCast(values(2), FrameworkElement)
            Dim converter As New ThemeResourceConverter()
            Return converter.Convert(New Object() { treeWalker, key, frameworkElement }, targetType, Nothing, culture)
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class

    Public Class AnnotationsDataContext
        Public Class AnnotationsItem
            Public Property Name() As String
            Public Property Mode() As ScrollBarAnnotationMode
            Public Property ResourceKey() As Object
            Public Property CustomColor() As Brush
        End Class

        Private privateAnnotationsItems As List(Of AnnotationsItem)
        Public Property AnnotationsItems() As List(Of AnnotationsItem)
            Get
                Return privateAnnotationsItems
            End Get
            Private Set(ByVal value As List(Of AnnotationsItem))
                privateAnnotationsItems = value
            End Set
        End Property

        Public Sub New()
            AnnotationsItems = New List(Of AnnotationsItem)() From {
                New AnnotationsItem() With {
                    .Name = "Focused Row", .Mode = ScrollBarAnnotationMode.FocusedRow, .ResourceKey = New TableViewThemeKeyExtension() With {.ResourceKey = TableViewThemeKeys.AnnotationFocusedRowBrush}
                },
                New AnnotationsItem() With {
                    .Name = "Selected Rows", .Mode = ScrollBarAnnotationMode.Selected, .ResourceKey = New TableViewThemeKeyExtension() With {.ResourceKey = TableViewThemeKeys.AnnotationSelectionBrush}
                },
                New AnnotationsItem() With {
                    .Name = "Search Results", .Mode = ScrollBarAnnotationMode.SearchResult, .ResourceKey = New TableViewThemeKeyExtension() With {.ResourceKey = TableViewThemeKeys.AnnotationSearchBrush}
                },
                New AnnotationsItem() With {
                    .Name = "Invalid Cells", .Mode = ScrollBarAnnotationMode.InvalidCells, .ResourceKey = New TableViewThemeKeyExtension() With {.ResourceKey = TableViewThemeKeys.AnnotationErrorBrush}
                },
                New AnnotationsItem() With {.Name = "Modified Rows", .Mode = ScrollBarAnnotationMode.Custom, .ResourceKey = Nothing, .CustomColor = Brushes.Green}
            }
        End Sub
    End Class

End Namespace
