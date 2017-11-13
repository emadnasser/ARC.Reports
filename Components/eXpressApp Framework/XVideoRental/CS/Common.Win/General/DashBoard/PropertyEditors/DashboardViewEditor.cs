﻿using System;
using System.Windows.Forms;
using Common.Win.General.DashBoard.BusinessObjects;
using Common.Win.General.DashBoard.Helpers;
using DevExpress.DashboardWin;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Editors;

namespace Common.Win.General.DashBoard.PropertyEditors {
    [PropertyEditor(typeof(String), false)]
    public class DashboardViewEditor : WinPropertyEditor, IComplexViewItem {
        XafApplication _application;
        IObjectSpace _objectSpace;

        public DashboardViewEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model) {
        }

        public DashboardViewer DashboardViewer {
            get { return (DashboardViewer)Control; }
        }

        public IObjectSpace ObjectSpace {
            get { return _objectSpace; }
        }

        public XafApplication Application {
            get { return _application; }
        }

        public void Setup(IObjectSpace objectSpace, XafApplication application) {
            _objectSpace = objectSpace;
            _application = application;
        }

        protected override object CreateControlCore() {
            return new DashboardViewer { Margin = new Padding(0), Padding = new Padding(0) };
        }

        protected override void ReadValueCore() {
            var template = CurrentObject as IDashboardDefinition;
            DashboardViewer.Dashboard = template.CreateDashBoard(ObjectSpace, false);
        }
    }
}
