using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.Xpo;

namespace ContactManagement {
    public partial class ContactDetail : System.Windows.Forms.Form {
        private void SetupBindings() {
            txtOID.DataBindings.Add("Text", theContact, "Oid");
            txtFirstName.DataBindings.Add("Text", theContact, "FirstName");
            txtLastName.DataBindings.Add("Text", theContact, "LastName");
            txtPhoneNumber.DataBindings.Add("Text", theContact, "PhoneNumber");
            txtEmail.DataBindings.Add("Text", theContact, "Email");
            XPCollection collection = new XPCollection(theContact.Session, typeof(Company));
            collection.DisplayableProperties = "Name;This";
            cmbEmployer.DataSource = collection;
            cmbEmployer.DisplayMember = "Name";
            cmbEmployer.ValueMember = "This";
            cmbEmployer.DataBindings.Add("SelectedValue", theContact, "Employer!");
        }

        public Contact Contact {
            get { return theContact; }
            set {
                theContact = value;
                SetupBindings();
            }
        }

        public ContactDetail() {
            InitializeComponent();
        }
        public ContactDetail(Contact theContact)
            : this() {
            this.Contact = theContact;
        }
        
        private void btnAddresses_Click(object sender, System.EventArgs e) {
            ObjectList list = new ObjectList("Addresses", this.Contact.Addresses,
                "Owner.DisplayName;Street;City;IsDefault");
            list.OnInsertObject += new InsertObjectEventHandler(this.OnInsertAddress);
            list.OnEditObject += new EditObjectEventHandler(this.OnEditAddress);
            list.ShowDialog(this);
        }

        private void btnDocs_Click(object sender, System.EventArgs e) {
            ObjectList list = new ObjectList("Attachments", this.Contact.Attachments,
                "Owner.DisplayName;Name");
            list.OnInsertObject += new InsertObjectEventHandler(this.OnInsertAttachment);
            list.OnEditObject += new EditObjectEventHandler(this.OnEditAttachment);
            list.ShowDialog(this);
        }
        private void OnEditAttachment(object sender, EditObjectEventArgs e) {
            AttachmentDetail attachmentDetailForm = new AttachmentDetail();
            attachmentDetailForm.Attachment = (Attachment)e.ObjectToEdit;
            if(attachmentDetailForm.ShowDialog(this) != DialogResult.OK)
                ((Attachment)e.ObjectToEdit).Reload();
        }
        private void OnInsertAttachment(object sender) {
            AttachmentDetail attachmentDetailForm = new AttachmentDetail();
            Attachment attach = new Attachment(Contact.Session);
            attach.Owner = Contact;
            attachmentDetailForm.Attachment = attach;
            if(attachmentDetailForm.ShowDialog(this) == DialogResult.OK) {
                this.Contact.Attachments.Add(attach);
            }
        }
        private void OnEditAddress(object sender, EditObjectEventArgs e) {
            AddressDetail addressDetailForm = new AddressDetail();
            addressDetailForm.Address = (Address)e.ObjectToEdit;
            if(addressDetailForm.ShowDialog(this) != DialogResult.OK)
                ((Address)e.ObjectToEdit).Reload();
        }
        private void OnInsertAddress(object sender) {
            AddressDetail addressDetailForm = new AddressDetail();
            Address address = new Address(Contact.Session);
            address.Owner = Contact;
            addressDetailForm.Address = address;
            if(addressDetailForm.ShowDialog(this) == DialogResult.OK) {
                this.Contact.Addresses.Add(address);
            }
        }
    }
}
