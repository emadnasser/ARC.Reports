<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" %>
<script runat="server">
	Public ReadOnly Property ReportTypeName() As String
		Get
			Return "XtraReportsDemos.Overview.Report"
		End Get
	End Property
	Public ReadOnly Property IsASPViewer() As Boolean
		Get
			Return Request.Params(ViewerSelectorState.Key) = ViewerSelectorState.ClassicViewer
		End Get
	End Property
	Public ReadOnly Property IsHTML5Viewer() As Boolean
		Get
			Return Request.Params(ViewerSelectorState.Key) Is Nothing
		End Get
	End Property
	Public ReadOnly Property IsMobileViewer() As Boolean
		Get
			Return Request.Params(ViewerSelectorState.Key) = ViewerSelectorState.MobileViewer
		End Get
	End Property
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		Dim mobileEmulator = TryCast(Master.FindControl("OverviewDemoContentHolder").FindControl("mobileEmulator"), IMobileEmulator)
		If mobileEmulator IsNot Nothing Then
			mobileEmulator.ReportTypeName = ReportTypeName
		End If
	End Sub
</script>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
	<link rel="stylesheet" type="text/css" href="<%=Page.ResolveClientUrl("~/Content/ViewerSelector.css")%>" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopRightMenuRegion" runat="Server">
	<dx:ViewerSelector ID="viewerSelector" runat="server" />
</asp:Content>
<asp:Content ID="Content" ContentPlaceHolderID="OverviewDemoContentHolder" runat="Server">
<%
	   If IsASPViewer Then
%>
	<dx:ASPxDocumentViewer ID="documentViewer" ReportTypeName="XtraReportsDemos.Overview.Report" runat="server" />
<%
	   ElseIf IsHTML5Viewer Then
%>
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
<%
	   ElseIf IsMobileViewer Then
%>
	<dx:MobileEmulator ID="mobileEmulator" runat="server" />
<%
	   End If
%>
</asp:Content>