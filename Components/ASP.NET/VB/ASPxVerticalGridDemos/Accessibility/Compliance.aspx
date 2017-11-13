<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Compliance.aspx.vb" Inherits="Accessibility_Compliance" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomTopAreaHolder">
	<dx:SkipRepetitiveNavigationLinksControl ID="SkipRepetitiveNavigationLinksControl1" runat="server" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
	<dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="HeadphonesDataSource" Width="100%" 
		KeyFieldName="ID" AccessibilityCompliant="true">
		<Rows>
			<dx:VerticalGridCommandRow ShowSelectCheckbox="true" />
			<dx:VerticalGridImageRow FieldName="PhotoUrl" Caption="Photo">
				<PropertiesImage ImageHeight="180" />
			</dx:VerticalGridImageRow>
			<dx:VerticalGridDataRow FieldName="Brand" RecordStyle-HorizontalAlign="Center" />
			<dx:VerticalGridDataRow FieldName="Model" RecordStyle-HorizontalAlign="Center" />
			<dx:VerticalGridDataRow FieldName="Rating" RecordStyle-HorizontalAlign="Center">
				<DataItemTemplate>
					<dx:ASPxRatingControl runat="server" Value="<%#Convert.ToDecimal(Container.Text)%>" ReadOnly="true" AccessibilityCompliant="true" />
				</DataItemTemplate>
			</dx:VerticalGridDataRow>
			<dx:VerticalGridTextRow FieldName="Price">
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:VerticalGridTextRow>
			<dx:VerticalGridTextRow FieldName="Discount">
				<RecordStyle ForeColor="Red" />
				<PropertiesTextEdit DisplayFormatString="{0}%" />
			</dx:VerticalGridTextRow>
			<dx:VerticalGridTextRow FieldName="Total" UnboundType="Decimal" UnboundExpression="[Price]- [Price] * [Discount] / 100">
				<RecordStyle Font-Bold="true" />
				<PropertiesTextEdit DisplayFormatString="c" />
			</dx:VerticalGridTextRow>
		</Rows>
		<Settings HeaderAreaWidth="100" RecordWidth="200" />
		<SettingsPager PageSize="4">
			<AllButton Visible="true" />
			<FirstPageButton Visible="true" />
			<LastPageButton Visible="true" />
		</SettingsPager>
	</dx:ASPxVerticalGrid>
	<dx:AccessibilityValidatorLink ID="ValidatorLink" runat="server" />
	<asp:ObjectDataSource ID="HeadphonesDataSource" runat="server" SelectMethod="SelectHeadphones" TypeName="HeadphonesDataProvider" />
</asp:Content>