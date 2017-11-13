using System;
using System.Web.UI;

public partial class FileManager_GridViewMode : Page {
    protected void Page_Init(object sender, EventArgs e) {

    }
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack) {
            fileManager.SettingsFileList.DetailsViewSettings.AllowColumnResize = allowColumnResize.Checked;
            fileManager.SettingsFileList.DetailsViewSettings.AllowColumnDragDrop = allowColumnDragDrop.Checked;
            fileManager.SettingsFileList.DetailsViewSettings.AllowColumnSort = allowColumnSort.Checked;
            fileManager.SettingsFileList.DetailsViewSettings.ShowHeaderFilterButton = showHeaderFilterButton.Checked;
        }
    }
}
