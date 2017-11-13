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
    Partial Public Class Employees
        Inherits BaseTutorialControl

        Public Sub New()
            ' This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog()
            InitializeComponent()
            InitData()
            ' TODO: Add any initialization after the InitForm call

        End Sub

        Private Sub InitData()
            layoutControl1.SetDefaultLayout()
            InitPanels()
            Me.pictureEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsEmployees1, "Employees.Photo"))
            lookUpEdit1.Properties.DataSource = GetNWindData(dsEmployees1, "Employees")
        End Sub

        Public Overrides ReadOnly Property BaseLayout() As LayoutControl
            Get
                Return layoutControl1
            End Get
        End Property
        Protected Overrides ReadOnly Property FileMask() As String
            Get
                Return "nwind_"
            End Get
        End Property
    End Class
End Namespace
