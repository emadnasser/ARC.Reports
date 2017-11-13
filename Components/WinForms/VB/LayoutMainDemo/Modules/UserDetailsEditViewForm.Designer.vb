Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraEditors
Namespace DevExpress.XtraLayout.Demos
	Public Partial Class UserDetailsEditViewForm
		Inherits TutorialControl
		Private WithEvents dataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
		Private layoutControlGroup1 As LayoutControlGroup
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private dateEdit1 As DevExpress.XtraEditors.DateEdit
		Private textEdit3 As DevExpress.XtraEditors.TextEdit
		Private textEdit4 As DevExpress.XtraEditors.TextEdit
		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private textEdit5 As DevExpress.XtraEditors.TextEdit
		Private textEdit6 As DevExpress.XtraEditors.TextEdit
		Private dateEdit2 As DevExpress.XtraEditors.DateEdit
		Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
		Private textEdit7 As DevExpress.XtraEditors.TextEdit
		Private textEdit9 As DevExpress.XtraEditors.TextEdit
		Private textEdit10 As DevExpress.XtraEditors.TextEdit
		Private spinEdit2 As DevExpress.XtraEditors.SpinEdit
		Private textEdit11 As DevExpress.XtraEditors.TextEdit
        Private layoutControlItem6 As LayoutControlItem
		Private layoutControlItem15 As LayoutControlItem
		Private layoutControlItem7 As LayoutControlItem
		Private layoutControlItem9 As LayoutControlItem
		Private layoutControlItem10 As LayoutControlItem
		Private layoutControlItem18 As LayoutControlItem
		Private layoutControlItem11 As LayoutControlItem
		Private layoutControlItem8 As LayoutControlItem
		Private layoutControlItem3 As LayoutControlItem
		Private layoutControlItem16 As LayoutControlItem
		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private layoutControlItem20 As LayoutControlItem
		Private layoutControlItem19 As LayoutControlItem
		Private emptySpaceItem1 As EmptySpaceItem
		Private emptySpaceItem2 As EmptySpaceItem
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
		Private layoutControlItem12 As LayoutControlItem
		Private xpCollection1 As DevExpress.Xpo.XPCollection
		Private Sub InitializeComponent()
            Me.xpCollection1 = New DevExpress.Xpo.XPCollection
            Me.dataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator
            Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
            Me.textEdit2 = New DevExpress.XtraEditors.TextEdit
            Me.dateEdit1 = New DevExpress.XtraEditors.DateEdit
            Me.textEdit3 = New DevExpress.XtraEditors.TextEdit
            Me.textEdit4 = New DevExpress.XtraEditors.TextEdit
            Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit
            Me.textEdit5 = New DevExpress.XtraEditors.TextEdit
            Me.textEdit6 = New DevExpress.XtraEditors.TextEdit
            Me.dateEdit2 = New DevExpress.XtraEditors.DateEdit
            Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit
            Me.textEdit7 = New DevExpress.XtraEditors.TextEdit
            Me.textEdit9 = New DevExpress.XtraEditors.TextEdit
            Me.textEdit10 = New DevExpress.XtraEditors.TextEdit
            Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit
            Me.textEdit11 = New DevExpress.XtraEditors.TextEdit
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem
            Me.ItemForPostalCode = New DevExpress.XtraLayout.LayoutControlItem
            Me.ItemForCountry = New DevExpress.XtraLayout.LayoutControlItem
            Me.ItemForRegion = New DevExpress.XtraLayout.LayoutControlItem
            Me.ItemForCity = New DevExpress.XtraLayout.LayoutControlItem
            Me.ItemForAddress = New DevExpress.XtraLayout.LayoutControlItem
            CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataLayoutControl1.SuspendLayout()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForPostalCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForCountry, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForRegion, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForCity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'xpCollection1
            '
            Me.xpCollection1.DisplayableProperties = "Address;BirthDate;City;Country;EmployeeID;Extension;FirstName;HireDate;HomePhone;" & _
                "LastName;Notes;PostalCode;Region;ReportsTo;Title;TitleOfCourtesy"
            Me.xpCollection1.ObjectType = GetType(DevExpress.XtraLayout.Demos.DBObjects.Employees)
            '
            'dataLayoutControl1
            '
            Me.dataLayoutControl1.Controls.Add(Me.memoEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.dataNavigator1)
            Me.dataLayoutControl1.Controls.Add(Me.simpleButton2)
            Me.dataLayoutControl1.Controls.Add(Me.labelControl1)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit2)
            Me.dataLayoutControl1.Controls.Add(Me.dateEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit3)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit4)
            Me.dataLayoutControl1.Controls.Add(Me.spinEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit5)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit6)
            Me.dataLayoutControl1.Controls.Add(Me.dateEdit2)
            Me.dataLayoutControl1.Controls.Add(Me.hyperLinkEdit1)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit7)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit9)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit10)
            Me.dataLayoutControl1.Controls.Add(Me.spinEdit2)
            Me.dataLayoutControl1.Controls.Add(Me.textEdit11)
            Me.dataLayoutControl1.DataSource = Me.xpCollection1
            Me.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dataLayoutControl1.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem15})
            Me.dataLayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.dataLayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.dataLayoutControl1.Name = "dataLayoutControl1"
            Me.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-1231, 189, 450, 350)
            Me.dataLayoutControl1.Root = Me.layoutControlGroup1
            Me.dataLayoutControl1.Size = New System.Drawing.Size(653, 657)
            Me.dataLayoutControl1.TabIndex = 0
            Me.dataLayoutControl1.Text = "dataLayoutControl1"
            '
            'memoEdit1
            '
            Me.memoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Notes", True))
            Me.memoEdit1.Location = New System.Drawing.Point(6, 256)
            Me.memoEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(641, 304)
            Me.memoEdit1.StyleController = Me.dataLayoutControl1
            Me.memoEdit1.TabIndex = 25
            '
            'dataNavigator1
            '
            Me.dataNavigator1.DataSource = Me.xpCollection1
            Me.dataNavigator1.Location = New System.Drawing.Point(6, 628)
            Me.dataNavigator1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.dataNavigator1.Name = "dataNavigator1"
            Me.dataNavigator1.Size = New System.Drawing.Size(256, 19)
            Me.dataNavigator1.StyleController = Me.dataLayoutControl1
            Me.dataNavigator1.TabIndex = 24
            Me.dataNavigator1.Text = "dataNavigator1"
            '
            'simpleButton2
            '
            Me.simpleButton2.Location = New System.Drawing.Point(551, 628)
            Me.simpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.simpleButton2.Name = "simpleButton2"
            Me.simpleButton2.Size = New System.Drawing.Size(96, 23)
            Me.simpleButton2.StyleController = Me.dataLayoutControl1
            Me.simpleButton2.TabIndex = 23
            Me.simpleButton2.Text = "Edit Data"
            '
            'labelControl1
            '
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Location = New System.Drawing.Point(6, 6)
            Me.labelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(641, 29)
            Me.labelControl1.StyleController = Me.dataLayoutControl1
            Me.labelControl1.TabIndex = 21
            Me.labelControl1.Text = "User details"
            '
            'textEdit2
            '
            Me.textEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Address", True))
            Me.textEdit2.Location = New System.Drawing.Point(78, 173)
            Me.textEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.textEdit2.Name = "textEdit2"
            Me.textEdit2.Size = New System.Drawing.Size(569, 22)
            Me.textEdit2.StyleController = Me.dataLayoutControl1
            Me.textEdit2.TabIndex = 5
            '
            'dateEdit1
            '
            Me.dateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "BirthDate", True))
            Me.dateEdit1.EditValue = Nothing
            Me.dateEdit1.Location = New System.Drawing.Point(404, 77)
            Me.dateEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.dateEdit1.Name = "dateEdit1"
            Me.dateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.dateEdit1.Size = New System.Drawing.Size(243, 22)
            Me.dateEdit1.StyleController = Me.dataLayoutControl1
            Me.dateEdit1.TabIndex = 6
            '
            'textEdit3
            '
            Me.textEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "City", True))
            Me.textEdit3.Location = New System.Drawing.Point(78, 141)
            Me.textEdit3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.textEdit3.Name = "textEdit3"
            Me.textEdit3.Size = New System.Drawing.Size(244, 22)
            Me.textEdit3.StyleController = Me.dataLayoutControl1
            Me.textEdit3.TabIndex = 7
            '
            'textEdit4
            '
            Me.textEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Country", True))
            Me.textEdit4.Location = New System.Drawing.Point(78, 109)
            Me.textEdit4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.textEdit4.Name = "textEdit4"
            Me.textEdit4.Size = New System.Drawing.Size(244, 22)
            Me.textEdit4.StyleController = Me.dataLayoutControl1
            Me.textEdit4.TabIndex = 8
            '
            'spinEdit1
            '
            Me.spinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "EmployeeID", True))
            Me.spinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit1.Location = New System.Drawing.Point(0, 0)
            Me.spinEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.spinEdit1.Name = "spinEdit1"
            Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinEdit1.Size = New System.Drawing.Size(0, 22)
            Me.spinEdit1.StyleController = Me.dataLayoutControl1
            Me.spinEdit1.TabIndex = 9
            '
            'textEdit5
            '
            Me.textEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Extension", True))
            Me.textEdit5.Location = New System.Drawing.Point(404, 205)
            Me.textEdit5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.textEdit5.Name = "textEdit5"
            Me.textEdit5.Size = New System.Drawing.Size(243, 22)
            Me.textEdit5.StyleController = Me.dataLayoutControl1
            Me.textEdit5.TabIndex = 10
            '
            'textEdit6
            '
            Me.textEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "FirstName", True))
            Me.textEdit6.Location = New System.Drawing.Point(270, 45)
            Me.textEdit6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.textEdit6.Name = "textEdit6"
            Me.textEdit6.Size = New System.Drawing.Size(111, 22)
            Me.textEdit6.StyleController = Me.dataLayoutControl1
            Me.textEdit6.TabIndex = 11
            '
            'dateEdit2
            '
            Me.dateEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "HireDate", True))
            Me.dateEdit2.EditValue = Nothing
            Me.dateEdit2.Location = New System.Drawing.Point(78, 77)
            Me.dateEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.dateEdit2.Name = "dateEdit2"
            Me.dateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.dateEdit2.Size = New System.Drawing.Size(244, 22)
            Me.dateEdit2.StyleController = Me.dataLayoutControl1
            Me.dateEdit2.TabIndex = 12
            '
            'hyperLinkEdit1
            '
            Me.hyperLinkEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "HomePhone", True))
            Me.hyperLinkEdit1.Location = New System.Drawing.Point(78, 205)
            Me.hyperLinkEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
            Me.hyperLinkEdit1.Size = New System.Drawing.Size(244, 22)
            Me.hyperLinkEdit1.StyleController = Me.dataLayoutControl1
            Me.hyperLinkEdit1.TabIndex = 13
            '
            'textEdit7
            '
            Me.textEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "LastName", True))
            Me.textEdit7.Location = New System.Drawing.Point(463, 45)
            Me.textEdit7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.textEdit7.Name = "textEdit7"
            Me.textEdit7.Size = New System.Drawing.Size(184, 22)
            Me.textEdit7.StyleController = Me.dataLayoutControl1
            Me.textEdit7.TabIndex = 14
            '
            'textEdit9
            '
            Me.textEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "PostalCode", True))
            Me.textEdit9.Location = New System.Drawing.Point(404, 141)
            Me.textEdit9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.textEdit9.Name = "textEdit9"
            Me.textEdit9.Size = New System.Drawing.Size(243, 22)
            Me.textEdit9.StyleController = Me.dataLayoutControl1
            Me.textEdit9.TabIndex = 16
            '
            'textEdit10
            '
            Me.textEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Region", True))
            Me.textEdit10.Location = New System.Drawing.Point(404, 109)
            Me.textEdit10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.textEdit10.Name = "textEdit10"
            Me.textEdit10.Size = New System.Drawing.Size(243, 22)
            Me.textEdit10.StyleController = Me.dataLayoutControl1
            Me.textEdit10.TabIndex = 17
            '
            'spinEdit2
            '
            Me.spinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "ReportsTo", True))
            Me.spinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEdit2.Location = New System.Drawing.Point(0, 0)
            Me.spinEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.spinEdit2.Name = "spinEdit2"
            Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.spinEdit2.Size = New System.Drawing.Size(0, 22)
            Me.spinEdit2.StyleController = Me.dataLayoutControl1
            Me.spinEdit2.TabIndex = 18
            '
            'textEdit11
            '
            Me.textEdit11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Title", True))
            Me.textEdit11.Location = New System.Drawing.Point(78, 45)
            Me.textEdit11.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.textEdit11.Name = "textEdit11"
            Me.textEdit11.Size = New System.Drawing.Size(110, 22)
            Me.textEdit11.StyleController = Me.dataLayoutControl1
            Me.textEdit11.TabIndex = 19
            '
            'layoutControlItem6
            '
            Me.layoutControlItem6.Control = Me.spinEdit1
            Me.layoutControlItem6.CustomizationFormText = "EmployeeID"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "ItemForEmployeeID"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem6.Size = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.Text = "EmployeeID"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(50, 20)
            Me.layoutControlItem6.TextToControlDistance = 5
            '
            'layoutControlItem15
            '
            Me.layoutControlItem15.Control = Me.spinEdit2
            Me.layoutControlItem15.CustomizationFormText = "ReportsTo"
            Me.layoutControlItem15.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem15.Name = "ItemForReportsTo"
            Me.layoutControlItem15.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem15.Size = New System.Drawing.Size(0, 0)
            Me.layoutControlItem15.Text = "ReportsTo"
            Me.layoutControlItem15.TextSize = New System.Drawing.Size(50, 20)
            Me.layoutControlItem15.TextToControlDistance = 5
            '
            'layoutControlGroup1
            '
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7, Me.layoutControlItem18, Me.layoutControlItem11, Me.layoutControlItem8, Me.layoutControlItem3, Me.layoutControlItem16, Me.layoutControlItem20, Me.layoutControlItem19, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem12, Me.ItemForPostalCode, Me.ItemForCountry, Me.ItemForRegion, Me.ItemForCity, Me.ItemForAddress})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(653, 657)
            Me.layoutControlGroup1.Text = "layoutControlGroup1"
            Me.layoutControlGroup1.TextVisible = False
            '
            'layoutControlItem7
            '
            Me.layoutControlItem7.Control = Me.textEdit5
            Me.layoutControlItem7.CustomizationFormText = "Extension"
            Me.layoutControlItem7.Location = New System.Drawing.Point(326, 199)
            Me.layoutControlItem7.Name = "ItemForExtension"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem7.Size = New System.Drawing.Size(325, 32)
            Me.layoutControlItem7.Text = "Extension"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(68, 16)
            '
            'layoutControlItem18
            '
            Me.layoutControlItem18.Control = Me.labelControl1
            Me.layoutControlItem18.CustomizationFormText = "layoutControlItem18"
            Me.layoutControlItem18.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem18.Name = "layoutControlItem18"
            Me.layoutControlItem18.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem18.Size = New System.Drawing.Size(651, 39)
            Me.layoutControlItem18.Text = "layoutControlItem18"
            Me.layoutControlItem18.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem18.TextToControlDistance = 0
            Me.layoutControlItem18.TextVisible = False
            '
            'layoutControlItem11
            '
            Me.layoutControlItem11.Control = Me.textEdit7
            Me.layoutControlItem11.CustomizationFormText = "LastName"
            Me.layoutControlItem11.Location = New System.Drawing.Point(385, 39)
            Me.layoutControlItem11.Name = "ItemForLastName"
            Me.layoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem11.Size = New System.Drawing.Size(266, 32)
            Me.layoutControlItem11.Text = "LastName"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(68, 16)
            '
            'layoutControlItem8
            '
            Me.layoutControlItem8.Control = Me.textEdit6
            Me.layoutControlItem8.CustomizationFormText = "FirstName"
            Me.layoutControlItem8.Location = New System.Drawing.Point(192, 39)
            Me.layoutControlItem8.Name = "ItemForFirstName"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem8.Size = New System.Drawing.Size(193, 32)
            Me.layoutControlItem8.Text = "FirstName"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(68, 16)
            '
            'layoutControlItem3
            '
            Me.layoutControlItem3.Control = Me.dateEdit1
            Me.layoutControlItem3.CustomizationFormText = "BirthDate"
            Me.layoutControlItem3.Location = New System.Drawing.Point(326, 71)
            Me.layoutControlItem3.Name = "ItemForBirthDate"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(325, 32)
            Me.layoutControlItem3.Text = "BirthDate"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(68, 16)
            '
            'layoutControlItem16
            '
            Me.layoutControlItem16.Control = Me.textEdit11
            Me.layoutControlItem16.CustomizationFormText = "Title"
            Me.layoutControlItem16.Location = New System.Drawing.Point(0, 39)
            Me.layoutControlItem16.Name = "ItemForTitle"
            Me.layoutControlItem16.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem16.Size = New System.Drawing.Size(192, 32)
            Me.layoutControlItem16.Text = "Title"
            Me.layoutControlItem16.TextSize = New System.Drawing.Size(68, 16)
            '
            'layoutControlItem20
            '
            Me.layoutControlItem20.Control = Me.simpleButton2
            Me.layoutControlItem20.CustomizationFormText = "layoutControlItem20"
            Me.layoutControlItem20.Location = New System.Drawing.Point(545, 622)
            Me.layoutControlItem20.Name = "layoutControlItem20"
            Me.layoutControlItem20.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem20.Size = New System.Drawing.Size(106, 33)
            Me.layoutControlItem20.Text = "layoutControlItem20"
            Me.layoutControlItem20.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem20.TextToControlDistance = 0
            Me.layoutControlItem20.TextVisible = False
            '
            'layoutControlItem19
            '
            Me.layoutControlItem19.Control = Me.dataNavigator1
            Me.layoutControlItem19.CustomizationFormText = "layoutControlItem19"
            Me.layoutControlItem19.Location = New System.Drawing.Point(0, 622)
            Me.layoutControlItem19.Name = "layoutControlItem19"
            Me.layoutControlItem19.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem19.Size = New System.Drawing.Size(266, 33)
            Me.layoutControlItem19.Text = "layoutControlItem19"
            Me.layoutControlItem19.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem19.TextToControlDistance = 0
            Me.layoutControlItem19.TextVisible = False
            '
            'emptySpaceItem1
            '
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(266, 622)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.emptySpaceItem1.Size = New System.Drawing.Size(279, 33)
            Me.emptySpaceItem1.Text = "emptySpaceItem1"
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'emptySpaceItem2
            '
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 564)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.emptySpaceItem2.Size = New System.Drawing.Size(651, 58)
            Me.emptySpaceItem2.Text = "emptySpaceItem2"
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'layoutControlItem9
            '
            Me.layoutControlItem9.Control = Me.dateEdit2
            Me.layoutControlItem9.CustomizationFormText = "HireDate"
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 71)
            Me.layoutControlItem9.Name = "ItemForHireDate"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem9.Size = New System.Drawing.Size(326, 32)
            Me.layoutControlItem9.Text = "HireDate"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(68, 16)
            '
            'layoutControlItem10
            '
            Me.layoutControlItem10.Control = Me.hyperLinkEdit1
            Me.layoutControlItem10.CustomizationFormText = "HomePhone"
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 199)
            Me.layoutControlItem10.Name = "ItemForHomePhone"
            Me.layoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem10.Size = New System.Drawing.Size(326, 32)
            Me.layoutControlItem10.Text = "HomePhone"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(68, 16)
            '
            'layoutControlItem12
            '
            Me.layoutControlItem12.Control = Me.memoEdit1
            Me.layoutControlItem12.CustomizationFormText = "Notes"
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 231)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlItem12.Size = New System.Drawing.Size(651, 333)
            Me.layoutControlItem12.Text = "Notes"
            Me.layoutControlItem12.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(68, 16)
            '
            'ItemForPostalCode
            '
            Me.ItemForPostalCode.Control = Me.textEdit9
            Me.ItemForPostalCode.CustomizationFormText = "PostalCode"
            Me.ItemForPostalCode.Location = New System.Drawing.Point(326, 135)
            Me.ItemForPostalCode.Name = "ItemForPostalCode"
            Me.ItemForPostalCode.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForPostalCode.Size = New System.Drawing.Size(325, 32)
            Me.ItemForPostalCode.Text = "PostalCode"
            Me.ItemForPostalCode.TextSize = New System.Drawing.Size(68, 16)
            '
            'ItemForCountry
            '
            Me.ItemForCountry.Control = Me.textEdit4
            Me.ItemForCountry.CustomizationFormText = "Country"
            Me.ItemForCountry.Location = New System.Drawing.Point(0, 103)
            Me.ItemForCountry.Name = "ItemForCountry"
            Me.ItemForCountry.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForCountry.Size = New System.Drawing.Size(326, 32)
            Me.ItemForCountry.Text = "Country"
            Me.ItemForCountry.TextSize = New System.Drawing.Size(68, 16)
            '
            'ItemForRegion
            '
            Me.ItemForRegion.Control = Me.textEdit10
            Me.ItemForRegion.CustomizationFormText = "Region"
            Me.ItemForRegion.Location = New System.Drawing.Point(326, 103)
            Me.ItemForRegion.Name = "ItemForRegion"
            Me.ItemForRegion.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForRegion.Size = New System.Drawing.Size(325, 32)
            Me.ItemForRegion.Text = "Region"
            Me.ItemForRegion.TextSize = New System.Drawing.Size(68, 16)
            '
            'ItemForCity
            '
            Me.ItemForCity.Control = Me.textEdit3
            Me.ItemForCity.CustomizationFormText = "City"
            Me.ItemForCity.Location = New System.Drawing.Point(0, 135)
            Me.ItemForCity.Name = "ItemForCity"
            Me.ItemForCity.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForCity.Size = New System.Drawing.Size(326, 32)
            Me.ItemForCity.Text = "City"
            Me.ItemForCity.TextSize = New System.Drawing.Size(68, 16)
            '
            'ItemForAddress
            '
            Me.ItemForAddress.Control = Me.textEdit2
            Me.ItemForAddress.CustomizationFormText = "Address"
            Me.ItemForAddress.Location = New System.Drawing.Point(0, 167)
            Me.ItemForAddress.Name = "ItemForAddress"
            Me.ItemForAddress.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.ItemForAddress.Size = New System.Drawing.Size(651, 32)
            Me.ItemForAddress.Text = "Address"
            Me.ItemForAddress.TextSize = New System.Drawing.Size(68, 16)
            '
            'UserDetailsEditViewForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.dataLayoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "UserDetailsEditViewForm"
            Me.Size = New System.Drawing.Size(653, 657)
            CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataLayoutControl1.ResumeLayout(False)
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateEdit1.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateEdit2.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForPostalCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForCountry, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForRegion, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForCity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ItemForAddress, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		Private ItemForPostalCode As LayoutControlItem
		Private ItemForCountry As LayoutControlItem
		Private ItemForRegion As LayoutControlItem
		Private ItemForCity As LayoutControlItem
		Private ItemForAddress As LayoutControlItem
	End Class
End Namespace
