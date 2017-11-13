<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="TwoWayBinding.aspx.vb"
	Inherits="GridEditing_TwoWayBinding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="DemoDataSource1"
		KeyFieldName="EmployeeID" AutoGenerateColumns="False" Width="100%" EnableRowsCache="False">
		<Columns>
			<dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowEditButton="true" VisibleIndex="0" />
			<dx:GridViewDataTextColumn FieldName="FirstName" VisibleIndex="1" />
			<dx:GridViewDataColumn FieldName="LastName" VisibleIndex="2" />
			<dx:GridViewDataColumn FieldName="Title" VisibleIndex="4" />
			<dx:GridViewDataMemoColumn FieldName="Notes" Visible="False" />
			<dx:GridViewDataColumn FieldName="BirthDate" VisibleIndex="3" />
			<dx:GridViewDataColumn FieldName="HireDate" VisibleIndex="5" />
		</Columns>
		<SettingsPager Mode="ShowAllRecords" />
		<Templates>
			<EditForm>
				<table class="OptionsTable" style="width: 100%">
					<tr>
<%
						   If (Not grid.IsNewRowEditing) Then
%>
						<td rowspan="4" style="vertical-align: top">
							<div style="border: solid 1px #c0c0c0; padding: 2px;">
								<dx:ASPxBinaryImage ID="ASPxBinaryImage1" runat="server" Value='<%#Eval("Photo")%>'>
								</dx:ASPxBinaryImage>
							</div>
						</td>
<%
						   End If
%>
						<td style="white-space: nowrap">
							First Name
						</td>
						<td style="width: 50%">
							<dx:ASPxTextBox runat="server" ID="edFirst" Text='<%#Bind("FirstName")%>' Width="100%">
							</dx:ASPxTextBox>
						</td>
						<td style="white-space: nowrap">
							Last Name
						</td>
						<td style="width: 50%">
							<dx:ASPxTextBox runat="server" ID="edLast" Text='<%#Bind("LastName")%>' Width="100%">
							</dx:ASPxTextBox>
						</td>
					</tr>
					<tr>
						<td>
							Title
						</td>
						<td style="width: 100%" colspan="3">
							<dx:ASPxTextBox runat="server" ID="edTitle" Text='<%#Bind("Title")%>' Width="100%">
							</dx:ASPxTextBox>
						</td>
					</tr>
					<tr>
						<td style="white-space: nowrap">
							Birth Date
						</td>
						<td style="width: 50%">
							<dx:ASPxDateEdit runat="server" ID="edBirth" Value='<%#Bind("BirthDate")%>' Width="100%">
							</dx:ASPxDateEdit>
						</td>
						<td style="white-space: nowrap">
							Hire Date
						</td>
						<td style="width: 50%">
							<dx:ASPxDateEdit runat="server" ID="edHire" Value='<%#Bind("HireDate")%>' Width="100%">
							</dx:ASPxDateEdit>
						</td>
					</tr>
					<tr>
						<td colspan="4">
							<dx:ASPxMemo runat="server" ID="edNotes" Text='<%#Bind("Notes")%>' Width="100%"
								Height="100px">
							</dx:ASPxMemo>
						</td>
					</tr>
				</table>                
				<div style="text-align: right; padding: 2px">
					<dx:ASPxGridViewTemplateReplacement ID="UpdateButton" ReplacementType="EditFormUpdateButton"
						runat="server">
					</dx:ASPxGridViewTemplateReplacement>
					<dx:ASPxGridViewTemplateReplacement ID="CancelButton" ReplacementType="EditFormCancelButton"
						runat="server">
					</dx:ASPxGridViewTemplateReplacement>
				</div>
			</EditForm>
		</Templates>
	</dx:ASPxGridView>
	<demo:DemoDataSource runat="server" ID="DemoDataSource1" DataSourceID="EmployeesDataSource" IdentityKey="EmployeeID"></demo:DemoDataSource>
	<ef:EntityDataSource runat="server" ID="EmployeesDataSource"
		ContextTypeName="NorthwindContext"
		EnableDelete="True" EnableInsert="True" EnableUpdate="True"
		EntitySetName="Employees">
	</ef:EntityDataSource>
</asp:Content>