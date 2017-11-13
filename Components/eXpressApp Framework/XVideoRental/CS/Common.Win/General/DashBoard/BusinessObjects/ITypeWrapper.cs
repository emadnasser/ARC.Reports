using System;

namespace Common.Win.General.DashBoard.BusinessObjects {
    public interface ITypeWrapper {
        string Caption { get; }
        Type Type { get; }
    }
}
