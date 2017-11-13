<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ClientAPI.aspx.cs"
    Inherits="ASPxComboBox_ClientAPI" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        var lastCountry = null;
        function OnCountryChanged(cmbCountry) {
            if (cmbCity.InCallback() )
                lastCountry = cmbCountry.GetValue().toString();
            else
            	cmbCity.PerformCallback(cmbCountry.GetValue().toString());
        }
        function OnEndCallback(s,e){        
            if (lastCountry){
                cmbCity.PerformCallback(lastCountry);
                lastCountry = null;
            }
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <table class="OptionsTable">
        <tr>
            <td style="padding-right:16px">
                <dx:ASPxComboBox runat="server" ID="CmbCountry" DropDownStyle="DropDownList" IncrementalFilteringMode="StartsWith"
                    DataSourceID="CountriesDataSource" TextField="CountryName" ValueField="CountryName" Caption="Country:"
                    EnableSynchronization="False">
                    <ClientSideEvents SelectedIndexChanged="function(s, e) { OnCountryChanged(s); }" />
                </dx:ASPxComboBox>
            </td>
            <td>
                <dx:ASPxComboBox runat="server" ID="CmbCity" ClientInstanceName="cmbCity" OnCallback="CmbCity_Callback"
                    DropDownStyle="DropDown" TextField="CityName"
                    ValueField="CityName" IncrementalFilteringMode="StartsWith" EnableSynchronization="False" Caption="City:">
                    <ClientSideEvents EndCallback=" OnEndCallback"/>
                </dx:ASPxComboBox>
            </td>
        </tr>
    </table>
    <ef:EntityDataSource runat="server" ID="CountriesDataSource" ContextTypeName="WorldCitiesContext" 
        CommandText="SELECT cr.CountryName, c.CityName as Capital FROM Cities AS c INNER JOIN Countries AS cr ON c.CityId = cr.CapitalId order by cr.CountryName" />
</asp:Content>
