<%@ Control Language="C#" AutoEventWireup="true" CodeFile="EmployeesCardView_Detail.ascx.cs" Inherits="UserControls_ViewControls_EmployeesCardView_Detail" %>
<span id="EmployeeNameText" runat="server" class="emplName"></span>&nbsp;&nbsp; <%--TODO replace to ASPxLabel--%>
<span id="EmployeeDepartmentText" runat="server" class="emplDepartment"></span>
<dx:ASPxPageControl ID="DetailsPageControl" runat="server" Width="100%" ActiveTabIndex="0" TabAlign="Right" CssClass="emplCardViewDetailsPages">
    <TabPages>
        <dx:TabPage Name="Evaluations" Text="Evaluations">
            <ContentCollection>
                <dx:ContentControl>
                    <dx:ASPxGridView ID="EvaluationGridView" runat="server" Width="100%" CssClass="emplEvaluationGridView" KeyFieldName="Id">
                        <Settings VerticalScrollBarMode="Auto" VerticalScrollableHeight="170" GridLines="None" />
                        <SettingsBehavior AllowFocusedRow="true" />
                        <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                        <ClientSideEvents CustomButtonClick="DevAV.Page.EvaluationGrid_CustomButtonClick" />
                        <Columns>
                            <dx:GridViewDataTextColumn Caption="Subject" FieldName="Subject">
                                <DataItemTemplate>
                                    <b><%# Eval("Subject") %></b><br />
                                    <%# Eval("Details") %>
                                </DataItemTemplate>
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataDateColumn Caption="Created On" FieldName="CreatedOn" Width="100px"></dx:GridViewDataDateColumn>
                            <dx:GridViewCommandColumn Caption=" " Width="120px">
                                <CustomButtons>
                                    <dx:GridViewCommandColumnCustomButton ID="EvaluationEditBtn" Text="Edit"></dx:GridViewCommandColumnCustomButton>
                                    <dx:GridViewCommandColumnCustomButton ID="EvaluationDeleteBtn" Text="Delete"></dx:GridViewCommandColumnCustomButton>
                                </CustomButtons>
                            </dx:GridViewCommandColumn>
                        </Columns>
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
        <dx:TabPage Name="Tasks" Text="Tasks">
            <ContentCollection>
                <dx:ContentControl>
                    <dx:ASPxGridView runat="server" ID="CVTasksGridView" Width="100%" CssClass="emplTasksGridView" KeyFieldName="Id" PreviewFieldName="Description">
                        <Settings VerticalScrollBarMode="Auto" VerticalScrollableHeight="170" GridLines="None" ShowPreview="true" />
                        <SettingsBehavior AllowFocusedRow="true" />
                        <SettingsPager Mode="ShowAllRecords"></SettingsPager>
                        <ClientSideEvents CustomButtonClick="DevAV.Page.TaskGrid_CustomButtonClick" />
                        <Columns>
                            <dx:GridViewDataTextColumn Caption="Subject" FieldName="Subject"></dx:GridViewDataTextColumn>
                            <dx:GridViewDataDateColumn Caption="Start Date" FieldName="StartDate" Width="100px">
                                <PropertiesDateEdit AllowNull="true"></PropertiesDateEdit>
                            </dx:GridViewDataDateColumn>
                            <dx:GridViewDataDateColumn Caption="Due Date" FieldName="DueDate" Width="100px">
                                <PropertiesDateEdit AllowNull="true"></PropertiesDateEdit>
                            </dx:GridViewDataDateColumn>
                            <dx:GridViewDataColumn Caption="Priority" Width="80px">
                                <DataItemTemplate>
                                    <dx:ASPxImage runat="server" ID="PriorityImage" ImageUrl='<%# GetPriorityImageUrl(Container) %>' />
                                </DataItemTemplate>
                            </dx:GridViewDataColumn>
                            <dx:GridViewDataColumn Caption="% Completed" Width="200px">
                                <DataItemTemplate>
                                    <table>
                                        <tr>
                                            <td class="progressBarCell">
                                                <dx:ASPxProgressBar ID="ASPxProgressBar1" ShowPosition="false" runat="server" Position='<%# (int)Eval("Completion") %>' Height="10px" Width="100%"></dx:ASPxProgressBar>
                                            </td>
                                            <td>
                                                <%# Eval("Completion") %>%
                                            </td>
                                        </tr>
                                    </table>
                                </DataItemTemplate>
                            </dx:GridViewDataColumn>
                            <dx:GridViewCommandColumn Caption=" " Width="120px">
                                <CustomButtons>
                                    <dx:GridViewCommandColumnCustomButton ID="EditBtn" Text="Edit"></dx:GridViewCommandColumnCustomButton>
                                    <dx:GridViewCommandColumnCustomButton ID="DeleteBtn" Text="Delete"></dx:GridViewCommandColumnCustomButton>
                                </CustomButtons>
                            </dx:GridViewCommandColumn>
                        </Columns>
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
