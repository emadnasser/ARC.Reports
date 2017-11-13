Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Namespace ContactManagement
	Public Partial Class ObjectList
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
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
			Me.gridObjects = New System.Windows.Forms.DataGrid()
			Me.mainMenu = New System.Windows.Forms.MainMenu(Me.components)
			Me.mnuAdd = New System.Windows.Forms.MenuItem()
			Me.mnuEdit = New System.Windows.Forms.MenuItem()
			Me.mnuDelete = New System.Windows.Forms.MenuItem()
			CType(Me.gridObjects, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridObjects
			' 
			Me.gridObjects.DataMember = ""
			Me.gridObjects.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridObjects.HeaderForeColor = System.Drawing.SystemColors.ControlText
			Me.gridObjects.Location = New System.Drawing.Point(0, 0)
			Me.gridObjects.Name = "gridObjects"
			Me.gridObjects.ReadOnly = True
			Me.gridObjects.Size = New System.Drawing.Size(507, 259)
			Me.gridObjects.TabIndex = 0
'			Me.gridObjects.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.gridObjects_KeyDown);
			' 
			' mainMenu
			' 
			Me.mainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
			' 
			' mnuAdd
			' 
			Me.mnuAdd.Index = 0
			Me.mnuAdd.Text = "Add"
'			Me.mnuAdd.Click += New System.EventHandler(Me.mnuAdd_Click);
			' 
			' mnuEdit
			' 
			Me.mnuEdit.Index = 1
			Me.mnuEdit.Text = "Edit"
'			Me.mnuEdit.Click += New System.EventHandler(Me.mnuEdit_Click);
			' 
			' mnuDelete
			' 
			Me.mnuDelete.Index = 2
			Me.mnuDelete.Text = "Delete"
'			Me.mnuDelete.Click += New System.EventHandler(Me.mnuDelete_Click);
			' 
			' ObjectList
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(507, 259)
			Me.Controls.Add(Me.gridObjects)
			Me.Menu = Me.mainMenu
			Me.Name = "ObjectList"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Objects"
			CType(Me.gridObjects, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents gridObjects As System.Windows.Forms.DataGrid
		Private mainMenu As System.Windows.Forms.MainMenu
		Private WithEvents mnuAdd As System.Windows.Forms.MenuItem
		Private WithEvents mnuEdit As System.Windows.Forms.MenuItem
		Private WithEvents mnuDelete As System.Windows.Forms.MenuItem
		Public objects As XPCollection = Nothing
		Private components As System.ComponentModel.IContainer

	End Class
End Namespace
