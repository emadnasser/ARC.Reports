using System;
using System.IO;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Demos.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo;
using FeatureCenter.Module.Win.Printing;
using FeatureCenter.Module.Win.PropertyEditors;
using FeatureCenter.Module.Win.TreeList;

namespace FeatureCenter.Module.Win {
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();

			if(ObjectSpace is XPObjectSpace) {
				CreateStringInSpecialFormatObjects();
				CreatePrintingDemoObjects();
				CreateTreeListDemoObjects();
				CreateImageSourceBrowserObjects();
			}

            ObjectSpace.CommitChanges();
        }

        private void CreateImageSourceBrowserObjects() {
            if(ObjectSpace.FindObject<ImageSourceBrowserBase>(null) == null) {
                FileImageSourceBrowser fileImageSourceBrowser = ObjectSpace.CreateObject<FileImageSourceBrowser>();
                fileImageSourceBrowser.ImageSourceName = "..\\..\\..\\Images\\";
                fileImageSourceBrowser.Save();
                AssemblyImageSourceBrowser standardLibBrowser = ObjectSpace.CreateObject<AssemblyImageSourceBrowser>();
                standardLibBrowser.ImageSourceName = "DevExpress.ExpressApp.Images" + XafApplication.CurrentVersion;
                standardLibBrowser.SetMemberValue("Hint", Hints.ImageSourceBrowserStandardImagesHint);
                standardLibBrowser.Save();
                AssemblyImageSourceBrowser customLibBrowser = ObjectSpace.CreateObject<AssemblyImageSourceBrowser>();
                customLibBrowser.ImageSourceName = "CustomImages";
                customLibBrowser.SetMemberValue("Hint", Hints.ImageSourceBrowserCustomImagesHint);
                customLibBrowser.Save();
            }
        }

        private void CreateTreeListDemoObjects() {
        }

        private void CreatePrintingDemoObjects() {
            if(ObjectSpace.FindObject<TreeListDemoObject>(null) == null) {
                TreeListDemoObject obj1 = ObjectSpace.CreateObject<TreeListDemoObject>();
                obj1.Caption = "Root object 1";
                obj1.Save();
                TreeListDemoObject obj2 = ObjectSpace.CreateObject<TreeListDemoObject>();
                obj2.Caption = "Root object 2";
                obj2.Save();
                TreeListDemoObject obj3 = ObjectSpace.CreateObject<TreeListDemoObject>();
                obj3.ParentObject = obj1;
                obj3.Caption = "Nested object 1";
                obj3.Save();
                TreeListDemoObject obj4 = ObjectSpace.CreateObject<TreeListDemoObject>();
                obj4.ParentObject = obj2;
                obj4.Caption = "Nested object 2";
                obj4.Save();
            }
            if(ObjectSpace.FindObject<GridDemoObject>(null) == null) {
                GridDemoObject obj1 = ObjectSpace.CreateObject<GridDemoObject>();
                obj1.Name = "Object 1";
                obj1.IntegerProperty = 1;
                obj1.Save();
                GridDemoObject obj2 = ObjectSpace.CreateObject<GridDemoObject>();
                obj2.Name = "Object 2";
                obj2.IntegerProperty = 2;
                obj2.Save();
            }
            if(ObjectSpace.FindObject<LayoutDemoObject>(null) == null) {
                LayoutDemoObject obj1 = ObjectSpace.CreateObject<LayoutDemoObject>();
                obj1.Name = "Object for the layout printing demo";
                obj1.Key = 1;
                obj1.BooleanProperty = true;
                obj1.DecimalProperty = 125.23M;
                obj1.IntegerProperty = 16;
                obj1.FloatProperty = 21.3456F;
                obj1.StringProperty = "Simple string";
                NestedObject1 obj2 = ObjectSpace.CreateObject<NestedObject1>();
                obj2.Name = "NestedObject1";
                obj2.IntegerProperty = 634;
                obj2.Save();
                obj1.NestedObjectWithIntegerProperty.Add(obj2);
                NestedObject2 obj3 = ObjectSpace.CreateObject<NestedObject2>();
                obj3.Name = "NestedObject2";
                obj3.BooleanProperty = true;
                obj3.Save();
                obj1.NestedObjectWithBooleanProperty.Add(obj3);
                obj1.Save();
            }
        }

        private void CreateStringInSpecialFormatObjects() {
            WinStringInSpecialFormatProperties obj = ObjectSpace.CreateObject<WinStringInSpecialFormatProperties>();
            StreamReader rdr = new StreamReader(GetType().Assembly.GetManifestResourceStream("FeatureCenter.Module.Win.PropertyEditors.Resources.StringInSpecialFormatRtfText.rtf"));
            obj.RtfStringProperty = rdr.ReadToEnd();
            obj.HtmlStringProperty = "<H1>String Property</H1>\r\n<P>with <FONT color=red size=5>HTML</FONT> <STRONG>formatting</STRONG></P>";
            obj.Name = "Object 1";
            obj.Save();
        }
    }
}
