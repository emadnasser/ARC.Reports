using System;
using System.Web.UI;

public partial class Common_RightToLeft : Page {

    protected decimal GetRatingValue(object value) {
        return value != null ? Decimal.Parse((string)value) : 0;
    }

}
