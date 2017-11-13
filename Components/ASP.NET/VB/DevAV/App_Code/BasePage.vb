Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Web
Imports DevExpress.Web

    ' TODO rename file
Public MustInherit Class BasePage
    Inherits System.Web.UI.Page

    Public MustOverride ReadOnly Property PageName() As String
    Public MustOverride ReadOnly Property FilterBag() As FilterBag

    Public MustOverride Function GetFilterColumns() As IEnumerable(Of FilterControlColumn)
    Public MustOverride Sub OnFilterChanged()

    Public Overridable ReadOnly Property ContentHasScroll() As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overridable ReadOnly Property ContentHasBorder() As Boolean
        Get
            Return True
        End Get
    End Property
    Public Overridable ReadOnly Property HasSearchPanel() As Boolean
        Get
            Return True
        End Get
    End Property

    Public Overridable Sub SaveEditFormChanges(ByVal args As String)
    End Sub
    Public Overridable Sub DeleteEntry(ByVal args As String)
    End Sub
    Public Overridable Sub PrepareToolbarItem(ByVal menuItem As DevExpress.Web.MenuItem)
    End Sub

    Public Function CanHighlightField(ByVal fieldName As String) As Boolean
        Return FilterBag.SearchFieldNames.Contains(fieldName)
    End Function
    Public Function HighlightSearchText(ByVal text As String) As String
        Return If((Not String.IsNullOrWhiteSpace(text)), DemoUtils.HighlightSearchText(text, FilterBag.SearchText), text)
    End Function
End Class

Public MustInherit Class MasterDetailPage
    Inherits BasePage

    Public MustOverride ReadOnly Property MasterUC() As MasterUserControl
    Public MustOverride ReadOnly Property DetailUC() As DetailUserControl

    Public ReadOnly Property SelectedItemID() As Long
        Get
            Return MasterUC.SelectedItemID
        End Get
    End Property
    Public Sub Update()
        MasterUC.Update() ' should force update detail
    End Sub
    Public Overridable Sub UpdateDetail()
        If DetailUC IsNot Nothing Then
            DetailUC.Update()
        End If
    End Sub
End Class
Public MustInherit Class MasterUserControl
    Inherits ViewUserControl

    Public Shadows ReadOnly Property OwnerPage() As MasterDetailPage
        Get
            Return TryCast(Page, MasterDetailPage)
        End Get
    End Property

    Protected Overridable Sub UpdateDetail()
        OwnerPage.UpdateDetail()
    End Sub
End Class
Public MustInherit Class DetailUserControl
    Inherits ViewUserControl

    Public Shadows ReadOnly Property OwnerPage() As MasterDetailPage
        Get
            Return TryCast(Page, MasterDetailPage)
        End Get
    End Property
    Public Overrides Property SelectedItemID() As Long
        Get
            Return OwnerPage.SelectedItemID
        End Get
        Set(ByVal value As Long)
        End Set
    End Property
End Class

Public MustInherit Class ViewUserControl
    Inherits UserControl

    Public MustOverride Sub Update()

    Public ReadOnly Property OwnerPage() As BasePage
        Get
            Return TryCast(Page, BasePage)
        End Get
    End Property
    Public Overridable Property SelectedItemID() As Long
    Protected ReadOnly Property Filter() As FilterBag
        Get
            Return OwnerPage.FilterBag
        End Get
    End Property
End Class

Public MustInherit Class EditFormUserControl
    Inherits UserControl

    Public MustOverride Function SaveChanges(ByVal args As String) As Long
End Class

Public MustInherit Class ChartUserControl
    Inherits UserControl

    Public MustOverride ReadOnly Property Chart() As WebChartControl

    Public Overridable Property SelectedItemID() As Long
    Protected Sub ChangeChartWidth(ByVal width As Integer)
        Chart.Width = Unit.Pixel(If(width < 500, width, 500))
        Chart.Series(0).LabelsVisibility = If(width < 375, DefaultBoolean.False, DefaultBoolean.True)
    End Sub
    Protected Sub OnCustomDrawSeriesPoint(ByVal e As CustomDrawSeriesPointEventArgs)
        e.LegendText = e.SeriesPoint.Argument.ToString()
        Dim legendImage = New Bitmap(11, 11)
        Using graphics = System.Drawing.Graphics.FromImage(legendImage)
            graphics.FillRectangle(New LinearGradientBrush(New Rectangle(New Point(), legendImage.Size), e.LegendDrawOptions.Color, e.LegendDrawOptions.ActualColor2, LinearGradientMode.BackwardDiagonal), New Rectangle(New Point(), legendImage.Size))
        End Using
        e.LegendMarkerImage = legendImage
    End Sub
End Class
