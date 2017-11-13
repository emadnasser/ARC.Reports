<%@ Control Language="C#" %>
<dx:ASPxCloudControl EnableTheming="False" ID="ASPxCloudControl1" runat="server"
    DataSourceID="CountriesDataSource" MaxColor="#4887C7" MinColor="#336699" NavigateUrlField="Name"
    NavigateUrlFormatString="javascript:void('{0}')" TextField="Name" ValueField="Area"
    CssFilePath="~/CloudControl/Resources/Strict/styles.css" CssPostfix="Strict">
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
