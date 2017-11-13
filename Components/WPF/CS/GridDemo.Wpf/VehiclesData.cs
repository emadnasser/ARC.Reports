using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.DemoData.Models.Vehicles;
using VehicleModel = DevExpress.DemoData.Models.Vehicles.Model;

namespace DevExpress.DemoData {
    public class VehiclesData {
        VehiclesContext context = new VehiclesContext();
        public IEnumerable<VehicleModel> Models {
            get { return context.Models.ToList(); }
        }
    }
}
