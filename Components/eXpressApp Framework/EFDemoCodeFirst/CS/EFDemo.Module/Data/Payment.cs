using System;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

using DevExpress.Persistent.Base;

namespace EFDemo.Module.Data {
    [DefaultClassOptions]
    public class Payment : INotifyPropertyChanging, INotifyPropertyChanged {
		private void OnPropertyChanging(String propertyName) {
			if(PropertyChanging != null) {
				PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		private void OnPropertyChanged(String propertyName) {
			if(PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
        //[Browsable(false)]
        [VisibleInDetailView(false), VisibleInListView(false), VisibleInLookupListView(false)]
		public Int32 ID { get; protected set; }
		private Decimal hours;
		private Decimal rate;
		public Decimal Rate {
			get { return rate; }
			set {
				if(rate != value) {
					OnPropertyChanging("Rate");
					rate = value;
					OnPropertyChanged("Rate");
				}
			}
		}
		public Decimal Hours {
			get { return hours; }
			set {
				if(hours != value) {
					OnPropertyChanging("Hours");
					hours = value;
					OnPropertyChanged("Hours");
				}
			}
		}
		
		[NotMapped]
		public Decimal Amount {
            get { return Rate * Hours; }
        }

		// INotifyPropertyChanging
		public event PropertyChangingEventHandler PropertyChanging;

		// INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
	}
}
