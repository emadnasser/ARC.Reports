Imports DevExpress.DXperience.Demos
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.About
Imports DevExpress.Utils.Frames

Namespace DevExpress.XtraGauges.Demos
    Public Class frmMain
        Inherits DevExpress.DXperience.Demos.RibbonMainForm
        Private showOutdated As Boolean = True
        Public Sub New(ByVal arguments() As String)
            MyBase.New(arguments)
            ToolTipController.DefaultController.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
            For Each name As String In arguments
                If name = "-demo" Then
                    showOutdated = False
                End If
            Next name
        End Sub
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "The XtraGauge Suite by DevExpress (VB code)"
            End Get
        End Property
        Protected Overrides Sub ShowAbout()
            DevExpress.XtraGauges.Win.GaugeControl.About()
        End Sub
        Protected Overrides Sub SetFormParam()
            'Me.accordionControl1.Parent.Width = 210
            Me.MinimumSize = New System.Drawing.Size(800, 600)
            Me.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(DevExpress.XtraGauges.Demos.frmMain).Assembly)
        End Sub
        Protected Overrides Function CreateRibbonMenuManager() As RibbonMenuManager
            Return New GaugesRibbonMenuManager(Me)
        End Function
        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DefaultLookAndFeel, ByVal caption As ApplicationCaption)
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager)
        End Sub
        Protected Overrides Sub FillNavBar()
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText, showOutdated)
        End Sub
    End Class
End Namespace
