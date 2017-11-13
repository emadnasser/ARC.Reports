Namespace DevExpress.DevAV.Modules
    Partial Public Class EmployeesFilterPane
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
            Me.btnNewEmployee = New DevExpress.XtraEditors.SimpleButton()
            Me.moduleLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.treeList = New DevExpress.XtraTreeList.TreeList()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.treeListLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.btnNewEmployeeLayoutControlItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.moduleLayout.SuspendLayout()
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeListLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.btnNewEmployeeLayoutControlItem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.btnNewEmployee.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.btnNewEmployee.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewEmploye.svg?Size=16x16"
            Me.btnNewEmployee.Location = New System.Drawing.Point(14, 14)
            Me.btnNewEmployee.MaximumSize = New System.Drawing.Size(150, 0)
            Me.btnNewEmployee.MinimumSize = New System.Drawing.Size(150, 0)
            Me.btnNewEmployee.Name = "btnNewEmployee"
            Me.btnNewEmployee.Size = New System.Drawing.Size(150, 22)
            Me.btnNewEmployee.StyleController = Me.moduleLayout
            Me.btnNewEmployee.TabIndex = 0
            Me.btnNewEmployee.Text = "New Employee"
            Me.moduleLayout.AllowCustomization = False
            Me.moduleLayout.Controls.Add(Me.btnNewEmployee)
            Me.moduleLayout.Controls.Add(Me.treeList)
            Me.moduleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.moduleLayout.Location = New System.Drawing.Point(0, 0)
            Me.moduleLayout.Name = "moduleLayout"
            Me.moduleLayout.Root = Me.Root
            Me.moduleLayout.Size = New System.Drawing.Size(200, 603)
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
            Me.treeList.Size = New System.Drawing.Size(176, 537)
            Me.treeList.TabIndex = 1
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.treeListLayoutControlItem, Me.btnNewEmployeeLayoutControlItem})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.OptionsItemText.TextToControlDistance = 6
            Me.Root.Size = New System.Drawing.Size(200, 603)
            Me.treeListLayoutControlItem.Control = Me.treeList
            Me.treeListLayoutControlItem.CustomizationFormText = "treeListLayoutControlItem"
            Me.treeListLayoutControlItem.Location = New System.Drawing.Point(0, 42)
            Me.treeListLayoutControlItem.Name = "treeListLayoutControlItem"
            Me.treeListLayoutControlItem.Size = New System.Drawing.Size(180, 541)
            Me.treeListLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.treeListLayoutControlItem.TextVisible = False
            Me.btnNewEmployeeLayoutControlItem.Control = Me.btnNewEmployee
            Me.btnNewEmployeeLayoutControlItem.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnNewEmployeeLayoutControlItem.CustomizationFormText = "btnNewEmployeeLayoutControlItem"
            Me.btnNewEmployeeLayoutControlItem.Location = New System.Drawing.Point(0, 0)
            Me.btnNewEmployeeLayoutControlItem.Name = "btnNewEmployeeLayoutControlItem"
            Me.btnNewEmployeeLayoutControlItem.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 16)
            Me.btnNewEmployeeLayoutControlItem.Size = New System.Drawing.Size(180, 42)
            Me.btnNewEmployeeLayoutControlItem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.btnNewEmployeeLayoutControlItem.TextSize = New System.Drawing.Size(0, 0)
            Me.btnNewEmployeeLayoutControlItem.TextVisible = False
            Me.btnNewEmployeeLayoutControlItem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.moduleLayout)
            Me.Name = "EmployeesFilterPane"
            Me.Size = New System.Drawing.Size(200, 603)
            CType(Me.mvvmContext, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.moduleLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.moduleLayout.ResumeLayout(False)
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeListLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.btnNewEmployeeLayoutControlItem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private btnNewEmployee As DevExpress.XtraEditors.SimpleButton
        Private treeList As XtraTreeList.TreeList
        Private moduleLayout As XtraLayout.LayoutControl
        Private Root As XtraLayout.LayoutControlGroup
        Private treeListLayoutControlItem As XtraLayout.LayoutControlItem
        Private btnNewEmployeeLayoutControlItem As XtraLayout.LayoutControlItem
    End Class
End Namespace
