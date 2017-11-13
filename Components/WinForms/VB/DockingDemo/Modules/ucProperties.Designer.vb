Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraBars.Demos.DockingDemo
	Partial Public Class ucProperties
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
			Me.propertyGrid = New DevExpress.DXperience.Demos.XtraPropertyGrid()
			Me.comboBox = New DevExpress.XtraEditors.ComboBoxEdit()
			CType(Me.comboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' propertyGrid
			' 
			Me.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGrid.Location = New System.Drawing.Point(0, 22)
			Me.propertyGrid.Name = "propertyGrid"
			Me.propertyGrid.Size = New System.Drawing.Size(219, 404)
			Me.propertyGrid.TabIndex = 4
			' 
			' comboBox
			' 
			Me.comboBox.Dock = System.Windows.Forms.DockStyle.Top
			Me.comboBox.Location = New System.Drawing.Point(0, 0)
			Me.comboBox.Name = "comboBox"
			Me.comboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.comboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.comboBox.Size = New System.Drawing.Size(219, 22)
			Me.comboBox.TabIndex = 3
'			Me.comboBox.SelectedIndexChanged += New System.EventHandler(Me.comboBox_SelectedIndexChanged);
			' 
			' ucProperties
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.propertyGrid)
			Me.Controls.Add(Me.comboBox)
			Me.Name = "ucProperties"
			Me.Size = New System.Drawing.Size(219, 426)
			CType(Me.comboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private propertyGrid As DevExpress.DXperience.Demos.XtraPropertyGrid
		Private WithEvents comboBox As DevExpress.XtraEditors.ComboBoxEdit
	End Class
End Namespace
