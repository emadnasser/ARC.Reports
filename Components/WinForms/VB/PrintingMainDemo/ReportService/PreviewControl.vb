Imports System
Imports DevExpress.XtraBars
Imports DevExpress.ReportServer.Printing
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.ReportServer.ServiceModel.DataContracts
Imports DevExpress.DocumentServices.ServiceModel
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraEditors.Controls

Namespace XtraPrintingDemos.ReportService
    ''' <summary>
    ''' Summary description for PreviewControl.
    ''' </summary>
    Public Class PreviewControl
        Inherits XtraPrintingDemos.PreviewControl

        Private Class ReportInfo
            Public Property Id() As Integer
            Public Property Parameter() As Pair(Of String, Object)
        End Class

        Private Shared ReadOnly availableReports As New Dictionary(Of String, ReportInfo)()

        Private components As System.ComponentModel.IContainer
        Private navigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
        Private WithEvents reportListBox As DevExpress.XtraEditors.CheckedListBoxControl
        Private printingSystem As DevExpress.XtraPrinting.PrintingSystem

        Private ReadOnly Property SelectedReport() As String
            Get
                Dim checkedItem = reportListBox.Items.FirstOrDefault(Function(item) item.CheckState = System.Windows.Forms.CheckState.Checked)
                Return If(checkedItem IsNot Nothing, checkedItem.Value.ToString(), availableReports.Keys.ElementAt(0))
            End Get
        End Property

        Public Sub New()
            availableReports.Add("Invoice", New ReportInfo With {.Id = 5, .Parameter = New Pair(Of String, Object)("maxOrderId", 10260)})
            availableReports.Add("Suppliers", New ReportInfo With {.Id = 6})
            availableReports.Add("Product List", New ReportInfo With {.Id = 4})
            availableReports.Add("Customer Order History", New ReportInfo With {.Id = 1113})

            InitializeComponent()
            For Each key As String In availableReports.Keys
                reportListBox.Items.Add(key)
            Next key
            reportListBox.Items(0).CheckState = System.Windows.Forms.CheckState.Checked
        End Sub

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                DisposeDocumentSource()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private Sub LoadReport(ByVal reportId As Integer, ByVal parameter As Pair(Of String, Object))
            DisposeDocumentSource()
            Dim documentSource = New RemoteDocumentSource With {.ServiceUri = My.Settings.Default.ReportServer, .ReportIdentity = New ReportIdentity(reportId), .AuthenticationType = AuthenticationType.Guest}
            pControl.DocumentSource = documentSource
            Dim parameters = New DefaultValueParameterContainer()
            If parameter IsNot Nothing Then
                parameters(parameter.First).Value = parameter.Second
            End If
            documentSource.CreateDocument(parameters)
            Viewer.ExecCommand(PrintingSystemCommand.ZoomToPageWidth)
        End Sub
        Private Sub DisposeDocumentSource()
            Dim documentSource As RemoteDocumentSource = TryCast(pControl.DocumentSource, RemoteDocumentSource)
            If documentSource IsNot Nothing Then
                pControl.DocumentSource = Nothing
                documentSource.Dispose()
            End If
        End Sub
        Protected Overrides Sub CreateDocumentCore()
            Dim reportInfo As ReportInfo = availableReports(SelectedReport)
            LoadReport(reportInfo.Id, reportInfo.Parameter)
        End Sub
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.printingSystem = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
            Me.reportListBox = New DevExpress.XtraEditors.CheckedListBoxControl()
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            CType(Me.printingSystem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPage1.SuspendLayout()
            CType(Me.reportListBox, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' pControl
            ' 
            Me.pControl.DocumentSource = Me.printingSystem
            Me.pControl.Size = New System.Drawing.Size(997, 497)
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Location = New System.Drawing.Point(1001, 0)
            Me.navigationPane1.PageProperties.ShowExpandButton = False
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() { Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(210, 501)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(210, 501)
            Me.navigationPane1.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Default
            Me.navigationPane1.Visible = True
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Reports"
            Me.navigationPage1.Controls.Add(Me.reportListBox)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(167, 441)
            ' 
            ' reportListBox
            ' 
            Me.reportListBox.CheckOnClick = True
            Me.reportListBox.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.reportListBox.Cursor = System.Windows.Forms.Cursors.Default
            Me.reportListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.reportListBox.Location = New System.Drawing.Point(0, 0)
            Me.reportListBox.Name = "reportListBox"
            Me.reportListBox.Size = New System.Drawing.Size(167, 441)
            Me.reportListBox.TabIndex = 0
            ' 
            ' PreviewControl
            ' 
            Me.Name = "PreviewControl"
            CType(Me.navigationPane1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            CType(Me.printingSystem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPage1.ResumeLayout(False)
            CType(Me.reportListBox, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private Sub reportListBox_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles reportListBox.ItemCheck
            RemoveHandler reportListBox.ItemCheck, AddressOf reportListBox_ItemCheck

            For i As Integer = 0 To reportListBox.Items.Count - 1
                If i <> e.Index Then
                    reportListBox.Items(i).CheckState = System.Windows.Forms.CheckState.Unchecked
                End If
            Next i

            AddHandler reportListBox.ItemCheck, AddressOf reportListBox_ItemCheck
            CreateDocument()
        End Sub
    End Class
End Namespace
