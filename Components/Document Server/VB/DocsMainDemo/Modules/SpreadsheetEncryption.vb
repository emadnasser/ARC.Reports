Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraSpreadsheet
Imports DevExpress.DXperience.Demos
Imports System

Namespace DevExpress.Docs.Demos
	Partial Public Class SpreadsheetEncryption
		Inherits SpreadsheetTutorialControl

		Public Sub New()
			InitializeComponent()
			FitToPageCheckEdit.Visible = False
			FitToPageCheckEdit.Enabled = False
			SpreadsheetTutorialPanel.Dock = System.Windows.Forms.DockStyle.Fill
			InitializeEncryptionOptions()

			FitToPageCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked ' RefreshPreview
		End Sub

		Protected Overrides ReadOnly Property DefaultFileName() As String
			Get
				Return "Document"
			End Get
		End Property
		Protected Overrides ReadOnly Property DefaultSaveFileFilter() As String
			Get
				Return "Excel Workbook files(*.xlsx)|*.xlsx|Excel 97 - 2003 Workbook files(*.xls) | *.xls"
			End Get
		End Property

		Public Overrides Function CreateBook() As IWorkbook
			Dim book As IWorkbook = New Workbook()
			book.LoadDocument(DemoUtils.GetRelativePath("ProfitAndLoss.xlsx"))
			book.DocumentSettings.Encryption.Password = passwordEdit.Text
			book.DocumentSettings.Encryption.Type = CType(System.Enum.Parse(GetType(EncryptionType), typeEdit.Text), EncryptionType)
			Return book
		End Function

		Private Sub InitializeEncryptionOptions()
			passwordEdit.Text = "test"

			For Each currentValue As EncryptionType In EnumHelper.GetValues(Of EncryptionType)()
				typeEdit.Properties.Items.Add(currentValue.ToString())
			Next currentValue
			typeEdit.SelectedItem = EncryptionType.Strong.ToString()
		End Sub
	End Class
End Namespace
