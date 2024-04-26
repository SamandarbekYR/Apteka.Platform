using DataAccesLayer.Data;
using DataAccesLayer.Interfaces;
using Domian.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DataAccesLayer.Repositories;

public class Repository<TEntity> : IRepository<TEntity> 
            where TEntity : BaseEntity
{
    private DbSet<TEntity> _dbSet;
    private AppDbContext _appDb;

    public Repository(AppDbContext appDb)
    {
        _dbSet = appDb.Set<TEntity>();
        _appDb = appDb;
    }
    public bool Add(TEntity entity)
    {
        _dbSet.Add(entity);
        _appDb.SaveChanges();

        return true;
    }
  

    public bool Remove(TEntity entity)
    {
        _dbSet.Remove(entity);
        _appDb.SaveChanges();
        
        return true;
    }

    public  IQueryable<TEntity> GetAll()
    {
        return _dbSet;
    }

    public TEntity? GetById(Guid id)
    {
        TEntity? entity = _dbSet.FirstOrDefault(x => x.Id == id);
        if (entity == null)
        {
          return null;
        }

        return entity;
    }

    public bool Update(TEntity entity)
    {
        _dbSet.Update(entity);
        _appDb.SaveChanges();

        return true;
    }
}
