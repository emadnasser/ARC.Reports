Imports DevExpress.Map
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Demos
Imports DevExpress.XtraMap
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace DevExpress.VoteApp
	Partial Public Class Map
		Inherits TutorialControl

		Private voteSummary As VoteSummaryInfo = Nothing
		Private electionData As ElectionData = Nothing
		Private colorizer As New VoteMapColorizer()
		Private usStateInfo, usCountyInfo As LoadedMapInfo
		Private electionResults As ElectionResults = DevExpress.VoteApp.ElectionResults.e2016

		Private activeStateCounty As StateInfo = Nothing
        Private isCountyMode_Renamed As Boolean = False
        Private mapData As MapViewData

        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()
            Me.mapControl.EnableScrolling = EnableMapScrollingInStateView
            SetWaitDialogCaption("Load Map Info")
            Me.usStateInfo = New LoadedMapInfo() With {.Layer = Me.stateLayer}
            Me.usCountyInfo = New LoadedMapInfo()
            LoadUSCountyShapes()
            SetWaitDialogCaption("Load Election Results")
            Me.electionResults = DevExpress.VoteApp.ElectionResults.e2016
            LoadElectionData()
            CreateColorLegend()
            switchResults.Visible = True
        End Sub
        Private Sub LoadElectionData()
            Dim needRefresh As Boolean = electionData IsNot Nothing
            Me.voteResultsAltered = False
            Select Case electionResults
                Case DevExpress.VoteApp.ElectionResults.e2016
                    electionData = VoteHelpers.LoadResults2016()
                Case DevExpress.VoteApp.ElectionResults.e2012
                    electionData = VoteHelpers.LoadResults2012()
            End Select
            UpdateElectionInfo()
            If needRefresh Then
                Refresh()
            End If
        End Sub
        Private Sub Map_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            mapControl.ZoomToFit(usStateInfo.VisibleItems)
            Me.lastAdjustedSize = Size
        End Sub
        Private Sub UpdateListSource()
            If IsCountyMode AndAlso MapMode <> DevExpress.VoteApp.MapMode.StateCountyView Then
                colArea.Caption = (If(activeStateCounty Is Nothing, "County", activeStateCounty.Name))
                Me.listVoteResultsBindingSource.DataSource = GenerateCountyResults()
                Return
            End If
            colArea.Caption = "State"
            Me.listVoteResultsBindingSource.DataSource = GenerateStateResults()
        End Sub
        Private Sub CreateColorLegend()
            Dim legend As New ColorListLegend()
            Dim dem As Color = colorizer.RepColor

            legend.CustomItems.Add(New ColorLegendItem() With {.Color = HSLColor.Darken(dem, 0.5), .Text = "85% +"})
            legend.CustomItems.Add(New ColorLegendItem() With {.Color = HSLColor.Darken(dem, 0.8), .Text = "70%..85%"})
            legend.CustomItems.Add(New ColorLegendItem() With {.Color = dem, .Text = "50%..70%"})

            legend.CustomItems.Add(New ColorLegendItem() With {.Color = Color.Silver, .Text = "Results unknown"})

            dem = colorizer.DemColor

            legend.CustomItems.Add(New ColorLegendItem() With {.Color = dem, .Text = "50%..70%"})
            legend.CustomItems.Add(New ColorLegendItem() With {.Color = HSLColor.Darken(dem, 0.8), .Text = "70%..85%"})
            legend.CustomItems.Add(New ColorLegendItem() With {.Color = HSLColor.Darken(dem, 0.5), .Text = "85% +"})
            legend.Header = Nothing
            legend.Alignment = LegendAlignment.BottomRight
            legend.ItemStyle.Font = New Font(Appearance.Font.FontFamily, 8)
            mapControl.Legends.Add(legend)

        End Sub

        Private Sub UpdateElectionInfo(Optional ByVal partialBool As Boolean = False)
            UpdateListSource()
            If Not partialBool Then
                LoadUSShape(usStateInfo, electionData, True)
            End If
            UpdateElectionSummary()
            CType(mapControl.Overlays(0).Items(0), MapOverlayTextItem).Text = electionData.Source
            lbElection.Text = electionData.Title & " " & electionData.Year & (If(tsElectionSimilutor.IsOn AndAlso voteResultsAltered, " </i>(altered)", ""))

            colDem.Caption = voteSummary.CandidateNameDem
            lciDemPicture.Text = voteSummary.CandidateNameDem
            piDem.Image = Helpers.GetCandidatePhoto(voteSummary.CandidateNameDem)
            colGOP.Caption = voteSummary.CandidateNameRep
            lciRepPicture.Text = voteSummary.CandidateNameRep
            piRep.Image = Helpers.GetCandidatePhoto(voteSummary.CandidateNameRep)

            UpdateVotePanels()
            Refresh()

        End Sub
        Private ReadOnly Property IsElectionPlaygroundMode() As Boolean
            Get
                Return tsElectionSimilutor.IsOn
            End Get
        End Property
        Private Sub UpdateVotePanels()
            votesPanelPeople.VotesCountLeft = voteSummary.TotalVotesDem
            votesPanelPeople.VotesCountRight = voteSummary.TotalVotesRep
            votesPanelPeople.VotesCountTotal = voteSummary.TotalVotes
            votesPanelPeople.ColorLeft = colorizer.DemColor
            votesPanelPeople.ColorRight = colorizer.RepColor

            votesPanelPeople.VotesTextLeft = If(voteSummary.TotalVotesDem > 0, String.Format("<b>{0:p}</b> <i> {1:n0} votes", Helpers.GetPercent(voteSummary.TotalVotesDem, voteSummary.TotalVotes), voteSummary.TotalVotesDem), "")
            votesPanelPeople.VotesTextRight = If(voteSummary.TotalVotesRep > 0, String.Format("{1:n0} votes</size> <b>{0:p}</b>", Helpers.GetPercent(voteSummary.TotalVotesRep, voteSummary.TotalVotes), voteSummary.TotalVotesRep), "")


            votesPanelElectoral.VotesCountLeft = voteSummary.ElectoralVotesDem
            votesPanelElectoral.VotesCountRight = voteSummary.ElectoralVotesRep
            votesPanelElectoral.VotesCountTotal = voteSummary.ElectoralVotesTotal
            votesPanelElectoral.ColorLeft = colorizer.DemColor
            votesPanelElectoral.ColorRight = colorizer.RepColor


            votesPanelElectoral.VotesTextLeft = If(voteSummary.ElectoralVotesDem > 0, String.Format("<b>{0}</b> <size=-5><i>Electoral Votes", voteSummary.ElectoralVotesDem), "")
            votesPanelElectoral.VotesTextRight = If(voteSummary.ElectoralVotesRep > 0, String.Format("<size=-5>Electoral Votes</size> <b>{0}</b>", voteSummary.ElectoralVotesRep), "")
        End Sub

        Private Sub UpdateElectionSummary()
            Me.voteSummary = New VoteSummaryInfo()
            If electionData Is Nothing Then
                Return
            End If
            Dim allVotes = electionData.Votes.SelectMany(Function(q) q.Votes)

            voteSummary.ElectoralVotesDem = allVotes.Where(Function(q) q.CandidateType = CandidateType.Democrat).Sum(Function(x) x.ElectoralVotes)
            voteSummary.ElectoralVotesRep = allVotes.Where(Function(q) q.CandidateType = CandidateType.Republican).Sum(Function(x) x.ElectoralVotes)


            voteSummary.TotalVotesDem = allVotes.Where(Function(q) q.CandidateType = CandidateType.Democrat).Sum(Function(x) x.VotesCount)
            voteSummary.TotalVotesRep = allVotes.Where(Function(q) q.CandidateType = CandidateType.Republican).Sum(Function(x) x.VotesCount)
            voteSummary.TotalVotesOther = allVotes.Where(Function(q) q.CandidateType = CandidateType.Other).Sum(Function(x) x.VotesCount)

            voteSummary.TotalVotes = allVotes.Sum(Function(q) q.VotesCount)
            Dim dem = electionData.Votes.SelectMany(Function(q) q.Votes).FirstOrDefault(Function(x) x.CandidateType = CandidateType.Democrat)
            Dim rep = electionData.Votes.SelectMany(Function(q) q.Votes).FirstOrDefault(Function(x) x.CandidateType = CandidateType.Republican)

            voteSummary.CandidateNameDem = If(dem Is Nothing, "Democrat", dem.Name)
            voteSummary.CandidateNameRep = If(rep Is Nothing, "Republican", rep.Name)


        End Sub

        Private Function StateFromMapAttribute(ByVal attributes As MapItemAttributeCollection) As StateInfo
            Return colorizer.StateFromMapAttribute(attributes)
        End Function
        Private Function CountyFromMapAttribute(ByVal attributes As MapItemAttributeCollection) As CountyInfo
            Return colorizer.CountyFromMapAttribute(attributes)
        End Function
        Private Function GenerateCountyResults() As List(Of ListVoteResults)
            Dim res As New List(Of ListVoteResults)()
            If electionData Is Nothing Then
                Return res
            End If
            Dim results = GetStateVoteInfo(activeStateCounty)
            If results IsNot Nothing AndAlso results.HasCountyVotes Then
                For Each c In results.CountyVotes
                    Dim li As New ListVoteResults()
                    li.State = c.State
                    Dim county = c.GetCounty()
                    li.Name = If(county Is Nothing, "UNKNOWN", county.CountyName.Replace(" County", ""))
                    li.CountyFIPS = If(county Is Nothing, "", county.FIPS)
                    li.TotalVotes = c.TotalVotesCount
                    Dim rep = c.Votes.FirstOrDefault(Function(q) q.CandidateType = CandidateType.Republican)
                    Dim dem = c.Votes.FirstOrDefault(Function(q) q.CandidateType = CandidateType.Democrat)
                    Dim oth = c.Votes.FirstOrDefault(Function(q) q.CandidateType = CandidateType.Other)

                    li.RepVotes = If(rep Is Nothing, 0, rep.VotesCount)
                    li.DemVotes = If(dem Is Nothing, 0, dem.VotesCount)
                    li.OtherVotes = If(oth Is Nothing, 0, oth.VotesCount)

                    res.Add(li)
                Next c
            End If
            Return res
        End Function

        Private Function GenerateStateResults() As List(Of ListVoteResults)
            Dim res As New List(Of ListVoteResults)()
            If electionData Is Nothing Then
                Return res
            End If
            For Each state In electionData.Votes.OrderBy(Function(q) q.State)
                Dim li As New ListVoteResults()
                li.State = state.State
                li.Name = StateInfo.GetState(li.State).Name
                li.TotalVotes = state.TotalVotesCount
                Dim rep = state.Votes.FirstOrDefault(Function(q) q.CandidateType = CandidateType.Republican)
                Dim dem = state.Votes.FirstOrDefault(Function(q) q.CandidateType = CandidateType.Democrat)
                Dim oth = state.Votes.FirstOrDefault(Function(q) q.CandidateType = CandidateType.Other)

                li.RepVotes = If(rep Is Nothing, 0, rep.VotesCount)
                li.DemVotes = If(dem Is Nothing, 0, dem.VotesCount)
                li.OtherVotes = If(oth Is Nothing, 0, oth.VotesCount)

                li.RepElectoralVotes = If(rep Is Nothing, 0, rep.ElectoralVotes)
                li.DemElectoralVotes = If(dem Is Nothing, 0, dem.ElectoralVotes)

                res.Add(li)
            Next state
            Return res
        End Function

        Private mapMode_Renamed As MapMode
        Public Property MapMode() As MapMode
            Get
                Return mapMode_Renamed
            End Get
            Set(ByVal value As MapMode)
                If MapMode = value Then
                    Return
                End If
                mapMode_Renamed = value
                OnMapModeChanged()
            End Set
        End Property

        Private Sub OnMapModeChanged()
            If MapMode = DevExpress.VoteApp.MapMode.StateView Then
                ShowStateMap()
                Return
            End If
            If MapMode = DevExpress.VoteApp.MapMode.StateCountyView Then
                ShowStateCountyMap()
                Return
            End If
        End Sub
        Private lastClickTime As Long = 0
        Private Sub mapControl_MapItemClick(ByVal sender As Object, ByVal e As MapItemClickEventArgs) Handles mapControl.MapItemClick, mapControl.MapItemDoubleClick
            Dim showHintOnClick As Boolean = False
            If MouseEventSourceInfo.IsTouchEvent() AndAlso e.MouseArgs.Clicks = 1 Then
                If Environment.TickCount - lastClickTime > 200 Then
                    lastClickTime = Environment.TickCount
                    showHintOnClick = True
                    If IsCountyMode AndAlso StateFromMapAttribute(e.Item.Attributes) IsNot Nothing Then
                        showHintOnClick = False
                    End If
                End If
            End If
            If showHintOnClick Then
                mapTooltipController.ShowHint(New ToolTipControlInfo(e.Item, "text") With {.ImmediateToolTip = True, .ForcedShow = DefaultBoolean.True, .ToolTipLocation = ToolTipLocation.TopCenter, .ToolTipPosition = Point.Subtract(mapControl.PointToScreen(e.MouseArgs.Location), New Size(0, 60))})
                e.Handled = True
                Return
            End If

            Dim state = StateFromMapAttribute(e.Item.Attributes)
            If state IsNot Nothing Then
                If IsElectionPlaygroundMode Then
                    SwitchStateVote(state)
                    Return
                End If
                ShowCountyMap(state)
            End If
        End Sub
        Private voteResultsAltered As Boolean = False

        Private Sub SwitchStateVote(ByVal state As StateInfo)
            Dim vote = GetStateVoteInfo(state)
            If vote Is Nothing Then
                Return
            End If
            ReverseVotes(vote.Votes)
            Me.voteResultsAltered = True
            colorizer.ColorizeStateItems(electionData, usStateInfo.VisibleItems)
            UpdateElectionInfo(True)
        End Sub

        Private Sub ReverseVotes(ByVal votes As List(Of CandidateVote))
            Dim dem = votes.FirstOrDefault(Function(q) q.CandidateType = CandidateType.Democrat)
            Dim rep = votes.FirstOrDefault(Function(q) q.CandidateType = CandidateType.Republican)
            If dem Is Nothing OrElse rep Is Nothing Then
                Return
            End If
            Dim x = dem.Name
            dem.Name = rep.Name
            dem.CandidateType = CandidateType.Republican
            rep.Name = x
            rep.CandidateType = CandidateType.Democrat

        End Sub

        Private ReadOnly Property IsCountyMode() As Boolean
            Get
                Return isCountyMode_Renamed
            End Get
        End Property

        Private Function IsSkipGeoid(ByVal attr As MapItemAttribute) As Boolean
            If attr Is Nothing OrElse attr.Value Is Nothing Then
                Return True
            End If
            Return False
        End Function
        Private ReadOnly Property EnableMapScrollingInStateView() As Boolean
            Get
                Return True
            End Get
        End Property
        Private Sub ShowCountyMap(ByVal state As StateInfo, Optional ByVal forceFullMap As Boolean = False)
            If electionData Is Nothing Then
                Return
            End If
            If state Is Nothing AndAlso (Not forceFullMap) Then
                Return
            End If
            Me.mapData = Nothing
            If Not IsCountyMode Then
                Me.mapData = SaveMapView(mapControl)
            End If
            DisposeCountyLayer()
            If state IsNot Nothing Then
                Dim voteInfo = electionData.Votes.FirstOrDefault(Function(q) q.State = state.State)
                If voteInfo Is Nothing OrElse (Not voteInfo.HasCountyVotes) Then
                    XtraMessageBox.Show(Me, String.Format("{0} state has no detailed county data", state.Name))
                    Return
                End If
            End If
            Me.mapControl.EnableScrolling = True
            Me.activeStateCounty = state
            isCountyMode_Renamed = True
            UpdateListSource()
            btBackToStates.Visible = True
            btBackToStates.BringToFront()
            LoadCountyShape(If(state Is Nothing, Nothing, state.FIPS), usCountyInfo)
            For Each item In usStateInfo.VisibleItems
                item.Fill = Color.FromArgb(100, item.Fill)
                item.HighlightedFill = item.Fill
                item.SelectedFill = item.HighlightedFill
            Next item
            mapControl.Layers.Add(usCountyInfo.Layer)
            mapControl.ZoomToFit(usCountyInfo.VisibleItems)
            gridView.ClearColumnsFilter()
        End Sub
        Private Sub ShowStateCountyMap()
            ShowCountyMap(Nothing, True)
        End Sub

        Private Sub ShowStateMap()
            If usCountyInfo.Layer IsNot Nothing Then
                btBackToStates.Visible = False
                DisposeCountyLayer()
                Me.mapControl.EnableScrolling = EnableMapScrollingInStateView
                stateLayer.Visible = True
                colorizer.ColorizeStateItems(electionData, usStateInfo.VisibleItems)
                isCountyMode_Renamed = False
                Me.activeStateCounty = Nothing

                If mapData IsNot Nothing Then
                    RestoreMapView(mapControl, mapData)
                Else
                    btCenter_Click(Me, EventArgs.Empty)
                End If
                gridView.ClearColumnsFilter()
                UpdateListSource()
            End If
        End Sub
        Private Sub LoadUSCountyShapes()
            Me.usCountyInfo.AllItems = LoadMapShapeItems(Helpers.GetUSCountyMap())
        End Sub
        Private Sub LoadUSShape(ByVal info As LoadedMapInfo, ByVal electionData As ElectionData, Optional ByVal colorize As Boolean = True)
            info.DestroyStorage()
            info.AllItems = LoadMapShapeItems(Helpers.GetUSMap())
            info.VisibleItems = New List(Of MapItem)(info.AllItems)
            If colorize Then
                colorizer.ColorizeStateItems(electionData, info.AllItems)
            End If
            If info.Layer Is Nothing Then
                info.Layer = New VectorItemsLayer()
            End If
            info.SetupVisibleItemsLayerStorage()
        End Sub

        Private Function LoadMapShapeItems(ByVal shapeFile As String) As List(Of MapItem)
            Dim mapItems As New List(Of MapItem)()
            Dim shapeAdapter As New ShapefileDataAdapter()
            AddHandler shapeAdapter.ItemsLoaded, Sub(s, e) mapItems.AddRange(e.Items)
            Dim shapeDfb As String = Path.Combine(Path.GetDirectoryName(shapeFile), Path.GetFileNameWithoutExtension(shapeFile) & ".dbf")
            Using fsShp As New FileStream(shapeFile, FileMode.Open, FileAccess.Read)
                Using fsDb As New FileStream(shapeDfb, FileMode.Open, FileAccess.Read)
                    shapeAdapter.LoadFromStream(fsShp, fsDb)
                End Using
            End Using
            shapeAdapter.Dispose()
            Return mapItems
        End Function
        Private Sub LoadMapShape(ByVal shapeFile As String, ByVal vectorLayer As VectorItemsLayer, ByVal mapItems As List(Of MapItem), ByVal shapeAdapter As ShapefileDataAdapter)
            Dim shapeDfb As String = Path.Combine(Path.GetDirectoryName(shapeFile), Path.GetFileNameWithoutExtension(shapeFile) & ".dbf")
            Using fsShp As New FileStream(shapeFile, FileMode.Open, FileAccess.Read)
                Using fsDb As New FileStream(shapeDfb, FileMode.Open, FileAccess.Read)
                    shapeAdapter.LoadFromStream(fsShp, fsDb)
                End Using
            End Using
        End Sub
        Private Sub LoadCountyShape(ByVal county As String, ByVal countyInfo_Renamed As LoadedMapInfo)
            countyInfo_Renamed.VisibleItems = New List(Of MapItem)()
            If county IsNot Nothing Then
                For Each item In countyInfo_Renamed.AllItems
                    Dim stateAttr = item.Attributes("STATEFP")
                    If stateAttr IsNot Nothing AndAlso stateAttr.Value.ToString() = county Then
                        If IsSkipGeoid(item.Attributes("GEOID")) Then
                            Continue For
                        End If
                        countyInfo_Renamed.VisibleItems.Add(item)
                    End If
                Next item
            Else
                countyInfo_Renamed.VisibleItems.AddRange(countyInfo_Renamed.AllItems)
            End If
            colorizer.ColorizeCountyItems(electionData, countyInfo_Renamed.VisibleItems)
            DisposeCountyLayer()
            countyInfo_Renamed.Layer = New VectorItemsLayer() With {.ToolTipPattern = "tooltip"}
            countyInfo_Renamed.SetupVisibleItemsLayerStorage()
        End Sub

        Private Sub DisposeCountyLayer(Optional ByVal countyInfo_Renamed As LoadedMapInfo = Nothing)
            If countyInfo_Renamed Is Nothing Then
                countyInfo_Renamed = Me.usCountyInfo
            End If
            countyInfo_Renamed.DestroyStorage()
            countyInfo_Renamed.DestroyLayer()
        End Sub
        Private Function SaveMapView(ByVal map As MapControl) As MapViewData
            Return New VoteApp.MapViewData() With {.CenterPoint = map.CenterPoint, .Zoom = map.ZoomLevel}
        End Function
        Private Sub RestoreMapView(ByVal map As MapControl, ByVal data As MapViewData, Optional ByVal animated As Boolean = True)
            If data Is Nothing Then
                Return
            End If
            map.ZoomLevel = data.Zoom
            map.SetCenterPoint(data.CenterPoint, animated)
        End Sub
        Private Sub btBackToStates_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btBackToStates.Click
            If IsCountyMode Then
                ShowStateMap()
            End If
        End Sub
        Private lastAdjustedSize As Size = Size.Empty
        Private Sub Map_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.SizeChanged
            If IsCountyMode OrElse lastAdjustedSize.IsEmpty Then
                Return
            End If
            If Math.Abs(lastAdjustedSize.Width - Size.Width) > 70 OrElse Math.Abs(lastAdjustedSize.Height - Size.Height) > 70 Then
                lastAdjustedSize = Size
                mapControl.ZoomToFit(usStateInfo.VisibleItems)
            End If
        End Sub
        Private Sub gridView_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView.CustomDrawCell
            If e.Column IsNot colArea Then
                Return
            End If
            Dim lr As ListVoteResults = TryCast(gridView.GetRow(e.RowHandle), ListVoteResults)
            If lr Is Nothing Then
                Return
            End If
            Dim votes As Integer = 0
            Dim color As Color = System.Drawing.Color.Empty
            If IsCountyMode Then
                votes = If(lr.DemVotes = 0, lr.RepVotes, lr.DemVotes)
                color = If(lr.RepVotes > lr.DemVotes, colorizer.RepColor, colorizer.DemColor)
            Else
                votes = If(lr.DemElectoralVotes = 0, lr.RepElectoralVotes, lr.DemElectoralVotes)
                color = If(lr.DemElectoralVotes = 0, colorizer.RepColor, colorizer.DemColor)
            End If
            If votes = 0 Then
                Return
            End If
            e.Appearance.BackColor = color
            e.Appearance.ForeColor = System.Drawing.Color.White
            e.DefaultDraw()
            e.Handled = True
            If IsCountyMode Then
                Return
            End If
            Dim bounds_Renamed As Rectangle = e.Bounds
            Dim app As New AppearanceObject() With {.ForeColor = System.Drawing.Color.White}
            app.TextOptions.HAlignment = HorzAlignment.Far
            app.TextOptions.VAlignment = VertAlignment.Bottom
            app.DrawString(e.Cache, votes.ToString(), bounds_Renamed)

        End Sub
        Private Sub gridView_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gridView.RowClick
            If e.Clicks > 1 AndAlso (Not IsCountyMode) Then
                If IsElectionPlaygroundMode Then
                    Return
                End If
                Dim lr As ListVoteResults = TryCast(gridView.GetRow(e.RowHandle), ListVoteResults)
                If lr Is Nothing Then
                    Return
                End If
                Dim stateInfo_Renamed = DevExpress.VoteApp.StateInfo.GetState(lr.State)
                If stateInfo_Renamed IsNot Nothing Then
                    ShowCountyMap(stateInfo_Renamed)
                End If
            End If
        End Sub
        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            Dim lr = TryCast(gridView.GetFocusedRow(), ListVoteResults)
            If lr Is Nothing Then
                Return
            End If
            If IsCountyMode Then
                If usCountyInfo.Layer Is Nothing Then
                    Return
                End If
                Dim countyItem = usCountyInfo.VisibleItems.FirstOrDefault(Function(q) (If(colorizer.CountyFromMapAttribute(q.Attributes), New CountyInfo(""))).FIPS = lr.CountyFIPS)
                usCountyInfo.Layer.SelectedItem = countyItem
            Else
                Dim stateItem = usStateInfo.VisibleItems.FirstOrDefault(Function(q) (If(colorizer.StateFromMapAttribute(q.Attributes), New StateInfo(""))).State = lr.State)
                stateLayer.SelectedItem = stateItem
            End If
            If MouseEventSourceInfo.IsTouchEvent() Then
                gridTooltipController.ShowHint(New ToolTipControlInfo(lr, "text") With {.ForcedShow = DefaultBoolean.True, .ImmediateToolTip = True, .ToolTipLocation = ToolTipLocation.TopCenter})
            End If
        End Sub
        Private Sub gridTooltipController_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs) Handles gridTooltipController.BeforeShow
            Dim lr As ListVoteResults = TryCast(e.SelectedObject, ListVoteResults)
            If lr Is Nothing Then
                Return
            End If
            Dim superTip As New SuperToolTip() With {.MaxWidth = 350, .AllowHtmlText = DefaultBoolean.True}
            e.AutoHide = False
            e.ToolTipType = ToolTipType.SuperTip
            e.Show = False
            If IsCountyMode AndAlso (Not String.IsNullOrEmpty(lr.CountyFIPS)) Then
                e.Show = GenerateCountyToolTip(CountyInfo.GetCounty(lr.CountyFIPS), superTip)
            End If

            If Not IsCountyMode Then
                e.Show = GenerateStateToolTip(StateInfo.GetState(lr.State), superTip)
            End If

            e.SuperTip = superTip
        End Sub

        Private Sub mapTooltipController_BeforeShow(ByVal sender As Object, ByVal e As ToolTipControllerShowEventArgs) Handles mapTooltipController.BeforeShow
            If Not (TypeOf e.SelectedObject Is MapPath) Then
                Return
            End If
            Dim mapPath = DirectCast(e.SelectedObject, MapPath)

            Dim superTip As New SuperToolTip() With {.MaxWidth = 350, .AllowHtmlText = DefaultBoolean.True}
            e.AutoHide = False
            e.ToolTipType = ToolTipType.SuperTip

            If IsCountyMode Then
                If Not GenerateCountyToolTip(CountyFromMapAttribute(mapPath.Attributes), superTip) Then
                    e.Show = False
                End If
            Else
                If Not GenerateStateToolTip(StateFromMapAttribute(mapPath.Attributes), superTip) Then
                    e.Show = False
                End If
            End If
            e.SuperTip = superTip
        End Sub

        Private Function GenerateStateToolTip(ByVal state As StateInfo, ByVal superTip As SuperToolTip) As Boolean
            Dim voteInfo = GetStateVoteInfo(state)

            If voteInfo Is Nothing Then
                Return False
            End If
            Return GenerateVoteToolTipCore(superTip, state.Name, voteInfo.Votes, voteInfo.TotalVotesCount, True)
        End Function
        Private Function GenerateCountyToolTip(ByVal county As CountyInfo, ByVal superTip As SuperToolTip) As Boolean
            Dim voteInfo = GetCountyVoteInfo(county)
            If county Is Nothing Then
                Return False
            End If
            If voteInfo Is Nothing Then
                voteInfo = New CountyVote() With {.Votes = New List(Of CandidateVote)()} 'generating empty tooltip
            End If
            Return GenerateVoteToolTipCore(superTip, county.CountyName, voteInfo.Votes, voteInfo.TotalVotesCount, False)
        End Function
        Private Function GenerateVoteToolTipCore(ByVal superTip As SuperToolTip, ByVal titleText As String, ByVal votes As List(Of CandidateVote), ByVal totalCount As Integer, Optional ByVal allowElecotralInfo As Boolean = True) As Boolean
            Dim title As New ToolTipTitleItem() With {.Text = titleText}
            superTip.Items.Add(title)
            superTip.Items.AddSeparator()

            If votes.Count = 0 Then
                superTip.Items.Add(New ToolTipItem() With {.Text = "No information available yet"})
                Return True
            End If
            Dim eWinner As CandidateVote = Nothing
            For Each vote In votes.OrderBy(Function(q) q.CandidateType)
                Dim ti As New ToolTipItem()
                ti.Image = colorizer.GenerateImage(vote.CandidateType)
                ti.Text = String.Format("{0} <b>{1:p}</b> ({2:n0})", GetNameByType(vote.CandidateType), Helpers.GetPercent(vote.VotesCount, totalCount), vote.VotesCount)
                superTip.Items.Add(ti)

                If vote.ElectoralVotes > 0 Then
                    If eWinner IsNot Nothing Then
                        eWinner = Nothing
                    Else
                        eWinner = vote
                    End If
                End If
            Next vote

            If eWinner IsNot Nothing AndAlso allowElecotralInfo Then
                superTip.Items.AddSeparator()
                Dim winner As New ToolTipItem()
                winner.Image = colorizer.GenerateImage(eWinner.CandidateType)
                winner.Text = String.Format("<b>{0}</b> electoral votes going to <b>{1}</b>", eWinner.ElectoralVotes, GetNameByType(eWinner.CandidateType))
                superTip.Items.Add(winner)
            End If
            Return True
        End Function
        Private Function GetNameByType(ByVal type As CandidateType) As String
            If voteSummary Is Nothing Then
                Return type.ToString()
            End If
            Select Case type
                Case CandidateType.Democrat
                    Return voteSummary.CandidateNameDem
                Case CandidateType.Republican
                    Return voteSummary.CandidateNameRep
            End Select
            Return "Others"
        End Function
        Private Function GetCountyVoteInfo(ByVal county As CountyInfo) As CountyVote
            If county Is Nothing OrElse electionData Is Nothing Then
                Return Nothing
            End If
            Return electionData.Votes.Where(Function(n) n.HasCountyVotes).SelectMany(Function(q) q.CountyVotes).FirstOrDefault(Function(x) x.FIPS = county.FIPS)
        End Function
        Private Function GetStateVoteInfo(ByVal state As StateInfo) As StateVote
            If state Is Nothing OrElse electionData Is Nothing Then
                Return Nothing
            End If
            Return electionData.Votes.FirstOrDefault(Function(q) q.State = state.State)
        End Function

        Private Sub gridTooltipController_GetActiveObjectInfo(ByVal sender As Object, ByVal e As ToolTipControllerGetActiveObjectInfoEventArgs) Handles gridTooltipController.GetActiveObjectInfo
            Dim hi = gridView.CalcHitInfo(e.ControlMousePosition)
            If hi.InRow Then
                e.Info = New ToolTipControlInfo(gridView.GetRow(hi.RowHandle), "text")

            End If
        End Sub
        Private Sub mapControl_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles mapControl.DoubleClick
            If IsCountyMode AndAlso usCountyInfo.Layer IsNot Nothing AndAlso usCountyInfo.Layer.SelectedItem Is Nothing Then
                Dim ti As New Timer() With {.Interval = 400}
                AddHandler ti.Tick, Sub(s, ee)
                                        ti.Dispose()
                                        If IsCountyMode Then
                                            ShowStateMap()
                                        End If
                                    End Sub
                ti.Start()
            End If
        End Sub

        Private Sub switchResults_Click(ByVal sender As Object, ByVal e As EventArgs) Handles switchResults.Click
            electionResults = If(electionResults = DevExpress.VoteApp.ElectionResults.e2012, DevExpress.VoteApp.ElectionResults.e2016, DevExpress.VoteApp.ElectionResults.e2012)
            switchResults.Text = If(electionResults = DevExpress.VoteApp.ElectionResults.e2016, "Show 2012", "Show 2016")
            LoadElectionData()
            tsElectionSimilutor.IsOn = electionData.IsPlayGround
        End Sub

        Private Sub tsElectionSimilutor_Toggled(ByVal sender As Object, ByVal e As EventArgs) Handles tsElectionSimilutor.Toggled
            If (Not tsElectionSimilutor.IsOn) AndAlso voteResultsAltered Then
                LoadElectionData()
            End If
            ShowStateMap()
            UpdateElectionInfo(True)
        End Sub

        Private Sub btCenter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btCenter.Click
            If IsCountyMode Then
                mapControl.ZoomToFit(usCountyInfo.VisibleItems)
            Else
                mapControl.ZoomToFit(usStateInfo.VisibleItems)
            End If
        End Sub
    End Class
    Public Enum ElectionResults
        e2012
        e2016
    End Enum
    Public Enum MapMode
        StateView
        StateCountyView
        CountyView
    End Enum
    Public Class MapViewData
        Public Property CenterPoint() As CoordPoint
        Public Property Zoom() As Double
    End Class
    Public Class VoteSummaryInfo
        Public Property TotalVotes() As Integer
        Public Property TotalVotesDem() As Integer
        Public Property TotalVotesRep() As Integer
        Public Property TotalVotesOther() As Integer

        Public Property ElectoralVotesDem() As Integer
        Public Property ElectoralVotesRep() As Integer
        Public ReadOnly Property ElectoralVotesTotal() As Integer
            Get
                Return 538
            End Get
        End Property

        Public Property CandidateNameDem() As String
        Public Property CandidateNameRep() As String
    End Class
End Namespace
