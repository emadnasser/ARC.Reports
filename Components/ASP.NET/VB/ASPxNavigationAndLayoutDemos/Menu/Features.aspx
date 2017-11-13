<%@ Page Language="vb" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.vb"
	Inherits="Menu_Features" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
	<div style="float: left; width: 45%">
		<dx:ASPxMenu ID="mMain" runat="server" AllowSelectItem="True" ShowPopOutImages="True" >
			<Items>
				<dx:MenuItem Text="Home">
					<Items>
						<dx:MenuItem Text="News">
							<Items>
								<dx:MenuItem Text="For Developers">
								</dx:MenuItem>
								<dx:MenuItem Text="Website news">
								</dx:MenuItem>
							</Items>
						</dx:MenuItem>
						<dx:MenuItem Text="Our Mission">
						</dx:MenuItem>
						<dx:MenuItem Text="Our Customers">
						</dx:MenuItem>
					</Items>
				</dx:MenuItem>
				<dx:MenuItem Text="Products">
					<Items>
						<dx:MenuItem Text="Subscriptions / Packs">
						</dx:MenuItem>
						<dx:MenuItem Text=".NET Windows Forms Components">
						</dx:MenuItem>
						<dx:MenuItem Text="Reporting / Printing Suites">
						</dx:MenuItem>
						<dx:MenuItem Text="VCL Components and Tools">
						</dx:MenuItem>
						<dx:MenuItem Text="ASP.NET Components">
						</dx:MenuItem>
					</Items>
				</dx:MenuItem>
				<dx:MenuItem Text="Support">
					<Items>
						<dx:MenuItem Text="Knowledge Base">
						</dx:MenuItem>
						<dx:MenuItem Text="Documentation">
						</dx:MenuItem>
						<dx:MenuItem Text="Support Center">
						</dx:MenuItem>
						<dx:MenuItem Text="Newsgroups">
						</dx:MenuItem>
						<dx:MenuItem Text="Best Practicies">
						</dx:MenuItem>
					</Items>
				</dx:MenuItem>
			</Items>
		</dx:ASPxMenu>
	</div>
	<div style="float: right; width: 53%">
		<table class="OptionsTable">
			<tr>
				<td>
					<dx:ASPxCheckBox ID="cbAllowSelectItem" runat="server" AutoPostBack="True" Checked="True" 
						Text="AllowSelectItem" />
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxCheckBox ID="cbAutoPostBack" runat="server" AutoPostBack="True" Text="AutoPostBack" />
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxCheckBox ID="cbEnableAnimation" runat="server" AutoPostBack="True" Checked="True"
						Text="EnableAnimation" />
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxCheckBox ID="cbEnableHotTrack" runat="server" AutoPostBack="True" Checked="True"
						Text="EnableHotTrack" />
				</td>
			</tr>
		</table>
		<table class="OptionsTable">
			<tr>
				<td>
					<dx:ASPxLabel ID="lblAutoSeparators" runat="server" Text="AutoSeparators:" AssociatedControlID="ddlAutoSeparators" />
				</td>
				<td>
					<dx:ASPxComboBox SelectedIndex="2" ID="ddlAutoSeparators" runat="server" AutoPostBack="True" Width="100">
						<Items>
							<dx:ListEditItem Text="All" Value="All" />
							<dx:ListEditItem Text="RootOnly" Value="RootOnly" />
							<dx:ListEditItem Text="None" Value="None" />
						</Items>
					</dx:ASPxComboBox>
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="lblAppearAfter" runat="server" Text="AppearAfter (ms):" AssociatedControlID="tbAppearAfter" />
				</td>
				<td>
					<dx:ASPxTextBox ID="tbAppearAfter" runat="server" Width="50px" Text="300" />
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="lblDisappearAfter" runat="server" Text="DisappearAfter (ms):" AssociatedControlID="tbDisappearAfter" />
				</td>
				<td>
					<dx:ASPxTextBox ID="tbDisappearAfter" runat="server" Width="50px" Text="500" />
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="lblMaximumDisplayLevels" runat="server" Text="MaximumDisplayLevels:"
						AssociatedControlID="tbMaximumDisplayLevels" />
				</td>
				<td>
					<dx:ASPxTextBox ID="tbMaximumDisplayLevels" runat="server" Width="50px" Text="0" />
				</td>
			</tr>
			<tr>
				<td>
					<dx:ASPxLabel ID="lblOpacity" runat="server" Text="Opacity (%):" AssociatedControlID="tbOpacity" />
				</td>
				<td>
					<dx:ASPxTextBox ID="tbOpacity" runat="server" Width="50px" Text="100" />
				</td>
			</tr>
			<tr>
				<td colspan="2" class="TopPadding">
					<dx:ASPxButton ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click"
						Width="70px" />
				</td>
			</tr>
			<tr>
				<td colspan="2">
					<dx:ASPxLabel ID="lblAppearAfterError" runat="server" ForeColor="Red" Text="AppearAfter value isn't valid"
						Visible="False" />
				</td>
			</tr>
			<tr>
				<td colspan="2">
					<dx:ASPxLabel ID="lblDisappearAfterError" runat="server" ForeColor="Red" Text="DisappearAfter value isn't valid"
						Visible="False" />
				</td>
			</tr>
			<tr>
				<td colspan="2">
					<dx:ASPxLabel ID="lblMaximumDisplayError" runat="server" ForeColor="Red" Text="MaximumDisplayLevels value isn't valid"
						Visible="False" />
				</td>
			</tr>
			<tr>
				<td colspan="2">
					<dx:ASPxLabel ID="lblOpacityError" runat="server" ForeColor="Red" Text="Opacity value isn't valid"
						Visible="False" />
				</td>
			</tr>
		</table>
	</div>
</asp:Content>