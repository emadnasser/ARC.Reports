Imports System.Linq
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.ExpressApp.Actions

Public Class ProjectTaskController
	Inherits ViewController
	Public Sub New()
		TargetObjectType = GetType(ProjectTask)
		TargetViewType = ViewType.Any
		Dim markCompletedAction As New SimpleAction(Me, "MarkCompleted", DevExpress.Persistent.Base.PredefinedCategory.RecordEdit) With {
		    .TargetObjectsCriteria = (CriteriaOperator.Parse("Status != ?", ProjectTaskStatus.Completed)).ToString(), 
		    .ConfirmationMessage = "Are you sure to mark the selected task(s) as 'Completed'?", 
		    .ImageName = "State_Task_Completed"
		}
		AddHandler markCompletedAction.Execute, Sub(s, e)
			For Each task As ProjectTask In e.SelectedObjects
				task.EndDate = Date.Now
				task.Status = ProjectTaskStatus.Completed
				View.ObjectSpace.SetModified(task) ' Mark the changed object as 'dirty' (only required if data properties do not provide change notifications).
			Next task
			View.ObjectSpace.CommitChanges()
			View.ObjectSpace.Refresh() ' Optionally update the UI in accordance with the latest data changes.
		End Sub
	End Sub
End Class
