Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Utils
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraBars
Imports DevExpress.DXperience.Demos
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraTreeList.Demos
	Partial Public Class TreeListPictures
		Inherits TutorialControl

		Public Overrides ReadOnly Property ViewOptionsControl() As TreeList
			Get
				Return treeList1
			End Get
		End Property
		Public Overrides ReadOnly Property ExportControl() As TreeList
			Get
				Return treeList1
			End Get
		End Property
		Protected Overrides ReadOnly Property BarName() As String
			Get
				Return "Pictures"
			End Get
		End Property
		Protected Overrides ReadOnly Property Manager() As BarManager
			Get
				Return barManager1
			End Get
		End Property
		Protected Overrides Sub InitBarInfo()
			Me.BarInfos.Add(New BarInfo("Print Preview", New ItemClickEventHandler(AddressOf PrintPreviewClick), imageCollection1.Images(0), False, False, False))
			Me.BarInfos.Add(New BarInfo("Print Designer", New ItemClickEventHandler(AddressOf PrintDesignerClick), imageCollection1.Images(1), False, False, False))
		End Sub

		Public Sub New()
			InitializeComponent()
			TutorialInfo.WhatsThisCodeFile = "VB\TreeListMainDemo\Modules\Pictures.vb"
			TutorialInfo.WhatsThisXMLFile = "Pictures.xml"
			InitData()
			InitHeaderPanelColor()
		End Sub

		Protected Overrides Sub OnSwitchStyle()
			InitHeaderPanelColor()
		End Sub

		'<treeList1>
		Private Sub PrintPreviewClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			treeList1.ShowPrintPreview()
			Cursor.Current = currentCursor
		End Sub

		Private Sub PrintDesignerClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Dim frm As New DevExpress.XtraEditors.XtraForm()
			frm.Text = "Print Designer"
			Dim print As New DevExpress.XtraTreeList.Frames.TreeListPrinting()
			print.InitFrame(treeList1, "PrintingReport management", CType(imageCollection1.Images(0), Bitmap))
			print.Dock = DockStyle.Fill
			frm.Controls.Add(print)
			frm.Size = print.UserControlSize
			frm.StartPosition = FormStartPosition.CenterScreen
			frm.ShowDialog()
			Cursor.Current = currentCursor
		End Sub
		'</treeList1>

		Private Sub InitData()
			Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\BioLife.xml")
			If DBFileName <> "" Then
				Dim dataSet As New DataSet()
				dataSet.ReadXml(DBFileName)
				treeList1.DataSource = dataSet.Tables(0).DefaultView
			End If
		End Sub

		Private Sub InitHeaderPanelColor()
			Dim isDefault As Boolean = UserLookAndFeel.Default.UseWindowsXPTheme OrElse UserLookAndFeel.Default.Style = LookAndFeelStyle.Skin OrElse UserLookAndFeel.Default.Style = LookAndFeelStyle.Office2003
			treeList1.Appearance.HeaderPanel.ForeColor = If(isDefault, Color.Empty, Color.White) 'SystemColors.WindowText
		End Sub
	End Class
End Namespace
