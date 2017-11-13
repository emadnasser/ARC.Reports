using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Win.SystemModule;
using FeatureCenter.Module.ConcurrentModifications;

namespace FeatureCenter.Module.Win.ConcurrentModifications {
    public class ConcurrentModificationsController : ObjectViewController<DetailView, Person> {
        private const string ActiveKey = "ConcurrentModificationsController";
        protected override void OnActivated() {
            base.OnActivated();
            Frame.GetController<LockController>().Active[ActiveKey] = false;
            Frame.GetController<DeleteObjectsViewController>().Active[ActiveKey] = false;
            Frame.GetController<NewObjectViewController>().Active[ActiveKey] = false;
            Frame.GetController<ModificationsController>().SaveAndCloseAction.Active[ActiveKey] = false;
            Frame.GetController<ModificationsController>().SaveAndNewAction.Active[ActiveKey] = false;
            ((DevExpress.ExpressApp.Xpo.XPObjectSpace)ObjectSpace).Session.TrackPropertiesModifications = true;
            View.CurrentObject = GetPerson();
        }
        private Person GetPerson() {
            Person person = ObjectSpace.FindObject<Person>(null);
            if(person == null) {
                person = ObjectSpace.CreateObject<Person>();
                person.ContactName = "Maria Anders";
                person.ContactTitle = "Sales Representative";
                person.CompanyName = "Alfreds Futterkiste";
                person.Country = "Germany";
                person.City = "Berlin";
                person.Phone = "030-0074321";
                ObjectSpace.CommitChanges();
            }
            return person;
        }
    }
}
