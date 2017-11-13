Imports System
Imports System.Data
Imports System.Linq
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.Diagram.Demos
Imports DevExpress.XtraBars.Ribbon
Imports System.Drawing
Imports DevExpress.XtraTreeList

Namespace DevExpress.XtraDiagram.Demos
    Partial Public Class OrgChartModule
        Inherits DiagramTutorialControlBase


        Private selectedTemplate_Renamed As OrgChartTemplateInfo
        Public Property SelectedTemplate() As OrgChartTemplateInfo
            Get
                Return selectedTemplate_Renamed
            End Get
            Set(ByVal value As OrgChartTemplateInfo)
                If value IsNot selectedTemplate_Renamed Then
                    selectedTemplate_Renamed = value
                    diagramOrgChartController1.Refresh()
                End If
            End Set
        End Property
        Private privateTemplates As OrgChartTemplateInfo()
        Public Property Templates() As OrgChartTemplateInfo()
            Get
                Return privateTemplates
            End Get
            Private Set(ByVal value As OrgChartTemplateInfo())
                privateTemplates = value
            End Set
        End Property
        Protected Overrides ReadOnly Property Ribbon() As RibbonControl
            Get
                Return ribbonControl1
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler Diagram.SelectionChanged, AddressOf DiagramControlSelectionChanged
            Templates = GetOrgChartTemplates()
            SelectedTemplate = Templates.FirstOrDefault()

            InitTemplatesGallery()
            AddHandler diagramOrgChartController1.ItemsGenerated, Sub(_o, _e) FitToItems()
            AddHandler Load, Sub(_d, _e) FitToItems()

            employeeBindingSource.DataSource = EmployeesData.Employees
            treeListControl1.ExpandAll()
        End Sub

        Private Sub FitToItems()
            Dim items = diagramControl.Items.OfType(Of DiagramContainer)().GroupBy(Function(x) x.Y).OrderBy(Function(x) x.Key).Take(3).SelectMany(Function(x) x).ToArray()
            diagramControl.FitToItems(items)
        End Sub
        Private Sub GenerateOrgChartItem(ByVal sender As Object, ByVal e As DiagramGenerateItemEventArgs) Handles diagramOrgChartController1.GenerateItem
            If SelectedTemplate IsNot Nothing Then
                e.Item = e.CreateItemFromTemplate(SelectedTemplate.Name)
            End If
        End Sub
        #Region "Galleries"

        Private Sub InitTemplatesGallery()
            Dim group = New GalleryItemGroup()
            For Each template In Templates
                Dim item = New GalleryItem()
                item.Caption = template.Name
                item.Value = template
                item.Image = template.Image
                group.Items.Add(item)
            Next template
            ribbonGalleryBarItem1.Gallery.Groups.Add(group)
        End Sub
        Private Function GetOrgChartTemplates() As OrgChartTemplateInfo()
            Dim templateNames = diagramOrgChartController1.TemplateDiagram.Items.OfType(Of DiagramContainer)().Select(Function(x) x.TemplateName).ToArray()
            Dim templateImages = templateNames.Select(Function(x) String.Format("images/orgchart/{0}.png", x.Replace(" ", String.Empty).ToLower())).Select(Function(x) DiagramDemoFileHelper.GetImageResource(x))
            Return templateNames.Zip(templateImages, Function(name, image) New OrgChartTemplateInfo(name, image)).ToArray()
        End Function
        Private Sub TemplatesGalleryItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs) Handles ribbonGalleryBarItem1.GalleryItemClick
            SelectedTemplate = CType(e.Item.Value, OrgChartTemplateInfo)
        End Sub
        Private Sub TemplatesGalleryInitDropDownGallery(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs) Handles ribbonGalleryBarItem1.GalleryInitDropDownGallery
            e.PopupGallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside
        End Sub

        #End Region
        #Region "Selection"

        Private isSelectionLocked As Boolean = False

        Private Sub TreeListControlFocusedNodeChanged(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs) Handles treeListControl1.FocusedNodeChanged
            DoLockedSelectionAction(Sub()
                Dim selectedEmployee As Employee = TryCast(treeListControl1.GetDataRecordByNode(e.Node), Employee)
                Dim diagramItem As DiagramItem = Nothing
                If selectedEmployee IsNot Nothing Then
                    diagramItem = diagramControl.Items.FirstOrDefault(Function(x) x.DataContext Is selectedEmployee)
                End If
                If diagramItem IsNot Nothing Then
                    diagramControl.SelectItem(diagramItem)
                    diagramControl.BringItemsIntoView( { diagramItem })
                Else
                    diagramControl.ClearSelection()
                End If
            End Sub)
        End Sub
        Private Sub DiagramControlSelectionChanged(ByVal sender As Object, ByVal e As DiagramSelectionChangedEventArgs)
            DoLockedSelectionAction(Sub()
                Dim selectedEmployee As Employee = Nothing
                If diagramControl.PrimarySelection IsNot Nothing AndAlso TypeOf diagramControl.PrimarySelection.DataContext Is Employee Then
                    selectedEmployee = CType(diagramControl.PrimarySelection.DataContext, Employee)
                End If
                If selectedEmployee IsNot Nothing Then
                    treeListControl1.FocusedNode = treeListControl1.FindNodeByKeyID(selectedEmployee.Id)
                Else
                    treeListControl1.FocusedNode = Nothing
                End If
            End Sub)
        End Sub
        Private Sub DoLockedSelectionAction(ByVal action As Action)
            If isSelectionLocked Then
                Return
            End If
            isSelectionLocked = True
            action()
            isSelectionLocked = False
        End Sub

        #End Region
    End Class
    Public Class OrgChartTemplateInfo
        Private privateName As String
        Public Property Name() As String
            Get
                Return privateName
            End Get
            Private Set(ByVal value As String)
                privateName = value
            End Set
        End Property
        Private privateImage As Image
        Public Property Image() As Image
            Get
                Return privateImage
            End Get
            Private Set(ByVal value As Image)
                privateImage = value
            End Set
        End Property

        Public Sub New(ByVal name As String, ByVal image As Image)
            Me.Name = name
            Me.Image = image
        End Sub
    End Class
End Namespace
