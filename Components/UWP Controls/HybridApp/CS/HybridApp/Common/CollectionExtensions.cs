using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HybridApp.Common {
    public static class CollectionExtensions {
        public static void Replace<TItem>(this IList<TItem> list, Predicate<TItem> source, Func<TItem, TItem> target) {
            for(int i = 0; i < list.Count; ++i) {
                if(source(list[i]))
                    list[i] = target(list[i]);
            }
        }
        public static ObservableCollection<T> AsObservableCollection<T>(this IEnumerable<T> source) {
            if(source == null) return null;
            return new ObservableCollection<T>(source);
        }
    }
}
