Imports System
Imports System.Web.UI
Imports DevExpress.Web

Partial Public Class SiteMasterBase
    Inherits MasterPage

    Protected Sub DownloadButton_CustomJSProperties(ByVal sender As Object, ByVal e As CustomJSPropertiesEventArgs)
        e.Properties("cpTrialUrl") = AssemblyInfo.DXLinkTrial
    End Sub
End Class
