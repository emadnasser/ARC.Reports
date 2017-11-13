Imports System
Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl

Namespace MainDemo.Module.BusinessObjects
    <DefaultClassOptions()> _
    Public Class Payment
        Inherits BaseObject
        Private rate_Renamed As Double
        Private hours_Renamed As Double
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        <PersistentAlias("Rate * Hours")> _
        Public ReadOnly Property Amount() As Double
            Get
                Return Convert.ToDouble(EvaluateAlias("Amount"))
            End Get
        End Property
        Public Property Rate() As Double
            Get
                Return rate_Renamed
            End Get
            Set(ByVal value As Double)
                If SetPropertyValue("Rate", rate_Renamed, value) Then
                    OnChanged("Amount")
                End If
            End Set
        End Property
        Public Property Hours() As Double
            Get
                Return hours_Renamed
            End Get
            Set(ByVal value As Double)
                If SetPropertyValue("Hours", hours_Renamed, value) Then
                    OnChanged("Amount")
                End If
            End Set
        End Property
    End Class
End Namespace
