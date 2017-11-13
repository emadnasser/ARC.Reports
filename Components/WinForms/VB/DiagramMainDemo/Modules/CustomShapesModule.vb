Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraDiagram.Demos
Imports DevExpress.DXperience.Demos
Imports DevExpress.Diagram.Core
Imports System.Text.RegularExpressions
Imports DevExpress.Utils
Imports System.Collections
Imports System.Globalization

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class CustomShapesModule
        Inherits DiagramTutorialControl

        Public ReadOnly OfficeStencil As New DiagramStencil("OfficeShapes", "Office Shapes")

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            AddHandler diagramControl.ItemInitializing, AddressOf DiagramControlItemInitializing
            InitializeOfficeStencil()
            diagramControl.OptionsBehavior.Stencils = New DiagramStencilCollection( { OfficeStencil }.Concat(DiagramToolboxRegistrator.Stencils))
            LoadDocument("OfficePlan.xml")
        End Sub

        Private Sub InitializeOfficeStencil()
            Const directoryPath As String = "images/officeplan"
            Dim assembly = Me.GetType().Assembly
            Dim filePaths = AssemblyHelper.GetResources(assembly).OfType(Of DictionaryEntry)().Select(Function(x) CStr(x.Key)).Where(Function(x) x.StartsWith(directoryPath))

            For Each filePath In filePaths.OrderBy(Function(x) x)
                Dim evaluator As New MatchEvaluator(Function(match) match.Groups(2).Value)
                Dim fileName As String = Regex.Replace(filePath.Replace("%20", " "), String.Format("({0}/)([A-z0-9 ]*)(.svg)", directoryPath), evaluator)
                Dim shapeId As String = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(fileName)
                Dim stream = AssemblyHelper.GetResourceStream(assembly, filePath, True)
                Dim sd = DevExpress.Diagram.Core.ShapeDescription.CreateSvgShape(shapeId, shapeId, stream, False)
                OfficeStencil.RegisterShape(sd)
            Next filePath
        End Sub
        Private Sub DiagramControlItemInitializing(ByVal sender As Object, ByVal e As DiagramItemInitializingEventArgs)
            Dim shape = TryCast(e.Item, DiagramShape)
            If shape IsNot Nothing AndAlso OfficeStencil.ContainsShape(shape.Shape) Then
                shape.CanEdit = False
            End If
        End Sub
    End Class
End Namespace
