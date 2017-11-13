Namespace DevExpress.XtraGrid.Demos
    Partial Public Class RowHeight
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(RowHeight))
            Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            Me.colFirstName1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastName1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitle1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitleOfCourtesy1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.colBirthDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHireDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHomePhone1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.colPhoto1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHireDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHomePhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitleOfCourtesy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.sbSwitching = New DevExpress.XtraEditors.SimpleButton()
            Me.chePicture = New DevExpress.XtraEditors.CheckEdit()
            Me.cheMemo = New DevExpress.XtraEditors.CheckEdit()
            Me.cheAutoHeight = New DevExpress.XtraEditors.CheckEdit()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chePicture.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cheMemo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cheAutoHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' cardView1
            ' 
            resources.ApplyResources(Me.cardView1, "cardView1")
            Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colFirstName1, Me.colLastName1, Me.colTitle1, Me.colTitleOfCourtesy1, Me.colBirthDate1, Me.colHireDate1, Me.colHomePhone1, Me.colNotes1, Me.colPhoto1})
            Me.cardView1.FocusedCardTopFieldIndex = 0
            Me.cardView1.GridControl = Me.gridControl1
            Me.cardView1.MaximumCardColumns = 2
            Me.cardView1.Name = "cardView1"
            Me.cardView1.OptionsBehavior.AutoHorzWidth = True
            Me.cardView1.OptionsBehavior.FieldAutoHeight = True
            Me.cardView1.OptionsView.ShowLines = False
            Me.cardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
            ' 
            ' colFirstName1
            ' 
            resources.ApplyResources(Me.colFirstName1, "colFirstName1")
            Me.colFirstName1.FieldName = "FirstName"
            Me.colFirstName1.Name = "colFirstName1"
            ' 
            ' colLastName1
            ' 
            resources.ApplyResources(Me.colLastName1, "colLastName1")
            Me.colLastName1.FieldName = "LastName"
            Me.colLastName1.Name = "colLastName1"
            ' 
            ' colTitle1
            ' 
            resources.ApplyResources(Me.colTitle1, "colTitle1")
            Me.colTitle1.FieldName = "Title"
            Me.colTitle1.Name = "colTitle1"
            ' 
            ' colTitleOfCourtesy1
            ' 
            resources.ApplyResources(Me.colTitleOfCourtesy1, "colTitleOfCourtesy1")
            Me.colTitleOfCourtesy1.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colTitleOfCourtesy1.FieldName = "TitleOfCourtesy"
            Me.colTitleOfCourtesy1.Name = "colTitleOfCourtesy1"
            Me.colTitleOfCourtesy1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemImageComboBox1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), resources.GetString("repositoryItemImageComboBox1.Items1"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items2"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), resources.GetString("repositoryItemImageComboBox1.Items4"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items5"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), resources.GetString("repositoryItemImageComboBox1.Items7"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items8"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), resources.GetString("repositoryItemImageComboBox1.Items10"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items11"), Integer))),
                New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), resources.GetString("repositoryItemImageComboBox1.Items13"), (DirectCast(resources.GetObject("repositoryItemImageComboBox1.Items14"), Integer)))
            })
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox1.SmallImages = Me.imageCollection1
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (DirectCast(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imageCollection1.Images.SetKeyName(0, "Doctor.png")
            Me.imageCollection1.Images.SetKeyName(1, "Miss.png")
            Me.imageCollection1.Images.SetKeyName(2, "Mr.png")
            Me.imageCollection1.Images.SetKeyName(3, "Mrs.png")
            Me.imageCollection1.Images.SetKeyName(4, "Ms.png")
            ' 
            ' colBirthDate1
            ' 
            resources.ApplyResources(Me.colBirthDate1, "colBirthDate1")
            Me.colBirthDate1.FieldName = "BirthDate"
            Me.colBirthDate1.Name = "colBirthDate1"
            ' 
            ' colHireDate1
            ' 
            resources.ApplyResources(Me.colHireDate1, "colHireDate1")
            Me.colHireDate1.FieldName = "HireDate"
            Me.colHireDate1.Name = "colHireDate1"
            ' 
            ' colHomePhone1
            ' 
            resources.ApplyResources(Me.colHomePhone1, "colHomePhone1")
            Me.colHomePhone1.FieldName = "HomePhone"
            Me.colHomePhone1.Name = "colHomePhone1"
            ' 
            ' colNotes1
            ' 
            Me.colNotes1.AppearanceCell.Options.UseTextOptions = True
            Me.colNotes1.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            resources.ApplyResources(Me.colNotes1, "colNotes1")
            Me.colNotes1.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes1.FieldName = "Notes"
            Me.colNotes1.Name = "colNotes1"
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' colPhoto1
            ' 
            resources.ApplyResources(Me.colPhoto1, "colPhoto1")
            Me.colPhoto1.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto1.FieldName = "Photo"
            Me.colPhoto1.Name = "colPhoto1"
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.CustomHeight = 40
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            gridLevelNode1.LevelTemplate = Me.cardView1
            gridLevelNode1.RelationName = "Card"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMemoEdit1, Me.repositoryItemPictureEdit1, Me.repositoryItemImageComboBox1})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.cardView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colBirthDate, Me.colFirstName, Me.colHireDate, Me.colHomePhone, Me.colLastName, Me.colNotes, Me.colPhoto, Me.colTitle, Me.colTitleOfCourtesy})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.RowAutoHeight = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            ' 
            ' colBirthDate
            ' 
            resources.ApplyResources(Me.colBirthDate, "colBirthDate")
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.Name = "colBirthDate"
            ' 
            ' colFirstName
            ' 
            resources.ApplyResources(Me.colFirstName, "colFirstName")
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            ' 
            ' colHireDate
            ' 
            resources.ApplyResources(Me.colHireDate, "colHireDate")
            Me.colHireDate.FieldName = "HireDate"
            Me.colHireDate.Name = "colHireDate"
            ' 
            ' colHomePhone
            ' 
            resources.ApplyResources(Me.colHomePhone, "colHomePhone")
            Me.colHomePhone.FieldName = "HomePhone"
            Me.colHomePhone.Name = "colHomePhone"
            ' 
            ' colLastName
            ' 
            resources.ApplyResources(Me.colLastName, "colLastName")
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            ' 
            ' colNotes
            ' 
            Me.colNotes.AppearanceCell.Options.UseTextOptions = True
            Me.colNotes.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            resources.ApplyResources(Me.colNotes, "colNotes")
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.OptionsFilter.AllowFilter = False
            ' 
            ' colPhoto
            ' 
            resources.ApplyResources(Me.colPhoto, "colPhoto")
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.FixedWidth = True
            Me.colPhoto.OptionsFilter.AllowFilter = False
            ' 
            ' colTitle
            ' 
            resources.ApplyResources(Me.colTitle, "colTitle")
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            ' 
            ' colTitleOfCourtesy
            ' 
            resources.ApplyResources(Me.colTitleOfCourtesy, "colTitleOfCourtesy")
            Me.colTitleOfCourtesy.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colTitleOfCourtesy.FieldName = "TitleOfCourtesy"
            Me.colTitleOfCourtesy.Name = "colTitleOfCourtesy"
            Me.colTitleOfCourtesy.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            ' 
            ' sbSwitching
            ' 
            resources.ApplyResources(Me.sbSwitching, "sbSwitching")
            Me.sbSwitching.Name = "sbSwitching"
            Me.sbSwitching.StyleController = Me.layoutControl1
            ' 
            ' chePicture
            ' 
            resources.ApplyResources(Me.chePicture, "chePicture")
            Me.chePicture.Name = "chePicture"
            Me.chePicture.Properties.Caption = resources.GetString("chePicture.Properties.Caption")
            Me.chePicture.StyleController = Me.layoutControl1
            ' 
            ' cheMemo
            ' 
            resources.ApplyResources(Me.cheMemo, "cheMemo")
            Me.cheMemo.Name = "cheMemo"
            Me.cheMemo.Properties.Caption = resources.GetString("cheMemo.Properties.Caption")
            Me.cheMemo.StyleController = Me.layoutControl1
            ' 
            ' cheAutoHeight
            ' 
            resources.ApplyResources(Me.cheAutoHeight, "cheAutoHeight")
            Me.cheAutoHeight.Name = "cheAutoHeight"
            Me.cheAutoHeight.Properties.Caption = resources.GetString("cheAutoHeight.Properties.Caption")
            Me.cheAutoHeight.StyleController = Me.layoutControl1
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
            Me.navigationPane1.RegularSize = New System.Drawing.Size(250, 481)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.SelectedPageIndex = 0
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Image = (DirectCast(resources.GetObject("navigationPage1.Image"), System.Drawing.Image))
            Me.navigationPage1.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.sbSwitching)
            Me.layoutControl1.Controls.Add(Me.cheAutoHeight)
            Me.layoutControl1.Controls.Add(Me.chePicture)
            Me.layoutControl1.Controls.Add(Me.cheMemo)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.layoutControlItem4})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(200, 421)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cheAutoHeight
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(180, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.cheMemo
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 35)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(180, 23)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.chePicture
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(180, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 81)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(180, 294)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 23)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(180, 12)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.sbSwitching
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 375)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(180, 26)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' RowHeight
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "RowHeight"
            DirectCast(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chePicture.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cheMemo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cheAutoHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private colHireDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colHomePhone As DevExpress.XtraGrid.Columns.GridColumn
        Private colBirthDate As DevExpress.XtraGrid.Columns.GridColumn
        Private colTitle As DevExpress.XtraGrid.Columns.GridColumn
        Private colTitleOfCourtesy As DevExpress.XtraGrid.Columns.GridColumn
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
        Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
        Private colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
        Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Private colFirstName1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colLastName1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colTitle1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colTitleOfCourtesy1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colBirthDate1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colHireDate1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colHomePhone1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colNotes1 As DevExpress.XtraGrid.Columns.GridColumn
        Private colPhoto1 As DevExpress.XtraGrid.Columns.GridColumn
        Private WithEvents cheAutoHeight As DevExpress.XtraEditors.CheckEdit
        Private WithEvents cheMemo As DevExpress.XtraEditors.CheckEdit
        Private WithEvents chePicture As DevExpress.XtraEditors.CheckEdit
        Private WithEvents sbSwitching As DevExpress.XtraEditors.SimpleButton
        Private components As System.ComponentModel.IContainer
        Private imageCollection1 As DevExpress.Utils.ImageCollection
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private layoutControl1 As XtraLayout.LayoutControl
        Private layoutControlGroup1 As XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As XtraLayout.LayoutControlItem
        Private layoutControlItem2 As XtraLayout.LayoutControlItem
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private layoutControlItem4 As XtraLayout.LayoutControlItem
        Private panelControl1 As XtraEditors.PanelControl
    End Class
End Namespace
