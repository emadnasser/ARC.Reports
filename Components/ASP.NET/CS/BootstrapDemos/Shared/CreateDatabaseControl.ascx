<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CreateDatabaseControl.ascx.cs" Inherits="Shared_CreateDatabaseControl" %>
<asp:PlaceHolder runat="server" ID="Message">
    <div class="alert alert-info" role="alert">
        <span class="message">This demo requires a large database. To create a sample database, click the Create Database button below. This may take a few minutes.</span>
        <br /><br />
        <dx:BootstrapButton runat="server" ID="CreateButton" Text="Create Database" AutoPostBack="false">
            <ClientSideEvents Click="dxBootstrapDemo.dbCreator.onCreateDbButtonClick" />
        </dx:BootstrapButton>
        <dx:BootstrapProgressBar runat="server" ID="ProgressBar" ClientInstanceName="progressBar" Striped="true" Animated="true" ClientVisible="false"></dx:BootstrapProgressBar>
    </div>
</asp:PlaceHolder>
<dx:ASPxCallback runat="server" ID="Callback" ClientInstanceName="createDbCallback" OnCallback="Callback_Callback">
    <ClientSideEvents CallbackComplete="dxBootstrapDemo.dbCreator.onCallbackComplete" CallbackError="dxBootstrapDemo.dbCreator.onCallbackError" />
</dx:ASPxCallback>
