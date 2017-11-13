using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Globalization;
using DevExpress.Utils;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class HierarchicalData : TreeMapTutorialControl {
        TreeMapHierarchicalDataAdapter DataAdapter { get { return (TreeMapHierarchicalDataAdapter)treeMapControl1.DataAdapter; } }
        
        public HierarchicalData() {
            InitializeComponent();
            DataAdapter.DataSource = LoadDataFromXML();
            DataAdapter.Mappings[0].Type = typeof(CountryEnergyInfo);
            DataAdapter.Mappings[1].Type = typeof(EnergyStatisticItem);
        }

        List<CountryEnergyInfo> LoadDataFromXML() {
            XDocument document = XDocument.Load(Utils.GetRelativePath("EnergyStatistic.xml"));
            List<CountryEnergyInfo> infos = new List<CountryEnergyInfo>();
            if (document != null) {
                foreach (XElement element in document.Element("ArrayOfEnergyStatistic").Elements()) {
                    CountryEnergyInfo energyInfo = new CountryEnergyInfo();
                    energyInfo.Country = element.Attribute("Country").Value;
                    foreach (XElement energyElement in element.Elements()) {
                        EnergyStatisticItem item = new EnergyStatisticItem();
                        item.TypeName = energyElement.Attribute("TypeName").Value;
                        item.Value = Convert.ToDouble(energyElement.Attribute("Value").Value, CultureInfo.InvariantCulture);
                        energyInfo.EnergyStatistic.Add(item);
                    }
                    infos.Add(energyInfo);
                }
            }
            return infos;
        }
    }

    public class CountryEnergyInfo {
        readonly List<EnergyStatisticItem> energyStatistic = new List<EnergyStatisticItem>();
        public List<EnergyStatisticItem> EnergyStatistic { get { return energyStatistic; } }
        public string Country { get; set; }
    }

    public class EnergyStatisticItem {
        public double Value { get; set; }
        public string TypeName { get; set; }
    }
}
