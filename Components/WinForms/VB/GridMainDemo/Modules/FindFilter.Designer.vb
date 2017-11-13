﻿Namespace DevExpress.XtraGrid.Demos
    Partial Public Class FindFilter
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(FindFilter))
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
            Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ucFindOptions1 = New DevExpress.XtraGrid.Demos.ucFindOptions()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            DirectCast(Me.layoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
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
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.HorzScrollStep = 30
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.PreviewFieldName = "Address"
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
            Me.colAddress.Name = "colAddress"
            ' 
            ' colCity
            ' 
            resources.ApplyResources(Me.colCity, "colCity")
            Me.colCity.FieldName = "City"
            Me.colCity.Name = "colCity"
            Me.colCity.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
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
            Me.repositoryItemComboBox1.DropDownRows = 12
            Me.repositoryItemComboBox1.Items.AddRange(New Object() { resources.GetString("repositoryItemComboBox1.Items"), resources.GetString("repositoryItemComboBox1.Items1"), resources.GetString("repositoryItemComboBox1.Items2"), resources.GetString("repositoryItemComboBox1.Items3"), resources.GetString("repositoryItemComboBox1.Items4"), resources.GetString("repositoryItemComboBox1.Items5"), resources.GetString("repositoryItemComboBox1.Items6"), resources.GetString("repositoryItemComboBox1.Items7"), resources.GetString("repositoryItemComboBox1.Items8"), resources.GetString("repositoryItemComboBox1.Items9"), resources.GetString("repositoryItemComboBox1.Items10"), resources.GetString("repositoryItemComboBox1.Items11"), resources.GetString("repositoryItemComboBox1.Items12"), resources.GetString("repositoryItemComboBox1.Items13"), resources.GetString("repositoryItemComboBox1.Items14"), resources.GetString("repositoryItemComboBox1.Items15"), resources.GetString("repositoryItemComboBox1.Items16"), resources.GetString("repositoryItemComboBox1.Items17")})
            Me.repositoryItemComboBox1.LookAndFeel.SkinName = "Money Twins"
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' colPostalCode
            ' 
            resources.ApplyResources(Me.colPostalCode, "colPostalCode")
            Me.colPostalCode.FieldName = "PostalCode"
            Me.colPostalCode.Name = "colPostalCode"
            ' 
            ' colCountry
            ' 
            resources.ApplyResources(Me.colCountry, "colCountry")
            Me.colCountry.ColumnEdit = Me.repositoryItemComboBox2
            Me.colCountry.FieldName = "Country"
            Me.colCountry.Name = "colCountry"
            Me.colCountry.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
            ' 
            ' repositoryItemComboBox2
            ' 
            resources.ApplyResources(Me.repositoryItemComboBox2, "repositoryItemComboBox2")
            Me.repositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("repositoryItemComboBox2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.repositoryItemComboBox2.DropDownRows = 12
            Me.repositoryItemComboBox2.Items.AddRange(New Object() { resources.GetString("repositoryItemComboBox2.Items"), resources.GetString("repositoryItemComboBox2.Items1"), resources.GetString("repositoryItemComboBox2.Items2"), resources.GetString("repositoryItemComboBox2.Items3"), resources.GetString("repositoryItemComboBox2.Items4"), resources.GetString("repositoryItemComboBox2.Items5"), resources.GetString("repositoryItemComboBox2.Items6"), resources.GetString("repositoryItemComboBox2.Items7"), resources.GetString("repositoryItemComboBox2.Items8"), resources.GetString("repositoryItemComboBox2.Items9"), resources.GetString("repositoryItemComboBox2.Items10"), resources.GetString("repositoryItemComboBox2.Items11"), resources.GetString("repositoryItemComboBox2.Items12"), resources.GetString("repositoryItemComboBox2.Items13"), resources.GetString("repositoryItemComboBox2.Items14"), resources.GetString("repositoryItemComboBox2.Items15"), resources.GetString("repositoryItemComboBox2.Items16"), resources.GetString("repositoryItemComboBox2.Items17"), resources.GetString("repositoryItemComboBox2.Items18"), resources.GetString("repositoryItemComboBox2.Items19"), resources.GetString("repositoryItemComboBox2.Items20")})
            Me.repositoryItemComboBox2.LookAndFeel.SkinName = "Money Twins"
            Me.repositoryItemComboBox2.Name = "repositoryItemComboBox2"
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
            ' ucFindOptions1
            ' 
            resources.ApplyResources(Me.ucFindOptions1, "ucFindOptions1")
            Me.ucFindOptions1.Name = "ucFindOptions1"
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
            Me.navigationPane1.RegularSize = New System.Drawing.Size(266, 493)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.SelectedPageIndex = 0
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl2)
            Me.navigationPage1.Image = (DirectCast(resources.GetObject("navigationPage1.Image"), System.Drawing.Image))
            Me.navigationPage1.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.ucFindOptions1)
            resources.ApplyResources(Me.layoutControl2, "layoutControl2")
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl2.Root = Me.layoutControlGroup2
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "Root"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(216, 433)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ucFindOptions1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(196, 413)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' FindFilter
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "FindFilter"
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            DirectCast(Me.layoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private repositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
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
        Private gridControl1 As GridControl
        Private ucFindOptions1 As ucFindOptions
        Private navigationPane1 As XtraBars.Navigation.NavigationPane
        Private navigationPage1 As XtraBars.Navigation.NavigationPage
        Private layoutControl2 As XtraLayout.LayoutControl
        Private layoutControlGroup2 As XtraLayout.LayoutControlGroup
        Private layoutControlItem3 As XtraLayout.LayoutControlItem
        Private panelControl1 As XtraEditors.PanelControl
    End Class
End Namespace
