using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.Common.DataModel;
using DevExpress.DevAV.Common.DataModel.EntityFramework;
using DevExpress.DevAV;
using DevExpress.Mvvm;

namespace DevExpress.DevAV.DevAVDbDataModel {
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

        #region inner classes
                class DbUnitOfWorkFactory : IUnitOfWorkFactory<IDevAVDbUnitOfWork> {
            public static readonly IUnitOfWorkFactory<IDevAVDbUnitOfWork> Instance = new DbUnitOfWorkFactory();
            DbUnitOfWorkFactory() { }
            IDevAVDbUnitOfWork IUnitOfWorkFactory<IDevAVDbUnitOfWork>.CreateUnitOfWork() {
                return new DevAVDbUnitOfWork(() => new DevAVDb());
            }
        }
                  #endregion

  /// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IDevAVDbUnitOfWork> GetUnitOfWorkFactory() {
            return DbUnitOfWorkFactory.Instance;
        }
      }
}
