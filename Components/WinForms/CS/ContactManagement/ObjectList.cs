using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace ContactManagement {
	
	public partial class ObjectList : System.Windows.Forms.Form {
		private void UpdateMenu() {
			mnuDelete.Enabled = gridObjects.CurrentRowIndex >= 0;
			mnuEdit.Enabled = mnuDelete.Enabled;
		}
		public event InsertObjectEventHandler OnInsertObject;
		public event EditObjectEventHandler OnEditObject;

		public ObjectList() {
			InitializeComponent();
		}
		public ObjectList(string caption, XPCollection collection, string displayableProperties) : this() {
			this.Text = caption;
			objects = collection;
			objects.DisplayableProperties = displayableProperties;
			gridObjects.DataSource = objects;
			UpdateMenu();
		}
		public ObjectList(string caption, Session session, Type objectType, CriteriaOperator criteria, string displayableProperties)
			: this(caption, new XPCollection(session, objectType, criteria), displayableProperties) {
		}
		
		private void gridObjects_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
			if(e.KeyCode == Keys.Delete) mnuDelete_Click(null, null);			
			if(e.KeyCode == Keys.Insert) mnuAdd_Click(null, null);
			if(e.KeyCode == Keys.Enter) mnuEdit_Click(null, null);
		}

		private void mnuAdd_Click(object sender, System.EventArgs e) {
			if(OnInsertObject != null)
				OnInsertObject(this);
			objects.Reload();
			gridObjects.Refresh();
			UpdateMenu();
		}

		private void mnuEdit_Click(object sender, System.EventArgs e) {
			if(OnEditObject != null)
				OnEditObject(this, new EditObjectEventArgs(objects[gridObjects.CurrentRowIndex]));
			objects.Reload();
			gridObjects.Refresh();
		}

		private void mnuDelete_Click(object sender, System.EventArgs e) {
			XPObject obj = (XPObject)objects[gridObjects.CurrentRowIndex];
			obj.Delete();
			obj.Save();
			objects.Remove(obj);
			UpdateMenu();
		}
	}
}
