using System;
using System.Linq;
using System.Collections.Generic;

namespace EFDemo.Module.Data {
	public partial class EFDemoObjectContext {
		partial void OnContextCreated() {
		}
		protected override void Dispose(Boolean disposing) {
			base.Dispose(disposing);
		}
	}
}
