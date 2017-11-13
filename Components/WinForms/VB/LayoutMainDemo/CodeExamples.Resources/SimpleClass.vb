Imports System
Imports Microsoft.VisualBasic
Imports DevExpress.XtraLayout
Imports DevExpress.Utils
Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos.CodeDemo
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Utils
Imports System.Drawing
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraDataLayout
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel
Imports DevExpress.XtraLayout.Customization
Imports DevExpress.XtraLayout.Customization.Controls
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraLayout.Registrator
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils.Design
Imports DevExpress.XtraEditors.ButtonsPanelControl
Imports DevExpress.XtraEditors.Controls
Imports System.Collections.Generic

Namespace Examples
    <CodeExampleClass("Create layout in code", "SimpleClass.vb"), CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "LayoutType")>
    Public NotInheritable Class CreateLayoutInCode

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim layoutControl As New LayoutControl()
            layoutControl.Dock = DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            TryCast(sampleHost.Controls(0), LayoutControl).Dispose()
        End Sub
        <CodeExampleCase("Horizontal arrangement")>
        Public Shared Sub CreateHorzAlignedLayout(ByVal layoutControl As LayoutControl)
            ' A layout consisting of two horizontally arranged items.
            layoutControl.Root.DefaultLayoutType = LayoutType.Horizontal
            layoutControl.AddItem("Memo 1", New MemoEdit() With {.Text = "Memo1", .Name = "Memo1"})
            layoutControl.AddItem("Memo 2", New MemoEdit() With {.Text = "Memo2", .Name = "Memo2"})
            layoutControl.BestFit()
        End Sub
        <CodeExampleCase("Vertical arrangement")>
        Public Shared Sub CreateVertAlignedLayout(ByVal layoutControl As LayoutControl)
            ' A layout consisting of two vertically arranged items.
            layoutControl.Root.DefaultLayoutType = LayoutType.Vertical
            layoutControl.AddItem("Memo 1", New MemoEdit() With {.Text = "Memo1", .Name = "Memo1"})
            layoutControl.AddItem("Memo 2", New MemoEdit() With {.Text = "Memo2", .Name = "Memo2"})
            layoutControl.BestFit()
        End Sub
        <CodeExampleCase("Visible and hidden items")>
        Public Shared Sub CreateVisibleAndHiddenItems(ByVal layoutControl As LayoutControl)
            ' This example creates a layout consisting of two items displaying two text boxes. 
            ' In addition, one hidden item (containing a memo editor) is also created. It can be accessed from the Customization Form.

            'Create a layout item and add it to the root group.    
            Dim item1 As LayoutControlItem = layoutControl.Root.AddItem()
            ' Set the item's Control and caption.
            item1.Name = "Layout Item 1"
            Dim textBox1 As Control = New TextEdit()
            textBox1.Name = "TextBox1"
            item1.Control = textBox1
            item1.Text = "Name:"

            ' Create a new layout item.
            Dim item2 As New LayoutControlItem()
            ' Add the item to the root group by setting its parent.
            item2.Parent = layoutControl.Root
            item2.Name = "Layout Item 2"
            Dim textBox2 As Control = New TextEdit()
            textBox2.Name = "TextBox2"
            item2.Control = textBox2
            item2.Text = "E-mail:"

            ' Create a hidden layout item.
            Dim item3 As New LayoutControlItem()
            item3.Name = "Layout Item 3"
            layoutControl.HiddenItems.AddRange(New BaseLayoutItem() {item3})
            Dim memo As Control = New MemoEdit()
            memo.Name = "memo1"
            item3.Control = memo
            item3.Text = "Notes:"

            'layoutControl.ShowCustomizationForm();

        End Sub
        <CodeExampleCase("Group with title and borders")>
        Public Shared Sub CreateGroupWithTitleBorder(ByVal layoutControl As LayoutControl)
            ' This example creates a layout containing a group of two items.
            ' The second item is positioned using the Move method, 
            ' which allows you to place an item at any of the four edges of another item.

            ' Create a new "Personal Info" group.
            Dim group1 As New LayoutControlGroup()
            group1.Name = "GroupPersonalInfo"
            group1.Text = "Personal Info"
            ' Create a layout item within the group.
            Dim item1 As LayoutControlItem = group1.AddItem()
            ' Bind a control to the layout item.
            Dim textEdit As New TextEdit()
            textEdit.Name = "TextBox1"
            item1.Control = textEdit
            item1.Text = "Name"

            ' Create a layout item that will display a DateEdit control.
            Dim dtPicker As New DateEdit()
            dtPicker.Name = "dateEdit"
            Dim item2 As New LayoutControlItem(layoutControl, dtPicker)
            item2.Text = "Date"
            ' Position this item to the right of item1
            item2.Move(item1, InsertType.Right)
            ' Add the created group to the root group.
            layoutControl.Root.Add(group1)


        End Sub
        <CodeExampleCase("Tabbed group")>
        Public Shared Sub CreateTabbedGroup(ByVal layoutControl As LayoutControl)
            ' This example creates a layout containing a tabbed group that has two tabs (regular groups).
            ' Each tab displays a single control (PictureEdit and MemoEdit, respectively).

            ' Create a tabbed group within the root group.
            Dim tabbedGroup As TabbedControlGroup = layoutControl.Root.AddTabbedGroup()
            tabbedGroup.Name = "TabbedGroup"
            ' Add a new group as a tab to the tabbed group.
            Dim group1 As LayoutControlGroup = TryCast(tabbedGroup.AddTabPage(), LayoutControlGroup)
            group1.Name = "LayoutControlGroup1"
            group1.Text = "Photo"
            ' Add a new layout item to the group that will display an image.
            Dim item1 As LayoutControlItem = group1.AddItem()
            item1.Name = "LayoutControlItem1"
            item1.Control = New PictureEdit() With {.Name = "PictureEdit"}
            ' Hide the item's text region.
            item1.TextVisible = False
            ' Add a new group to the tabbed group.
            Dim group2 As LayoutControlGroup = TryCast(tabbedGroup.AddTabPage(), LayoutControlGroup)
            group2.Name = "LayoutControlGroup2"
            group2.Text = "Notes"

            ' Add a new layout item to the group that will display an image.
            Dim item2 As LayoutControlItem = group2.AddItem()
            item2.Name = "LayoutControlItem1"
            item2.Control = New MemoEdit() With {.Name = "MemoEdit"}

            ' Hide the item's text region.
            item2.TextVisible = False

            ' Make the first tab page active.
            tabbedGroup.SelectedTabPage = group1

        End Sub
        <CodeExampleCase("M rows x N columns layout")>
        Public Shared Sub CreateMxNLayout(ByVal layoutControl As LayoutControl)
            ' A layout consisting of a specified number of columns and rows.
            Dim rowCount As Integer = 4
            Dim columnCount As Integer = 4
            Dim group1 As New LayoutControlGroup()
            group1.BeginUpdate()
            For i As Integer = 0 To rowCount - 1
                For j As Integer = 0 To columnCount - 1
                    Dim itemIndex As Integer = group1.Items.Count + 1
                    Dim item As LayoutControlItem = group1.AddItem("Memo" & itemIndex, New MemoEdit() With {.Name = "Memo" & itemIndex})
                    item.Location = New Point(i * 100, j * 100)
                    item.Size = New Size(100, 100)
                Next j
            Next i

            group1.EndUpdate()
            layoutControl.Root = group1
        End Sub
        <CodeExampleCase("Highlight Focused item"), CodeExampleHighlightTokens("DefaultBoolean"), CodeExampleUnderlineTokens("HighlightFocusedItem"), CodeExampleVersionID(162)>
        Public Shared Sub HighLightFocusedItem(ByVal layoutControl As LayoutControl)
            ' HighlightFocusedItem at the item's level

            'layoutControl.OptionsView.HighlightFocusedItem = true;

            Dim newItem1 As LayoutControlItem = layoutControl.AddItem("Memo 1", New MemoEdit() With {.Text = "Memo1", .Name = "Memo1"})
            newItem1.HighlightFocusedItem = DefaultBoolean.True
            Dim newItem2 As LayoutControlItem = layoutControl.AddItem("Memo 2", New MemoEdit() With {.Text = "Memo2", .Name = "Memo2"})
            newItem2.HighlightFocusedItem = DefaultBoolean.False
            Dim newItem3 As LayoutControlItem = layoutControl.AddItem("Memo 3", New MemoEdit() With {.Text = "Memo3", .Name = "Memo3"})
            newItem3.HighlightFocusedItem = DefaultBoolean.Default
            layoutControl.BestFit()
        End Sub

        <CodeExampleCase("Expand Animation"), CodeExampleHighlightTokens("DefaultBoolean"), CodeExampleUnderlineTokens("AllowExpandAnimation"), CodeExampleVersionID(162)>
        Public Shared Sub ExpandAnimation(ByVal layoutControl As LayoutControl)
            layoutControl.OptionsView.AllowExpandAnimation = DefaultBoolean.True

            For i As Integer = 0 To 2
                Dim newGroup As LayoutControlGroup = layoutControl.AddGroup()
                newGroup.ExpandButtonVisible = True
                newGroup.AddItem("Memo 1 in newGroup " & i, New MemoEdit() With {.Text = "Memo1" & i, .Name = "Memo1" & i})
                newGroup.AddItem("Memo 2 in newGroup " & i, New MemoEdit() With {.Text = "Memo2" & i, .Name = "Memo2" & i})
            Next i
            layoutControl.BestFit()
        End Sub

        <CodeExampleCase("HTML Text Formatting"), CodeExampleHighlightTokens("DefaultBoolean"), CodeExampleUnderlineTokens("AllowHtmlStringInCaption"), CodeExampleVersionID(162)>
        Public Shared Sub AllowHtmlString(ByVal layoutControl As LayoutControl)
            Dim newItem1 As LayoutControlItem = layoutControl.AddItem("", New MemoEdit() With {.Text = "Memo1", .Name = "Memo1"})
            newItem1.Text = "<color=255, 0, 0>Memo Red</color> <u>Underline</u>"
            newItem1.AllowHtmlStringInCaption = True

            Dim addGroup As LayoutControlGroup = layoutControl.AddGroup()
            addGroup.Text = "<color=0, 0, 255>Layout Group</color> <b>Bold</b>"
            addGroup.AllowHtmlStringInCaption = True

            layoutControl.BestFit()
        End Sub

        <CodeExampleCase("Word Wrap Text"), CodeExampleHighlightTokens("LabelControl, WordWrap, LayoutType, LabelAutoSizeMode"), CodeExampleUnderlineTokens("WordWrap"), CodeExampleVersionID(162)>
        Public Shared Sub WordWrapText(ByVal layoutControl As LayoutControl)
            Dim STR_Laborum As String = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            layoutControl.Root.DefaultLayoutType = LayoutType.Horizontal

            Dim labelControl1 As New LabelControl() With {.Text = STR_Laborum, .BackColor = Color.LightGreen, .Name = "label1"}
            labelControl1.Appearance.TextOptions.WordWrap = WordWrap.Wrap
            labelControl1.AutoSizeMode = LabelAutoSizeMode.Vertical
            Dim item1 As LayoutControlItem = layoutControl.Root.AddItem("", labelControl1)
            item1.TextVisible = False

            layoutControl.AddItem(New SplitterItem())

            Dim labelControl2 As New LabelControl() With {.Text = STR_Laborum, .BackColor = Color.LightSkyBlue, .Name = "label2"}
            labelControl2.Appearance.TextOptions.WordWrap = WordWrap.Wrap
            labelControl2.AutoSizeMode = LabelAutoSizeMode.Vertical
            Dim item2 As LayoutControlItem = layoutControl.Root.AddItem("", labelControl2)
            item2.TextVisible = False

            layoutControl.BestFit()
        End Sub
    End Class
    <CodeExampleClass("Change layout in code", "SimpleClass.vb"), CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SplitterItem")>
    Public NotInheritable Class ChangeLayout

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim layoutControl As New LayoutControl()
            layoutControl.Dock = DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            TryCast(sampleHost.Controls(0), LayoutControl).Dispose()
        End Sub
        <CodeExampleCase("Custom size constraints"), CodeExampleHighlightTokens("SplitterItem", "Size")>
        Public Shared Sub ChangeCustomSizeConstraints(ByVal layoutControl As LayoutControl)
            ' This example applies size constraints to the first item 
            ' Resize the items using the splitter.
            ' The size constraints will not allow you to change the first item's height to a value beyond the range [50;200].
            layoutControl.Root.DefaultLayoutType = LayoutType.Vertical
            Dim item1 As LayoutControlItem = layoutControl.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo1"})
            item1.SizeConstraintsType = SizeConstraintsType.Custom
            item1.MinSize = New Size(0, 50)
            item1.MaxSize = New Size(0, 200)
            layoutControl.AddItem(New SplitterItem())
            layoutControl.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo2"})
            layoutControl.BestFit()
        End Sub
        <CodeExampleCase("Custom align any control within its layout item"), CodeExampleHighlightTokens("ContentAlignment", "Size")>
        Public Shared Sub ChangeControlAlignment(ByVal layoutControl As LayoutControl)
            ' Center the control horizontally and vertically.
            Dim layoutControlItem1 As LayoutControlItem = layoutControl.AddItem("TextEdit", New TextEdit() With {.Name = "TextEdit"})
            layoutControlItem1.SizeConstraintsType = SizeConstraintsType.Custom
            layoutControlItem1.MinSize = Size.Empty
            layoutControlItem1.MaxSize = Size.Empty
            layoutControlItem1.FillControlToClientArea = False
            layoutControlItem1.Control.MaximumSize = New Size(200, 20)
            layoutControlItem1.ControlAlignment = ContentAlignment.MiddleCenter
        End Sub
        <CodeExampleCase("Horizontal alignment of auto-sized CheckEdit and RadioGroup"), CodeExampleHighlightTokens("CheckEdit", "ContentAlignment", "RadioGroup", "Size")>
        Public Shared Sub ChangeCheckEditAndRadioGroupAlignment(ByVal layoutControl As LayoutControl)
            ' CheckEdit and RadioGroup provide the AutoSizeInLayoutControl property, which enables the auto-sizing feature inside the Layout Control.
            ' This example shows how to custom align these controls when the auto-sizing feature is enabled.
            Dim checkEdit1 As New CheckEdit() With {.Name = "CheckEdit"}
            Dim layoutControlItem1 As LayoutControlItem = layoutControl.AddItem("Check box", checkEdit1)
            checkEdit1.AutoSizeInLayoutControl = True
            layoutControlItem1.SizeConstraintsType = SizeConstraintsType.SupportHorzAlignment
            layoutControlItem1.ControlAlignment = ContentAlignment.TopCenter
            'layoutControlItem1.ControlAlignment = ContentAlignment.TopRight;
            'layoutControlItem1.ControlAlignment = ContentAlignment.TopLeft;

            Dim radioGroup1 As New RadioGroup() With {.Name = "RadioGroup"}
            radioGroup1.Properties.Items.AddEnum(Of ContentAlignment)()
            Dim layoutControlItem2 As LayoutControlItem = layoutControl.AddItem("Radio Group", radioGroup1)
            radioGroup1.AutoSizeInLayoutControl = True
            layoutControlItem2.SizeConstraintsType = SizeConstraintsType.SupportHorzAlignment
            layoutControlItem2.ControlMaxSize = New Size(100, 0)
            layoutControlItem2.ControlAlignment = ContentAlignment.TopRight
            'layoutControlItem2.ControlAlignment = ContentAlignment.TopCenter;
            'layoutControlItem2.ControlAlignment = ContentAlignment.TopLeft;
        End Sub

        <CodeExampleCase("Horizontal alignment of auto-sized SimpleButton"), CodeExampleHighlightTokens("SimpleButton", "ContentAlignment")>
        Public Shared Sub ChangeSimpleButtonAlignment(ByVal layoutControl As LayoutControl)
            ' SimpleButton provides the AutoWidthInLayoutControl property, which enables the auto-sizing feature inside the Layout Control.
            ' This example shows how to custom align a SimpleButton when the auto-sizing feature is enabled.

            Dim btn As New SimpleButton() With {.Name = "SimpleButton", .Text = "button"}
            Dim layoutControlItem1 As LayoutControlItem = layoutControl.AddItem("Button", btn)
            btn.AutoWidthInLayoutControl = True
            layoutControlItem1.SizeConstraintsType = SizeConstraintsType.SupportHorzAlignment
            layoutControlItem1.ControlAlignment = ContentAlignment.TopRight
            'layoutControlItem1.ControlAlignment = ContentAlignment.TopCenter;
            'layoutControlItem1.ControlAlignment = ContentAlignment.TopLeft;
        End Sub



        <CodeExampleCase("Text location"), CodeExampleHighlightTokens("Locations", "SimpleButton", "ContentAlignment", "Font", "FontStyle")>
        Public Shared Sub ChangeTextLocation(ByVal layoutControl As LayoutControl)
            ' This example shows how to change an item's text location.
            Dim item As LayoutControlItem = layoutControl.AddItem("Memo", New MemoEdit() With {.Name = "Memo"})
            item.TextLocation = Locations.Right
            item.AppearanceItemCaption.Font = New Font(item.AppearanceItemCaption.Font, FontStyle.Bold)


            ' Optional code that creates a button allowing you to change the text location on a click.
            Dim textLocationArray() As Locations = {Locations.Bottom, Locations.Left, Locations.Top, Locations.Right}
            Dim locationCounter As Integer = 0
            Dim btn As New SimpleButton() With {.Name = "Button", .Text = "Change text location"}
            Dim item2 As LayoutControlItem = layoutControl.AddItem("Button", btn)
            item2.TextVisible = False
            AddHandler btn.Click, Sub(s, e)
                                      item.TextLocation = textLocationArray((locationCounter) Mod 4)
                                      locationCounter += 1
                                  End Sub
            ' Center the button.
            btn.AutoWidthInLayoutControl = True
            item2.SizeConstraintsType = SizeConstraintsType.SupportHorzAlignment
            item2.ControlAlignment = ContentAlignment.TopCenter

        End Sub
        <CodeExampleCase("Save and restore layout"), CodeExampleHighlightTokens("Locations", "SimpleButton", "ContentAlignment")>
        Public Shared Sub ChangeSaveAndRestoreLayout(ByVal layoutControl As LayoutControl)
            ' This example saves the current layout to an internal memory buffer, changes the layout and then restores the saved layout.
            ' NOTE: To correctly save and restore a layout, unique values must be assigned to the Name properties 
            ' of all layout items and controls displayed within layout items. 
            Dim item As LayoutControlItem = layoutControl.AddItem("Memo", New MemoEdit() With {.Name = "Memo"})
            item.Name = "itemMemo"
            ' Save the layout.
            layoutControl.SetDefaultLayout()
            ' Change the layout.
            item.TextLocation = Locations.Right
            '..
            ' Restore the saved layout.
            layoutControl.RestoreDefaultLayout()
            ' To save the layout to an XML file, stream or the system registry, use the SaveLayoutToXml, SaveLayoutToStream and SaveLayoutToRegistry methods, respectively.
            ' To restore the saved layouts, use RestoreLayoutFromXml, RestoreLayoutFromStream and RestoreLayoutFromRegistry methods


            ' Optional code that creates buttons allowing you to manually save, change and restore a layout.
            Dim buttonGroup As LayoutControlGroup = layoutControl.AddGroup()
            buttonGroup.Name = "buttonGroup"
            buttonGroup.Text = "Layout buttons"
            buttonGroup.DefaultLayoutType = LayoutType.Horizontal
            Dim btnSaveLayout As New SimpleButton() With {.Name = "ButtonSave", .Text = "Save Layout"}
            Dim btnChangeLayout As New SimpleButton() With {.Name = "ButtonChange", .Text = "Change Text Location"}
            Dim btnRestoreLayout As New SimpleButton() With {.Name = "ButtonRestore", .Text = "Restore Layout"}

            Dim itemSaveLayout As LayoutControlItem = buttonGroup.AddItem("Save Layout", btnSaveLayout)
            itemSaveLayout.TextVisible = False
            itemSaveLayout.Name = "itemSaveLayout"
            Dim itemChangeLayout As LayoutControlItem = buttonGroup.AddItem("Change Layout", btnChangeLayout)
            itemChangeLayout.TextVisible = False
            itemChangeLayout.Name = "itemChangeLayout"
            Dim itemRestoreLayout As LayoutControlItem = buttonGroup.AddItem("Restore Layout", btnRestoreLayout)
            itemRestoreLayout.TextVisible = False
            itemRestoreLayout.Name = "itemRestoreLayout"
            buttonGroup.BestFit()
            Dim locationCounter As Integer = 0
            AddHandler btnSaveLayout.Click, Sub(s, e) layoutControl.SetDefaultLayout()
            AddHandler btnChangeLayout.Click, Sub(s, e)
                                                  Dim textLocationArray() As Locations = {Locations.Bottom, Locations.Left, Locations.Top, Locations.Right}
                                                  item.TextLocation = textLocationArray((locationCounter) Mod 4)
                                                  locationCounter += 1
                                              End Sub
            AddHandler btnRestoreLayout.Click, Sub(s, e) layoutControl.RestoreDefaultLayout()
        End Sub



        <CodeExampleCase("Swap controls"), CodeExampleHighlightTokens("DxImageAssemblyUtil", "SimpleButton", "PictureEdit", "ImageSize", "ImageType", "ContentAlignment", "Control")>
        Public Shared Sub ChangeLayoutSwapControls(ByVal layoutControl As LayoutControl)
            ' This example shows how to swap controls of two layout items.
            ' Click the button to perform swapping.
            Dim item1 As LayoutControlItem = layoutControl.AddItem("Memo", New MemoEdit() With {.Name = "Memo1", .Text = "Memo"})
            Dim item2 As LayoutControlItem = layoutControl.AddItem("Picture", New PictureEdit() With {.Name = "Picture", .Image = DxImageAssemblyUtil.ImageProvider.GetImage("ColorMixer", ImageSize.Size32x32, ImageType.Colored)})
            layoutControl.BestFit()

            Dim btn As New SimpleButton() With {.Text = "Click Me to Swap Controls"}
            Dim itemButton As LayoutControlItem = layoutControl.AddItem("btnSwapControls", btn)
            itemButton.TextVisible = False
            AddHandler btn.Click, Sub(s, e)
                                      layoutControl.BeginUpdate()
                                      Dim ctrl1 As Control = item1.Control
                                      Dim ctrl2 As Control = item2.Control
                                      item1.Control = Nothing
                                      item2.Control = Nothing
                                      item1.Control = ctrl2
                                      item2.Control = ctrl1
                                      layoutControl.EndUpdate()
                                  End Sub

        End Sub

        <CodeExampleCase("Layout group border color blending"), CodeExampleHighlightTokens("Color"), CodeExampleUnderlineTokens("AllowBorderColorBlending")>
        Public Shared Sub AllowBorderColorBlending(ByVal layoutControl As LayoutControl)
            'This example showes how to highlight the group border.
            layoutControl.AddGroup()
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            group.AllowBorderColorBlending = True
            group.AppearanceGroup.BorderColor = Color.YellowGreen
            layoutControl.BestFit()

        End Sub
    End Class
    <CodeExampleClass("LayoutControl events", "SimpleClass.vb"), CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public NotInheritable Class EventLayoutControl

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim layoutControl As New LayoutControl()
            layoutControl.Dock = DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            TryCast(sampleHost.Controls(0), LayoutControl).Dispose()
        End Sub
        <CodeExampleCase("Change group caption on expanding/collapsing"), CodeExampleUnderlineTokens("GroupExpandChanged")>
        Public Shared Sub EventGroupExpandChanged(ByVal layoutControl As LayoutControl)
            ' This example uses the GroupExpandChanged event to modify the group caption.
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            group.ExpandButtonVisible = True
            group.Text = "Group (Expanded)"
            group.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo 1"})
            group.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo 2"})
            group.BestFit()
            AddHandler layoutControl.GroupExpandChanged, Sub(s, e)
                                                             If e.Group.Expanded Then
                                                                 e.Group.Text = "Group (Expanded)"
                                                             Else
                                                                 e.Group.Text = "Group (Collapsed)"
                                                             End If
                                                         End Sub

        End Sub
        <CodeExampleCase("Toggle item visibility on click")>
        Public Shared Sub EventLayoutItemClick(ByVal layoutControl As LayoutControl)
            ' This example handles the LayoutItem.Click event to change a clicked item's visibility.
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            group.ExpandButtonVisible = True
            group.Text = "My Group"
            Dim memoLCI1 As LayoutControlItem = group.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo 1"})
            Dim memoLCI2 As LayoutControlItem = group.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo 2"})
            group.BestFit()
            AddHandler memoLCI1.Click, Sub(s, e)
                                           If TypeOf s Is LayoutControlItem Then
                                               Dim item As LayoutControlItem = TryCast(s, LayoutControlItem)
                                               item.ContentVisible = Not item.ContentVisible
                                           End If
                                       End Sub
            AddHandler memoLCI2.Click, Sub(s, e)
                                           If TypeOf s Is LayoutControlItem Then
                                               Dim item As LayoutControlItem = TryCast(s, LayoutControlItem)
                                               item.ContentVisible = Not item.ContentVisible
                                           End If
                                       End Sub
        End Sub
        <CodeExampleCase("Expand/collapse group from context menu"), CodeExampleHighlightTokens("DXMenuItem", "LayoutGroup"), CodeExampleUnderlineTokens("PopupMenuShowing")>
        Public Shared Sub EventRightButtonPopupMenu(ByVal layoutControl As LayoutControl)
            ' This example handles the PopupMenuShowing event to add a 'Collapse'/'Expand' command to a group's context menu.
            ' Right-click the group caption and select 'Collapse' or 'Expand'
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            group.Name = "My group"
            group.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo 1"})
            group.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo 2"})
            group.BestFit()
            AddHandler layoutControl.PopupMenuShowing, Sub(s, e)
                                                           If e.HitInfo.Item.Parent IsNot Nothing AndAlso e.HitInfo.Item.IsGroup Then
                                                               Dim layoutGroup As LayoutGroup = TryCast(e.HitInfo.Item, LayoutGroup)
                                                               Dim menu As New DXMenuItem(If(group.Expanded, "Collapse", "Expand"), Sub(sender, eventArgs)
                                                                                                                                        If TypeOf sender Is DXMenuItem Then
                                                                                                                                            Dim groupToExpandCollapse As LayoutGroup = TryCast((TryCast(sender, DXMenuItem)).Tag, LayoutGroup)
                                                                                                                                            groupToExpandCollapse.Expanded = Not groupToExpandCollapse.Expanded
                                                                                                                                        End If
                                                                                                                                    End Sub)
                                                               menu.Tag = e.HitInfo.Item
                                                               e.Menu.Items.Add(menu)
                                                           End If
                                                       End Sub
        End Sub
        <CodeExampleCase("Expand/collapse group from Tree View's context menu"), CodeExampleHighlightTokens("DXMenuItem", "LayoutGroup"), CodeExampleUnderlineTokens("LayoutTreeViewPopupMenuShowing")>
        Public Shared Sub EventLayoutTreeViewPopupMenuShowing(ByVal layoutControl As LayoutControl)
            ' This example handles the LayoutTreeViewPopupMenuShowing event to add a 'Collapse'/'Expand' command to the context menu
            ' for groups in the 'Layout Tree View' tab in the Customization Form.
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            group.Name = "My Group"
            group.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo 1"})
            group.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo 2"})
            group.BestFit()
            AddHandler layoutControl.LayoutTreeViewPopupMenuShowing, Sub(s, e)
                                                                         If e.HitInfo.Item.Parent IsNot Nothing AndAlso e.HitInfo.Item.IsGroup Then
                                                                             Dim layoutGroup As LayoutGroup = TryCast(e.HitInfo.Item, LayoutGroup)
                                                                             Dim menu As New DXMenuItem(If(group.Expanded, "Collapse", "Expand"), Sub(sender, eventArgs)
                                                                                                                                                      If TypeOf sender Is DXMenuItem Then
                                                                                                                                                          Dim groupToExpandCollapse As LayoutGroup = TryCast((TryCast(sender, DXMenuItem)).Tag, LayoutGroup)
                                                                                                                                                          groupToExpandCollapse.Expanded = Not groupToExpandCollapse.Expanded
                                                                                                                                                      End If
                                                                                                                                                  End Sub)
                                                                             menu.Tag = e.HitInfo.Item
                                                                             e.Menu.Items.Add(menu)
                                                                         End If
                                                                     End Sub
            layoutControl.ShowCustomizationForm()
            group.Selected = True

        End Sub
        <CodeExampleCase("Drag items only within their parent groups"), CodeExampleHighlightTokens("EmptySpaceItem", "InsertType", "ILayoutControl"), CodeExampleUnderlineTokens("ItemDragging")>
        Public Shared Sub EventItemDragging(ByVal layoutControl As LayoutControl)
            'This example handles the ItemDragging event to prevent items from being moved between groups.
            Dim group1 As LayoutControlGroup = layoutControl.AddGroup()
            group1.AddItem(New EmptySpaceItem())
            group1.AddItem(New EmptySpaceItem())
            Dim group2 As LayoutControlGroup = layoutControl.AddGroup(group1, InsertType.Right)
            group2.AddItem(New EmptySpaceItem())
            group2.AddItem(New EmptySpaceItem())
            layoutControl.BestFit()
            AddHandler layoutControl.ItemDragging, Sub(s, e)
                                                       If e.DragController Is Nothing Then
                                                           Return
                                                       End If
                                                       If e.DragController.DragItem Is Nothing OrElse e.DragController.Item Is Nothing Then
                                                           Return
                                                       End If
                                                       If e.DragController.DragItem.Parent IsNot e.DragController.Item.Parent Then
                                                           e.AllowDrop = False
                                                       End If
                                                   End Sub
            DirectCast(layoutControl, ILayoutControl).EnableCustomizationMode = True
        End Sub
        <CodeExampleCase("Custom draw items"), CodeExampleHighlightTokens("EmptySpaceItem", "Color", "SolidBrush", "MemoEdit"), CodeExampleUnderlineTokens("CustomDraw"), CodeExampleVersionID(162)>
        Public Shared Sub CustomDraw(ByVal layoutControl As LayoutControl)
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            Dim item As LayoutControlItem = layoutControl.AddItem("Memo 1", New MemoEdit() With {.Text = "Memo1", .Name = "Memo1"})
            Dim addTabbedGroup As TabbedControlGroup = layoutControl.AddTabbedGroup()
            addTabbedGroup.AddTabPage()
            addTabbedGroup.AddTabPage()
            layoutControl.BestFit()
            'Custom draw LayoutControlGroup
            AddHandler group.CustomDraw, Sub(s, e)
                                             e.DefaultDraw()
                                             e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(50, 0, 255, 0)), e.Bounds)
                                             e.Handled = True
                                         End Sub
            'Custom draw LayoutControlItem
            AddHandler item.CustomDraw, Sub(s, e)
                                            e.DefaultDraw()
                                            e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(50, 255, 0, 0)), e.Bounds)
                                            e.Handled = True
                                        End Sub
            'Custom draw TabbedControlGroup
            AddHandler addTabbedGroup.CustomDraw, Sub(s, e)
                                                      e.DefaultDraw()
                                                      e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(50, 0, 0, 255)), e.Bounds)
                                                      e.Handled = True
                                                  End Sub
        End Sub

        <CodeExampleCase("CustomHeaderButtons In Group"), CodeExampleHighlightTokens("EmptySpaceItem", "GroupBoxButton", "ButtonStyle", "MessageBox"), CodeExampleUnderlineTokens("CustomButtonClick", "CustomButtonChecked", "CustomButtonUnchecked"), CodeExampleVersionID(162)>
        Public Shared Sub CustomHeaderButtonsInGroup(ByVal layoutControl As LayoutControl)
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            group.HeaderButtonsLocation = GroupElementLocation.AfterText
            group.CustomHeaderButtons.Add(New GroupBoxButton("Push Button", "Find;Size16x16;Office2013", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1))
            group.CustomHeaderButtons.Add(New GroupBoxButton("Check Button", "Apply;Size16x16;Office2013", DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1))
            AddHandler group.CustomButtonClick, Sub(s, e) MessageBox.Show(String.Format("{0} click", e.Button.Properties.Caption))
            AddHandler group.CustomButtonChecked, Sub(s, e) MessageBox.Show(String.Format("{0} checked", e.Button.Properties.Caption))
            AddHandler group.CustomButtonUnchecked, Sub(s, e) MessageBox.Show(String.Format("{0} Unchecked", e.Button.Properties.Caption))
        End Sub
        <CodeExampleCase("CustomHeaderButtons In Tabbed Group"), CodeExampleHighlightTokens("TabbedControlGroup", "CustomHeaderButton", "ButtonPredefines", "MessageBox", "Enum"), CodeExampleUnderlineTokens("CustomHeaderButtonClick"), CodeExampleVersionID(162)>
        Public Shared Sub CustomHeaderButtonsInTabbedGroup(ByVal layoutControl As LayoutControl)
            Dim tGroup As TabbedControlGroup = layoutControl.AddTabbedGroup()
            tGroup.AddTabPage()
            tGroup.AddTabPage()
            tGroup.CustomHeaderButtons.Add(New DevExpress.XtraTab.Buttons.CustomHeaderButton(ButtonPredefines.OK))
            tGroup.CustomHeaderButtons.Add(New DevExpress.XtraTab.Buttons.CustomHeaderButton(ButtonPredefines.Search))
            tGroup.CustomHeaderButtons.Add(New DevExpress.XtraTab.Buttons.CustomHeaderButton(ButtonPredefines.Delete))
            AddHandler tGroup.CustomHeaderButtonClick, Sub(s, e) MessageBox.Show(String.Format("{0} click", System.Enum.GetName(GetType(ButtonPredefines), e.Button.Kind)))
        End Sub

    End Class
    <CodeExampleClass("Flow layout", "SimpleClass.vb"), CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public NotInheritable Class FlowLayoutControl

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim layoutControl As New LayoutControl()
            layoutControl.Dock = DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            TryCast(sampleHost.Controls(0), LayoutControl).Dispose()
        End Sub
        <CodeExampleCase("Simple flow layout"), CodeExampleHighlightTokens("Size")>
        Public Shared Sub FlowSimpleLayout(ByVal layoutControl As LayoutControl)
            ' This example creates a flow layout consisting of a few Memo editors.
            ' Resize the window to see the flow layout in action.
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            For i As Integer = 1 To 7
                Dim caption As String = "Memo " & i
                group.AddItem(caption, New MemoEdit() With {.Name = caption})
            Next i
            group.BestFit()
            group.LayoutMode = LayoutMode.Flow
            For Each item As LayoutControlItem In group.Items
                item.Size = New Size(150, 80)
            Next item
        End Sub
        <CodeExampleCase("Wrap the flow"), CodeExampleHighlightTokens("Size")>
        Public Shared Sub FlowWrap(ByVal layoutControl As LayoutControl)
            ' This example creates a flow layout and forcibly wraps the flow after the 2nd item.
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            For i As Integer = 1 To 7
                Dim caption As String = "Memo " & i
                group.AddItem(caption, New MemoEdit() With {.Name = caption})
            Next i
            group.BestFit()
            group.LayoutMode = LayoutMode.Flow
            For Each item As LayoutControlItem In group.Items
                item.Size = New Size(150, 80)
            Next item
            group(2).StartNewLine = True
        End Sub
        <CodeExampleCase("Change FlowDirection"), CodeExampleHighlightTokens("Size", "ILayoutControl", "FlowDirection"), CodeExampleVersionID(162)>
        Public Shared Sub FlowChangeFlowDirection(ByVal layoutControl As LayoutControl)
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            group.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo 1"})
            group.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo 2"})
            group.AddItem("Memo 3", New MemoEdit() With {.Name = "Memo 3"})
            group.AddItem("Memo 4", New MemoEdit() With {.Name = "Memo 4"})
            group.BestFit()
            group.LayoutMode = LayoutMode.Flow
            For Each item As LayoutControlItem In group.Items
                item.Size = New Size(200, 100)
            Next item
            group.FlowDirection = FlowDirection.BottomUp
            'group.FlowDirection = FlowDirection.LeftToRight;
            'group.FlowDirection = FlowDirection.RightToLeft;
            'group.FlowDirection = FlowDirection.TopDown;

            ' Enable customization mode to see FlowDirection
            DirectCast(layoutControl, ILayoutControl).EnableCustomizationMode = True
        End Sub
        <CodeExampleCase("Rearrange items"), CodeExampleHighlightTokens("Size", "InsertType")>
        Public Shared Sub FlowRearrangeItems(ByVal layoutControl As LayoutControl)
            ' This example shows how to use the Move method to place an item next to another item.
            Dim group As LayoutControlGroup = layoutControl.AddGroup()
            group.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo 1"})
            group.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo 2"})
            group.AddItem("Memo 3", New MemoEdit() With {.Name = "Memo 3"})
            group.AddItem("Memo 4", New MemoEdit() With {.Name = "Memo 4"})
            group.BestFit()
            group.LayoutMode = LayoutMode.Flow
            For Each item As LayoutControlItem In group.Items
                item.Size = New Size(200, 100)
            Next item
            group(0).Move(group(3), InsertType.Right)
            group(2).Move(group(1), InsertType.Left)
        End Sub
    End Class
    <CodeExampleClass("Advanced examples", "SimpleClass.vb"), CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public NotInheritable Class AdvancedExamplesLayoutControl

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim layoutControl As New LayoutControl()
            layoutControl.Dock = DockStyle.Fill
            layoutControl.Parent = sampleHost
            Return New Object() {layoutControl}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            TryCast(sampleHost.Controls(0), LayoutControl).Dispose()
        End Sub
        <CodeExampleCase("Create custom 'fixed' item in Customization Form", New Type() {GetType(MyFixedLabelItem), GetType(MyFixedLabelPropertiesWrapper)}), CodeExampleHighlightTokens("Control", "MyFixedLabelItem", "LinkLabelLinkClickedEventArgs", "BasePropertyGridObjectWrapper", "IFixedLayoutControlItem", "ILayoutControl", "Image"), CodeExampleUnderlineTokens("LinkClicked")>
        Public Shared Sub AdvExamplesCustomFixedItem(ByVal layoutControl As LayoutControl)
            ' This example adds a custom link item to the Customization Form.
            ' You can add this item to the form using drag-and-drop, and change the link text in the Properties grid.
            layoutControl.OptionsCustomizationForm.ShowPropertyGrid = True
            layoutControl.RegisterCustomPropertyGridWrapper(GetType(MyFixedLabelItem), GetType(MyFixedLabelPropertiesWrapper))
            layoutControl.RegisterFixedItemType(GetType(MyFixedLabelItem))
            layoutControl.ShowCustomizationForm()
        End Sub
        <CodeExampleNestedClass("The custom 'fixed' item")>
        Public Class MyFixedLabelItem
            Inherits LayoutControlItem
            Implements IFixedLayoutControlItem

            ' Must return the name of the item's type
            Public Overrides ReadOnly Property TypeName() As String Implements IFixedLayoutControlItem.TypeName
                Get
                    Return "MyFixedLabelItem"
                End Get
            End Property
            Private linkCore As String
            Private controlCore As Control = Nothing

            Public Property Link() As String
                Get
                    Return linkCore
                End Get
                Set(ByVal value As String)
                    If Link = value Then
                        Return
                    End If
                    Me.linkCore = value
                    OnLinkChanged()
                End Set
            End Property
            Private Sub label_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs)
                '...
            End Sub
            Public Overrides Property Text() As String
                Get
                    Return Link
                End Get
                Set(ByVal value As String)
                    Link = value
                End Set
            End Property
            ' This method is called when the Link property is changed.
            ' It assigns the new link to the embedded LinkLabel control.
            Protected Sub OnLinkChanged()
                controlCore.Text = Link
            End Sub

            ' Initialize the item.
            Private Sub IFixedLayoutControlItem_OnInitialize() Implements IFixedLayoutControlItem.OnInitialize
                Me.linkCore = "www.devexpress.com"
                OnLinkChanged()
                TextVisible = False
            End Sub
            ' Create and return the item's control.
            Private Function IFixedLayoutControlItem_OnCreateControl() As Control Implements IFixedLayoutControlItem.OnCreateControl
                Me.controlCore = New LinkLabel()
                AddHandler CType(controlCore, LinkLabel).LinkClicked, AddressOf label_LinkClicked
                Return controlCore
            End Function
            ' Destroy the item's control.
            Private Sub IFixedLayoutControlItem_OnDestroy() Implements IFixedLayoutControlItem.OnDestroy
                If controlCore IsNot Nothing Then
                    RemoveHandler CType(controlCore, LinkLabel).LinkClicked, AddressOf label_LinkClicked
                    controlCore.Dispose()
                    controlCore = Nothing
                End If
            End Sub
            Private ReadOnly Property IFixedLayoutControlItem_CustomizationName() As String Implements IFixedLayoutControlItem.CustomizationName
                Get
                    Return "DevExpress Link"
                End Get
            End Property
            Private ReadOnly Property IFixedLayoutControlItem_CustomizationImage() As Image Implements IFixedLayoutControlItem.CustomizationImage
                Get
                    Return Nothing
                End Get
            End Property
            Private ReadOnly Property IFixedLayoutControlItem_AllowChangeTextLocation() As Boolean Implements IFixedLayoutControlItem.AllowChangeTextLocation
                Get
                    Return False
                End Get
            End Property
            Private ReadOnly Property IFixedLayoutControlItem_AllowChangeTextVisibility() As Boolean Implements IFixedLayoutControlItem.AllowChangeTextVisibility
                Get
                    Return False
                End Get
            End Property
            Private ReadOnly Property IFixedLayoutControlItem_AllowClipText() As Boolean Implements IFixedLayoutControlItem.AllowClipText
                Get
                    Return False
                End Get
            End Property
            Private Property IFixedLayoutControlItem_Owner() As ILayoutControl Implements IFixedLayoutControlItem.Owner
                Get
                    Return MyBase.Owner
                End Get
                Set(ByVal value As ILayoutControl)
                    MyBase.Owner = value
                End Set
            End Property
        End Class
        <CodeExampleNestedClass("Specifies which properties to display in the Property Grid")>
        Public Class MyFixedLabelPropertiesWrapper
            Inherits BasePropertyGridObjectWrapper

            Protected ReadOnly Property Label() As MyFixedLabelItem
                Get
                    Return TryCast(WrappedObject, MyFixedLabelItem)
                End Get
            End Property
            <Description("The link's text")>
            Public Property Link() As String
                Get
                    Return Label.Link
                End Get
                Set(ByVal value As String)
                    Label.Link = value
                End Set
            End Property
            Public Overrides Function Clone() As BasePropertyGridObjectWrapper
                Return New MyFixedLabelPropertiesWrapper()
            End Function
        End Class
        <CodeExampleCase("Provide custom Customization Form and override button actions", New Type() {GetType(MyCustomizationForm)}), CodeExampleHighlightTokens("MyCustomizationForm", "MyButtonsPanel", "ButtonsPanel", "MessageBox", "CustomizationForm", "EventArgs"), CodeExampleUnderlineTokens("RegisterUserCustomizationForm"), CodeExampleVersionID(162)>
        Public Shared Sub AdvExamplesCustomCustomizationForm(ByVal layoutControl As LayoutControl)
            ' This example replaces the standard Customization Form with a custom one.
            ' Actions for the Customization Form's buttons are overridden to display message boxes.
            layoutControl.OptionsCustomizationForm.ShowPropertyGrid = True
            layoutControl.RegisterUserCustomizationForm(GetType(MyCustomizationForm))
            layoutControl.ShowCustomizationForm()
        End Sub
        <CodeExampleNestedClass("")>
        Public Class MyCustomizationForm
            Inherits CustomizationForm

            Protected Overrides Sub OnSaveLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs)
                MessageBox.Show("'Save Layout' button click")
                MyBase.OnSaveLayoutButtonClick(sender, e)

            End Sub
            Protected Overrides Sub OnLoadLayoutButtonClick(ByVal sender As Object, ByVal e As EventArgs)
                MessageBox.Show("'Load Layout' button click")
                MyBase.OnLoadLayoutButtonClick(sender, e)

            End Sub

            Protected Overrides Sub OnRedoButtonClick(ByVal sender As Object, ByVal e As EventArgs)
                MessageBox.Show("'Redo' button click")
                MyBase.OnRedoButtonClick(sender, e)
            End Sub

            Protected Overrides Sub OnUndoButtonClick(ByVal sender As Object, ByVal e As EventArgs)
                MessageBox.Show("'Undo' button click")
                MyBase.OnUndoButtonClick(sender, e)
            End Sub

        End Class
        <CodeExampleCase("Display custom properties for items in Customization Form", New Type() {GetType(MyLayoutControlItemPropertyWrapper)}), CodeExampleHighlightTokens("LayoutControlItemWrapper", "MyLayoutControlItemPropertyWrapper", "AutoCompleteType", "Category", "DefaultValue", "MaskType", "BasePropertyGridObjectWrapper"), CodeExampleUnderlineTokens("RegisterCustomPropertyGridWrapper")>
        Public Shared Sub AdvExamplesCustomPropertiesInCustomizationForm(ByVal layoutControl As LayoutControl)
            ' This example shows how to extend properties displayed in the Customization Form's Property Grid when an item is selected.
            ' A few mask-specific settings are added to the 'Mask' category.
            layoutControl.OptionsCustomizationForm.ShowPropertyGrid = True
            Dim textEdit1 As New TextEdit() With {.Name = "TextEdit"}
            Dim item As LayoutControlItem = layoutControl.Root.AddItem("Text Edit", textEdit1)
            layoutControl.RegisterCustomPropertyGridWrapper(GetType(LayoutControlItem), GetType(MyLayoutControlItemPropertyWrapper))
            layoutControl.ShowCustomizationForm()
            ' Select the created item.
            item.Selected = True
        End Sub
        <CodeExampleNestedClass("")>
        Public Class MyLayoutControlItemPropertyWrapper
            Inherits LayoutControlItemWrapper

            Protected ReadOnly Property Editor() As TextEdit
                Get
                    Return TryCast(Item.Control, TextEdit)
                End Get
            End Property

            <Category("Mask"), DefaultValue(AutoCompleteType.Default)>
            Public Property AutoComplete() As AutoCompleteType
                Get
                    If Editor IsNot Nothing Then
                        Return Editor.Properties.Mask.AutoComplete
                    Else
                        Return AutoCompleteType.Default
                    End If
                End Get
                Set(ByVal value As AutoCompleteType)
                    If Editor IsNot Nothing Then
                        Editor.Properties.Mask.AutoComplete = value
                    End If
                End Set
            End Property

            <Category("Mask"), DefaultValue(False)>
            Public Property BeepOnError() As Boolean
                Get
                    If Editor IsNot Nothing Then
                        Return Editor.Properties.Mask.BeepOnError
                    Else
                        Return False
                    End If
                End Get
                Set(ByVal value As Boolean)
                    If Editor IsNot Nothing Then
                        Editor.Properties.Mask.BeepOnError = value
                    End If
                End Set
            End Property

            <Category("Mask"), DefaultValue("")>
            Public Property EditMask() As String
                Get
                    If Editor IsNot Nothing Then
                        Return Editor.Properties.Mask.EditMask
                    Else
                        Return String.Empty
                    End If
                End Get
                Set(ByVal value As String)
                    If Editor IsNot Nothing Then
                        Editor.Properties.Mask.EditMask = value
                    End If
                End Set
            End Property

            <Category("Mask"), DefaultValue(True)>
            Public Property IgnoreMaskBlank() As Boolean
                Get
                    If Editor IsNot Nothing Then
                        Return Editor.Properties.Mask.IgnoreMaskBlank
                    Else
                        Return True
                    End If
                End Get
                Set(ByVal value As Boolean)
                    If Editor IsNot Nothing Then
                        Editor.Properties.Mask.IgnoreMaskBlank = True
                    End If
                End Set
            End Property

            <Category("Mask"), DefaultValue(MaskType.None)>
            Public Property MaskType() As MaskType
                Get
                    If Editor IsNot Nothing Then
                        Return Editor.Properties.Mask.MaskType
                    Else
                        Return MaskType.None
                    End If
                End Get
                Set(ByVal value As MaskType)
                    If Editor IsNot Nothing Then
                        Editor.Properties.Mask.MaskType = value
                    End If
                End Set
            End Property

            <Category("Mask"), DefaultValue(ControlChars.NullChar)>
            Public Property PlaceHolder() As Char
                Get
                    If Editor IsNot Nothing Then
                        Return Editor.Properties.Mask.PlaceHolder
                    Else
                        Return ControlChars.NullChar
                    End If
                End Get
                Set(ByVal value As Char)
                    If Editor IsNot Nothing Then
                        Editor.Properties.Mask.PlaceHolder = ControlChars.NullChar
                    End If
                End Set
            End Property

            <Category("Mask"), DefaultValue(True)>
            Public Property SaveLiteral() As Boolean
                Get
                    If Editor IsNot Nothing Then
                        Return Editor.Properties.Mask.SaveLiteral
                    Else
                        Return True
                    End If
                End Get
                Set(ByVal value As Boolean)
                    If Editor IsNot Nothing Then
                        Editor.Properties.Mask.SaveLiteral = value
                    End If
                End Set
            End Property

            <Category("Mask"), DefaultValue(True)>
            Public Property ShowPlaceHolders() As Boolean
                Get
                    If Editor IsNot Nothing Then
                        Return Editor.Properties.Mask.ShowPlaceHolders
                    Else
                        Return True
                    End If
                End Get
                Set(ByVal value As Boolean)
                    If Editor IsNot Nothing Then
                        Editor.Properties.Mask.ShowPlaceHolders = value
                    End If
                End Set
            End Property

            <Category("Mask"), DefaultValue(False)>
            Public Property UseMaskAsDisplayFormat() As Boolean
                Get
                    If Editor IsNot Nothing Then
                        Return Editor.Properties.Mask.UseMaskAsDisplayFormat
                    Else
                        Return False
                    End If
                End Get
                Set(ByVal value As Boolean)
                    If Editor IsNot Nothing Then
                        Editor.Properties.Mask.UseMaskAsDisplayFormat = value
                    End If
                End Set
            End Property

            Public Overrides Function Clone() As BasePropertyGridObjectWrapper
                Return New MyLayoutControlItemPropertyWrapper()
            End Function
        End Class
        <CodeExampleCase("Custom paint group captions", New Type() {GetType(MyLayoutControl), GetType(MyLayoutControlImplementor), GetType(MySkinGroupObjectPainter), GetType(MyLayoutSkinPaintStyle)}), CodeExampleHighlightTokens("MyLayoutControl", "MyLayoutControlImplementor", "MySkinGroupObjectPainter", "MyLayoutSkinPaintStyle", "LayoutControl", "ILayoutControlOwner", "DockStyle", "Color", "GroupObjectInfoArgs", "LayoutOffice2003PaintStyle", "ISupportLookAndFeel", "LayoutWindowsXPPaintStyle", "Style3DPaintStyle", "UltraFlatPaintStyle", "FlatPaintStyle", "GroupObjectPainter", "LayoutControlImplementor", "IPanelControlOwner", "ISkinProvider", "SkinGroupObjectPainter", "LayoutSkinPaintStyle"), CodeExampleUnderlineTokens("RegisterCustomPropertyGridWrapper")>
        Public Shared Sub AdvExamplesCustomPaintGroupCaptions(ByVal layoutControl As LayoutControl)
            ' This example creates a LayoutControl descendant to override the group caption painting method.
            Dim sampleHost As XtraUserControl = TryCast(layoutControl.Parent, XtraUserControl)
            sampleHost.Controls.Clear()
            Dim myLayoutControl As New MyLayoutControl()
            myLayoutControl.Dock = DockStyle.Fill
            sampleHost.Controls.Add(myLayoutControl)
            myLayoutControl.Root.AddGroup("Group 1")
            myLayoutControl.Root.AddGroup("Group 2")
            myLayoutControl.BestFit()
        End Sub
        <CodeExampleNestedClass("")>
        Public Class MySkinGroupObjectPainter
            Inherits SkinGroupObjectPainter

            Public Sub New(ByVal owner As IPanelControlOwner, ByVal provider As ISkinProvider)
                MyBase.New(owner, provider)
            End Sub
            Protected Overrides Sub DrawCaption(ByVal info As GroupObjectInfoArgs)
                If info.CaptionBounds.IsEmpty Then
                    Return
                End If
                info.Cache.FillRectangle(info.Cache.GetSolidBrush(Color.PowderBlue), info.CaptionBounds)
                DrawButton(info)
                DrawVString(info.Cache, info.AppearanceCaption, info.Caption, info.TextBounds, GetRotateAngle(info))
            End Sub

        End Class
        <CodeExampleNestedClass("")>
        Public Class MyLayoutControlImplementor
            Inherits LayoutControlImplementor

            Public Sub New(ByVal owner As ILayoutControlOwner)
                MyBase.New(owner)
            End Sub
            Protected Overrides Sub InitializePaintStyles()
                Dim lookAndFeelOwner As ISupportLookAndFeel = owner.GetISupportLookAndFeel()
                If lookAndFeelOwner IsNot Nothing Then
                    PaintStyles.Add(New LayoutOffice2003PaintStyle(lookAndFeelOwner))
                    PaintStyles.Add(New LayoutWindowsXPPaintStyle(lookAndFeelOwner))
                    '
                    ' TODO: Add your owner PaintStyle instead of PaintStyles.Add(new LayoutSkinPaintStyle(lookAndFeelOwner));
                    '
                    PaintStyles.Add(New MyLayoutSkinPaintStyle(lookAndFeelOwner))

                    PaintStyles.Add(New Style3DPaintStyle(lookAndFeelOwner))
                    PaintStyles.Add(New UltraFlatPaintStyle(lookAndFeelOwner))
                    PaintStyles.Add(New FlatPaintStyle(lookAndFeelOwner))
                End If
                lookAndFeelOwner = Nothing
            End Sub
        End Class
        <CodeExampleNestedClass("")>
        Public Class MyLayoutSkinPaintStyle
            Inherits LayoutSkinPaintStyle

            Public Sub New(ByVal lookAndFeelOwner As ISupportLookAndFeel)
                MyBase.New(lookAndFeelOwner)
            End Sub

            Public Overrides Function CreateGroupPainter(ByVal owner As IPanelControlOwner) As GroupObjectPainter
                Return New MySkinGroupObjectPainter(owner, LookAndFeel)
            End Function


        End Class
        <CodeExampleNestedClass("")>
        Public Class MyLayoutControl
            Inherits LayoutControl

            Protected Overrides Function CreateILayoutControlImplementorCore() As LayoutControlImplementor
                Return New MyLayoutControlImplementor(Me)
            End Function
        End Class


    End Class
    <CodeExampleClass("DataLayoutControl", "SimpleClass.vb"), CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "SizeType", "LayoutType", "Size", "LayoutMode", "SizeConstraintsType")>
    Public NotInheritable Class DataLayoutControlExample

        Private Sub New()
        End Sub

        <CodeExampleSetUp>
        Public Shared Function SetUp(ByVal sampleHost As XtraUserControl) As Object()
            Dim dataLayoutControl As New DataLayoutControl()
            dataLayoutControl.Dock = DockStyle.Fill
            dataLayoutControl.Parent = sampleHost
            Return New Object() {dataLayoutControl}
        End Function
        <CodeExampleTearDown>
        Public Shared Sub TearDown(ByVal sampleHost As XtraUserControl)
            TryCast(sampleHost.Controls(0), LayoutControl).Dispose()
        End Sub
        <CodeExampleNestedClass("")>
        Public Class MyClassWithAttributes
            Public Enum GenderEnum
                Male
                Female
            End Enum
            'Do not generate a layout item (editor) for the ID field.
            <Display(AutoGenerateField:=False)>
            Public Property ID() As Integer

            ' Specify the display format for the Age field.
            <DisplayFormat(DataFormatString:="d2", ApplyFormatInEditMode:=True)>
            Public Property Age() As Integer

            ' Disable editing.
            <Editable(False)>
            Public Property Employer() As String

            ' Override the display name, specify the order and mark the field as required.
            <Display(Name:="First name", Order:=0), Required>
            Public Property FirstName() As String

            <Display(Name:="Full name", Order:=2)>
            Public ReadOnly Property FullName() As String
                Get
                    Return FirstName & " " & LastName
                End Get
            End Property
            <Display(ShortName:="Sex", Order:=3)>
            Public Property Gender() As GenderEnum
            <Display(Name:="Last name", Order:=1), Required>
            Public Property LastName() As String

            ' The editor will be read-only.
            <ReadOnlyAttribute(True)>
            Public Property SSN() As String

            ' Specify the text displayed when the editor's value is null.
            <DisplayFormat(NullDisplayText:="Department not set")>
            Public Property Department() As String
        End Class
        <CodeExampleCase("Simple attributes: names, visibility, order, display format, etc.", New Type() {GetType(MyClassWithAttributes)}), CodeExampleHighlightTokens("DisplayFormat", "MyClassWithAttributes", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable"), CodeExampleUnderlineTokens("RetrieveFields")>
        Public Shared Sub DataAnnotationSimpleAttributesExample(ByVal dataLayoutControl1 As DataLayoutControl)
            ' In this example, the DataLayoutControl automatically builds a layout for editing a MyClassWithAttributes object
            ' taking into account the DataAnnotations attributes applied to the object's properties
            Dim source As New BindingSource()
            source.DataSource = New MyClassWithAttributes()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.RetrieveFields()
            dataLayoutControl1.BestFit()
        End Sub
        <CodeExampleNestedClass()>
        Public Class MyClassWithDataTypeAttributes
            Public Enum GenderEnum
                Male
                Female
            End Enum
            Public Property BoolProperty() As Boolean
            Public Property EnumProperty() As GenderEnum
            Public Property StringProperty() As String
            Public Property DateTimeProperty() As Date

            <DataType(DataType.Currency)>
            Public Property CurrencyProperty() As Decimal
            <DataType(DataType.MultilineText)>
            Public Property MultilineTextProperty() As String
            <DataType(DataType.Password)>
            Public Property PasswordProperty() As String
            <DataType(DataType.PhoneNumber)>
            Public Property PhoneNumberProperty() As String
        End Class
        <CodeExampleCase("Specify editors and their settings", New Type() {GetType(MyClassWithDataTypeAttributes)}), CodeExampleHighlightTokens("MyClassWithDataTypeAttributes", "BindingSource", "GenderEnum", "DataType", "DateTime", "ReadOnlyAttribute", "Editable"), CodeExampleUnderlineTokens("RetrieveFields")>
        Public Shared Sub DataAnnotationDataTypeAttributeExample(ByVal dataLayoutControl1 As DataLayoutControl)
            ' In this example, the DataLayoutControl automatically builds a layout for editing a MyClassWithDataTypeAttributes object
            ' taking into account the DataAnnotation.DataType attributes applied to the object's properties.
            Dim source As New BindingSource()
            source.DataSource = New MyClassWithDataTypeAttributes()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.RetrieveFields()
            dataLayoutControl1.BestFit()
        End Sub
        <CodeExampleNestedClass("")>
        Public Class MyClassSimpleGroupedLayout
            Private Const JobGroup As String = "Job"
            Private Const ContactGroup As String = "Contact"
            Private Const AddressGroup As String = "Address"
            Private Const PersonalGroup As String = "Personal"

            <Display(GroupName:=AddressGroup, ShortName:="", Order:=4)>
            Public Property AddressLine1() As String
            <Display(GroupName:=AddressGroup, ShortName:="")>
            Public Property AddressLine2() As String
            <Display(GroupName:=PersonalGroup, Name:="Birth date")>
            Public Property BirthDate() As Date
            <Display(GroupName:=ContactGroup)>
            Public Property Email() As String
            <Display(Name:="First name", Order:=0)>
            Public Property FirstName() As String
            <Display(GroupName:=PersonalGroup, Order:=5)>
            Public Property Gender() As GenderEnum
            <Display(GroupName:=JobGroup, Order:=2)>
            Public Property Group() As String
            <Display(GroupName:=JobGroup, Name:="Hire date")>
            Public Property HireDate() As Date
            <Display(Name:="Last name", Order:=1)>
            Public Property LastName() As String
            <Display(GroupName:=ContactGroup, Order:=3), DataType(DataType.PhoneNumber)>
            Public Property Phone() As String
            <Display(GroupName:=JobGroup), DataType(DataType.Currency)>
            Public Property Salary() As Decimal
            <Display(GroupName:=JobGroup, Order:=21)>
            Public Property Title() As String
            Public Enum GenderEnum
                Male
                Female
            End Enum
        End Class
        <CodeExampleCase("Grouping and order", New Type() {GetType(MyClassSimpleGroupedLayout)}), CodeExampleHighlightTokens("MyClassSimpleGroupedLayout", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType"), CodeExampleUnderlineTokens("RetrieveFields")>
        Public Shared Sub DataAnnotationSimpleGroupingExample(ByVal dataLayoutControl1 As DataLayoutControl)
            ' In this example, the DataLayoutControl automatically builds a layout for editing a MyClassSimpleGroupedLayout object.
            ' A layout item with an editor is generated for each property of the MyClassSimpleGroupedLayout object.
            ' The layout items are placed into regular groups according to the DataAnnotation.Display attributes applied to the properties.
            Dim source As New BindingSource()
            source.DataSource = New MyClassSimpleGroupedLayout()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.RetrieveFields()
            dataLayoutControl1.BestFit()
        End Sub
        <CodeExampleNestedClass("")>
        Public Class MyClassTabsLayout
            ' The two items below will be displayed by DataLayoutControl  
            ' in a borderless Name group with no title. 
            <Display(GroupName:="<Name|>", Name:="Last name")>
            Public Property LastName() As String
            <Display(GroupName:="<Name|>", Name:="First name", Order:=0)>
            Public Property FirstName() As String
            'The four items below will go to a Contact tab within tabbed Tabs group. 
            <Display(GroupName:="{Tabs}/Contact", Order:=2), DataType(DataType.PhoneNumber)>
            Public Property Phone() As String
            <Display(GroupName:="{Tabs}/Contact", Order:=4), DataType(DataType.EmailAddress)>
            Public Property Email() As String
            'The two items below will go to the Address group within the Contact tab. 
            <Display(GroupName:="{Tabs}/Contact/Address", ShortName:="")>
            Public Property AddressLine1() As String
            <Display(GroupName:="{Tabs}/Contact/Address", ShortName:="")>
            Public Property AddressLine2() As String
            'The two items below will go to horizontally oriented Personal group. 
            <Display(GroupName:="Personal-", Name:="Birth date")>
            Public Property BirthDate() As Date
            <Display(GroupName:="Personal-", Order:=3)>
            Public Property Gender() As GenderEnum
            'The four items below will go to the Job tab of the tabbed Tabs group 
            <Display(GroupName:="{Tabs}/Job", Order:=6)>
            Public Property Group() As String
            <Display(GroupName:="{Tabs}/Job", Name:="Hire date")>
            Public Property HireDate() As Date
            <Display(GroupName:="{Tabs}/Job"), DataType(DataType.Currency)>
            Public Property Salary() As Decimal
            <Display(GroupName:="{Tabs}/Job", Order:=7)>
            Public Property Title() As String
            Public Enum GenderEnum
                Male
                Female
            End Enum
        End Class
        <CodeExampleCase("Advanced grouping", New Type() {GetType(MyClassTabsLayout)}), CodeExampleHighlightTokens("MyClassTabsLayout", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType"), CodeExampleUnderlineTokens("RetrieveFields")>
        Public Shared Sub DataAnnotationAdvGroupingExample(ByVal dataLayoutControl1 As DataLayoutControl)
            ' In this example, the DataLayoutControl automatically builds a layout for editing a MyClassTabsLayout object.
            ' A layout item with an editor is generated for each property of the MyClassTabsLayout object.
            ' The layout items are placed into regular and tabbed groups according to the DataAnnotation.Display attributes applied to the properties.
            Dim source As New BindingSource()
            source.DataSource = New MyClassTabsLayout()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.RetrieveFields()
            dataLayoutControl1.BestFit()
        End Sub
        <CodeExampleNestedClass("")>
        Public Class Person
            Private Const GroupForName As String = "<groupForName->"
            Private Const GroupForPhone As String = "<groupForPhone->"
            Private Const GroupForBirthDate As String = "<groupForBD->"
            <Display(GroupName:=GroupForName)>
            Public Property FirstName() As String
            <Display(GroupName:=GroupForName)>
            Public Property LastName() As String
            Public ReadOnly Property FullName() As String
                Get
                    Return FirstName & " " & LastName
                End Get
            End Property
            <Display(GroupName:=GroupForPhone)>
            Public Property Phone() As String
            <Display(GroupName:=GroupForPhone)>
            Public Property Email() As String
            <Display(GroupName:=GroupForBirthDate)>
            Public Property BirthDate() As Date
            <Display(GroupName:=GroupForBirthDate)>
            Public Property Gender() As GenderEnum
            Public Enum GenderEnum
                Male
                Female
            End Enum
            <Display(GroupName:="Address")>
            Public Property AddressInfo() As AddressClass
        End Class
        <CodeExampleNestedClass("")>
        Public Class AddressClass
            Private Const GroupForCity As String = "<groupForCity->"
            Private Const GroupForAddressLine As String = "<groupForAddressLine->"
            Private Const GroupForLocation As String = "<groupForLocation->"
            <Display(GroupName:=GroupForCity)>
            Public Property City() As String
            <Display(GroupName:=GroupForCity)>
            Public Property State() As String
            <Display(Name:="Address", GroupName:=GroupForAddressLine)>
            Public Property Line() As String
            <Display(GroupName:=GroupForAddressLine)>
            Public Property ZipCode() As String
            <Display(GroupName:=GroupForLocation)>
            Public Property Latitude() As Double
            <Display(GroupName:=GroupForLocation)>
            Public Property Longitude() As Double
        End Class
        <CodeExampleCase("Nested object example", New Type() {GetType(Person), GetType(AddressClass)}), CodeExampleHighlightTokens("DefaultBoolean", "RetrieveFieldsParameters", "Person", "AddressClass", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType"), CodeExampleUnderlineTokens("RetrieveFields")>
        Public Shared Sub DataLayoutBindToMultipleClass(ByVal dataLayoutControl1 As DataLayoutControl)
            ' In this example, the DataLayoutControl automatically builds a layout for editing the Person and nested Address objects.
            ' To edit the nested Address object's properties, a group of items is automatically generated.
            ' The RetrieveFields method is called with the DataSourceUpdateMode parameter set to 'OnPropertyChanged'.
            ' This causes data to be posted to the underlying object immediately on text entering.
            Dim source As New BindingSource()
            source.DataSource = New Person()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.AllowGeneratingNestedGroups = DefaultBoolean.True
            Dim parameters As New RetrieveFieldsParameters()
            parameters.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged
            dataLayoutControl1.RetrieveFields(parameters)
        End Sub

        <CodeExampleCase("Customize properties of auto-generated Layout items and controls", New Type() {GetType(Person), GetType(AddressClass)}), CodeExampleHighlightTokens("Color", "DefaultBoolean", "RetrieveFieldsParameters", "Person", "AddressClass", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType"), CodeExampleUnderlineTokens("FieldRetrieved")>
        Public Shared Sub DataLayoutControlFieldRetrieved(ByVal dataLayoutControl1 As DataLayoutControl)
            'In this example, the FieldRetrieved event is handled to customize auto-generated controls' properties.
            Dim source As New BindingSource()
            source.DataSource = New Person()
            dataLayoutControl1.AllowGeneratingNestedGroups = DefaultBoolean.True
            dataLayoutControl1.DataSource = source
            AddHandler dataLayoutControl1.FieldRetrieved, Sub(s, e)
                                                              If e.FieldName = "FirstName" OrElse e.FieldName = "LastName" Then
                                                                  e.Control.BackColor = Color.GreenYellow
                                                              End If
                                                          End Sub
            dataLayoutControl1.RetrieveFields()
        End Sub
        <CodeExampleCase("Customize binding info and editor type", New Type() {GetType(Person), GetType(AddressClass)}), CodeExampleHighlightTokens("DataSourceUpdateMode", "ComboBoxEdit", "DefaultBoolean", "RetrieveFieldsParameters", "Person", "AddressClass", "BindingSource", "GenderEnum", "Display", "Required", "ReadOnlyAttribute", "Editable", "DataType"), CodeExampleUnderlineTokens("FieldRetrieving")>
        Public Shared Sub DataLayoutControlFieldRetrieving(ByVal dataLayoutControl1 As DataLayoutControl)
            'In this example, the FieldRetrieving event is handled to customize the binding info and editor type.
            Dim source As New BindingSource()
            source.DataSource = New Person()
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.AllowGeneratingNestedGroups = DefaultBoolean.True
            AddHandler dataLayoutControl1.FieldRetrieving, Sub(s, e)
                                                               If e.FieldName = "AddressInfo.ZipCode" Then
                                                                   e.EditorType = GetType(ComboBoxEdit)
                                                               End If
                                                               e.DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged
                                                               e.Handled = True
                                                           End Sub
            dataLayoutControl1.RetrieveFields()
        End Sub


        <CodeExampleNestedClass("")>
        Public Class CollectionData
            Public Property Employees() As List(Of Person)
            Public Property BoolProperty() As Boolean
            Public Property StringProperty() As String
        End Class
        <CodeExampleCase("Generate CollectionProperties", New Type() {GetType(CollectionData), GetType(Person), GetType(AddressClass)}), CodeExampleHighlightTokens("DisplayFormat", "CollectionData", "BindingSource", "Person", "List", "Display"), CodeExampleUnderlineTokens("AllowGeneratingCollectionProperties"), CodeExampleVersionID(162)>
        Public Shared Sub DataLayoutControlCollectionProperties(ByVal dataLayoutControl1 As DataLayoutControl)
            Dim source As New BindingSource()
            source.DataSource = New CollectionData() With {
                .Employees = New List(Of Person)() From {New Person()}
            }
            dataLayoutControl1.AllowGeneratingCollectionProperties = DefaultBoolean.True
            dataLayoutControl1.DataSource = source
            dataLayoutControl1.RetrieveFields()
            dataLayoutControl1.BestFit()
        End Sub

    End Class
End Namespace
