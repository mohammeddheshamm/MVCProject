using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Specification
{
    public class DepartmentWithEmployeeSpecifications : BaseSpecification<Department>
    {
        public DepartmentWithEmployeeSpecifications(string name)
            :base(D => D.Name.Contains(name))
        {
            Includes.Add(D => D.Employees);
        }
    }
}
