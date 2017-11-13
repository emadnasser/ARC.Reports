Imports System.Collections.Generic
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors.Designer.Utils
Imports DevExpress.XtraNavBar

Namespace DevExpress.ApplicationUI.Demos
    Partial Public Class IDEWorkspaces
        Inherits TutorialControlBase

        Private fileStreams As List(Of Stream)
        Public Sub New()
            InitializeComponent()
            FillNavBar()
            InitPropertyGrid()
            AddPerformanceReport()
            LoadWorkspaces()
            AddHandler tabbedView1.QueryControl, AddressOf tabbedView1_QueryControl
        End Sub
        Private Sub LoadWorkspaces()
            workspaceManager1.LoadWorkspace("Default Workspace", Program.GetStream("Workspace 1.xml"))
            workspaceManager1.LoadWorkspace("Perfomance Analyze", Program.GetStream("Workspace 2.xml"))
            workspaceManager1.LoadWorkspace("Compare Documents", Program.GetStream("Workspace 3.xml"))
        End Sub
        Private Sub AddPerformanceReport()
            Me.fileStreams = Program.CreateResourceStreams()
            Dim document = tabbedView1.AddDocument(New ucPerfomanceGrid())
            document.Caption = "Analyzed Report"
        End Sub
        Private Sub InitPropertyGrid()
            Dim propertyGrid As New DXPropertyGridEx()
            dockPanel3_Container.Controls.Add(propertyGrid)
            propertyGrid.Dock = DockStyle.Fill
            propertyGrid.SelectedObject = workspaceManager1
        End Sub
        Private fileIndex As Integer = 0
        Private Sub tabbedView1_QueryControl(ByVal sender As Object, ByVal e As XtraBars.Docking2010.Views.QueryControlEventArgs)
            Dim control = New ucCodeEditor()
            control.LoadCode(fileStreams(fileIndex Mod 3))
            fileIndex += 1
            e.Control = control
        End Sub
        Private Sub FillNavBar()
            Dim standardGroup As NavBarGroup = navBarControl1.Groups.Add()
            standardGroup.Caption = "Standard"
            standardGroup.Name = "standardGroup"
            Dim devexpressGroup As NavBarGroup = navBarControl1.Groups.Add()
            devexpressGroup.Caption = "DevExpress"
            devexpressGroup.Name = "devexpressGroup"
            devexpressGroup.Expanded = True
            For Each key As String In toolboxImages.Images.Keys
                Dim item As New NavBarItem()
                item.Caption = GetCaption(key)
                item.Name = item.Caption
                item.SmallImageIndex = toolboxImages.Images.IndexOfKey(key)
                navBarControl1.Items.Add(item)
                If Not key.Contains("DX") Then
                    standardGroup.ItemLinks.Add(item)
                Else
                    devexpressGroup.ItemLinks.Add(item)
                End If
            Next key
        End Sub
        Private Function GetCaption(ByVal key As String) As String
            Return key.Substring(0, key.IndexOf("_"c))
        End Function
    End Class
End Namespace
