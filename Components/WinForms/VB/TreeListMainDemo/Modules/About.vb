Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.Tutorials


Namespace DevExpress.XtraTreeList.Demos
    Partial Public Class About
        Inherits ucOverviewPage
        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' TODO: Add any initialization after the InitializeComponent call
        End Sub
        Protected Overrides ReadOnly Property Line1Text As String
            Get
                Return "The XtraTreeList Suite"
            End Get
        End Property
        Protected Overrides ReadOnly Property Line2Text As String
            Get
                Return "A hybrid treeview-listview control for the WinForms platform."
            End Get
        End Property
        Protected Overrides ReadOnly Property Line3Text As String
            Get
                Return "DevExpress Desktop Controls"
            End Get
        End Property
        Protected Overrides ReadOnly Property Line4Text As String
            Get
                Return votedVSM
            End Get
        End Property
    End Class
End Namespace

