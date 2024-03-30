using Demo.BLL.Interfaces;
using Demo.BLL.Specification;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly MVCProjectDbContext _dbContext;
        // By giving the ctor DBContext as a parameter this tells the clr to inject the object from the context to the REPO.
        public GenericRepository(MVCProjectDbContext dbContext)
        {
            // I made this constractor as i will not call these function unless i made an object from DepartmentRepo.
            // So i will call those functions by creating object also from the Dbcontext in the constructor. 
            //DbContext = new MVCProjectDbContext();
            _dbContext = dbContext;
        }
        public async Task<int> Add(T Item)
        {
            await _dbContext.Set<T>().AddAsync(Item);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(T Item)
        {
            _dbContext.Set<T>().Remove(Item);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<T> Get(int id)
            // We Used FirstOrDefault because it may return more than 1 element so to avoid this mess.
            //=> _dbContext.Set<T>().Where(G => G.Id == id).FirstOrDefault();
            => await _dbContext.Set<T>().FindAsync(id);


        public async Task<IEnumerable<T>> GetAll()
        {
            if (typeof(T) == typeof(Employee))
                return (IEnumerable<T>) await _dbContext.Set<Employee>().Include(E => E.Department).ToListAsync();
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IReadOnlyList<T>> SearchByNameWithSpec(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public async Task<int> Update(T Item)
        {
            _dbContext.Set<T>().Update(Item);
            return await _dbContext.SaveChangesAsync();
        }

        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_dbContext.Set<T>(), spec);
        }
    }
}
