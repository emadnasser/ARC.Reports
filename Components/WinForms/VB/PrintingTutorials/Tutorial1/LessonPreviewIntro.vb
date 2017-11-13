Imports System
Imports System.ComponentModel
Imports DevExpress.XtraPrinting
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.Tutorials
Imports DevExpress.DXperience.Demos

Namespace XtraPrintingDemos.Tutorial1
    Public Class LessonPreviewIntro
        Inherits ModuleBase

        Private components As Container
        Private featuresRtf As RichTextBox

        Public Sub New()
            InitializeComponent()
            Dim resourceStream As System.IO.Stream = System.Reflection.Assembly.GetAssembly(GetType(LessonPreviewIntro)).GetManifestResourceStream("PrintingTutorials.BaseForms.PrintingAbout.rtf")
            If resourceStream IsNot Nothing Then
                featuresRtf.LoadFile(resourceStream, RichTextBoxStreamType.RichText)
            End If
        End Sub
        Private Sub InitializeComponent()
            components = New Container()
            featuresRtf = New RichTextBox()
            featuresRtf.Name = "featuresRtf"
            featuresRtf.Dock = DockStyle.Fill

            Controls.Add(featuresRtf)
        End Sub
    End Class
End Namespace
