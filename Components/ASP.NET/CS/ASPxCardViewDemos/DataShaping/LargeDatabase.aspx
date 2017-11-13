<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="LargeDatabase.aspx.cs" Inherits="Data_LargeDatabase" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        var start;
        function cardView_Init(s, e) {
            cardView.Refresh();
        }
        function cardView_BeginCallback(s, e) {
            start = new Date();
            ClientCommandLabel.SetText(e.command);
            ClientTimeLabel.SetText("working...");
        }
        function cardView_EndCallback(s, e) {
            ClientTimeLabel.SetText(new Date() - start);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:CreateDatabaseControl runat="server" ID="CreateDatabaseControl" TableKey="GeneratedEmailTable" />
    <div runat="server" id="Demo">
        <div style="float: left">
            <div>
                <b>Data Source</b>
            </div>
            <div class="TopPadding">
                <dx:ASPxRadioButton runat="server" Text="EntityServerModeDataSource (DevExpress data source)"
                    AutoPostBack="True" ID="rbEntityDevExpress" GroupName="DataSource" Checked="True" />
                <dx:ASPxRadioButton runat="server" Text=" EntityDataSource (standard .NET data source)"
                    AutoPostBack="True" ID="rbEntityMS2008" GroupName="DataSource" />
            </div>
        </div>
        <div style="float: left; margin-left: 4%">
            <div>
                <b>Test Results</b>
            </div>
            <div class="TopPadding LeftPadding">
                <div>
                    <dx:ASPxLabel runat="server" ID="ASPxLabel1" Text="Command:" />
                    <b>
                        <dx:ASPxLabel runat="server" ID="ASPxLabel2" ClientInstanceName="ClientCommandLabel"
                            Text="..." />
                    </b>
                </div>
                <div class="TopPadding">
                    <dx:ASPxLabel runat="server" ID="ASPxLabel3" Text="Time taken (ms):" />
                    <b>
                        <dx:ASPxLabel runat="server" ID="ASPxLabel4" ClientInstanceName="ClientTimeLabel"
                            Text="..." />
                    </b>
                </div>
            </div>
        </div>
        <b class="Clear"></b>
        <br /><br />
        <dx:ASPxCardView ID="CardView" ClientInstanceName="cardView" runat="server" KeyFieldName="ID" Width="100%" >
            <Columns>
                <dx:CardViewColumn FieldName="From" />
                <dx:CardViewColumn FieldName="Subject" />
                <dx:CardViewDateColumn FieldName="Sent" />
                <dx:CardViewColumn FieldName="Size" />
                <dx:CardViewCheckColumn FieldName="HasAttachment">
                    <PropertiesCheckEdit>
                        <DisplayImageChecked IconID="mail_attachmentobject_16x16gray" ToolTip="Has attachment" />
                        <DisplayImageUnchecked Url="~/Content/1x1.gif" />
                    </PropertiesCheckEdit>
                </dx:CardViewCheckColumn>
            </Columns>
            <CardLayoutProperties>
                <Items>
                    <dx:CardViewColumnLayoutItem ColumnName="HasAttachment" HorizontalAlign="Right" ShowCaption="False" />
                    <dx:CardViewColumnLayoutItem ColumnName="From" />
                    <dx:CardViewColumnLayoutItem ColumnName="Size" />
                    <dx:CardViewColumnLayoutItem ColumnName="Sent" />
                    <dx:CardViewColumnLayoutItem ColumnName="Subject" />
                </Items>
            </CardLayoutProperties>
            <Settings ShowHeaderPanel="true" />
            <ClientSideEvents Init="cardView_Init" BeginCallback="cardView_BeginCallback" EndCallback="cardView_EndCallback" />
        </dx:ASPxCardView>
        <ef:EntityDataSource ID="EntityDataSource" runat="server" ContextTypeName="LargeDatabaseContext"
            EntitySetName="Emails" />
        <dx:EntityServerModeDataSource ID="EntityServerModeDataSource" runat="server" ContextTypeName="LargeDatabaseContext"
            TableName="Emails" />
    </div>
</asp:Content>
