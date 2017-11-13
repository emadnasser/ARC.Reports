Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for FilesDir.
    ''' </summary>
    Partial Public Class FilesDir
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\FilesDir.vb;VB\GridMainDemo\Modules\Directories.vb"
            TutorialInfo.WhatsThisXMLFile = "FilesDir.xml"
            SetWaitDialogCaption(My.Resources.ReadingFolders)
            InitData()
            CreateFormatConditions()
            InitAppearance()
            Me.gridControl1.LevelTree.Nodes(1).RelationName = My.Resources.Files
            Me.gridControl1.LevelTree.Nodes(0).RelationName = My.Resources.Directories
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Protected Overrides ReadOnly Property PaintViews() As PaintView()
            Get
                Return New PaintView() {New PaintView(gridView1, "Pastel#3"), New PaintView(gridView2, "Pastel#3"), New PaintView(cardView1, "Orange")}
            End Get
        End Property
#Region "Init"
        Private Sub InitData()
            AddDirectoriesColumns(gridView1)
            AddDirectoriesColumns(gridView2)
            AddFilesColumns(cardView1)

            '<gridControl1>
            Dim directories As New Directories(New System.IO.DirectoryInfo(Application.StartupPath).Root.Name)
            gridControl1.DataSource = directories
            '</gridControl1>
            If gridView1.Columns.Count = 0 Then
                gridControl1.MainView.PopulateColumns()
            End If
        End Sub
        Private Sub InitAppearance()
            gridControl1.ForceInitialize()
            gridView1.BestFitColumns()
        End Sub
        Protected Overrides Sub OnSetCaption(ByVal caption As String)
            MyBase.OnSetCaption("")
            GridRibbonMenuManager.RefreshOptionsMenu(gridControl1.DefaultView)
        End Sub
#End Region
#Region "Create"
        Private Sub AddDirectoriesColumns(ByVal cv As DevExpress.XtraGrid.Views.Base.ColumnView)
            CreateGridColumn(cv, My.Resources.Name, "Name", 0)
            CreateGridColumn(cv, My.Resources.FullName, "FullName", 1)
            CreateGridColumn(cv, My.Resources.CreationTime, "CreationTime", 2)
            CreateGridColumn(cv, My.Resources.Attributes, "Attributes", 3)
            CreateGridColumn(cv, My.Resources.ChildDirCount, "ChildDirCount", 4)
            CreateGridColumn(cv, My.Resources.FilesCount, "FilesCount", 5)
        End Sub

        Private Sub AddFilesColumns(ByVal cv As DevExpress.XtraGrid.Views.Base.ColumnView)
            CreateGridColumn(cv, My.Resources.FileName, "Name", 0)
            CreateGridColumn(cv, My.Resources.Length, "Length", 1)
            CreateGridColumn(cv, My.Resources.CreationTime, "CreationTime", 2)
            CreateGridColumn(cv, My.Resources.LastWriteTime, "LastWriteTime", 3)
            CreateGridColumn(cv, My.Resources.LastAccessTime, "LastAccessTime", 4)
            CreateGridColumn(cv, My.Resources.FileAttributes, "Attributes", 5)
        End Sub

        Private Function CreateGridColumn(ByVal cv As DevExpress.XtraGrid.Views.Base.ColumnView, ByVal caption As String, ByVal field As String, ByVal visibleindex As Integer) As DevExpress.XtraGrid.Columns.GridColumn
            Dim gc As DevExpress.XtraGrid.Columns.GridColumn = cv.Columns.Add()
            gc.Caption = caption
            gc.FieldName = field
            gc.VisibleIndex = visibleindex
            gc.OptionsColumn.AllowEdit = False
            If gc.VisibleIndex = 0 Then
                gc.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            End If
            If field.IndexOf("Time") > 0 Then
                gc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                gc.DisplayFormat.FormatString = "g"
            End If
            Return gc
        End Function
        Private Sub CreateFormatConditions()
            Dim appDef1 As New AppearanceDefault(Color.OrangeRed, Color.Empty, New Font(AppearanceObject.DefaultFont, FontStyle.Bold Or FontStyle.Italic))
            Dim appDef2 As New AppearanceDefault(Color.White, Color.CornflowerBlue, Color.Empty, Color.SteelBlue, New Font(AppearanceObject.DefaultFont, FontStyle.Bold))
            Dim sfcFilesCount1 As New StyleFormatCondition(FormatConditionEnum.NotEqual, Nothing, appDef1, 0, 0, gridView1.Columns("FilesCount"), False)
            Dim sfcFilesCount2 As New StyleFormatCondition(FormatConditionEnum.NotEqual, Nothing, appDef1, 0, 0, gridView2.Columns("FilesCount"), False)
            Dim sfcDirCount1 As New StyleFormatCondition(FormatConditionEnum.NotEqual, Nothing, appDef2, 0, 0, gridView1.Columns("ChildDirCount"), False)
            Dim sfcDirCount2 As New StyleFormatCondition(FormatConditionEnum.NotEqual, Nothing, appDef2, 0, 0, gridView2.Columns("ChildDirCount"), False)
            gridView1.FormatConditions.AddRange(New StyleFormatCondition() {sfcFilesCount1, sfcDirCount1})
            gridView2.FormatConditions.AddRange(New StyleFormatCondition() {sfcFilesCount2, sfcDirCount2})
        End Sub
#End Region
#Region "Grid events"
        Private Sub gridControl1_DefaultViewChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridControl1.DefaultViewChanged
            If TypeOf gridControl1.DefaultView Is DevExpress.XtraGrid.Views.Grid.GridView Then
                CType(gridControl1.DefaultView, DevExpress.XtraGrid.Views.Grid.GridView).BestFitColumns()
            End If
            gridControl1.FocusedView = gridControl1.DefaultView
            If GridRibbonMenuManager IsNot Nothing Then
                GridRibbonMenuManager.RefreshOptionsMenu(gridControl1.DefaultView)
            End If
        End Sub
        Private Sub gridControl1_ViewRegistered(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.ViewOperationEventArgs) Handles gridControl1.ViewRegistered
            gridControl1.FocusedView = e.View
        End Sub

        '<gridControl1>
        '        
        '~Use either CardView or GridView to display child records:
        '         
        Private Sub gridView2_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles gridView2.MasterRowGetLevelDefaultView
            If e.RelationIndex > 0 Then
                e.DefaultView = cardView1
            Else
                e.DefaultView = gridView2
            End If
        End Sub
        '</gridControl1>

#End Region
    End Class
End Namespace
