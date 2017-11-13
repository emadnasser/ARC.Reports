<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Scrolling.aspx.vb" Inherits="PagingAndScrolling_Scrolling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<table class="OptionsTable BottomMargin">
		<tr>
			<td style="padding-left: 0">
				<dx:ASPxLabel ID="HorzScrollLabel" runat="server" AssociatedControlID="HorzScrollCombo"
					Text="Horizontal ScrollBar Mode:" />
			</td>
			<td>
				<dx:ASPxComboBox runat="server" ID="HorzScrollCombo" AutoPostBack="true" />
			</td>
		</tr>
		<tr>
			<td style="padding-left: 0">
				<dx:ASPxLabel ID="VertScrollLabel" runat="server" AssociatedControlID="VertScrollCombo"
					Text="Vertical ScrollBar Mode:" />
			</td>
			<td>
				<dx:ASPxComboBox runat="server" ID="VertScrollCombo" AutoPostBack="true" />
			</td>
		</tr>
	</table>
	<dx:ASPxVerticalGrid runat="server" ID="VerticalGrid" Width="100%">
		<Rows>
			<dx:VerticalGridImageRow FieldName="PhotoUrl" Caption="Photo" Fixed="true">
				<PropertiesImage ImageHeight="180" />
			</dx:VerticalGridImageRow>
			<dx:VerticalGridDataRow FieldName="Brand" RecordStyle-HorizontalAlign="Center" />
			<dx:VerticalGridDataRow FieldName="Model" RecordStyle-HorizontalAlign="Center" />
			<dx:VerticalGridCategoryRow Caption="Pricing">
				<Rows>
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
			</dx:VerticalGridCategoryRow>
			<dx:VerticalGridCategoryRow Caption="Specifications">
				<Rows>
					<dx:VerticalGridTextRow FieldName="Sensitivity" Caption="Sensitivity, dB" />
					<dx:VerticalGridTextRow FieldName="MinFrequency" Caption="Min Frequency, Hz" />
					<dx:VerticalGridTextRow FieldName="MaxFrequency" Caption="Max Frequency, Hz" />
					<dx:VerticalGridTextRow FieldName="Power" Caption="Power, MW" />
					<dx:VerticalGridTextRow FieldName="Impedance" Caption="Impendance, ohms" />
					<dx:VerticalGridCheckRow FieldName="Wireless" />
					<dx:VerticalGridCheckRow FieldName="Bluetooth" />
					<dx:VerticalGridCheckRow FieldName="SoundIsolating" />
					<dx:VerticalGridCheckRow FieldName="WaterResistant" />
					<dx:VerticalGridCheckRow FieldName="PhoneControl" />
					<dx:VerticalGridCheckRow FieldName="CarryingCase" />
					<dx:VerticalGridCheckRow FieldName="BuiltInMicrophone" />
				</Rows>
			</dx:VerticalGridCategoryRow>
			<dx:VerticalGridCategoryRow Caption="Appearance">
				<Rows>
					<dx:VerticalGridComboBoxRow FieldName="Fit" RecordStyle-HorizontalAlign="Right" />
					<dx:VerticalGridTextRow FieldName="Height" Caption="Height, in" />
					<dx:VerticalGridTextRow FieldName="Width" Caption="Width, in" />
					<dx:VerticalGridTextRow FieldName="Depth" Caption="Depth, in" />
					<dx:VerticalGridTextRow FieldName="Weight" Caption="Weight, lbs" />
				</Rows>
			</dx:VerticalGridCategoryRow>
		</Rows>
		<SettingsPager PageSize="10" />
		<Settings ShowCategoryIndents="false" HeaderAreaWidth="150" RecordWidth="200" VerticalScrollableHeight="500" />
	</dx:ASPxVerticalGrid>
</asp:Content>