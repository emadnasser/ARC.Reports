using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using FeatureCenter.Module.Reports;

namespace FeatureCenter.Module.NonPersistentObjects {
    public class NonPersistentObjectActivatorController : ObjectViewController<DetailView, BaseNonPersistentClass> {
        protected override void OnActivated() {
            base.OnActivated();
            if((ObjectSpace is NonPersistentObjectSpace) && (View.CurrentObject == null)) {
                View.CurrentObject = View.ObjectTypeInfo.CreateInstance();
                View.ViewEditMode = DevExpress.ExpressApp.Editors.ViewEditMode.Edit;
            }
        }
    }
    public class NonPersistentClassWindowController : WindowController {
        private List<BaseNonPersistentClass> globalObjects;
        private IObjectSpace additionalObjectSpace;

        private void ObjectSpace_ObjectsGetting(Object sender, ObjectsGettingEventArgs e) {
            BindingList<BaseNonPersistentClass> objects = new BindingList<BaseNonPersistentClass>();
            objects.AllowNew = true;
            objects.AllowEdit = true;
            objects.AllowRemove = true;
            foreach(BaseNonPersistentClass obj in globalObjects) {
                if(e.ObjectType.IsAssignableFrom(obj.GetType())) {
                    objects.Add(obj);
                }
            }
            e.Objects = objects;
        }
        private void ObjectSpace_ObjectByKeyGetting(Object sender, ObjectByKeyGettingEventArgs e) {
            foreach(Object obj in globalObjects) {
                if((obj.GetType() == e.ObjectType) && (obj is NonPersistentClassWithKeyProperty) && (e.Key is Int32)
                        && (((NonPersistentClassWithKeyProperty)obj).ID == (Int32)e.Key)) {
                    e.Object = obj;
                    break;
                }
            }
        }
        private void ObjectSpace_Committing(Object sender, CancelEventArgs e) {
            NonPersistentObjectSpace objectSpace = (NonPersistentObjectSpace)sender;
            foreach(Object obj in objectSpace.ModifiedObjects) {
                if(obj is BaseNonPersistentClass) {
                    if(!globalObjects.Contains((BaseNonPersistentClass)obj)) {
                        globalObjects.Add((BaseNonPersistentClass)obj);
                    }
                    else if(objectSpace.IsDeletedObject(obj)) {
                        globalObjects.Remove((BaseNonPersistentClass)obj);
                    }
                }
            }
        }
        private void Application_ObjectSpaceCreated(Object sender, ObjectSpaceCreatedEventArgs e) {
            if(e.ObjectSpace is NonPersistentObjectSpace) {
                e.ObjectSpace.Committing += ObjectSpace_Committing;
                ((NonPersistentObjectSpace)e.ObjectSpace).ObjectsGetting += ObjectSpace_ObjectsGetting;
                ((NonPersistentObjectSpace)e.ObjectSpace).ObjectByKeyGetting += ObjectSpace_ObjectByKeyGetting;
                ((NonPersistentObjectSpace)e.ObjectSpace).AdditionalObjectSpaces.Add(additionalObjectSpace);
            }
        }
        private void Application_ViewCreated(Object sender, ViewCreatedEventArgs e) {
            ObjectView objectView = e.View as ObjectView;
            if(objectView != null) {
                if((objectView is ListView) && typeof(BaseNonPersistentClass).IsAssignableFrom(objectView.ObjectTypeInfo.Type)) {
                    ((ListView)objectView).CollectionSource.ResetCollection();
                }
            }
        }

        protected override void OnActivated() {
            base.OnActivated();
            globalObjects = new List<BaseNonPersistentClass>();

            SimpleNonPersistentClass simpleNonPersistentClass = new SimpleNonPersistentClass("Simple Non-Persistent Object");
            NonPersistentClassWithNonPersistentCollection nonPersistentClassWithNonPersistentCollection = new NonPersistentClassWithNonPersistentCollection(1, "Non-Persistent Object with a Non-Persistent Collection");
            NonPersistentClassWithPersistentProperty nonPersistentClassWithPersistentProperty = new NonPersistentClassWithPersistentProperty(2, "First Non-Persistent Object with a Persistent Property");
            NonPersistentClassWithPersistentProperty nonPersistentClassWithPersistentProperty1 = new NonPersistentClassWithPersistentProperty(3, "Second Non-Persistent Object with a Persistent Property");

            globalObjects.Add(simpleNonPersistentClass);
            globalObjects.Add(nonPersistentClassWithNonPersistentCollection);
            globalObjects.Add(nonPersistentClassWithPersistentProperty);
            globalObjects.Add(nonPersistentClassWithPersistentProperty1);

            nonPersistentClassWithNonPersistentCollection.AddNonPersistentClassWithPersistentProperty(nonPersistentClassWithPersistentProperty);
            nonPersistentClassWithNonPersistentCollection.AddNonPersistentClassWithPersistentProperty(nonPersistentClassWithPersistentProperty1);

            Application.ViewCreated += Application_ViewCreated;
            Application.ObjectSpaceCreated += Application_ObjectSpaceCreated;
            additionalObjectSpace = Application.CreateObjectSpace(typeof(ContactForReport));
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            Application.ViewCreated -= Application_ViewCreated;
            Application.ObjectSpaceCreated -= Application_ObjectSpaceCreated;
            if(additionalObjectSpace != null) {
                additionalObjectSpace.Dispose();
                additionalObjectSpace = null;
            }
        }
        public NonPersistentClassWindowController()
            : base() {
            TargetWindowType = WindowType.Main;
        }
    }
}
