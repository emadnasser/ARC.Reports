Imports Microsoft.VisualBasic
Imports System.Windows.Forms

Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class Calendar
		Inherits UserControl
		Public Sub New()
            InitializeComponent()
            dateNavigator1.DateTime = DateTime.Now
            dateNavigator1.CalendarIndent = 10
        End Sub
        Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
            MyBase.OnResize(e)
            dateNavigator1.CalcBestSize()
        End Sub
	End Class
End Namespace
