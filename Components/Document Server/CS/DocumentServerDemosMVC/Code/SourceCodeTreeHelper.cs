using System;
using System.Collections.Generic;
using System.IO;
using DevExpress.DXperience.Demos;
using DevExpress.Web.ASPxTreeList;

namespace DevExpress.Web.Demos {
    public class ExampleModel {
        public List<CodeExampleGroup> Groups { get; set; }

        public CodeExample GetExampleById(int id) {
            foreach (CodeExampleGroup group in Groups) {
                if (group.Id == id && group.Examples.Count > 0)
                    return group.Examples[0];
                foreach (var example in group.Examples)
                    if (example.Id == id)
                        return example;
            }
            return null;
        }
        public void SetIdForExamples() {
            int indx = 0;
            foreach (CodeExampleGroup group in Groups) {
                group.Id = indx++;
                foreach (CodeExample example in group.Examples)
                    example.Id = indx++;
            }
        }
        public void RearrangeExamples() {
            for (int i = 0; i < Groups.Count; i++) {
                CodeExampleGroup group = Groups[i];
                if (group.Name == "Charts" || group.Name == "Pivot Table Actions") {
                    Groups.RemoveAt(i);
                    Groups.Insert(0, group);
                    break;
                }
            }
            for (int i = 0; i < Groups.Count; i++) {
                CodeExampleGroup group = Groups[i];
                if (group.Name == "Creation and Data Actions") {
                    Groups.RemoveAt(i);
                    Groups.Insert(1, group);
                    break;
                }
            }
        }
    }
    public class SourceCodeTreeHelper {
        static string MapPath(string path) {
            return System.Web.HttpContext.Current.Request.MapPath(path);
        }

        SourceCodeTreeModel treeModel;
        ExampleModel exampleModel;

        public SourceCodeTreeHelper(SourceCodeTreeModel model) {
            this.treeModel = model;
        }
        ExampleModel ExampleModel {
            get {
                if (this.exampleModel == null)
                    this.exampleModel = CreateExampleModel();
                return this.exampleModel;
            }
        }

        public void VirtualModeCreateChildren(TreeListVirtualModeCreateChildrenEventArgs e) {
            ExampleModel model = CreateExampleModel();

            List<Object> nodeList = new List<Object>();

            if (e.NodeObject == null) {
                foreach (CodeExampleGroup group in model.Groups)
                    nodeList.Add(group);
            }
            else {
                CodeExampleGroup currentGroup = e.NodeObject as CodeExampleGroup;
                if (currentGroup == null)
                    return;
                foreach (CodeExample example in currentGroup.Examples)
                    nodeList.Add(example);
            }
            e.Children = nodeList;
        }
        
        public void VirtualModeNodeCreating(TreeListVirtualModeNodeCreatingEventArgs e) {
            CodeExampleGroup nodeGroup = e.NodeObject as CodeExampleGroup;
            if (nodeGroup != null) {
                e.NodeKeyValue = nodeGroup.Id;
                e.IsLeaf = nodeGroup.Examples.Count == 0;
                e.SetNodeValue("name", nodeGroup.Name);
                return;
            }
            CodeExample example = e.NodeObject as CodeExample;
            if (example != null) {
                e.NodeKeyValue = example.Id;
                e.IsLeaf = true;
                e.SetNodeValue("name", example.RegionName);
            }
        }
        public CodeExample GetExampleById(int exampleId) {
            return ExampleModel.GetExampleById(exampleId);
        }
        ExampleModel CreateExampleModel() {
            string examplePath = MapPath(this.treeModel.ExamplePath);
            Dictionary<string, FileInfo> examplesCS = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.Csharp);
            Dictionary<string, FileInfo> examplesVB = CodeExampleDemoUtils.GatherExamplesFromProject(examplePath, ExampleLanguage.VB);

            ExampleModel model = new ExampleModel();
            model.Groups = CodeExampleDemoUtils.FindExamples(examplePath, examplesCS, examplesVB);
            model.RearrangeExamples();
            model.SetIdForExamples();
            return model;
        }
    }
}
