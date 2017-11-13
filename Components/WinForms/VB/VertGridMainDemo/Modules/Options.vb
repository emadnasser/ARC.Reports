Imports System.Collections
Imports System.ComponentModel



Namespace DevExpress.XtraVerticalGrid.Demos
    Partial Public Class Options
        Inherits DevExpress.XtraVerticalGrid.Demos.PropertiesBase

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()
            TutorialInfo.WhatsThisCodeFile = "VB\VertGridMainDemo\Modules\Options.vb;"
            TutorialInfo.WhatsThisXMLFile = "Options.xml"
            panel1.BringToFront()
            ' TODO: Add any initialization after the InitializeComponent call
        End Sub

        '<propertyGridControl1>
        '        
        '~Note: the following code is set at design time and listed here for demonstration purposes.
        '~ 
        '~Me.propertyGridControl1.DefaultEditors.AddRange(New DevExpress.XtraVerticalGrid.Rows.DefaultEditor() {
        '~    New DevExpress.XtraVerticalGrid.Rows.DefaultEditor(GetType(Boolean), Me.repositoryItemCheckEdit1)})
        '~Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        '~Me.propertyGridControl1.Location = new System.Drawing.Point(8, 4)
        '~Me.propertyGridControl1.Name = "propertyGridControl1"
        '~Me.propertyGridControl1.OptionsMenu.EnableContextMenu = True
        '~Me.propertyGridControl1.RecordWidth = 72
        '~Me.propertyGridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { _
        '~    Me.repositoryItemCheckEdit1})
        '~Me.propertyGridControl1.RowHeaderWidth = 128
        '~Me.propertyGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { _
        '~    Me.categoryAppearance, _
        '~    Me.categoryBehavior, _
        '~    Me.categoryLayout, _
        '~    Me.categoryOptions})
        '~Me.propertyGridControl1.Size = new System.Drawing.Size(280, 384)
        '~Me.propertyGridControl1.TabIndex = 0
        '
        '</propertyGridControl1>

        Protected Overrides Sub AdjustmentGrid()
            MyBase.AdjustmentGrid()
            Me.propertyGridControl1.SelectedObject = CurrentGrid
        End Sub
    End Class
End Namespace

