using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;

using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace ContactManagement {
    public partial class MainForm : System.Windows.Forms.Form {
        public MainForm() {
            InitializeComponent();
            UpdateMenu();
        }

        private void UpdateMenu() {
            mnuDeleteContact.Enabled = gridContacts.CurrentRowIndex >= 0;
            mnuProperties.Enabled = mnuDeleteContact.Enabled;
        }
        private void RefreshGrid() {
            contacts.Reload();
            gridContacts.Refresh();
        }
        private void mnuExit_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void EditContact(Contact theContact) {
            ContactDetail detailForm = new ContactDetail(theContact);
            if(detailForm.ShowDialog(this) == DialogResult.OK) {
                theContact.Save();
                RefreshGrid();
            }
            else {
                if(!session.IsNewObject(theContact))
                    theContact.Reload();
            }
        }

        private void mnuAddContact_Click(object sender, System.EventArgs e) {
            EditContact(new Contact(session));
            UpdateMenu();
        }

        private void mnuProperties_Click(object sender, System.EventArgs e) {
            if(gridContacts.CurrentRowIndex >= 0) {
                EditContact((Contact)contacts[gridContacts.CurrentRowIndex]);
            }
        }

        private void gridContacts_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                mnuProperties_Click(null, null);
            }
        }

        private void OnEditCompany(object sender, EditObjectEventArgs e) {
            CompanyDetail companyDetailForm = new CompanyDetail();
            companyDetailForm.Company = (Company)e.ObjectToEdit;
            if(companyDetailForm.ShowDialog(this) != DialogResult.OK)
                ((Company)e.ObjectToEdit).Reload();
        }
        private void OnInsertCompany(object sender) {
            CompanyDetail companyDetailForm = new CompanyDetail();
            companyDetailForm.Company = new Company(session);
            companyDetailForm.ShowDialog(this);
        }

        private void mnuCompanies_Click(object sender, System.EventArgs e) {
            try {
                ObjectList list = new ObjectList("Companies", session, typeof(Company), null,
                    "Name;WebSite;PhoneNumber;CreatedOn");
                list.OnInsertObject += new InsertObjectEventHandler(this.OnInsertCompany);
                list.OnEditObject += new EditObjectEventHandler(this.OnEditCompany);
                list.ShowDialog(this);
                RefreshGrid();
            }
            catch(RequiredPropertyValueMissing ex) {
                System.Windows.Forms.MessageBox.Show(this, ex.Message);
            }
        }

        private void mnuDeleteContact_Click(object sender, System.EventArgs e) {
            Contact contact = ((Contact)contacts[gridContacts.CurrentRowIndex]);
            contact.Delete();
            contact.Save();
            contacts.Remove(contact);
            UpdateMenu();
        }

        private void mnuAbout_Click(object sender, System.EventArgs e) {
            new About().ShowDialog(this);
        }

        private void mnuCompact_Click(object sender, System.EventArgs e) {
            System.Windows.Forms.Cursor cur = this.Cursor;
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            try {
                session.PurgeDeletedObjects();
                MessageBox.Show(this, "Compacting done.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally {
                this.Cursor = cur;
            }
        }

        private void gridContacts_Navigate(object sender, System.Windows.Forms.NavigateEventArgs ne) {

        }
    }
}
