Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraReports.UI
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace XtraReportsDemos.TreeView
    Public Class PreviewControl
        Inherits XtraReportsDemos.PreviewControl

        Private splitter1 As SplitterControl
        Private panelTreeView As DevExpress.XtraEditors.PanelControl
        Private holder As New TreeViewHolder()

        Public Sub New()
            InitializeComponent()
            holder.Dock = DockStyle.Fill
            Me.panelTreeView.Controls.Add(holder)
        End Sub
        Protected Overrides Function CreateReport() As XtraReport
            Dim report As New Report()
            AddHandler report.BeforePrint, Sub(s, e) report.WinControlContainer.PrintableComponent = holder.TreeView
            Return report
        End Function
        Private Overloads Sub InitializeComponent()
            Me.panelTreeView = New DevExpress.XtraEditors.PanelControl()
            Me.splitter1 = New SplitterControl()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' printControl
            ' 
            Me.printControl.Size = New System.Drawing.Size(696, 261)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.splitter1)
            Me.panelControl1.Controls.Add(Me.panelTreeView)
            Me.panelControl1.Controls.SetChildIndex(Me.panelTreeView, 0)
            Me.panelControl1.Controls.SetChildIndex(Me.splitter1, 0)
            Me.panelControl1.Controls.SetChildIndex(Me.printControl, 0)
            ' 
            ' panelTreeView
            ' 
            Me.panelTreeView.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panelTreeView.Location = New System.Drawing.Point(2, 266)
            Me.panelTreeView.Name = "panelTreeView"
            Me.panelTreeView.Size = New System.Drawing.Size(696, 92)
            Me.panelTreeView.TabIndex = 2
            ' 
            ' splitter1
            ' 
            Me.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.splitter1.Location = New System.Drawing.Point(2, 263)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(696, 3)
            Me.splitter1.TabIndex = 3
            Me.splitter1.TabStop = False
            ' 
            ' PreviewControl
            ' 
            Me.Name = "PreviewControl"
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
    End Class
End Namespace

