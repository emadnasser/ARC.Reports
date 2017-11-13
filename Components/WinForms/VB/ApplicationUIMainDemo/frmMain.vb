Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class frmMain
        Inherits DevExpress.DXperience.Demos.RibbonMainForm
        Protected Overrides Sub SetFormParam()
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.ApplicationUI.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "Application UI Layout Controls Demo (VB code)"
            End Get
        End Property
        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "ApplicationUI"
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            DevExpress.XtraBars.Docking2010.DocumentManager.About()
        End Sub
        Protected Overloads Overrides Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
            DemosInfo.ShowDemoModule(name, group, caption, RibbonMenuManager)
        End Sub
        Protected Overrides Sub FillNavBar()
            DevExpress.DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList, True, DevExpress.XtraNavBar.NavBarImage.Large)
        End Sub
    End Class
End Namespace
