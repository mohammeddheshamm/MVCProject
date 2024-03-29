using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {   // 3mlt dh leeeh 3l4aaan al injection hy7saal 3andy hinaa w ana ba3d kida bab3atooo ll Parent.
        private readonly MVCProjectDbContext _dbContext;

        public EmployeeRepository(MVCProjectDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Employee> SearchEmployeesByName(string name)
            =>   _dbContext.Employees.Where(E => E.Name.Contains(name));
        
        //public IQueryable<Employee> GetEmployeesByDepartmentName(string DepartmentName)
        //{

        //}
    }
}
