Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraPivotGrid.Demos.Helpers
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraPivotGrid.Localization
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraPivotGrid.Demos.Modules
    Partial Public Class OLAP
        Inherits DevExpress.XtraPivotGrid.Demos.TutorialControl
        Private isConnecting As Boolean

        Protected Overrides ReadOnly Property HideCustFormWhenSwitchDemo() As Boolean
            Get
                Return False
            End Get
        End Property
        Public Sub New()
            CreateWaitDialog()
            InitializeComponent()

            TutorialInfo.WhatsThisCodeFile = "VB\PivotGridMainDemo\Modules\OLAP.vb"
            TutorialInfo.WhatsThisXMLFile = "OLAP.xml"
        End Sub

        Private Sub OLAP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            pivotGridControl.FieldsCustomization()
            isConnecting = True
            Dim success As Boolean = OLAPConfigurator.CreateSampleOLAPConfiguration(pivotGridControl)
            isConnecting = False
            panelError.Visible = Not success
            separator1.Visible = Not success
            buttonNewConnection.Enabled = success
        End Sub
        Public Overrides ReadOnly Property ViewOptionsControl() As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property
        Public Overrides ReadOnly Property ExportControl() As PivotGridControl
            Get
                Return pivotGridControl
            End Get
        End Property
        Private Sub buttonNewConnection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonNewConnection.Click
            Using connectionDesigner As New OLAPConnectionDesigner()
                If connectionDesigner.ShowDialog() = DialogResult.OK Then
                    pivotGridControl.Fields.Clear()
                    '<buttonNewConnection>
                    pivotGridControl.OLAPConnectionString = connectionDesigner.ConnectionString
                    '</buttonNewConnection>
                    OLAPConfigurator.RetrieveFields(pivotGridControl)
                End If
            End Using
        End Sub

        Private Sub pivotGridControl_FieldValueNotExpanded(ByVal sender As Object, ByVal e As PivotFieldValueEventArgs) Handles pivotGridControl.FieldValueNotExpanded
            XtraMessageBox.Show("Cannot show details for this item: it has no child items.", "OLAP Browser", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub

        Private Sub pivotGridControl_ShowingCustomizationForm(ByVal sender As Object, ByVal e As CustomizationFormShowingEventArgs) Handles pivotGridControl.ShowingCustomizationForm
            e.ParentControl = splitPivotContainer.Panel1
            e.CustomizationForm.Dock = DockStyle.Fill
        End Sub

        Private Sub pivotGridControl_PopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles pivotGridControl.PopupMenuShowing
            If e.MenuType = PivotGridMenuType.Header OrElse e.MenuType = PivotGridMenuType.HeaderArea Then
                For Each item As DXMenuItem In e.Menu.Items
                    If item.Caption = PivotGridLocalizer.GetString(PivotGridStringId.PopupMenuHideFieldList) Then
                        e.Menu.Items.Remove(item)
                        Exit For
                    End If
                Next item
            End If
        End Sub

        Private Sub pivotGridControl_QueryException(ByVal sender As Object, ByVal e As PivotQueryExceptionEventArgs) Handles pivotGridControl.QueryException
            If Not isConnecting Then
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace

