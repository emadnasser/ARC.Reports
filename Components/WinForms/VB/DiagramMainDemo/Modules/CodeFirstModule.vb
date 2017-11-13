Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.DXperience.Demos.CodeDemo
Imports System.Reflection
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraDiagram.Demos
    Public Class CodeFirstModule
        Inherits CodeTutorialControlBase

        Shared Sub New()
            Using TempDiagramControl As DiagramControl = New DiagramControl()
            End Using
        End Sub
        Protected Overrides ReadOnly Property CurrentExampleLanguage() As ExampleLanguage
            Get
                Return If(DemoHelper.GetLanguageString(GetType(CodeFirstModule).Assembly) = "CS", ExampleLanguage.Csharp, ExampleLanguage.VB)
            End Get
        End Property
    End Class
End Namespace
