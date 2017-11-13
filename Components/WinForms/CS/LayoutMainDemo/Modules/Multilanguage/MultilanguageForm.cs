using DevExpress.Utils;
using DevExpress.Utils.Drawing.Animation;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraLayout.Demos {
    public partial class MultilanguageForm : XtraForm, ISupportXtraAnimationEx {
        private int delayBeforeAnimation = 500;
        private static int FormBoundsAnimationLength = 2000;
        private Timer timer;

        internal readonly object FormBoundsAnimationId = new object();
        private SizeF formMinSize, formMaxSize, landscape, portrait;

        public MultilanguageForm() {
            XpoDefault.DataLayer = new SimpleDataLayer(new InMemoryDataStore(AutoCreateOption.DatabaseAndSchema));
            XpoDefault.Session.Delete(new XPCollection(typeof(VideoCatalogItem)));
            CreateCatalogItems();
            InitializeComponent();
            SizeF scaleFactor = (layoutControl1 as ILayoutControl).AutoScaleFactor;
            formMinSize = new SizeF(485 * scaleFactor.Width, 675 * scaleFactor.Height);
            formMaxSize = new SizeF(1085 * scaleFactor.Width, 675 * scaleFactor.Height);
            landscape = new SizeF(675 * scaleFactor.Width, 490 * scaleFactor.Height);
            portrait = new SizeF(460 * scaleFactor.Width, 650 * scaleFactor.Height);
            Icon = ResourceImageHelper.CreateIconFromResources("DevExpress.XtraLayout.Demos.AppIcon.ico", typeof(frmMain).Assembly);
        }

        bool ISupportXtraAnimation.CanAnimate {
            get {
                return true;
            }
        }
        Control ISupportXtraAnimation.OwnerControl {
            get {
                return this;
            }
        }

        public Size FormMaxSize {
            get {
                return formMaxSize.ToSize();
            }
        }
        public Size FormMinSize {
            get {
                return formMinSize.ToSize();
            }
        }
        public Size Landscape {
            get {
                return landscape.ToSize();
            }
        }
        public Size Portrait {
            get {
                return portrait.ToSize();
            }
        }

        void ISupportXtraAnimationEx.OnEndAnimation(BaseAnimationInfo info) {
            if(Width == formMaxSize.Width) {
                AnimateControlBoundsMinimization();
            }
        }
        void ISupportXtraAnimationEx.OnFrameStep(BaseAnimationInfo info) {
            Width = (int)(((DoubleSplineAnimationInfo)info).Value);
        }
        private void timer_Tick(object sender, EventArgs e) {
            timer.Tick -= timer_Tick;
            timer.Dispose();
            AnimateControlBoundsMaximization();
        }

        protected internal virtual void AnimateControlBoundsMaximization() {
            DoubleSplineAnimationInfo info = new DoubleSplineAnimationInfo(this, FormBoundsAnimationId, formMinSize.Width, formMaxSize.Width, FormBoundsAnimationLength);
            XtraAnimator.Current.AddAnimation(info);
        }
        protected internal virtual void AnimateControlBoundsMinimization() {
            DoubleSplineAnimationInfo info = new DoubleSplineAnimationInfo(this, FormBoundsAnimationId, formMaxSize.Width, formMinSize.Width, FormBoundsAnimationLength);
            XtraAnimator.Current.AddAnimation(info);
        }

        public void ChangedSize(float scale) {
            labelControl1.Appearance.Font = new Font(labelControl1.Appearance.Font.FontFamily, labelControl1.Appearance.Font.Size * scale);
            labelControl8.Appearance.Font = new Font(labelControl8.Appearance.Font.FontFamily, labelControl8.Appearance.Font.Size * scale);
            layoutControlGroup1.AppearanceItemCaption.Font = new Font(layoutControlGroup1.AppearanceItemCaption.Font.FontFamily, layoutControlGroup1.AppearanceItemCaption.Font.Size * scale, FontStyle.Bold);
            AppearanceObject.DefaultFont = new Font(Appearance.Font.FontFamily, Appearance.Font.Size * scale);
        }
        public static void CreateCatalogItems() {
            if(System.Threading.Thread.CurrentThread.CurrentUICulture.EnglishName == "English") {
                new VideoCatalogItem(
                    XpoDefault.Session,
                    "The Sting",
                    "George Roy Hill",
                    "Crime / Comedy",
                    "Paul Newman, Robert Redford, Robert Shaw",
                    "USA",
                    "In 1930s Chicago, a young con man seeking revenge for his murdered partner teams up with a master of the big con to win a fortune from a criminal banker",
                    1973,
                    ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.film1-en.png", typeof(frmMain).Assembly),
                    new TimeSpan(0, 129, 0)).Save();

                new VideoCatalogItem(
                    XpoDefault.Session,
                    "Die Hard",
                    "John McTiernan",
                    "Action / Crime / Thriller",
                    "Bruce Willis, Reginald VelJohnson, Alan Rickman",
                    "USA",
                    "New York cop John McClane gives terrorists a dose of their own medicine as they hold hostages in an LA office building",
                    1988,
                    ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.film2-en.png", typeof(frmMain).Assembly),
                    new TimeSpan(0, 131, 0)).Save();

                new VideoCatalogItem(
                    XpoDefault.Session,
                    "Playing by heart",
                    "Willard Carroll",
                    "Comedy / Drama / Romance",
                    "Angelina Jolie, Dennis Quaid, Sean Connery, Gillian Anderson",
                    "USA",
                    "Eleven articulate people work through affairs of the heart in L.A.",
                    1998,
                    ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.film3-en.png", typeof(frmMain).Assembly),
                    new TimeSpan(0, 121, 0)).Save();
            }
            if(System.Threading.Thread.CurrentThread.CurrentUICulture.EnglishName == "German (Germany)") {
                new VideoCatalogItem(
                    XpoDefault.Session,
                    "Der Clou",
                    "George Roy Hill",
                    "Krimi / Komodie",
                    "Paul Newman, Robert Redford, Robert Shaw",
                    "USA",
                    "Im Chicago der 30er Jahre will ein Gelegenheitsbetruger Rache fur den Tod seines Partners und verbundet sich mit einem Meister des gro?en Betrugs, um einem kriminellen Bankier ein Vermogen abzunehmen",
                    1973,
                    ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.film1-de.png", typeof(frmMain).Assembly),
                    new TimeSpan(0, 129, 0)).Save();

                new VideoCatalogItem(
                    XpoDefault.Session,
                    "Stirb langsam",
                    "John McTiernan",
                    "Action / Krimi / Thriller",
                    "Bruce Willis, Reginald VelJohnson, Alan Rickman",
                    "USA",
                    "Der New Yorker Polizist John McClane gibt Terroristen eine Dosis ihrer eigenen Medizin, als sie in einem Burogebaude in Los Angeles Geiseln nehmen",
                    1988,
                    ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.film2-de.png", typeof(frmMain).Assembly),
                    new TimeSpan(0, 131, 0)).Save();

                new VideoCatalogItem(
                    XpoDefault.Session,
                    "Leben und Lieben in L.A.",
                    "Willard Carroll",
                    "Komodie / Drama / Romantik",
                    "Angelina Jolie, Dennis Quaid, Sean Connery, Gillian Anderson",
                    "USA",
                    "Elf Menschen in verschiedenem Alter suchen im Nachtleben der Metropole Los Angeles nach Liebe und Zuneigung",
                    1998,
                    ResourceImageHelper.CreateBitmapFromResources("DevExpress.XtraLayout.Demos.Images.film3-de.png", typeof(frmMain).Assembly),
                    new TimeSpan(0, 121, 0)).Save();
            }
        }
        public void SetLayout(Utils.LayoutMode layoutMode) {
            layoutModeGroup.LayoutMode = layoutMode;
        }
        public void ShowAnimation() {
            Size = FormMinSize;
            timer = new Timer() { Interval = delayBeforeAnimation };
            timer.Tick += timer_Tick;
            timer.Start();
        }
    }

    [NonPersistent]
    public class VideoCatalogBase : XPObject {
        public VideoCatalogBase(Session session)
            : base(session) {
        }
    }

    public class VideoCatalogItem : VideoCatalogBase {
        private string fCaption;
        private string fCast;
        private string fCountry;
        private string fDescription;
        private string fDirector;
        private string fGenre;
        private Image fPhoto;
        private TimeSpan fRunTime;
        private int fYear;

        public VideoCatalogItem(Session session)
            : base(session) {
        }
        public VideoCatalogItem(Session session, string caption, string director, string genre,
            string cast, string country, string description, int year, Image photo, TimeSpan runTime)
            : base(session) {
            fCaption = caption;
            fDirector = director;
            fGenre = genre;
            fCast = cast;
            fCountry = country;
            fDescription = description;
            fYear = year;
            fPhoto = photo;
            fRunTime = runTime;
        }

        [Size(254)]
        public string Caption {
            get {
                return fCaption;
            }
            set {
                string oldValue = fCaption;
                if(oldValue == value) {
                    return;
                }
                fCaption = value;
                OnChanged("Caption", oldValue, value);
            }
        }
        [Size(254)]
        public string Cast {
            get {
                return fCast;
            }
            set {
                string oldValue = fCast;
                if(oldValue == value) {
                    return;
                }
                fCast = value;
                OnChanged("Cast", oldValue, value);
            }
        }
        [Size(254)]
        public string Country {
            get {
                return fCountry;
            }
            set {
                string oldValue = fCountry;
                if(oldValue == value) {
                    return;
                }
                fCountry = value;
                OnChanged("Country", oldValue, value);
            }
        }
        [Size(1500)]
        public string Description {
            get {
                return fDescription;
            }
            set {
                string oldValue = fDescription;
                if(oldValue == value) {
                    return;
                }
                fDescription = value;
                OnChanged("Description", oldValue, value);
            }
        }
        [Size(254)]
        public string Director {
            get {
                return fDirector;
            }
            set {
                string oldValue = fDirector;
                if(oldValue == value) {
                    return;
                }
                fDirector = value;
                OnChanged("Director", oldValue, value);
            }
        }
        [Size(254)]
        public string Genre {
            get {
                return fGenre;
            }
            set {
                string oldValue = fGenre;
                if(oldValue == value) {
                    return;
                }
                fGenre = value;
                OnChanged("Genre", oldValue, value);
            }
        }
        [ValueConverter(typeof(ImageValueConverter))]
        public Image Photo {
            get {
                return fPhoto;
            }
            set {
                Image oldValue = fPhoto;
                if(ReferenceEquals(oldValue, value)) {
                    return;
                }
                fPhoto = value;
                OnChanged("Photo", oldValue, value);
            }
        }
        public TimeSpan RunTime {
            get {
                return fRunTime;
            }
            set {
                TimeSpan oldValue = fRunTime;
                if(oldValue == value) {
                    return;
                }
                fRunTime = value;
                OnChanged("RunTime", oldValue, value);
            }
        }
        public int Year {
            get {
                return fYear;
            }
            set {
                int oldValue = fYear;
                if(oldValue == value) {
                    return;
                }
                fYear = value;
                OnChanged("Year", oldValue, value);
            }
        }
    }
}
