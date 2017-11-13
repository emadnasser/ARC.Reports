<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="SEOFriendly.aspx.cs"
    Inherits="DataViewControl_Example" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxDataView ID="ASPxDataView1" runat="server" DataSourceID="EmployeesDataSource" Width="680px">
        <SettingsTableLayout ColumnCount="2" RowsPerPage="2" />
        <ItemTemplate>
            <div class="BottomMargin">
                <dx:ASPxBinaryImage ID="ASPxBinaryImage1" runat="server" Value='<%# Eval("Photo") %>' />
            </div>
            <div>
                <div class="BottomMargin">
                <b>FirstName:</b>
                <dx:ASPxLabel ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstName") %>' />
            </div>
            <div class="BottomMargin">
                <b>LastName:</b>
                <dx:ASPxLabel ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>' />
            </div>
            <div class="BottomMargin">
                <b>Title:</b>
                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text='<%# Eval("Title") %>' />
            </div>
            </div>
        </ItemTemplate>
        <PagerSettings SEOFriendly="Enabled">
            <AllButton Visible="True" />
        </PagerSettings>
    </dx:ASPxDataView>
    <ef:EntityDataSource ID="EmployeesDataSource" runat="server" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>
