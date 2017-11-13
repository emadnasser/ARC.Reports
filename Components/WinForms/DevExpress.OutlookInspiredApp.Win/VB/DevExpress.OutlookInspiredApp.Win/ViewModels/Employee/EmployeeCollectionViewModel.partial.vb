Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.DevAV
Imports System.Linq
Imports System.Collections.Generic
Imports System

Namespace DevExpress.DevAV.ViewModels

    Partial Public Class EmployeeCollectionViewModel
        Implements ISupportMap, ISupportCustomFilters

        Public Overrides Sub Refresh()
            MyBase.Refresh()
            RaiseReload()
        End Sub
        Protected Overrides Sub OnEntityChanged(ByVal entity As Employee)
            entity.ResetBindable()
        End Sub
        Protected Overrides Sub OnSelectedEntityChanged()
            MyBase.OnSelectedEntityChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.ShowMap())
            Me.RaiseCanExecuteChanged(Sub(x) x.PrintProfile())
            Me.RaiseCanExecuteChanged(Sub(x) x.MailMerge())
            Me.RaiseCanExecuteChanged(Sub(x) x.QuickLetter(EmployeeMailTemplate.ThankYouNote))
        End Sub
        Public Overridable Property Selection() As IEnumerable(Of Employee)
        Protected Overridable Sub OnSelectionChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.GroupSelection())
        End Sub
        Public Event Reload As EventHandler
        Public Event CustomFilter As EventHandler
        Public Event CustomFiltersReset As EventHandler Implements ISupportCustomFilters.CustomFiltersReset
        Public Event CustomGroup As EventHandler
        Public Event CustomGroupFromSelection As EventHandler(Of GroupEventArgs(Of Employee))
        <Command>
        Public Sub ShowMap() Implements ISupportMap.ShowMap
            ShowMapCore(SelectedEntity)
        End Sub
        Public Function CanShowMap() As Boolean Implements ISupportMap.CanShowMap
            Return CanShowMapCore(SelectedEntity)
        End Function
        Protected Friend Sub ShowMapCore(ByVal employee As Employee)
            ShowDocument(Of EmployeeMapViewModel)("MapView", employee.Id)
        End Sub
        Protected Friend Function CanShowMapCore(ByVal employee As Employee) As Boolean
            Return employee IsNot Nothing
        End Function
        <Command>
        Public Sub ShowViewSettings()
            Dim dms = DirectCast(Me, DevExpress.Mvvm.ISupportServices).ServiceContainer.GetService(Of DevExpress.Mvvm.IDocumentManagerService)("View Settings")
            If dms IsNot Nothing Then
                Dim document = dms.Documents.FirstOrDefault(Function(d) TypeOf d.Content Is ViewSettingsViewModel)
                If document Is Nothing Then
                    document = dms.CreateDocument("View Settings", Nothing, Nothing, Me)
                End If
                document.Show()
            End If
        End Sub
        <Command>
        Public Sub NewGroup()
            RaiseCustomGroup()
        End Sub
        <Command>
        Public Sub GroupSelection()
            RaiseCustomGroupFromSelection()
        End Sub
        Public Function CanGroupSelection() As Boolean
            Return (Selection IsNot Nothing) AndAlso Selection.Any()
        End Function
        <Command>
        Public Sub NewCustomFilter()
            RaiseCustomFilter()
        End Sub
        <Command>
        Public Sub PrintProfile()
            PrintCore(SelectedEntity, EmployeeReportType.Profile)
        End Sub
        Public Function CanPrintProfile() As Boolean
            Return CanPrintProfileCore(SelectedEntity)
        End Function
        Protected Friend Sub PrintCore(ByVal employee As Employee, ByVal reportType As EmployeeReportType)
            RaisePrint(reportType)
        End Sub
        Protected Friend Function CanPrintProfileCore(ByVal employee As Employee) As Boolean
            Return employee IsNot Nothing
        End Function
        Private Shared ReadOnly scheduler As String = "This demo does not include integration with our WinForms Scheduler Suite but you can easily introduce" & Environment.NewLine & "Outlook-inspired scheduling and task management capabilities to your apps with DevExpress Tools."
        <Command>
        Public Sub ShowMeeting()
            SchedulerMessage("Meeting")
        End Sub
        <Command>
        Public Sub ShowTask()
            SchedulerMessage("Tasks")
        End Sub
        Private Sub SchedulerMessage(ByVal caption As String)
            MessageBoxService.Show(scheduler, caption, DevExpress.Mvvm.MessageButton.OK, DevExpress.Mvvm.MessageIcon.Information, DevExpress.Mvvm.MessageResult.OK)
        End Sub
        <Command>
        Public Sub PrintSummary()
            RaisePrint(EmployeeReportType.Summary)
        End Sub
        <Command>
        Public Sub PrintDirectory()
            RaisePrint(EmployeeReportType.Directory)
        End Sub
        <Command>
        Public Sub PrintTaskList()
            RaisePrint(EmployeeReportType.TaskList)
        End Sub
        <Command(UseCommandManager := False, CanExecuteMethodName := "CanPrintProfile")>
        Public Sub MailMerge()
            ShowDocument(Of EmployeeMailMergeViewModel)("MailMerge", Nothing)
        End Sub
        <Command>
        Public Sub QuickLetter(ByVal mailTemplate As EmployeeMailTemplate)
            QuickLetterCore(SelectedEntity, mailTemplate)
        End Sub
        Public Function CanQuickLetter(ByVal mailTemplate As EmployeeMailTemplate) As Boolean
            Return CanQuickLetterCore(SelectedEntity, mailTemplate)
        End Function
        Protected Friend Sub QuickLetterCore(ByVal employee As Employee, ByVal mailTemplate As EmployeeMailTemplate)
            ShowDocument(Of EmployeeMailMergeViewModel)("MailMerge", mailTemplate)
        End Sub
        Protected Friend Function CanQuickLetterCore(ByVal employee As Employee, ByVal mailTemplate As EmployeeMailTemplate) As Boolean
            Return employee IsNot Nothing
        End Function
        <Command>
        Public Sub ShowAllFolders()
            RaiseShowAllFolders()
        End Sub
        <Command>
        Public Sub ResetCustomFilters() Implements ISupportCustomFilters.ResetCustomFilters
            RaiseCustomFiltersReset()
        End Sub
        Private Sub RaisePrint(ByVal reportType As EmployeeReportType)
            Dim mainViewModel As MainViewModel = ViewModelHelper.GetParentViewModel(Of MainViewModel)(Me)
            If mainViewModel IsNot Nothing Then
                mainViewModel.RaisePrint(reportType)
            End If
        End Sub
        Private Sub RaiseShowAllFolders()
            Dim mainViewModel As MainViewModel = ViewModelHelper.GetParentViewModel(Of MainViewModel)(Me)
            If mainViewModel IsNot Nothing Then
                mainViewModel.RaiseShowAllFolders()
            End If
        End Sub
        Private Sub RaiseReload()
            Dim handler As EventHandler = ReloadEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Sub RaiseCustomFilter()
            Dim handler As EventHandler = CustomFilterEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Sub RaiseCustomFiltersReset()
            Dim handler As EventHandler = CustomFiltersResetEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Sub RaiseCustomGroup()
            Dim handler As EventHandler = CustomGroupEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Private Sub RaiseCustomGroupFromSelection()
            Dim handler As EventHandler(Of GroupEventArgs(Of Employee)) = CustomGroupFromSelectionEvent
            If handler IsNot Nothing Then
                handler(Me, New GroupEventArgs(Of Employee)(Selection))
            End If
        End Sub
        Private Sub ShowDocument(Of TViewModel)(ByVal documentType As String, ByVal parameter As Object)
            Dim document = FindDocument(Of TViewModel)()
            If TypeOf parameter Is Long Then
                document = FindDocument(Of TViewModel)(DirectCast(parameter, Long))
            End If
            If document Is Nothing Then
                document = DocumentManagerService.CreateDocument(documentType, Nothing, parameter, Me)
            Else
                ViewModelHelper.EnsureViewModel(document.Content, Me, parameter)
            End If
            document.Show()
        End Sub
    End Class
End Namespace
