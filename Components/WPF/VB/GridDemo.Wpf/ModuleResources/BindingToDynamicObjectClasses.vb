Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Dynamic
Imports System.Windows.Data
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace GridDemo
    Public Class DynamicBindingList
        Inherits ObservableCollection(Of DynamicDictionary)

    End Class
    Public Class DynamicDictionary
        Inherits DynamicObject
        Implements INotifyPropertyChanged

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        #Region "inner classes"
        Private Class SetMemberValueBinder
            Inherits SetMemberBinder

            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName, False)
            End Sub
            Public Overrides Function FallbackSetMember(ByVal target As DynamicMetaObject, ByVal value As DynamicMetaObject, ByVal errorSuggestion As DynamicMetaObject) As DynamicMetaObject
                Return errorSuggestion
            End Function
        End Class
        Private Class GetMemberValueBinder
            Inherits GetMemberBinder

            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName, False)
            End Sub
            Public Overrides Function FallbackGetMember(ByVal target As DynamicMetaObject, ByVal errorSuggestion As DynamicMetaObject) As DynamicMetaObject
                Return errorSuggestion
            End Function
        End Class
        #End Region

        Public Sub New()
            SetValue("Id", 0)
            SetValue("FirstName", "")
            SetValue("LastName", "")
        End Sub
        Private dictionary As New Dictionary(Of String, Object)()
        Public ReadOnly Property Count() As Integer
            Get
                Return dictionary.Count
            End Get
        End Property
        Public Sub SetValue(ByVal propertyName As String, ByVal value As Object)
            TrySetMember(New SetMemberValueBinder(propertyName), value)
        End Sub
        Public Function GetValue(ByVal propertyName As String) As Object
            Dim value As Object = Nothing
            TryGetMember(New GetMemberValueBinder(propertyName), value)
            Return value
        End Function
        Public Overrides Function TryGetMember(ByVal binder As GetMemberBinder, <System.Runtime.InteropServices.Out()> ByRef result As Object) As Boolean
            Dim name As String = binder.Name.ToLower()
            Return dictionary.TryGetValue(name, result)
        End Function

        Public Overrides Function TrySetMember(ByVal binder As SetMemberBinder, ByVal value As Object) As Boolean
            dictionary(binder.Name.ToLower()) = value
            NotifyPropertyChanged(binder.Name)
            Return True
        End Function
        Private Sub NotifyPropertyChanged(ByVal info As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
        End Sub
    End Class
    Public Class StringStateToBoolConverter
        Implements IValueConverter

        Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
            Return Not String.IsNullOrEmpty(DirectCast(value, String))
        End Function

        Private Function IValueConverter_ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
            Throw New NotImplementedException()
        End Function
    End Class
    <POCOViewModel>
    Public Class NewColumnModel
        Public Overridable Property ColumnName() As String
        Public Overridable Property TypeIndex() As Integer
    End Class

End Namespace
