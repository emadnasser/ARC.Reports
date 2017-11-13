Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Windows.Forms
Imports System.Threading
Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraLayout.Demos
	Public Class TutorialControl
		Inherits TutorialControlBase
		Private fDescription As DevExpress.Utils.Frames.NotePanel = Nothing
		Public Overridable ReadOnly Property ExportControl() As LayoutControl
			Get
				Return Nothing
			End Get
		End Property
		Protected Overrides Sub AllowExport()
			EnabledPrintExportActions(True, ExportFormats.PDF Or ExportFormats.HTML Or ExportFormats.MHT Or ExportFormats.XLS Or ExportFormats.RTF Or ExportFormats.Text Or ExportFormats.XLSX, False)
		End Sub
		Public Overrides ReadOnly Property AllowPrintOptions() As Boolean
			Get
				Return ExportControl IsNot Nothing
			End Get
		End Property
		Protected Overrides Sub SetControlManager(ByVal ctrl As Control, ByVal manager As BarManager)
			Dim layout As DevExpress.XtraLayout.LayoutControl = TryCast(ctrl, DevExpress.XtraLayout.LayoutControl)
			If layout IsNot Nothing Then
				layout.MenuManager = manager
            End If
            Dim be As BaseEdit = TryCast(ctrl, BaseEdit)
            If be IsNot Nothing Then
                be.MenuManager = manager
            End If
        End Sub

		Public Property Description() As DevExpress.Utils.Frames.NotePanel
			Get
				Return fDescription
			End Get
			Set(ByVal value As DevExpress.Utils.Frames.NotePanel)
				fDescription = value
				OnSetDescription("")
			End Set
		End Property
		Protected Overridable Sub OnSetDescription(ByVal fDescription As String)
			If fDescription Is String.Empty Then
			Return
			End If
			Description.Text = String.Format(fDescription)
		End Sub
		Public ReadOnly Property TutorialDataView() As DataView
			Get
				Return dvTutorial
			End Get
		End Property
		Private dvTutorial As DataView = Nothing
		Protected Function GetNWindData(ByVal ds As DataSet, ByVal tableName As String) As DataView
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\nwind.mdb")
			If DBFileName <> "" Then
				If ds Is Nothing Then
				ds = New DataSet()
				End If
				Dim con As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName
				Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM " & tableName, con)
				SetWaitDialogCaption(String.Format("Loading {0}...", tableName))
				oleDbDataAdapter.Fill(ds, tableName)

				dvTutorial = ds.Tables(tableName).DefaultView
				Return dvTutorial
			End If
			Return Nothing
		End Function
		Protected Function GetCarsData(ByVal ds As DataSet) As DataView
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath,"Data\cars.xml")
			If DBFileName <> "" Then
				If ds Is Nothing Then
				ds = New DataSet()
				End If
				SetWaitDialogCaption(String.Format("Loading {0}...", "cars.xml"))
				ds.ReadXml(DBFileName)
				dvTutorial = ds.Tables(0).DefaultView
				Return dvTutorial
			End If
			Return Nothing
		End Function
		Public Function GetDataRowByIndex(ByVal index As Integer) As DataRowView
			If dvTutorial IsNot Nothing Then
				Return dvTutorial(index)
			End If
			Return Nothing
		End Function
		#Region "Print and Export"
		Protected Overrides Sub ExportToCore(ByVal filename As String, ByVal ext As String)
			If ExportControl Is Nothing Then
			Return
			End If
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			If ext = "rtf" Then
			ExportControl.ExportToRtf(filename)
			End If
			If ext = "pdf" Then
			ExportControl.ExportToPdf(filename)
			End If
			If ext = "mht" Then
			ExportControl.ExportToMht(filename)
			End If
			If ext = "html" Then
			ExportControl.ExportToHtml(filename)
			End If
			If ext = "txt" Then
			ExportControl.ExportToText(filename)
			End If
			If ext = "xls" Then
			ExportControl.ExportToXls(filename)
			End If
			If ext = "xlsx" Then
			ExportControl.ExportToXlsx(filename)
			End If
			Cursor.Current = currentCursor
		End Sub
		Protected Overrides Sub ExportToPDF()
			ExportTo("pdf", "PDF document (*.pdf)|*.pdf")
		End Sub
		Protected Overrides Sub ExportToHTML()
			ExportTo("html", "HTML document (*.html)|*.html")
		End Sub
		Protected Overrides Sub ExportToMHT()
			ExportTo("mht", "MHT document (*.mht)|*.mht")
		End Sub
		Protected Overrides Sub ExportToXLS()
			ExportTo("xls", "XLS document (*.xls)|*.xls")
		End Sub
		Protected Overrides Sub ExportToXLSX()
			ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx")
		End Sub
		Protected Overrides Sub ExportToRTF()
			ExportTo("rtf", "RTF document (*.rtf)|*.rtf")
		End Sub
		Protected Overrides Sub ExportToText()
			ExportTo("txt", "Text document (*.txt)|*.txt")
		End Sub
		Protected Overrides Sub PrintPreview()
			If Me.ExportControl IsNot Nothing Then
				If RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm Then
					Me.ExportControl.ShowRibbonPrintPreview()
				Else
					Me.ExportControl.ShowPrintPreview()
				End If
			End If
		End Sub
		#End Region
	End Class
End Namespace
