<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Templates.aspx.vb"
	Inherits="FileManager_Templates" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.tmplThumb
		{
			float: left;
			width: 50px;
			height: 50px;
		}
		.tmplTextContainer
		{            
			height: 100%;
			overflow: hidden;
			line-height: 17px;
			padding-left: 6px;
			text-align: left;
			text-overflow: ellipsis;
		}
		.tmplTextContainer .additionalInfo
		{
			color: #818284;
		}
		.selectedFile .tmplTextContainer .additionalInfo
		{
			color: inherit;
		}
	</style>
	<%--start highlighted block--%>
	<script type="text/javascript">
		onHighlightItemTemplate = function(s, e) {
			var startIndex = e.itemName.toLowerCase().indexOf(e.filterValue.toLowerCase()),
				textStart = e.itemName.substr(0, startIndex),
				textMiddle = e.itemName.substr(startIndex, e.filterValue.length),
				textEnd = e.itemName.substr(startIndex + e.filterValue.length),
				highlightedText = textStart + "<span class='" + e.highlightCssClassName + "'>" + textMiddle +"</span>" + textEnd,
				textContainer = ASPxClientUtils.GetChildByTagName(e.templateElement, "DIV", 0);
			ASPxClientUtils.GetChildByTagName(textContainer, "SPAN", 0).innerHTML = "Name: " + highlightedText;
		}
	</script>
	<%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxFileManager ID="fileManager" runat="server">
		<Settings RootFolder="~/Content/FileManager/Files" ThumbnailFolder="~/Content/FileManager/Thumbnails"
			AllowedFileExtensions=".jpg,.jpeg,.gif,.rtf,.txt,.avi,.png,.mp3,.xml,.doc,.pdf"
			InitialFolder="Images\Employees" />
		<ClientSideEvents HighlightItemTemplate="onHighlightItemTemplate" />
		<SettingsUpload Enabled="false" />
		<SettingsFileList>
			<ThumbnailsViewSettings ThumbnailHeight="50" ThumbnailWidth="50">
				<ItemTemplate>
					<img class="tmplThumb" src='<%#Eval("ThumbnailUrl")%>' alt='<%#Eval("Name")%>' />
					<div class="tmplTextContainer">
						<span><%#Eval("Name")%></span>
						<br />
						<span class="additionalInfo"><%#GetFileType(TryCast(Container.DataItem, FileManagerFile))%></span>
						<br />
						<span class="additionalInfo"><%#GetSize(TryCast(Container.DataItem, FileManagerFile))%></span>
					</div>
				</ItemTemplate>
			</ThumbnailsViewSettings>
		</SettingsFileList>
		<Styles>
			<File Width="200px" Height="65px">
				<HoverStyle CssClass="selectedFile" />
				<SelectionActiveStyle CssClass="selectedFile" />
			</File>
		</Styles>
	</dx:ASPxFileManager>
</asp:Content>