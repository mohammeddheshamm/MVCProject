using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        //For add and update and delete methods the return type is int because it returns the number of rows affected in the database.
        Task<int> Add(T item);
        Task<int> Update(T item);
        Task<int> Delete(T item);
    }
}
