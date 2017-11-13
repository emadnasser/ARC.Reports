Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraVerticalGrid.Rows

Namespace DevExpress.XtraVerticalGrid.Demos
    Partial Public Class PropertyGrid
        Inherits DevExpress.XtraVerticalGrid.Demos.TutorialControl

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\VertGridMainDemo\Modules\PropertyGrid.vb"
            TutorialInfo.WhatsThisXMLFile = "PropertyGrid.xml"


            '<chDefaultEditors>
            '
            '~Note: the DefaultEditors property is customized at design time and listed here only for demonstration purposes.
            '~Add items to the DefaultEditors collection, and so define which editors must be used to edit values of specific data types.
            '~Values of the Color, Boolean and Image types will be edited using the ColorEdit, CheckEdit and PictureEdit control, respectively:
            '~
            '~propertyGridControl1.DefaultEditors.AddRange(New DefaultEditor() {
            '~    New DefaultEditor(GetType(System.Drawing.Color), Me.repositoryItemColorEdit1),
            '~   New DefaultEditor(GetType(Boolean), Me.repositoryItemCheckEdit1),
            '~    New DefaultEditor(GetType(System.Drawing.Image), Me.repositoryItemPictureEdit1)})
            '
            '</chDefaultEditors>
        End Sub
        Private optionsUpdate As Boolean = False
        Public Overrides ReadOnly Property ExportControl() As VGridControlBase
            Get
                Return propertyGridControl1
            End Get
        End Property
        Public Overrides ReadOnly Property ViewOptionsControl() As VGridControlBase
            Get
                Return propertyGridControl1
            End Get
        End Property

        Private Sub PropertyGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitControls()
            InitOptions()
        End Sub

        Private Sub InitControls()
            propertyDescriptionControl1.PropertyGrid = Me.propertyGridControl1
            For Each ctrl As Control In pcControls.Controls
                icbControls.Properties.Items.Add(New ImageComboBoxItem(ctrl.Name, ctrl, -1))
                AddHandler ctrl.GotFocus, AddressOf Control_GotFocus
            Next ctrl
            icbControls.SelectedIndex = 0
        End Sub


        Private Sub InitOptions()
            optionsUpdate = True
            chRootCategories.Checked = propertyGridControl1.OptionsView.ShowRootCategories
            chDefaultEditors.Checked = propertyGridControl1.OptionsBehavior.UseDefaultEditorsCollection
            chPropertyDescription.Checked = propertyDescriptionControl1.Visible
            optionsUpdate = False
        End Sub

        Protected Overrides Sub OnOptionsChanged(ByVal sender As Object, ByVal e As EventArgs)
            InitOptions()
        End Sub

        Private Sub Control_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
            icbControls.EditValue = sender
        End Sub

        '<icbControls>
        Private Sub icbControls_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles icbControls.SelectedIndexChanged
            propertyGridControl1.SelectedObject = icbControls.EditValue
            propertyGridControl1.RetrieveFields()
        End Sub
        '</icbControls>

        '<chRootCategories>
        Private Sub chRootCategories_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chRootCategories.CheckedChanged
            If optionsUpdate Then
                Return
            End If
            propertyGridControl1.OptionsView.ShowRootCategories = chRootCategories.Checked
        End Sub
        '</chRootCategories>

        '<chDefaultEditors>
        Private Sub chDefaultEditors_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chDefaultEditors.CheckedChanged
            If optionsUpdate Then
                Return
            End If
            propertyGridControl1.OptionsBehavior.UseDefaultEditorsCollection = chDefaultEditors.Checked
            propertyGridControl1.LayoutChanged()
        End Sub
        '</chDefaultEditors>

        '<chPropertyDescription>
        Private Sub chPropertyDescription_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chPropertyDescription.CheckedChanged
            If optionsUpdate Then
                Return
            End If
            propertyDescriptionControl1.Visible = chPropertyDescription.Checked
            splitterControl2.Visible = chPropertyDescription.Checked
        End Sub
        '</chPropertyDescription>

    End Class
End Namespace

