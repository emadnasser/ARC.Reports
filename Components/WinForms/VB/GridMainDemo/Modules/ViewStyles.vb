Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Card
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraGrid.Demos
    ''' <summary>
    ''' Summary description for ViewStyles.
    ''' </summary>
    Partial Public Class ViewStyles
        Inherits TutorialControl

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\ViewStyles.vb"
            TutorialInfo.WhatsThisXMLFile = "ViewStyles.xml"
            gridControl1.ForceInitialize()
            InitVehiclesData()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
        #Region "Init"

        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            VehiclesData.InitMDBData(connectionString, gridControl1)
            VehiclesData.InitColumnViewEditors(advBandedGridView1)
            VehiclesData.InitColumnViewEditors(bandedGridView1)
            VehiclesData.InitColumnViewEditors(gridView1)
            VehiclesData.InitColumnViewEditors(cardView1)
        End Sub
        #End Region
        #Region "Change view"
        Public Overrides ReadOnly Property ExportView() As BaseView
            Get
                Return gridControl1.MainView
            End Get
        End Property
        '<chGrid>
        '<chBanded>
        '<chCard>
        '<chAdvBanded>
        Private Sub ChangeView(ByVal viewType As String)
            chAdvBanded.Checked = False
            chBanded.Checked = chAdvBanded.Checked
            chCard.Checked = chBanded.Checked
            chGrid.Checked = chCard.Checked
            Select Case viewType
                Case "GridView"
                    chGrid.Checked = True
                    gridControl1.MainView = gridView1
                Case "CardView"
                    chCard.Checked = True
                    gridControl1.MainView = cardView1
                Case "Banded GridView"
                    chBanded.Checked = True
                    gridControl1.MainView = bandedGridView1
                    bandedGridView1.ExpandAllGroups()
                Case "Advanced Banded GridView"
                    chAdvBanded.Checked = True
                    gridControl1.MainView = advBandedGridView1
            End Select
            '<skip>
            OnSetCaption(viewType)
            '</skip>
        End Sub
        '</chGrid>
        '</chBanded>
        '</chCard>
        '</chAdvBanded>
        Protected Overrides Sub OnSetCaption(ByVal fCaption As String)
            If fCaption = String.Empty Then
                fCaption = GetCheckedCaption()
            End If
            If Caption IsNot Nothing Then
                Caption.Text = String.Format("{0} ({1})", TutorialName, fCaption)
            End If
            GridRibbonMenuManager.RefreshOptionsMenu(gridControl1.MainView)
        End Sub
        Private Function GetCheckedCaption() As String
            For Each ctrl As Control In panelControl1.Controls
                Dim button As CheckButton = TryCast(ctrl, CheckButton)
                If button IsNot Nothing AndAlso button.Checked Then
                    Return button.Tag.ToString()
                End If
            Next ctrl
            Return String.Empty
        End Function
        #End Region
        #Region "GridView events"
        Private Sub gridView1_DragObjectOver(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.DragObjectOverEventArgs) Handles gridView1.DragObjectOver
            If TypeOf e.DragObject Is GridColumn Then
                Dim cpi As DevExpress.XtraGrid.Dragging.ColumnPositionInfo = TryCast(e.DropInfo, DevExpress.XtraGrid.Dragging.ColumnPositionInfo)
                If e.DropInfo.Index = 0 AndAlso (Not cpi.InGroupPanel) Then
                    e.DropInfo.Valid = False
                End If
            End If
        End Sub
        #End Region

        Private updateInfo As Boolean = False
        '<chGrid>
        '<chBanded>
        '<chCard>
        '<chAdvBanded>
        Private Sub ch_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chAdvBanded.CheckedChanged, chBanded.CheckedChanged, chCard.CheckedChanged, chGrid.CheckedChanged
            If updateInfo Then
                Return
            End If
            OnButtonChecked(TryCast(sender, CheckButton))
        End Sub

        Private Sub OnButtonChecked(ByVal button As CheckButton)
            If button.Tag Is Nothing Then
                Return
            End If
            updateInfo = True
            Dim caption As String = button.Tag.ToString()
            ChangeView(caption)
            updateInfo = False
        End Sub
        '</chGrid>
        '</chBanded>
        '</chCard>
        '</chAdvBanded>
        #Region "CardView events"
        Private Sub cardView1_CustomCardCaptionImage(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Card.CardCaptionImageEventArgs) Handles cardView1.CustomCardCaptionImage
            Dim model As VehiclesData.Model = TryCast(cardView1.GetRow(e.RowHandle), VehiclesData.Model)

            e.Image = model.GetSmallTrademarkImage()

        End Sub

        Private Sub cardView1_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles cardView1.ValidatingEditor
            If cardView1.FocusedColumn.FieldName = "Trademark" Then
                Me.BeginInvoke(New MethodInvoker(Sub() cardView1.LayoutChanged()))
            End If
        End Sub
        #End Region
    End Class
End Namespace
