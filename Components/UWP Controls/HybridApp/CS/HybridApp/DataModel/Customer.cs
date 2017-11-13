using System.Collections.ObjectModel;

namespace HybridApp.HybridAppService {
    public partial class Customer {
        ObservableCollection<double> monthlySales;
        public ObservableCollection<double> MonthlySales {
            get { return monthlySales; }
            set {
                if(monthlySales != value) {
                    monthlySales = value;
                    RaisePropertyChanged("MonthlySales");
                }
            }
        }
        public ObservableCollection<double> ExpandedMonthlySales {
            get { return CalculateExpandedMonthlySales(); }
        }
        ObservableCollection<double> CalculateExpandedMonthlySales() {
            ObservableCollection<double> sales = new ObservableCollection<double>();
            if(monthlySales != null && monthlySales.Count > 2) {
                sales.Add((3 * monthlySales[0] - monthlySales[1]) / 2);
                for(int i = 0; i < monthlySales.Count - 1; i++) {
                    sales.Add(monthlySales[i]);
                    sales.Add((monthlySales[i] + monthlySales[i + 1]) / 2);
                }
                sales.Add(monthlySales[monthlySales.Count - 1]);
                sales.Add((3 * monthlySales[monthlySales.Count - 1] - monthlySales[monthlySales.Count - 2]) / 2);
            }
            return sales;
        }
    }
}
