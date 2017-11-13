using System;
using System.Web.UI;
using DevExpress.Web;

public partial class FileManager_MultipleFileSelection : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsPostBack) {
            FileListView selectedViewMode = (FileListView)Enum.Parse(typeof(FileListView),
                ddlViewMode.SelectedItem.Value.ToString());
            if(!ASPxFileManager1.SettingsFileList.View.Equals(selectedViewMode))
                ASPxFileManager1.SettingsFileList.View = selectedViewMode;
        }
    }   
}
