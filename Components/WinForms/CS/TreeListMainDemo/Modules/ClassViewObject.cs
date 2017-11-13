using System.Collections.Generic;

namespace DevExpress.XtraTreeList.Demos {
    public class ClassViewHelper {
        public static List<ClassInfo> GetClassView1() {
            List<ClassInfo> classView = new List<ClassInfo>();
            classView.Add(new ClassInfo(0, 1, "System", (int)ClassType.Solution));
            classView.Add(new ClassInfo(1, 2, "System.Timers", (int)ClassType.Namespace));
            classView.Add(new ClassInfo(1, 3, "System.Threading", (int)ClassType.Namespace));
            classView.Add(new ClassInfo(1, 4, "System.IO", (int)ClassType.Namespace));
            classView.Add(new ClassInfo(1, 5, "System.Diagnostics", (int)ClassType.Namespace));
            classView.Add(new ClassInfo(2, 6, "ElapsedEventArgs", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 7, "ElapsedEventHandler", (int)ClassType.Delegate));
            classView.Add(new ClassInfo(2, 8, "Timer", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 9, "TimersDescriptionAttribute", (int)ClassType.Class));
            classView.Add(new ClassInfo(5, 10, "Debug", (int)ClassType.Class));
            classView.Add(new ClassInfo(5, 11, "Process", (int)ClassType.Class));
            classView.Add(new ClassInfo(5, 12, "EventLog", (int)ClassType.Class));
            classView.Add(new ClassInfo(5, 13, "ICollectData", (int)ClassType.Interface));
            classView.Add(new ClassInfo(5, 14, "PerformanceCounterType", (int)ClassType.Enum));
            classView.Add(new ClassInfo(5, 15, "ProcessModule", (int)ClassType.Delegate));
            classView.Add(new ClassInfo(5, 16, "ProcessPriorityClass", (int)ClassType.Enum));
            classView.Add(new ClassInfo(5, 17, "ProcessThread", (int)ClassType.Class));
            classView.Add(new ClassInfo(3, 18, "Barrier", (int)ClassType.Class));
            classView.Add(new ClassInfo(3, 19, "ThreadExceptionEventArgs", (int)ClassType.Class));
            classView.Add(new ClassInfo(3, 20, "ThreadExceptionEventHandler", (int)ClassType.Delegate));
            classView.Add(new ClassInfo(4, 21, "ErrorEventArgs", (int)ClassType.Class));
            classView.Add(new ClassInfo(4, 22, "ErrorEventHandler", (int)ClassType.Delegate));
            classView.Add(new ClassInfo(4, 23, "FileSystemEventArgs", (int)ClassType.Class));
            classView.Add(new ClassInfo(4, 24, "FileSystemEventHandler", (int)ClassType.Delegate));
            classView.Add(new ClassInfo(4, 25, "WaitForChangedResult", (int)ClassType.Class));
            classView.Add(new ClassInfo(0, 26, "System.Design", (int)ClassType.Solution));
            classView.Add(new ClassInfo(26, 27, "System.ComponentModel.Design", (int)ClassType.Namespace));
            classView.Add(new ClassInfo(26, 28, "System.Diagnostics.Design", (int)ClassType.Namespace));
            classView.Add(new ClassInfo(26, 29, "System.Windows.Forms.Design", (int)ClassType.Namespace));
            classView.Add(new ClassInfo(27, 30, "IComponentDesignerDebugService", (int)ClassType.Interface));
            classView.Add(new ClassInfo(27, 31, "IComponentDesignerStateService", (int)ClassType.Interface));
            classView.Add(new ClassInfo(27, 32, "DisplayMode", (int)ClassType.Enum));
            classView.Add(new ClassInfo(27, 33, "CollectionEditor", (int)ClassType.Class));
            classView.Add(new ClassInfo(27, 34, "ComponentDesigner", (int)ClassType.Class));
            classView.Add(new ClassInfo(27, 35, "DesignerActionItem", (int)ClassType.Class));
            classView.Add(new ClassInfo(27, 36, "DesignerActionService", (int)ClassType.Class));
            classView.Add(new ClassInfo(27, 37, "DesignSurface", (int)ClassType.Class));
            classView.Add(new ClassInfo(27, 38, "UndoEngine", (int)ClassType.Class));
            classView.Add(new ClassInfo(28, 39, "ProcessDesigner", (int)ClassType.Class));
            classView.Add(new ClassInfo(28, 40, "ProcessModuleDesigner", (int)ClassType.Class));
            classView.Add(new ClassInfo(28, 41, "ProcessThreadDesigner", (int)ClassType.Class));
            classView.Add(new ClassInfo(29, 42, "ComponentTray", (int)ClassType.Class));
            classView.Add(new ClassInfo(29, 43, "AnchorEditor", (int)ClassType.Class));
            classView.Add(new ClassInfo(29, 44, "ControlDesigner", (int)ClassType.Class));
            classView.Add(new ClassInfo(29, 45, "FileNameEditor", (int)ClassType.Class));
            classView.Add(new ClassInfo(29, 46, "DocumentDesigner", (int)ClassType.Class));
            classView.Add(new ClassInfo(29, 47, "DockEditor", (int)ClassType.Class));
            classView.Add(new ClassInfo(29, 48, "IMenuEditorService", (int)ClassType.Interface));
            classView.Add(new ClassInfo(29, 49, "ParentControlDesigner", (int)ClassType.Class));
            return classView;
        }
        public static List<ClassInfo> GetClassView2() {
            List<ClassInfo> classView = new List<ClassInfo>();
            classView.Add(new ClassInfo(0, 1, "System.Windows.Forms", (int)ClassType.Solution));
            classView.Add(new ClassInfo(1, 2, "System.Windows.Forms", (int)ClassType.Namespace));
            classView.Add(new ClassInfo(1, 3, "System.Windows.Forms.Layout", (int)ClassType.Namespace));
            classView.Add(new ClassInfo(1, 4, "System.Windows.Forms.Design", (int)ClassType.Namespace));
            classView.Add(new ClassInfo(2, 6, "CheckedListBox", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 7, "CheckBox", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 8, "CheckState", (int)ClassType.Enum));
            classView.Add(new ClassInfo(2, 9, "Button", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 10, "ButtonBase", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 11, "ButtonBorderStyle", (int)ClassType.Enum));
            classView.Add(new ClassInfo(2, 12, "BorderStyle", (int)ClassType.Enum));
            classView.Add(new ClassInfo(2, 13, "BindingSource", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 14, "IBindableComponent", (int)ClassType.Interface));
            classView.Add(new ClassInfo(2, 15, "IButtonControl", (int)ClassType.Interface));
            classView.Add(new ClassInfo(2, 16, "IDropTarget", (int)ClassType.Interface));
            classView.Add(new ClassInfo(2, 17, "IFeatureSupport", (int)ClassType.Interface));
            classView.Add(new ClassInfo(2, 18, "ImageList", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 19, "LayoutEventHandler", (int)ClassType.Delegate));
            classView.Add(new ClassInfo(2, 20, "LayoutEventArgs", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 21, "Control", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 22, "TextBox", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 23, "TextBoxBase", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 24, "ToolStrip", (int)ClassType.Class));
            classView.Add(new ClassInfo(2, 25, "ToolStripButton", (int)ClassType.Class));
            classView.Add(new ClassInfo(3, 26, "LayoutEngine", (int)ClassType.Class));
            classView.Add(new ClassInfo(3, 27, "TableLayoutSettingsTypeConverter", (int)ClassType.Class));
            classView.Add(new ClassInfo(4, 28, "EventsTab", (int)ClassType.Class));
            classView.Add(new ClassInfo(4, 29, "PropertyTab", (int)ClassType.Class));
            classView.Add(new ClassInfo(4, 30, "IUIService", (int)ClassType.Interface));
            classView.Add(new ClassInfo(4, 31, "ComponentEditorForm", (int)ClassType.Class));
            classView.Add(new ClassInfo(4, 32, "IWindowsFormsEditorService", (int)ClassType.Interface));
            return classView;
        }
    }
    public enum ClassType { Solution, Namespace, Class, Interface, Enum, Delegate }
    public class ClassInfo {
        public ClassInfo() { }
        public ClassInfo(int parentID, int id, string name, int imageIndex) {
            ParentID = parentID;
            ID = id;
            Name = name;
            ImageIndex = imageIndex;
        }
        public int ParentID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int ImageIndex { get; set; }
    }
}
