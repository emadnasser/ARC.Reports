Imports System.Collections
Imports System.ComponentModel

Namespace DevExpress.XtraNavBar.Demos
	''' <summary>
	''' Summary description for UserControl1.
	''' </summary>
	Partial Public Class DistanceChanger
		Inherits DevExpress.XtraEditors.XtraUserControl
		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call

		End Sub

		Public Event ValueChanged As EventHandler
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			trackBar1.Enabled = checkBox1.Checked
			RaiseValueChanged()
		End Sub

		Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.ValueChanged
			RaiseValueChanged()
		End Sub

		Private Sub RaiseValueChanged()
			RaiseEvent ValueChanged(Me, EventArgs.Empty)
		End Sub

		Public Property Caption() As String
			Get
				Return label1.Text
			End Get
			Set(ByVal value As String)
				label1.Text = value
			End Set
		End Property
		<DefaultValue(50)> _
		Public Property Maximum() As Integer
			Get
				Return trackBar1.Properties.Maximum
			End Get
			Set(ByVal value As Integer)
				trackBar1.Properties.Maximum = value
			End Set
		End Property

		<DefaultValue(0)> _
		Public Property Minimum() As Integer
			Get
				Return trackBar1.Properties.Minimum
			End Get
			Set(ByVal value As Integer)
				trackBar1.Properties.Minimum = value
			End Set
		End Property

		Public Property Value() As Integer
			Get
				Return trackBar1.Value
			End Get
			Set(ByVal value As Integer)
				trackBar1.Value = value
			End Set
		End Property
		Public ReadOnly Property StatusEnabled() As Boolean
			Get
				Return checkBox1.Checked
			End Get
		End Property
	End Class
End Namespace
