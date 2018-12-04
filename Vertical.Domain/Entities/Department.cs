using System;
using System.Collections.Generic;

namespace Vertical.Domain.Entities
{
    public class Department
    {
        public Department()
        {
            Employees=new HashSet<Employee>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}