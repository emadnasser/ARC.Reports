Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.Persistent.Base.Security
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Security
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.PivotChart.Web
Imports DevExpress.ExpressApp.PivotChart
Imports MainDemo.Module.DatabaseUpdate

Namespace MainDemo.Module.Web.DatabaseUpdate
    Public Class Updater
        Inherits ModuleUpdater
        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            CType(New TaskAnalysis1LayoutUpdater(), TaskAnalysis1LayoutUpdater).Update(ObjectSpace.FindObject(Of Analysis)(CriteriaOperator.Parse("Name='Completed tasks'")))
            CType(New TaskAnalysis2LayoutUpdater(), TaskAnalysis2LayoutUpdater).Update(ObjectSpace.FindObject(Of Analysis)(CriteriaOperator.Parse("Name='Estimated and actual work comparison'")))
        End Sub
    End Class
    Public Class TaskAnalysis1LayoutUpdater
        Inherits TaskAnalysis1LayoutUpdaterBase
        Protected Overrides Function CreateAnalysisControl() As IAnalysisControl
            Return New AnalysisControlWeb()
        End Function
        Protected Overrides Function CreatePivotGridSettingsStore(ByVal control As IAnalysisControl) As DevExpress.Persistent.Base.IPivotGridSettingsStore
            Return New ASPxPivotGridSettingsStore((CType(control, AnalysisControlWeb)).PivotGrid)
        End Function
    End Class
    Public Class TaskAnalysis2LayoutUpdater
        Inherits TaskAnalysis2LayoutUpdaterBase
        Protected Overrides Function CreateAnalysisControl() As IAnalysisControl
            Return New AnalysisControlWeb()
        End Function
        Protected Overrides Function CreatePivotGridSettingsStore(ByVal control As IAnalysisControl) As DevExpress.Persistent.Base.IPivotGridSettingsStore
            Return New ASPxPivotGridSettingsStore((CType(control, AnalysisControlWeb)).PivotGrid)
        End Function
    End Class
End Namespace
