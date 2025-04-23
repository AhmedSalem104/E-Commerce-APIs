using Domain.Contracts;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    static class SpecificationEvaluator
    {
        public static IQueryable<TEntity> GetQuery<TEntity, TKey>(IQueryable<TEntity> inputQuery ,ISpecifications<TEntity, TKey> spec)
            where TEntity : BaseEntity<TKey>
        {
            IQueryable<TEntity>? query = inputQuery;
            //  _context.Set<TEntity>()

            if (spec.Creteria is not null)
               query =  query.Where(spec.Creteria);
            //  _context.Set<TEntity>().Where(P => P.Id == 12)

            if(spec.OrderBy is not null)
                query = query.OrderBy(spec.OrderBy);
            else if(spec.OrderByDescending is not null)
                query = query.OrderByDescending(spec.OrderByDescending);

            if (spec.IsPagination)
                query = query.Skip(spec.Skip).Take(spec.Take);

            query = spec.IncludeExpressions.Aggregate(query, (currentQuery, includeExpression) => currentQuery.Include(includeExpression));
            //  _context.Set<TEntity>().Where(P => P.Id == 12).Include(P => P.Brand).Incldue(P => P.Type)
            return query;
            //  _context.Set<TEntity>().Where(P => P.Id == 12).Include(P => P.Brand).Incldue(P => P.Type)

        }
    }
}


//  _context.Set<TEntity>()