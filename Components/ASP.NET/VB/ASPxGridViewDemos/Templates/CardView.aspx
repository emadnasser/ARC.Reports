<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CardView.aspx.vb"
	Inherits="Templates_CardView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.templateTable
		{
			border-collapse: collapse;
			width: 100%;
		}
		.templateTable td
		{
			border: solid 1px #C2D4DA;
			padding: 6px;
		}
		.templateTable td.value
		{
			font-weight: bold;            
		}
		.imageCell 
		{
			width: 160px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxCheckBox runat="server" ID="chkShowHeaders" Checked="true" Text="Show Headers"
		AutoPostBack="true" OnCheckedChanged="chkShowHeaders_CheckedChanged" />
	<br />
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="EmployeesDataSource"
		KeyFieldName="EmployeeID" Width="100%" EnableRowsCache="False">
		<Columns>
			<dx:GridViewDataColumn FieldName="FirstName" VisibleIndex="1" />
			<dx:GridViewDataColumn FieldName="LastName" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="BirthDate" VisibleIndex="3" />
			<dx:GridViewDataColumn FieldName="Title" VisibleIndex="4" />
			<dx:GridViewDataColumn FieldName="HireDate" VisibleIndex="5" />
		</Columns>
		<SettingsPager PageSize="5" />
		<Templates>
			<DataRow>
				<div style="padding: 5px">
					<table class="templateTable">
						<tr>
							<td class="imageCell" rowspan="4">
								<dx:ASPxBinaryImage ID="ASPxBinaryImage1" runat="server" Value='<%#Eval("Photo")%>' />
							</td>
							<td>
								First Name
							</td>
							<td class="value">
								<dx:ASPxLabel ID="lblFirstName" runat="server" Text='<%#Eval("FirstName")%>' />
							</td>
							<td>
								Last Name
							</td>
							<td class="value">
								<dx:ASPxLabel ID="lblLastName" runat="server" Text='<%#Eval("LastName")%>' />
							</td>
						</tr>
						<tr>
							<td>
								Title
							</td>
							<td  class="value" colspan="3">
								<dx:ASPxLabel ID="lblTitle" runat="server" Text='<%#Eval("Title")%>' />
							</td>
						</tr>
						<tr>
							<td>
								Birth Date
							</td>
							<td class="value">
								<dx:ASPxLabel ID="lblBirthDate" runat="server" Text='<%#Eval("BirthDate", "{0:d}")%>' />
							</td>
							<td>
								Hire Date
							</td>
							<td class="value">
								<dx:ASPxLabel ID="lblHireDate" runat="server" Text='<%#Eval("HireDate", "{0:d}")%>' />
							</td>
						</tr>
						<tr>
							<td colspan="4" style="vertical-align: top;">
								<dx:ASPxLabel ID="lblNotes" runat="server" Text='<%#Eval("Notes")%>' />
							</td>
						</tr>
					</table>
				</div>
			</DataRow>
		</Templates>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>