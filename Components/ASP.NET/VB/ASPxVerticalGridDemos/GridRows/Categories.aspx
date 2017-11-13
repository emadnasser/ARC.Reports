<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Categories.aspx.vb" Inherits="PagingAndScrolling_Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
	<dx:ASPxCheckBox runat="server" ID="chbEnableAnimation" Text="Enable row expanding animation" Checked="true" AutoPostBack="true"></dx:ASPxCheckBox>
	<dx:ASPxCheckBox runat="server" ID="chbAllowExpanding" Text="Allow expanding" Checked="true" AutoPostBack="true"></dx:ASPxCheckBox>
	<dx:ASPxCheckBox runat="server" ID="chbShowIndents" Text="Show category indents" Checked="false" AutoPostBack="true"></dx:ASPxCheckBox>
	<dx:ASPxCheckBox runat="server" ID="chbEnableCallbackMode" Text="Enable callback mode" Checked="false" AutoPostBack="true"></dx:ASPxCheckBox>
	<br />
	<dx:ASPxVerticalGrid runat="server" ID="VerticalGrid" Width="100%">
		<Rows>
			<dx:VerticalGridImageRow FieldName="PhotoUrl" Caption="Photo">
				<PropertiesImage ImageHeight="180" />
			</dx:VerticalGridImageRow>
			<dx:VerticalGridDataRow FieldName="Brand" RecordStyle-HorizontalAlign="Center" />
			<dx:VerticalGridDataRow FieldName="Model" RecordStyle-HorizontalAlign="Center" />
			<dx:VerticalGridCategoryRow Caption="Reviews">
				<Rows>
					<dx:VerticalGridDataRow FieldName="Rating" RecordStyle-HorizontalAlign="Center">
						<DataItemTemplate>
							<dx:ASPxRatingControl runat="server" Value="<%#Convert.ToDecimal(Container.Text)%>" ReadOnly="true" />
						</DataItemTemplate>
					</dx:VerticalGridDataRow>
					<dx:VerticalGridHyperLinkRow FieldName="ReviewCount" Caption="Reviews" RecordStyle-HorizontalAlign="Center">
						<PropertiesHyperLinkEdit NavigateUrlFormatString="javascript:void(0)" DisplayFormatString="{0} reviews" />
					</dx:VerticalGridHyperLinkRow>
				</Rows>
			</dx:VerticalGridCategoryRow>
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
				</Rows>
			</dx:VerticalGridCategoryRow>
			<dx:VerticalGridCategoryRow Caption="Appearance" Expanded="false">
				<Rows>
					<dx:VerticalGridComboBoxRow FieldName="Fit" RecordStyle-HorizontalAlign="Right" />
					<dx:VerticalGridTextRow FieldName="Height" Caption="Height, in" />
					<dx:VerticalGridTextRow FieldName="Width" Caption="Height, in" />
					<dx:VerticalGridTextRow FieldName="Depth" Caption="Depth, in" />
					<dx:VerticalGridTextRow FieldName="Weight" Caption="Weight, lbs" />
				</Rows>
			</dx:VerticalGridCategoryRow>
		</Rows>
		<Settings ShowCategoryIndents="false" HeaderAreaWidth="180" />
	</dx:ASPxVerticalGrid>
</asp:Content>