Imports System.ComponentModel
Imports System.Text
Imports DevExpress.MailClient.Win
Imports DevExpress.XtraWaitForm

Namespace DevExpress.ProductsDemo.Win.Forms
	Partial Public Class wfMain
		Inherits DemoWaitForm

		Public Sub New()
			DevExpress.Utils.LocalizationHelper.SetCurrentCulture(DataHelper.ApplicationArguments)
			InitializeComponent()
			ProgressPanel.Caption = My.Resources.ProgressPanelCaption
			ProgressPanel.Description = My.Resources.ProgressPanelDescription
		End Sub
	End Class
End Namespace
