<%@ Control Language="C#" %>
<dx:ASPxCloudControl EnableTheming="False" ID="ASPxCloudControl1" runat="server"
    MaxColor="#FECC32" MinColor="#FECC32" DataSourceID="VideoClipsDataSource" TextField="CategoryName"
    ValueField="Popularity" CssFilePath="~/CloudControl/Resources/Technology/styles.css"
    CssPostfix="Technology">
    <RankProperties>
        <dx:RankProperties />
        <dx:RankProperties />
        <dx:RankProperties />
        <dx:RankProperties />
        <dx:RankProperties />
        <dx:RankProperties />
    </RankProperties>
</dx:ASPxCloudControl>
<ef:EntityDataSource ID="VideoClipsDataSource" runat="server" ContextTypeName="DataContext" EntitySetName="VideoClips" />
