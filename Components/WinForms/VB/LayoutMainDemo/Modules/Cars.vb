Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace DevExpress.XtraLayout.Demos
    ''' <summary>
    ''' Summary description for Employees.
    ''' </summary>
    Partial Public Class Cars
        Inherits BaseTutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            InitData()

            ' TODO: Add any initialization after the InitForm call

        End Sub

        Public Overrides ReadOnly Property BaseLayout() As LayoutControl
            Get
                Return layoutControl1
            End Get
        End Property
        Protected Overrides ReadOnly Property FileMask() As String
            Get
                Return "cars_"
            End Get
        End Property

        Private Sub InitData()
            layoutControl1.SetDefaultLayout()
            InitPanels()
            GetCarsData(Nothing)
            dataNavigator1.DataSource = TutorialDataView
            Me.pictureEdit1.DataBindings.Add(New Binding("EditValue", TutorialDataView, "Picture"))
            Me.memoEdit1.DataBindings.Add(New Binding("Text", TutorialDataView, "Description"))
            Me.textEdit1.DataBindings.Add(New Binding("Text", TutorialDataView, "Trademark"))
            Me.textEdit2.DataBindings.Add(New Binding("Text", TutorialDataView, "Model"))
            Me.imageComboBoxEdit1.DataBindings.Add(New Binding("EditValue", TutorialDataView, "Category"))
            Me.hyperLinkEdit1.DataBindings.Add(New Binding("Text", TutorialDataView, "Hyperlink"))
            Me.calcEdit1.DataBindings.Add(New Binding("EditValue", TutorialDataView, "Price"))
            Me.dateEdit1.DataBindings.Add(New Binding("EditValue", TutorialDataView, "Delivery Date"))
            Me.checkEdit1.DataBindings.Add(New Binding("EditValue", TutorialDataView, "Is In Stock"))
            Me.textEdit3.DataBindings.Add(New Binding("Text", TutorialDataView, "HP"))
            Me.textEdit4.DataBindings.Add(New Binding("EditValue", TutorialDataView, "Liter"))
            Me.spinEdit1.DataBindings.Add(New Binding("EditValue", TutorialDataView, "Cyl"))
            Me.spinEdit2.DataBindings.Add(New Binding("EditValue", TutorialDataView, "MPG Highway"))
            Me.spinEdit3.DataBindings.Add(New Binding("EditValue", TutorialDataView, "MPG City"))
            Me.spinEdit4.DataBindings.Add(New Binding("EditValue", TutorialDataView, "Transmiss Speed Count"))
            Me.checkEdit2.DataBindings.Add(New Binding("EditValue", TutorialDataView, "Transmiss Automatic"))
        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkEdit1.CheckedChanged
            layoutControl1.BeginUpdate()
            dateEdit1.Enabled = checkEdit1.Checked
            calcEdit1.Enabled = dateEdit1.Enabled
            layoutControl1.EndUpdate()
        End Sub
    End Class
End Namespace
