Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraScheduler.Demos
	Partial Public Class CarsDBDataSet
	End Class
End Namespace

Namespace DevExpress.XtraScheduler.Demos.CarsDBDataSetTableAdapters
	Partial Public Class CarSchedulingTableAdapter
		Public ReadOnly Property DataAdapter() As System.Data.OleDb.OleDbDataAdapter
			Get
				Return Me.Adapter
			End Get
		End Property
	End Class
End Namespace
