<%@ Control Language="vb" AutoEventWireup="true" CodeFile="EmployeesGridView_Detail.ascx.vb" Inherits="UserControls_ViewControls_EmployeesGridView_Detail" %>
<div class="employeesDetailsMainContainer">
    <div class="employeesDetailsContainer">
        <table>
            <tr>
                <td>
                    <dx:ASPxHeadline ID="DetailsHeaderHeadLine" CssClass="employeesDetailsHeadline" runat="server" HeaderText="Employee's Name" ContentText="Position">
                        <HeaderStyle CssClass="header" />
                        <ContentStyle CssClass="content"></ContentStyle>
                        <RightPanelStyle CssClass="rightPanel"></RightPanelStyle>
                    </dx:ASPxHeadline>
                </td>
                <td class="employeeEditButtonCell">
                    <dx:ASPxImage ID="EditImage" runat="server" ImageUrl="~/Content/Images/Buttons/EditCustomerButton_Gray.png">
                        <ClientSideEvents Click="DevAV.Page.EmployeeEditButton_Click"/>
                    </dx:ASPxImage>
                </td>
            </tr>
        </table>
        <table class="employeesDetailsInfo">
            <tr>
                <td>
                    <dx:ASPxImage ID="EmployeeImage" runat="server" Height="170" />
                </td>
                <td>
                    <h5>ADDRESS</h5>
                    <span runat="server" id="DetailsAddressText"></span>
                    <h5>PHONE</h5>
                    <span runat="server" id="DetailsPhoneText"></span>
                    <h5>EMAIL</h5>
                    <span runat="server" id="DetailsEmailText"></span>
                </td>
            </tr>
        </table>
    </div>
    <div class="employeesPagesContainer">
        <dx:ASPxPageControl ID="DetailsPageControl" runat="server" ActiveTabIndex="0" Width="100%" CssClass="emplGridViewDetailsPages">
            <TabPages>
                <dx:TabPage Text="Evaluations" Name="Evaluations">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                            <dx:ASPxGridView ID="EvaluationGrid" ClientInstanceName="evaluationGrid" runat="server" Width="100%" CssClass="emplEvaluationGridView" KeyFieldName="Id">
                                <Columns>
                                    <dx:GridViewDataTextColumn Caption="Subject" FieldName="Subject"></dx:GridViewDataTextColumn>
                                    <dx:GridViewDataDateColumn Caption="Created On" FieldName="CreatedOn" Width="100px"></dx:GridViewDataDateColumn>
                                    <dx:GridViewCommandColumn Caption=" " Width="120px">
                                        <CustomButtons>
                                            <dx:GridViewCommandColumnCustomButton ID="EvaluationEditBtn" Text="Edit"></dx:GridViewCommandColumnCustomButton>
                                            <dx:GridViewCommandColumnCustomButton ID="EvaluationDeleteBtn" Text="Delete"></dx:GridViewCommandColumnCustomButton>
                                        </CustomButtons>
                                    </dx:GridViewCommandColumn>
                                </Columns>
                                <Settings VerticalScrollBarMode="Auto" VerticalScrollableHeight="190" GridLines="None" />
                                <SettingsBehavior AllowFocusedRow="true" />
                                <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                                <ClientSideEvents CustomButtonClick="DevAV.Page.EvaluationGrid_CustomButtonClick" />
                                <Styles>
                                    <Table CssClass="dataTable"></Table>
                                    <Header CssClass="header"></Header>
                                    <CommandColumn CssClass="commandColumn"></CommandColumn>
                                    <CommandColumnItem CssClass="commandColumnBtn"></CommandColumnItem>
                                    <FocusedRow CssClass="focusRow"></FocusedRow>
                                </Styles>
                            </dx:ASPxGridView>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="Tasks" Name="Tasks">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            <dx:ASPxGridView ID="TasksGrid" ClientInstanceName="tasksGrid" runat="server" Width="100%" CssClass="emplTasksGridView" KeyFieldName="Id">
                                <Columns>
                                    <dx:GridViewDataTextColumn Caption="Subject" FieldName="Subject"></dx:GridViewDataTextColumn>
                                    <dx:GridViewDataDateColumn Caption="Due Date" FieldName="DueDate" Width="100px"></dx:GridViewDataDateColumn>
                                    <dx:GridViewCommandColumn Caption=" " Width="120px">
                                        <CustomButtons>
                                            <dx:GridViewCommandColumnCustomButton ID="EditBtn" Text="Edit"></dx:GridViewCommandColumnCustomButton>
                                            <dx:GridViewCommandColumnCustomButton ID="DeleteBtn" Text="Delete"></dx:GridViewCommandColumnCustomButton>
                                        </CustomButtons>
                                    </dx:GridViewCommandColumn>
                                </Columns>
                                <Settings VerticalScrollBarMode="Auto" VerticalScrollableHeight="190" GridLines="None" />
                                <SettingsBehavior AllowFocusedRow="true" />
                                <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                                <ClientSideEvents CustomButtonClick="DevAV.Page.TaskGrid_CustomButtonClick" />
                                <Styles>
                                    <Table CssClass="dataTable"></Table>
                                    <Header CssClass="header"></Header>
                                    <CommandColumn CssClass="commandColumn"></CommandColumn>
                                    <CommandColumnItem CssClass="commandColumnBtn"></CommandColumnItem>
                                    <FocusedRow CssClass="focusRow"></FocusedRow>
                                </Styles>
                            </dx:ASPxGridView>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
            </TabPages>
        </dx:ASPxPageControl>
    </div>
</div>