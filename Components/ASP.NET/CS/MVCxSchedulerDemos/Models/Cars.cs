using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.Linq;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraScheduler;

namespace DevExpress.Web.Demos {
    using DevExpress.Web.Mvc;

    public static class CarsDataProvider {
        const string CarsDataContextKey = "DXCarsDataContext";

        public static CarsDBContext DB {
            get {
                if (HttpContext.Current.Items[CarsDataContextKey] == null)
                    HttpContext.Current.Items[CarsDataContextKey] = new CarsDBContext();
                return (CarsDBContext)HttpContext.Current.Items[CarsDataContextKey];
            }
        }

        public static IEnumerable GetCars() {
            return DB.Cars.Where(c => c.ID < 6).ToList().Select(c => new { ID = c.ID, Model = c.Model });
        }
        public static Binary GetCarPictureById(int id) {
            return (Binary)((from car in DB.Cars where car.ID == id select car.Picture).SingleOrDefault());
        }
        public static IEnumerable GetCarSchedulings() {
            return DB.CarSchedulings.ToList();
        }
        public static IEnumerable GetImportedCarSchedulings() {
            IEnumerable carScheduling = (IEnumerable)HttpContext.Current.Session["ImportedCarScheduling"];
            if (carScheduling == null)
                carScheduling = GetCarSchedulings();
            return carScheduling;
        }
        public static void SetImportedCarSchedulings(IEnumerable carSchedulings) {
            IList<EditableSchedule> listScheduling = new List<EditableSchedule>();
            foreach (EditableSchedule schedule in carSchedulings) {
                schedule.ID = listScheduling.Count + 1;
                listScheduling.Add(schedule);
            }
            HttpContext.Current.Session["ImportedCarScheduling"] = listScheduling;
        }
        public static IList<T> GetEditableCarSchedulings<T>() where T: ScheduleBase {
            string key = "CarScheduling_" + typeof(T).Name;
            IList<T> carScheduling = (IList<T>)HttpContext.Current.Session[key];

            if (carScheduling == null) {
                carScheduling = DB.CarSchedulings.ToList().Select(schedule => (T)Activator.CreateInstance(typeof(T), schedule)).ToList();
                HttpContext.Current.Session[key] = carScheduling;
            }
            return carScheduling;
        }
        public static T GetEditableSchedule<T>(int ID) where T: ScheduleBase {
            return (from carSchedulings in GetEditableCarSchedulings<T>() where carSchedulings.ID == ID select carSchedulings).FirstOrDefault();
        }
        public static void InsertSchedule<T>(ScheduleBase schedule) where T : ScheduleBase {
            if (schedule == null)
                return;

            T editableSchedule = Activator.CreateInstance<T>();
            editableSchedule.Assign(schedule);
            editableSchedule.ID = GetNewScheduleID<T>();
            GetEditableCarSchedulings<T>().Add(editableSchedule);
        }
        public static void UpdateSchedule<T>(T schedule) where T : ScheduleBase {
            if (schedule == null)
                return;

            T editableSchedule = GetEditableSchedule<T>(schedule.ID);
            editableSchedule.Assign(schedule);
        }
        public static void DeleteCarScheduling<T>(T schedule) where T: ScheduleBase {
            if (schedule == null)
                return;

            T editableSchedule = GetEditableSchedule<T>(schedule.ID);
            if (editableSchedule != null)
                GetEditableCarSchedulings<T>().Remove(editableSchedule);
        }
        public static int GetNewScheduleID<T>() where T: ScheduleBase {
            IList<T> carScheduling = GetEditableCarSchedulings<T>();
            return (carScheduling.Count() > 0) ? carScheduling.Last().ID + 1 : 0;
        }
    }

    public class SchedulerDataHelper {
        public static SchedulerDataObject DataObject {
            get {
                return new SchedulerDataObject() {
                    Appointments = CarsDataProvider.GetCarSchedulings(),
                    Resources = CarsDataProvider.GetCars()
                };
            }
        }
        public static SchedulerDataObject EditableDataObject {
            get {
                return new SchedulerDataObject() {
                    Appointments = CarsDataProvider.GetEditableCarSchedulings<EditableSchedule>(),
                    Resources = CarsDataProvider.GetCars()
                };
            }
        }
        public static SchedulerDataObject CustomDataObject {
            get {
                return new SchedulerDataObject() {
                    Appointments = CarsDataProvider.GetEditableCarSchedulings<ValidationSchedule>(),
                    Resources = CarsDataProvider.GetCars()
                };
            }
        }
        public static void UpdateEditableDataObject() {
            InsertAppointment();
            UpdateAppointments();
            DeleteAppointments();
        }
        static void InsertAppointment() {
            EditableSchedule[] carScheduling = GetAppointmentsToInsert<EditableSchedule>(EditableDataObject, SchedulerDemoHelper.DefaultAppointmentStorage);
            foreach(EditableSchedule schedule in carScheduling) {
                CarsDataProvider.InsertSchedule<EditableSchedule>(schedule);
            }
        }
        static void UpdateAppointments() {
            EditableSchedule[] carScheduling = GetAppointmentsToUpdate<EditableSchedule>(EditableDataObject, SchedulerDemoHelper.DefaultAppointmentStorage);
            foreach (EditableSchedule schedule in carScheduling) {
                CarsDataProvider.UpdateSchedule<EditableSchedule>(schedule);
            }
        }
        public static void DeleteAppointments() {
            EditableSchedule[] carSchedulings = GetAppointmentsToRemove<EditableSchedule>(EditableDataObject, SchedulerDemoHelper.DefaultAppointmentStorage);
            foreach (EditableSchedule schedule in carSchedulings) {
                CarsDataProvider.DeleteCarScheduling<EditableSchedule>(schedule);
            }
        }

        public static T[] GetAppointmentsToInsert<T>(SchedulerDataObject dataObject, MVCxAppointmentStorage appointmentStorage) where T: ScheduleBase {
            return SchedulerExtension.GetAppointmentsToInsert<T>("scheduler", dataObject.Appointments, dataObject.Resources,
                appointmentStorage, SchedulerDemoHelper.DefaultResourceStorage);
        }
        public static T[] GetAppointmentsToUpdate<T>(SchedulerDataObject dataObject, MVCxAppointmentStorage appointmentStorage) where T: ScheduleBase {
            return SchedulerExtension.GetAppointmentsToUpdate<T>("scheduler", dataObject.Appointments, dataObject.Resources,
                appointmentStorage, SchedulerDemoHelper.DefaultResourceStorage);
        }
        public static T[] GetAppointmentsToRemove<T>(SchedulerDataObject dataObject, MVCxAppointmentStorage appointmentStorage) where T: ScheduleBase {
            return SchedulerExtension.GetAppointmentsToRemove<T>("scheduler", dataObject.Appointments, dataObject.Resources, 
                appointmentStorage, SchedulerDemoHelper.DefaultResourceStorage);
        }
    }

    public class SchedulerDataObject {
        public IEnumerable Appointments { get; set; }
        public IEnumerable Resources { get; set; }
    }

    public class EditableSchedule: ScheduleBase {
        public EditableSchedule() {
        }
        public EditableSchedule(CarsDb_CarScheduling carScheduling)
            : base(carScheduling) {
            Subject = carScheduling.Subject;
            Description = carScheduling.Description;
            StartTime = carScheduling.StartTime;
            EndTime = carScheduling.EndTime;
        }
        
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public override void Assign(ScheduleBase source) {
            base.Assign(source);
            EditableSchedule editableSchedule = source as EditableSchedule;
            if (editableSchedule != null) {
                Subject = editableSchedule.Subject;
                Description = editableSchedule.Description;
                StartTime = editableSchedule.StartTime;
                EndTime = editableSchedule.EndTime;
            }
        }
    }
    public class ValidationSchedule: ScheduleBase {
        public ValidationSchedule() {
        }
        public ValidationSchedule(CarsDb_CarScheduling carScheduling)
            : base(carScheduling) {
            if (carScheduling != null) {
                Subject = carScheduling.Subject;
                Price = carScheduling.Price;
                StartTime = carScheduling.StartTime.Value;
                EndTime = carScheduling.EndTime.Value;
                Description = carScheduling.Description;
                ContactInfo = carScheduling.ContactInfo;
            }
        }

        [Required(ErrorMessage = "The Subject must contain at least one character.")]
        public string Subject { get; set; }
        public decimal? Price { get; set; }
        [Required, Display(Name = "Start time")]
        public DateTime StartTime { get; set; }
        [Required, Display(Name = "End time")]
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        [Display(Name = "Contact info")]
        public string ContactInfo { get; set; }

        public override void Assign(ScheduleBase source) {
            base.Assign(source);
            ValidationSchedule validationSchedule = source as ValidationSchedule;
            if (validationSchedule != null) {
                Subject = validationSchedule.Subject;
                Price = validationSchedule.Price;
                StartTime = validationSchedule.StartTime;
                EndTime = validationSchedule.EndTime;
                Description = validationSchedule.Description;
                ContactInfo = validationSchedule.ContactInfo;
            }
        }

        public static ValidationSchedule ConvertFrom(Appointment appointment) {
            return new ValidationSchedule {
                ID = appointment.Id == null ? -1 : (int)appointment.Id,
                Subject = appointment.Subject,
                Location = appointment.Location,
                StartTime = appointment.Start,
                EndTime = appointment.End,
                Description = appointment.Description,

                Price = GetPrice(appointment),
                ContactInfo = Convert.ToString(appointment.CustomFields["ContactInfo"])
            };
        }
        static decimal? GetPrice(Appointment appointment) {
            object rawValue = appointment.CustomFields["Price"];
            return rawValue == DBNull.Value ? 0 : (decimal?)rawValue;
        }
    }

    public abstract class ScheduleBase {
        public ScheduleBase() {
        }
        public ScheduleBase(CarsDb_CarScheduling carScheduling) {
            if (carScheduling != null) {
                ID = carScheduling.ID;
                EventType = carScheduling.EventType;
                Label = carScheduling.Label;
                AllDay = carScheduling.AllDay;
                Location = carScheduling.Location;
                CarId = carScheduling.CarId;
                Status = carScheduling.Status;
                RecurrenceInfo = carScheduling.RecurrenceInfo;
                ReminderInfo = carScheduling.ReminderInfo;
            }
        }

        public int ID { get; set; }
        public int? EventType { get; set; }
        public int? Label { get; set; }
        public bool AllDay { get; set; }
        public string Location { get; set; }
        public int? CarId { get; set; }
        public int? Status { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }

        public virtual void Assign(ScheduleBase source) {
            if (source != null) {
                ID = source.ID;
                EventType = source.EventType;
                Label = source.Label;
                AllDay = source.AllDay;
                Location = source.Location;
                CarId = source.CarId;
                Status = source.Status;
                RecurrenceInfo = source.RecurrenceInfo;
                ReminderInfo = source.ReminderInfo;
            }
        }
    }
}
