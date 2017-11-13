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

Namespace XtraPrintingDemos
    ''' <summary>
    ''' Summary description for ModuleControl.
    ''' </summary>
    Public MustInherit Class PreviewControl
        Inherits TutorialModuleControl

        Private documentViewer As DevExpress.XtraPrinting.Preview.DocumentViewer
        Protected printingSystem As DevExpress.XtraPrinting.PrintingSystem
        Private components As System.ComponentModel.IContainer
        Private saveCursor As Cursor
        Protected barManager1 As DevExpress.XtraBars.BarManager
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Protected fBarSettings As DevExpress.XtraBars.Bar
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Protected fPrintBarManager As PrintBarManager

        Protected Overridable ReadOnly Property PrintBarManagerForm() As ContainerControl
            Get
                Return documentViewer
            End Get
        End Property
        Protected Overridable ReadOnly Property PreviewForm() As PrintPreviewFormEx
            Get
                Return If(printingSystem Is Nothing, Nothing, printingSystem.PreviewFormEx)
            End Get
        End Property

        Public Overridable ReadOnly Property PrintControl() As PrintControl
            Get
                Return documentViewer
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            printingSystem.SetCommandVisibility(PrintingSystemCommand.ClosePreview, CommandVisibility.None)

            If fPrintBarManager IsNot Nothing Then
                fPrintBarManager.Dispose()
            End If
            fPrintBarManager = CreatePrintBarManager(documentViewer)
        End Sub

        Public Overrides Sub Activate()
            MyBase.Activate()
            ActivateCore()
        End Sub

        Protected Overridable Sub ActivateCore()
            CreateDocument()
        End Sub
        Protected Sub CreateDocument()
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
            Me.components = New System.ComponentModel.Container()
            Me.documentViewer = New DevExpress.XtraPrinting.Preview.DocumentViewer()
            Me.printingSystem = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.fBarSettings = New DevExpress.XtraBars.Bar()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType(Me.printingSystem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' documentViewer
            ' 
            Me.documentViewer.BackColor = System.Drawing.Color.Empty
            Me.documentViewer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.documentViewer.ForeColor = System.Drawing.Color.Empty
            Me.documentViewer.IsMetric = False
            Me.documentViewer.Location = New System.Drawing.Point(2, 2)
            Me.documentViewer.Name = "documentViewer"
            Me.documentViewer.DocumentSource = Me.printingSystem
            Me.documentViewer.Size = New System.Drawing.Size(696, 368)
            Me.documentViewer.TabIndex = 1
            Me.documentViewer.TabStop = False
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.fBarSettings})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me.panelControl1
            Me.barManager1.MaxItemId = 2
            ' 
            ' fBarSettings
            ' 
            Me.fBarSettings.BarName = "Custom 1"
            Me.fBarSettings.DockCol = 0
            Me.fBarSettings.DockRow = 0
            Me.fBarSettings.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.fBarSettings.FloatLocation = New System.Drawing.Point(51, 129)
            Me.fBarSettings.FloatSize = New System.Drawing.Size(46, 24)
            Me.fBarSettings.Text = "Custom 1"
            Me.fBarSettings.Visible = False
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.documentViewer)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 24)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(700, 372)
            Me.panelControl1.TabIndex = 5
            ' 
            ' PreviewControl
            ' 
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "PreviewControl"
            Me.Size = New System.Drawing.Size(700, 396)
            CType(Me.printingSystem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        #End Region

        Protected Function CreatePrintBarManager(ByVal pc As PrintControl) As PrintBarManager
            Dim printBarManager As New PrintBarManager()
            printBarManager.Form = PrintBarManagerForm
            printBarManager.Initialize(pc)
            printBarManager.MainMenu.Visible = False
            printBarManager.AllowCustomization = False
            Return printBarManager
        End Function

        Private Sub RestoreProcess()
            Cursor.Current = saveCursor
        End Sub
        Private Sub SetWaitProcess()
            saveCursor = Cursor.Current
            Cursor.Current = Cursors.AppStarting
        End Sub
        Private Function GetPrintingSystem() As PrintingSystem
            Return printingSystem
        End Function
    End Class
End Namespace
