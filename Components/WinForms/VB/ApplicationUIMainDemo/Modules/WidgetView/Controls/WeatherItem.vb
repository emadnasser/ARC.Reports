Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class WeatherItem
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Property Sity() As String
			Get
				Return labelControl1.Text
			End Get
			Set(ByVal value As String)
				labelControl1.Text = value
			End Set
		End Property
		Public Property Temperature() As String
			Get
				Return labelControl2.Text
			End Get
			Set(ByVal value As String)
				labelControl2.Text = value
			End Set
		End Property
		Public Property SkyConditions() As String
			Get
				Return labelControl3.Text
			End Get
			Set(ByVal value As String)
				labelControl3.Text = value
			End Set
		End Property
		Public Property RelativeHumidity() As String
			Get
				Return labelControl4.Text
			End Get
			Set(ByVal value As String)
				labelControl4.Text = value
			End Set
		End Property
		Public Property Image() As Image
			Get
                Return WindowsUIButtonPanel1.Buttons(0).Properties.Image
			End Get
			Set(ByVal value As Image)
                WindowsUIButtonPanel1.Buttons(0).Properties.Image = value
			End Set
		End Property
	End Class
End Namespace
