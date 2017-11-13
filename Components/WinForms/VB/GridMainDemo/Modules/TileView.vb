Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.XtraGrid.Demos
    Partial Public Class TileView
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            InitData()
            SetupView()
            InitOrientationDropDown()
            AddHandler tileView1.ItemClick, AddressOf tileView1_ItemClick
            AddHandler barCheckItem1.CheckedChanged, AddressOf barCheckItem1_CheckedChanged
            AddHandler repositoryItemZoomTrackBar1.EditValueChanged, AddressOf repositoryItemZoomTrackBar1_EditValueChanged
        End Sub

        Private Sub InitOrientationDropDown()
            For Each orientation As Orientation In System.Enum.GetValues(GetType(Orientation))
                Dim cbItem As New ImageComboBoxItem(orientation.ToString(), orientation, -1)
                repositoryItemImageComboBox1.Items.Add(cbItem)
            Next orientation
            barEditItem2.EditValue = Orientation.Horizontal
            AddHandler barEditItem2.EditValueChanged, AddressOf barEditItem2_EditValueChanged
        End Sub

        Private Sub barEditItem2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim orientation = CType(barEditItem2.EditValue, Orientation)
            tileView1.OptionsTiles.Orientation = orientation
        End Sub

        Private Sub repositoryItemZoomTrackBar1_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim h As Integer = CInt(((TryCast(sender, BaseEdit)).EditValue))
            Dim w As Integer = CInt((h * 1.78))
            tileView1.OptionsTiles.ItemSize = New Size(w, h)
        End Sub

        Private Sub barCheckItem1_CheckedChanged(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            If (TryCast(sender, BarCheckItem)).Checked Then
                tileView1.ColumnSet.GroupColumn = tileView1.Columns("YearBuilt")
            Else
                tileView1.ColumnSet.GroupColumn = Nothing
            End If
        End Sub

        Private Sub SetupView()
            Try
                ' Setup tiles options
                tileView1.BeginUpdate()
                tileView1.OptionsTiles.RowCount = 3
                tileView1.OptionsTiles.Padding = New Padding(20)
                tileView1.OptionsTiles.ItemPadding = New Padding(10)
                tileView1.OptionsTiles.IndentBetweenItems = 20
                tileView1.OptionsTiles.ItemSize = New Size(340, 190)
                tileView1.Appearance.ItemNormal.ForeColor = Color.White
                tileView1.Appearance.ItemNormal.BorderColor = Color.Transparent
                'Setup tiles template
                Dim leftPanel As New TileViewItemElement()
                Dim splitLine As New TileViewItemElement()
                Dim addressCaption As New TileViewItemElement()
                Dim addressValue As New TileViewItemElement()
                Dim yearBuiltCaption As New TileViewItemElement()
                Dim yearBuiltValue As New TileViewItemElement()
                Dim price As New TileViewItemElement()
                Dim image As New TileViewItemElement()
                tileView1.TileTemplate.Add(leftPanel)
                tileView1.TileTemplate.Add(splitLine)
                tileView1.TileTemplate.Add(addressCaption)
                tileView1.TileTemplate.Add(addressValue)
                tileView1.TileTemplate.Add(yearBuiltCaption)
                tileView1.TileTemplate.Add(yearBuiltValue)
                tileView1.TileTemplate.Add(price)
                tileView1.TileTemplate.Add(image)
                '
                leftPanel.StretchVertical = True
                leftPanel.Width = 122
                leftPanel.TextLocation = New Point(-10, 0)
                leftPanel.Appearance.Normal.BackColor = Color.FromArgb(58, 166, 101)
                '
                splitLine.StretchVertical = True
                splitLine.Width = 3
                splitLine.TextAlignment = TileItemContentAlignment.Manual
                splitLine.TextLocation = New Point(110, 0)
                splitLine.Appearance.Normal.BackColor = Color.White
                '
                addressCaption.Text = "ADDRESS"
                addressCaption.TextAlignment = TileItemContentAlignment.TopLeft
                addressCaption.Appearance.Normal.FontSizeDelta = -1
                '
                addressValue.Column = tileView1.Columns("Address")
                addressValue.AnchorElement = addressCaption
                addressValue.AnchorIndent = 2
                addressValue.MaxWidth = 100
                addressValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold
                '
                yearBuiltCaption.Text = "YEAR BUILT"
                yearBuiltCaption.AnchorElement = addressValue
                yearBuiltCaption.AnchorIndent = 14
                yearBuiltCaption.Appearance.Normal.FontSizeDelta = -1
                '
                yearBuiltValue.Column = tileView1.Columns("YearBuilt")
                yearBuiltValue.AnchorElement = yearBuiltCaption
                yearBuiltValue.AnchorIndent = 2
                yearBuiltValue.Appearance.Normal.FontStyleDelta = FontStyle.Bold
                '
                price.Column = tileView1.Columns("PriceShort")
                price.TextAlignment = TileItemContentAlignment.BottomLeft
                price.Appearance.Normal.Font = New Font("Segoe UI Semilight", 25.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
                '
                image.Column = tileView1.Columns("Image")
                image.ImageSize = New Size(280, 220)
                image.ImageAlignment = TileItemContentAlignment.MiddleRight
                image.ImageScaleMode = TileItemImageScaleMode.ZoomOutside
                image.ImageLocation = New Point(10, 10)

            Finally
                tileView1.EndUpdate()
            End Try
        End Sub

        Protected Overridable Sub InitData()
            Try
                Dim homesTable = VideoCatalogDataSet().Tables("Homes")
                homesTable.Columns.Add("Image", GetType(Image))
                homesTable.Columns.Add("PriceShort", GetType(String))
                For Each row_Renamed As DataRow In homesTable.Rows
                    Dim img = DevExpress.XtraEditors.Controls.ByteImageConverter.FromByteArray(TryCast(row_Renamed("Photo"), Byte()))
                    row_Renamed("Image") = New Bitmap(img, New Size(351, 234))
                    Dim price As Decimal = DirectCast(row_Renamed("Price"), Decimal)
                    row_Renamed("PriceShort") = String.Format("${0}M", (price / 1000000).ToString("0.0"))
                Next row_Renamed
                gridControl1.DataSource = homesTable
            Catch
            End Try
        End Sub
        Private Function VideoCatalogDataSet() As DataSet
            Dim ds As New DataSet()
            Dim DBFileName As String = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\Homes.xml")
            If DBFileName <> String.Empty Then
                SetWaitDialogCaption(My.Resources.LoadingTables)
                ds.ReadXml(DBFileName)
            End If
            Return ds
        End Function

        Private colorPanelReady As Color = Color.FromArgb(58, 166, 101)
        Private colorPanelSold As Color = Color.FromArgb(158, 158, 158)
        Private colorCaptionReady As Color = Color.FromArgb(193, 222, 204)
        Private colorCaptionSold As Color = Color.FromArgb(219, 219, 219)


        Private Sub tileView1_ItemCustomize(ByVal sender As Object, ByVal e As TileViewItemCustomizeEventArgs) Handles tileView1.ItemCustomize
            If e.Item Is Nothing OrElse e.Item.Elements.Count = 0 Then
                Return
            End If
            Dim status As Integer = CInt((tileView1.GetRowCellValue(e.RowHandle, tileView1.Columns("Status"))))
            Dim panelColor As Color = colorPanelReady
            Dim captionColor As Color = colorCaptionReady
            If status = 1 Then
                panelColor = colorPanelSold
                captionColor = colorCaptionSold
                e.Item.Elements(6).Text = "Sold"
            End If
            e.Item.Elements(0).Appearance.Normal.BackColor = panelColor
            e.Item.Elements(2).Appearance.Normal.ForeColor = captionColor
            e.Item.Elements(4).Appearance.Normal.ForeColor = captionColor
        End Sub

        Private Sub tileView1_ItemClick(ByVal sender As Object, ByVal e As TileViewItemClickEventArgs)
            Dim address As String = tileView1.GetRowCellDisplayText(e.Item.RowHandle, tileView1.Columns("Address"))
            MessageBox.Show(String.Format("'{0}' item clicked", address))
        End Sub
    End Class
End Namespace
