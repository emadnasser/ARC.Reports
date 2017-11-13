using DevExpress.XtraEditors;

namespace DevExpress.Docs.Demos {
    public partial class SpreadsheetMailMergeModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.phone = new DevExpress.XtraEditors.LabelControl();
            this.state = new DevExpress.XtraEditors.LabelControl();
            this.email = new DevExpress.XtraEditors.LabelControl();
            this.phoneTE = new DevExpress.XtraEditors.TextEdit();
            this.stateAddressTE = new DevExpress.XtraEditors.TextEdit();
            this.emailTE = new DevExpress.XtraEditors.TextEdit();
            this.zipCode = new DevExpress.XtraEditors.LabelControl();
            this.zipCodeTE = new DevExpress.XtraEditors.TextEdit();
            this.statementNumber = new DevExpress.XtraEditors.LabelControl();
            this.statementNumberTE = new DevExpress.XtraEditors.TextEdit();
            this.customerID = new DevExpress.XtraEditors.LabelControl();
            this.customerIDTE = new DevExpress.XtraEditors.TextEdit();
            this.namelbl = new DevExpress.XtraEditors.LabelControl();
            this.nameTE = new DevExpress.XtraEditors.TextEdit();
            this.streetAddress = new DevExpress.XtraEditors.LabelControl();
            this.streetAddressTE = new DevExpress.XtraEditors.TextEdit();
            this.cityAddress = new DevExpress.XtraEditors.LabelControl();
            this.cityAddressTE = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateAddressTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statementNumberTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetAddressTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityAddressTE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(474, 33);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(34, 13);
            this.phone.TabIndex = 24;
            this.phone.Text = "Phone:";
            // 
            // state
            // 
            this.state.Location = new System.Drawing.Point(249, 56);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(30, 13);
            this.state.TabIndex = 25;
            this.state.Text = "State:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(474, 56);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(32, 13);
            this.email.TabIndex = 26;
            this.email.Text = "E-mail:";
            // 
            // phoneTE
            // 
            this.phoneTE.EditValue = "(206)555-812";
            this.phoneTE.Location = new System.Drawing.Point(526, 30);
            this.phoneTE.Name = "phoneTE";
            this.phoneTE.Size = new System.Drawing.Size(125, 20);
            this.phoneTE.TabIndex = 6;
            this.phoneTE.EditValueChanged += new System.EventHandler(this.textEdit_EditValueChanged);
            // 
            // stateAddressTE
            // 
            this.stateAddressTE.EditValue = "WA";
            this.stateAddressTE.Location = new System.Drawing.Point(329, 53);
            this.stateAddressTE.Name = "stateAddressTE";
            this.stateAddressTE.Size = new System.Drawing.Size(125, 20);
            this.stateAddressTE.TabIndex = 5;
            this.stateAddressTE.EditValueChanged += new System.EventHandler(this.textEdit_EditValueChanged);
            // 
            // emailTE
            // 
            this.emailTE.EditValue = "mpeacock@example.net";
            this.emailTE.Location = new System.Drawing.Point(526, 53);
            this.emailTE.Name = "emailTE";
            this.emailTE.Size = new System.Drawing.Size(125, 20);
            this.emailTE.TabIndex = 8;
            this.emailTE.EditValueChanged += new System.EventHandler(this.textEdit_EditValueChanged);
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(474, 10);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(48, 13);
            this.zipCode.TabIndex = 0;
            this.zipCode.Text = "ZIP Code:";
            // 
            // zipCodeTE
            // 
            this.zipCodeTE.EditValue = "98052";
            this.zipCodeTE.Location = new System.Drawing.Point(526, 7);
            this.zipCodeTE.Name = "zipCodeTE";
            this.zipCodeTE.Size = new System.Drawing.Size(125, 20);
            this.zipCodeTE.TabIndex = 6;
            this.zipCodeTE.EditValueChanged += new System.EventHandler(this.textEdit_EditValueChanged);
            // 
            // statementNumber
            // 
            this.statementNumber.Location = new System.Drawing.Point(6, 10);
            this.statementNumber.Name = "statementNumber";
            this.statementNumber.Size = new System.Drawing.Size(94, 13);
            this.statementNumber.TabIndex = 12;
            this.statementNumber.Text = "Statement Number:";
            // 
            // statementNumberTE
            // 
            this.statementNumberTE.EditValue = "No.";
            this.statementNumberTE.Location = new System.Drawing.Point(104, 7);
            this.statementNumberTE.Name = "statementNumberTE";
            this.statementNumberTE.Size = new System.Drawing.Size(125, 20);
            this.statementNumberTE.TabIndex = 0;
            this.statementNumberTE.EditValueChanged += new System.EventHandler(this.textEdit_EditValueChanged);
            // 
            // customerID
            // 
            this.customerID.Location = new System.Drawing.Point(6, 33);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(64, 13);
            this.customerID.TabIndex = 14;
            this.customerID.Text = "Customer ID:";
            // 
            // customerIDTE
            // 
            this.customerIDTE.EditValue = "ABC12345";
            this.customerIDTE.Location = new System.Drawing.Point(104, 30);
            this.customerIDTE.Name = "customerIDTE";
            this.customerIDTE.Size = new System.Drawing.Size(125, 20);
            this.customerIDTE.TabIndex = 1;
            this.customerIDTE.EditValueChanged += new System.EventHandler(this.textEdit_EditValueChanged);
            // 
            // name
            // 
            this.namelbl.Location = new System.Drawing.Point(6, 56);
            this.namelbl.Name = "name";
            this.namelbl.Size = new System.Drawing.Size(80, 13);
            this.namelbl.TabIndex = 16;
            this.namelbl.Text = "Customer Name:";
            // 
            // nameTE
            // 
            this.nameTE.EditValue = "Margaret Peacock";
            this.nameTE.Location = new System.Drawing.Point(104, 53);
            this.nameTE.Name = "nameTE";
            this.nameTE.Size = new System.Drawing.Size(125, 20);
            this.nameTE.TabIndex = 2;
            this.nameTE.EditValueChanged += new System.EventHandler(this.textEdit_EditValueChanged);
            // 
            // streetAddress
            // 
            this.streetAddress.Location = new System.Drawing.Point(249, 10);
            this.streetAddress.Name = "streetAddress";
            this.streetAddress.Size = new System.Drawing.Size(76, 13);
            this.streetAddress.TabIndex = 20;
            this.streetAddress.Text = "Street Address:";
            // 
            // streetAddressTE
            // 
            this.streetAddressTE.EditValue = "NE 74th St, Town Center";
            this.streetAddressTE.Location = new System.Drawing.Point(329, 7);
            this.streetAddressTE.Name = "streetAddressTE";
            this.streetAddressTE.Size = new System.Drawing.Size(125, 20);
            this.streetAddressTE.TabIndex = 3;
            this.streetAddressTE.EditValueChanged += new System.EventHandler(this.textEdit_EditValueChanged);
            // 
            // cityAddress
            // 
            this.cityAddress.Location = new System.Drawing.Point(249, 33);
            this.cityAddress.Name = "cityAddress";
            this.cityAddress.Size = new System.Drawing.Size(23, 13);
            this.cityAddress.TabIndex = 22;
            this.cityAddress.Text = "City:";
            // 
            // cityAddressTE
            // 
            this.cityAddressTE.EditValue = "Redmond";
            this.cityAddressTE.Location = new System.Drawing.Point(329, 30);
            this.cityAddressTE.Name = "cityAddressTE";
            this.cityAddressTE.Size = new System.Drawing.Size(125, 20);
            this.cityAddressTE.TabIndex = 4;
            this.cityAddressTE.EditValueChanged += new System.EventHandler(this.textEdit_EditValueChanged);
            // 
            // MailMergeModule
            // 
            this.Controls.Add(this.statementNumber);
            this.Controls.Add(this.statementNumberTE);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.customerIDTE);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.nameTE);
            this.Controls.Add(this.streetAddress);
            this.Controls.Add(this.streetAddressTE);
            this.Controls.Add(this.cityAddress);
            this.Controls.Add(this.cityAddressTE);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.zipCodeTE);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.state);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phoneTE);
            this.Controls.Add(this.stateAddressTE);
            this.Controls.Add(this.emailTE);
            this.Name = "MailMergeModule";
            this.Controls.SetChildIndex(this.emailTE, 0);
            this.Controls.SetChildIndex(this.stateAddressTE, 0);
            this.Controls.SetChildIndex(this.phoneTE, 0);
            this.Controls.SetChildIndex(this.email, 0);
            this.Controls.SetChildIndex(this.state, 0);
            this.Controls.SetChildIndex(this.phone, 0);
            this.Controls.SetChildIndex(this.zipCodeTE, 0);
            this.Controls.SetChildIndex(this.zipCode, 0);
            this.Controls.SetChildIndex(this.cityAddressTE, 0);
            this.Controls.SetChildIndex(this.cityAddress, 0);
            this.Controls.SetChildIndex(this.streetAddressTE, 0);
            this.Controls.SetChildIndex(this.streetAddress, 0);
            this.Controls.SetChildIndex(this.nameTE, 0);
            this.Controls.SetChildIndex(this.namelbl, 0);
            this.Controls.SetChildIndex(this.customerIDTE, 0);
            this.Controls.SetChildIndex(this.customerID, 0);
            this.Controls.SetChildIndex(this.statementNumberTE, 0);
            this.Controls.SetChildIndex(this.statementNumber, 0);
            ((System.ComponentModel.ISupportInitialize)(this.phoneTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateAddressTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zipCodeTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statementNumberTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIDTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetAddressTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityAddressTE.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        LabelControl statementNumber;
        LabelControl customerID;
        LabelControl namelbl;
        LabelControl streetAddress;
        LabelControl cityAddress;
        LabelControl zipCode;
        LabelControl phone;
        LabelControl state;
        LabelControl email;
        TextEdit statementNumberTE;
        TextEdit customerIDTE;
        TextEdit nameTE;
        TextEdit streetAddressTE;
        TextEdit cityAddressTE;
        TextEdit stateAddressTE;
        TextEdit zipCodeTE;
        TextEdit phoneTE;
        TextEdit emailTE;
    }
}
