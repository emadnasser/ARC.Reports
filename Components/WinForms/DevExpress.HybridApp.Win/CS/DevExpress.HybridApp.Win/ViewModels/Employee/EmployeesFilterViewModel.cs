﻿using DevExpress.DevAV.Properties;
using System;

namespace DevExpress.DevAV.ViewModels {
    public class EmployeesFilterViewModel : FilterViewModel<Employee> {
        public EmployeesFilterViewModel()
            : base(new FilterModelPageSpecificSettings<Settings>(Settings.Default, x => x.EmployeeStaticFilters, null),
            new Action<object, Action>(FiltersSettings.RegisterEntityChangedMessageHandler<Employee, long>)) {
        }
    }
}
