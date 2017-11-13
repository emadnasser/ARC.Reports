Namespace DevExpress.DevAV.Modules
    Partial Public Class QuotesFilterPane
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
            Me.btnNewQuote = New DevExpress.XtraEditors.SimpleButton()
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.treeList = New DevExpress.XtraTreeList.TreeList()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.treeListLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.btnNewQuoteLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeListLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnNewQuoteLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.btnNewQuote.Image = My.Resources.icon_new_opportunities_16
            Me.btnNewQuote.Location = New System.Drawing.Point(14, 14)
            Me.btnNewQuote.MaximumSize = New System.Drawing.Size(150, 0)
            Me.btnNewQuote.MinimumSize = New System.Drawing.Size(150, 0)
            Me.btnNewQuote.Name = "btnNewQuote"
            Me.btnNewQuote.Size = New System.Drawing.Size(150, 22)
            Me.btnNewQuote.StyleController = Me.moduleLayout
            Me.btnNewQuote.TabIndex = 0
            Me.btnNewQuote.Text = "New Quote"
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.btnNewQuote)
            Me.moduleLayout.Controls.Add(Me.treeList)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.Root
            Me.moduleLayout.Size = New System.Drawing.Size(200, 700)
            Me.moduleLayout.TabIndex = 2
            Me.treeList.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
            Me.treeList.Appearance.Empty.Options.UseBackColor = True
            Me.treeList.Appearance.FocusedRow.Font = New System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold)
            Me.treeList.Appearance.FocusedRow.Options.UseFont = True
            Me.treeList.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold)
            Me.treeList.Appearance.HideSelectionRow.Options.UseFont = True
            Me.treeList.Appearance.Row.BackColor = System.Drawing.Color.Transparent
            Me.treeList.Appearance.Row.Options.UseBackColor = True
            Me.treeList.Appearance.SelectedRow.Font = New System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold)
            Me.treeList.Appearance.SelectedRow.Options.UseFont = True
            Me.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeList.Location = New System.Drawing.Point(12, 54)
            Me.treeList.Name = "treeList"
            Me.treeList.OptionsDragAndDrop.DragNodesMode = XtraTreeList.DragNodesMode.Single
            Me.treeList.OptionsBehavior.Editable = False
            Me.treeList.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.treeList.OptionsView.ShowColumns = False
            Me.treeList.OptionsView.FocusRectStyle = XtraTreeList.DrawFocusRectStyle.None
            Me.treeList.OptionsView.ShowHorzLines = False
            Me.treeList.OptionsView.ShowIndentAsRowStyle = True
            Me.treeList.OptionsView.ShowIndicator = False
            Me.treeList.OptionsView.ShowVertLines = False
            Me.treeList.Size = New System.Drawing.Size(176, 634)
            Me.treeList.TabIndex = 1
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.treeListLayoutControlItem, Me.btnNewQuoteLayoutControlItem})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.OptionsItemText.TextToControlDistance = 6
            Me.Root.Size = New System.Drawing.Size(200, 700)
            Me.Root.Text = "Root"
            Me.treeListLayoutControlItem.Control = Me.treeList
            Me.treeListLayoutControlItem.CustomizationFormText = "treeListLayoutControlItem"
            Me.treeListLayoutControlItem.Location = New System.Drawing.Point(0, 42)
            Me.treeListLayoutControlItem.Name = "treeListLayoutControlItem"
            Me.treeListLayoutControlItem.Size = New System.Drawing.Size(180, 638)
            Me.treeListLayoutControlItem.Text = "treeListLayoutControlItem"
            Me.treeListLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.treeListLayoutControlItem.TextToControlDistance = 0
            Me.treeListLayoutControlItem.TextVisible = False
            Me.btnNewQuoteLayoutControlItem.Control = Me.btnNewQuote
            Me.btnNewQuoteLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNewQuoteLayoutControlItem.CustomizationFormText = "btnNewQuoteLayoutControlItem"
            Me.btnNewQuoteLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.btnNewQuoteLayoutControlItem.Name = "btnNewQuoteLayoutControlItem"
            Me.btnNewQuoteLayoutControlItem.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 16)
            Me.btnNewQuoteLayoutControlItem.Size = New System.Drawing.Size(180, 42)
            Me.btnNewQuoteLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.btnNewQuoteLayoutControlItem.Text = "btnNewQuoteLayoutControlItem"
            Me.btnNewQuoteLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.btnNewQuoteLayoutControlItem.TextToControlDistance = 0
            Me.btnNewQuoteLayoutControlItem.TextVisible = False
            Me.btnNewQuoteLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "QuotesFilterPane"
            Me.Size = New System.Drawing.Size(200, 700)
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeListLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnNewQuoteLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private btnNewQuote As DevExpress.XtraEditors.SimpleButton
        Private treeList As XtraTreeList.TreeList
        Private moduleLayout As XtraLayout.LayoutControl
        Private Root As XtraLayout.LayoutControlGroup
        Private treeListLayoutControlItem As XtraLayout.LayoutControlItem
        Private btnNewQuoteLayoutControlItem As XtraLayout.LayoutControlItem
    End Class
End Namespace
