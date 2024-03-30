using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        
        private Hashtable _repository;
        private readonly MVCProjectDbContext _context;

        public UnitOfWork(MVCProjectDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (_repository == null) 
                _repository = new Hashtable();
            
            var type = typeof(TEntity).Name;

            if (!_repository.Contains(type))
            {
                var repository = new GenericRepository<TEntity>(_context);
                _repository.Add(type, repository);
            }

            return (IGenericRepository<TEntity>)_repository[type];
        }

        public async Task<int> Complete()
            => await _context.SaveChangesAsync();

        public void Dispose()
        {
            //  al context b3d ma y5alaas byrgaa3 ydawaaar 3la al function dy
            _context.Dispose();
        }
    }
}
