Imports System
Imports System.Linq

Partial Public Class UserControls_EditForms_EvaluationEditForm
    Inherits EditFormUserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        EvaluationEditPopup.JSProperties("cpEditFormName") = "Evaluation"
    End Sub
    Public Overrides Function SaveChanges(ByVal args As String) As Long

        Dim id_Renamed As Long = Long.Parse(DemoUtils.DeserializeCallbackArgs(args)(0))
        If id_Renamed = DataProvider.emptyEntryID Then
            Return DataProvider.emptyEntryID
        End If
        Dim evaluation = DataProvider.Evaluations.FirstOrDefault(Function(e) e.Id = id_Renamed)
        If evaluation Is Nothing Then
            Return DataProvider.emptyEntryID
        End If
        evaluation.Subject = EvaluationSubjectTextBox.Text
        evaluation.Details = EvaluationMemo.Text
        DataProvider.SaveChanges()
        Return evaluation.Id
    End Function

    Protected Sub EvaluationEditPopup_WindowCallback(ByVal source As Object, ByVal e As DevExpress.Web.PopupWindowCallbackArgs)

        Dim id_Renamed As Long = Long.Parse(e.Parameter)
        Dim evaluation = DataProvider.Evaluations.FirstOrDefault(Function(em) em.Id = id_Renamed)
        If evaluation Is Nothing Then
            Return
        End If
        EvaluationSubjectTextBox.Text = evaluation.Subject
        EvaluationMemo.Text = evaluation.Details
        EvaluationEditPopup.JSProperties("cpEvaluationID") = evaluation.Id
        EvaluationEditPopup.JSProperties("cpHeaderText") = String.Format("Edit Evaluations({0})", evaluation.Employee.FullName)
    End Sub
End Class
