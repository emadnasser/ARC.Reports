Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports System

Namespace DevExpress.DevAV.ViewModels

    Partial Public Class EmployeeViewModel
        Public Shadows Function IsNew() As Boolean
            Return MyBase.IsNew()
        End Function

        Private contacts_Renamed As EmployeeContactsViewModel
        Public ReadOnly Property Contacts() As EmployeeContactsViewModel
            Get
                If contacts_Renamed Is Nothing Then
                    contacts_Renamed = EmployeeContactsViewModel.Create().SetParentViewModel(Me)
                End If
                Return contacts_Renamed
            End Get
        End Property
        Protected Overrides Function GetTitle() As String
            Return Entity.FullName
        End Function
        Protected Overrides Sub OnEntityChanged()
            MyBase.OnEntityChanged()
            Contacts.Entity = Entity
            Me.RaiseCanExecuteChanged(Sub(x) x.ShowMap())
            Me.RaiseCanExecuteChanged(Sub(x) x.MailMerge())
            Me.RaiseCanExecuteChanged(Sub(x) x.Print(EmployeeReportType.Profile))
            Me.RaiseCanExecuteChanged(Sub(x) x.QuickLetter(EmployeeMailTemplate.ThankYouNote))
            Dim handler As EventHandler = EntityChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
        Public Event EntityChanged As EventHandler
        <Command>
        Public Sub QuickLetter(ByVal mailTemplate As EmployeeMailTemplate)
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then
                collectionViewModel.QuickLetterCore(Entity, mailTemplate)
            End If
        End Sub
        Public Function CanQuickLetter(ByVal mailTemplate As EmployeeMailTemplate) As Boolean
            If Entity Is Nothing OrElse IsNew() Then
                Return False
            End If
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            Return (collectionViewModel IsNot Nothing) AndAlso collectionViewModel.CanQuickLetterCore(Entity, mailTemplate)
        End Function
        <Command>
        Public Sub Print(ByVal reportType As EmployeeReportType)
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then
                collectionViewModel.PrintCore(Entity, reportType)
            End If
        End Sub
        Public Function CanPrint(ByVal reportType As EmployeeReportType) As Boolean
            If Entity Is Nothing OrElse IsNew() Then
                Return False
            End If
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            Return (collectionViewModel IsNot Nothing) AndAlso collectionViewModel.CanPrintProfileCore(Entity)
        End Function
        <Command>
        Public Sub MailMerge()
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then
                collectionViewModel.MailMerge()
            End If
        End Sub
        Public Function CanMailMerge() As Boolean
            Return (Entity IsNot Nothing) AndAlso Not IsNew()
        End Function
        <Command>
        Public Sub ShowMap()
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then
                collectionViewModel.ShowMapCore(Entity)
            End If
        End Sub
        Public Function CanShowMap() As Boolean
            If Entity Is Nothing OrElse IsNew() Then
                Return False
            End If
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            Return (collectionViewModel IsNot Nothing) AndAlso collectionViewModel.CanShowMapCore(Entity)
        End Function
        <Command>
        Public Sub ShowMeeting()
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then
                collectionViewModel.ShowMeeting()
            End If
        End Sub
        Public Function CanShowMeeting() As Boolean
            Return (Entity IsNot Nothing) AndAlso Not IsNew()
        End Function
        <Command>
        Public Sub ShowTask()
            Dim collectionViewModel As EmployeeCollectionViewModel = ViewModelHelper.GetParentViewModel(Of EmployeeCollectionViewModel)(Me)
            If collectionViewModel IsNot Nothing Then
                collectionViewModel.ShowTask()
            End If
        End Sub
        Public Function CanShowTask() As Boolean
            Return (Entity IsNot Nothing) AndAlso Not IsNew()
        End Function
    End Class
    Partial Public Class SynchronizedEmployeeViewModel
        Inherits EmployeeViewModel

        Protected Overrides ReadOnly Property EnableSelectedItemSynchronization() As Boolean
            Get
                Return True
            End Get
        End Property
        Protected Overrides ReadOnly Property EnableEntityChangedSynchronization() As Boolean
            Get
                Return True
            End Get
        End Property
    End Class
End Namespace
