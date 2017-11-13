Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraVerticalGrid.Blending
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars

Namespace DevExpress.XtraVerticalGrid.Demos.Tutorials
	Public Class TutorialControl
		Inherits DevExpress.Tutorials.ModuleBase
		Public Overridable ReadOnly Property ShowLookAndFeel() As Boolean
			Get
				Return True
			End Get
		End Property
		Public Overridable ReadOnly Property SetNewWhatsThisPadding() As Boolean
			Get
				Return False
			End Get
		End Property
		Public Overrides Sub StartWhatsThis()
			TutorialsInfo.CloseCustomizationForm(Me)
			If SetNewWhatsThisPadding Then
				Me.Padding = New Padding(8)
				Me.Refresh()
			End If
		End Sub
		Public Overrides Sub EndWhatsThis()
			If SetNewWhatsThisPadding Then
				Me.Padding = New Padding(0)
			End If
		End Sub
    End Class
    Public Class VertGridTutorialMenu
        Inherits DevExpress.DXperience.Demos.LookAndFeelMenu
        Public Sub New(ByVal manager As BarManager, ByVal lookAndFeel As DefaultLookAndFeel, ByVal about As String)
            MyBase.New(manager, lookAndFeel, about)
        End Sub
        Protected Overrides ReadOnly Property ProductName() As String
            Get
                Return "XtraVerticalGrid"
            End Get
        End Property
        Protected Overrides Sub biProductWebPage_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            System.Diagnostics.Process.Start("http://www.devexpress.com/Products/NET/WinForms/XtraVerticalGrid/")
        End Sub
        Protected Overrides Sub miAboutProduct_Click(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            VGridControlBase.About()
        End Sub
    End Class

End Namespace
