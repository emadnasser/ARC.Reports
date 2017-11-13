using System;
using System.Drawing;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace DevExpress.Xpo.Demos
{
    public class Cars : XPLiteObject {
        int fID;
        [Key]
        public int ID {
            get { return fID; }
            set { SetPropertyValue<int>("ID", ref fID, value); }
        }
        string fTrademark;
        [Size(SizeAttribute.Unlimited)]
        public string Trademark {
            get { return fTrademark; }
            set { SetPropertyValue<string>("Trademark", ref fTrademark, value); }
        }
        string fModel;
        [Size(SizeAttribute.Unlimited)]
        public string Model {
            get { return fModel; }
            set { SetPropertyValue<string>("Model", ref fModel, value); }
        }
        short fHP;
        public short HP {
            get { return fHP; }
            set { SetPropertyValue<short>("HP", ref fHP, value); }
        }
        double fLiter;
        public double Liter {
            get { return fLiter; }
            set { SetPropertyValue<double>("Liter", ref fLiter, value); }
        }
        byte fCyl;
        public byte Cyl {
            get { return fCyl; }
            set { SetPropertyValue<byte>("Cyl", ref fCyl, value); }
        }
        string fCategory;
        [Size(SizeAttribute.Unlimited)]
        public string Category {
            get { return fCategory; }
            set { SetPropertyValue<string>("Category", ref fCategory, value); }
        }
        string fDescription;
        [Size(SizeAttribute.Unlimited)]
        public string Description {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        string fHyperlink;
        [Size(SizeAttribute.Unlimited)]
        public string Hyperlink {
            get { return fHyperlink; }
            set { SetPropertyValue<string>("Hyperlink", ref fHyperlink, value); }
        }
        byte[] fIcon;
        [Size(SizeAttribute.Unlimited)]
        public byte[] Icon {
            get { return fIcon; }
            set { SetPropertyValue<byte[]>("Icon", ref fIcon, value); }
        }
        System.Drawing.Image fPicture;
        [Size(SizeAttribute.Unlimited)]
        [ValueConverter(typeof(DevExpress.Xpo.Metadata.ImageValueConverter))]
        public System.Drawing.Image Picture {
            get { return fPicture; }
            set { SetPropertyValue<System.Drawing.Image>("Picture", ref fPicture, value); }
        }
        decimal fPrice;
        public decimal Price {
            get { return fPrice; }
            set { SetPropertyValue<decimal>("Price", ref fPrice, value); }
        }
        DateTime fDeliveryDate;
        [Persistent(@"Delivery Date")]
        public DateTime DeliveryDate {
            get { return fDeliveryDate; }
            set { SetPropertyValue<DateTime>("DeliveryDate", ref fDeliveryDate, value); }
        }
        bool fIsInStock;
        [Persistent(@"Is In Stock")]
        public bool IsInStock {
            get { return fIsInStock; }
            set { SetPropertyValue<bool>("IsInStock", ref fIsInStock, value); }
        }
        public Cars(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}
