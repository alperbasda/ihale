using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Ihale.Core.Entity;

namespace Ihale.Core.DataAccess
{
    public interface IEntityRepositoryBase<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        List<T> GetList(int skip, int take, Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}