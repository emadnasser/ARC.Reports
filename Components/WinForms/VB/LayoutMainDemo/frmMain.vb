Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraNavBar
Imports DevExpress.DXperience.Demos
Imports DevExpress.Utils.About

Namespace DevExpress.XtraLayout.Demos
    Public Class frmMain
        Inherits DevExpress.DXperience.Demos.RibbonMainForm
        Protected Overrides Sub SetFormParam()
            'Me.navBarControl1.Parent.Width = 176
            Me.Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResources("AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "The XtraLayout Control by DevExpress (VB code)"
            End Get
        End Property
        Protected Overrides ReadOnly Property ProductName As String
            Get
                Return "XtraLayoutControl"
            End Get
        End Property

        Protected Overrides Sub ShowAbout()
            LayoutControl.About()
        End Sub
        Protected Overloads Overrides Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
            DemosInfo.ShowModule(name, group, caption, RibbonMenuManager)
        End Sub
        Protected Overrides Sub FillNavBar()
            DemosInfo.FillAccordionControl(accordionControl1, DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList, True, NavBarImage.Large)
        End Sub

    End Class
End Namespace
