using System;
using System.ComponentModel;
using Common.Win;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

[assembly: OnlineRepoLocation("http://goo.gl/RZUhf")]

namespace Common.Win.General {
    [Serializable]
    [NonPersistent]
    public abstract class CustomObject : XPCustomObject {
        public const string ChangedPropertiesName = "ChangedProperties";
#if MediumTrust
		private Guid oid = Guid.Empty;
		[Browsable(false), Key(true), NonCloneable]
		public Guid Oid {
			get { return oid; }
			set { oid = value; }
		}
#else

        private Guid oid = Guid.Empty;
        [Persistent("Oid"), Key(true), Browsable(false), MemberDesignTimeVisibility(false)]
        public Guid Oid {
            get { return oid; }
            set { oid = value; }
        }
#endif
        private bool isDefaultPropertyAttributeInit;
        private XPMemberInfo defaultPropertyMemberInfo;

        protected override void OnSaving() {
            base.OnSaving();
            if (TrucateStrings)
                trucateStrings();
            if (!(Session is NestedUnitOfWork) && Session.IsNewObject(this) && oid == Guid.Empty) {
                oid = XpoDefault.NewGuid();
            }
        }


        public override string ToString() {
            if (!isDefaultPropertyAttributeInit) {
                var attrib = ClassInfo.FindAttributeInfo(typeof(DefaultPropertyAttribute)) as DefaultPropertyAttribute;
                if (attrib != null) {
                    defaultPropertyMemberInfo = ClassInfo.FindMember(attrib.Name);
                }
                isDefaultPropertyAttributeInit = true;
            }
            if (defaultPropertyMemberInfo != null) {
                object obj = defaultPropertyMemberInfo.GetValue(this);
                if (obj != null) {
                    return obj.ToString();
                }
            }
            return base.ToString();
        }


        public const string CancelTriggerObjectChangedName = "CancelTriggerObjectChanged";
        protected CustomObject(Session session)
            : base(session) {
        }

        [Browsable(false)]
        [MemberDesignTimeVisibility(false)]
        public bool IsNewObject {
            get { return Session.IsNewObject(this); }
        }



        protected override void TriggerObjectChanged(ObjectChangeEventArgs args) {
            if (!CancelTriggerObjectChanged)
                base.TriggerObjectChanged(args);
        }

        [Browsable(false)]
        [NonPersistent]
        [MemberDesignTimeVisibility(false)]
        public bool CancelTriggerObjectChanged { get; set; }

        [Browsable(false)]
        [NonPersistent]
        [MemberDesignTimeVisibility(false)]
        public bool TrucateStrings { get; set; }

        private void trucateStrings() {
            foreach (XPMemberInfo xpMemberInfo in ClassInfo.PersistentProperties) {
                if (xpMemberInfo.MemberType == typeof(string)) {
                    var value = xpMemberInfo.GetValue(this) as string;
                    if (value != null) {
                        value = TruncateValue(xpMemberInfo, value);
                        xpMemberInfo.SetValue(this, value);
                    }
                }
            }
        }
        string TruncateValue(XPMemberInfo xpMemberInfo, string value) {
            if (xpMemberInfo.HasAttribute(typeof(SizeAttribute))) {
                int size = ((SizeAttribute)xpMemberInfo.GetAttributeInfo(typeof(SizeAttribute))).Size;
                if (size > -1 && value.Length > size)
                    value = value.Substring(0, size - 1);
            } else if (value.Length > 99)
                value = value.Substring(0, 99);
            return value;
        }

    }

}
