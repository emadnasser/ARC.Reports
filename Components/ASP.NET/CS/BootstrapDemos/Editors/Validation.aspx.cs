using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Editors_Validation : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string formAction = "~/Editors/Validation.aspx";
        ButtonOK.PostBackUrl = formAction + "#validation";
        OKButton.PostBackUrl = formAction + "#custom-validation";
    }

    protected void NameTextBox_Validation(object sender, DevExpress.Web.ValidationEventArgs e) {
        if((e.Value as string).Length < 2)
            e.IsValid = false;
    }

    protected void AgeTextBox_Validation(object sender, DevExpress.Web.ValidationEventArgs e) {
        string strAge = Convert.ToString(e.Value);
        if(string.IsNullOrEmpty(strAge))
            return;
        strAge = strAge.TrimStart('0');
        if(strAge.Length == 0)
            return;
        int age = 0;
        if(!int.TryParse(strAge, out age) || age < 18)
            e.IsValid = false;
    }

    protected void ArrivalDateEdit_Validation(object sender, DevExpress.Web.ValidationEventArgs e) {
        if(!(e.Value is DateTime))
            return;
        DateTime selectedDate = (DateTime)e.Value;
        DateTime currentDate = DateTime.Now;
        if(selectedDate.Year != currentDate.Year || selectedDate.Month != currentDate.Month)
            e.IsValid = false;
    }
}
