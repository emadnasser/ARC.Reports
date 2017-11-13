<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ItemTemplate.aspx.vb" Inherits="ASPxGridLookup_ItemTemplate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="CustomHeadHolder" runat="server">
	<style type="text/css">
		.templateTable td.caption 
		{
			font-weight: bold;
			padding: 0 5px 2px;
		}
		.templateContainer
		{
			margin: 8px; 
			padding: 2px;
			min-height: 100px;
			border: solid 1px #C2D4DA;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxLabel ID="CaptionLabel" runat="server" Text="Select employee (incremental filtering is on):" AssociatedControlID="GridLookup" />
	<div class="TopPadding">
		<dx:ASPxGridLookup ID="GridLookup" runat="server" DataSourceID="EmployeesDataSource" KeyFieldName="EmployeeID" Width="200px" 
					SelectionMode="Single" TextFormatString="{0} {1}">
			<ClearButton DisplayMode="OnHover"></ClearButton>
			<Columns> 
				<dx:GridViewDataColumn FieldName="FirstName" />
				<dx:GridViewDataColumn FieldName="LastName" />
			</Columns>
			<GridViewProperties EnableRowsCache="false">
				<Templates>
					<DataRow>
						<div class="templateContainer">
							<div style="float: left; margin-right: 2px;">
								<dx:ASPxBinaryImage ID="PhotoBinaryImage" runat="server" Width="100px" Height="100px" Value='<%#Eval("Photo")%>' />
							</div>
							<table class="templateTable">
								<tr><td class="caption">First Name:</td><td><%#Eval("FirstName")%></td></tr>
								<tr><td class="caption">Last Name:</td><td><%#Eval("LastName")%></td></tr>
								<tr><td class="caption">Birth Date:</td><td><%#String.Format("{0:d}",Eval("BirthDate"))%></td></tr>                                         
								<tr><td class="caption">City:</td><td><%#Eval("City")%></td></tr>                                         
								<tr><td class="caption">Region:</td><td><%#Eval("Region")%></td></tr>   
							</table>                                    
						</div>  
					</DataRow>
				</Templates>
				<Settings ShowColumnHeaders="False" VerticalScrollBarMode="Visible" VerticalScrollableHeight="300" />
				<SettingsPager Mode="ShowAllRecords" />
				<SettingsBehavior EnableRowHotTrack="True" />
			</GridViewProperties>
		</dx:ASPxGridLookup>
	</div>    
	<ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>