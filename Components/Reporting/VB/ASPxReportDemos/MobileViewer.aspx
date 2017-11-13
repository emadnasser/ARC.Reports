<%@ Page Language="vb" AutoEventWireup="true" CodeFile="MobileViewer.aspx.vb" Inherits="MobileViewer" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title></title>
	<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=0" />
	<link href="Content/Designer.css" rel="stylesheet" />
</head>
<body>
	<form id="form1" runat="server">
		<asp:PlaceHolder runat="server">
<%
			   If isPollingReport Then
%>
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
			<dx:ASPxWebDocumentViewer runat="server" CssClass="fullscreen" Height="100%" MobileMode="true" ID="webDocumentViewer" ClientInstanceName="webDocumentViewer" EnableViewState="False">
				<clientsideevents init="WebDocumentViewerInit" />
			</dx:ASPxWebDocumentViewer>
<%
			   Else
%>
			<dx:ASPxWebDocumentViewer runat="server" CssClass="fullscreen" Height="100%" MobileMode="true" ID="webDocumentViewer1" EnableViewState="False" />
<%
			   End If
%>
		</asp:PlaceHolder>
	</form>
</body>
</html>