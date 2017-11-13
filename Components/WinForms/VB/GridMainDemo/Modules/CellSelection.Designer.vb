Namespace DevExpress.XtraGrid.Demos
    Partial Public Class CellSelection
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CellSelection))
            Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
            Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRegion = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colPostalCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.icbSelectMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbTranslucentColors = New DevExpress.XtraEditors.CheckEdit()
            Me.sbRecords = New DevExpress.XtraEditors.SimpleButton()
            Me.ceMultiSelect = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.repositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbSelectMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.icbTranslucentColors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceMultiSelect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' colCountry
            ' 
            resources.ApplyResources(Me.colCountry, "colCountry")
            Me.colCountry.ColumnEdit = Me.repositoryItemComboBox2
            Me.colCountry.FieldName = "Country"
            Me.colCountry.Name = "colCountry"
            ' 
            ' repositoryItemComboBox2
            ' 
            resources.ApplyResources(Me.repositoryItemComboBox2, "repositoryItemComboBox2")
            Me.repositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemComboBox2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemComboBox2.Items.AddRange(New Object() { resources.GetString("repositoryItemComboBox2.Items"), resources.GetString("repositoryItemComboBox2.Items1"), resources.GetString("repositoryItemComboBox2.Items2"), resources.GetString("repositoryItemComboBox2.Items3"), resources.GetString("repositoryItemComboBox2.Items4"), resources.GetString("repositoryItemComboBox2.Items5"), resources.GetString("repositoryItemComboBox2.Items6"), resources.GetString("repositoryItemComboBox2.Items7"), resources.GetString("repositoryItemComboBox2.Items8"), resources.GetString("repositoryItemComboBox2.Items9"), resources.GetString("repositoryItemComboBox2.Items10"), resources.GetString("repositoryItemComboBox2.Items11"), resources.GetString("repositoryItemComboBox2.Items12"), resources.GetString("repositoryItemComboBox2.Items13"), resources.GetString("repositoryItemComboBox2.Items14"), resources.GetString("repositoryItemComboBox2.Items15"), resources.GetString("repositoryItemComboBox2.Items16"), resources.GetString("repositoryItemComboBox2.Items17"), resources.GetString("repositoryItemComboBox2.Items18"), resources.GetString("repositoryItemComboBox2.Items19"), resources.GetString("repositoryItemComboBox2.Items20")})
            Me.repositoryItemComboBox2.Name = "repositoryItemComboBox2"
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1, Me.repositoryItemComboBox2})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax})
            styleFormatCondition1.Appearance.BackColor = (DirectCast(resources.GetObject("resource.BackColor"), System.Drawing.Color))
            styleFormatCondition1.Appearance.BackColor2 = (DirectCast(resources.GetObject("resource.BackColor2"), System.Drawing.Color))
            styleFormatCondition1.Appearance.ForeColor = (DirectCast(resources.GetObject("resource.ForeColor"), System.Drawing.Color))
            styleFormatCondition1.Appearance.GradientMode = (DirectCast(resources.GetObject("resource.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
            styleFormatCondition1.Appearance.Options.UseBackColor = True
            styleFormatCondition1.Appearance.Options.UseForeColor = True
            styleFormatCondition1.Column = Me.colCountry
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Between
            styleFormatCondition1.Value1 = "U"
            styleFormatCondition1.Value2 = "V"
            Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.HorzScrollStep = 30
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' colCustomerID
            ' 
            resources.ApplyResources(Me.colCustomerID, "colCustomerID")
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            Me.colCustomerID.OptionsFilter.AllowFilter = False
            ' 
            ' colCompanyName
            ' 
            resources.ApplyResources(Me.colCompanyName, "colCompanyName")
            Me.colCompanyName.FieldName = "CompanyName"
            Me.colCompanyName.Name = "colCompanyName"
            Me.colCompanyName.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((DirectCast(resources.GetObject("colCompanyName.Summary"), DevExpress.Data.SummaryItemType)))})
            ' 
            ' colContactName
            ' 
            resources.ApplyResources(Me.colContactName, "colContactName")
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.Image = My.Resources.contact_16x16
            Me.colContactName.Name = "colContactName"
            ' 
            ' colContactTitle
            ' 
            resources.ApplyResources(Me.colContactTitle, "colContactTitle")
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            ' 
            ' colAddress
            ' 
            resources.ApplyResources(Me.colAddress, "colAddress")
            Me.colAddress.FieldName = "Address"
            Me.colAddress.Image = (DirectCast(resources.GetObject("colAddress.Image"), System.Drawing.Image))
            Me.colAddress.Name = "colAddress"
            ' 
            ' colCity
            ' 
            resources.ApplyResources(Me.colCity, "colCity")
            Me.colCity.FieldName = "City"
            Me.colCity.Name = "colCity"
            ' 
            ' colRegion
            ' 
            resources.ApplyResources(Me.colRegion, "colRegion")
            Me.colRegion.ColumnEdit = Me.repositoryItemComboBox1
            Me.colRegion.FieldName = "Region"
            Me.colRegion.Name = "colRegion"
            ' 
            ' repositoryItemComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemComboBox1, "repositoryItemComboBox1")
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() { resources.GetString("repositoryItemComboBox1.Items"), resources.GetString("repositoryItemComboBox1.Items1"), resources.GetString("repositoryItemComboBox1.Items2"), resources.GetString("repositoryItemComboBox1.Items3"), resources.GetString("repositoryItemComboBox1.Items4"), resources.GetString("repositoryItemComboBox1.Items5"), resources.GetString("repositoryItemComboBox1.Items6"), resources.GetString("repositoryItemComboBox1.Items7"), resources.GetString("repositoryItemComboBox1.Items8"), resources.GetString("repositoryItemComboBox1.Items9"), resources.GetString("repositoryItemComboBox1.Items10"), resources.GetString("repositoryItemComboBox1.Items11"), resources.GetString("repositoryItemComboBox1.Items12"), resources.GetString("repositoryItemComboBox1.Items13"), resources.GetString("repositoryItemComboBox1.Items14"), resources.GetString("repositoryItemComboBox1.Items15"), resources.GetString("repositoryItemComboBox1.Items16"), resources.GetString("repositoryItemComboBox1.Items17")})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' colPostalCode
            ' 
            resources.ApplyResources(Me.colPostalCode, "colPostalCode")
            Me.colPostalCode.FieldName = "PostalCode"
            Me.colPostalCode.Name = "colPostalCode"
            ' 
            ' colPhone
            ' 
            resources.ApplyResources(Me.colPhone, "colPhone")
            Me.colPhone.FieldName = "Phone"
            Me.colPhone.Name = "colPhone"
            ' 
            ' colFax
            ' 
            resources.ApplyResources(Me.colFax, "colFax")
            Me.colFax.FieldName = "Fax"
            Me.colFax.Name = "colFax"
            ' 
            ' icbSelectMode
            ' 
            resources.ApplyResources(Me.icbSelectMode, "icbSelectMode")
            Me.icbSelectMode.Name = "icbSelectMode"
            Me.icbSelectMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("icbSelectMode.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.icbSelectMode.StyleController = Me.layoutControl1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.icbTranslucentColors)
            Me.layoutControl1.Controls.Add(Me.sbRecords)
            Me.layoutControl1.Controls.Add(Me.icbSelectMode)
            Me.layoutControl1.Controls.Add(Me.ceMultiSelect)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' icbTranslucentColors
            ' 
            resources.ApplyResources(Me.icbTranslucentColors, "icbTranslucentColors")
            Me.icbTranslucentColors.Name = "icbTranslucentColors"
            Me.icbTranslucentColors.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
            Me.icbTranslucentColors.Properties.Appearance.Options.UseTextOptions = True
            Me.icbTranslucentColors.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.icbTranslucentColors.Properties.AutoHeight = (DirectCast(resources.GetObject("icbTranslucentColors.Properties.AutoHeight"), Boolean))
            Me.icbTranslucentColors.Properties.Caption = resources.GetString("icbTranslucentColors.Properties.Caption")
            Me.icbTranslucentColors.StyleController = Me.layoutControl1
            ' 
            ' sbRecords
            ' 
            resources.ApplyResources(Me.sbRecords, "sbRecords")
            Me.sbRecords.Name = "sbRecords"
            Me.sbRecords.StyleController = Me.layoutControl1
            ' 
            ' ceMultiSelect
            ' 
            resources.ApplyResources(Me.ceMultiSelect, "ceMultiSelect")
            Me.ceMultiSelect.Name = "ceMultiSelect"
            Me.ceMultiSelect.Properties.Caption = resources.GetString("ceMultiSelect.Properties.Caption")
            Me.ceMultiSelect.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.emptySpaceItem1, Me.layoutControlItem4, Me.emptySpaceItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(237, 413)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceMultiSelect
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(217, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbSelectMode
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(217, 24)
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.sbRecords
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 367)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(217, 26)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 103)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(217, 264)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.icbTranslucentColors
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 60)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(217, 43)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 47)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(217, 13)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(287, 473)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.SelectedPageIndex = 0
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Selection Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Image = (DirectCast(resources.GetObject("navigationPage1.Image"), System.Drawing.Image))
            Me.navigationPage1.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' CellSelection
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "CellSelection"
            DirectCast(Me.repositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbSelectMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.icbTranslucentColors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceMultiSelect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private components As System.ComponentModel.IContainer = Nothing
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
        Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn
        Private colContactName As DevExpress.XtraGrid.Columns.GridColumn
        Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn
        Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
        Private colCity As DevExpress.XtraGrid.Columns.GridColumn
        Private colRegion As DevExpress.XtraGrid.Columns.GridColumn
        Private colPostalCode As DevExpress.XtraGrid.Columns.GridColumn
        Private colCountry As DevExpress.XtraGrid.Columns.GridColumn
        Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
        Private colFax As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private repositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private WithEvents sbRecords As DevExpress.XtraEditors.SimpleButton
        Private WithEvents icbSelectMode As DevExpress.XtraEditors.ImageComboBoxEdit
        Private WithEvents icbTranslucentColors As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceMultiSelect As DevExpress.XtraEditors.CheckEdit
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private panelControl1 As XtraEditors.PanelControl
    End Class
End Namespace
