Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.Widget
Imports DevExpress.XtraEditors

Namespace Examples
    <CodeExampleClass("WidgetView via code", "WidgetView.vb"), CodeExampleHighlightTokens("WidgetView", "StackGroup", "UserControl", "DocumentContent", "Document", "Orientation", "LengthUnitType", "DocumentManager", "XtraUserControl", "RowDefinition", "ColumnDefinition", "Color", "Pen", "SolidBrush", "StringFormat", "StringAlignment", "StringTrimming", "StringFormatFlags", "ControlStyles", "PaintEventArgs", "Panel")>
    Public NotInheritable Class WidgetLayout

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim documentManager As New DocumentManager()
            Dim documentManagerHost As New XtraUserControl()
            documentManagerHost.Parent = sampleHost
            documentManagerHost.Dock = DockStyle.Fill
            Return New Object() {documentManager, documentManagerHost}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            Dim documentManager As DocumentManager = documentManager.FromControl(sampleHost)
            If documentManager IsNot Nothing Then
                documentManager = Nothing
            End If
        End Sub
        <CodeExampleCase("Create WidgetView")>
        Public Shared Sub CreateWidgetView(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New StackGroup())
            view.AddDocument(New UserControl() With {.Text = "Document1"})
        End Sub
        <CodeExampleCase("Using maximized Control", New Type() {GetType(DocumentContent)})>
        Public Shared Sub UsingMaximizedControl(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New StackGroup())
            Dim document = TryCast(view.AddDocument(New DocumentContent() With {.Text = "Document1"}), Document)
            document.MaximizedControl = New DocumentContent() With {.Text = "Maximized control"}
            view.Controller.Maximize(document)
        End Sub
        <CodeExampleCase("Create Vertical StackLayout"), CodeExampleGroupName("Stack Layout")>
        Public Shared Sub CreateVerticalStackGroup(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New StackGroup())
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)
            Dim group1 As New StackGroup()
            view.StackGroups.Add(group1)
            view.Controller.Dock(document2, group1)
        End Sub
        <CodeExampleCase("Create Horizontal StackLayout"), CodeExampleGroupName("Stack Layout")>
        Public Shared Sub CreateHorizontalStackGroup(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New StackGroup())
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)

            view.Orientation = Orientation.Horizontal

            Dim group1 As New StackGroup()
            view.StackGroups.Add(group1)
            view.Controller.Dock(document2, group1)
        End Sub
        <CodeExampleCase("Dragging StackGroup"), CodeExampleGroupName("Stack Layout")>
        Public Shared Sub DraggingStackGroup(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WidgetView()
            view.AllowStartupAnimation = DevExpress.Utils.DefaultBoolean.False
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New StackGroup() With {.Caption = "StackGroup1"})
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)
            Dim group1 As New StackGroup() With {.Caption = "StackGroup2"}
            view.StackGroups.Add(group1)
            view.Controller.Dock(document2, group1)

            view.BeginUpdateAnimation()
            view.StackGroups.Remove(group1)
            view.StackGroups.Insert(0, group1)
            view.EndUpdateAnimation()
        End Sub
        <CodeExampleCase("Resize Document in StackLayout"), CodeExampleGroupName("Stack Layout")>
        Public Shared Sub ResizeDocumentInStackLayout(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New StackGroup())
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)
            document1.Height = 300
            Dim group1 As New StackGroup()
            view.StackGroups.Add(group1)
            view.Controller.Dock(document2, group1)
        End Sub
        <CodeExampleCase("Resize StackGroup"), CodeExampleGroupName("Stack Layout")>
        Public Shared Sub ResizeStackGroup(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            view.StackGroups.Add(New StackGroup())
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)
            Dim group1 As New StackGroup()
            group1.Length.UnitType = LengthUnitType.Pixel
            group1.Length.UnitValue = 200
            view.StackGroups.Add(group1)
            view.Controller.Dock(document2, group1)
        End Sub
        <CodeExampleCase("Create TableLayout", New Type() {GetType(DefaultWidgetViewCreator)}), CodeExampleGroupName("Table Layout")>
        Public Shared Sub CreateTableLayout(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view = DefaultWidgetViewCreator.Create(documentManager, ownerControl)
            view.LayoutMode = LayoutMode.FlowLayout
            Dim document = TryCast(view.Documents(1), Document)
            view.LayoutMode = LayoutMode.TableLayout
            view.Rows.Add(New RowDefinition())
            view.Rows.Add(New RowDefinition())
            view.Columns.Add(New ColumnDefinition())
            view.Columns.Add(New ColumnDefinition())
            document.RowIndex = 1
            document.ColumnIndex = 1
        End Sub
        <CodeExampleCase("Resize Document", New Type() {GetType(DefaultWidgetViewCreator)}), CodeExampleGroupName("Table Layout")>
        Public Shared Sub ResizeDocumentInTableLayout(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view = DefaultWidgetViewCreator.Create(documentManager, ownerControl)
            view.LayoutMode = LayoutMode.FlowLayout
            Dim document = TryCast(view.Documents(1), Document)
            view.LayoutMode = LayoutMode.TableLayout
            view.Rows.Add(New RowDefinition())
            view.Rows.Add(New RowDefinition())
            view.Columns.Add(New ColumnDefinition())
            view.Columns.Add(New ColumnDefinition())
            document.RowIndex = 1
            document.ColumnIndex = 0
            document.ColumnSpan = 2
        End Sub
        <CodeExampleCase("Resize TableLayout"), CodeExampleGroupName("Table Layout")>
        Public Shared Sub ResizeTableLayout(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)
            document2.RowIndex = 0
            document2.ColumnIndex = 1
            view.LayoutMode = LayoutMode.TableLayout
            view.Rows.Add(New RowDefinition())
            view.Rows.Add(New RowDefinition())
            view.Columns.Add(New ColumnDefinition())
            view.Columns.Add(New ColumnDefinition())
            Dim column = view.Columns(1)
            column.Length.UnitType = LengthUnitType.Pixel
            column.Length.UnitValue = 150
        End Sub
        <CodeExampleCase("Create FlowLayout"), CodeExampleGroupName("Flow Layout")>
        Public Shared Sub CreateFlowLayout(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)
            view.LayoutMode = LayoutMode.FlowLayout
        End Sub
        <CodeExampleCase("Change FlowDirection", New Type() {GetType(DefaultWidgetViewCreator)}), CodeExampleGroupName("Flow Layout")>
        Public Shared Sub ChangeFlowDirection(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view = DefaultWidgetViewCreator.Create(documentManager, ownerControl)
            view.LayoutMode = LayoutMode.FlowLayout
            view.FlowLayoutProperties.FlowDirection = FlowDirection.RightToLeft
        End Sub
        <CodeExampleCase("Resize Document", New Type() {GetType(DefaultWidgetViewCreator)}), CodeExampleGroupName("Flow Layout")>
        Public Shared Sub ResizeDocumentInFlowLayout(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view = DefaultWidgetViewCreator.Create(documentManager, ownerControl)
            view.LayoutMode = LayoutMode.FlowLayout
            Dim document = TryCast(view.Documents(0), Document)
            document.Width = 180
            document.Height = 180
        End Sub
        <CodeExampleCase("Create FreeLayout"), CodeExampleGroupName("Free Layout")>
        Public Shared Sub CreateFreeLayout(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim view As New WidgetView()
            documentManager.View = view
            documentManager.ViewCollection.Add(view)
            documentManager.ContainerControl = ownerControl
            Dim document1 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document1"}), Document)
            Dim document2 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document2"}), Document)
            Dim document3 = TryCast(view.AddDocument(New UserControl() With {.Text = "Document3"}), Document)
            view.LayoutMode = LayoutMode.FreeLayout
            view.Orientation = Orientation.Horizontal
            document3.DockTo(document2, Orientation.Vertical)
        End Sub
        <CodeExampleCase("Create Document with fixed Length", New Type() {GetType(DefaultWidgetViewCreator)}), CodeExampleGroupName("Free Layout")>
        Public Shared Sub CreateDocumentWithFixedLength(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim documentsCount As Integer = 3
            Dim view As WidgetView = DefaultWidgetViewCreator.Create(documentManager, ownerControl, documentsCount)
            view.LayoutMode = LayoutMode.FreeLayout
            view.Orientation = Orientation.Horizontal
            Dim document2 As Document = TryCast(view.Documents(1), Document)
            view.BeginUpdate()
            document2.FreeLayoutWidth.UnitType = LengthUnitType.Pixel
            document2.FreeLayoutWidth.UnitValue = 150
            view.EndUpdate()
        End Sub
        <CodeExampleCase("Resize Document", New Type() {GetType(DefaultWidgetViewCreator)}), CodeExampleGroupName("Free Layout")>
        Public Shared Sub ResizeDocumentInFreeLayout(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl)
            Dim documentsCount As Integer = 3
            Dim view As WidgetView = DefaultWidgetViewCreator.Create(documentManager, ownerControl, documentsCount)
            view.LayoutMode = LayoutMode.FreeLayout
            view.Orientation = Orientation.Horizontal
            Dim document1 As Document = TryCast(view.Documents(0), Document)
            Dim document2 As Document = TryCast(view.Documents(1), Document)
            Dim delta As Double = 0.2R
            document1.FreeLayoutWidth.UnitValue += delta
            document2.FreeLayoutWidth.UnitValue -= delta
        End Sub
        <CodeExampleNestedClass>
        Public NotInheritable Class DefaultWidgetViewCreator

            Private Sub New()
            End Sub

            Public Shared Function Create(ByVal documentManager As DocumentManager, ByVal ownerControl As XtraUserControl, Optional ByVal documentCount As Integer = 2) As WidgetView
                Dim view As New WidgetView()
                documentManager.View = view
                documentManager.ViewCollection.Add(view)
                documentManager.ContainerControl = ownerControl
                For i As Integer = 0 To documentCount - 1
                    view.AddDocument(New UserControl() With {.Text = "Document" & (i + 1)})
                Next i
                Return view
            End Function
        End Class
        <CodeExampleNestedClass>
        Public Class DocumentContent
            Inherits Panel

            Private Shared currentColor As Integer
            Private Shared forecolors() As Color = {Color.Red, Color.Blue, Color.Green}
            Private sb As SolidBrush
            Private pen As Pen
            Private sf As StringFormat
            Private Shared newFont As New Font("Segoe UI", 24.0F)
            Public Sub New()
                sf = New StringFormat() With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center, .Trimming = StringTrimming.EllipsisCharacter, .FormatFlags = StringFormatFlags.NoWrap}
                DoubleBuffered = True
                ForeColor = forecolors((currentColor) Mod forecolors.Length)
                currentColor += 1
                SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint, True)
                SetStyle(ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer, True)
            End Sub
            Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
                If sb Is Nothing Then
                    sb = New SolidBrush(Color.FromArgb(100, ForeColor))
                End If
                If pen Is Nothing Then
                    pen = New Pen(Color.FromArgb(200, 221, 223, 223))
                End If
                e.Graphics.FillRectangle(sb, ClientRectangle)
                e.Graphics.DrawString(Text, newFont, sb, ClientRectangle, sf)
            End Sub
        End Class
    End Class
End Namespace
