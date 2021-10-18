using EmployeeManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public DeptNameList DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }

    }
}
