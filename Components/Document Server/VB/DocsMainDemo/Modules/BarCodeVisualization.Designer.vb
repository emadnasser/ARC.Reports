Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.BarCodes
Imports System.Drawing
Imports System.Text
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class BarCodeVisualization
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing
		Private pictureEdit As PictureEdit
		Private barCode As BarCode
		Private WithEvents symbologySelectCB As ComboBoxEdit
		Private descriptionME As MemoEdit
		Private WithEvents showTextCE As CheckEdit
		Private WithEvents barCodeText As TextEdit
		Private WithEvents backColorE As ColorEdit
		Private WithEvents foreColorE As ColorEdit
		Private WithEvents angleSE As SpinEdit
		Private topCaptionGC As GroupControl
		Private WithEvents topCaptionTE As TextEdit
		Private WithEvents bottomCaptionTE As TextEdit
		Private WithEvents topCaptionCE As CheckEdit
		Private WithEvents bottomCaptionCE As CheckEdit
		Private barCogeGC As GroupControl
		Private WithEvents codeTextFE As FontEdit
		Private codeTextLC As LabelControl

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
			Me.pictureEdit = New DevExpress.XtraEditors.PictureEdit()
			Me.symbologySelectCB = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.descriptionME = New DevExpress.XtraEditors.MemoEdit()
			Me.showTextCE = New DevExpress.XtraEditors.CheckEdit()
			Me.barCodeText = New DevExpress.XtraEditors.TextEdit()
			Me.backColorE = New DevExpress.XtraEditors.ColorEdit()
			Me.foreColorE = New DevExpress.XtraEditors.ColorEdit()
			Me.angleSE = New DevExpress.XtraEditors.SpinEdit()
			Me.topCaptionGC = New DevExpress.XtraEditors.GroupControl()
			Me.topCaptionAligmentCB = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.topCaptionTE = New DevExpress.XtraEditors.TextEdit()
			Me.topCaptionCE = New DevExpress.XtraEditors.CheckEdit()
			Me.topCaptionForeCE = New DevExpress.XtraEditors.ColorEdit()
			Me.topCaptionFE = New DevExpress.XtraEditors.FontEdit()
			Me.TopCaptionTextLC = New DevExpress.XtraEditors.LabelControl()
			Me.topCaptionAlignmentLC = New DevExpress.XtraEditors.LabelControl()
			Me.topCaptionForeColorLC = New DevExpress.XtraEditors.LabelControl()
			Me.topCaptionFontNameLC = New DevExpress.XtraEditors.LabelControl()
			Me.bottomCaptionTE = New DevExpress.XtraEditors.TextEdit()
			Me.bottomCaptionAligmentCB = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.bottomCaptionCE = New DevExpress.XtraEditors.CheckEdit()
			Me.codeTextHorzAlignmentCB = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.codeTextVertAlignmentCB = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.barCogeGC = New DevExpress.XtraEditors.GroupControl()
			Me.backcolorLC = New DevExpress.XtraEditors.LabelControl()
			Me.foreColorLC = New DevExpress.XtraEditors.LabelControl()
			Me.angleLC = New DevExpress.XtraEditors.LabelControl()
			Me.codeTextFontLC = New DevExpress.XtraEditors.LabelControl()
			Me.codeTextHorzAlignmentLC = New DevExpress.XtraEditors.LabelControl()
			Me.codeTextVertAlignmentLC = New DevExpress.XtraEditors.LabelControl()
			Me.codeTextLC = New DevExpress.XtraEditors.LabelControl()
			Me.codeTextFE = New DevExpress.XtraEditors.FontEdit()
			Me.bottomCaptionGC = New DevExpress.XtraEditors.GroupControl()
			Me.bottomCaptionForeCE = New DevExpress.XtraEditors.ColorEdit()
			Me.bottomCaptionFE = New DevExpress.XtraEditors.FontEdit()
			Me.bottomCaptionTextLC = New DevExpress.XtraEditors.LabelControl()
			Me.bottomCaptionAlignmentLC = New DevExpress.XtraEditors.LabelControl()
			Me.bottomCaptionFontNameLC = New DevExpress.XtraEditors.LabelControl()
			Me.bottomCaptionForeColorLC = New DevExpress.XtraEditors.LabelControl()
			Me.errorText = New DevExpress.XtraEditors.LabelControl()
			CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.symbologySelectCB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.descriptionME.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.showTextCE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barCodeText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.backColorE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.foreColorE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.angleSE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.topCaptionGC, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.topCaptionGC.SuspendLayout()
			CType(Me.topCaptionAligmentCB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.topCaptionTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.topCaptionCE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.topCaptionForeCE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.topCaptionFE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bottomCaptionTE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bottomCaptionAligmentCB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bottomCaptionCE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.codeTextHorzAlignmentCB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.codeTextVertAlignmentCB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barCogeGC, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.barCogeGC.SuspendLayout()
			CType(Me.codeTextFE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bottomCaptionGC, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.bottomCaptionGC.SuspendLayout()
			CType(Me.bottomCaptionForeCE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bottomCaptionFE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pictureEdit
			' 
			Me.pictureEdit.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pictureEdit.Location = New System.Drawing.Point(3, 29)
			Me.pictureEdit.Name = "pictureEdit"
			Me.pictureEdit.Properties.ShowMenu = False
			Me.pictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
			Me.pictureEdit.Size = New System.Drawing.Size(377, 368)
			Me.pictureEdit.TabIndex = 1
			' 
			' symbologySelectCB
			' 
			Me.symbologySelectCB.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.symbologySelectCB.Location = New System.Drawing.Point(3, 3)
			Me.symbologySelectCB.Name = "symbologySelectCB"
			Me.symbologySelectCB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.symbologySelectCB.Properties.DropDownRows = 20
			Me.symbologySelectCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.symbologySelectCB.Size = New System.Drawing.Size(377, 20)
			Me.symbologySelectCB.TabIndex = 0
'			Me.symbologySelectCB.SelectedIndexChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' descriptionME
			' 
			Me.descriptionME.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.descriptionME.Location = New System.Drawing.Point(2, 403)
			Me.descriptionME.Name = "descriptionME"
			Me.descriptionME.Properties.ReadOnly = True
			Me.descriptionME.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
			Me.descriptionME.Size = New System.Drawing.Size(377, 156)
			Me.descriptionME.TabIndex = 2
			' 
			' showTextCE
			' 
			Me.showTextCE.Location = New System.Drawing.Point(10, 24)
			Me.showTextCE.Name = "showTextCE"
			Me.showTextCE.Properties.Caption = "Show text"
			Me.showTextCE.Size = New System.Drawing.Size(107, 19)
			Me.showTextCE.TabIndex = 3
'			Me.showTextCE.CheckStateChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' barCodeText
			' 
			Me.barCodeText.Location = New System.Drawing.Point(75, 47)
			Me.barCodeText.Name = "barCodeText"
			Me.barCodeText.Size = New System.Drawing.Size(240, 20)
			Me.barCodeText.TabIndex = 4
'			Me.barCodeText.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' backColorE
			' 
			Me.backColorE.EditValue = System.Drawing.Color.White
			Me.backColorE.Location = New System.Drawing.Point(75, 205)
			Me.backColorE.Name = "backColorE"
			Me.backColorE.Size = New System.Drawing.Size(240, 20)
			Me.backColorE.TabIndex = 10
'			Me.backColorE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' foreColorE
			' 
			Me.foreColorE.EditValue = System.Drawing.Color.Black
			Me.foreColorE.Location = New System.Drawing.Point(75, 179)
			Me.foreColorE.Name = "foreColorE"
			Me.foreColorE.Size = New System.Drawing.Size(240, 20)
			Me.foreColorE.TabIndex = 9
'			Me.foreColorE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' angleSE
			' 
			Me.angleSE.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.angleSE.Location = New System.Drawing.Point(75, 153)
			Me.angleSE.Name = "angleSE"
			Me.angleSE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.angleSE.Size = New System.Drawing.Size(240, 20)
			Me.angleSE.TabIndex = 8
'			Me.angleSE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' topCaptionGC
			' 
			Me.topCaptionGC.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.topCaptionGC.Controls.Add(Me.topCaptionAligmentCB)
			Me.topCaptionGC.Controls.Add(Me.topCaptionTE)
			Me.topCaptionGC.Controls.Add(Me.topCaptionCE)
			Me.topCaptionGC.Controls.Add(Me.topCaptionForeCE)
			Me.topCaptionGC.Controls.Add(Me.topCaptionFE)
			Me.topCaptionGC.Controls.Add(Me.TopCaptionTextLC)
			Me.topCaptionGC.Controls.Add(Me.topCaptionAlignmentLC)
			Me.topCaptionGC.Controls.Add(Me.topCaptionForeColorLC)
			Me.topCaptionGC.Controls.Add(Me.topCaptionFontNameLC)
			Me.topCaptionGC.Location = New System.Drawing.Point(385, 241)
			Me.topCaptionGC.Name = "topCaptionGC"
			Me.topCaptionGC.Size = New System.Drawing.Size(319, 156)
			Me.topCaptionGC.TabIndex = 11
			Me.topCaptionGC.Text = "Top Caption"
			' 
			' topCaptionAligmentCB
			' 
			Me.topCaptionAligmentCB.Location = New System.Drawing.Point(75, 76)
			Me.topCaptionAligmentCB.Name = "topCaptionAligmentCB"
			Me.topCaptionAligmentCB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.topCaptionAligmentCB.Properties.DropDownRows = 20
			Me.topCaptionAligmentCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.topCaptionAligmentCB.Size = New System.Drawing.Size(239, 20)
			Me.topCaptionAligmentCB.TabIndex = 13
'			Me.topCaptionAligmentCB.SelectedIndexChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' topCaptionTE
			' 
			Me.topCaptionTE.EditValue = "top caption"
			Me.topCaptionTE.Location = New System.Drawing.Point(75, 50)
			Me.topCaptionTE.Name = "topCaptionTE"
			Me.topCaptionTE.Size = New System.Drawing.Size(239, 20)
			Me.topCaptionTE.TabIndex = 12
'			Me.topCaptionTE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' topCaptionCE
			' 
			Me.topCaptionCE.Location = New System.Drawing.Point(10, 24)
			Me.topCaptionCE.Name = "topCaptionCE"
			Me.topCaptionCE.Properties.Caption = "Show Caption"
			Me.topCaptionCE.Size = New System.Drawing.Size(109, 19)
			Me.topCaptionCE.TabIndex = 11
'			Me.topCaptionCE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' topCaptionForeCE
			' 
			Me.topCaptionForeCE.EditValue = System.Drawing.Color.Black
			Me.topCaptionForeCE.Location = New System.Drawing.Point(75, 102)
			Me.topCaptionForeCE.Name = "topCaptionForeCE"
			Me.topCaptionForeCE.Size = New System.Drawing.Size(239, 20)
			Me.topCaptionForeCE.TabIndex = 14
'			Me.topCaptionForeCE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' topCaptionFE
			' 
			Me.topCaptionFE.Location = New System.Drawing.Point(75, 128)
			Me.topCaptionFE.Name = "topCaptionFE"
			Me.topCaptionFE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.topCaptionFE.Size = New System.Drawing.Size(239, 20)
			Me.topCaptionFE.TabIndex = 15
'			Me.topCaptionFE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' TopCaptionTextLC
			' 
			Me.TopCaptionTextLC.Location = New System.Drawing.Point(12, 53)
			Me.TopCaptionTextLC.Name = "TopCaptionTextLC"
			Me.TopCaptionTextLC.Size = New System.Drawing.Size(26, 13)
			Me.TopCaptionTextLC.TabIndex = 10
			Me.TopCaptionTextLC.Text = "Text:"
			' 
			' topCaptionAlignmentLC
			' 
			Me.topCaptionAlignmentLC.Location = New System.Drawing.Point(12, 79)
			Me.topCaptionAlignmentLC.Name = "topCaptionAlignmentLC"
			Me.topCaptionAlignmentLC.Size = New System.Drawing.Size(51, 13)
			Me.topCaptionAlignmentLC.TabIndex = 10
			Me.topCaptionAlignmentLC.Text = "Alignment:"
			' 
			' topCaptionForeColorLC
			' 
			Me.topCaptionForeColorLC.Location = New System.Drawing.Point(12, 105)
			Me.topCaptionForeColorLC.Name = "topCaptionForeColorLC"
			Me.topCaptionForeColorLC.Size = New System.Drawing.Size(54, 13)
			Me.topCaptionForeColorLC.TabIndex = 10
			Me.topCaptionForeColorLC.Text = "Fore Color:"
			' 
			' topCaptionFontNameLC
			' 
			Me.topCaptionFontNameLC.Location = New System.Drawing.Point(13, 131)
			Me.topCaptionFontNameLC.Name = "topCaptionFontNameLC"
			Me.topCaptionFontNameLC.Size = New System.Drawing.Size(56, 13)
			Me.topCaptionFontNameLC.TabIndex = 10
			Me.topCaptionFontNameLC.Text = "Font Name:"
			' 
			' bottomCaptionTE
			' 
			Me.bottomCaptionTE.EditValue = "bottom caption"
			Me.bottomCaptionTE.Location = New System.Drawing.Point(74, 50)
			Me.bottomCaptionTE.Name = "bottomCaptionTE"
			Me.bottomCaptionTE.Size = New System.Drawing.Size(239, 20)
			Me.bottomCaptionTE.TabIndex = 17
'			Me.bottomCaptionTE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' bottomCaptionAligmentCB
			' 
			Me.bottomCaptionAligmentCB.Location = New System.Drawing.Point(74, 76)
			Me.bottomCaptionAligmentCB.Name = "bottomCaptionAligmentCB"
			Me.bottomCaptionAligmentCB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.bottomCaptionAligmentCB.Properties.DropDownRows = 20
			Me.bottomCaptionAligmentCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.bottomCaptionAligmentCB.Size = New System.Drawing.Size(239, 20)
			Me.bottomCaptionAligmentCB.TabIndex = 18
'			Me.bottomCaptionAligmentCB.SelectedIndexChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' bottomCaptionCE
			' 
			Me.bottomCaptionCE.Location = New System.Drawing.Point(10, 24)
			Me.bottomCaptionCE.Name = "bottomCaptionCE"
			Me.bottomCaptionCE.Properties.AutoWidth = True
			Me.bottomCaptionCE.Properties.Caption = "Show Caption"
			Me.bottomCaptionCE.Size = New System.Drawing.Size(89, 19)
			Me.bottomCaptionCE.TabIndex = 16
'			Me.bottomCaptionCE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' codeTextHorzAlignmentCB
			' 
			Me.codeTextHorzAlignmentCB.Location = New System.Drawing.Point(75, 101)
			Me.codeTextHorzAlignmentCB.Name = "codeTextHorzAlignmentCB"
			Me.codeTextHorzAlignmentCB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.codeTextHorzAlignmentCB.Properties.DropDownRows = 20
			Me.codeTextHorzAlignmentCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.codeTextHorzAlignmentCB.Size = New System.Drawing.Size(240, 20)
			Me.codeTextHorzAlignmentCB.TabIndex = 6
'			Me.codeTextHorzAlignmentCB.SelectedIndexChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' codeTextVertAlignmentCB
			' 
			Me.codeTextVertAlignmentCB.Location = New System.Drawing.Point(75, 75)
			Me.codeTextVertAlignmentCB.Name = "codeTextVertAlignmentCB"
			Me.codeTextVertAlignmentCB.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.codeTextVertAlignmentCB.Properties.DropDownRows = 20
			Me.codeTextVertAlignmentCB.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.codeTextVertAlignmentCB.Size = New System.Drawing.Size(240, 20)
			Me.codeTextVertAlignmentCB.TabIndex = 5
'			Me.codeTextVertAlignmentCB.SelectedIndexChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' barCogeGC
			' 
			Me.barCogeGC.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.barCogeGC.Controls.Add(Me.showTextCE)
			Me.barCogeGC.Controls.Add(Me.barCodeText)
			Me.barCogeGC.Controls.Add(Me.codeTextVertAlignmentCB)
			Me.barCogeGC.Controls.Add(Me.backColorE)
			Me.barCogeGC.Controls.Add(Me.codeTextHorzAlignmentCB)
			Me.barCogeGC.Controls.Add(Me.foreColorE)
			Me.barCogeGC.Controls.Add(Me.backcolorLC)
			Me.barCogeGC.Controls.Add(Me.foreColorLC)
			Me.barCogeGC.Controls.Add(Me.angleLC)
			Me.barCogeGC.Controls.Add(Me.codeTextFontLC)
			Me.barCogeGC.Controls.Add(Me.codeTextHorzAlignmentLC)
			Me.barCogeGC.Controls.Add(Me.codeTextVertAlignmentLC)
			Me.barCogeGC.Controls.Add(Me.codeTextLC)
			Me.barCogeGC.Controls.Add(Me.codeTextFE)
			Me.barCogeGC.Controls.Add(Me.angleSE)
			Me.barCogeGC.Location = New System.Drawing.Point(385, 3)
			Me.barCogeGC.Name = "barCogeGC"
			Me.barCogeGC.Size = New System.Drawing.Size(319, 232)
			Me.barCogeGC.TabIndex = 3
			Me.barCogeGC.Text = "BarCode Properties"
			' 
			' backcolorLC
			' 
			Me.backcolorLC.Location = New System.Drawing.Point(12, 207)
			Me.backcolorLC.Name = "backcolorLC"
			Me.backcolorLC.Size = New System.Drawing.Size(54, 13)
			Me.backcolorLC.TabIndex = 10
			Me.backcolorLC.Text = "Back Color:"
			' 
			' foreColorLC
			' 
			Me.foreColorLC.Location = New System.Drawing.Point(12, 181)
			Me.foreColorLC.Name = "foreColorLC"
			Me.foreColorLC.Size = New System.Drawing.Size(54, 13)
			Me.foreColorLC.TabIndex = 10
			Me.foreColorLC.Text = "Fore Color:"
			' 
			' angleLC
			' 
			Me.angleLC.Location = New System.Drawing.Point(12, 155)
			Me.angleLC.Name = "angleLC"
			Me.angleLC.Size = New System.Drawing.Size(31, 13)
			Me.angleLC.TabIndex = 10
			Me.angleLC.Text = "Angle:"
			' 
			' codeTextFontLC
			' 
			Me.codeTextFontLC.Location = New System.Drawing.Point(12, 129)
			Me.codeTextFontLC.Name = "codeTextFontLC"
			Me.codeTextFontLC.Size = New System.Drawing.Size(56, 13)
			Me.codeTextFontLC.TabIndex = 10
			Me.codeTextFontLC.Text = "Font Name:"
			' 
			' codeTextHorzAlignmentLC
			' 
			Me.codeTextHorzAlignmentLC.Location = New System.Drawing.Point(12, 103)
			Me.codeTextHorzAlignmentLC.Name = "codeTextHorzAlignmentLC"
			Me.codeTextHorzAlignmentLC.Size = New System.Drawing.Size(52, 13)
			Me.codeTextHorzAlignmentLC.TabIndex = 10
			Me.codeTextHorzAlignmentLC.Text = "Horz Align:"
			' 
			' codeTextVertAlignmentLC
			' 
			Me.codeTextVertAlignmentLC.Location = New System.Drawing.Point(12, 77)
			Me.codeTextVertAlignmentLC.Name = "codeTextVertAlignmentLC"
			Me.codeTextVertAlignmentLC.Size = New System.Drawing.Size(50, 13)
			Me.codeTextVertAlignmentLC.TabIndex = 10
			Me.codeTextVertAlignmentLC.Text = "Vert Align:"
			' 
			' codeTextLC
			' 
			Me.codeTextLC.Location = New System.Drawing.Point(12, 49)
			Me.codeTextLC.Name = "codeTextLC"
			Me.codeTextLC.Size = New System.Drawing.Size(26, 13)
			Me.codeTextLC.TabIndex = 10
			Me.codeTextLC.Text = "Text:"
			' 
			' codeTextFE
			' 
			Me.codeTextFE.Location = New System.Drawing.Point(75, 127)
			Me.codeTextFE.Name = "codeTextFE"
			Me.codeTextFE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.codeTextFE.Size = New System.Drawing.Size(240, 20)
			Me.codeTextFE.TabIndex = 7
'			Me.codeTextFE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' bottomCaptionGC
			' 
			Me.bottomCaptionGC.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.bottomCaptionGC.Controls.Add(Me.bottomCaptionTE)
			Me.bottomCaptionGC.Controls.Add(Me.bottomCaptionCE)
			Me.bottomCaptionGC.Controls.Add(Me.bottomCaptionAligmentCB)
			Me.bottomCaptionGC.Controls.Add(Me.bottomCaptionForeCE)
			Me.bottomCaptionGC.Controls.Add(Me.bottomCaptionFE)
			Me.bottomCaptionGC.Controls.Add(Me.bottomCaptionTextLC)
			Me.bottomCaptionGC.Controls.Add(Me.bottomCaptionAlignmentLC)
			Me.bottomCaptionGC.Controls.Add(Me.bottomCaptionFontNameLC)
			Me.bottomCaptionGC.Controls.Add(Me.bottomCaptionForeColorLC)
			Me.bottomCaptionGC.Location = New System.Drawing.Point(385, 403)
			Me.bottomCaptionGC.Name = "bottomCaptionGC"
			Me.bottomCaptionGC.Size = New System.Drawing.Size(318, 156)
			Me.bottomCaptionGC.TabIndex = 16
			Me.bottomCaptionGC.Text = "Bottom Caption"
			' 
			' bottomCaptionForeCE
			' 
			Me.bottomCaptionForeCE.EditValue = System.Drawing.Color.Black
			Me.bottomCaptionForeCE.Location = New System.Drawing.Point(74, 102)
			Me.bottomCaptionForeCE.Name = "bottomCaptionForeCE"
			Me.bottomCaptionForeCE.Size = New System.Drawing.Size(239, 20)
			Me.bottomCaptionForeCE.TabIndex = 19
'			Me.bottomCaptionForeCE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' bottomCaptionFE
			' 
			Me.bottomCaptionFE.Location = New System.Drawing.Point(74, 128)
			Me.bottomCaptionFE.Name = "bottomCaptionFE"
			Me.bottomCaptionFE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.bottomCaptionFE.Size = New System.Drawing.Size(239, 20)
			Me.bottomCaptionFE.TabIndex = 20
'			Me.bottomCaptionFE.EditValueChanged += New System.EventHandler(Me.editValueChanged);
			' 
			' bottomCaptionTextLC
			' 
			Me.bottomCaptionTextLC.Location = New System.Drawing.Point(11, 52)
			Me.bottomCaptionTextLC.Name = "bottomCaptionTextLC"
			Me.bottomCaptionTextLC.Size = New System.Drawing.Size(26, 13)
			Me.bottomCaptionTextLC.TabIndex = 10
			Me.bottomCaptionTextLC.Text = "Text:"
			' 
			' bottomCaptionAlignmentLC
			' 
			Me.bottomCaptionAlignmentLC.Location = New System.Drawing.Point(11, 78)
			Me.bottomCaptionAlignmentLC.Name = "bottomCaptionAlignmentLC"
			Me.bottomCaptionAlignmentLC.Size = New System.Drawing.Size(51, 13)
			Me.bottomCaptionAlignmentLC.TabIndex = 10
			Me.bottomCaptionAlignmentLC.Text = "Alignment:"
			' 
			' bottomCaptionFontNameLC
			' 
			Me.bottomCaptionFontNameLC.Location = New System.Drawing.Point(11, 130)
			Me.bottomCaptionFontNameLC.Name = "bottomCaptionFontNameLC"
			Me.bottomCaptionFontNameLC.Size = New System.Drawing.Size(56, 13)
			Me.bottomCaptionFontNameLC.TabIndex = 10
			Me.bottomCaptionFontNameLC.Text = "Font Name:"
			' 
			' bottomCaptionForeColorLC
			' 
			Me.bottomCaptionForeColorLC.Location = New System.Drawing.Point(11, 104)
			Me.bottomCaptionForeColorLC.Name = "bottomCaptionForeColorLC"
			Me.bottomCaptionForeColorLC.Size = New System.Drawing.Size(54, 13)
			Me.bottomCaptionForeColorLC.TabIndex = 10
			Me.bottomCaptionForeColorLC.Text = "Fore Color:"
			' 
			' errorText
			' 
			Me.errorText.Appearance.BackColor = System.Drawing.Color.White
			Me.errorText.Appearance.ForeColor = System.Drawing.Color.Red
			Me.errorText.LineColor = System.Drawing.Color.White
			Me.errorText.Location = New System.Drawing.Point(12, 376)
			Me.errorText.Name = "errorText"
			Me.errorText.Size = New System.Drawing.Size(189, 13)
			Me.errorText.TabIndex = 17
			Me.errorText.Text = "BarCode text contains invalid symbol(s)"
			Me.errorText.Visible = False
			' 
			' BarCodeVisualization
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.errorText)
			Me.Controls.Add(Me.pictureEdit)
			Me.Controls.Add(Me.symbologySelectCB)
			Me.Controls.Add(Me.descriptionME)
			Me.Controls.Add(Me.bottomCaptionGC)
			Me.Controls.Add(Me.topCaptionGC)
			Me.Controls.Add(Me.barCogeGC)
			Me.Name = "BarCodeVisualization"
			Me.Size = New System.Drawing.Size(712, 569)
			CType(Me.pictureEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.symbologySelectCB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.descriptionME.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.showTextCE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barCodeText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.backColorE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.foreColorE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.angleSE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.topCaptionGC, System.ComponentModel.ISupportInitialize).EndInit()
			Me.topCaptionGC.ResumeLayout(False)
			Me.topCaptionGC.PerformLayout()
			CType(Me.topCaptionAligmentCB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.topCaptionTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.topCaptionCE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.topCaptionForeCE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.topCaptionFE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bottomCaptionTE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bottomCaptionAligmentCB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bottomCaptionCE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.codeTextHorzAlignmentCB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.codeTextVertAlignmentCB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barCogeGC, System.ComponentModel.ISupportInitialize).EndInit()
			Me.barCogeGC.ResumeLayout(False)
			Me.barCogeGC.PerformLayout()
			CType(Me.codeTextFE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bottomCaptionGC, System.ComponentModel.ISupportInitialize).EndInit()
			Me.bottomCaptionGC.ResumeLayout(False)
			Me.bottomCaptionGC.PerformLayout()
			CType(Me.bottomCaptionForeCE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bottomCaptionFE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		Private WithEvents bottomCaptionAligmentCB As ComboBoxEdit
		Private WithEvents topCaptionAligmentCB As ComboBoxEdit
		Private WithEvents codeTextHorzAlignmentCB As ComboBoxEdit
		Private WithEvents codeTextVertAlignmentCB As ComboBoxEdit
		Private bottomCaptionGC As GroupControl
		Private WithEvents topCaptionForeCE As ColorEdit
		Private WithEvents bottomCaptionForeCE As ColorEdit
		Private WithEvents topCaptionFE As FontEdit
		Private WithEvents bottomCaptionFE As FontEdit
		Private codeTextVertAlignmentLC As LabelControl
		Private codeTextHorzAlignmentLC As LabelControl
		Private TopCaptionTextLC As LabelControl
		Private topCaptionAlignmentLC As LabelControl
		Private topCaptionForeColorLC As LabelControl
		Private topCaptionFontNameLC As LabelControl
		Private backcolorLC As LabelControl
		Private foreColorLC As LabelControl
		Private angleLC As LabelControl
		Private codeTextFontLC As LabelControl
		Private bottomCaptionTextLC As LabelControl
		Private bottomCaptionAlignmentLC As LabelControl
		Private bottomCaptionFontNameLC As LabelControl
		Private bottomCaptionForeColorLC As LabelControl
		Private errorText As LabelControl
	End Class
End Namespace
