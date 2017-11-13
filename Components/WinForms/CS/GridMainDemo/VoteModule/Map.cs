using DevExpress.Map;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Demos;
using DevExpress.XtraMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.VoteApp {
    public partial class Map : TutorialControl {
        VoteSummaryInfo voteSummary = null;
        ElectionData electionData = null;
        VoteMapColorizer colorizer = new VoteMapColorizer();
        LoadedMapInfo usStateInfo, usCountyInfo;
        ElectionResults electionResults = ElectionResults.e2016;

        StateInfo activeStateCounty = null;
        bool isCountyMode = false;
        MapViewData mapData;

        public Map() {
            CreateWaitDialog();
            InitializeComponent();
            this.mapControl.EnableScrolling = EnableMapScrollingInStateView;
            SetWaitDialogCaption("Load Map Info");
            this.usStateInfo = new LoadedMapInfo() { Layer = this.stateLayer };
            this.usCountyInfo = new LoadedMapInfo();
            LoadUSCountyShapes();
            SetWaitDialogCaption("Load Election Results");
            this.electionResults = ElectionResults.e2016;
            LoadElectionData();
            CreateColorLegend();
            switchResults.Visible = true;
        }
        void LoadElectionData() {
            bool needRefresh = electionData != null;
            this.voteResultsAltered = false;
            switch(electionResults) {
                case ElectionResults.e2016: electionData = VoteHelpers.LoadResults2016(); break;
                case ElectionResults.e2012: electionData = VoteHelpers.LoadResults2012(); break;
            }
            UpdateElectionInfo();
            if(needRefresh) {
                Refresh();
            }
        }
        void Map_Load(object sender, EventArgs e) {
            mapControl.ZoomToFit(usStateInfo.VisibleItems);
            this.lastAdjustedSize = Size;
        }
        void UpdateListSource() {
            if(IsCountyMode && MapMode != MapMode.StateCountyView) {
                colArea.Caption = (activeStateCounty == null ? "County" : activeStateCounty.Name);
                this.listVoteResultsBindingSource.DataSource = GenerateCountyResults();
                return;
            }
            colArea.Caption = "State";
            this.listVoteResultsBindingSource.DataSource = GenerateStateResults();
        }
        void CreateColorLegend() {
            ColorListLegend legend = new ColorListLegend();
            Color dem = colorizer.RepColor;

            legend.CustomItems.Add(new ColorLegendItem() { Color = HSLColor.Darken(dem, 0.5), Text = "85% +" });
            legend.CustomItems.Add(new ColorLegendItem() { Color = HSLColor.Darken(dem, 0.8), Text = "70%..85%" });
            legend.CustomItems.Add(new ColorLegendItem() { Color = dem, Text = "50%..70%" });

            legend.CustomItems.Add(new ColorLegendItem() { Color = Color.Silver, Text = "Results unknown" });

            dem = colorizer.DemColor;

            legend.CustomItems.Add(new ColorLegendItem() { Color = dem, Text = "50%..70%" });
            legend.CustomItems.Add(new ColorLegendItem() { Color = HSLColor.Darken(dem, 0.8), Text = "70%..85%" });
            legend.CustomItems.Add(new ColorLegendItem() { Color = HSLColor.Darken(dem, 0.5), Text = "85% +" });
            legend.Header = null;
            legend.Alignment = LegendAlignment.BottomRight;
            legend.ItemStyle.Font = new Font(Appearance.Font.FontFamily, 8);
            mapControl.Legends.Add(legend);

        }

        void UpdateElectionInfo(bool partial = false) {
            UpdateListSource();
            if(!partial) LoadUSShape(usStateInfo, electionData, true);
            UpdateElectionSummary();
            ((MapOverlayTextItem)mapControl.Overlays[0].Items[0]).Text = electionData.Source;
            lbElection.Text = electionData.Title + " " + electionData.Year + (tsElectionSimilutor.IsOn && voteResultsAltered ? " </i>(altered)" : "");

            colDem.Caption = voteSummary.CandidateNameDem;
            lciDemPicture.Text = voteSummary.CandidateNameDem;
            piDem.Image = Helpers.GetCandidatePhoto(voteSummary.CandidateNameDem);
            colGOP.Caption = voteSummary.CandidateNameRep;
            lciRepPicture.Text = voteSummary.CandidateNameRep;
            piRep.Image = Helpers.GetCandidatePhoto(voteSummary.CandidateNameRep);

            UpdateVotePanels();
            Refresh();

        }
        bool IsElectionPlaygroundMode {  get { return tsElectionSimilutor.IsOn; } }
        void UpdateVotePanels() {
            votesPanelPeople.VotesCountLeft = voteSummary.TotalVotesDem;
            votesPanelPeople.VotesCountRight = voteSummary.TotalVotesRep;
            votesPanelPeople.VotesCountTotal = voteSummary.TotalVotes;
            votesPanelPeople.ColorLeft = colorizer.DemColor;
            votesPanelPeople.ColorRight = colorizer.RepColor;

            votesPanelPeople.VotesTextLeft = voteSummary.TotalVotesDem > 0 ? string.Format("<b>{0:p}</b> <i> {1:n0} votes", Helpers.GetPercent(voteSummary.TotalVotesDem, voteSummary.TotalVotes), voteSummary.TotalVotesDem) : "";
            votesPanelPeople.VotesTextRight = voteSummary.TotalVotesRep > 0 ? string.Format("{1:n0} votes</size> <b>{0:p}</b>", Helpers.GetPercent(voteSummary.TotalVotesRep, voteSummary.TotalVotes), voteSummary.TotalVotesRep) : "";


            votesPanelElectoral.VotesCountLeft = voteSummary.ElectoralVotesDem;
            votesPanelElectoral.VotesCountRight = voteSummary.ElectoralVotesRep;
            votesPanelElectoral.VotesCountTotal = voteSummary.ElectoralVotesTotal;
            votesPanelElectoral.ColorLeft = colorizer.DemColor;
            votesPanelElectoral.ColorRight = colorizer.RepColor;


            votesPanelElectoral.VotesTextLeft = voteSummary.ElectoralVotesDem > 0 ? string.Format("<b>{0}</b> <size=-5><i>Electoral Votes", voteSummary.ElectoralVotesDem) : "";
            votesPanelElectoral.VotesTextRight = voteSummary.ElectoralVotesRep > 0 ? string.Format("<size=-5>Electoral Votes</size> <b>{0}</b>", voteSummary.ElectoralVotesRep) : "";
        }

        void UpdateElectionSummary() {
            this.voteSummary = new VoteSummaryInfo();
            if(electionData == null) return;
            var allVotes = electionData.Votes.SelectMany(q => q.Votes);

            voteSummary.ElectoralVotesDem = allVotes.Where(q => q.CandidateType == CandidateType.Democrat).Sum(x => x.ElectoralVotes);
            voteSummary.ElectoralVotesRep = allVotes.Where(q => q.CandidateType == CandidateType.Republican).Sum(x => x.ElectoralVotes);


            voteSummary.TotalVotesDem = allVotes.Where(q => q.CandidateType == CandidateType.Democrat).Sum(x => x.VotesCount);
            voteSummary.TotalVotesRep = allVotes.Where(q => q.CandidateType == CandidateType.Republican).Sum(x => x.VotesCount);
            voteSummary.TotalVotesOther = allVotes.Where(q => q.CandidateType == CandidateType.Other).Sum(x => x.VotesCount);

            voteSummary.TotalVotes = allVotes.Sum(q => q.VotesCount);
            var dem = electionData.Votes.SelectMany(q => q.Votes).FirstOrDefault(x => x.CandidateType == CandidateType.Democrat);
            var rep = electionData.Votes.SelectMany(q => q.Votes).FirstOrDefault(x => x.CandidateType == CandidateType.Republican);

            voteSummary.CandidateNameDem = dem == null ? "Democrat" : dem.Name;
            voteSummary.CandidateNameRep = rep == null ? "Republican" : rep.Name;


        }

        StateInfo StateFromMapAttribute(MapItemAttributeCollection attributes) { return colorizer.StateFromMapAttribute(attributes); }
        CountyInfo CountyFromMapAttribute(MapItemAttributeCollection attributes) { return colorizer.CountyFromMapAttribute(attributes);  }
        List<ListVoteResults> GenerateCountyResults() {
            List<ListVoteResults> res = new List<ListVoteResults>();
            if(electionData == null) return res;
            var results = GetStateVoteInfo(activeStateCounty);
            if(results != null && results.HasCountyVotes) {
                foreach(var c in results.CountyVotes) {
                    ListVoteResults li = new ListVoteResults();
                    li.State = c.State;
                    var county = c.GetCounty();
                    li.Name = county == null ? "UNKNOWN" : county.CountyName.Replace(" County", "");
                    li.CountyFIPS = county == null ? "" : county.FIPS;
                    li.TotalVotes = c.TotalVotesCount;
                    var rep = c.Votes.FirstOrDefault(q => q.CandidateType == CandidateType.Republican);
                    var dem = c.Votes.FirstOrDefault(q => q.CandidateType == CandidateType.Democrat);
                    var oth = c.Votes.FirstOrDefault(q => q.CandidateType == CandidateType.Other);

                    li.RepVotes = rep == null ? 0 : rep.VotesCount;
                    li.DemVotes = dem == null ? 0 : dem.VotesCount;
                    li.OtherVotes = oth == null ? 0 : oth.VotesCount;

                    res.Add(li);
                }
            }
            return res;
        }
                
        List<ListVoteResults> GenerateStateResults() {
            List<ListVoteResults> res = new List<ListVoteResults>();
            if(electionData == null) return res;
            foreach(var state in electionData.Votes.OrderBy(q=>q.State)) {
                ListVoteResults li = new ListVoteResults();
                li.State = state.State;
                li.Name = StateInfo.GetState(li.State).Name;
                li.TotalVotes = state.TotalVotesCount;
                var rep = state.Votes.FirstOrDefault(q => q.CandidateType == CandidateType.Republican);
                var dem = state.Votes.FirstOrDefault(q => q.CandidateType == CandidateType.Democrat);
                var oth = state.Votes.FirstOrDefault(q => q.CandidateType == CandidateType.Other);

                li.RepVotes = rep == null ? 0 : rep.VotesCount;
                li.DemVotes = dem == null ? 0 : dem.VotesCount;
                li.OtherVotes = oth == null ? 0 : oth.VotesCount;

                li.RepElectoralVotes = rep == null ? 0 : rep.ElectoralVotes;
                li.DemElectoralVotes = dem == null ? 0 : dem.ElectoralVotes;

                res.Add(li);
            }
            return res;
        }

        MapMode mapMode;
        public MapMode MapMode {
            get { return mapMode; }
            set {
                if(MapMode == value) return;
                mapMode = value;
                OnMapModeChanged();
            }
        }

        void OnMapModeChanged() {
            if(MapMode == MapMode.StateView) {
                ShowStateMap();
                return;
            }
            if(MapMode == MapMode.StateCountyView) {
                ShowStateCountyMap();
                return;
            }
        }
        long lastClickTime = 0;
        void mapControl_MapItemClick(object sender, MapItemClickEventArgs e) {
            bool showHintOnClick = false;
            if(MouseEventSourceInfo.IsTouchEvent() && e.MouseArgs.Clicks == 1) {
                if(Environment.TickCount - lastClickTime > 200) {
                    lastClickTime = Environment.TickCount;
                    showHintOnClick = true;
                    if(IsCountyMode && StateFromMapAttribute(e.Item.Attributes) != null) showHintOnClick = false;
                }
            }
            if(showHintOnClick) {
                mapTooltipController.ShowHint(new ToolTipControlInfo(e.Item, "text") {
                    ImmediateToolTip = true,
                    ForcedShow = DefaultBoolean.True,
                    ToolTipLocation = ToolTipLocation.TopCenter,
                    ToolTipPosition = Point.Subtract(mapControl.PointToScreen(e.MouseArgs.Location), new Size(0, 60))
                });
                e.Handled = true;
                return;
            }

            var state = StateFromMapAttribute(e.Item.Attributes);
            if(state != null) {
                if(IsElectionPlaygroundMode) {
                    SwitchStateVote(state);
                    return;
                }
                ShowCountyMap(state);
            }
        }
        bool voteResultsAltered = false;

        void SwitchStateVote(StateInfo state) {
            var vote = GetStateVoteInfo(state);
            if(vote == null) return;
            ReverseVotes(vote.Votes);
            this.voteResultsAltered = true;
            colorizer.ColorizeStateItems(electionData, usStateInfo.VisibleItems);
            UpdateElectionInfo(true);
        }

        void ReverseVotes(List<CandidateVote> votes) {
            var dem = votes.FirstOrDefault(q => q.CandidateType == CandidateType.Democrat);
            var rep = votes.FirstOrDefault(q => q.CandidateType == CandidateType.Republican);
            if(dem == null || rep == null) return;
            var x = dem.Name;
            dem.Name = rep.Name;
            dem.CandidateType = CandidateType.Republican;
            rep.Name = x;
            rep.CandidateType = CandidateType.Democrat;

        }

        bool IsCountyMode {
            get { return isCountyMode; }
        }
    
        bool IsSkipGeoid(MapItemAttribute attr) {
            if(attr == null || attr.Value == null) return true;
            return false;
        }
        bool EnableMapScrollingInStateView {  get { return true; } }
        void ShowCountyMap(StateInfo state, bool forceFullMap = false) {
            if(electionData == null) return;
            if(state == null && !forceFullMap) return;
            this.mapData = null;
            if(!IsCountyMode) this.mapData = SaveMapView(mapControl);
            DisposeCountyLayer();
            if(state != null) {
                var voteInfo = electionData.Votes.FirstOrDefault(q => q.State == state.State);
                if(voteInfo == null || !voteInfo.HasCountyVotes) {
                    XtraMessageBox.Show(this, string.Format("{0} state has no detailed county data", state.Name));
                    return;
                }
            }
            this.mapControl.EnableScrolling = true;
            this.activeStateCounty = state;
            isCountyMode = true;
            UpdateListSource();
            btBackToStates.Visible = true;
            btBackToStates.BringToFront();
            LoadCountyShape(state == null ? null : state.FIPS, usCountyInfo);
            foreach(var item in usStateInfo.VisibleItems) {
                item.SelectedFill = item.HighlightedFill = item.Fill = Color.FromArgb(100, item.Fill);
            }
            mapControl.Layers.Add(usCountyInfo.Layer);
            mapControl.ZoomToFit(usCountyInfo.VisibleItems);
            gridView.ClearColumnsFilter();
        }
        void ShowStateCountyMap() { ShowCountyMap(null, true); }

        void ShowStateMap() {
            if(usCountyInfo.Layer != null) {
                btBackToStates.Visible = false;
                DisposeCountyLayer();
                this.mapControl.EnableScrolling = EnableMapScrollingInStateView;
                stateLayer.Visible = true;
                colorizer.ColorizeStateItems(electionData, usStateInfo.VisibleItems);
                isCountyMode = false;
                this.activeStateCounty = null;

                if(mapData != null)
                    RestoreMapView(mapControl, mapData);
                else btCenter_Click(this, EventArgs.Empty);
                gridView.ClearColumnsFilter();
                UpdateListSource();
            }
        }
        void LoadUSCountyShapes() {
            this.usCountyInfo.AllItems = LoadMapShapeItems(Helpers.GetUSCountyMap());
        }
        void LoadUSShape(LoadedMapInfo info, ElectionData electionData, bool colorize = true) {
            info.DestroyStorage();
            info.AllItems = LoadMapShapeItems(Helpers.GetUSMap());
            info.VisibleItems = new List<MapItem>(info.AllItems);
            if(colorize) colorizer.ColorizeStateItems(electionData, info.AllItems);
            if(info.Layer == null) info.Layer = new VectorItemsLayer();
            info.SetupVisibleItemsLayerStorage();
        }

        List<MapItem> LoadMapShapeItems(string shapeFile) {
            List<MapItem> mapItems = new List<MapItem>();
            ShapefileDataAdapter shapeAdapter = new ShapefileDataAdapter();
            shapeAdapter.ItemsLoaded += (s, e) => { mapItems.AddRange(e.Items); };
            string shapeDfb = Path.Combine(Path.GetDirectoryName(shapeFile), Path.GetFileNameWithoutExtension(shapeFile) + ".dbf");
            using(FileStream fsShp = new FileStream(shapeFile, FileMode.Open, FileAccess.Read)) {
                using(FileStream fsDb = new FileStream(shapeDfb, FileMode.Open, FileAccess.Read)) {
                    shapeAdapter.LoadFromStream(fsShp, fsDb);
                }
            }
            shapeAdapter.Dispose();
            return mapItems;
        }
        void LoadMapShape(string shapeFile, VectorItemsLayer vectorLayer, List<MapItem> mapItems, ShapefileDataAdapter shapeAdapter) {
            string shapeDfb = Path.Combine(Path.GetDirectoryName(shapeFile), Path.GetFileNameWithoutExtension(shapeFile) + ".dbf");
            using(FileStream fsShp = new FileStream(shapeFile, FileMode.Open, FileAccess.Read)) {
                using(FileStream fsDb = new FileStream(shapeDfb, FileMode.Open, FileAccess.Read)) {
                    shapeAdapter.LoadFromStream(fsShp, fsDb);
                }
            }
        }
        void LoadCountyShape(string county, LoadedMapInfo countyInfo) {
            countyInfo.VisibleItems = new List<MapItem>();
            if(county != null) {
                foreach(var item in countyInfo.AllItems) {
                    var stateAttr = item.Attributes["STATEFP"];
                    if(stateAttr != null && stateAttr.Value.ToString() == county) {
                        if(IsSkipGeoid(item.Attributes["GEOID"])) continue;
                        countyInfo.VisibleItems.Add(item);
                    }
                };
            }
            else countyInfo.VisibleItems.AddRange(countyInfo.AllItems);
            colorizer.ColorizeCountyItems(electionData, countyInfo.VisibleItems);
            DisposeCountyLayer();
            countyInfo.Layer = new VectorItemsLayer() { ToolTipPattern = "tooltip" };
            countyInfo.SetupVisibleItemsLayerStorage();
        }

        void DisposeCountyLayer(LoadedMapInfo countyInfo = null) {
            if(countyInfo == null) countyInfo = this.usCountyInfo;
            countyInfo.DestroyStorage();
            countyInfo.DestroyLayer();
        }
        MapViewData SaveMapView(MapControl map) {
            return new VoteApp.MapViewData() { CenterPoint = map.CenterPoint, Zoom = map.ZoomLevel };
        }
        void RestoreMapView(MapControl map, MapViewData data, bool animated = true) {
            if(data == null) return;
            map.ZoomLevel = data.Zoom;
            map.SetCenterPoint(data.CenterPoint, animated);
        }
        void btBackToStates_Click(object sender, EventArgs e) {
            if(IsCountyMode) ShowStateMap();
        }
        Size lastAdjustedSize = Size.Empty;
        void Map_SizeChanged(object sender, EventArgs e) {
            if(IsCountyMode || lastAdjustedSize.IsEmpty) return;
            if(Math.Abs(lastAdjustedSize.Width - Size.Width) > 70 ||
                Math.Abs(lastAdjustedSize.Height - Size.Height) > 70) {
                lastAdjustedSize = Size;
                mapControl.ZoomToFit(usStateInfo.VisibleItems);
            }
        }
        void gridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.Column != colArea) return;
            ListVoteResults lr = gridView.GetRow(e.RowHandle) as ListVoteResults;
            if(lr == null) return;
            int votes = 0;
            Color color = Color.Empty;
            if(IsCountyMode) {
                votes = lr.DemVotes == 0 ? lr.RepVotes : lr.DemVotes;
                color = lr.RepVotes > lr.DemVotes ? colorizer.RepColor : colorizer.DemColor;
            }
            else {
                votes = lr.DemElectoralVotes == 0 ? lr.RepElectoralVotes : lr.DemElectoralVotes;
                color = lr.DemElectoralVotes == 0 ? colorizer.RepColor : colorizer.DemColor;
            }
            if(votes == 0) return;
            e.Appearance.BackColor = color;
            e.Appearance.ForeColor = Color.White;
            e.DefaultDraw();
            e.Handled = true;
            if(IsCountyMode) return;
            Rectangle bounds = e.Bounds;
            AppearanceObject app = new AppearanceObject() { ForeColor = Color.White };
            app.TextOptions.HAlignment = HorzAlignment.Far;
            app.TextOptions.VAlignment = VertAlignment.Bottom;
            app.DrawString(e.Cache, votes.ToString(), bounds);

        }
        void gridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            if(e.Clicks > 1 && !IsCountyMode) {
                if(IsElectionPlaygroundMode) return;
                ListVoteResults lr = gridView.GetRow(e.RowHandle) as ListVoteResults;
                if(lr == null) return;
                var stateInfo = StateInfo.GetState(lr.State);
                if(stateInfo != null) ShowCountyMap(stateInfo);
            }
        }
        void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            var lr = gridView.GetFocusedRow() as ListVoteResults;
            if(lr == null) return;
            if(IsCountyMode) {
                if(usCountyInfo.Layer == null) return;
                var countyItem = usCountyInfo.VisibleItems.FirstOrDefault(q => (colorizer.CountyFromMapAttribute(q.Attributes) ?? new CountyInfo("")).FIPS == lr.CountyFIPS);
                usCountyInfo.Layer.SelectedItem = countyItem;
            }
            else {
                var stateItem = usStateInfo.VisibleItems.FirstOrDefault(q => (colorizer.StateFromMapAttribute(q.Attributes) ?? new StateInfo("")).State == lr.State);
                stateLayer.SelectedItem = stateItem;
            }
            if(MouseEventSourceInfo.IsTouchEvent())
                gridTooltipController.ShowHint(new ToolTipControlInfo(lr, "text") {
                    ForcedShow = DefaultBoolean.True,
                    ImmediateToolTip = true,
                    ToolTipLocation = ToolTipLocation.TopCenter
                });
        }
        void gridTooltipController_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            ListVoteResults lr = e.SelectedObject as ListVoteResults;
            if(lr == null) return;
            SuperToolTip superTip = new SuperToolTip() { MaxWidth = 350, AllowHtmlText = DefaultBoolean.True };
            e.AutoHide = false;
            e.ToolTipType = ToolTipType.SuperTip;
            e.Show = false;
            if(IsCountyMode && !string.IsNullOrEmpty(lr.CountyFIPS)) {
                e.Show = GenerateCountyToolTip(CountyInfo.GetCounty(lr.CountyFIPS), superTip);
            }

            if(!IsCountyMode) {
                e.Show = GenerateStateToolTip(StateInfo.GetState(lr.State), superTip);
            }
        
            e.SuperTip = superTip;
        }

        void mapTooltipController_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            if(!(e.SelectedObject is MapPath)) return;
            var mapPath = (MapPath)e.SelectedObject;

            SuperToolTip superTip = new SuperToolTip() { MaxWidth = 350, AllowHtmlText = DefaultBoolean.True };
            e.AutoHide = false;
            e.ToolTipType = ToolTipType.SuperTip;

            if(IsCountyMode) {
                if(!GenerateCountyToolTip(CountyFromMapAttribute(mapPath.Attributes), superTip))
                    e.Show = false;
            }
            else {
                if(!GenerateStateToolTip(StateFromMapAttribute(mapPath.Attributes), superTip))
                    e.Show = false;
            }
            e.SuperTip = superTip;
        }

        bool GenerateStateToolTip(StateInfo state, SuperToolTip superTip) {
            var voteInfo = GetStateVoteInfo(state);

            if(voteInfo == null) {
                return false;
            }
            return GenerateVoteToolTipCore(superTip, state.Name, voteInfo.Votes, voteInfo.TotalVotesCount, true);
        }
        bool GenerateCountyToolTip(CountyInfo county, SuperToolTip superTip) {
            var voteInfo = GetCountyVoteInfo(county);
            if(county == null) return false;
            if(voteInfo == null) {
                voteInfo = new CountyVote() { Votes = new List<CandidateVote>() }; //generating empty tooltip
            }
            return GenerateVoteToolTipCore(superTip, county.CountyName, voteInfo.Votes, voteInfo.TotalVotesCount, false);
        }
        bool GenerateVoteToolTipCore(SuperToolTip superTip, string titleText, List<CandidateVote> votes, int totalCount,  bool allowElecotralInfo = true) {
            ToolTipTitleItem title = new ToolTipTitleItem() { Text = titleText };
            superTip.Items.Add(title);
            superTip.Items.AddSeparator();

            if(votes.Count == 0) {
                superTip.Items.Add(new ToolTipItem() { Text = "No information available yet" });
                return true;
            }
            CandidateVote eWinner = null;
            foreach(var vote in votes.OrderBy(q => q.CandidateType)) {
                ToolTipItem ti = new ToolTipItem();
                ti.Image = colorizer.GenerateImage(vote.CandidateType);
                ti.Text = string.Format("{0} <b>{1:p}</b> ({2:n0})", GetNameByType(vote.CandidateType), Helpers.GetPercent(vote.VotesCount, totalCount), vote.VotesCount);
                superTip.Items.Add(ti);

                if(vote.ElectoralVotes > 0) {
                    if(eWinner != null) eWinner = null;
                    else eWinner = vote;
                }
            }

            if(eWinner != null && allowElecotralInfo) {
                superTip.Items.AddSeparator();
                ToolTipItem winner = new ToolTipItem();
                winner.Image = colorizer.GenerateImage(eWinner.CandidateType);
                winner.Text = string.Format("<b>{0}</b> electoral votes going to <b>{1}</b>", eWinner.ElectoralVotes, GetNameByType(eWinner.CandidateType));
                superTip.Items.Add(winner);
            }
            return true;
        }
        string GetNameByType(CandidateType type) {
            if(voteSummary == null) return type.ToString();
            switch(type) {
                case CandidateType.Democrat: return voteSummary.CandidateNameDem;
                case CandidateType.Republican: return voteSummary.CandidateNameRep;
            }
            return "Others";
        }
        CountyVote GetCountyVoteInfo(CountyInfo county) {
            if(county == null || electionData == null) return null;
            return electionData.Votes.Where(n => n.HasCountyVotes).SelectMany(q => q.CountyVotes).FirstOrDefault(x => x.FIPS == county.FIPS);
        }
        StateVote GetStateVoteInfo(StateInfo state) {
            if(state == null || electionData == null) return null;
            return electionData.Votes.FirstOrDefault(q => q.State == state.State);
        }

        void gridTooltipController_GetActiveObjectInfo(object sender, ToolTipControllerGetActiveObjectInfoEventArgs e) {
            var hi = gridView.CalcHitInfo(e.ControlMousePosition);
            if(hi.InRow) {
                e.Info = new ToolTipControlInfo(gridView.GetRow(hi.RowHandle), "text");

            }
        }
        void mapControl_DoubleClick(object sender, EventArgs e) {
            if(IsCountyMode && usCountyInfo.Layer != null && usCountyInfo.Layer.SelectedItem == null) {
                Timer ti = new Timer() { Interval = 400 };
                ti.Tick += (s, ee) => {
                    ti.Dispose();
                    if(IsCountyMode) ShowStateMap();
                };
                ti.Start();
            }
        }

        void switchResults_Click(object sender, EventArgs e) {
            electionResults = electionResults == ElectionResults.e2012 ? ElectionResults.e2016 : ElectionResults.e2012;
            switchResults.Text = electionResults == ElectionResults.e2016 ? "Show 2012" : "Show 2016";
            LoadElectionData();
            tsElectionSimilutor.IsOn = electionData.IsPlayGround;
        }

        void tsElectionSimilutor_Toggled(object sender, EventArgs e) {
            if(!tsElectionSimilutor.IsOn && voteResultsAltered) LoadElectionData();
            ShowStateMap();
            UpdateElectionInfo(true);
        }

        void btCenter_Click(object sender, EventArgs e) {
            if(IsCountyMode) {
                mapControl.ZoomToFit(usCountyInfo.VisibleItems);
            }
            else
                mapControl.ZoomToFit(usStateInfo.VisibleItems);
        }
    }
    public enum ElectionResults { e2012, e2016 };
    public enum MapMode {  StateView, StateCountyView, CountyView };
    public class MapViewData {
        public CoordPoint CenterPoint { get; set; }
        public double Zoom { get; set; }
    }
    public class VoteSummaryInfo {
        public int TotalVotes { get; set; }
        public int TotalVotesDem { get; set; }
        public int TotalVotesRep { get; set; }
        public int TotalVotesOther { get; set; }

        public int ElectoralVotesDem { get; set; }
        public int ElectoralVotesRep { get; set; }
        public int ElectoralVotesTotal { get { return 538; } }

        public string CandidateNameDem { get; set;}
        public string CandidateNameRep { get; set; }
    }
}
