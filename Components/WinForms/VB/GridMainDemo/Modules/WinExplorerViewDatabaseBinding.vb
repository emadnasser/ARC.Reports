Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.WinExplorer
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class WinExplorerViewDatabaseBinding
        Inherits TutorialControl

        Public Sub New()
            AutoMergeRibbon = True
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            InitVehiclesData()
            InitGrid()
        End Sub

        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            Dim tblModel As String = "Model", tblCategory As String = "Category", tblTrademark As String = "Trademark", tblBodyStyle As String = "BodyStyle", tblTransmissionType As String = "TransmissionType"
            Dim ds As New DataSet()

            FillTable(tblModel, String.Format("SELECT model.ID, model.Name, category.Name, trademark.Name, transmission.Name, bodyStyle.Name, model.InStock, model.Photo, model.Image, model.Description FROM {0} model, {1} category, {2} trademark, {3} transmission, {4} bodyStyle WHERE model.TrademarkID=trademark.ID AND model.CategoryID=category.ID AND model.[Transmission Type]=transmission.ID AND model.BodyStyleID=bodyStyle.ID AND model.Photo Is Not Null", tblModel, tblCategory, tblTrademark, tblTransmissionType, tblBodyStyle), connectionString, ds)

            SetGridDataSource(tblModel, ds, Me.gridControl1)
        End Sub

        Private Sub FillTable(ByVal table As String, ByVal query As String, ByVal connectionString As String, ByVal ds As DataSet)
            If query Is Nothing Then
                query = String.Format("SELECT * FROM {0}", table)
            End If
            Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter(query, connectionString)
            SetWaitDialogCaption(String.Format("Loading {0}...", table))
            oleDbDataAdapter.Fill(ds, table)
        End Sub

        Private Sub SetGridDataSource(ByVal table As String, ByVal ds As DataSet, ByVal grid As GridControl)
            Dim dvManager As New DataViewManager(ds)
            Dim dv As DataView = dvManager.CreateDataView(ds.Tables(table))
            grid.DataMember = Nothing
            grid.DataSource = dv
        End Sub

        Private Sub InitGrid()
            Me.winExplorerView1.Columns.Clear()
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "model.ID"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "model.Name"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Description"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Photo"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Image"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "InStock"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "category.Name"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "trademark.Name"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "transmission.Name"})
            Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "bodyStyle.Name"})

            Dim item As New RepositoryItemTextEdit()
            Me.winExplorerView1.Columns("model.Name").ColumnEdit = item
            Me.gridControl1.RepositoryItems.Add(item)

            Me.winExplorerView1.ColumnSet.TextColumn = Me.winExplorerView1.Columns("model.Name")
            Me.winExplorerView1.ColumnSet.DescriptionColumn = Me.winExplorerView1.Columns("Description")
            Me.winExplorerView1.ColumnSet.ExtraLargeImageColumn = Me.winExplorerView1.Columns("Photo")
            Me.winExplorerView1.ColumnSet.MediumImageColumn = Me.winExplorerView1.Columns("Image")
            Me.winExplorerView1.ColumnSet.CheckBoxColumn = Me.winExplorerView1.Columns("InStock")
            Me.winExplorerView1.ColumnSet.GroupColumn = Me.winExplorerView1.Columns("category.Name")
        End Sub

        Private Sub ribbonGalleryBarItem1_Gallery_ItemCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.Ribbon.GalleryItemEventArgs) Handles rgbiViewStyles.Gallery.ItemCheckedChanged
            If Not e.Item.Checked Then
                Return
            End If
            Select Case e.Item.Caption
                Case "Extra large icons"
                    Me.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.ExtraLarge
                Case "Large icons"
                    Me.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Large
                Case "Medium icons"
                    Me.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Medium
                Case "Small icons"
                    Me.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Small
                Case "List"
                    Me.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.List
                Case "Tiles"
                    Me.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Tiles
                Case "Content"
                    Me.winExplorerView1.OptionsView.Style = WinExplorerViewStyle.Content
            End Select
        End Sub

        Private Sub bcItemCheckBoxes_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bcItemCheckBoxes.CheckedChanged
            Me.winExplorerView1.OptionsView.ShowCheckBoxes = Me.bcItemCheckBoxes.Checked
        End Sub

        Private Sub bcGroupCaptionButton_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bcGroupCaptionButton.CheckedChanged
            Me.winExplorerView1.OptionsView.ShowExpandCollapseButtons = Me.bcGroupCaptionButton.Checked
        End Sub

        Private Sub bcGroupCheckBoxes_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bcGroupCheckBoxes.CheckedChanged, bcGroupCheckBoxes.CheckedChanged
            Me.winExplorerView1.OptionsView.ShowCheckBoxInGroupCaption = Me.bcGroupCheckBoxes.Checked
        End Sub

        Private Sub OnSortingCheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs) Handles bcAscending.CheckedChanged, bcDescending.CheckedChanged, bcSortNone.CheckedChanged
            If Not CType(e.Item, BarCheckItem).Checked Then
                Return
            End If
            If e.Item Is bcAscending Then
                Me.winExplorerView1.ColumnSet.GroupColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
                Me.winExplorerView1.ColumnSet.TextColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
            End If
            If e.Item Is bcDescending Then
                Me.winExplorerView1.ColumnSet.GroupColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
                Me.winExplorerView1.ColumnSet.TextColumn.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            End If
            If e.Item Is bcSortNone Then
                Me.winExplorerView1.ColumnSet.GroupColumn.SortOrder = DevExpress.Data.ColumnSortOrder.None
                Me.winExplorerView1.ColumnSet.TextColumn.SortOrder = DevExpress.Data.ColumnSortOrder.None
            End If
        End Sub

        Private Sub OnGroupByCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bcTrademark.CheckedChanged, bcCategory.CheckedChanged, bcTransmissionType.CheckedChanged, bcBodyStyle.CheckedChanged, bcGroupNone.CheckedChanged
            Me.winExplorerView1.GroupCount = If(e.Item Is Me.bcGroupNone, 0, 1)
            If e.Item Is Me.bcTrademark Then
                Me.winExplorerView1.ColumnSet.GroupColumn = Me.winExplorerView1.Columns("trademark.Name")
            ElseIf e.Item Is Me.bcTransmissionType Then
                Me.winExplorerView1.ColumnSet.GroupColumn = Me.winExplorerView1.Columns("transmission.Name")
            ElseIf e.Item Is Me.bcCategory Then
                Me.winExplorerView1.ColumnSet.GroupColumn = Me.winExplorerView1.Columns("category.Name")
            ElseIf e.Item Is Me.bcBodyStyle Then
                Me.winExplorerView1.ColumnSet.GroupColumn = Me.winExplorerView1.Columns("bodyStyle.Name")
            End If
        End Sub
        Private Sub OnAnimationTypeChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bcAnimationNone.CheckedChanged, bcExpandAnimation.CheckedChanged, bcPushAnimation.CheckedChanged, bcSegmentedAnimation.CheckedChanged, bcSlideAnimation.CheckedChanged
            If e.Item Is Me.bcAnimationNone Then
                Me.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.None
            ElseIf e.Item Is Me.bcExpandAnimation Then
                Me.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Expand
            ElseIf e.Item Is Me.bcPushAnimation Then
                Me.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Push
            ElseIf e.Item Is Me.bcSlideAnimation Then
                Me.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.Slide
            ElseIf e.Item Is Me.bcSegmentedAnimation Then
                Me.winExplorerView1.OptionsImageLoad.AnimationType = ImageContentAnimationType.SegmentedFade
            End If
        End Sub

        Private Sub barCheckItem1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barCheckItem1.ItemClick
            Me.winExplorerView1.OptionsImageLoad.RandomShow = barCheckItem1.Checked
        End Sub

    End Class
End Namespace
