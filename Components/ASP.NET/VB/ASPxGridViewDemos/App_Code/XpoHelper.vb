Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Threading
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata
Imports DevExpress.Web.Demos

Public NotInheritable Class XpoHelper
	Private Sub New()
	End Sub
	Public Shared Function GetNewSession() As Session
		Return New Session(DataLayer)
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
		Dim store As IDataStore = XpoDefault.GetConnectionProvider(GetConnectionString(), AutoCreateOption.SchemaAlreadyExists)
		dict.GetDataStoreSchema(GetType(XpoEmailEntity), GetType(XpoPersonEntity))
		Dim dl As IDataLayer = New ThreadSafeDataLayer(dict, store)
		Return dl
	End Function

	Private Shared Function GetConnectionString() As String
		Dim table As DatabaseGenerator.TableData = If(EmailDataGenerator.Table, PersonDataGenerator.Table)
		Dim result As String = table.ConnectionString
		result &= ";XpoProvider=MSSqlServer"
		Return result
	End Function
End Class
