<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeFile="Example.aspx.cs"
    Inherits="Callback_Example" %>
<asp:Content ID="localCss" runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <style type="text/css">
        .rssFeed
        {
            background-color: #D7E4F2;
            border-top: 1px solid #FFFFFF;
            padding: 13px;
        }
        .rssFeed.Active
        {
            font-weight: bold;
            background-color: #F3F3F3;
        }
        .rssFeed a
        {
            color: #000000;
            text-decoration: none;
            float: left;
            padding: 1px 0 0 10px;
            outline: 0 none;
        }
        .titleTxt
        {
            float: left;
            padding: 1px 0 0 10px;
        }
        .rssFeed a:hover
        {
            text-decoration: underline;
        }
        .feedImg
        {
            background-image: url('Images/rss-inactive.png');
            width: 16px;
            height: 16px;
            float: left;
        }
        .Active .feedImg
        {
            background-image: url('Images/rss-active.png');
        }
        .loadingPanel
        {
            height: 20px;
            padding: 17px 0 0 290px;
        }
        .loadingTxt
        {
            font-weight: normal;
            padding: 1px 0 0 2px;
            color: #A0A0A0;
            font-style: italic;
            float: left;
        }
        .details
        {
            padding: 10px 26px 3px 26px;
            font-weight: normal;
        }
        .clear
        {
            display: block;
            clear: both;
            height: 0;
            width: 0;
            font-size: 0;
            line-height: 0;
            overflow: hidden;
            visibility: hidden;
        }
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        function ShowDetails(feedID) {
            var strFeedID = feedID.toString();
            var feedContainer = document.getElementById("feed" + strFeedID);           
            var feedTitleLink = document.getElementById("titleLink" + strFeedID);
            var feedTitleTxt = document.getElementById("titleTxt" + strFeedID);
            var loadingPanel = document.getElementById("lp" + strFeedID);
            feedContainer.className += " Active";
            feedTitleLink.style.display = "none";
            feedTitleTxt.style.display = "";
            loadingPanel.style.display = "";
            Callback1.PerformCallback(feedID);
        }
        function OnCallbackComplete(s, e) {
            var strFeedID = e.parameter.toString();
            var loadingPanel = document.getElementById("lp" + strFeedID);
            var detailsContainer = document.getElementById("details" + strFeedID);
            loadingPanel.style.display = "none";
            detailsContainer.style.display = "";
            detailsContainer.innerHTML = e.result;
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="XmlDataSource1" EnableViewState="false">
        <ItemTemplate>
            <div id="feed<%# Eval("newsID") %>" class="rssFeed">
                <div>
                    <dx:ASPxImage runat="server" AlternateText="rss" CssClass="feedImg" />
                    <a id="titleLink<%# Eval("newsID") %>" href="javascript:ShowDetails(<%# Eval("newsID") %>)"
                        style="float: left;">
                        <%# Eval("Title") %>
                    </a><span id="titleTxt<%# Eval("newsID") %>" class="titleTxt" style="display: none;">
                        <%# Eval("Title") %>
                    </span><b class="clear"></b>
                </div>
                <div id="lp<%# Eval("newsID") %>" class="loadingPanel" style="display: none;">
                    <img src="Images/loading.gif" alt="loading" style="float: left" />
                    <div class="loadingTxt">
                        Loading&hellip;</div>
                    <b class="clear"></b>
                </div>
                <div id="details<%# Eval("newsID") %>" class="details" style="display: none;">
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="Callback1"
        OnCallback="ASPxCallback1_Callback">
        <ClientSideEvents CallbackComplete="OnCallbackComplete" />
    </dx:ASPxCallback>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/WebSiteNewsRSS.xml"
        XPath="/items/*" TransformFile="~/App_Data/CallbackRSS.xslt" />
</asp:Content>
