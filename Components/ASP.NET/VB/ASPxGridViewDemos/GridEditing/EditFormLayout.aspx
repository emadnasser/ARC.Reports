<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditFormLayout.aspx.vb" Inherits="GridEditing_EditFormLayout" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentHolder" runat="server">
	<div style="width: 950px">
		<dx:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="DemoDataSource1"
		 KeyFieldName="EmployeeID" PreviewFieldName="Notes">
			<Columns>
				<dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowEditButton="true" ShowDeleteButton="true" VisibleIndex="0" />
				<dx:GridViewDataTextColumn FieldName="FirstName" VisibleIndex="1" />
				<dx:GridViewDataTextColumn FieldName="LastName" VisibleIndex="2" />
				<dx:GridViewDataDateColumn FieldName="BirthDate" VisibleIndex="3" />
				<dx:GridViewDataTextColumn FieldName="Title" Caption="Position" VisibleIndex="4" />
				<dx:GridViewDataDateColumn FieldName="HireDate" VisibleIndex="5" />
			</Columns>
			<Settings ShowPreview="true" />
			<SettingsPager PageSize="5" />
			<EditFormLayoutProperties ColCount="3">
				<Items>
					<dx:GridViewColumnLayoutItem ColumnName="FirstName">
					</dx:GridViewColumnLayoutItem>
					<dx:GridViewColumnLayoutItem ColumnName="LastName">
					</dx:GridViewColumnLayoutItem>
					<dx:GridViewColumnLayoutItem ColumnName="BirthDate">
					</dx:GridViewColumnLayoutItem>
					<dx:GridViewColumnLayoutItem ColumnName="Position" ColSpan="2">
					</dx:GridViewColumnLayoutItem>
					<dx:GridViewColumnLayoutItem Caption="Hire Date" RowSpan="2" VerticalAlign="Top">
						<Template>
							<dx:ASPxCalendar ID="hireDateCalendar" runat="server" Value='<%#Bind("HireDate")%>' />
						</Template>
					</dx:GridViewColumnLayoutItem>          
					<dx:GridViewColumnLayoutItem Caption="Notes" ColSpan="2" VerticalAlign="Top">
						<Template>
							<dx:ASPxMemo ID="notesMemo" runat="server" Width="100%" Height="253" Text='<%#Bind("Notes")%>' />
						</Template>
					</dx:GridViewColumnLayoutItem>
					<dx:EditModeCommandLayoutItem ColSpan="3" HorizontalAlign="Right" />
				</Items>
			</EditFormLayoutProperties>
		</dx:ASPxGridView>
	</div>
	<demo:DemoDataSource runat="server" ID="DemoDataSource1" IdentityKey="EmployeeID" DataSourceID="EmployeesDataSource" IsSiteMode="True" />
	<ef:EntityDataSource runat="server" ID="EmployeesDataSource"
		ContextTypeName="NorthwindContext"
		EnableDelete="True" EnableInsert="True" EnableUpdate="True"
		EntitySetName="Employees">
	</ef:EntityDataSource>
</asp:Content>