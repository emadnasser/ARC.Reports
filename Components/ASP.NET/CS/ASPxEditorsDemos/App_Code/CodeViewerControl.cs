using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using DevExpress.Web.Demos;

public class CodeViewerControl : UserControl {
    public SourceCodePage SourceCodePage { get; set; }
    public int Index { get; set; }
    public bool DisableTextWrap { get; set; }
}
