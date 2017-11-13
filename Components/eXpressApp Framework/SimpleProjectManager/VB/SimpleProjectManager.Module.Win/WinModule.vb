Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating

<ToolboxItemFilter("Xaf.Platform.Win")> _
Partial Public NotInheritable Class SimpleProjectManagerWindowsFormsModule
    Inherits ModuleBase
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
        Return ModuleUpdater.EmptyModuleUpdaters
    End Function
End Class
