<%@ Control Language="vb" AutoEventWireup="true" CodeFile="TasksGridView.ascx.vb" Inherits="UserControls_ViewControls_TasksGridView" %>
<dx:ASPxGridView ID="TaskGrid" runat="server" ClientInstanceName="taskGrid" AutoGenerateColumns="False" 
    KeyFieldName="Id" PreviewFieldName="Description" Width="100%" CssClass="tasksGridView">
    <Columns>
        <dx:GridViewDataTextColumn FieldName="Subject" Settings-AllowFilterBySearchPanel="True" />
        <dx:GridViewDataDateColumn Caption="Start Date" FieldName="StartDate" Width="100" PropertiesDateEdit-DisplayFormatString="MM/dd/yyyy" />
        <dx:GridViewDataDateColumn Caption="Due Date" FieldName="DueDate" Width="100" />
        <dx:GridViewDataComboBoxColumn FieldName="Priority" Width="80">
            <PropertiesComboBox>
                <Items>
                    <dx:ListEditItem Text="" Value="Low" ImageUrl="~/Content/Images/Priority/Priority1.png" />
                    <dx:ListEditItem Text="" Value="Normal" ImageUrl="~/Content/Images/Priority/Priority2.png" />
                    <dx:ListEditItem Text="" Value="High" ImageUrl="~/Content/Images/Priority/Priority3.png" />
                    <dx:ListEditItem Text="" Value="Urgent" ImageUrl="~/Content/Images/Priority/Priority4.png" />
                </Items>
            </PropertiesComboBox>
        </dx:GridViewDataComboBoxColumn>
        <dx:GridViewDataColumn Caption="% Completed" Width="200">
            <DataItemTemplate>
                <table><tr><td class="progressBarCell">
                    <dx:ASPxProgressBar ID="Progress" runat="server" ShowPosition="false" Position='<%#DirectCast(Eval("Completion"), Integer)%>' Width="140" Height="10" />
                </td><td>
                    <%#Eval("Completion")%>%
                </td></tr></table>
            </DataItemTemplate>
        </dx:GridViewDataColumn>
        <dx:GridViewCommandColumn  Caption=" " Width="120px">
            <CustomButtons>
                <dx:GridViewCommandColumnCustomButton Text="Edit" ID="EditBtn" />
                <dx:GridViewCommandColumnCustomButton Text="Delete" ID="DeleteBtn" />
            </CustomButtons>
        </dx:GridViewCommandColumn>
    </Columns>
    <Templates>
        <PreviewRow>
            <div onclick="taskGrid.SetFocusedRowIndex(<%#Container.VisibleIndex%>)"><%#GetDescription(Container)%></div>
        </PreviewRow>
    </Templates>
    <Settings ShowPreview="true" GridLines="None" VerticalScrollBarMode="Auto" VerticalScrollableHeight="600" />
    <SettingsSearchPanel CustomEditorID="SearchBox" />
    <SettingsBehavior AllowFocusedRow="true" />
    <SettingsPager PageSize="9" NumericButtonCount="4" AlwaysShowPager="true" />
    <SettingsContextMenu Enabled="true">
        <ColumnMenuItemVisibility ShowFooter="false" ShowFilterRow="false" GroupByColumn="false" ShowGroupPanel="false" />
    </SettingsContextMenu>
    <SettingsPopup>
        <CustomizationWindow HorizontalAlign="LeftSides" VerticalAlign="Below" />
    </SettingsPopup>
    <ClientSideEvents CustomButtonClick="DevAV.Page.TaskGrid_CustomButtonClick" ContextMenuItemClick="DevAV.Page.TasksGrid_ContextMenuItemClick" />
    <Styles>
        <Table CssClass="dataTable" />
        <Header CssClass="header" />
        <CommandColumn CssClass="commandColumn" />
        <CommandColumnItem CssClass="commandColumnBtn" />
        <FocusedRow CssClass="focusRow" />
        <PreviewRow CssClass="preview" />
    </Styles>
</dx:ASPxGridView>