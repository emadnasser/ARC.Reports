Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.ApplicationUI.Demos
	Partial Public Class BaseControl
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseControl))
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.Images = Me.imageList1
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar"})
'			Me.dockManager1.RegisterDockPanel += New DevExpress.XtraBars.Docking.DockPanelEventHandler(Me.dockManager1_RegisterDockPanel);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "")
			' 
			' BaseControl
			' 
			Me.Name = "BaseControl"
			Me.Size = New System.Drawing.Size(276, 156)
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Protected WithEvents dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
