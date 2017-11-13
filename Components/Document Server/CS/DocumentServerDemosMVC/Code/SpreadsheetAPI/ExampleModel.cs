//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text.RegularExpressions;
//using System.Text;
//using DevExpress.Utils;

//namespace DevExpress.Docs.Demos {
//    public class ExampleModel {
//        public ExampleModel() {
//            Groups = new List<ExampleGroup>();
//        }
//        public List<ExampleGroup> Groups { get; private set; }
//        public bool IsVb { get; set; }
//        public string CodeExampleFileExtension {
//            get {
//                if(IsVb)
//                    return ".vb";
//                return ".cs";
//            }
//        }
//        public string AlternateCodeExampleFileExtension {
//            get {
//                if(!IsVb)
//                    return ".vb";
//                return ".cs";
//            }
//        }

//        public Example GetExampleById(int id) {
//            foreach(var group in Groups) {
//                if(group.Id == id && group.Examples.Count > 0)
//                    return group.Examples[0];
//                foreach(var example in group.Examples)
//                    if(example.Id == id)
//                        return example;
//            }
//            return null;
//        }
//    }
//    public class ExampleModelBuilder {
//        string exampleDir;
//        bool visualBasicExamples;

//        public ExampleModelBuilder(string exampleDir, bool visualBasicExamples) {
//            this.exampleDir = exampleDir;
//            this.visualBasicExamples = visualBasicExamples;
//        }

//        public string ExampleDir { get { return exampleDir; } }
//        public string CodeExampleFileExtension {
//            get {
//                if(visualBasicExamples)
//                    return ".vb";
//                return ".cs";
//            }
//        }
//        public string AlternateCodeExampleFileExtension {
//            get {
//                if(visualBasicExamples)
//                    return ".cs";
//                return ".vb";
//            }
//        }

//        public ExampleModel Build() {
//            ExampleModel exampleModel = new ExampleModel();
//            GatherExamplesFromProject(exampleModel.Groups, ExampleDir);
//            exampleModel.IsVb = this.visualBasicExamples;
//            return exampleModel;
//        }
//        void GatherExamplesFromProject(List<ExampleGroup> exampleGroups, string examplesPath) {
//            List<FileInfo> sourceFiles = new List<FileInfo>();
//            foreach(string fileName in Directory.GetFiles(examplesPath))
//                if(Path.GetExtension(fileName) == CodeExampleFileExtension)
//                    sourceFiles.Add(new FileInfo(fileName));

//            int indx = 0;
//            foreach(FileInfo fileInfo in sourceFiles) {
//                string code = ReadCode(fileInfo);
//                string alternateCode = ReadAlternateCode(fileInfo);
//                List<Example> findedExamples = ParseSouceFileAndFindRegionsWithExamples(fileInfo.Name, code, alternateCode);
//                if(findedExamples.Count > 0) {
//                    ExampleGroup group = new ExampleGroup(findedExamples[0].Group, findedExamples);
//                    group.Id = indx++;
//                    findedExamples.ForEach(item => item.Id = indx++);
//                    exampleGroups.Add(group);
//                }
//            }
//        }
//        string ReadAlternateCode(FileInfo fileInfo) {
//            int indx = fileInfo.FullName.LastIndexOf(CodeExampleFileExtension);
//            string alternateFileName = fileInfo.FullName.Substring(0, indx) + AlternateCodeExampleFileExtension;
//            FileInfo alternateFileInfo = new FileInfo(alternateFileName);
//            if(!alternateFileInfo.Exists)
//                return String.Empty;
//            using(FileStream stream = File.Open(alternateFileName, FileMode.Open, FileAccess.Read, FileShare.Read)) {
//                StreamReader sr = new StreamReader(stream);
//                return sr.ReadToEnd();
//            }
//        }
//        string ReadCode(FileInfo fileInfo) {
//            using(FileStream stream = File.Open(fileInfo.FullName, FileMode.Open, FileAccess.Read, FileShare.Read)) {
//                StreamReader sr = new StreamReader(stream);
//                return sr.ReadToEnd();
//            }
//        }
//        List<Example> ParseSouceFileAndFindRegionsWithExamples(string exampleGroup, string sourceCode, string alternateCode) {
//            List<Example> result = new List<Example>();

//            string pattern = (this.visualBasicExamples) ? "#Region.*?#End Region" : "#region.*?#endregion";
//            MatchCollection matches = Regex.Matches(sourceCode, pattern, RegexOptions.Singleline);
//            MatchCollection alternateMatches = null;
//            if(!String.IsNullOrEmpty(alternateCode)) {
//                string alternatePattern = (!this.visualBasicExamples) ? "#Region.*?#End Region" : "#region.*?#endregion";
//                alternateMatches = Regex.Matches(alternateCode, alternatePattern, RegexOptions.Singleline);
//                if(alternateMatches.Count != matches.Count)
//                    alternateMatches = null;
//            }
//            int count = matches.Count;
//            for(int i = 0; i < count; i++) {
//                Match match = matches[i];
//                Example newExample = ParseExample(match, exampleGroup, this.visualBasicExamples);
//                if(newExample == null)
//                    continue;
//                result.Add(newExample);
//                if(alternateMatches == null)
//                    continue;
//                Example alternateExample = ParseExample(alternateMatches[i], exampleGroup, !this.visualBasicExamples);
//                if(alternateExample == null)
//                    continue;
//                newExample.AlternateCode = alternateExample.Code;
//            }
//            return result;
//        }
//        Example ParseExample(Match match, string exampleGroup, bool isVb) {
//            string[] lines = match.ToString().Split(new string[] { "\r\n" }, StringSplitOptions.None);
//            if(lines.Length <= 2)
//                return null;
//            string region = lines[0];
//            string endRegion = lines[lines.Length - 1];
//            lines = DeleteLeadingWhiteSpaces(lines, "            ");
//            if(isVb)
//                lines = DeleteLeadingWhiteSpaces(lines, "\t\t\t");

//            string regionStarts = (isVb) ? "#Region \"#" : "#region #";
//            int regionIndex = region.IndexOf(regionStarts);

//            if(regionIndex < 0)
//                return null;

//            int keepHashMark = 0; // "#example" if value is -1 or "example" if value will be 0
//            string regionName = ConvertStringToMoreHumanReadableForm(region.Substring(regionIndex + regionStarts.Length + keepHashMark));
//            if(isVb)
//                regionName = regionName.TrimEnd('\"');

//            string exampleCode = string.Join("\r\n", lines, 1, lines.Length - 2);

//            Example newExample = new Example();
//            newExample.Code = exampleCode;
//            newExample.RegionName = regionName;
//            newExample.Group = ConvertStringToMoreHumanReadableForm(Path.GetFileNameWithoutExtension(exampleGroup));
//            return newExample;
//        }
//        string[] DeleteLeadingWhiteSpaces(string[] lines, String stringToDelete) {
//            string[] result = new string[lines.Length];
//            int stringToDeleteLength = stringToDelete.Length;

//            for(int i = 0; i < lines.Length; i++) {
//                int index = lines[i].IndexOf(stringToDelete);
//                result[i] = (index >= 0) ? lines[i].Substring(index + stringToDeleteLength) : lines[i];
//            }
//            return result;
//        }
//        string ConvertStringToMoreHumanReadableForm(string exampleName) {
//            string result = SplitCamelCase(exampleName);
//            result = result.Replace(" In ", " in ");
//            result = result.Replace(" And ", " and ");
//            result = result.Replace(" To ", " to ");
//            return result;
//        }
//        string SplitCamelCase(string exampleName) {
//            int length = exampleName.Length;
//            if(length == 1)
//                return exampleName;

//            StringBuilder result = new StringBuilder(length * 2);
//            for(int position = 0; position < length - 1; position++) {
//                char current = exampleName[position];
//                char next = exampleName[position + 1];
//                result.Append(current);
//                if(char.IsLower(current) && char.IsUpper(next)) {
//                    result.Append(' ');
//                }
//            }
//            result.Append(exampleName[length - 1]);
//            return result.ToString();
//        }
//    }

//    public class ExampleItem {
//        public int Id { get; set; }
//    }
//    public class ExampleGroup : ExampleItem {
//        private string name;
//        private List<Example> innerList;
//        public ExampleGroup(string name, List<Example> examples) {
//            Guard.ArgumentNotNull(name, "name");
//            Guard.ArgumentNotNull(examples, "examples");
//            this.name = name;
//            this.innerList = examples;
//        }
//        public string Name { get { return name; } }
//        public List<Example> Examples { get { return innerList; } }
//    }
//    public class Example : ExampleItem {
//        public string Code { get; set; }
//        public string RegionName { get; set; }
//        public string Group { get; set; }
//        public string AlternateCode { get; set; }
//    }
//}
