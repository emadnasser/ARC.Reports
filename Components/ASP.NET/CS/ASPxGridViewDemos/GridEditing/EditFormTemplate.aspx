<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EditFormTemplate.aspx.cs"
    Inherits="GridEditing_EditFormTemplate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxCheckBox runat="server" ID="chkPopup" AutoPostBack="true" Text="Show Edit Form as Popup" />
    <br />
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="DemoDataSource1"
        KeyFieldName="EmployeeID" AutoGenerateColumns="False" OnRowUpdating="grid_RowUpdating"
        Width="100%" OnRowInserting="grid_RowInserting">
        <Columns>
            <dx:GridViewCommandColumn ShowNewButtonInHeader="true" ShowEditButton="true" VisibleIndex="0" />
            <dx:GridViewDataTextColumn FieldName="FirstName" VisibleIndex="1">
                <EditFormSettings VisibleIndex="0" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColumn FieldName="LastName" VisibleIndex="2">
                <EditFormSettings VisibleIndex="1" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="Title" VisibleIndex="4">
                <EditFormSettings VisibleIndex="2" ColumnSpan="2" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataMemoColumn FieldName="Notes" Visible="False">
            </dx:GridViewDataMemoColumn>
            <dx:GridViewDataColumn FieldName="BirthDate" VisibleIndex="3">
                <EditFormSettings VisibleIndex="3" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="HireDate" VisibleIndex="5">
                <EditFormSettings VisibleIndex="4" />
            </dx:GridViewDataColumn>
        </Columns>
        <SettingsPager Mode="ShowAllRecords" />
        <SettingsPopup>
            <EditForm Width="600" Modal="true" />
        </SettingsPopup>
        <Templates>
            <EditForm>
                <div style="padding: 4px 3px 4px">
                    <dx:ASPxPageControl runat="server" ID="pageControl" Width="100%">
                        <TabPages>
                            <dx:TabPage Text="Info" Visible="true">
                                <ContentCollection>
                                    <dx:ContentControl runat="server">
                                        <dx:ASPxGridViewTemplateReplacement ID="Editors" ReplacementType="EditFormEditors"
                                            runat="server">
                                        </dx:ASPxGridViewTemplateReplacement>
                                    </dx:ContentControl>
                                </ContentCollection>
                            </dx:TabPage>
                            <dx:TabPage Text="Notes" Visible="true">
                                <ContentCollection>
                                    <dx:ContentControl runat="server">
                                        <dx:ASPxMemo runat="server" ID="notesEditor" Text='<%# Eval("Notes")%>' Width="100%"
                                            Height="93px">
                                        </dx:ASPxMemo>
                                    </dx:ContentControl>
                                </ContentCollection>
                            </dx:TabPage>
                        </TabPages>
                    </dx:ASPxPageControl>
                </div>
                <div style="text-align: right; padding: 2px">
                    <dx:ASPxGridViewTemplateReplacement ID="UpdateButton" ReplacementType="EditFormUpdateButton"
                        runat="server">
                    </dx:ASPxGridViewTemplateReplacement>
                    <dx:ASPxGridViewTemplateReplacement ID="CancelButton" ReplacementType="EditFormCancelButton"
                        runat="server">
                    </dx:ASPxGridViewTemplateReplacement>
                </div>
            </EditForm>
        </Templates>
    </dx:ASPxGridView>
    <demo:DemoDataSource runat="server" ID="DemoDataSource1" DataSourceID="EmployeesDataSource" IdentityKey="EmployeeID"></demo:DemoDataSource>
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource"
        ContextTypeName="NorthwindContext"
        EnableDelete="True" EnableInsert="True" EnableUpdate="True"
        EntitySetName="Employees">
    </ef:EntityDataSource>
</asp:Content>
