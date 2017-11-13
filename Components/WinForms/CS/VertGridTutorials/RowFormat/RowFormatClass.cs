using System;

namespace DevExpress.XtraVerticalGrid.Demos.Tutorials {
	public class RowFormatRecord {
		private double payment; 
		private long length;
		private DateTime purchaseDate;
		private int number;
        
		public RowFormatRecord(double payment, long length, DateTime purchaseDate, int number) {
			this.payment = payment;
			this.length = length;
			this.purchaseDate = purchaseDate;
			this.number = number;
		}

		public double Payment {
			get { return payment; }
			set { payment = value; }
		}
		
		public long Length {
			get { return length; }
			set { length = value; }
		}

		public DateTime PurchaseDate { 
			get  { return purchaseDate; }
			set { purchaseDate = value; }
		}

		public int Number {
			get { return number; }
			set { number = value; }
		}
	}
	public class BaseFormatter : IFormatProvider, ICustomFormatter {

		public object GetFormat(Type format) {
			if (format == typeof (ICustomFormatter)) return this;
			else return null;
		}

		public string Format (string format, object arg, IFormatProvider provider) {
			if (format == null) {
				if (arg is IFormattable)
					return ((IFormattable)arg).ToString(format, provider);
				else
					return arg.ToString(); 
			}


			if (!format.StartsWith("B")) {  
				if (arg is IFormattable)
					return ((IFormattable)arg).ToString(format, provider);
				else
					return arg.ToString(); 
			}

			format = format.Trim (new char [] {'B'});
			int b = Convert.ToInt32 (format);
			return Convert.ToString ((int)arg, b);
		}
	}
}

