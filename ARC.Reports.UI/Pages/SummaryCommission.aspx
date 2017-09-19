<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="SummaryCommission.aspx.cs" Inherits="ARC.Reports.Pages.SummaryCommission" %>

<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.XtraReports.v16.2.Web, Version=16.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    </style>
    <script>
        $(document).ready(function () {
            $(function () {
                $("#sidebar > ul > li > ul:nth-child(3) > li > ul > li:nth-child(5)").addClass("active");
                //$('#MainContent_ASPxDocumentViewer_Splitter_RibbonToolbar_T0G3I2').remove();
                //$('#MainContent_ASPxDocumentViewer_Splitter_ParametersPanel_Submit').click().delay(3000);

                //if ($('#MainContent_ASPxDocumentViewer_Splitter_ParametersPanel_dxxrppEditor1_I').val() == "1/1/2007")
                //{

                //}
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxDocumentViewer ID="ASPxDocumentViewer" runat="server" EnableTheming="True" Theme="DevEx" ToolbarMode="Ribbon" ReportTypeName="ARC.Reports.Reports.SummaryCommission" AssociatedRibbonID="213" Width="100%" Height="100%" SettingsDocumentMap-AllowSelectNode="true" >
        <settingsdocumentmap showtreelines="True" AllowSelectNode="true" />
        <StylesReportViewer ShowDocumentShadow="false"></StylesReportViewer>
        <stylessplitter sidepanewidth="230px">
        </stylessplitter>
    </dx:ASPxDocumentViewer>
</asp:Content>
