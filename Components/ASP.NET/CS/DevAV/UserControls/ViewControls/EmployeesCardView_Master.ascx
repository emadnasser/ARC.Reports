<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmployeesCardView_Master.ascx.cs" Inherits="UserControls_ViewControls_EmployeesCardView_Master" %>
<dx:ASPxCardView ID="EmployeeCardView" ClientInstanceName="employeeCardView" CssClass="employeesCardViewer" EnableViewState="false" EnableCardsCache="False" KeyFieldName="Id" Width="100%" runat="server">
    <CardLayoutProperties ColCount="3" ShowItemCaptionColon="False">
        <Items>
            <dx:CardViewColumnLayoutItem ColumnName="FirstName" Visible="false" />
            <dx:CardViewColumnLayoutItem ColumnName="LastName" Visible="false" />
            <dx:CardViewColumnLayoutItem RowSpan="5" Width="110">
                <Template>
                    <dx:ASPxImage ID="EmployeeImage" runat="server" ImageUrl="<% # GetEmployeeImageUrl(Convert.ToInt64(Container.KeyValue)) %>" Width="100" Height="122"/>
                </Template>
            </dx:CardViewColumnLayoutItem>
            <dx:CardViewColumnLayoutItem CssClass="textContainer" Width="150">
                <Paddings PaddingBottom="15"></Paddings>
                <Template>
                    <h5><%# HighlightSearchText(Container, "FirstName") %> <%# HighlightSearchText(Container, "LastName") %></h5>
                </Template>
            </dx:CardViewColumnLayoutItem>
            <dx:CardViewColumnLayoutItem CssClass="textContainer" RowSpan="5">
                <Template>
                    <dx:ASPxImage ID="EditImage" runat="server" ImageUrl="~/Content/Images/Buttons/EditCustomerButton_White.png" OnLoad="EditImage_Load" CssClass="editIcon">
                        <ClientSideEvents click="DevAV.Page.EmployeeEditButton_Click"/>
                    </dx:ASPxImage>
                </Template>
            </dx:CardViewColumnLayoutItem>
            <dx:CardViewColumnLayoutItem CssClass="textContainer">
                <Template><%# Eval("Address.Line") %></Template>
            </dx:CardViewColumnLayoutItem>
            <dx:CardViewColumnLayoutItem CssClass="textContainer">
                <Template><%# Eval("Address.City") %>, <%# Eval("Address.State") %></Template>
            </dx:CardViewColumnLayoutItem>
            <dx:CardViewColumnLayoutItem ColumnName="MobilePhone" CssClass="textContainer"></dx:CardViewColumnLayoutItem>
            <dx:CardViewColumnLayoutItem ColumnName="Email" CssClass="textContainer">
                <Paddings PaddingBottom="15"></Paddings>
            </dx:CardViewColumnLayoutItem>
        </Items>
        <SettingsItems ShowCaption="False">
        </SettingsItems>
        <Styles>
            <LayoutGroup>
                <Cell>
                    <Paddings Padding="0"></Paddings>
                </Cell>
            </LayoutGroup>
            <LayoutItem>
                <Paddings Padding="0px"/>
            </LayoutItem>
        </Styles>
    </CardLayoutProperties>
    <ClientSideEvents Init="DevAV.CardView_Init" EndCallback="DevAV.CardView_EndCallback" FocusedCardChanged="DevAV.Page.EmployeesGrid_FocusedRowChanged"/>
    <Settings LayoutMode="Flow" VerticalScrollBarMode="Auto"></Settings>
    <SettingsBehavior AllowFocusedCard="True"></SettingsBehavior>
    <SettingsPager AlwaysShowPager="True" ShowNumericButtons="False">
        <FirstPageButton Visible="True"></FirstPageButton>
        <LastPageButton Visible="True"></LastPageButton>
        <Summary Text="Page {0} of {1}"></Summary>
    </SettingsPager>
    <SettingsSearchPanel CustomEditorID="SearchBox" HighlightResults="True" ColumnNames="FirstName; LastName"></SettingsSearchPanel>
    <Styles>
        <Table>
            <Border BorderWidth="0"></Border>
        </Table>
        <FlowCard Width="300" Height="134" CssClass="dvCard">
            <Border BorderWidth="0"></Border>
        </FlowCard>
        <FocusedCard CssClass="focusCard">
            <Border BorderWidth="0"></Border>
        </FocusedCard>
        <PagerBottomPanel HorizontalAlign="Right"></PagerBottomPanel>
    </Styles>
</dx:ASPxCardView>
