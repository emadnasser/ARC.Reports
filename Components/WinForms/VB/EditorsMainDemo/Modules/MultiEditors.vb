Imports System.Collections
Imports System.ComponentModel

Namespace DevExpress.XtraEditors.Demos
	''' <summary>
	''' Summary description for MultiEditors.
	''' </summary>
	Partial Public Class MultiEditors
		Inherits TutorialControl

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            gridView1.OptionsMenu.ShowAutoFilterRowItem = False
			'TutorialInfo.WhatsThisCodeFile = "CS\\GridMainDemo\\Modules\\MultiEditors.vb";
			'TutorialInfo.WhatsThisXMLFile = "MultiEditors.xml";
			gridControl1.ForceInitialize()
			InitData()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		#Region "Init"
		Private Function GetImage(ByVal name As String) As Image
			Dim str As System.IO.Stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Images." & name)
			If str IsNot Nothing Then
				Return Bitmap.FromStream(str)
			End If
			Return Nothing
		End Function

		Private Function ImageToByteArray(ByVal image As Image) As Byte()
			Dim mStream As New System.IO.MemoryStream()
			image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg)
			Dim ret() As Byte = mStream.ToArray()
			mStream.Close()
			Return ret
		End Function
		Private Sub InitData()
			Dim records(9) As RecordOrder
			records(0) = New RecordOrder(My.Resources.ProductName, "Mishi Kobe Niku", "Teatime Chocolate Biscuits", "Ipoh Coffee")
			records(1) = New RecordOrder(My.Resources.Category, 6, 3, 1)
			records(2) = New RecordOrder(My.Resources.Supplier, "Tokyo Traders", "Specialty Biscuits, Ltd.", "Leka Trading")
			records(3) = New RecordOrder(My.Resources.QuantityPerUnit, "18 - 500 g pkgs.", "10 boxes x 12 pieces", "16 - 500 g tins")
			records(4) = New RecordOrder(My.Resources.UnitPrice, 97.00, 9.20, 46.00)
			records(5) = New RecordOrder(My.Resources.UnitsInStock, 29, 25, 17)
			records(6) = New RecordOrder(My.Resources.Discontinued, False, True, True)
			records(7) = New RecordOrder(My.Resources.LastOrder, New Date(2001, 12, 14), New Date(2003, 7, 20), New Date(2002, 1, 7))
			records(8) = New RecordOrder(My.Resources.Picture, My.Resources.product1, My.Resources.product2, My.Resources.product3)
			records(9) = New RecordOrder(My.Resources.Relevance, 70, 90, 50)

			gridControl1.DataSource = records
		End Sub
		#End Region
		#Region "Grid events"
		'<gridControl1>
		Private Sub gridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEdit
			If e.Column.FieldName <> "Category" Then
				Dim rec As RecordOrder = TryCast(gridView1.GetRow(e.RowHandle), RecordOrder)
				If rec.Category = My.Resources.Category Then
					e.RepositoryItem = repositoryItemImageComboBox1
				End If
				If rec.Category = My.Resources.Supplier Then
					e.RepositoryItem = repositoryItemComboBox1
				End If
				If rec.Category = My.Resources.UnitPrice Then
					e.RepositoryItem = repositoryItemCalcEdit1
				End If
				If rec.Category = My.Resources.UnitsInStock Then
					e.RepositoryItem = repositoryItemSpinEdit1
				End If
				If rec.Category = My.Resources.Discontinued Then
					e.RepositoryItem = repositoryItemCheckEdit1
				End If
				If rec.Category = My.Resources.Discontinued Then
					e.RepositoryItem = repositoryItemCheckEdit1
				End If
				If rec.Category = My.Resources.LastOrder Then
					e.RepositoryItem = repositoryItemDateEdit1
				End If
				If rec.Category = My.Resources.Picture Then
					e.RepositoryItem = repositoryItemPictureEdit1
				End If
				If rec.Category = My.Resources.Relevance Then
					e.RepositoryItem = repositoryItemProgressBar1
				End If
			End If
		End Sub
		'</gridControl1>

		Private Sub gridView1_RowCellDefaultAlignment(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellAlignmentEventArgs) Handles gridView1.RowCellDefaultAlignment
			If e.Column.FieldName <> "Category" Then
				If e.RowHandle = 4 OrElse e.RowHandle = 5 Then
					e.HorzAlignment = DevExpress.Utils.HorzAlignment.Far
				End If
				If e.RowHandle = 9 Then
					e.HorzAlignment = DevExpress.Utils.HorzAlignment.Center
				End If
			End If
		End Sub

		'<gridControl1>
'         
'         ~Set custom height for row 8:
'         
		Private Sub gridView1_CalcRowHeight(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs) Handles gridView1.CalcRowHeight
			If e.RowHandle = 8 Then
				e.RowHeight = 150
			End If
		End Sub
		'</gridControl1>

		#End Region
		#Region "RepositoryItems events"
		Private Sub repositoryItemProgressBar1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles repositoryItemProgressBar1.KeyPress
			Dim i As Integer = 0
			If gridView1.ActiveEditor Is Nothing Then
				Return
			End If

			If e.KeyChar = "+"c Then
				i = CInt(Fix(gridView1.ActiveEditor.EditValue))
				If i < 100 Then
					gridView1.ActiveEditor.EditValue = i + 1
				End If
			End If
			If e.KeyChar = "-"c Then
				i = CInt(Fix(gridView1.ActiveEditor.EditValue))
				If i > 0 Then
					gridView1.ActiveEditor.EditValue = i - 1
				End If
			End If
		End Sub
		#End Region
	End Class
End Namespace
