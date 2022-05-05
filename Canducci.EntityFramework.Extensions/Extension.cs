using System;
using System.Linq;
using System.Linq.Expressions;

namespace Canducci.EntityFramework.Extensions
{
    public static class Extension
    {
        public static IQueryable<TSource> When<TSource, T>(this IQueryable<TSource> query, T value, Expression<Func<TSource, bool>> where)
        {
            if (value == null)
            {
                return query;
            }
            return query.Where(where);
        }
    }
}
