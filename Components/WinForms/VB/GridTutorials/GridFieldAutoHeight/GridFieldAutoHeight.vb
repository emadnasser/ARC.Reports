Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for GridFieldAutoHeight.
	''' </summary>
	Public Partial Class GridFieldAutoHeight
		Inherits TutorialControl
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

	  '<radioGroup1>
		Private Sub GridFieldAutoHeight_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		 '</radioGroup1>
			InitData()
			cardView1.FocusedRowHandle = 15
			'<radioGroup1>
		 radioGroup1.Properties.Items(0).Value = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
			radioGroup1.Properties.Items(1).Value = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
			radioGroup1.Properties.Items(2).Value = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
			radioGroup1.EditValue = radioGroup1.Properties.Items(2).Value
		End Sub
	  '</radioGroup1>

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\DXProducts.xml")
			If DBFileName <> "" Then
				Dim ds As DataSet = New DataSet()
				ds.ReadXml(DBFileName)
				gridControl1.DataSource = ds.Tables(0)
			End If
		End Sub

        '<radioGroup1>
		Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioGroup1.SelectedIndexChanged
			cardView1.VertScrollVisibility = CType(radioGroup1.EditValue, DevExpress.XtraGrid.Views.Base.ScrollVisibility)
		End Sub
        '</radioGroup1>
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
	End Class
End Namespace
