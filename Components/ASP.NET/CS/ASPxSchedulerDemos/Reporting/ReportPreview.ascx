<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ReportPreview.ascx.cs"
    Inherits="Reporting_ReportPreview" %>
<div style="width: 670px; height: 35px">
    <dx:ReportToolbar ID="ReportToolbar1" runat="server" ReportViewer="<%# ReportViewer %>"
        ShowDefaultButtons="False">
        <Items>
            <dx:ReportToolbarButton ItemKind="PrintReport" ToolTip="Print the report" />
            <dx:ReportToolbarButton ItemKind="PrintPage" ToolTip="Print the current page" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind="FirstPage" ToolTip="First Page" />
            <dx:ReportToolbarButton ItemKind="PreviousPage" ToolTip="Previous Page" />
            <dx:ReportToolbarLabel ItemKind="PageLabel" />
            <dx:ReportToolbarComboBox ItemKind="PageNumber" Width="65px">
            </dx:ReportToolbarComboBox>
            <dx:ReportToolbarLabel ItemKind="OfLabel"/>
            <dx:ReportToolbarTextBox IsReadOnly="True" ItemKind="PageCount" />
            <dx:ReportToolbarButton ItemKind="NextPage" ToolTip="Next Page" />
            <dx:ReportToolbarButton ItemKind="LastPage" ToolTip="Last Page" />
            <dx:ReportToolbarSeparator />
            <dx:ReportToolbarButton ItemKind="SaveToDisk" ToolTip="Export a report and save it to the disk" />
            <dx:ReportToolbarButton ItemKind="SaveToWindow" ToolTip="Export a report and show it in a new window" />
            <dx:ReportToolbarComboBox ItemKind="SaveFormat" Width="70px">
                <Elements>
                    <dx:ListElement Text="Pdf" Value="pdf" />
                    <dx:ListElement Text="Mht" Value="mht" />
                    <dx:ListElement Text="Image" Value="png" />
                </Elements>
            </dx:ReportToolbarComboBox>
        </Items>
    </dx:ReportToolbar>
</div>
<div id="ClientArea" style="overflow: auto; overflow-x: hidden; padding-right: 20px;">
    <script type="text/javascript" id="dxss_s1">
    // <![CDATA[
        window.OnClientReportViewerLoad = function () {
            var maxSizeRatio = 0.8;
            var maxPCWidth = document.documentElement.clientWidth * maxSizeRatio;
            var maxPCHeight = document.documentElement.clientHeight * maxSizeRatio;
            scheduler.HideLoadingPanel();
            ASPxPopupControl1.Show();
            var clientAreaDiv = document.getElementById('ClientArea');
            clientAreaDiv.style.width = '0';
            clientAreaDiv.style.height = '0';
            if(ASPxClientUtils.chrome)
                ASPxPopupControl1.GetWindowElement(-1).style.width = "0px";
            ASPxPopupControl1.SetSize(0, 0);
            var reportViewerMainElement = ClientReportViewer.getContentElement();
            var pcClientAreaWidth = reportViewerMainElement.offsetWidth < maxPCWidth ? reportViewerMainElement.offsetWidth : maxPCWidth;
            var pcClientAreaHeight = reportViewerMainElement.offsetHeight < maxPCHeight ? reportViewerMainElement.offsetHeight : maxPCHeight;
            clientAreaDiv.style.width = pcClientAreaWidth + 'px';
            clientAreaDiv.style.height = pcClientAreaHeight + 'px';
            
            if (ASPxClientUtils.touchUI)
                ASPxPopupControl1.SetSize(0, 0);
            ASPxPopupControl1.UpdatePosition();
        }
    // ]]> 
    </script>
    <dx:ReportViewer ID="ReportViewer" runat="server" ClientInstanceName="ClientReportViewer">
        <ClientSideEvents PageLoad="function(s, e) { window.setTimeout('OnClientReportViewerLoad()', 0) }" />
    </dx:ReportViewer>
</div>
