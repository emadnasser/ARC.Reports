<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Focusing.aspx.vb" Inherits="Focusing" %>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="CustomHeadHolder">
	<%--start highlighted block--%>
	<script type="text/javascript">
		function OnFocusedCardChanged() {
			cardView.GetCardValues(cardView.GetFocusedCardIndex(), 'FirstName;LastName;HomePhone;Title;Notes', OnGetCardValues);
		}
		function OnGetCardValues(values) {
			var editors = [FirstName, LastName, Phone, Title, Notes];
			for (var i = 0; i < editors.length; i++) {
				var editor = editors[i];
				editor.SetValue(values[i]);
			}
		}
	</script>
	 <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCardView ID="CardView" ClientInstanceName="cardView" runat="server" DataSourceID="EmployeesDataSource" EnableCardsCache="false"
		Width="100%" KeyFieldName="EmployeeID">
		<ClientSideEvents FocusedCardChanged="OnFocusedCardChanged" />
		<SettingsBehavior AllowFocusedCard="true" />
		<SettingsPager>
			<settingstablelayout columncount="4" rowsperpage="1" />
		</SettingsPager>
		<CardLayoutProperties ColCount="2">
			<Items>
				<dx:CardViewColumnLayoutItem ColumnName="Photo" ShowCaption="False" ColSpan="2" HorizontalAlign="Center" />
				<dx:CardViewColumnLayoutItem ShowCaption="False" HorizontalAlign="Center">
					<Template>
						<span>
							<%#Eval("FirstName")%>&nbsp;<%#Eval("LastName")%></span>
					</Template>
				</dx:CardViewColumnLayoutItem>
			</Items>
		</CardLayoutProperties>
		<Columns>
			<dx:CardViewBinaryImageColumn FieldName="Photo">
				<PropertiesBinaryImage ImageWidth="150px" ImageHeight="150px" />
			</dx:CardViewBinaryImageColumn>
			<dx:CardViewColumn FieldName="FirstName" />
			<dx:CardViewColumn FieldName="LastName" />
			<dx:CardViewColumn FieldName="HomePhone" Visible="false" />
			<dx:CardViewColumn FieldName="Title" Visible="false" />
			<dx:CardViewColumn FieldName="Notes" Visible="false" />
		</Columns>
	</dx:ASPxCardView>
	<dx:ASPxFormLayout ID="Details" ClientInstanceName="Details" runat="server" Width="100%">
		<Items>
			<dx:LayoutGroup ColCount="2" Caption="Details">
				<Items>
					<dx:LayoutItem FieldName="FirstName">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxLabel ID="FirstName" ClientInstanceName="FirstName" runat="server" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem FieldName="LastName">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxLabel ID="LastName" ClientInstanceName="LastName" runat="server" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem FieldName="HomePhone">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxLabel ID="HomePhone" ClientInstanceName="Phone" runat="server" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem FieldName="Title">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxLabel ID="Title" ClientInstanceName="Title" runat="server" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
					<dx:LayoutItem FieldName="Notes" ColSpan="2">
						<LayoutItemNestedControlCollection>
							<dx:LayoutItemNestedControlContainer>
								<dx:ASPxLabel ID="Notes" ClientInstanceName="Notes" runat="server" />
							</dx:LayoutItemNestedControlContainer>
						</LayoutItemNestedControlCollection>
					</dx:LayoutItem>
				</Items>
			</dx:LayoutGroup>
		</Items>
		<Styles LayoutItem-Caption-Font-Bold="true" />
	</dx:ASPxFormLayout>
	<ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>