Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.Docs.Demos
	Partial Public Class Decompression

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
			Me.tlZipContent = New DevExpress.XtraTreeList.TreeList()
			Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colUncompressedSize = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colType = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colCompressedSize = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.buttonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
			Me.textPreview = New DevExpress.XtraRichEdit.RichEditControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			CType(Me.tlZipContent, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' tlZipContent
			' 
			Me.tlZipContent.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colName, Me.colUncompressedSize, Me.colType, Me.colCompressedSize})
			Me.tlZipContent.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tlZipContent.Location = New System.Drawing.Point(0, 0)
			Me.tlZipContent.Name = "tlZipContent"
			Me.tlZipContent.OptionsBehavior.Editable = False
			Me.tlZipContent.Size = New System.Drawing.Size(778, 272)
			Me.tlZipContent.TabIndex = 0
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' colUncompressedSize
			' 
			Me.colUncompressedSize.Caption = "Uncompressed size"
			Me.colUncompressedSize.FieldName = "UncompressedSize"
			Me.colUncompressedSize.Name = "colUncompressedSize"
			Me.colUncompressedSize.Visible = True
			Me.colUncompressedSize.VisibleIndex = 1
			' 
			' colType
			' 
			Me.colType.Name = "colType"
			' 
			' colCompressedSize
			' 
			Me.colCompressedSize.Caption = "Compressed size"
			Me.colCompressedSize.FieldName = "CompressedSize"
			Me.colCompressedSize.Name = "colCompressedSize"
			Me.colCompressedSize.Visible = True
			Me.colCompressedSize.VisibleIndex = 2
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.buttonEdit1.Location = New System.Drawing.Point(3, 6)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.buttonEdit1.Size = New System.Drawing.Size(778, 20)
			Me.buttonEdit1.TabIndex = 2
'			Me.buttonEdit1.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.buttonEdit1_ButtonClick);
'			Me.buttonEdit1.KeyUp += New System.Windows.Forms.KeyEventHandler(Me.buttonEdit1_KeyUp);
			' 
			' textPreview
			' 
			Me.textPreview.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple
			Me.textPreview.Dock = System.Windows.Forms.DockStyle.Fill
			Me.textPreview.Location = New System.Drawing.Point(0, 0)
			Me.textPreview.Name = "textPreview"
			Me.textPreview.Options.Fields.UseCurrentCultureDateTimeFormat = False
			Me.textPreview.Options.MailMerge.KeepLastParagraph = False
			Me.textPreview.ReadOnly = True
			Me.textPreview.Size = New System.Drawing.Size(778, 120)
			Me.textPreview.TabIndex = 7
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.splitContainerControl1.Horizontal = False
			Me.splitContainerControl1.Location = New System.Drawing.Point(3, 32)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.tlZipContent)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.pictureBox1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.textPreview)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(778, 397)
			Me.splitContainerControl1.SplitterPosition = 272
			Me.splitContainerControl1.TabIndex = 8
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(778, 120)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
			Me.pictureBox1.TabIndex = 8
			Me.pictureBox1.TabStop = False
			Me.pictureBox1.Visible = False
			' 
			' Decompression
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Controls.Add(Me.buttonEdit1)
			Me.Name = "Decompression"
			CType(Me.tlZipContent, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tlZipContent As XtraTreeList.TreeList
		Private colName As XtraTreeList.Columns.TreeListColumn
		Private colType As XtraTreeList.Columns.TreeListColumn
		Private colUncompressedSize As XtraTreeList.Columns.TreeListColumn
		Private colCompressedSize As XtraTreeList.Columns.TreeListColumn
		Private WithEvents buttonEdit1 As XtraEditors.ButtonEdit
		Private textPreview As XtraRichEdit.RichEditControl
		Private splitContainerControl1 As XtraEditors.SplitContainerControl
		Private pictureBox1 As System.Windows.Forms.PictureBox
	End Class
End Namespace
