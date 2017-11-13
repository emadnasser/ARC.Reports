<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="PagerSettings.aspx.cs" Inherits="PagingAndScrolling_PagerSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxFormLayout ID="Details" ClientInstanceName="Details" runat="server" ColCount="2">
        <Items>
            <dx:LayoutItem Caption="Position">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxComboBox ID="Position" runat="server" AutoPostBack="true" SelectedIndex="2">
                            <Items>
                                <dx:ListEditItem Value="Bottom" Text="Bottom" />
                                <dx:ListEditItem Value="Top" Text="Top" />
                                <dx:ListEditItem Value="TopAndBottom" Text="TopAndBottom" />
                            </Items>
                        </dx:ASPxComboBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="ShowDisabledButtons">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxCheckBox ID="ShowDisabledButtons" runat="server" AutoPostBack="true" Checked="true" />
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="PageSizeItem position">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxComboBox ID="PageSizePosition" runat="server" AutoPostBack="true" SelectedIndex="1">
                            <Items>
                                <dx:ListEditItem Value="Left" Text="Left" />
                                <dx:ListEditItem Value="Right" Text="Right" />
                            </Items>
                        </dx:ASPxComboBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="ShowNumericButtons">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxCheckBox ID="ShowNumericButtons" runat="server" AutoPostBack="true" Checked="true" />
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Show PageSizeItem">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxCheckBox ID="ShowPageSizeItems" runat="server" Checked="true" AutoPostBack="true" />
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="ShowSeparators">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxCheckBox ID="ShowSeparators" runat="server" AutoPostBack="true" Checked="true" />
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Show Summary">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxCheckBox ID="ShowSummary" runat="server" AutoPostBack="true" />
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
        </Items>
    </dx:ASPxFormLayout>
    <dx:ASPxVerticalGrid ID="VerticalGrid" runat="server" DataSourceID="InvoicesDataSource" Width="100%">
        <Rows>
            <dx:VerticalGridTextRow FieldName="ProductName">
                <RecordStyle Font-Bold="true" />
            </dx:VerticalGridTextRow>
            <dx:VerticalGridCategoryRow Caption="Company info">
                <Rows>
                    <dx:VerticalGridTextRow FieldName="CompanyName" />
                    <dx:VerticalGridTextRow FieldName="Address" />
                    <dx:VerticalGridTextRow FieldName="Country" />
                    <dx:VerticalGridTextRow FieldName="City" />
                </Rows>
            </dx:VerticalGridCategoryRow>
            <dx:VerticalGridCategoryRow Caption="Pricing">
                <Rows>
                    <dx:VerticalGridTextRow FieldName="UnitPrice">
                        <PropertiesTextEdit DisplayFormatString="c" />
                    </dx:VerticalGridTextRow>
                    <dx:VerticalGridTextRow FieldName="Quantity" />
                    <dx:VerticalGridTextRow FieldName="Total" UnboundType="Decimal" UnboundExpression="UnitPrice * Quantity * (1 - Discount)">
                        <PropertiesTextEdit DisplayFormatString="{0:c}" />
                    </dx:VerticalGridTextRow>
                </Rows>
            </dx:VerticalGridCategoryRow>
        </Rows>
        <SettingsBehavior AllowRowExpanding="false" />
        <Settings HorizontalScrollBarMode="Visible" HeaderAreaWidth="150" RecordWidth="200" ShowCategoryIndents="false" />
    </dx:ASPxVerticalGrid>
    <ef:EntityDataSource runat="server" ID="InvoicesDataSource" ContextTypeName="NorthwindContext"
        CommandText="SELECT c.CompanyName AS CompanyName, i.OrderID, i.Country, i.City, i.Address, i.PostalCode, i.ProductName, i.UnitPrice, i.Quantity, i.Discount FROM Invoices as i INNER JOIN Customers as c ON c.CustomerId = i.CustomerId" />
</asp:Content>
