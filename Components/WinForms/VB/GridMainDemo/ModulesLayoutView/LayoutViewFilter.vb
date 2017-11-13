Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports DevExpress.Utils.Filtering

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class LayoutViewFilter
        Inherits TutorialControl
        Public Sub New()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\ModulesLayoutView\LayoutViewFilter.vb"
            TutorialInfo.WhatsThisXMLFile = "FilteringUI.xml"

            CreateWaitDialog()
            InitializeComponent()
            InitVehiclesData()
        End Sub
        Private models As List(Of VehiclesData.Model)
        Private trademarks As List(Of VehiclesData.Trademark)
        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            VehiclesData.InitMDBDataAndCreateEditors(connectionString, gridControl, models, trademarks)
            ' Bind grid to data
            modelBindingSource.DataSource = models
            ' Retrieving the Filtering UI editors into the AccordionControl
            filteringUIContext.RetrieveFields()
            accordionControl.ExpandAll()
        End Sub
#Region "Obtaining required additional data for Filtering UI editors"
        '<accordionControl>
        Sub filteringUIContext_QueryRangeData(ByVal sender As Object, ByVal e As QueryRangeDataEventArgs) Handles filteringUIContext.QueryRangeData
            If e.PropertyPath = "Price" Then
                e.Result.Minimum = models.Min(Function(t) t.Price)
                e.Result.Maximum = models.Max(Function(t) t.Price)
            End If
        End Sub
        Sub filteringUIContext_QueryLookupData(ByVal sender As Object, ByVal e As QueryLookupDataEventArgs) Handles filteringUIContext.QueryLookupData
            If e.PropertyPath = "Trademark" Then
                e.Result.DataSource = trademarks
            End If
        End Sub
        '</accordionControl>
#End Region
#Region " Applying Context's FilterCriteria"
        Private criteriaChangedFromFilteringUI As Integer = 0
        Private Sub filteringUIContext_FilterCriteriaChanged(ByVal sender As Object, ByVal e As FilterCriteriaChangedEventArgs) Handles filteringUIContext.FilterCriteriaChanged
            criteriaChangedFromFilteringUI += 1
            layoutView.ActiveFilterCriteria = e.FilterCriteria
            criteriaChangedFromFilteringUI -= 1
        End Sub
        Private Sub layoutView_ColumnFilterChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles layoutView.ColumnFilterChanged
            If criteriaChangedFromFilteringUI > 0 Then
                Return
            End If
            If layoutView.ActiveFilter.IsEmpty Then
                filteringUIContext.ClearFilterCriteria()
            End If
        End Sub
#End Region
    End Class
    ' Metadata For Filtering Model
    '<accordionControl>
    Public Class FilteringModel
        Const Main As String = "Main Parameters"
        <Display(GroupName:=Main), FilterLookup(10, ValueMember:="ID", DisplayMember:="Name")>
        Public Property Trademark() As Integer
        <Display(Name:="Model Available", GroupName:=Main)>
        <FilterBooleanChoice(False)>
        Public Property InStock() As Boolean
        <Display(GroupName:=Main), FilterRange(0, 170000), DataType(DataType.Currency)>
        Public Property Price() As Decimal
        <Display(GroupName:=Main)> _
        <EnumDataType(GetType(VehiclesData.Category))> _
        Public Property Category() As Integer
    End Class
    '</accordionControl>
End Namespace
