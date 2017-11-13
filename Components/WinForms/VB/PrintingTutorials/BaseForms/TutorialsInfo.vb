Imports System
Imports System.Reflection
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Tutorials
Imports DevExpress.XtraEditors

Namespace XtraPrintingDemos
    Public Class PrintingAppearanceMenu
        Inherits DevExpress.DXperience.Demos.LookAndFeelMenu

        Public Sub New(ByVal manager As BarManager, ByVal lookAndFeel As DefaultLookAndFeel, ByVal about As String, ByVal showHelpMenu As Boolean)
            MyBase.New(manager, lookAndFeel, about)
            miHelp.Visibility = If(showHelpMenu, BarItemVisibility.Always, BarItemVisibility.Never)
        End Sub
        Protected Overrides ReadOnly Property ProductName() As String
            Get
                Return "XtraPrinting"
            End Get
        End Property
        Protected Overrides Sub biProductWebPage_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            System.Diagnostics.Process.Start("http://www.devexpress.com/Products/NET/WinForms/XtraPrinting/")
        End Sub
        Protected Overrides Sub miAboutProduct_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            DevExpress.XtraPrinting.PrintingSystem.About()
        End Sub
    End Class
    Public Class TutorialsInfo
        Inherits ModulesInfo

        Private Const languageDir As String = "CS\"

        Public Shared Sub CloseCustomizationForm(ByVal control As Control)
            If control Is Nothing Then
                Return
            End If
            For Each obj As Object In control.Controls
                Dim ribbonControl As RibbonControl = TryCast(obj, RibbonControl)
                If ribbonControl Is Nothing Then
                    Continue For
                End If
                ribbonControl.Visible = False
                ribbonControl.Visible = True
            Next obj
        End Sub

        Public Shared Function ShowModuleEx(ByVal name As String, ByVal groupControl As DevExpress.XtraEditors.GroupControl, ByVal menu As LookAndFeelMenu, ByVal lookAndFeel As DefaultLookAndFeel) As DevExpress.Tutorials.ModuleBase
            Dim item As DevExpress.DXperience.Demos.ModuleInfo = TutorialsInfo.GetItem(name)
            Dim currentCursor As Cursor = Cursor.Current
            Cursor.Current = Cursors.WaitCursor
            groupControl.Parent.SuspendLayout()
            groupControl.SuspendLayout()
            Try
                Dim oldTutorial As Control = Nothing
                If Instance.CurrentModuleBase IsNot Nothing Then
                    oldTutorial = Instance.CurrentModuleBase.TModule
                End If
                Instance.CurrentModuleBase = item
                Dim tutorialBase As XtraUserControl = TryCast(item.TModule, XtraUserControl)
                If tutorialBase IsNot Nothing Then
                    tutorialBase.Bounds = groupControl.DisplayRectangle
                    tutorialBase.Visible = False
                    groupControl.Controls.Add(tutorialBase)
                    tutorialBase.Dock = DockStyle.Fill

                    Dim tutorial As TutorialModuleControl = TryCast(item.TModule, TutorialModuleControl)
                    If tutorial IsNot Nothing Then
                        tutorial.Activate()
                    End If

                    CloseCustomizationForm(oldTutorial)
                    menu.InitLookAndFeelMenu(lookAndFeel)

                    tutorialBase.Visible = True
                End If
                If oldTutorial IsNot Nothing Then
                    oldTutorial.Visible = False
                End If
            Finally
                groupControl.ResumeLayout(True)
                groupControl.Parent.ResumeLayout(True)
                Cursor.Current = currentCursor
            End Try
            RaiseModuleChanged()
            Dim [module] As ModuleBase = TryCast(Instance.CurrentModuleBase.TModule, ModuleBase)
            If [module] IsNot Nothing Then
                [module].TutorialInfo.Description = Instance.CurrentModuleBase.Description
                [module].TutorialInfo.TutorialName = Instance.CurrentModuleBase.Name
                [module].TutorialInfo.WhatsThisCodeFile = Instance.CurrentModuleBase.CodeFile
                [module].TutorialInfo.WhatsThisXMLFile = Instance.CurrentModuleBase.XMLFile
                Dim xmlFile As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, [module].TutorialInfo.WhatsThisXMLFile, False)
                Dim codeFile As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, [module].TutorialInfo.WhatsThisCodeFile, False)
                If xmlFile = "" Then
                    [module].TutorialInfo.WhatsThisXMLFile = DemoHelper.StringComposite([module].TutorialInfo.WhatsThisXMLFile, languageDir)
                End If
                If codeFile = "" Then
                    [module].TutorialInfo.WhatsThisCodeFile = DemoHelper.StringComposite([module].TutorialInfo.WhatsThisCodeFile, languageDir)
                End If
            End If
            Return [module]
        End Function
    End Class
End Namespace

