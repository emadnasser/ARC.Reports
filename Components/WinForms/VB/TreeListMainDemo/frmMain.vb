Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials
Imports DevExpress.Utils.About

Namespace DevExpress.XtraTreeList.Demos
    Public Class frmMain
        Inherits DevExpress.DXperience.Demos.RibbonMainForm

        Protected Overrides Sub SetFormParam()
            Me.accordionControl1.Parent.Width = 200
            Me.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
        Protected Overrides ReadOnly Property FileType() As SourceFileType
            Get
                Return SourceFileType.VB
            End Get
        End Property
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "The XtraTreeList Suite by DevExpress (VB code)"
            End Get
        End Property
        Protected Overrides Sub ShowAbout()
            TreeList.About()
        End Sub

        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New TreeListRibbonMenuManager(Me)
        End Function
        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
            DemosInfo.ShowModule(name, group, caption, TryCast(RibbonMenuManager, TreeListRibbonMenuManager))
        End Sub

        Protected Overrides Sub FillNavBar()
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, True, DevExpress.XtraNavBar.NavBarImage.Large)
        End Sub
    End Class
End Namespace
