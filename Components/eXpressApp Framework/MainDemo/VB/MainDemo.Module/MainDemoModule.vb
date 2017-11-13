Imports Microsoft.VisualBasic
Imports System
Imports System.Reflection
Imports System.Collections.Generic

Imports DevExpress.ExpressApp
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo.Metadata
Imports DevExpress.Xpo
Imports System.Configuration
Imports DevExpress.ExpressApp.ViewVariantsModule
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.ExpressApp.DC
Imports MainDemo.Module.BusinessObjects
Imports DevExpress.ExpressApp.ReportsV2

Namespace MainDemo.Module
    Partial Public NotInheritable Class MainDemoModule
        Inherits ModuleBase
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
            Dim predefinedReportsUpdater As PredefinedReportsUpdater = New PredefinedReportsUpdater(Application, objectSpace, versionFromDB)
            predefinedReportsUpdater.AddPredefinedReport(Of ContactsReport)("Contacts Report", GetType(Contact), True)
            Return New ModuleUpdater() {updater, predefinedReportsUpdater}
        End Function
        Shared Sub New()
            '            Note that you can specify the required format in a configuration file:
            '			<appSettings>
            '			   <add key="FullAddressFormat" value="{Country.Name} {City} {Street}">
            '			   <add key="FullAddressPersistentAlias" value="Country.Name+City+Street">
            '			   ...
            '			</appSettings>
            '
            '			... and set the specified format here in code:
            '			Address.SetFullAddressFormat(ConfigurationManager.AppSettings["FullAddressFormat"], ConfigurationManager.AppSettings["FullAddressPersistentAlias"]);
            '			

            Person.SetFullNameFormat("{LastName} {FirstName} {MiddleName}", "concat(FirstName, MiddleName, LastName)")
            Address.SetFullAddressFormat("City: {City}, Street: {Street}", "concat(City, Street)")
        End Sub
        Public Overrides Sub CustomizeTypesInfo(ByVal typesInfo As ITypesInfo)
            MyBase.CustomizeTypesInfo(typesInfo)
            CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo)
        End Sub
    End Class
    Public Class ReportDialogController
        Inherits ViewController(Of DetailView)
        Public Sub New()
            TargetObjectType = GetType(IReportDataV2)
        End Sub

        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            Dim controller As PreviewReportDialogController = Frame.GetController(Of PreviewReportDialogController)()
            If controller IsNot Nothing Then
                controller.CancelAction.Active.RemoveItem("ReportDesigner")
            End If
        End Sub
    End Class
End Namespace
