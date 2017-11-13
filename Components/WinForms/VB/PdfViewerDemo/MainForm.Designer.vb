Imports Microsoft.VisualBasic
Imports System
Namespace PdfViewerDemo
	Partial Public Class MainForm
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.ribbonGallerySkins = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.pdfViewer = New DevExpress.XtraPdfViewer.PdfViewer()
			CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl
			' 
			Me.ribbonControl.ExpandCollapseItem.Id = 0
			Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.ribbonGallerySkins})
			Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl.MaxItemId = 2
			Me.ribbonControl.Name = "ribbonControl"
			Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
			Me.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False
			Me.ribbonControl.Size = New System.Drawing.Size(1308, 49)
			Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
'			Me.ribbonControl.Paint += New System.Windows.Forms.PaintEventHandler(Me.OnRibbonControlPaint);
			' 
			' ribbonGallerySkins
			' 
			Me.ribbonGallerySkins.Caption = "Skins"
			Me.ribbonGallerySkins.Id = 1
			Me.ribbonGallerySkins.Name = "ribbonGallerySkins"
			' 
			' pdfViewer
			' 
			Me.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pdfViewer.Location = New System.Drawing.Point(0, 49)
			Me.pdfViewer.Name = "pdfViewer"
			Me.pdfViewer.NavigationPaneWidth = 303
			Me.pdfViewer.Size = New System.Drawing.Size(1308, 810)
			Me.pdfViewer.TabIndex = 1
			Me.pdfViewer.ZoomMode = DevExpress.XtraPdfViewer.PdfZoomMode.FitToWidth
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1308, 859)
			Me.Controls.Add(Me.pdfViewer)
			Me.Controls.Add(Me.ribbonControl)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "MainForm"
			Me.Ribbon = Me.ribbonControl
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "PDF Viewer"
			CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
		Private pdfViewer As DevExpress.XtraPdfViewer.PdfViewer
		Private ribbonGallerySkins As DevExpress.XtraBars.RibbonGalleryBarItem
	End Class
End Namespace

