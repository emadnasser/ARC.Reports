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

namespace DevExpress.MVVM.Demos.ExpensesDbContextDataModel {
    /// <summary>
    /// IExpensesDbContextUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IExpensesDbContextUnitOfWork : IUnitOfWork {

        /// <summary>
        /// The Account entities repository.
        /// </summary>
        IRepository<Account, long> Accounts { get; }

        /// <summary>
        /// The Category entities repository.
        /// </summary>
        IRepository<Category, long> Categories { get; }

        /// <summary>
        /// The Transaction entities repository.
        /// </summary>
        IRepository<Transaction, long> Transactions { get; }
    }
}
