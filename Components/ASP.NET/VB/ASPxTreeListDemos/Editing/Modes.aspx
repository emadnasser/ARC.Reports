<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Modes.aspx.vb"
	Inherits="Editing_Modes" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<table class="OptionsTable OptionsBottomMargin">
		<tr>
			<td>
				<dx:ASPxComboBox ID="cmbMode" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cmbMode_SelectedIndexChanged"
					ValueType="System.Int32" Caption="Mode"/>
			</td>
			<td style="width: 100%">
			</td>
			<td>
				<dx:ASPxCheckBox ID="chkDragging" runat="server" AutoPostBack="true" Checked="true"
					Text="Allow node dragging" Wrap="false" />
			</td>
		</tr>
	</table>
	<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="false" Width="100%"
		DataSourceID="ObjectDataSource1" KeyFieldName="ID" ParentFieldName="ParentID">
		<Settings GridLines="Both" />
		<SettingsBehavior ExpandCollapseAction="NodeDblClick" />
		<SettingsEditing Mode="EditFormAndDisplayNode" />
		<SettingsPopupEditForm Width="500" />
		<Columns>
			<dx:TreeListTextColumn FieldName="From">
				<EditFormSettings VisibleIndex="0" />
			</dx:TreeListTextColumn>
			<dx:TreeListTextColumn FieldName="Subject">
				<EditFormSettings VisibleIndex="2" ColumnSpan="2" />
			</dx:TreeListTextColumn>
			<dx:TreeListMemoColumn FieldName="Text" Visible="False">
				<EditFormSettings VisibleIndex="3" ColumnSpan="2" Visible="true" />
				<PropertiesMemo Rows="6" />
				<EditFormCaptionStyle VerticalAlign="top" />
			</dx:TreeListMemoColumn>
			<dx:TreeListDateTimeColumn FieldName="DateCreated">
				<EditFormSettings VisibleIndex="1" />
			</dx:TreeListDateTimeColumn>
			<dx:TreeListCheckColumn FieldName="HasAttachment" Caption="Has Attachment">
				<EditFormSettings ColumnSpan="2" />
				<EditFormSettings VisibleIndex="4" />
			</dx:TreeListCheckColumn>
			<dx:TreeListCommandColumn ShowNewButtonInHeader="true">
				<EditButton Visible="true" />
				<NewButton Visible="true" />
			</dx:TreeListCommandColumn>
		</Columns>
	</dx:ASPxTreeList>
	<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Thread"
		TypeName="NewsGroupDataProvider" DeleteMethod="Delete" InsertMethod="Insert"
		SelectMethod="Select" UpdateMethod="Update">
		<UpdateParameters>
			<asp:Parameter Name="ParentID" />
			<asp:Parameter Name="From" />
			<asp:Parameter Name="Subject" />
			<asp:Parameter Name="Text" />
			<asp:Parameter Name="DateCreated" />
			<asp:Parameter Name="HasAttachment" />
		</UpdateParameters>
	</asp:ObjectDataSource>
</asp:Content>