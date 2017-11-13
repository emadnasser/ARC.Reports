<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Features.aspx.cs"
    Inherits="ASPxCalendar_Features" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left;">
        <dx:ASPxCalendar ID="calendar" runat="server" />
    </div>
    <div style="float: left; margin-left: 2%">
        <div>
            <dx:ASPxCheckBox ID="cbHighlightToday" runat="server" Text="HighlightToday" AutoPostBack="True"
                Checked="True" />
        </div>
        <div class="TopPadding">
            <dx:ASPxCheckBox ID="cbHighlightWeekends" runat="server" Text="HighlightWeekends"
                AutoPostBack="True" Checked="True" />
        </div>
        <div class="TopPadding">
            <dx:ASPxCheckBox ID="cbShowClearButton" runat="server" Text="ShowClearButton" AutoPostBack="True"
                Checked="True" />
        </div>
        <div class="TopPadding">
            <dx:ASPxCheckBox ID="cbShowTodayButton" runat="server" Text="ShowTodayButton" AutoPostBack="True"
                Checked="True" />
        </div>
        <div class="TopPadding">
            <dx:ASPxCheckBox ID="cbShowDayHeaders" runat="server" Text="ShowDayHeaders" AutoPostBack="True"
                Checked="True" />
        </div>
        <div class="TopPadding">
            <dx:ASPxCheckBox ID="cbShowHeader" runat="server" Text="ShowHeader" AutoPostBack="True"
                Checked="True" />
        </div>
        <div class="TopPadding">
            <dx:ASPxCheckBox ID="cbShowWeekNumber" runat="server" Text="ShowWeekNumber" AutoPostBack="True"
                Checked="True" />
        </div>
        <div class="TopPadding">
            <dx:ASPxCheckBox ID="cbEnableMultiSelect" runat="server" Text="EnableMultiSelect"
                AutoPostBack="True" Checked="False" />
        </div>
    </div>
</asp:Content>
