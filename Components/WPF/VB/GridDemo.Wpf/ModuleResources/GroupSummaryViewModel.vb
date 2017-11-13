Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Mvvm

Namespace GridDemo
    Public Class GroupSummaryViewModel
        Inherits BindableBase


        Private defaultDisplayModeSummaries_Renamed As GridSummaryList
        Public Property DefaultDisplayModeSummaries() As GridSummaryList
            Get
                Return defaultDisplayModeSummaries_Renamed
            End Get
            Set(ByVal value As GridSummaryList)
                SetProperty(defaultDisplayModeSummaries_Renamed, value, Function() DefaultDisplayModeSummaries)
                UpdateSummarySource()
            End Set
        End Property

        Private alignByColumnsDisplayModeSummaries_Renamed As GridSummaryList
        Public Property AlignByColumnsDisplayModeSummaries() As GridSummaryList
            Get
                Return alignByColumnsDisplayModeSummaries_Renamed
            End Get
            Set(ByVal value As GridSummaryList)
                SetProperty(alignByColumnsDisplayModeSummaries_Renamed, value, Function() AlignByColumnsDisplayModeSummaries)
                UpdateSummarySource()
            End Set
        End Property

        Private alignSummariesByColumns_Renamed As Boolean
        Public Property AlignSummariesByColumns() As Boolean
            Get
                Return alignSummariesByColumns_Renamed
            End Get
            Set(ByVal value As Boolean)
                SetProperty(alignSummariesByColumns_Renamed, value, Function() AlignSummariesByColumns)
                UpdateSummarySource()
                UpdateCityColumn()
            End Set
        End Property

        Private showGroupFooters_Renamed As Boolean = True
        Public Property ShowGroupFooters() As Boolean
            Get
                Return showGroupFooters_Renamed
            End Get
            Set(ByVal value As Boolean)
                SetProperty(showGroupFooters_Renamed, value, Function() ShowGroupFooters)
            End Set
        End Property

        Private allowCascadeUpdate_Renamed As Boolean
        Public Property AllowCascadeUpdate() As Boolean
            Get
                Return allowCascadeUpdate_Renamed
            End Get
            Set(ByVal value As Boolean)
                SetProperty(allowCascadeUpdate_Renamed, value, Function() AllowCascadeUpdate)
            End Set
        End Property

        Private summarySource_Renamed As GridSummaryList
        Public Property SummarySource() As GridSummaryList
            Get
                Return summarySource_Renamed
            End Get
            Set(ByVal value As GridSummaryList)
                SetProperty(summarySource_Renamed, value, Function() SummarySource)
            End Set
        End Property

        Private cityColumnVisibleIndex_Renamed As Integer
        Public Property CityColumnVisibleIndex() As Integer
            Get
                Return cityColumnVisibleIndex_Renamed
            End Get
            Set(ByVal value As Integer)
                SetProperty(cityColumnVisibleIndex_Renamed, value, Function() CityColumnVisibleIndex)
            End Set
        End Property

        Private cityColumnGroupIndex_Renamed As Integer
        Public Property CityColumnGroupIndex() As Integer
            Get
                Return cityColumnGroupIndex_Renamed
            End Get
            Set(ByVal value As Integer)
                SetProperty(cityColumnGroupIndex_Renamed, value, Function() CityColumnGroupIndex)
            End Set
        End Property
        Private Sub UpdateSummarySource()
            SummarySource = If(AlignSummariesByColumns, AlignByColumnsDisplayModeSummaries, DefaultDisplayModeSummaries)
        End Sub
        Private Sub UpdateCityColumn()
            If AlignSummariesByColumns Then
                CityColumnVisibleIndex = 0
            End If
            CityColumnGroupIndex = 0
        End Sub
    End Class
End Namespace
