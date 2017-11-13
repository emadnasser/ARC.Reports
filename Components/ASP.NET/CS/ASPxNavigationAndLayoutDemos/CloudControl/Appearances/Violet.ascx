<%@ Control Language="C#" %>
<dx:ASPxCloudControl EnableTheming="False" ID="ASPxCloudControl1" runat="server"
    ItemBeginText="{" ItemEndText="}" SpacerFontSize="12px" DataSourceID="TopicsDataSource"
    Scale="Linear" ValueField="Popularity" CssFilePath="~/CloudControl/Resources/Violet/styles.css"
    CssPostfix="Violet">
    <RankProperties>
        <dx:RankProperties Font-Size="9px" ForeColor="#225C87" />
        <dx:RankProperties Font-Size="11px" ForeColor="#3A5188" />
        <dx:RankProperties Font-Size="14px" ForeColor="#663F8A" />
        <dx:RankProperties Font-Size="15px" ForeColor="#703B8B" />
        <dx:RankProperties Font-Size="21px" ForeColor="#CC138F" />
    </RankProperties>
</dx:ASPxCloudControl>
<ef:EntityDataSource ID="TopicsDataSource" runat="server" ContextTypeName="DataContext" EntitySetName="Topics" />
