using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using DevExpress.MVVM.Demos.Common.Utils;
using DevExpress.MVVM.Demos.Common.DataModel;
using DevExpress.MVVM.Demos.Common.DataModel.EntityFramework;
using DevExpress.MVVM.Demos.DataBase;
using DevExpress.MVVM.Demos.Model;
using DevExpress.Mvvm;
using System.Collections;
using System.ComponentModel;
using DevExpress.Data.Linq;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Async.Helpers;

namespace DevExpress.MVVM.Demos.ExpensesDbContextDataModel {
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IExpensesDbContextUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IExpensesDbContextUnitOfWork>(() => new ExpensesDbContextUnitOfWork(() => new ExpensesDbContext()));
        }
    }
}
