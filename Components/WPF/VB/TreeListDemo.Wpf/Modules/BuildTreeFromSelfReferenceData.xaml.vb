Imports System
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports DevExpress.Xpf.Grid
Imports System.Windows.Media.Imaging
Imports System.IO
Imports System.ComponentModel
Imports DevExpress.Xpf.DemoBase.Helpers
Imports DevExpress.Mvvm

Namespace TreeListDemo
    Partial Public Class BuildTreeFromSelfReferenceData
        Inherits TreeListDemoModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DemoModuleControl_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Me.treeList.View.ExpandAllNodes()
        End Sub
    End Class

    Public Class SelfReferenceDataViewModel
        Inherits BindableBase


        Private showServiceColumns_Renamed As Boolean

        Public Property ShowServiceColumns() As Boolean
            Get
                Return showServiceColumns_Renamed
            End Get
            Set(ByVal value As Boolean)
                SetProperty(showServiceColumns_Renamed, value, Function() ShowServiceColumns)
            End Set
        End Property
        Public ReadOnly Property KeyFieldName() As String
            Get
                Return "Id"
            End Get
        End Property
        Public ReadOnly Property ParentFieldName() As String
            Get
                Return "ParentId"
            End Get
        End Property
    End Class
End Namespace
