Namespace DevExpress.SalesDemo.Model
	Public Interface IDataProvider
		Function GetTotalSalesByRange(ByVal start As Date, ByVal [end] As Date) As SalesGroup
		Function GetSales(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As IEnumerable(Of SalesGroup)
		Function GetSalesByChannel(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As IEnumerable(Of SalesGroup)
		Function GetSalesByProduct(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As IEnumerable(Of SalesGroup)
		Function GetSalesByRegion(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As IEnumerable(Of SalesGroup)
		Function GetSalesBySector(ByVal start As Date, ByVal [end] As Date, ByVal period As GroupingPeriod) As IEnumerable(Of SalesGroup)
	End Interface
	'
	Public Interface IDataGenerator
		Event Start As ProgressEventHandler
		Event Progress As ProgressEventHandler
		Event Complete As ProgressEventHandler
	End Interface
	Public Delegate Sub ProgressEventHandler(ByVal sender As Object, ByVal e As ProgressEventArgs)
	Public Class ProgressEventArgs
		Public Sub New(ByVal progress As Integer)
			Me.Progress = progress
		End Sub
		Private privateProgress As Integer
		Public Property Progress() As Integer
			Get
				Return privateProgress
			End Get
			Private Set(ByVal value As Integer)
				privateProgress = value
			End Set
		End Property
	End Class
End Namespace
