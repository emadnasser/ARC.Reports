<%@ Page Title="" Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true"
	CodeFile="Compliance.aspx.vb" Inherits="Accessibility_Compliance" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomTopAreaHolder">
	<dx:SkipRepetitiveNavigationLinksControl ID="SkipRepetitiveNavigationLinksControl1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div class="dxAIFE" tabindex="0">main content</div>
	<dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="false" Width="100%" Caption="Departments"
		DataSourceID="DepartmentsDataSource" KeyFieldName="ID" ParentFieldName="ParentID" AccessibilityCompliant="true">
		<Columns>
			<dx:TreeListTextColumn FieldName="DepartmentName" Caption="Department" />
			<dx:TreeListTextColumn FieldName="Location" />
			<dx:TreeListTextColumn FieldName="Phone1" />
			<dx:TreeListTextColumn FieldName="Phone2" />
		</Columns>
		<SettingsBehavior AutoExpandAllNodes="true" />
		<SettingsSelection Enabled="True" AllowSelectAll="true" />
		<SettingsPager Mode="ShowPager" >
			<AllButton Visible="true" />
			<FirstPageButton Visible="true" />
			<LastPageButton Visible="true" />
		</SettingsPager>
	</dx:ASPxTreeList>
	<dx:AccessibilityValidatorLink ID="ValidatorLink" runat="server" />
	<ef:EntityDataSource ID="DepartmentsDataSource" runat="server" ContextTypeName="DepartmentsContext" EntitySetName="Departments" />
	<script type="text/javascript">
		if(ASPxClientUtils.ie && ASPxClientUtils.browserVersion > 7 && document.body.offsetWidth % 2 > 0)
			document.body.style.width = (document.body.offsetWidth - 1) + "px";
	</script>
</asp:Content>