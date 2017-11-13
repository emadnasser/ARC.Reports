Imports System
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Input
Imports DevExpress.Export
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraPrinting.Native.ExportOptionsControllers
Imports Microsoft.Win32
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.Xpf.Grid.Printing

Namespace GridDemo
    Partial Public Class DemoModuleExportControl
        Inherits UserControl

        Private privateView As DataViewBase
        Public Property View() As DataViewBase
            Get
                Return privateView
            End Get
            Private Set(ByVal value As DataViewBase)
                privateView = value
            End Set
        End Property
        Public ReadOnly Property DesignerWrapper() As IGridViewFactory(Of ColumnWrapper, RowBaseWrapper)
            Get
                Return TryCast(View, IGridViewFactory(Of ColumnWrapper, RowBaseWrapper))
            End Get
        End Property
        Private privateExportCommand As ICommand
        Public Property ExportCommand() As ICommand
            Get
                Return privateExportCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateExportCommand = value
            End Set
        End Property

        Public Sub New(ByVal view As DataViewBase, Optional ByVal allowDataAwareExport As Boolean = True, Optional ByVal allowWysiwygExport As Boolean = True, Optional ByVal allowReport As Boolean = False)
            ExportCommand = New DelegateCommand(Of ExportFormat)(AddressOf Export)
            Me.View = view
            DataContext = Me.View
            InitializeComponent()
            If Not allowDataAwareExport Then
                dataAwareExportPanel.Visibility = System.Windows.Visibility.Collapsed
            End If
            If Not allowWysiwygExport Then
                wysiwygExportPanel.Visibility = System.Windows.Visibility.Collapsed
                printPreviewButton.Visibility = System.Windows.Visibility.Collapsed
            End If
        End Sub
        #Region "Data Aware Export"

        Private Sub DataAwareExportToXlsx(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Logger.Log("DataAwareExportToXlsx")
            CType(New DemoModuleExportHelper(View), DemoModuleExportHelper).ExportToXlsx()
        End Sub
        Private Sub DataAwareExportToXls(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Logger.Log("DataAwareExportToXls")
            CType(New DemoModuleExportHelper(View), DemoModuleExportHelper).ExportToXls()
        End Sub
        Private Sub DataAwareExportToCsv(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Logger.Log("DataAwareExportToCsv")
            CType(New DemoModuleExportHelper(View), DemoModuleExportHelper).ExportToCsv()
        End Sub

        #End Region
        #Region "WYSIWYG"
        Private Sub Export(ByVal format As ExportFormat)
            Logger.Log(String.Format("ExportTo{0}", format))
            Dim exportHelper As New DemoModuleWYSIWYGExportHelper(View)
            exportHelper.DoExport(format)
        End Sub
        #End Region
    End Class
    Public Class DemoModuleWYSIWYGExportHelper
        Inherits DemoModuleExportHelper

        Private link As PrintableControlLink
        Public Sub New(ByVal view As DataViewBase)
            MyBase.New(view)
             Me.link = New PrintableControlLink(view)
        End Sub
        Public Sub DoExport(ByVal format As ExportFormat)
            Select Case format
                Case ExportFormat.Xls
                    ExportToXls()
                Case ExportFormat.Xlsx
                    ExportToXlsx()
                Case ExportFormat.Pdf
                    ExportToPdf()
                Case ExportFormat.Htm
                    ExportToHtml()
                Case ExportFormat.Mht
                    ExportToMht()
                Case ExportFormat.Rtf
                    ExportToRtf()
                Case ExportFormat.Txt
                    ExportToTxt()
                Case ExportFormat.Image
                    ExportToImage()
                Case ExportFormat.Xps
                    ExportToXps()
            End Select
        End Sub
        Public Sub ExportToHtml()
            Dim fileName As String = GetFileName(New HtmlExportOptions())
            Export(Sub(file, options) link.ExportToHtml(file, options), fileName, New HtmlExportOptions())
        End Sub
        Public Sub ExportToPdf()
            Dim fileName As String = GetFileName(New PdfExportOptions())
            Export(Sub(file, options) link.ExportToPdf(file, options), fileName, New PdfExportOptions())
        End Sub
        Public Sub ExportToMht()
            Dim fileName As String = GetFileName(New MhtExportOptions())
            Export(Sub(file, options) link.ExportToMht(file, options), fileName, New MhtExportOptions())
        End Sub
        Public Sub ExportToRtf()
            Dim fileName As String = GetFileName(New RtfExportOptions())
            Export(Sub(file, options) link.ExportToRtf(file, options), fileName, New RtfExportOptions())
        End Sub
        Public Sub ExportToTxt()
            Dim fileName As String = GetFileName(New TextExportOptions())
            Export(Sub(file, options) link.ExportToText(file, options), fileName, New TextExportOptions())
        End Sub
        Public Sub ExportToImage()
            Dim fileName As String = GetFileName(New ImageExportOptions())
            Export(Sub(file, options) link.ExportToImage(file, options), fileName, New ImageExportOptions())
        End Sub
        Public Sub ExportToXps()
            Dim fileName As String = GetFileName(New XpsExportOptions())
            Export(Sub(file, options) link.ExportToXps(file, options), fileName, New XpsExportOptions())
        End Sub
        Public Overrides Sub ExportToXlsx()
            Dim fileName As String = GetFileName(New XlsxExportOptions())
            Export(Sub(file, options) link.ExportToXlsx(file, options), fileName, New XlsxExportOptions())
        End Sub
        Public Overrides Sub ExportToXls()
            Dim fileName As String = GetFileName(New XlsExportOptions())
            Export(Sub(file, options) link.ExportToXls(file, options), fileName, New XlsExportOptions())
        End Sub
        Public Overrides Sub ExportToCsv()
            Dim fileName As String = GetFileName(New CsvExportOptions())
            Export(Sub(file, options) link.ExportToCsv(file, options), fileName, New CsvExportOptions())
        End Sub
        Protected Overrides Sub SubscribeProgressEvents(Of T)(ByVal options As T)
            AddHandler link.PrintingSystem.ProgressReflector.PositionChanged, AddressOf OnExportProgress
            AddHandler link.PrintingSystem.AfterBuildPages, AddressOf OnAfterBuildPages
        End Sub
        Private Sub OnAfterBuildPages(ByVal sender As Object, ByVal e As EventArgs)
            DXSplashScreen.Close()
        End Sub
        Private Sub OnExportProgress(ByVal sender As Object, ByVal e As EventArgs)
            ExportProgress(New ProgressChangedEventArgs(link.PrintingSystem.ProgressReflector.Position, Nothing))
        End Sub
        Protected Overrides Sub UnsubscribeProgressEvents(Of T)(ByVal options As T)
            RemoveHandler link.PrintingSystem.ProgressReflector.PositionChanged, AddressOf OnExportProgress
            RemoveHandler link.PrintingSystem.AfterBuildPages, AddressOf OnAfterBuildPages
        End Sub
    End Class
    Public Class DemoModuleExportHelper
        Protected ReadOnly view As DataViewBase
        Public Sub New(ByVal view As DataViewBase)
            Me.view = view
        End Sub
        Public Overridable Sub ExportToXlsx()
            Dim fileName As String = GetFileName(New XlsxExportOptions())
            Export(Sub(file, options) view.ExportToXlsx(file, options), fileName, New XlsxExportOptionsEx())
        End Sub
        Public Overridable Sub ExportToXls()
            Dim fileName As String = GetFileName(New XlsExportOptions())
            Export(Sub(file, options) view.ExportToXls(file, options), fileName, New XlsExportOptionsEx())
        End Sub
        Public Overridable Sub ExportToCsv()
            Dim fileName As String = GetFileName(New CsvExportOptions())
            Export(Sub(file, options) view.ExportToCsv(file, options), fileName, New CsvExportOptionsEx())
        End Sub
        Protected Sub Export(Of T As ExportOptionsBase)(ByVal exportToFile As Action(Of String, T), ByVal fileName As String, ByVal options As T)
            If String.IsNullOrEmpty(fileName) Then
                Return
            End If
            Try
                ExportCore(exportToFile, fileName, options)
            Catch e As Exception
                DXMessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
            End Try
        End Sub
        Protected Overridable Sub SubscribeProgressEvents(Of T)(ByVal options As T)
            AddHandler DirectCast(options, IDataAwareExportOptions).ExportProgress, AddressOf ExportProgress
        End Sub
        Protected Overridable Sub UnsubscribeProgressEvents(Of T)(ByVal options As T)
            RemoveHandler DirectCast(options, IDataAwareExportOptions).ExportProgress, AddressOf ExportProgress
        End Sub
        Protected Overridable Sub ExportCore(Of T As ExportOptionsBase)(ByVal exportToFile As Action(Of String, T), ByVal fileName As String, ByVal options As T)
            DXSplashScreen.Show(Of ExportWaitIndicator)()
            SubscribeProgressEvents(Of T)(options)
            Try
                exportToFile(fileName, options)
            Finally
                UnsubscribeProgressEvents(Of T)(options)
                If DXSplashScreen.IsActive Then
                    DXSplashScreen.Close()
                End If
            End Try
            If ShouldOpenExportedFile() Then
                ProcessLaunchHelper.StartProcess(fileName, False)
            End If
        End Sub
        Protected Sub ExportProgress(ByVal ea As ProgressChangedEventArgs)
            If Not DXSplashScreen.IsActive Then
                Return
            End If
            DXSplashScreen.Progress(ea.ProgressPercentage)
        End Sub
        Protected Shared Function GetFileName(ByVal options As ExportOptionsBase) As String
            Return GetFileName(ExportOptionsControllerBase.GetControllerByOptions(options))
        End Function
        Private Shared Function GetFileName(ByVal controller As ExportOptionsControllerBase) As String
            Dim dlg As SaveFileDialog = CreateSaveFileDialog(controller)
            If dlg.ShowDialog() = True AndAlso (Not String.IsNullOrEmpty(dlg.FileName)) Then
                Return FileHelper.SetValidExtension(dlg.FileName, controller.FileExtensions(0), controller.FileExtensions)
            Else
                Return String.Empty
            End If
        End Function
        Private Shared Function CreateSaveFileDialog(ByVal controller As ExportOptionsControllerBase) As SaveFileDialog
            Dim dlg As New SaveFileDialog()
            dlg.Title = PreviewLocalizer.GetString(PreviewStringId.SaveDlg_Title)
            dlg.ValidateNames = True
            dlg.FileName = PrintPreviewOptions.DefaultFileNameDefault
            dlg.Filter = controller.Filter
            Return dlg
        End Function
        Protected Shared Function ShouldOpenExportedFile() As Boolean
            Return DXMessageBox.Show(PreviewLocalizer.GetString(PreviewStringId.Msg_OpenFileQuestion), PreviewLocalizer.GetString(PreviewStringId.Msg_OpenFileQuestionCaption), MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.Yes
        End Function
    End Class
    Public Class PrintingIconImageSourceConverter
        Implements IValueConverter

        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Dim rawIconName As String = TryCast(value, String)
            If rawIconName Is Nothing Then
                Return Nothing
            End If
            Dim iconName As String = Regex.Replace(rawIconName, "[^a-zA-Z]", String.Empty)
            Dim iconPath As String = "Images/BarItems/" & iconName & "_32x32.png"
            Return New PrintingResourceImageExtension() With {.ResourceName = iconPath}.ProvideValue(Nothing)
        End Function
        Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
