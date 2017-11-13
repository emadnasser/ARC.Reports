<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProgressBar.aspx.vb"
	Inherits="ASPxProgressBar_ProgressBar" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" AutoGenerateColumns="False"
		DataSourceID="TasksDataSource" KeyFieldName="ID" Width="100%">
		<Columns>
			<dx:GridViewDataTextColumn FieldName="Name" VisibleIndex="0" />
			<dx:GridViewDataTextColumn FieldName="Priority" VisibleIndex="1" />
			<dx:GridViewDataTextColumn FieldName="Status" VisibleIndex="2" />            
			<dx:GridViewDataProgressBarColumn FieldName="Complete" VisibleIndex="3" />
			<dx:GridViewDataTextColumn FieldName="Assigned_To" VisibleIndex="4" />            
		</Columns>
	</dx:ASPxGridView>
	<ef:EntityDataSource runat="server" ID="TasksDataSource" ContextTypeName="EditorsSampleDBContext" EntitySetName="Tasks" />
</asp:Content>