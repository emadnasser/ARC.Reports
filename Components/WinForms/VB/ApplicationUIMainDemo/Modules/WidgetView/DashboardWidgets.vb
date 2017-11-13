Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraBars.Docking2010.Views.Widget

Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class DashboardWidgets
        Inherits TutorialControlBase

        Private WidgetColors() As Color = {Color.FromArgb(&HFFADB4), Color.FromArgb(&HFFF3B6), Color.FromArgb(&HE6C6E4), Color.FromArgb(&HFFDBBD), Color.FromArgb(&HBDE6FF), Color.FromArgb(&HCCF5C2)}
        Private random As New Random()
        Public Sub New()
            InitializeComponent()
            widgetView1.AllowDocumentStateChangeAnimation = DevExpress.Utils.DefaultBoolean.True
            AutoMergeRibbon = True
            AddHandler widgetView1.QueryControl, AddressOf OnQueryControl
            SetWidgetsAppearances()
            For Each item As Document In widgetView1.Documents
                item.Width = CInt(Math.Round(item.Width * Skins.DpiProvider.Default.DpiScaleFactor))
                item.Height = CInt(Math.Round(item.Height * Skins.DpiProvider.Default.DpiScaleFactor))
            Next
            ApplyLayoutMode(widgetView1.LayoutMode)
        End Sub
        Private Sub OnQueryControl(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.QueryControlEventArgs)
            If Not String.IsNullOrEmpty(e.Document.ControlTypeName) Then
                e.Control = TryCast(Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)), Control)
            Else
                e.Control = New Control()
            End If
        End Sub
        Private Sub OnLayoutModeCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biTableMode.ItemClick, biStackedMode.ItemClick, biFreeMode.ItemClick, biFlowMode.ItemClick
            Dim layoutMode As LayoutMode = CType(e.Item.Tag, LayoutMode)
            ApplyLayoutMode(layoutMode)
        End Sub
        Private Sub ApplyLayoutMode(ByVal layoutMode As LayoutMode)
            widgetView1.BeginUpdateAnimation()
            widgetView1.LayoutMode = layoutMode
            Select Case layoutMode
                Case LayoutMode.FlowLayout
                    InitFlowLayout()
                Case LayoutMode.FreeLayout
                    InitFreeLayout()
                Case Else
                    pgMixAction.Visible = True
                    biItemMixer.Visibility = XtraBars.BarItemVisibility.Always
                    biDragMode.Visibility = XtraBars.BarItemVisibility.OnlyInCustomizing
                    pgFlowDirection.Visible = False
            End Select
            widgetView1.EndUpdateAnimation()
        End Sub
        Private Sub InitFlowLayout()
            pgMixAction.Visible = True
            biItemMixer.Visibility = XtraBars.BarItemVisibility.Always
            biDragMode.Visibility = XtraBars.BarItemVisibility.OnlyInCustomizing
            pgFlowDirection.Visible = True
        End Sub
        Private Sub InitFreeLayout()
            pgFlowDirection.Visible = False
            biItemMixer.Visibility = XtraBars.BarItemVisibility.OnlyInCustomizing
            biDragMode.Visibility = XtraBars.BarItemVisibility.Always
        End Sub
        Private Sub OnFlowDirectionCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biTopDown.ItemClick, biRightToLeft.ItemClick, biLeftToRight.ItemClick, biBottomUp.ItemClick
            widgetView1.BeginUpdateAnimation()
            Dim flowDirection As FlowDirection = CType(e.Item.Tag, FlowDirection)
            widgetView1.FlowLayoutProperties.FlowDirection = flowDirection
            widgetView1.EndUpdateAnimation()
        End Sub
        Private Sub OnMixButtonClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biItemMixer.ItemClick
            Select Case widgetView1.LayoutMode
                Case LayoutMode.FlowLayout
                    FlowLayoutMix()
                Case LayoutMode.StackLayout
                    StackLayoutMix()
                Case LayoutMode.TableLayout
                    TableLayoutMix()
            End Select
        End Sub
        Private Sub StackLayoutMix()
            Dim randomIndex As Integer = 0
            Try
                widgetView1.BeginUpdateAnimation()
                For Each document As Document In widgetView1.Documents
                    Dim oldGroup As StackGroup = document.Parent
                    If oldGroup IsNot Nothing Then
                        oldGroup.Items.Remove(document)
                    End If
                    randomIndex = random.Next(widgetView1.StackGroups.Count)
                    widgetView1.StackGroups(randomIndex).Items.Add(document)
                Next document
            Finally
                widgetView1.EndUpdateAnimation()
            End Try
        End Sub
        Private Sub TableLayoutMix()
            Try
                widgetView1.BeginUpdateAnimation()
                Dim points As New List(Of Point)()
                For i As Integer = 0 To 2
                    For j As Integer = 0 To 2
                        points.Add(New Point(i, j))
                    Next j
                Next i
                For Each document As Document In widgetView1.Documents
                    Dim newLocation As Point = points(random.Next(points.Count))
                    document.RowIndex = newLocation.Y
                    document.ColumnIndex = newLocation.X
                    points.Remove(newLocation)
                Next document
            Finally
                widgetView1.EndUpdateAnimation()
            End Try
        End Sub
        Private Sub FlowLayoutMix()
            Dim index As Integer = 0
            Dim document As New Document()
            Try
                widgetView1.BeginUpdateAnimation()
                Dim i As Integer = 0
                Do While i < widgetView1.FlowLayoutProperties.FlowLayoutItems.Count
                    index = random.Next(widgetView1.Documents.Count)
                    If i = index Then
                        i += 1
                        Continue Do
                    End If
                    document = widgetView1.FlowLayoutProperties.FlowLayoutItems(i)
                    widgetView1.FlowLayoutProperties.FlowLayoutItems.Remove(document)
                    widgetView1.FlowLayoutProperties.FlowLayoutItems.Insert(index, document)
                    i += 1
                Loop
            Finally
                widgetView1.EndUpdateAnimation()
            End Try
        End Sub
        Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles BarCheckItem1.CheckedChanged
            If (TryCast(e.Item, XtraBars.BarCheckItem)).Checked Then
                SetWidgetsAppearances()
            Else
                ResetWidgetAppearances()
            End If
        End Sub
        Private Sub SetWidgetsAppearances()
            Dim documents As New List(Of BaseDocument)()
            documents.AddRange(widgetView1.Documents.ToArray())
            documents.AddRange(widgetView1.FloatDocuments.ToArray())
            For i As Integer = 0 To documents.Count - 1
                Dim document As Document = TryCast(documents(i), Document)
                document.AppearanceActiveCaption.BackColor = WidgetColors(i Mod WidgetColors.Length)
                document.AppearanceCaption.BackColor = WidgetColors(i Mod WidgetColors.Length)
            Next i
        End Sub
        Private Sub ResetWidgetAppearances()
            Dim documents As New List(Of BaseDocument)()
            documents.AddRange(widgetView1.FloatDocuments.ToArray())
            documents.AddRange(widgetView1.Documents.ToArray())
            For Each document As Document In documents
                document.AppearanceActiveCaption.Reset()
                document.AppearanceCaption.Reset()
            Next document
        End Sub
        Private Sub ToggleFreeLayoutDragMode(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles biDragMode.ItemClick
            If biDragMode.Down Then
                widgetView1.FreeLayoutProperties.ItemDragStyle = ItemDragStyle.DockingHints
            Else
                widgetView1.FreeLayoutProperties.ItemDragStyle = ItemDragStyle.Default
            End If
        End Sub
    End Class
End Namespace
