Namespace DevExpress.XtraGrid.Demos
	Partial Public Class LookUpProperties
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(LookUpProperties))
			Me.lblSelect = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.lbDisplay = New System.Windows.Forms.Label()
			Me.lbValue = New System.Windows.Forms.Label()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.ceAutoComplete = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowPopupFooter = New DevExpress.XtraEditors.CheckEdit()
			Me.cePopupSizeable = New DevExpress.XtraEditors.CheckEdit()
			Me.ceImmediatePopup = New DevExpress.XtraEditors.CheckEdit()
			Me.icbTextEditStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.label2 = New System.Windows.Forms.Label()
			Me.groupControl2 = New DevExpress.XtraEditors.GroupControl()
			Me.ceEnableAppearanceEvenRow = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowVerticalLines = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowHorzLines = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowIndicator = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowColumnHeaders = New DevExpress.XtraEditors.CheckEdit()
			Me.ceShowAutoFilterRow = New DevExpress.XtraEditors.CheckEdit()
			Me.ceEnableAppearanceOddRow = New DevExpress.XtraEditors.CheckEdit()
			Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.ceAutoComplete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowPopupFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceImmediatePopup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbTextEditStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl2.SuspendLayout()
			CType(Me.ceEnableAppearanceEvenRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowVerticalLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowHorzLines.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowIndicator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowColumnHeaders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceShowAutoFilterRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceEnableAppearanceOddRow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xtraScrollableControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' lblSelect
			' 
			resources.ApplyResources(Me.lblSelect, "lblSelect")
			Me.lblSelect.Name = "lblSelect"
			' 
			' label1
			' 
			resources.ApplyResources(Me.label1, "label1")
			Me.label1.Name = "label1"
			' 
			' lbDisplay
			' 
			resources.ApplyResources(Me.lbDisplay, "lbDisplay")
			Me.lbDisplay.Name = "lbDisplay"
			' 
			' lbValue
			' 
			resources.ApplyResources(Me.lbValue, "lbValue")
			Me.lbValue.Name = "lbValue"
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.ceAutoComplete)
			Me.groupControl1.Controls.Add(Me.ceShowPopupFooter)
			Me.groupControl1.Controls.Add(Me.cePopupSizeable)
			Me.groupControl1.Controls.Add(Me.ceImmediatePopup)
			Me.groupControl1.Controls.Add(Me.icbTextEditStyle)
			Me.groupControl1.Controls.Add(Me.label2)
			resources.ApplyResources(Me.groupControl1, "groupControl1")
			Me.groupControl1.Name = "groupControl1"
			' 
			' ceAutoComplete
			' 
			resources.ApplyResources(Me.ceAutoComplete, "ceAutoComplete")
			Me.ceAutoComplete.Name = "ceAutoComplete"
			Me.ceAutoComplete.Properties.Caption = resources.GetString("ceAutoComplete.Properties.Caption")
'			Me.ceAutoComplete.CheckedChanged += New System.EventHandler(Me.ceAutoComplete_CheckedChanged)
			' 
			' ceShowPopupFooter
			' 
			resources.ApplyResources(Me.ceShowPopupFooter, "ceShowPopupFooter")
			Me.ceShowPopupFooter.Name = "ceShowPopupFooter"
			Me.ceShowPopupFooter.Properties.Caption = resources.GetString("ceShowPopupFooter.Properties.Caption")
'			Me.ceShowPopupFooter.CheckedChanged += New System.EventHandler(Me.ceShowPopupFooter_CheckedChanged)
			' 
			' cePopupSizeable
			' 
			resources.ApplyResources(Me.cePopupSizeable, "cePopupSizeable")
			Me.cePopupSizeable.Name = "cePopupSizeable"
			Me.cePopupSizeable.Properties.Caption = resources.GetString("cePopupSizeable.Properties.Caption")
'			Me.cePopupSizeable.CheckedChanged += New System.EventHandler(Me.cePopupSizeable_CheckedChanged)
			' 
			' ceImmediatePopup
			' 
			resources.ApplyResources(Me.ceImmediatePopup, "ceImmediatePopup")
			Me.ceImmediatePopup.Name = "ceImmediatePopup"
			Me.ceImmediatePopup.Properties.Caption = resources.GetString("ceImmediatePopup.Properties.Caption")
'			Me.ceImmediatePopup.CheckedChanged += New System.EventHandler(Me.ceImmediatePopup_CheckedChanged)
			' 
			' icbTextEditStyle
			' 
			resources.ApplyResources(Me.icbTextEditStyle, "icbTextEditStyle")
			Me.icbTextEditStyle.Name = "icbTextEditStyle"
			Me.icbTextEditStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("icbTextEditStyle.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
'			Me.icbTextEditStyle.SelectedIndexChanged += New System.EventHandler(Me.icbTextEditStyle_SelectedIndexChanged)
			' 
			' label2
			' 
			resources.ApplyResources(Me.label2, "label2")
			Me.label2.Name = "label2"
			' 
			' groupControl2
			' 
			Me.groupControl2.Controls.Add(Me.ceEnableAppearanceEvenRow)
			Me.groupControl2.Controls.Add(Me.ceShowVerticalLines)
			Me.groupControl2.Controls.Add(Me.ceShowHorzLines)
			Me.groupControl2.Controls.Add(Me.ceShowIndicator)
			Me.groupControl2.Controls.Add(Me.ceShowColumnHeaders)
			Me.groupControl2.Controls.Add(Me.ceShowAutoFilterRow)
			Me.groupControl2.Controls.Add(Me.ceEnableAppearanceOddRow)
			resources.ApplyResources(Me.groupControl2, "groupControl2")
			Me.groupControl2.Name = "groupControl2"
			' 
			' ceEnableAppearanceEvenRow
			' 
			resources.ApplyResources(Me.ceEnableAppearanceEvenRow, "ceEnableAppearanceEvenRow")
			Me.ceEnableAppearanceEvenRow.Name = "ceEnableAppearanceEvenRow"
			Me.ceEnableAppearanceEvenRow.Properties.Caption = resources.GetString("ceEnableAppearanceEvenRow.Properties.Caption")
'			Me.ceEnableAppearanceEvenRow.CheckedChanged += New System.EventHandler(Me.ceEnableAppearanceEvenRow_CheckedChanged)
			' 
			' ceShowVerticalLines
			' 
			resources.ApplyResources(Me.ceShowVerticalLines, "ceShowVerticalLines")
			Me.ceShowVerticalLines.Name = "ceShowVerticalLines"
			Me.ceShowVerticalLines.Properties.Caption = resources.GetString("ceShowVerticalLines.Properties.Caption")
'			Me.ceShowVerticalLines.CheckedChanged += New System.EventHandler(Me.ceShowVerticalLines_CheckedChanged)
			' 
			' ceShowHorzLines
			' 
			resources.ApplyResources(Me.ceShowHorzLines, "ceShowHorzLines")
			Me.ceShowHorzLines.Name = "ceShowHorzLines"
			Me.ceShowHorzLines.Properties.Caption = resources.GetString("ceShowHorzLines.Properties.Caption")
'			Me.ceShowHorzLines.CheckedChanged += New System.EventHandler(Me.ceShowHorzLines_CheckedChanged)
			' 
			' ceShowIndicator
			' 
			resources.ApplyResources(Me.ceShowIndicator, "ceShowIndicator")
			Me.ceShowIndicator.Name = "ceShowIndicator"
			Me.ceShowIndicator.Properties.Caption = resources.GetString("ceShowIndicator.Properties.Caption")
'			Me.ceShowIndicator.CheckedChanged += New System.EventHandler(Me.ceShowIndicator_CheckedChanged)
			' 
			' ceShowColumnHeaders
			' 
			resources.ApplyResources(Me.ceShowColumnHeaders, "ceShowColumnHeaders")
			Me.ceShowColumnHeaders.Name = "ceShowColumnHeaders"
			Me.ceShowColumnHeaders.Properties.Caption = resources.GetString("ceShowColumnHeaders.Properties.Caption")
'			Me.ceShowColumnHeaders.CheckedChanged += New System.EventHandler(Me.ceShowColumnHeaders_CheckedChanged)
			' 
			' ceShowAutoFilterRow
			' 
			resources.ApplyResources(Me.ceShowAutoFilterRow, "ceShowAutoFilterRow")
			Me.ceShowAutoFilterRow.Name = "ceShowAutoFilterRow"
			Me.ceShowAutoFilterRow.Properties.Caption = resources.GetString("ceShowAutoFilterRow.Properties.Caption")
'			Me.ceShowAutoFilterRow.CheckedChanged += New System.EventHandler(Me.ceShowAutoFilterRow_CheckedChanged)
			' 
			' ceEnableAppearanceOddRow
			' 
			resources.ApplyResources(Me.ceEnableAppearanceOddRow, "ceEnableAppearanceOddRow")
			Me.ceEnableAppearanceOddRow.Name = "ceEnableAppearanceOddRow"
			Me.ceEnableAppearanceOddRow.Properties.Caption = resources.GetString("ceEnableAppearanceOddRow.Properties.Caption")
'			Me.ceEnableAppearanceOddRow.CheckedChanged += New System.EventHandler(Me.ceEnableAppearanceOddRow_CheckedChanged)
			' 
			' xtraScrollableControl1
			' 
			Me.xtraScrollableControl1.Controls.Add(Me.groupControl1)
			Me.xtraScrollableControl1.Controls.Add(Me.groupControl2)
			Me.xtraScrollableControl1.Controls.Add(Me.lblSelect)
			Me.xtraScrollableControl1.Controls.Add(Me.label1)
			Me.xtraScrollableControl1.Controls.Add(Me.lbValue)
			Me.xtraScrollableControl1.Controls.Add(Me.lbDisplay)
			resources.ApplyResources(Me.xtraScrollableControl1, "xtraScrollableControl1")
			Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
			' 
			' LookUpProperties
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.xtraScrollableControl1)
			Me.Name = "LookUpProperties"
'			Me.Load += New System.EventHandler(Me.LookUpProperties_Load)
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			Me.groupControl1.PerformLayout()
			CType(Me.ceAutoComplete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowPopupFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cePopupSizeable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceImmediatePopup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbTextEditStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl2.ResumeLayout(False)
			CType(Me.ceEnableAppearanceEvenRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowVerticalLines.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowHorzLines.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowIndicator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowColumnHeaders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceShowAutoFilterRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceEnableAppearanceOddRow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xtraScrollableControl1.ResumeLayout(False)
			Me.xtraScrollableControl1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private lblSelect As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private lbDisplay As System.Windows.Forms.Label
		Private lbValue As System.Windows.Forms.Label
		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private groupControl2 As DevExpress.XtraEditors.GroupControl
		Private label2 As System.Windows.Forms.Label
		Private components As System.ComponentModel.Container = Nothing
		Private WithEvents ceImmediatePopup As DevExpress.XtraEditors.CheckEdit
		Private WithEvents icbTextEditStyle As DevExpress.XtraEditors.ImageComboBoxEdit
		Private WithEvents ceShowAutoFilterRow As DevExpress.XtraEditors.CheckEdit
		Private WithEvents cePopupSizeable As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowPopupFooter As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowHorzLines As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowIndicator As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowColumnHeaders As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceShowVerticalLines As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceEnableAppearanceEvenRow As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceEnableAppearanceOddRow As DevExpress.XtraEditors.CheckEdit
		Private WithEvents ceAutoComplete As DevExpress.XtraEditors.CheckEdit
		Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
	End Class
End Namespace
