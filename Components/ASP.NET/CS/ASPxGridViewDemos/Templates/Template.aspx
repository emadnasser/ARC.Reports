<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Template.aspx.cs"
    Inherits="Templates_Template" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">    
    <style type="text/css">
        .InfoTable td
        {
            padding: 0 4px;
            vertical-align: top;
        }
    </style>
    <%--start highlighted block--%>
    <script type="text/javascript">
        var keyValue;
        function OnMoreInfoClick(element, key) {
            callbackPanel.SetContentHtml("");
            popup.ShowAtElement(element);
            keyValue = key;
        }
        function popup_Shown(s, e) {
            callbackPanel.PerformCallback(keyValue);
        }
    </script>
    <%--end highlighted block--%>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxPopupControl ID="popup" ClientInstanceName="popup" runat="server" AllowDragging="true"
        PopupHorizontalAlign="OutsideRight" HeaderText="Photo & Notes">
        <ContentCollection>
            <dx:PopupControlContentControl runat="server">
                <dx:ASPxCallbackPanel ID="callbackPanel" ClientInstanceName="callbackPanel" runat="server"
                    Width="320px" Height="100px" OnCallback="callbackPanel_Callback" RenderMode="Table">
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <table class="InfoTable">
                                <tr>
                                    <td>
                                        <dx:ASPxBinaryImage ID="edBinaryImage" runat="server" AlternateText="Loading..." ImageAlign="Left" CssClass="Image">
                                        </dx:ASPxBinaryImage>
                                    </td>
                                    <td>
                                        <asp:Literal ID="litText" runat="server" Text=""></asp:Literal>
                                    </td>
                                </tr>
                            </table>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxCallbackPanel>
            </dx:PopupControlContentControl>
        </ContentCollection>
        <ClientSideEvents Shown="popup_Shown" />
    </dx:ASPxPopupControl>
    <dx:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="EmployeesDataSource"
        KeyFieldName="EmployeeID" Width="100%">
        <Columns>
            <dx:GridViewDataColumn FieldName="FirstName" VisibleIndex="1" />
            <dx:GridViewDataColumn FieldName="Title" VisibleIndex="4" />
            <dx:GridViewDataColumn FieldName="Notes" Visible="False" />
            <dx:GridViewDataColumn FieldName="LastName" VisibleIndex="2" />
            <dx:GridViewDataColumn FieldName="BirthDate" VisibleIndex="3" />
            <dx:GridViewDataColumn FieldName="HireDate" VisibleIndex="5" />
            <dx:GridViewDataColumn Caption="Details" VisibleIndex="8" Width="15%">
                <DataItemTemplate>
                    <a href="javascript:void(0);" onclick="OnMoreInfoClick(this, '<%# Container.KeyValue %>')">
                        More Info...</a>
                </DataItemTemplate>
            </dx:GridViewDataColumn>
        </Columns>
        <SettingsPager Mode="ShowAllRecords" />
    </dx:ASPxGridView>
    <ef:EntityDataSource runat="server" ID="EmployeesDataSource" ContextTypeName="NorthwindContext" EntitySetName="Employees" Where="it.Photo IS NOT NULL" />
</asp:Content>
