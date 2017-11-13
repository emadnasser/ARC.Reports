<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CustomAppointmentTooltip.ascx.cs"
    Inherits="UserForms_CustomAppointmentTooltip" %>
    
<div class="cToolTipContainer">
    <div class="cToolTipTopLeftCorner">
        &nbsp;</div>
    <div class="cToolTipTopSide">
        &nbsp;</div>
    <div class="cToolTipTopRightCorner">
        &nbsp;</div>
    <div class="cToolTipClearFlow">
        &nbsp;</div>
    <div class="cToolTipLeftSide">
        <div class="cToolTipRightSide">
            <div style="padding: 5px 15px 10px 15px;">
                <div style="padding-bottom: 35px;">
                    <div style="padding-bottom: 5px;">
                        <dx:ASPxLabel runat="server" ID="lblInterval" EnableClientSideAPI="true" Font-Size="9pt"
                            Font-Names="Tahoma" ForeColor="black">
                        </dx:ASPxLabel>
                    </div>
                    <div>
                        <dx:ASPxLabel runat="server" ID="lblSubject" EnableClientSideAPI="true" Font-Size="9pt"
                            Font-Names="Tahoma" ForeColor="black">
                        </dx:ASPxLabel>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="cToolTipLeftSide cToolTipFooter">
        <div class="cToolTipRightSide">
            <div style="padding: 0 1px;">
                <div class="cToolTipSeparatingStrip">
                    &nbsp;</div>
            </div>
            <div style="padding: 8px 14px; height: 24px; vertical-align: middle;">
                <div style="float: right;">
                    <dx:ASPxButton runat="server" ID="btnDelete" Text="Delete" EnableClientSideAPI="true"
                        AutoPostBack="false" style="margin-right: 6px">
                    </dx:ASPxButton>
                    <dx:ASPxButton runat="server" ID="btnEdit" Text="Edit" EnableClientSideAPI="true"
                        AutoPostBack="false">
                    </dx:ASPxButton>
                </div>
                <span runat="server" id="lblShowMenu" style="cursor: pointer; text-decoration: underline;
                    width: 100px; color: #3e6b96; font-family: Tahoma; font-size: 9pt; padding: 6px 0;">Show menu</span>
            </div>
        </div>
    </div>
    <div class="cToolTipClearFlow">
        &nbsp;</div>
    <div class="cToolTipBottomLeftCorner">
        &nbsp;</div>
    <div class="cToolTipBottomSide">
        <div class="cToolTipBottomSideSizeFixer">
            &nbsp;</div>
    </div>
    <div class="cToolTipBottomRightCorner">
        &nbsp;</div>
    <div class="cToolTipClearFlow">
        &nbsp;</div>
</div>
<script type="text/javascript" id="dxss_cat">
    // <![CDATA[
    ASPxClientAppointmentToolTip = ASPx.CreateClass(ASPxClientToolTipBase, {
        Initialize: function () {
            this.controls.btnEdit.Click.AddHandler(ASPx.CreateDelegate(this.OnBtnEditClick, this));
            this.controls.btnDelete.Click.AddHandler(ASPx.CreateDelegate(this.OnBtnDeleteClick, this));
            ASPxClientUtils.AttachEventToElement(this.controls.lblShowMenu, "click", ASPx.CreateDelegate(this.OnLblShowMenuClick, this));
        },
        Update: function (data) {
            var apt = data.GetAppointment();
            this.apt = apt;
            if(!apt.updated) {
                this.scheduler.RefreshClientAppointmentProperties(apt, AppointmentPropertyNames.Normal, ASPx.CreateDelegate(this.OnAppointmentRefresh, this));
                this.controls.lblSubject.SetText("Loading...");
            } else
                this.controls.lblSubject.SetText(ASPx.Str.EncodeHtml(apt.GetSubject()));
            var textInterval = this.ConvertIntervalToString(apt.interval);
            this.controls.lblInterval.SetText(textInterval);
        },
        OnAppointmentRefresh: function (apt) {
            apt.updated = true;
            this.controls.lblSubject.SetText(ASPx.Str.EncodeHtml(apt.GetSubject()));
        },
        OnButtonDivClick: function (s, e) {
            this.ShowAppointmentMenu(s);
        },
        OnBtnEditClick: function () {
            this.scheduler.ShowAppointmentFormByClientId(this.apt.GetId());
            this.Close();
        },
        OnBtnDeleteClick: function () {
            this.scheduler.DeleteAppointment(this.apt);
        },
        OnLblShowMenuClick: function (e) {
            this.ShowAppointmentMenu(e);
        }
    });    
    // ]]> 
</script>
