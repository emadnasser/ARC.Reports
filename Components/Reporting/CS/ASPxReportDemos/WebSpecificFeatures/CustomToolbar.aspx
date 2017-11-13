<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomToolbar.aspx.cs" Inherits="WebSpecificFeatures_CustomToolbar" %>
<%@ Register Assembly="DevExpress.XtraReports.v16.2.Web" Namespace="DevExpress.XtraReports.Web" TagPrefix="dxxr" %>
<%@ Register Assembly="DevExpress.XtraReports.v16.2.Web" Namespace="DevExpress.XtraReports.Web.DocumentViewer.Ribbon" TagPrefix="dxxrdvr" %>
<asp:Content ID="Content2" ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <script src="../Scripts/CustomToolBarScripts.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRibbon ID="ASPxRibbon1" runat="server" ShowFileTab="False" Width="1100px" EnableTheming="True" OnInit="ASPxRibbon1_Init">
        <clientsideevents
            init="function(s, e) { CustomToolbarClientControl.OnInit(s, e); }"
            commandexecuted="function(s, e) { CustomToolbarClientControl.CommandExecuted(s, e); }" />
        <tabs>
        <dxxrdvr:DocumentViewerHomeRibbonTab>
            <Groups>
                <dxxrdvr:DocumentViewerPrintRibbonGroup>
                    <Items>
                        <dxxr:DocumentViewerPrintReportRibbonCommand></dxxr:DocumentViewerPrintReportRibbonCommand>
                        <dxxr:DocumentViewerPrintPageRibbonCommand></dxxr:DocumentViewerPrintPageRibbonCommand>
                    </Items>
                </dxxrdvr:DocumentViewerPrintRibbonGroup>
                <dxxrdvr:DocumentViewerExportRibbonGroup>
                    <Items>
                        <dxxr:DocumentViewerSaveToDiskDropDownRibbonCommand>
                            <Items>
                                <dxxr:RibbonPdfFormatCommand></dxxr:RibbonPdfFormatCommand>
                                <dxxr:RibbonXlsFormatCommand></dxxr:RibbonXlsFormatCommand>
                                <dxxr:RibbonXlsxFormatCommand></dxxr:RibbonXlsxFormatCommand>
                                <dxxr:RibbonRtfFormatCommand></dxxr:RibbonRtfFormatCommand>
                                <dxxr:RibbonMhtFormatCommand></dxxr:RibbonMhtFormatCommand>
                                <dxxr:RibbonHtmlFormatCommand></dxxr:RibbonHtmlFormatCommand>
                                <dxxr:RibbonTextFormatCommand></dxxr:RibbonTextFormatCommand>
                                <dxxr:RibbonCsvFormatCommand></dxxr:RibbonCsvFormatCommand>
                                <dxxr:RibbonPngFormatCommand></dxxr:RibbonPngFormatCommand>
                            </Items>
                        </dxxr:DocumentViewerSaveToDiskDropDownRibbonCommand>
                        <dxxr:DocumentViewerSaveToWindowDropDownRibbonCommand>
                            <Items>
                                <dxxr:RibbonPdfFormatCommand></dxxr:RibbonPdfFormatCommand>
                                <dxxr:RibbonXlsFormatCommand></dxxr:RibbonXlsFormatCommand>
                                <dxxr:RibbonXlsxFormatCommand></dxxr:RibbonXlsxFormatCommand>
                                <dxxr:RibbonRtfFormatCommand></dxxr:RibbonRtfFormatCommand>
                                <dxxr:RibbonMhtFormatCommand></dxxr:RibbonMhtFormatCommand>
                                <dxxr:RibbonHtmlFormatCommand></dxxr:RibbonHtmlFormatCommand>
                                <dxxr:RibbonTextFormatCommand></dxxr:RibbonTextFormatCommand>
                                <dxxr:RibbonCsvFormatCommand></dxxr:RibbonCsvFormatCommand>
                                <dxxr:RibbonPngFormatCommand></dxxr:RibbonPngFormatCommand>
                            </Items>
                        </dxxr:DocumentViewerSaveToWindowDropDownRibbonCommand>
                    </Items>
                </dxxrdvr:DocumentViewerExportRibbonGroup>
                <dxxrdvr:DocumentViewerNavigationRibbonGroup>
                    <Items>
                        <dxxr:DocumentViewerFirstPageRibbonCommand></dxxr:DocumentViewerFirstPageRibbonCommand>
                        <dxxr:DocumentViewerPreviousPageRibbonCommand></dxxr:DocumentViewerPreviousPageRibbonCommand>
                        <dxxr:DocumentViewerPageNumbersTemplateRibbonCommand>
                            <Template>
                                <dxxr:DocumentViewerRibbonCurrentPageLabel runat="server"></dxxr:DocumentViewerRibbonCurrentPageLabel>
                                <dxxr:DocumentViewerRibbonPagesComboBox runat="server"></dxxr:DocumentViewerRibbonPagesComboBox>
                                <dxxr:DocumentViewerRibbonPageCountLabel runat="server"></dxxr:DocumentViewerRibbonPageCountLabel>
                            </Template>
                        </dxxr:DocumentViewerPageNumbersTemplateRibbonCommand>
                        <dxxr:DocumentViewerNextPageRibbonCommand></dxxr:DocumentViewerNextPageRibbonCommand>
                        <dxxr:DocumentViewerLastPageRibbonCommand></dxxr:DocumentViewerLastPageRibbonCommand>
                    </Items>
                </dxxrdvr:DocumentViewerNavigationRibbonGroup>
                <dx:RibbonGroup Name="CustomReportGroup" Text="Report">
                    <Items>
                        <dxxr:DocumentViewerSearchRibbonCommand></dxxr:DocumentViewerSearchRibbonCommand>
                        <dx:RibbonToggleButtonItem Name="ShowParametersPanelToggleCommand" Size="Large" Text="Parameters Panel" ToolTip="Open the Parameters pane to enter values for report parameters."></dx:RibbonToggleButtonItem>
                        <dx:RibbonToggleButtonItem Name="ShowDocumentMapToggleCommand" Size="Large" Text="Document Map" ToolTip="Open the Document Map to navigate through document bookmarks."></dx:RibbonToggleButtonItem>
                    </Items>
                </dx:RibbonGroup>
            </Groups>
        </dxxrdvr:DocumentViewerHomeRibbonTab>
    </tabs>
    </dx:ASPxRibbon>
    <dx:ASPxDocumentViewer runat="server" ID="documentViewer" Width="1100px" ToolbarMode="ExternalRibbon" AssociatedRibbonID="ASPxRibbon1" EnableViewState="False">
        <stylessplitter sidepanewidth="290px" />
        <clientsideevents
            init="function(s) { CustomToolbarClientControl.AssignDocumentViewer(s); }"
            pageload="function(s, e) { CustomToolbarClientControl.OnPageLoad(s, e); }" />
    </dx:ASPxDocumentViewer>
</asp:Content>
