Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating

<ToolboxItemFilter("Xaf.Platform.Web")> _
Partial Public NotInheritable Class SimpleProjectManagerAspNetModule
    Inherits ModuleBase
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
        Return ModuleUpdater.EmptyModuleUpdaters
    End Function
End Class
