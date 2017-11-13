Namespace TabbedBrowser
	Partial Public Class HostWindow
        Inherits RootMainForm
        Private rootForm As RootMainForm
        Public Sub New(ByVal allHistory As Dictionary(Of String, Date), ByVal Form As RootMainForm)
            MyBase.New(allHistory, Form.WindowState)
            InitializeComponent()
            IsInitialized = False
            rootForm = Form
        End Sub
	End Class
End Namespace
