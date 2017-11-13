using System.Web.UI;
using DevExpress.Web;

public partial class Modules_Standard_Editors : Page {
    protected void ASPxSpellChecker1_CheckedElementResolve(object sender, ControlResolveEventArgs e) {
        e.ResolvedControl = TextBox1;
    }
}
