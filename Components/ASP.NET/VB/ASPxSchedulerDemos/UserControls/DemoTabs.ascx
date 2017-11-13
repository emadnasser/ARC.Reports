<%@ Control Language="vb" AutoEventWireup="true" CodeFile="DemoTabs.ascx.vb" Inherits="UserControls_DemoTabs" %>
<dx:ASPxPageControl ID="DemoPageControl" ClientInstanceName="DemoPageControl" CssClass="DemoPageControl" runat="server" EnableTheming="false"
	EnableViewState="false" Width="100%" EnableCallBacks="True" EnableTabScrolling="true" TabAlign="Justify">
	<Paddings Padding="0" />
	<TabStyle Height="29px">
	</TabStyle>
	<TabPages>
		<dx:TabPage Name="Description" Text="Description">
			<ContentCollection>
				<dx:ContentControl>
					<div class="TextContent">
						<%=Utils.CurrentDemo.Description%>
<%
						   If Utils.CurrentDemoPage.SeeAlsoLinks.Count > 0 Then
%>
						<br />
						<span class="SeeAlso">See Also:</span>
						<ul>
<%
							   For Each sa In Utils.CurrentDemoPage.SeeAlsoLinks
%>
							<li><a href="<%=sa.Url%>"><%=sa.Title%></a></li>
<%
							   Next sa
%>
						</ul>
<%
						   End If
%>
					</div>
				</dx:ContentControl>
			</ContentCollection>
		</dx:TabPage>
	</TabPages>
	<ClientSideEvents ActiveTabChanged="DXDemo.HightlightedCode.DemoPageControl_OnActiveTabChanged"/>
</dx:ASPxPageControl>