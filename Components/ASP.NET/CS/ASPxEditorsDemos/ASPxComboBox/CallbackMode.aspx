<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CallbackMode.aspx.cs"
    Inherits="ASPxComboBox_CallbackMode" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <div style="float: left">
        <dx:ASPxComboBox ID="ASPxComboBox1" runat="server" DataSourceID="CountriesDataSource"
            TextField="CountryName" ValueField="CountryName" Width="180px" SelectedIndex="0" CallbackPageSize="15"
            EnableCallbackMode="True" EnableViewState="false"/>
    </div>
    <div style="float: left; margin-left: 2%">
        <div>
            CallBackPageSize = 15
        </div>
        <div class="TopPadding">
            EnableCallbackMode = True
        </div>
    </div>
    <ef:EntityDataSource runat="server" ID="CountriesDataSource" ContextTypeName="WorldCitiesContext" EntitySetName="Countries" OrderBy="it.CountryName" />
</asp:Content>
