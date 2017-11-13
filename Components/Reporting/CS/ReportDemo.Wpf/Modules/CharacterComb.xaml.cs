using DevExpress.Xpf.Printing;
using DevExpress.XtraReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReportWpfDemo {
    public partial class CharacterComb : ReportModuleBase {
        public CharacterComb() {
            InitializeComponent();
        }
    }

    public class CharacterCombViewModel : ReportModuleViewModelBase {
        static CharacterCombViewModel() {
            EditingFieldExtensions.Instance.RegisterEditorInfo("Name", "Custom", "Name");
            EditingFieldExtensions.Instance.RegisterEditorInfo("NumbersAndUppercaseLetters", "Custom", "Numbers and Uppercase letters");
            EditingFieldExtensions.Instance.RegisterEditorInfo("UppercaseText", "Custom", "Uppercase Text");

        }
        protected override IReport CreateReport() {
            return new XtraReportsDemos.CharacterComb.Report();
        }
    }
}
