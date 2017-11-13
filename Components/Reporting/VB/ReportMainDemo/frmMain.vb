Imports System
Imports System.Configuration
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.DemoData.Helpers
Imports DevExpress.DemoReports
Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials
Imports DevExpress.Utils
Imports DevExpress.XtraReports.UI

Namespace XtraReportsDemos
    Public Class frmMain
        Inherits DevExpress.DXperience.Demos.RibbonMainForm

        Public Sub New()
        End Sub
        Protected Overrides Sub SetFormParam()
            Me.ribbonControl1.AutoHideEmptyItems = True
            Me.ribbonControl1.TransparentEditors = True
            Me.Icon = My.Resources.AppIcon
        End Sub
        Protected Overrides ReadOnly Property ProductName() As String
            Get
                Return "XtraReportsForWin"
            End Get
        End Property
        Protected Overrides ReadOnly Property IsAllowAboutModule() As Boolean
            Get
                Return False
            End Get
        End Property
        Protected Overrides ReadOnly Property DefaultModuleIndex() As Integer
            Get
                Dim item As DevExpress.DXperience.Demos.ModuleInfo = ModulesInfo.GetItemByType(GetType(XtraReportsDemos.MasterDetailReport.PreviewControl).FullName)
                If item IsNot Nothing Then
                    Dim index As Integer = ModulesInfo.GetItemIndex(item)
                    If index >= 0 Then
                        Return index
                    End If
                End If
                Return Math.Max(0, ModulesInfo.Count - 1)
            End Get
        End Property
        Protected Overrides ReadOnly Property DemoName() As String
            Get
                Return "DevExpress Reports Demo (C# code)"
            End Get
        End Property
        Protected Overrides Sub ShowModule(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal lookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption)
            Try
                Dim control As ModuleControl = TryCast(DemosInfo.ShowModuleEx(name, group, caption, RibbonMenuManager), ModuleControl)
                If control IsNot Nothing Then
                    control.Activate()
                End If

                If name.StartsWith("DevExpress XtraReports") OrElse ribbonStatusBar.Visible = True Then
                    Return
                End If
                ribbonStatusBar.Visible = True
            Catch ex As Exception
                Throw New Exception("Module failed: " & name, ex)
            End Try
        End Sub
        <STAThread>
        Shared Sub Main()
            Dim path As String = FilesHelper.FindingFileName(AppDomain.CurrentDomain.BaseDirectory, "Data\NWind.mdf", False)

            CType(New ConnectionStringConfigurator(ConfigurationManager.ConnectionStrings), ConnectionStringConfigurator).SelectDbEngine().ExpandDataDirectory(Function(fileName) DataFilesHelper.FindFile(fileName, DataFilesHelper.DataPath))

            Dim directory As String = System.IO.Path.GetDirectoryName(path)
            ConnectionHelper.SetDataDirectory(directory)

            ConnectionHelper.ApplyDataDirectory(directory)
            DevExpress.UserSkins.BonusSkins.Register()
            Application.Run(New frmMain())
        End Sub
        Protected Overrides ReadOnly Property AllowMergeStatusBar() As Boolean
            Get
                Return True
            End Get
        End Property
        Protected Overrides Sub ShowAbout()
            DevExpress.XtraReports.Extensions.ReportsAboutHelper.About()
        End Sub
    End Class
    Public Class DemosInfo
        Inherits ModulesInfo

        Public Shared Function ShowModuleEx(ByVal name As String, ByVal group As DevExpress.XtraEditors.GroupControl, ByVal caption As DevExpress.Utils.Frames.ApplicationCaption, ByVal manager As RibbonMenuManager) As TutorialControlBase
            If Instance.CurrentModuleBase IsNot Nothing Then
                If Instance.CurrentModuleBase.Name = name Then
                    Return Nothing
                End If
                Instance.CurrentModuleBase.TModule.Visible = False
            End If

            Dim item As DevExpress.DXperience.Demos.ModuleInfo = DemosInfo.GetItem(name)
            Dim tutorial As TutorialControlBase = TryCast(item.TModule, TutorialControlBase)
            If tutorial.IsDisposed Then
                Return Nothing
            End If
            tutorial.Bounds = group.DisplayRectangle
            Instance.CurrentModuleBase = item
            tutorial.Visible = False
            group.Controls.Add(tutorial)
            tutorial.Dock = DockStyle.Fill
            tutorial.RibbonMenuManager = manager
            tutorial.TutorialName = name
            tutorial.Caption = caption
            tutorial.Visible = True
            tutorial.BringToFront()
            tutorial.Focus()
            RaiseModuleChanged()
            Return tutorial
        End Function
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
                Return "The XtraReports Suite"
            End Get
        End Property
        Protected Overrides ReadOnly Property Line2Text() As String
            Get
                Return "A banded report designer and viewer for the WinForms platform."
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
                Return DevExpress.Utils.About.ProductKind.XtraReports
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
