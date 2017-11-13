Namespace DevExpress.DevAV.Modules
    Partial Public Class CustomersFilterPane
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
            Me.btnNewCustomer = New DevExpress.XtraEditors.SimpleButton()
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.treeList = New DevExpress.XtraTreeList.TreeList()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.treeListLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.btnNewCustomerLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeListLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnNewCustomerLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.btnNewCustomer.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnNewCustomer.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewCustomer.svg?Size=16x16"
            Me.btnNewCustomer.Location = New System.Drawing.Point(14, 14)
            Me.btnNewCustomer.MaximumSize = New System.Drawing.Size(150, 0)
            Me.btnNewCustomer.MinimumSize = New System.Drawing.Size(150, 0)
            Me.btnNewCustomer.Name = "btnNewCustomer"
            Me.btnNewCustomer.Size = New System.Drawing.Size(150, 22)
            Me.btnNewCustomer.StyleController = Me.moduleLayout
            Me.btnNewCustomer.TabIndex = 0
            Me.btnNewCustomer.Text = "New Customer"
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.btnNewCustomer)
            Me.moduleLayout.Controls.Add(Me.treeList)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.Root
            Me.moduleLayout.Size = New System.Drawing.Size(200, 700)
            Me.moduleLayout.TabIndex = 2
            Me.treeList.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.treeList.Location = New System.Drawing.Point(12, 54)
            Me.treeList.Name = "treeList"
            Me.treeList.OptionsBehavior.Editable = False
            Me.treeList.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Single
            Me.treeList.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.treeList.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
            Me.treeList.OptionsView.ShowColumns = False
            Me.treeList.OptionsView.ShowHorzLines = False
            Me.treeList.OptionsView.ShowIndentAsRowStyle = True
            Me.treeList.OptionsView.ShowIndicator = False
            Me.treeList.OptionsView.ShowVertLines = False
            Me.treeList.Size = New System.Drawing.Size(176, 634)
            Me.treeList.TabIndex = 1
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.treeListLayoutControlItem, Me.btnNewCustomerLayoutControlItem})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.OptionsItemText.TextToControlDistance = 6
            Me.Root.Size = New System.Drawing.Size(200, 700)
            Me.treeListLayoutControlItem.Control = Me.treeList
            Me.treeListLayoutControlItem.CustomizationFormText = "treeListLayoutControlItem"
            Me.treeListLayoutControlItem.Location = New System.Drawing.Point(0, 42)
            Me.treeListLayoutControlItem.Name = "treeListLayoutControlItem"
            Me.treeListLayoutControlItem.Size = New System.Drawing.Size(180, 638)
            Me.treeListLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.treeListLayoutControlItem.TextVisible = False
            Me.btnNewCustomerLayoutControlItem.Control = Me.btnNewCustomer
            Me.btnNewCustomerLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNewCustomerLayoutControlItem.CustomizationFormText = "btnNewCustomerLayoutControlItem"
            Me.btnNewCustomerLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.btnNewCustomerLayoutControlItem.Name = "btnNewCustomerLayoutControlItem"
            Me.btnNewCustomerLayoutControlItem.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 16)
            Me.btnNewCustomerLayoutControlItem.Size = New System.Drawing.Size(180, 42)
            Me.btnNewCustomerLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.btnNewCustomerLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.btnNewCustomerLayoutControlItem.TextVisible = False
            Me.btnNewCustomerLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "CustomersFilterPane"
            Me.Size = New System.Drawing.Size(200, 700)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeListLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnNewCustomerLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private btnNewCustomer As DevExpress.XtraEditors.SimpleButton
        Private treeList As XtraTreeList.TreeList
        Private moduleLayout As XtraLayout.LayoutControl
        Private Root As XtraLayout.LayoutControlGroup
        Private treeListLayoutControlItem As XtraLayout.LayoutControlItem
        Private btnNewCustomerLayoutControlItem As XtraLayout.LayoutControlItem
    End Class
End Namespace
