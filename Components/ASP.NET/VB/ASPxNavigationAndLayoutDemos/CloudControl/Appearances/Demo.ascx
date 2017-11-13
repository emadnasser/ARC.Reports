<%@ Control Language="vb" %>
<dx:ASPxCloudControl EnableTheming="True" ID="ASPxCloudControl1" runat="server" DataSourceID="CountriesDataSource"
	NavigateUrlField="Name" NavigateUrlFormatString="javascript:void('{0}')" TextField="Name"
	ValueField="Area">
	<RankProperties>
		<dx:RankProperties />
		<dx:RankProperties />
		<dx:RankProperties />
		<dx:RankProperties />
		<dx:RankProperties />
		<dx:RankProperties />
		<dx:RankProperties />
	</RankProperties>
</dx:ASPxCloudControl>
<ef:EntityDataSource ID="CountriesDataSource" runat="server" ContextTypeName="DataContext" EntitySetName="countries" />