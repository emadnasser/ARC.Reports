using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Demos.Tutorials;
using DevExpress.Data.Filtering;
using System.Collections.Generic;

namespace DevExpress.Xpo.Demos {
    public partial class ObjectsInAlias : TutorialControl {
        public ObjectsInAlias() {
            InitializeComponent();
            CreateConnection();
            LoadData();
        }
        public override bool SetNewWhatsThisPadding { get { return true; } set { base.SetNewWhatsThisPadding = value; } }

        UnitOfWork session;
        void CreateConnection() {
            InMemoryDataStore dataStore = new InMemoryDataStore(AutoCreateOption.DatabaseAndSchema);
            IDataLayer dataLayer = new SimpleDataLayer(dataStore);
            string DBFileName = DevExpress.Utils.FilesHelper.FindingFileName(Application.StartupPath, "Data\\nwind.xml");
            if (!string.IsNullOrEmpty(DBFileName)) {
                using (UnitOfWork saveSession = new UnitOfWork(dataLayer)) {
                    InMemoryDataStore internalDataStore = new InMemoryDataStore(AutoCreateOption.None);
                    internalDataStore.ReadXml(DBFileName);
                    List<Person> persons = new List<Person>();
                    using (UnitOfWork loadSession = new UnitOfWork(new SimpleDataLayer(internalDataStore))) {
                        ICollection loadedPersons = loadSession.GetObjects(loadSession.Dictionary.GetClassInfo(typeof(Employees)), null, null, 0, false, true);
                        foreach (Employees empl in loadedPersons) {
                            Person person = new Person(saveSession);
                            person.FirstName = empl.FirstName;
                            person.LastName = empl.LastName;
                            persons.Add(person);
                        }
                    }
                    int personCounter = 0;
                    for (int i = 0; i < 40; i++) {
                        Order order = new Order(saveSession);
                        order.MainCustomerIsOne = i % 2 == 0;
                        switch (i % 3) { 
                            case 0:
                                order.CustomerOne = persons[personCounter++];
                                if (personCounter >= persons.Count) personCounter = 0;
                                order.CustomerTwo = persons[personCounter++];
                                if (personCounter >= persons.Count) personCounter = 0;
                                break;
                            case 1:
                                order.CustomerOne = persons[personCounter++];
                                if (personCounter >= persons.Count) personCounter = 0;
                                break;
                            case 2:
                                order.CustomerTwo = persons[personCounter++];
                                if (personCounter >= persons.Count) personCounter = 0;
                                break;
                        }
                    }
                    saveSession.CommitChanges();
                }
            }
            session = new UnitOfWork(dataLayer);
        }
        //<gcMain>
        void LoadData() {
            XPView view = new XPView(session, typeof(Order));
            view.AddProperty("CustomerOne", "CustomerOne.FullName");
            view.AddProperty("CustomerTwo", "CustomerTwo.FullName");
            view.AddProperty("MainCustomerIsOne", "MainCustomerIsOne");
            view.AddProperty("MainCustomer", "MainCustomer.FullName");                  //Access to the FullName property of object in alias
            view.AddProperty("NotNullCustomer", "NotNullCustomer.FullName");            //Access to the FullName property of object in alias
            view.AddProperty("CustomerOneBySingle", "CustomerOneBySingle.FullName");    //Access to the FullName property of object in alias
            gcMain.DataSource = view;
            gridView1.PopulateColumns();
            gridView1.BestFitColumns();
        }
        public class Order : XPObject {
            [PersistentAlias("Iif(MainCustomerIsOne, CustomerOne, CustomerTwo)")]
            public Person MainCustomer {
                get { return (Person)EvaluateAlias("MainCustomer"); }
            }
            [PersistentAlias("IsNull(CustomerOne, CustomerTwo)")]
            public Person NotNullCustomer {
                get { return (Person)EvaluateAlias("NotNullCustomer"); }
            }
            [PersistentAlias("[<Person>][Oid = ^.CustomerOne].Single()")]
            public Person CustomerOneBySingle {
                get { return (Person)EvaluateAlias("CustomerOneBySingle"); }
            }

            bool mainCustomerIsOne;
            Person customer1;
            Person customer2;
            string title;
            public string Title {
                get { return title; }
                set { SetPropertyValue("Title", ref title, value); }
            }
            public bool MainCustomerIsOne {
                get { return mainCustomerIsOne; }
                set { SetPropertyValue("MainCustomerIsOne", ref mainCustomerIsOne, value); }
            }
            public Person CustomerOne {
                get { return customer1; }
                set { SetPropertyValue("CustomerOne", ref customer1, value); }
            }
            public Person CustomerTwo {
                get { return customer2; }
                set { SetPropertyValue("CustomerTwo", ref customer2, value); }
            }
            public Order(Session session)
                : base(session) {
            }
        }
        public class Person : XPObject {
            string lastName;
            string firstName;
            public string FirstName {
                get { return firstName; }
                set { SetPropertyValue("FirstName", ref firstName, value); }
            }
            public string LastName {
                get { return lastName; }
                set { SetPropertyValue("LastName", ref lastName, value); }
            }
            [PersistentAlias("FirstName + ' ' + LastName")]
            public string FullName {
                get {
                    return (string)EvaluateAlias("FullName");
                }
            }
            public Person(Session session)
                : base(session) {
            }
        }
        //</gcMain>
    }
}
