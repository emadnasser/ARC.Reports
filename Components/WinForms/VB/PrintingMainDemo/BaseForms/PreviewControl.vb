Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Preview
Imports DevExpress.XtraPrinting.Control
Imports System.Data
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.DXperience.Demos
Imports DevExpress.Tutorials.Controls

Namespace XtraPrintingDemos
    ''' <summary>
    ''' Summary description for ModuleControl.
    ''' </summary>
    Public Class PreviewControl
        Inherits TutorialControlBase
        Implements IPreviewControl

        Protected pControl As DevExpress.XtraPrinting.Preview.DocumentViewer
        Protected navigationPane1 As DevExpress.XtraBars.Navigation.NavigationPane
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private wasActivated As Boolean = False

        Private ReadOnly Property IPreviewControl_Viewer() As DocumentViewer Implements IPreviewControl.Viewer
            Get
                Return Viewer
            End Get
        End Property
        Protected ReadOnly Property Viewer() As DocumentViewer
            Get
                Return pControl
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Overrides Property AutoMergeRibbon() As Boolean
            Get
                Return False
            End Get
            Set(ByVal value As Boolean)
            End Set
        End Property
        Private Sub IPreviewControl_Activate(ByVal controller As DocumentViewerRibbonController) Implements IPreviewControl.Activate
            If pControl.DockManager IsNot Nothing Then
                Dim navigationDockPanel As DevExpress.XtraBars.Docking.DockPanel = pControl.DockManager.Panels(New System.Guid("6b2e64eb-afd0-4676-bc3d-eca7e99946aa"))
                If navigationDockPanel IsNot Nothing Then
                    navigationDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
                End If
            End If
            If controller IsNot Nothing Then
                controller.DocumentViewer = pControl
            End If
            If Not wasActivated Then
                CreateDocument()
                wasActivated = True
            End If
        End Sub
        Protected Overrides Sub DoHide()
        End Sub
        Public Sub CreateDocument()
            Dim currentCursor As Cursor = Cursor.Current
            Try
                Cursor.Current = Cursors.WaitCursor
                CreateDocumentCore()
            Finally
                Cursor.Current = currentCursor
            End Try
        End Sub
        Protected Overridable Sub CreateDocumentCore()
        End Sub

        #Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        ''' 
        Private Sub InitializeComponent()
            Me.pControl = New DevExpress.XtraPrinting.Preview.DocumentViewer()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.NavigationPane()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' pControl
            ' 
            Me.pControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pControl.IsMetric = False
            Me.pControl.Location = New System.Drawing.Point(2, 2)
            Me.pControl.Name = "pControl"
            Me.pControl.RequestDocumentCreation = False
            Me.pControl.Size = New System.Drawing.Size(1207, 497)
            Me.pControl.TabIndex = 1
            Me.pControl.TabStop = False
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right
            Me.navigationPane1.ItemOrientation = System.Windows.Forms.Orientation.Vertical
            Me.navigationPane1.Location = New System.Drawing.Point(1211, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.RegularSize = New System.Drawing.Size(300, 333)
            Me.navigationPane1.SelectedPage = Nothing
            Me.navigationPane1.Size = New System.Drawing.Size(0, 501)
            Me.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Collapsed
            Me.navigationPane1.TabIndex = 7
            Me.navigationPane1.Text = "navigationPane1"
            Me.navigationPane1.Visible = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.pControl)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(1211, 501)
            Me.panelControl1.TabIndex = 8
            ' 
            ' PreviewControl
            ' 
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.navigationPane1)
            Me.Name = "PreviewControl"
            Me.Size = New System.Drawing.Size(1211, 501)
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub
        #End Region
    End Class
End Namespace
