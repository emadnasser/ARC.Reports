Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace DevExpress.RealtorWorld.Win
	Partial Public Class ucDraft
		Inherits BaseModule
		Public Overrides ReadOnly Property ModuleCaption() As String
			Get
				Return "User management"
			End Get
		End Property
		Public Overrides ReadOnly Property AllowWaitDialog() As Boolean
			Get
				Return False
			End Get
		End Property
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
