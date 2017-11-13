Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpellChecker.Demos
	Partial Public Class CheckRichTextBox
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
			Me.components = New System.ComponentModel.Container()
			Dim optionsSpelling1 As New DevExpress.XtraSpellChecker.OptionsSpelling()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CheckRichTextBox))
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.panel1.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1})
			Me.barManager1.MaxItemId = 1
'			Me.barManager1.QueryShowPopupMenu += New DevExpress.XtraBars.QueryShowPopupMenuEventHandler(Me.barManager1_QueryShowPopupMenu);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(716, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 396)
			Me.barDockControlBottom.Size = New System.Drawing.Size(716, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 396)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(716, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 396)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' richTextBox1
			' 
			Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richTextBox1.Location = New System.Drawing.Point(0, 47)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
			Me.richTextBox1.Size = New System.Drawing.Size(716, 349)
			Me.spellChecker1.SetSpellCheckerOptions(Me.richTextBox1, optionsSpelling1)
			Me.richTextBox1.TabIndex = 5
			Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
'			Me.richTextBox1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.OnEditControlKeyDown);
			' 
			' popupMenu1
			' 
			Me.popupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1)})
			Me.popupMenu1.Manager = Me.barManager1
			Me.popupMenu1.Name = "popupMenu1"
			' 
			' CheckRichTextBox
			' 
			Me.Appearance.Options.UseFont = True
			Me.Controls.Add(Me.richTextBox1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "CheckRichTextBox"
			Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
			Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
			Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
			Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
			Me.Controls.SetChildIndex(Me.panel1, 0)
			Me.Controls.SetChildIndex(Me.richTextBox1, 0)
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private components As System.ComponentModel.IContainer = Nothing
		Private WithEvents barManager1 As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox

	End Class
End Namespace
