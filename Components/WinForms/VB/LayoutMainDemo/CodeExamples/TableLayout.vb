Imports System
Imports DevExpress.XtraLayout
Imports DevExpress.Utils
Imports System.Globalization
Imports DevExpress.XtraEditors
Imports DevExpress.DXperience.Demos.CodeDemo
Imports System.Windows.Forms
Imports DevExpress.XtraLayout.Utils
Imports System.Linq
Imports DevExpress.Utils.Design

Namespace Examples
    <CodeExampleClass("Table layout", "TableLayout.vb"), CodeExampleHighlightTokens("LayoutControlItem", "BaseLayoutItem", "LayoutControlGroup", "TabbedControlGroup", "MemoEdit", "PictureEdit", "TextEdit", "DateEdit", "InsertType", "Point", "ColumnDefinition", "RowDefinition")>
    Public NotInheritable Class TableLayout

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
        <CodeExampleCase("Two table items")>
        Public Shared Sub TableLayoutSimple(ByVal layoutControl As LayoutControl)
            ' A layout consisting of two items.
            ' When Table Layout mode is enabled, two rows and two columns are automatically created.
            ' The first item is implicitly positioned in the cell (col=0, row=0).
            ' The second item is explicitly positioned in the cell (col=1, row=1).
            layoutControl.Root.LayoutMode = LayoutMode.Table
            Dim item1 As LayoutControlItem = layoutControl.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo1"})
            Dim item2 As LayoutControlItem = layoutControl.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo2"})
            item2.OptionsTableLayoutItem.RowIndex = 1
            item2.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub
        <CodeExampleCase("Rows and columns")>
        Public Shared Sub TableLayoutRowsAndColumns(ByVal layoutControl As LayoutControl)
            ' A layout consisting of five items explicitly positioned within table cells.
            ' Two items occupy more than one cell.

            layoutControl.Root.LayoutMode = LayoutMode.Table

            'After enabling Table mode, two columns already exist. Add one more column.
            Dim columnDefinition3 As New ColumnDefinition()
            columnDefinition3.SizeType = SizeType.Percent
            columnDefinition3.Width = 50
            layoutControl.Root.OptionsTableLayoutGroup.ColumnDefinitions.Add(columnDefinition3)

            'Two rows already exist. Add one more row.
            Dim rowDefinition3 As New RowDefinition()
            rowDefinition3.SizeType = SizeType.Percent
            rowDefinition3.Height = 50
            layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions.Add(rowDefinition3)

            ' Create controls and position them within table cells.
            Dim item1 As LayoutControlItem = layoutControl.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo1"})
            Dim item2 As LayoutControlItem = layoutControl.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo2"})
            Dim item3 As LayoutControlItem = layoutControl.AddItem("Memo 3", New MemoEdit() With {.Name = "Memo3"})
            Dim item4 As LayoutControlItem = layoutControl.AddItem("Memo 4", New MemoEdit() With {.Name = "Memo4"})
            Dim item5 As LayoutControlItem = layoutControl.AddItem("Memo 5", New MemoEdit() With {.Name = "Memo5"})

            item1.OptionsTableLayoutItem.RowIndex = 0
            item1.OptionsTableLayoutItem.ColumnIndex = 0

            item2.OptionsTableLayoutItem.RowIndex = 0
            item2.OptionsTableLayoutItem.ColumnIndex = 2

            item3.OptionsTableLayoutItem.RowIndex = 1
            item3.OptionsTableLayoutItem.ColumnIndex = 0
            item3.OptionsTableLayoutItem.RowSpan = 2

            item4.OptionsTableLayoutItem.RowIndex = 1
            item4.OptionsTableLayoutItem.ColumnIndex = 1

            item5.OptionsTableLayoutItem.RowIndex = 2
            item5.OptionsTableLayoutItem.ColumnIndex = 1
            item5.OptionsTableLayoutItem.ColumnSpan = 2

        End Sub

        <CodeExampleCase("Absolute row height")>
        Public Shared Sub TableLayoutAbsoluteRowHeight(ByVal layoutControl As LayoutControl)
            ' This example sets a row's height to an absolute value.
            layoutControl.Root.LayoutMode = LayoutMode.Table
            ' When Table Layout mode is enabled, two rows and two columns are automatically created.
            ' Access the first row.
            Dim row1 As RowDefinition = layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions(0)
            row1.SizeType = System.Windows.Forms.SizeType.Absolute
            row1.Height = 100
            layoutControl.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo1"})
            Dim item As LayoutControlItem = layoutControl.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo2"})
            item.OptionsTableLayoutItem.RowIndex = 1
            item.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub
        <CodeExampleCase("Auto-sized row"), CodeExampleHighlightTokens("DxImageAssemblyUtil", "ImageSize", "ImageType", "Size")>
        Public Shared Sub TableLayoutAutoSizedRow(ByVal layoutControl As LayoutControl)
            ' This example demonstrates the auto-sizing feature of rows.

            ' When Table Layout mode is enabled, two rows and two columns are automatically created. 
            ' Three items (Picture editor and two Memo controls) are displayed in their individual table cells.
            ' The Picture editor's maximum height is limited.
            ' It is positioned in the first row, whose RowDefinition.SizeType property is set to AutoSize.
            ' The row is auto-sized to fit the Picture editor in its entirety.
            layoutControl.Root.LayoutMode = LayoutMode.Table
            layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions(0).SizeType = SizeType.AutoSize
            Dim item1 As LayoutControlItem = layoutControl.AddItem("Picture", New PictureEdit() With {.Name = "Picture", .Image = DxImageAssemblyUtil.ImageProvider.GetImage("ColorMixer", ImageSize.Size32x32, ImageType.Colored)})
            ' Limit the PictureEdit control height.
            item1.SizeConstraintsType = SizeConstraintsType.Custom
            item1.ControlMaxSize = New System.Drawing.Size(0, 40)

            Dim item2 As LayoutControlItem = layoutControl.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo1"})
            item2.OptionsTableLayoutItem.RowIndex = 1
            item2.OptionsTableLayoutItem.ColumnIndex = 0
            Dim item3 As LayoutControlItem = layoutControl.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo2"})
            item3.OptionsTableLayoutItem.RowIndex = 1
            item3.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub
        <CodeExampleCase("Relative row height"), CodeExampleUnderlineTokens("BeginUpdate", "EndUpdate")>
        Public Shared Sub TableLayoutRelativeRowHeight(ByVal layoutControl As LayoutControl)
            ' This example sets the height of table rows to proportional values.

            layoutControl.Root.LayoutMode = LayoutMode.Table
            ' When Table Layout mode is enabled, two rows and two columns are automatically created.
            ' Access these rows.
            Dim row1 As RowDefinition = layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions(0)
            Dim row2 As RowDefinition = layoutControl.Root.OptionsTableLayoutGroup.RowDefinitions(1)
            layoutControl.Root.BeginUpdate()
            row2.SizeType = System.Windows.Forms.SizeType.Percent
            row1.SizeType = row2.SizeType
            row1.Height = 40
            row2.Height = 60
            layoutControl.Root.EndUpdate()
            Dim item1 As LayoutControlItem = layoutControl.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo1"})
            Dim item2 As LayoutControlItem = layoutControl.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo2"})
            item2.OptionsTableLayoutItem.RowIndex = 1
            item2.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub
        <CodeExampleCase("Relative column size and column span"), CodeExampleUnderlineTokens("BeginUpdate", "EndUpdate")>
        Public Shared Sub TableLayoutColumnSizeAndSpan(ByVal layoutControl As LayoutControl)
            ' This example sets the width of table columns to proportinal values.
            ' In addtion, the column span setting is demonstrated.

            layoutControl.Root.LayoutMode = LayoutMode.Table
            ' When Table Layout mode is enabled, two rows and two columns are automatically created.
            ' Access these columns.
            Dim column1 As ColumnDefinition = layoutControl.Root.OptionsTableLayoutGroup.ColumnDefinitions(0)
            Dim column2 As ColumnDefinition = layoutControl.Root.OptionsTableLayoutGroup.ColumnDefinitions(1)
            layoutControl.Root.BeginUpdate()
            column2.SizeType = System.Windows.Forms.SizeType.Percent
            column1.SizeType = column2.SizeType
            column1.Width = 40
            column2.Width = 60
            layoutControl.Root.EndUpdate()
            Dim item1 As LayoutControlItem = layoutControl.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo1"})
            item1.OptionsTableLayoutItem.RowIndex = 0
            item1.OptionsTableLayoutItem.ColumnIndex = 0
            item1.OptionsTableLayoutItem.ColumnSpan = 2
            Dim item2 As LayoutControlItem = layoutControl.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo2"})
            item2.OptionsTableLayoutItem.RowIndex = 1
            item2.OptionsTableLayoutItem.ColumnIndex = 1
        End Sub
        <CodeExampleCase("Table layout with nested group")>
        Public Shared Sub TableLayoutNestedGroup(ByVal layoutControl As LayoutControl)
            ' In this example, a table cell displays a nested layout group with two Memo controls.
            layoutControl.Root.LayoutMode = LayoutMode.Table
            ' When Table Layout mode is enabled, two rows and two columns are automatically created.
            Dim item1 As LayoutControlItem = layoutControl.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo1"})
            Dim innerGroup As LayoutControlGroup = layoutControl.AddGroup()
            innerGroup.AddItem("Memo 2", New MemoEdit() With {.Name = "Memo2"})
            innerGroup.AddItem("Memo 3", New MemoEdit() With {.Name = "Memo3"})
            ' Position the created group in a target cell.
            innerGroup.OptionsTableLayoutItem.RowIndex = 1
            innerGroup.OptionsTableLayoutItem.ColumnIndex = 1
            innerGroup.BestFit()
        End Sub
        <CodeExampleCase("M rows x N columns layout"), CodeExampleUnderlineTokens("BeginUpdate", "EndUpdate")>
        Public Shared Sub TableLayoutMxN(ByVal layoutControl As LayoutControl)
            ' This example creates a table consisting of a certain number of columns and rows.
            Dim tableGroup As LayoutControlGroup = layoutControl.Root.AddGroup()
            tableGroup.LayoutMode = LayoutMode.Table
            tableGroup.OptionsTableLayoutGroup.ColumnDefinitions.Clear()
            tableGroup.OptionsTableLayoutGroup.RowDefinitions.Clear()
            Dim rowCount As Integer = 10
            Dim columnCount As Integer = 10
            tableGroup.BeginUpdate()
            For n As Integer = 0 To columnCount - 1
                tableGroup.OptionsTableLayoutGroup.ColumnDefinitions.Add(New ColumnDefinition(layoutControl.Root, 10, SizeType.Percent))
            Next n
            For m As Integer = 0 To rowCount - 1
                tableGroup.OptionsTableLayoutGroup.RowDefinitions.Add(New RowDefinition(layoutControl.Root, 10, SizeType.Percent))
            Next m
            tableGroup.EndUpdate()
            Dim memo1LCI As LayoutControlItem = tableGroup.AddItem("Memo 1", New MemoEdit() With {.Name = "Memo1"})
            memo1LCI.OptionsTableLayoutItem.ColumnIndex = 5
            memo1LCI.OptionsTableLayoutItem.RowIndex = 4
        End Sub


    End Class
End Namespace
