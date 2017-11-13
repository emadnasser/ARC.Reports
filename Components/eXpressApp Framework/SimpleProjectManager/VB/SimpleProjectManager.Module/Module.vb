Imports System
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.DC
Imports DevExpress.ExpressApp.Xpo
Imports System.Collections.Generic
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.Updating

' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppModuleBasetopic.aspx.
Partial Public NotInheritable Class SimpleProjectManagerModule
    Inherits ModuleBase
    Shared Sub New()
        DevExpress.Data.Linq.CriteriaToEFExpressionConverter.SqlFunctionsType = GetType(System.Data.Entity.SqlServer.SqlFunctions)
        DevExpress.Data.Linq.CriteriaToEFExpressionConverter.EntityFunctionsType = GetType(System.Data.Entity.DbFunctions)
		' Uncomment this code to delete and recreate the database each time the data model has changed.
		' Do not use this code in a production environment to avoid data loss.
		' #If DEBUG
		'     Database.SetInitializer(New DropCreateDatabaseIfModelChanges(Of SimpleProjectManagerDbContext)())
		' #End If 
    End Sub
    Public Sub New()
        InitializeComponent()
        BaseObject.OidInitializationMode = OidInitializationMode.AfterConstruction
    End Sub
    Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
        Dim updater As ModuleUpdater = New Updater(objectSpace, versionFromDB)
        Return New ModuleUpdater() {updater}
    End Function
    Public Overrides Sub Setup(ByVal application As XafApplication)
        MyBase.Setup(application)
        ' Manage various aspects of the application UI and behavior at the module level.
    End Sub
    Public Overrides Sub CustomizeTypesInfo(ByVal typesInfo As ITypesInfo)
        MyBase.CustomizeTypesInfo(typesInfo)
        CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo)
    End Sub
End Class
