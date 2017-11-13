using System;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using DevExpress.MailClient.Helpers;

namespace DevExpress.MailClient.ViewModel {
    public enum MessageFolderName { All, Announcements, ASP, WinForms, IDETools, Frameworks, Root };
    public enum MessageType { Inbox, Deleted, Sent, Draft };
    public enum MessagePriority { Low, Medium, High }

    [POCOViewModel(ImplementIDataErrorInfo = true)]
    public class MailMessageViewModel {
        public static MailMessageViewModel Create() {
            return ViewModelSource.Create(() => new MailMessageViewModel());
        }

        public MessageFolderName Folder { get; set; }
        public MessageType Type { get; set; }
        public string SubjectDisplayText { get { return string.Format("{1}{0}", Subject, IsReply ? "Re: " : ""); } }

        public virtual string PlainText { get; protected set; }
        public virtual DateTime Date { get; set; }
        public virtual string From { get; set; }
        [EmailAddressValidationAttribute(true)]
        public virtual string To { get; set; }
        public virtual string Subject { get; set; }
        public virtual string Text { get; set; }
        public virtual bool IsUnread { get; set; }
        public virtual bool IsReply { get; set; }
        public virtual bool HasAttachment { get; set; }
        public virtual MessagePriority Priority { get; set; }

        protected MailMessageViewModel() {
            From = string.Empty;
            To = string.Empty;
            Subject = string.Empty;
            Text = string.Empty;
            Priority = MessagePriority.Medium;
        }

        [Command(false)]
        public void Assign(MailMessageViewModel message) {
            Folder = message.Folder;
            Type = message.Type;
            Date = message.Date;
            From = message.From;
            To = EmailValidationHelper.NormalizeEmailsString(message.To);
            Subject = message.Subject;
            Text = message.Text;
            IsUnread = message.IsUnread;
            IsReply = message.IsReply;
            HasAttachment = message.HasAttachment;
            Priority = message.Priority;
        }
        [Command(false)]
        public void NormalizeEmails() {
            To = EmailValidationHelper.NormalizeEmailsString(To);
        }
        protected virtual void OnTextChanged() {
            PlainText = Text == null ? null : ObjectHelper.GetPlainText(Text.Length > 200 ? string.Format("{0}...", Text.Remove(197)) : Text);
        }
    }
    class EmailAddressValidationAttribute : ValidationAttribute {
        public bool MultipleEmails { get; private set; }

        public EmailAddressValidationAttribute(bool multipleEmails) {
            this.MultipleEmails = multipleEmails;
        }

        public override bool IsValid(object value) {
            string mails = (string)value;
            if(string.IsNullOrWhiteSpace(mails))
                return false;

            if(!MultipleEmails)
                return EmailValidationHelper.IsEmailValid(mails);

            bool result = true;
            bool hasValues = false;

            foreach(string email in EmailValidationHelper.ExtractEmails(mails)) {
                result &= EmailValidationHelper.IsEmailValid(email);
                hasValues = true;
            }
            return result && hasValues;
        }
    }
}
