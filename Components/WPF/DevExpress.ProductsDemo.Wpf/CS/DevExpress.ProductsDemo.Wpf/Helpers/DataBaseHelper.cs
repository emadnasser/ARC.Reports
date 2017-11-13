using DevExpress.Xpf.Core.Native;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Task = ProductsDemo.Modules.Task;

namespace ProductsDemo.Modules {
    public class DataBaseHelper {
        static DataBaseHelper instanse = null;
        static public DataBaseHelper Instance {
            get {
                if(instanse == null) {
                    instanse = new DataBaseHelper();
                }
                return instanse;
            }
        }

        DataBaseHelper() {
            Contacts = FillContacts();
            FillAppointments();
            Tasks = FillTasks();
        }

        List<Task> FillTasks() {
            List<Task> ret = new List<Task>();
            for(int i = 0; i < TaskGenerator.CustomerCount; i++)
                foreach(string s in CollectionResources.OfficeTasks)
                    ret.Add(TaskGenerator.CreateTask(s, TaskCategory.Work));
            foreach(string s in CollectionResources.HouseTasks)
                ret.Add(TaskGenerator.CreateTask(s, TaskCategory.HouseChores));
            foreach(string s in CollectionResources.ShoppingTasks)
                ret.Add(TaskGenerator.CreateTask(s, TaskCategory.Shopping));
            return ret;
        }
        List<Contact> FillContacts() {
            XmlDocument doc = new XmlDocument();
            List<Contact> contacts = new List<Contact>();
            XmlNodeList customers = null;
            XmlNodeList names = null;
            Contact contact = null;
            try {
                string fileName = Utils.GetRelativePath("VideoRent.xml");
                doc.Load(fileName);
                customers = doc.GetElementsByTagName("Customer");
                names = doc.GetElementsByTagName("Person");
            }
            catch(Exception) {
                return contacts;
            }
            foreach(XmlNode customer in customers) {
                contact = new Contact();
                contact.Name = new Name();
                contact.Name.MiddleName = customer["MiddleName"].InnerText;
                contact.Email = customer["Email"].ChildNodes[0].Value;
                contact.Email = contact.Email.Replace("dxvideorent.com", "dxmail.net");
                contact.Address = new Address(customer["Address"].ChildNodes[0].Value);
                contact.Phone = customer["Phone"].ChildNodes[0].Value;
                contact.Activity = GetContactActivity(customer["CustomerId"].InnerText);
                if(customer["Photo"] != null) {
                    contact.Photo = ImageHelper.CreateImageFromStream(new MemoryStream(Convert.FromBase64String(customer["Photo"].ChildNodes[0].Value)));
                }
                FillPersonInformation(contact, names, customer["Oid"].ChildNodes[0].Value);
                contacts.Add(contact);
            }
            return contacts;
        }
        List<int> GetContactActivity(string customerId) {
            List<int> activity = new List<int>();
            int seed = int.Parse(customerId);
            Random rnd = new Random(seed);
            for(int i = 0; i < 6; i++) {
                activity.Add(rnd.Next(0, 10));
            }
            return activity;
        }
        void FillPersonInformation(Contact contact, XmlNodeList names, string id) {
            foreach(XmlNode customer in names) {
                if(customer["Oid"].ChildNodes[0].Value == id) {
                    contact.Name.FirstName = customer["FirstName"].ChildNodes[0].Value;
                    contact.Name.LastName = customer["LastName"].ChildNodes[0].Value;
                    contact.Gender = (ContactGender)Enum.Parse(typeof(ContactGender), customer["Gender"].ChildNodes[0].Value);
                    string birthDate = customer["BirthDate"].ChildNodes[0].Value;
                    contact.BirthDate = new DateTime(Convert.ToInt32(birthDate.Substring(0, 4)), Convert.ToInt32(birthDate.Substring(5, 2)), Convert.ToInt32(birthDate.Substring(8, 2)));
                }
            }
        }
        void FillAppointments() {
            Appointments = new ObservableCollection<Appointment>();
            DataTable appointmentsTable = CreateDataTable("Appointments");
            if (appointmentsTable != null && appointmentsTable.Rows.Count > 0) {
                foreach (DataRow row in appointmentsTable.Rows)
                    Appointments.Add(CreateAppointment(row));
            }
        }
        DataTable CreateDataTable(string table) {
            DataSet dataSet = new DataSet();
            try {
                string dataFile = Utils.GetRelativePath("Mail.xml");
                if (dataFile != string.Empty) {
                    FileInfo fi = new FileInfo(dataFile);
                    dataSet.ReadXml(fi.FullName);
                    return dataSet.Tables[table];
                }
            }
            catch (Exception) { }
            return null;
        }
        Appointment CreateAppointment(DataRow row) {
            Appointment appointment = new Appointment();
            appointment.EventType = (int?)row["EventType"];
            appointment.StartDate = (DateTime?)row["StartDate"];
            appointment.EndDate = (DateTime?)row["EndDate"];
            appointment.AllDay = (bool?)row["AllDay"];
            appointment.Subject = Convert.ToString(row["Subject"]);
            appointment.Location = Convert.ToString(row["Location"]);
            appointment.Description = Convert.ToString(row["Description"]);
            appointment.Status = (int?)row["Status"];
            appointment.Label = (int?)row["Label"];
            appointment.RecurrenceInfo = Convert.ToString(row["RecurrenceInfo"]);
            appointment.ReminderInfo = Convert.ToString(row["ReminderInfo"]);
            appointment.ContactInfo = Convert.ToString(row["ContactInfo"]);
            return appointment;
        }

        public List<Contact> Contacts { get; private set; }
        public List<Task> Tasks { get; private set; }
        public ObservableCollection<Appointment> Appointments { get; private set; }
    }

    class TaskGenerator {
        public static int CustomerCount = 10;
        static Random rndGenerator = new Random();
        static List<Contact> customers;
        internal static List<Contact> Customers {
            get {
                if(customers == null) {
                    customers = new List<Contact>();
                    List<Contact> temp = DataBaseHelper.Instance.Contacts;
                    if(temp.Count > CustomerCount) {
                        while(customers.Count < CustomerCount) {
                            Contact contact = GetCustomer(rndGenerator.Next(temp.Count - 1), customers, temp);
                            if(contact != null)
                                customers.Add(contact);
                        }
                    }
                }
                return customers;
            }
        }
        static Contact GetCustomer(int index, List<Contact> customers, List<Contact> contacts) {
            Contact contact = contacts[index];
            foreach(Contact c in customers)
                if(ReferenceEquals(c, contact)) return null;
            return contact;
        }
        public static Task CreateTask(string subject, TaskCategory category) {
            Task task = new Task(subject, category, DateTime.Now.AddHours(-rndGenerator.Next(96)));
            int rndStatus = rndGenerator.Next(10);
            if(task.TimeDiff.TotalHours > 12) {
                if(task.TimeDiff.TotalHours > 80) {
                    task.Status = TaskStatus.Completed;

                } else {
                    task.Status = TaskStatus.InProgress;
                    task.PercentComplete = rndGenerator.Next(9) * 10;
                }
                task.StartDate = task.CreatedDate.AddMinutes(rndGenerator.Next(720)).Date;
            }
            if(rndStatus != 5) task.DueDate = task.CreatedDate.AddHours((90 - rndStatus * 9) + 24).Date;
            if(rndStatus > 8) task.Priority = TaskPriority.High;
            if(rndStatus < 3) task.Priority = TaskPriority.Low;
            if(rndStatus == 6 && task.Status == TaskStatus.InProgress) task.Status = TaskStatus.Deferred;
            if(rndStatus == 4 && task.Status == TaskStatus.InProgress && task.PercentComplete < 40) task.Status = TaskStatus.WaitingOnSomeoneElse;
            if(task.Category == TaskCategory.Work && rndStatus != 7 && Customers.Count > 0)
                task.AssignTo = Customers[rndGenerator.Next(Customers.Count)];
            if(task.Status == TaskStatus.Completed) {
                if(task.StartDate == null) task.StartDate = task.CreatedDate.AddHours(12).Date;
                task.CompletedDate = task.StartDate.Value.AddHours(rndGenerator.Next(48) + 24);
            }
            return task;
        }
    }

    public class CollectionResources {
        public static List<string> HouseTasks = new List<string>() {
            "Set-up home theater (surround sound) system",
            "Install 3 overhead lights in bedroom",
            "Change light bulbs in backyard",
            "Install a programmable thermostat",
            "Install ceiling fan in John's bedroom",
            "Install LED lights in kitchen",
            "Check wiring in main electricity panel",
            "Replace master bedroom light switch with dimmer",
            "Install an new electric outlet in garage",
            "Install electric outlet and ethernet drop in closet",
            "Install chandelier in dining room",
            "Hook up DVD Player to TV for kids",
            "Clean the House top to bottom",
            "Light cleaning of the house",
            "Clean the entire house",
            "Clean and organize basement",
            "Pick up clothes for charity event",
            "Ironing, laundry and vacuuming",
            "Take kids to park and play baseball on Sunday",
            "Clean art studio",
            "Bake brownies and send them to neighbors",
            "Assemble Kitchen Cart",
            "Move piano",
            "Clean backyard",
            "Clean out garage",
            "Organize guest bedroom",
            "Clean out closet",
            "Preapre for yard sale",
            "Sorting clothing for give-away",
            "Organize Storage Room"};
        public static List<string> ShoppingTasks = new List<string>() {
            "Shopping at Macy's",
            "Return coffee machine",
            "Purchase plastic trash bins",
            "Shop for dinner ingredients at the store",
            "Buy new utensils for kitchen",
            "Send post card to Timothy",
            "Buy dining table and TV stand online",
            "Buy ingredients for Pasta Bolognese",
            "Size 3 diapers (3 cases)",
            "Order 3 pizzas",
            "Find out where to buy the new tablet",
            "Buy broccoli and tomatoes",
            "Buy bottle of Champagne",
            "Grocery shopping at Market Basket",
            "Find a bike at a store close to me",
            "Return jeans at JCrew",
            "Buy dog food for Fido",
            "Buy rigid foam insulation",
            "Purchase 3 24-packs of bottled Coke",
            "Purchase & deliver flowers to my home"};
        public static List<string> OfficeTasks = new List<string>() {
            "Input bank statement transactions into Excel spreadsheet",
            "Schedule appointments and pay bills",
            "Place new address stickers on envelopes",
            "Set up and arrange appointments",
            "Copy PDF file into Word",
            "Organize business expenses (last 6 months)",
            "Return samples to vendor",
            "Organize receipts and match them up with business expenses and trips ",
            "File papers and receipts",
            "Ship out CDs to customers",
            "Respond to e-mails until noon",
            "Enter expenses into an online accounting system",
            "Conduct inventory of all furniture in office",
            "Arrange travel to conference",
            "Staple flyers to gift bags",
            "File and shred mail",
            "Print copies of brochures",
            "Enter all receipts into an Excel spreadsheet",
            "Research possible vendors",
            "Sort through paper receipts",
            "Re-package products for retail sale",
            "Scan docs, and put in desktop folder",
            "Print registration stickers"};
    }
}
