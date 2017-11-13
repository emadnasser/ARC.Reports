Imports Microsoft.VisualBasic
Imports System
Namespace FinancialDemo.Designer
	Partial Public Class DesignerForm
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DesignerForm))
			Me.dashboardDesigner1 = New DevExpress.DashboardWin.DashboardDesigner()
			Me.SuspendLayout()
			' 
			' dashboardDesigner1
			' 
			Me.dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardDesigner1.Location = New System.Drawing.Point(0, 0)
			Me.dashboardDesigner1.Name = "dashboardDesigner1"
			Me.dashboardDesigner1.Size = New System.Drawing.Size(1370, 813)
			Me.dashboardDesigner1.TabIndex = 0
			' 
			' DesignerForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1370, 813)
			Me.Controls.Add(Me.dashboardDesigner1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "DesignerForm"
			Me.Text = "Financial Dashboard Demo Designer"
'			Me.Load += New System.EventHandler(Me.DesignerForm_Load);
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dashboardDesigner1 As DevExpress.DashboardWin.DashboardDesigner
	End Class
End Namespace
