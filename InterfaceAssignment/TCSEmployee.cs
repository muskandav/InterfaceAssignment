using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{
    internal class TCSEmployee : IGovtRules
    {
        

        public string Name { get; set; }
        public string Designation { get; set; }
        public string EmpId { get; set; }
        public string Department { get; set; }
        public double BasicSalary { get; set; }

        public TCSEmployee(string name, string designation, string empId, string department, double basicSalary)
        {
            Name = name;
            Designation = designation;
            EmpId = empId;
            Department = department;
            BasicSalary = basicSalary;
        }

       

        public double EmployeePF(double basicSalary)
        {
            var pensionFund = (0.12*basicSalary) + (0.0833*basicSalary) + (0.0367*basicSalary);
            return pensionFund;

        }

        public double GratuityAmount(float serviceCompleted, double basicSalary)
        {
            double gratuity = 0;

            if(serviceCompleted > 5 && serviceCompleted < 10)
            {
                gratuity = basicSalary;
            }else if(serviceCompleted < 20){
                gratuity = 2 * basicSalary;
            }else if(serviceCompleted < 30){
                gratuity = 3 * basicSalary;
            }

            return gratuity;
        }

        public string LeaveDetails()
        {
            string leaveDetails = "Casual leave = 1 day per month, Sick leave = 12 days per year, Privilege leave = 10 days per year.";
            return leaveDetails;
        }

        public void ViewDetails(float service)
        {
            Console.WriteLine($"Employee: {this.Name}");
            Console.WriteLine($"Id: {this.EmpId}");
            Console.WriteLine($"Department: {this.Department}");
            Console.WriteLine($"Designation: {this.Designation}");
            Console.WriteLine($"Basic Salary: {this.BasicSalary}");
            Console.WriteLine($"PF: {this.EmployeePF(this.BasicSalary)}");
            Console.WriteLine($"Gratuity: {this.GratuityAmount(service, this.BasicSalary)}");
            Console.WriteLine($"Leave Details: {(this.LeaveDetails())}");
        }
    }
}
