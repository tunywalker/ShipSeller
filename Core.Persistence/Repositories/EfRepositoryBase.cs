using Core.Persistence.EntityBaseModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories;

public class EfRepositoryBase<TContext, TEntity, TId> : IEntityRepository<TEntity, TId>, IQuery<TEntity>
    where TEntity : Entity<TId>
    where TContext : DbContext
{

    protected TContext Context { get; set; }
    public EfRepositoryBase(TContext context)
    {
        Context = context;
    }


    void IEntityRepository<TEntity, TId>.Add(TEntity entity)
    {
        Context.Set<TEntity>().Add(entity);
        Context.SaveChanges();

    }

    void IEntityRepository<TEntity, TId>.Delete(TEntity entity)
    {
        Context.Set<TEntity>().Remove(entity);
        Context.SaveChanges();

    }

    List<TEntity> IEntityRepository<TEntity, TId>.GetAll(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include)
    {
        IQueryable<TEntity> queryable = Query();
        if (predicate is not null)
            queryable = queryable.Where(predicate);
        if (include is not null)
            queryable = include(queryable);
        return queryable.ToList();

    }

    TEntity? IEntityRepository<TEntity, TId>.GetByFilter(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include)
    {
        IQueryable<TEntity> queryable = Query();
        queryable = queryable.Where(predicate);
        if (include is not null)
            queryable = include(queryable);
        return queryable.FirstOrDefault();
    }

    TEntity? IEntityRepository<TEntity, TId>.GetById(TId id, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include)
    {
        IQueryable<TEntity> queryable = Query();
        if (include is not null)
            queryable = include(queryable);
        return queryable.SingleOrDefault(x => x.Id.Equals(id));
    }

    void IEntityRepository<TEntity, TId>.Update(TEntity entity)
    {
       Context.Set<TEntity>().Update(entity);
       Context.SaveChanges();
    }
    public IQueryable<TEntity> Query()
    {
        throw new NotImplementedException();
    }
}
