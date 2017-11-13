<%@ Page Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ServerSide.aspx.cs"
    Inherits="PopupControl_ServerSide" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="Server">
    <%--start highlighted block--%>
    <script type="text/javascript">
        function PC_OnInit() {
            btnShowAllNotes.SetEnabled(false);
            if(pcMain.GetWindowCount() > 0) {
                for (var i = 0; i < pcMain.GetWindowCount(); i++) {
                    var window = pcMain.GetWindow(i);
                    if (!pcMain.IsWindowVisible(window)) {
                        btnShowAllNotes.SetEnabled(true);
                        break;
                    }
                }
            }
            btnClearAllNotes.SetEnabled(pcMain.GetWindowCount() > 0);
            btnCreateNote.SetEnabled(false);
            TBWindowContentReset();
        }
        function PC_OnCloseUp() {
            btnShowAllNotes.SetEnabled(true);
        }
        function PC_OnPopUp() {
            btnClearAllNotes.SetEnabled(true);
        }
        function ShowAllNotes() {
            for (var i = 0; i < pcMain.GetWindowCount(); i++) {
                var window = pcMain.GetWindow(i);
                if (!pcMain.IsWindowVisible(window))
                    pcMain.ShowWindow(window);
            }
            btnShowAllNotes.SetEnabled(false);
        }
        function TBWindowContentFocus() {
            if(!btnCreateNote.GetEnabled()) {
                mContent.SetText('');
                SetMemoInactive(false);
            }
        }
        function TBWindowContentChange() {
            if(mContent.GetText() != '')
                btnCreateNote.SetEnabled(true);
        }
        function ImposeMaxLength(maxLength) {
            return mContent.GetText().length <= maxLength;
        }
        function TBWindowContentBlur() {
            if(mContent.GetText() == '') {
                TBWindowContentReset();
                btnCreateNote.SetEnabled(false);
            }
        }
        function TBWindowContentReset() {
            mContent.SetText('[Enter some text here and then press the Create Note button]');
            SetMemoInactive(true);
        }
        function SetMemoInactive(value) {
            mContent.GetInputElement().style.color = value ? 'gray' : '';
        }
    </script>
    <%--end highlighted block--%>
    <dx:ASPxPopupControl ClientInstanceName="pcMain" SkinID="None" EnableHotTrack="False"
        HeaderText="Note" AllowDragging="True" CloseAction="CloseButton" PopupHorizontalAlign="LeftSides"
        PopupVerticalAlign="TopSides" ID="ASPxPopupControl1" runat="server" ShowFooter="True"
        EnableHierarchyRecreation="True" PopupAnimationType="None">
        <FooterStyle BackColor="#FFFBBA">
            <Border BorderWidth="0px" />
            <BorderTop BorderWidth="0px" />
        </FooterStyle>
        <Border BorderColor="#BAAE6D" BorderStyle="Solid" BorderWidth="1px" />
        <CloseButtonImage Height="15px" Url="~/PopupControl/Images/Hint/pcClose.gif" Width="15px" />
        <HeaderStyle BackColor="#FCFADD" Font-Bold="True" ForeColor="#9E8A4F" Font-Size="9pt">
            <Border BorderWidth="0px" />
            <BorderBottom BorderWidth="1px" BorderColor="#DCD9B0" BorderStyle="Solid" />
            <Paddings PaddingBottom="6px" PaddingLeft="13px" PaddingRight="8px" PaddingTop="6px" />
        </HeaderStyle>
        <ContentStyle BackColor="#FFFBBA" ForeColor="#9E8A4F">
            <Border BorderWidth="0px" />
            <Paddings PaddingBottom="10px" PaddingLeft="13px" PaddingRight="13px" PaddingTop="9px" />
        </ContentStyle>
        <CloseButtonStyle>
            <Paddings Padding="0px" PaddingLeft="3px" />
        </CloseButtonStyle>
        <ClientSideEvents CloseUp="PC_OnCloseUp" Init="PC_OnInit"
            PopUp="PC_OnPopUp" />
    </dx:ASPxPopupControl>
    <dx:ASPxMemo ID="ASPxMemo1" ClientInstanceName="mContent" runat="server" Columns="80" Rows="7" Text="[Enter some text here and then press the Create Note button]">
        <ClientSideEvents GotFocus="TBWindowContentFocus" LostFocus="TBWindowContentBlur"
            KeyPress="function(s, e) { return ImposeMaxLength(200); }" KeyUp="TBWindowContentChange"
            TextChanged="TBWindowContentChange" />
    </dx:ASPxMemo>
    <div style="margin: 10px 0 150px;">
        <dx:ASPxButton ClientInstanceName="btnCreateNote" ID="btnCreateNote" ClientEnabled="False"
            runat="server" Text="Create Note" OnClick="Button1_Click" />
        <dx:ASPxButton ClientInstanceName="btnShowAllNotes" ID="btnShowAllNotes" runat="server" Text="Show All Notes" AutoPostBack="false" style="margin-left: 10px;">
            <ClientSideEvents Click="function(s,e) { ShowAllNotes(true); }" />
        </dx:ASPxButton>
        <dx:ASPxButton ClientInstanceName="btnClearAllNotes" ID="btnClearAllNotes" runat="server" Text="Clear All Notes" OnClick="hlClearAllNotes_Click" style="margin-left: 10px;"/>
    </div>
</asp:Content>
