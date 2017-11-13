Imports System.Collections
Imports System.ComponentModel

Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu


Namespace DevExpress.XtraTreeList.Demos
    Partial Public Class FixedColumns
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\TreeListMainDemo\Modules\FixedColumns.vb"
            TutorialInfo.WhatsThisXMLFile = "FixedColumns.xml"
            InitData()
            InitEditors()
            treeList1.ExpandAll()
            '<treeList1>
            '
            '~Note: the following property is set at design time and listed here only for demonstration purposes.
            '~Anchor a column to the TreeList's left edge:
            '~
            '~treeListColumn1.Fixed = FixedStyle.Left
            '
            '</treeList1>

        End Sub
        Private Sub InitEditors()
            ceAllowPixelScrolling.Checked = True
        End Sub
        Private Sub InitData()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\BioLife.xml")
            If DBFileName <> "" Then
                Dim dataSet As New DataSet()
                dataSet.ReadXml(DBFileName)
                treeList1.DataSource = dataSet.Tables(0).DefaultView
            End If
        End Sub
        '<treeList1>
        '        
        '~Create a menu with commands to anchor tree list columns:
        '         
        Private Sub treeList1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.PopupMenuShowingEventArgs) Handles treeList1.PopupMenuShowing
            Dim hitInfo As TreeListHitInfo = treeList1.CalcHitInfo(e.Point)
            If hitInfo.HitInfoType = HitInfoType.Column Then
                Dim menu As DevExpress.XtraTreeList.Menu.TreeListColumnMenu = TryCast(e.Menu, DevExpress.XtraTreeList.Menu.TreeListColumnMenu)
                menu.Items.Clear()
                If menu.Column IsNot Nothing Then
                    menu.Items.Add(CreateCheckItem("Not Fixed", menu.Column, FixedStyle.None, imageList1.Images(0)))
                    menu.Items.Add(CreateCheckItem("Fixed Left", menu.Column, FixedStyle.Left, imageList1.Images(1)))
                    menu.Items.Add(CreateCheckItem("Fixed Right", menu.Column, FixedStyle.Right, imageList1.Images(2)))
                End If
            End If
        End Sub
        Private Function CreateCheckItem(ByVal caption As String, ByVal column As TreeListColumn, ByVal style As FixedStyle, ByVal image As Image) As DXMenuCheckItem
            Dim item As New DXMenuCheckItem(caption, column.Fixed = style, image, New EventHandler(AddressOf OnFixedClick))
            item.Tag = New MenuInfo(column, style)
            Return item
        End Function
        Private Sub OnFixedClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As DXMenuItem = TryCast(sender, DXMenuItem)
            Dim info As MenuInfo = TryCast(item.Tag, MenuInfo)
            If info Is Nothing Then
                Return
            End If
            info.Column.Fixed = info.Style
        End Sub
        '</treeList1>

        '<spinEdit1>
        Private Sub spinEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles spinEdit1.EditValueChanged
            treeList1.FixedLineWidth = CInt(Fix(spinEdit1.Value))
        End Sub
        '</spinEdit1>

        Private Sub treeList1_CustomDrawNodeCell(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs) Handles treeList1.CustomDrawNodeCell
            If e.Column.Fixed <> FixedStyle.None AndAlso e.Node IsNot treeList1.FocusedNode Then
                e.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
                e.Appearance.BackColor = Color.DarkGray
                e.Appearance.ForeColor = Color.Black
            End If
        End Sub

        '<treeList1>
        Private Class MenuInfo
            Public Sub New(ByVal column As TreeListColumn, ByVal style As FixedStyle)
                Me.Column = column
                Me.Style = style
            End Sub
            Public Style As FixedStyle
            Public Column As TreeListColumn
        End Class
        '</treeList1>

        Private Sub ceAllowPixelScrolling_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ceAllowPixelScrolling.CheckedChanged
            If ceAllowPixelScrolling.Checked Then
                treeList1.OptionsBehavior.AllowPixelScrolling = DefaultBoolean.True
            Else
                treeList1.OptionsBehavior.AllowPixelScrolling = DefaultBoolean.False
            End If
        End Sub
    End Class
End Namespace
