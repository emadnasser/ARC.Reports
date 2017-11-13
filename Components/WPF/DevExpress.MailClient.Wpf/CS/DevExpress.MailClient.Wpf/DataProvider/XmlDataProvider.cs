using DevExpress.MailClient.Helpers;
using DevExpress.MailClient.ViewModel;
using DevExpress.Xpf.Core.Native;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace DevExpress.MailClient.DataProvider {
    public class XmlDataProvider : DataProviderBase {
        DataSet messagesDataSet;
        DataSet contactsDataSet;
        int initItemsCount = 0;

        public XmlDataProvider(string mailPath = "Mail.xml", string contactsPath = "VideoRent.xml") {
            messagesDataSet = InitDataSet(mailPath);
            contactsDataSet = InitDataSet(contactsPath);
        }

        void ReleaseDataIfNeeded() {
            if(++initItemsCount == 4) {
                messagesDataSet.Dispose();
                messagesDataSet = null;
                contactsDataSet.Dispose();
                contactsDataSet = null;
            }
        }
        #region Fill data
        protected override IList<TaskItemViewModel> FillTasks(IEnumerable<ContactItemViewModel> contacts) {
            var result = TaskGenerator.GenerateTasks(contacts.ToList());
            ReleaseDataIfNeeded();
            return result;
        }
        protected override IList<MailMessageViewModel> FillMessages() {
            IList<MailMessageViewModel> result = new List<MailMessageViewModel>();
            DataTable messagesTable = messagesDataSet.Tables["Messages"];
            DateTime lastMailDate = DateTime.Now;
            if(messagesTable != null && messagesTable.Rows.Count > 0) {
                lastMailDate = (DateTime)messagesTable.Rows[0]["Date"];
                foreach(DataRow row in messagesTable.Rows)
                    result.Add(CreateMessage(row, lastMailDate));
            }

            ReleaseDataIfNeeded();
            return result;
        }
        protected override IList<AppointmentViewModel> FillAppointments() {
            var result = new List<AppointmentViewModel>();
            DataTable appointmentsTable = messagesDataSet.Tables["Appointments"];
            if(appointmentsTable != null && appointmentsTable.Rows.Count > 0) {
                foreach(DataRow row in appointmentsTable.Rows)
                    result.Add(CreateAppointment(row));
            }

            ReleaseDataIfNeeded();
            return result;
        }
        protected override IList<ContactItemViewModel> FillContacts() {
            var result = new List<ContactItemViewModel>();
            DataTable customers = contactsDataSet.Tables["Customer"];
            DataTable personalData = contactsDataSet.Tables["Person"];
            foreach(DataRow row in customers.Rows) {
                var contact = CreateContact(row);
                FillPersonInformation(contact, Convert.ToString(row["Oid"]), personalData);
                result.Add(contact);
            }

            ReleaseDataIfNeeded();
            return result;
        }
        #endregion

        #region Static
        static DataSet InitDataSet(string path) {
            var result = new DataSet();
            string fullPath = FilePathHelper.GetFullPath(path);
            if(fullPath != string.Empty) {
                FileInfo fi = new FileInfo(fullPath);
                result.ReadXml(fi.FullName);
            }

            return result;
        }
        static ContactItemViewModel CreateContact(DataRow row) {
            var contact = ContactItemViewModel.Create();
            contact.Name.MiddleName = Convert.ToString(row["MiddleName"]);
            contact.Email = Convert.ToString(row["Email"]);
            contact.Email = contact.Email.Replace("dxvideorent.com", "dxmail.net");
            contact.Address = AddressViewModel.Create(Convert.ToString(row["Address"]));
            contact.Phone = Convert.ToString(row["Phone"]);
            if(row["Photo"] is byte[])
                contact.Photo = ImageHelper.CreateImageFromStream(new MemoryStream(row["Photo"] as byte[]));

            return contact;
        }
        static void FillPersonInformation(ContactItemViewModel contact, string id, DataTable personalData) {
            var personalInfo = personalData.Rows.Cast<DataRow>().First(x => Convert.ToString(x["Oid"]) == id);
            contact.Name.FirstName = Convert.ToString(personalInfo["FirstName"]);
            contact.Name.LastName = Convert.ToString(personalInfo["LastName"]);
            contact.Gender = (ContactGender)Enum.Parse(typeof(ContactGender), Convert.ToString(personalInfo["Gender"]));
            contact.BirthDate = Convert.ToDateTime(personalInfo["BirthDate"]);
        }
        static AppointmentViewModel CreateAppointment(DataRow row) {
            AppointmentViewModel appointment = AppointmentViewModel.Create();
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
        static MailMessageViewModel CreateMessage(DataRow row, DateTime lastMailDate) {
            MailMessageViewModel message = MailMessageViewModel.Create();
            message.Date = ((DateTime)row["Date"]).Add(DateTime.Now - lastMailDate);
            message.From = string.Format("{0}", row["From"]);
            message.Subject = string.Format("{0}", row["Subject"]);
            message.IsReply = (bool)row["IsReply"];
            message.HasAttachment = (bool)row["HasAttachment"];
            message.IsUnread = (DateTime.Now - message.Date) < TimeSpan.FromHours(100);
            message.Text = string.Format("{0}", row["Text"]);
            message.Folder = GetFolder(string.Format("{0}", row["Folder"]));
            message.Priority = message.IsReply ? MessagePriority.Medium : MessagePriority.High;
            message.To = "Me";
            return message;
        }
        static MessageFolderName GetFolder(string folder) {
            if(string.IsNullOrEmpty(folder))
                return MessageFolderName.All;
            return (MessageFolderName)Enum.Parse(typeof(MessageFolderName), folder.Replace(" ", ""), true);
        }
        #endregion
    }
}
