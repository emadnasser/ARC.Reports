<%@ Control Language="vb" AutoEventWireup="true" CodeFile="InsertTemplateForm.ascx.vb"
	Inherits="Features_InsertTemplateForm" %>
<dx:ASPxLoadingPanel ID="ASPxLoadingPanel1" runat="server" ClientInstanceName="loadingPanel">
</dx:ASPxLoadingPanel>
<dx:ASPxGridView ID="ASPxGridView1" runat="server" DataSourceID="XmlDataSource1"
	AutoGenerateColumns="False" Width="400px" ClientInstanceName="templatesGrid"
	KeyFieldName="Name" KeyboardSupport="True">
	<Columns>
		<dx:GridViewDataTextColumn FieldName="Name" Visible="False" VisibleIndex="0">
		</dx:GridViewDataTextColumn>
		<dx:GridViewDataImageColumn FieldName="ImageUrl" VisibleIndex="0">
		</dx:GridViewDataImageColumn>
		<dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="1" Width="100%">
		</dx:GridViewDataTextColumn>
		<dx:GridViewDataTextColumn FieldName="Html" Visible="False" VisibleIndex="2">
		</dx:GridViewDataTextColumn>
	</Columns>
	<SettingsBehavior AllowFocusedRow="True" />
	<SettingsPager Mode="ShowAllRecords">
	</SettingsPager>
	<Settings ShowColumnHeaders="False" />
	<ClientSideEvents RowDblClick="OnGridRowDblClick" />
</dx:ASPxGridView>
<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/InsertTemplateData.xml"
	TransformFile="~/App_Data/InsertTemplateData.xsl" XPath="//Templates/*"></asp:XmlDataSource>
<div style="margin-top: 10px">
	<dx:ASPxCheckBox ID="OverwriteCheckBox" runat="server" Checked="True" Text="Overwrite content"
		ClientInstanceName="overwriteCheckBox">
	</dx:ASPxCheckBox>
</div>