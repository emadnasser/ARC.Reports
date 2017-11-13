<%@ Control Language="C#" AutoEventWireup="true" CodeFile="TasksCardView.ascx.cs" Inherits="UserControls_ViewControls_TasksCardView" %>
<dx:ASPxCardView ID="TaskCardView" ClientInstanceName="taskCardView" CssClass="tasksCardViewer" EnableViewState="false" EnableCardsCache="False" KeyFieldName="Id" Width="100%" runat="server">
    <CardLayoutProperties>
        <Items>
            <dx:CardViewColumnLayoutItem CssClass="taskCardHeader">
                <Template>
                    <span><%# HighlightSearchText(Container, "Subject") %></span>
                    <dx:ASPxImage runat="server" ID="PriorityImage" ImageUrl="<%# GetPriorityImageUrl(Container) %>"/>
                </Template>
            </dx:CardViewColumnLayoutItem>
            <dx:CardViewColumnLayoutItem CssClass="taskCardContent">
                <Template>
                    <table class="taskCardData">
                        <tr>
                            <td>
                                <span>Start Date</span>
                                <%# ((DateTime) Eval("StartDate")).ToShortDateString() %>
                            </td>
                            <td>
                                <span>Due Date</span>
                                <%# ((DateTime) Eval("DueDate")).ToShortDateString() %>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <span>Assigned To</span>
                                <span class="fullName"><%# HighlightSearchText(Container, "AssignedEmployee.FirstName") + " " + HighlightSearchText(Container, "AssignedEmployee.LastName") %></span>
                            </td>
                        </tr>
                    </table>
                    <div class="taskCardProgress">
                        <%# Eval("Completion") %>%
                        <dx:ASPxProgressBar ID="ASPxProgressBar2" ShowPosition="false" runat="server" Position='<%# (int) Eval("Completion") %>' Height="10px" Width="100%"></dx:ASPxProgressBar>
                    </div>
                </Template>
            </dx:CardViewColumnLayoutItem>
            <dx:CardViewColumnLayoutItem CssClass="taskCardFooter">
                <Template>
                    <dx:ASPxCheckBox runat="server" ID="CompletedCheckBox" ReadOnly="true" CssClass="taskCardComplete"
                                     Checked="<%# GetCheckedState(Container) %>" Text="Mark as Completed">
                    </dx:ASPxCheckBox>
                    <dx:ASPxButton runat="server" ID="ViewButton" Text="View" AutoPostBack="false" UseSubmitBehavior="False" EnableTheming="false" CssClass="blueButton" OnLoad="ViewButton_Load">
                        <ClientSideEvents Click="DevAV.Page.ViewButton_Click"/>
                    </dx:ASPxButton>
                    <dx:ASPxButton runat="server" ID="EditButton" Text="Edit" AutoPostBack="false" UseSubmitBehavior="False" EnableTheming="false" CssClass="blueButton" OnLoad="EditButton_Load">
                        <ClientSideEvents Click="DevAV.Page.EditButton_Click"/>
                    </dx:ASPxButton>
                    <dx:ASPxButton runat="server" ID="DeleteButton" Text="Delete" AutoPostBack="false" UseSubmitBehavior="False" EnableTheming="false" CssClass="blueButton" OnLoad="DeleteButton_Load">
                        <ClientSideEvents Click="DevAV.Page.DeleteButton_Click"/>
                    </dx:ASPxButton>
                </Template>
            </dx:CardViewColumnLayoutItem>
        </Items>
        <SettingsItems ShowCaption="False">
        </SettingsItems>
        <Styles>
            <LayoutItem>
                <Paddings Padding="0"></Paddings>
            </LayoutItem>
            <LayoutGroup>
                <Cell>
                    <Paddings Padding="0"></Paddings>
                </Cell>
            </LayoutGroup>
        </Styles>
    </CardLayoutProperties>
    <ClientSideEvents Init="DevAV.CardView_Init" EndCallback="DevAV.CardView_EndCallback" />
    <Settings LayoutMode="Flow" VerticalScrollBarMode="Auto"></Settings>
    <SettingsBehavior AllowFocusedCard="True"></SettingsBehavior>
    <SettingsPager AlwaysShowPager="True" ShowNumericButtons="False">
        <FirstPageButton Visible="True"></FirstPageButton>
        <LastPageButton Visible="True"></LastPageButton>
        <SettingsFlowLayout ItemsPerPage="12"></SettingsFlowLayout>
        <Summary Position="Inside" Text="Page {0} of {1}"></Summary>
    </SettingsPager>
    <SettingsSearchPanel CustomEditorID="SearchBox" HighlightResults="True" ColumnNames="FirstName; LastName"></SettingsSearchPanel>
    <Styles>
        <Table>
            <Border BorderWidth="0"></Border>
        </Table>
        <FlowCard Width="380" Height="175" CssClass="dvCard">
            <Border BorderWidth="1"></Border>
        </FlowCard>
        <FocusedCard CssClass="focusCard">
        </FocusedCard>
        <PagerBottomPanel HorizontalAlign="Right"></PagerBottomPanel>
    </Styles>
</dx:ASPxCardView>
