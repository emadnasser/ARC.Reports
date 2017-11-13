Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	''' <summary>
	''' Summary description for SimpleMode.
	''' </summary>
	Public Partial Class SimpleMode
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
        Public Overrides ReadOnly Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
        End Property
		Private Sub SimpleMode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitData()
		End Sub

		Private Sub InitData()
			vGridControl1.DataSource = New Contacts()
		End Sub
	End Class
End Namespace
