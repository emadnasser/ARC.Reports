Namespace DevExpress.XtraGrid.Demos
    Partial Public Class ucFindOptions
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ucFindOptions))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceSearchInPreview = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowFindButton = New DevExpress.XtraEditors.CheckEdit()
            Me.icbFindMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.seFindDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.ceShowCloseButton = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowClearButton = New DevExpress.XtraEditors.CheckEdit()
            Me.ceHighlightFindResults = New DevExpress.XtraEditors.CheckEdit()
            Me.ceClearFind = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAlwaysVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowFindFilter = New DevExpress.XtraEditors.CheckEdit()
            Me.cbFindFilterColumns = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.ceSearchInPreview.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowFindButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.icbFindMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.seFindDelay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowCloseButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceShowClearButton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceHighlightFindResults.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceClearFind.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceAlwaysVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ceAllowFindFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbFindFilterColumns.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceSearchInPreview)
            Me.layoutControl1.Controls.Add(Me.ceShowFindButton)
            Me.layoutControl1.Controls.Add(Me.icbFindMode)
            Me.layoutControl1.Controls.Add(Me.seFindDelay)
            Me.layoutControl1.Controls.Add(Me.ceShowCloseButton)
            Me.layoutControl1.Controls.Add(Me.ceShowClearButton)
            Me.layoutControl1.Controls.Add(Me.ceHighlightFindResults)
            Me.layoutControl1.Controls.Add(Me.ceClearFind)
            Me.layoutControl1.Controls.Add(Me.ceAlwaysVisible)
            Me.layoutControl1.Controls.Add(Me.ceAllowFindFilter)
            Me.layoutControl1.Controls.Add(Me.cbFindFilterColumns)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' ceSearchInPreview
            ' 
            resources.ApplyResources(Me.ceSearchInPreview, "ceSearchInPreview")
            Me.ceSearchInPreview.Name = "ceSearchInPreview"
            Me.ceSearchInPreview.Properties.Caption = resources.GetString("ceSearchInPreview.Properties.Caption")
            Me.ceSearchInPreview.StyleController = Me.layoutControl1
            ' 
            ' ceShowFindButton
            ' 
            resources.ApplyResources(Me.ceShowFindButton, "ceShowFindButton")
            Me.ceShowFindButton.Name = "ceShowFindButton"
            Me.ceShowFindButton.Properties.Caption = resources.GetString("ceShowFindButton.Properties.Caption")
            Me.ceShowFindButton.StyleController = Me.layoutControl1
            ' 
            ' icbFindMode
            ' 
            resources.ApplyResources(Me.icbFindMode, "icbFindMode")
            Me.icbFindMode.Name = "icbFindMode"
            Me.icbFindMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("icbFindMode.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.icbFindMode.StyleController = Me.layoutControl1
            ' 
            ' seFindDelay
            ' 
            resources.ApplyResources(Me.seFindDelay, "seFindDelay")
            Me.seFindDelay.Name = "seFindDelay"
            Me.seFindDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seFindDelay.Properties.IsFloatValue = False
            Me.seFindDelay.Properties.Mask.EditMask = resources.GetString("seFindDelay.Properties.Mask.EditMask")
            Me.seFindDelay.Properties.MaxValue = New Decimal(New Integer() { 5000, 0, 0, 0})
            Me.seFindDelay.Properties.MinValue = New Decimal(New Integer() { 100, 0, 0, 0})
            Me.seFindDelay.StyleController = Me.layoutControl1
            ' 
            ' ceShowCloseButton
            ' 
            resources.ApplyResources(Me.ceShowCloseButton, "ceShowCloseButton")
            Me.ceShowCloseButton.Name = "ceShowCloseButton"
            Me.ceShowCloseButton.Properties.Caption = resources.GetString("ceShowCloseButton.Properties.Caption")
            Me.ceShowCloseButton.StyleController = Me.layoutControl1
            ' 
            ' ceShowClearButton
            ' 
            resources.ApplyResources(Me.ceShowClearButton, "ceShowClearButton")
            Me.ceShowClearButton.Name = "ceShowClearButton"
            Me.ceShowClearButton.Properties.Caption = resources.GetString("ceShowClearButton.Properties.Caption")
            Me.ceShowClearButton.StyleController = Me.layoutControl1
            ' 
            ' ceHighlightFindResults
            ' 
            resources.ApplyResources(Me.ceHighlightFindResults, "ceHighlightFindResults")
            Me.ceHighlightFindResults.Name = "ceHighlightFindResults"
            Me.ceHighlightFindResults.Properties.Caption = resources.GetString("ceHighlightFindResults.Properties.Caption")
            Me.ceHighlightFindResults.StyleController = Me.layoutControl1
            ' 
            ' ceClearFind
            ' 
            resources.ApplyResources(Me.ceClearFind, "ceClearFind")
            Me.ceClearFind.Name = "ceClearFind"
            Me.ceClearFind.Properties.Caption = resources.GetString("ceClearFind.Properties.Caption")
            Me.ceClearFind.StyleController = Me.layoutControl1
            ' 
            ' ceAlwaysVisible
            ' 
            resources.ApplyResources(Me.ceAlwaysVisible, "ceAlwaysVisible")
            Me.ceAlwaysVisible.Name = "ceAlwaysVisible"
            Me.ceAlwaysVisible.Properties.Caption = resources.GetString("ceAlwaysVisible.Properties.Caption")
            Me.ceAlwaysVisible.StyleController = Me.layoutControl1
            ' 
            ' ceAllowFindFilter
            ' 
            resources.ApplyResources(Me.ceAllowFindFilter, "ceAllowFindFilter")
            Me.ceAllowFindFilter.Name = "ceAllowFindFilter"
            Me.ceAllowFindFilter.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True
            Me.ceAllowFindFilter.Properties.Caption = resources.GetString("ceAllowFindFilter.Properties.Caption")
            Me.ceAllowFindFilter.StyleController = Me.layoutControl1
            ' 
            ' cbFindFilterColumns
            ' 
            resources.ApplyResources(Me.cbFindFilterColumns, "cbFindFilterColumns")
            Me.cbFindFilterColumns.Name = "cbFindFilterColumns"
            Me.cbFindFilterColumns.Properties.DropDownRows = 25
            Me.cbFindFilterColumns.StyleController = Me.layoutControl1
            ' 
            ' layoutControlGroup1
            ' 
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem11, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.emptySpaceItem1, Me.emptySpaceItem2, Me.emptySpaceItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(225, 356)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceAllowFindFilter
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(225, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceAlwaysVisible
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(225, 23)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceClearFind
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 46)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(225, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seFindDelay
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 204)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(225, 24)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(94, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.cbFindFilterColumns
            resources.ApplyResources(Me.layoutControlItem7, "layoutControlItem7")
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 228)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(225, 24)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(94, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.icbFindMode
            resources.ApplyResources(Me.layoutControlItem8, "layoutControlItem8")
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 252)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(225, 24)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(94, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceHighlightFindResults
            resources.ApplyResources(Me.layoutControlItem4, "layoutControlItem4")
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 69)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(225, 23)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceShowCloseButton
            resources.ApplyResources(Me.layoutControlItem5, "layoutControlItem5")
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 102)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(225, 23)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.ceShowClearButton
            resources.ApplyResources(Me.layoutControlItem9, "layoutControlItem9")
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 125)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(225, 23)
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.ceShowFindButton
            resources.ApplyResources(Me.layoutControlItem10, "layoutControlItem10")
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 148)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(225, 23)
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.ceSearchInPreview
            resources.ApplyResources(Me.layoutControlItem11, "layoutControlItem11")
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 171)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(225, 23)
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 276)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(225, 80)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 92)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(225, 10)
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.AllowHotTrack = False
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 194)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(225, 10)
            Me.emptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' ucFindOptions
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ucFindOptions"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.ceSearchInPreview.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowFindButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.icbFindMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.seFindDelay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowCloseButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceShowClearButton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceHighlightFindResults.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceClearFind.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceAlwaysVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ceAllowFindFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbFindFilterColumns.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents ceAlwaysVisible As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceAllowFindFilter As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents ceClearFind As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents ceShowCloseButton As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceHighlightFindResults As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents seFindDelay As DevExpress.XtraEditors.SpinEdit
        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents icbFindMode As DevExpress.XtraEditors.ImageComboBoxEdit
        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents ceSearchInPreview As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceShowFindButton As DevExpress.XtraEditors.CheckEdit
        Private WithEvents ceShowClearButton As DevExpress.XtraEditors.CheckEdit
        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Private WithEvents cbFindFilterColumns As DevExpress.XtraEditors.ImageComboBoxEdit
        Private emptySpaceItem1 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem2 As XtraLayout.EmptySpaceItem
        Private emptySpaceItem3 As XtraLayout.EmptySpaceItem
    End Class
End Namespace
