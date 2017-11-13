Imports Microsoft.VisualBasic
Imports System
Namespace PivotGridOlapBrowser
	Partial Public Class PivotGridBrowser
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
				connectionDesigner.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.browserTabs = New PivotGridOlapBrowser.Helpers.BrowserTabControl()
			CType(Me.browserTabs, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.browserTabs.SuspendLayout()
			Me.SuspendLayout()
			' 
			' browserTabs
			' 
			Me.browserTabs.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.browserTabs.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
			Me.browserTabs.Dock = System.Windows.Forms.DockStyle.Fill
			Me.browserTabs.HeaderButtons = (CType(((DevExpress.XtraTab.TabButtons.Prev Or DevExpress.XtraTab.TabButtons.Next) Or DevExpress.XtraTab.TabButtons.Close), DevExpress.XtraTab.TabButtons))
			Me.browserTabs.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.WhenNeeded
			Me.browserTabs.Location = New System.Drawing.Point(8, 8)
			Me.browserTabs.Name = "browserTabs"
			Me.browserTabs.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False
			Me.browserTabs.Size = New System.Drawing.Size(727, 399)
'			Me.browserTabs.SelectedPageChanged += New DevExpress.XtraTab.TabPageChangedEventHandler(browserTabs_SelectedPageChanged);
			Me.browserTabs.TabIndex = 0
			' 
			' PivotGridBrowser
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.browserTabs)
			Me.Name = "PivotGridBrowser"
			Me.Padding = New System.Windows.Forms.Padding(8)
			Me.Size = New System.Drawing.Size(743, 415)
			CType(Me.browserTabs, System.ComponentModel.ISupportInitialize).EndInit()
			Me.browserTabs.ResumeLayout(False)
			Me.ResumeLayout(False)
		End Sub
		#End Region

		Private WithEvents browserTabs As PivotGridOlapBrowser.Helpers.BrowserTabControl
	End Class
End Namespace
