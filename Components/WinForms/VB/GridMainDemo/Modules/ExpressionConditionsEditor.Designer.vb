Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ExpressionConditionsEditor
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ExpressionConditionsEditor))
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barMain = New DevExpress.XtraBars.Bar()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.FormatItemList = New DevExpress.XtraEditors.ListBoxControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.propertyGrid1 = New DevExpress.DXperience.Demos.XtraPropertyGrid()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FormatItemList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager1
            ' 
            Me.barManager1.AllowCustomization = False
            Me.barManager1.AllowQuickCustomization = False
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.barMain})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Images = Me.imageCollection1
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3})
            Me.barManager1.MainMenu = Me.barMain
            Me.barManager1.MaxItemId = 3
            ' 
            ' barMain
            ' 
            Me.barMain.BarName = "Main menu"
            Me.barMain.DockCol = 0
            Me.barMain.DockRow = 0
            Me.barMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.barMain.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2),
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3, True)
            })
            Me.barMain.OptionsBar.AllowQuickCustomization = False
            Me.barMain.OptionsBar.DisableCustomization = True
            Me.barMain.OptionsBar.DrawDragBorder = False
            Me.barMain.OptionsBar.DrawSizeGrip = True
            Me.barMain.OptionsBar.UseWholeRow = True
            resources.ApplyResources(Me.barMain, "barMain")
            ' 
            ' barButtonItem1
            ' 
            resources.ApplyResources(Me.barButtonItem1, "barButtonItem1")
            Me.barButtonItem1.Id = 0
            Me.barButtonItem1.ImageIndex = 0
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            resources.ApplyResources(Me.barButtonItem2, "barButtonItem2")
            Me.barButtonItem2.Id = 1
            Me.barButtonItem2.ImageIndex = 1
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            resources.ApplyResources(Me.barButtonItem3, "barButtonItem3")
            Me.barButtonItem3.Id = 2
            Me.barButtonItem3.ItemAppearance.Normal.Font = (CType(resources.GetObject("barButtonItem3.ItemAppearance.Normal.Font"), System.Drawing.Font))
            Me.barButtonItem3.ItemAppearance.Normal.Options.UseFont = True
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            resources.ApplyResources(Me.barDockControlTop, "barDockControlTop")
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            resources.ApplyResources(Me.barDockControlBottom, "barDockControlBottom")
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            resources.ApplyResources(Me.barDockControlLeft, "barDockControlLeft")
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            resources.ApplyResources(Me.barDockControlRight, "barDockControlRight")
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.imageCollection1.Images.SetKeyName(0, "add-16x16.png")
            Me.imageCollection1.Images.SetKeyName(1, "delete-16x16.png")
            ' 
            ' FormatItemList
            ' 
            Me.FormatItemList.Appearance.Options.UseTextOptions = True
            Me.FormatItemList.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.FormatItemList.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            resources.ApplyResources(Me.FormatItemList, "FormatItemList")
            Me.FormatItemList.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
            Me.FormatItemList.ItemHeight = 16
            Me.FormatItemList.Name = "FormatItemList"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AllowHtmlString = True
            resources.ApplyResources(Me.labelControl1, "labelControl1")
            Me.labelControl1.Name = "labelControl1"
            ' 
            ' propertyGrid1
            ' 
            resources.ApplyResources(Me.propertyGrid1, "propertyGrid1")
            Me.propertyGrid1.Name = "propertyGrid1"
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.AllowHtmlString = True
            resources.ApplyResources(Me.labelControl2, "labelControl2")
            Me.labelControl2.Name = "labelControl2"
            ' 
            ' checkEdit1
            ' 
            resources.ApplyResources(Me.checkEdit1, "checkEdit1")
            Me.checkEdit1.MenuManager = Me.barManager1
            Me.checkEdit1.Name = "checkEdit1"
            Me.checkEdit1.Properties.Caption = resources.GetString("checkEdit1.Properties.Caption")
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.imageComboBoxEdit1)
            Me.panelControl1.Controls.Add(Me.labelControl3)
            Me.panelControl1.Controls.Add(Me.checkEdit1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' imageComboBoxEdit1
            ' 
            resources.ApplyResources(Me.imageComboBoxEdit1, "imageComboBoxEdit1")
            Me.imageComboBoxEdit1.MenuManager = Me.barManager1
            Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
            Me.imageComboBoxEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
            Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("imageComboBoxEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            ' 
            ' labelControl3
            ' 
            resources.ApplyResources(Me.labelControl3, "labelControl3")
            Me.labelControl3.Name = "labelControl3"
            ' 
            ' ExpressionConditionsEditor
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.labelControl2)
            Me.Controls.Add(Me.FormatItemList)
            Me.Controls.Add(Me.labelControl1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "ExpressionConditionsEditor"
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FormatItemList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private barManager1 As DevExpress.XtraBars.BarManager
        Private barMain As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Private WithEvents barButtonItem3 As DevExpress.XtraBars.BarButtonItem
        Private imageCollection1 As DevExpress.Utils.ImageCollection
        Private WithEvents FormatItemList As DevExpress.XtraEditors.ListBoxControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private propertyGrid1 As DevExpress.DXperience.Demos.XtraPropertyGrid
        Private labelControl2 As DevExpress.XtraEditors.LabelControl
        Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
        Private labelControl3 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace
