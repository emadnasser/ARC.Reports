﻿<%@ Page Title="ARC Reports - Summary Commission Portfolio" Language="C#" MasterPageFile="~/Pages/Admin.Master" AutoEventWireup="true" CodeBehind="SummaryCommissionPortfolio.aspx.cs" Inherits="ARC.Reports.Pages.SummaryCommissionPortfolio" %>

<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register Assembly="DevExpress.XtraReports.v16.2.Web, Version=16.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .pnl {
        width:200px !important;
        }
    </style>
    <script>
        $(document).ready(function () {
            $(function () {
                $("#sidebar > ul > li > ul:nth-child(3) > li > ul > li:nth-child(6)").addClass("active");
                $("#MainContent_ASPxDocumentViewer_Splitter_RibbonToolbar_T0G3I2").remove();
                $("#MainContent_ASPxDocumentViewer_Splitter_1i1i0_CC").removeAttr("style");
                $("#MainContent_ASPxDocumentViewer_Splitter_1i1i0_CC").addClass("pnl");
                //$('#MainContent_ASPxDocumentViewer_Splitter_ParametersPanel_Submit').click().delay(3000);

                //if ($('#MainContent_ASPxDocumentViewer_Splitter_ParametersPanel_dxxrppEditor1_I').val() == "1/1/2007")
                //{

                //}
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxDocumentViewer ID="ASPxDocumentViewer" runat="server" EnableTheming="True" Theme="DevEx" ToolbarMode="Ribbon" ReportTypeName="ARC.Reports.Reports.SummaryCommissionPortfolio" AssociatedRibbonID="213" Width="100%" Height="100%" SettingsDocumentMap-AllowSelectNode="true" >
        <settingsdocumentmap showtreelines="True" AllowSelectNode="true" />
        <StylesReportViewer ShowDocumentShadow="false"></StylesReportViewer>
        <stylessplitter sidepanewidth="200px" >
        </stylessplitter>
    </dx:ASPxDocumentViewer>
</asp:Content>
