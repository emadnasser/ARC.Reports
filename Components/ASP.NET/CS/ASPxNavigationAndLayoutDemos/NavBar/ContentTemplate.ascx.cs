using System;
using System.Web.UI;

public partial class NavBar_HeaderTemplate : UserControl, ITemplate {

    void ITemplate.InstantiateIn(Control container) {
        container.Controls.Add(this);
    }

}
