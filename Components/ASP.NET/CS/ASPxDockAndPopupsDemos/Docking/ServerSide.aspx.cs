using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;
using System.Drawing;

public partial class Docking_ServerSide : Page {
    protected void Page_PreRender(object sender, EventArgs e) {
        if(IsPostBack)
            ApplyPanelPropeties();
    }

    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            PreparePanels();
            PrepareZones();
            InitializePropertiesEditors();
        }
    }

    protected void cbDockPanels_SelectedIndexChanged(object sender, EventArgs e) {
        InitializePropertiesEditors();
    }

    protected void ApplyPanelPropeties() {
        ASPxDockPanel dockPanel = GetCurrentDockPanel();
        if(dockPanel == null)
            return;

        dockPanel.Visible = cbPanelVisibility.Checked;
        dockPanel.ShowCloseButton = cbShowCloseButton.Checked;
        dockPanel.ShowShadow = cbShowShadow.Checked;
        dockPanel.ShowHeader = cbShowHeader.Checked;
        dockPanel.ShowFooter = cbShowFooter.Checked;
        dockPanel.AllowResize = cbAllowResize.Checked;
        dockPanel.ShowSizeGrip = (ShowSizeGrip)Enum.Parse(typeof(ShowSizeGrip), ddlShowSizeGrip.Value.ToString());
        dockPanel.AllowedDockState = (AllowedDockState)Enum.Parse(typeof(AllowedDockState), ddlAllowedDockState.Value.ToString());
    }

    protected void InitializePropertiesEditors() {
        ASPxDockPanel dockPanel = GetCurrentDockPanel();
        if(dockPanel == null)
            return;

        cbPanelVisibility.Value = dockPanel.Visible;
        seVisibleIndex.Value = dockPanel.VisibleIndex;
        cbShowCloseButton.Value = dockPanel.ShowCloseButton;
        cbShowShadow.Value = dockPanel.ShowShadow;
        cbShowHeader.Value = dockPanel.ShowHeader;
        cbShowFooter.Value = dockPanel.ShowFooter;
        cbAllowResize.Value = dockPanel.AllowResize;
        ddlShowSizeGrip.Value = dockPanel.ShowSizeGrip;
        ddlAllowedDockState.Value = dockPanel.AllowedDockState;
        if(dockPanel.OwnerZone != null)
            cbZones.SelectedItem = cbZones.Items.FindByValue(dockPanel.OwnerZoneUID);
        else
            cbZones.SelectedItem = cbZones.Items.FindByValue("none");
    }

    protected void cbZones_ValueChanged(object sender, EventArgs e) {
        if(cbZones.SelectedIndex < 0)
            return;

        ASPxDockPanel panel = GetCurrentDockPanel();
        ASPxDockZone zone = GetCurrentDockZone();

        panel.OwnerZoneUID = zone != null ? zone.ZoneUID : null;
    }

    protected void dockManager_AfterDock(object sender, DockManagerEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterDock for Manager");
    }

    protected void dockManager_BeforeDock(object sender, DockManagerCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeDock for Manager");
    }

    protected void dockManager_AfterFloat(object sender, DockManagerEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterFloat for Manager");
        InitializePropertiesEditors();
    }

    protected void dockManager_BeforeFloat(object sender, DockManagerCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeFloat for Manager");
    }

    protected void panel1_AfterDock(object sender, EventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterDock for Panels");
    }

    protected void panel1_BeforeDock(object sender, DockPanelCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeDock for Panels");
    }

    protected void panel1_AfterFloat(object sender, EventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterFloat for Panels");
    }

    protected void panel1_BeforeFloat(object sender, DockPanelCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeFloat for Panels");
    }

    protected void panel2_AfterDock(object sender, EventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterDock for Panels");
    }

    protected void panel2_BeforeDock(object sender, DockPanelCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeDock for Panels");
    }

    protected void panel2_AfterFloat(object sender, EventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterFloat for Panels");
    }

    protected void panel2_BeforeFloat(object sender, DockPanelCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeFloat for Panels");
    }

    protected void panel3_AfterDock(object sender, EventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterDock for Panels");
    }

    protected void panel3_BeforeDock(object sender, DockPanelCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeDock for Panels");
    }

    protected void panel3_AfterFloat(object sender, EventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterFloat for Panels");
    }

    protected void panel3_BeforeFloat(object sender, DockPanelCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeFloat for Panels");
    }

    protected void panel4_AfterDock(object sender, EventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterDock for Panels");
    }

    protected void panel4_BeforeDock(object sender, DockPanelCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeDock for Panels");
    }

    protected void panel4_AfterFloat(object sender, EventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterFloat for Panels");
    }

    protected void panel4_BeforeFloat(object sender, DockPanelCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeFloat for Panels");
    }

    protected void dockZone1_AfterDock(object sender, DockZoneEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterDock for Zones");
        InitializePropertiesEditors();
    }

    protected void dockZone1_BeforeDock(object sender, DockZoneCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeDock for Zones");
        InitializePropertiesEditors();
    }

    protected void dockZone2_AfterDock(object sender, DockZoneEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "AfterDock for Zones");
        InitializePropertiesEditors();
    }

    protected void dockZone2_BeforeDock(object sender, DockZoneCancelEventArgs e) {
        EventMonitor.TraceEvent(sender, e, "BeforeDock for Zones");
        InitializePropertiesEditors();
    }

    protected ASPxDockPanel GetCurrentDockPanel() {
        if(cbDockPanels.SelectedIndex < 0)
            return null;

        return dockManager.FindPanelByUID(cbDockPanels.SelectedItem.Value.ToString());
    }

    protected ASPxDockZone GetCurrentDockZone() {
        if(cbZones.SelectedIndex < 0)
            return null;

        return dockManager.FindZoneByUID(cbZones.SelectedItem.Value.ToString());
    }

    protected void PreparePanels() {
        foreach(ASPxDockPanel panel in dockManager.Panels) {
            panel.EnableHierarchyRecreation = true;
            panel.ShowCloseButton = false;
            panel.ShowFooter = true;
            panel.Width = 250;
            panel.Height = 190;
            panel.Styles.Content.Paddings.Padding = 0;
            panel.Styles.Content.Paddings.PaddingTop = 5;
            panel.Styles.Content.Paddings.PaddingBottom = 5;
            panel.Styles.Content.HorizontalAlign = HorizontalAlign.Center;
            panel.Styles.Content.BackColor = Color.White;
        }
    }

    protected void PrepareZones() {
        foreach(ASPxDockZone zone in dockManager.Zones) {
            zone.PanelSpacing = 11;
            zone.Width = 250;
            zone.Height = 385;
        }
    }

    protected void seVisibleIndex_ValueChanged(object sender, EventArgs e) {
        ASPxDockPanel dockPanel = GetCurrentDockPanel();
        if(dockPanel != null)
            dockPanel.VisibleIndex = (int)seVisibleIndex.Number;
    }
}
