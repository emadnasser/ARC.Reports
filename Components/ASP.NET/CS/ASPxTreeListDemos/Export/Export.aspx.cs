using System;
using System.Web.UI;

public partial class Shaping_Export : Page {
    protected void Page_Load(object sender, EventArgs e) {
		if(!IsPostBack) {
			treeList.DataBind();
			treeList.ExpandToLevel(1);
		}
    }
    protected void btnExportToPdf_Click(object sender, EventArgs e) {
        PrepareExporter();
        treeListExporter.WritePdfToResponse();
    }
    protected void btnExportToXls_Click(object sender, EventArgs e) {
        PrepareExporter();
        treeListExporter.WriteXlsToResponse();
    }
    protected void btnExportToXlsx_Click(object sender, EventArgs e) {
        PrepareExporter();
        treeListExporter.WriteXlsxToResponse();
    }
    protected void btnExportToRtf_Click(object sender, EventArgs e) {
        PrepareExporter();
        treeListExporter.WriteRtfToResponse();
    }
    void PrepareExporter() {
        treeListExporter.Settings.AutoWidth = chkAutoWidth.Checked;
		treeListExporter.Settings.ExpandAllNodes = chkExpandAll.Checked;
    }
}
