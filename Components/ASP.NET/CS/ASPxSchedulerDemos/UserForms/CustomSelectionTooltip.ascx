<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CustomSelectionTooltip.ascx.cs" Inherits="UserForms_CustomSelectionTooltip" %>
<div class="cToolTipContainer">
    <div class="cToolTipTopLeftCorner">&nbsp;</div>
    <div class="cToolTipTopSide">&nbsp;</div>
    <div class="cToolTipTopRightCorner">&nbsp;</div>
    <div class="cToolTipClearFlow">&nbsp;</div>
    
    <div class="cToolTipLeftSide">
        <div class="cToolTipRightSide">
            <div style="float:right; position:relative; padding-right:5px;padding-top:0;z-index:1000;">
                            <dx:ASPxImage runat="server" ID="imgCloseButton" ImageUrl="../Content/CustomToolTip/CloseButton.png" AlternateText="[x]" EnableClientSideAPI="true" Width="15px" Height="14px">
                                <ClientSideEvents Click="function(s,e) {}" />
                            </dx:ASPxImage>
            </div>
            <div class="cToolTipClearFlow">&nbsp;</div>
            <div style="padding:0 15px 10px 15px;">
                <div>
                    <div style="padding-bottom:10px;">
                        <dx:ASPxLabel runat="server" ID="lblInterval" EnableClientSideAPI="true" Font-Names="Tahoma" Font-Size="9pt" ForeColor="black" Text="some interval"></dx:ASPxLabel>
                    </div> 
                    <div>
                        <div class="cToolTipClearFlow">&nbsp;</div>
                        <div style="float:left;padding-right:5px; padding-top:2px; padding-bottom:45px;color:#666666;font-family:Tahoma;font-size:9pt;">Subject:</div>
                        <div style="float:left;">
                            <dx:ASPxTextBox ID="tbSubject" runat="server" Width="170px" EnableClientSideAPI="true" AutoPostBack="false"  >
                                <ClientSideEvents KeyDown="function(s,e) {}" />
                            </dx:ASPxTextBox>
                        </div>
                    </div>    
                </div>
            </div>
        </div>
    </div>
    <div class="cToolTipLeftSide cToolTipFooter">
        <div class="cToolTipRightSide">
            <div style="padding:0 1px;">
                <div class="cToolTipSeparatingStrip">&nbsp;</div>
            </div>
            <div style="padding: 8px 14px; height: 24px; vertical-align: middle;">
                <div style="float:right;">
                    <dx:ASPxButton runat="server" ID="btnCreate" Text="Create" EnableClientSideAPI="true" AutoPostBack="false"></dx:ASPxButton>
                </div>
                <span runat="server" id="lblShowMenu" style="cursor:pointer; text-decoration:underline;
                    width:100px; color:#3e6b96; font-family:Tahoma; font-size:9pt; padding: 6px 0;">Show menu</span>
            </div>
        </div>
    </div>
    <div class="cToolTipClearFlow">&nbsp;</div>
    <div class="cToolTipBottomLeftCorner">&nbsp;</div>
    <div class="cToolTipBottomSide">
        <div class="cToolTipBottomSideSizeFixer">&nbsp;</div>
    </div>
    <div class="cToolTipBottomRightCorner">&nbsp;</div>
    <div class="cToolTipClearFlow">&nbsp;</div>
</div>
<script type="text/javascript" id="dxss_cst">
    ASPxClientSelectionToolTip = ASPx.CreateClass(ASPxClientToolTipBase, {
        Initialize: function() {
              ASPxClientUtils.AttachEventToElement(this.controls.lblShowMenu, "click", ASPx.CreateDelegate(this.OnLblShowMenuClick, this));
              this.controls.btnCreate.Click.AddHandler(ASPx.CreateDelegate(this.OnBtnCreateClick, this));
              this.controls.tbSubject.KeyDown.AddHandler(ASPx.CreateDelegate(this.OnTbSubjectKeyDown, this));
              this.controls.imgCloseButton.Click.AddHandler(ASPx.CreateDelegate(this.OnImgCloseButtonClick, this));
        },
        Update: function(data) {
            var textInterval = this.ConvertIntervalToString(data.GetInterval());
            this.controls.lblInterval.SetText(textInterval);
        },
        FinalizeUpdate: function(data) {
            this.controls.tbSubject.Focus();  
        },
        OnBtnCreateClick: function() {
            var apt = this.CreateAppointmentFromSelectionInterval();
            var textSubject = this.controls.tbSubject.GetText();
            apt.SetSubject(textSubject);
            this.Clear();
            this.scheduler.InsertAppointment(apt);
        },
        OnImgCloseButtonClick: function() {
            this.Close();
        },
        CreateAppointmentFromSelectionInterval: function() {
            var apt = new ASPxClientAppointment();
            var scheduler = this.scheduler;
            var selectedInterval = scheduler.GetSelectedInterval();
            apt.SetStart(selectedInterval.GetStart());
            apt.SetEnd(selectedInterval.GetEnd());
            apt.AddResource(scheduler.GetSelectedResource());
            apt.SetLabelId(1);
            apt.SetStatusId(3);
            return apt;
        },
        Clear: function() {
            this.controls.tbSubject.SetText("");
        },
        OnLblShowMenuClick: function(e) {
            this.ShowViewMenu(e);
        },
        OnTbSubjectKeyDown: function(s, e) {
            if (e.htmlEvent.keyCode == 13) {
                ASPxClientUtils.PreventEvent(e.htmlEvent);
                this.OnBtnCreateClick();
            } 
            else if (e.htmlEvent.keyCode == 27) {
                this.Close();
            }
        }
    });    
</script>
