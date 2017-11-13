Imports DevExpress.Diagram.Core
Imports System.Linq
Imports System.Text.RegularExpressions
Imports DevExpress.Utils
Imports System.Collections
Imports System.Globalization
Imports DevExpress.Diagram.Demos
Imports DevExpress.Xpf.Diagram

Namespace DiagramDemo
    Partial Public Class OfficePlanModule
        Inherits DiagramDemoModule

        Public ReadOnly OfficeStencil As New DiagramStencil("OfficeShapes", "Office Shapes")

        Public Sub New()
            InitializeComponent()
            InitializeOfficeStencil()
            diagramControl.Stencils = New DiagramStencilCollection( { OfficeStencil }.Concat(DiagramToolboxRegistrator.Stencils))
            diagramControl.LoadDemoData("OfficePlan.xml")
        End Sub
        Private Sub InitializeOfficeStencil()
            Const directoryPath As String = "images/officeplan"
            Dim assembly = Me.GetType().Assembly
            Dim filePaths = AssemblyHelper.GetResources(assembly).OfType(Of DictionaryEntry)().Select(Function(x) CStr(x.Key)).Where(Function(x) x.StartsWith(directoryPath))
            For Each filePath In filePaths.OrderBy(Function(x) x)
                Dim evaluator As New MatchEvaluator(Function(match) match.Groups(2).Value)
                Dim fileName As String = Regex.Replace(filePath.Replace("%20", " "), String.Format("({0}/)([A-z0-9 ]*)(.svg)", directoryPath), evaluator)
                Dim shapeId As String = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(fileName)
                Dim stream = DiagramDemoFileHelper.GetResourceStream(filePath)
                Dim sd = ShapeDescription.CreateSvgShape(shapeId, shapeId, stream, False)
                OfficeStencil.RegisterShape(sd)
            Next filePath
        End Sub
        Private Sub diagramControl_ItemInitializing(ByVal sender As Object, ByVal e As DevExpress.Xpf.Diagram.DiagramItemInitializingEventArgs)
            Dim shape = TryCast(e.Item, DiagramShape)
            If shape IsNot Nothing AndAlso OfficeStencil.ContainsShape(shape.Shape) Then
                shape.CanEdit = False
            End If
        End Sub
    End Class
End Namespace
