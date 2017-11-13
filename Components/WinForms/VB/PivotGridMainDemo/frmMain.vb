Imports Microsoft.VisualBasic
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils
Imports System
Imports DevExpress.Tutorials

Namespace DevExpress.XtraPivotGrid.Demos
    Public Class frmMain
        Inherits RibbonMainForm
        Protected Overrides ReadOnly Property FileType() As SourceFileType
            Get
                Return SourceFileType.VB
            End Get
        End Property
        Protected Overrides Sub SetFormParam()
            Me.Icon = ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraPivotGrid.Demos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
        Protected Overrides Sub ShowModule(name As String, group As XtraEditors.GroupControl, lookAndFeel As LookAndFeel.DefaultLookAndFeel, caption As DevExpress.Utils.Frames.ApplicationCaption, notePanel As System.Windows.Forms.Control)
            DemosInfo.Show(name, group, caption, notePanel, TryCast(RibbonMenuManager, PivotGridRibbonMenuManager))
        End Sub

        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "XtraPivotGrid Features Demo (" & DemoHelper.GetLanguageString(GetType(frmMain).Assembly) & " code)"
            End Get
        End Property
        Protected Overrides Sub FillNavBar()
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText)
        End Sub
        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New PivotGridRibbonMenuManager(Me)
        End Function
        Protected Overrides Sub ShowAbout()
            PivotGridControl.About()
        End Sub
    End Class
End Namespace
