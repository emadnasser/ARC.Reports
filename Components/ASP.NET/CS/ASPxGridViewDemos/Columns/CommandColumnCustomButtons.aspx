<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="CommandColumnCustomButtons.aspx.cs"
    Inherits="Columns_CommandColumnCustomButtons" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="DemoDataSource1"
        KeyFieldName="EmployeeID" AutoGenerateColumns="False" Width="100%" OnCustomButtonCallback="grid_CustomButtonCallback"
        OnInitNewRow="grid_InitNewRow">
        <Columns>
            <dx:GridViewCommandColumn ShowNewButton="true" ShowEditButton="true" VisibleIndex="0" ButtonRenderMode="Image">
                <CustomButtons>
                    <dx:GridViewCommandColumnCustomButton ID="Clone">
                        <Image ToolTip="Clone Record" Url="Images/clone.png" />
                    </dx:GridViewCommandColumnCustomButton>
                </CustomButtons>
            </dx:GridViewCommandColumn>
            <dx:GridViewDataTextColumn FieldName="FirstName" VisibleIndex="1">
                <EditFormSettings VisibleIndex="0" />
            </dx:GridViewDataTextColumn>
            <dx:GridViewDataColumn FieldName="Title" VisibleIndex="4">
                <EditFormSettings VisibleIndex="1" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataMemoColumn FieldName="Notes" Visible="False">
                <EditFormSettings RowSpan="4" Visible="True" VisibleIndex="2" />
            </dx:GridViewDataMemoColumn>
            <dx:GridViewDataColumn FieldName="LastName" VisibleIndex="2">
                <EditFormSettings VisibleIndex="3" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="BirthDate" VisibleIndex="3">
                <EditFormSettings VisibleIndex="4" />
            </dx:GridViewDataColumn>
            <dx:GridViewDataColumn FieldName="HireDate" VisibleIndex="5">
                <EditFormSettings VisibleIndex="5" />
            </dx:GridViewDataColumn>
        </Columns>
        <SettingsEditing EditFormColumnCount="3" />
        <SettingsPager Mode="ShowAllRecords" />
        <SettingsCommandButton>
            <NewButton>
                <Image ToolTip="New" Url="Images/new.png" />
            </NewButton>
            <EditButton>
                <Image ToolTip="Edit" Url="Images/edit.png" />
            </EditButton>
            <UpdateButton RenderMode="Image">
                <Image ToolTip="Save changes and close Edit Form" Url="Images/update.png" />
            </UpdateButton>
            <CancelButton RenderMode="Image">
                <Image ToolTip="Close Edit Form without saving changes" Url="Images/cancel.png" />
            </CancelButton>
        </SettingsCommandButton>
        <Styles>
            <CommandColumn Spacing="2px" Wrap="False" />
        </Styles>
    </dx:ASPxGridView>
    <demo:DemoDataSource runat="server" ID="DemoDataSource1" DataSourceID="EmployeesDataSource" IdentityKey="EmployeeID"></demo:DemoDataSource>
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" EnableDelete="true" EnableUpdate="true" EnableInsert="true" />
</asp:Content>
