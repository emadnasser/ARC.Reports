﻿using System;
using System.ComponentModel;
using System.Drawing;
using Common.Win.General.Import;
using Common.Win.General.Sequence;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base.General;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace XVideoRental.Module.Win.BusinessObjects {
    public class ViewIdProvider {
        public const string MovieItemMediaPerformance = "MovieItem_ListView_MediaPerformance";
        public const string MediaPerformance_Movie_Summury = "Rent_ListView_MediaPerformance_Movie_Summury";
        public const string CustomersKPI = "Receipt_ListView_KPI";
        public const string CustomersKPIDiscount = "Receipt_ListView_KPI_Discount";
        public const string CustomersKPICustomersByDates = "Receipt_ListView_KPI_Customers_By_Dates";
        public const string StatisticsTopCustomers = "Receipt_ListView_Statistics_TopCustomers";
        public const string StatisticsRevenueSplit = "Receipt_ListView_Statistics_Revenue_Split";
        public const string StatisticsRevenueByCustomer = "Receipt_ListView_Statistics_Revenue_ByCustomer";
        public const string StatisticsNetIncome = "Receipt_ListView_Statistics_Net_Income";
        public const string StatisticsNetIncomeReceipts = "Receipt_ListView_Statistics_Net_Income_Receipts";
    }
    [NonPersistent]
    public abstract class VideoRentalBaseObject : SequenceBaseObject {
        DateTime _createdAt;
        SecuritySystemUser _createdBy;
        string _tag;

        protected VideoRentalBaseObject(Session session)
            : base(session) {
        }
        [Browsable(false)]
        public SecuritySystemUser CreatedBy {
            get { return _createdBy; }
            set { SetPropertyValue("CreatedBy", ref _createdBy, value); }
        }
        [Browsable(false)]
        public DateTime CreatedAt {
            get { return _createdAt; }
            set { SetPropertyValue<DateTime>("CreatedAt", ref _createdAt, value); }
        }

        [Size(SizeAttribute.Unlimited)]
        [Browsable(false)]
        public string Tag {
            get { return _tag; }
            set { SetPropertyValue("Tag", ref _tag, value); }
        }

        internal static bool Updating;
        public override void GenerateSequence() {
            if (!Updating || Id == 0)
                base.GenerateSequence();
        }
        public override void AfterConstruction() {
            base.AfterConstruction();
            IObjectSpace objectSpace = XPObjectSpace.FindObjectSpaceByObject(this);
            if (objectSpace != null) CreatedBy = (SecuritySystemUser)objectSpace.GetObject(SecuritySystem.CurrentUser);
        }
    }
    [NonPersistent]
    public abstract class VideoPerson : VideoRentalBaseObject {
        string _address;
        Gender _gender;
        string _middleName;
        protected VideoPerson(Session session)
            : base(session) {
        }
        #region Person
        const string defaultFullNameFormat = "{LastName} {MiddleName} {FirstName}";
        const string defaultFullNamePersistentAlias = "concat(FirstName,' ',MiddleName,' ', LastName)";
        readonly PersonImpl person = new PersonImpl();


        static VideoPerson() {
            PersonImpl.FullNameFormat = defaultFullNameFormat;
        }

        public string MiddleName {
            get { return _middleName; }
            set { SetPropertyValue("MiddleName", ref _middleName, value); }
        }

        [InitialData]
        public Gender Gender {
            get { return _gender; }
            set { SetPropertyValue("Gender", ref _gender, value); }
        }



        public void SetFullName(string fullName) {
            person.SetFullName(fullName);
        }
        [RuleRequiredField]
        public string FirstName {
            get { return person.FirstName; }
            set {
                person.FirstName = value;
                OnChanged("FirstName");
            }
        }
        [RuleRequiredField]
        public string LastName {
            get { return person.LastName; }
            set {
                person.LastName = value;
                OnChanged("LastName");
            }
        }

        [DevExpress.Xpo.DisplayName("BirthDate")]
        public DateTime Birthday {
            get { return person.Birthday; }
            set {
                person.Birthday = value;
                OnChanged("Birthday");
            }
        }

        //        [ObjectValidatorIgnoreIssue(typeof(ObjectValidatorDefaultPropertyIsNonPersistentNorAliased)),
        //         SearchMemberOptions(SearchMemberMode.Include)]
        [PersistentAlias(defaultFullNamePersistentAlias)]
        public string FullName {
            get {
                return EvaluateAlias("FullName") as string;
                //                return ObjectFormatter.Format(PersonImpl.FullNameFormat, this,
                //                                              EmptyEntriesMode.RemoveDelimeterWhenEntryIsEmpty);
            }
        }

        [Size(255)]
        public string Email {
            get { return person.Email; }
            set {
                person.Email = value;
                OnChanged("Email");
            }
        }

        [Size(SizeAttribute.Unlimited), Delayed(true), ValueConverter(typeof(ImageValueConverter))]
        public Image Photo {
            get { return GetDelayedPropertyValue<Image>("Photo"); }
            set { SetDelayedPropertyValue("Photo", value); }
        }



        [Size(SizeAttribute.Unlimited)]
        [RuleRequiredField]
        public string Address {
            get { return _address; }
            set { SetPropertyValue("Address", ref _address, value); }
        }
        #endregion
    }

}
