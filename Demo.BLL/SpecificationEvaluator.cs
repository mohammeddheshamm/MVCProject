using Demo.BLL.Specification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL
{
    public static class SpecificationEvaluator<T> where T : class
    {
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> spec)
        {
            var query = inputQuery;
            //_context.Set<Product>()

            if (spec.Criteria != null)
                query = query.Where(spec.Criteria);
            //_context.Set<Product>().Where(P => P.Id == 10)

            if (spec.OrderBy != null)
                query = query.OrderBy(spec.OrderBy);

            if (spec.OrderByDescending != null)
                query = query.OrderByDescending(spec.OrderByDescending);

            query = spec.Includes.Aggregate(query, (currentQuery, includeExpression) => currentQuery.Include(includeExpression));

            //_context.Set<Product>().Where(P => P.Id == 10).Include(P => P.ProductBrand).Include(P => P.ProductType);

            return query;
        }
    }
}
