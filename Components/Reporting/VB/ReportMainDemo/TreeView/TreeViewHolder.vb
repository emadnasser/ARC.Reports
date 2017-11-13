Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.Native
Imports DevExpress.DemoData.Models

Namespace XtraReportsDemos.TreeView
    Partial Public Class TreeViewHolder
        Inherits UserControl

        Private regionsHierarchy As IList(Of Hierarchy)
        Public Sub New()
            InitializeComponent()

            imageList1.Images.Clear()
            Dim bmp As Image = My.Resources.continent
            imageList1.ImageSize = bmp.Size
            imageList1.Images.AddStrip(bmp)

            Me.treeView1.TreeLevelWidth = bmp.Size.Width
            Using entities As New CountriesEntities(DevExpress.DemoReports.Properties.Settings.Default.countriesDBConnectionString)
                regionsHierarchy = entities.Hierarchy.ToList()
            End Using

            PopulateTreeView()
        End Sub
        Private Shared Function LoadImage(ByVal name As String) As Image
            Dim bmp As Bitmap = CType(DevExpress.Utils.ResourceImageHelper.CreateImageFromResourcesEx("XtraReportsDemos." & name, System.Reflection.Assembly.GetExecutingAssembly()), Bitmap)
            bmp.MakeTransparent(Color.Magenta)
            Return bmp
        End Function
        Private Sub PopulateTreeView()
            treeView1.Nodes.Clear()
            Dim regions As New Dictionary(Of String, TreeListNode)()
            Dim subRegions As New Dictionary(Of String, TreeListNode)()

            Dim nodeRegion As TreeListNode = Nothing
            Dim nodeSubRegion As TreeListNode = Nothing

            For Each hierarchy As Hierarchy In regionsHierarchy
                If Not regions.TryGetValue(hierarchy.Region, nodeRegion) Then
                    nodeRegion = CreateTreeNode(hierarchy.Region, 0, Nothing)
                    regions.Add(hierarchy.Region, nodeRegion)
                End If
                If Not subRegions.TryGetValue(hierarchy.SubRegion, nodeSubRegion) Then
                    nodeSubRegion = CreateTreeNode(hierarchy.SubRegion, 0, nodeRegion)
                    subRegions.Add(hierarchy.SubRegion, nodeSubRegion)
                End If
                Dim imageIndex As Integer = 0
                Try
                    Dim img As System.Drawing.Image = DevExpress.XtraPrinting.Native.PSConvert.ImageFromArray(hierarchy.BFlag)
                    If img IsNot Nothing Then
                        imageList1.Images.Add(img)
                    End If
                    imageIndex = imageList1.Images.Count - 1
                Catch
                End Try
                Dim countryName As String = hierarchy.OfficialName
                If countryName.Length > 60 Then
                    countryName = countryName.Substring(0, 60) & "..."
                End If
                Dim node As TreeListNode = CreateTreeNode(countryName, imageIndex, nodeSubRegion)
            Next hierarchy
        End Sub
        Private Function CreateTreeNode(ByVal text As String, ByVal imageIndex As Integer, ByVal parentNode As TreeListNode) As TreeListNode
            Dim node As TreeListNode = treeView1.AppendNode(New Object() { text }, parentNode)
            node.StateImageIndex = imageIndex
            Return node
        End Function
    End Class
End Namespace
