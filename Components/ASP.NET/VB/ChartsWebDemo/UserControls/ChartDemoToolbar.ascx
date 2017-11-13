<%@ Control Language="vb" AutoEventWireup="true" CodeFile="ChartDemoToolbar.ascx.vb"
	Inherits="ChartDemoToolbar" %>
<div>
	<dx:ASPxMenu ID="mnuToolbar" runat="server" ClientInstanceName="mnuToolbar" EnableViewstate="False"
		ApplyItemStyleToTemplates="True" ShowAsToolbar="true">
		<Items>
			<dx:MenuItem Name="mnuPrint" Text="" ToolTip="Print the chart">
				<Image Url="~/Content/Toolbar/BtnPrint.png" Width="16px" Height="16px" />
			</dx:MenuItem>
			<dx:MenuItem Name="mnuSaveToDisk" Text="" ToolTip="Export a chart and save it to the disk"
				BeginGroup="True">
				<Image Url="~/Content/Toolbar/BtnSave.png" Width="16px" Height="16px" />
			</dx:MenuItem>
			<dx:MenuItem Name="mnuSaveToWindow" Text="" ToolTip="Export a chart and show it in a new window">
				<Image Url="~/Content/Toolbar/BtnSaveWindow.png" Width="16px" Height="16px" />
			</dx:MenuItem>
			<dx:MenuItem Name="mnuFormat">
				<Template>
					<dx:ASPxComboBox runat="server" Width="60px" ValueType="System.String" ID="cbFormat"
						SelectedIndex="0" ClientInstanceName="cbFormat">
						<Items>
							<dx:ListEditItem Value="pdf" Text="pdf" />
							<dx:ListEditItem Value="xls" Text="xls" />
							<dx:ListEditItem Value="xlsx" Text="xlsx" />
							<dx:ListEditItem Value="rtf" Text="rtf" />
							<dx:ListEditItem Value="mht" Text="mht" />
							<dx:ListEditItem Value="png" Text="png" />
							<dx:ListEditItem Value="jpeg" Text="jpeg" />
							<dx:ListEditItem Value="bmp" Text="bmp" />
							<dx:ListEditItem Value="tiff" Text="tiff" />
							<dx:ListEditItem Value="gif" Text="gif" />
						</Items>
					</dx:ASPxComboBox>
				</Template>
				<ItemStyle>
					<Paddings Padding="2" PaddingBottom="1" />
				</ItemStyle>
			</dx:MenuItem>
			<dx:MenuItem Name="mnuAppearance" BeginGroup="True">
				<Template>
					<dx:ASPxComboBox runat="server" Width="120px" ValueType="System.String" ID="cbAppearance"
						ClientInstanceName="cbAppearance" Caption="Chart&nbsp;Appearance">
						<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Appearance&quot;); }" />
					</dx:ASPxComboBox>
				</Template>
				<ItemStyle>
					<Paddings PaddingTop="2" PaddingBottom="1" PaddingLeft="16" />
				</ItemStyle>
			</dx:MenuItem>
			<dx:MenuItem Name="mnuPalette">
				<Template>
					<dx:ASPxComboBox runat="server" Width="120px" ValueType="System.String" ID="cbPalette"
						ClientInstanceName="cbPalette" Caption="Palette">
						<ClientSideEvents SelectedIndexChanged="function(s, e) { chart.PerformCallback(&quot;Palette&quot;); }" />
					</dx:ASPxComboBox>
				</Template>
				<ItemStyle>
					<Paddings PaddingTop="2" PaddingBottom="1" PaddingLeft="18"/>
				</ItemStyle>
			</dx:MenuItem>
		</Items>
		<ClientSideEvents ItemClick="function(s, e) {
	chart.GetPrintOptions().SetSizeMode('Zoom');
	if (e.item.name == 'mnuPrint')
		chart.Print();
	if (e.item.name == 'mnuSaveToDisk')
		chart.SaveToDisk(cbFormat.GetText());
	if (e.item.name == 'mnuSaveToWindow')
		chart.SaveToWindow(cbFormat.GetText());
}" />
	</dx:ASPxMenu>
</div>
<br />