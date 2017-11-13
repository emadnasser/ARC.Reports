Imports System.Collections
Imports System.ComponentModel
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class CardSizing
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\ModulesLayoutView\CardSizing.vb"
            TutorialInfo.WhatsThisXMLFile = "CardSizing.xml"
            InitData()
        End Sub

        Protected Overridable Sub InitData()
            Try
                Dim homesTable As DataTable = VideoCatalogDataSet().Tables("Homes")
                homesTable.Columns.Add("Image", GetType(Image))
                For Each Row As DataRow In homesTable.Rows
                    Dim img As Image = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(CType(Row("Photo"), Byte()))
                    Row("Image") = New Bitmap(img, New Size(351, 234)) ' resize to max used size
                Next
                gridControl1.DataSource = homesTable
            Catch
            End Try
            '<gridControl1>
            '
            '~Note: the following code is set at design-time and listed here for educational purposes only.
            '~
            '~layoutView1.OptionsView.ShowCardBorderIfCaptionHidden = False
            '~layoutView1.OptionsView.ShowCardCaption = False
            '~layoutView1.OptionsView.ShowCardLines = False
            '~layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            '~layoutView1.OptionsView.ShowHeaderPanel = False
            '~layoutViewTemplateCard.GroupBordersVisible = False
            ' 
            '</gridControl1>
        End Sub
        Private Function VideoCatalogDataSet() As DataSet
            Dim ds As New DataSet()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Homes.xml")
            If DBFileName <> String.Empty Then
                SetWaitDialogCaption(My.Resources.LoadingTables)
                ds.ReadXml(DBFileName)
            End If
            Return ds
        End Function
        Private originalCardMinSize As Size = Size.Empty
        '<zoomTrackBarControl1>
        Private Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles zoomTrackBarControl1.EditValueChanged
            If originalCardMinSize = Size.Empty Then
                originalCardMinSize = layoutView1.CardMinSize
            End If
            Dim koeff As Double = (CInt(Fix(zoomTrackBarControl1.EditValue))) / 100.0 - 0.2
            Dim newSize As New Size(originalCardMinSize.Width + CInt(Fix(originalCardMinSize.Width * koeff)), originalCardMinSize.Height + CInt(Fix(originalCardMinSize.Height * koeff)))
            layoutViewField_colPhoto.EditorPreferredWidth = newSize.Width - 10
            layoutView1.CardMinSize = newSize
        End Sub
        '</zoomTrackBarControl1>
    End Class
End Namespace
