<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientSide.aspx.cs"
    Inherits="ObjectContainer_ClientSide" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function SelectAllCountryInFlash() {
            var countries = document.getElementById("countries");
            var action = document.getElementById("all").checked ? "check" : "uncheck";
            if (countries != null) {
                for (var i = 0; i < countries.getElementsByTagName('input').length; i++) {
                    var name = countries.getElementsByTagName('input')[i].getAttribute('id');
                    SelectCountryInHtml(name, action);
                    SelectCountryInFlash(name);
                }
            }
        }
        function GetActualSelectAllCheckBoxStatus() {
            var countries = document.getElementById("countries");
            var isSelectAllCheck = true;
            if (countries != null) {
                for (var i = 0; i < countries.getElementsByTagName('input').length; i++) {
                    if (!countries.getElementsByTagName('input')[i].checked) {
                        isSelectAllCheck = false;
                    }
                }
            }
            return isSelectAllCheck ? "check" : "uncheck";
        }
        function SetSelectAllCheckBox() {
            var action = GetActualSelectAllCheckBoxStatus();
            var country = document.getElementById("all");
            if (country != null) {
                if (action == "check")
                    country.checked = true;
                else if (action == "uncheck")
                    country.checked = false;
            }
        }
        function SelectCountryInFlash(name) {
            var country = document.getElementById(name);
            if (country != null) {
                var action = country.checked ? "checked" : "unchecked";
                OCFlashMap.SetVariable("_root.worker.area", name);
                OCFlashMap.SetVariable("_root.worker.command", action);
                OCFlashMap.SetVariable("_root.worker.checker", action);
                SetSelectAllCheckBox();
            }
        }
        function SelectCountryInHtml(name, action) {
            var country = document.getElementById(name);
            if (country != null) {
                if (action == "check")
                    country.checked = true;
                else if (action == "uncheck")
                    country.checked = false;
                SetSelectAllCheckBox();
            }
        }
        function InitMap() {
            var map = document.getElementById("map");
            if (map != null) {
                for (var i = 0; i < map.getElementsByTagName('input').length; i++) {
                    var name = map.getElementsByTagName('input')[i].getAttribute('id');
                    SelectCountryInHtml(name, "uncheck");
                }
            }
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left; width: 300px">
        <dx:ASPxObjectContainer ID="ASPxObjectContainer1" runat="server" ObjectUrl="~/ObjectContainer/Files/SouthAmerica.swf"
            ObjectType="Flash" ClientInstanceName="OCFlashMap" EnableClientSideAPI="True"
            Height="553px" Width="353px">
            <ObjectProperties SWLiveConnect="True" />
            <ClientSideEvents FlashScriptCommand="function(s, e) { DXEventMonitor.Trace(s, e, 'FlashScriptCommand'); SelectCountryInHtml(e.args, e.command); }"
                Init="function(s, e) { InitMap(); }" />
        </dx:ASPxObjectContainer>
    </div>
    <div style="float: right; width: 300px">
        <table class="OptionsTable">
            <tr>
                <td>
                    <input type="checkbox" id="all" onclick="SelectAllCountryInFlash();" />
                </td>
                <td>
                    <label for="all" class="NoWrap">
                        All</label>
                </td>
            </tr>
        </table>
        <table class="OptionsTable" id="countries">
            <tr>
                <td>
                    <input type="checkbox" id="argentina" onclick="SelectCountryInFlash('argentina');" />
                </td>
                <td>
                    <label for="argentina" class="NoWrap">
                        Argentina</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="bolivia" onclick="SelectCountryInFlash('bolivia');" />
                </td>
                <td>
                    <label for="bolivia" class="NoWrap">
                        Bolivia</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="brazil" onclick="SelectCountryInFlash('brazil');" />
                </td>
                <td>
                    <label for="brazil" class="NoWrap">
                        Brazil</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="chile" onclick="SelectCountryInFlash('chile');" />
                </td>
                <td>
                    <label for="chile" class="NoWrap">
                        Chile</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="colombia" onclick="SelectCountryInFlash('colombia');" />
                </td>
                <td>
                    <label for="colombia" class="NoWrap">
                        Colombia</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="ecuador" onclick="SelectCountryInFlash('ecuador');" />
                </td>
                <td>
                    <label for="ecuador" class="NoWrap">
                        Ecuador</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="guyana" onclick="SelectCountryInFlash('guyana');" />
                </td>
                <td>
                    <label for="guyana" class="NoWrap">
                        Guyana</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="french" onclick="SelectCountryInFlash('french');" />
                </td>
                <td>
                    <label for="french" class="NoWrap">
                        French Guyana</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="paraguay" onclick="SelectCountryInFlash('paraguay');" />
                </td>
                <td>
                    <label for="paraguay" class="NoWrap">
                        Paraguay</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="peru" onclick="SelectCountryInFlash('peru');" />
                </td>
                <td>
                    <label for="peru" class="NoWrap">
                        Peru</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="suriname" onclick="SelectCountryInFlash('suriname');" />
                </td>
                <td>
                    <label for="suriname" class="NoWrap">
                        Suriname</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="uruguay" onclick="SelectCountryInFlash('uruguay');" />
                </td>
                <td>
                    <label for="uruguay" class="NoWrap">
                        Uruguay</label>
                </td>
            </tr>
            <tr>
                <td>
                    <input type="checkbox" id="venezuela" onclick="SelectCountryInFlash('venezuela');" />
                </td>
                <td>
                    <label for="venezuela" class="NoWrap">
                        Venezuela</label>
                </td>
            </tr>
        </table>
    </div>
    <dx:EventMonitor runat="server" ID="EventMonitor" EventNames="FlashScriptCommand"
        EventLogWidth="520" />
</asp:Content>
