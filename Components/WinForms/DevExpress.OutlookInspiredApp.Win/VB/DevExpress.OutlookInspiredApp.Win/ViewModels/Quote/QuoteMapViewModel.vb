Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.DevAV.ViewModels
Imports System

Namespace DevExpress.DevAV.ViewModels

    Public Class QuoteMapViewModel
        Inherits QuoteViewModel

        Public Overridable Property Stage() As Stage
        <Command>
        Public Sub SetHighStage()
            Stage = Stage.High
        End Sub
        Public Function CanSetHighStage() As Boolean
            Return Stage <> Stage.High
        End Function
        <Command>
        Public Sub SetMediumStage()
            Stage = Stage.Medium
        End Sub
        Public Function CanSetMediumStage() As Boolean
            Return Stage <> Stage.Medium
        End Function
        <Command>
        Public Sub SetLowStage()
            Stage = Stage.Low
        End Sub
        Public Function CanSetLowStage() As Boolean
            Return Stage <> Stage.Low
        End Function
        <Command>
        Public Sub SetUnlikelyStage()
            Stage = Stage.Unlikely
        End Sub
        Public Function CanSetUnlikelyStage() As Boolean
            Return Stage <> Stage.Unlikely
        End Function
        Protected Overridable Sub OnStageChanged()
            Me.RaiseCanExecuteChanged(Sub(x) x.SetHighStage())
            Me.RaiseCanExecuteChanged(Sub(x) x.SetMediumStage())
            Me.RaiseCanExecuteChanged(Sub(x) x.SetLowStage())
            Me.RaiseCanExecuteChanged(Sub(x) x.SetUnlikelyStage())
            RaiseStageChanged()
        End Sub
        Public Event StageChanged As EventHandler
        Private Sub RaiseStageChanged()
            Dim handler As EventHandler = StageChangedEvent
            If handler IsNot Nothing Then
                handler(Me, EventArgs.Empty)
            End If
        End Sub
    End Class
End Namespace
