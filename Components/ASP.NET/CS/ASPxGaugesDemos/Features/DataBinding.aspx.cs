using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Xml;
using System.Xml.XPath;
using DevExpress.Web;
using DevExpress.XtraGauges.Core.Model;

public partial class DataBindingPage : Page {
    Car carPropLimits;
    IList<Car> carsCore;
    //
    protected IList<Car> Cars {
        get {
            if(carsCore == null) carsCore = LoadCars();
            return carsCore;
        }
    }
    protected void Page_Load(object sender, EventArgs e) {
        if(!IsPostBack) {
            ASPxComboBox firstCar = GetCombo("firstCarID");
            ASPxComboBox secondCar = GetCombo("secondCarID");
            if(Cars.Count > 0) {
                foreach(Car car in Cars) {
                    firstCar.Items.Add(new ListEditItem(car.Name, car.ID));
                    secondCar.Items.Add(new ListEditItem(car.Name, car.ID));
                }
                firstCar.Text = Cars[0].Name;
                secondCar.Text = Cars[1].Name;
            }
        }
        if(!IsCallback) {
            cGauge1.Labels["criteria"].Text = (string)criteria.Value;
            gaugeControl.DataBind();
        }
    }
    protected void OnGaugeCallback(object source, CallbackEventArgsBase e) {
        cGauge1.Labels["criteria"].Text = (string)criteria.Value;
        gaugeControl.DataBind();
    }
    protected void OnScale1DataBinding(object sender, EventArgs e) {
        UpdateScale((ArcScale)sender, GetCarID("firstCarID"), GetCriteria("criteria"));
    }
    protected void OnScale2DataBinding(object sender, EventArgs e) {
        UpdateScale((ArcScale)sender, GetCarID("secondCarID"), GetCriteria("criteria"));
    }
    void UpdateScale(ArcScale scale, int id, string criteria) {
        if(Cars.Count > 0 && id <= Cars.Count) {
            Car car = CarsExtension.GetCarByID(Cars, id);
            float maxValue = (float)CarsExtension.GetCarProperty(carPropLimits, criteria);
            scale.MaxValue = maxValue;
            scale.MinValue = (maxValue == 7) ? 1 : 0;
            scale.Value = (float)CarsExtension.GetCarProperty(car, criteria);
        }
    }
    int GetCarID(string comboID) {
        ASPxComboBox firstCar = GetCombo(comboID);
        int id = 0;
        int.TryParse((string)firstCar.Value, out id);
        return id;
    }
    string GetCriteria(string comboID) {
        ASPxComboBox criteria = GetCombo(comboID);
        return (string)criteria.Value;
    }
    protected List<Car> LoadCars() {
        List<Car> cars = new List<Car>();
        XPathNodeIterator carIterator = GetCarsIterator();

        float maxLiter = 0;
        float maxMPGCity = 0;
        float maxMPGHighway = 0;
        float maxHP = 0;
        int maxCyl = 0;
        while(carIterator.MoveNext()) {
            XPathNavigator carNodeNavigator = carIterator.Current.Clone();
            int id = carNodeNavigator.SelectSingleNode("ID").ValueAsInt;
            string displayName = String.Format("{0} {1}",
                        carNodeNavigator.SelectSingleNode("Trademark").Value,
                        carNodeNavigator.SelectSingleNode("Model").Value
                    );
            float liter = (float)carNodeNavigator.SelectSingleNode("Liter").ValueAsDouble;
            float mpgCity = (float)carNodeNavigator.SelectSingleNode("MPG_x0020_City").ValueAsInt;
            float mpgHighway = (float)carNodeNavigator.SelectSingleNode("MPG_x0020_Highway").ValueAsInt;
            float hp = (float)carNodeNavigator.SelectSingleNode("HP").ValueAsDouble;
            int cyl = carNodeNavigator.SelectSingleNode("Cyl").ValueAsInt;
            cars.Add(new Car(id, displayName, cyl, hp, liter, mpgCity, mpgHighway));
            maxLiter = Math.Max(liter, maxLiter);
            maxMPGCity = Math.Max(mpgCity, maxMPGCity);
            maxMPGHighway = Math.Max(mpgHighway, maxMPGHighway);
            maxHP = Math.Max(hp, maxHP);
            maxCyl = Math.Max(cyl, maxCyl);
        }
        carPropLimits = new Car(-1, "Limits",
                (int)CorrectLimit(maxCyl),
                CorrectLimit(maxHP),
                CorrectLimit(maxLiter),
                CorrectLimit(maxMPGCity),
                CorrectLimit(maxMPGHighway)
            );
        return cars;
    }
    float CorrectLimit(float limit) {
        int[] limits = new int[] { 7, 12, 36, 360 };
        for(int i = 0; i < limits.Length; i++) {
            if(limit < limits[i]) return limits[i];
        }
        return limit;
    }
    ASPxComboBox GetCombo(string id) {
        return ASPxRoundPanel1.FindControl(id) as ASPxComboBox;
    }
    XPathNavigator GetXPathNavigator() {
        XmlDocument doc = carsDS.GetXmlDocument();
        return doc.CreateNavigator();
    }
    XPathNodeIterator GetCarsIterator() {
        XPathNavigator navigator = GetXPathNavigator();
        return navigator.Select(GetCarsQuery());
    }
    XPathExpression GetCarsQuery() {
        return XPathExpression.Compile("//Cars");
    }

    public class Car {
        string nameCore;
        int idCore;
        int cylCore;
        float hpCore;
        float literCore;
        float mpgCityCore;
        float mpgHighwayCore;

        public Car(int id, string name, int cyl, float hp, float liter, float mpgCity, float mpgHighWay) {
            idCore = id;
            nameCore = name;
            cylCore = cyl;
            hpCore = hp;
            literCore = liter;
            mpgCityCore = mpgCity;
            mpgHighwayCore = mpgHighWay;
        }
        public int ID { get { return idCore; } }
        public string Name { get { return nameCore; } }
        public float Cyl { get { return cylCore; } }
        public float HP { get { return hpCore; } }
        public float MPG_City { get { return mpgCityCore; } }
        public float MPG_Highway { get { return mpgHighwayCore; } }
        public float Liter { get { return literCore; } }
    }
    public static class CarsExtension {
        public static Car GetCarByID(IEnumerable<Car> list, int id) {
            Car result = null;
            foreach(Car c in list) {
                if(c.ID == id) return c;
            }
            return result;
        }
        public static object GetCarProperty(Car car, string propName) {
            switch(propName) {
                case "Cylinders": return car.Cyl;
                case "HP": return car.HP;
                case "Liter": return car.Liter;
                case "MPG City": return car.MPG_City;
                case "MPG Highway": return car.MPG_Highway;
                default: return car.Name;
            }
        }
    }
}
