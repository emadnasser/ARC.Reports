using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;

namespace DevExpress.XtraTreeList.Demos {
    public enum Priority { Normal = 0, Low = 1, High = 2 }
    public class Project {
        string name;
        string description;
        DateTime startDate;
        DateTime endDate;
        Priority priority;
        Projects owner;
        Projects projects;
        bool isTask;
        public Project() {
            this.owner = null;
            this.name = "";
            this.description = "";
            this.isTask = false;
            this.startDate = this.endDate = DateTime.Today;
            this.priority = Priority.Normal;
            this.projects = new Projects();
        }
        public Project(string name, string description, DateTime startDate, DateTime endDate, Priority priority, bool isTask) {
            this.name = name;
            this.description = description;
            this.isTask = isTask;
            this.startDate = startDate;
            this.endDate = endDate;
            this.priority = priority;
            this.projects = new Projects();
        }
        public Project(Projects projects, string name, string description, DateTime startDate, DateTime endDate, Priority priority, bool isTask)
            : this(name, description, startDate, endDate, priority, isTask) {
            this.projects = projects;
        }
        [Browsable(false)]
        public Projects Owner {
            get { return owner; }
            set { owner = value; }
        }
        public bool IsTask { 
            get { return isTask; }
            set {
                if(isTask == value) return;
                isTask = value;
                OnChanged();
            }
        }
        public string Name { 
            get { return name; } 
            set {
                if(Name == value) return;
                name = value;
                OnChanged();
            } 
        }
        [Browsable(false)]
        public string Description {
            get { return description; }
            set {
                if(Description == value) return;
                description = value;
                OnChanged();
            }
        }
        public DateTime StartDate {
            get { return startDate; }
            set {
                if(StartDate == value) return;
                startDate = value;
                OnChanged();
            }
        }
        public DateTime EndDate {
            get { return endDate; }
            set {
                if(StartDate == value) return;
                endDate = value;
                OnChanged();
            }
        }
        public Priority Priority {
            get { return priority; }
            set {
                if(Priority == value) return;
                priority = value;
                OnChanged();
            }
        }
        [Browsable(false)]
        public Projects Projects { get { return projects; } }
        void OnChanged() {
            if(owner == null) return;
            int index = owner.IndexOf(this);
            owner.ResetItem(index);
        }
    }
    //<treeList1>
    public class Projects : BindingList<Project>, TreeList.IVirtualTreeListData {
        void TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes(VirtualTreeGetChildNodesInfo info) {
            Project obj = info.Node as Project;
            info.Children = obj.Projects;
        }
        protected override void InsertItem(int index, Project item) {
            item.Owner = this;
            base.InsertItem(index, item);
        }
        void TreeList.IVirtualTreeListData.VirtualTreeGetCellValue(VirtualTreeGetCellValueInfo info) {
            Project obj = info.Node as Project;
            switch(info.Column.Caption) { 
                case "Name":
                    info.CellData = obj.Name;
                    break;
                case "Description":
                    info.CellData = obj.Description;
                    break;
                case "StartDate":
                    info.CellData = obj.StartDate;
                    break;
                case "EndDate":
                    info.CellData = obj.EndDate;
                    break;
                case "Priority":
                    info.CellData = obj.Priority;
                    break;
            }
        }
        void TreeList.IVirtualTreeListData.VirtualTreeSetCellValue(VirtualTreeSetCellValueInfo info) {
            Project obj = info.Node as Project;
            switch(info.Column.Caption) {
                case "Name":
                    obj.Name = (string)info.NewCellData;
                    break;
                case "Description":
                    obj.Description = (string)info.NewCellData;
                    break;
                case "StartDate":
                    obj.StartDate = (DateTime)info.NewCellData;
                    break;
                case "EndDate":
                    obj.EndDate = (DateTime)info.NewCellData;
                    break;
                case "Priority":
                    obj.Priority = (Priority)info.NewCellData;
                    break;
            }
        } 
    }
    //</treeList1>
}
