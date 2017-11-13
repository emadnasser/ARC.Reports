using DevExpress.Export.Xl;
using System;
using System.CodeDom.Compiler;
using System.Reflection;

namespace DevExpress.DXperience.Demos {
    #region CodeEvaluationResult
    public enum CodeEvaluationResult {
        Success,
        CompileErrors,
        ExecuteErrors
    }
    #endregion
    #region XLExportExampleCodeEvaluatorBase
    public abstract class XLExportExampleCodeEvaluatorBase {
        protected abstract string CodeStart { get; }
        protected abstract string CodeEnd { get; }
        protected abstract CodeDomProvider GetCodeDomProvider();
        protected string GetModuleAssembly() {
            return AssemblyInfo.SRAssemblySpreadsheetCore;
        }
        protected string GetExampleClassName() {
            return "XLExportExampleCode.ExampleItem";
        }

        public CodeEvaluationResult ExecuteCodeAndGenerateDocument(string exampleCode, object[] parameters) {
            string theCode = String.Concat(CodeStart, exampleCode, CodeEnd);
            string[] linesOfCode = new string[] { theCode };
            return CompileAndRun(linesOfCode, parameters);
        }

        protected internal CodeEvaluationResult CompileAndRun(string[] linesOfCode, object[] parameters) {
            CompilerParameters CompilerParams = new CompilerParameters();

            CompilerParams.GenerateInMemory = true;
            CompilerParams.TreatWarningsAsErrors = false;
            CompilerParams.GenerateExecutable = false;

            string[] referencesSystem = new string[] { "System.dll",
                                                      "System.Windows.Forms.dll",
                                                      "System.Data.dll",
                                                      "System.Xml.dll",
                                                      "System.Drawing.dll" };

            string[] referencesDX = new string[] {
                AssemblyInfo.SRAssemblyData,
                GetModuleAssembly(),
                AssemblyInfo.SRAssemblyOfficeCore,
                AssemblyInfo.SRAssemblyPrintingCore,
                AssemblyInfo.SRAssemblyPrinting,
                AssemblyInfo.SRAssemblyDocs,
                AssemblyInfo.SRAssemblyUtils
            };
            string[] references = new string[referencesSystem.Length + referencesDX.Length];

            for (int referenceIndex = 0; referenceIndex < referencesSystem.Length; referenceIndex++) {
                references[referenceIndex] = referencesSystem[referenceIndex];
            }

            for (int i = 0, initial = referencesSystem.Length; i < referencesDX.Length; i++) {
                Assembly assembly = Assembly.Load(referencesDX[i] + AssemblyInfo.FullAssemblyVersionExtension);
                if (assembly != null)
                    references[i + initial] = assembly.Location;
            }
            CompilerParams.ReferencedAssemblies.AddRange(references);


            CodeDomProvider provider = GetCodeDomProvider();
            CompilerResults compile = provider.CompileAssemblyFromSource(CompilerParams, linesOfCode);

            if (compile.Errors.HasErrors)
                return CodeEvaluationResult.CompileErrors;

            Module module = null;
            try {
                module = compile.CompiledAssembly.GetModules()[0];
            }
            catch { }

            Type moduleType = null;

            if (module == null)
                return CodeEvaluationResult.CompileErrors;

            moduleType = module.GetType(GetExampleClassName());

            MethodInfo methInfo = null;
            if (moduleType == null)
                return CodeEvaluationResult.CompileErrors;

            methInfo = moduleType.GetMethod("Process");

            if (methInfo == null)
                return CodeEvaluationResult.CompileErrors;
            try {
                methInfo.Invoke(null, parameters);
            }
            catch (Exception ex) {
                ShowErrorMessage(ex.InnerException.Message);
                return CodeEvaluationResult.ExecuteErrors;
            }
            return CodeEvaluationResult.Success;
        }
        protected virtual void ShowErrorMessage(string message) {
        }
    }
    #endregion
}
