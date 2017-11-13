using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public class RichEditMailMergeModel : RichEditModelBase {
        public RichEditMailMergeModel() {
            Data = new InMemoryNWindData();
            Customers = Data.Customers;
            Employees = Data.Employees;
            EmployeeId = Employees[0].EmployeeID;
            CustomerId = Customers[0].CustomerID;
            PreviewModel.PreviewDocumentAction = "PreviewMailMerge";
        }
        public Employee Employee {get { return Employees.Find(item => item.EmployeeID == EmployeeId); }}
        public Customer Customer { get { return Customers.Find(item => item.CustomerID == CustomerId); } }
        public int EmployeeId { get; set; }
        public string CustomerId { get; set; }
        public List<Customer> Customers { get; private set; }
        public List<Employee> Employees { get; private set; }
        public InMemoryNWindData Data { get; set; }
    }
}
