<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Validation.aspx.vb"
	Inherits="GridEditing_Validation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="ObjectDataSource1"
		KeyFieldName="Id" AutoGenerateColumns="False" Width="100%" OnHtmlRowPrepared="grid_HtmlRowPrepared"
		OnRowValidating="grid_RowValidating" OnStartRowEditing="grid_StartRowEditing">
		<Columns>
			<dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowEditButton="true" VisibleIndex="0" />
			<dx:GridViewDataTextColumn Caption="First Name" FieldName="FirstName" VisibleIndex="1" />
			<dx:GridViewDataTextColumn Caption="Last Name" FieldName="LastName" VisibleIndex="2" />
			<dx:GridViewDataTextColumn Caption="Age" FieldName="Age" VisibleIndex="3" PropertiesTextEdit-MaskSettings-Mask="99" />
			<dx:GridViewDataTextColumn Caption="E-mail" FieldName="Email" VisibleIndex="4" />
			<dx:GridViewDataDateColumn Caption="Arrival Date" FieldName="ArrivalDate" VisibleIndex="5" />
		</Columns>
	</dx:ASPxGridView>
	<asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="InMemoryPerson"
		SelectMethod="GetList" TypeName="InMemoryPersonProvider" UpdateMethod="Update" InsertMethod="Insert" />
</asp:Content>