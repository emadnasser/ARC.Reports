Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class RichEditMailMerge
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New DevExpress.Docs.Demos.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.cLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.cContactName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.printPreviewControl = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.employeesTableAdapter = New DevExpress.Docs.Demos.nwindDataSetTableAdapters.EmployeesTableAdapter()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.gridControl1.DataSource = Me.employeesBindingSource
			Me.gridControl1.Location = New System.Drawing.Point(3, 3)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(299, 426)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.cLastName, Me.cContactName})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupCount = 1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False
			Me.gridView1.OptionsBehavior.Editable = False
			Me.gridView1.OptionsView.ShowGroupPanel = False
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.cLastName, DevExpress.Data.ColumnSortOrder.Ascending)})
			' 
			' cLastName
			' 
			Me.cLastName.Caption = "Employee"
			Me.cLastName.FieldName = "LastName"
			Me.cLastName.Name = "cLastName"
			Me.cLastName.Visible = True
			Me.cLastName.VisibleIndex = 0
			' 
			' cContactName
			' 
			Me.cContactName.Caption = "Contact Name"
			Me.cContactName.FieldName = "ContactName"
			Me.cContactName.Name = "cContactName"
			Me.cContactName.Visible = True
			Me.cContactName.VisibleIndex = 0
			' 
			' printPreviewControl
			' 
			Me.printPreviewControl.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.printPreviewControl.IsMetric = False
			Me.printPreviewControl.Location = New System.Drawing.Point(308, 3)
			Me.printPreviewControl.Name = "printPreviewControl"
			Me.printPreviewControl.Size = New System.Drawing.Size(473, 426)
			Me.printPreviewControl.TabIndex = 33
			Me.printPreviewControl.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' MailMerge
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.printPreviewControl)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "MailMerge"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As XtraGrid.GridControl
		Private gridView1 As XtraGrid.Views.Grid.GridView
		Private printPreviewControl As XtraPrinting.Control.PrintControl
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private nwindDataSet As nwindDataSet
		Private employeesTableAdapter As nwindDataSetTableAdapters.EmployeesTableAdapter
		Private cLastName As XtraGrid.Columns.GridColumn
		Private cContactName As XtraGrid.Columns.GridColumn
	End Class
End Namespace
