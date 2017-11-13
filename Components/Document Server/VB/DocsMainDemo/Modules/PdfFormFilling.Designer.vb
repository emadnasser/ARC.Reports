Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class PdfFormFilling
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
			Me.components = New System.ComponentModel.Container()
			Me.viewerPanel = New DevExpress.XtraEditors.PanelControl()
			Me.panelDocument = New System.Windows.Forms.Panel()
			Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			Me.panelOptions = New System.Windows.Forms.Panel()
			Me.deDate = New DevExpress.XtraEditors.DateEdit()
			Me.labelDate = New DevExpress.XtraEditors.LabelControl()
			Me.labelFlight = New DevExpress.XtraEditors.LabelControl()
			Me.teFlight = New DevExpress.XtraEditors.TextEdit()
			Me.labelPassport = New DevExpress.XtraEditors.LabelControl()
			Me.tePassport = New DevExpress.XtraEditors.TextEdit()
			Me.buttonSubmit = New DevExpress.XtraEditors.SimpleButton()
			Me.panelSubmit = New System.Windows.Forms.Panel()
			Me.labelAddress = New DevExpress.XtraEditors.LabelControl()
			Me.labelVisa = New DevExpress.XtraEditors.LabelControl()
			Me.labelCountry = New DevExpress.XtraEditors.LabelControl()
			Me.labelGender = New DevExpress.XtraEditors.LabelControl()
			Me.labelLastName = New DevExpress.XtraEditors.LabelControl()
			Me.labelFirstName = New DevExpress.XtraEditors.LabelControl()
			Me.cbeNationality = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.teAddress = New DevExpress.XtraEditors.TextEdit()
			Me.teVisa = New DevExpress.XtraEditors.TextEdit()
			Me.teLastName = New DevExpress.XtraEditors.TextEdit()
			Me.teFirstName = New DevExpress.XtraEditors.TextEdit()
			Me.ceFemale = New DevExpress.XtraEditors.CheckEdit()
			Me.ceMale = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.viewerPanel.SuspendLayout()
			Me.panelDocument.SuspendLayout()
			Me.panelOptions.SuspendLayout()
			CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teFlight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tePassport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbeNationality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teVisa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceFemale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ceMale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' viewerPanel
			' 
			Me.viewerPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.viewerPanel.Controls.Add(Me.panelDocument)
			Me.viewerPanel.Controls.Add(Me.panelOptions)
			Me.viewerPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.viewerPanel.Location = New System.Drawing.Point(0, 0)
			Me.viewerPanel.Name = "viewerPanel"
			Me.viewerPanel.Size = New System.Drawing.Size(737, 564)
			Me.viewerPanel.TabIndex = 7
			' 
			' panelDocument
			' 
			Me.panelDocument.Controls.Add(Me.pdfViewer)
			Me.panelDocument.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelDocument.Location = New System.Drawing.Point(0, 0)
			Me.panelDocument.Name = "panelDocument"
			Me.panelDocument.Size = New System.Drawing.Size(451, 564)
			Me.panelDocument.TabIndex = 8
			' 
			' pdfViewer
			' 
			Me.pdfViewer.DetachStreamAfterLoadComplete = True
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 0)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneInitialVisibility = DevExpress.XtraPdfViewer.PdfNavigationPaneVisibility.Hidden
			Me.pdfViewer.ReadOnly = True
			Me.pdfViewer.Size = New System.Drawing.Size(451, 564)
			Me.pdfViewer.TabIndex = 6
			Me.pdfViewer.TabStop = False
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
'			Me.pdfViewer.DocumentClosing += New DevExpress.XtraPdfViewer.PdfDocumentClosingEventHandler(Me.DocumentClosing);
			' 
			' panelOptions
			' 
			Me.panelOptions.Controls.Add(Me.deDate)
			Me.panelOptions.Controls.Add(Me.labelDate)
			Me.panelOptions.Controls.Add(Me.teLastName)
			Me.panelOptions.Controls.Add(Me.labelFlight)
			Me.panelOptions.Controls.Add(Me.ceMale)
			Me.panelOptions.Controls.Add(Me.teFlight)
			Me.panelOptions.Controls.Add(Me.ceFemale)
			Me.panelOptions.Controls.Add(Me.labelPassport)
			Me.panelOptions.Controls.Add(Me.teFirstName)
			Me.panelOptions.Controls.Add(Me.tePassport)
			Me.panelOptions.Controls.Add(Me.teVisa)
			Me.panelOptions.Controls.Add(Me.buttonSubmit)
			Me.panelOptions.Controls.Add(Me.teAddress)
			Me.panelOptions.Controls.Add(Me.panelSubmit)
			Me.panelOptions.Controls.Add(Me.cbeNationality)
			Me.panelOptions.Controls.Add(Me.labelAddress)
			Me.panelOptions.Controls.Add(Me.labelFirstName)
			Me.panelOptions.Controls.Add(Me.labelVisa)
			Me.panelOptions.Controls.Add(Me.labelLastName)
			Me.panelOptions.Controls.Add(Me.labelCountry)
			Me.panelOptions.Controls.Add(Me.labelGender)
			Me.panelOptions.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelOptions.Location = New System.Drawing.Point(451, 0)
			Me.panelOptions.Name = "panelOptions"
			Me.panelOptions.Size = New System.Drawing.Size(286, 564)
			Me.panelOptions.TabIndex = 6
			' 
			' deDate
			' 
			Me.deDate.EditValue = New System.DateTime(1985, 8, 30, 0, 0, 0, 0)
			Me.deDate.Location = New System.Drawing.Point(112, 134)
			Me.deDate.Name = "deDate"
			Me.deDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
			Me.deDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.deDate.Properties.MaxValue = New System.DateTime((CLng(Fix(0))))
			Me.deDate.Size = New System.Drawing.Size(152, 20)
			Me.deDate.TabIndex = 64
			' 
			' labelDate
			' 
			Me.labelDate.Location = New System.Drawing.Point(22, 137)
			Me.labelDate.Name = "labelDate"
			Me.labelDate.Size = New System.Drawing.Size(65, 13)
			Me.labelDate.TabIndex = 63
			Me.labelDate.Text = "Date of Birth:"
			' 
			' labelFlight
			' 
			Me.labelFlight.Location = New System.Drawing.Point(22, 257)
			Me.labelFlight.Name = "labelFlight"
			Me.labelFlight.Size = New System.Drawing.Size(46, 13)
			Me.labelFlight.TabIndex = 62
			Me.labelFlight.Text = "Flight No:"
			' 
			' teFlight
			' 
			Me.teFlight.EditValue = "(KL) KLM 876"
			Me.teFlight.Location = New System.Drawing.Point(112, 254)
			Me.teFlight.Margin = New System.Windows.Forms.Padding(2)
			Me.teFlight.Name = "teFlight"
			Me.teFlight.Size = New System.Drawing.Size(152, 20)
			Me.teFlight.TabIndex = 61
			' 
			' labelPassport
			' 
			Me.labelPassport.Location = New System.Drawing.Point(21, 161)
			Me.labelPassport.Name = "labelPassport"
			Me.labelPassport.Size = New System.Drawing.Size(62, 13)
			Me.labelPassport.TabIndex = 60
			Me.labelPassport.Text = "Passport No:"
			' 
			' tePassport
			' 
			Me.tePassport.EditValue = "31195855"
			Me.tePassport.Location = New System.Drawing.Point(112, 158)
			Me.tePassport.Margin = New System.Windows.Forms.Padding(2)
			Me.tePassport.Name = "tePassport"
			Me.tePassport.Size = New System.Drawing.Size(152, 20)
			Me.tePassport.TabIndex = 59
			' 
			' buttonSubmit
			' 
			Me.buttonSubmit.Location = New System.Drawing.Point(112, 282)
			Me.buttonSubmit.Margin = New System.Windows.Forms.Padding(30)
			Me.buttonSubmit.Name = "buttonSubmit"
			Me.buttonSubmit.Size = New System.Drawing.Size(152, 23)
			Me.buttonSubmit.TabIndex = 52
			Me.buttonSubmit.Text = "Submit"
'			Me.buttonSubmit.Click += New System.EventHandler(Me.SubmitClick);
			' 
			' panelSubmit
			' 
			Me.panelSubmit.Location = New System.Drawing.Point(112, 282)
			Me.panelSubmit.Name = "panelSubmit"
			Me.panelSubmit.Size = New System.Drawing.Size(152, 23)
			Me.panelSubmit.TabIndex = 58
			' 
			' labelAddress
			' 
			Me.labelAddress.Location = New System.Drawing.Point(21, 209)
			Me.labelAddress.Name = "labelAddress"
			Me.labelAddress.Size = New System.Drawing.Size(43, 13)
			Me.labelAddress.TabIndex = 57
			Me.labelAddress.Text = "Address:"
			' 
			' labelVisa
			' 
			Me.labelVisa.Location = New System.Drawing.Point(22, 233)
			Me.labelVisa.Name = "labelVisa"
			Me.labelVisa.Size = New System.Drawing.Size(39, 13)
			Me.labelVisa.TabIndex = 56
			Me.labelVisa.Text = "Visa No:"
			' 
			' labelCountry
			' 
			Me.labelCountry.Location = New System.Drawing.Point(22, 185)
			Me.labelCountry.Name = "labelCountry"
			Me.labelCountry.Size = New System.Drawing.Size(55, 13)
			Me.labelCountry.TabIndex = 55
			Me.labelCountry.Text = "Nationality:"
			' 
			' labelGender
			' 
			Me.labelGender.Location = New System.Drawing.Point(22, 80)
			Me.labelGender.Name = "labelGender"
			Me.labelGender.Size = New System.Drawing.Size(39, 13)
			Me.labelGender.TabIndex = 54
			Me.labelGender.Text = "Gender:"
			' 
			' labelLastName
			' 
			Me.labelLastName.Location = New System.Drawing.Point(22, 42)
			Me.labelLastName.Name = "labelLastName"
			Me.labelLastName.Size = New System.Drawing.Size(53, 13)
			Me.labelLastName.TabIndex = 53
			Me.labelLastName.Text = "Last name:"
			' 
			' labelFirstName
			' 
			Me.labelFirstName.Location = New System.Drawing.Point(21, 18)
			Me.labelFirstName.Name = "labelFirstName"
			Me.labelFirstName.Size = New System.Drawing.Size(54, 13)
			Me.labelFirstName.TabIndex = 50
			Me.labelFirstName.Text = "First name:"
			' 
			' cbeNationality
			' 
			Me.cbeNationality.EditValue = "United States"
			Me.cbeNationality.Location = New System.Drawing.Point(112, 182)
			Me.cbeNationality.Margin = New System.Windows.Forms.Padding(2)
			Me.cbeNationality.Name = "cbeNationality"
			Me.cbeNationality.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbeNationality.Size = New System.Drawing.Size(152, 20)
			Me.cbeNationality.TabIndex = 48
			' 
			' teAddress
			' 
			Me.teAddress.EditValue = "98033, 722 Moss Bay Blvd., Kirkland, WA, USA"
			Me.teAddress.Location = New System.Drawing.Point(112, 206)
			Me.teAddress.Margin = New System.Windows.Forms.Padding(2)
			Me.teAddress.Name = "teAddress"
			Me.teAddress.Size = New System.Drawing.Size(152, 20)
			Me.teAddress.TabIndex = 51
			' 
			' teVisa
			' 
			Me.teVisa.EditValue = "73203393"
			Me.teVisa.Location = New System.Drawing.Point(112, 230)
			Me.teVisa.Margin = New System.Windows.Forms.Padding(2)
			Me.teVisa.Name = "teVisa"
			Me.teVisa.Size = New System.Drawing.Size(152, 20)
			Me.teVisa.TabIndex = 49
			' 
			' teLastName
			' 
			Me.teLastName.EditValue = "Leverling"
			Me.teLastName.Location = New System.Drawing.Point(112, 39)
			Me.teLastName.Margin = New System.Windows.Forms.Padding(2)
			Me.teLastName.Name = "teLastName"
			Me.teLastName.Size = New System.Drawing.Size(152, 20)
			Me.teLastName.TabIndex = 45
			' 
			' teFirstName
			' 
			Me.teFirstName.EditValue = "Janet"
			Me.teFirstName.Location = New System.Drawing.Point(112, 15)
			Me.teFirstName.Margin = New System.Windows.Forms.Padding(2)
			Me.teFirstName.Name = "teFirstName"
			Me.teFirstName.Size = New System.Drawing.Size(152, 20)
			Me.teFirstName.TabIndex = 44
			' 
			' ceFemale
			' 
			Me.ceFemale.EditValue = True
			Me.ceFemale.Location = New System.Drawing.Point(112, 96)
			Me.ceFemale.Name = "ceFemale"
			Me.ceFemale.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			Me.ceFemale.Properties.Caption = "Female"
			Me.ceFemale.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.ceFemale.Properties.RadioGroupIndex = 0
			Me.ceFemale.Size = New System.Drawing.Size(152, 19)
			Me.ceFemale.TabIndex = 47
			' 
			' ceMale
			' 
			Me.ceMale.Location = New System.Drawing.Point(112, 77)
			Me.ceMale.Name = "ceMale"
			Me.ceMale.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
			Me.ceMale.Properties.Caption = "Male"
			Me.ceMale.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
			Me.ceMale.Properties.RadioGroupIndex = 0
			Me.ceMale.Size = New System.Drawing.Size(152, 19)
			Me.ceMale.TabIndex = 46
			Me.ceMale.TabStop = False
			' 
			' PdfFormFilling
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.viewerPanel)
			Me.Name = "PdfFormFilling"
			Me.Size = New System.Drawing.Size(737, 564)
			CType(Me.viewerPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.viewerPanel.ResumeLayout(False)
			Me.panelDocument.ResumeLayout(False)
			Me.panelOptions.ResumeLayout(False)
			Me.panelOptions.PerformLayout()
			CType(Me.deDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.deDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teFlight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tePassport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbeNationality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teVisa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceFemale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ceMale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private viewerPanel As XtraEditors.PanelControl
		Private panelOptions As System.Windows.Forms.Panel
		Private panelDocument As System.Windows.Forms.Panel
		Private WithEvents pdfViewer As XtraPdfViewer.PdfViewer
		Private deDate As XtraEditors.DateEdit
		Private labelDate As XtraEditors.LabelControl
		Private labelFlight As XtraEditors.LabelControl
		Private teFlight As XtraEditors.TextEdit
		Private labelPassport As XtraEditors.LabelControl
		Private tePassport As XtraEditors.TextEdit
		Private WithEvents buttonSubmit As XtraEditors.SimpleButton
		Private panelSubmit As System.Windows.Forms.Panel
		Private labelAddress As XtraEditors.LabelControl
		Private labelVisa As XtraEditors.LabelControl
		Private labelCountry As XtraEditors.LabelControl
		Private labelGender As XtraEditors.LabelControl
		Private labelLastName As XtraEditors.LabelControl
		Private labelFirstName As XtraEditors.LabelControl
		Private cbeNationality As XtraEditors.ComboBoxEdit
		Private teAddress As XtraEditors.TextEdit
		Private teVisa As XtraEditors.TextEdit
		Private teLastName As XtraEditors.TextEdit
		Private teFirstName As XtraEditors.TextEdit
		Private ceFemale As XtraEditors.CheckEdit
		Private ceMale As XtraEditors.CheckEdit

	End Class
End Namespace
