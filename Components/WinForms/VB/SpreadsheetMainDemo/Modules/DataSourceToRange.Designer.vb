Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class DataSourceToRangeModule
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DataSourceToRangeModule))
			Me.panel = New DevExpress.XtraEditors.PanelControl()
			Me.edOrderId = New DevExpress.XtraEditors.LookUpEdit()
			Me.chbDiscount = New DevExpress.XtraEditors.CheckEdit()
			Me.lbOrderId = New DevExpress.XtraEditors.LabelControl()
			Me.btnReset = New DevExpress.XtraEditors.SimpleButton()
			Me.edProductName = New DevExpress.XtraEditors.LookUpEdit()
			Me.lbProduct = New DevExpress.XtraEditors.LabelControl()
			Me.separatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel.SuspendLayout()
			CType(Me.edOrderId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.chbDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.edProductName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.separatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Options.Behavior.Column.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
			Me.spreadsheetControl1.Options.Behavior.Column.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
			Me.spreadsheetControl1.Options.Behavior.Row.Delete = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
			Me.spreadsheetControl1.Options.Behavior.Row.Insert = DevExpress.XtraSpreadsheet.DocumentCapability.Disabled
			Me.spreadsheetControl1.Options.Behavior.UseSkinColors = False
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Options.View.Charts.Antialiasing = DevExpress.XtraSpreadsheet.DocumentCapability.Enabled
			resources.ApplyResources(Me.spreadsheetControl1, "spreadsheetControl1")
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			resources.ApplyResources(Me.ribbonControl1, "ribbonControl1")
			' 
			' panel
			' 
			Me.panel.Controls.Add(Me.edOrderId)
			Me.panel.Controls.Add(Me.chbDiscount)
			Me.panel.Controls.Add(Me.lbOrderId)
			Me.panel.Controls.Add(Me.lbProduct)
			Me.panel.Controls.Add(Me.btnReset)
			Me.panel.Controls.Add(Me.edProductName)
			resources.ApplyResources(Me.panel, "panel")
			Me.panel.Name = "panel"
			' 
			' edOrderId
			' 
			resources.ApplyResources(Me.edOrderId, "edOrderId")
			Me.edOrderId.MenuManager = Me.ribbonControl1
			Me.edOrderId.Name = "edOrderId"
			Me.edOrderId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.edOrderId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("edOrderId.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.edOrderId.Properties.NullText = resources.GetString("edOrderId.Properties.NullText")
			Me.edOrderId.Properties.PopupFormMinSize = New System.Drawing.Size(140, 0)
			Me.edOrderId.Properties.ShowFooter = False
			Me.edOrderId.Properties.ShowHeader = False
'			Me.edOrderId.EditValueChanged += New System.EventHandler(Me.edOrderId_EditValueChanged);
			' 
			' chbDiscount
			' 
			resources.ApplyResources(Me.chbDiscount, "chbDiscount")
			Me.chbDiscount.MenuManager = Me.ribbonControl1
			Me.chbDiscount.Name = "chbDiscount"
			Me.chbDiscount.Properties.Caption = resources.GetString("chbDiscount.Properties.Caption")
'			Me.chbDiscount.CheckedChanged += New System.EventHandler(Me.chbDiscount_CheckedChanged);
			' 
			' lbOrderId
			' 
			resources.ApplyResources(Me.lbOrderId, "lbOrderId")
			Me.lbOrderId.Name = "lbOrderId"
			' 
			' btnReset
			' 
			resources.ApplyResources(Me.btnReset, "btnReset")
			Me.btnReset.Name = "btnReset"
'			Me.btnReset.Click += New System.EventHandler(Me.btnReset_Click);
			' 
			' edProductName
			' 
			resources.ApplyResources(Me.edProductName, "edProductName")
			Me.edProductName.MenuManager = Me.ribbonControl1
			Me.edProductName.Name = "edProductName"
			Me.edProductName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.edProductName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("edProductName.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.edProductName.Properties.NullText = resources.GetString("edProductName.Properties.NullText")
			Me.edProductName.Properties.ShowFooter = False
			Me.edProductName.Properties.ShowHeader = False
'			Me.edProductName.EditValueChanged += New System.EventHandler(Me.edProductName_EditValueChanged);
			' 
			' lbProduct
			' 
			resources.ApplyResources(Me.lbProduct, "lbProduct")
			Me.lbProduct.Name = "lbProduct"
			' 
			' separatorControl1
			' 
			resources.ApplyResources(Me.separatorControl1, "separatorControl1")
			Me.separatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
			Me.separatorControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
			Me.separatorControl1.Name = "separatorControl1"
			' 
			' DataSourceToRangeModule
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.separatorControl1)
			Me.Controls.Add(Me.panel)
			Me.Name = "DataSourceToRangeModule"
			resources.ApplyResources(Me, "$this")
			Me.Controls.SetChildIndex(Me.ribbonControl1, 0)
			Me.Controls.SetChildIndex(Me.panel, 0)
			Me.Controls.SetChildIndex(Me.separatorControl1, 0)
			Me.Controls.SetChildIndex(Me.spreadsheetControl1, 0)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel.ResumeLayout(False)
			Me.panel.PerformLayout()
			CType(Me.edOrderId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chbDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.edProductName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.separatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		Private panel As XtraEditors.PanelControl
		Private separatorControl1 As XtraEditors.SeparatorControl
		Private WithEvents edOrderId As XtraEditors.LookUpEdit
		Private lbProduct As XtraEditors.LabelControl
		Private WithEvents edProductName As XtraEditors.LookUpEdit
		Private lbOrderId As XtraEditors.LabelControl
		Private WithEvents btnReset As XtraEditors.SimpleButton
		Private WithEvents chbDiscount As XtraEditors.CheckEdit
	End Class
End Namespace
