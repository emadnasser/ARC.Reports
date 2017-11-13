Namespace DevExpress.XtraGrid.Demos
	Partial Public Class CustomDataSummaries
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomDataSummaries))
			Dim styleFormatCondition1 As New DevExpress.XtraGrid.StyleFormatCondition()
			Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOrder = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.pnlLeft = New DevExpress.XtraEditors.PanelControl()
			Me.numCustom = New DevExpress.XtraEditors.SpinEdit()
			Me.label2 = New System.Windows.Forms.Label()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlLeft.SuspendLayout()
			CType(Me.numCustom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' colFreight
			' 
			resources.ApplyResources(Me.colFreight, "colFreight")
			Me.colFreight.ColumnEdit = Me.repositoryItemSpinEdit2
			Me.colFreight.DisplayFormat.FormatString = "c"
			Me.colFreight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colFreight.FieldName = "Freight"
			Me.colFreight.Name = "colFreight"
			Me.colFreight.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("colFreight.Summary"), DevExpress.Data.SummaryItemType)), resources.GetString("colFreight.Summary1"), resources.GetString("colFreight.Summary2"))})
			' 
			' repositoryItemSpinEdit2
			' 
			resources.ApplyResources(Me.repositoryItemSpinEdit2, "repositoryItemSpinEdit2")
			Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
			' 
			' gridControl2
			' 
			resources.ApplyResources(Me.gridControl2, "gridControl2")
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit2, Me.repositoryItemLookUpEdit2, Me.repositoryItemLookUpEdit3})
			Me.gridControl2.ShowOnlyPredefinedDetails = True
			Me.gridControl2.Tag = ""
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrder, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colFreight, Me.colShipCountry})
			styleFormatCondition1.Appearance.BackColor = (CType(resources.GetObject("resource.BackColor"), System.Drawing.Color))
			styleFormatCondition1.Appearance.BackColor2 = (CType(resources.GetObject("resource.BackColor2"), System.Drawing.Color))
			styleFormatCondition1.Appearance.Font = (CType(resources.GetObject("resource.Font"), System.Drawing.Font))
			styleFormatCondition1.Appearance.ForeColor = (CType(resources.GetObject("resource.ForeColor"), System.Drawing.Color))
			styleFormatCondition1.Appearance.GradientMode = (CType(resources.GetObject("resource.GradientMode"), System.Drawing.Drawing2D.LinearGradientMode))
			styleFormatCondition1.Appearance.Options.UseBackColor = True
			styleFormatCondition1.Appearance.Options.UseFont = True
			styleFormatCondition1.Appearance.Options.UseForeColor = True
			styleFormatCondition1.Column = Me.colFreight
			styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.GreaterOrEqual
			styleFormatCondition1.Value1 = "100"
			Me.gridView2.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() { styleFormatCondition1})
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.GroupCount = 1
			Me.gridView2.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView2.GroupSummary"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView2.GroupSummary1"), Nothing, resources.GetString("gridView2.GroupSummary2")), New DevExpress.XtraGrid.GridGroupSummaryItem((CType(resources.GetObject("gridView2.GroupSummary3"), DevExpress.Data.SummaryItemType)), resources.GetString("gridView2.GroupSummary4"), Nothing, resources.GetString("gridView2.GroupSummary5"))})
			Me.gridView2.HorzScrollStep = 30
			Me.gridView2.Name = "gridView2"
			Me.gridView2.OptionsView.ShowFooter = True
			Me.gridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEmployeeID, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView2.CustomDrawFooterCell += New DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(Me.gridView2_CustomDrawFooterCell)
'			Me.gridView2.PopupMenuShowing += New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(Me.gridView2_PopupMenuShowing)
'			Me.gridView2.CustomSummaryCalculate += New DevExpress.Data.CustomSummaryEventHandler(Me.gridView2_CustomSummaryCalculate)
			' 
			' colOrder
			' 
			resources.ApplyResources(Me.colOrder, "colOrder")
			Me.colOrder.FieldName = "OrderID"
			Me.colOrder.Name = "colOrder"
			Me.colOrder.OptionsFilter.AllowFilter = False
			Me.colOrder.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridColumnSummaryItem((CType(resources.GetObject("colOrder.Summary"), DevExpress.Data.SummaryItemType)))})
			' 
			' colCustomerID
			' 
			resources.ApplyResources(Me.colCustomerID, "colCustomerID")
			Me.colCustomerID.ColumnEdit = Me.repositoryItemLookUpEdit2
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.OptionsFilter.AllowFilter = False
			' 
			' repositoryItemLookUpEdit2
			' 
			resources.ApplyResources(Me.repositoryItemLookUpEdit2, "repositoryItemLookUpEdit2")
			Me.repositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemLookUpEdit2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit2.Columns"), resources.GetString("repositoryItemLookUpEdit2.Columns1"))})
			Me.repositoryItemLookUpEdit2.DisplayMember = "CompanyName"
			Me.repositoryItemLookUpEdit2.DropDownRows = 10
			Me.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2"
			Me.repositoryItemLookUpEdit2.PopupWidth = 200
			Me.repositoryItemLookUpEdit2.ValueMember = "CustomerID"
			' 
			' colEmployeeID
			' 
			resources.ApplyResources(Me.colEmployeeID, "colEmployeeID")
			Me.colEmployeeID.ColumnEdit = Me.repositoryItemLookUpEdit3
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.Name = "colEmployeeID"
			Me.colEmployeeID.OptionsFilter.AllowFilter = False
			' 
			' repositoryItemLookUpEdit3
			' 
			resources.ApplyResources(Me.repositoryItemLookUpEdit3, "repositoryItemLookUpEdit3")
			Me.repositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemLookUpEdit3.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit3.Columns"), resources.GetString("repositoryItemLookUpEdit3.Columns1")), New DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("repositoryItemLookUpEdit3.Columns2"), resources.GetString("repositoryItemLookUpEdit3.Columns3"))})
			Me.repositoryItemLookUpEdit3.DisplayMember = "Name"
			Me.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3"
			Me.repositoryItemLookUpEdit3.PopupWidth = 200
			Me.repositoryItemLookUpEdit3.ValueMember = "EmployeeID"
			' 
			' colOrderDate
			' 
			resources.ApplyResources(Me.colOrderDate, "colOrderDate")
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Name = "colOrderDate"
			' 
			' colShipCountry
			' 
			resources.ApplyResources(Me.colShipCountry, "colShipCountry")
			Me.colShipCountry.FieldName = "ShipCountry"
			Me.colShipCountry.Name = "colShipCountry"
			' 
			' pnlLeft
			' 
			Me.pnlLeft.Controls.Add(Me.numCustom)
			Me.pnlLeft.Controls.Add(Me.label2)
			resources.ApplyResources(Me.pnlLeft, "pnlLeft")
			Me.pnlLeft.Name = "pnlLeft"
			' 
			' numCustom
			' 
			resources.ApplyResources(Me.numCustom, "numCustom")
			Me.numCustom.Name = "numCustom"
			Me.numCustom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.numCustom.Properties.MaxValue = New Decimal(New Integer() { 1000, 0, 0, 0})
			Me.numCustom.Properties.ValidateOnEnterKey = True
'			Me.numCustom.EditValueChanged += New System.EventHandler(Me.numCustom_ValueChanged)
			' 
			' label2
			' 
			resources.ApplyResources(Me.label2, "label2")
			Me.label2.Name = "label2"
			' 
			' panelControl1
			' 
			Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			resources.ApplyResources(Me.panelControl1, "panelControl1")
			Me.panelControl1.Name = "panelControl1"
			' 
			' CustomDataSummaries
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.gridControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Controls.Add(Me.pnlLeft)
			Me.Name = "CustomDataSummaries"
'			Me.Load += New System.EventHandler(Me.CustomDataSummaries_Load)
			CType(Me.repositoryItemSpinEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlLeft, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlLeft.ResumeLayout(False)
			CType(Me.numCustom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private components As System.ComponentModel.IContainer = Nothing
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colFreight As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private label2 As System.Windows.Forms.Label
		Private pnlLeft As DevExpress.XtraEditors.PanelControl
		Private colOrder As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private repositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private repositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private WithEvents numCustom As DevExpress.XtraEditors.SpinEdit
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace
