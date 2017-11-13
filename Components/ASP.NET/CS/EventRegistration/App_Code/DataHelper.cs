using System;
using System.Collections.Generic;
using DevExpress.Web.ASPxScheduler;
using DevExpress.XtraScheduler;
using System.Drawing;
using System.Web;
using System.Xml.Linq;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Globalization;

public class CustomFileldNames {
    public const string Speaker = "Speaker";
    public const string CategoryName = "CategoryName";
    public const string Level = "Level";
}

public enum SessionInterest {
    NotInterest,
    Interest,
    HighInterest
};

public class Speaker {
    [XmlAttribute]
    public string Name { get; set; }
    [XmlAttribute]
    public string ImageName { get; set; }
    [XmlAttribute]
    public string Description { get; set; }
}

public class Section {
    [XmlAttribute]
    public string Name { get; set; }
}

public class Category {
    [XmlAttribute]
    public String Name { get; set; }
    [XmlAttribute]
    public String Key { get; set; }
    
    [XmlIgnore]
    public int Id { get; set; }
    [XmlIgnore]
    public Color Color { get; set; }
}
public class PersonalData {
    public bool Completed { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string JobTitle { get; set; }
    public string CompanyName { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string FullName { get; set; }

    public PersonalData() {
        Completed = false;
    }
}

public class Session {
    public Session() { }
    public Session(Session session) {
        Subject = session.Subject;
        Description = session.Description;
        Location = session.Location;
        Speaker = session.Speaker;
        CategoryKey = session.CategoryKey;
        StartTime = session.StartTime;
        EndTime = session.EndTime;
        Level = session.Level;
        Featured = session.Featured;
        Image = session.Image;
        SpeakerDescription = session.SpeakerDescription;

        Id = session.Id;
        Interest = session.Interest;
    }
    
    [XmlAttribute]
    public string Subject { get; set; }
    [XmlAttribute]
    public string Description { get; set; }
    [XmlAttribute]
    public string Location { get; set; }
    [XmlAttribute]
    public string Speaker { get; set; }
    [XmlAttribute]
    public string CategoryKey { get; set; }
    [XmlAttribute("StartTime")]
    public string StartTimeString { get; set; }
    [XmlAttribute("EndTime")]
    public string EndTimeString { get; set; }
    [XmlAttribute]
    public int Level { get; set; }
    [XmlAttribute]
    public bool Featured { get; set; }
    [XmlAttribute]
    public string Image { get; set; }
    [XmlAttribute]
    public string SpeakerDescription { get; set; }

    string id;
    [XmlIgnore]
    public string Id {
        get {
            if(this.id == null)
                this.id = HttpUtility.UrlEncode(Subject.Replace(' ', '_'));
            return this.id;
        }
        set {
            this.id = value;
        }
    }
    [XmlIgnore]
    public int Index { get { return DataHelper.Data.Sessions.IndexOf(this); } }
    [XmlIgnore]
    public Category Category {
        get {
            Category category = DataHelper.Data.Categories.Find(c => c.Key == CategoryKey);
            return category == null
                ? DataHelper.Data.Categories[1]
                : category;
        }
    }
    [XmlIgnore]
    public int CategoryId { get { return Category.Id; } set { } }
    [XmlIgnore]
    public string CategoryName { get { return Category.Name; } set { } }
    [XmlIgnore]
    public DateTime StartTime { get; set; }
    [XmlIgnore]
    public DateTime EndTime { get; set; }
    
    [XmlIgnore]
    public int Interest { get; set; }
}

public class Break {
    [XmlAttribute]
    public string Subject { get; set; }
    [XmlAttribute("StartTime")]
    public string StartTimeString { get; set; }
    [XmlAttribute("EndTime")]
    public string EndTimeString { get; set; }
}

public class ConferenceDay {
    public ConferenceDay() {
        Sessions = new List<Session>();
    }
    [XmlElement("Session")]
    public List<Session> Sessions { get; set; }
    [XmlElement("Break")]
    public List<Break> Breaks { get; set; }
}

[XmlRoot("EventRegistration")]
public class EventRegistrationData {
    static readonly List<Color> DefaultColors = new List<Color>() {
        Color.FromArgb(55, 186, 255),
        Color.FromArgb(212, 98, 180),
        Color.FromArgb(100, 203, 16),
        Color.FromArgb(168, 99, 255),
        Color.MediumPurple, Color.Aqua,
        Color.Firebrick
    };
    static readonly DateTime StartDate = DateTime.Now.Date.AddDays(15);
    
    public EventRegistrationData() {
        Speakers = new List<Speaker>();
        Sections = new List<Section>();
        Categories = new List<Category>();
        Days = new List<ConferenceDay>();
        Sessions = new SessionList();
        Breaks = new List<TimeInterval>();
    }
    public List<Speaker> Speakers { get; set; }
    public List<Section> Sections { get; set; }
    public List<Category> Categories { get; set; }
    [XmlElement("ConferenceDay")]
    public List<ConferenceDay> Days { get; set; }

    [XmlIgnore]
    public SessionList Sessions { get; set; }
    [XmlIgnore]
    public List<TimeInterval> Breaks { get; set; }

    public DateTime GetDate(int day) {
        return StartDate.AddDays(day);
    }
    public int GetDay(DateTime date) {
        return (date - StartDate).Days;
    }

    public void Initialize() {
        InitializeCategories();
        InitializeSessions();
        InitializeBreaks();
    }
    void InitializeCategories() {
        for(int i = 0; i < Categories.Count; i++) {
            Category category = Categories[i];
            category.Id = i;
            category.Color = (i >= 0 && i < DefaultColors.Count)
                ? DefaultColors[i]
                : Color.Transparent;
        }
    }
    void InitializeSessions() {
        for(int i = 0; i < Days.Count; i++) {
            ConferenceDay day = Days[i];
            foreach(Session session in day.Sessions) {
                Sessions.Add(session);
                session.StartTime = GetDate(i).Add(ParseDateTime(session.StartTimeString).TimeOfDay);
                session.EndTime = GetDate(i).Add(ParseDateTime(session.EndTimeString).TimeOfDay);
            }
        }
    }
    void InitializeBreaks() {
        for(int i = 0; i < Days.Count; i++) {
            ConferenceDay day = Days[i];
            foreach(Break _break in day.Breaks) {
                Breaks.Add(new TimeInterval(GetDate(i).Add(ParseDateTime(_break.StartTimeString).TimeOfDay), GetDate(i).Add(ParseDateTime(_break.EndTimeString).TimeOfDay)));
            }
        }
    }
    DateTime ParseDateTime(string val) {
        return DateTime.Parse(val, CultureInfo.InvariantCulture);
    }
}

public static class DataHelper {
    public const string StarsPhotoFolder = "~/Images/Stars/";
    public const string FeaturedSessionsFolder = "~/Images/FeaturedSessions/";
    const string xmlDataBaseFilePath = "~\\App_Data\\Sessions.xml";
    const string xmlSpeakersFilePath = "~\\App_Data\\Speakers.xml";

    static EventRegistrationData data;
    public static EventRegistrationData Data { get { return data; } private set { data = value; } }

    //load
    public static void LoadDataBase() {
        XmlSerializer serializer = new XmlSerializer(typeof(EventRegistrationData));
        using(FileStream dataFile = File.OpenRead(HttpContext.Current.Server.MapPath(xmlDataBaseFilePath))) {
            Data = (EventRegistrationData)serializer.Deserialize(dataFile);
            Data.Initialize();
        }
    }

   //setup scheduler
    public static void Setup(ASPxSchedulerStorage storage) {
        storage.BeginUpdate();
        try {
            SetLabelCollection(storage.Appointments.Labels);
            SetStatusCollection(storage.Appointments.Statuses);
            FillResources(storage.Resources.Items);
        }
        finally {
            storage.EndUpdate();
        }
    }

    static void FillResources(ResourceCollection resources) {
        for(int i = 0; i < Data.Sections.Count; i++) {
            string sectionName = Data.Sections[i].Name;
            Resource resource = resources.Storage.CreateResource(sectionName);
            resource.Caption = sectionName;
            resources.Add(resource);
        }
    }

    static void SetStatusCollection(AppointmentStatusCollection statuses) {
        statuses.Clear();
        foreach (Category category in Data.Categories) {
            IAppointmentStatus status = statuses.CreateNewStatus(category.Key);
            status.SetColor(category.Color);
        }
    }

    static void SetLabelCollection(AppointmentLabelCollection labels) {
        labels.Clear();
        IAppointmentLabel notInterestLabel = labels.CreateNewLabel(SessionInterest.NotInterest.ToString());
        notInterestLabel.SetColor(ColorTranslator.FromHtml("#FFFFFF"));

        IAppointmentLabel interestLabel = labels.CreateNewLabel(SessionInterest.Interest.ToString());
        interestLabel.SetColor(ColorTranslator.FromHtml("#FFF8CA"));

        IAppointmentLabel highInterestLabel = labels.CreateNewLabel(SessionInterest.HighInterest.ToString());
        highInterestLabel.SetColor(ColorTranslator.FromHtml("#FFD2E0"));

        labels.Add(notInterestLabel);
        labels.Add(interestLabel);
        labels.Add(highInterestLabel);     
    }
}
