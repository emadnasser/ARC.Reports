<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Paging.aspx.cs"
    Inherits="Shaping_Paging" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function prevButton_Click(s, e) {
            treeList.PrevPage();
        }
        function nextButton_Click(s, e) {
            treeList.NextPage();
        }
        function treeList_Init(s, e) {
            CheckButtonsEnabled();
        }
        function treeList_EndCallback(s, e) {
            CheckButtonsEnabled();
        }
        function CheckButtonsEnabled() {
            var pageIndex = treeList.GetPageIndex();
            var pageCount = treeList.GetPageCount();
            prevButton.SetEnabled(pageIndex != 0);
            nextButton.SetEnabled(pageIndex != pageCount - 1);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable" style="float: left">
        <tr>
            <td>
                <dx:ASPxLabel ID="lblPosition" runat="server" Text="Position:" AssociatedControlID="cmbPosition" Wrap="False" />
            </td>
            <td>
                <dx:ASPxComboBox SelectedIndex="0" ID="cmbPosition" runat="server" AutoPostBack="True"
                    Width="120px">
                    <Items>
                        <dx:ListEditItem Value="Bottom" Text="Bottom" />
                        <dx:ListEditItem Value="Top" Text="Top" />
                        <dx:ListEditItem Value="TopAndBottom" Text="TopAndBottom" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblPageSizeItemPosition" runat="server" Text="PageSizeItem position:" AssociatedControlID="cmbPageSizeItemPosition" Wrap="False" />
            </td>
            <td>
                <dx:ASPxComboBox SelectedIndex="1" ID="cmbPageSizeItemPosition" runat="server" AutoPostBack="True"
                    Width="120px">
                    <Items>
                        <dx:ListEditItem Value="Left" Text="Left" />
                        <dx:ListEditItem Value="Right" Text="Right" />
                    </Items>
                </dx:ASPxComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblShowPageSizeItem" runat="server" Text="Show PageSizeItem:"
                    AssociatedControlID="cbShowPageSizeItem" Wrap="False" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowPageSizeItem" runat="server" Checked="True" AutoPostBack="True" />
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblShowSummary" runat="server" Text="Show Summary:" AssociatedControlID="cbShowSummary" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowSummary" runat="server" AutoPostBack="True" Checked="True" />
            </td>
        </tr>
    </table>
    <table class="OptionsTable" style="float: left; margin-left: 16px;">
        <tr>
            <td>
                <dx:ASPxLabel ID="lblShowDisabledButtons" runat="server" Text="ShowDisabledButtons:"
                    AssociatedControlID="cbShowDisabledButtons" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowDisabledButtons" runat="server" Checked="True" AutoPostBack="True" />
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblShowNumericButtons" runat="server" Text="ShowNumericButtons:"
                    AssociatedControlID="cbShowNumericButtons" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowNumericButtons" runat="server" Checked="True" AutoPostBack="True" />
            </td>
        </tr>
        <tr>
            <td>
                <dx:ASPxLabel ID="lblShowSeparators" runat="server" Text="ShowSeparators:" AssociatedControlID="cbShowSeparators" />
            </td>
            <td>
                <dx:ASPxCheckBox ID="cbShowSeparators" runat="server" AutoPostBack="True" />
            </td>
        </tr>
    </table>
    <table class="OptionsTable OptionsBottomMargin" style="float: right; clear: both; margin-top: -24px">
        <tr>
            <td>
                <dx:ASPxButton ID="prevButton" runat="server" Text="&lt; Prev" UseSubmitBehavior="False"
                    AutoPostBack="False" EnableClientSideAPI="True" Wrap="false" ClientInstanceName="prevButton">
                    <ClientSideEvents Click="prevButton_Click" />
                </dx:ASPxButton>
            </td>
            <td>
                <dx:ASPxButton ID="nextButton" runat="server" Text="Next &gt;" UseSubmitBehavior="False"
                    AutoPostBack="False" EnableClientSideAPI="True" Wrap="false" ClientInstanceName="nextButton">
                    <ClientSideEvents Click="nextButton_Click" />
                </dx:ASPxButton>
            </td>
        </tr>
    </table>
    <b class="Clear"></b>
    <dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1"
        Width="100%" ClientInstanceName="treeList">
        <Columns>
            <dx:TreeListDataColumn FieldName="title" VisibleIndex="0" />
        </Columns>
        <Settings ShowColumnHeaders="False" GridLines="Both" SuppressOuterGridLines="true" />
        <SettingsPager Mode="ShowPager">
            <PageSizeItemSettings Items="10, 20, 50" Visible="true" />
        </SettingsPager>
        <SettingsBehavior AutoExpandAllNodes="True" ExpandCollapseAction="NodeDblClick" />
        <Border BorderStyle="Solid" />
        <Styles>
            <PagerTopPanel>
                <BorderBottom BorderStyle="Solid" />
            </PagerTopPanel>
            <PagerBottomPanel>
                <BorderTop BorderStyle="Solid" />
            </PagerBottomPanel>
            <AlternatingNode Enabled="True" />
        </Styles>
        <ClientSideEvents Init="treeList_Init" EndCallback="treeList_EndCallback" />
    </dx:ASPxTreeList>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/App_Data/SiteMap.xml"
        XPath="/*/*/*" />
</asp:Content>
