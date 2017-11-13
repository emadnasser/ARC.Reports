Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for RTFView.
    ''' </summary>
    Partial Public Class RTFView
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\RTFView.vb"
            TutorialInfo.WhatsThisXMLFile = "RTFView.xml"
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
        Public Overrides ReadOnly Property ExportView() As BaseView
            Get
                If xtraTabControl1.SelectedTabPageIndex = 0 Then
                    Return gridView1
                Else
                    Return Nothing
                End If
            End Get
        End Property
        Private Sub RTFView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            gridControl1.DataSource = ProductInfoCreator.CreateData()
            gridControl2.DataSource = ProductInfoCreator.CreateData()
            InitGrid()
            '<gridControl1>
            '            
            '~ Note: the following property is set at design time and listed here only for demonstration purposes.   
            '~ Assign a RichTextEdit in-place editor to the Notes column via the ColumnEdit property:
            '~                
            '~Dim repositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit = New XtraEditors.Repository.RepositoryItemRichTextEdit()
            '~colNotes.ColumnEdit = repositoryItemRichTextEdit1
            '            
            '</gridControl1>
        End Sub
        Protected Overrides Sub DoShow()
            MyBase.DoShow()
            xtraTabControl1.SelectedTabPageIndex = CInt(IIf(TutorialName.IndexOf("Preview") <> -1, 1, 0))
        End Sub
        Private Sub InitGrid()
            gridView1.FocusedColumn = colNotes
            seCustomHeight.Value = repositoryItemRichTextEdit1.CustomHeight
            seHIndent.Value = repositoryItemRichTextEdit1.HorizontalIndent
            seVIndent.Value = repositoryItemRichTextEdit1.VerticalIndent
            gridView2.ExpandAllGroups()
            gridView2.OptionsBehavior.AllowGroupExpandAnimation = Utils.DefaultBoolean.False
            repositoryItemRichTextEdit1.BestFitWidth = 400
        End Sub
        '<gridControl2>
        Private Sub gridView2_CustomDrawRowPreview(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView2.CustomDrawRowPreview
            Using vi As New RichTextEditViewInfo(repositoryItemRichTextEdit2)
                Dim info As ProductInfo = TryCast(gridView2.GetRow(e.RowHandle), ProductInfo)
                vi.LoadText(info.Notes)
                vi.UpdatePaintAppearance()
                vi.CalcViewInfo(e.Graphics, System.Windows.Forms.MouseButtons.None, New Point(0, 0), e.Bounds)
                DevExpress.XtraEditors.Drawing.RichTextEditPainter.DrawRTF(vi, e.Cache)
            End Using
            e.Handled = True
        End Sub
        '</gridControl2>
        Private Sub gridView2_MeasurePreviewHeight(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles gridView2.MeasurePreviewHeight
            Using vi As New RichTextEditViewInfo(repositoryItemRichTextEdit2)
                Dim info As ProductInfo = TryCast(gridView2.GetRow(e.RowHandle), ProductInfo)
                vi.LoadText(info.Notes)
                e.RowHeight = vi.CalcHeight(CType(gridView2.GetViewInfo(), GridViewInfo).CalcRowPreviewWidth(e.RowHandle) - 1) + 2
            End Using
        End Sub
        '<seCustomHeight>
        Private Sub seCustomHeight_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seCustomHeight.EditValueChanged
            repositoryItemRichTextEdit1.CustomHeight = CInt(Fix(seCustomHeight.Value))
        End Sub
        '</seCustomHeight>

        '<seHIndent>
        Private Sub seHIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seHIndent.EditValueChanged
            repositoryItemRichTextEdit1.HorizontalIndent = CInt(Fix(seHIndent.Value))
        End Sub
        '</seHIndent>

        '<seVIndent>
        Private Sub seVIndent_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles seVIndent.EditValueChanged
            repositoryItemRichTextEdit1.VerticalIndent = CInt(Fix(seVIndent.Value))
        End Sub
        '</seVIndent>

        Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
            RibbonMenuManager.AllowExport(ExportView)
        End Sub
    End Class
End Namespace
