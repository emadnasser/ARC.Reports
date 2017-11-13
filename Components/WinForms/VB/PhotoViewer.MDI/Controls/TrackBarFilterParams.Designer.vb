Imports Microsoft.VisualBasic
Imports System
Namespace PhotoViewer
	Partial Public Class TrackBarFilterParams
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
			Me.trackBar = New DevExpress.XtraEditors.TrackBarControl()
			CType(Me.SimpleFilterParamsConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SimpleFilterParamsConvertedLayout.SuspendLayout()
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.applyButtonItem, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.trackBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.SimpleFilterParamsConvertedLayout.Controls.SetChildIndex(Me.applyFilterButton, 0)
			' 
			' trackBarControl1
			' 
			Me.trackBar.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.trackBar.EditValue = 500
			Me.trackBar.Location = New System.Drawing.Point(104, 51)
			Me.trackBar.Name = "trackBarControl1"
			Me.trackBar.Properties.Alignment = DevExpress.Utils.VertAlignment.Center
			Me.trackBar.Properties.AllowFocused = False
			Me.trackBar.Properties.AutoSize = False
			Me.trackBar.Properties.Maximum = 1000
			Me.trackBar.Properties.ShowValueToolTip = True
			Me.trackBar.Properties.TickStyle = System.Windows.Forms.TickStyle.None
'			Me.trackBar.Properties.BeforeShowValueToolTip += New DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(Me.OnBeforeShowTrackBarValueToolTip);
			Me.trackBar.Size = New System.Drawing.Size(216, 70)
			Me.trackBar.TabIndex = 1
			Me.trackBar.Value = 500
'			Me.trackBar.EditValueChanged += New System.EventHandler(Me.trackBar_EditValueChanged);
			' 
			' TrackBarFilterParams
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "TrackBarFilterParams"
			CType(Me.SimpleFilterParamsConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
			Me.SimpleFilterParamsConvertedLayout.ResumeLayout(False)
			CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.applyButtonItem, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.trackBar, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Protected WithEvents trackBar As DevExpress.XtraEditors.TrackBarControl

	End Class
End Namespace
