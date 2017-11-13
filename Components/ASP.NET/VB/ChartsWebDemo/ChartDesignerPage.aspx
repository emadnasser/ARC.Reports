<%@ Page Language="vb" AutoEventWireup="true" CodeFile="ChartDesignerPage.aspx.vb" Inherits="ChartDesignerPage" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title></title>
	<link href="Content/Designer.css" rel="stylesheet" />
</head>
<body style="height: 100%">
	<form id="form1" runat="server">
		<dxchartdesigner:ASPxChartDesigner runat="server" ID="chartDesigner"
			ClientInstanceName="chartDesigner" CssClass="fullscreen"
			OnSaveChartLayout ="chartDesigner_SaveChartLayout"
			EnableViewState="False" Height=""/>
	</form>
	<script src="Scripts/Designer.js"></script>
</body>
</html>