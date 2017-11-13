<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<script runat="server">
    public string ReportTypeName {
        get {
            return "XtraReportsDemos.Overview.Report";
        }
    }
    public bool IsASPViewer {
        get {
            return Request.Params[ViewerSelectorState.Key] == ViewerSelectorState.ClassicViewer;
        }
    }
    public bool IsHTML5Viewer {
        get {
            return Request.Params[ViewerSelectorState.Key] == null;
        }
    }
    public bool IsMobileViewer {
        get {
            return Request.Params[ViewerSelectorState.Key] == ViewerSelectorState.MobileViewer;
        }
    }
    protected void Page_Init(object sender, EventArgs e) {
        var mobileEmulator = Master.FindControl("OverviewDemoContentHolder").FindControl("mobileEmulator") as IMobileEmulator;
        if(mobileEmulator != null) {
            mobileEmulator.ReportTypeName = ReportTypeName;
        }
    }
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
    <link rel="stylesheet" type="text/css" href="<%= Page.ResolveClientUrl("~/Content/ViewerSelector.css") %>" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopRightMenuRegion" runat="Server">
    <dx:ViewerSelector ID="viewerSelector" runat="server" />
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
    <% if(IsASPViewer) { %>
    <dx:ASPxDocumentViewer ID="documentViewer" ReportTypeName="XtraReportsDemos.Overview.Report" runat="server" />
    <% } else if(IsHTML5Viewer) { %>
    <script type="text/javascript">
        function customizeActions(s, e) {
            var ignore = ["Zoom In", "Zoom Out", "Zoom 100%"];
            e.Actions.forEach(function(action) {
                if(ignore.indexOf(action.text) > -1) {
                    action.visible = false;
                }
            });
        }
    </script>
    <dx:ASPxWebDocumentViewer runat="server" ID="webDocumentViewer" ClientInstanceName="webDocumentViewer" EnableViewState="False" Height="380px" ReportSourceId="XtraReportsDemos.Overview.Report">
        <ClientSideEvents CustomizeMenuActions="customizeActions"></ClientSideEvents>
    </dx:ASPxWebDocumentViewer>
    <% } else if(IsMobileViewer) { %>
    <dx:MobileEmulator ID="mobileEmulator" runat="server" />
    <% } %>
</asp:Content>
