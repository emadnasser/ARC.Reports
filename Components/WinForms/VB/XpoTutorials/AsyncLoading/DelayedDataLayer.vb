Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.Threading

Namespace DevExpress.Xpo.Demos
    Public Class DelayedDataLayer
        Implements IDataLayer
        Private _dataLayer As IDataLayer
        Public Sub New(ByVal dataLayer As IDataLayer)
            If dataLayer Is Nothing Then
                Throw New ArgumentException()
            End If
            Me._dataLayer = dataLayer
            AddHandler dataLayer.SchemaInit, AddressOf dataLayer_SchemaInit
        End Sub

        Private Sub dataLayer_SchemaInit(ByVal sender As Object, ByVal e As SchemaInitEventArgs)
            RaiseEvent SchemaInit(sender, e)
        End Sub
        Public ReadOnly Property AutoCreateOption() As AutoCreateOption Implements IDataLayer.AutoCreateOption
            Get
                Return _dataLayer.AutoCreateOption
            End Get
        End Property

        Public ReadOnly Property Connection() As System.Data.IDbConnection Implements IDataLayer.Connection
            Get
                Throw New NotSupportedException()
            End Get
        End Property

        Public Function CreateCommand() As System.Data.IDbCommand Implements IDataLayer.CreateCommand
            Throw New NotSupportedException()
        End Function

        Public Function GetDataLayerWideData(ByVal key As Object) As Object Implements IDataLayer.GetDataLayerWideData
            Return _dataLayer.GetDataLayerWideData(key)
        End Function

        Public Function ModifyData(ByVal ParamArray dmlStatements() As ModificationStatement) As ModificationResult Implements IDataLayer.ModifyData
            Thread.Sleep(1000)
            Return _dataLayer.ModifyData(dmlStatements)
        End Function

        Public Event SchemaInit As SchemaInitEventHandler Implements IDataLayer.SchemaInit

        Public Function SelectData(ByVal ParamArray selects() As SelectStatement) As SelectedData Implements IDataLayer.SelectData
            Thread.Sleep(1000)
            Dim data As SelectedData = _dataLayer.SelectData(selects)
            Return data
        End Function

        Public Sub SetDataLayerWideData(ByVal key As Object, ByVal data As Object) Implements IDataLayer.SetDataLayerWideData
            _dataLayer.SetDataLayerWideData(key, data)
        End Sub

        Public Function UpdateSchema(ByVal dontCreateIfFirstTableNotExist As Boolean, ByVal ParamArray types() As DevExpress.Xpo.Metadata.XPClassInfo) As UpdateSchemaResult Implements IDataLayer.UpdateSchema
            Return _dataLayer.UpdateSchema(dontCreateIfFirstTableNotExist, types)
        End Function

        Public Sub Dispose() Implements System.IDisposable.Dispose
            If _dataLayer IsNot Nothing Then
                _dataLayer.Dispose()
            End If
        End Sub

        Public ReadOnly Property DataLayer() As IDataLayer Implements IDataLayer.DataLayer
            Get
                Return Me
            End Get
        End Property

        Public ReadOnly Property Dictionary() As DevExpress.Xpo.Metadata.XPDictionary Implements DevExpress.Xpo.Metadata.Helpers.IXPDictionaryProvider.Dictionary
            Get
                Return _dataLayer.Dictionary
            End Get
        End Property
    End Class
End Namespace