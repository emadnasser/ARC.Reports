Namespace DevExpress.XtraGrid.Demos
	Partial Public Class ValidationControl
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ValidationControl))
			Me.label1 = New System.Windows.Forms.Label()
			Me.imageComboBoxEdit1 = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.imageComboBoxEdit2 = New DevExpress.XtraEditors.ImageComboBoxEdit()
			Me.spinEdit2 = New DevExpress.XtraEditors.SpinEdit()
			Me.label2 = New System.Windows.Forms.Label()
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			resources.ApplyResources(Me.label1, "label1")
			Me.label1.Name = "label1"
			' 
			' imageComboBoxEdit1
			' 
			resources.ApplyResources(Me.imageComboBoxEdit1, "imageComboBoxEdit1")
			Me.imageComboBoxEdit1.Name = "imageComboBoxEdit1"
			Me.imageComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("imageComboBoxEdit1.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.imageComboBoxEdit1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items"), (CObj(resources.GetObject("imageComboBoxEdit1.Properties.Items1"))), (CInt(Fix(resources.GetObject("imageComboBoxEdit1.Properties.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items3"), (CObj(resources.GetObject("imageComboBoxEdit1.Properties.Items4"))), (CInt(Fix(resources.GetObject("imageComboBoxEdit1.Properties.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items6"), (CObj(resources.GetObject("imageComboBoxEdit1.Properties.Items7"))), (CInt(Fix(resources.GetObject("imageComboBoxEdit1.Properties.Items8"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items9"), (CObj(resources.GetObject("imageComboBoxEdit1.Properties.Items10"))), (CInt(Fix(resources.GetObject("imageComboBoxEdit1.Properties.Items11"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit1.Properties.Items12"), (CObj(resources.GetObject("imageComboBoxEdit1.Properties.Items13"))), (CInt(Fix(resources.GetObject("imageComboBoxEdit1.Properties.Items14")))))})
'			Me.imageComboBoxEdit1.SelectedIndexChanged += New System.EventHandler(Me.imageComboBoxEdit1_SelectedIndexChanged)
			' 
			' spinEdit1
			' 
			resources.ApplyResources(Me.spinEdit1, "spinEdit1")
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit1.Properties.ValidateOnEnterKey = True
'			Me.spinEdit1.EditValueChanged += New System.EventHandler(Me.spinEdit_EditValueChanged)
			' 
			' imageComboBoxEdit2
			' 
			resources.ApplyResources(Me.imageComboBoxEdit2, "imageComboBoxEdit2")
			Me.imageComboBoxEdit2.Name = "imageComboBoxEdit2"
			Me.imageComboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("imageComboBoxEdit2.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.imageComboBoxEdit2.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() { New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit2.Properties.Items"), (CObj(resources.GetObject("imageComboBoxEdit2.Properties.Items1"))), (CInt(Fix(resources.GetObject("imageComboBoxEdit2.Properties.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit2.Properties.Items3"), (CObj(resources.GetObject("imageComboBoxEdit2.Properties.Items4"))), (CInt(Fix(resources.GetObject("imageComboBoxEdit2.Properties.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("imageComboBoxEdit2.Properties.Items6"), (CObj(resources.GetObject("imageComboBoxEdit2.Properties.Items7"))), (CInt(Fix(resources.GetObject("imageComboBoxEdit2.Properties.Items8")))))})
'			Me.imageComboBoxEdit2.SelectedIndexChanged += New System.EventHandler(Me.imageComboBoxEdit2_SelectedIndexChanged)
			' 
			' spinEdit2
			' 
			resources.ApplyResources(Me.spinEdit2, "spinEdit2")
			Me.spinEdit2.Name = "spinEdit2"
			Me.spinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.spinEdit2.Properties.ValidateOnEnterKey = True
'			Me.spinEdit2.EditValueChanged += New System.EventHandler(Me.spinEdit_EditValueChanged)
			' 
			' label2
			' 
			resources.ApplyResources(Me.label2, "label2")
			Me.label2.Name = "label2"
			' 
			' ValidationControl
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.spinEdit2)
			Me.Controls.Add(Me.imageComboBoxEdit2)
			Me.Controls.Add(Me.spinEdit1)
			Me.Controls.Add(Me.imageComboBoxEdit1)
			Me.Controls.Add(Me.label1)
			Me.Name = "ValidationControl"
			CType(Me.imageComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageComboBoxEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private label1 As System.Windows.Forms.Label
		Public WithEvents imageComboBoxEdit1 As DevExpress.XtraEditors.ImageComboBoxEdit
		Public WithEvents spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Public WithEvents imageComboBoxEdit2 As DevExpress.XtraEditors.ImageComboBoxEdit
		Public WithEvents spinEdit2 As DevExpress.XtraEditors.SpinEdit
		Private label2 As System.Windows.Forms.Label
		Private components As System.ComponentModel.Container = Nothing
	End Class
End Namespace
