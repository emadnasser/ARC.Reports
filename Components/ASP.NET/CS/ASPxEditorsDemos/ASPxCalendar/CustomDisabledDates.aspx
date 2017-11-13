<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CustomDisabledDates.aspx.cs"
    Inherits="ASPxCalendar_CustomDisabledDates" %>
<asp:Content ContentPlaceHolderID="CustomHeadHolder" runat="server">
    <style type="text/css">
        .title
        {
            text-align: center;
            padding: 0px 0px 20px 0px;
        }
        .OptionsTable {
            border-collapse: separate;
            border-spacing: 75px 0px;
        }
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        function onCustomDisabledDate(s, e) {
            if(e.date.getDay() == 3)
                e.isDisabled = true;
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <table class="OptionsTable">
        <tr>
            <td>
                <h3 class="title">Disabled dates are defined by custom rules</h3>
                <dx:ASPxCalendar ID="ASPxCalendar1" runat="server" OnCustomDisabledDate="ASPxCalendar1_CustomDisabledDate">
                    <ClientSideEvents CustomDisabledDate="onCustomDisabledDate" />
                </dx:ASPxCalendar>
            </td>
            <td>
                <h3 class="title">Disabled dates are defined by a list</h3>
                <dx:ASPxCalendar ID="ASPxCalendar2" runat="server">
                </dx:ASPxCalendar>
            </td>
        </tr>
    </table>
</asp:Content>
