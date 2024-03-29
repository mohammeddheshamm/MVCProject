using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
        // We used i Queryable to make the filteration in the SQL and not to get Data not used 
        //public IQueryable<Employee> GetEmployeesByDepartmentName(string DepartmentName);

        public IQueryable<Employee> SearchEmployeesByName(string name);
    }
}
