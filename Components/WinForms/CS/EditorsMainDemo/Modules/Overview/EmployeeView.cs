using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.XtraEditors.Demos.Modules.Overview {
    public partial class EmployeeView : TutorialControl {
        public EmployeeView() {
            InitializeComponent();
            StatusImageComboBoxEdit.Properties.Items.AddEnum<EmployeeStatus>();
            EditorHelpers.CreatePersonPrefixImageComboBox(PrefixImageComboBoxEdit.Properties, null);
            colPriority.ColumnEdit = EditorHelpers.CreateTaskPriorityImageComboBox(null, gridControlTasks.RepositoryItems);
            DepartmentImageComboBoxEdit.Properties.Items.AddEnum<EmployeeDepartment>();
            StateImageComboBoxEdit.Properties.Items.AddEnum<StateEnum>();
            this.bindingSource.Add(EmployeeDataHelper.CreateDefaultEmployee());
        }
    }

}
