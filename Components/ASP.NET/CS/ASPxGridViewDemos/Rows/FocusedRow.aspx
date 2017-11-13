<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="FocusedRow.aspx.cs"
    Inherits="Rows_FocusedRow" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function OnGridFocusedRowChanged() {
            // Query the server for the "EmployeeID" and "Notes" fields from the focused row 
            // The values will be returned to the OnGetRowValues() function
            DetailNotes.SetText("Loading...");
            grid.GetRowValues(grid.GetFocusedRowIndex(), 'EmployeeID;Notes', OnGetRowValues);
        }
        // Value array contains "EmployeeID" and "Notes" field values returned from the server 
        function OnGetRowValues(values) {            
            DetailImage.SetImageUrl("FocusedRow.aspx?Photo=" + values[0]);
            DetailImage.SetVisible(true);
            DetailNotes.SetText(values[1]);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="EmployeesDataSource"
        KeyFieldName="EmployeeID" PreviewFieldName="Notes" AutoGenerateColumns="False"
        EnableRowsCache="false" Width="100%">
        <Columns>
            <dx:GridViewDataColumn FieldName="FirstName" VisibleIndex="0" />
            <dx:GridViewDataColumn FieldName="Title" VisibleIndex="3" />
            <dx:GridViewDataColumn FieldName="LastName" VisibleIndex="1" />
            <dx:GridViewDataColumn FieldName="BirthDate" VisibleIndex="2" />
            <dx:GridViewDataColumn FieldName="HireDate" VisibleIndex="4" />
        </Columns>
        <Settings ShowGroupPanel="true" />
        <SettingsBehavior AllowFocusedRow="True" />
        <ClientSideEvents FocusedRowChanged="function(s, e) { OnGridFocusedRowChanged(); }" />
    </dx:ASPxGridView>
    
    <table style="width: 100%; height: 200px" class="OptionsTable TopMargin">
        <tr>
            <td style="width: 160px">
                <dx:ASPxImage runat="server" ID="DetailImage" ClientInstanceName="DetailImage" ClientVisible="false" Width="160px" />
            </td>
            <td class="LeftPadding">
                <dx:ASPxMemo runat="server" ID="DetailNotes" ClientInstanceName="DetailNotes" Width="100%"
                    Height="170" ReadOnly="true" />
            </td>
        </tr>
    </table>
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" />
</asp:Content>
