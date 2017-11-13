using System;
using System.Linq;

public partial class UserControls_EditForms_EvaluationEditForm : EditFormUserControl {
    protected void Page_Load(object sender, EventArgs e) {
        EvaluationEditPopup.JSProperties["cpEditFormName"] = "Evaluation";
    }
    public override long SaveChanges(string args) {
        long id = long.Parse(DemoUtils.DeserializeCallbackArgs(args)[0]);
        if(id == DataProvider.emptyEntryID)
            return DataProvider.emptyEntryID;
        var evaluation = DataProvider.Evaluations.FirstOrDefault(e => e.Id == id);
        if(evaluation == null)
            return DataProvider.emptyEntryID;
        evaluation.Subject = EvaluationSubjectTextBox.Text;
        evaluation.Details = EvaluationMemo.Text;
        DataProvider.SaveChanges();
        return evaluation.Id;
    }

    protected void EvaluationEditPopup_WindowCallback(object source, DevExpress.Web.PopupWindowCallbackArgs e) {
        long id = long.Parse(e.Parameter);
        var evaluation = DataProvider.Evaluations.FirstOrDefault(em => em.Id == id);
        if(evaluation == null)
            return;
        EvaluationSubjectTextBox.Text = evaluation.Subject;
        EvaluationMemo.Text = evaluation.Details;
        EvaluationEditPopup.JSProperties["cpEvaluationID"] = evaluation.Id;
        EvaluationEditPopup.JSProperties["cpHeaderText"] = string.Format("Edit Evaluations({0})", evaluation.Employee.FullName);
    }
}
