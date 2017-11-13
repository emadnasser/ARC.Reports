using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace ContactManagement {
    public partial class CompanyDetail : System.Windows.Forms.Form {
        private void SetupBindings() {
            txtOID.DataBindings.Add("Text", theCompany, "Oid");
            txtName.DataBindings.Add("Text", theCompany, "Name");
            txtWebSite.DataBindings.Add("Text", theCompany, "WebSite");
            txtPhoneNumber.DataBindings.Add("Text", theCompany, "PhoneNumber");
            txtCreatedOn.DataBindings.Add("Text", theCompany, "CreatedOn");
        }

        public Company Company {
            get { return theCompany; }
            set {
                theCompany = value;
                SetupBindings();
            }
        }

        public CompanyDetail() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, System.EventArgs e) {
            theCompany.Save();
        }
    }
}
