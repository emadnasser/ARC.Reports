using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Data;
using DevExpress.XtraEditors;

namespace DevExpress.XtraScheduler.Demos {
    public partial class OverviewModule : TutorialControl {
        GridHitInfo downHitInfo;
        MedicScheduleContext dataContext;

        public OverviewModule() {
            InitializeComponent();
            this.schedulerControl1.Start = MedicScheduleDataHelper.BaseDate;
            MedicScheduleDataHelper.CreateLabels(this.schedulerStorage1);
            MedicScheduleDataHelper.CreateStatuses(this.schedulerStorage1);
            this.dataContext = new MedicScheduleContext();
            this.dataContext.LoadData();
            InitializeMappings();
            this.schedulerStorage1.Resources.DataSource = this.dataContext.Medics.Local.ToBindingList();
            this.schedulerStorage1.Appointments.DataSource = this.dataContext.MedicalAppointments.Local.ToBindingList();

            InitializePatinetGrid();
            InitializeGalleryControl();
            this.gridView1.Columns["Name"].SortOrder = ColumnSortOrder.Ascending;

            this.schedulerStorage1.AppointmentsChanged += schedulerStorage1_AppointmentsChanged;
            this.schedulerStorage1.AppointmentsInserted += schedulerStorage1_AppointmentsChanged;
            this.schedulerStorage1.AppointmentsDeleted += schedulerStorage1_AppointmentsChanged;
            this.schedulerControl1.CustomDrawResourceHeader += schedulerControl1_CustomDrawResourceHeader;
            this.schedulerControl1.InitAppointmentDisplayText += schedulerControl1_InitAppointmentDisplayText;
            this.schedulerControl1.AllowAppointmentConflicts += schedulerControl1_AllowAppointmentConflicts;
            this.schedulerControl1.AppointmentDrop += schedulerControl1_AppointmentDrop;

            this.galleryControl1.Gallery.ItemCheckedChanged += Gallery_ItemCheckedChanged;
            this.Resize += OverviewModule_Resize;
            UpdateSize();
        }

        void InitializeMappings() {
            AppointmentMappingInfo appointmentMapping = this.schedulerStorage1.Appointments.Mappings;
            appointmentMapping.AllDay = "AllDay";
            appointmentMapping.Description = "Note";
            appointmentMapping.Subject = "";
            appointmentMapping.Start = "StartTime";
            appointmentMapping.End = "EndTime";
            appointmentMapping.Label = "IssueId";
            appointmentMapping.Location = "Location";
            appointmentMapping.RecurrenceInfo = "RecurrenceInfo";
            appointmentMapping.ReminderInfo = "ReminderInfo";
            appointmentMapping.ResourceId = "MedicId";
            appointmentMapping.Status = "PaymentStatusId";
            appointmentMapping.Type = "EventType";

            AppointmentCustomFieldMapping сustomFieldMapping = new AppointmentCustomFieldMapping();
            сustomFieldMapping.Name = "Patient";
            сustomFieldMapping.ValueType = FieldValueType.Object;
            сustomFieldMapping.Member = "Patient";
            this.schedulerStorage1.Appointments.CustomFieldMappings.Add(сustomFieldMapping);

            ResourceMappingInfo resourceMapping = this.schedulerStorage1.Resources.Mappings;
            resourceMapping.Id = "Id";
            resourceMapping.Caption = "Name";
            resourceMapping.Image = "PhotoBytes";
        }

        void InitializeGalleryControl() {
            ResourceCollection resources = schedulerStorage1.Resources.Items;
            GalleryItemGroupCollection groups = this.galleryControlClient1.Gallery.Groups;
            foreach (Resource resource in resources) {
                Medic medic = resource.GetRow(this.schedulerStorage1) as Medic;
                if (medic == null)
                    continue;
                GalleryItemGroup group = groups.FirstOrDefault((g) => Object.Equals(g.Tag, medic.DepartmentId));
                if (group == null) {
                    group = CreateGalleryItemGroup(medic.DepartmentId);
                    groups.Add(group);
                }
                GalleryItem item = new GalleryItem(resource.GetImage(), medic.Name, medic.Phone);
                item.Value = medic.Id;
                item.Checked = group.Caption == "Therapy";
                resource.Visible = item.Checked;
                group.Items.Add(item);
            }
        }

        GalleryItemGroup CreateGalleryItemGroup(object id) {
            GalleryItemGroup group = new GalleryItemGroup();
            HospitalDepartment department = this.dataContext.HospitalDepartments.Find(id);
            if (department == null)
                department = new HospitalDepartment();
            group.Caption = department.Name;
            group.Tag = department.Id;
            return group;
        }

        void InitializePatinetGrid() {
            this.gridControl1.DataSource = this.dataContext.Patients.ToList();
        }

        void Gallery_ItemCheckedChanged(object sender, GalleryItemEventArgs e) {
            ResourceStorage resources = schedulerStorage1.Resources;
            GalleryItem item = e.Item;
            Resource resource = resources.GetResourceById(item.Value);
            resource.Visible = item.Checked;
        }

        void schedulerControl1_CustomDrawResourceHeader(object sender, CustomDrawObjectEventArgs e) {
            Graphics graphics = e.Graphics;
            ResourceHeader header = (ResourceHeader)e.ObjectInfo;
            Rectangle bounds = header.ImageBounds;
            bounds.Y = header.Bounds.Y + 9;
            header.ImageBounds = bounds;
            Rectangle imageBounds = Rectangle.Intersect(header.ImageBounds, header.ContentBounds);
            Rectangle textBounds = new Rectangle(imageBounds.X, header.Bounds.Bottom - 40, imageBounds.Width, 15);
            header.TextBounds = textBounds;
            e.DrawDefault();
            using (Brush brush = new SolidBrush(Color.FromArgb(70, Color.Black)))
                graphics.DrawRectangle(new Pen(brush), imageBounds);
            e.Handled = true;
            Medic medic = header.Resource.GetRow(this.schedulerStorage1) as Medic;
            if (medic == null)
                return;
            HospitalDepartment hospitalDepartment = this.dataContext.HospitalDepartments.Find(medic.DepartmentId);
            if (hospitalDepartment == null)
                return;

            TextOptions textOptions = new TextOptions(HorzAlignment.Center, VertAlignment.Center, WordWrap.NoWrap, Trimming.EllipsisCharacter);
            Rectangle additionalCaptionBounds = new Rectangle(textBounds.X, textBounds.Bottom, textBounds.Width, textBounds.Height);
            using (Brush additionalCaptionBrush = new SolidBrush(Color.FromArgb(150, header.CaptionAppearance.ForeColor)))
                graphics.DrawString(hospitalDepartment.Name, header.CaptionAppearance.Font, additionalCaptionBrush, additionalCaptionBounds, textOptions.GetStringFormat());
        }

        void OverviewModule_Resize(object sender, EventArgs e) {
            UpdateSize();
        }

        void UpdateSize() {
            int height = (int)((this.splitContainerControl1.Height - this.accordionContentContainer1.Bottom - 64) / 2);
            this.accordionContentContainer2.Height = height;
            this.accordionContentContainer3.Height = height;
            this.splitContainerControl1.SplitterPosition = this.splitContainerControl1.Right - 270;
        }

        void schedulerControl1_AllowAppointmentConflicts(object sender, AppointmentConflictEventArgs e) {
            e.Conflicts.Clear();
            FillConflictedAppointmentsCollection(e.Conflicts, e.Interval, schedulerStorage1.Appointments.Items, e.AppointmentClone);
        }

        void FillConflictedAppointmentsCollection(AppointmentBaseCollection conflicts, TimeInterval interval, AppointmentBaseCollection collection, Appointment currentAppointment) {
            int appointmentCount = collection.Count;
            Patient currentPatient = (Patient)currentAppointment.CustomFields["Patient"];
            for (int i = 0; i < appointmentCount; i++) {
                Appointment appointment = collection[i];
                if (appointment == currentAppointment)
                    continue;
                TimeInterval appointmentTimeInterval = new TimeInterval(appointment.Start, appointment.End);
                if (appointmentTimeInterval.IntersectsWith(interval) & !(appointment.Start == interval.End || appointment.End == interval.Start)) {
                    if (appointment.ResourceId.Equals(currentAppointment.ResourceId))
                        conflicts.Add(appointment);
                    else {
                        Patient patient = (Patient)appointment.CustomFields["Patient"];
                        if (patient != null && patient.Equals(currentPatient))
                            conflicts.Add(appointment);
                    }

                }
                if (appointment.Type.Equals(AppointmentType.Pattern))
                    FillConflictedAppointmentsCollection(conflicts, interval, appointment.GetExceptions(), currentAppointment);
            }
        }

        void schedulerStorage1_AppointmentsChanged(object sender, PersistentObjectsEventArgs e) {
            this.dataContext.SaveChanges();
        }

        void schedulerControl1_InitAppointmentDisplayText(object sender, AppointmentDisplayTextEventArgs e) {
            Patient patient = (Patient)e.Appointment.CustomFields["Patient"];
            e.Text = patient == null ? String.Empty : patient.Name;
        }

        void gridView1_MouseMove(object sender, MouseEventArgs e) {
            GridView view = sender as GridView;
            if (e.Button == MouseButtons.Left && downHitInfo != null) {
                Size dragSize = SystemInformation.DragSize;
                Rectangle dragRect = new Rectangle(new Point(downHitInfo.HitPoint.X - (int)(dragSize.Width / 2),
                    downHitInfo.HitPoint.Y - (int)(dragSize.Height / 2)), dragSize);

                if (!dragRect.Contains(new Point(e.X, e.Y))) {
                    view.GridControl.DoDragDrop(GetDragData(view), DragDropEffects.All);
                    downHitInfo = null;
                }
            }
        }

        SchedulerDragData GetDragData(GridView view) {
            int[] selection = view.GetSelectedRows();
            if (selection == null)
                return null;
            AppointmentBaseCollection appointments = new AppointmentBaseCollection();
            int count = selection.Length;
            for (int i = 0; i < count; i++) {
                int rowIndex = selection[i];
                Appointment apt = schedulerStorage1.CreateAppointment(AppointmentType.Normal);
                apt.CustomFields["Patient"] = view.GetRow(rowIndex);
                appointments.Add(apt);
            }

            return new SchedulerDragData(appointments, 0);
        }

        void gridView1_MouseDown(object sender, MouseEventArgs e) {
            GridView view = sender as GridView;
            downHitInfo = null;

            GridHitInfo hitInfo = view.CalcHitInfo(new Point(e.X, e.Y));
            if (Control.ModifierKeys != Keys.None)
                return;
            if (e.Button == MouseButtons.Left && hitInfo.InRow && hitInfo.HitTest != GridHitTest.RowIndicator)
                downHitInfo = hitInfo;
        }

        void schedulerControl1_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e) {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            Modules.MedicalAppointmentForm form = new Modules.MedicalAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            form.SetDataContext(this.dataContext);
            try {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            } finally {
                form.Dispose();
            }
        }

        void schedulerControl1_AppointmentDrop(object sender, AppointmentDragEventArgs e) {
            string createEventMsg = "Creating an event at {0} on {1}.";
            string moveEventMsg = "Moving the event from {0} on {1} to {2} {3} on {4}.";

            Appointment sourceAppointment = e.SourceAppointment;
            Appointment editedAppointment = e.EditedAppointment;
            DateTime srcStart = sourceAppointment.Start;
            DateTime newStart = editedAppointment.Start;
            bool isNewAppointment = srcStart == DateTime.MinValue;

            string resourceName = String.Empty;
            if (sourceAppointment.ResourceId != editedAppointment.ResourceId)
                resourceName = e.HitResource.Caption;

            string msg = isNewAppointment ? String.Format(createEventMsg, newStart.ToShortTimeString(), newStart.ToShortDateString()) :
                String.Format(moveEventMsg, srcStart.ToShortTimeString(), srcStart.ToShortDateString(), resourceName, newStart.ToShortTimeString(), newStart.ToShortDateString());

            if (XtraMessageBox.Show(msg + "\r\nProceed?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                e.Allow = false;
            } else if (isNewAppointment) {
                this.schedulerControl1.SelectedAppointments.Clear();
                this.schedulerControl1.SelectedAppointments.Add(e.EditedAppointment);
            }
        }
    }
}
