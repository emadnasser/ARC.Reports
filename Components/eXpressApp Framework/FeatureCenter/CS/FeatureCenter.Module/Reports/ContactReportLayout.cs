using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeatureCenter.Module.Reports {
    public class ContactReportLayout {
        static readonly string reportLayout = @"
/// <XRTypeInfo>
///   <AssemblyFullName>DevExpress.XtraReportsVSuffix, Version=dllVersion, Culture=neutral, PublicKeyToken=dllPublicKeyToken</AssemblyFullName>
///   <AssemblyLocation>C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraReportsVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraReportsVSuffix.dll</AssemblyLocation>
///   <TypeName>DevExpress.XtraReports.UI.XtraReport</TypeName>
///   <Localization />
///   <Version>VersionShort</Version>
///   <References>
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.Persistent.BaseVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.Persistent.BaseVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Configuration\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Data.SqlXml\v4.0_4.0.0.0__b77a5c561934e089\System.Data.SqlXml.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Security\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Security.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XpoVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XpoVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.Services\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.Services.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_64\System.Web\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Framework\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Framework.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xaml\v4.0_4.0.0.0__b77a5c561934e089\System.Xaml.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.DataAnnotations\v4.0_4.0.0.0__31bf3856ad364e35\System.ComponentModel.DataAnnotations.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Numerics\v4.0_4.0.0.0__b77a5c561934e089\System.Numerics.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Caching\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Runtime.Caching.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_64\System.Data\v4.0_4.0.0.0__b77a5c561934e089\System.Data.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_64\System.Transactions\v4.0_4.0.0.0__b77a5c561934e089\System.Transactions.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_64\System.EnterpriseServices\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.EnterpriseServices.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.DirectoryServices\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.DirectoryServices.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Remoting\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Remoting.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization.Formatters.Soap\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Runtime.Serialization.Formatters.Soap.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.ApplicationServices\v4.0_4.0.0.0__31bf3856ad364e35\System.Web.ApplicationServices.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Drawing\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Drawing.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Utilities.v4.0\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Utilities.v4.0.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.DirectoryServices.Protocols\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.DirectoryServices.Protocols.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Design\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Design.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Windows.Forms\v4.0_4.0.0.0__b77a5c561934e089\System.Windows.Forms.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Accessibility\v4.0_4.0.0.0__b03f5f7f11d50a3a\Accessibility.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Deployment\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Deployment.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Drawing.Design\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Drawing.Design.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_64\System.Data.OracleClient\v4.0_4.0.0.0__b77a5c561934e089\System.Data.OracleClient.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Web.RegularExpressions\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Web.RegularExpressions.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Build.Tasks.v4.0\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Build.Tasks.v4.0.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceProcess\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.ServiceProcess.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Configuration.Install\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Configuration.Install.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Internals\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Internals.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\SMDiagnostics\v4.0_4.0.0.0__b77a5c561934e089\SMDiagnostics.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel\v4.0_4.0.0.0__b77a5c561934e089\System.ServiceModel.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.DurableInstancing\v4.0_4.0.0.0__31bf3856ad364e35\System.Runtime.DurableInstancing.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xml.Linq\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.Linq.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Net.Http\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Net.Http.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.IdentityModel\v4.0_4.0.0.0__b77a5c561934e089\System.IdentityModel.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Messaging\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Messaging.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.IdentityModel.Selectors\v4.0_4.0.0.0__b77a5c561934e089\System.IdentityModel.Selectors.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.Transactions.Bridge\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.Transactions.Bridge.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Activation\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Activation.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xaml.Hosting\v4.0_4.0.0.0__31bf3856ad364e35\System.Xaml.Hosting.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ServiceModel.Activities\v4.0_4.0.0.0__31bf3856ad364e35\System.ServiceModel.Activities.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Activities\v4.0_4.0.0.0__31bf3856ad364e35\System.Activities.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_64\Microsoft.VisualBasic.Activities.Compiler\v4.0_10.0.0.0__b03f5f7f11d50a3a\Microsoft.VisualBasic.Activities.Compiler.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.VisualBasic\v4.0_10.0.0.0__b03f5f7f11d50a3a\Microsoft.VisualBasic.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Management\v4.0_4.0.0.0__b03f5f7f11d50a3a\System.Management.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.JScript\v4.0_10.0.0.0__b03f5f7f11d50a3a\Microsoft.JScript.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Activities.DurableInstancing\v4.0_4.0.0.0__31bf3856ad364e35\System.Activities.DurableInstancing.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.ExpressAppVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.ExpressAppVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.UtilsVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.UtilsVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\UIAutomationClient\v4.0_4.0.0.0__31bf3856ad364e35\UIAutomationClient.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\UIAutomationProvider\v4.0_4.0.0.0__31bf3856ad364e35\UIAutomationProvider.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\UIAutomationTypes\v4.0_4.0.0.0__31bf3856ad364e35\UIAutomationTypes.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\WindowsBase\v4.0_4.0.0.0__31bf3856ad364e35\WindowsBase.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_64\PresentationCore\v4.0_4.0.0.0__31bf3856ad364e35\PresentationCore.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Windows.Input.Manipulations\v4.0_4.0.0.0__b77a5c561934e089\System.Windows.Input.Manipulations.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.ExpressApp.XpoVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.ExpressApp.XpoVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraReportsVSuffix.Extensions\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraReportsVSuffix.Extensions.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.UtilsVSuffix.UI\v4.0_dllVersion__dllPublicKeyToken\DevExpress.UtilsVSuffix.UI.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraBarsVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraBarsVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraEditorsVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraEditorsVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Data.Linq\v4.0_4.0.0.0__b77a5c561934e089\System.Data.Linq.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraTreeListVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraTreeListVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraRichEditVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraRichEditVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraPrintingVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraPrintingVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraVerticalGridVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraVerticalGridVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.DataAccessVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.DataAccessVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Data.Entity\v4.0_4.0.0.0__b77a5c561934e089\System.Data.Entity.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraChartsVSuffix.Extensions\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraChartsVSuffix.Extensions.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraChartsVSuffix.Wizard\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraChartsVSuffix.Wizard.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraNavBarVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraNavBarVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraPivotGridVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraPivotGridVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.CodeParserVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.CodeParserVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.DataAccessVSuffix.UI\v4.0_dllVersion__dllPublicKeyToken\DevExpress.DataAccessVSuffix.UI.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraWizardVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraWizardVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraGridVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraGridVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraLayoutVSuffix\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraLayoutVSuffix.dll"" />
///     <Reference Path=""C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\DevExpress.XtraGaugesVSuffix.Core\v4.0_dllVersion__dllPublicKeyToken\DevExpress.XtraGaugesVSuffix.Core.dll"" />
///   </References>
///   <Resources>
///     <Resource Name=""XtraReportSerialization.ContactReport"">
/// zsrvvgEAAACRAAAAbFN5c3RlbS5SZXNvdXJjZXMuUmVzb3VyY2VSZWFkZXIsIG1zY29ybGliLCBWZXJzaW9uPTQuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49Yjc3YTVjNTYxOTM0ZTA4OSNTeXN0ZW0uUmVzb3VyY2VzLlJ1bnRpbWVSZXNvdXJjZVNldAIAAAAAAAAAAAAAAFBBRFBBRFC0AAAA</Resource>
///   </Resources>
/// </XRTypeInfo>
namespace XtraReportSerialization {
    
    public class ContactReport : DevExpress.XtraReports.UI.XtraReport {
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.PageFooterBand pageFooterBand1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.Persistent.Base.ReportsV2.CollectionDataSource collectionDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle FieldCaption;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DataField;
        private System.Resources.ResourceManager _resources;
        private string _resourceString;
        public ContactReport() {
            this._resourceString = DevExpress.XtraReports.Serialization.XRResourceManager.GetResourceFor(""XtraReportSerialization.ContactReport"");
            this.InitializeComponent();
        }
        private System.Resources.ResourceManager resources {
            get {
                if (_resources == null) {
                    this._resources = new DevExpress.XtraReports.Serialization.XRResourceManager(this._resourceString);
                }
                return this._resources;
            }
        }
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.pageFooterBand1 = new DevExpress.XtraReports.UI.PageFooterBand();
            this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.collectionDataSource1 = new DevExpress.Persistent.Base.ReportsV2.CollectionDataSource();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.FieldCaption = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DataField = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.xrLabel9,
                        this.xrLabel1,
                        this.xrLabel2,
                        this.xrLabel3,
                        this.xrLabel4,
                        this.xrLabel5,
                        this.xrLabel6,
                        this.xrLabel7,
                        this.xrLabel8,
                        this.xrLabel10,
                        this.xrLine1});
            this.Detail.HeightF = 134.25F;
            this.Detail.Name = ""Detail"";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pageFooterBand1
            // 
            this.pageFooterBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.xrPageInfo1,
                        this.xrPageInfo2});
            this.pageFooterBand1.HeightF = 29F;
            this.pageFooterBand1.Name = ""pageFooterBand1"";
            // 
            // reportHeaderBand1
            // 
            this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                        this.xrLabel11});
            this.reportHeaderBand1.HeightF = 51F;
            this.reportHeaderBand1.Name = ""reportHeaderBand1"";
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.HeightF = 100F;
            this.topMarginBand1.Name = ""topMarginBand1"";
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.HeightF = 100F;
            this.bottomMarginBand1.Name = ""bottomMarginBand1"";
            // 
            // xrLabel9
            // 
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                        new DevExpress.XtraReports.UI.XRBinding(""Text"", null, ""Position.Title"")});
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(174F, 81.00001F);
            this.xrLabel9.Name = ""xrLabel9"";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(470.0001F, 17.99999F);
            this.xrLabel9.Text = ""xrLabel9"";
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 9F);
            this.xrLabel1.Name = ""xrLabel1"";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.xrLabel1.StyleName = ""FieldCaption"";
            this.xrLabel1.Text = ""First Name"";
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(6F, 33F);
            this.xrLabel2.Name = ""xrLabel2"";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.xrLabel2.StyleName = ""FieldCaption"";
            this.xrLabel2.Text = ""Last Name"";
            // 
            // xrLabel3
            // 
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(6F, 57F);
            this.xrLabel3.Name = ""xrLabel3"";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.xrLabel3.StyleName = ""FieldCaption"";
            this.xrLabel3.Text = ""Email"";
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(6F, 81F);
            this.xrLabel4.Name = ""xrLabel4"";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.xrLabel4.StyleName = ""FieldCaption"";
            this.xrLabel4.Text = ""Position"";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(6F, 105F);
            this.xrLabel5.Name = ""xrLabel5"";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(162F, 18F);
            this.xrLabel5.StyleName = ""FieldCaption"";
            this.xrLabel5.Text = ""Birthday"";
            // 
            // xrLabel6
            // 
            this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                        new DevExpress.XtraReports.UI.XRBinding(""Text"", null, ""FirstName"")});
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(174F, 9F);
            this.xrLabel6.Name = ""xrLabel6"";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(470F, 18F);
            this.xrLabel6.StyleName = ""DataField"";
            this.xrLabel6.Text = ""xrLabel6"";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                        new DevExpress.XtraReports.UI.XRBinding(""Text"", null, ""LastName"")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(174F, 33F);
            this.xrLabel7.Name = ""xrLabel7"";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(470F, 18F);
            this.xrLabel7.StyleName = ""DataField"";
            this.xrLabel7.Text = ""xrLabel7"";
            // 
            // xrLabel8
            // 
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                        new DevExpress.XtraReports.UI.XRBinding(""Text"", null, ""Email"")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(174F, 57F);
            this.xrLabel8.Name = ""xrLabel8"";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(470F, 18F);
            this.xrLabel8.StyleName = ""DataField"";
            this.xrLabel8.Text = ""xrLabel8"";
            // 
            // xrLabel10
            // 
            this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
                        new DevExpress.XtraReports.UI.XRBinding(""Text"", null, ""Birthday"")});
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(174F, 105F);
            this.xrLabel10.Name = ""xrLabel10"";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(470F, 18F);
            this.xrLabel10.StyleName = ""DataField"";
            this.xrLabel10.Text = ""xrLabel10"";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 3F);
            this.xrLine1.Name = ""xrLine1"";
            this.xrLine1.SizeF = new System.Drawing.SizeF(638F, 2F);
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.xrPageInfo1.Name = ""xrPageInfo1"";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
            this.xrPageInfo1.StyleName = ""PageInfo"";
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.Format = ""Page {0} of {1}"";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
            this.xrPageInfo2.Name = ""xrPageInfo2"";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
            this.xrPageInfo2.StyleName = ""PageInfo"";
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel11
            // 
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
            this.xrLabel11.Name = ""xrLabel11"";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(638F, 33F);
            this.xrLabel11.StyleName = ""Title"";
            this.xrLabel11.Text = ""Contacts"";
            // 
            // collectionDataSource1
            // 
            this.collectionDataSource1.Name = ""collectionDataSource1"";
            this.collectionDataSource1.ObjectTypeName = ""FeatureCenter.Module.Reports.ContactForReport"";
            this.collectionDataSource1.TopReturnedRecords = 0;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new System.Drawing.Font(""Times New Roman"", 20F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Maroon;
            this.Title.Name = ""Title"";
            // 
            // FieldCaption
            // 
            this.FieldCaption.BackColor = System.Drawing.Color.Transparent;
            this.FieldCaption.BorderColor = System.Drawing.Color.Black;
            this.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.FieldCaption.BorderWidth = 1F;
            this.FieldCaption.Font = new System.Drawing.Font(""Arial"", 10F, System.Drawing.FontStyle.Bold);
            this.FieldCaption.ForeColor = System.Drawing.Color.Maroon;
            this.FieldCaption.Name = ""FieldCaption"";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new System.Drawing.Font(""Times New Roman"", 10F, System.Drawing.FontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.Black;
            this.PageInfo.Name = ""PageInfo"";
            // 
            // DataField
            // 
            this.DataField.BackColor = System.Drawing.Color.Transparent;
            this.DataField.BorderColor = System.Drawing.Color.Black;
            this.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DataField.BorderWidth = 1F;
            this.DataField.Font = new System.Drawing.Font(""Times New Roman"", 10F);
            this.DataField.ForeColor = System.Drawing.Color.Black;
            this.DataField.Name = ""DataField"";
            this.DataField.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // ContactReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                        this.Detail,
                        this.pageFooterBand1,
                        this.reportHeaderBand1,
                        this.topMarginBand1,
                        this.bottomMarginBand1});
            this.ComponentStorage.Add(this.collectionDataSource1);
            this.DataSource = this.collectionDataSource1;
            this.DisplayName = ""Contacts Report (editable)"";
            this.Extensions.Add(""DataSerializationExtension"", ""XtraReport"");
            this.Extensions.Add(""DataEditorExtension"", ""XtraReport"");
            this.Extensions.Add(""ParameterEditorExtension"", ""XtraReport"");
            this.Name = ""ContactReport"";
            this.PageHeight = 1100;
            this.PageWidth = 850;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
                        this.Title,
                        this.FieldCaption,
                        this.PageInfo,
                        this.DataField});
            this.Version = ""VersionShort"";
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }
    }
}
";
        public static byte[] ReportLayout {
            get {
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(ConvertVersion(reportLayout));
                return byteArray;
            }
        }
        private static string ConvertVersion(string reportLayout) {
            string result = reportLayout;
            result = result.Replace("VSuffix", AssemblyInfo.VSuffix);
            result = result.Replace("dllVersion", AssemblyInfo.Version);
            result = result.Replace("dllPublicKeyToken", AssemblyInfo.PublicKeyToken);
            result = result.Replace("VersionShort", AssemblyInfo.VersionShort);
            return result;
        }
    }
}
