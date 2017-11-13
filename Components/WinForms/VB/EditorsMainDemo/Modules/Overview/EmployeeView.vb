Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.ComponentModel.DataAnnotations

Namespace DevExpress.XtraEditors.Demos.Modules.Overview
	Partial Public Class EmployeeView
		Inherits TutorialControl

		Public Sub New()
			InitializeComponent()
			StatusImageComboBoxEdit.Properties.Items.AddEnum(Of EmployeeStatus)()
			EditorHelpers.CreatePersonPrefixImageComboBox(PrefixImageComboBoxEdit.Properties, Nothing)
			colPriority.ColumnEdit = EditorHelpers.CreateTaskPriorityImageComboBox(Nothing, gridControlTasks.RepositoryItems)
			DepartmentImageComboBoxEdit.Properties.Items.AddEnum(Of EmployeeDepartment)()
			StateImageComboBoxEdit.Properties.Items.AddEnum(Of StateEnum)()
			Me.bindingSource.Add(EmployeeDataHelper.CreateDefaultEmployee())
		End Sub
	End Class

End Namespace
