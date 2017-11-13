using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using DevExpress.Xpf.DemoBase;
using DevExpress.Xpf.Editors;

namespace ChartsDemo {
    [CodeFile("Modules/XyzChart/MathematicalFunctions(.SL).xaml"),
    CodeFile("Modules/XyzChart/MathematicalFunctions.xaml.(cs)")]
    public partial class MathematicalFunctions : ChartsDemoModule {
        MathematicalFunctionsViewModel model;

        public MathematicalFunctions() {
            InitializeComponent();
            this.model = new MathematicalFunctionsViewModel();
            this.DataContext = model;
        }
        void RatioChanged(object sender, EditValueChangedEventArgs e) {
            model.AspectRatio = new Size3D(slRatioX.Value, slRatioY.Value, slRatioZ.Value);
        }
        void UseRatioChanged(object sender, EditValueChangedEventArgs e) {
            if(cbUseAspectRatio.IsChecked.Value)
                RatioChanged(sender, e);
            else
                model.AspectRatio = new Size3D(0, 0, 0);
        }
        public override bool SupportSidebarContent() {
            return false;
        }
    }

    public class MathematicalFunctionsViewModel : INotifyPropertyChanged {
        const double UnitFactor = 15;

        Dictionary<FunctionsType, Func<double, double, Point3D>> functionToCalculator;
        List<Point3D> points;
        Size3D aspectRatio;
        Function3DItemData function;
        PropertyChangedEventHandler onPropertyChanged;
        readonly ObservableCollection<Function3DItemData> functions = Chart3DUtils.CreateFunctionItemsData();

        public ObservableCollection<Function3DItemData> FunctionItemsData {get { return functions; } }
        public Function3DItemData Function {
            get { return function; }
            set {
                function = value;
                if(function != null)
                    UpdateFunction(function.Type);
                NotifyPropertyChanged("Function");
            }
        }

        public List<Point3D> Points {
            get { return points; }
            set {
                points = value;
                NotifyPropertyChanged("Points");
            }
        }
        public Size3D AspectRatio {
            get { return aspectRatio; }
            set {
                aspectRatio = value;
                NotifyPropertyChanged("AspectRatio");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged {
            add { onPropertyChanged += value; }
            remove { onPropertyChanged -= value; }
        }

        public MathematicalFunctionsViewModel() {
            this.functionToCalculator = CreateCalculators();
            Function = FunctionItemsData[3];
        }

        Dictionary<FunctionsType, Func<double, double, Point3D>> CreateCalculators() {
            Dictionary<FunctionsType, Func<double, double, Point3D>> calculators = new Dictionary<FunctionsType, Func<double, double, Point3D>>();
            calculators.Add(FunctionsType.First, CalculateFirstValue);
            calculators.Add(FunctionsType.Second, CalculateSecondValue);
            calculators.Add(FunctionsType.Third, CalculateThirdValue);
            calculators.Add(FunctionsType.Four, CalculateFourValue);
            calculators.Add(FunctionsType.Five, CalculateFiveValue);
            return calculators;
        }
        void NotifyPropertyChanged(string propertyName) {
            if(this.onPropertyChanged != null)
                this.onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        double Sinc(double x) {
            return x != 0 ? Math.Sin(x) : 1;
        }
        Point3D CalculateFirstValue(double x, double y) {
            x *= UnitFactor;
            y *= UnitFactor;
            double value = Sinc(Math.Sin(Math.Pow(Math.Pow(x, 6) + Math.Pow(y, 6), 1.0 / 6.0))) * 5;
            return new Point3D(x, y, value);
        }
        Point3D CalculateSecondValue(double x, double y) {
            x *= UnitFactor;
            y *= UnitFactor;
            double square = Math.Sqrt(x * x + y * y);
            double value = square * Sinc(square) * 0.2;
            return new Point3D(x, y, value);
        }
        Point3D CalculateThirdValue(double x, double y) {
            x *= UnitFactor / 2;
            y *= UnitFactor / 2;
            double value = Math.Sin(x) * Math.Cos(y) * 2;
            return new Point3D(x, y, value);
        }
        Point3D CalculateFourValue(double x, double y) {
            double theta = Math.Atan2(y, x);
            double r = x * x + y * y;
            double z = Math.Exp(-r) * Math.Sin(2 * Math.PI * Math.Sqrt(r)) * Math.Cos(3 * theta);
            return new Point3D(x, y, z);
        }
        Point3D CalculateFiveValue(double x, double y) {
            x *= 3;
            y *= 3;
            double z = Math.Sin(x * y);
            return new Point3D(x, y, z);
        }
        List<Point3D> CreatePoints(Func<double, double, Point3D> valueCalculator) {
            List<Point3D> points = new List<Point3D>();
            for(double x = -1; x < 1; x += 0.017)
                for(double y = -1; y < 1; y += 0.017)
                    points.Add(valueCalculator(x, y));
            return points;
        }
        List<Point3D> CreateFunctionPoints(FunctionsType function) {
            return CreatePoints(functionToCalculator[function]);
        }
        public void UpdateFunction(FunctionsType function) {
            Points = CreateFunctionPoints(function);
        }
    }
    public enum FunctionsType {
        First,
        Second,
        Third,
        Four,
        Five
    }
    public class Function3DItemData : INotifyPropertyChanged {
        FunctionsType type;
        BitmapImage image;
        public FunctionsType Type { get { return type; } set { type = value; NotifyPropertyChanged("Type"); } }
        public BitmapImage Image { get { return image; } set { image = value; NotifyPropertyChanged("Image"); } }

        #region INotifyPropertyChanged
        PropertyChangedEventHandler onPropertyChanged;

        public event PropertyChangedEventHandler PropertyChanged {
            add { onPropertyChanged += value; }
            remove { onPropertyChanged -= value; }
        }
        void NotifyPropertyChanged(string propertyName) {
            if(this.onPropertyChanged != null)
                this.onPropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
