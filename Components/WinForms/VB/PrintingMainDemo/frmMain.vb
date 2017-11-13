Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.LookAndFeel
Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials
Imports DevExpress.XtraPrinting
Imports DevExpress.Tutorials.Controls

Namespace XtraPrintingDemos
    Public Class frmMain
        Inherits DevExpress.DXperience.Demos.RibbonMainForm

        Private isDemoCenter As Boolean = False
        Private moduleContainer As ModuleContainer

        Protected Overrides Sub SetFormParam()
            Me.ribbonControl1.AutoHideEmptyItems = True
            Me.Icon = ResourceImageHelper.CreateIconFromResourcesEx("XtraPrintingDemos.AppIcon.ico", GetType(frmMain).Assembly)
        End Sub
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "XtraPrinting Features Demo (C# code)"
            End Get
        End Property
        Protected Overrides ReadOnly Property ProductName() As String
            Get
                Return "XtraPrinting"
            End Get
        End Property
        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
            If moduleContainer Is Nothing Then
                moduleContainer = New ModuleContainer() With {.Bounds = group.DisplayRectangle, .Dock = DockStyle.Fill}
                group.Controls.Add(moduleContainer)
                MergeRibbon(moduleContainer.RibbonControl)
            End If
            DemosInfo.ActivateModule(name, caption, Sub([module])
                moduleContainer.ModuleControl = [module]
                If TypeOf [module] Is IPreviewControl Then
                    DirectCast([module], IPreviewControl).Activate(moduleContainer.PrintRibbonController)
                End If
            End Sub)
        End Sub
        Protected Overrides Sub ShowAbout()
            PrintingSystem.About()
        End Sub
        <STAThread>
        Shared Sub Main(ByVal args() As String)
            Dim path As String = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, "Data\nwind.mdb", False)
            Dim directory As String = System.IO.Path.GetDirectoryName(path)
            AppDomain.CurrentDomain.SetData("DataDirectory", directory)

            DevExpress.UserSkins.BonusSkins.Register()
            Application.Run(New frmMain())
        End Sub
        Public Sub New()
            Me.New(New String() { })
        End Sub

        Public Sub New(ByVal args() As String)
            InitializeComponent()
            bciFilter.Checked = False

            If args.Length > 0 Then
                For Each arg As String In args
                    isDemoCenter = (Not String.IsNullOrEmpty(arg)) AndAlso arg.Equals("-demo")
                Next arg
            End If
        End Sub

        Private Sub InitializeComponent()
            Me.SuspendLayout()
            Me.ribbonStatusBar.Visible = True
            Me.ribbonControl1.TransparentEditors = True
            Me.ResumeLayout(False)
        End Sub
        Protected Overrides ReadOnly Property AllowMergeStatusBar() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
    Public Class About
        Inherits ucOverviewPage

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides ReadOnly Property Awards() As Image
            Get
                Return DevExpress.Tutorials.Properties.Resources.Awards_main
            End Get
        End Property
        Protected Overrides ReadOnly Property Line1Text() As String
            Get
                Return "The XtraPrinting Library"
            End Get
        End Property
        Protected Overrides ReadOnly Property Line2Text() As String
            Get
                Return "Print or export the contents of DevExpress WinForms controls."
            End Get
        End Property
        Protected Overrides ReadOnly Property Line3Text() As String
            Get
                Return "DevExpress Desktop Controls"
            End Get
        End Property
        Protected Overrides ReadOnly Property Line4Text() As String
            Get
                Return votedVSM
            End Get
        End Property
        Protected Overrides ReadOnly Property ProductKind() As DevExpress.Utils.About.ProductKind
            Get
                Return DevExpress.Utils.About.ProductKind.DXperienceWin
            End Get
        End Property
        Private Sub InitializeComponent()
            Me.SuspendLayout()
            ' 
            ' About
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "About"
            Me.Size = New System.Drawing.Size(439, 260)
            Me.ResumeLayout(False)

        End Sub
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private components As System.ComponentModel.IContainer = Nothing
    End Class
End Namespace
