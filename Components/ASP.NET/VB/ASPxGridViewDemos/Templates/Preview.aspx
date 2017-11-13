<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Preview.aspx.vb"
	Inherits="Templates_Preview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="EmployeesDataSource"
		KeyFieldName="EmployeeID" PreviewFieldName="Notes" Width="100%" EnableRowsCache="False">
		<Columns>
			<dx:GridViewDataColumn FieldName="FirstName" VisibleIndex="1" />
			<dx:GridViewDataColumn FieldName="Title" VisibleIndex="4" />
			<dx:GridViewDataColumn FieldName="LastName" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="BirthDate" VisibleIndex="3" />
			<dx:GridViewDataColumn FieldName="HireDate" VisibleIndex="5" />
		</Columns>
		<Templates>
			<PreviewRow>
				<table>
					<tr>
						<td style="padding-right: 12px">
							<dx:ASPxBinaryImage ID="ASPxBinaryImage1" runat="server" Value='<%#Eval("Photo")%>' />
						</td>
						<td style="vertical-align: top">
							<dx:ASPxLabel ID="lblNotes" runat="server" Text='<%#Container.Text%>' />
						</td>
					</tr>
				</table>
			</PreviewRow>
		</Templates>
		<Settings ShowPreview="true" />
		<SettingsPager PageSize="3" />
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>