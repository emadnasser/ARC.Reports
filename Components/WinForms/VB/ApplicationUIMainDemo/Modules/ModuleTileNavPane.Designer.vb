Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class ModuleTileNavPane
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ModuleTileNavPane))
			Dim tileItemElement19 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement20 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement21 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement22 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement23 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement24 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement32 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement27 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement25 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement26 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement28 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement29 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement30 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement31 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement33 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement34 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement35 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement36 As New DevExpress.XtraEditors.TileItemElement()
			Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
			Me.xtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
			Me.tileNavPane = New DevExpress.XtraBars.Navigation.TileNavPane()
			Me.navButtonHome = New DevExpress.XtraBars.Navigation.NavButton()
			Me.navButtonMain = New DevExpress.XtraBars.Navigation.NavButton()
			Me.catCreateNew = New DevExpress.XtraBars.Navigation.TileNavCategory()
			Me.tileNavItem6 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.tileNavItem7 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.tileNavItem8 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.tileNavItem9 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.tileNavItem10 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.tileNavItem11 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.navButtonSettings = New DevExpress.XtraBars.Navigation.NavButton()
			Me.navButtonHelp = New DevExpress.XtraBars.Navigation.NavButton()
			Me.catSales = New DevExpress.XtraBars.Navigation.TileNavCategory()
			Me.tileNavItem1 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.tileNavSubItem1 = New DevExpress.XtraBars.Navigation.TileNavSubItem()
			Me.tileNavSubItem2 = New DevExpress.XtraBars.Navigation.TileNavSubItem()
			Me.tileNavItem2 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.tileNavItem3 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.tileNavItem4 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.tileNavItem5 = New DevExpress.XtraBars.Navigation.TileNavItem()
			Me.catServices = New DevExpress.XtraBars.Navigation.TileNavCategory()
			Me.catMarketing = New DevExpress.XtraBars.Navigation.TileNavCategory()
			Me.catSettings = New DevExpress.XtraBars.Navigation.TileNavCategory()
			Me.catHelp = New DevExpress.XtraBars.Navigation.TileNavCategory()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.seDropDownHeight = New DevExpress.XtraEditors.SpinEdit()
			Me.ceOuterClick = New DevExpress.XtraEditors.CheckEdit()
			Me.ceItemShadow = New DevExpress.XtraEditors.CheckEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.cbDock = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.eventsLog = New DevExpress.XtraEditors.MemoEdit()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btnClearEventLog = New DevExpress.XtraEditors.SimpleButton()
			Me.panelContainer = New System.Windows.Forms.Panel()
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraTabControl1.SuspendLayout()
			Me.xtraTabPage1.SuspendLayout()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.seDropDownHeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceOuterClick.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceItemShadow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbDock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.eventsLog.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			Me.panelContainer.SuspendLayout()
			Me.SuspendLayout()
			' 
			' xtraTabControl1
			' 
			Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xtraTabControl1.Location = New System.Drawing.Point(0, 0)
			Me.xtraTabControl1.Name = "xtraTabControl1"
			Me.xtraTabControl1.SelectedTabPage = Me.xtraTabPage1
			Me.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.xtraTabControl1.Size = New System.Drawing.Size(784, 432)
			Me.xtraTabControl1.TabIndex = 0
			Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.xtraTabPage1})
			' 
			' xtraTabPage1
			' 
			Me.xtraTabPage1.Controls.Add(Me.panelContainer)
			Me.xtraTabPage1.Controls.Add(Me.tileNavPane)
			Me.xtraTabPage1.Name = "xtraTabPage1"
			Me.xtraTabPage1.Size = New System.Drawing.Size(778, 426)
			Me.xtraTabPage1.Text = "xtraTabPage1"
			' 
			' tileNavPane
			' 
			Me.tileNavPane.AllowGlyphSkinning = True
			Me.tileNavPane.ButtonPadding = New System.Windows.Forms.Padding(12)
			Me.tileNavPane.Buttons.Add(Me.navButtonHome)
			Me.tileNavPane.Buttons.Add(Me.navButtonMain)
			Me.tileNavPane.Buttons.Add(Me.catCreateNew)
			Me.tileNavPane.Buttons.Add(Me.navButtonSettings)
			Me.tileNavPane.Buttons.Add(Me.navButtonHelp)
			Me.tileNavPane.Categories.AddRange(New DevExpress.XtraBars.Navigation.TileNavCategory() { Me.catSales, Me.catServices, Me.catMarketing, Me.catSettings, Me.catHelp})
			' 
			' tileNavCategory1
			' 
			Me.tileNavPane.DefaultCategory.Name = "tileNavCategory1"
			Me.tileNavPane.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavPane.DefaultCategory.OwnerCollection = Nothing
			' 
			' 
			' 
			Me.tileNavPane.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			Me.tileNavPane.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavPane.Dock = System.Windows.Forms.DockStyle.Top
			Me.tileNavPane.Location = New System.Drawing.Point(0, 0)
			Me.tileNavPane.Name = "tileNavPane"
			Me.tileNavPane.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavPane.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavPane.Size = New System.Drawing.Size(778, 40)
			Me.tileNavPane.TabIndex = 0
			Me.tileNavPane.Text = "tileNavPane"
'			Me.tileNavPane.TileClick += New DevExpress.XtraBars.Navigation.NavElementClickEventHandler(Me.tileNavPane_TileClick);
'			Me.tileNavPane.SelectedElementChanged += New DevExpress.XtraBars.Navigation.TileNavPaneElementEventHandler(Me.tileNavPane_SelectedElementChanged);
			' 
			' navButtonHome
			' 
			Me.navButtonHome.Caption = ""
			Me.navButtonHome.Glyph = (CType(resources.GetObject("navButtonHome.Glyph"), System.Drawing.Image))
			Me.navButtonHome.Name = "navButtonHome"
'			Me.navButtonHome.ElementClick += New DevExpress.XtraBars.Navigation.NavElementClickEventHandler(Me.navButtonHome_ElementClick);
			' 
			' navButtonMain
			' 
			Me.navButtonMain.Caption = "DevExpress CRM"
			Me.navButtonMain.IsMain = True
			Me.navButtonMain.Name = "navButtonMain"
			' 
			' catCreateNew
			' 
			Me.catCreateNew.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
			Me.catCreateNew.Caption = "Create"
			Me.catCreateNew.Glyph = (CType(resources.GetObject("catCreateNew.Glyph"), System.Drawing.Image))
			Me.catCreateNew.Items.AddRange(New DevExpress.XtraBars.Navigation.TileNavItem() { Me.tileNavItem6, Me.tileNavItem7, Me.tileNavItem8, Me.tileNavItem9, Me.tileNavItem10, Me.tileNavItem11})
			Me.catCreateNew.Name = "catCreateNew"
			Me.catCreateNew.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.catCreateNew.OwnerCollection = Nothing
			' 
			' 
			' 
			Me.catCreateNew.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			Me.catCreateNew.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			' 
			' tileNavItem6
			' 
			Me.tileNavItem6.Caption = "Phone Call"
			Me.tileNavItem6.GroupName = "Activities"
			Me.tileNavItem6.Name = "tileNavItem6"
			Me.tileNavItem6.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem6.OwnerCollection = Me.catCreateNew.Items
			' 
			' 
			' 
			Me.tileNavItem6.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement19.Image = (CType(resources.GetObject("tileItemElement19.Image"), System.Drawing.Image))
			tileItemElement19.Text = "Phone Call"
			Me.tileNavItem6.Tile.Elements.Add(tileItemElement19)
			Me.tileNavItem6.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
			Me.tileNavItem6.Tile.Name = "tileBarItem1"
			' 
			' tileNavItem7
			' 
			Me.tileNavItem7.Caption = "E-mail"
			Me.tileNavItem7.GroupName = "Activities"
			Me.tileNavItem7.Name = "tileNavItem7"
			Me.tileNavItem7.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem7.OwnerCollection = Me.catCreateNew.Items
			' 
			' 
			' 
			Me.tileNavItem7.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(0))))))
			Me.tileNavItem7.Tile.AppearanceItem.Normal.Options.UseBackColor = True
			Me.tileNavItem7.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement20.Image = (CType(resources.GetObject("tileItemElement20.Image"), System.Drawing.Image))
			tileItemElement20.Text = "E-mail"
			Me.tileNavItem7.Tile.Elements.Add(tileItemElement20)
			Me.tileNavItem7.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
			Me.tileNavItem7.Tile.Name = "tileBarItem2"
			' 
			' tileNavItem8
			' 
			Me.tileNavItem8.Caption = "Task"
			Me.tileNavItem8.GroupName = "Activities"
			Me.tileNavItem8.Name = "tileNavItem8"
			Me.tileNavItem8.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem8.OwnerCollection = Me.catCreateNew.Items
			' 
			' 
			' 
			Me.tileNavItem8.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(133))))), (CInt(Fix((CByte(153))))))
			Me.tileNavItem8.Tile.AppearanceItem.Normal.Options.UseBackColor = True
			Me.tileNavItem8.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement21.Image = (CType(resources.GetObject("tileItemElement21.Image"), System.Drawing.Image))
			tileItemElement21.Text = "Task"
			Me.tileNavItem8.Tile.Elements.Add(tileItemElement21)
			Me.tileNavItem8.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium
			Me.tileNavItem8.Tile.Name = "tileBarItem3"
			' 
			' tileNavItem9
			' 
			Me.tileNavItem9.Caption = "Account"
			Me.tileNavItem9.GroupName = "Records"
			Me.tileNavItem9.Name = "tileNavItem9"
			Me.tileNavItem9.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem9.OwnerCollection = Me.catCreateNew.Items
			' 
			' 
			' 
			Me.tileNavItem9.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement22.Image = (CType(resources.GetObject("tileItemElement22.Image"), System.Drawing.Image))
			tileItemElement22.Text = "Account"
			Me.tileNavItem9.Tile.Elements.Add(tileItemElement22)
			Me.tileNavItem9.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavItem9.Tile.Name = "tileBarItem1"
			' 
			' tileNavItem10
			' 
			Me.tileNavItem10.Caption = "Case"
			Me.tileNavItem10.GroupName = "Records"
			Me.tileNavItem10.Name = "tileNavItem10"
			Me.tileNavItem10.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem10.OwnerCollection = Me.catCreateNew.Items
			' 
			' 
			' 
			Me.tileNavItem10.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement23.Image = (CType(resources.GetObject("tileItemElement23.Image"), System.Drawing.Image))
			tileItemElement23.Text = "Case"
			Me.tileNavItem10.Tile.Elements.Add(tileItemElement23)
			Me.tileNavItem10.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavItem10.Tile.Name = "tileBarItem2"
			' 
			' tileNavItem11
			' 
			Me.tileNavItem11.Caption = "Contact"
			Me.tileNavItem11.GroupName = "Records"
			Me.tileNavItem11.Name = "tileNavItem11"
			Me.tileNavItem11.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem11.OwnerCollection = Me.catCreateNew.Items
			' 
			' 
			' 
			Me.tileNavItem11.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement24.Image = (CType(resources.GetObject("tileItemElement24.Image"), System.Drawing.Image))
			tileItemElement24.Text = "Contact"
			Me.tileNavItem11.Tile.Elements.Add(tileItemElement24)
			Me.tileNavItem11.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavItem11.Tile.Name = "tileBarItem3"
			' 
			' navButtonSettings
			' 
			Me.navButtonSettings.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
			Me.navButtonSettings.Caption = ""
			Me.navButtonSettings.Glyph = (CType(resources.GetObject("navButtonSettings.Glyph"), System.Drawing.Image))
			Me.navButtonSettings.Name = "navButtonSettings"
'			Me.navButtonSettings.ElementClick += New DevExpress.XtraBars.Navigation.NavElementClickEventHandler(Me.navButtonSettings_ElementClick);
			' 
			' navButtonHelp
			' 
			Me.navButtonHelp.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right
			Me.navButtonHelp.Caption = ""
			Me.navButtonHelp.Glyph = (CType(resources.GetObject("navButtonHelp.Glyph"), System.Drawing.Image))
			Me.navButtonHelp.Name = "navButtonHelp"
'			Me.navButtonHelp.ElementClick += New DevExpress.XtraBars.Navigation.NavElementClickEventHandler(Me.navButtonHelp_ElementClick);
			' 
			' catSales
			' 
			Me.catSales.Caption = "Sales"
			Me.catSales.Items.AddRange(New DevExpress.XtraBars.Navigation.TileNavItem() { Me.tileNavItem1, Me.tileNavItem2, Me.tileNavItem3, Me.tileNavItem4, Me.tileNavItem5})
			Me.catSales.Name = "catSales"
			Me.catSales.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.catSales.OwnerCollection = Me.tileNavPane.Categories
			' 
			' 
			' 
			Me.catSales.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement32.Image = (CType(resources.GetObject("tileItemElement32.Image"), System.Drawing.Image))
			tileItemElement32.Text = "Sales"
			Me.catSales.Tile.Elements.Add(tileItemElement32)
			Me.catSales.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.catSales.Tile.Name = "tileBarItem2"
			' 
			' tileNavItem1
			' 
			Me.tileNavItem1.Caption = "Dashboards"
			Me.tileNavItem1.GroupName = "My Work"
			Me.tileNavItem1.Name = "tileNavItem1"
			Me.tileNavItem1.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem1.OwnerCollection = Me.catSales.Items
			Me.tileNavItem1.SubItems.AddRange(New DevExpress.XtraBars.Navigation.TileNavSubItem() { Me.tileNavSubItem1, Me.tileNavSubItem2})
			' 
			' 
			' 
			Me.tileNavItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement27.Image = (CType(resources.GetObject("tileItemElement27.Image"), System.Drawing.Image))
			tileItemElement27.Text = "Dashboards"
			Me.tileNavItem1.Tile.Elements.Add(tileItemElement27)
			Me.tileNavItem1.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavItem1.Tile.Name = "tileBarItem1"
			' 
			' tileNavSubItem1
			' 
			Me.tileNavSubItem1.Caption = "Marketing Dashboard"
			Me.tileNavSubItem1.Name = "tileNavSubItem1"
			Me.tileNavSubItem1.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			' 
			' 
			' 
			Me.tileNavSubItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement25.Image = (CType(resources.GetObject("tileItemElement25.Image"), System.Drawing.Image))
			tileItemElement25.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
			tileItemElement25.Text = "Marketing Dashboard"
			Me.tileNavSubItem1.Tile.Elements.Add(tileItemElement25)
			Me.tileNavSubItem1.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavSubItem1.Tile.Name = "tileBarItem1"
			' 
			' tileNavSubItem2
			' 
			Me.tileNavSubItem2.Caption = "Social Dashboard"
			Me.tileNavSubItem2.Name = "tileNavSubItem2"
			Me.tileNavSubItem2.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			' 
			' 
			' 
			Me.tileNavSubItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement26.Image = (CType(resources.GetObject("tileItemElement26.Image"), System.Drawing.Image))
			tileItemElement26.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight
			tileItemElement26.Text = "Social Dashboard"
			Me.tileNavSubItem2.Tile.Elements.Add(tileItemElement26)
			Me.tileNavSubItem2.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavSubItem2.Tile.Name = "tileBarItem2"
			' 
			' tileNavItem2
			' 
			Me.tileNavItem2.Caption = "What's new"
			Me.tileNavItem2.Name = "tileNavItem2"
			Me.tileNavItem2.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem2.OwnerCollection = Me.catSales.Items
			' 
			' 
			' 
			Me.tileNavItem2.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(0))))), (CInt(Fix((CByte(133))))), (CInt(Fix((CByte(153))))))
			Me.tileNavItem2.Tile.AppearanceItem.Normal.Options.UseBackColor = True
			Me.tileNavItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement28.Image = (CType(resources.GetObject("tileItemElement28.Image"), System.Drawing.Image))
			tileItemElement28.Text = "What's new"
			Me.tileNavItem2.Tile.Elements.Add(tileItemElement28)
			Me.tileNavItem2.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavItem2.Tile.Name = "tileBarItem2"
			' 
			' tileNavItem3
			' 
			Me.tileNavItem3.Caption = "Activities"
			Me.tileNavItem3.Name = "tileNavItem3"
			Me.tileNavItem3.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem3.OwnerCollection = Me.catSales.Items
			' 
			' 
			' 
			Me.tileNavItem3.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(82))))), (CInt(Fix((CByte(82))))), (CInt(Fix((CByte(82))))))
			Me.tileNavItem3.Tile.AppearanceItem.Normal.Options.UseBackColor = True
			Me.tileNavItem3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement29.Image = (CType(resources.GetObject("tileItemElement29.Image"), System.Drawing.Image))
			tileItemElement29.Text = "Activities"
			Me.tileNavItem3.Tile.Elements.Add(tileItemElement29)
			Me.tileNavItem3.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavItem3.Tile.Name = "tileBarItem3"
			' 
			' tileNavItem4
			' 
			Me.tileNavItem4.Caption = "Accounts"
			Me.tileNavItem4.Name = "tileNavItem4"
			Me.tileNavItem4.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem4.OwnerCollection = Me.catSales.Items
			' 
			' 
			' 
			Me.tileNavItem4.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(0))))))
			Me.tileNavItem4.Tile.AppearanceItem.Normal.Options.UseBackColor = True
			Me.tileNavItem4.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement30.Image = (CType(resources.GetObject("tileItemElement30.Image"), System.Drawing.Image))
			tileItemElement30.Text = "Accounts"
			Me.tileNavItem4.Tile.Elements.Add(tileItemElement30)
			Me.tileNavItem4.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavItem4.Tile.Name = "tileBarItem4"
			' 
			' tileNavItem5
			' 
			Me.tileNavItem5.Caption = "Contacts"
			Me.tileNavItem5.Name = "tileNavItem5"
			Me.tileNavItem5.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.tileNavItem5.OwnerCollection = Me.catSales.Items
			' 
			' 
			' 
			Me.tileNavItem5.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(62))))), (CInt(Fix((CByte(112))))), (CInt(Fix((CByte(56))))))
			Me.tileNavItem5.Tile.AppearanceItem.Normal.Options.UseBackColor = True
			Me.tileNavItem5.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement31.Image = (CType(resources.GetObject("tileItemElement31.Image"), System.Drawing.Image))
			tileItemElement31.Text = "Contacts"
			Me.tileNavItem5.Tile.Elements.Add(tileItemElement31)
			Me.tileNavItem5.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.tileNavItem5.Tile.Name = "tileBarItem5"
			' 
			' catServices
			' 
			Me.catServices.Caption = "Services"
			Me.catServices.Name = "catServices"
			Me.catServices.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.catServices.OwnerCollection = Me.tileNavPane.Categories
			' 
			' 
			' 
			Me.catServices.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement33.Image = (CType(resources.GetObject("tileItemElement33.Image"), System.Drawing.Image))
			tileItemElement33.Text = "Services"
			Me.catServices.Tile.Elements.Add(tileItemElement33)
			Me.catServices.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.catServices.Tile.Name = "tileBarItem3"
			' 
			' catMarketing
			' 
			Me.catMarketing.Caption = "Marketing"
			Me.catMarketing.Name = "catMarketing"
			Me.catMarketing.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.catMarketing.OwnerCollection = Me.tileNavPane.Categories
			' 
			' 
			' 
			Me.catMarketing.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement34.Image = (CType(resources.GetObject("tileItemElement34.Image"), System.Drawing.Image))
			tileItemElement34.Text = "Marketing"
			Me.catMarketing.Tile.Elements.Add(tileItemElement34)
			Me.catMarketing.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.catMarketing.Tile.Name = "tileBarItem4"
			' 
			' catSettings
			' 
			Me.catSettings.Caption = "Settings"
			Me.catSettings.Name = "catSettings"
			Me.catSettings.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.catSettings.OwnerCollection = Me.tileNavPane.Categories
			' 
			' 
			' 
			Me.catSettings.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement35.Image = (CType(resources.GetObject("tileItemElement35.Image"), System.Drawing.Image))
			tileItemElement35.Text = "Settings"
			Me.catSettings.Tile.Elements.Add(tileItemElement35)
			Me.catSettings.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.catSettings.Tile.Name = "tileBarItem5"
			' 
			' catHelp
			' 
			Me.catHelp.Caption = "Help"
			Me.catHelp.Name = "catHelp"
			Me.catHelp.OptionsDropDown.BackColor = System.Drawing.Color.Empty
			Me.catHelp.OwnerCollection = Me.tileNavPane.Categories
			' 
			' 
			' 
			Me.catHelp.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
			tileItemElement36.Image = (CType(resources.GetObject("tileItemElement36.Image"), System.Drawing.Image))
			tileItemElement36.Text = "Help"
			Me.catHelp.Tile.Elements.Add(tileItemElement36)
			Me.catHelp.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default
			Me.catHelp.Tile.Name = "tileBarItem6"
			' 
			' groupControl2
			' 
			Me.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl2.Appearance.Options.UseBackColor = True
			Me.groupControl2.Controls.Add(Me.labelControl2)
			Me.groupControl2.Controls.Add(Me.seDropDownHeight)
			Me.groupControl2.Controls.Add(Me.ceOuterClick)
			Me.groupControl2.Controls.Add(Me.ceItemShadow)
			Me.groupControl2.Controls.Add(Me.labelControl1)
			Me.groupControl2.Controls.Add(Me.cbDock)
			Me.groupControl2.Location = New System.Drawing.Point(3, 3)
			Me.groupControl2.Name = "groupControl2"
			Me.groupControl2.Padding = New System.Windows.Forms.Padding(8)
			Me.groupControl2.Size = New System.Drawing.Size(242, 198)
			Me.groupControl2.TabIndex = 16
			Me.groupControl2.Text = "Options"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(13, 131)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(90, 13)
			Me.labelControl2.TabIndex = 5
			Me.labelControl2.Text = "Drop-down height:"
			' 
			' seDropDownHeight
			' 
			Me.seDropDownHeight.EditValue = New Decimal(New Integer() { 120, 0, 0, 0})
			Me.seDropDownHeight.Location = New System.Drawing.Point(119, 128)
			Me.seDropDownHeight.Name = "seDropDownHeight"
			Me.seDropDownHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.seDropDownHeight.Properties.IsFloatValue = False
			Me.seDropDownHeight.Properties.Mask.EditMask = "N00"
			Me.seDropDownHeight.Properties.MaxValue = New Decimal(New Integer() { 500, 0, 0, 0})
			Me.seDropDownHeight.Properties.MinValue = New Decimal(New Integer() { 120, 0, 0, 0})
			Me.seDropDownHeight.Size = New System.Drawing.Size(100, 20)
			Me.seDropDownHeight.TabIndex = 4
'			Me.seDropDownHeight.EditValueChanged += New System.EventHandler(Me.seDropDownHeight_EditValueChanged);
			' 
			' ceOuterClick
			' 
			Me.ceOuterClick.EditValue = True
			Me.ceOuterClick.Location = New System.Drawing.Point(13, 64)
			Me.ceOuterClick.Name = "ceOuterClick"
			Me.ceOuterClick.Properties.Caption = "Close drop-down on outer mouse click"
			Me.ceOuterClick.Size = New System.Drawing.Size(206, 15)
			Me.ceOuterClick.TabIndex = 3
'			Me.ceOuterClick.CheckedChanged += New System.EventHandler(Me.ceOuterClick_CheckedChanged);
			' 
			' ceItemShadow
			' 
			Me.ceItemShadow.Location = New System.Drawing.Point(13, 32)
			Me.ceItemShadow.Name = "ceItemShadow"
			Me.ceItemShadow.Properties.Caption = "Show tile shadow"
			Me.ceItemShadow.Size = New System.Drawing.Size(180, 15)
			Me.ceItemShadow.TabIndex = 2
'			Me.ceItemShadow.CheckedChanged += New System.EventHandler(Me.ceItemShadow_CheckedChanged);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(13, 99)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(27, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Dock:"
			' 
			' cbDock
			' 
			Me.cbDock.EditValue = "Top"
			Me.cbDock.Location = New System.Drawing.Point(119, 96)
			Me.cbDock.Name = "cbDock"
			Me.cbDock.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbDock.Properties.Items.AddRange(New Object() { "Top", "Bottom"})
			Me.cbDock.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbDock.Size = New System.Drawing.Size(100, 20)
			Me.cbDock.TabIndex = 0
'			Me.cbDock.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEdit1_SelectedIndexChanged);
			' 
			' groupControl1
			' 
			Me.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.groupControl1.Appearance.Options.UseBackColor = True
			Me.groupControl1.Controls.Add(Me.eventsLog)
			Me.groupControl1.Controls.Add(Me.panelControl1)
			Me.groupControl1.Location = New System.Drawing.Point(251, 3)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Padding = New System.Windows.Forms.Padding(8)
			Me.groupControl1.Size = New System.Drawing.Size(328, 198)
			Me.groupControl1.TabIndex = 15
			Me.groupControl1.Text = "Event log"
			' 
			' eventsLog
			' 
			Me.eventsLog.Dock = System.Windows.Forms.DockStyle.Fill
			Me.eventsLog.EditValue = ""
			Me.eventsLog.Location = New System.Drawing.Point(10, 29)
			Me.eventsLog.Name = "eventsLog"
			Me.eventsLog.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
			Me.eventsLog.Properties.Appearance.ForeColor = System.Drawing.SystemColors.InfoText
			Me.eventsLog.Properties.Appearance.Options.UseBackColor = True
			Me.eventsLog.Properties.Appearance.Options.UseForeColor = True
			Me.eventsLog.Properties.ReadOnly = True
			Me.eventsLog.Size = New System.Drawing.Size(308, 112)
			Me.eventsLog.TabIndex = 0
			Me.eventsLog.TabStop = False
			Me.eventsLog.UseOptimizedRendering = True
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl1.Controls.Add(Me.btnClearEventLog)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(10, 141)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(308, 47)
			Me.panelControl1.TabIndex = 9
			' 
			' btnClearEventLog
			' 
			Me.btnClearEventLog.Location = New System.Drawing.Point(228, 12)
			Me.btnClearEventLog.Name = "btnClearEventLog"
			Me.btnClearEventLog.Size = New System.Drawing.Size(80, 23)
			Me.btnClearEventLog.TabIndex = 8
			Me.btnClearEventLog.Text = "Clear log"
'			Me.btnClearEventLog.Click += New System.EventHandler(Me.btnClearEventLog_Click);
			' 
			' panelContainer
			' 
			Me.panelContainer.Controls.Add(Me.groupControl2)
			Me.panelContainer.Controls.Add(Me.groupControl1)
			Me.panelContainer.Location = New System.Drawing.Point(100, 134)
			Me.panelContainer.Name = "panelContainer"
			Me.panelContainer.Size = New System.Drawing.Size(581, 204)
			Me.panelContainer.TabIndex = 17
			' 
			' ModuleTileNavPane
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraTabControl1)
			Me.Name = "ModuleTileNavPane"
			CType(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraTabControl1.ResumeLayout(False)
			Me.xtraTabPage1.ResumeLayout(False)
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			Me.groupControl2.PerformLayout()
			CType(Me.seDropDownHeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceOuterClick.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceItemShadow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbDock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.eventsLog.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelContainer.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xtraTabControl1 As XtraTab.XtraTabControl
		Private xtraTabPage1 As XtraTab.XtraTabPage
		Private WithEvents tileNavPane As XtraBars.Navigation.TileNavPane
		Private navButtonMain As XtraBars.Navigation.NavButton
		Private catSales As XtraBars.Navigation.TileNavCategory
		Private catServices As XtraBars.Navigation.TileNavCategory
		Private catMarketing As XtraBars.Navigation.TileNavCategory
		Private catHelp As XtraBars.Navigation.TileNavCategory
		Private tileNavItem1 As XtraBars.Navigation.TileNavItem
		Private tileNavItem2 As XtraBars.Navigation.TileNavItem
		Private tileNavItem3 As XtraBars.Navigation.TileNavItem
		Private tileNavItem4 As XtraBars.Navigation.TileNavItem
		Private tileNavItem5 As XtraBars.Navigation.TileNavItem
		Private catSettings As XtraBars.Navigation.TileNavCategory
		Private tileNavSubItem1 As XtraBars.Navigation.TileNavSubItem
		Private tileNavSubItem2 As XtraBars.Navigation.TileNavSubItem
		Private WithEvents navButtonHome As XtraBars.Navigation.NavButton
		Private catCreateNew As XtraBars.Navigation.TileNavCategory
		Private WithEvents navButtonSettings As XtraBars.Navigation.NavButton
		Private WithEvents navButtonHelp As XtraBars.Navigation.NavButton
		Private tileNavItem6 As XtraBars.Navigation.TileNavItem
		Private tileNavItem7 As XtraBars.Navigation.TileNavItem
		Private tileNavItem8 As XtraBars.Navigation.TileNavItem
		Private tileNavItem9 As XtraBars.Navigation.TileNavItem
		Private tileNavItem10 As XtraBars.Navigation.TileNavItem
		Private tileNavItem11 As XtraBars.Navigation.TileNavItem
		Private groupControl1 As XtraEditors.GroupControl
		Private eventsLog As XtraEditors.MemoEdit
		Private panelControl1 As XtraEditors.PanelControl
		Private WithEvents btnClearEventLog As XtraEditors.SimpleButton
		Private groupControl2 As XtraEditors.GroupControl
		Private WithEvents cbDock As XtraEditors.ComboBoxEdit
		Private labelControl1 As XtraEditors.LabelControl
		Private WithEvents ceOuterClick As XtraEditors.CheckEdit
		Private WithEvents ceItemShadow As XtraEditors.CheckEdit
		Private WithEvents seDropDownHeight As XtraEditors.SpinEdit
		Private labelControl2 As XtraEditors.LabelControl
		Private panelContainer As System.Windows.Forms.Panel
	End Class
End Namespace
