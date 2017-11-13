<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Templates.aspx.cs"
    Inherits="Shaping_Templates" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <style type="text/css">
        table.treeListCard
        {
            background: #f5f5f5;
            border-collapse: collapse;
        }
        table.treeListCard td
        {
            border: solid 1px #cecece;
            padding: 4px;
            white-space: normal;
        }
        table.treeListCard td.name
        {
            background: #efefef;
            white-space: nowrap;
            width: 10%;
        }
        table.treeListCard img
        {
            border: 0;
        }
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        function showNotes(text) {
            notesPopup.SetContentHTML(text);
        }
        function loadNotes(id, refElement) {
            notesPopup.Hide();
            notesPopup.ShowAtElement(refElement);
            notesPopup.SetContentHTML("Loading...");
            treeList.PerformCustomDataCallback(id);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxTreeList ID="treeList" runat="server" AutoGenerateColumns="False" DataSourceID="FishDataSource"
        Width="100%" KeyFieldName="ID" ParentFieldName="ParentID" ClientInstanceName="treeList"
        OnCustomDataCallback="treList_CustomDataCallback">
        <Columns>
            <dx:TreeListDataColumn Caption="Fish Catalog" VisibleIndex="0" AllowSort="False" />
        </Columns>
        <Templates>
            <DataCell>
                <table class="treeListCard" style="width: 100%">
                    <tr>
                        <td rowspan="4" style="width: 10%">
                            <a href="javascript:;" onclick="loadNotes(<%# Eval("ID") %>, this)">
                                <dx:ASPxBinaryImage runat="server" ID="ASPxBinaryImage1" Value='<%# Eval("Picture") %>' /></a>
                        </td>
                        <td class="name">
                            Species No:
                        </td>
                        <td>
                            <%# Eval("Species_No") %>
                        </td>
                        <td class="name">
                            Length:
                        </td>
                        <td>
                            <%# Eval("Length") %>
                        </td>
                    </tr>
                    <tr>
                        <td class="name">
                            Common Name:
                        </td>
                        <td colspan="3">
                            <%# Eval("Common_Name") %>
                        </td>
                    </tr>
                    <tr>
                        <td class="name">
                            Species Name:
                        </td>
                        <td colspan="3">
                            <%# Eval("Species_Name") %>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="4">
                            <a href="javascript:;" onclick="loadNotes(<%# Eval("ID") %>, this)">Show notes...</a>
                        </td>
                    </tr>
                </table>
            </DataCell>
        </Templates>
        <SettingsPager Mode="ShowPager" PageSize="5" />
        <Styles>
            <Cell>
                <Paddings PaddingTop="2px" PaddingBottom="2px" PaddingLeft="0px" PaddingRight="0px" />
            </Cell>
        </Styles>
        <ClientSideEvents CustomDataCallback="function(s, e) {	showNotes(e.result); }" />
    </dx:ASPxTreeList>
    
    <ef:EntityDataSource runat="server" ID="FishDataSource" ContextTypeName="FishContext" EntitySetName="BioLives" />
    <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" ClientInstanceName="notesPopup"
        HeaderText="Notes" AllowDragging="True" CloseAction="OuterMouseClick" Width="400px"
        PopupHorizontalAlign="LeftSides" PopupVerticalAlign="Below"/>
</asp:Content>
