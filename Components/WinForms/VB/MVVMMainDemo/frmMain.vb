Namespace DevExpress.MVVM.Demos
    Partial Public Class frmMain
        Inherits DevExpress.DXperience.Demos.RibbonMainForm

        Protected Overrides Sub SetFormParam()
            Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.MVVM.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
        Protected Overrides ReadOnly Property ProductName() As String
            Get
                Return "MVVM"
            End Get
        End Property
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "Application Infrastructural MVVM Pattern Demo (VB code)"
            End Get
        End Property
        Protected Overrides Sub ShowAbout()
            DevExpress.Utils.MVVM.MVVMContext.About()
        End Sub
        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
            DemosInfo.ShowDemoModule(name, group, caption, RibbonMenuManager)
        End Sub
        Protected Overrides Sub FillNavBar()
            DevExpress.DXperience.Demos.ModulesInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList, True, DevExpress.XtraNavBar.NavBarImage.Large)
        End Sub
    End Class
End Namespace
