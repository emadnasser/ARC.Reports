Imports System
Imports DevExpress.Mvvm.Native
Imports DevExpress.Mvvm.UI
Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Xpf.Printing
Imports DevExpress.Xpf.Printing.Parameters.Models
Imports DevExpress.XtraReports

Namespace ReportWpfDemo
    Partial Public Class Subreports
        Inherits ReportModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Friend Interface IParametersModelProvider
        ReadOnly Property ParametersModel() As ParametersModel
    End Interface
    <TargetType(GetType(DocumentPreviewControl))>
    Public Class ParametersModelProvider
        Inherits ServiceBase
        Implements IParametersModelProvider

        Private ReadOnly Property IParametersModelProvider_ParametersModel() As ParametersModel Implements IParametersModelProvider.ParametersModel
            Get
                Return If(IsAttached, (TryCast(AssociatedObject, DocumentPreviewControl)).With(Function(x) x.ParametersModel), Nothing)
            End Get
        End Property
    End Class

    Public Class SubreportsViewModel
        Inherits ReportModuleViewModelBase

        Private Const FromDateParameterName As String = "fromDateParameter"
        Private Const ToDateParameterName As String = "toDateParameter"
        Private ReadOnly Property ParametersModel() As ParametersModel
            Get
                Return GetService(Of IParametersModelProvider)().With(Function(x) x.ParametersModel)
            End Get
        End Property

        Private Sub ParametersModel_Validate(ByVal sender As Object, ByVal e As ValidateParameterEventArgs)
            If e.ParameterModel.Name = FromDateParameterName Then
                If Not(TypeOf e.ParameterModel.Value Is Date) Then
                    e.Error = "Please enter a valid Date."
                End If
            End If

            If e.ParameterModel.Name = ToDateParameterName Then
                If Not(TypeOf e.ParameterModel.Value Is Date) Then
                    e.Error = "Please enter a valid Date."
                End If
                Dim fromDateParameter = ParametersModel.FindParameterByName(FromDateParameterName)
                If fromDateParameter Is Nothing OrElse Not(TypeOf fromDateParameter.Value Is Date) Then
                    Return
                End If
                e.Error = If(CDate(e.ParameterModel.Value) < CDate(fromDateParameter.Value), "The end date should be grater than the start date.", String.Empty)
            End If
        End Sub

        Protected Overrides Function CreateReport() As IReport
            ParametersModel.Do(Sub(x)
                RemoveHandler x.Validate, AddressOf ParametersModel_Validate
                AddHandler x.Validate, AddressOf ParametersModel_Validate
            End Sub)
            Return New XtraReportsDemos.Subreports.MasterReport()
        End Function
    End Class
End Namespace
