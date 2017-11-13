<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Export.aspx.vb"
	Inherits="Shaping_Export" %>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsBottomMargin">
		<tr>
			<td>
				<dx:ASPxButton ID="btnExportToPdf" runat="server" Text="Export to PDF" OnClick="btnExportToPdf_Click" />
			</td>
			<td>
				&nbsp;
			</td>
			<td>
				<dx:ASPxButton ID="btnExportToXls" runat="server" Text="Export to XLS" OnClick="btnExportToXls_Click" />
			</td>
			<td>
				&nbsp;
			</td>
			<td>
				<dx:ASPxButton ID="btnExportToXlsx" runat="server" Text="Export to XLSX" OnClick="btnExportToXlsx_Click" />
			</td>
			<td>
				&nbsp;
			</td>
			<td>
				<dx:ASPxButton ID="btnExportToRtf" runat="server" Text="Export to RTF" OnClick="btnExportToRtf_Click" />
			</td>
			<td>
				&nbsp;&nbsp;
			</td>
			<td>
				<dx:ASPxCheckBox ID="chkAutoWidth" runat="server" Text="Auto-width" />
			</td>
			<td>
				&nbsp;&nbsp;
			</td>
			<td>
				<dx:ASPxCheckBox ID="chkExpandAll" runat="server" Text="Expand all nodes">
				</dx:ASPxCheckBox>
			</td>
		</tr>
	</table>
	<dx:ASPxTreeList ID="treeList" runat="server" Width="100%" AutoGenerateColumns="False"
		DataSourceID="DepartmentsDataSource" KeyFieldName="ID" ParentFieldName="ParentID">
		<Settings GridLines="Both" ShowFooter="True" ShowGroupFooter="True" />
		<SettingsBehavior ExpandCollapseAction="NodeDblClick" />
		<Columns>
			<dx:TreeListDataColumn FieldName="DepartmentName" Caption="Department" VisibleIndex="0" />
			<dx:TreeListDataColumn FieldName="Budget" VisibleIndex="1" DisplayFormat="{0:C}" />
			<dx:TreeListDataColumn FieldName="Location" VisibleIndex="2" />
			<dx:TreeListDataColumn FieldName="Phone1" VisibleIndex="3" />
		</Columns>
		<Summary>
			<dx:TreeListSummaryItem FieldName="DepartmentName" ShowInColumn="DepartmentName" SummaryType="Count" />
			<dx:TreeListSummaryItem DisplayFormat="{0:C}" FieldName="Budget" ShowInColumn="Budget"
				SummaryType="Sum" />
		</Summary>
	</dx:ASPxTreeList>
	<dx:ASPxTreeListExporter ID="treeListExporter" runat="server" TreeListID="treeList" />
	<ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
</asp:Content>