<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="XLExportAPI.aspx.cs" Inherits="Spreadsheet_XLExportAPI" %>
<asp:Content ID="localCss" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .borderedContent {
            border: 1px Solid rgb(224, 224, 224);
        }
    </style>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <script type="text/javascript">
        function LayoutView() {
            var mainTableHeight = document.getElementById("mainTable").offsetHeight;
            document.getElementById("treeListContainer").style.height = mainTableHeight - 6 + "px";
        }
        function UpdateCodePreview(s, e) {
            var indx = e.result.indexOf('|');
            var isCSVButtonEnabled = (e.result.substring(0, indx) === 'true');
            indx++;
            var xlsEnabledIndex = e.result.indexOf('|', indx);
            var isXLSButtonEnabled = (e.result.substring(indx, xlsEnabledIndex) === 'true');
            indx = xlsEnabledIndex + 1;
            var exampleNameIndex = e.result.indexOf('|', indx);
            var exampleName = e.result.substring(indx, exampleNameIndex);
            var data = e.result;
            indx = exampleNameIndex + 1;
            do {
                var endElementNameIndx = data.indexOf("$", indx);
                var elementName = data.substring(indx, endElementNameIndx);
                indx = endElementNameIndx + 1;
                var endLengthIndx = e.result.indexOf("$", indx);
                var length = parseInt(data.substring(indx, endLengthIndx));
                var indx = endLengthIndx + 1;
                var endCodeIndx = indx + length;
                var code = data.substring(indx, endCodeIndx);
                var indx = endCodeIndx + 1;
                document.getElementById(elementName).innerHTML = code;
            } while (indx < data.length);
            lblSourceName.SetText(exampleName);
            btnExportToCSV.SetEnabled(isCSVButtonEnabled);
            btnExportToXLS.SetEnabled(isXLSButtonEnabled);
            var key = s.GetFocusedNodeKey();
        }
    </script>
    <dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
        <clientsideevents controlsinitialized="function(s,e){ LayoutView(); }" />
    </dx:ASPxGlobalEvents>
    <table>
        <tr>
            <td style="width: 100%;">
                <dx:ASPxLabel runat="server" ID="lblSourceName" Font-Size="X-Large" ClientInstanceName="lblSourceName">
                </dx:ASPxLabel>
            </td>
            <td>
                <dx:ASPxButton ID="btnExportToXLSX" runat="server" Text="Export to XLSX" OnClick="btnExportToXLSX_Click" Style="margin-right: 9px;" />
            </td>
            <td>
                <dx:ASPxButton ID="btnExportToXLS" runat="server" Text="Export to XLS" ClientInstanceName="btnExportToXLS" OnClick="btnExportToXLS_Click" Style="margin-right: 9px;" />
            </td>
            <td>
                <dx:ASPxButton ID="btnExportToCSV" runat="server" Text="Export to CSV" ClientInstanceName="btnExportToCSV" OnClick="btnExportToCSV_Click" />
            </td>
        </tr>
    </table>
    <div class="Separator">
    </div>
    <table id="mainTable" style="width: 100%;">
        <tr>
            <td style="vertical-align: top; vertical-align: top; width: 100%">
                <dx:ASPxPageControl ID="ASPxPageControl1" ClientInstanceName="ASPxPageControl1" runat="server"
                    ActiveTabIndex="0" Width="100%" EnableViewState="False" EnableHierarchyRecreation="True"
                    BorderRight-BorderWidth="0" BorderRight-BorderStyle="None">
                    <clientsideevents activetabchanged="function(s, e) { }" activetabchanging="function(s, e) {  }"
                        init="function(s, e) {}" tabclick="function(s, e) { }" />
                    <contentstyle paddings-paddingright="0" paddings-paddingtop="1px" paddings-paddingbottom="1px">
                    </contentstyle>
                    <tabpages>
                        <dx:TabPage Name="C#" Text="C#">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl1" runat="server">
                                    <div style="overflow: auto; height: 550px;">
                                        <code runat="server" id="CSharpCodeHolder" clientidmode="Static"></code>
                                    </div>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                        <dx:TabPage Name="VB" Text="VB">
                            <ContentCollection>
                                <dx:ContentControl ID="ContentControl2" runat="server" ClientIDMode="Static">
                                    <div style="overflow: auto; height: 550px;">
                                        <code runat="server" id="VBCodeHolder" clientidmode="Static"></code>
                                    </div>
                                </dx:ContentControl>
                            </ContentCollection>
                        </dx:TabPage>
                    </tabpages>
                </dx:ASPxPageControl>
            </td>
            <td>
                <div id="treeListContainer" style="height: 550px; overflow: scroll; width: 280px; padding: 0; margin: 0;">
                    <dx:ASPxTreeList ID="ASPxTreeList1" ClientInstanceName="treeList" runat="server"
                        Height="334px" Width="240px" OnCustomDataCallback="treeList_CustomDataCallback">
                        <columns>
                            <dx:TreeListTextColumn FieldName="Name">
                                <PropertiesTextEdit EncodeHtml="false" />
                            </dx:TreeListTextColumn>
                        </columns>
                        <settingsbehavior allowfocusednode="True" />
                        <settings showcolumnheaders="false" />
                        <clientsideevents
                            customdatacallback="function(s, e) {
                            UpdateCodePreview(s, e);
                           
                         }"
                            focusednodechanged="function(s, e) { 
                            var key = treeList.GetFocusedNodeKey();
                            treeList.PerformCustomDataCallback(key); 
                        }" />
                    </dx:ASPxTreeList>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
