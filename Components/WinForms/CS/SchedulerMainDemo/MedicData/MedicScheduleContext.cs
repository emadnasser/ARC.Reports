using System;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;

namespace DevExpress.XtraScheduler.Demos {
    public class MedicScheduleContext : DbContext {
        #region tableCreationScript
        string tableCreationScript =
@"
-- Table: Medics
CREATE TABLE Medics ( 
Id      INTEGER PRIMARY KEY AUTOINCREMENT
                    UNIQUE,
    Name    TEXT,
    Phone TEXT,
    PhotoBytes BLOB,
    DepartmentId        INT64 
);

-- Table: HospitalDepartments
CREATE TABLE HospitalDepartments ( 
Id      INTEGER PRIMARY KEY AUTOINCREMENT
                    UNIQUE,
    Name    TEXT
);

-- Table: Patients
CREATE TABLE Patients ( 
Id      INTEGER PRIMARY KEY AUTOINCREMENT
                    UNIQUE,
    Name    TEXT,    
    Birthday DATE,
    Phone TEXT
);

-- Table: MedicalAppointments
CREATE TABLE MedicalAppointments ( 
    Id             INTEGER  PRIMARY KEY AUTOINCREMENT
                            UNIQUE,
    AllDay          BOOLEAN,
    StartTime           DATETIME,
    [EndTime]           DATETIME,
    PatientId       INT64,
    Note            TEXT,
    IssueId         INTEGER,
    PaymentStatusId INTEGER,
    EventType       INTEGER,
    Location        TEXT,
    RecurrenceInfo  TEXT,
    ReminderInfo    TEXT,
    MedicId        INT64 
);
";
        #endregion


        public MedicScheduleContext() : base("name=DevExpress.XtraScheduler.Demos.Properties.Settings.MedicConnectionString") {
            CreateDBStructureIfRequired();
        }

        public DbSet<Medic> Medics { get; set; }
        public DbSet<MedicalAppointment> MedicalAppointments { get; set; }
        public DbSet<HospitalDepartment> HospitalDepartments { get; set; }
        public DbSet<Patient> Patients { get; set; }

        string TableCreationScript { get { return String.Format(tableCreationScript); } }

        public void LoadData() {
            LoadPatients();
            LoadHospitalDepartments();
            LoadMedics();
            LoadMedicalAppointments();
        }

        void CreateDBStructureIfRequired() {
            SQLiteConnection connection = Database.Connection as SQLiteConnection;
            if (connection == null)
                return;
            connection.Open();
            DataTable a = connection.GetSchema("Tables");
            if (a.Rows.Count > 0)
                return;
            SQLiteCommand command = new SQLiteCommand(TableCreationScript, connection);
            command.ExecuteNonQuery();
        }

        void LoadMedics() {
            Medics.Load();
            if (Medics.Count() > 0)
                return;
            Medics.AddRange(MedicScheduleDataHelper.CreateMedics(HospitalDepartments.ToList()));
            SaveChanges();
        }

        void LoadHospitalDepartments() {
            HospitalDepartments.Load();
            if (HospitalDepartments.Count() > 0)
                return;
            HospitalDepartments.AddRange(MedicScheduleDataHelper.CreateHospitalDepartments());
            SaveChanges();
        }

        void LoadPatients() {
            Patients.Load();
            if (Patients.Count() > 0)
                return;
            Patients.AddRange(MedicScheduleDataHelper.CreatePatients());
            SaveChanges();
        }

        void LoadMedicalAppointments() {
            MedicalAppointments.Load();
            int medicalAppointmentsCount = MedicalAppointments.Count();
            if (medicalAppointmentsCount > 0) {
                MedicalAppointment appointment = MedicalAppointments.FirstOrDefault((apt) => apt.EndTime >= MedicScheduleDataHelper.BaseDate);
                if (appointment != null)
                    return;
                MedicalAppointments.Local.Clear();
                SaveChanges();
            }
            MedicalAppointments.AddRange(MedicScheduleDataHelper.CreateMedicalAppointments(Medics.ToList()));
            SaveChanges();
        }
    }
}
