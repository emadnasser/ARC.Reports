Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.DXperience.Demos

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class Layout3D
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\ModulesLayoutView\Layout3D.vb"
            TutorialInfo.WhatsThisXMLFile = "Layout3D.xml"
            InitData()
            gridControl1.ForceInitialize()
            '<gridControl1>
            Dim tmr As New Timer()
            AddHandler tmr.Tick, AddressOf tmr_Tick
            tmr.Start()
            '</gridControl1>
        End Sub
        '<gridControl1>
        Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
            layoutView1.MoveBy(layoutView1.RowCount \ 2 - 1)
            DirectCast(sender, Timer).Stop()
        End Sub
        '</gridControl1>
        Protected Overridable Sub InitData()
            Try
                gridControl1.DataSource = VideoCatalogDataSet().Tables("Movie")
            Catch
            End Try
        End Sub
        Private Function VideoCatalogDataSet() As DataSet
            Dim ds As New DataSet()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\VideoRent.xml")
            If DBFileName <> String.Empty Then
                SetWaitDialogCaption(My.Resources.LoadingTables)
                ds.ReadXml(DBFileName)
            End If
            Return ds
        End Function

        '<cardsCount>
        Private Sub cardsCount_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cardsCount.EditValueChanged
            If Not IsHandleCreated Then
                Return
            End If
            layoutView1.OptionsCarouselMode.CardCount = CInt((cardsCount.EditValue))
        End Sub
        '</cardsCount>
        '<flatFactor>
        Private Sub flatFactor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles flatFactor.EditValueChanged
            layoutView1.OptionsCarouselMode.PitchAngle = CSng((CInt((flatFactor.EditValue))) / 360.0F * 2 * Math.PI)
        End Sub
        '</flatFactor>
        '<rollAngle>
        Private Sub rollAngle_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rollAngle.EditValueChanged
            layoutView1.OptionsCarouselMode.RollAngle = CSng((CInt((rollAngle.EditValue))) / 360.0F * 2 * Math.PI)
        End Sub
        '</rollAngle>
        '<endSizeScale>
        Private Sub endSizeScale_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles endSizeScale.EditValueChanged
            layoutView1.OptionsCarouselMode.BottomCardScale = (CInt((endSizeScale.EditValue))) / 100.0F
        End Sub
        '</endSizeScale>
        '<endAlpha>
        Private Sub endAlpha_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles endAlpha.EditValueChanged
            layoutView1.OptionsCarouselMode.BottomCardAlphaLevel = (CInt((endAlpha.EditValue))) / 100.0F
        End Sub
        '</endAlpha>
        '<bottomCardFading>
        Private Sub zoomTrackBarControl1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles bottomCardFading.EditValueChanged
            layoutView1.OptionsCarouselMode.BottomCardFading = (CInt((bottomCardFading.EditValue))) / 100.0F
        End Sub
        '</bottomCardFading>
        Private Sub Layout3D_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            For Each modeName As InterpolationMode In System.Enum.GetValues(GetType(InterpolationMode))
                If modeName = InterpolationMode.Invalid Then
                    Continue For
                End If
                comboBoxEdit1.Properties.Items.Add(New ImageComboBoxItem(EnumTitlesKeeper(Of InterpolationMode).GetTitle(modeName), modeName, -1))
            Next modeName
            comboBoxEdit1.EditValue = InterpolationMode.Default
        End Sub
        '<comboBoxEdit1>
        Private Sub comboBoxEdit1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.SelectedIndexChanged
            layoutView1.OptionsCarouselMode.InterpolationMode = CType(comboBoxEdit1.EditValue, InterpolationMode)
        End Sub
        '</comboBoxEdit1>
    End Class
End Namespace
