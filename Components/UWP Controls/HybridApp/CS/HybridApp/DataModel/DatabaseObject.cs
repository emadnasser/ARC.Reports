using DevExpress.Mvvm.Native;

namespace HybridApp.HybridAppService {
    public partial class DatabaseObject {
        public DatabaseObject() {
            Id = -1;
        }
        public bool IsNew { get { return Id == -1; } }
        public bool IsCloned { get; set; }
        public override bool Equals(object obj) {
            return (obj as DatabaseObject).If(x => x.Id == Id).If(x => x.GetType() == GetType()).ReturnSuccess();
        }
        public override int GetHashCode() {
            return GetType().GetHashCode() ^ Id.GetHashCode();
        }
    }
}
