Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data.Services
Imports System.Data.Services.Common
Imports Northwind
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.ServiceModel
Imports System.IO
Imports System.Web

Namespace DevExpress.Xpo.Demos

	Public Class XpoDemoContext
		Inherits XpoContext
		Public Sub New(ByVal s1 As String, ByVal s2 As String, ByVal dataLayer As IDataLayer)
			MyBase.New(s1, s2, dataLayer)
		End Sub
	End Class
	Public Class MyFactory
		Inherits DataServiceHostFactory
		Public Sub New()
			MyBase.New()
		End Sub
		Protected Overrides Overloads Function CreateServiceHost(ByVal serviceType As Type, ByVal baseAddresses() As Uri) As ServiceHost
			Return MyBase.CreateServiceHost(serviceType, baseAddresses)
		End Function
	End Class
	<ServiceBehavior(InstanceContextMode := InstanceContextMode.PerCall)> _
	Public Class XpoDemoService
		Inherits XpoDataServiceV3
		Private Shared ReadOnly context As New XpoContext("XpoContext", "Northwind", CreateDataLayer())

		Public Sub New()
			MyBase.New(context)
		End Sub

		Private Shared Function CreateDataLayer() As IDataLayer
			Dim dict As DevExpress.Xpo.Metadata.XPDictionary = New DevExpress.Xpo.Metadata.ReflectionDictionary()
			' Initialize the XPO dictionary. 
			dict.GetDataStoreSchema(GetType(Orders).Assembly)
			Dim store As New InMemoryDataStore(AutoCreateOption.SchemaOnly)
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(HttpRuntime.AppDomainAppPath, "Data\nwind.xml")
			If DBFileName <> "" Then
				store.ReadXml(DBFileName)
			End If
			Dim dataLayer As IDataLayer = New ThreadSafeDataLayer(dict, store)
			XpoDefault.DataLayer = dataLayer
			XpoDefault.Session = Nothing
			Return dataLayer
		End Function
		Protected Overrides Sub OnStartProcessingRequest(ByVal args As ProcessRequestArgs)
			MyBase.OnStartProcessingRequest(args)
		End Sub
		Public Shared Sub InitializeService(ByVal config As DataServiceConfiguration)
			config.SetEntitySetAccessRule("*", EntitySetRights.All)
			config.DataServiceBehavior.AcceptAnyAllRequests = True
			config.UseVerboseErrors = True
			config.SetServiceOperationAccessRule("*", ServiceOperationRights.All)
			config.SetServiceActionAccessRule("*", ServiceActionRights.Invoke)
			config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3
			config.DataServiceBehavior.AcceptProjectionRequests = True
			config.DataServiceBehavior.AcceptCountRequests = True
			config.AnnotationsBuilder = CreateAnnotationsBuilder(Function() context)
			config.DataServiceBehavior.AcceptReplaceFunctionInQuery = True
			config.DataServiceBehavior.AcceptSpatialLiteralsInQuery = True
			config.DisableValidationOnMetadataWrite = True
		End Sub
	End Class
End Namespace
