<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Live.aspx.cs"
    Inherits="DataBinding_Live" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        var timeout;
        function scheduleGridUpdate(grid) {
            window.clearTimeout(timeout);
            timeout = window.setTimeout( 
                function() { grid.Refresh(); },
                2000
            );
        }
        function grid_Init(s, e) {
            scheduleGridUpdate(s);
        }
        function grid_BeginCallback(s, e) {
            window.clearTimeout(timeout);
        }
        function grid_EndCallback(s, e) {
            scheduleGridUpdate(s);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxGridView ID="grid" runat="server" DataSourceID="ObjectDataSource1"
        Width="100%" AutoGenerateColumns="False">
        <ClientSideEvents Init="grid_Init" BeginCallback="grid_BeginCallback" EndCallback="grid_EndCallback" />
        <Columns>
            <dx:GridViewDataTextColumn Caption="Symbol" FieldName="Symbol" />
            <dx:GridViewDataTextColumn Caption="Price" FieldName="Price" Width="120px">
                <PropertiesTextEdit DisplayFormatString="0.00">
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Change" FieldName="Change" Width="120px">
                <DataItemTemplate>
                    <dx:ASPxImage runat="server" ID="icon" ImageUrl="<%# GetIconImageUrl(Container) %>" style="margin: 2px 4px;" Width="10" Height="10" />
                    <%# GetPercentageText(Container) %>                    
                </DataItemTemplate>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Day Max" FieldName="DayMax" Width="120px">
                <PropertiesTextEdit DisplayFormatString="0.00">
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataTextColumn Caption="Day Min" FieldName="DayMin" Width="120px">
                <PropertiesTextEdit DisplayFormatString="0.00">
                </PropertiesTextEdit>
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataDateColumn Caption="Last Updated" FieldName="LastUpdated" Width="120px">
                <PropertiesDateEdit DisplayFormatString="HH:mm:ss">
                </PropertiesDateEdit>
                <CellStyle HorizontalAlign="Right" />
            </dx:GridViewDataDateColumn>
        </Columns>
        <Styles>
            <Header HorizontalAlign="Center" />
        </Styles>
        <Settings GridLines="Vertical" />
        <SettingsBehavior AllowDragDrop="false" />
        <SettingsPager Mode="ShowAllRecords" />
        <SettingsLoadingPanel Mode="ShowOnStatusBar" />
    </dx:ASPxGridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetQuotes"
        TypeName="QuotesProvider" />
    <div class="Note">
		<b>Note:</b>
		The quote values are generated for the demonstration purpose only. 
    </div>
</asp:Content>
