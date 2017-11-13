Imports System
Imports DevExpress.Utils
Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos.CodeDemo
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.Utils.Menu
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.Utils.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils.Design
Imports DevExpress.XtraDiagram
Imports DevExpress.Diagram.Core
Imports System.Threading.Tasks
Imports DevExpress.XtraDiagram.ViewInfo
Imports System.IO
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraDiagram.Utils
Imports DevExpress.XtraDiagram.Designer

Namespace Examples
    <CodeExampleClass("Diagram properties", "SimpleClass.cs"), CodeExampleHighlightTokens("SizeF", "DiagramDesignerUtils", "DiagramDesignerForm", "FormWindowState", "DiagramDesignerUtils"), CodeExampleVersionID(161)>
    Public NotInheritable Class DiagramProperties

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim diagram As New DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = DockStyle.Fill
            diagram.OptionsView.PageSize = New SizeF(600, 400)
            diagram.FitToPage()

            Dim hostButton As New SimpleButton()
            Dim hostButton1 As New SimpleButton()
            Dim panel As New PanelControl()
            panel.Dock = DockStyle.Top
            hostButton.Parent = panel
            hostButton1.Parent = panel
            hostButton1.Width = CInt((80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            hostButton.Width = CInt((80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            panel.Height = CInt((30 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            hostButton.Dock = DockStyle.Left
            hostButton1.Dock = DockStyle.Left

            Dim diagramItem1 As New DiagramShape(BasicShapes.Rectangle, 200, 120, 50, 50)
            Dim diagramItem2 As New DiagramShape(BasicShapes.Rectangle, 270, 120, 50, 50)
            Dim diagramItem3 As New DiagramShape(BasicShapes.Rectangle, 200, 190, 50, 50)
            Dim diagramItem4 As New DiagramShape(BasicShapes.Rectangle, 270, 190, 50, 50)
            diagram.Items.AddRange(diagramItem1, diagramItem2, diagramItem3, diagramItem4)
            Return New Object() { diagram, panel, sampleHost }
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
        End Sub

        <CodeExampleCase("Page size")>
        Public Shared Sub PageSize(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            diagramControl.OptionsView.PageSize = New SizeF(550, 400)
            diagramControl.FitToPage()
        End Sub

        <CodeExampleCase("Grid size")>
        Public Shared Sub GridSize(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            diagramControl.OptionsView.GridSize = New SizeF(50, 50)
        End Sub

        <CodeExampleCase("Draw Grid and Rulers")>
        Public Shared Sub DrawGridAndRulers(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            diagramControl.OptionsView.ShowGrid = False
            diagramControl.OptionsView.ShowRulers = False
        End Sub

        <CodeExampleCase("Zooming")>
        Public Shared Sub Zooming(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            panel.Parent = diagramControl.Parent
            Dim button1 As SimpleButton = TryCast(panel.Controls(0), SimpleButton)
            Dim button2 As SimpleButton = TryCast(panel.Controls(1), SimpleButton)
            button1.Text = "Zoom In"
            button2.Text = "Zoom Out"

            AddHandler button1.Click, Sub(sender, e) diagramControl.OptionsView.ZoomFactor += 0.1F

            AddHandler button2.Click, Sub(sender, e) diagramControl.OptionsView.ZoomFactor -= 0.1F
        End Sub

        <CodeExampleUnderlineTokens("Clear"), CodeExampleCase("Clear diagram contents")>
        Public Shared Sub ClearDiagramContents(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            panel.Parent = diagramControl.Parent
            Dim button As SimpleButton = TryCast(panel.Controls(0), SimpleButton)
            button.Text = "Clear"
            AddHandler button.Click, Sub(sender, e) diagramControl.Items.Clear()
            panel.Controls(1).Dispose()
        End Sub

        <CodeExampleUnderlineTokens("RunDesigner"), CodeExampleCase("Design diagram")>
        Public Shared Sub DesignDiagram(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            panel.Parent = diagramControl.Parent
            Dim button As SimpleButton = TryCast(panel.Controls(0), SimpleButton)
            button.Text = "Design"
            AddHandler button.Click, Sub(sender, e)
                Dim designerForm = New DiagramDesignerForm() With {.ShowInTaskbar = False, .WindowState = FormWindowState.Maximized}
                DiagramDesignerUtils.RunDesigner(diagramControl, designerForm)
            End Sub
            panel.Controls(1).Dispose()
        End Sub

        <CodeExampleCase("Select items")>
        Public Shared Sub SelectItems(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            diagramControl.SelectItems(diagramControl.Items(0), diagramControl.Items(1), diagramControl.Items(2), diagramControl.Items(3))
        End Sub

        <CodeExampleUnderlineTokens("CopySelectedItems", "Paste"), CodeExampleCase("Copy and Paste")>
        Public Shared Sub CopyPaste(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            panel.Parent = diagramControl.Parent
            Dim button1 As SimpleButton = TryCast(panel.Controls(0), SimpleButton)
            Dim button2 As SimpleButton = TryCast(panel.Controls(1), SimpleButton)
            button1.Text = "Copy"
            button2.Text = "Paste"

            AddHandler button1.Click, Sub(sender, e) diagramControl.CopySelectedItems()

            AddHandler button2.Click, Sub(sender, e) diagramControl.Paste()
        End Sub
    End Class

    <CodeExampleVersionID(161), CodeExampleHighlightTokens("DiagramShape", "BasicShapes", "List", "ShapeDescription", "DiagramToolboxRegistrator", "Rectangle", "Timer", "BasicFlowchartShapes", "ArrowShapes", "DecorativeShapes, DiagramStencil"), CodeExampleClass("Create diagrams", "SimpleClass.cs")>
    Public NotInheritable Class CreateDiagrams

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim diagram As New DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = DockStyle.Fill
            diagram.OptionsView.PageSize = New SizeF(600, 400)
            diagram.FitToPage()

            Dim hostButton As New SimpleButton()
            Dim panel As New PanelControl()
            panel.Dock = DockStyle.Top
            hostButton.Parent = panel
            hostButton.Width = CInt((80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            panel.Height = CInt((30 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            hostButton.Dock = DockStyle.Left

            diagram.Appearance.Shape.ForeColor = Color.Black
            Return New Object() { diagram, panel, sampleHost }
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
        End Sub
        <CodeExampleCase("Add diagram item")>
        Public Shared Sub AddDiagramItem(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            Dim diagramItem As New DiagramShape(BasicShapes.Rectangle, 50, 10, 200, 100)
            diagramControl.Items.Add(diagramItem)
        End Sub


        <CodeExampleCase("Create various shapes")>
        Public Shared Sub CreateVariousShapes(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            diagramControl.Items.Add(New DiagramShape(BasicFlowchartShapes.Subprocess, New Rectangle(50, 50, 150, 100)))
            diagramControl.Items.Add(New DiagramShape(BasicShapes.Decagon, New Rectangle(250, 50, 150, 100)))
            diagramControl.Items.Add(New DiagramShape(ArrowShapes.CurvedLeftArrow, New Rectangle(50, 170, 150, 100)))
            diagramControl.Items.Add(New DiagramShape(DecorativeShapes.Cloud, New Rectangle(250, 170, 150, 100)))
        End Sub

        <CodeExampleCase("Show all shapes")>
        Public Shared Sub ShowVariousShapes(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            Dim descriptions As New List(Of ShapeDescription)()
            For Each a As DiagramStencil In DiagramToolboxRegistrator.Stencils
                descriptions.AddRange(a.Shapes.ToList())
            Next a
            Dim description As ShapeDescription = descriptions.First()

            Dim shape As New DiagramShape(BasicShapes.Rectangle, New Rectangle(200, 100, 200, 150))
            diagramControl.Items.Add(shape)

            Dim myTimer As New Timer()
            AddHandler myTimer.Tick, Sub(sender, e)
                If diagramControl.Page Is Nothing Then
                    myTimer.Stop()
                    Return
                End If
                shape.Shape = description
                shape.Content = description.Id
                Dim index As Integer = descriptions.IndexOf(description) + 1
                If index = descriptions.Count Then
                    index = 0
                End If
                description = descriptions(index)
            End Sub
            myTimer.Interval = 500
            myTimer.Start()
        End Sub

        <CodeExampleUnderlineTokens("DeleteSelectedItems"), CodeExampleCase("Delete selected items")>
        Public Shared Sub DeleteSelectedItems(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl, ByVal sampleHost As XtraUserControl)
            Dim diagramItem1 As New DiagramShape(BasicShapes.Rectangle, 50, 50, 50, 50)
            Dim diagramItem2 As New DiagramShape(BasicShapes.Rectangle, 50, 150, 50, 50)
            Dim diagramItem3 As New DiagramShape(BasicShapes.Rectangle, 150, 50, 50, 50)
            Dim diagramItem4 As New DiagramShape(BasicShapes.Rectangle, 150, 150, 50, 50)
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, diagramItem3, diagramItem4)

            panel.Parent = diagramControl.Parent
            Dim button As SimpleButton = TryCast(panel.Controls(0), SimpleButton)
            button.Text = "Delete"

            AddHandler button.Click, Sub(sender, e) diagramControl.DeleteSelectedItems()
        End Sub

    End Class

    <CodeExampleHighlightTokens("Size", "DiagramShape"), CodeExampleVersionID(161), CodeExampleClass("Customize diagram items", "SimpleClass.cs")>
    Public NotInheritable Class CustomizeDiagramItems

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim diagram As New DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = DockStyle.Fill
            diagram.OptionsView.PageSize = New SizeF(600, 400)
            diagram.FitToPage()

            Dim diagramItem As New DiagramShape(BasicShapes.Rectangle, 100, 100, 200, 100)
            diagram.Items.Add(diagramItem)
            Return New Object() { diagram }
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
        End Sub

        <CodeExampleCase("Resize diagram item")>
        Public Shared Sub ResizeDiagramItem(ByVal diagramControl As DiagramControl)
            diagramControl.Items(0).Size = New System.Drawing.Size(50, 100)
        End Sub

        <CodeExampleCase("Show text in diagram item")>
        Public Shared Sub ShowDiagramItemText(ByVal diagramControl As DiagramControl)
            TryCast(diagramControl.Items(0), DiagramShape).Content = "Text"
        End Sub

        <CodeExampleCase("Customize item properties")>
        Public Shared Sub CustomizeProperties(ByVal diagramControl As DiagramControl)
            diagramControl.Items(0).CanDelete = False
            diagramControl.Items(0).CanMove = False
            diagramControl.Items(0).CanCopy = False
            diagramControl.Items(0).CanRotate = False
        End Sub

        <CodeExampleCase("Rotate item")>
        Public Shared Sub RotateItem(ByVal diagramControl As DiagramControl)
            diagramControl.Items(0).Angle = 30
        End Sub
    End Class

    <CodeExampleClass("Diagram connectors", "SimpleClass.cs"), CodeExampleHighlightTokens("DiagramShape", "DiagramConnector", "Point", "ArrowDescriptions", "BasicShapes", "SizeF", "Timer", "Math"), CodeExampleVersionID(161)>
    Public NotInheritable Class DiagramConnectors

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim diagram As New DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = DockStyle.Fill
            diagram.OptionsView.PageSize = New SizeF(600, 400)
            diagram.FitToPage()

            Return New Object() { diagram }
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
        End Sub

        <CodeExampleCase("Create diagram connector")>
        Public Shared Sub CreateDiagramConnector(ByVal diagramControl As DiagramControl)
            Dim connector As New DiagramConnector(New Point(50, 50), New Point(200, 200), New Point(50, 200))
            connector.EndArrow = ArrowDescriptions.Filled90
            diagramControl.Items.Add(connector)
        End Sub

        <CodeExampleCase("Arrow Styles")>
        Public Shared Sub CustomizeArrowStyle(ByVal diagramControl As DiagramControl)
            Dim connector1 As New DiagramConnector(New Point(50, 50), New Point(300, 50))
            connector1.EndArrow = ArrowDescriptions.Diamond
            Dim connector2 As New DiagramConnector(New Point(50, 100), New Point(300, 100))
            connector2.EndArrow = ArrowDescriptions.Filled90
            Dim connector3 As New DiagramConnector(New Point(50, 150), New Point(300, 150))
            connector3.EndArrow = ArrowDescriptions.Open90
            Dim connector4 As New DiagramConnector(New Point(50, 200), New Point(300, 200))
            connector4.EndArrow = ArrowDescriptions.FilledFletch
            diagramControl.Items.AddRange(connector1, connector2, connector3, connector4)
            'Various styles:
            'ClosedASMEArrow, ClosedDiamond, ClosedDot, ClosedDoubleArrow, Diamond, Filled90, FilledDiamond, FilledDot, FilledDoubleArrow, FilledFletch
            'FilledSquare, IndentedFilledArrow, Open90, OpenFletch, OutdentedFilledArrow
        End Sub

        <CodeExampleCase("Show all arrow Styles")>
        Public Shared Sub ShowArrowStyles(ByVal diagramControl As DiagramControl)
            Dim diagramItem1 As New DiagramShape(BasicShapes.Rectangle, 100, 100, 100, 100)
            Dim diagramItem2 As New DiagramShape(BasicShapes.Rectangle, 400, 100, 100, 100)
            Dim connector1 As New DiagramConnector(diagramItem1, diagramItem2)
            connector1.EndArrowSize = New SizeF(20, 20)
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, connector1)

            Dim index As Integer = 0

            Dim myTimer As New Timer()
            AddHandler myTimer.Tick, Sub(sender, e)
                If diagramControl.Page Is Nothing Then
                    myTimer.Stop()
                    Return
                End If
                connector1.EndArrow = ArrowDescriptions.Arrows.ElementAt(index)
                connector1.Content = ArrowDescriptions.Arrows.ElementAt(index).Id
                index += 1
                If index = ArrowDescriptions.Arrows.Count() Then
                    index = 0
                End If
            End Sub
            myTimer.Interval = 700
            myTimer.Start()
        End Sub


        <CodeExampleCase("Resize arrow")>
        Public Shared Sub ChangeArrowSize(ByVal diagramControl As DiagramControl)
            Dim connector As New DiagramConnector(New Point(50, 50), New Point(200, 200), New Point(50, 200))
            connector.EndArrow = ArrowDescriptions.Filled90
            connector.EndArrowSize = New SizeF(30, 20)
            diagramControl.Items.Add(connector)
        End Sub

        <CodeExampleCase("Connect diagram items")>
        Public Shared Sub ConnectDiagramItems(ByVal diagramControl As DiagramControl)
            Dim diagramItem1 As New DiagramShape(BasicShapes.Rectangle, 10, 10, 200, 100)
            Dim diagramItem2 As New DiagramShape(BasicShapes.Rectangle, 10, 200, 200, 100)
            Dim connector1 As New DiagramConnector(diagramItem1, diagramItem2)
            connector1.EndArrow = ArrowDescriptions.Filled90
            Dim diagramItem3 As New DiagramShape(BasicShapes.Rectangle, 250, 10, 200, 100)
            Dim diagramItem4 As New DiagramShape(BasicShapes.Rectangle, 400, 200, 200, 100)
            Dim connector2 As New DiagramConnector(diagramItem3, diagramItem4, New Point(350, 250))
            connector2.EndArrow = ArrowDescriptions.Filled90
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, diagramItem3, diagramItem4, connector1, connector2)
        End Sub

        <CodeExampleCase("Connect two items")>
        Public Shared Sub ConnectTwoItems(ByVal diagramControl As DiagramControl)
            Dim a As Double = Math.PI / 2
            Dim rad = 100
            Dim diagramItem1 As New DiagramShape(BasicShapes.Rectangle, 200, 100, 50, 50)
            Dim diagramItem2 As New DiagramShape(BasicShapes.Rectangle, 200, 200, 50, 50)
            diagramControl.Items.AddRange(diagramItem1, diagramItem2, New DiagramConnector(diagramItem1, diagramItem2))

            Dim myTimer As New Timer()
            AddHandler myTimer.Tick, Sub(sender, e)
                If diagramControl.Page Is Nothing Then
                    myTimer.Stop()
                    Return
                End If
                a += Math.PI / 10
                diagramItem2.X = diagramItem1.X + CInt((rad * Math.Cos(a)))
                diagramItem2.Y = diagramItem1.Y + CInt((rad * Math.Sin(a)))
                myTimer.Enabled = True
                diagramControl.UpdateRoute()
            End Sub
            myTimer.Interval = 250
            myTimer.Start()
        End Sub

        <CodeExampleCase("Customize connector properties")>
        Public Shared Sub CustomizeConnectorProperties(ByVal diagramControl As DiagramControl)
            Dim connector As New DiagramConnector(New Point(50, 50), New Point(200, 200), New Point(50, 200))
            connector.EndArrow = ArrowDescriptions.Filled90
            connector.CanCopy = False
            connector.CanDelete = False
            diagramControl.Items.Add(connector)
        End Sub

        <CodeExampleCase("Show text in diagram connector")>
        Public Shared Sub ShowTextInDiagramConnector(ByVal diagramControl As DiagramControl)
            Dim connector As New DiagramConnector(New Point(50, 50), New Point(200, 200))
            connector.EndArrow = ArrowDescriptions.Filled90
            connector.Content = "Text"
            diagramControl.Items.Add(connector)
        End Sub
    End Class

    <CodeExampleClass("Undo and Redo Operations", "SimpleClass.cs"), CodeExampleVersionID(161)>
    Public NotInheritable Class UndoRedoInCode

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim diagram As New DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = DockStyle.Fill
            diagram.OptionsView.PageSize = New SizeF(600, 400)
            diagram.FitToPage()

            Dim hostButton As New SimpleButton()
            Dim hostButton1 As New SimpleButton()
            Dim panel As New PanelControl()
            panel.Dock = DockStyle.Top
            hostButton.Parent = panel
            hostButton1.Parent = panel
            hostButton1.Width = CInt((80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            hostButton.Width = CInt((80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            panel.Height = CInt((30 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            hostButton.Dock = DockStyle.Left
            hostButton1.Dock = DockStyle.Left
            panel.Parent = sampleHost

            Dim diagramItem1 As New DiagramShape(BasicShapes.Rectangle, 50, 50, 100, 100)
            Dim diagramItem2 As New DiagramShape(BasicShapes.Rectangle, 200, 50, 100, 100)
            Dim connector As New DiagramConnector(diagramItem1, diagramItem2)
            connector.EndArrow = ArrowDescriptions.Filled90
            diagram.Items.Add(connector)
            diagram.Items.Add(diagramItem1)
            diagram.Items.Add(diagramItem2)
            Return New Object() { diagram, panel}
        End Function

        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
        End Sub


        <CodeExampleUnderlineTokens("Undo", "Redo"), CodeExampleCase("Undo and Redo")>
        Public Shared Sub UndoAndRedo(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl)
            Dim button1 As SimpleButton = TryCast(panel.Controls(0), SimpleButton)
            Dim button2 As SimpleButton = TryCast(panel.Controls(1), SimpleButton)

            button1.Text = "Undo"
            button2.Text = "Redo"
            AddHandler button1.Click, Sub(sender, e) diagramControl.UndoManager.Undo()

            AddHandler button2.Click, Sub(sender, e) diagramControl.UndoManager.Redo()
        End Sub
    End Class

    <CodeExampleClass("Themes", "SimpleClass.cs"), CodeExampleHighlightTokens("DiagramThemes", "DiagramShapeStyleId", "ThemeRegistrator", "Timer", "DiagramConnectorStyleId", "DiagramShapeStyleId", "DiagramConnector", "DiagramShape"), CodeExampleVersionID(161)>
    Public NotInheritable Class Themes

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim diagram As New DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = DockStyle.Fill
            diagram.OptionsView.PageSize = New SizeF(600, 400)
            diagram.FitToPage()

            Dim diagramItem1 As New DiagramShape(BasicShapes.Rectangle, 100, 100, 100, 100)
            Dim diagramItem2 As New DiagramShape(BasicShapes.Rectangle, 350, 100, 100, 100)
            Dim diagramConnector1 As New DiagramConnector(diagramItem1, diagramItem2)
            diagramConnector1.EndArrow = ArrowDescriptions.Filled90
            diagram.Items.AddRange(diagramItem2, diagramConnector1, diagramItem1)
            Return New Object() { diagram }
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
        End Sub

        <CodeExampleCase("Diagram theme")>
        Public Shared Sub GlobalTheme(ByVal diagramControl As DiagramControl)
            diagramControl.OptionsView.Theme = DiagramThemes.NoTheme
            'DiagramThemes: Daybreak, Integral, Linear, Lines, Office, Parallel, Sequence
        End Sub

        <CodeExampleCase("Shape theme")>
        Public Shared Sub ShapeTheme(ByVal diagramControl As DiagramControl)
            diagramControl.OptionsView.Theme = DiagramThemes.Office
            diagramControl.Items(0).ThemeStyleId = DiagramShapeStyleId.Variant3
            diagramControl.Items(2).ThemeStyleId = DiagramShapeStyleId.Variant2
        End Sub

        <CodeExampleCase("Connector theme")>
        Public Shared Sub ConnectorTheme(ByVal diagramControl As DiagramControl)
            diagramControl.OptionsView.Theme = DiagramThemes.Linear
            diagramControl.Items(1).ThemeStyleId = DiagramConnectorStyleId.Intense2
        End Sub

        <CodeExampleCase("Show all diagram themes")>
        Public Shared Sub ShowVariousGlobalThemes(ByVal diagramControl As DiagramControl)
            Dim index As Integer = 0
            Dim myTimer As New Timer()
            AddHandler myTimer.Tick, Sub(sender, e)
                If diagramControl.Page Is Nothing Then
                    myTimer.Stop()
                    Return
                End If
                diagramControl.OptionsView.Theme = ThemeRegistrator.Themes.ElementAt(index)
                index += 1
                If index = ThemeRegistrator.Themes.Count() Then
                    index = 0
                End If
            End Sub
            myTimer.Interval = 700
            myTimer.Start()
        End Sub


        <CodeExampleCase("Show all item themes")>
        Public Shared Sub ShowConnectorAndShapeThemes(ByVal diagramControl As DiagramControl)
            Dim diagramShape1 As DiagramShape = TryCast(diagramControl.Items(0), DiagramShape)
            Dim diagramShape2 As DiagramShape = TryCast(diagramControl.Items(2), DiagramShape)
            Dim diagramConnector1 As DiagramConnector = TryCast(diagramControl.Items(1), DiagramConnector)

            Dim index1 As Integer = 0
            Dim index2 As Integer = 0

            Dim myTimer As New Timer()
            AddHandler myTimer.Tick, Sub(sender, e)
                If diagramControl.Page Is Nothing Then
                    myTimer.Stop()
                    Return
                End If
                Dim id() As String = DiagramShapeStyleId.Styles(index1).Id.Split("."c)
                diagramShape1.ThemeStyleId = DiagramShapeStyleId.Styles(index1)
                diagramShape1.Content = id(id.Count() - 1)
                diagramShape2.ThemeStyleId = DiagramShapeStyleId.Styles(index1)
                diagramShape2.Content = id(id.Count() - 1)
                diagramConnector1.ThemeStyleId = DiagramConnectorStyleId.Styles(index2)
                diagramConnector1.Content = DiagramConnectorStyleId.Styles(index2).Id.Split("."c)(1)
                index1 += 1
                index2 += 1
                If index1 = DiagramShapeStyleId.Styles.Count Then
                    index1 = 0
                End If
                If index2 = DiagramConnectorStyleId.Styles.Count Then
                    index2 = 0
                End If
            End Sub
            myTimer.Interval = 700
            myTimer.Start()
        End Sub
    End Class

    <CodeExampleVersionID(161), CodeExampleHighlightTokens("ArrowDescriptions", "DiagramShape", "DiagramConnector", "Color", "Font", "BasicShapes", "DiagramShape"), CodeExampleClass("Appearance", "SimpleClass.cs")>
    Public NotInheritable Class Appearance

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim diagram As New DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = DockStyle.Fill
            diagram.OptionsView.PageSize = New SizeF(600, 400)
            diagram.FitToPage()

            Return New Object() { diagram }
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
        End Sub

        <CodeExampleCase("Diagram appearance")>
        Public Shared Sub CustomizeDiagramAppearance(ByVal diagramControl As DiagramControl)
            Dim diagramItem1 As New DiagramShape(BasicShapes.Rectangle, 10, 10, 200, 100)
            diagramItem1.Content = "Text"
            diagramControl.Appearance.Shape.Font = New Font("Times New Roman", 40)
            diagramControl.Appearance.Shape.BackColor = Color.Yellow
            diagramControl.Appearance.Shape.ForeColor = Color.Red
            diagramControl.Appearance.Shape.BorderColor = Color.Orange
            diagramControl.Appearance.Shape.BorderSize = 5

            diagramControl.Items.Add(diagramItem1)
            diagramControl.Items.Add(New DiagramShape(BasicShapes.Rectangle, 10, 150, 200, 100))
        End Sub

        <CodeExampleCase("Change shape appearance")>
        Public Shared Sub ChangeShapeAppearance(ByVal diagramControl As DiagramControl)
            diagramControl.Appearance.Shape.Font = New Font("Times New Roman", 40)
            diagramControl.Appearance.Shape.ForeColor = Color.Yellow

            Dim diagramShape1 As New DiagramShape(BasicShapes.Rectangle, 10, 150, 200, 100)
            Dim diagramShape2 As New DiagramShape(BasicShapes.Rectangle, 250, 10, 200, 100)

            diagramShape1.Content = "Text1"
            diagramShape2.Content = "Text2"

            diagramShape1.Appearance.BackColor = Color.Green
            diagramShape1.Appearance.BorderColor = Color.Orange
            diagramShape2.Appearance.BorderColor = diagramShape1.Appearance.GetBackColor()
            diagramShape1.Appearance.BorderSize = 5
            diagramShape2.Appearance.BorderSize = 12
            diagramShape2.Appearance.Font = New Font("Times New Roman", 20)

            diagramControl.Items.AddRange(diagramShape1, diagramShape2)
        End Sub

        <CodeExampleCase("Change connector appearance")>
        Public Shared Sub ChangeConnectorAppearance(ByVal diagramControl As DiagramControl)
            diagramControl.Appearance.Connector.ForeColor = Color.Red
            diagramControl.Appearance.Connector.BackColor = Color.Green

            Dim diagramShape1 As New DiagramShape(BasicShapes.Rectangle, 50, 50, 50, 50)
            Dim diagramShape2 As New DiagramShape(BasicShapes.Rectangle, 50, 150, 50, 50)
            Dim diagramShape3 As New DiagramShape(BasicShapes.Rectangle, 300, 50, 50, 50)
            Dim diagramShape4 As New DiagramShape(BasicShapes.Rectangle, 300, 150, 50, 50)

            Dim connector1 As New DiagramConnector(diagramShape1, diagramShape3)
            connector1.Content = "Text1"
            connector1.Appearance.BackColor = Color.Orange
            connector1.Appearance.ForeColor = Color.Blue
            connector1.EndArrow = ArrowDescriptions.Open90

            Dim connector2 As New DiagramConnector(diagramShape2, diagramShape4)
            connector2.Content = "Text2"
            connector2.EndArrow = ArrowDescriptions.Open90

            diagramControl.Items.AddRange(diagramShape1, diagramShape2, diagramShape3, diagramShape4, connector1, connector2)
        End Sub
        <CodeExampleCase("Custom Item Drawing")>
        Public Shared Sub CustomDraw(ByVal diagramControl As DiagramControl)
            Dim shape As New DiagramShape(BasicShapes.Rectangle, 50, 50, 100, 75)
            shape.Content = "Rectangle with shadow"

            AddHandler diagramControl.CustomDrawItem, Sub(s, e)
                If e.Context = DiagramDrawingContext.Canvas OrElse e.Context = DiagramDrawingContext.DragPreview Then
                    Dim foreColor = e.Appearance.ForeColor
                    e.DefaultDraw(CustomDrawItemMode.Background)

                    Dim transform = e.Graphics.Transform.Clone()
                    transform.Translate(1, 1)
                    e.Graphics.Transform = transform
                    e.Appearance.ForeColor = Color.DarkGray
                    e.DefaultDraw(CustomDrawItemMode.Content)

                    transform.Translate(-1, -1)
                    e.Graphics.Transform = transform
                    e.Appearance.ForeColor = foreColor
                    e.DefaultDraw(CustomDrawItemMode.Content)

                    e.Handled = True
                End If
            End Sub

            diagramControl.Items.Add(shape)
            diagramControl.FitToItems( { shape })
        End Sub
    End Class

    <CodeExampleVersionID(161), CodeExampleHighlightTokens("SimpleButton", "SeekOrigin", "MemoryStream"), CodeExampleClass("Save and load documents", "SimpleClass.cs")>
    Public NotInheritable Class SaveLoadDocument

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim diagram As New DiagramControl()
            diagram.Parent = sampleHost
            diagram.Dock = DockStyle.Fill
            diagram.OptionsView.PageSize = New SizeF(600, 400)
            diagram.FitToPage()

            Dim hostButton As New SimpleButton()
            Dim hostButton1 As New SimpleButton()
            Dim panel As New PanelControl()
            panel.Dock = DockStyle.Top
            hostButton.Parent = panel
            hostButton1.Parent = panel
            hostButton1.Width = CInt((80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            hostButton.Width = CInt((80 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            panel.Height = CInt((30 * DevExpress.Skins.DpiProvider.Default.DpiScaleFactor))
            hostButton.Dock = DockStyle.Left
            hostButton1.Dock = DockStyle.Left
            panel.Parent = sampleHost

            Dim diagramItem1 As New DiagramShape(BasicShapes.Rectangle, 50, 50, 50, 50)
            Dim num = 1

            For i As Integer = 0 To 2
                For j As Integer = 0 To 2
                    diagramItem1.Content = String.Format("Item {0}", num)
                    num += 1
                    diagram.Items.Add(diagramItem1)
                    diagramItem1 = New DiagramShape(BasicShapes.Rectangle, diagramItem1.X + diagramItem1.Width + 20, diagramItem1.Y, 50, 50)
                Next j
                diagramItem1 = New DiagramShape(BasicShapes.Rectangle, 50, diagramItem1.Y + diagramItem1.Height + 20, 50, 50)
            Next i
            diagram.FitToDrawing()
            Return New Object() { diagram, panel}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            For Each control As Control In sampleHost.Controls
                control.Dispose()
            Next control
        End Sub

        <CodeExampleUnderlineTokens("SaveDocument", "LoadDocument"), CodeExampleCase("Save and restore diagram to/from stream")>
        Public Shared Sub SaveRestoreDiagramFromStream(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl)
            Dim button1 As SimpleButton = TryCast(panel.Controls(0), SimpleButton)
            Dim button2 As SimpleButton = TryCast(panel.Controls(1), SimpleButton)
            button1.Text = "Save"
            button2.Text = "Restore"
            Dim memoryStream As New MemoryStream()
            diagramControl.SaveDocument(memoryStream)
            AddHandler button1.Click, Sub(sender, e)
                memoryStream.Dispose()
                memoryStream = New MemoryStream()
                diagramControl.SaveDocument(memoryStream)
            End Sub
            AddHandler button2.Click, Sub(sender, e)
                memoryStream.Seek(0, SeekOrigin.Begin)
                diagramControl.LoadDocument(memoryStream)
            End Sub
        End Sub

        <CodeExampleUnderlineTokens("SaveFile", "OpenFile"), CodeExampleCase("Save and restore diagram to/from file")>
        Public Shared Sub SaveRestoreDiagramInFile(ByVal diagramControl As DiagramControl, ByVal panel As PanelControl)
            Dim button1 As SimpleButton = TryCast(panel.Controls(0), SimpleButton)
            Dim button2 As SimpleButton = TryCast(panel.Controls(1), SimpleButton)
            button1.Text = "Save File"
            button2.Text = "Load File"
            AddHandler button1.Click, Sub(sender, e) diagramControl.SaveFile()

            AddHandler button2.Click, Sub(sender, e) diagramControl.OpenFile()
        End Sub
    End Class
End Namespace
