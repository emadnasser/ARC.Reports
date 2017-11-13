Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraNavBar.Demos
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace DevExpress.XtraNavBar.Demos
	Partial Public Class AccordionControlBusinessModule
		Inherits TutorialControl
		Public Sub New()
			InitializeComponent()
			InitVehiclesData()
			InitGrid()
			InitAccordion()
		End Sub
		Private dataSet As DataSet
		Protected Function GetDataDir() As String
			Dim path As String = AppDomain.CurrentDomain.BaseDirectory
			For i As Integer = 0 To 9
				path &= "..\"
				If Directory.Exists(path & "Data") Then
					Return path & "Data"
				End If
			Next i
			Return String.Empty
		End Function
		Protected ReadOnly Property DataPath() As String
			Get
				Dim dataPath_Renamed As String = GetDataDir() & "\AccordionControlData"
                If Directory.Exists(dataPath_Renamed) Then
                    Return dataPath_Renamed
                End If
				Return String.Empty
			End Get
		End Property
		Protected Overridable Sub InitVehiclesData()
			Dim DBFileName As String = String.Empty
			DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(DataPath, "\Vehicles.mdb")
			If DBFileName <> String.Empty Then
				InitMDBData("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DBFileName)
			End If
		End Sub
		Protected Sub InitMDBData(ByVal connectionString As String)
			Dim tblModel As String = "Model", tblCategory As String = "Category", tblTrademark As String = "Trademark", tblBodyStyle As String = "BodyStyle", tblTransmissionType As String = "TransmissionType"
			Dim ds As New DataSet()

			FillTable(tblModel, String.Format("SELECT model.ID, model.Name, model.Price, category.Name, model.[MPG City], model.[MPG Highway], model.Doors, trademark.Name, transmission.Name, bodyStyle.Name, model.Photo, model.Image, model.Description FROM {0} model, {1} category, {2} trademark, {3} transmission, {4} bodyStyle WHERE model.TrademarkID=trademark.ID AND model.CategoryID=category.ID AND model.[Transmission Type]=transmission.ID AND model.BodyStyleID=bodyStyle.ID ", tblModel, tblCategory, tblTrademark, tblTransmissionType, tblBodyStyle), connectionString, ds)

			SetGridDataSource(tblModel, ds, Me.gridControl1)
			dataSet = ds
		End Sub

		Private Sub SetGridDataSource(ByVal table As String, ByVal ds As DataSet, ByVal grid As GridControl)
			grid.DataMember = "Model"
			grid.DataSource = ds
		End Sub
		Private Sub FillTable(ByVal table As String, ByVal query As String, ByVal connectionString As String, ByVal ds As DataSet)
			If query Is Nothing Then
				query = String.Format("SELECT * FROM {0}", table)
			End If
			Dim oleDbDataAdapter As New System.Data.OleDb.OleDbDataAdapter(query, connectionString)
			oleDbDataAdapter.Fill(ds, table)
		End Sub
		Private Sub InitGrid()
			Me.winExplorerView1.Columns.Clear()
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "model.ID"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "model.Name"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Description"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Photo"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Image"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "InStock"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "category.Name"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "trademark.Name"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "transmission.Name"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "bodyStyle.Name"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Price"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "Doors"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "MPG City"})
			Me.winExplorerView1.Columns.Add(New GridColumn() With {.FieldName = "MPG Highway"})

			Dim item As New RepositoryItemTextEdit()
			Me.winExplorerView1.Columns("model.Name").ColumnEdit = item
			Me.gridControl1.RepositoryItems.Add(item)

			Me.winExplorerView1.ColumnSet.TextColumn = Me.winExplorerView1.Columns("model.Name")
			Me.winExplorerView1.ColumnSet.DescriptionColumn = Me.winExplorerView1.Columns("Price")
			Me.winExplorerView1.Columns("Price").DisplayFormat.FormatType = Utils.FormatType.Numeric
			Me.winExplorerView1.Columns("Price").DisplayFormat.FormatString = "c"
			Me.winExplorerView1.ColumnSet.ExtraLargeImageColumn = Me.winExplorerView1.Columns("Photo")
			Me.winExplorerView1.ColumnSet.MediumImageColumn = Me.winExplorerView1.Columns("Image")
			Me.winExplorerView1.ColumnSet.CheckBoxColumn = Me.winExplorerView1.Columns("InStock")
		End Sub

        Private Sub InitAccordion()
            If dataSet Is Nothing Or dataSet.Tables("Model") Is Nothing Then
                Return
            End If
            InitMain()
            InitBody()
            InitEngine()
        End Sub

		Private Sub InitEngine()
			InitMPGCity()
			InitMPGHighway()
		End Sub

		Private Sub InitMPGHighway()
			rtbMPGHighway.Properties.Minimum = Convert.ToInt32(FindMinMax(True, "MPG Highway"))
			rtbMPGHighway.Properties.Maximum = Convert.ToInt32(FindMinMax(False, "MPG Highway"))

            Dim c As Integer = CType(((rtbMPGHighway.Properties.Maximum - rtbMPGHighway.Properties.Minimum) / rtbMPGHighway.Properties.TickFrequency) * rtbMPGHighway.Properties.TickFrequency + rtbMPGHighway.Properties.Minimum, Integer)
			rtbMPGHighway.Properties.Labels(0).Value = rtbMPGHighway.Properties.Minimum
			rtbMPGHighway.Properties.Labels(1).Value = c

			rtbMPGHighway.Properties.Labels(1).Label = rtbMPGHighway.Properties.Maximum.ToString()
			rtbMPGHighway.Properties.Labels(0).Label = rtbMPGHighway.Properties.Minimum.ToString()
		End Sub

		Private Sub InitMPGCity()
			rtbMPGCity.Properties.Minimum = Convert.ToInt32(FindMinMax(True, "MPG City"))
			rtbMPGCity.Properties.Maximum = Convert.ToInt32(FindMinMax(False, "MPG City"))

            Dim c As Integer = CType(((rtbMPGCity.Properties.Maximum - rtbMPGCity.Properties.Minimum) / rtbMPGCity.Properties.TickFrequency) * rtbMPGCity.Properties.TickFrequency + rtbMPGCity.Properties.Minimum, Integer)
			rtbMPGCity.Properties.Labels(0).Value = rtbMPGCity.Properties.Minimum
			rtbMPGCity.Properties.Labels(1).Value = c

			rtbMPGCity.Properties.Labels(1).Label = rtbMPGCity.Properties.Maximum.ToString()
			rtbMPGCity.Properties.Labels(0).Label = rtbMPGCity.Properties.Minimum.ToString()
		End Sub
		Private Sub InitBody()
			InitBodyStyle()
			InitDoorsCount()
		End Sub
		Private Sub InitDoorsCount()
			rgDoorsCount.Properties.Items.Add(New RadioGroupItem("2", "2"))
			rgDoorsCount.Properties.Items.Add(New RadioGroupItem("3", "3"))
			rgDoorsCount.Properties.Items.Add(New RadioGroupItem("4", "4"))
			rgDoorsCount.Properties.Items.Add(New RadioGroupItem("All", "All"))
			rgDoorsCount.SelectedIndex = 3
		End Sub
		Private Sub InitBodyStyle()
			Dim bodyStyles As List(Of String) = GetListFromDB("bodyStyle.Name")
			For Each str As String In bodyStyles
				clbBodyStyle.Items.Add(str)
			Next str
		End Sub

		Private Sub InitMain()
			InitPrice()
			InitTrademarks()
			InitTransmissionType()
		End Sub
		Private Sub InitTransmissionType()
		   Dim transmissions As List(Of String) = GetListFromDB("transmission.Name")
		   For Each str As String In transmissions
			   rgTransmissionType.Properties.Items.Add(New RadioGroupItem(str, str))
		   Next str
		   rgTransmissionType.Properties.Items.Add(New RadioGroupItem("All", "All"))
		   rgTransmissionType.SelectedIndex = 2
		End Sub
		Private Sub InitPrice()
			rTBPrice.Properties.Minimum = Convert.ToInt32(FindMinMax(True, "Price"))
			rTBPrice.Properties.Maximum = Convert.ToInt32(FindMinMax(False, "Price"))

			Dim c As Integer = CType(((rTBPrice.Properties.Maximum - rTBPrice.Properties.Minimum) / rTBPrice.Properties.TickFrequency) * rTBPrice.Properties.TickFrequency + rTBPrice.Properties.Minimum, Integer)
			rTBPrice.Properties.Labels(1).Value = rTBPrice.Properties.Minimum
			rTBPrice.Properties.Labels(0).Value = c

            rTBPrice.Properties.Labels(0).Label = String.Format("{0:N0}", rTBPrice.Properties.Maximum)
            rTBPrice.Properties.Labels(1).Label = String.Format("{0:N0}", rTBPrice.Properties.Minimum)
		End Sub
		Private Sub InitTrademarks()
			Dim trademarks As List(Of String) = GetListFromDB("trademark.Name")
			For Each str As String In trademarks
				chLBMark.Items.Add(str)
			Next str
		End Sub

        Private Function FindMinMax(ByVal isMin As Boolean, ByVal column As String) As Integer
            If dataSet Is Nothing Or dataSet.Tables("Model") Is Nothing Then
                Return 0
            End If
            Dim min As Integer = 0
            Dim max As Integer = 0
            For Each row As DataRow In dataSet.Tables("Model").Rows
                Dim val As String = row(column).ToString()
                Dim cur As Integer
                If Int32.TryParse(val, cur) Then
                    min = If(min = 0, cur, Math.Min(min, cur))
                    max = Math.Max(max, cur)
                End If
            Next row
            If isMin Then
                Return min
            End If
            Return max
        End Function
		Private Function GetListFromDB(ByVal column As String) As List(Of String)
            Dim list As New List(Of String)()
            If dataSet Is Nothing Or dataSet.Tables("Model") Is Nothing Then
                Return list
            End If
			For Each row As DataRow In dataSet.Tables("Model").Rows
				Dim str As String = row(column).ToString()
				If Not list.Contains(str) Then
					list.Add(str)
				End If
			Next row
			list.Sort()
			Return list
		End Function

        Private Sub rTBPrice_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rTBPrice.EditValueChanged
            If winExplorerView1.Columns("Price") Is Nothing Then
                Return
            End If
            Dim str As String = "[Price] >= " & rTBPrice.Value.Minimum.ToString() & " AND [Price] <= " & rTBPrice.Value.Maximum.ToString()
            winExplorerView1.Columns("Price").FilterInfo = New ColumnFilterInfo(str)
        End Sub
		Private Function GetFilterString(ByVal column As String, ByVal checkedListBoxItemCollection As CheckedListBoxItemCollection) As String
			Dim str As String = String.Empty
			For Each item As CheckedListBoxItem In checkedListBoxItemCollection
				If item.CheckState <> CheckState.Checked Then
					Continue For
				End If
				If str <> String.Empty Then
					str = str & "OR"
				End If
				str = str & "[" & column & "] = '" & item.Value.ToString() & "' "
			Next item
			Return str
		End Function

		Private Sub rgTransmissionType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgTransmissionType.SelectedIndexChanged
			If rgTransmissionType.SelectedIndex = 2 Then
				winExplorerView1.Columns("transmission.Name").FilterInfo = ColumnFilterInfo.Empty
				Return
			End If
			Dim str As String = rgTransmissionType.Properties.Items(rgTransmissionType.SelectedIndex).Value.ToString()
			str = "[transmission.Name] = '" & str & "'"
			winExplorerView1.Columns("transmission.Name").FilterInfo = New ColumnFilterInfo(str)
		End Sub
		Private Sub rgDoorsCount_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rgDoorsCount.SelectedIndexChanged
			If rgDoorsCount.SelectedIndex = 3 Then
				winExplorerView1.Columns("Doors").FilterInfo = ColumnFilterInfo.Empty
				Return
			End If
			Dim str As String = rgDoorsCount.Properties.Items(rgDoorsCount.SelectedIndex).Value.ToString()
			str = "[Doors] = '" & str & "'"
			winExplorerView1.Columns("Doors").FilterInfo = New ColumnFilterInfo(str)
		End Sub
		Private Sub chLBMark_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles chLBMark.ItemCheck
			Dim str As String = GetFilterString("trademark.Name", chLBMark.Items)
			winExplorerView1.Columns("trademark.Name").FilterInfo = New ColumnFilterInfo(str)
		End Sub
		Private Sub clbBodyStyle_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles clbBodyStyle.ItemCheck
			Dim str As String = GetFilterString("bodyStyle.Name", clbBodyStyle.Items)
			winExplorerView1.Columns("bodyStyle.Name").FilterInfo = New ColumnFilterInfo(str)
		End Sub
        Private Sub rtbMPGCity_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rtbMPGCity.EditValueChanged
            If winExplorerView1.Columns("MPG City") Is Nothing Then
                Return
            End If
            Dim str As String = "[MPG City] >= " & rtbMPGCity.Value.Minimum.ToString() & " AND [MPG City] <= " & rtbMPGCity.Value.Maximum.ToString()
            winExplorerView1.Columns("MPG City").FilterInfo = New ColumnFilterInfo(str)
        End Sub
        Private Sub rtbMPGHighway_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rtbMPGHighway.EditValueChanged
            If winExplorerView1.Columns("MPG Highway") Is Nothing Then
                Return
            End If
            Dim str As String = "[MPG Highway] >= " & rtbMPGHighway.Value.Minimum.ToString() & " AND [MPG Highway] <= " & rtbMPGHighway.Value.Maximum.ToString()
            winExplorerView1.Columns("MPG Highway").FilterInfo = New ColumnFilterInfo(str)
        End Sub

        Private Sub rTBPrice_BeforeShowValueToolTip(sender As Object, e As XtraEditors.TrackBarValueToolTipEventArgs) Handles rTBPrice.BeforeShowValueToolTip
            e.ShowArgs.ToolTip = String.Format("{0:C} - {1:C}", rTBPrice.Value.Minimum, rTBPrice.Value.Maximum)
        End Sub

        Private Sub rtbMPGCity_BeforeShowValueToolTip(sender As Object, e As XtraEditors.TrackBarValueToolTipEventArgs) Handles rtbMPGCity.BeforeShowValueToolTip
            e.ShowArgs.ToolTip = String.Format("{0} - {1}", rtbMPGCity.Value.Minimum, rtbMPGCity.Value.Maximum)
        End Sub

        Private Sub rtbMPGHighway_BeforeShowValueToolTip(sender As Object, e As XtraEditors.TrackBarValueToolTipEventArgs) Handles rtbMPGHighway.BeforeShowValueToolTip
            e.ShowArgs.ToolTip = String.Format("{0} - {1}", rtbMPGHighway.Value.Minimum, rtbMPGHighway.Value.Maximum)
        End Sub
    End Class
End Namespace
