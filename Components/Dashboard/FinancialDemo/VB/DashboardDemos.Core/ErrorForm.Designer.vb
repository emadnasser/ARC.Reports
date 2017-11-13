Imports Microsoft.VisualBasic
Imports System
Namespace DashboardDemos.Core
	Partial Public Class ErrorForm
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ErrorForm))
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.labelErrorCaption = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.textEditErrorDetails = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.textEditErrorDetails.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.simpleButton1.Location = New System.Drawing.Point(192, 314)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(103, 32)
			Me.simpleButton1.TabIndex = 0
			Me.simpleButton1.Text = "OK"
			' 
			' labelErrorCaption
			' 
			Me.labelErrorCaption.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.labelErrorCaption.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
			Me.labelErrorCaption.Location = New System.Drawing.Point(52, 11)
			Me.labelErrorCaption.Name = "labelErrorCaption"
			Me.labelErrorCaption.Size = New System.Drawing.Size(380, 29)
			Me.labelErrorCaption.TabIndex = 2
			Me.labelErrorCaption.Text = "Unable to connect to {0} SQL Server instance:"
			' 
			' labelControl3
			' 
			Me.labelControl3.AllowHtmlString = True
			Me.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
			Me.labelControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.labelControl3.Cursor = System.Windows.Forms.Cursors.Default
			Me.labelControl3.Location = New System.Drawing.Point(57, 199)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(380, 91)
			Me.labelControl3.TabIndex = 2
			Me.labelControl3.Text = resources.GetString("labelControl3.Text")
'			Me.labelControl3.HyperlinkClick += New DevExpress.Utils.HyperlinkClickEventHandler(Me.labelControl3_HyperlinkClick);
			' 
			' textEditErrorDetails
			' 
			Me.textEditErrorDetails.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.textEditErrorDetails.Location = New System.Drawing.Point(52, 49)
			Me.textEditErrorDetails.Margin = New System.Windows.Forms.Padding(6)
			Me.textEditErrorDetails.Name = "textEditErrorDetails"
			Me.textEditErrorDetails.Properties.ReadOnly = True
			Me.textEditErrorDetails.Size = New System.Drawing.Size(385, 141)
			Me.textEditErrorDetails.TabIndex = 3
			Me.textEditErrorDetails.UseOptimizedRendering = True
			' 
			' ErrorForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(495, 370)
			Me.Controls.Add(Me.textEditErrorDetails)
			Me.Controls.Add(Me.labelErrorCaption)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.labelControl3)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "ErrorForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Financial Dashboard"
			CType(Me.textEditErrorDetails.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private labelErrorCaption As DevExpress.XtraEditors.LabelControl
		Private WithEvents labelControl3 As DevExpress.XtraEditors.LabelControl
		Private textEditErrorDetails As DevExpress.XtraEditors.MemoEdit
	End Class
End Namespace
