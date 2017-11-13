<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Scrolling.aspx.cs" Inherits="Shaping_Scrolling" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable OptionsBottomMargin">
		<tr>
			<td>
				<dx:ASPxLabel ID="HorzScrollLabel" runat="server" AssociatedControlID="HorzScrollCombo" 
                    Text="Horizontal ScrollBar Mode:" />
			</td>
			<td>
				<dx:ASPxComboBox runat="server" ID="HorzScrollCombo" AutoPostBack="true" />
			</td>
		</tr>
        <tr>
			<td>
				<dx:ASPxLabel ID="VertScrollLabel" runat="server" AssociatedControlID="VertScrollCombo" 
                    Text="Vertical ScrollBar Mode:" />
			</td>
			<td>
				<dx:ASPxComboBox runat="server" ID="VertScrollCombo" AutoPostBack="true" />
			</td>
		</tr>
	</table>
    <dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="false" DataSourceID="NewsGroupsDataSource"
        KeyFieldName="ID" ParentFieldName="ParentID" Width="800" Border-BorderStyle="Solid">
        <Columns>
            <dx:TreeListDataColumn FieldName="From" Width="200" />
            <dx:TreeListDataColumn FieldName="Subject" Width="250" />
            <dx:TreeListDateTimeColumn FieldName="DateCreated" Width="150">
                <PropertiesDateEdit DisplayFormatString="g" />
            </dx:TreeListDateTimeColumn>
            <dx:TreeListCheckColumn FieldName="HasAttachment" Width="100" />
        </Columns>
        <Settings GridLines="Both" ScrollableHeight="300" SuppressOuterGridLines="true" />
    </dx:ASPxTreeList>
    <ef:EntityDataSource ID="NewsGroupsDataSource" runat="server" ContextTypeName="NewsGroupsContext" EntitySetName="Threads" />
</asp:Content>
