Imports DevExpress.Utils
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Frames
Imports DevExpress.Utils.About
Imports DevExpress.XtraEditors
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Native
Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials

Namespace DevExpress.XtraEditors.Demos
    Partial Public Class frmMain
        Inherits RibbonMainForm
        Protected Overrides ReadOnly Property FileType() As SourceFileType
            Get
                Return SourceFileType.VB
            End Get
        End Property
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "The XtraEditors Suite Demo (VB code)"
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub SetFormParam()
            accordionControl1.Parent.Width = 220
            Icon = ResourceImageHelper.CreateIconFromResourcesEx("AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel, ByVal caption As ApplicationCaption)
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager)
        End Sub
        Protected Overrides Sub ShowAbout()
            BaseEdit.About()
        End Sub
    End Class
End Namespace
