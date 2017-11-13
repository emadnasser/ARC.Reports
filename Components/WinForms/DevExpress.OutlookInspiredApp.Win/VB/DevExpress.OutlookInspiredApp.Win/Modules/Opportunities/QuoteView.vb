Imports DevExpress.DevAV.ViewModels
Imports System.Collections.Generic

Namespace DevExpress.DevAV.Modules

    Partial Public Class QuoteView
        Inherits BaseModuleControl

        Public Sub New()
            MyBase.New(GetType(SynchronizedQuoteViewModel))
            InitializeComponent()
        End Sub
        Public ReadOnly Overloads Property ViewModel() As QuoteViewModel
            Get
                Return GetViewModel(Of QuoteViewModel)()
            End Get
        End Property
        Public Property DataSource() As IList(Of QuoteMapItem)
            Get
                Return TryCast(chartControl.DataSource, IList(Of QuoteMapItem))
            End Get
            Set(ByVal value As IList(Of QuoteMapItem))
                chartControl.DataSource = value
                If value IsNot Nothing Then
                    chartControl.Series(0).ArgumentDataMember = "Name"
                    chartControl.Series(0).ValueDataMembers.AddRange(New String() { "Value" })
                End If
            End Set
        End Property
        Protected Friend Function GetStageColor(ByVal stage As Stage) As System.Drawing.Color
            Dim values = System.Enum.GetValues(GetType(Stage))
            Dim entries = chartControl.GetPaletteEntries(values.Length)
            Return entries(System.Array.IndexOf(values, stage)).Color
        End Function
    End Class
End Namespace
