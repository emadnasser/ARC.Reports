<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DataBinding.aspx.vb"
	Inherits="ToolbarItems_DataBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<%--start highlighted block--%>
	<script type="text/javascript">
	// <![CDATA[
		function OnCommandExecute(s, e) {
			var value = e.parameter;
			switch (e.commandName) {
				case "InsertTemplate":
					InsertTemplate(value);
					break;
				case "InsertSmiley":
					InsertSmiley(value);
					break;
				case "InsertCustomer":
					InsertCustomer(value);
					break;
			}
		}
		function InsertTemplate(value) {
			HtmlEditor.GetSelection().SetHtml(value + " ");
		}
		function InsertSmiley(value) {
			var selection = HtmlEditor.GetSelection();
			var valueInfo = value.split("#");
			selection.SetHtml("<img style='margin-bottom:-2px;' src='../Content/Smilies/" + valueInfo[0] + ".png' alt='" + valueInfo[2] + "' title='" + valueInfo[1] + "' />");
		}
		function InsertCustomer(value) {
			HtmlEditor.GetSelection().SetHtml(value);
		}
	// ]]> 
	</script>
	<%--end highlighted block--%>
	<dx:ASPxHtmlEditor ID="DemoHtmlEditor" runat="server" Height="300px" ClientInstanceName="HtmlEditor">
		<ClientSideEvents CustomCommand="OnCommandExecute" />
		<Toolbars>
			<dx:HtmlEditorToolbar>
				<Items>
					<dx:ToolbarUndoButton>
					</dx:ToolbarUndoButton>
					<dx:ToolbarRedoButton>
					</dx:ToolbarRedoButton>
					<dx:ToolbarJustifyLeftButton BeginGroup="True">
					</dx:ToolbarJustifyLeftButton>
					<dx:ToolbarJustifyCenterButton>
					</dx:ToolbarJustifyCenterButton>
					<dx:ToolbarJustifyRightButton>
					</dx:ToolbarJustifyRightButton>
					<dx:ToolbarJustifyFullButton>
					</dx:ToolbarJustifyFullButton>
					<dx:ToolbarDropDownMenu BeginGroup="true" CommandName="InsertTemplate" ToolTip="Insert Template" DataSourceID="MenuDataSource" TextField="Name" ValueField="Text"
							BeginGroupField="BeginGroup" TooltipField="ToolTip">
						<Image Url="~/Content/Demo/Toolbar/template.png" Height="16px" Width="16px">
						</Image>
					</dx:ToolbarDropDownMenu>
					<dx:ToolbarDropDownItemPicker CommandName="InsertSmiley" SelectedItemIndex="0" ToolTip="Insert Smiley"
						ColumnCount="4" ItemHeight="24" ItemWidth="24" DataSourceID="ItemPickerDataSource" ImageUrlField="ImageUrl"
							ValueField="Value" TooltipField="Tooltip">
					</dx:ToolbarDropDownItemPicker>
					<dx:ToolbarComboBox CommandName="InsertCustomer" ToolTip="Insert Customer" DefaultCaption="Customers">
						<PropertiesComboBox DataSourceID="ComboBoxDataSource" ValueField="Name" TextField="Name">
						</PropertiesComboBox>
					</dx:ToolbarComboBox>
				</Items>
			</dx:HtmlEditorToolbar>
		</Toolbars>
	</dx:ASPxHtmlEditor>
	<asp:XmlDataSource ID="MenuDataSource" runat="server" DataFile="~/App_Data/MenuData.xml"
		TransformFile="~/App_Data/MenuData.xslt" XPath="//Templates/*" />
	<asp:XmlDataSource ID="ItemPickerDataSource" runat="server" DataFile="~/App_Data/ItemPickerData.xml"
		XPath="//Smilies/*" />
	<asp:XmlDataSource ID="ComboBoxDataSource" runat="server" DataFile="~/App_Data/ComboBoxData.xml"
		XPath="//Customers/*" />
</asp:Content>