Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class CardViewControl
        Inherits DevExpress.XtraGrid.Demos.TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\GridMainDemo\Modules\CardViewControl.vb"
            TutorialInfo.WhatsThisXMLFile = "CardViewControl.xml"
            ' TODO: Add any initialization after the InitializeComponent call
        End Sub
        Private updateLayout As Boolean = False
        Private oldMaxColumn As Integer = -1
        Private oldMaxRows As Integer = -1
        #Region "Init"
        Public Overrides ReadOnly Property ExportView() As DevExpress.XtraGrid.Views.Base.BaseView
            Get
                Return cardView1
            End Get
        End Property
        Private Sub CardView_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitVehiclesData()
            InitEditors()
            cardView1_Layout(cardView1, EventArgs.Empty)
        End Sub

        Public Overrides ReadOnly Property ShowViewOptions() As Boolean
            Get
                Return True
            End Get
        End Property

        Protected Overrides Sub InitMDBData(ByVal connectionString As String)
            VehiclesData.InitMDBData(connectionString, gridControl1)
            VehiclesData.InitColumnViewEditors(cardView1)
        End Sub

        Private Sub InitEditors()
            icbFormat.EditValue = cardView1.CardCaptionFormat
            seMaxColumns.EditValue = cardView1.MaximumCardColumns
            seMaxRows.EditValue = cardView1.MaximumCardRows
            ceAutoHorzWidth.Checked = cardView1.OptionsBehavior.AutoHorzWidth
            ceMultiSelect.Checked = cardView1.OptionsSelection.MultiSelect
        End Sub
        #End Region
        #Region "Editing"

        Private Sub cardView1_Layout(ByVal sender As Object, ByVal e As System.EventArgs) Handles cardView1.Layout
            updateLayout = True
            ceCustomize.Checked = cardView1.OptionsView.ShowQuickCustomizeButton
            ceButtons.Checked = cardView1.OptionsView.ShowCardExpandButton
            updateLayout = False
        End Sub
        #End Region
        #Region "Customize"
        '<ceCustomize>
        Private Sub ceCustomize_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceCustomize.CheckedChanged
            '<skip>
            If updateLayout Then
                Return
            End If
            '</skip>
            cardView1.OptionsView.ShowQuickCustomizeButton = ceCustomize.Checked
            '<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(cardView1)
            '</skip>
        End Sub
        '</ceCustomize>
        '<ceSorting>
        Private Sub ceSorting_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceSorting.CheckedChanged
            For Each col As GridColumn In cardView1.Columns
                col.OptionsColumn.AllowSort = If(ceSorting.Checked, DevExpress.Utils.DefaultBoolean.Default, DevExpress.Utils.DefaultBoolean.False)
            Next col
        End Sub
        '</ceSorting>
        '<ceFiltering>
        Private Sub ceFiltering_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceFiltering.CheckedChanged
            For Each col As GridColumn In cardView1.Columns
                col.OptionsFilter.AllowFilter = ceFiltering.Checked
            Next col
        End Sub
        '</ceFiltering>
        #End Region
        #Region "Captions"
        '<ceImage>
        Private Sub cardView1_CustomCardCaptionImage(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Card.CardCaptionImageEventArgs) Handles cardView1.CustomCardCaptionImage
            If Not ceImage.Checked Then
                Return
            End If
            Dim model As VehiclesData.Model = TryCast(cardView1.GetRow(e.RowHandle), VehiclesData.Model)
            e.Image = model.GetSmallTrademarkImage()
        End Sub
        Private Sub cardView1_ValidatingEditor(ByVal sender As Object, ByVal e As BaseContainerValidateEditorEventArgs) Handles cardView1.ValidatingEditor
            If cardView1.FocusedColumn.FieldName = "Trademark" Then
                Me.BeginInvoke(New MethodInvoker(Sub() cardView1.LayoutChanged()))
            End If
        End Sub
        Private Sub ceImage_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceImage.CheckedChanged
            cardView1.LayoutChanged()
        End Sub
        '</ceImage>
        '<ceButtons>
        Private Sub ceButtons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceButtons.CheckedChanged
            '<skip>
            If updateLayout Then
                Return
            End If
            '</skip>
            cardView1.OptionsView.ShowCardExpandButton = ceButtons.Checked
            '<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(cardView1)
            '</skip>
        End Sub
        '</ceButtons>
        '<icbFormat>
        Private Sub icbFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbFormat.SelectedIndexChanged
            cardView1.CardCaptionFormat = icbFormat.EditValue.ToString()
        End Sub
        '</icbFormat>
        #End Region
        #Region "Layout"

        '<seMaxColumns>
        Private Sub seMaxColumns_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seMaxColumns.EditValueChanged
            Dim val As Integer = Convert.ToInt32(seMaxColumns.Value)
            If val = 0 Then
                val = If(val > oldMaxColumn, 1, -1)
                seMaxColumns.Value = val
            End If
            cardView1.MaximumCardColumns = val
            oldMaxColumn = val
        End Sub
        '</seMaxColumns>
        '<seMaxRows>
        Private Sub seMaxRows_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seMaxRows.EditValueChanged
            Dim val As Integer = Convert.ToInt32(seMaxRows.Value)
            If val = 0 Then
                val = If(val > oldMaxRows, 1, -1)
                seMaxRows.Value = val
            End If
            cardView1.MaximumCardRows = val
            oldMaxRows = val
        End Sub
        '</seMaxRows>
        '<ceAutoHorzWidth>
        Private Sub ceAutoHorzWidth_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceAutoHorzWidth.CheckedChanged
            cardView1.OptionsBehavior.AutoHorzWidth = ceAutoHorzWidth.Checked
        End Sub
        '</ceAutoHorzWidth>
        #End Region
        #Region "MultiSelect"
        '<ceMultiSelect>
        Private Sub ceMultiSelect_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ceMultiSelect.CheckedChanged
            cardView1.OptionsSelection.MultiSelect = ceMultiSelect.Checked
            If ceMultiSelect.Checked AndAlso cardView1.SelectedRowsCount < 2 Then
                cardView1.SelectRange(2, 9)
            End If
            '<skip>
            SetButtonEnabled()
            '</skip>
        End Sub
        '</ceMultiSelect>
        Private Sub navigationPane1_SelectedPageChanged(ByVal sender As Object, ByVal e As XtraBars.Navigation.SelectedPageChangedEventArgs) Handles navigationPane1.SelectedPageChanged
            ceMultiSelect.Checked = e.Page Is navigationPage4
        End Sub
        Private Sub SetButtonEnabled()
            sbRecords.Enabled = cardView1.SelectedRowsCount > 0 AndAlso ceMultiSelect.Checked
        End Sub

        Private Sub cardView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles cardView1.SelectionChanged
            SetButtonEnabled()
        End Sub
        '<sbRecords>
        Private Sub sbRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbRecords.Click
            DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectedRows(), My.Resources.SelectedRows)
        End Sub

        Private Function GetSelectedRows() As String
            Dim ret As String = ""
            For Each i As Integer In cardView1.GetSelectedRows()
                Dim model As VehiclesData.Model = TryCast(cardView1.GetRow(i), VehiclesData.Model)
                If ret <> "" Then
                    ret &= ControlChars.CrLf
                End If
                ret &= String.Format("{0} {1} : {2:$#,0.00}", model.TrademarkName, model.Name, model.Price)
            Next i
            Return ret
        End Function
        '</sbRecords>
        #End Region
    End Class
End Namespace

