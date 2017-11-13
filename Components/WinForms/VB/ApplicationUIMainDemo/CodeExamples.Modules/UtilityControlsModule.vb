Imports System
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Utils.Taskbar
Imports DevExpress.Utils.Taskbar.Core
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.DXperience.Demos.CodeDemo

Namespace DevExpress.ApplicationUI.Demos
    Public Class UtilityControlsModule
        Inherits CodeTutorialControlBase

        Public Sub New()
            MyBase.New()
        End Sub
        Protected Overrides ReadOnly Property UseSameTutorialControlNameForGenerateExample() As Boolean
            Get
                Return True
            End Get
        End Property
        Protected Overrides ReadOnly Property CurrentExampleLanguage As ExampleLanguage
            Get
                Return ExampleLanguage.VB
            End Get
        End Property
        'protected override string[] FileNamesForModule {
        '    get { return new string[] { "CommonConcepts.cs", "TabbedView.cs", "WindowsUIView.cs", "WidgetView.cs" }; }
        '}
    End Class
End Namespace
