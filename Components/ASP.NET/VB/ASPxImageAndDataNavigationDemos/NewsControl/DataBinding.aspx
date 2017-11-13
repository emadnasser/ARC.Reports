<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.vb"
	Inherits="NewsControl_DataBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<%--start highlighted block--%>
	<script type="text/javascript">
	// <![CDATA[
		var curTailElement = null;
		var loadingDivText = '<div style="vertical-align: middle; text-align: center;">Loading&hellip;</div>';
		function OnTailClick(newsID, htmlElement) {
			if (!NewsCallback.InCallback() && !IsCurrentNews(htmlElement)) {
				curTailElement = htmlElement;
				ShowPopup(htmlElement, loadingDivText);
				NewsCallback.PerformCallback(newsID);
			}
		}
		function OnCallbackComplete(result) {
			if (GetPopupControl().IsVisible())
				ShowPopup(curTailElement, result);
		}
		function OnNewsControlBeginCallback() {
			GetPopupControl().Hide();
		}
		function IsCurrentNews(htmlElement) {
			return (curTailElement == htmlElement) && GetPopupControl().IsVisible();
		}
		function GetPopupControl() {
			return ASPxPopupClientControl;
		}        
		function ShowPopup(element, contentText) {
			GetPopupControl().Hide();
			GetPopupControl().SetContentHTML(contentText);
			GetPopupControl().ShowAtElement(element);
		}
	// ]]> 
	</script>
	<%--end highlighted block--%>
	<dx:ASPxPopupControl PopupAction="None" ClientInstanceName="ASPxPopupClientControl"
		PopupHorizontalAlign="OutsideRight" EnableViewState="False" ID="ASPxPopupControl1"
		runat="server" PopupHorizontalOffset="5" AllowDragging="True" PopupAnimationType="None"
		PopupVerticalAlign="TopSides" CloseAction="CloseButton" HeaderText="Details" Width="250px">
	</dx:ASPxPopupControl>
	<dx:ASPxNewsControl DataSourceID="XmlDataSource1" ID="ASPxNewsControl1" runat="server"
		NavigateUrlFormatString="javascript:void('{0}');" NameField="Name" Width="800px">
		<ItemSettings ShowImageAsLink="True" MaxLength="120" TailText="Details" />
		<PagerSettings CurrentPageNumberFormat="{0}">
		</PagerSettings>
		<ClientSideEvents TailClick="function(s, e) { OnTailClick(e.name, e.htmlElement); }"
			BeginCallback="function(s, e) { OnNewsControlBeginCallback(); }" />
	</dx:ASPxNewsControl>
	<dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="NewsCallback"
		OnCallback="ASPxCallback1_Callback">
		<ClientSideEvents CallbackComplete="function(s, e) { OnCallbackComplete(e.result); }" />
	</dx:ASPxCallback>
	<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/NewsControl/RSS.xml"
		TransformFile="~/App_Data/NewsControl/RSS.xslt" XPath="//item" />
</asp:Content>