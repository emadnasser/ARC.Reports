Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.XtraSpreadsheet.Demos
	Partial Public Class CustomDrawModule
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomDrawModule))
			Me.panel1 = New DevExpress.XtraEditors.PanelControl()
			Me.ceDisplayFCallouts = New DevExpress.XtraEditors.CheckEdit()
			Me.cуHighlightErrors = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.ceDisplayFCallouts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cуHighlightErrors.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panel1.Controls.Add(Me.ceDisplayFCallouts)
			Me.panel1.Controls.Add(Me.cуHighlightErrors)
			resources.ApplyResources(Me.panel1, "panel1")
			Me.panel1.Name = "panel1"
			' 
			' ceDisplayFCallouts
			' 
			resources.ApplyResources(Me.ceDisplayFCallouts, "ceDisplayFCallouts")
			Me.ceDisplayFCallouts.Name = "ceDisplayFCallouts"
			Me.ceDisplayFCallouts.Properties.Caption = resources.GetString("ceDisplayFCallouts.Properties.Caption")
'			Me.ceDisplayFCallouts.CheckedChanged += New System.EventHandler(Me.checkEdit_CheckedChanged);
			' 
			' cуHighlightErrors
			' 
			resources.ApplyResources(Me.cуHighlightErrors, "cуHighlightErrors")
			Me.cуHighlightErrors.Name = "cуHighlightErrors"
			Me.cуHighlightErrors.Properties.Caption = resources.GetString("cуHighlightErrors.Properties.Caption")
'			Me.cуHighlightErrors.CheckedChanged += New System.EventHandler(Me.checkEdit_CheckedChanged);
			' 
			' CustomDrawModule
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.panel1)
			Me.Name = "CustomDrawModule"
			CType(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.ceDisplayFCallouts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cуHighlightErrors.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As XtraEditors.PanelControl
		Private WithEvents ceDisplayFCallouts As XtraEditors.CheckEdit
		Private WithEvents cуHighlightErrors As XtraEditors.CheckEdit
	End Class
End Namespace
