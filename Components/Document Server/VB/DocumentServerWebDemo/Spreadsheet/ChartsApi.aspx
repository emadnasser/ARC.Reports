<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ChartsApi.aspx.vb"
	Inherits="Charts_Api" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.borderedContent
		{
			border: 1px Solid rgb(224, 224, 224);
		}
	</style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<script type="text/javascript">
	// <![CDATA[
		function LayoutView() {
			var mainTableHeight = document.getElementById("mainTable").offsetHeight;
			document.getElementById("treeListContainer").style.height = mainTableHeight - 6 + "px";
		}
		function UpdateCodePreview(s, e) {
			var indx = e.result.indexOf('|');
			var exampleName = e.result.substring(0, indx);
			var data = e.result;
			indx++;
			do {
				var endElelmentNameIndx = data.indexOf("$", indx);
				var elementName = data.substring(indx, endElelmentNameIndx);
				indx = endElelmentNameIndx + 1;
				var endLengthIndx = e.result.indexOf("$", indx);
				var length = parseInt(data.substring(indx, endLengthIndx));
				var indx = endLengthIndx + 1;
				var endCodeIndx = indx + length;
				var code = data.substring(indx, endCodeIndx);
				var indx = endCodeIndx + 1;
				document.getElementById(elementName).innerHTML = code;
			} while (indx < data.length);
			lblSourceName.SetText(exampleName);
			var key = s.GetFocusedNodeKey();
			var previewFrame = document.getElementById('previewFrame');
			previewFrame.src = 'chartsapi.aspx?preview=' + key;
		}
	// ]]> 
	</script>
	<dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
		<ClientSideEvents ControlsInitialized="function(s,e){ LayoutView(); }" />
	</dx:ASPxGlobalEvents>
	<table>
		<tr>
			<td style="width: 100%;">
				<dx:ASPxLabel runat="server" ID="lblSourceName" Font-Size="X-Large" ClientInstanceName="lblSourceName">
				</dx:ASPxLabel>
			</td>
			<td>
				<dx:ASPxComboBox ID="cbDownloadType" runat="server" ValueType="System.Int32" SelectedIndex="0"
					ClientInstanceName="cbDownloadType" Width="215px" Style="margin-right: 9px;">
					<Items>
						<dx:ListEditItem Text="Excel Workbook (*.xlsx)" Value="1" />
						<dx:ListEditItem Text="Excel 97-2003 Workbook (*.xls)" Value="2" />
						<dx:ListEditItem Text="Comma delimited (*.csv)" Value="3" />
						<dx:ListEditItem Text="PDF (*.pdf)" Value="4" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td>
				<dx:ASPxButton ID="btnDownload" runat="server" Text="Download" OnClick="btnDownload_Click" />
			</td>
		</tr>
	</table>
	<div class="Separator">
	</div>
	<table id="mainTable" style="width: 100%;">
		<tr>
			<td style="vertical-align: top; vertical-align: top; width: 100%">
				<dx:ASPxPageControl ID="ASPxPageControl1" ClientInstanceName="ASPxPageControl1" runat="server"
					ActiveTabIndex="0" Width="100%" EnableViewState="False" EnableHierarchyRecreation="True"
					BorderRight-BorderWidth="0" BorderRight-BorderStyle="None">
					<ClientSideEvents ActiveTabChanged="function(s, e) { }" ActiveTabChanging="function(s, e) {  }"
						Init="function(s, e) {}" TabClick="function(s, e) { }" />
					<ContentStyle Paddings-PaddingRight="0" Paddings-PaddingTop="1px" Paddings-PaddingBottom="1px">
					</ContentStyle>
					<TabPages>
						<dx:TabPage Name="C#" Text="C#">
							<ContentCollection>
								<dx:ContentControl ID="ContentControl1" runat="server">
									<div style="overflow: auto; height: 180px;">
										<code runat="server" id="CSharpCodeHolder" clientidmode="Static"></code>
									</div>
								</dx:ContentControl>
							</ContentCollection>
						</dx:TabPage>
						<dx:TabPage Name="VB" Text="VB">
							<ContentCollection>
								<dx:ContentControl ID="ContentControl2" runat="server" ClientIDMode="Static">
									<div style="overflow: auto; height: 180px;">
										<code runat="server" id="VBCodeHolder" clientidmode="Static"></code>
									</div>
								</dx:ContentControl>
							</ContentCollection>
						</dx:TabPage>
					</TabPages>
				</dx:ASPxPageControl>
			</td>
			<td rowspan="2">
				<div id="treeListContainer" style="height: 550px; overflow: scroll; width: 215px;
					padding: 0; margin: 0;">
					<dx:ASPxTreeList ID="ASPxTreeList1" ClientInstanceName="treeList" runat="server"
						Height="334px" Width="175px" OnCustomDataCallback="treeList_CustomDataCallback">
						<Columns>
							<dx:TreeListTextColumn FieldName="Name">
								<PropertiesTextEdit EncodeHtml="false" />
							</dx:TreeListTextColumn>
						</Columns>
						<SettingsBehavior AllowFocusedNode="True" />
						<Settings ShowColumnHeaders="false" />
						<ClientSideEvents CustomDataCallback="function(s, e) {
							UpdateCodePreview(s, e);

						 }" FocusedNodeChanged="function(s, e) { 
							var key = treeList.GetFocusedNodeKey();
							treeList.PerformCustomDataCallback(key); 
						}" />
					</dx:ASPxTreeList>
				</div>
			</td>
		</tr>
		<tr>
			<td id="previewFrameContainer" style="vertical-align: top; width: 100%; height: 340px;
				padding-right: 2px;">
				<iframe id="previewFrame" src="ChartsApi.aspx?preview=0" class="borderedContent" style="width: 100%;
					height: 340px;"></iframe>
			</td>
		</tr>
	</table>
</asp:Content>