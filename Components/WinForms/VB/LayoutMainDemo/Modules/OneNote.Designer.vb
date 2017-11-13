Namespace DevExpress.XtraLayout.Demos
    Partial Public Class OneNote
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
            Dim stubGlyphOptions1 As New DevExpress.Utils.Drawing.StubGlyphOptions()
            Dim stubGlyphOptions2 As New DevExpress.Utils.Drawing.StubGlyphOptions()
            Dim stubGlyphOptions3 As New DevExpress.Utils.Drawing.StubGlyphOptions()
            Dim stubGlyphOptions4 As New DevExpress.Utils.Drawing.StubGlyphOptions()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
            Me.richEdit7 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.richEdit6 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.richEdit4 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.richEdit3 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.tabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.tabbedControlGroup2 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup8 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup9 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.behaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.richEditControl2 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabbedControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup8, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup9, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.behaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.richEditControl2)
            Me.layoutControl1.Controls.Add(Me.richEditControl1)
            Me.layoutControl1.Controls.Add(Me.webBrowser1)
            Me.layoutControl1.Controls.Add(Me.richEdit7)
            Me.layoutControl1.Controls.Add(Me.richEdit6)
            Me.layoutControl1.Controls.Add(Me.richEdit4)
            Me.layoutControl1.Controls.Add(Me.richEdit3)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-1059, 171, 825, 384)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(794, 492)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' webBrowser1
            ' 
            Me.webBrowser1.Location = New System.Drawing.Point(17, 39)
            Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.webBrowser1.Name = "webBrowser1"
            Me.webBrowser1.ScriptErrorsSuppressed = True
            Me.webBrowser1.Size = New System.Drawing.Size(684, 436)
            Me.webBrowser1.TabIndex = 10
            ' 
            ' richEdit7
            ' 
            Me.richEdit7.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEdit7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEdit7.Location = New System.Drawing.Point(15, 37)
            Me.richEdit7.Name = "richEdit7"
            Me.richEdit7.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEdit7.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEdit7.Size = New System.Drawing.Size(688, 440)
            Me.richEdit7.TabIndex = 4
            ' 
            ' richEdit6
            ' 
            Me.richEdit6.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEdit6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEdit6.Location = New System.Drawing.Point(15, 37)
            Me.richEdit6.Name = "richEdit6"
            Me.richEdit6.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEdit6.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEdit6.Size = New System.Drawing.Size(688, 440)
            Me.richEdit6.TabIndex = 5
            ' 
            ' richEdit4
            ' 
            Me.richEdit4.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEdit4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEdit4.Location = New System.Drawing.Point(12, 34)
            Me.richEdit4.Name = "richEdit4"
            Me.richEdit4.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEdit4.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEdit4.Size = New System.Drawing.Size(770, 446)
            Me.richEdit4.TabIndex = 7
            ' 
            ' richEdit3
            ' 
            Me.richEdit3.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEdit3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEdit3.Location = New System.Drawing.Point(12, 34)
            Me.richEdit3.Name = "richEdit3"
            Me.richEdit3.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEdit3.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEdit3.Size = New System.Drawing.Size(770, 446)
            Me.richEdit3.TabIndex = 8
            ' 
            ' Root
            ' 
            Me.Root.CustomizationFormText = "Main"
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabbedControlGroup1})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.Root.Size = New System.Drawing.Size(794, 492)
            Me.Root.Text = "Main"
            Me.Root.TextVisible = False
            ' 
            ' tabbedControlGroup1
            ' 
            Me.tabbedControlGroup1.CustomizationFormText = "tabbedControlGroup1"
            Me.tabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.tabbedControlGroup1.Name = "tabbedControlGroup1"
            Me.tabbedControlGroup1.SelectedTabPage = Me.layoutControlGroup1
            Me.tabbedControlGroup1.SelectedTabPageIndex = 0
            Me.tabbedControlGroup1.Size = New System.Drawing.Size(794, 492)
            Me.tabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup1, Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AppearanceTabPage.Header.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(83)))), (CInt((CByte(194)))))
            Me.layoutControlGroup1.AppearanceTabPage.Header.Options.UseBackColor = True
            stubGlyphOptions1.ColorMode = DevExpress.Utils.Drawing.GlyphColorMode.Blue
            Me.behaviorManager1.SetBehaviors(Me.layoutControlGroup1, New DevExpress.Utils.Behaviors.Behavior() {(CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraLayout.BehaviorSource.StubGlyphBehaviorSourceForLayoutGroup), stubGlyphOptions1, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior))})
            Me.layoutControlGroup1.CustomizationFormText = "General"
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.tabbedControlGroup2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(770, 446)
            Me.layoutControlGroup1.Text = "General"
            ' 
            ' tabbedControlGroup2
            ' 
            Me.tabbedControlGroup2.CustomizationFormText = "tabbedControlGroup2"
            Me.tabbedControlGroup2.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal
            Me.tabbedControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.tabbedControlGroup2.Name = "tabbedControlGroup2"
            Me.tabbedControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.tabbedControlGroup2.SelectedTabPage = Me.layoutControlGroup6
            Me.tabbedControlGroup2.SelectedTabPageIndex = 0
            Me.tabbedControlGroup2.Size = New System.Drawing.Size(770, 446)
            Me.tabbedControlGroup2.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup6, Me.layoutControlGroup7, Me.layoutControlGroup8, Me.layoutControlGroup9})
            Me.tabbedControlGroup2.TextLocation = DevExpress.Utils.Locations.Right
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.CustomizationFormText = "Content"
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup6.Name = "layoutControlGroup6"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(688, 440)
            Me.layoutControlGroup6.Text = "Content"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.webBrowser1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(688, 440)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlGroup7
            ' 
            Me.layoutControlGroup7.CustomizationFormText = "Code Sample"
            Me.layoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5})
            Me.layoutControlGroup7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup7.Name = "layoutControlGroup7"
            Me.layoutControlGroup7.Size = New System.Drawing.Size(688, 440)
            Me.layoutControlGroup7.Text = "Code Sample"
            ' 
            ' layoutControlGroup8
            ' 
            Me.layoutControlGroup8.CustomizationFormText = "Notes"
            Me.layoutControlGroup8.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6})
            Me.layoutControlGroup8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup8.Name = "layoutControlGroup8"
            Me.layoutControlGroup8.Size = New System.Drawing.Size(688, 440)
            Me.layoutControlGroup8.Text = "Notes"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.richEdit6
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem6.Size = New System.Drawing.Size(688, 440)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlGroup9
            ' 
            Me.layoutControlGroup9.CustomizationFormText = "Hyperlinks"
            Me.layoutControlGroup9.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem7})
            Me.layoutControlGroup9.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup9.Name = "layoutControlGroup9"
            Me.layoutControlGroup9.Size = New System.Drawing.Size(688, 440)
            Me.layoutControlGroup9.Text = "Hyperlinks"
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.richEdit7
            Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem7.Size = New System.Drawing.Size(688, 440)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AppearanceTabPage.Header.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(64)))), (CInt((CByte(168)))), (CInt((CByte(19)))))
            Me.layoutControlGroup2.AppearanceTabPage.Header.Options.UseBackColor = True
            stubGlyphOptions2.ColorMode = DevExpress.Utils.Drawing.GlyphColorMode.Green
            Me.behaviorManager1.SetBehaviors(Me.layoutControlGroup2, New DevExpress.Utils.Behaviors.Behavior() {(CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraLayout.BehaviorSource.StubGlyphBehaviorSourceForLayoutGroup), stubGlyphOptions2, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior))})
            Me.layoutControlGroup2.CustomizationFormText = "Basics"
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(770, 446)
            Me.layoutControlGroup2.Text = "Basics"
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.AppearanceTabPage.Header.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(245)))), (CInt((CByte(121)))), (CInt((CByte(10)))))
            Me.layoutControlGroup3.AppearanceTabPage.Header.Options.UseBackColor = True
            stubGlyphOptions3.ColorMode = DevExpress.Utils.Drawing.GlyphColorMode.Yellow
            Me.behaviorManager1.SetBehaviors(Me.layoutControlGroup3, New DevExpress.Utils.Behaviors.Behavior() {(CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraLayout.BehaviorSource.StubGlyphBehaviorSourceForLayoutGroup), stubGlyphOptions3, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior))})
            Me.layoutControlGroup3.CustomizationFormText = "History"
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(770, 446)
            Me.layoutControlGroup3.Text = "History"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.richEdit3
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem3.Size = New System.Drawing.Size(770, 446)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.AppearanceTabPage.Header.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(196)))), (CInt((CByte(19)))), (CInt((CByte(19)))))
            Me.layoutControlGroup4.AppearanceTabPage.Header.Options.UseBackColor = True
            stubGlyphOptions4.ColorMode = DevExpress.Utils.Drawing.GlyphColorMode.Red
            Me.behaviorManager1.SetBehaviors(Me.layoutControlGroup4, New DevExpress.Utils.Behaviors.Behavior() {(CType(DevExpress.Utils.Behaviors.Common.StubGlyphBehavior.Create(GetType(DevExpress.XtraLayout.BehaviorSource.StubGlyphBehaviorSourceForLayoutGroup), stubGlyphOptions4, New System.Drawing.Size(16, 16)), DevExpress.Utils.Behaviors.Behavior))})
            Me.layoutControlGroup4.CustomizationFormText = "Remarks"
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(770, 446)
            Me.layoutControlGroup4.Text = "Remarks"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.richEdit4
            Me.layoutControlItem4.CustomizationFormText = "layoutControlItem4"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem4.Size = New System.Drawing.Size(770, 446)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl1.Location = New System.Drawing.Point(17, 39)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl1.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl1.Size = New System.Drawing.Size(684, 436)
            Me.richEditControl1.TabIndex = 13
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.richEditControl1
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(688, 440)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' richEditControl2
            ' 
            Me.richEditControl2.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft
            Me.richEditControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.richEditControl2.Location = New System.Drawing.Point(14, 36)
            Me.richEditControl2.Name = "richEditControl2"
            Me.richEditControl2.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl2.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
            Me.richEditControl2.Size = New System.Drawing.Size(766, 442)
            Me.richEditControl2.TabIndex = 14
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.richEditControl2
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(770, 446)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' OneNote
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "OneNote"
            Me.Size = New System.Drawing.Size(794, 492)
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabbedControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup8, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup9, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.behaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private components As System.ComponentModel.IContainer = Nothing
        Private layoutControl1 As LayoutControl
        Private Root As LayoutControlGroup
        Private tabbedControlGroup1 As TabbedControlGroup
        Private layoutControlGroup1 As LayoutControlGroup
        Private tabbedControlGroup2 As TabbedControlGroup
        Private layoutControlGroup9 As LayoutControlGroup
        Private layoutControlGroup6 As LayoutControlGroup
        Private layoutControlGroup7 As LayoutControlGroup
        Private layoutControlGroup8 As LayoutControlGroup
        Private layoutControlGroup2 As LayoutControlGroup
        Private layoutControlGroup3 As LayoutControlGroup
        Private layoutControlGroup4 As LayoutControlGroup
        Private richEdit7 As DevExpress.XtraRichEdit.RichEditControl
        Private richEdit6 As DevExpress.XtraRichEdit.RichEditControl
        Private richEdit4 As DevExpress.XtraRichEdit.RichEditControl
        Private richEdit3 As DevExpress.XtraRichEdit.RichEditControl
        Private layoutControlItem6 As LayoutControlItem
        Private layoutControlItem7 As LayoutControlItem
        Private layoutControlItem3 As LayoutControlItem
        Private layoutControlItem4 As LayoutControlItem
        Private behaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
        Private webBrowser1 As System.Windows.Forms.WebBrowser
        Private layoutControlItem1 As LayoutControlItem
        Private richEditControl2 As XtraRichEdit.RichEditControl
        Private richEditControl1 As XtraRichEdit.RichEditControl
        Private layoutControlItem5 As LayoutControlItem
        Private layoutControlItem2 As LayoutControlItem
    End Class
End Namespace
