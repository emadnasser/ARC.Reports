<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditModes.aspx.cs" Inherits="GridEditing_EditModes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" Runat="Server">
	<dx:ASPxComboBox runat="server" ID="ddlEditMode" AutoPostBack="true" Width="200"
		OnSelectedIndexChanged="ddlEditMode_SelectedIndexChanged" Caption="Edit Mode">
        <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
    </dx:ASPxComboBox>
    <br />
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="DemoDataSource1" KeyFieldName="CustomerID" Width="100%" EnableRowsCache="False">
        <Columns>
            <dx:GridViewCommandColumn ShowEditButton="true" VisibleIndex="0" />
            <dx:GridViewDataColumn FieldName="ContactName" VisibleIndex="1" />            
            <dx:GridViewDataColumn FieldName="CompanyName" VisibleIndex="2" />
            <dx:GridViewDataColumn FieldName="City" VisibleIndex="3" />
            <dx:GridViewDataColumn FieldName="Region" VisibleIndex="4" />
            <dx:GridViewDataColumn FieldName="Country" VisibleIndex="5" />
        </Columns>
        <SettingsPopup>
            <EditForm Width="600" />
        </SettingsPopup>
    </dx:ASPxGridView>
    <demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="CustomerID" DataSourceID="CustomersDataSource"></demo:DemoDataSource>
    <ef:EntityDataSource runat="server" ID="CustomersDataSource"
        ContextTypeName="NorthwindContext"
        EnableDelete="True" EnableInsert="True" EnableUpdate="True"
        EntitySetName="Customers">
    </ef:EntityDataSource>
</asp:Content>
