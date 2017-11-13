<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Card.aspx.vb" Inherits="Templates_Card" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="Server">
	<link href="../Templates/CSS/Card.css" rel="Stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<span style="line-height: 40px;">Move the mouse pointer over cards to see the detail information.</span>
	<dx:ASPxCardView ID="CardView" runat="server" DataSourceID="EmployeesDataSource" EnableCardsCache="false">
		<SettingsPager SettingsTableLayout-RowsPerPage="2" />
		<Columns>
			<dx:CardViewBinaryImageColumn FieldName="Photo">
				<PropertiesBinaryImage ImageWidth="150px" ImageHeight="150px" />
			</dx:CardViewBinaryImageColumn>
			<dx:CardViewColumn FieldName="FirstName" />
			<dx:CardViewColumn FieldName="LastName" />
			<dx:CardViewColumn FieldName="Title" />
			<dx:CardViewColumn FieldName="Country" />
			<dx:CardViewColumn FieldName="City" />
			<dx:CardViewColumn FieldName="Address" />
		</Columns>
		<Templates>
			<Card>
				<dx:ASPxBinaryImage ID="Photo" runat="server" Value='<%#Eval("Photo")%>' />
				<div class="info">
					<p><%#Eval("FirstName")%>&nbsp;<%#Eval("LastName")%></p>
					<span><%#Eval("Title")%></span>
					<div class="address">
						<span><%#Eval("Country")%>,&nbsp;<%#Eval("City")%></span>
						<br />
						<span><%#Eval("Address")%></span>
					</div>
				</div>
			</Card>
		</Templates>
		<Styles>
			<Card CssClass="card" />
		</Styles>
	</dx:ASPxCardView>
	<ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>