Namespace DevExpress.XtraTreeList.Demos
    Public Class ClassViewHelper
        Public Shared Function GetClassView1() As List(Of ClassInfo)
            Dim classView As New List(Of ClassInfo)()
            classView.Add(New ClassInfo(0, 1, "System", CInt(ClassType.Solution)))
            classView.Add(New ClassInfo(1, 2, "System.Timers", CInt(ClassType.Namespace)))
            classView.Add(New ClassInfo(1, 3, "System.Threading", CInt(ClassType.Namespace)))
            classView.Add(New ClassInfo(1, 4, "System.IO", CInt(ClassType.Namespace)))
            classView.Add(New ClassInfo(1, 5, "System.Diagnostics", CInt(ClassType.Namespace)))
            classView.Add(New ClassInfo(2, 6, "ElapsedEventArgs", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 7, "ElapsedEventHandler", CInt(ClassType.Delegate)))
            classView.Add(New ClassInfo(2, 8, "Timer", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 9, "TimersDescriptionAttribute", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(5, 10, "Debug", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(5, 11, "Process", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(5, 12, "EventLog", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(5, 13, "ICollectData", CInt(ClassType.Interface)))
            classView.Add(New ClassInfo(5, 14, "PerformanceCounterType", CInt(ClassType.Enum)))
            classView.Add(New ClassInfo(5, 15, "ProcessModule", CInt(ClassType.Delegate)))
            classView.Add(New ClassInfo(5, 16, "ProcessPriorityClass", CInt(ClassType.Enum)))
            classView.Add(New ClassInfo(5, 17, "ProcessThread", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(3, 18, "Barrier", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(3, 19, "ThreadExceptionEventArgs", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(3, 20, "ThreadExceptionEventHandler", CInt(ClassType.Delegate)))
            classView.Add(New ClassInfo(4, 21, "ErrorEventArgs", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(4, 22, "ErrorEventHandler", CInt(ClassType.Delegate)))
            classView.Add(New ClassInfo(4, 23, "FileSystemEventArgs", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(4, 24, "FileSystemEventHandler", CInt(ClassType.Delegate)))
            classView.Add(New ClassInfo(4, 25, "WaitForChangedResult", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(0, 26, "System.Design", CInt(ClassType.Solution)))
            classView.Add(New ClassInfo(26, 27, "System.ComponentModel.Design", CInt(ClassType.Namespace)))
            classView.Add(New ClassInfo(26, 28, "System.Diagnostics.Design", CInt(ClassType.Namespace)))
            classView.Add(New ClassInfo(26, 29, "System.Windows.Forms.Design", CInt(ClassType.Namespace)))
            classView.Add(New ClassInfo(27, 30, "IComponentDesignerDebugService", CInt(ClassType.Interface)))
            classView.Add(New ClassInfo(27, 31, "IComponentDesignerStateService", CInt(ClassType.Interface)))
            classView.Add(New ClassInfo(27, 32, "DisplayMode", CInt(ClassType.Enum)))
            classView.Add(New ClassInfo(27, 33, "CollectionEditor", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(27, 34, "ComponentDesigner", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(27, 35, "DesignerActionItem", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(27, 36, "DesignerActionService", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(27, 37, "DesignSurface", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(27, 38, "UndoEngine", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(28, 39, "ProcessDesigner", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(28, 40, "ProcessModuleDesigner", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(28, 41, "ProcessThreadDesigner", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(29, 42, "ComponentTray", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(29, 43, "AnchorEditor", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(29, 44, "ControlDesigner", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(29, 45, "FileNameEditor", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(29, 46, "DocumentDesigner", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(29, 47, "DockEditor", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(29, 48, "IMenuEditorService", CInt(ClassType.Interface)))
            classView.Add(New ClassInfo(29, 49, "ParentControlDesigner", CInt(ClassType.Class)))
            Return classView
        End Function
        Public Shared Function GetClassView2() As List(Of ClassInfo)
            Dim classView As New List(Of ClassInfo)()
            classView.Add(New ClassInfo(0, 1, "System.Windows.Forms", CInt(ClassType.Solution)))
            classView.Add(New ClassInfo(1, 2, "System.Windows.Forms", CInt(ClassType.Namespace)))
            classView.Add(New ClassInfo(1, 3, "System.Windows.Forms.Layout", CInt(ClassType.Namespace)))
            classView.Add(New ClassInfo(1, 4, "System.Windows.Forms.Design", CInt(ClassType.Namespace)))
            classView.Add(New ClassInfo(2, 6, "CheckedListBox", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 7, "CheckBox", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 8, "CheckState", CInt(ClassType.Enum)))
            classView.Add(New ClassInfo(2, 9, "Button", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 10, "ButtonBase", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 11, "ButtonBorderStyle", CInt(ClassType.Enum)))
            classView.Add(New ClassInfo(2, 12, "BorderStyle", CInt(ClassType.Enum)))
            classView.Add(New ClassInfo(2, 13, "BindingSource", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 14, "IBindableComponent", CInt(ClassType.Interface)))
            classView.Add(New ClassInfo(2, 15, "IButtonControl", CInt(ClassType.Interface)))
            classView.Add(New ClassInfo(2, 16, "IDropTarget", CInt(ClassType.Interface)))
            classView.Add(New ClassInfo(2, 17, "IFeatureSupport", CInt(ClassType.Interface)))
            classView.Add(New ClassInfo(2, 18, "ImageList", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 19, "LayoutEventHandler", CInt(ClassType.Delegate)))
            classView.Add(New ClassInfo(2, 20, "LayoutEventArgs", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 21, "Control", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 22, "TextBox", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 23, "TextBoxBase", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 24, "ToolStrip", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(2, 25, "ToolStripButton", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(3, 26, "LayoutEngine", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(3, 27, "TableLayoutSettingsTypeConverter", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(4, 28, "EventsTab", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(4, 29, "PropertyTab", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(4, 30, "IUIService", CInt(ClassType.Interface)))
            classView.Add(New ClassInfo(4, 31, "ComponentEditorForm", CInt(ClassType.Class)))
            classView.Add(New ClassInfo(4, 32, "IWindowsFormsEditorService", CInt(ClassType.Interface)))
            Return classView
        End Function
    End Class
    Public Enum ClassType
        Solution
        [Namespace]
        [Class]
        [Interface]
        [Enum]
        [Delegate]
    End Enum
    Public Class ClassInfo
        Public Sub New()
        End Sub
        Public Sub New(ByVal parentID As Integer, ByVal id As Integer, ByVal name As String, ByVal imageIndex As Integer)
            Me.ParentID = parentID
            Me.ID = id
            Me.Name = name
            Me.ImageIndex = imageIndex
        End Sub
        Public Property ParentID() As Integer
        Public Property ID() As Integer
        Public Property Name() As String
        Public Property ImageIndex() As Integer
    End Class
End Namespace
