Imports DevExpress.XtraEditors.Designer.Utils
Namespace DevExpress.XtraLayout.Demos
	Partial Public Class TechnoLayout
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
			Me.layoutControl3 = New DevExpress.XtraLayout.LayoutControl()
			Me.facesUserControl1 = New DevExpress.XtraLayout.Demos.Modules.TechnoLayout.FacesUserControl()
			Me.lcgMain = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
			Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
			Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
			Me.cheCustomizationMode = New DevExpress.XtraEditors.CheckEdit()
			Me.propertyGrid = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.ztbcSize = New DevExpress.XtraEditors.ZoomTrackBarControl()
			Me.ztbcSpacing = New DevExpress.XtraEditors.ZoomTrackBarControl()
			Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
			Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
			Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
			DirectCast(Me.layoutControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl3.SuspendLayout()
			DirectCast(Me.lcgMain, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.navigationPane1.SuspendLayout()
			Me.navigationPage1.SuspendLayout()
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.layoutControl1.SuspendLayout()
			DirectCast(Me.cheCustomizationMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.propertyGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ztbcSize, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ztbcSize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ztbcSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.ztbcSpacing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' layoutControl3
			' 
			Me.layoutControl3.AutoScroll = False
			Me.layoutControl3.Controls.Add(Me.facesUserControl1)
			Me.layoutControl3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl3.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl3.Name = "layoutControl3"
			Me.layoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(332, 256, 892, 743)
			Me.layoutControl3.OptionsView.AlwaysScrollActiveControlIntoView = False
			Me.layoutControl3.Root = Me.lcgMain
			Me.layoutControl3.Size = New System.Drawing.Size(618, 650)
			Me.layoutControl3.TabIndex = 2
			Me.layoutControl3.Text = "layoutControl3"
			' 
			' facesUserControl1
			' 
			Me.facesUserControl1.Location = New System.Drawing.Point(0, 0)
			Me.facesUserControl1.Name = "facesUserControl1"
			Me.facesUserControl1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
			Me.facesUserControl1.Size = New System.Drawing.Size(618, 650)
			Me.facesUserControl1.TabIndex = 26
			' 
			' lcgMain
			' 
			Me.lcgMain.CustomizationFormText = "Root"
			Me.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.lcgMain.GroupBordersVisible = False
			Me.lcgMain.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1})
			Me.lcgMain.Location = New System.Drawing.Point(0, 0)
			Me.lcgMain.Name = "Root"
			Me.lcgMain.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.lcgMain.Size = New System.Drawing.Size(618, 650)
			Me.lcgMain.TextVisible = False
			' 
			' layoutControlItem1
			' 
			Me.layoutControlItem1.Control = Me.facesUserControl1
			Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
			Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem1.Name = "layoutControlItem1"
			Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlItem1.Size = New System.Drawing.Size(618, 650)
			Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem1.TextVisible = False
			' 
			' navigationPane1
			' 
			Me.navigationPane1.Controls.Add(Me.navigationPage1)
			Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
			Me.navigationPane1.Location = New System.Drawing.Point(618, 0)
			Me.navigationPane1.Name = "navigationPane1"
			Me.navigationPane1.PageProperties.ShowExpandButton = False
			Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image
			Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1})
			Me.navigationPane1.RegularSize = New System.Drawing.Size(358, 650)
			Me.navigationPane1.SelectedPage = Me.navigationPage1
			Me.navigationPane1.Size = New System.Drawing.Size(358, 650)
			Me.navigationPane1.TabIndex = 27
			Me.navigationPane1.Text = "navigationPane1"
			' 
			' navigationPage1
			' 
			Me.navigationPage1.Caption = "Options"
			Me.navigationPage1.Controls.Add(Me.layoutControl1)
			Me.navigationPage1.ImageUri.Uri = "Properties;Size16x16;Office2013"
			Me.navigationPage1.Name = "navigationPage1"
			Me.navigationPage1.Size = New System.Drawing.Size(308, 590)
			' 
			' layoutControl1
			' 
			Me.layoutControl1.Controls.Add(Me.cheCustomizationMode)
			Me.layoutControl1.Controls.Add(Me.propertyGrid)
			Me.layoutControl1.Controls.Add(Me.ztbcSize)
			Me.layoutControl1.Controls.Add(Me.ztbcSpacing)
			Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControl1.Name = "layoutControl1"
			Me.layoutControl1.Root = Me.layoutControlGroup1
			Me.layoutControl1.Size = New System.Drawing.Size(308, 590)
			Me.layoutControl1.TabIndex = 0
			Me.layoutControl1.Text = "layoutControl1"
			' 
			' cheCustomizationMode
			' 
			Me.cheCustomizationMode.EditValue = True
			Me.cheCustomizationMode.Location = New System.Drawing.Point(2, 2)
			Me.cheCustomizationMode.Name = "cheCustomizationMode"
			Me.cheCustomizationMode.Properties.Caption = "Customization Mode"
			Me.cheCustomizationMode.Size = New System.Drawing.Size(304, 19)
			Me.cheCustomizationMode.StyleController = Me.layoutControl1
			Me.cheCustomizationMode.TabIndex = 25
'			Me.cheCustomizationMode.CheckedChanged += New System.EventHandler(Me.cheCustomizationMode_CheckedChanged)
			' 
			' propertyGrid
			' 
			Me.propertyGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.propertyGrid.Location = New System.Drawing.Point(2, 101)
			Me.propertyGrid.Name = "propertyGrid"
			Me.propertyGrid.Size = New System.Drawing.Size(304, 487)
			Me.propertyGrid.TabIndex = 24
			' 
			' ztbcSize
			' 
			Me.ztbcSize.EditValue = 150
			Me.ztbcSize.Location = New System.Drawing.Point(2, 41)
			Me.ztbcSize.Name = "ztbcSize"
			Me.ztbcSize.Properties.LargeChange = 10
			Me.ztbcSize.Properties.Maximum = 250
			Me.ztbcSize.Properties.Middle = 150
			Me.ztbcSize.Properties.Minimum = 50
			Me.ztbcSize.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.ztbcSize.Properties.SmallChange = 10
			Me.ztbcSize.Size = New System.Drawing.Size(304, 23)
			Me.ztbcSize.StyleController = Me.layoutControl1
			Me.ztbcSize.TabIndex = 4
			Me.ztbcSize.Value = 150
'			Me.ztbcSize.EditValueChanged += New System.EventHandler(Me.zoomTrackBarControl1_EditValueChanged)
			' 
			' ztbcSpacing
			' 
			Me.ztbcSpacing.EditValue = 15
			Me.ztbcSpacing.Location = New System.Drawing.Point(2, 79)
			Me.ztbcSpacing.Name = "ztbcSpacing"
			Me.ztbcSpacing.Properties.Maximum = 30
			Me.ztbcSpacing.Properties.Middle = 15
			Me.ztbcSpacing.Properties.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.ztbcSpacing.Size = New System.Drawing.Size(304, 23)
			Me.ztbcSpacing.StyleController = Me.layoutControl1
			Me.ztbcSpacing.TabIndex = 5
			Me.ztbcSpacing.Value = 15
'			Me.ztbcSpacing.EditValueChanged += New System.EventHandler(Me.zoomTrackBarControl2_EditValueChanged)
			' 
			' layoutControlGroup1
			' 
			Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
			Me.layoutControlGroup1.GroupBordersVisible = False
			Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5})
			Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlGroup1.Name = "layoutControlGroup1"
			Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
			Me.layoutControlGroup1.Size = New System.Drawing.Size(308, 590)
			Me.layoutControlGroup1.TextVisible = False
			' 
			' layoutControlItem2
			' 
			Me.layoutControlItem2.Control = Me.cheCustomizationMode
			Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
			Me.layoutControlItem2.Name = "layoutControlItem2"
			Me.layoutControlItem2.Size = New System.Drawing.Size(308, 23)
			Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem2.TextVisible = False
			' 
			' layoutControlItem3
			' 
			Me.layoutControlItem3.Control = Me.ztbcSize
			Me.layoutControlItem3.Location = New System.Drawing.Point(0, 23)
			Me.layoutControlItem3.Name = "layoutControlItem3"
			Me.layoutControlItem3.Size = New System.Drawing.Size(308, 38)
			Me.layoutControlItem3.Text = "Size:"
			Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
			Me.layoutControlItem3.TextSize = New System.Drawing.Size(37, 13)
			' 
			' layoutControlItem4
			' 
			Me.layoutControlItem4.Control = Me.ztbcSpacing
			Me.layoutControlItem4.Location = New System.Drawing.Point(0, 61)
			Me.layoutControlItem4.Name = "layoutControlItem4"
			Me.layoutControlItem4.Size = New System.Drawing.Size(308, 38)
			Me.layoutControlItem4.Text = "Spacing"
			Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
			Me.layoutControlItem4.TextSize = New System.Drawing.Size(37, 13)
			' 
			' layoutControlItem5
			' 
			Me.layoutControlItem5.Control = Me.propertyGrid
			Me.layoutControlItem5.Location = New System.Drawing.Point(0, 99)
			Me.layoutControlItem5.Name = "layoutControlItem5"
			Me.layoutControlItem5.Size = New System.Drawing.Size(308, 491)
			Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
			Me.layoutControlItem5.TextVisible = False
			' 
			' TechnoLayout
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.layoutControl3)
			Me.Controls.Add(Me.navigationPane1)
			Me.Name = "TechnoLayout"
			Me.Size = New System.Drawing.Size(976, 650)
			DirectCast(Me.layoutControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl3.ResumeLayout(False)
			DirectCast(Me.lcgMain, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.navigationPane1.ResumeLayout(False)
			Me.navigationPage1.ResumeLayout(False)
			DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.layoutControl1.ResumeLayout(False)
			DirectCast(Me.cheCustomizationMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.propertyGrid, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ztbcSize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ztbcSize, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ztbcSpacing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.ztbcSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private propertyGrid As XtraVerticalGrid.PropertyGridControl
		Private layoutControl3 As LayoutControl
		Private lcgMain As LayoutControlGroup
		Private WithEvents ztbcSpacing As XtraEditors.ZoomTrackBarControl
		Private WithEvents ztbcSize As XtraEditors.ZoomTrackBarControl
		Private WithEvents cheCustomizationMode As XtraEditors.CheckEdit
		Private facesUserControl1 As Modules.TechnoLayout.FacesUserControl
		Private layoutControlItem1 As LayoutControlItem
		Private navigationPane1 As XtraBars.Navigation.NavigationPane
		Private navigationPage1 As XtraBars.Navigation.NavigationPage
		Private layoutControl1 As LayoutControl
		Private layoutControlGroup1 As LayoutControlGroup
		Private layoutControlItem2 As LayoutControlItem
		Private layoutControlItem3 As LayoutControlItem
		Private layoutControlItem4 As LayoutControlItem
		Private layoutControlItem5 As LayoutControlItem
	End Class
End Namespace
