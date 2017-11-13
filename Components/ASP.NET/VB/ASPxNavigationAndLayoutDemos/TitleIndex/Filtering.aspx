<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Filtering.aspx.vb"
	Inherits="TitleIndex_Filtering" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<table class="OptionsTable">
		<tr>
			<td>
				<dx:ASPxLabel ID="lblHorizontalPosition" EnableViewState="False" runat="server" Text="HorizontalPosition:"  AssociatedControlID="ddlHorizontalPosition"/>
			</td>
			<td>
				<dx:ASPxComboBox SelectedIndex="2" ID="ddlHorizontalPosition" runat="server" AutoPostBack="True"
					ValueType="System.String">
					<Items>
						<dx:ListEditItem Value="Left" Text="Left" />
						<dx:ListEditItem Value="Right" Text="Right" />
						<dx:ListEditItem Value="Center" Text="Center" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td colspan="3" class="LeftPadding">
				<dx:ASPxCheckBox ID="cbSoftFiltering" runat="server" AutoPostBack="True" CssClass="DemoCheckBox"
					Checked="False" Text="SoftFiltering" />
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxLabel ID="lblVerticalPosition" EnableViewState="False" runat="server" Text="VerticalPosition:" AssociatedControlID="ddlVerticalPosition"/>
			</td>
			<td>
				<dx:ASPxComboBox SelectedIndex="0" ID="ddlVerticalPosition" runat="server" AutoPostBack="True"
					ValueType="System.String">
					<Items>
						<dx:ListEditItem Value="BelowIndexPanel" Text="BelowIndexPanel" />
						<dx:ListEditItem Value="AboveIndexPanel" Text="AboveIndexPanel" />
					</Items>
				</dx:ASPxComboBox>
			</td>
			<td class="LeftPadding" style="white-space:nowrap">
				<dx:ASPxLabel ID="lblDelay" EnableViewState="False" runat="server" 
					Text="Delay (ms):" />
			</td>
			<td>
				<dx:ASPxSpinEdit ID="seDelay" MaxValue="100000" runat="server" Height="21px" Width="50px"
					Number="0">
					<SpinButtons ShowIncrementButtons="False" />
				</dx:ASPxSpinEdit>
			</td>
			<td style="width: 100%; padding-left: 3px;">
				<dx:ASPxButton ID="btnApply" runat="server" Text="Apply" Width="70px" OnClick="btnApply_Click" />
			</td>
		</tr>
	</table>
	<dx:ASPxTitleIndex CssClass="InfoPanelIndent" ID="titleIndex" runat="server"
		DataSourceID="CountryLocationsDataSource" Width="500px">
		<Columns>
			<dx:TitleIndexColumn />
		</Columns>
		<GroupContentStyle ItemSpacing="2px">
		</GroupContentStyle>
	</dx:ASPxTitleIndex>
	<ef:EntityDataSource ID="CountryLocationsDataSource" runat="server" ContextTypeName="DataContext" EntitySetName="CountryLocations" />
</asp:Content>