using System;
using System.Web.UI;

public partial class Menu_Toolbars_Office2007Children : UserControl, ITemplate {

    void ITemplate.InstantiateIn(Control container) {
        container.Controls.Add(this);
    }

}
