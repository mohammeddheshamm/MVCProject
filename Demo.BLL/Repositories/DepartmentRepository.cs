using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
    // Singleton Design pattern is to make the dev can only make one object of class and if it is called back it will give him the one which is already made.
{   // Interface is a code contract between the developer who made the interface and the One who will implement it.
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly MVCProjectDbContext _dbContext;
        #region Before Generics
        //Readonly to prevent anyone from changing in the context.
        // To Treat with the Database.
        //private readonly MVCProjectDbContext _dbContext;
        //// By giving the ctor DBContext as a parameter this tells the clr to inject the object from the context to the REPO.
        //public DepartmentRepository(MVCProjectDbContext dbContext)
        //{
        //    // I made this constractor as i will not call these function unless i made an object from DepartmentRepo.
        //    // So i will call those functions by creating object also from the Dbcontext in the constructor. 
        //    //DbContext = new MVCProjectDbContext();
        //    _dbContext = dbContext;
        //}
        //public int Add(Department department)
        //{
        //    _dbContext.Departments.Add(department);
        //    return _dbContext.SaveChanges();
        //}

        //public int Delete(Department department)
        //{
        //    _dbContext.Departments.Remove(department);
        //    return _dbContext.SaveChanges();
        //}

        //public Department Get(int id)
        //    // We Used FirstOrDefault because it may return more than 1 element so to avoid this mess.
        //    => _dbContext.Departments.Where(D =>  D.Id == id).FirstOrDefault();


        //public IEnumerable<Department> GetAll()
        //    => _dbContext.Departments.ToList();


        //public int Update(Department department)
        //{
        //    _dbContext.Departments.Update(department);
        //    return _dbContext.SaveChanges();
        //} 
        #endregion

        public DepartmentRepository(MVCProjectDbContext dbContext):base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Department> SearchDepartmentByName(string SearchValue)
            => _dbContext.Departments.Where(D => D.Name.Contains(SearchValue));
    }
}
