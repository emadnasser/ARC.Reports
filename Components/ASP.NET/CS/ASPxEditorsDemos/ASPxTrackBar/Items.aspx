<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Items.aspx.cs" Inherits="ASPxTrackBar_Items" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function OnPositionChanged(s, e) {
            updateItems(s);
        }
        function OnInit(s, e) {
            updateItems(s);
        }
        function updateItems(trackBar) {
            var trackBarPosition = trackBar.GetPosition();
            var itemContainer = document.getElementById('itemContainer');
            var itemCount = trackBar.GetItemCount();
            for (var i = 0; i < itemCount; i++) {
                var itemElement = ASPxClientUtils.GetChildByTagName(itemContainer, "DIV", i);
                itemElement.style.display = i == trackBarPosition ? "" : "none";
            }
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server"> 
    <div style="margin: auto; width: 480px" id="itemContainer">
        <asp:Repeater runat="server" DataSourceID="TimeLapse">
            <ItemTemplate>
                <div style="display: none">
                    <dx:ASPxImage runat="server" Width="480" Height="270" ImageUrl='<%#GetImageUrl(Eval("DayNum")) %>' />
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <br /><br /><br />
    <div style="margin:auto; width: 400px">
        <dx:ASPxTrackBar ID="ASPxTrackBar" runat="server" DataSourceID="TimeLapse" TextField="Text"
            ToolTipField="ToolTip" ValueField="DayNum" Height="50" ValueType="System.Int32" 
            ScalePosition="Both" Position="0" Width="400">
            <ClientSideEvents PositionChanged="OnPositionChanged" Init="OnInit" />
        </dx:ASPxTrackBar>
    </div>
    <asp:XmlDataSource ID="TimeLapse" DataFile="~/App_Data/TimeLapse.xml" XPath="//Day" runat="server" />
</asp:Content>
