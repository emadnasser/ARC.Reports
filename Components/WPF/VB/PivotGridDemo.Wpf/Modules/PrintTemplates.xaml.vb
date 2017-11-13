Imports System.Windows
Imports System.Linq
Imports DevExpress.Xpf.DemoBase
Imports DevExpress.Xpf.Printing
Imports System
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Native
Imports System.Collections.Generic
Imports System.Windows.Media.Imaging
Imports System.IO
Imports System.Reflection
Imports System.Windows.Controls
Imports DevExpress.Xpf.PivotGrid.Internal
Imports DevExpress.Xpf.PivotGrid
Imports DevExpress.Xpf.PivotGrid.Printing
Imports System.Windows.Data
Imports DevExpress.DemoData.Models

Namespace PivotGridDemo.PivotGrid
    Public Enum MoonPhase
        NewMoon
        WaxingCrescentMoon
        FirstQuarterMoon
        WaxingGibbousMoon
        FullMoon
        WaningGibbousMoon
        LastQuarterMoon
        WaningCrescentMoon
    End Enum

    Partial Public Class PrintTemplates
        Inherits PivotGridDemoModule

        Private defaultCellTemplate, defaultValueTemplate, defaultHeaderTemplate As DataTemplate
        Private defaultCellTemplateSelector, defaultValueTemplateSelector As DataTemplateSelector

        Public Sub New()
            InitializeComponent()
            pivotGrid.DataSource = NWindContext.Create().ProductReports.ToList()
            SaveDefaultTemplates()
            ResetItems()
        End Sub

        Private Sub SaveDefaultTemplates()
            defaultCellTemplate = pivotGrid.PrintFieldCellTemplate
            defaultValueTemplate = pivotGrid.PrintFieldValueTemplate
            defaultHeaderTemplate = pivotGrid.PrintFieldHeaderTemplate
            defaultCellTemplateSelector = pivotGrid.PrintFieldCellTemplateSelector
            defaultValueTemplateSelector = pivotGrid.PrintFieldValueTemplateSelector
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ShowPrintPreview(pivotGrid)
        End Sub

        Private Sub pivotGrid_CustomGroupInterval(ByVal sender As Object, ByVal e As PivotCustomGroupIntervalEventArgs)
            Dim [date] As Date = CDate(e.Value)
            e.GroupValue = CalculateMoonPhase([date].Year, [date].Month, [date].Day)
        End Sub

        Private Shared Function GetFracPart(ByVal value As Double) As Double
            Return value - Convert.ToDouble(Decimal.Truncate(Convert.ToDecimal(value)))
        End Function
        Private Shared Function MoonPhaseFromInt(ByVal phase As Integer) As MoonPhase
            Select Case phase
                Case 0
                    Return MoonPhase.NewMoon
                Case 1
                    Return MoonPhase.WaxingCrescentMoon
                Case 2
                    Return MoonPhase.FirstQuarterMoon
                Case 3
                    Return MoonPhase.WaxingGibbousMoon
                Case 4
                    Return MoonPhase.FullMoon
                Case 5
                    Return MoonPhase.WaningGibbousMoon
                Case 6
                    Return MoonPhase.LastQuarterMoon
                Case 7
                    Return MoonPhase.WaningCrescentMoon
                Case Else
                    Throw New ArgumentException("Phase must be between 0 and 7", "phase")
            End Select
        End Function

        Private Function CalculateMoonPhase(ByVal year As Integer, ByVal month As Integer, ByVal day As Integer) As MoonPhase
            Dim moonCycle As Double = 29.53
            Dim daysInMonth As Double = 30.6
            Dim daysInYear As Double = 365.25
            Dim phasesCount As Integer = 8

            If month < 3 Then
                year -= 1
                month += 12
            End If
            month += 1
            Dim totalDaysElapsed As Double = daysInYear * year + daysInMonth * month + day - 694039.09
            Dim phase As Double = totalDaysElapsed / moonCycle
            Dim result As Integer = CInt((Math.Round(GetFracPart(phase) * phasesCount)))
            Return MoonPhaseFromInt(If(result = phasesCount, 0, result))
        End Function

        Private Sub ResetItems()
            fieldCategory.Area = FieldArea.RowArea
            fieldMoonPhase.Area = FieldArea.ColumnArea
            fieldMoonPhase.Visible = False
            fieldMoonPhase.FilterValues.Clear()
            fieldYear.Area = FieldArea.ColumnArea
            fieldYear.Visible = True
            fieldYear.AreaIndex = 0
            fieldYear.FilterValues.Clear()
            fieldQuarter.Area = FieldArea.ColumnArea
            fieldQuarter.Visible = True
            fieldQuarter.AreaIndex = 1
            fieldQuarter.FilterValues.Clear()
            fieldSales.Area = FieldArea.DataArea
            fieldSales.Visible = True
            fieldSales.FilterValues.Clear()
            If defaultCellTemplate Is Nothing Then
                Return
            End If
            pivotGrid.PrintFieldCellTemplate = defaultCellTemplate
            pivotGrid.PrintFieldValueTemplate = defaultValueTemplate
            pivotGrid.PrintFieldHeaderTemplate = defaultHeaderTemplate
            pivotGrid.PrintFieldCellTemplateSelector = Nothing
            pivotGrid.PrintFieldValueTemplateSelector = Nothing
        End Sub

        Private Sub templatesList_SelectedIndexChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            If Not IsInitialized Then
                Return
            End If
            ResetItems()
            If templatesList.SelectedIndex = 1 Then
                fieldYear.Visible = False
                fieldQuarter.Visible = False
                fieldMoonPhase.Visible = True
            End If
            If templatesList.SelectedIndex = 2 Then
                pivotGrid.PrintFieldCellTemplateSelector = defaultCellTemplateSelector
                pivotGrid.PrintFieldValueTemplateSelector = defaultValueTemplateSelector
                pivotGrid.PrintFieldCellTemplate = Nothing
                pivotGrid.PrintFieldValueTemplate = Nothing
                pivotGrid.PrintFieldHeaderTemplate = CType(Me.FindResource("headerTemplate"), DataTemplate)
            End If
        End Sub
    End Class

    Public Class CellTemplateSelector
        Inherits DataTemplateSelector

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim cellItem As PrintCellsAreaItem = TryCast(item, PrintCellsAreaItem)
            If cellItem Is Nothing Then
                Return MyBase.SelectTemplate(item, container)
            Else
                Return If(cellItem.IsTotalAppearance, CellTotalTemplate, CellTemplate)
            End If
        End Function

        Public Property CellTemplate() As DataTemplate
        Public Property CellTotalTemplate() As DataTemplate
    End Class

    Public Class FieldValueTemplateSelector
        Inherits DataTemplateSelector

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim cellItem As PrintFieldValueItem = TryCast(item, PrintFieldValueItem)
            If cellItem Is Nothing Then
                Return MyBase.SelectTemplate(item, container)
            Else
                Return If(cellItem.IsTotalAppearance, ValueTotalTemplate, ValueTemplate)
            End If
        End Function

        Public Property ValueTemplate() As DataTemplate
        Public Property ValueTotalTemplate() As DataTemplate
    End Class

    Public Class MoonPhaseImageConverter
        Implements IValueConverter

        Private Shared images As New Dictionary(Of String, BitmapImage)()
        Private Shared Function LoadImage(ByVal imageName As String) As BitmapImage
            Return New BitmapImage(New Uri(String.Format("/PivotGridDemo;component/Images/MoonPhase/{0}.png", imageName), UriKind.RelativeOrAbsolute))
        End Function

        Private Shared Sub image_ImageFailed(ByVal sender As Object, ByVal e As ExceptionRoutedEventArgs)
            Throw New NotImplementedException()
        End Sub

        Private Shared Function GetImage(ByVal imageName As String) As BitmapImage
            Dim image As BitmapImage = Nothing
            If Not images.TryGetValue(imageName, image) Then
                image = LoadImage(imageName)
                images.Add(imageName, image)
            End If
            Return image
        End Function

        #Region "IValueConverter Members"

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim item As FieldValueItem = TryCast(value, FieldValueItem)
            If item Is Nothing OrElse Not(TypeOf item.Value Is MoonPhase) Then
                Return Nothing
            Else
                Return GetImage(item.Value.ToString())
            End If
        End Function

        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function

        #End Region
    End Class
End Namespace
