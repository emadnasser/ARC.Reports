<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MapsIntegration.aspx.cs"
    Inherits="MapsIntegration" %>
<asp:Content ID="CssContent" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <script type="text/javascript">
        document.write('<scr' + 'ipt charset="UTF-8" type="text/javascript" src="' +
			'https://ecn.dev.virtualearth.net/mapcontrol/mapcontrol.ashx?v=7.0&mkt=en-us&s=1' + '"></scr' + 'ipt>'); 
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxPageControl ID="ASPxPageControl1" runat="server" ActiveTabIndex="0" Width="100%">
        <TabPages>
            <dx:TabPage Name="tabPivotGrid" Text="PivotGrid">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxPivotGrid ID="pivotGrid" runat="server" DataSourceID="InvoicesDataSource"
                            Width="100%" ClientInstanceName="pivotGrid" OnCustomJsProperties="pivotGrid_CustomJsProperties">
                            <Fields>
                                <dx:PivotGridField ID="fieldCountry" Area="ColumnArea" AreaIndex="0" FieldName="Country" />
                                <dx:PivotGridField ID="fieldProductName" Area="RowArea" AreaIndex="0" FieldName="ProductName" />
                                <dx:PivotGridField ID="fieldQuantity" Area="DataArea" AreaIndex="0" FieldName="Quantity" />
                            </Fields>
                            <OptionsView HorizontalScrollBarMode="Auto"/>
                            <OptionsFilter NativeCheckBoxes="False" />
                            <OptionsCustomization AllowDrag="False" />
                        </dx:ASPxPivotGrid>
                        <ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Invoices" />
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
            <dx:TabPage Name="tabMap" Text="Map">
                <ContentCollection>
                    <dx:ContentControl runat="server">
                        <dx:ASPxLoadingPanel ID="loadingPanel1" ClientInstanceName="loadingPanel1" runat="server" />
                        <div id="myMap" style="position: relative; width: 830px; height: 400px;"></div>
                    </dx:ContentControl>
                </ContentCollection>
            </dx:TabPage>
        </TabPages>
        <ClientSideEvents ActiveTabChanged="function(s, e) {
    if(e.tab.name != 'tabMap') { 
        if(salesMap)
            salesMap.StopShowing(); 
        return; 
    }
    salesMap = new SalesMap();
    salesMap.ShowMap('myMap', pivotGrid.cpCountrySales, loadingPanel1);
}" />
    </dx:ASPxPageControl>
    <script type="text/javascript">
        function SalesMap() {
            var map = null,
                pinInfoBox = null,
                loadingPanel = null,
                salesPerCountry = null,
                activeCallbackCount = 0,
                locations = [],
                stopShowing = false;
            function searchModuleLoaded() {
                var searchManager = new Microsoft.Maps.Search.SearchManager(map),
                    displayingCountry = getNextCountry(null);
                while(displayingCountry) {
                    searchCountry(searchManager, displayingCountry);
                    displayingCountry = getNextCountry(displayingCountry);
                }
            }
            function searchCountry(searchManager, country) {
                activeCallbackCount++;
                var searchRequest = { query: country, count: 1, callback:searchCallback, userData: country };
                searchManager.search(searchRequest);
            }
            function searchCallback(searchResponse, userData) {
                activeCallbackCount--;
                if(stopShowing || searchResponse.parseResults.length === 0) return;
                var location = searchResponse.parseResults[0].location.location;
                locations.push(location);
                displayCountrySales(location, userData);
                if(activeCallbackCount === 0) {
                    setMapView();
                    completeCallbacksProcessing();
                }
            }
            function setMapView() {
                var bestview = Microsoft.Maps.LocationRect.fromLocations(locations);
                map.setView({ bounds:bestview });
            }
            function completeCallbacksProcessing() {
                stopShowing = true;
                loadingPanel.Hide();
                loadingPanel = null;
                map = null;
                pinInfoBox = null;
                salesPerCountry = null;
            }
            function getNextCountry(country) {
                var found = false;
                for(name in salesPerCountry) {
                    if(name === country) {
                        found = true;
                        continue;
                    }
                    if(found || country === null)
                        return name;
                }
                return null;
            }
            function displayCountrySales(location, displayingCountry) {
                var sales = salesPerCountry[displayingCountry],
                    pin = new Microsoft.Maps.Pushpin(location);
                pin.title = displayingCountry;
                pin.description = displayingCountry + ' sales: ' + sales + ' pieces';
                Microsoft.Maps.Events.addHandler(pin, 'mouseover', onMouseover);
                Microsoft.Maps.Events.addHandler(pin, 'mouseout', onMouseout);
                map.entities.push(pin);
            }
            function onMouseover(e) {
                var pin = e.target;
                pinInfobox.setOptions({ title: pin.title, description: pin.description, visible:true }); 
                pinInfobox.setLocation(pin.getLocation());
            }
            function onMouseout(e) {
                pinInfobox.setOptions({ visible:false });
            }
            
            this.StopShowing = function() {
                if(!stopShowing)
                    completeCallbacksProcessing();
            };
            this.ShowMap = function (mapContainerId, sales, panel) {
                loadingPanel = panel;
                salesPerCountry = sales;
                loadingPanel.ShowInElement(document.getElementById(mapContainerId));
                if(!map)
                    map = new Microsoft.Maps.Map(document.getElementById(mapContainerId), {
                        credentials: "AjkzrHog1zkaw_jajEMlAoWGRFQDj-qQe6adwmx3bjBxY1-Nb7mxuTTQIh0qbOgg",
                        mapTypeId: Microsoft.Maps.MapTypeId.road,
                        zoom: 2
                    });
                Microsoft.Maps.loadModule('Microsoft.Maps.Search', { callback: searchModuleLoaded });
                pinInfobox = new Microsoft.Maps.Infobox(new Microsoft.Maps.Location(0,0), { height: 80, visible: false, offset: new Microsoft.Maps.Point(0, 40) });
                map.entities.push(pinInfobox);
            };
        }
    </script>
</asp:Content>
