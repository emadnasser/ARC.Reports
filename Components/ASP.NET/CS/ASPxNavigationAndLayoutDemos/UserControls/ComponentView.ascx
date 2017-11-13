<%@ Control Language="C#" %>
<script runat="server">
    string componentGroupName;
    protected void Page_Init(object sender, EventArgs e) {
        XmlDataSource1.XPath = string.Format("/Groups/Group[@Text='{0}']/*", ComponentGroupName);
    }
    public string ComponentGroupName {
        get { return componentGroupName; }
        set { componentGroupName = value; }
    }
</script>
<dx:ASPxDataView runat="server" ID="DataView" DataSourceID="XmlDataSource1" EnableTheming="false" AllowPaging="false" Width="100%" ItemSpacing="0">
    <ItemTemplate>
        <div class="componentItem">
            <dx:ASPxImage CssClass="componentItemImage" runat="server" ID="Img" SpriteCssClass='<%# "componentImage_" + Eval("Index") %>' />
            <dx:ASPxHyperLink runat="server" ID="Text" Text='<%# Eval("Text") %>' NavigateUrl='<%# "javascript:void(" + Eval("Index") + ");" %>'
                Font-Underline="False">
            </dx:ASPxHyperLink>
        </div>
    </ItemTemplate>
    <ItemStyle BackColor="Transparent" Border-BorderWidth="0px" Height="0px" Paddings-Padding="0px" />
    <Paddings Padding="0px" />
</dx:ASPxDataView>
<asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/Components.xml" />
