Namespace DevExpress.SalesDemo.Model
	Public NotInheritable Class DataSource

		Private Sub New()
		End Sub

		Private Shared instance As IDataProvider
		Private Shared Function GetEntryAssemblyDirectory() As String
			Dim curr As System.Reflection.Assembly = System.Reflection.Assembly.GetEntryAssembly()
			If curr Is Nothing Then
				Return Nothing
			End If
			Dim appPath As String = curr.Location
			Return System.IO.Path.GetDirectoryName(appPath)
		End Function
		Private Shared ReadOnly Property AppDirectory() As String
			Get
				Return GetEntryAssemblyDirectory()
			End Get
		End Property
		Private Shared Function FindFile(ByVal fileName As String, ByVal directoryName As String) As String
			Dim appPath As String = AppDirectory
			If appPath Is Nothing Then
				Return Nothing
			End If
			Dim dirName As String = System.IO.Path.GetFullPath(appPath)
			For n As Integer = 0 To 8
				Dim path As String = dirName & "\" & directoryName & "\" & fileName
				Try
					If System.IO.File.Exists(path) OrElse System.IO.Directory.Exists(path) Then
						Return path
					End If
				Catch
				End Try
				dirName &= "\.."
			Next n
			Throw New System.IO.FileNotFoundException(fileName & " not found")
		End Function
		Public Shared Function GetDataProvider() As IDataProvider
			If instance Is Nothing Then
				EnsureDataProvider()
			End If
			Return instance
		End Function
		Public Shared Sub EnsureDataProvider()
			If instance IsNot Nothing Then
				Return
			End If
			Dim dbPath As String = FindFile("sales.mdb", "Data")
			System.IO.File.SetAttributes(dbPath, System.IO.FileAttributes.Normal)
			Dim generator = New DevExpress.Demos.SalesDBGenerator.SalesGenerator()
			Using ProgressTracker.Instance.StartTracking(generator)
				generator.Run(OleDataProvider.GetConnectionString(dbPath))
				instance = New OleDataProvider(dbPath)
			End Using
		End Sub
		Public Shared ReadOnly Property Progress() As IObservable(Of Integer)
			Get
				Return (CType(ProgressTracker.Instance, IObservable(Of Integer)))
			End Get
		End Property
		#Region "IObservable"
		Private Class ProgressTracker
			Implements IObservable(Of Integer)

			Friend Shared Instance As New ProgressTracker()
			Private observers As IList(Of IObserver(Of Integer))
			Private Sub New()
				observers = New List(Of IObserver(Of Integer))()
			End Sub
			Public Function StartTracking(ByVal generator As IDataGenerator) As IDisposable
				Return New TrackingContext(generator, Me)
			End Function
			Private Function IObservableGeneric_Subscribe(ByVal observer As IObserver(Of Integer)) As IDisposable Implements IObservable(Of Integer).Subscribe
				Return New Subscription(Me, observer)
			End Function
			Private Sub generator_Start(ByVal sender As Object, ByVal e As ProgressEventArgs)
				For Each observer As IObserver(Of Integer) In observers
					observer.OnNext(e.Progress)
				Next observer
			End Sub
			Private Sub generator_Complete(ByVal sender As Object, ByVal e As ProgressEventArgs)
				For Each observer As IObserver(Of Integer) In observers
					observer.OnCompleted()
				Next observer
			End Sub
			Private Sub generator_Progress(ByVal sender As Object, ByVal e As ProgressEventArgs)
				For Each observer As IObserver(Of Integer) In observers
					observer.OnNext(e.Progress)
				Next observer
			End Sub
			Private Class TrackingContext
				Implements IDisposable

                Private generator As IDataGenerator
				Private tracker As ProgressTracker
				Public Sub New(ByVal generator As IDataGenerator, ByVal tracker As ProgressTracker)
                    AddHandler generator.Start, AddressOf tracker.generator_Start
                    AddHandler generator.Complete, AddressOf tracker.generator_Complete
                    AddHandler generator.Progress, AddressOf tracker.generator_Progress
					Me.generator = generator
					Me.tracker = tracker
				End Sub
				Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
                    RemoveHandler generator.Start, AddressOf tracker.generator_Start
                    RemoveHandler generator.Complete, AddressOf tracker.generator_Complete
                    RemoveHandler generator.Progress, AddressOf tracker.generator_Progress
				End Sub
			End Class
			Private Class Subscription
				Implements IDisposable

				Private observer As IObserver(Of Integer)
				Private tracker As ProgressTracker
				Public Sub New(ByVal tracker As ProgressTracker, ByVal observer As IObserver(Of Integer))
					If Not tracker.observers.Contains(observer) Then
						tracker.observers.Add(observer)
					End If
					Me.tracker = tracker
					Me.observer = observer
				End Sub
				Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
					tracker.observers.Remove(observer)
				End Sub
			End Class
		End Class
		#End Region ' IObservable
	End Class
	'
	Public Class SalesGroup
		Private privateGroupName As String
		Public Property GroupName() As String
			Get
				Return privateGroupName
			End Get
			Set(ByVal value As String)
				privateGroupName = value
			End Set
		End Property
		Private privateTotalCost As Decimal
		Public Property TotalCost() As Decimal
			Get
				Return privateTotalCost
			End Get
			Set(ByVal value As Decimal)
				privateTotalCost = value
			End Set
		End Property
		Private privateUnits As Integer
		Public Property Units() As Integer
			Get
				Return privateUnits
			End Get
			Set(ByVal value As Integer)
				privateUnits = value
			End Set
		End Property
		Private privateStartOfPeriod As Date
		Public Property StartOfPeriod() As Date
			Get
				Return privateStartOfPeriod
			End Get
			Set(ByVal value As Date)
				privateStartOfPeriod = value
			End Set
		End Property
		Private privateEndOfPeriod As Date
		Public Property EndOfPeriod() As Date
			Get
				Return privateEndOfPeriod
			End Get
			Set(ByVal value As Date)
				privateEndOfPeriod = value
			End Set
		End Property
		Public Sub New()
		End Sub
		Public Sub New(ByVal groupName As String, ByVal totalCost As Decimal, ByVal unitsSold As Integer, ByVal startOfPeriod As Date, ByVal endOfPeriod As Date)
			Me.GroupName = groupName
			Me.TotalCost = totalCost
			Units = unitsSold
			Me.StartOfPeriod = startOfPeriod
			Me.EndOfPeriod = endOfPeriod
		End Sub
	End Class
	Public Enum GroupingPeriod
		Hour
		Day
		All
		None
	End Enum
End Namespace
