using System;
using System.Linq;
using Common.Win;
using Common.Win.Common;
using Common.Win.ModelAdapter;
using DevExpress.ExpressApp.Scheduler.Win;
using DevExpress.XtraScheduler;

[assembly: OnlineRepoLocation("http://goo.gl/6VgCv")]

namespace Common.Win.Scheduler.Model {
    public class SchedulerListEditorModelSynchronizer : ModelListSynchronizer {
        public SchedulerListEditorModelSynchronizer(SchedulerListEditor schedulerListEditor)
            : base(schedulerListEditor, schedulerListEditor.Model) {
            ModelSynchronizerList.Add(new SchedulerControlSynchronizer(schedulerListEditor));
            var appointmentsModel = ((IModelListViewOptionsScheduler)schedulerListEditor.Model).OptionsScheduler.GetNode("Storage").GetNode("Appointments").GetNode("Storage").GetNode("Appointments");
            ModelSynchronizerList.Add(new AppoitmentLabelsSynchronizer(schedulerListEditor.SchedulerControl.DataStorage.Appointments.Labels, (IModelAppoitmentLabels)appointmentsModel.GetNode("Labels")));
            ModelSynchronizerList.Add(new AppoitmentStatusSynchronizer(schedulerListEditor.SchedulerControl.DataStorage.Appointments.Statuses, (IModelAppoitmentStatuses)appointmentsModel.GetNode("Statuses")));
        }
    }
    public class SchedulerControlSynchronizer : ComponentSynchronizer<SchedulerControl, IModelOptionsSchedulerEx> {
        public SchedulerControlSynchronizer(SchedulerListEditor schedulerListEditor)
            : base(schedulerListEditor.SchedulerControl, ((IModelListViewOptionsScheduler)schedulerListEditor.Model).OptionsScheduler, false) {
        }

        public override void SynchronizeModel() {

        }
    }

    public class AppoitmentLabelsSynchronizer : ModelSynchronizer<IAppointmentLabelStorage, IModelAppoitmentLabels> {
        public AppoitmentLabelsSynchronizer(IAppointmentLabelStorage component, IModelAppoitmentLabels modelNode)
            : base(component, modelNode) {
        }
        #region Overrides of ModelSynchronizer
        protected override void ApplyModelCore() {
            if (Model.Any(label => label.NodeEnabled)) {
                Control.Clear();
                foreach (IModelAppoitmentLabel modelAppoitmentLabel in Model) {
                    var appointmentLabel = Control.CreateNewLabel(null);
                    Control.Add(appointmentLabel);
                    ApplyModel(modelAppoitmentLabel, appointmentLabel, ApplyValues);
                }
            }

        }

        public override void SynchronizeModel() {

        }
        #endregion
    }
    public class AppoitmentStatusSynchronizer : ModelSynchronizer<IAppointmentStatusStorage, IModelAppoitmentStatuses> {
        #region Overrides of ModelSynchronizer
        public AppoitmentStatusSynchronizer(IAppointmentStatusStorage component, IModelAppoitmentStatuses modelNode)
            : base(component, modelNode) {
        }
        protected override void ApplyModelCore() {
            if (Model.Any(label => label.NodeEnabled)) {
                Control.Clear();
                foreach (var modelAppoitmentStatus in Model) {
                    var appointmentLabel = Control.CreateNewStatus(null); 
                    Control.Add(appointmentLabel);
                    ApplyModel(modelAppoitmentStatus, appointmentLabel, ApplyValues);
                }
            }

        }

        public override void SynchronizeModel() {

        }
        #endregion
    }
    public class SchedulerPopupMenuModelSynchronizer : ModelSynchronizer<SchedulerPopupMenu, IModelSchedulerPopupMenu> {
        public SchedulerPopupMenuModelSynchronizer(SchedulerPopupMenu component, IModelSchedulerPopupMenu modelNode)
            : base(component, modelNode) {
        }
        #region Overrides of ModelSynchronizer
        protected override void ApplyModelCore() {
            ApplyModel(Model, Control, ApplyValues);
        }

        public override void SynchronizeModel() {
            throw new NotImplementedException();
        }
        #endregion
    }
}
