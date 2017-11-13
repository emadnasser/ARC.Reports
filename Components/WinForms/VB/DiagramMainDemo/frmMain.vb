Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraNavBar
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Frames
Imports DevExpress.Tutorials
Imports System.Linq

Namespace DevExpress.XtraDiagram.Demos
    Public Class frmMain
        Inherits RibbonMainForm

        Public Sub New()
        End Sub
        Protected Overrides Sub SetFormParam()
            Dim assembly = GetType(frmMain).Assembly
            Me.Icon = ResourceImageHelper.CreateIconFromResources(assembly.GetManifestResourceNames().First(Function(x) x.Contains("DemoIcon.ico")), assembly)
        End Sub
        Protected Overrides Sub ShowAbout()
            DiagramControl.About()
        End Sub
        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As GroupControl, ByVal lookAndFeel As DefaultLookAndFeel, ByVal caption As ApplicationCaption)
            DemosInfo.ShowDiagramModule(name, group, caption, RibbonMenuManager)
        End Sub
        Protected Overrides Sub FillNavBar()
            DemosInfo.FillAccordionControl(accordionControl1, NavBarGroupStyle.SmallIconsList, True, NavBarImage.Large)
        End Sub
        Protected Overrides ReadOnly Property FileType() As SourceFileType
            Get
                Return SourceFileType.CS
            End Get
        End Property

        Protected Overrides ReadOnly Property CustomWidth() As Integer
            Get
                Return 1350
            End Get
        End Property
        Protected Overrides ReadOnly Property CustomHeight() As Integer
            Get
                Return 950
            End Get
        End Property

        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "The XtraDiagramControl by DevExpress (" & GetLanguageString() & " code)"
            End Get
        End Property
        Protected Overrides ReadOnly Property ProductName() As String
            Get
                Return "XtraDiagramControl"
            End Get
        End Property

        Private Shared Function GetLanguageString() As String
            Dim result As String = DemoHelper.GetLanguageString(GetType(frmMain).Assembly)
            If result = "CS" Then
                result = "C#"
            End If
            Return result
        End Function
    End Class
End Namespace
