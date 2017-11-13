<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="MultiSelect.aspx.cs"
    Inherits="ASPxListBox_MultiSelect" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxComboBox ID="lbSelectionMode" runat="server" AutoPostBack="True" OnSelectedIndexChanged="lbSelectionMode_SelectedIndexChanged"
        SelectedIndex="2" Caption="Selection mode">
        <RootStyle CssClass="OptionsBottomMargin"></RootStyle>
        <Items>
            <dx:ListEditItem Text="Single" Value="0" />
            <dx:ListEditItem Text="Multiple" Value="1" />
            <dx:ListEditItem Text="CheckColumn" Value="2" />
        </Items>
    </dx:ASPxComboBox>
    <div style="float: left">
        <dx:ASPxListBox ID="lbFeatures" runat="server" SelectionMode="CheckColumn" Width="250" Height="210"
            DataSourceID="Features" ValueField="ID" ValueType="System.String" TextField="Name" Caption="Phone features">
            <CaptionSettings Position="Top" />
            <ClientSideEvents SelectedIndexChanged="function(s, e) {lbModels.PerformCallback('1');}" />
        </dx:ASPxListBox>
    </div>
    <div style="float: left; padding-left: 2%">
        <dx:ASPxListBox ID="lbModels" runat="server" SelectionMode="CheckColumn" Width="300" Height="210px"
            ClientInstanceName="lbModels" DataSourceID="PhoneModels" ValueField="ID"
            ValueType="System.String" OnCallback="lbModels_Callback" Caption="Accepted models">
            <CaptionSettings Position="Top" />
            <Columns>
                <dx:ListBoxColumn FieldName="Name" Caption="Model" Width="100%" />
                <dx:ListBoxColumn FieldName="Price" Width="50px" />
            </Columns>
        </dx:ASPxListBox>
    </div>
    <asp:XmlDataSource ID="Features" DataFile="~/App_Data/PhoneModels.xml" XPath="//Feature"
        runat="server" />
    <asp:XmlDataSource ID="PhoneModels" DataFile="~/App_Data/PhoneModels.xml" XPath="//Model"
        runat="server" />
</asp:Content>
