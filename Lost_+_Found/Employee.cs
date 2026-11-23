using System;
using System.Collections.Generic;
using System.Text;

namespace Lost___Found
{
    public class Employee : Person
    {
        

        private string EmployeeID { get; set; }

        public Employee(string name, int age, string employeeID) : base(name, age)
        {

            EmployeeID = employeeID;
        }

        public void AddCustomer()
        {


        }
        public override string GetInfo()
        {
            string baseInfo = base.GetInfo();
            return $"{baseInfo} , EmployeeID: {EmployeeID}";
        }

    }
}
