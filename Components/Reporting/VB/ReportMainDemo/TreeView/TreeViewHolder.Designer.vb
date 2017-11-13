Namespace XtraReportsDemos.TreeView
    Partial Public Class TreeViewHolder
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing
        Private imageList1 As System.Windows.Forms.ImageList

        Public ReadOnly Property TreeView() As DevExpress.XtraTreeList.TreeList
            Get
                Return Me.treeView1
            End Get
        End Property

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
            Me.components = New System.ComponentModel.Container()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.treeView1 = New DevExpress.XtraTreeList.TreeList()
            Me.SuspendLayout()
            ' 
            ' imageList1
            ' 
            Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
            Me.imageList1.ImageSize = New System.Drawing.Size(48, 16)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            ' 
            ' treeView1
            ' 
            Me.treeView1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { New DevExpress.XtraTreeList.Columns.TreeListColumn()})
            Me.treeView1.Columns(0).Visible = True
            Me.treeView1.Columns(0).VisibleIndex = 0
            Me.treeView1.Columns(0).OptionsColumn.AllowFocus = True
            Me.treeView1.Appearance.Row.Font = New System.Drawing.Font("Segoe UI", 12F)
            Me.treeView1.Appearance.Row.Options.UseFont = True
            Me.treeView1.AppearancePrint.Row.BackColor = System.Drawing.Color.Transparent
            Me.treeView1.AppearancePrint.Row.Font = New System.Drawing.Font("Segoe UI", 12F)
            Me.treeView1.AppearancePrint.Row.Options.UseBackColor = True
            Me.treeView1.AppearancePrint.Row.Options.UseFont = True
            Me.treeView1.CausesValidation = False
            Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeView1.Location = New System.Drawing.Point(0, 0)
            Me.treeView1.Name = "treeView1"
            Me.treeView1.OptionsBehavior.Editable = False
            Me.treeView1.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.None
            Me.treeView1.OptionsPrint.PrintAllNodes = True
            Me.treeView1.OptionsPrint.PrintPageHeader = False
            Me.treeView1.OptionsPrint.PrintTreeButtons = False
            Me.treeView1.OptionsPrint.PrintHorzLines = False
            Me.treeView1.OptionsPrint.PrintVertLines = False
            Me.treeView1.OptionsPrint.PrintImages = True
            Me.treeView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.treeView1.OptionsSelection.MultiSelect = False
            Me.treeView1.OptionsView.AutoWidth = True
            Me.treeView1.OptionsView.ShowColumns = False
            Me.treeView1.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.None
            Me.treeView1.OptionsView.ShowHorzLines = False
            Me.treeView1.OptionsView.ShowIndicator = False
            Me.treeView1.OptionsView.ShowVertLines = False
            Me.treeView1.OptionsView.ShowButtons = True
            Me.treeView1.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowAlways
            Me.treeView1.Size = New System.Drawing.Size(440, 121)
            Me.treeView1.StateImageList = Me.imageList1
            Me.treeView1.TabIndex = 0
            ' 
            ' hierarchyTableAdapter1
            ' 
            ' 
            ' TreeViewHolder
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeView1)
            Me.Name = "TreeViewHolder"
            Me.Size = New System.Drawing.Size(440, 121)

            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private treeView1 As DevExpress.XtraTreeList.TreeList

    End Class
End Namespace
