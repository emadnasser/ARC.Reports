using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.XtraGrid.Demos.Tutorials {
    public partial class GridUnboudErrorNotificationNew : TutorialControl {
        public GridUnboudErrorNotificationNew() {
            InitializeComponent();
            InitData();
        }
        private void InitData() {
            Persons persons = new Persons();
            persons.Add(new Person("John", "", "123 Home Lane, Homesville", "(555) 956-1547", "none"));
            persons.Add(new Person("Henry", "McAllister", "436 1st Ave, Cleveland", "(555) 941-2432", "@hotbox.com"));
            persons.Add(new Person("Frank", "Frankson", "349 Graphic Design L, Newman", "(555) 155-0502", "none"));
            persons.Add(new Person("Leticia", "Ford", "93900 Carter Lane, Cartersville", "(555) 776-1566", "none"));
            persons.Add(new Person("Karen", "Holmes", "", "(555) 342-2574", "none"));
            persons.Add(new Person("Roger", "Michelson", "3920 Michelson Dr., Bridgeford", "(555) 954-5188", "none"));
            gridControl1.DataSource = persons;
        }
        public override bool SetNewWhatsThisPadding { get { return true; } }
    }
}
