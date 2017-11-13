<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditFormTemplate.aspx.vb"
	Inherits="Editing_EditFormTemplate" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxCheckBox ID="chkPopEditForm" runat="server" AutoPostBack="true" Checked="true"
		Text="Use Popup Edit Form" Wrap="false" CssClass="OptionsBottomMargin" />
	<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="false" Width="100%"
		DataSourceID="ObjectDataSource1" KeyFieldName="ID" ParentFieldName="ParentID"
		OnNodeUpdating="treeList_NodeUpdating" OnNodeInserting="treeList_NodeInserting">
		<Settings GridLines="Both" />
		<SettingsBehavior ExpandCollapseAction="NodeDblClick" />
		<SettingsPopupEditForm Width="500" />
		<Templates>
			<EditForm>
				<dx:ASPxPageControl ID="tabs" runat="server" ActiveTabIndex="0" Width="100%">
					<TabPages>
						<dx:TabPage Text="Headers">
							<ContentCollection>
								<dx:ContentControl runat="server">
									<dx:ASPxTreeListTemplateReplacement runat="server" ReplacementType="Editors" />
								</dx:ContentControl>
							</ContentCollection>
						</dx:TabPage>
						<dx:TabPage Text="Message">
							<ContentCollection>
								<dx:ContentControl runat="server">
									<dx:ASPxMemo ID="message" runat="server" AutoResizeWithContainer="True" Height="200px"
										Width="100%" Text='<%#Eval("Text")%>' />
								</dx:ContentControl>
							</ContentCollection>
						</dx:TabPage>
					</TabPages>
				</dx:ASPxPageControl>
				<div style="text-align: right; padding-top: 8px">
					<dx:ASPxTreeListTemplateReplacement runat="server" ReplacementType="UpdateButton" />
					<dx:ASPxTreeListTemplateReplacement runat="server" ReplacementType="CancelButton" />
				</div>
			</EditForm>
		</Templates>
		<Columns>
			<dx:TreeListTextColumn FieldName="From" VisibleIndex="0">
				<EditFormSettings VisibleIndex="0" />
			</dx:TreeListTextColumn>
			<dx:TreeListTextColumn FieldName="Subject" VisibleIndex="1">
				<EditFormSettings VisibleIndex="2" ColumnSpan="2" />
			</dx:TreeListTextColumn>
			<dx:TreeListDateTimeColumn FieldName="DateCreated" VisibleIndex="2">
				<EditFormSettings VisibleIndex="1" />
			</dx:TreeListDateTimeColumn>
			<dx:TreeListCommandColumn ShowNewButtonInHeader="True" VisibleIndex="3">
				<EditButton Visible="True" />
				<NewButton Visible="True" />
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