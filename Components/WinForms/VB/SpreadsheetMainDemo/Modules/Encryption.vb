Imports Microsoft.VisualBasic
Imports DevExpress.DXperience.Demos
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars.Ribbon
Imports System
Imports System.Diagnostics
Imports System.Windows.Forms

Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class EncryptionModule
		Inherits SpreadsheetRibbonTutorialControlBase
		Private workbook As IWorkbook

		Public Sub New()
			InitializeComponent()
			InitializeWorkbook()
			InitializeEncryptionOptions()
			workbook.History.Clear()
		End Sub

		#Region "Properties"
		Protected Friend Overrides ReadOnly Property SelectedRibbonPage() As RibbonPage
			Get
				Return fileRibbonPage1
			End Get
		End Property
		#End Region

		Private Sub InitializeWorkbook()
			workbook = spreadsheetControl1.Document
			workbook.LoadDocument(DemoUtils.GetRelativePath("ProfitAndLoss.xlsx"))
		End Sub

		Private Sub InitializeEncryptionOptions()
			passwordEdit.Text = "test"

			For Each currentValue As EncryptionType In EnumHelper.GetValues(Of EncryptionType)()
				typeEdit.Properties.Items.Add(currentValue.ToString())
			Next currentValue
			typeEdit.SelectedItem = EncryptionType.Strong.ToString()
		End Sub

		Private Sub TypeEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles typeEdit.TextChanged
			workbook.DocumentSettings.Encryption.Type = CType(System.Enum.Parse(GetType(EncryptionType), typeEdit.Text), EncryptionType)
		End Sub

		Private Sub PasswordEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles passwordEdit.TextChanged
			workbook.DocumentSettings.Encryption.Password = passwordEdit.Text
		End Sub

		Private Sub BtnExportToXLSX_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportToXLSX.Click
			OnBtnClick("Excel Workbook files(*.xlsx)|*.xlsx", "Document.xlsx")
		End Sub

		Private Sub BtnExportToXLS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExportToXLS.Click
			OnBtnClick("Excel 97-2003 Workbook files(*.xls)|*.xls", "Document.xls")
		End Sub

		Private Sub OnBtnClick(ByVal filter As String, ByVal defaultName As String)
			Dim sfDialog As New SaveFileDialog()
			sfDialog.Filter = filter
			sfDialog.FileName = defaultName
			If sfDialog.ShowDialog() <> DialogResult.OK Then
				Return
			End If

			Dim fileName As String = sfDialog.FileName
			workbook.SaveDocument(fileName)

			If chbOpenResultingFile.Checked Then
				Process.Start(fileName)
			End If
		End Sub

		Protected Overrides Sub DoShow()
			MyBase.DoShow()
			spreadsheetControl1.Focus()
		End Sub
	End Class
End Namespace
