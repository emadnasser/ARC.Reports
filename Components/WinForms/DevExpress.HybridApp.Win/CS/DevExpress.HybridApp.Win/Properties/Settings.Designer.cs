﻿

namespace DevExpress.DevAV.Properties {


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {

        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All</Name>
    <ImageUri>Resources/Employees/All.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Salaried</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Salaried#</FilterCriteria>
    <ImageUri>Resources/Employees/Salaried.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Commission</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Commission#</FilterCriteria>
    <ImageUri>Resources/Employees/Commission.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Contract</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Contract#</FilterCriteria>
    <ImageUri>Resources/Employees/Probation.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Terminated</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,Terminated#</FilterCriteria>
    <ImageUri>Resources/Employees/Terminated.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>On Leave</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeStatus,OnLeave#</FilterCriteria>
    <ImageUri>Resources/Employees/OnLeave.png</ImageUri>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public DevExpress.DevAV.ViewModels.FilterInfoList EmployeeStaticFilters {
            get {
                return ((DevExpress.DevAV.ViewModels.FilterInfoList)(this["EmployeeStaticFilters"]));
            }
            set {
                this["EmployeeStaticFilters"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All Tasks</Name>
    <FilterCriteria />
    <ImageUri>Resources/Tasks/AllTasks.png</ImageUri>
</FilterInfo>
<FilterInfo>
  <Name>In Progress</Name>
  <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeTaskStatus,InProgress#</FilterCriteria>
  <ImageUri>Resources/Tasks/InProgress.png</ImageUri>
</FilterInfo>
<FilterInfo>
    <Name>Not Started</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeTaskStatus,NotStarted#</FilterCriteria>
    <ImageUri>Resources/Tasks/NotStarted.png</ImageUri>
</FilterInfo>
<FilterInfo>
    <Name>Deferred</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeTaskStatus,Deferred#</FilterCriteria>
    <ImageUri>Resources/Tasks/Deferred.png</ImageUri>
	</FilterInfo>\r\n  <FilterInfo>
    <Name>Completed</Name>
    <FilterCriteria>[Status] = ##Enum#DevExpress.DevAV.EmployeeTaskStatus,Completed#</FilterCriteria>
    <ImageUri>Resources/Tasks/Completed.png</ImageUri>
</FilterInfo>
<FilterInfo>
    <Name>High Priority</Name>
    <FilterCriteria>[Priority] = ##Enum#DevExpress.DevAV.EmployeeTaskPriority,High#</FilterCriteria>
    <ImageUri>Resources/Tasks/HighPriority.png</ImageUri>
</FilterInfo>
<FilterInfo>
    <Name>Urgent</Name>
    <FilterCriteria>[Priority] = ##Enum#DevExpress.DevAV.EmployeeTaskPriority,Urgent#</FilterCriteria>
    <ImageUri>Resources/Tasks/Urgent.png</ImageUri>
</FilterInfo>
</ArrayOfFilterInfo>")]
        public DevExpress.DevAV.ViewModels.FilterInfoList EmployeeTaskStaticFilters {
            get {
                return ((DevExpress.DevAV.ViewModels.FilterInfoList)(this["EmployeeTaskStaticFilters"]));
            }
            set {
                this["EmployeeTaskStaticFilters"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All</Name>
    <ImageUri>Resources/Products/All.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Video Players</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,VideoPlayers#</FilterCriteria>
    <ImageUri>Resources/Products/VideoPlayers.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Automation</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Automation#</FilterCriteria>
    <ImageUri>Resources/Products/Automation.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Monitors</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Monitors#</FilterCriteria>
    <ImageUri>Resources/Products/Monitors.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Projectors</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Projectors#</FilterCriteria>
    <ImageUri>Resources/Products/Projectors.png</ImageUri>
  </FilterInfo>
  <FilterInfo>
    <Name>Televisions</Name>
    <FilterCriteria>[Category] = ##Enum#DevExpress.DevAV.ProductCategory,Televisions#</FilterCriteria>
    <ImageUri>Resources/Products/TVs.png</ImageUri>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public DevExpress.DevAV.ViewModels.FilterInfoList ProductStaticFilters {
            get {
                return ((DevExpress.DevAV.ViewModels.FilterInfoList)(this["ProductStaticFilters"]));
            }
            set {
                this["ProductStaticFilters"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All Products</Name>
    <FilterCriteria />
  </FilterInfo>
  <FilterInfo>
    <Name>HD Video player</Name>
    <FilterCriteria>Contains([Name], 'HD') And Category = 'VideoPlayers'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>50inch Plasma</Name>
    <FilterCriteria>Contains([Name], '50') And Category = 'Televisions'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>21inch Monitor</Name>
    <FilterCriteria>Contains([Name], '21') And Category = 'Monitors'</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Remote Control</Name>
    <FilterCriteria>Contains([Name], 'Remote') And Category = 'Automation'</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public DevExpress.DevAV.ViewModels.FilterInfoList ProductCustomFilters
        {
            get
            {
                return ((DevExpress.DevAV.ViewModels.FilterInfoList)(this["ProductCustomFilters"]));
            }
            set
            {
                this["ProductCustomFilters"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfFilterInfo xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <FilterInfo>
    <Name>All Customers</Name>
    <FilterCriteria />
  </FilterInfo>
  <FilterInfo>
    <Name>My Account</Name>
    <FilterCriteria>[HomeOffice.State] = ##Enum#DevExpress.DevAV.StateEnum,CA#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>John's Account</Name>
    <FilterCriteria>[HomeOffice.State] = ##Enum#DevExpress.DevAV.StateEnum,WA#</FilterCriteria>
  </FilterInfo>
  <FilterInfo>
    <Name>Top Stores</Name>
    <FilterCriteria>[AnnualRevenue] &gt;= 90000000000.0m</FilterCriteria>
  </FilterInfo>
</ArrayOfFilterInfo>")]
        public global::DevExpress.DevAV.ViewModels.FilterInfoList CustomerCustomFilters
        {
            get
            {
                return ((global::DevExpress.DevAV.ViewModels.FilterInfoList)(this["CustomerCustomFilters"]));
            }
            set
            {
                this["CustomerCustomFilters"] = value;
            }
        }
    }
}