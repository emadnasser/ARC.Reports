Imports System.ComponentModel
Imports System.Text

Namespace DevExpress.XtraBars.Demos.TileControlDemo
	Partial Public Class MainForm
		Inherits Form
        Public Sub New()
            DevExpress.Utils.About.UAlgo.Default.DoEventObject(DevExpress.Utils.About.UAlgo.kDemo, DevExpress.Utils.About.UAlgo.pWinForms, Me) 'DEMO_REMOVE
            InitializeComponent()
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End Sub
	End Class
End Namespace
