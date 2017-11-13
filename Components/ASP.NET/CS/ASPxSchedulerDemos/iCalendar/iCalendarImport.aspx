<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="iCalendarImport.aspx.cs"
    Inherits="iCalendar_iCalendarImport" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <script type="text/javascript">
        function Uploader_TextChanged() {
            uploader.UploadFile();
        }
        function Uploader_FileUploadStart() {
            scheduler.ShowLoadingPanel();
        }
        function Uploader_FileUploadComplete() {
            scheduler.HideLoadingPanel();
            scheduler.RaiseCallback("IMPRTAPT|");
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    <demo:DefaultDataSources runat="server" ID="DataSource1" UniqueSessionPrefix="iCalendarImport" InitAppointments="false" />
    <dx:ASPxRoundPanel ID="ASPxRoundPanel1" runat="server" Width="100%" HeaderText="Demo Options">
        <PanelCollection>
            <dx:PanelContent ID="PanelContent1" runat="server">
                <table class="OptionsTable">
                    <tr>
                        <td>
                            <dx:ASPxLabel ID="lblSelectImage" runat="server" Text="Select iCalendar file:&nbsp;">
                            </dx:ASPxLabel>
                        </td>
                        <td class="edit">
                            <dx:ASPxUploadControl ID="ASPxUploadControl1" runat="server" OnFileUploadComplete="ASPxUploadControl1_FileUploadComplete" 
                                ClientInstanceName="uploader">
                                <ValidationSettings MaxFileSize="1048576">
                                </ValidationSettings>
                                <ClientSideEvents TextChanged="function(s, e) { Uploader_TextChanged(); }" FilesUploadComplete="function(s, e) {Uploader_FileUploadComplete(); }"
                                    FilesUploadStart="function(s, e) {Uploader_FileUploadStart(); }" />
                            </dx:ASPxUploadControl>
                        </td>
                        <td>
                            <dx:ASPxCheckBox ID="ASPxCheckBox1" runat="server" Text="Clear existing appointments before import">
                            </dx:ASPxCheckBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td class="note">
                            <dx:ASPxLabel ID="lblMaxFileSize" runat="server" Text="Maximum file size: 1 MB" Font-Size="8pt">
                            </dx:ASPxLabel>
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxRoundPanel>
    <br />
    <dx:ASPxScheduler ID="ASPxScheduler1" runat="server" Width="100%" ActiveViewType="WorkWeek"
        ClientInstanceName="scheduler" OnBeforeExecuteCallbackCommand="ASPxScheduler1_BeforeExecuteCallbackCommand">
        <Storage EnableReminders="false"/>
        <Views>
            <DayView>
                <DayViewStyles ScrollAreaHeight="400px" />
            </DayView>
            <WorkWeekView>
                <WorkWeekViewStyles ScrollAreaHeight="400px" />
            </WorkWeekView>
            <FullWeekView Enabled="true">
                <FullWeekViewStyles ScrollAreaHeight="400px" />
            </FullWeekView>
            <WeekView Enabled="false"></WeekView>
        </Views>
    </dx:ASPxScheduler>
</asp:Content>
