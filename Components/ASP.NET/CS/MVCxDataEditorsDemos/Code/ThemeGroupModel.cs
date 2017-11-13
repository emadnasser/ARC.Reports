using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Web.UI;

namespace DevExpress.Web.Demos {

    public class ThemeGroupModel : ThemeModelBase {
        List<ThemeModel> _themes = new List<ThemeModel>();
        string _float;

        [XmlElement(ElementName = "Theme")]
        public List<ThemeModel> Themes {
            get { return _themes; }
        }

        [XmlAttribute]
        public string Float {
            get { return _float; }
            set { _float = value; }
        }
    }

}
