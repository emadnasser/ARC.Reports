<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Example.aspx.cs"
    Inherits="HiddenField_Example" %>
<asp:Content runat="server" ContentPlaceHolderID="CustomHeadHolder">
    <script type="text/javascript">
        var viewsCount = 3;
        function ShowPrevPage(){
            ChangeActiveViewIndex(-1); 
        }
        function ShowNextPage(){
            ChangeActiveViewIndex(1);
        }
        <%--start highlighted block--%>
        function ChangeActiveViewIndex(changeIndex){
            hfAnswers.Set("questionIndex", GetQuestionIndex() + changeIndex);
            cpVoting.PerformCallback();
        }
        function GetQuestionIndex(){
            return hfAnswers.Get("questionIndex");
        }
        <%--end highlighted block--%>
        function SetButtonState(){
            btnPrev.SetVisible(GetQuestionIndex() > 0);
            btnNext.SetVisible(!IsPreviewPage());
            btnSubmit.SetVisible(IsPreviewPage());
        }
        function FixPanelHeight(){
            cpVoting.GetMainElement().style.height = cpVoting.GetMainElement().offsetHeight + "px";
        }
        function IsPreviewPage(){
            return GetQuestionIndex() == (viewsCount - 1);
        }
        <%--start highlighted block--%>
        function OnSeasonChanged(s, e){
            hfAnswers.Set("month", 0);
            hfAnswers.Set("season", s.GetSelectedIndex());
        }
        function OnMonthChanged(s, e){
            hfAnswers.Set("month", s.GetSelectedIndex());
        }
        <%--end highlighted block--%>
        function OnSubmit(s, e){
            var message = "Thank you for participating in the survey. Your answers will be posted to the server. The demo will be reloaded.";
            alert(message);
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <dx:ASPxRoundPanel ID="rp" ShowHeader="false" runat="server" Width="400px">
        <PanelCollection>
            <dx:PanelContent runat="server">
                <dx:ASPxCallbackPanel runat="server" ClientInstanceName="cpVoting" Width="400px" ID="cpVoting">
                    <ClientSideEvents EndCallback="SetButtonState" Init="FixPanelHeight"></ClientSideEvents>
                    <PanelCollection>
                        <dx:PanelContent runat="server">
                            <asp:MultiView runat="server" ActiveViewIndex="0" ID="mvVoting">
                                <asp:View runat="server" ID="View1">
                                    Select a season:
                                    <br />
                                    <dx:ASPxRadioButtonList runat="server" SelectedIndex="0" Width="258px" ID="rblSeasons">
                                        <Border BorderStyle="None"></Border>
                                        <ClientSideEvents SelectedIndexChanged="OnSeasonChanged" />
                                    </dx:ASPxRadioButtonList>
                                </asp:View>
                                <asp:View runat="server" ID="View2">
                                    Select a month:
                                    <br />
                                    <dx:ASPxRadioButtonList runat="server" Width="258px" ID="rblMonths">
                                        <Border BorderStyle="None"></Border>
                                        <ClientSideEvents SelectedIndexChanged="OnMonthChanged" />
                                    </dx:ASPxRadioButtonList>
                                </asp:View>
                                <asp:View runat="server" ID="View3">
                                    Your selections:<br />
                                    <br />
                                    <table>
                                        <tr>
                                            <td style="padding-left: 10px;">
                                                Season:</td>
                                            <td>
                                                <dx:ASPxLabel Font-Bold="true" ID="lblSelectedSeason" runat="server" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="padding-left: 10px;">
                                                Month:</td>
                                            <td>
                                                <dx:ASPxLabel Font-Bold="true" ID="lblSelectedMonth" runat="server" />
                                            </td>
                                        </tr>
                                    </table>
                                </asp:View>
                            </asp:MultiView>
                            <dx:ASPxHiddenField runat="server" ClientInstanceName="hfAnswers" ID="hfAnswers">
                            </dx:ASPxHiddenField>
                        </dx:PanelContent>
                    </PanelCollection>
                </dx:ASPxCallbackPanel>
                <div>
                    <dx:ASPxButton runat="server" ClientInstanceName="btnSubmit" ClientVisible="False"
                        Text="Submit" Width="70px" ID="btnSubmit" OnClick="btnSubmit_Click" style="margin-left: 12px; float: right;">
                        <ClientSideEvents Click="OnSubmit" />
                    </dx:ASPxButton>
                    <dx:ASPxButton runat="server" AutoPostBack="False" ClientInstanceName="btnNext" Text="Next"
                        Width="70px" ID="btnNext" style="margin-left: 12px; float: right;">
                        <ClientSideEvents Click="ShowNextPage" />
                    </dx:ASPxButton>
                    <dx:ASPxButton runat="server" AutoPostBack="False" ClientInstanceName="btnPrev" ClientVisible="False"
                        Text="Prev" Width="70px" ID="btnPrev" style="margin-left: 12px; float: right;">
                        <ClientSideEvents Click="ShowPrevPage" />
                    </dx:ASPxButton>
                </div>
                <script type="text/javascript">
                    SetButtonState();
                </script>
            </dx:PanelContent>
        </PanelCollection>
        <ContentPaddings Padding="12px" />
    </dx:ASPxRoundPanel>
</asp:Content>
