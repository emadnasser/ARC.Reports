Imports Microsoft.VisualBasic
Imports System
Imports System.Threading
Imports System.Web
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata


Public NotInheritable Class XpoHelper
	Private Sub New()
	End Sub
	Public Shared Function GetNewSession() As Session
		Return New Session(DataLayer)
	End Function

	Public Shared Function GetNewUnitOfWork() As UnitOfWork
		Return New UnitOfWork(DataLayer)
	End Function

	Private ReadOnly Shared _lockObject As Object = New Object()

	Private Shared _dataLayer As Object
	Private Shared ReadOnly Property DataLayer() As IDataLayer
		Get
			If _dataLayer Is Nothing Then
				SyncLock _lockObject
					If Thread.VolatileRead(_dataLayer) Is Nothing Then
						Thread.VolatileWrite(_dataLayer, CreateDataLayer())
					End If
				End SyncLock
			End If
			Return CType(_dataLayer, IDataLayer)
		End Get
	End Property

	Private Shared Function CreateDataLayer() As IDataLayer
		XpoDefault.Session = Nothing
		Dim dict As XPDictionary = New ReflectionDictionary()
		' Note: in a real application, use the AutoCreateOption.SchemaAlreadyExists option
		Dim store As IDataStore = XpoDefault.GetConnectionProvider(GetConnectionString(), AutoCreateOption.DatabaseAndSchema)
		dict.GetDataStoreSchema(GetType(Task), GetType(Employee))
		Dim dl As IDataLayer = New ThreadSafeDataLayer(dict, store)
		Return dl
	End Function

	Private Shared Function GetConnectionString() As String
		Return AccessConnectionProviderMultiUserThreadSafe.GetConnectionString(HttpContext.Current.Server.MapPath("~\App_Data\XPOBoundMode.mdb"), String.Empty, String.Empty)
	End Function
End Class
