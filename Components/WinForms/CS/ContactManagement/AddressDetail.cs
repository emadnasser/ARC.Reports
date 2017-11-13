using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace ContactManagement {
    /// <summary>
    /// Summary description for AddressDetail.
    /// </summary>
    public partial class AddressDetail : System.Windows.Forms.Form {
        private void SetupBindings() {
            txtOID.DataBindings.Add("Text", theAddress, "Oid");
            txtOwner.DataBindings.Add("Text", theAddress.Owner, "DisplayName");
            txtCity.DataBindings.Add("Text", theAddress, "City");
            txtStreet.DataBindings.Add("Text", theAddress, "Street");
            chkDefault.DataBindings.Add("Checked", theAddress, "IsDefault");
        }

        public AddressDetail() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public Address Address {
            set {
                theAddress = value;
                SetupBindings();
            }
        }

        private void btnSave_Click(object sender, System.EventArgs e) {
            if(chkDefault.Checked)
                theAddress.Owner.DefaultAddress = theAddress;
            theAddress.Save();
        }
    }
}
