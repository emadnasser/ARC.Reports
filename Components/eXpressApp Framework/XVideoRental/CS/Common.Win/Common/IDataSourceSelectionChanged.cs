using System.Collections;

namespace Common.Win.Common {
    [OnlineRepoLocation("http://goo.gl/wbT73")]
    public interface IDataSourceSelectionChanged {
        IList SelectedObjects { get; set; }
    }
}
