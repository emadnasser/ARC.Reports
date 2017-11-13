<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PollingReport.aspx.vb"
	Inherits="ReportTypes_PollingReport" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
	<link rel="stylesheet" type="text/css" href="<%=Page.ResolveClientUrl("~/Content/RunDesignerButton.css")%>" />
	<link rel="stylesheet" type="text/css" href="<%=Page.ResolveClientUrl("~/Content/ViewerSelector.css")%>" />
	<script type="text/javascript">
		function WebDocumentViewerInit(s, e) {
			var reportPreview = s.GetPreviewModel().reportPreview;
			reportPreview.customProcessBrickClick = function(pageIndex, brick) {
				if(brick) {
					if(brick.text() === "Show Results") {
						reportPreview.drillThrough("showResults");
					} else if(brick.text() === "Start a new poll") {
						reportPreview.drillThrough("startNewPoll");
					}
				}
			}
			reportPreview.editingFieldChanged = function(field) {
				if(field.groupID()) {
					reportPreview.editingFieldsProvider()
						.forEach(function(item) {
							if(item.id() === field.id() && item !== field) {
								item.readOnly(field.editValue() !== DevExpress.Report.Preview.CheckState.Checked);
							}
						});
				}
			}
		}
	</script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="TopRightMenuRegion" runat="Server">
	<dx:ViewerSelector ID="viewerSelector" runat="server" />
	<dx:ShowDesignerButton ID="showDesignerButton" runat="server" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
<%
	   If IsASPViewer Then
%>
	<dx:ASPxDocumentViewer runat="server" ID="documentViewer"
		Width="1046px" 
		EnableViewState="False">
	</dx:ASPxDocumentViewer>
<%
	   ElseIf IsHTML5Viewer Then
%>
	<dx:ASPxWebDocumentViewer runat="server" ID="webDocumentViewer" ClientInstanceName="webDocumentViewer" EnableViewState="False" >
		<ClientSideEvents Init="WebDocumentViewerInit"  />
	</dx:ASPxWebDocumentViewer>
<%
	   ElseIf IsMobileViewer Then
%>
	<dx:MobileEmulator ID="mobileEmulator" runat="server" />
<%
	   End If
%>
</asp:Content>