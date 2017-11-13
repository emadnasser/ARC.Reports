using System;
using System.Web.UI;

public partial class Headline_Example : Page {
    protected DateTime ConvertToDate(object dateObject) {
        return DateTime.Parse(dateObject.ToString().Replace(" PST", ""));
    }
}
