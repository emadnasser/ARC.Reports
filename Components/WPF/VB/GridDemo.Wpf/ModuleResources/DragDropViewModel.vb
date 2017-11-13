Imports System
Imports System.Collections.ObjectModel
Imports System.Linq
Imports System.Windows.Input
Imports DevExpress.Mvvm

Namespace GridDemo
    Public Class DragDropViewModel
        Private privateClearRecycleBin As ICommand
        Public Property ClearRecycleBin() As ICommand
            Get
                Return privateClearRecycleBin
            End Get
            Private Set(ByVal value As ICommand)
                privateClearRecycleBin = value
            End Set
        End Property
        Public Sub New()
            DataSource = New ObservableCollection(Of OutlookData)(OutlookDataGenerator.CreateOutlookArrayList(200).Cast(Of OutlookData)())
            RecycleBinSource = New ObservableCollection(Of OutlookData)(OutlookDataGenerator.CreateOutlookArrayList(5).Cast(Of OutlookData)())
            ClearRecycleBin = New DelegateCommand(Of Object)(AddressOf OnClearRecycleBin)
        End Sub
        Private privateDataSource As ObservableCollection(Of OutlookData)
        Public Property DataSource() As ObservableCollection(Of OutlookData)
            Get
                Return privateDataSource
            End Get
            Private Set(ByVal value As ObservableCollection(Of OutlookData))
                privateDataSource = value
            End Set
        End Property
        Private privateRecycleBinSource As ObservableCollection(Of OutlookData)
        Public Property RecycleBinSource() As ObservableCollection(Of OutlookData)
            Get
                Return privateRecycleBinSource
            End Get
            Private Set(ByVal value As ObservableCollection(Of OutlookData))
                privateRecycleBinSource = value
            End Set
        End Property
        Private Sub OnClearRecycleBin(ByVal parameter As Object)
            RecycleBinSource.Clear()
        End Sub
    End Class
End Namespace
