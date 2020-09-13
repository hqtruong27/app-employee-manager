using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
   public class salaryEntity
    {
        int employeeId;
        string employeeName;
        string gender;
        string department;
        string position;
        int publicDay;
        float salaryBasic;
        float salary;
        public salaryEntity()
        {

        }

        public salaryEntity(int employeeId, string employeeName, string gender, string department, string position, int publicDay, float salaryBasic, float salary)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.Gender = gender;
            Department = department;
            this.Position = position;
            this.PublicDay = publicDay;
            this.SalaryBasic = salaryBasic;
            Salary = salary;
        }

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Department { get => department; set => department = value; }
        public string Position { get => position; set => position = value; }
        public int PublicDay { get => publicDay; set => publicDay = value; }
        public float SalaryBasic { get => salaryBasic; set => salaryBasic = value; }
        public float Salary { get => salary; set => salary = value; }
    }
}
