Imports System
Imports System.ComponentModel
Imports System.Linq.Expressions
Imports System.Linq
Imports System.Reflection
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Linq.Mapping
Imports System.Data.Linq

'#pragma warning disable 1591

Namespace GridDemo.Controls


    <Global.System.Data.Linq.Mapping.DatabaseAttribute(Name := "DXGridServerModeDB")>
    Partial Public Class PersonDataContext
        Inherits System.Data.Linq.DataContext

        Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

        #Region "Extensibility Method Definitions"
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub InsertPerson(ByVal instance As Person)
        End Sub
        Partial Private Sub UpdatePerson(ByVal instance As Person)
        End Sub
        Partial Private Sub DeletePerson(ByVal instance As Person)
        End Sub
        #End Region

        Public Sub New(ByVal connection As String)
            MyBase.New(connection, mappingSource)
            OnCreated()
        End Sub

        Public Sub New(ByVal connection As System.Data.IDbConnection)
            MyBase.New(connection, mappingSource)
            OnCreated()
        End Sub

        Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
            MyBase.New(connection, mappingSource)
            OnCreated()
        End Sub

        Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
            MyBase.New(connection, mappingSource)
            OnCreated()
        End Sub

        Public ReadOnly Property Person() As System.Data.Linq.Table(Of Person)
            Get
                Return Me.GetTable(Of Person)()
            End Get
        End Property
    End Class

    <Global.System.Data.Linq.Mapping.TableAttribute(Name := "dbo.Person")>
    Partial Public Class Person
        Implements INotifyPropertyChanging, INotifyPropertyChanged

        Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

        Private _PersonID As Integer

        Private _FullName As String

        Private _Company As String

        Private _JobTitle As String

        Private _City As String

        Private _Address As String

        Private _Phone As String

        Private _Email As String

        #Region "Extensibility Method Definitions"
        Partial Private Sub OnLoaded()
        End Sub
        Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        End Sub
        Partial Private Sub OnCreated()
        End Sub
        Partial Private Sub OnPersonIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnPersonIDChanged()
        End Sub
        Partial Private Sub OnFullNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnFullNameChanged()
        End Sub
        Partial Private Sub OnCompanyChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCompanyChanged()
        End Sub
        Partial Private Sub OnJobTitleChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnJobTitleChanged()
        End Sub
        Partial Private Sub OnCityChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCityChanged()
        End Sub
        Partial Private Sub OnAddressChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnAddressChanged()
        End Sub
        Partial Private Sub OnPhoneChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnPhoneChanged()
        End Sub
        Partial Private Sub OnEmailChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnEmailChanged()
        End Sub
        #End Region

        Public Sub New()
            OnCreated()
        End Sub

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage := "_PersonID", AutoSync := AutoSync.OnInsert, DbType := "Int NOT NULL IDENTITY", IsPrimaryKey := True, IsDbGenerated := True)>
        Public Property PersonID() As Integer
            Get
                Return Me._PersonID
            End Get
            Set(ByVal value As Integer)
                If (Me._PersonID <> value) Then
                    Me.OnPersonIDChanging(value)
                    Me.SendPropertyChanging()
                    Me._PersonID = value
                    Me.SendPropertyChanged("PersonID")
                    Me.OnPersonIDChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage := "_FullName", DbType := "NVarChar(MAX)")>
        Public Property FullName() As String
            Get
                Return Me._FullName
            End Get
            Set(ByVal value As String)
                If (Me._FullName <> value) Then
                    Me.OnFullNameChanging(value)
                    Me.SendPropertyChanging()
                    Me._FullName = value
                    Me.SendPropertyChanged("FullName")
                    Me.OnFullNameChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage := "_Company", DbType := "NVarChar(MAX)")>
        Public Property Company() As String
            Get
                Return Me._Company
            End Get
            Set(ByVal value As String)
                If (Me._Company <> value) Then
                    Me.OnCompanyChanging(value)
                    Me.SendPropertyChanging()
                    Me._Company = value
                    Me.SendPropertyChanged("Company")
                    Me.OnCompanyChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage := "_JobTitle", DbType := "NVarChar(MAX)")>
        Public Property JobTitle() As String
            Get
                Return Me._JobTitle
            End Get
            Set(ByVal value As String)
                If (Me._JobTitle <> value) Then
                    Me.OnJobTitleChanging(value)
                    Me.SendPropertyChanging()
                    Me._JobTitle = value
                    Me.SendPropertyChanged("JobTitle")
                    Me.OnJobTitleChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage := "_City", DbType := "NVarChar(MAX)")>
        Public Property City() As String
            Get
                Return Me._City
            End Get
            Set(ByVal value As String)
                If (Me._City <> value) Then
                    Me.OnCityChanging(value)
                    Me.SendPropertyChanging()
                    Me._City = value
                    Me.SendPropertyChanged("City")
                    Me.OnCityChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage := "_Address", DbType := "NVarChar(MAX)")>
        Public Property Address() As String
            Get
                Return Me._Address
            End Get
            Set(ByVal value As String)
                If (Me._Address <> value) Then
                    Me.OnAddressChanging(value)
                    Me.SendPropertyChanging()
                    Me._Address = value
                    Me.SendPropertyChanged("Address")
                    Me.OnAddressChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage := "_Phone", DbType := "NVarChar(MAX)")>
        Public Property Phone() As String
            Get
                Return Me._Phone
            End Get
            Set(ByVal value As String)
                If (Me._Phone <> value) Then
                    Me.OnPhoneChanging(value)
                    Me.SendPropertyChanging()
                    Me._Phone = value
                    Me.SendPropertyChanged("Phone")
                    Me.OnPhoneChanged()
                End If
            End Set
        End Property

        <Global.System.Data.Linq.Mapping.ColumnAttribute(Storage := "_Email", DbType := "NVarChar(MAX)")>
        Public Property Email() As String
            Get
                Return Me._Email
            End Get
            Set(ByVal value As String)
                If (Me._Email <> value) Then
                    Me.OnEmailChanging(value)
                    Me.SendPropertyChanging()
                    Me._Email = value
                    Me.SendPropertyChanged("Email")
                    Me.OnEmailChanged()
                End If
            End Set
        End Property

        Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Overridable Sub SendPropertyChanging()
            RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
        End Sub

        Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace
'#pragma warning restore 1591
